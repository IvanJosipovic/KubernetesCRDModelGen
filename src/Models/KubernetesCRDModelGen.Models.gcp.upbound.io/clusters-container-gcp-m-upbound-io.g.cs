using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.container.gcp.m.upbound.io;
#nullable enable
/// <summary>Cluster is the Schema for the Clusters API. Creates a Google Kubernetes Engine (GKE) cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ClusterList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Cluster>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ClusterList";
    public const string KubeGroup = "container.gcp.m.upbound.io";
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
/// <summary>. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderAddonsConfigCloudrunConfig
{
    /// <summary>The status of the Istio addon, which makes it easy to set up Istio for services in a cluster. It is disabled by default. Set disabled = false to enable.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>The load balancer type of CloudRun ingress service. It is external load balancer by default. Set load_balancer_type=LOAD_BALANCER_TYPE_INTERNAL to configure it as internal load balancer.</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>. The status of the ConfigConnector addon. It is disabled by default; Set enabled = true to enable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderAddonsConfigConfigConnectorConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>. The status of the NodeLocal DNSCache addon. It is disabled by default. Set enabled = true to enable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderAddonsConfigDnsCacheConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>. Whether this cluster should enable the Google Compute Engine Persistent Disk Container Storage Interface (CSI) Driver. Set enabled = true to enable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderAddonsConfigGcePersistentDiskCsiDriverConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The status of the Filestore CSI driver addon, which allows the usage of filestore instance as volumes. It is disabled by default; set enabled = true to enable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderAddonsConfigGcpFilestoreCsiDriverConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The status of the GCSFuse CSI driver addon, which allows the usage of a gcs bucket as volumes. It is disabled by default for Standard clusters; set enabled = true to enable. It is enabled by default for Autopilot clusters with version 1.24 or later; set enabled = true to enable it explicitly. See Enable the Cloud Storage FUSE CSI driver for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderAddonsConfigGcsFuseCsiDriverConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>. The status of the Backup for GKE agent addon. It is disabled by default; Set enabled = true to enable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderAddonsConfigGkeBackupAgentConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The status of the Horizontal Pod Autoscaling addon, which increases or decreases the number of replica pods a replication controller has based on the resource usage of the existing pods. It is enabled by default; set disabled = true to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderAddonsConfigHorizontalPodAutoscaling
{
    /// <summary>The status of the Istio addon, which makes it easy to set up Istio for services in a cluster. It is disabled by default. Set disabled = false to enable.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The status of the HTTP (L7) load balancing controller addon, which makes it easy to set up HTTP load balancers for services in a cluster. It is enabled by default; set disabled = true to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderAddonsConfigHttpLoadBalancing
{
    /// <summary>The status of the Istio addon, which makes it easy to set up Istio for services in a cluster. It is disabled by default. Set disabled = false to enable.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Whether we should enable the network policy addon for the master.  This must be enabled in order to enable network policy for the nodes. To enable this, you must also define a network_policy block, otherwise nothing will happen. It can only be disabled if the nodes already do not have network policies enabled. Defaults to disabled; set disabled = false to enable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderAddonsConfigNetworkPolicyConfig
{
    /// <summary>The status of the Istio addon, which makes it easy to set up Istio for services in a cluster. It is disabled by default. Set disabled = false to enable.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The status of the Parallelstore CSI driver addon, which allows the usage of a Parallelstore instances as volumes. It is disabled by default for Standard clusters; set enabled = true to enable. It is enabled by default for Autopilot clusters with version 1.29 or later; set enabled = true to enable it explicitly. See Enable the Parallelstore CSI driver for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderAddonsConfigParallelstoreCsiDriverConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Logging configuration for the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderAddonsConfigRayOperatorConfigRayClusterLoggingConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Monitoring configuration for the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderAddonsConfigRayOperatorConfigRayClusterMonitoringConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderAddonsConfigRayOperatorConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Logging configuration for the cluster. Structure is documented below.</summary>
    [JsonPropertyName("rayClusterLoggingConfig")]
    public V1beta1ClusterSpecForProviderAddonsConfigRayOperatorConfigRayClusterLoggingConfig? RayClusterLoggingConfig { get; set; }

    /// <summary>Monitoring configuration for the cluster. Structure is documented below.</summary>
    [JsonPropertyName("rayClusterMonitoringConfig")]
    public V1beta1ClusterSpecForProviderAddonsConfigRayOperatorConfigRayClusterMonitoringConfig? RayClusterMonitoringConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>. The status of the Stateful HA addon, which provides automatic configurable failover for stateful applications. It is disabled by default for Standard clusters. Set enabled = true to enable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderAddonsConfigStatefulHaConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The configuration for addons supported by GKE. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderAddonsConfig
{
    /// <summary>. Structure is documented below.</summary>
    [JsonPropertyName("cloudrunConfig")]
    public V1beta1ClusterSpecForProviderAddonsConfigCloudrunConfig? CloudrunConfig { get; set; }

    /// <summary>. The status of the ConfigConnector addon. It is disabled by default; Set enabled = true to enable.</summary>
    [JsonPropertyName("configConnectorConfig")]
    public V1beta1ClusterSpecForProviderAddonsConfigConfigConnectorConfig? ConfigConnectorConfig { get; set; }

    /// <summary>. The status of the NodeLocal DNSCache addon. It is disabled by default. Set enabled = true to enable.</summary>
    [JsonPropertyName("dnsCacheConfig")]
    public V1beta1ClusterSpecForProviderAddonsConfigDnsCacheConfig? DnsCacheConfig { get; set; }

    /// <summary>. Whether this cluster should enable the Google Compute Engine Persistent Disk Container Storage Interface (CSI) Driver. Set enabled = true to enable.</summary>
    [JsonPropertyName("gcePersistentDiskCsiDriverConfig")]
    public V1beta1ClusterSpecForProviderAddonsConfigGcePersistentDiskCsiDriverConfig? GcePersistentDiskCsiDriverConfig { get; set; }

    /// <summary>The status of the Filestore CSI driver addon, which allows the usage of filestore instance as volumes. It is disabled by default; set enabled = true to enable.</summary>
    [JsonPropertyName("gcpFilestoreCsiDriverConfig")]
    public V1beta1ClusterSpecForProviderAddonsConfigGcpFilestoreCsiDriverConfig? GcpFilestoreCsiDriverConfig { get; set; }

    /// <summary>The status of the GCSFuse CSI driver addon, which allows the usage of a gcs bucket as volumes. It is disabled by default for Standard clusters; set enabled = true to enable. It is enabled by default for Autopilot clusters with version 1.24 or later; set enabled = true to enable it explicitly. See Enable the Cloud Storage FUSE CSI driver for more information.</summary>
    [JsonPropertyName("gcsFuseCsiDriverConfig")]
    public V1beta1ClusterSpecForProviderAddonsConfigGcsFuseCsiDriverConfig? GcsFuseCsiDriverConfig { get; set; }

    /// <summary>. The status of the Backup for GKE agent addon. It is disabled by default; Set enabled = true to enable.</summary>
    [JsonPropertyName("gkeBackupAgentConfig")]
    public V1beta1ClusterSpecForProviderAddonsConfigGkeBackupAgentConfig? GkeBackupAgentConfig { get; set; }

    /// <summary>The status of the Horizontal Pod Autoscaling addon, which increases or decreases the number of replica pods a replication controller has based on the resource usage of the existing pods. It is enabled by default; set disabled = true to disable.</summary>
    [JsonPropertyName("horizontalPodAutoscaling")]
    public V1beta1ClusterSpecForProviderAddonsConfigHorizontalPodAutoscaling? HorizontalPodAutoscaling { get; set; }

    /// <summary>The status of the HTTP (L7) load balancing controller addon, which makes it easy to set up HTTP load balancers for services in a cluster. It is enabled by default; set disabled = true to disable.</summary>
    [JsonPropertyName("httpLoadBalancing")]
    public V1beta1ClusterSpecForProviderAddonsConfigHttpLoadBalancing? HttpLoadBalancing { get; set; }

    /// <summary>Whether we should enable the network policy addon for the master.  This must be enabled in order to enable network policy for the nodes. To enable this, you must also define a network_policy block, otherwise nothing will happen. It can only be disabled if the nodes already do not have network policies enabled. Defaults to disabled; set disabled = false to enable.</summary>
    [JsonPropertyName("networkPolicyConfig")]
    public V1beta1ClusterSpecForProviderAddonsConfigNetworkPolicyConfig? NetworkPolicyConfig { get; set; }

    /// <summary>The status of the Parallelstore CSI driver addon, which allows the usage of a Parallelstore instances as volumes. It is disabled by default for Standard clusters; set enabled = true to enable. It is enabled by default for Autopilot clusters with version 1.29 or later; set enabled = true to enable it explicitly. See Enable the Parallelstore CSI driver for more information.</summary>
    [JsonPropertyName("parallelstoreCsiDriverConfig")]
    public V1beta1ClusterSpecForProviderAddonsConfigParallelstoreCsiDriverConfig? ParallelstoreCsiDriverConfig { get; set; }

    /// <summary>. The status of the Ray Operator addon. It is disabled by default. Set enabled = true to enable. The minimum cluster version to enable Ray is 1.30.0-gke.1747000.</summary>
    [JsonPropertyName("rayOperatorConfig")]
    public IList<V1beta1ClusterSpecForProviderAddonsConfigRayOperatorConfig>? RayOperatorConfig { get; set; }

    /// <summary>. The status of the Stateful HA addon, which provides automatic configurable failover for stateful applications. It is disabled by default for Standard clusters. Set enabled = true to enable.</summary>
    [JsonPropertyName("statefulHaConfig")]
    public V1beta1ClusterSpecForProviderAddonsConfigStatefulHaConfig? StatefulHaConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for anonymous authentication restrictions. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderAnonymousAuthenticationConfig
{
    /// <summary>Sets or removes authentication restrictions. Available options include LIMITED and ENABLED.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the Google Groups for GKE feature. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderAuthenticatorGroupsConfig
{
    /// <summary>The name of the RBAC security group for use with Google security groups in Kubernetes RBAC. Group name must be in format gke-security-groups@yourdomain.com.</summary>
    [JsonPropertyName("securityGroup")]
    public string? SecurityGroup { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration options for the Binary Authorization feature. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderBinaryAuthorization
{
    /// <summary>(DEPRECATED) Enable Binary Authorization for this cluster. Deprecated in favor of evaluation_mode.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Mode of operation for Binary Authorization policy evaluation. Valid values are DISABLED and PROJECT_SINGLETON_POLICY_ENFORCE.</summary>
    [JsonPropertyName("evaluationMode")]
    public string? EvaluationMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>NodeManagement configuration for this NodePool. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterAutoscalingAutoProvisioningDefaultsManagement
{
    /// <summary>Specifies whether the node auto-repair is enabled for the node pool. If enabled, the nodes in this node pool will be monitored and, if they fail health checks too many times, an automatic repair action will be triggered.</summary>
    [JsonPropertyName("autoRepair")]
    public bool? AutoRepair { get; set; }

    /// <summary>Specifies whether node auto-upgrade is enabled for the node pool. If enabled, node auto-upgrade helps keep the nodes in your node pool up to date with the latest release version of Kubernetes.</summary>
    [JsonPropertyName("autoUpgrade")]
    public bool? AutoUpgrade { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Shielded Instance options. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterAutoscalingAutoProvisioningDefaultsShieldedInstanceConfig
{
    /// <summary>Defines if the instance has integrity monitoring enabled.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>Defines if the instance has Secure Boot enabled.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }
}
#nullable disable

#nullable enable
/// <summary>green upgrade. To be specified when strategy is set to BLUE_GREEN. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterAutoscalingAutoProvisioningDefaultsUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy
{
    /// <summary>Number of blue nodes to drain in a batch. Only one of the batch_percentage or batch_node_count can be specified.</summary>
    [JsonPropertyName("batchNodeCount")]
    public double? BatchNodeCount { get; set; }

    /// <summary>:  Percentage of the bool pool nodes to drain in a batch. The range of this field should be (0.0, 1.0). Only one of the batch_percentage or batch_node_count can be specified.</summary>
    [JsonPropertyName("batchPercentage")]
    public double? BatchPercentage { get; set; }

    /// <summary>Soak time after each batch gets drained. A duration in seconds with up to nine fractional digits, ending with 's'. Example: "3.5s".`.</summary>
    [JsonPropertyName("batchSoakDuration")]
    public string? BatchSoakDuration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Settings for blue-green upgrade strategy. To be specified when strategy is set to BLUE_GREEN. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterAutoscalingAutoProvisioningDefaultsUpgradeSettingsBlueGreenSettings
{
    /// <summary>Time needed after draining entire blue pool. After this period, blue pool will be cleaned up. A duration in seconds with up to nine fractional digits, ending with 's'. Example: "3.5s".</summary>
    [JsonPropertyName("nodePoolSoakDuration")]
    public string? NodePoolSoakDuration { get; set; }

    /// <summary>green upgrade. To be specified when strategy is set to BLUE_GREEN. Structure is documented below.</summary>
    [JsonPropertyName("standardRolloutPolicy")]
    public V1beta1ClusterSpecForProviderClusterAutoscalingAutoProvisioningDefaultsUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy? StandardRolloutPolicy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies the upgrade settings for NAP created node pools. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterAutoscalingAutoProvisioningDefaultsUpgradeSettings
{
    /// <summary>Settings for blue-green upgrade strategy. To be specified when strategy is set to BLUE_GREEN. Structure is documented below.</summary>
    [JsonPropertyName("blueGreenSettings")]
    public V1beta1ClusterSpecForProviderClusterAutoscalingAutoProvisioningDefaultsUpgradeSettingsBlueGreenSettings? BlueGreenSettings { get; set; }

    /// <summary>The maximum number of nodes that can be created beyond the current size of the node pool during the upgrade process. To be used when strategy is set to SURGE. Default is 0.</summary>
    [JsonPropertyName("maxSurge")]
    public double? MaxSurge { get; set; }

    /// <summary>The maximum number of nodes that can be simultaneously unavailable during the upgrade process. To be used when strategy is set to SURGE. Default is 0.</summary>
    [JsonPropertyName("maxUnavailable")]
    public double? MaxUnavailable { get; set; }

    /// <summary>Strategy used for node pool update. Strategy can only be one of BLUE_GREEN or SURGE. The default is value is SURGE.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Contains defaults for a node pool created by NAP. A subset of fields also apply to GKE Autopilot clusters. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterAutoscalingAutoProvisioningDefaults
{
    /// <summary>The Customer Managed Encryption Key used to encrypt the boot disk attached to each node in the node pool. This should be of the form projects/[KEY_PROJECT_ID]/locations/[LOCATION]/keyRings/[RING_NAME]/cryptoKeys/[KEY_NAME]. For more information about protecting resources with Cloud KMS Keys please see: https://cloud.google.com/compute/docs/disks/customer-managed-encryption</summary>
    [JsonPropertyName("bootDiskKmsKey")]
    public string? BootDiskKmsKey { get; set; }

    /// <summary>Size of the disk attached to each node, specified in GB. The smallest allowed disk size is 10GB. Defaults to 100</summary>
    [JsonPropertyName("diskSize")]
    public double? DiskSize { get; set; }

    /// <summary>Type of the disk attached to each node (e.g. 'pd-standard', 'pd-balanced' or 'pd-ssd'). If unspecified, the default disk type is 'pd-balanced'</summary>
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    /// <summary>The image type to use for this node. Note that changing the image type will delete and recreate all nodes in the node pool.</summary>
    [JsonPropertyName("imageType")]
    public string? ImageType { get; set; }

    /// <summary>NodeManagement configuration for this NodePool. Structure is documented below.</summary>
    [JsonPropertyName("management")]
    public V1beta1ClusterSpecForProviderClusterAutoscalingAutoProvisioningDefaultsManagement? Management { get; set; }

    /// <summary>Minimum CPU platform to be used by this instance. The instance may be scheduled on the specified or newer CPU platform. Applicable values are the friendly names of CPU platforms, such as Intel Haswell. See the official documentation for more information.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The set of Google API scopes to be made available on all of the node VMs under the "default" service account. Use the "https://www.googleapis.com/auth/cloud-platform" scope to grant access to all APIs. It is recommended that you set service_account to a non-default service account and grant IAM roles to that service account for only the resources that it needs.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }

    /// <summary>The service account to be used by the Node VMs. If not specified, the "default" service account is used.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Shielded Instance options. Structure is documented below.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta1ClusterSpecForProviderClusterAutoscalingAutoProvisioningDefaultsShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    /// <summary>Specifies the upgrade settings for NAP created node pools. Structure is documented below.</summary>
    [JsonPropertyName("upgradeSettings")]
    public V1beta1ClusterSpecForProviderClusterAutoscalingAutoProvisioningDefaultsUpgradeSettings? UpgradeSettings { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterAutoscalingResourceLimits
{
    /// <summary>Maximum amount of the resource in the cluster.</summary>
    [JsonPropertyName("maximum")]
    public double? Maximum { get; set; }

    /// <summary>Minimum amount of the resource in the cluster.</summary>
    [JsonPropertyName("minimum")]
    public double? Minimum { get; set; }

    /// <summary>The type of the resource. For example, cpu and memory.  See the guide to using Node Auto-Provisioning for a list of types.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Per-cluster configuration of Node Auto-Provisioning with Cluster Autoscaler to automatically adjust the size of the cluster and create/delete node pools based on the current needs of the cluster's workload. See the guide to using Node Auto-Provisioning for more details. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderClusterAutoscaling
{
    /// <summary>Contains defaults for a node pool created by NAP. A subset of fields also apply to GKE Autopilot clusters. Structure is documented below.</summary>
    [JsonPropertyName("autoProvisioningDefaults")]
    public V1beta1ClusterSpecForProviderClusterAutoscalingAutoProvisioningDefaults? AutoProvisioningDefaults { get; set; }

    /// <summary>The list of Google Compute Engine zones in which the NodePool's nodes can be created by NAP.</summary>
    [JsonPropertyName("autoProvisioningLocations")]
    public IList<string>? AutoProvisioningLocations { get; set; }

    /// <summary>Configuration options for the Autoscaling profile feature, which lets you choose whether the cluster autoscaler should optimize for resource utilization or resource availability when deciding to remove nodes from a cluster. Can be BALANCED or OPTIMIZE_UTILIZATION. Defaults to BALANCED.</summary>
    [JsonPropertyName("autoscalingProfile")]
    public string? AutoscalingProfile { get; set; }

    /// <summary>Whether node auto-provisioning is enabled. Must be supplied for GKE Standard clusters, true is implied for autopilot clusters. Resource limits for cpu and memory must be defined to enable node auto-provisioning for GKE Standard.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Global constraints for machine resources in the cluster. Configuring the cpu and memory types is required if node auto-provisioning is enabled. These limits will apply to node pool autoscaling in addition to node auto-provisioning. Structure is documented below.</summary>
    [JsonPropertyName("resourceLimits")]
    public IList<V1beta1ClusterSpecForProviderClusterAutoscalingResourceLimits>? ResourceLimits { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for Confidential Nodes feature. Structure is documented below documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderConfidentialNodes
{
    /// <summary>Defines the type of technology used by the confidential node.</summary>
    [JsonPropertyName("confidentialInstanceType")]
    public string? ConfidentialInstanceType { get; set; }

    /// <summary>Enable Confidential GKE Nodes for this node pool, to enforce encryption of data in-use.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DNS endpoint configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderControlPlaneEndpointsConfigDnsEndpointConfig
{
    /// <summary>Controls whether user traffic is allowed over this endpoint. Note that GCP-managed services may still use the endpoint even if this is false.</summary>
    [JsonPropertyName("allowExternalTraffic")]
    public bool? AllowExternalTraffic { get; set; }

    /// <summary>(Output) The cluster's DNS endpoint.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }
}
#nullable disable

#nullable enable
/// <summary>IP endpoint configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderControlPlaneEndpointsConfigIpEndpointsConfig
{
    /// <summary>Controls whether to allow direct IP access. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for all of the cluster's control plane endpoints. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderControlPlaneEndpointsConfig
{
    /// <summary>DNS endpoint configuration.</summary>
    [JsonPropertyName("dnsEndpointConfig")]
    public V1beta1ClusterSpecForProviderControlPlaneEndpointsConfigDnsEndpointConfig? DnsEndpointConfig { get; set; }

    /// <summary>IP endpoint configuration.</summary>
    [JsonPropertyName("ipEndpointsConfig")]
    public V1beta1ClusterSpecForProviderControlPlaneEndpointsConfigIpEndpointsConfig? IpEndpointsConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the Cost Allocation feature. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderCostManagementConfig
{
    /// <summary>Whether to enable the cost allocation feature.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderDatabaseEncryption
{
    /// <summary>the key to use to encrypt/decrypt secrets.  See the DatabaseEncryption definition for more information.</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>ENCRYPTED or DECRYPTED</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}
#nullable disable

#nullable enable
/// <summary>GKE SNAT DefaultSnatStatus contains the desired state of whether default sNAT should be disabled on the cluster, API doc. Structure is documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderDefaultSnatStatus
{
    /// <summary>Whether the cluster disables default in-node sNAT rules. In-node sNAT rules will be disabled when defaultSnatStatus is disabled.When disabled is set to false, default IP masquerade rules will be applied to the nodes to prevent sNAT on cluster internal traffic</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for Using Cloud DNS for GKE. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderDnsConfig
{
    /// <summary>This will enable Cloud DNS additive VPC scope. Must provide a domain name that is unique within the VPC. For this to work cluster_dns = "CLOUD_DNS" and cluster_dns_scope = "CLUSTER_SCOPE" must both be set as well.</summary>
    [JsonPropertyName("additiveVpcScopeDnsDomain")]
    public string? AdditiveVpcScopeDnsDomain { get; set; }

    /// <summary>Which in-cluster DNS provider should be used. PROVIDER_UNSPECIFIED (default) or PLATFORM_DEFAULT or CLOUD_DNS.</summary>
    [JsonPropertyName("clusterDns")]
    public string? ClusterDns { get; set; }

    /// <summary>The suffix used for all cluster service records.</summary>
    [JsonPropertyName("clusterDnsDomain")]
    public string? ClusterDnsDomain { get; set; }

    /// <summary>The scope of access to cluster DNS records. DNS_SCOPE_UNSPECIFIED or CLUSTER_SCOPE or VPC_SCOPE. If the cluster_dns field is set to CLOUD_DNS, DNS_SCOPE_UNSPECIFIED and empty/null behave like CLUSTER_SCOPE.</summary>
    [JsonPropertyName("clusterDnsScope")]
    public string? ClusterDnsScope { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for Kubernetes Beta APIs. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderEnableK8SBetaApis
{
    /// <summary>Enabled Kubernetes Beta APIs. To list a Beta API resource, use the representation {group}/{version}/{resource}. The version must be a Beta version. Note that you cannot disable beta APIs that are already enabled on a cluster without recreating it. See the Configure beta APIs for more information.</summary>
    [JsonPropertyName("enabledApis")]
    public IList<string>? EnabledApis { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for [Enterprise edition].(https://cloud.google.com/kubernetes-engine/enterprise/docs/concepts/gke-editions). Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderEnterpriseConfig
{
    /// <summary>Sets the tier of the cluster. Available options include STANDARD and ENTERPRISE.</summary>
    [JsonPropertyName("desiredTier")]
    public string? DesiredTier { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Fleet configuration for the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderFleet
{
    /// <summary>The name of the Fleet host project where this cluster will be registered.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for GKE Gateway API controller. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderGatewayApiConfig
{
    /// <summary>Which Gateway Api channel should be used. CHANNEL_DISABLED, CHANNEL_EXPERIMENTAL or CHANNEL_STANDARD.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration options for the auto-upgrade patch type feature, which provide more control over the speed of automatic upgrades of your GKE clusters. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderGkeAutoUpgradeConfig
{
    /// <summary>The selected patch mode. Accepted values are:</summary>
    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderIdentityServiceConfig
{
    /// <summary>Whether to enable the Identity Service component. It is disabled by default. Set enabled=true to enable.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The configuration for additional pod secondary ranges at the cluster level. Used for Autopilot clusters and Standard clusters with which control of the secondary Pod IP address assignment to node pools isn't needed. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderIpAllocationPolicyAdditionalPodRangesConfig
{
    /// <summary>The names of the Pod ranges to add to the cluster.</summary>
    [JsonPropertyName("podRangeNames")]
    public IList<string>? PodRangeNames { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderIpAllocationPolicyPodCidrOverprovisionConfig
{
    /// <summary>The status of the Istio addon, which makes it easy to set up Istio for services in a cluster. It is disabled by default. Set disabled = false to enable.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration of cluster IP allocation for VPC-native clusters. If this block is unset during creation, it will be set by the GKE backend. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderIpAllocationPolicy
{
    /// <summary>The configuration for additional pod secondary ranges at the cluster level. Used for Autopilot clusters and Standard clusters with which control of the secondary Pod IP address assignment to node pools isn't needed. Structure is documented below.</summary>
    [JsonPropertyName("additionalPodRangesConfig")]
    public V1beta1ClusterSpecForProviderIpAllocationPolicyAdditionalPodRangesConfig? AdditionalPodRangesConfig { get; set; }

    /// <summary>The IP address range for the cluster pod IPs. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use.</summary>
    [JsonPropertyName("clusterIpv4CidrBlock")]
    public string? ClusterIpv4CidrBlock { get; set; }

    /// <summary>The name of the existing secondary range in the cluster's subnetwork to use for pod IP addresses. Alternatively, cluster_ipv4_cidr_block can be used to automatically create a GKE-managed one.</summary>
    [JsonPropertyName("clusterSecondaryRangeName")]
    public string? ClusterSecondaryRangeName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podCidrOverprovisionConfig")]
    public V1beta1ClusterSpecForProviderIpAllocationPolicyPodCidrOverprovisionConfig? PodCidrOverprovisionConfig { get; set; }

    /// <summary>The IP address range of the services IPs in this cluster. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use.</summary>
    [JsonPropertyName("servicesIpv4CidrBlock")]
    public string? ServicesIpv4CidrBlock { get; set; }

    /// <summary>The name of the existing secondary range in the cluster's subnetwork to use for service ClusterIPs. Alternatively, services_ipv4_cidr_block can be used to automatically create a GKE-managed one.</summary>
    [JsonPropertyName("servicesSecondaryRangeName")]
    public string? ServicesSecondaryRangeName { get; set; }

    /// <summary>The IP Stack Type of the cluster. Default value is IPV4. Possible values are IPV4 and IPV4_IPV6.</summary>
    [JsonPropertyName("stackType")]
    public string? StackType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Logging configuration for the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderLoggingConfig
{
    /// <summary>The GKE components exposing logs. Supported values include: SYSTEM_COMPONENTS, APISERVER, CONTROLLER_MANAGER, SCHEDULER, and WORKLOADS.</summary>
    [JsonPropertyName("enableComponents")]
    public IList<string>? EnableComponents { get; set; }
}
#nullable disable

#nullable enable
/// <summary>structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderMaintenancePolicyDailyMaintenanceWindow
{
    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>MaintenanceExclusionOptions provides maintenance exclusion related options.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderMaintenancePolicyMaintenanceExclusionExclusionOptions
{
    /// <summary>Whether or not to enable GKE Auto-Monitoring. Supported values include: ALL, NONE.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderMaintenancePolicyMaintenanceExclusion
{
    /// <summary></summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>The name of the cluster, unique within the project and location.</summary>
    [JsonPropertyName("exclusionName")]
    public string? ExclusionName { get; set; }

    /// <summary>MaintenanceExclusionOptions provides maintenance exclusion related options.</summary>
    [JsonPropertyName("exclusionOptions")]
    public V1beta1ClusterSpecForProviderMaintenancePolicyMaintenanceExclusionExclusionOptions? ExclusionOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>structure documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderMaintenancePolicyRecurringWindow
{
    /// <summary></summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurrence")]
    public string? Recurrence { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The maintenance policy to use for the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderMaintenancePolicy
{
    /// <summary>structure documented below.</summary>
    [JsonPropertyName("dailyMaintenanceWindow")]
    public V1beta1ClusterSpecForProviderMaintenancePolicyDailyMaintenanceWindow? DailyMaintenanceWindow { get; set; }

    /// <summary>structure documented below</summary>
    [JsonPropertyName("maintenanceExclusion")]
    public IList<V1beta1ClusterSpecForProviderMaintenancePolicyMaintenanceExclusion>? MaintenanceExclusion { get; set; }

    /// <summary>structure documented below</summary>
    [JsonPropertyName("recurringWindow")]
    public V1beta1ClusterSpecForProviderMaintenancePolicyRecurringWindow? RecurringWindow { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Whether client certificate authorization is enabled for this cluster.  For example:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderMasterAuthClientCertificateConfig
{
    /// <summary></summary>
    [JsonPropertyName("issueClientCertificate")]
    public bool? IssueClientCertificate { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The authentication information for accessing the Kubernetes master. Some values in this block are only returned by the API if your service account has permission to get credentials for your GKE cluster. If you see an unexpected diff unsetting your client cert, ensure you have the container.clusters.getCredentials permission. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderMasterAuth
{
    /// <summary>Whether client certificate authorization is enabled for this cluster.  For example:</summary>
    [JsonPropertyName("clientCertificateConfig")]
    public V1beta1ClusterSpecForProviderMasterAuthClientCertificateConfig? ClientCertificateConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderMasterAuthorizedNetworksConfigCidrBlocks
{
    /// <summary>External network that can access Kubernetes master through HTTPS. Must be specified in CIDR notation.</summary>
    [JsonPropertyName("cidrBlock")]
    public string? CidrBlock { get; set; }

    /// <summary>Field for users to identify CIDR blocks.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The desired configuration options for master authorized networks. Omit the nested cidr_blocks attribute to disallow external access (except the cluster node IPs, which GKE automatically whitelists). Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderMasterAuthorizedNetworksConfig
{
    /// <summary>External networks that can access the Kubernetes cluster master through HTTPS.</summary>
    [JsonPropertyName("cidrBlocks")]
    public IList<V1beta1ClusterSpecForProviderMasterAuthorizedNetworksConfigCidrBlocks>? CidrBlocks { get; set; }

    /// <summary>Whether Kubernetes master is accessible via Google Compute Engine Public IPs.</summary>
    [JsonPropertyName("gcpPublicCidrsAccessEnabled")]
    public bool? GcpPublicCidrsAccessEnabled { get; set; }

    /// <summary>Whether authorized networks is enforced on the private endpoint or not.</summary>
    [JsonPropertyName("privateEndpointEnforcementEnabled")]
    public bool? PrivateEndpointEnforcementEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderMeshCertificates
{
    /// <summary>Controls the issuance of workload mTLS certificates. It is enabled by default. Workload Identity is required, see workload_config.</summary>
    [JsonPropertyName("enableCertificates")]
    public bool? EnableCertificates { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for Advanced Datapath Monitoring. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderMonitoringConfigAdvancedDatapathObservabilityConfig
{
    /// <summary>Whether or not to enable advanced datapath metrics.</summary>
    [JsonPropertyName("enableMetrics")]
    public bool? EnableMetrics { get; set; }

    /// <summary>Whether or not Relay is enabled.</summary>
    [JsonPropertyName("enableRelay")]
    public bool? EnableRelay { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration options for GKE Auto-Monitoring.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderMonitoringConfigManagedPrometheusAutoMonitoringConfig
{
    /// <summary>Whether or not to enable GKE Auto-Monitoring. Supported values include: ALL, NONE.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for Managed Service for Prometheus. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderMonitoringConfigManagedPrometheus
{
    /// <summary>Configuration options for GKE Auto-Monitoring.</summary>
    [JsonPropertyName("autoMonitoringConfig")]
    public V1beta1ClusterSpecForProviderMonitoringConfigManagedPrometheusAutoMonitoringConfig? AutoMonitoringConfig { get; set; }

    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Monitoring configuration for the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderMonitoringConfig
{
    /// <summary>Configuration for Advanced Datapath Monitoring. Structure is documented below.</summary>
    [JsonPropertyName("advancedDatapathObservabilityConfig")]
    public V1beta1ClusterSpecForProviderMonitoringConfigAdvancedDatapathObservabilityConfig? AdvancedDatapathObservabilityConfig { get; set; }

    /// <summary>The GKE components exposing metrics. Supported values include: SYSTEM_COMPONENTS, APISERVER, SCHEDULER, CONTROLLER_MANAGER, STORAGE, HPA, POD, DAEMONSET, DEPLOYMENT, STATEFULSET, KUBELET, CADVISOR, DCGM and JOBSET. In beta provider, WORKLOADS is supported on top of those 12 values. (WORKLOADS is deprecated and removed in GKE 1.24.) KUBELET and CADVISOR are only supported in GKE 1.29.3-gke.1093000 and above. JOBSET is only supported in GKE 1.32.1-gke.1357001 and above.</summary>
    [JsonPropertyName("enableComponents")]
    public IList<string>? EnableComponents { get; set; }

    /// <summary>Configuration for Managed Service for Prometheus. Structure is documented below.</summary>
    [JsonPropertyName("managedPrometheus")]
    public V1beta1ClusterSpecForProviderMonitoringConfigManagedPrometheus? ManagedPrometheus { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Network bandwidth tier configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNetworkPerformanceConfig
{
    /// <summary>Specifies the total network bandwidth tier for NodePools in the cluster.</summary>
    [JsonPropertyName("totalEgressBandwidthTier")]
    public string? TotalEgressBandwidthTier { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration options for the NetworkPolicy feature. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNetworkPolicy
{
    /// <summary>Whether network policy is enabled on the cluster.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The selected network policy provider. Defaults to PROVIDER_UNSPECIFIED.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNetworkRefPolicy
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
public partial class V1beta1ClusterSpecForProviderNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderNetworkRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNetworkSelectorPolicy
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
public partial class V1beta1ClusterSpecForProviderNetworkSelector
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
    public V1beta1ClusterSpecForProviderNetworkSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies options for controlling advanced machine features. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeConfigAdvancedMachineFeatures
{
    /// <summary>Defines whether the instance should have nested virtualization enabled. Defaults to false.</summary>
    [JsonPropertyName("enableNestedVirtualization")]
    public bool? EnableNestedVirtualization { get; set; }

    /// <summary>Defines the performance monitoring unit PMU level. Valid values are ARCHITECTURAL, STANDARD, or ENHANCED. Defaults to off.</summary>
    [JsonPropertyName("performanceMonitoringUnit")]
    public string? PerformanceMonitoringUnit { get; set; }

    /// <summary>The number of threads per physical core. To disable simultaneous multithreading (SMT) set this to 1. If unset, the maximum number of threads supported per core by the underlying processor is assumed.</summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for Confidential Nodes feature. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeConfigConfidentialNodes
{
    /// <summary>Defines the type of technology used by the confidential node.</summary>
    [JsonPropertyName("confidentialInstanceType")]
    public string? ConfidentialInstanceType { get; set; }

    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig
{
    /// <summary></summary>
    [JsonPropertyName("secretUri")]
    public string? SecretUri { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig
{
    /// <summary></summary>
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpSecretManagerCertificateConfig")]
    public V1beta1ClusterSpecForProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig? GcpSecretManagerCertificateConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for private container registries. There are two fields in this config:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeConfigContainerdConfigPrivateRegistryAccessConfig
{
    /// <summary>List of configuration objects for CA and domains. Each object identifies a certificate and its assigned domains. See how to configure for private container registries for more detail. Example:</summary>
    [JsonPropertyName("certificateAuthorityDomainConfig")]
    public IList<V1beta1ClusterSpecForProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig>? CertificateAuthorityDomainConfig { get; set; }

    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters to customize containerd runtime. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeConfigContainerdConfig
{
    /// <summary>Configuration for private container registries. There are two fields in this config:</summary>
    [JsonPropertyName("privateRegistryAccessConfig")]
    public V1beta1ClusterSpecForProviderNodeConfigContainerdConfigPrivateRegistryAccessConfig? PrivateRegistryAccessConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters for the ephemeral storage filesystem. If unspecified, ephemeral storage is backed by the boot disk. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeConfigEphemeralStorageLocalSsdConfig
{
    /// <summary>Number of raw-block local NVMe SSD disks to be attached to the node utilized for GKE Data Cache. If zero, then GKE Data Cache will not be enabled in the nodes.</summary>
    [JsonPropertyName("dataCacheCount")]
    public double? DataCacheCount { get; set; }

    /// <summary>The amount of local SSD disks that will be attached to each cluster node. Defaults to 0.</summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters for the NCCL Fast Socket feature. If unspecified, NCCL Fast Socket will not be enabled on the node pool. Node Pool must enable gvnic. GKE version 1.25.2-gke.1700 or later. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeConfigFastSocket
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters for the Google Container Filesystem (GCFS). If unspecified, GCFS will not be enabled on the node pool. When enabling this feature you must specify image_type = "COS_CONTAINERD" and node_version from GKE versions 1.19 or later to use it. For GKE versions 1.19, 1.20, and 1.21, the recommended minimum node_version would be 1.19.15-gke.1300, 1.20.11-gke.1300, and 1.21.5-gke.1300 respectively. A machine_type that has more than 16 GiB of memory is also recommended. GCFS must be enabled in order to use image streaming. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeConfigGcfsConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for auto installation of GPU driver. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeConfigGuestAcceleratorGpuDriverInstallationConfig
{
    /// <summary>Mode for how the GPU driver is installed. Accepted values are:</summary>
    [JsonPropertyName("gpuDriverVersion")]
    public string? GpuDriverVersion { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for GPU sharing. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeConfigGuestAcceleratorGpuSharingConfig
{
    /// <summary>The type of GPU sharing strategy to enable on the GPU node. Accepted values are:</summary>
    [JsonPropertyName("gpuSharingStrategy")]
    public string? GpuSharingStrategy { get; set; }

    /// <summary>The maximum number of containers that can share a GPU.</summary>
    [JsonPropertyName("maxSharedClientsPerGpu")]
    public double? MaxSharedClientsPerGpu { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeConfigGuestAccelerator
{
    /// <summary>The number of the guest accelerator cards exposed to this instance.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>Configuration for auto installation of GPU driver. Structure is documented below.</summary>
    [JsonPropertyName("gpuDriverInstallationConfig")]
    public V1beta1ClusterSpecForProviderNodeConfigGuestAcceleratorGpuDriverInstallationConfig? GpuDriverInstallationConfig { get; set; }

    /// <summary>Size of partitions to create on the GPU. Valid values are described in the NVIDIA mig user guide.</summary>
    [JsonPropertyName("gpuPartitionSize")]
    public string? GpuPartitionSize { get; set; }

    /// <summary>Configuration for GPU sharing. Structure is documented below.</summary>
    [JsonPropertyName("gpuSharingConfig")]
    public V1beta1ClusterSpecForProviderNodeConfigGuestAcceleratorGpuSharingConfig? GpuSharingConfig { get; set; }

    /// <summary>The accelerator type resource to expose to this instance. E.g. nvidia-tesla-k80.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Google Virtual NIC (gVNIC) is a virtual network interface. Installing the gVNIC driver allows for more efficient traffic transmission across the Google network infrastructure. gVNIC is an alternative to the virtIO-based ethernet driver. GKE nodes must use a Container-Optimized OS node image. GKE node version 1.15.11-gke.15 or later Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeConfigGvnic
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The maintenance policy to use for the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeConfigHostMaintenancePolicy
{
    /// <summary></summary>
    [JsonPropertyName("maintenanceInterval")]
    public string? MaintenanceInterval { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Kubelet configuration, currently supported attributes can be found here. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeConfigKubeletConfig
{
    /// <summary>Defines a comma-separated allowlist of unsafe sysctls or sysctl patterns which can be set on the Pods. The allowed sysctl groups are kernel.shm*, kernel.msg*, kernel.sem, fs.mqueue.*, and net.*.</summary>
    [JsonPropertyName("allowedUnsafeSysctls")]
    public IList<string>? AllowedUnsafeSysctls { get; set; }

    /// <summary>Defines the maximum number of container log files that can be present for a container. The integer must be between 2 and 10, inclusive.</summary>
    [JsonPropertyName("containerLogMaxFiles")]
    public double? ContainerLogMaxFiles { get; set; }

    /// <summary>Defines the maximum size of the container log file before it is rotated. Specified as a positive number and a unit suffix, such as "100Ki", "10Mi". Valid units are "Ki", "Mi", "Gi". The value must be between "10Mi" and "500Mi", inclusive. And the total container log size (container_log_max_size * container_log_max_files) cannot exceed 1% of the total storage of the node.</summary>
    [JsonPropertyName("containerLogMaxSize")]
    public string? ContainerLogMaxSize { get; set; }

    /// <summary>If true, enables CPU CFS quota enforcement for containers that specify CPU limits.</summary>
    [JsonPropertyName("cpuCfsQuota")]
    public bool? CpuCfsQuota { get; set; }

    /// <summary>The CPU CFS quota period value. Specified as a sequence of decimal numbers, each with optional fraction and a unit suffix, such as "300ms". Valid time units are "ns", "us" (or "µs"), "ms", "s", "m", "h". The value must be a positive duration.</summary>
    [JsonPropertyName("cpuCfsQuotaPeriod")]
    public string? CpuCfsQuotaPeriod { get; set; }

    /// <summary>The CPU management policy on the node. See K8S CPU Management Policies. One of "none" or "static". If unset (or set to the empty string ""), the API will treat the field as if set to "none". Prior to the 6.4.0 this field was marked as required. The workaround for the required field is setting the empty string "", which will function identically to not setting this field.</summary>
    [JsonPropertyName("cpuManagerPolicy")]
    public string? CpuManagerPolicy { get; set; }

    /// <summary>Defines the percent of disk usage after which image garbage collection is always run. The integer must be between 10 and 85, inclusive.</summary>
    [JsonPropertyName("imageGcHighThresholdPercent")]
    public double? ImageGcHighThresholdPercent { get; set; }

    /// <summary>Defines the percent of disk usage before which image garbage collection is never run. Lowest disk usage to garbage collect to. The integer must be between 10 and 85, inclusive.</summary>
    [JsonPropertyName("imageGcLowThresholdPercent")]
    public double? ImageGcLowThresholdPercent { get; set; }

    /// <summary>Defines the maximum age an image can be unused before it is garbage collected. Specified as a sequence of decimal numbers, each with optional fraction and a unit suffix, such as "300s", "1.5m", and "2h45m". Valid time units are "ns", "us" (or "µs"), "ms", "s", "m", "h". The value must be a positive duration.</summary>
    [JsonPropertyName("imageMaximumGcAge")]
    public string? ImageMaximumGcAge { get; set; }

    /// <summary>Defines the minimum age for an unused image before it is garbage collected. Specified as a sequence of decimal numbers, each with optional fraction and a unit suffix, such as "300s", "1.5m". The value cannot be greater than "2m".</summary>
    [JsonPropertyName("imageMinimumGcAge")]
    public string? ImageMinimumGcAge { get; set; }

    /// <summary>only port is enabled for newly created node pools in the cluster. It is strongly recommended to set this to FALSE. Possible values: TRUE, FALSE.</summary>
    [JsonPropertyName("insecureKubeletReadonlyPortEnabled")]
    public string? InsecureKubeletReadonlyPortEnabled { get; set; }

    /// <summary>Controls the maximum number of processes allowed to run in a pod. The value must be greater than or equal to 1024 and less than 4194304.</summary>
    [JsonPropertyName("podPidsLimit")]
    public double? PodPidsLimit { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Amounts for 2M and 1G hugepages. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeConfigLinuxNodeConfigHugepagesConfig
{
    /// <summary>Amount of 1G hugepages.</summary>
    [JsonPropertyName("hugepageSize1G")]
    public double? HugepageSize1G { get; set; }

    /// <summary>Amount of 2M hugepages.</summary>
    [JsonPropertyName("hugepageSize2M")]
    public double? HugepageSize2M { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters that can be configured on Linux nodes. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeConfigLinuxNodeConfig
{
    /// <summary>Possible cgroup modes that can be used. Accepted values are:</summary>
    [JsonPropertyName("cgroupMode")]
    public string? CgroupMode { get; set; }

    /// <summary>Amounts for 2M and 1G hugepages. Structure is documented below.</summary>
    [JsonPropertyName("hugepagesConfig")]
    public V1beta1ClusterSpecForProviderNodeConfigLinuxNodeConfigHugepagesConfig? HugepagesConfig { get; set; }

    /// <summary>The Linux kernel parameters to be applied to the nodes and all pods running on the nodes. Specified as a map from the key, such as net.core.wmem_max, to a string value. Currently supported attributes can be found here. Note that validations happen all server side. All attributes are optional.</summary>
    [JsonPropertyName("sysctls")]
    public IDictionary<string, string>? Sysctls { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters for the local NVMe SSDs. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeConfigLocalNvmeSsdBlockConfig
{
    /// <summary>The amount of local SSD disks that will be attached to each cluster node. Defaults to 0.</summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The configuration of the desired reservation which instances could take capacity from. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeConfigReservationAffinity
{
    /// <summary>The type of reservation consumption Accepted values are:</summary>
    [JsonPropertyName("consumeReservationType")]
    public string? ConsumeReservationType { get; set; }

    /// <summary>Key for taint.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>name"</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeConfigSecondaryBootDisks
{
    /// <summary>Path to disk image to create the secondary boot disk from. After using the gke-disk-image-builder, this argument should be global/images/DISK_IMAGE_NAME.</summary>
    [JsonPropertyName("diskImage")]
    public string? DiskImage { get; set; }

    /// <summary>How to expose the node metadata to the workload running on the node. Accepted values are:</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeConfigServiceAccountRefPolicy
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
public partial class V1beta1ClusterSpecForProviderNodeConfigServiceAccountRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderNodeConfigServiceAccountRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeConfigServiceAccountSelectorPolicy
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
public partial class V1beta1ClusterSpecForProviderNodeConfigServiceAccountSelector
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
    public V1beta1ClusterSpecForProviderNodeConfigServiceAccountSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Shielded Instance options. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeConfigShieldedInstanceConfig
{
    /// <summary>Defines if the instance has integrity monitoring enabled.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>Defines if the instance has Secure Boot enabled.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeConfigSoleTenantConfigNodeAffinity
{
    /// <summary>Key for taint.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies affinity or anti-affinity. Accepted values are "IN" or "NOT_IN"</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>name"</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Allows specifying multiple node affinities useful for running workloads on sole tenant nodes. node_affinity structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeConfigSoleTenantConfig
{
    /// <summary></summary>
    [JsonPropertyName("nodeAffinity")]
    public IList<V1beta1ClusterSpecForProviderNodeConfigSoleTenantConfigNodeAffinity>? NodeAffinity { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeConfigTaint
{
    /// <summary>Effect for taint. Accepted values are NO_SCHEDULE, PREFER_NO_SCHEDULE, and NO_EXECUTE.</summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>Key for taint.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value for taint.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Windows node configuration, currently supporting OSVersion attribute. The value must be one of [OS_VERSION_UNSPECIFIED, OS_VERSION_LTSC2019, OS_VERSION_LTSC2022]. For example:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeConfigWindowsNodeConfig
{
    /// <summary></summary>
    [JsonPropertyName("osversion")]
    public string? Osversion { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Metadata configuration to expose to workloads on the node pool. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeConfigWorkloadMetadataConfig
{
    /// <summary>How to expose the node metadata to the workload running on the node. Accepted values are:</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters used in creating the default node pool. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodeConfig
{
    /// <summary>Specifies options for controlling advanced machine features. Structure is documented below.</summary>
    [JsonPropertyName("advancedMachineFeatures")]
    public V1beta1ClusterSpecForProviderNodeConfigAdvancedMachineFeatures? AdvancedMachineFeatures { get; set; }

    /// <summary>The Customer Managed Encryption Key used to encrypt the boot disk attached to each node in the node pool. This should be of the form projects/[KEY_PROJECT_ID]/locations/[LOCATION]/keyRings/[RING_NAME]/cryptoKeys/[KEY_NAME]. For more information about protecting resources with Cloud KMS Keys please see: https://cloud.google.com/compute/docs/disks/customer-managed-encryption</summary>
    [JsonPropertyName("bootDiskKmsKey")]
    public string? BootDiskKmsKey { get; set; }

    /// <summary>Configuration for Confidential Nodes feature. Structure is documented below.</summary>
    [JsonPropertyName("confidentialNodes")]
    public V1beta1ClusterSpecForProviderNodeConfigConfidentialNodes? ConfidentialNodes { get; set; }

    /// <summary>Parameters to customize containerd runtime. Structure is documented below.</summary>
    [JsonPropertyName("containerdConfig")]
    public V1beta1ClusterSpecForProviderNodeConfigContainerdConfig? ContainerdConfig { get; set; }

    /// <summary>Size of the disk attached to each node, specified in GB. The smallest allowed disk size is 10GB. Defaults to 100GB.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>Type of the disk attached to each node (e.g. 'pd-standard', 'pd-balanced' or 'pd-ssd'). If unspecified, the default disk type is 'pd-balanced'</summary>
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    /// <summary>Enabling Confidential Storage will create boot disk with confidential mode. It is disabled by default.</summary>
    [JsonPropertyName("enableConfidentialStorage")]
    public bool? EnableConfidentialStorage { get; set; }

    /// <summary>Parameters for the ephemeral storage filesystem. If unspecified, ephemeral storage is backed by the boot disk. Structure is documented below.</summary>
    [JsonPropertyName("ephemeralStorageLocalSsdConfig")]
    public V1beta1ClusterSpecForProviderNodeConfigEphemeralStorageLocalSsdConfig? EphemeralStorageLocalSsdConfig { get; set; }

    /// <summary>Parameters for the NCCL Fast Socket feature. If unspecified, NCCL Fast Socket will not be enabled on the node pool. Node Pool must enable gvnic. GKE version 1.25.2-gke.1700 or later. Structure is documented below.</summary>
    [JsonPropertyName("fastSocket")]
    public V1beta1ClusterSpecForProviderNodeConfigFastSocket? FastSocket { get; set; }

    /// <summary>Enables Flex Start provisioning model for the node pool.</summary>
    [JsonPropertyName("flexStart")]
    public bool? FlexStart { get; set; }

    /// <summary>Parameters for the Google Container Filesystem (GCFS). If unspecified, GCFS will not be enabled on the node pool. When enabling this feature you must specify image_type = "COS_CONTAINERD" and node_version from GKE versions 1.19 or later to use it. For GKE versions 1.19, 1.20, and 1.21, the recommended minimum node_version would be 1.19.15-gke.1300, 1.20.11-gke.1300, and 1.21.5-gke.1300 respectively. A machine_type that has more than 16 GiB of memory is also recommended. GCFS must be enabled in order to use image streaming. Structure is documented below.</summary>
    [JsonPropertyName("gcfsConfig")]
    public V1beta1ClusterSpecForProviderNodeConfigGcfsConfig? GcfsConfig { get; set; }

    /// <summary>List of the type and count of accelerator cards attached to the instance. Structure documented below. Note: As of 6.0.0, argument syntax is no longer supported for this field in favor of block syntax. To dynamically set a list of guest accelerators, use dynamic blocks. To set an empty list, use a single guest_accelerator block with count = 0.</summary>
    [JsonPropertyName("guestAccelerator")]
    public IList<V1beta1ClusterSpecForProviderNodeConfigGuestAccelerator>? GuestAccelerator { get; set; }

    /// <summary>Google Virtual NIC (gVNIC) is a virtual network interface. Installing the gVNIC driver allows for more efficient traffic transmission across the Google network infrastructure. gVNIC is an alternative to the virtIO-based ethernet driver. GKE nodes must use a Container-Optimized OS node image. GKE node version 1.15.11-gke.15 or later Structure is documented below.</summary>
    [JsonPropertyName("gvnic")]
    public V1beta1ClusterSpecForProviderNodeConfigGvnic? Gvnic { get; set; }

    /// <summary>The maintenance policy to use for the cluster. Structure is documented below.</summary>
    [JsonPropertyName("hostMaintenancePolicy")]
    public V1beta1ClusterSpecForProviderNodeConfigHostMaintenancePolicy? HostMaintenancePolicy { get; set; }

    /// <summary>The image type to use for this node. Note that changing the image type will delete and recreate all nodes in the node pool.</summary>
    [JsonPropertyName("imageType")]
    public string? ImageType { get; set; }

    /// <summary>Kubelet configuration, currently supported attributes can be found here. Structure is documented below.</summary>
    [JsonPropertyName("kubeletConfig")]
    public V1beta1ClusterSpecForProviderNodeConfigKubeletConfig? KubeletConfig { get; set; }

    /// <summary>The Kubernetes labels (key/value pairs) to be applied to each node. The kubernetes.io/ and k8s.io/ prefixes are reserved by Kubernetes Core components and cannot be specified.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Parameters that can be configured on Linux nodes. Structure is documented below.</summary>
    [JsonPropertyName("linuxNodeConfig")]
    public V1beta1ClusterSpecForProviderNodeConfigLinuxNodeConfig? LinuxNodeConfig { get; set; }

    /// <summary>Parameters for the local NVMe SSDs. Structure is documented below.</summary>
    [JsonPropertyName("localNvmeSsdBlockConfig")]
    public V1beta1ClusterSpecForProviderNodeConfigLocalNvmeSsdBlockConfig? LocalNvmeSsdBlockConfig { get; set; }

    /// <summary>The amount of local SSD disks that will be attached to each cluster node. Defaults to 0.</summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary>Possible Local SSD encryption modes: Accepted values are:</summary>
    [JsonPropertyName("localSsdEncryptionMode")]
    public string? LocalSsdEncryptionMode { get; set; }

    /// <summary>wide default value. Valid values include DEFAULT and MAX_THROUGHPUT. See Increasing logging agent throughput for more information.</summary>
    [JsonPropertyName("loggingVariant")]
    public string? LoggingVariant { get; set; }

    /// <summary>The name of a Google Compute Engine machine type. Defaults to e2-medium. To create a custom machine type, value should be set as specified here.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>The runtime of each node in the node pool in seconds, terminated by 's'. Example: "3600s".</summary>
    [JsonPropertyName("maxRunDuration")]
    public string? MaxRunDuration { get; set; }

    /// <summary>The metadata key/value pairs assigned to instances in the cluster. From GKE 1. To avoid this, set the value in your config.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Minimum CPU platform to be used by this instance. The instance may be scheduled on the specified or newer CPU platform. Applicable values are the friendly names of CPU platforms, such as Intel Haswell. See the official documentation for more information.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>Setting this field will assign instances of this pool to run on the specified node group. This is useful for running workloads on sole tenant nodes.</summary>
    [JsonPropertyName("nodeGroup")]
    public string? NodeGroup { get; set; }

    /// <summary>The set of Google API scopes to be made available on all of the node VMs under the "default" service account. Use the "https://www.googleapis.com/auth/cloud-platform" scope to grant access to all APIs. It is recommended that you set service_account to a non-default service account and grant IAM roles to that service account for only the resources that it needs.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }

    /// <summary>A boolean that represents whether or not the underlying node VMs are preemptible. See the official documentation for more information. Defaults to false.</summary>
    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    /// <summary>The configuration of the desired reservation which instances could take capacity from. Structure is documented below.</summary>
    [JsonPropertyName("reservationAffinity")]
    public V1beta1ClusterSpecForProviderNodeConfigReservationAffinity? ReservationAffinity { get; set; }

    /// <summary>The GCP labels (key/value pairs) to be applied to each node. Refer here for how these labels are applied to clusters, node pools and nodes.</summary>
    [JsonPropertyName("resourceLabels")]
    public IDictionary<string, string>? ResourceLabels { get; set; }

    /// <summary>A map of resource manager tag keys and values to be attached to the nodes for managing Compute Engine firewalls using Network Firewall Policies. Tags must be according to specifications found here. A maximum of 5 tag key-value pairs can be specified. Existing tags will be replaced with new values. Tags must be in one of the following formats ([KEY]=[VALUE]) 1. tagKeys/{tag_key_id}=tagValues/{tag_value_id} 2. {org_id}/{tag_key_name}={tag_value_name} 3. {project_id}/{tag_key_name}={tag_value_name}.</summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }

    /// <summary>Parameters for secondary boot disks to preload container images and data on new nodes. Structure is documented below. gcfs_config must be enabled=true for this feature to work. min_master_version must also be set to use GKE 1.28.3-gke.106700 or later versions.</summary>
    [JsonPropertyName("secondaryBootDisks")]
    public IList<V1beta1ClusterSpecForProviderNodeConfigSecondaryBootDisks>? SecondaryBootDisks { get; set; }

    /// <summary>The service account to be used by the Node VMs. If not specified, the "default" service account is used.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1ClusterSpecForProviderNodeConfigServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountSelector")]
    public V1beta1ClusterSpecForProviderNodeConfigServiceAccountSelector? ServiceAccountSelector { get; set; }

    /// <summary>Shielded Instance options. Structure is documented below.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta1ClusterSpecForProviderNodeConfigShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    /// <summary>Allows specifying multiple node affinities useful for running workloads on sole tenant nodes. node_affinity structure is documented below.</summary>
    [JsonPropertyName("soleTenantConfig")]
    public V1beta1ClusterSpecForProviderNodeConfigSoleTenantConfig? SoleTenantConfig { get; set; }

    /// <summary>A boolean that represents whether the underlying node VMs are spot. See the official documentation for more information. Defaults to false.</summary>
    [JsonPropertyName("spot")]
    public bool? Spot { get; set; }

    /// <summary>The list of Storage Pools where boot disks are provisioned.</summary>
    [JsonPropertyName("storagePools")]
    public IList<string>? StoragePools { get; set; }

    /// <summary>The list of instance tags applied to all nodes. Tags are used to identify valid sources or targets for network firewalls.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>A list of Kubernetes taints to apply to nodes. Structure is documented below.</summary>
    [JsonPropertyName("taint")]
    public IList<V1beta1ClusterSpecForProviderNodeConfigTaint>? Taint { get; set; }

    /// <summary>Windows node configuration, currently supporting OSVersion attribute. The value must be one of [OS_VERSION_UNSPECIFIED, OS_VERSION_LTSC2019, OS_VERSION_LTSC2022]. For example:</summary>
    [JsonPropertyName("windowsNodeConfig")]
    public V1beta1ClusterSpecForProviderNodeConfigWindowsNodeConfig? WindowsNodeConfig { get; set; }

    /// <summary>Metadata configuration to expose to workloads on the node pool. Structure is documented below.</summary>
    [JsonPropertyName("workloadMetadataConfig")]
    public V1beta1ClusterSpecForProviderNodeConfigWorkloadMetadataConfig? WorkloadMetadataConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Linux system configuration for the cluster's automatically provisioned node pools. Only cgroup_mode field is supported in node_pool_auto_config. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodePoolAutoConfigLinuxNodeConfig
{
    /// <summary>Possible cgroup modes that can be used. Accepted values are:</summary>
    [JsonPropertyName("cgroupMode")]
    public string? CgroupMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The network tag config for the cluster's automatically provisioned node pools. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodePoolAutoConfigNetworkTags
{
    /// <summary>The list of instance tags applied to all nodes. Tags are used to identify valid sources or targets for network firewalls.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Kubelet configuration for Autopilot clusters. Currently, only insecure_kubelet_readonly_port_enabled is supported here. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodePoolAutoConfigNodeKubeletConfig
{
    /// <summary>only port is enabled for newly created node pools in the cluster. It is strongly recommended to set this to FALSE. Possible values: TRUE, FALSE.</summary>
    [JsonPropertyName("insecureKubeletReadonlyPortEnabled")]
    public string? InsecureKubeletReadonlyPortEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Node pool configs that apply to auto-provisioned node pools in autopilot clusters and node auto-provisioning-enabled clusters. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodePoolAutoConfig
{
    /// <summary>Linux system configuration for the cluster's automatically provisioned node pools. Only cgroup_mode field is supported in node_pool_auto_config. Structure is documented below.</summary>
    [JsonPropertyName("linuxNodeConfig")]
    public V1beta1ClusterSpecForProviderNodePoolAutoConfigLinuxNodeConfig? LinuxNodeConfig { get; set; }

    /// <summary>The network tag config for the cluster's automatically provisioned node pools. Structure is documented below.</summary>
    [JsonPropertyName("networkTags")]
    public V1beta1ClusterSpecForProviderNodePoolAutoConfigNetworkTags? NetworkTags { get; set; }

    /// <summary>Kubelet configuration for Autopilot clusters. Currently, only insecure_kubelet_readonly_port_enabled is supported here. Structure is documented below.</summary>
    [JsonPropertyName("nodeKubeletConfig")]
    public V1beta1ClusterSpecForProviderNodePoolAutoConfigNodeKubeletConfig? NodeKubeletConfig { get; set; }

    /// <summary>A map of resource manager tag keys and values to be attached to the nodes for managing Compute Engine firewalls using Network Firewall Policies. Tags must be according to specifications found here. A maximum of 5 tag key-value pairs can be specified. Existing tags will be replaced with new values. Tags must be in one of the following formats ([KEY]=[VALUE]) 1. tagKeys/{tag_key_id}=tagValues/{tag_value_id} 2. {org_id}/{tag_key_name}={tag_value_name} 3. {project_id}/{tag_key_name}={tag_value_name}.</summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodePoolDefaultsNodeConfigDefaultsContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig
{
    /// <summary></summary>
    [JsonPropertyName("secretUri")]
    public string? SecretUri { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodePoolDefaultsNodeConfigDefaultsContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig
{
    /// <summary></summary>
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpSecretManagerCertificateConfig")]
    public V1beta1ClusterSpecForProviderNodePoolDefaultsNodeConfigDefaultsContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig? GcpSecretManagerCertificateConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for private container registries. There are two fields in this config:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodePoolDefaultsNodeConfigDefaultsContainerdConfigPrivateRegistryAccessConfig
{
    /// <summary>List of configuration objects for CA and domains. Each object identifies a certificate and its assigned domains. See how to configure for private container registries for more detail. Example:</summary>
    [JsonPropertyName("certificateAuthorityDomainConfig")]
    public IList<V1beta1ClusterSpecForProviderNodePoolDefaultsNodeConfigDefaultsContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig>? CertificateAuthorityDomainConfig { get; set; }

    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters to customize containerd runtime. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodePoolDefaultsNodeConfigDefaultsContainerdConfig
{
    /// <summary>Configuration for private container registries. There are two fields in this config:</summary>
    [JsonPropertyName("privateRegistryAccessConfig")]
    public V1beta1ClusterSpecForProviderNodePoolDefaultsNodeConfigDefaultsContainerdConfigPrivateRegistryAccessConfig? PrivateRegistryAccessConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The default Google Container Filesystem (GCFS) configuration at the cluster level. e.g. enable image streaming across all the node pools within the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodePoolDefaultsNodeConfigDefaultsGcfsConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Subset of NodeConfig message that has defaults.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodePoolDefaultsNodeConfigDefaults
{
    /// <summary>Parameters to customize containerd runtime. Structure is documented below.</summary>
    [JsonPropertyName("containerdConfig")]
    public V1beta1ClusterSpecForProviderNodePoolDefaultsNodeConfigDefaultsContainerdConfig? ContainerdConfig { get; set; }

    /// <summary>The default Google Container Filesystem (GCFS) configuration at the cluster level. e.g. enable image streaming across all the node pools within the cluster. Structure is documented below.</summary>
    [JsonPropertyName("gcfsConfig")]
    public V1beta1ClusterSpecForProviderNodePoolDefaultsNodeConfigDefaultsGcfsConfig? GcfsConfig { get; set; }

    /// <summary>only port is enabled for newly created node pools in the cluster. It is strongly recommended to set this to FALSE. Possible values: TRUE, FALSE.</summary>
    [JsonPropertyName("insecureKubeletReadonlyPortEnabled")]
    public string? InsecureKubeletReadonlyPortEnabled { get; set; }

    /// <summary>The type of logging agent that is deployed by default for newly created node pools in the cluster. Valid values include DEFAULT and MAX_THROUGHPUT. See Increasing logging agent throughput for more information.</summary>
    [JsonPropertyName("loggingVariant")]
    public string? LoggingVariant { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Default NodePool settings for the entire cluster. These settings are overridden if specified on the specific NodePool object. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNodePoolDefaults
{
    /// <summary>Subset of NodeConfig message that has defaults.</summary>
    [JsonPropertyName("nodeConfigDefaults")]
    public V1beta1ClusterSpecForProviderNodePoolDefaultsNodeConfigDefaults? NodeConfigDefaults { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Choose what type of notifications you want to receive. If no filters are applied, you'll receive all notification types. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNotificationConfigPubsubFilter
{
    /// <summary>Can be used to filter what notifications are sent. Accepted values are UPGRADE_AVAILABLE_EVENT, UPGRADE_EVENT, SECURITY_BULLETIN_EVENT and UPGRADE_INFO_EVENT. See Filtering notifications for more details.</summary>
    [JsonPropertyName("eventType")]
    public IList<string>? EventType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The pubsub config for the cluster's upgrade notifications.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNotificationConfigPubsub
{
    /// <summary>Whether or not the notification config is enabled</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Choose what type of notifications you want to receive. If no filters are applied, you'll receive all notification types. Structure is documented below.</summary>
    [JsonPropertyName("filter")]
    public V1beta1ClusterSpecForProviderNotificationConfigPubsubFilter? Filter { get; set; }

    /// <summary>The pubsub topic to push upgrade notifications to. Must be in the same project as the cluster. Must be in the format: projects/{project}/topics/{topic}.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the cluster upgrade notifications feature. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderNotificationConfig
{
    /// <summary>The pubsub config for the cluster's upgrade notifications.</summary>
    [JsonPropertyName("pubsub")]
    public V1beta1ClusterSpecForProviderNotificationConfigPubsub? Pubsub { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderPodAutoscaling
{
    /// <summary>Enable the Horizontal Pod Autoscaling profile for this cluster. Acceptable values are:</summary>
    [JsonPropertyName("hpaProfile")]
    public string? HpaProfile { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Controls cluster master global access settings. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderPrivateClusterConfigMasterGlobalAccessConfig
{
    /// <summary>Whether the cluster master is accessible globally or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderPrivateClusterConfigPrivateEndpointSubnetworkRefPolicy
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
/// <summary>Reference to a Subnetwork in compute to populate privateEndpointSubnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderPrivateClusterConfigPrivateEndpointSubnetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderPrivateClusterConfigPrivateEndpointSubnetworkRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderPrivateClusterConfigPrivateEndpointSubnetworkSelectorPolicy
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
/// <summary>Selector for a Subnetwork in compute to populate privateEndpointSubnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderPrivateClusterConfigPrivateEndpointSubnetworkSelector
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
    public V1beta1ClusterSpecForProviderPrivateClusterConfigPrivateEndpointSubnetworkSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for private clusters, clusters with private nodes. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderPrivateClusterConfig
{
    /// <summary>When true, the cluster's private endpoint is used as the cluster endpoint and access through the public endpoint is disabled. When false, either endpoint can be used. This field only applies to private clusters, when enable_private_nodes is true.</summary>
    [JsonPropertyName("enablePrivateEndpoint")]
    public bool? EnablePrivateEndpoint { get; set; }

    /// <summary>Enables the private cluster feature, creating a private endpoint on the cluster. In a private cluster, nodes only have RFC 1918 private addresses and communicate with the master's private endpoint via private networking.</summary>
    [JsonPropertyName("enablePrivateNodes")]
    public bool? EnablePrivateNodes { get; set; }

    /// <summary>Controls cluster master global access settings. Structure is documented below.</summary>
    [JsonPropertyName("masterGlobalAccessConfig")]
    public V1beta1ClusterSpecForProviderPrivateClusterConfigMasterGlobalAccessConfig? MasterGlobalAccessConfig { get; set; }

    /// <summary>The IP range in CIDR notation to use for the hosted master network. This range will be used for assigning private IP addresses to the cluster master(s) and the ILB VIP. This range must not overlap with any other ranges in use within the cluster's network, and it must be a /28 subnet. See Private Cluster Limitations for more details. This field only applies to private clusters, when enable_private_nodes is true.</summary>
    [JsonPropertyName("masterIpv4CidrBlock")]
    public string? MasterIpv4CidrBlock { get; set; }

    /// <summary>Subnetwork in cluster's network where master's endpoint will be provisioned.</summary>
    [JsonPropertyName("privateEndpointSubnetwork")]
    public string? PrivateEndpointSubnetwork { get; set; }

    /// <summary>Reference to a Subnetwork in compute to populate privateEndpointSubnetwork.</summary>
    [JsonPropertyName("privateEndpointSubnetworkRef")]
    public V1beta1ClusterSpecForProviderPrivateClusterConfigPrivateEndpointSubnetworkRef? PrivateEndpointSubnetworkRef { get; set; }

    /// <summary>Selector for a Subnetwork in compute to populate privateEndpointSubnetwork.</summary>
    [JsonPropertyName("privateEndpointSubnetworkSelector")]
    public V1beta1ClusterSpecForProviderPrivateClusterConfigPrivateEndpointSubnetworkSelector? PrivateEndpointSubnetworkSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration options for the Release channel feature, which provide more control over automatic upgrades of your GKE clusters. When updating this field, GKE imposes specific version requirements. See Selecting a new release channel for more details; the google_container_engine_versions datasource can provide the default version for a channel. Instead, use the "UNSPECIFIED" channel. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderReleaseChannel
{
    /// <summary>The selected release channel. Accepted values are:</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters for using BigQuery as the destination of resource usage export.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderResourceUsageExportConfigBigqueryDestination
{
    /// <summary>The ID of a BigQuery Dataset. For Example:</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the ResourceUsageExportConfig feature. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderResourceUsageExportConfig
{
    /// <summary>Parameters for using BigQuery as the destination of resource usage export.</summary>
    [JsonPropertyName("bigqueryDestination")]
    public V1beta1ClusterSpecForProviderResourceUsageExportConfigBigqueryDestination? BigqueryDestination { get; set; }

    /// <summary>Whether to enable network egress metering for this cluster. If enabled, a daemonset will be created in the cluster to meter network egress traffic.</summary>
    [JsonPropertyName("enableNetworkEgressMetering")]
    public bool? EnableNetworkEgressMetering { get; set; }

    /// <summary>Whether to enable resource consumption metering on this cluster. When enabled, a table will be created in the resource export BigQuery dataset to store resource consumption data. The resulting table can be joined with the resource usage table or with BigQuery billing export. Defaults to true.</summary>
    [JsonPropertyName("enableResourceConsumptionMetering")]
    public bool? EnableResourceConsumptionMetering { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the SecretManagerConfig feature. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderSecretManagerConfig
{
    /// <summary>Enable the Secret Manager add-on for this cluster.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Enable/Disable Security Posture API features for the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderSecurityPostureConfig
{
    /// <summary>Sets the mode of the Kubernetes security posture API's off-cluster features. Available options include DISABLED, BASIC, and ENTERPRISE.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Sets the mode of the Kubernetes security posture API's workload vulnerability scanning. Available options include VULNERABILITY_DISABLED, VULNERABILITY_BASIC and VULNERABILITY_ENTERPRISE.</summary>
    [JsonPropertyName("vulnerabilityMode")]
    public string? VulnerabilityMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderServiceExternalIpsConfig
{
    /// <summary>Controls whether external ips specified by a service will be allowed. It is enabled by default.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderSubnetworkRefPolicy
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
public partial class V1beta1ClusterSpecForProviderSubnetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecForProviderSubnetworkRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderSubnetworkSelectorPolicy
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
public partial class V1beta1ClusterSpecForProviderSubnetworkSelector
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
    public V1beta1ClusterSpecForProviderSubnetworkSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The custom keys configuration of the cluster Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderUserManagedKeysConfig
{
    /// <summary>The Certificate Authority Service caPool to use for the aggreation CA in this cluster.</summary>
    [JsonPropertyName("aggregationCa")]
    public string? AggregationCa { get; set; }

    /// <summary>The Certificate Authority Service caPool to use for the cluster CA in this cluster.</summary>
    [JsonPropertyName("clusterCa")]
    public string? ClusterCa { get; set; }

    /// <summary>The Cloud KMS cryptoKey to use for Confidential Hyperdisk on the control plane nodes.</summary>
    [JsonPropertyName("controlPlaneDiskEncryptionKey")]
    public string? ControlPlaneDiskEncryptionKey { get; set; }

    /// <summary>The Certificate Authority Service caPool to use for the etcd API CA in this cluster.</summary>
    [JsonPropertyName("etcdApiCa")]
    public string? EtcdApiCa { get; set; }

    /// <summary>The Certificate Authority Service caPool to use for the etcd peer CA in this cluster.</summary>
    [JsonPropertyName("etcdPeerCa")]
    public string? EtcdPeerCa { get; set; }

    /// <summary>Resource path of the Cloud KMS cryptoKey to use for encryption of internal etcd backups.</summary>
    [JsonPropertyName("gkeopsEtcdBackupEncryptionKey")]
    public string? GkeopsEtcdBackupEncryptionKey { get; set; }

    /// <summary>The Cloud KMS cryptoKeyVersions to use for signing service account JWTs issued by this cluster.</summary>
    [JsonPropertyName("serviceAccountSigningKeys")]
    public IList<string>? ServiceAccountSigningKeys { get; set; }

    /// <summary>The Cloud KMS cryptoKeyVersions to use for verifying service account JWTs issued by this cluster.</summary>
    [JsonPropertyName("serviceAccountVerificationKeys")]
    public IList<string>? ServiceAccountVerificationKeys { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Vertical Pod Autoscaling automatically adjusts the resources of pods controlled by it. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderVerticalPodAutoscaling
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Workload Identity allows Kubernetes service accounts to act as a user-managed Google IAM Service Account. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProviderWorkloadIdentityConfig
{
    /// <summary>The workload pool to attach all Kubernetes service accounts to.</summary>
    [JsonPropertyName("workloadPool")]
    public string? WorkloadPool { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecForProvider
{
    /// <summary>The configuration for addons supported by GKE. Structure is documented below.</summary>
    [JsonPropertyName("addonsConfig")]
    public V1beta1ClusterSpecForProviderAddonsConfig? AddonsConfig { get; set; }

    /// <summary>Enable NET_ADMIN for the cluster. Defaults to false. This field should only be enabled for Autopilot clusters (enable_autopilot set to true).</summary>
    [JsonPropertyName("allowNetAdmin")]
    public bool? AllowNetAdmin { get; set; }

    /// <summary>Configuration for anonymous authentication restrictions. Structure is documented below.</summary>
    [JsonPropertyName("anonymousAuthenticationConfig")]
    public V1beta1ClusterSpecForProviderAnonymousAuthenticationConfig? AnonymousAuthenticationConfig { get; set; }

    /// <summary>Configuration for the Google Groups for GKE feature. Structure is documented below.</summary>
    [JsonPropertyName("authenticatorGroupsConfig")]
    public V1beta1ClusterSpecForProviderAuthenticatorGroupsConfig? AuthenticatorGroupsConfig { get; set; }

    /// <summary>Configuration options for the Binary Authorization feature. Structure is documented below.</summary>
    [JsonPropertyName("binaryAuthorization")]
    public V1beta1ClusterSpecForProviderBinaryAuthorization? BinaryAuthorization { get; set; }

    /// <summary>Per-cluster configuration of Node Auto-Provisioning with Cluster Autoscaler to automatically adjust the size of the cluster and create/delete node pools based on the current needs of the cluster's workload. See the guide to using Node Auto-Provisioning for more details. Structure is documented below.</summary>
    [JsonPropertyName("clusterAutoscaling")]
    public V1beta1ClusterSpecForProviderClusterAutoscaling? ClusterAutoscaling { get; set; }

    /// <summary>The IP address range of the Kubernetes pods in this cluster in CIDR notation (e.g. 10.96.0.0/14). Leave blank to have one automatically chosen or specify a /14 block in 10.0.0.0/8. This field will default a new cluster to routes-based, where ip_allocation_policy is not defined.</summary>
    [JsonPropertyName("clusterIpv4Cidr")]
    public string? ClusterIpv4Cidr { get; set; }

    /// <summary>Configuration for Confidential Nodes feature. Structure is documented below documented below.</summary>
    [JsonPropertyName("confidentialNodes")]
    public V1beta1ClusterSpecForProviderConfidentialNodes? ConfidentialNodes { get; set; }

    /// <summary>Configuration for all of the cluster's control plane endpoints. Structure is documented below.</summary>
    [JsonPropertyName("controlPlaneEndpointsConfig")]
    public V1beta1ClusterSpecForProviderControlPlaneEndpointsConfig? ControlPlaneEndpointsConfig { get; set; }

    /// <summary>Configuration for the Cost Allocation feature. Structure is documented below.</summary>
    [JsonPropertyName("costManagementConfig")]
    public V1beta1ClusterSpecForProviderCostManagementConfig? CostManagementConfig { get; set; }

    /// <summary>Structure is documented below.</summary>
    [JsonPropertyName("databaseEncryption")]
    public V1beta1ClusterSpecForProviderDatabaseEncryption? DatabaseEncryption { get; set; }

    /// <summary>The desired datapath provider for this cluster. This is set to LEGACY_DATAPATH by default, which uses the IPTables-based kube-proxy implementation. Set to ADVANCED_DATAPATH to enable Dataplane v2.</summary>
    [JsonPropertyName("datapathProvider")]
    public string? DatapathProvider { get; set; }

    /// <summary>The default maximum number of pods per node in this cluster. This doesn't work on "routes-based" clusters, clusters that don't have IP Aliasing enabled. See the official documentation for more information.</summary>
    [JsonPropertyName("defaultMaxPodsPerNode")]
    public double? DefaultMaxPodsPerNode { get; set; }

    /// <summary>GKE SNAT DefaultSnatStatus contains the desired state of whether default sNAT should be disabled on the cluster, API doc. Structure is documented below</summary>
    [JsonPropertyName("defaultSnatStatus")]
    public V1beta1ClusterSpecForProviderDefaultSnatStatus? DefaultSnatStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>Description of the cluster.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Disable L4 load balancer VPC firewalls to enable firewall policies.</summary>
    [JsonPropertyName("disableL4LbFirewallReconciliation")]
    public bool? DisableL4LbFirewallReconciliation { get; set; }

    /// <summary>Configuration for Using Cloud DNS for GKE. Structure is documented below.</summary>
    [JsonPropertyName("dnsConfig")]
    public V1beta1ClusterSpecForProviderDnsConfig? DnsConfig { get; set; }

    /// <summary>Enable Autopilot for this cluster. Defaults to false. Note that when this option is enabled, certain features of Standard GKE are not available. See the official documentation for available features.</summary>
    [JsonPropertyName("enableAutopilot")]
    public bool? EnableAutopilot { get; set; }

    /// <summary>Whether CiliumClusterWideNetworkPolicy is enabled on this cluster. Defaults to false.</summary>
    [JsonPropertyName("enableCiliumClusterwideNetworkPolicy")]
    public bool? EnableCiliumClusterwideNetworkPolicy { get; set; }

    /// <summary>Whether FQDN Network Policy is enabled on this cluster. Users who enable this feature for existing Standard clusters must restart the GKE Dataplane V2 anetd DaemonSet after enabling it. See the Enable FQDN Network Policy in an existing cluster for more information.</summary>
    [JsonPropertyName("enableFqdnNetworkPolicy")]
    public bool? EnableFqdnNetworkPolicy { get; set; }

    /// <summary>Whether Intra-node visibility is enabled for this cluster. This makes same node pod to pod traffic visible for VPC network.</summary>
    [JsonPropertyName("enableIntranodeVisibility")]
    public bool? EnableIntranodeVisibility { get; set; }

    /// <summary>Configuration for Kubernetes Beta APIs. Structure is documented below.</summary>
    [JsonPropertyName("enableK8SBetaApis")]
    public V1beta1ClusterSpecForProviderEnableK8SBetaApis? EnableK8SBetaApis { get; set; }

    /// <summary>Whether to enable Kubernetes Alpha features for this cluster. Note that when this option is enabled, the cluster cannot be upgraded and will be automatically deleted after 30 days.</summary>
    [JsonPropertyName("enableKubernetesAlpha")]
    public bool? EnableKubernetesAlpha { get; set; }

    /// <summary>Whether L4ILB Subsetting is enabled for this cluster.</summary>
    [JsonPropertyName("enableL4IlbSubsetting")]
    public bool? EnableL4IlbSubsetting { get; set; }

    /// <summary>Whether the ABAC authorizer is enabled for this cluster. When enabled, identities in the system, including service accounts, nodes, and controllers, will have statically granted permissions beyond those provided by the RBAC configuration or IAM. Defaults to false</summary>
    [JsonPropertyName("enableLegacyAbac")]
    public bool? EnableLegacyAbac { get; set; }

    /// <summary>Whether multi-networking is enabled for this cluster.</summary>
    [JsonPropertyName("enableMultiNetworking")]
    public bool? EnableMultiNetworking { get; set; }

    /// <summary>Enable Shielded Nodes features on all nodes in this cluster.  Defaults to true.</summary>
    [JsonPropertyName("enableShieldedNodes")]
    public bool? EnableShieldedNodes { get; set; }

    /// <summary>Whether to enable Cloud TPU resources in this cluster. See the official documentation.</summary>
    [JsonPropertyName("enableTpu")]
    public bool? EnableTpu { get; set; }

    /// <summary>Configuration for [Enterprise edition].(https://cloud.google.com/kubernetes-engine/enterprise/docs/concepts/gke-editions). Structure is documented below.</summary>
    [JsonPropertyName("enterpriseConfig")]
    public V1beta1ClusterSpecForProviderEnterpriseConfig? EnterpriseConfig { get; set; }

    /// <summary>Fleet configuration for the cluster. Structure is documented below.</summary>
    [JsonPropertyName("fleet")]
    public V1beta1ClusterSpecForProviderFleet? Fleet { get; set; }

    /// <summary>Configuration for GKE Gateway API controller. Structure is documented below.</summary>
    [JsonPropertyName("gatewayApiConfig")]
    public V1beta1ClusterSpecForProviderGatewayApiConfig? GatewayApiConfig { get; set; }

    /// <summary>Configuration options for the auto-upgrade patch type feature, which provide more control over the speed of automatic upgrades of your GKE clusters. Structure is documented below.</summary>
    [JsonPropertyName("gkeAutoUpgradeConfig")]
    public V1beta1ClusterSpecForProviderGkeAutoUpgradeConfig? GkeAutoUpgradeConfig { get; set; }

    /// <summary>. Structure is documented below.</summary>
    [JsonPropertyName("identityServiceConfig")]
    public V1beta1ClusterSpecForProviderIdentityServiceConfig? IdentityServiceConfig { get; set; }

    /// <summary>Defines the config of in-transit encryption. Valid values are IN_TRANSIT_ENCRYPTION_DISABLED and IN_TRANSIT_ENCRYPTION_INTER_NODE_TRANSPARENT.</summary>
    [JsonPropertyName("inTransitEncryptionConfig")]
    public string? InTransitEncryptionConfig { get; set; }

    /// <summary>The number of nodes to create in this cluster's default node pool. In regional or multi-zonal clusters, this is the number of nodes per zone. Must be set if node_pool is not set. If you're using google_container_node_pool objects with no default node pool, you'll need to set this to a value of at least 1, alongside setting remove_default_node_pool to true.</summary>
    [JsonPropertyName("initialNodeCount")]
    public double? InitialNodeCount { get; set; }

    /// <summary>Configuration of cluster IP allocation for VPC-native clusters. If this block is unset during creation, it will be set by the GKE backend. Structure is documented below.</summary>
    [JsonPropertyName("ipAllocationPolicy")]
    public V1beta1ClusterSpecForProviderIpAllocationPolicy? IpAllocationPolicy { get; set; }

    /// <summary>The location (region or zone) in which the cluster master will be created, as well as the default node location. If you specify a zone (such as us-central1-a), the cluster will be a zonal cluster with a single cluster master. If you specify a region (such as us-west1), the cluster will be a regional cluster with multiple masters spread across zones in the region, and with default node locations in those zones as well</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Logging configuration for the cluster. Structure is documented below.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta1ClusterSpecForProviderLoggingConfig? LoggingConfig { get; set; }

    /// <summary>The logging service that the cluster should write logs to. Available options include logging.googleapis.com(Legacy Stackdriver), logging.googleapis.com/kubernetes(Stackdriver Kubernetes Engine Logging), and none. Defaults to logging.googleapis.com/kubernetes</summary>
    [JsonPropertyName("loggingService")]
    public string? LoggingService { get; set; }

    /// <summary>The maintenance policy to use for the cluster. Structure is documented below.</summary>
    [JsonPropertyName("maintenancePolicy")]
    public V1beta1ClusterSpecForProviderMaintenancePolicy? MaintenancePolicy { get; set; }

    /// <summary>The authentication information for accessing the Kubernetes master. Some values in this block are only returned by the API if your service account has permission to get credentials for your GKE cluster. If you see an unexpected diff unsetting your client cert, ensure you have the container.clusters.getCredentials permission. Structure is documented below.</summary>
    [JsonPropertyName("masterAuth")]
    public V1beta1ClusterSpecForProviderMasterAuth? MasterAuth { get; set; }

    /// <summary>The desired configuration options for master authorized networks. Omit the nested cidr_blocks attribute to disallow external access (except the cluster node IPs, which GKE automatically whitelists). Structure is documented below.</summary>
    [JsonPropertyName("masterAuthorizedNetworksConfig")]
    public V1beta1ClusterSpecForProviderMasterAuthorizedNetworksConfig? MasterAuthorizedNetworksConfig { get; set; }

    /// <summary>Structure is documented below.</summary>
    [JsonPropertyName("meshCertificates")]
    public V1beta1ClusterSpecForProviderMeshCertificates? MeshCertificates { get; set; }

    /// <summary>The minimum version of the master. GKE will auto-update the master to new versions, so this does not guarantee the current master version--use the read-only master_version field to obtain that. If unset, the cluster's version will be set by GKE to the version of the most recent official release (which is not necessarily the latest version). If you intend to specify versions manually, the docs describe the various acceptable formats for this field.</summary>
    [JsonPropertyName("minMasterVersion")]
    public string? MinMasterVersion { get; set; }

    /// <summary>Monitoring configuration for the cluster. Structure is documented below.</summary>
    [JsonPropertyName("monitoringConfig")]
    public V1beta1ClusterSpecForProviderMonitoringConfig? MonitoringConfig { get; set; }

    /// <summary>The monitoring service that the cluster should write metrics to. Automatically send metrics from pods in the cluster to the Google Cloud Monitoring API. VM metrics will be collected by Google Compute Engine regardless of this setting Available options include monitoring.googleapis.com(Legacy Stackdriver), monitoring.googleapis.com/kubernetes(Stackdriver Kubernetes Engine Monitoring), and none. Defaults to monitoring.googleapis.com/kubernetes</summary>
    [JsonPropertyName("monitoringService")]
    public string? MonitoringService { get; set; }

    /// <summary>The name or self_link of the Google Compute Engine network to which the cluster is connected. For Shared VPC, set this to the self link of the shared network.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Network bandwidth tier configuration. Structure is documented below.</summary>
    [JsonPropertyName("networkPerformanceConfig")]
    public V1beta1ClusterSpecForProviderNetworkPerformanceConfig? NetworkPerformanceConfig { get; set; }

    /// <summary>Configuration options for the NetworkPolicy feature. Structure is documented below.</summary>
    [JsonPropertyName("networkPolicy")]
    public V1beta1ClusterSpecForProviderNetworkPolicy? NetworkPolicy { get; set; }

    /// <summary>Reference to a Network in compute to populate network.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1ClusterSpecForProviderNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate network.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta1ClusterSpecForProviderNetworkSelector? NetworkSelector { get; set; }

    /// <summary>Determines whether alias IPs or routes will be used for pod IPs in the cluster. Options are VPC_NATIVE or ROUTES. VPC_NATIVE enables IP aliasing. Newly created clusters will default to VPC_NATIVE.</summary>
    [JsonPropertyName("networkingMode")]
    public string? NetworkingMode { get; set; }

    /// <summary>Parameters used in creating the default node pool. Structure is documented below.</summary>
    [JsonPropertyName("nodeConfig")]
    public V1beta1ClusterSpecForProviderNodeConfig? NodeConfig { get; set; }

    /// <summary>The list of zones in which the cluster's nodes are located. Nodes must be in the region of their regional cluster or in the same region as their cluster's zone for zonal clusters. If this is specified for a zonal cluster, omit the cluster's zone.</summary>
    [JsonPropertyName("nodeLocations")]
    public IList<string>? NodeLocations { get; set; }

    /// <summary>Node pool configs that apply to auto-provisioned node pools in autopilot clusters and node auto-provisioning-enabled clusters. Structure is documented below.</summary>
    [JsonPropertyName("nodePoolAutoConfig")]
    public V1beta1ClusterSpecForProviderNodePoolAutoConfig? NodePoolAutoConfig { get; set; }

    /// <summary>Default NodePool settings for the entire cluster. These settings are overridden if specified on the specific NodePool object. Structure is documented below.</summary>
    [JsonPropertyName("nodePoolDefaults")]
    public V1beta1ClusterSpecForProviderNodePoolDefaults? NodePoolDefaults { get; set; }

    /// <summary>The Kubernetes version on the nodes. Must either be unset or set to the same value as min_master_version on create. Defaults to the default version set by GKE which is not necessarily the latest version. This only affects nodes in the default node pool. To update nodes in other node pools, use the version attribute on the node pool.</summary>
    [JsonPropertyName("nodeVersion")]
    public string? NodeVersion { get; set; }

    /// <summary>Configuration for the cluster upgrade notifications feature. Structure is documented below.</summary>
    [JsonPropertyName("notificationConfig")]
    public V1beta1ClusterSpecForProviderNotificationConfig? NotificationConfig { get; set; }

    /// <summary>Configuration for the Structure is documented below.</summary>
    [JsonPropertyName("podAutoscaling")]
    public V1beta1ClusterSpecForProviderPodAutoscaling? PodAutoscaling { get; set; }

    /// <summary>Configuration for private clusters, clusters with private nodes. Structure is documented below.</summary>
    [JsonPropertyName("privateClusterConfig")]
    public V1beta1ClusterSpecForProviderPrivateClusterConfig? PrivateClusterConfig { get; set; }

    /// <summary>The desired state of IPv6 connectivity to Google Services. By default, no private IPv6 access to or from Google Services (all access will be via IPv4).</summary>
    [JsonPropertyName("privateIpv6GoogleAccess")]
    public string? PrivateIpv6GoogleAccess { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Configuration options for the Release channel feature, which provide more control over automatic upgrades of your GKE clusters. When updating this field, GKE imposes specific version requirements. See Selecting a new release channel for more details; the google_container_engine_versions datasource can provide the default version for a channel. Instead, use the "UNSPECIFIED" channel. Structure is documented below.</summary>
    [JsonPropertyName("releaseChannel")]
    public V1beta1ClusterSpecForProviderReleaseChannel? ReleaseChannel { get; set; }

    /// <summary>If true, deletes the default node pool upon cluster creation. If you're using google_container_node_pool resources with no default node pool, this should be set to true, alongside setting initial_node_count to at least 1.</summary>
    [JsonPropertyName("removeDefaultNodePool")]
    public bool? RemoveDefaultNodePool { get; set; }

    /// <summary>The GCE resource labels (a map of key/value pairs) to be applied to the cluster.</summary>
    [JsonPropertyName("resourceLabels")]
    public IDictionary<string, string>? ResourceLabels { get; set; }

    /// <summary>Configuration for the ResourceUsageExportConfig feature. Structure is documented below.</summary>
    [JsonPropertyName("resourceUsageExportConfig")]
    public V1beta1ClusterSpecForProviderResourceUsageExportConfig? ResourceUsageExportConfig { get; set; }

    /// <summary>Configuration for the SecretManagerConfig feature. Structure is documented below.</summary>
    [JsonPropertyName("secretManagerConfig")]
    public V1beta1ClusterSpecForProviderSecretManagerConfig? SecretManagerConfig { get; set; }

    /// <summary>Enable/Disable Security Posture API features for the cluster. Structure is documented below.</summary>
    [JsonPropertyName("securityPostureConfig")]
    public V1beta1ClusterSpecForProviderSecurityPostureConfig? SecurityPostureConfig { get; set; }

    /// <summary>Structure is documented below.</summary>
    [JsonPropertyName("serviceExternalIpsConfig")]
    public V1beta1ClusterSpecForProviderServiceExternalIpsConfig? ServiceExternalIpsConfig { get; set; }

    /// <summary>The name or self_link of the Google Compute Engine subnetwork in which the cluster's instances are launched.</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta1ClusterSpecForProviderSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkSelector")]
    public V1beta1ClusterSpecForProviderSubnetworkSelector? SubnetworkSelector { get; set; }

    /// <summary>The custom keys configuration of the cluster Structure is documented below.</summary>
    [JsonPropertyName("userManagedKeysConfig")]
    public V1beta1ClusterSpecForProviderUserManagedKeysConfig? UserManagedKeysConfig { get; set; }

    /// <summary>Vertical Pod Autoscaling automatically adjusts the resources of pods controlled by it. Structure is documented below.</summary>
    [JsonPropertyName("verticalPodAutoscaling")]
    public V1beta1ClusterSpecForProviderVerticalPodAutoscaling? VerticalPodAutoscaling { get; set; }

    /// <summary>Workload Identity allows Kubernetes service accounts to act as a user-managed Google IAM Service Account. Structure is documented below.</summary>
    [JsonPropertyName("workloadIdentityConfig")]
    public V1beta1ClusterSpecForProviderWorkloadIdentityConfig? WorkloadIdentityConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderAddonsConfigCloudrunConfig
{
    /// <summary>The status of the Istio addon, which makes it easy to set up Istio for services in a cluster. It is disabled by default. Set disabled = false to enable.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>The load balancer type of CloudRun ingress service. It is external load balancer by default. Set load_balancer_type=LOAD_BALANCER_TYPE_INTERNAL to configure it as internal load balancer.</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>. The status of the ConfigConnector addon. It is disabled by default; Set enabled = true to enable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderAddonsConfigConfigConnectorConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>. The status of the NodeLocal DNSCache addon. It is disabled by default. Set enabled = true to enable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderAddonsConfigDnsCacheConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>. Whether this cluster should enable the Google Compute Engine Persistent Disk Container Storage Interface (CSI) Driver. Set enabled = true to enable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderAddonsConfigGcePersistentDiskCsiDriverConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The status of the Filestore CSI driver addon, which allows the usage of filestore instance as volumes. It is disabled by default; set enabled = true to enable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderAddonsConfigGcpFilestoreCsiDriverConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The status of the GCSFuse CSI driver addon, which allows the usage of a gcs bucket as volumes. It is disabled by default for Standard clusters; set enabled = true to enable. It is enabled by default for Autopilot clusters with version 1.24 or later; set enabled = true to enable it explicitly. See Enable the Cloud Storage FUSE CSI driver for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderAddonsConfigGcsFuseCsiDriverConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>. The status of the Backup for GKE agent addon. It is disabled by default; Set enabled = true to enable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderAddonsConfigGkeBackupAgentConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The status of the Horizontal Pod Autoscaling addon, which increases or decreases the number of replica pods a replication controller has based on the resource usage of the existing pods. It is enabled by default; set disabled = true to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderAddonsConfigHorizontalPodAutoscaling
{
    /// <summary>The status of the Istio addon, which makes it easy to set up Istio for services in a cluster. It is disabled by default. Set disabled = false to enable.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The status of the HTTP (L7) load balancing controller addon, which makes it easy to set up HTTP load balancers for services in a cluster. It is enabled by default; set disabled = true to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderAddonsConfigHttpLoadBalancing
{
    /// <summary>The status of the Istio addon, which makes it easy to set up Istio for services in a cluster. It is disabled by default. Set disabled = false to enable.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Whether we should enable the network policy addon for the master.  This must be enabled in order to enable network policy for the nodes. To enable this, you must also define a network_policy block, otherwise nothing will happen. It can only be disabled if the nodes already do not have network policies enabled. Defaults to disabled; set disabled = false to enable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderAddonsConfigNetworkPolicyConfig
{
    /// <summary>The status of the Istio addon, which makes it easy to set up Istio for services in a cluster. It is disabled by default. Set disabled = false to enable.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The status of the Parallelstore CSI driver addon, which allows the usage of a Parallelstore instances as volumes. It is disabled by default for Standard clusters; set enabled = true to enable. It is enabled by default for Autopilot clusters with version 1.29 or later; set enabled = true to enable it explicitly. See Enable the Parallelstore CSI driver for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderAddonsConfigParallelstoreCsiDriverConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Logging configuration for the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderAddonsConfigRayOperatorConfigRayClusterLoggingConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Monitoring configuration for the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderAddonsConfigRayOperatorConfigRayClusterMonitoringConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderAddonsConfigRayOperatorConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Logging configuration for the cluster. Structure is documented below.</summary>
    [JsonPropertyName("rayClusterLoggingConfig")]
    public V1beta1ClusterSpecInitProviderAddonsConfigRayOperatorConfigRayClusterLoggingConfig? RayClusterLoggingConfig { get; set; }

    /// <summary>Monitoring configuration for the cluster. Structure is documented below.</summary>
    [JsonPropertyName("rayClusterMonitoringConfig")]
    public V1beta1ClusterSpecInitProviderAddonsConfigRayOperatorConfigRayClusterMonitoringConfig? RayClusterMonitoringConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>. The status of the Stateful HA addon, which provides automatic configurable failover for stateful applications. It is disabled by default for Standard clusters. Set enabled = true to enable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderAddonsConfigStatefulHaConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The configuration for addons supported by GKE. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderAddonsConfig
{
    /// <summary>. Structure is documented below.</summary>
    [JsonPropertyName("cloudrunConfig")]
    public V1beta1ClusterSpecInitProviderAddonsConfigCloudrunConfig? CloudrunConfig { get; set; }

    /// <summary>. The status of the ConfigConnector addon. It is disabled by default; Set enabled = true to enable.</summary>
    [JsonPropertyName("configConnectorConfig")]
    public V1beta1ClusterSpecInitProviderAddonsConfigConfigConnectorConfig? ConfigConnectorConfig { get; set; }

    /// <summary>. The status of the NodeLocal DNSCache addon. It is disabled by default. Set enabled = true to enable.</summary>
    [JsonPropertyName("dnsCacheConfig")]
    public V1beta1ClusterSpecInitProviderAddonsConfigDnsCacheConfig? DnsCacheConfig { get; set; }

    /// <summary>. Whether this cluster should enable the Google Compute Engine Persistent Disk Container Storage Interface (CSI) Driver. Set enabled = true to enable.</summary>
    [JsonPropertyName("gcePersistentDiskCsiDriverConfig")]
    public V1beta1ClusterSpecInitProviderAddonsConfigGcePersistentDiskCsiDriverConfig? GcePersistentDiskCsiDriverConfig { get; set; }

    /// <summary>The status of the Filestore CSI driver addon, which allows the usage of filestore instance as volumes. It is disabled by default; set enabled = true to enable.</summary>
    [JsonPropertyName("gcpFilestoreCsiDriverConfig")]
    public V1beta1ClusterSpecInitProviderAddonsConfigGcpFilestoreCsiDriverConfig? GcpFilestoreCsiDriverConfig { get; set; }

    /// <summary>The status of the GCSFuse CSI driver addon, which allows the usage of a gcs bucket as volumes. It is disabled by default for Standard clusters; set enabled = true to enable. It is enabled by default for Autopilot clusters with version 1.24 or later; set enabled = true to enable it explicitly. See Enable the Cloud Storage FUSE CSI driver for more information.</summary>
    [JsonPropertyName("gcsFuseCsiDriverConfig")]
    public V1beta1ClusterSpecInitProviderAddonsConfigGcsFuseCsiDriverConfig? GcsFuseCsiDriverConfig { get; set; }

    /// <summary>. The status of the Backup for GKE agent addon. It is disabled by default; Set enabled = true to enable.</summary>
    [JsonPropertyName("gkeBackupAgentConfig")]
    public V1beta1ClusterSpecInitProviderAddonsConfigGkeBackupAgentConfig? GkeBackupAgentConfig { get; set; }

    /// <summary>The status of the Horizontal Pod Autoscaling addon, which increases or decreases the number of replica pods a replication controller has based on the resource usage of the existing pods. It is enabled by default; set disabled = true to disable.</summary>
    [JsonPropertyName("horizontalPodAutoscaling")]
    public V1beta1ClusterSpecInitProviderAddonsConfigHorizontalPodAutoscaling? HorizontalPodAutoscaling { get; set; }

    /// <summary>The status of the HTTP (L7) load balancing controller addon, which makes it easy to set up HTTP load balancers for services in a cluster. It is enabled by default; set disabled = true to disable.</summary>
    [JsonPropertyName("httpLoadBalancing")]
    public V1beta1ClusterSpecInitProviderAddonsConfigHttpLoadBalancing? HttpLoadBalancing { get; set; }

    /// <summary>Whether we should enable the network policy addon for the master.  This must be enabled in order to enable network policy for the nodes. To enable this, you must also define a network_policy block, otherwise nothing will happen. It can only be disabled if the nodes already do not have network policies enabled. Defaults to disabled; set disabled = false to enable.</summary>
    [JsonPropertyName("networkPolicyConfig")]
    public V1beta1ClusterSpecInitProviderAddonsConfigNetworkPolicyConfig? NetworkPolicyConfig { get; set; }

    /// <summary>The status of the Parallelstore CSI driver addon, which allows the usage of a Parallelstore instances as volumes. It is disabled by default for Standard clusters; set enabled = true to enable. It is enabled by default for Autopilot clusters with version 1.29 or later; set enabled = true to enable it explicitly. See Enable the Parallelstore CSI driver for more information.</summary>
    [JsonPropertyName("parallelstoreCsiDriverConfig")]
    public V1beta1ClusterSpecInitProviderAddonsConfigParallelstoreCsiDriverConfig? ParallelstoreCsiDriverConfig { get; set; }

    /// <summary>. The status of the Ray Operator addon. It is disabled by default. Set enabled = true to enable. The minimum cluster version to enable Ray is 1.30.0-gke.1747000.</summary>
    [JsonPropertyName("rayOperatorConfig")]
    public IList<V1beta1ClusterSpecInitProviderAddonsConfigRayOperatorConfig>? RayOperatorConfig { get; set; }

    /// <summary>. The status of the Stateful HA addon, which provides automatic configurable failover for stateful applications. It is disabled by default for Standard clusters. Set enabled = true to enable.</summary>
    [JsonPropertyName("statefulHaConfig")]
    public V1beta1ClusterSpecInitProviderAddonsConfigStatefulHaConfig? StatefulHaConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for anonymous authentication restrictions. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderAnonymousAuthenticationConfig
{
    /// <summary>Sets or removes authentication restrictions. Available options include LIMITED and ENABLED.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the Google Groups for GKE feature. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderAuthenticatorGroupsConfig
{
    /// <summary>The name of the RBAC security group for use with Google security groups in Kubernetes RBAC. Group name must be in format gke-security-groups@yourdomain.com.</summary>
    [JsonPropertyName("securityGroup")]
    public string? SecurityGroup { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration options for the Binary Authorization feature. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderBinaryAuthorization
{
    /// <summary>(DEPRECATED) Enable Binary Authorization for this cluster. Deprecated in favor of evaluation_mode.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Mode of operation for Binary Authorization policy evaluation. Valid values are DISABLED and PROJECT_SINGLETON_POLICY_ENFORCE.</summary>
    [JsonPropertyName("evaluationMode")]
    public string? EvaluationMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>NodeManagement configuration for this NodePool. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterAutoscalingAutoProvisioningDefaultsManagement
{
    /// <summary>Specifies whether the node auto-repair is enabled for the node pool. If enabled, the nodes in this node pool will be monitored and, if they fail health checks too many times, an automatic repair action will be triggered.</summary>
    [JsonPropertyName("autoRepair")]
    public bool? AutoRepair { get; set; }

    /// <summary>Specifies whether node auto-upgrade is enabled for the node pool. If enabled, node auto-upgrade helps keep the nodes in your node pool up to date with the latest release version of Kubernetes.</summary>
    [JsonPropertyName("autoUpgrade")]
    public bool? AutoUpgrade { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Shielded Instance options. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterAutoscalingAutoProvisioningDefaultsShieldedInstanceConfig
{
    /// <summary>Defines if the instance has integrity monitoring enabled.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>Defines if the instance has Secure Boot enabled.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }
}
#nullable disable

#nullable enable
/// <summary>green upgrade. To be specified when strategy is set to BLUE_GREEN. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterAutoscalingAutoProvisioningDefaultsUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy
{
    /// <summary>Number of blue nodes to drain in a batch. Only one of the batch_percentage or batch_node_count can be specified.</summary>
    [JsonPropertyName("batchNodeCount")]
    public double? BatchNodeCount { get; set; }

    /// <summary>:  Percentage of the bool pool nodes to drain in a batch. The range of this field should be (0.0, 1.0). Only one of the batch_percentage or batch_node_count can be specified.</summary>
    [JsonPropertyName("batchPercentage")]
    public double? BatchPercentage { get; set; }

    /// <summary>Soak time after each batch gets drained. A duration in seconds with up to nine fractional digits, ending with 's'. Example: "3.5s".`.</summary>
    [JsonPropertyName("batchSoakDuration")]
    public string? BatchSoakDuration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Settings for blue-green upgrade strategy. To be specified when strategy is set to BLUE_GREEN. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterAutoscalingAutoProvisioningDefaultsUpgradeSettingsBlueGreenSettings
{
    /// <summary>Time needed after draining entire blue pool. After this period, blue pool will be cleaned up. A duration in seconds with up to nine fractional digits, ending with 's'. Example: "3.5s".</summary>
    [JsonPropertyName("nodePoolSoakDuration")]
    public string? NodePoolSoakDuration { get; set; }

    /// <summary>green upgrade. To be specified when strategy is set to BLUE_GREEN. Structure is documented below.</summary>
    [JsonPropertyName("standardRolloutPolicy")]
    public V1beta1ClusterSpecInitProviderClusterAutoscalingAutoProvisioningDefaultsUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy? StandardRolloutPolicy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies the upgrade settings for NAP created node pools. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterAutoscalingAutoProvisioningDefaultsUpgradeSettings
{
    /// <summary>Settings for blue-green upgrade strategy. To be specified when strategy is set to BLUE_GREEN. Structure is documented below.</summary>
    [JsonPropertyName("blueGreenSettings")]
    public V1beta1ClusterSpecInitProviderClusterAutoscalingAutoProvisioningDefaultsUpgradeSettingsBlueGreenSettings? BlueGreenSettings { get; set; }

    /// <summary>The maximum number of nodes that can be created beyond the current size of the node pool during the upgrade process. To be used when strategy is set to SURGE. Default is 0.</summary>
    [JsonPropertyName("maxSurge")]
    public double? MaxSurge { get; set; }

    /// <summary>The maximum number of nodes that can be simultaneously unavailable during the upgrade process. To be used when strategy is set to SURGE. Default is 0.</summary>
    [JsonPropertyName("maxUnavailable")]
    public double? MaxUnavailable { get; set; }

    /// <summary>Strategy used for node pool update. Strategy can only be one of BLUE_GREEN or SURGE. The default is value is SURGE.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Contains defaults for a node pool created by NAP. A subset of fields also apply to GKE Autopilot clusters. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterAutoscalingAutoProvisioningDefaults
{
    /// <summary>The Customer Managed Encryption Key used to encrypt the boot disk attached to each node in the node pool. This should be of the form projects/[KEY_PROJECT_ID]/locations/[LOCATION]/keyRings/[RING_NAME]/cryptoKeys/[KEY_NAME]. For more information about protecting resources with Cloud KMS Keys please see: https://cloud.google.com/compute/docs/disks/customer-managed-encryption</summary>
    [JsonPropertyName("bootDiskKmsKey")]
    public string? BootDiskKmsKey { get; set; }

    /// <summary>Size of the disk attached to each node, specified in GB. The smallest allowed disk size is 10GB. Defaults to 100</summary>
    [JsonPropertyName("diskSize")]
    public double? DiskSize { get; set; }

    /// <summary>Type of the disk attached to each node (e.g. 'pd-standard', 'pd-balanced' or 'pd-ssd'). If unspecified, the default disk type is 'pd-balanced'</summary>
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    /// <summary>The image type to use for this node. Note that changing the image type will delete and recreate all nodes in the node pool.</summary>
    [JsonPropertyName("imageType")]
    public string? ImageType { get; set; }

    /// <summary>NodeManagement configuration for this NodePool. Structure is documented below.</summary>
    [JsonPropertyName("management")]
    public V1beta1ClusterSpecInitProviderClusterAutoscalingAutoProvisioningDefaultsManagement? Management { get; set; }

    /// <summary>Minimum CPU platform to be used by this instance. The instance may be scheduled on the specified or newer CPU platform. Applicable values are the friendly names of CPU platforms, such as Intel Haswell. See the official documentation for more information.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The set of Google API scopes to be made available on all of the node VMs under the "default" service account. Use the "https://www.googleapis.com/auth/cloud-platform" scope to grant access to all APIs. It is recommended that you set service_account to a non-default service account and grant IAM roles to that service account for only the resources that it needs.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }

    /// <summary>The service account to be used by the Node VMs. If not specified, the "default" service account is used.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Shielded Instance options. Structure is documented below.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta1ClusterSpecInitProviderClusterAutoscalingAutoProvisioningDefaultsShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    /// <summary>Specifies the upgrade settings for NAP created node pools. Structure is documented below.</summary>
    [JsonPropertyName("upgradeSettings")]
    public V1beta1ClusterSpecInitProviderClusterAutoscalingAutoProvisioningDefaultsUpgradeSettings? UpgradeSettings { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterAutoscalingResourceLimits
{
    /// <summary>Maximum amount of the resource in the cluster.</summary>
    [JsonPropertyName("maximum")]
    public double? Maximum { get; set; }

    /// <summary>Minimum amount of the resource in the cluster.</summary>
    [JsonPropertyName("minimum")]
    public double? Minimum { get; set; }

    /// <summary>The type of the resource. For example, cpu and memory.  See the guide to using Node Auto-Provisioning for a list of types.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Per-cluster configuration of Node Auto-Provisioning with Cluster Autoscaler to automatically adjust the size of the cluster and create/delete node pools based on the current needs of the cluster's workload. See the guide to using Node Auto-Provisioning for more details. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderClusterAutoscaling
{
    /// <summary>Contains defaults for a node pool created by NAP. A subset of fields also apply to GKE Autopilot clusters. Structure is documented below.</summary>
    [JsonPropertyName("autoProvisioningDefaults")]
    public V1beta1ClusterSpecInitProviderClusterAutoscalingAutoProvisioningDefaults? AutoProvisioningDefaults { get; set; }

    /// <summary>The list of Google Compute Engine zones in which the NodePool's nodes can be created by NAP.</summary>
    [JsonPropertyName("autoProvisioningLocations")]
    public IList<string>? AutoProvisioningLocations { get; set; }

    /// <summary>Configuration options for the Autoscaling profile feature, which lets you choose whether the cluster autoscaler should optimize for resource utilization or resource availability when deciding to remove nodes from a cluster. Can be BALANCED or OPTIMIZE_UTILIZATION. Defaults to BALANCED.</summary>
    [JsonPropertyName("autoscalingProfile")]
    public string? AutoscalingProfile { get; set; }

    /// <summary>Whether node auto-provisioning is enabled. Must be supplied for GKE Standard clusters, true is implied for autopilot clusters. Resource limits for cpu and memory must be defined to enable node auto-provisioning for GKE Standard.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Global constraints for machine resources in the cluster. Configuring the cpu and memory types is required if node auto-provisioning is enabled. These limits will apply to node pool autoscaling in addition to node auto-provisioning. Structure is documented below.</summary>
    [JsonPropertyName("resourceLimits")]
    public IList<V1beta1ClusterSpecInitProviderClusterAutoscalingResourceLimits>? ResourceLimits { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for Confidential Nodes feature. Structure is documented below documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderConfidentialNodes
{
    /// <summary>Defines the type of technology used by the confidential node.</summary>
    [JsonPropertyName("confidentialInstanceType")]
    public string? ConfidentialInstanceType { get; set; }

    /// <summary>Enable Confidential GKE Nodes for this node pool, to enforce encryption of data in-use.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DNS endpoint configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderControlPlaneEndpointsConfigDnsEndpointConfig
{
    /// <summary>Controls whether user traffic is allowed over this endpoint. Note that GCP-managed services may still use the endpoint even if this is false.</summary>
    [JsonPropertyName("allowExternalTraffic")]
    public bool? AllowExternalTraffic { get; set; }

    /// <summary>(Output) The cluster's DNS endpoint.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }
}
#nullable disable

#nullable enable
/// <summary>IP endpoint configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderControlPlaneEndpointsConfigIpEndpointsConfig
{
    /// <summary>Controls whether to allow direct IP access. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for all of the cluster's control plane endpoints. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderControlPlaneEndpointsConfig
{
    /// <summary>DNS endpoint configuration.</summary>
    [JsonPropertyName("dnsEndpointConfig")]
    public V1beta1ClusterSpecInitProviderControlPlaneEndpointsConfigDnsEndpointConfig? DnsEndpointConfig { get; set; }

    /// <summary>IP endpoint configuration.</summary>
    [JsonPropertyName("ipEndpointsConfig")]
    public V1beta1ClusterSpecInitProviderControlPlaneEndpointsConfigIpEndpointsConfig? IpEndpointsConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the Cost Allocation feature. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderCostManagementConfig
{
    /// <summary>Whether to enable the cost allocation feature.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderDatabaseEncryption
{
    /// <summary>the key to use to encrypt/decrypt secrets.  See the DatabaseEncryption definition for more information.</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>ENCRYPTED or DECRYPTED</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}
#nullable disable

#nullable enable
/// <summary>GKE SNAT DefaultSnatStatus contains the desired state of whether default sNAT should be disabled on the cluster, API doc. Structure is documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderDefaultSnatStatus
{
    /// <summary>Whether the cluster disables default in-node sNAT rules. In-node sNAT rules will be disabled when defaultSnatStatus is disabled.When disabled is set to false, default IP masquerade rules will be applied to the nodes to prevent sNAT on cluster internal traffic</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for Using Cloud DNS for GKE. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderDnsConfig
{
    /// <summary>This will enable Cloud DNS additive VPC scope. Must provide a domain name that is unique within the VPC. For this to work cluster_dns = "CLOUD_DNS" and cluster_dns_scope = "CLUSTER_SCOPE" must both be set as well.</summary>
    [JsonPropertyName("additiveVpcScopeDnsDomain")]
    public string? AdditiveVpcScopeDnsDomain { get; set; }

    /// <summary>Which in-cluster DNS provider should be used. PROVIDER_UNSPECIFIED (default) or PLATFORM_DEFAULT or CLOUD_DNS.</summary>
    [JsonPropertyName("clusterDns")]
    public string? ClusterDns { get; set; }

    /// <summary>The suffix used for all cluster service records.</summary>
    [JsonPropertyName("clusterDnsDomain")]
    public string? ClusterDnsDomain { get; set; }

    /// <summary>The scope of access to cluster DNS records. DNS_SCOPE_UNSPECIFIED or CLUSTER_SCOPE or VPC_SCOPE. If the cluster_dns field is set to CLOUD_DNS, DNS_SCOPE_UNSPECIFIED and empty/null behave like CLUSTER_SCOPE.</summary>
    [JsonPropertyName("clusterDnsScope")]
    public string? ClusterDnsScope { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for Kubernetes Beta APIs. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderEnableK8SBetaApis
{
    /// <summary>Enabled Kubernetes Beta APIs. To list a Beta API resource, use the representation {group}/{version}/{resource}. The version must be a Beta version. Note that you cannot disable beta APIs that are already enabled on a cluster without recreating it. See the Configure beta APIs for more information.</summary>
    [JsonPropertyName("enabledApis")]
    public IList<string>? EnabledApis { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for [Enterprise edition].(https://cloud.google.com/kubernetes-engine/enterprise/docs/concepts/gke-editions). Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderEnterpriseConfig
{
    /// <summary>Sets the tier of the cluster. Available options include STANDARD and ENTERPRISE.</summary>
    [JsonPropertyName("desiredTier")]
    public string? DesiredTier { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Fleet configuration for the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderFleet
{
    /// <summary>The name of the Fleet host project where this cluster will be registered.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for GKE Gateway API controller. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderGatewayApiConfig
{
    /// <summary>Which Gateway Api channel should be used. CHANNEL_DISABLED, CHANNEL_EXPERIMENTAL or CHANNEL_STANDARD.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration options for the auto-upgrade patch type feature, which provide more control over the speed of automatic upgrades of your GKE clusters. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderGkeAutoUpgradeConfig
{
    /// <summary>The selected patch mode. Accepted values are:</summary>
    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderIdentityServiceConfig
{
    /// <summary>Whether to enable the Identity Service component. It is disabled by default. Set enabled=true to enable.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The configuration for additional pod secondary ranges at the cluster level. Used for Autopilot clusters and Standard clusters with which control of the secondary Pod IP address assignment to node pools isn't needed. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderIpAllocationPolicyAdditionalPodRangesConfig
{
    /// <summary>The names of the Pod ranges to add to the cluster.</summary>
    [JsonPropertyName("podRangeNames")]
    public IList<string>? PodRangeNames { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderIpAllocationPolicyPodCidrOverprovisionConfig
{
    /// <summary>The status of the Istio addon, which makes it easy to set up Istio for services in a cluster. It is disabled by default. Set disabled = false to enable.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration of cluster IP allocation for VPC-native clusters. If this block is unset during creation, it will be set by the GKE backend. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderIpAllocationPolicy
{
    /// <summary>The configuration for additional pod secondary ranges at the cluster level. Used for Autopilot clusters and Standard clusters with which control of the secondary Pod IP address assignment to node pools isn't needed. Structure is documented below.</summary>
    [JsonPropertyName("additionalPodRangesConfig")]
    public V1beta1ClusterSpecInitProviderIpAllocationPolicyAdditionalPodRangesConfig? AdditionalPodRangesConfig { get; set; }

    /// <summary>The IP address range for the cluster pod IPs. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use.</summary>
    [JsonPropertyName("clusterIpv4CidrBlock")]
    public string? ClusterIpv4CidrBlock { get; set; }

    /// <summary>The name of the existing secondary range in the cluster's subnetwork to use for pod IP addresses. Alternatively, cluster_ipv4_cidr_block can be used to automatically create a GKE-managed one.</summary>
    [JsonPropertyName("clusterSecondaryRangeName")]
    public string? ClusterSecondaryRangeName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podCidrOverprovisionConfig")]
    public V1beta1ClusterSpecInitProviderIpAllocationPolicyPodCidrOverprovisionConfig? PodCidrOverprovisionConfig { get; set; }

    /// <summary>The IP address range of the services IPs in this cluster. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use.</summary>
    [JsonPropertyName("servicesIpv4CidrBlock")]
    public string? ServicesIpv4CidrBlock { get; set; }

    /// <summary>The name of the existing secondary range in the cluster's subnetwork to use for service ClusterIPs. Alternatively, services_ipv4_cidr_block can be used to automatically create a GKE-managed one.</summary>
    [JsonPropertyName("servicesSecondaryRangeName")]
    public string? ServicesSecondaryRangeName { get; set; }

    /// <summary>The IP Stack Type of the cluster. Default value is IPV4. Possible values are IPV4 and IPV4_IPV6.</summary>
    [JsonPropertyName("stackType")]
    public string? StackType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Logging configuration for the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderLoggingConfig
{
    /// <summary>The GKE components exposing logs. Supported values include: SYSTEM_COMPONENTS, APISERVER, CONTROLLER_MANAGER, SCHEDULER, and WORKLOADS.</summary>
    [JsonPropertyName("enableComponents")]
    public IList<string>? EnableComponents { get; set; }
}
#nullable disable

#nullable enable
/// <summary>structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderMaintenancePolicyDailyMaintenanceWindow
{
    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>MaintenanceExclusionOptions provides maintenance exclusion related options.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderMaintenancePolicyMaintenanceExclusionExclusionOptions
{
    /// <summary>Whether or not to enable GKE Auto-Monitoring. Supported values include: ALL, NONE.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderMaintenancePolicyMaintenanceExclusion
{
    /// <summary></summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>The name of the cluster, unique within the project and location.</summary>
    [JsonPropertyName("exclusionName")]
    public string? ExclusionName { get; set; }

    /// <summary>MaintenanceExclusionOptions provides maintenance exclusion related options.</summary>
    [JsonPropertyName("exclusionOptions")]
    public V1beta1ClusterSpecInitProviderMaintenancePolicyMaintenanceExclusionExclusionOptions? ExclusionOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>structure documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderMaintenancePolicyRecurringWindow
{
    /// <summary></summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurrence")]
    public string? Recurrence { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The maintenance policy to use for the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderMaintenancePolicy
{
    /// <summary>structure documented below.</summary>
    [JsonPropertyName("dailyMaintenanceWindow")]
    public V1beta1ClusterSpecInitProviderMaintenancePolicyDailyMaintenanceWindow? DailyMaintenanceWindow { get; set; }

    /// <summary>structure documented below</summary>
    [JsonPropertyName("maintenanceExclusion")]
    public IList<V1beta1ClusterSpecInitProviderMaintenancePolicyMaintenanceExclusion>? MaintenanceExclusion { get; set; }

    /// <summary>structure documented below</summary>
    [JsonPropertyName("recurringWindow")]
    public V1beta1ClusterSpecInitProviderMaintenancePolicyRecurringWindow? RecurringWindow { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Whether client certificate authorization is enabled for this cluster.  For example:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderMasterAuthClientCertificateConfig
{
    /// <summary></summary>
    [JsonPropertyName("issueClientCertificate")]
    public bool? IssueClientCertificate { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The authentication information for accessing the Kubernetes master. Some values in this block are only returned by the API if your service account has permission to get credentials for your GKE cluster. If you see an unexpected diff unsetting your client cert, ensure you have the container.clusters.getCredentials permission. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderMasterAuth
{
    /// <summary>Whether client certificate authorization is enabled for this cluster.  For example:</summary>
    [JsonPropertyName("clientCertificateConfig")]
    public V1beta1ClusterSpecInitProviderMasterAuthClientCertificateConfig? ClientCertificateConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderMasterAuthorizedNetworksConfigCidrBlocks
{
    /// <summary>External network that can access Kubernetes master through HTTPS. Must be specified in CIDR notation.</summary>
    [JsonPropertyName("cidrBlock")]
    public string? CidrBlock { get; set; }

    /// <summary>Field for users to identify CIDR blocks.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The desired configuration options for master authorized networks. Omit the nested cidr_blocks attribute to disallow external access (except the cluster node IPs, which GKE automatically whitelists). Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderMasterAuthorizedNetworksConfig
{
    /// <summary>External networks that can access the Kubernetes cluster master through HTTPS.</summary>
    [JsonPropertyName("cidrBlocks")]
    public IList<V1beta1ClusterSpecInitProviderMasterAuthorizedNetworksConfigCidrBlocks>? CidrBlocks { get; set; }

    /// <summary>Whether Kubernetes master is accessible via Google Compute Engine Public IPs.</summary>
    [JsonPropertyName("gcpPublicCidrsAccessEnabled")]
    public bool? GcpPublicCidrsAccessEnabled { get; set; }

    /// <summary>Whether authorized networks is enforced on the private endpoint or not.</summary>
    [JsonPropertyName("privateEndpointEnforcementEnabled")]
    public bool? PrivateEndpointEnforcementEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderMeshCertificates
{
    /// <summary>Controls the issuance of workload mTLS certificates. It is enabled by default. Workload Identity is required, see workload_config.</summary>
    [JsonPropertyName("enableCertificates")]
    public bool? EnableCertificates { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for Advanced Datapath Monitoring. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderMonitoringConfigAdvancedDatapathObservabilityConfig
{
    /// <summary>Whether or not to enable advanced datapath metrics.</summary>
    [JsonPropertyName("enableMetrics")]
    public bool? EnableMetrics { get; set; }

    /// <summary>Whether or not Relay is enabled.</summary>
    [JsonPropertyName("enableRelay")]
    public bool? EnableRelay { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration options for GKE Auto-Monitoring.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderMonitoringConfigManagedPrometheusAutoMonitoringConfig
{
    /// <summary>Whether or not to enable GKE Auto-Monitoring. Supported values include: ALL, NONE.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for Managed Service for Prometheus. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderMonitoringConfigManagedPrometheus
{
    /// <summary>Configuration options for GKE Auto-Monitoring.</summary>
    [JsonPropertyName("autoMonitoringConfig")]
    public V1beta1ClusterSpecInitProviderMonitoringConfigManagedPrometheusAutoMonitoringConfig? AutoMonitoringConfig { get; set; }

    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Monitoring configuration for the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderMonitoringConfig
{
    /// <summary>Configuration for Advanced Datapath Monitoring. Structure is documented below.</summary>
    [JsonPropertyName("advancedDatapathObservabilityConfig")]
    public V1beta1ClusterSpecInitProviderMonitoringConfigAdvancedDatapathObservabilityConfig? AdvancedDatapathObservabilityConfig { get; set; }

    /// <summary>The GKE components exposing metrics. Supported values include: SYSTEM_COMPONENTS, APISERVER, SCHEDULER, CONTROLLER_MANAGER, STORAGE, HPA, POD, DAEMONSET, DEPLOYMENT, STATEFULSET, KUBELET, CADVISOR, DCGM and JOBSET. In beta provider, WORKLOADS is supported on top of those 12 values. (WORKLOADS is deprecated and removed in GKE 1.24.) KUBELET and CADVISOR are only supported in GKE 1.29.3-gke.1093000 and above. JOBSET is only supported in GKE 1.32.1-gke.1357001 and above.</summary>
    [JsonPropertyName("enableComponents")]
    public IList<string>? EnableComponents { get; set; }

    /// <summary>Configuration for Managed Service for Prometheus. Structure is documented below.</summary>
    [JsonPropertyName("managedPrometheus")]
    public V1beta1ClusterSpecInitProviderMonitoringConfigManagedPrometheus? ManagedPrometheus { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Network bandwidth tier configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNetworkPerformanceConfig
{
    /// <summary>Specifies the total network bandwidth tier for NodePools in the cluster.</summary>
    [JsonPropertyName("totalEgressBandwidthTier")]
    public string? TotalEgressBandwidthTier { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration options for the NetworkPolicy feature. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNetworkPolicy
{
    /// <summary>Whether network policy is enabled on the cluster.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The selected network policy provider. Defaults to PROVIDER_UNSPECIFIED.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNetworkRefPolicy
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
public partial class V1beta1ClusterSpecInitProviderNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderNetworkRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNetworkSelectorPolicy
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
public partial class V1beta1ClusterSpecInitProviderNetworkSelector
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
    public V1beta1ClusterSpecInitProviderNetworkSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies options for controlling advanced machine features. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeConfigAdvancedMachineFeatures
{
    /// <summary>Defines whether the instance should have nested virtualization enabled. Defaults to false.</summary>
    [JsonPropertyName("enableNestedVirtualization")]
    public bool? EnableNestedVirtualization { get; set; }

    /// <summary>Defines the performance monitoring unit PMU level. Valid values are ARCHITECTURAL, STANDARD, or ENHANCED. Defaults to off.</summary>
    [JsonPropertyName("performanceMonitoringUnit")]
    public string? PerformanceMonitoringUnit { get; set; }

    /// <summary>The number of threads per physical core. To disable simultaneous multithreading (SMT) set this to 1. If unset, the maximum number of threads supported per core by the underlying processor is assumed.</summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for Confidential Nodes feature. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeConfigConfidentialNodes
{
    /// <summary>Defines the type of technology used by the confidential node.</summary>
    [JsonPropertyName("confidentialInstanceType")]
    public string? ConfidentialInstanceType { get; set; }

    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig
{
    /// <summary></summary>
    [JsonPropertyName("secretUri")]
    public string? SecretUri { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig
{
    /// <summary></summary>
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpSecretManagerCertificateConfig")]
    public V1beta1ClusterSpecInitProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig? GcpSecretManagerCertificateConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for private container registries. There are two fields in this config:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeConfigContainerdConfigPrivateRegistryAccessConfig
{
    /// <summary>List of configuration objects for CA and domains. Each object identifies a certificate and its assigned domains. See how to configure for private container registries for more detail. Example:</summary>
    [JsonPropertyName("certificateAuthorityDomainConfig")]
    public IList<V1beta1ClusterSpecInitProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig>? CertificateAuthorityDomainConfig { get; set; }

    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters to customize containerd runtime. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeConfigContainerdConfig
{
    /// <summary>Configuration for private container registries. There are two fields in this config:</summary>
    [JsonPropertyName("privateRegistryAccessConfig")]
    public V1beta1ClusterSpecInitProviderNodeConfigContainerdConfigPrivateRegistryAccessConfig? PrivateRegistryAccessConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters for the ephemeral storage filesystem. If unspecified, ephemeral storage is backed by the boot disk. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeConfigEphemeralStorageLocalSsdConfig
{
    /// <summary>Number of raw-block local NVMe SSD disks to be attached to the node utilized for GKE Data Cache. If zero, then GKE Data Cache will not be enabled in the nodes.</summary>
    [JsonPropertyName("dataCacheCount")]
    public double? DataCacheCount { get; set; }

    /// <summary>The amount of local SSD disks that will be attached to each cluster node. Defaults to 0.</summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters for the NCCL Fast Socket feature. If unspecified, NCCL Fast Socket will not be enabled on the node pool. Node Pool must enable gvnic. GKE version 1.25.2-gke.1700 or later. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeConfigFastSocket
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters for the Google Container Filesystem (GCFS). If unspecified, GCFS will not be enabled on the node pool. When enabling this feature you must specify image_type = "COS_CONTAINERD" and node_version from GKE versions 1.19 or later to use it. For GKE versions 1.19, 1.20, and 1.21, the recommended minimum node_version would be 1.19.15-gke.1300, 1.20.11-gke.1300, and 1.21.5-gke.1300 respectively. A machine_type that has more than 16 GiB of memory is also recommended. GCFS must be enabled in order to use image streaming. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeConfigGcfsConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for auto installation of GPU driver. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeConfigGuestAcceleratorGpuDriverInstallationConfig
{
    /// <summary>Mode for how the GPU driver is installed. Accepted values are:</summary>
    [JsonPropertyName("gpuDriverVersion")]
    public string? GpuDriverVersion { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for GPU sharing. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeConfigGuestAcceleratorGpuSharingConfig
{
    /// <summary>The type of GPU sharing strategy to enable on the GPU node. Accepted values are:</summary>
    [JsonPropertyName("gpuSharingStrategy")]
    public string? GpuSharingStrategy { get; set; }

    /// <summary>The maximum number of containers that can share a GPU.</summary>
    [JsonPropertyName("maxSharedClientsPerGpu")]
    public double? MaxSharedClientsPerGpu { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeConfigGuestAccelerator
{
    /// <summary>The number of the guest accelerator cards exposed to this instance.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>Configuration for auto installation of GPU driver. Structure is documented below.</summary>
    [JsonPropertyName("gpuDriverInstallationConfig")]
    public V1beta1ClusterSpecInitProviderNodeConfigGuestAcceleratorGpuDriverInstallationConfig? GpuDriverInstallationConfig { get; set; }

    /// <summary>Size of partitions to create on the GPU. Valid values are described in the NVIDIA mig user guide.</summary>
    [JsonPropertyName("gpuPartitionSize")]
    public string? GpuPartitionSize { get; set; }

    /// <summary>Configuration for GPU sharing. Structure is documented below.</summary>
    [JsonPropertyName("gpuSharingConfig")]
    public V1beta1ClusterSpecInitProviderNodeConfigGuestAcceleratorGpuSharingConfig? GpuSharingConfig { get; set; }

    /// <summary>The accelerator type resource to expose to this instance. E.g. nvidia-tesla-k80.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Google Virtual NIC (gVNIC) is a virtual network interface. Installing the gVNIC driver allows for more efficient traffic transmission across the Google network infrastructure. gVNIC is an alternative to the virtIO-based ethernet driver. GKE nodes must use a Container-Optimized OS node image. GKE node version 1.15.11-gke.15 or later Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeConfigGvnic
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The maintenance policy to use for the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeConfigHostMaintenancePolicy
{
    /// <summary></summary>
    [JsonPropertyName("maintenanceInterval")]
    public string? MaintenanceInterval { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Kubelet configuration, currently supported attributes can be found here. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeConfigKubeletConfig
{
    /// <summary>Defines a comma-separated allowlist of unsafe sysctls or sysctl patterns which can be set on the Pods. The allowed sysctl groups are kernel.shm*, kernel.msg*, kernel.sem, fs.mqueue.*, and net.*.</summary>
    [JsonPropertyName("allowedUnsafeSysctls")]
    public IList<string>? AllowedUnsafeSysctls { get; set; }

    /// <summary>Defines the maximum number of container log files that can be present for a container. The integer must be between 2 and 10, inclusive.</summary>
    [JsonPropertyName("containerLogMaxFiles")]
    public double? ContainerLogMaxFiles { get; set; }

    /// <summary>Defines the maximum size of the container log file before it is rotated. Specified as a positive number and a unit suffix, such as "100Ki", "10Mi". Valid units are "Ki", "Mi", "Gi". The value must be between "10Mi" and "500Mi", inclusive. And the total container log size (container_log_max_size * container_log_max_files) cannot exceed 1% of the total storage of the node.</summary>
    [JsonPropertyName("containerLogMaxSize")]
    public string? ContainerLogMaxSize { get; set; }

    /// <summary>If true, enables CPU CFS quota enforcement for containers that specify CPU limits.</summary>
    [JsonPropertyName("cpuCfsQuota")]
    public bool? CpuCfsQuota { get; set; }

    /// <summary>The CPU CFS quota period value. Specified as a sequence of decimal numbers, each with optional fraction and a unit suffix, such as "300ms". Valid time units are "ns", "us" (or "µs"), "ms", "s", "m", "h". The value must be a positive duration.</summary>
    [JsonPropertyName("cpuCfsQuotaPeriod")]
    public string? CpuCfsQuotaPeriod { get; set; }

    /// <summary>The CPU management policy on the node. See K8S CPU Management Policies. One of "none" or "static". If unset (or set to the empty string ""), the API will treat the field as if set to "none". Prior to the 6.4.0 this field was marked as required. The workaround for the required field is setting the empty string "", which will function identically to not setting this field.</summary>
    [JsonPropertyName("cpuManagerPolicy")]
    public string? CpuManagerPolicy { get; set; }

    /// <summary>Defines the percent of disk usage after which image garbage collection is always run. The integer must be between 10 and 85, inclusive.</summary>
    [JsonPropertyName("imageGcHighThresholdPercent")]
    public double? ImageGcHighThresholdPercent { get; set; }

    /// <summary>Defines the percent of disk usage before which image garbage collection is never run. Lowest disk usage to garbage collect to. The integer must be between 10 and 85, inclusive.</summary>
    [JsonPropertyName("imageGcLowThresholdPercent")]
    public double? ImageGcLowThresholdPercent { get; set; }

    /// <summary>Defines the maximum age an image can be unused before it is garbage collected. Specified as a sequence of decimal numbers, each with optional fraction and a unit suffix, such as "300s", "1.5m", and "2h45m". Valid time units are "ns", "us" (or "µs"), "ms", "s", "m", "h". The value must be a positive duration.</summary>
    [JsonPropertyName("imageMaximumGcAge")]
    public string? ImageMaximumGcAge { get; set; }

    /// <summary>Defines the minimum age for an unused image before it is garbage collected. Specified as a sequence of decimal numbers, each with optional fraction and a unit suffix, such as "300s", "1.5m". The value cannot be greater than "2m".</summary>
    [JsonPropertyName("imageMinimumGcAge")]
    public string? ImageMinimumGcAge { get; set; }

    /// <summary>only port is enabled for newly created node pools in the cluster. It is strongly recommended to set this to FALSE. Possible values: TRUE, FALSE.</summary>
    [JsonPropertyName("insecureKubeletReadonlyPortEnabled")]
    public string? InsecureKubeletReadonlyPortEnabled { get; set; }

    /// <summary>Controls the maximum number of processes allowed to run in a pod. The value must be greater than or equal to 1024 and less than 4194304.</summary>
    [JsonPropertyName("podPidsLimit")]
    public double? PodPidsLimit { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Amounts for 2M and 1G hugepages. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeConfigLinuxNodeConfigHugepagesConfig
{
    /// <summary>Amount of 1G hugepages.</summary>
    [JsonPropertyName("hugepageSize1G")]
    public double? HugepageSize1G { get; set; }

    /// <summary>Amount of 2M hugepages.</summary>
    [JsonPropertyName("hugepageSize2M")]
    public double? HugepageSize2M { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters that can be configured on Linux nodes. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeConfigLinuxNodeConfig
{
    /// <summary>Possible cgroup modes that can be used. Accepted values are:</summary>
    [JsonPropertyName("cgroupMode")]
    public string? CgroupMode { get; set; }

    /// <summary>Amounts for 2M and 1G hugepages. Structure is documented below.</summary>
    [JsonPropertyName("hugepagesConfig")]
    public V1beta1ClusterSpecInitProviderNodeConfigLinuxNodeConfigHugepagesConfig? HugepagesConfig { get; set; }

    /// <summary>The Linux kernel parameters to be applied to the nodes and all pods running on the nodes. Specified as a map from the key, such as net.core.wmem_max, to a string value. Currently supported attributes can be found here. Note that validations happen all server side. All attributes are optional.</summary>
    [JsonPropertyName("sysctls")]
    public IDictionary<string, string>? Sysctls { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters for the local NVMe SSDs. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeConfigLocalNvmeSsdBlockConfig
{
    /// <summary>The amount of local SSD disks that will be attached to each cluster node. Defaults to 0.</summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The configuration of the desired reservation which instances could take capacity from. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeConfigReservationAffinity
{
    /// <summary>The type of reservation consumption Accepted values are:</summary>
    [JsonPropertyName("consumeReservationType")]
    public string? ConsumeReservationType { get; set; }

    /// <summary>Key for taint.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>name"</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeConfigSecondaryBootDisks
{
    /// <summary>Path to disk image to create the secondary boot disk from. After using the gke-disk-image-builder, this argument should be global/images/DISK_IMAGE_NAME.</summary>
    [JsonPropertyName("diskImage")]
    public string? DiskImage { get; set; }

    /// <summary>How to expose the node metadata to the workload running on the node. Accepted values are:</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeConfigServiceAccountRefPolicy
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
public partial class V1beta1ClusterSpecInitProviderNodeConfigServiceAccountRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderNodeConfigServiceAccountRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeConfigServiceAccountSelectorPolicy
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
public partial class V1beta1ClusterSpecInitProviderNodeConfigServiceAccountSelector
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
    public V1beta1ClusterSpecInitProviderNodeConfigServiceAccountSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Shielded Instance options. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeConfigShieldedInstanceConfig
{
    /// <summary>Defines if the instance has integrity monitoring enabled.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>Defines if the instance has Secure Boot enabled.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeConfigSoleTenantConfigNodeAffinity
{
    /// <summary>Key for taint.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies affinity or anti-affinity. Accepted values are "IN" or "NOT_IN"</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>name"</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Allows specifying multiple node affinities useful for running workloads on sole tenant nodes. node_affinity structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeConfigSoleTenantConfig
{
    /// <summary></summary>
    [JsonPropertyName("nodeAffinity")]
    public IList<V1beta1ClusterSpecInitProviderNodeConfigSoleTenantConfigNodeAffinity>? NodeAffinity { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeConfigTaint
{
    /// <summary>Effect for taint. Accepted values are NO_SCHEDULE, PREFER_NO_SCHEDULE, and NO_EXECUTE.</summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>Key for taint.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value for taint.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Windows node configuration, currently supporting OSVersion attribute. The value must be one of [OS_VERSION_UNSPECIFIED, OS_VERSION_LTSC2019, OS_VERSION_LTSC2022]. For example:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeConfigWindowsNodeConfig
{
    /// <summary></summary>
    [JsonPropertyName("osversion")]
    public string? Osversion { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Metadata configuration to expose to workloads on the node pool. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeConfigWorkloadMetadataConfig
{
    /// <summary>How to expose the node metadata to the workload running on the node. Accepted values are:</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters used in creating the default node pool. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodeConfig
{
    /// <summary>Specifies options for controlling advanced machine features. Structure is documented below.</summary>
    [JsonPropertyName("advancedMachineFeatures")]
    public V1beta1ClusterSpecInitProviderNodeConfigAdvancedMachineFeatures? AdvancedMachineFeatures { get; set; }

    /// <summary>The Customer Managed Encryption Key used to encrypt the boot disk attached to each node in the node pool. This should be of the form projects/[KEY_PROJECT_ID]/locations/[LOCATION]/keyRings/[RING_NAME]/cryptoKeys/[KEY_NAME]. For more information about protecting resources with Cloud KMS Keys please see: https://cloud.google.com/compute/docs/disks/customer-managed-encryption</summary>
    [JsonPropertyName("bootDiskKmsKey")]
    public string? BootDiskKmsKey { get; set; }

    /// <summary>Configuration for Confidential Nodes feature. Structure is documented below.</summary>
    [JsonPropertyName("confidentialNodes")]
    public V1beta1ClusterSpecInitProviderNodeConfigConfidentialNodes? ConfidentialNodes { get; set; }

    /// <summary>Parameters to customize containerd runtime. Structure is documented below.</summary>
    [JsonPropertyName("containerdConfig")]
    public V1beta1ClusterSpecInitProviderNodeConfigContainerdConfig? ContainerdConfig { get; set; }

    /// <summary>Size of the disk attached to each node, specified in GB. The smallest allowed disk size is 10GB. Defaults to 100GB.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>Type of the disk attached to each node (e.g. 'pd-standard', 'pd-balanced' or 'pd-ssd'). If unspecified, the default disk type is 'pd-balanced'</summary>
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    /// <summary>Enabling Confidential Storage will create boot disk with confidential mode. It is disabled by default.</summary>
    [JsonPropertyName("enableConfidentialStorage")]
    public bool? EnableConfidentialStorage { get; set; }

    /// <summary>Parameters for the ephemeral storage filesystem. If unspecified, ephemeral storage is backed by the boot disk. Structure is documented below.</summary>
    [JsonPropertyName("ephemeralStorageLocalSsdConfig")]
    public V1beta1ClusterSpecInitProviderNodeConfigEphemeralStorageLocalSsdConfig? EphemeralStorageLocalSsdConfig { get; set; }

    /// <summary>Parameters for the NCCL Fast Socket feature. If unspecified, NCCL Fast Socket will not be enabled on the node pool. Node Pool must enable gvnic. GKE version 1.25.2-gke.1700 or later. Structure is documented below.</summary>
    [JsonPropertyName("fastSocket")]
    public V1beta1ClusterSpecInitProviderNodeConfigFastSocket? FastSocket { get; set; }

    /// <summary>Enables Flex Start provisioning model for the node pool.</summary>
    [JsonPropertyName("flexStart")]
    public bool? FlexStart { get; set; }

    /// <summary>Parameters for the Google Container Filesystem (GCFS). If unspecified, GCFS will not be enabled on the node pool. When enabling this feature you must specify image_type = "COS_CONTAINERD" and node_version from GKE versions 1.19 or later to use it. For GKE versions 1.19, 1.20, and 1.21, the recommended minimum node_version would be 1.19.15-gke.1300, 1.20.11-gke.1300, and 1.21.5-gke.1300 respectively. A machine_type that has more than 16 GiB of memory is also recommended. GCFS must be enabled in order to use image streaming. Structure is documented below.</summary>
    [JsonPropertyName("gcfsConfig")]
    public V1beta1ClusterSpecInitProviderNodeConfigGcfsConfig? GcfsConfig { get; set; }

    /// <summary>List of the type and count of accelerator cards attached to the instance. Structure documented below. Note: As of 6.0.0, argument syntax is no longer supported for this field in favor of block syntax. To dynamically set a list of guest accelerators, use dynamic blocks. To set an empty list, use a single guest_accelerator block with count = 0.</summary>
    [JsonPropertyName("guestAccelerator")]
    public IList<V1beta1ClusterSpecInitProviderNodeConfigGuestAccelerator>? GuestAccelerator { get; set; }

    /// <summary>Google Virtual NIC (gVNIC) is a virtual network interface. Installing the gVNIC driver allows for more efficient traffic transmission across the Google network infrastructure. gVNIC is an alternative to the virtIO-based ethernet driver. GKE nodes must use a Container-Optimized OS node image. GKE node version 1.15.11-gke.15 or later Structure is documented below.</summary>
    [JsonPropertyName("gvnic")]
    public V1beta1ClusterSpecInitProviderNodeConfigGvnic? Gvnic { get; set; }

    /// <summary>The maintenance policy to use for the cluster. Structure is documented below.</summary>
    [JsonPropertyName("hostMaintenancePolicy")]
    public V1beta1ClusterSpecInitProviderNodeConfigHostMaintenancePolicy? HostMaintenancePolicy { get; set; }

    /// <summary>The image type to use for this node. Note that changing the image type will delete and recreate all nodes in the node pool.</summary>
    [JsonPropertyName("imageType")]
    public string? ImageType { get; set; }

    /// <summary>Kubelet configuration, currently supported attributes can be found here. Structure is documented below.</summary>
    [JsonPropertyName("kubeletConfig")]
    public V1beta1ClusterSpecInitProviderNodeConfigKubeletConfig? KubeletConfig { get; set; }

    /// <summary>The Kubernetes labels (key/value pairs) to be applied to each node. The kubernetes.io/ and k8s.io/ prefixes are reserved by Kubernetes Core components and cannot be specified.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Parameters that can be configured on Linux nodes. Structure is documented below.</summary>
    [JsonPropertyName("linuxNodeConfig")]
    public V1beta1ClusterSpecInitProviderNodeConfigLinuxNodeConfig? LinuxNodeConfig { get; set; }

    /// <summary>Parameters for the local NVMe SSDs. Structure is documented below.</summary>
    [JsonPropertyName("localNvmeSsdBlockConfig")]
    public V1beta1ClusterSpecInitProviderNodeConfigLocalNvmeSsdBlockConfig? LocalNvmeSsdBlockConfig { get; set; }

    /// <summary>The amount of local SSD disks that will be attached to each cluster node. Defaults to 0.</summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary>Possible Local SSD encryption modes: Accepted values are:</summary>
    [JsonPropertyName("localSsdEncryptionMode")]
    public string? LocalSsdEncryptionMode { get; set; }

    /// <summary>wide default value. Valid values include DEFAULT and MAX_THROUGHPUT. See Increasing logging agent throughput for more information.</summary>
    [JsonPropertyName("loggingVariant")]
    public string? LoggingVariant { get; set; }

    /// <summary>The name of a Google Compute Engine machine type. Defaults to e2-medium. To create a custom machine type, value should be set as specified here.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>The runtime of each node in the node pool in seconds, terminated by 's'. Example: "3600s".</summary>
    [JsonPropertyName("maxRunDuration")]
    public string? MaxRunDuration { get; set; }

    /// <summary>The metadata key/value pairs assigned to instances in the cluster. From GKE 1. To avoid this, set the value in your config.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Minimum CPU platform to be used by this instance. The instance may be scheduled on the specified or newer CPU platform. Applicable values are the friendly names of CPU platforms, such as Intel Haswell. See the official documentation for more information.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>Setting this field will assign instances of this pool to run on the specified node group. This is useful for running workloads on sole tenant nodes.</summary>
    [JsonPropertyName("nodeGroup")]
    public string? NodeGroup { get; set; }

    /// <summary>The set of Google API scopes to be made available on all of the node VMs under the "default" service account. Use the "https://www.googleapis.com/auth/cloud-platform" scope to grant access to all APIs. It is recommended that you set service_account to a non-default service account and grant IAM roles to that service account for only the resources that it needs.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }

    /// <summary>A boolean that represents whether or not the underlying node VMs are preemptible. See the official documentation for more information. Defaults to false.</summary>
    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    /// <summary>The configuration of the desired reservation which instances could take capacity from. Structure is documented below.</summary>
    [JsonPropertyName("reservationAffinity")]
    public V1beta1ClusterSpecInitProviderNodeConfigReservationAffinity? ReservationAffinity { get; set; }

    /// <summary>The GCP labels (key/value pairs) to be applied to each node. Refer here for how these labels are applied to clusters, node pools and nodes.</summary>
    [JsonPropertyName("resourceLabels")]
    public IDictionary<string, string>? ResourceLabels { get; set; }

    /// <summary>A map of resource manager tag keys and values to be attached to the nodes for managing Compute Engine firewalls using Network Firewall Policies. Tags must be according to specifications found here. A maximum of 5 tag key-value pairs can be specified. Existing tags will be replaced with new values. Tags must be in one of the following formats ([KEY]=[VALUE]) 1. tagKeys/{tag_key_id}=tagValues/{tag_value_id} 2. {org_id}/{tag_key_name}={tag_value_name} 3. {project_id}/{tag_key_name}={tag_value_name}.</summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }

    /// <summary>Parameters for secondary boot disks to preload container images and data on new nodes. Structure is documented below. gcfs_config must be enabled=true for this feature to work. min_master_version must also be set to use GKE 1.28.3-gke.106700 or later versions.</summary>
    [JsonPropertyName("secondaryBootDisks")]
    public IList<V1beta1ClusterSpecInitProviderNodeConfigSecondaryBootDisks>? SecondaryBootDisks { get; set; }

    /// <summary>The service account to be used by the Node VMs. If not specified, the "default" service account is used.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1ClusterSpecInitProviderNodeConfigServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountSelector")]
    public V1beta1ClusterSpecInitProviderNodeConfigServiceAccountSelector? ServiceAccountSelector { get; set; }

    /// <summary>Shielded Instance options. Structure is documented below.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta1ClusterSpecInitProviderNodeConfigShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    /// <summary>Allows specifying multiple node affinities useful for running workloads on sole tenant nodes. node_affinity structure is documented below.</summary>
    [JsonPropertyName("soleTenantConfig")]
    public V1beta1ClusterSpecInitProviderNodeConfigSoleTenantConfig? SoleTenantConfig { get; set; }

    /// <summary>A boolean that represents whether the underlying node VMs are spot. See the official documentation for more information. Defaults to false.</summary>
    [JsonPropertyName("spot")]
    public bool? Spot { get; set; }

    /// <summary>The list of Storage Pools where boot disks are provisioned.</summary>
    [JsonPropertyName("storagePools")]
    public IList<string>? StoragePools { get; set; }

    /// <summary>The list of instance tags applied to all nodes. Tags are used to identify valid sources or targets for network firewalls.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>A list of Kubernetes taints to apply to nodes. Structure is documented below.</summary>
    [JsonPropertyName("taint")]
    public IList<V1beta1ClusterSpecInitProviderNodeConfigTaint>? Taint { get; set; }

    /// <summary>Windows node configuration, currently supporting OSVersion attribute. The value must be one of [OS_VERSION_UNSPECIFIED, OS_VERSION_LTSC2019, OS_VERSION_LTSC2022]. For example:</summary>
    [JsonPropertyName("windowsNodeConfig")]
    public V1beta1ClusterSpecInitProviderNodeConfigWindowsNodeConfig? WindowsNodeConfig { get; set; }

    /// <summary>Metadata configuration to expose to workloads on the node pool. Structure is documented below.</summary>
    [JsonPropertyName("workloadMetadataConfig")]
    public V1beta1ClusterSpecInitProviderNodeConfigWorkloadMetadataConfig? WorkloadMetadataConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Linux system configuration for the cluster's automatically provisioned node pools. Only cgroup_mode field is supported in node_pool_auto_config. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodePoolAutoConfigLinuxNodeConfig
{
    /// <summary>Possible cgroup modes that can be used. Accepted values are:</summary>
    [JsonPropertyName("cgroupMode")]
    public string? CgroupMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The network tag config for the cluster's automatically provisioned node pools. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodePoolAutoConfigNetworkTags
{
    /// <summary>The list of instance tags applied to all nodes. Tags are used to identify valid sources or targets for network firewalls.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Kubelet configuration for Autopilot clusters. Currently, only insecure_kubelet_readonly_port_enabled is supported here. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodePoolAutoConfigNodeKubeletConfig
{
    /// <summary>only port is enabled for newly created node pools in the cluster. It is strongly recommended to set this to FALSE. Possible values: TRUE, FALSE.</summary>
    [JsonPropertyName("insecureKubeletReadonlyPortEnabled")]
    public string? InsecureKubeletReadonlyPortEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Node pool configs that apply to auto-provisioned node pools in autopilot clusters and node auto-provisioning-enabled clusters. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodePoolAutoConfig
{
    /// <summary>Linux system configuration for the cluster's automatically provisioned node pools. Only cgroup_mode field is supported in node_pool_auto_config. Structure is documented below.</summary>
    [JsonPropertyName("linuxNodeConfig")]
    public V1beta1ClusterSpecInitProviderNodePoolAutoConfigLinuxNodeConfig? LinuxNodeConfig { get; set; }

    /// <summary>The network tag config for the cluster's automatically provisioned node pools. Structure is documented below.</summary>
    [JsonPropertyName("networkTags")]
    public V1beta1ClusterSpecInitProviderNodePoolAutoConfigNetworkTags? NetworkTags { get; set; }

    /// <summary>Kubelet configuration for Autopilot clusters. Currently, only insecure_kubelet_readonly_port_enabled is supported here. Structure is documented below.</summary>
    [JsonPropertyName("nodeKubeletConfig")]
    public V1beta1ClusterSpecInitProviderNodePoolAutoConfigNodeKubeletConfig? NodeKubeletConfig { get; set; }

    /// <summary>A map of resource manager tag keys and values to be attached to the nodes for managing Compute Engine firewalls using Network Firewall Policies. Tags must be according to specifications found here. A maximum of 5 tag key-value pairs can be specified. Existing tags will be replaced with new values. Tags must be in one of the following formats ([KEY]=[VALUE]) 1. tagKeys/{tag_key_id}=tagValues/{tag_value_id} 2. {org_id}/{tag_key_name}={tag_value_name} 3. {project_id}/{tag_key_name}={tag_value_name}.</summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodePoolDefaultsNodeConfigDefaultsContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig
{
    /// <summary></summary>
    [JsonPropertyName("secretUri")]
    public string? SecretUri { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodePoolDefaultsNodeConfigDefaultsContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig
{
    /// <summary></summary>
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpSecretManagerCertificateConfig")]
    public V1beta1ClusterSpecInitProviderNodePoolDefaultsNodeConfigDefaultsContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig? GcpSecretManagerCertificateConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for private container registries. There are two fields in this config:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodePoolDefaultsNodeConfigDefaultsContainerdConfigPrivateRegistryAccessConfig
{
    /// <summary>List of configuration objects for CA and domains. Each object identifies a certificate and its assigned domains. See how to configure for private container registries for more detail. Example:</summary>
    [JsonPropertyName("certificateAuthorityDomainConfig")]
    public IList<V1beta1ClusterSpecInitProviderNodePoolDefaultsNodeConfigDefaultsContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig>? CertificateAuthorityDomainConfig { get; set; }

    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters to customize containerd runtime. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodePoolDefaultsNodeConfigDefaultsContainerdConfig
{
    /// <summary>Configuration for private container registries. There are two fields in this config:</summary>
    [JsonPropertyName("privateRegistryAccessConfig")]
    public V1beta1ClusterSpecInitProviderNodePoolDefaultsNodeConfigDefaultsContainerdConfigPrivateRegistryAccessConfig? PrivateRegistryAccessConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The default Google Container Filesystem (GCFS) configuration at the cluster level. e.g. enable image streaming across all the node pools within the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodePoolDefaultsNodeConfigDefaultsGcfsConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Subset of NodeConfig message that has defaults.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodePoolDefaultsNodeConfigDefaults
{
    /// <summary>Parameters to customize containerd runtime. Structure is documented below.</summary>
    [JsonPropertyName("containerdConfig")]
    public V1beta1ClusterSpecInitProviderNodePoolDefaultsNodeConfigDefaultsContainerdConfig? ContainerdConfig { get; set; }

    /// <summary>The default Google Container Filesystem (GCFS) configuration at the cluster level. e.g. enable image streaming across all the node pools within the cluster. Structure is documented below.</summary>
    [JsonPropertyName("gcfsConfig")]
    public V1beta1ClusterSpecInitProviderNodePoolDefaultsNodeConfigDefaultsGcfsConfig? GcfsConfig { get; set; }

    /// <summary>only port is enabled for newly created node pools in the cluster. It is strongly recommended to set this to FALSE. Possible values: TRUE, FALSE.</summary>
    [JsonPropertyName("insecureKubeletReadonlyPortEnabled")]
    public string? InsecureKubeletReadonlyPortEnabled { get; set; }

    /// <summary>The type of logging agent that is deployed by default for newly created node pools in the cluster. Valid values include DEFAULT and MAX_THROUGHPUT. See Increasing logging agent throughput for more information.</summary>
    [JsonPropertyName("loggingVariant")]
    public string? LoggingVariant { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Default NodePool settings for the entire cluster. These settings are overridden if specified on the specific NodePool object. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNodePoolDefaults
{
    /// <summary>Subset of NodeConfig message that has defaults.</summary>
    [JsonPropertyName("nodeConfigDefaults")]
    public V1beta1ClusterSpecInitProviderNodePoolDefaultsNodeConfigDefaults? NodeConfigDefaults { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Choose what type of notifications you want to receive. If no filters are applied, you'll receive all notification types. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNotificationConfigPubsubFilter
{
    /// <summary>Can be used to filter what notifications are sent. Accepted values are UPGRADE_AVAILABLE_EVENT, UPGRADE_EVENT, SECURITY_BULLETIN_EVENT and UPGRADE_INFO_EVENT. See Filtering notifications for more details.</summary>
    [JsonPropertyName("eventType")]
    public IList<string>? EventType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The pubsub config for the cluster's upgrade notifications.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNotificationConfigPubsub
{
    /// <summary>Whether or not the notification config is enabled</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Choose what type of notifications you want to receive. If no filters are applied, you'll receive all notification types. Structure is documented below.</summary>
    [JsonPropertyName("filter")]
    public V1beta1ClusterSpecInitProviderNotificationConfigPubsubFilter? Filter { get; set; }

    /// <summary>The pubsub topic to push upgrade notifications to. Must be in the same project as the cluster. Must be in the format: projects/{project}/topics/{topic}.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the cluster upgrade notifications feature. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderNotificationConfig
{
    /// <summary>The pubsub config for the cluster's upgrade notifications.</summary>
    [JsonPropertyName("pubsub")]
    public V1beta1ClusterSpecInitProviderNotificationConfigPubsub? Pubsub { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderPodAutoscaling
{
    /// <summary>Enable the Horizontal Pod Autoscaling profile for this cluster. Acceptable values are:</summary>
    [JsonPropertyName("hpaProfile")]
    public string? HpaProfile { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Controls cluster master global access settings. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderPrivateClusterConfigMasterGlobalAccessConfig
{
    /// <summary>Whether the cluster master is accessible globally or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderPrivateClusterConfigPrivateEndpointSubnetworkRefPolicy
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
/// <summary>Reference to a Subnetwork in compute to populate privateEndpointSubnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderPrivateClusterConfigPrivateEndpointSubnetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderPrivateClusterConfigPrivateEndpointSubnetworkRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderPrivateClusterConfigPrivateEndpointSubnetworkSelectorPolicy
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
/// <summary>Selector for a Subnetwork in compute to populate privateEndpointSubnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderPrivateClusterConfigPrivateEndpointSubnetworkSelector
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
    public V1beta1ClusterSpecInitProviderPrivateClusterConfigPrivateEndpointSubnetworkSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for private clusters, clusters with private nodes. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderPrivateClusterConfig
{
    /// <summary>When true, the cluster's private endpoint is used as the cluster endpoint and access through the public endpoint is disabled. When false, either endpoint can be used. This field only applies to private clusters, when enable_private_nodes is true.</summary>
    [JsonPropertyName("enablePrivateEndpoint")]
    public bool? EnablePrivateEndpoint { get; set; }

    /// <summary>Enables the private cluster feature, creating a private endpoint on the cluster. In a private cluster, nodes only have RFC 1918 private addresses and communicate with the master's private endpoint via private networking.</summary>
    [JsonPropertyName("enablePrivateNodes")]
    public bool? EnablePrivateNodes { get; set; }

    /// <summary>Controls cluster master global access settings. Structure is documented below.</summary>
    [JsonPropertyName("masterGlobalAccessConfig")]
    public V1beta1ClusterSpecInitProviderPrivateClusterConfigMasterGlobalAccessConfig? MasterGlobalAccessConfig { get; set; }

    /// <summary>The IP range in CIDR notation to use for the hosted master network. This range will be used for assigning private IP addresses to the cluster master(s) and the ILB VIP. This range must not overlap with any other ranges in use within the cluster's network, and it must be a /28 subnet. See Private Cluster Limitations for more details. This field only applies to private clusters, when enable_private_nodes is true.</summary>
    [JsonPropertyName("masterIpv4CidrBlock")]
    public string? MasterIpv4CidrBlock { get; set; }

    /// <summary>Subnetwork in cluster's network where master's endpoint will be provisioned.</summary>
    [JsonPropertyName("privateEndpointSubnetwork")]
    public string? PrivateEndpointSubnetwork { get; set; }

    /// <summary>Reference to a Subnetwork in compute to populate privateEndpointSubnetwork.</summary>
    [JsonPropertyName("privateEndpointSubnetworkRef")]
    public V1beta1ClusterSpecInitProviderPrivateClusterConfigPrivateEndpointSubnetworkRef? PrivateEndpointSubnetworkRef { get; set; }

    /// <summary>Selector for a Subnetwork in compute to populate privateEndpointSubnetwork.</summary>
    [JsonPropertyName("privateEndpointSubnetworkSelector")]
    public V1beta1ClusterSpecInitProviderPrivateClusterConfigPrivateEndpointSubnetworkSelector? PrivateEndpointSubnetworkSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration options for the Release channel feature, which provide more control over automatic upgrades of your GKE clusters. When updating this field, GKE imposes specific version requirements. See Selecting a new release channel for more details; the google_container_engine_versions datasource can provide the default version for a channel. Instead, use the "UNSPECIFIED" channel. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderReleaseChannel
{
    /// <summary>The selected release channel. Accepted values are:</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters for using BigQuery as the destination of resource usage export.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderResourceUsageExportConfigBigqueryDestination
{
    /// <summary>The ID of a BigQuery Dataset. For Example:</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the ResourceUsageExportConfig feature. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderResourceUsageExportConfig
{
    /// <summary>Parameters for using BigQuery as the destination of resource usage export.</summary>
    [JsonPropertyName("bigqueryDestination")]
    public V1beta1ClusterSpecInitProviderResourceUsageExportConfigBigqueryDestination? BigqueryDestination { get; set; }

    /// <summary>Whether to enable network egress metering for this cluster. If enabled, a daemonset will be created in the cluster to meter network egress traffic.</summary>
    [JsonPropertyName("enableNetworkEgressMetering")]
    public bool? EnableNetworkEgressMetering { get; set; }

    /// <summary>Whether to enable resource consumption metering on this cluster. When enabled, a table will be created in the resource export BigQuery dataset to store resource consumption data. The resulting table can be joined with the resource usage table or with BigQuery billing export. Defaults to true.</summary>
    [JsonPropertyName("enableResourceConsumptionMetering")]
    public bool? EnableResourceConsumptionMetering { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the SecretManagerConfig feature. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderSecretManagerConfig
{
    /// <summary>Enable the Secret Manager add-on for this cluster.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Enable/Disable Security Posture API features for the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderSecurityPostureConfig
{
    /// <summary>Sets the mode of the Kubernetes security posture API's off-cluster features. Available options include DISABLED, BASIC, and ENTERPRISE.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Sets the mode of the Kubernetes security posture API's workload vulnerability scanning. Available options include VULNERABILITY_DISABLED, VULNERABILITY_BASIC and VULNERABILITY_ENTERPRISE.</summary>
    [JsonPropertyName("vulnerabilityMode")]
    public string? VulnerabilityMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderServiceExternalIpsConfig
{
    /// <summary>Controls whether external ips specified by a service will be allowed. It is enabled by default.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderSubnetworkRefPolicy
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
public partial class V1beta1ClusterSpecInitProviderSubnetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ClusterSpecInitProviderSubnetworkRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderSubnetworkSelectorPolicy
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
public partial class V1beta1ClusterSpecInitProviderSubnetworkSelector
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
    public V1beta1ClusterSpecInitProviderSubnetworkSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The custom keys configuration of the cluster Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderUserManagedKeysConfig
{
    /// <summary>The Certificate Authority Service caPool to use for the aggreation CA in this cluster.</summary>
    [JsonPropertyName("aggregationCa")]
    public string? AggregationCa { get; set; }

    /// <summary>The Certificate Authority Service caPool to use for the cluster CA in this cluster.</summary>
    [JsonPropertyName("clusterCa")]
    public string? ClusterCa { get; set; }

    /// <summary>The Cloud KMS cryptoKey to use for Confidential Hyperdisk on the control plane nodes.</summary>
    [JsonPropertyName("controlPlaneDiskEncryptionKey")]
    public string? ControlPlaneDiskEncryptionKey { get; set; }

    /// <summary>The Certificate Authority Service caPool to use for the etcd API CA in this cluster.</summary>
    [JsonPropertyName("etcdApiCa")]
    public string? EtcdApiCa { get; set; }

    /// <summary>The Certificate Authority Service caPool to use for the etcd peer CA in this cluster.</summary>
    [JsonPropertyName("etcdPeerCa")]
    public string? EtcdPeerCa { get; set; }

    /// <summary>Resource path of the Cloud KMS cryptoKey to use for encryption of internal etcd backups.</summary>
    [JsonPropertyName("gkeopsEtcdBackupEncryptionKey")]
    public string? GkeopsEtcdBackupEncryptionKey { get; set; }

    /// <summary>The Cloud KMS cryptoKeyVersions to use for signing service account JWTs issued by this cluster.</summary>
    [JsonPropertyName("serviceAccountSigningKeys")]
    public IList<string>? ServiceAccountSigningKeys { get; set; }

    /// <summary>The Cloud KMS cryptoKeyVersions to use for verifying service account JWTs issued by this cluster.</summary>
    [JsonPropertyName("serviceAccountVerificationKeys")]
    public IList<string>? ServiceAccountVerificationKeys { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Vertical Pod Autoscaling automatically adjusts the resources of pods controlled by it. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderVerticalPodAutoscaling
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Workload Identity allows Kubernetes service accounts to act as a user-managed Google IAM Service Account. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProviderWorkloadIdentityConfig
{
    /// <summary>The workload pool to attach all Kubernetes service accounts to.</summary>
    [JsonPropertyName("workloadPool")]
    public string? WorkloadPool { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecInitProvider
{
    /// <summary>The configuration for addons supported by GKE. Structure is documented below.</summary>
    [JsonPropertyName("addonsConfig")]
    public V1beta1ClusterSpecInitProviderAddonsConfig? AddonsConfig { get; set; }

    /// <summary>Enable NET_ADMIN for the cluster. Defaults to false. This field should only be enabled for Autopilot clusters (enable_autopilot set to true).</summary>
    [JsonPropertyName("allowNetAdmin")]
    public bool? AllowNetAdmin { get; set; }

    /// <summary>Configuration for anonymous authentication restrictions. Structure is documented below.</summary>
    [JsonPropertyName("anonymousAuthenticationConfig")]
    public V1beta1ClusterSpecInitProviderAnonymousAuthenticationConfig? AnonymousAuthenticationConfig { get; set; }

    /// <summary>Configuration for the Google Groups for GKE feature. Structure is documented below.</summary>
    [JsonPropertyName("authenticatorGroupsConfig")]
    public V1beta1ClusterSpecInitProviderAuthenticatorGroupsConfig? AuthenticatorGroupsConfig { get; set; }

    /// <summary>Configuration options for the Binary Authorization feature. Structure is documented below.</summary>
    [JsonPropertyName("binaryAuthorization")]
    public V1beta1ClusterSpecInitProviderBinaryAuthorization? BinaryAuthorization { get; set; }

    /// <summary>Per-cluster configuration of Node Auto-Provisioning with Cluster Autoscaler to automatically adjust the size of the cluster and create/delete node pools based on the current needs of the cluster's workload. See the guide to using Node Auto-Provisioning for more details. Structure is documented below.</summary>
    [JsonPropertyName("clusterAutoscaling")]
    public V1beta1ClusterSpecInitProviderClusterAutoscaling? ClusterAutoscaling { get; set; }

    /// <summary>The IP address range of the Kubernetes pods in this cluster in CIDR notation (e.g. 10.96.0.0/14). Leave blank to have one automatically chosen or specify a /14 block in 10.0.0.0/8. This field will default a new cluster to routes-based, where ip_allocation_policy is not defined.</summary>
    [JsonPropertyName("clusterIpv4Cidr")]
    public string? ClusterIpv4Cidr { get; set; }

    /// <summary>Configuration for Confidential Nodes feature. Structure is documented below documented below.</summary>
    [JsonPropertyName("confidentialNodes")]
    public V1beta1ClusterSpecInitProviderConfidentialNodes? ConfidentialNodes { get; set; }

    /// <summary>Configuration for all of the cluster's control plane endpoints. Structure is documented below.</summary>
    [JsonPropertyName("controlPlaneEndpointsConfig")]
    public V1beta1ClusterSpecInitProviderControlPlaneEndpointsConfig? ControlPlaneEndpointsConfig { get; set; }

    /// <summary>Configuration for the Cost Allocation feature. Structure is documented below.</summary>
    [JsonPropertyName("costManagementConfig")]
    public V1beta1ClusterSpecInitProviderCostManagementConfig? CostManagementConfig { get; set; }

    /// <summary>Structure is documented below.</summary>
    [JsonPropertyName("databaseEncryption")]
    public V1beta1ClusterSpecInitProviderDatabaseEncryption? DatabaseEncryption { get; set; }

    /// <summary>The desired datapath provider for this cluster. This is set to LEGACY_DATAPATH by default, which uses the IPTables-based kube-proxy implementation. Set to ADVANCED_DATAPATH to enable Dataplane v2.</summary>
    [JsonPropertyName("datapathProvider")]
    public string? DatapathProvider { get; set; }

    /// <summary>The default maximum number of pods per node in this cluster. This doesn't work on "routes-based" clusters, clusters that don't have IP Aliasing enabled. See the official documentation for more information.</summary>
    [JsonPropertyName("defaultMaxPodsPerNode")]
    public double? DefaultMaxPodsPerNode { get; set; }

    /// <summary>GKE SNAT DefaultSnatStatus contains the desired state of whether default sNAT should be disabled on the cluster, API doc. Structure is documented below</summary>
    [JsonPropertyName("defaultSnatStatus")]
    public V1beta1ClusterSpecInitProviderDefaultSnatStatus? DefaultSnatStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>Description of the cluster.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Disable L4 load balancer VPC firewalls to enable firewall policies.</summary>
    [JsonPropertyName("disableL4LbFirewallReconciliation")]
    public bool? DisableL4LbFirewallReconciliation { get; set; }

    /// <summary>Configuration for Using Cloud DNS for GKE. Structure is documented below.</summary>
    [JsonPropertyName("dnsConfig")]
    public V1beta1ClusterSpecInitProviderDnsConfig? DnsConfig { get; set; }

    /// <summary>Enable Autopilot for this cluster. Defaults to false. Note that when this option is enabled, certain features of Standard GKE are not available. See the official documentation for available features.</summary>
    [JsonPropertyName("enableAutopilot")]
    public bool? EnableAutopilot { get; set; }

    /// <summary>Whether CiliumClusterWideNetworkPolicy is enabled on this cluster. Defaults to false.</summary>
    [JsonPropertyName("enableCiliumClusterwideNetworkPolicy")]
    public bool? EnableCiliumClusterwideNetworkPolicy { get; set; }

    /// <summary>Whether FQDN Network Policy is enabled on this cluster. Users who enable this feature for existing Standard clusters must restart the GKE Dataplane V2 anetd DaemonSet after enabling it. See the Enable FQDN Network Policy in an existing cluster for more information.</summary>
    [JsonPropertyName("enableFqdnNetworkPolicy")]
    public bool? EnableFqdnNetworkPolicy { get; set; }

    /// <summary>Whether Intra-node visibility is enabled for this cluster. This makes same node pod to pod traffic visible for VPC network.</summary>
    [JsonPropertyName("enableIntranodeVisibility")]
    public bool? EnableIntranodeVisibility { get; set; }

    /// <summary>Configuration for Kubernetes Beta APIs. Structure is documented below.</summary>
    [JsonPropertyName("enableK8SBetaApis")]
    public V1beta1ClusterSpecInitProviderEnableK8SBetaApis? EnableK8SBetaApis { get; set; }

    /// <summary>Whether to enable Kubernetes Alpha features for this cluster. Note that when this option is enabled, the cluster cannot be upgraded and will be automatically deleted after 30 days.</summary>
    [JsonPropertyName("enableKubernetesAlpha")]
    public bool? EnableKubernetesAlpha { get; set; }

    /// <summary>Whether L4ILB Subsetting is enabled for this cluster.</summary>
    [JsonPropertyName("enableL4IlbSubsetting")]
    public bool? EnableL4IlbSubsetting { get; set; }

    /// <summary>Whether the ABAC authorizer is enabled for this cluster. When enabled, identities in the system, including service accounts, nodes, and controllers, will have statically granted permissions beyond those provided by the RBAC configuration or IAM. Defaults to false</summary>
    [JsonPropertyName("enableLegacyAbac")]
    public bool? EnableLegacyAbac { get; set; }

    /// <summary>Whether multi-networking is enabled for this cluster.</summary>
    [JsonPropertyName("enableMultiNetworking")]
    public bool? EnableMultiNetworking { get; set; }

    /// <summary>Enable Shielded Nodes features on all nodes in this cluster.  Defaults to true.</summary>
    [JsonPropertyName("enableShieldedNodes")]
    public bool? EnableShieldedNodes { get; set; }

    /// <summary>Whether to enable Cloud TPU resources in this cluster. See the official documentation.</summary>
    [JsonPropertyName("enableTpu")]
    public bool? EnableTpu { get; set; }

    /// <summary>Configuration for [Enterprise edition].(https://cloud.google.com/kubernetes-engine/enterprise/docs/concepts/gke-editions). Structure is documented below.</summary>
    [JsonPropertyName("enterpriseConfig")]
    public V1beta1ClusterSpecInitProviderEnterpriseConfig? EnterpriseConfig { get; set; }

    /// <summary>Fleet configuration for the cluster. Structure is documented below.</summary>
    [JsonPropertyName("fleet")]
    public V1beta1ClusterSpecInitProviderFleet? Fleet { get; set; }

    /// <summary>Configuration for GKE Gateway API controller. Structure is documented below.</summary>
    [JsonPropertyName("gatewayApiConfig")]
    public V1beta1ClusterSpecInitProviderGatewayApiConfig? GatewayApiConfig { get; set; }

    /// <summary>Configuration options for the auto-upgrade patch type feature, which provide more control over the speed of automatic upgrades of your GKE clusters. Structure is documented below.</summary>
    [JsonPropertyName("gkeAutoUpgradeConfig")]
    public V1beta1ClusterSpecInitProviderGkeAutoUpgradeConfig? GkeAutoUpgradeConfig { get; set; }

    /// <summary>. Structure is documented below.</summary>
    [JsonPropertyName("identityServiceConfig")]
    public V1beta1ClusterSpecInitProviderIdentityServiceConfig? IdentityServiceConfig { get; set; }

    /// <summary>Defines the config of in-transit encryption. Valid values are IN_TRANSIT_ENCRYPTION_DISABLED and IN_TRANSIT_ENCRYPTION_INTER_NODE_TRANSPARENT.</summary>
    [JsonPropertyName("inTransitEncryptionConfig")]
    public string? InTransitEncryptionConfig { get; set; }

    /// <summary>The number of nodes to create in this cluster's default node pool. In regional or multi-zonal clusters, this is the number of nodes per zone. Must be set if node_pool is not set. If you're using google_container_node_pool objects with no default node pool, you'll need to set this to a value of at least 1, alongside setting remove_default_node_pool to true.</summary>
    [JsonPropertyName("initialNodeCount")]
    public double? InitialNodeCount { get; set; }

    /// <summary>Configuration of cluster IP allocation for VPC-native clusters. If this block is unset during creation, it will be set by the GKE backend. Structure is documented below.</summary>
    [JsonPropertyName("ipAllocationPolicy")]
    public V1beta1ClusterSpecInitProviderIpAllocationPolicy? IpAllocationPolicy { get; set; }

    /// <summary>Logging configuration for the cluster. Structure is documented below.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta1ClusterSpecInitProviderLoggingConfig? LoggingConfig { get; set; }

    /// <summary>The logging service that the cluster should write logs to. Available options include logging.googleapis.com(Legacy Stackdriver), logging.googleapis.com/kubernetes(Stackdriver Kubernetes Engine Logging), and none. Defaults to logging.googleapis.com/kubernetes</summary>
    [JsonPropertyName("loggingService")]
    public string? LoggingService { get; set; }

    /// <summary>The maintenance policy to use for the cluster. Structure is documented below.</summary>
    [JsonPropertyName("maintenancePolicy")]
    public V1beta1ClusterSpecInitProviderMaintenancePolicy? MaintenancePolicy { get; set; }

    /// <summary>The authentication information for accessing the Kubernetes master. Some values in this block are only returned by the API if your service account has permission to get credentials for your GKE cluster. If you see an unexpected diff unsetting your client cert, ensure you have the container.clusters.getCredentials permission. Structure is documented below.</summary>
    [JsonPropertyName("masterAuth")]
    public V1beta1ClusterSpecInitProviderMasterAuth? MasterAuth { get; set; }

    /// <summary>The desired configuration options for master authorized networks. Omit the nested cidr_blocks attribute to disallow external access (except the cluster node IPs, which GKE automatically whitelists). Structure is documented below.</summary>
    [JsonPropertyName("masterAuthorizedNetworksConfig")]
    public V1beta1ClusterSpecInitProviderMasterAuthorizedNetworksConfig? MasterAuthorizedNetworksConfig { get; set; }

    /// <summary>Structure is documented below.</summary>
    [JsonPropertyName("meshCertificates")]
    public V1beta1ClusterSpecInitProviderMeshCertificates? MeshCertificates { get; set; }

    /// <summary>The minimum version of the master. GKE will auto-update the master to new versions, so this does not guarantee the current master version--use the read-only master_version field to obtain that. If unset, the cluster's version will be set by GKE to the version of the most recent official release (which is not necessarily the latest version). If you intend to specify versions manually, the docs describe the various acceptable formats for this field.</summary>
    [JsonPropertyName("minMasterVersion")]
    public string? MinMasterVersion { get; set; }

    /// <summary>Monitoring configuration for the cluster. Structure is documented below.</summary>
    [JsonPropertyName("monitoringConfig")]
    public V1beta1ClusterSpecInitProviderMonitoringConfig? MonitoringConfig { get; set; }

    /// <summary>The monitoring service that the cluster should write metrics to. Automatically send metrics from pods in the cluster to the Google Cloud Monitoring API. VM metrics will be collected by Google Compute Engine regardless of this setting Available options include monitoring.googleapis.com(Legacy Stackdriver), monitoring.googleapis.com/kubernetes(Stackdriver Kubernetes Engine Monitoring), and none. Defaults to monitoring.googleapis.com/kubernetes</summary>
    [JsonPropertyName("monitoringService")]
    public string? MonitoringService { get; set; }

    /// <summary>The name or self_link of the Google Compute Engine network to which the cluster is connected. For Shared VPC, set this to the self link of the shared network.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Network bandwidth tier configuration. Structure is documented below.</summary>
    [JsonPropertyName("networkPerformanceConfig")]
    public V1beta1ClusterSpecInitProviderNetworkPerformanceConfig? NetworkPerformanceConfig { get; set; }

    /// <summary>Configuration options for the NetworkPolicy feature. Structure is documented below.</summary>
    [JsonPropertyName("networkPolicy")]
    public V1beta1ClusterSpecInitProviderNetworkPolicy? NetworkPolicy { get; set; }

    /// <summary>Reference to a Network in compute to populate network.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1ClusterSpecInitProviderNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate network.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta1ClusterSpecInitProviderNetworkSelector? NetworkSelector { get; set; }

    /// <summary>Determines whether alias IPs or routes will be used for pod IPs in the cluster. Options are VPC_NATIVE or ROUTES. VPC_NATIVE enables IP aliasing. Newly created clusters will default to VPC_NATIVE.</summary>
    [JsonPropertyName("networkingMode")]
    public string? NetworkingMode { get; set; }

    /// <summary>Parameters used in creating the default node pool. Structure is documented below.</summary>
    [JsonPropertyName("nodeConfig")]
    public V1beta1ClusterSpecInitProviderNodeConfig? NodeConfig { get; set; }

    /// <summary>The list of zones in which the cluster's nodes are located. Nodes must be in the region of their regional cluster or in the same region as their cluster's zone for zonal clusters. If this is specified for a zonal cluster, omit the cluster's zone.</summary>
    [JsonPropertyName("nodeLocations")]
    public IList<string>? NodeLocations { get; set; }

    /// <summary>Node pool configs that apply to auto-provisioned node pools in autopilot clusters and node auto-provisioning-enabled clusters. Structure is documented below.</summary>
    [JsonPropertyName("nodePoolAutoConfig")]
    public V1beta1ClusterSpecInitProviderNodePoolAutoConfig? NodePoolAutoConfig { get; set; }

    /// <summary>Default NodePool settings for the entire cluster. These settings are overridden if specified on the specific NodePool object. Structure is documented below.</summary>
    [JsonPropertyName("nodePoolDefaults")]
    public V1beta1ClusterSpecInitProviderNodePoolDefaults? NodePoolDefaults { get; set; }

    /// <summary>The Kubernetes version on the nodes. Must either be unset or set to the same value as min_master_version on create. Defaults to the default version set by GKE which is not necessarily the latest version. This only affects nodes in the default node pool. To update nodes in other node pools, use the version attribute on the node pool.</summary>
    [JsonPropertyName("nodeVersion")]
    public string? NodeVersion { get; set; }

    /// <summary>Configuration for the cluster upgrade notifications feature. Structure is documented below.</summary>
    [JsonPropertyName("notificationConfig")]
    public V1beta1ClusterSpecInitProviderNotificationConfig? NotificationConfig { get; set; }

    /// <summary>Configuration for the Structure is documented below.</summary>
    [JsonPropertyName("podAutoscaling")]
    public V1beta1ClusterSpecInitProviderPodAutoscaling? PodAutoscaling { get; set; }

    /// <summary>Configuration for private clusters, clusters with private nodes. Structure is documented below.</summary>
    [JsonPropertyName("privateClusterConfig")]
    public V1beta1ClusterSpecInitProviderPrivateClusterConfig? PrivateClusterConfig { get; set; }

    /// <summary>The desired state of IPv6 connectivity to Google Services. By default, no private IPv6 access to or from Google Services (all access will be via IPv4).</summary>
    [JsonPropertyName("privateIpv6GoogleAccess")]
    public string? PrivateIpv6GoogleAccess { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Configuration options for the Release channel feature, which provide more control over automatic upgrades of your GKE clusters. When updating this field, GKE imposes specific version requirements. See Selecting a new release channel for more details; the google_container_engine_versions datasource can provide the default version for a channel. Instead, use the "UNSPECIFIED" channel. Structure is documented below.</summary>
    [JsonPropertyName("releaseChannel")]
    public V1beta1ClusterSpecInitProviderReleaseChannel? ReleaseChannel { get; set; }

    /// <summary>If true, deletes the default node pool upon cluster creation. If you're using google_container_node_pool resources with no default node pool, this should be set to true, alongside setting initial_node_count to at least 1.</summary>
    [JsonPropertyName("removeDefaultNodePool")]
    public bool? RemoveDefaultNodePool { get; set; }

    /// <summary>The GCE resource labels (a map of key/value pairs) to be applied to the cluster.</summary>
    [JsonPropertyName("resourceLabels")]
    public IDictionary<string, string>? ResourceLabels { get; set; }

    /// <summary>Configuration for the ResourceUsageExportConfig feature. Structure is documented below.</summary>
    [JsonPropertyName("resourceUsageExportConfig")]
    public V1beta1ClusterSpecInitProviderResourceUsageExportConfig? ResourceUsageExportConfig { get; set; }

    /// <summary>Configuration for the SecretManagerConfig feature. Structure is documented below.</summary>
    [JsonPropertyName("secretManagerConfig")]
    public V1beta1ClusterSpecInitProviderSecretManagerConfig? SecretManagerConfig { get; set; }

    /// <summary>Enable/Disable Security Posture API features for the cluster. Structure is documented below.</summary>
    [JsonPropertyName("securityPostureConfig")]
    public V1beta1ClusterSpecInitProviderSecurityPostureConfig? SecurityPostureConfig { get; set; }

    /// <summary>Structure is documented below.</summary>
    [JsonPropertyName("serviceExternalIpsConfig")]
    public V1beta1ClusterSpecInitProviderServiceExternalIpsConfig? ServiceExternalIpsConfig { get; set; }

    /// <summary>The name or self_link of the Google Compute Engine subnetwork in which the cluster's instances are launched.</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta1ClusterSpecInitProviderSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkSelector")]
    public V1beta1ClusterSpecInitProviderSubnetworkSelector? SubnetworkSelector { get; set; }

    /// <summary>The custom keys configuration of the cluster Structure is documented below.</summary>
    [JsonPropertyName("userManagedKeysConfig")]
    public V1beta1ClusterSpecInitProviderUserManagedKeysConfig? UserManagedKeysConfig { get; set; }

    /// <summary>Vertical Pod Autoscaling automatically adjusts the resources of pods controlled by it. Structure is documented below.</summary>
    [JsonPropertyName("verticalPodAutoscaling")]
    public V1beta1ClusterSpecInitProviderVerticalPodAutoscaling? VerticalPodAutoscaling { get; set; }

    /// <summary>Workload Identity allows Kubernetes service accounts to act as a user-managed Google IAM Service Account. Structure is documented below.</summary>
    [JsonPropertyName("workloadIdentityConfig")]
    public V1beta1ClusterSpecInitProviderWorkloadIdentityConfig? WorkloadIdentityConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpecProviderConfigRef
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
public partial class V1beta1ClusterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ClusterSpec defines the desired state of Cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ClusterSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ClusterSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
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
/// <summary>. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderAddonsConfigCloudrunConfig
{
    /// <summary>The status of the Istio addon, which makes it easy to set up Istio for services in a cluster. It is disabled by default. Set disabled = false to enable.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>The load balancer type of CloudRun ingress service. It is external load balancer by default. Set load_balancer_type=LOAD_BALANCER_TYPE_INTERNAL to configure it as internal load balancer.</summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>. The status of the ConfigConnector addon. It is disabled by default; Set enabled = true to enable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderAddonsConfigConfigConnectorConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>. The status of the NodeLocal DNSCache addon. It is disabled by default. Set enabled = true to enable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderAddonsConfigDnsCacheConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>. Whether this cluster should enable the Google Compute Engine Persistent Disk Container Storage Interface (CSI) Driver. Set enabled = true to enable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderAddonsConfigGcePersistentDiskCsiDriverConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The status of the Filestore CSI driver addon, which allows the usage of filestore instance as volumes. It is disabled by default; set enabled = true to enable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderAddonsConfigGcpFilestoreCsiDriverConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The status of the GCSFuse CSI driver addon, which allows the usage of a gcs bucket as volumes. It is disabled by default for Standard clusters; set enabled = true to enable. It is enabled by default for Autopilot clusters with version 1.24 or later; set enabled = true to enable it explicitly. See Enable the Cloud Storage FUSE CSI driver for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderAddonsConfigGcsFuseCsiDriverConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>. The status of the Backup for GKE agent addon. It is disabled by default; Set enabled = true to enable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderAddonsConfigGkeBackupAgentConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The status of the Horizontal Pod Autoscaling addon, which increases or decreases the number of replica pods a replication controller has based on the resource usage of the existing pods. It is enabled by default; set disabled = true to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderAddonsConfigHorizontalPodAutoscaling
{
    /// <summary>The status of the Istio addon, which makes it easy to set up Istio for services in a cluster. It is disabled by default. Set disabled = false to enable.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The status of the HTTP (L7) load balancing controller addon, which makes it easy to set up HTTP load balancers for services in a cluster. It is enabled by default; set disabled = true to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderAddonsConfigHttpLoadBalancing
{
    /// <summary>The status of the Istio addon, which makes it easy to set up Istio for services in a cluster. It is disabled by default. Set disabled = false to enable.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Whether we should enable the network policy addon for the master.  This must be enabled in order to enable network policy for the nodes. To enable this, you must also define a network_policy block, otherwise nothing will happen. It can only be disabled if the nodes already do not have network policies enabled. Defaults to disabled; set disabled = false to enable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderAddonsConfigNetworkPolicyConfig
{
    /// <summary>The status of the Istio addon, which makes it easy to set up Istio for services in a cluster. It is disabled by default. Set disabled = false to enable.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The status of the Parallelstore CSI driver addon, which allows the usage of a Parallelstore instances as volumes. It is disabled by default for Standard clusters; set enabled = true to enable. It is enabled by default for Autopilot clusters with version 1.29 or later; set enabled = true to enable it explicitly. See Enable the Parallelstore CSI driver for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderAddonsConfigParallelstoreCsiDriverConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Logging configuration for the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderAddonsConfigRayOperatorConfigRayClusterLoggingConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Monitoring configuration for the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderAddonsConfigRayOperatorConfigRayClusterMonitoringConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderAddonsConfigRayOperatorConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Logging configuration for the cluster. Structure is documented below.</summary>
    [JsonPropertyName("rayClusterLoggingConfig")]
    public V1beta1ClusterStatusAtProviderAddonsConfigRayOperatorConfigRayClusterLoggingConfig? RayClusterLoggingConfig { get; set; }

    /// <summary>Monitoring configuration for the cluster. Structure is documented below.</summary>
    [JsonPropertyName("rayClusterMonitoringConfig")]
    public V1beta1ClusterStatusAtProviderAddonsConfigRayOperatorConfigRayClusterMonitoringConfig? RayClusterMonitoringConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>. The status of the Stateful HA addon, which provides automatic configurable failover for stateful applications. It is disabled by default for Standard clusters. Set enabled = true to enable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderAddonsConfigStatefulHaConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The configuration for addons supported by GKE. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderAddonsConfig
{
    /// <summary>. Structure is documented below.</summary>
    [JsonPropertyName("cloudrunConfig")]
    public V1beta1ClusterStatusAtProviderAddonsConfigCloudrunConfig? CloudrunConfig { get; set; }

    /// <summary>. The status of the ConfigConnector addon. It is disabled by default; Set enabled = true to enable.</summary>
    [JsonPropertyName("configConnectorConfig")]
    public V1beta1ClusterStatusAtProviderAddonsConfigConfigConnectorConfig? ConfigConnectorConfig { get; set; }

    /// <summary>. The status of the NodeLocal DNSCache addon. It is disabled by default. Set enabled = true to enable.</summary>
    [JsonPropertyName("dnsCacheConfig")]
    public V1beta1ClusterStatusAtProviderAddonsConfigDnsCacheConfig? DnsCacheConfig { get; set; }

    /// <summary>. Whether this cluster should enable the Google Compute Engine Persistent Disk Container Storage Interface (CSI) Driver. Set enabled = true to enable.</summary>
    [JsonPropertyName("gcePersistentDiskCsiDriverConfig")]
    public V1beta1ClusterStatusAtProviderAddonsConfigGcePersistentDiskCsiDriverConfig? GcePersistentDiskCsiDriverConfig { get; set; }

    /// <summary>The status of the Filestore CSI driver addon, which allows the usage of filestore instance as volumes. It is disabled by default; set enabled = true to enable.</summary>
    [JsonPropertyName("gcpFilestoreCsiDriverConfig")]
    public V1beta1ClusterStatusAtProviderAddonsConfigGcpFilestoreCsiDriverConfig? GcpFilestoreCsiDriverConfig { get; set; }

    /// <summary>The status of the GCSFuse CSI driver addon, which allows the usage of a gcs bucket as volumes. It is disabled by default for Standard clusters; set enabled = true to enable. It is enabled by default for Autopilot clusters with version 1.24 or later; set enabled = true to enable it explicitly. See Enable the Cloud Storage FUSE CSI driver for more information.</summary>
    [JsonPropertyName("gcsFuseCsiDriverConfig")]
    public V1beta1ClusterStatusAtProviderAddonsConfigGcsFuseCsiDriverConfig? GcsFuseCsiDriverConfig { get; set; }

    /// <summary>. The status of the Backup for GKE agent addon. It is disabled by default; Set enabled = true to enable.</summary>
    [JsonPropertyName("gkeBackupAgentConfig")]
    public V1beta1ClusterStatusAtProviderAddonsConfigGkeBackupAgentConfig? GkeBackupAgentConfig { get; set; }

    /// <summary>The status of the Horizontal Pod Autoscaling addon, which increases or decreases the number of replica pods a replication controller has based on the resource usage of the existing pods. It is enabled by default; set disabled = true to disable.</summary>
    [JsonPropertyName("horizontalPodAutoscaling")]
    public V1beta1ClusterStatusAtProviderAddonsConfigHorizontalPodAutoscaling? HorizontalPodAutoscaling { get; set; }

    /// <summary>The status of the HTTP (L7) load balancing controller addon, which makes it easy to set up HTTP load balancers for services in a cluster. It is enabled by default; set disabled = true to disable.</summary>
    [JsonPropertyName("httpLoadBalancing")]
    public V1beta1ClusterStatusAtProviderAddonsConfigHttpLoadBalancing? HttpLoadBalancing { get; set; }

    /// <summary>Whether we should enable the network policy addon for the master.  This must be enabled in order to enable network policy for the nodes. To enable this, you must also define a network_policy block, otherwise nothing will happen. It can only be disabled if the nodes already do not have network policies enabled. Defaults to disabled; set disabled = false to enable.</summary>
    [JsonPropertyName("networkPolicyConfig")]
    public V1beta1ClusterStatusAtProviderAddonsConfigNetworkPolicyConfig? NetworkPolicyConfig { get; set; }

    /// <summary>The status of the Parallelstore CSI driver addon, which allows the usage of a Parallelstore instances as volumes. It is disabled by default for Standard clusters; set enabled = true to enable. It is enabled by default for Autopilot clusters with version 1.29 or later; set enabled = true to enable it explicitly. See Enable the Parallelstore CSI driver for more information.</summary>
    [JsonPropertyName("parallelstoreCsiDriverConfig")]
    public V1beta1ClusterStatusAtProviderAddonsConfigParallelstoreCsiDriverConfig? ParallelstoreCsiDriverConfig { get; set; }

    /// <summary>. The status of the Ray Operator addon. It is disabled by default. Set enabled = true to enable. The minimum cluster version to enable Ray is 1.30.0-gke.1747000.</summary>
    [JsonPropertyName("rayOperatorConfig")]
    public IList<V1beta1ClusterStatusAtProviderAddonsConfigRayOperatorConfig>? RayOperatorConfig { get; set; }

    /// <summary>. The status of the Stateful HA addon, which provides automatic configurable failover for stateful applications. It is disabled by default for Standard clusters. Set enabled = true to enable.</summary>
    [JsonPropertyName("statefulHaConfig")]
    public V1beta1ClusterStatusAtProviderAddonsConfigStatefulHaConfig? StatefulHaConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for anonymous authentication restrictions. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderAnonymousAuthenticationConfig
{
    /// <summary>Sets or removes authentication restrictions. Available options include LIMITED and ENABLED.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the Google Groups for GKE feature. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderAuthenticatorGroupsConfig
{
    /// <summary>The name of the RBAC security group for use with Google security groups in Kubernetes RBAC. Group name must be in format gke-security-groups@yourdomain.com.</summary>
    [JsonPropertyName("securityGroup")]
    public string? SecurityGroup { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration options for the Binary Authorization feature. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderBinaryAuthorization
{
    /// <summary>(DEPRECATED) Enable Binary Authorization for this cluster. Deprecated in favor of evaluation_mode.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Mode of operation for Binary Authorization policy evaluation. Valid values are DISABLED and PROJECT_SINGLETON_POLICY_ENFORCE.</summary>
    [JsonPropertyName("evaluationMode")]
    public string? EvaluationMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterAutoscalingAutoProvisioningDefaultsManagementUpgradeOptions
{
    /// <summary></summary>
    [JsonPropertyName("autoUpgradeStartTime")]
    public string? AutoUpgradeStartTime { get; set; }

    /// <summary>Description of the cluster.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }
}
#nullable disable

#nullable enable
/// <summary>NodeManagement configuration for this NodePool. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterAutoscalingAutoProvisioningDefaultsManagement
{
    /// <summary>Specifies whether the node auto-repair is enabled for the node pool. If enabled, the nodes in this node pool will be monitored and, if they fail health checks too many times, an automatic repair action will be triggered.</summary>
    [JsonPropertyName("autoRepair")]
    public bool? AutoRepair { get; set; }

    /// <summary>Specifies whether node auto-upgrade is enabled for the node pool. If enabled, node auto-upgrade helps keep the nodes in your node pool up to date with the latest release version of Kubernetes.</summary>
    [JsonPropertyName("autoUpgrade")]
    public bool? AutoUpgrade { get; set; }

    /// <summary>Specifies the Auto Upgrade knobs for the node pool.</summary>
    [JsonPropertyName("upgradeOptions")]
    public IList<V1beta1ClusterStatusAtProviderClusterAutoscalingAutoProvisioningDefaultsManagementUpgradeOptions>? UpgradeOptions { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Shielded Instance options. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterAutoscalingAutoProvisioningDefaultsShieldedInstanceConfig
{
    /// <summary>Defines if the instance has integrity monitoring enabled.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>Defines if the instance has Secure Boot enabled.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }
}
#nullable disable

#nullable enable
/// <summary>green upgrade. To be specified when strategy is set to BLUE_GREEN. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterAutoscalingAutoProvisioningDefaultsUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy
{
    /// <summary>Number of blue nodes to drain in a batch. Only one of the batch_percentage or batch_node_count can be specified.</summary>
    [JsonPropertyName("batchNodeCount")]
    public double? BatchNodeCount { get; set; }

    /// <summary>:  Percentage of the bool pool nodes to drain in a batch. The range of this field should be (0.0, 1.0). Only one of the batch_percentage or batch_node_count can be specified.</summary>
    [JsonPropertyName("batchPercentage")]
    public double? BatchPercentage { get; set; }

    /// <summary>Soak time after each batch gets drained. A duration in seconds with up to nine fractional digits, ending with 's'. Example: "3.5s".`.</summary>
    [JsonPropertyName("batchSoakDuration")]
    public string? BatchSoakDuration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Settings for blue-green upgrade strategy. To be specified when strategy is set to BLUE_GREEN. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterAutoscalingAutoProvisioningDefaultsUpgradeSettingsBlueGreenSettings
{
    /// <summary>Time needed after draining entire blue pool. After this period, blue pool will be cleaned up. A duration in seconds with up to nine fractional digits, ending with 's'. Example: "3.5s".</summary>
    [JsonPropertyName("nodePoolSoakDuration")]
    public string? NodePoolSoakDuration { get; set; }

    /// <summary>green upgrade. To be specified when strategy is set to BLUE_GREEN. Structure is documented below.</summary>
    [JsonPropertyName("standardRolloutPolicy")]
    public V1beta1ClusterStatusAtProviderClusterAutoscalingAutoProvisioningDefaultsUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy? StandardRolloutPolicy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies the upgrade settings for NAP created node pools. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterAutoscalingAutoProvisioningDefaultsUpgradeSettings
{
    /// <summary>Settings for blue-green upgrade strategy. To be specified when strategy is set to BLUE_GREEN. Structure is documented below.</summary>
    [JsonPropertyName("blueGreenSettings")]
    public V1beta1ClusterStatusAtProviderClusterAutoscalingAutoProvisioningDefaultsUpgradeSettingsBlueGreenSettings? BlueGreenSettings { get; set; }

    /// <summary>The maximum number of nodes that can be created beyond the current size of the node pool during the upgrade process. To be used when strategy is set to SURGE. Default is 0.</summary>
    [JsonPropertyName("maxSurge")]
    public double? MaxSurge { get; set; }

    /// <summary>The maximum number of nodes that can be simultaneously unavailable during the upgrade process. To be used when strategy is set to SURGE. Default is 0.</summary>
    [JsonPropertyName("maxUnavailable")]
    public double? MaxUnavailable { get; set; }

    /// <summary>Strategy used for node pool update. Strategy can only be one of BLUE_GREEN or SURGE. The default is value is SURGE.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Contains defaults for a node pool created by NAP. A subset of fields also apply to GKE Autopilot clusters. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterAutoscalingAutoProvisioningDefaults
{
    /// <summary>The Customer Managed Encryption Key used to encrypt the boot disk attached to each node in the node pool. This should be of the form projects/[KEY_PROJECT_ID]/locations/[LOCATION]/keyRings/[RING_NAME]/cryptoKeys/[KEY_NAME]. For more information about protecting resources with Cloud KMS Keys please see: https://cloud.google.com/compute/docs/disks/customer-managed-encryption</summary>
    [JsonPropertyName("bootDiskKmsKey")]
    public string? BootDiskKmsKey { get; set; }

    /// <summary>Size of the disk attached to each node, specified in GB. The smallest allowed disk size is 10GB. Defaults to 100</summary>
    [JsonPropertyName("diskSize")]
    public double? DiskSize { get; set; }

    /// <summary>Type of the disk attached to each node (e.g. 'pd-standard', 'pd-balanced' or 'pd-ssd'). If unspecified, the default disk type is 'pd-balanced'</summary>
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    /// <summary>The image type to use for this node. Note that changing the image type will delete and recreate all nodes in the node pool.</summary>
    [JsonPropertyName("imageType")]
    public string? ImageType { get; set; }

    /// <summary>NodeManagement configuration for this NodePool. Structure is documented below.</summary>
    [JsonPropertyName("management")]
    public V1beta1ClusterStatusAtProviderClusterAutoscalingAutoProvisioningDefaultsManagement? Management { get; set; }

    /// <summary>Minimum CPU platform to be used by this instance. The instance may be scheduled on the specified or newer CPU platform. Applicable values are the friendly names of CPU platforms, such as Intel Haswell. See the official documentation for more information.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The set of Google API scopes to be made available on all of the node VMs under the "default" service account. Use the "https://www.googleapis.com/auth/cloud-platform" scope to grant access to all APIs. It is recommended that you set service_account to a non-default service account and grant IAM roles to that service account for only the resources that it needs.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }

    /// <summary>The service account to be used by the Node VMs. If not specified, the "default" service account is used.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Shielded Instance options. Structure is documented below.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta1ClusterStatusAtProviderClusterAutoscalingAutoProvisioningDefaultsShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    /// <summary>Specifies the upgrade settings for NAP created node pools. Structure is documented below.</summary>
    [JsonPropertyName("upgradeSettings")]
    public V1beta1ClusterStatusAtProviderClusterAutoscalingAutoProvisioningDefaultsUpgradeSettings? UpgradeSettings { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterAutoscalingResourceLimits
{
    /// <summary>Maximum amount of the resource in the cluster.</summary>
    [JsonPropertyName("maximum")]
    public double? Maximum { get; set; }

    /// <summary>Minimum amount of the resource in the cluster.</summary>
    [JsonPropertyName("minimum")]
    public double? Minimum { get; set; }

    /// <summary>The type of the resource. For example, cpu and memory.  See the guide to using Node Auto-Provisioning for a list of types.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Per-cluster configuration of Node Auto-Provisioning with Cluster Autoscaler to automatically adjust the size of the cluster and create/delete node pools based on the current needs of the cluster's workload. See the guide to using Node Auto-Provisioning for more details. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderClusterAutoscaling
{
    /// <summary>Contains defaults for a node pool created by NAP. A subset of fields also apply to GKE Autopilot clusters. Structure is documented below.</summary>
    [JsonPropertyName("autoProvisioningDefaults")]
    public V1beta1ClusterStatusAtProviderClusterAutoscalingAutoProvisioningDefaults? AutoProvisioningDefaults { get; set; }

    /// <summary>The list of Google Compute Engine zones in which the NodePool's nodes can be created by NAP.</summary>
    [JsonPropertyName("autoProvisioningLocations")]
    public IList<string>? AutoProvisioningLocations { get; set; }

    /// <summary>Configuration options for the Autoscaling profile feature, which lets you choose whether the cluster autoscaler should optimize for resource utilization or resource availability when deciding to remove nodes from a cluster. Can be BALANCED or OPTIMIZE_UTILIZATION. Defaults to BALANCED.</summary>
    [JsonPropertyName("autoscalingProfile")]
    public string? AutoscalingProfile { get; set; }

    /// <summary>Whether node auto-provisioning is enabled. Must be supplied for GKE Standard clusters, true is implied for autopilot clusters. Resource limits for cpu and memory must be defined to enable node auto-provisioning for GKE Standard.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Global constraints for machine resources in the cluster. Configuring the cpu and memory types is required if node auto-provisioning is enabled. These limits will apply to node pool autoscaling in addition to node auto-provisioning. Structure is documented below.</summary>
    [JsonPropertyName("resourceLimits")]
    public IList<V1beta1ClusterStatusAtProviderClusterAutoscalingResourceLimits>? ResourceLimits { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for Confidential Nodes feature. Structure is documented below documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderConfidentialNodes
{
    /// <summary>Defines the type of technology used by the confidential node.</summary>
    [JsonPropertyName("confidentialInstanceType")]
    public string? ConfidentialInstanceType { get; set; }

    /// <summary>Enable Confidential GKE Nodes for this node pool, to enforce encryption of data in-use.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DNS endpoint configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderControlPlaneEndpointsConfigDnsEndpointConfig
{
    /// <summary>Controls whether user traffic is allowed over this endpoint. Note that GCP-managed services may still use the endpoint even if this is false.</summary>
    [JsonPropertyName("allowExternalTraffic")]
    public bool? AllowExternalTraffic { get; set; }

    /// <summary>(Output) The cluster's DNS endpoint.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }
}
#nullable disable

#nullable enable
/// <summary>IP endpoint configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderControlPlaneEndpointsConfigIpEndpointsConfig
{
    /// <summary>Controls whether to allow direct IP access. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for all of the cluster's control plane endpoints. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderControlPlaneEndpointsConfig
{
    /// <summary>DNS endpoint configuration.</summary>
    [JsonPropertyName("dnsEndpointConfig")]
    public V1beta1ClusterStatusAtProviderControlPlaneEndpointsConfigDnsEndpointConfig? DnsEndpointConfig { get; set; }

    /// <summary>IP endpoint configuration.</summary>
    [JsonPropertyName("ipEndpointsConfig")]
    public V1beta1ClusterStatusAtProviderControlPlaneEndpointsConfigIpEndpointsConfig? IpEndpointsConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the Cost Allocation feature. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderCostManagementConfig
{
    /// <summary>Whether to enable the cost allocation feature.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderDatabaseEncryption
{
    /// <summary>the key to use to encrypt/decrypt secrets.  See the DatabaseEncryption definition for more information.</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>ENCRYPTED or DECRYPTED</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}
#nullable disable

#nullable enable
/// <summary>GKE SNAT DefaultSnatStatus contains the desired state of whether default sNAT should be disabled on the cluster, API doc. Structure is documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderDefaultSnatStatus
{
    /// <summary>Whether the cluster disables default in-node sNAT rules. In-node sNAT rules will be disabled when defaultSnatStatus is disabled.When disabled is set to false, default IP masquerade rules will be applied to the nodes to prevent sNAT on cluster internal traffic</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for Using Cloud DNS for GKE. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderDnsConfig
{
    /// <summary>This will enable Cloud DNS additive VPC scope. Must provide a domain name that is unique within the VPC. For this to work cluster_dns = "CLOUD_DNS" and cluster_dns_scope = "CLUSTER_SCOPE" must both be set as well.</summary>
    [JsonPropertyName("additiveVpcScopeDnsDomain")]
    public string? AdditiveVpcScopeDnsDomain { get; set; }

    /// <summary>Which in-cluster DNS provider should be used. PROVIDER_UNSPECIFIED (default) or PLATFORM_DEFAULT or CLOUD_DNS.</summary>
    [JsonPropertyName("clusterDns")]
    public string? ClusterDns { get; set; }

    /// <summary>The suffix used for all cluster service records.</summary>
    [JsonPropertyName("clusterDnsDomain")]
    public string? ClusterDnsDomain { get; set; }

    /// <summary>The scope of access to cluster DNS records. DNS_SCOPE_UNSPECIFIED or CLUSTER_SCOPE or VPC_SCOPE. If the cluster_dns field is set to CLOUD_DNS, DNS_SCOPE_UNSPECIFIED and empty/null behave like CLUSTER_SCOPE.</summary>
    [JsonPropertyName("clusterDnsScope")]
    public string? ClusterDnsScope { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for Kubernetes Beta APIs. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderEnableK8SBetaApis
{
    /// <summary>Enabled Kubernetes Beta APIs. To list a Beta API resource, use the representation {group}/{version}/{resource}. The version must be a Beta version. Note that you cannot disable beta APIs that are already enabled on a cluster without recreating it. See the Configure beta APIs for more information.</summary>
    [JsonPropertyName("enabledApis")]
    public IList<string>? EnabledApis { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for [Enterprise edition].(https://cloud.google.com/kubernetes-engine/enterprise/docs/concepts/gke-editions). Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderEnterpriseConfig
{
    /// <summary>The effective tier of the cluster.</summary>
    [JsonPropertyName("clusterTier")]
    public string? ClusterTier { get; set; }

    /// <summary>Sets the tier of the cluster. Available options include STANDARD and ENTERPRISE.</summary>
    [JsonPropertyName("desiredTier")]
    public string? DesiredTier { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Fleet configuration for the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderFleet
{
    /// <summary>The resource name of the fleet Membership resource associated to this cluster with format //gkehub.googleapis.com/projects/{{project}}/locations/{{location}}/memberships/{{name}}. See the official doc for fleet management.</summary>
    [JsonPropertyName("membership")]
    public string? Membership { get; set; }

    /// <summary>The short name of the fleet membership, extracted from fleet.0.membership. You can use this field to configure membership_id under google_gkehub_feature_membership.</summary>
    [JsonPropertyName("membershipId")]
    public string? MembershipId { get; set; }

    /// <summary>The location of the fleet membership,  extracted from fleet.0.membership. You can use this field to configure membership_location under google_gkehub_feature_membership.</summary>
    [JsonPropertyName("membershipLocation")]
    public string? MembershipLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preRegistered")]
    public bool? PreRegistered { get; set; }

    /// <summary>The name of the Fleet host project where this cluster will be registered.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for GKE Gateway API controller. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderGatewayApiConfig
{
    /// <summary>Which Gateway Api channel should be used. CHANNEL_DISABLED, CHANNEL_EXPERIMENTAL or CHANNEL_STANDARD.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration options for the auto-upgrade patch type feature, which provide more control over the speed of automatic upgrades of your GKE clusters. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderGkeAutoUpgradeConfig
{
    /// <summary>The selected patch mode. Accepted values are:</summary>
    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderIdentityServiceConfig
{
    /// <summary>Whether to enable the Identity Service component. It is disabled by default. Set enabled=true to enable.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The configuration for additional pod secondary ranges at the cluster level. Used for Autopilot clusters and Standard clusters with which control of the secondary Pod IP address assignment to node pools isn't needed. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderIpAllocationPolicyAdditionalPodRangesConfig
{
    /// <summary>The names of the Pod ranges to add to the cluster.</summary>
    [JsonPropertyName("podRangeNames")]
    public IList<string>? PodRangeNames { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderIpAllocationPolicyPodCidrOverprovisionConfig
{
    /// <summary>The status of the Istio addon, which makes it easy to set up Istio for services in a cluster. It is disabled by default. Set disabled = false to enable.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration of cluster IP allocation for VPC-native clusters. If this block is unset during creation, it will be set by the GKE backend. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderIpAllocationPolicy
{
    /// <summary>The configuration for additional pod secondary ranges at the cluster level. Used for Autopilot clusters and Standard clusters with which control of the secondary Pod IP address assignment to node pools isn't needed. Structure is documented below.</summary>
    [JsonPropertyName("additionalPodRangesConfig")]
    public V1beta1ClusterStatusAtProviderIpAllocationPolicyAdditionalPodRangesConfig? AdditionalPodRangesConfig { get; set; }

    /// <summary>The IP address range for the cluster pod IPs. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use.</summary>
    [JsonPropertyName("clusterIpv4CidrBlock")]
    public string? ClusterIpv4CidrBlock { get; set; }

    /// <summary>The name of the existing secondary range in the cluster's subnetwork to use for pod IP addresses. Alternatively, cluster_ipv4_cidr_block can be used to automatically create a GKE-managed one.</summary>
    [JsonPropertyName("clusterSecondaryRangeName")]
    public string? ClusterSecondaryRangeName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podCidrOverprovisionConfig")]
    public V1beta1ClusterStatusAtProviderIpAllocationPolicyPodCidrOverprovisionConfig? PodCidrOverprovisionConfig { get; set; }

    /// <summary>The IP address range of the services IPs in this cluster. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use.</summary>
    [JsonPropertyName("servicesIpv4CidrBlock")]
    public string? ServicesIpv4CidrBlock { get; set; }

    /// <summary>The name of the existing secondary range in the cluster's subnetwork to use for service ClusterIPs. Alternatively, services_ipv4_cidr_block can be used to automatically create a GKE-managed one.</summary>
    [JsonPropertyName("servicesSecondaryRangeName")]
    public string? ServicesSecondaryRangeName { get; set; }

    /// <summary>The IP Stack Type of the cluster. Default value is IPV4. Possible values are IPV4 and IPV4_IPV6.</summary>
    [JsonPropertyName("stackType")]
    public string? StackType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Logging configuration for the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderLoggingConfig
{
    /// <summary>The GKE components exposing logs. Supported values include: SYSTEM_COMPONENTS, APISERVER, CONTROLLER_MANAGER, SCHEDULER, and WORKLOADS.</summary>
    [JsonPropertyName("enableComponents")]
    public IList<string>? EnableComponents { get; set; }
}
#nullable disable

#nullable enable
/// <summary>structure documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderMaintenancePolicyDailyMaintenanceWindow
{
    /// <summary>Duration of the time window, automatically chosen to be smallest possible in the given scenario. Duration will be in RFC3339 format "PTnHnMnS".</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>MaintenanceExclusionOptions provides maintenance exclusion related options.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderMaintenancePolicyMaintenanceExclusionExclusionOptions
{
    /// <summary>Whether or not to enable GKE Auto-Monitoring. Supported values include: ALL, NONE.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderMaintenancePolicyMaintenanceExclusion
{
    /// <summary></summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>The name of the cluster, unique within the project and location.</summary>
    [JsonPropertyName("exclusionName")]
    public string? ExclusionName { get; set; }

    /// <summary>MaintenanceExclusionOptions provides maintenance exclusion related options.</summary>
    [JsonPropertyName("exclusionOptions")]
    public V1beta1ClusterStatusAtProviderMaintenancePolicyMaintenanceExclusionExclusionOptions? ExclusionOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>structure documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderMaintenancePolicyRecurringWindow
{
    /// <summary></summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurrence")]
    public string? Recurrence { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The maintenance policy to use for the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderMaintenancePolicy
{
    /// <summary>structure documented below.</summary>
    [JsonPropertyName("dailyMaintenanceWindow")]
    public V1beta1ClusterStatusAtProviderMaintenancePolicyDailyMaintenanceWindow? DailyMaintenanceWindow { get; set; }

    /// <summary>structure documented below</summary>
    [JsonPropertyName("maintenanceExclusion")]
    public IList<V1beta1ClusterStatusAtProviderMaintenancePolicyMaintenanceExclusion>? MaintenanceExclusion { get; set; }

    /// <summary>structure documented below</summary>
    [JsonPropertyName("recurringWindow")]
    public V1beta1ClusterStatusAtProviderMaintenancePolicyRecurringWindow? RecurringWindow { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Whether client certificate authorization is enabled for this cluster.  For example:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderMasterAuthClientCertificateConfig
{
    /// <summary></summary>
    [JsonPropertyName("issueClientCertificate")]
    public bool? IssueClientCertificate { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The authentication information for accessing the Kubernetes master. Some values in this block are only returned by the API if your service account has permission to get credentials for your GKE cluster. If you see an unexpected diff unsetting your client cert, ensure you have the container.clusters.getCredentials permission. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderMasterAuth
{
    /// <summary>Base64 encoded public certificate used by clients to authenticate to the cluster endpoint.</summary>
    [JsonPropertyName("clientCertificate")]
    public string? ClientCertificate { get; set; }

    /// <summary>Whether client certificate authorization is enabled for this cluster.  For example:</summary>
    [JsonPropertyName("clientCertificateConfig")]
    public V1beta1ClusterStatusAtProviderMasterAuthClientCertificateConfig? ClientCertificateConfig { get; set; }

    /// <summary>Base64 encoded public certificate that is the root certificate of the cluster.</summary>
    [JsonPropertyName("clusterCaCertificate")]
    public string? ClusterCaCertificate { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderMasterAuthorizedNetworksConfigCidrBlocks
{
    /// <summary>External network that can access Kubernetes master through HTTPS. Must be specified in CIDR notation.</summary>
    [JsonPropertyName("cidrBlock")]
    public string? CidrBlock { get; set; }

    /// <summary>Field for users to identify CIDR blocks.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The desired configuration options for master authorized networks. Omit the nested cidr_blocks attribute to disallow external access (except the cluster node IPs, which GKE automatically whitelists). Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderMasterAuthorizedNetworksConfig
{
    /// <summary>External networks that can access the Kubernetes cluster master through HTTPS.</summary>
    [JsonPropertyName("cidrBlocks")]
    public IList<V1beta1ClusterStatusAtProviderMasterAuthorizedNetworksConfigCidrBlocks>? CidrBlocks { get; set; }

    /// <summary>Whether Kubernetes master is accessible via Google Compute Engine Public IPs.</summary>
    [JsonPropertyName("gcpPublicCidrsAccessEnabled")]
    public bool? GcpPublicCidrsAccessEnabled { get; set; }

    /// <summary>Whether authorized networks is enforced on the private endpoint or not.</summary>
    [JsonPropertyName("privateEndpointEnforcementEnabled")]
    public bool? PrivateEndpointEnforcementEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderMeshCertificates
{
    /// <summary>Controls the issuance of workload mTLS certificates. It is enabled by default. Workload Identity is required, see workload_config.</summary>
    [JsonPropertyName("enableCertificates")]
    public bool? EnableCertificates { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for Advanced Datapath Monitoring. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderMonitoringConfigAdvancedDatapathObservabilityConfig
{
    /// <summary>Whether or not to enable advanced datapath metrics.</summary>
    [JsonPropertyName("enableMetrics")]
    public bool? EnableMetrics { get; set; }

    /// <summary>Whether or not Relay is enabled.</summary>
    [JsonPropertyName("enableRelay")]
    public bool? EnableRelay { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration options for GKE Auto-Monitoring.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderMonitoringConfigManagedPrometheusAutoMonitoringConfig
{
    /// <summary>Whether or not to enable GKE Auto-Monitoring. Supported values include: ALL, NONE.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for Managed Service for Prometheus. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderMonitoringConfigManagedPrometheus
{
    /// <summary>Configuration options for GKE Auto-Monitoring.</summary>
    [JsonPropertyName("autoMonitoringConfig")]
    public V1beta1ClusterStatusAtProviderMonitoringConfigManagedPrometheusAutoMonitoringConfig? AutoMonitoringConfig { get; set; }

    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Monitoring configuration for the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderMonitoringConfig
{
    /// <summary>Configuration for Advanced Datapath Monitoring. Structure is documented below.</summary>
    [JsonPropertyName("advancedDatapathObservabilityConfig")]
    public V1beta1ClusterStatusAtProviderMonitoringConfigAdvancedDatapathObservabilityConfig? AdvancedDatapathObservabilityConfig { get; set; }

    /// <summary>The GKE components exposing metrics. Supported values include: SYSTEM_COMPONENTS, APISERVER, SCHEDULER, CONTROLLER_MANAGER, STORAGE, HPA, POD, DAEMONSET, DEPLOYMENT, STATEFULSET, KUBELET, CADVISOR, DCGM and JOBSET. In beta provider, WORKLOADS is supported on top of those 12 values. (WORKLOADS is deprecated and removed in GKE 1.24.) KUBELET and CADVISOR are only supported in GKE 1.29.3-gke.1093000 and above. JOBSET is only supported in GKE 1.32.1-gke.1357001 and above.</summary>
    [JsonPropertyName("enableComponents")]
    public IList<string>? EnableComponents { get; set; }

    /// <summary>Configuration for Managed Service for Prometheus. Structure is documented below.</summary>
    [JsonPropertyName("managedPrometheus")]
    public V1beta1ClusterStatusAtProviderMonitoringConfigManagedPrometheus? ManagedPrometheus { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Network bandwidth tier configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNetworkPerformanceConfig
{
    /// <summary>Specifies the total network bandwidth tier for NodePools in the cluster.</summary>
    [JsonPropertyName("totalEgressBandwidthTier")]
    public string? TotalEgressBandwidthTier { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration options for the NetworkPolicy feature. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNetworkPolicy
{
    /// <summary>Whether network policy is enabled on the cluster.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The selected network policy provider. Defaults to PROVIDER_UNSPECIFIED.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies options for controlling advanced machine features. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodeConfigAdvancedMachineFeatures
{
    /// <summary>Defines whether the instance should have nested virtualization enabled. Defaults to false.</summary>
    [JsonPropertyName("enableNestedVirtualization")]
    public bool? EnableNestedVirtualization { get; set; }

    /// <summary>Defines the performance monitoring unit PMU level. Valid values are ARCHITECTURAL, STANDARD, or ENHANCED. Defaults to off.</summary>
    [JsonPropertyName("performanceMonitoringUnit")]
    public string? PerformanceMonitoringUnit { get; set; }

    /// <summary>The number of threads per physical core. To disable simultaneous multithreading (SMT) set this to 1. If unset, the maximum number of threads supported per core by the underlying processor is assumed.</summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for Confidential Nodes feature. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodeConfigConfidentialNodes
{
    /// <summary>Defines the type of technology used by the confidential node.</summary>
    [JsonPropertyName("confidentialInstanceType")]
    public string? ConfidentialInstanceType { get; set; }

    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig
{
    /// <summary></summary>
    [JsonPropertyName("secretUri")]
    public string? SecretUri { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig
{
    /// <summary></summary>
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpSecretManagerCertificateConfig")]
    public V1beta1ClusterStatusAtProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig? GcpSecretManagerCertificateConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for private container registries. There are two fields in this config:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodeConfigContainerdConfigPrivateRegistryAccessConfig
{
    /// <summary>List of configuration objects for CA and domains. Each object identifies a certificate and its assigned domains. See how to configure for private container registries for more detail. Example:</summary>
    [JsonPropertyName("certificateAuthorityDomainConfig")]
    public IList<V1beta1ClusterStatusAtProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig>? CertificateAuthorityDomainConfig { get; set; }

    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters to customize containerd runtime. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodeConfigContainerdConfig
{
    /// <summary>Configuration for private container registries. There are two fields in this config:</summary>
    [JsonPropertyName("privateRegistryAccessConfig")]
    public V1beta1ClusterStatusAtProviderNodeConfigContainerdConfigPrivateRegistryAccessConfig? PrivateRegistryAccessConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodeConfigEffectiveTaints
{
    /// <summary>Effect for taint. Accepted values are NO_SCHEDULE, PREFER_NO_SCHEDULE, and NO_EXECUTE.</summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>Key for taint.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value for taint.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters for the ephemeral storage filesystem. If unspecified, ephemeral storage is backed by the boot disk. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodeConfigEphemeralStorageLocalSsdConfig
{
    /// <summary>Number of raw-block local NVMe SSD disks to be attached to the node utilized for GKE Data Cache. If zero, then GKE Data Cache will not be enabled in the nodes.</summary>
    [JsonPropertyName("dataCacheCount")]
    public double? DataCacheCount { get; set; }

    /// <summary>The amount of local SSD disks that will be attached to each cluster node. Defaults to 0.</summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters for the NCCL Fast Socket feature. If unspecified, NCCL Fast Socket will not be enabled on the node pool. Node Pool must enable gvnic. GKE version 1.25.2-gke.1700 or later. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodeConfigFastSocket
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters for the Google Container Filesystem (GCFS). If unspecified, GCFS will not be enabled on the node pool. When enabling this feature you must specify image_type = "COS_CONTAINERD" and node_version from GKE versions 1.19 or later to use it. For GKE versions 1.19, 1.20, and 1.21, the recommended minimum node_version would be 1.19.15-gke.1300, 1.20.11-gke.1300, and 1.21.5-gke.1300 respectively. A machine_type that has more than 16 GiB of memory is also recommended. GCFS must be enabled in order to use image streaming. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodeConfigGcfsConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for auto installation of GPU driver. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodeConfigGuestAcceleratorGpuDriverInstallationConfig
{
    /// <summary>Mode for how the GPU driver is installed. Accepted values are:</summary>
    [JsonPropertyName("gpuDriverVersion")]
    public string? GpuDriverVersion { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for GPU sharing. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodeConfigGuestAcceleratorGpuSharingConfig
{
    /// <summary>The type of GPU sharing strategy to enable on the GPU node. Accepted values are:</summary>
    [JsonPropertyName("gpuSharingStrategy")]
    public string? GpuSharingStrategy { get; set; }

    /// <summary>The maximum number of containers that can share a GPU.</summary>
    [JsonPropertyName("maxSharedClientsPerGpu")]
    public double? MaxSharedClientsPerGpu { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodeConfigGuestAccelerator
{
    /// <summary>The number of the guest accelerator cards exposed to this instance.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>Configuration for auto installation of GPU driver. Structure is documented below.</summary>
    [JsonPropertyName("gpuDriverInstallationConfig")]
    public V1beta1ClusterStatusAtProviderNodeConfigGuestAcceleratorGpuDriverInstallationConfig? GpuDriverInstallationConfig { get; set; }

    /// <summary>Size of partitions to create on the GPU. Valid values are described in the NVIDIA mig user guide.</summary>
    [JsonPropertyName("gpuPartitionSize")]
    public string? GpuPartitionSize { get; set; }

    /// <summary>Configuration for GPU sharing. Structure is documented below.</summary>
    [JsonPropertyName("gpuSharingConfig")]
    public V1beta1ClusterStatusAtProviderNodeConfigGuestAcceleratorGpuSharingConfig? GpuSharingConfig { get; set; }

    /// <summary>The accelerator type resource to expose to this instance. E.g. nvidia-tesla-k80.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Google Virtual NIC (gVNIC) is a virtual network interface. Installing the gVNIC driver allows for more efficient traffic transmission across the Google network infrastructure. gVNIC is an alternative to the virtIO-based ethernet driver. GKE nodes must use a Container-Optimized OS node image. GKE node version 1.15.11-gke.15 or later Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodeConfigGvnic
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The maintenance policy to use for the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodeConfigHostMaintenancePolicy
{
    /// <summary></summary>
    [JsonPropertyName("maintenanceInterval")]
    public string? MaintenanceInterval { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Kubelet configuration, currently supported attributes can be found here. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodeConfigKubeletConfig
{
    /// <summary>Defines a comma-separated allowlist of unsafe sysctls or sysctl patterns which can be set on the Pods. The allowed sysctl groups are kernel.shm*, kernel.msg*, kernel.sem, fs.mqueue.*, and net.*.</summary>
    [JsonPropertyName("allowedUnsafeSysctls")]
    public IList<string>? AllowedUnsafeSysctls { get; set; }

    /// <summary>Defines the maximum number of container log files that can be present for a container. The integer must be between 2 and 10, inclusive.</summary>
    [JsonPropertyName("containerLogMaxFiles")]
    public double? ContainerLogMaxFiles { get; set; }

    /// <summary>Defines the maximum size of the container log file before it is rotated. Specified as a positive number and a unit suffix, such as "100Ki", "10Mi". Valid units are "Ki", "Mi", "Gi". The value must be between "10Mi" and "500Mi", inclusive. And the total container log size (container_log_max_size * container_log_max_files) cannot exceed 1% of the total storage of the node.</summary>
    [JsonPropertyName("containerLogMaxSize")]
    public string? ContainerLogMaxSize { get; set; }

    /// <summary>If true, enables CPU CFS quota enforcement for containers that specify CPU limits.</summary>
    [JsonPropertyName("cpuCfsQuota")]
    public bool? CpuCfsQuota { get; set; }

    /// <summary>The CPU CFS quota period value. Specified as a sequence of decimal numbers, each with optional fraction and a unit suffix, such as "300ms". Valid time units are "ns", "us" (or "µs"), "ms", "s", "m", "h". The value must be a positive duration.</summary>
    [JsonPropertyName("cpuCfsQuotaPeriod")]
    public string? CpuCfsQuotaPeriod { get; set; }

    /// <summary>The CPU management policy on the node. See K8S CPU Management Policies. One of "none" or "static". If unset (or set to the empty string ""), the API will treat the field as if set to "none". Prior to the 6.4.0 this field was marked as required. The workaround for the required field is setting the empty string "", which will function identically to not setting this field.</summary>
    [JsonPropertyName("cpuManagerPolicy")]
    public string? CpuManagerPolicy { get; set; }

    /// <summary>Defines the percent of disk usage after which image garbage collection is always run. The integer must be between 10 and 85, inclusive.</summary>
    [JsonPropertyName("imageGcHighThresholdPercent")]
    public double? ImageGcHighThresholdPercent { get; set; }

    /// <summary>Defines the percent of disk usage before which image garbage collection is never run. Lowest disk usage to garbage collect to. The integer must be between 10 and 85, inclusive.</summary>
    [JsonPropertyName("imageGcLowThresholdPercent")]
    public double? ImageGcLowThresholdPercent { get; set; }

    /// <summary>Defines the maximum age an image can be unused before it is garbage collected. Specified as a sequence of decimal numbers, each with optional fraction and a unit suffix, such as "300s", "1.5m", and "2h45m". Valid time units are "ns", "us" (or "µs"), "ms", "s", "m", "h". The value must be a positive duration.</summary>
    [JsonPropertyName("imageMaximumGcAge")]
    public string? ImageMaximumGcAge { get; set; }

    /// <summary>Defines the minimum age for an unused image before it is garbage collected. Specified as a sequence of decimal numbers, each with optional fraction and a unit suffix, such as "300s", "1.5m". The value cannot be greater than "2m".</summary>
    [JsonPropertyName("imageMinimumGcAge")]
    public string? ImageMinimumGcAge { get; set; }

    /// <summary>only port is enabled for newly created node pools in the cluster. It is strongly recommended to set this to FALSE. Possible values: TRUE, FALSE.</summary>
    [JsonPropertyName("insecureKubeletReadonlyPortEnabled")]
    public string? InsecureKubeletReadonlyPortEnabled { get; set; }

    /// <summary>Controls the maximum number of processes allowed to run in a pod. The value must be greater than or equal to 1024 and less than 4194304.</summary>
    [JsonPropertyName("podPidsLimit")]
    public double? PodPidsLimit { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Amounts for 2M and 1G hugepages. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodeConfigLinuxNodeConfigHugepagesConfig
{
    /// <summary>Amount of 1G hugepages.</summary>
    [JsonPropertyName("hugepageSize1G")]
    public double? HugepageSize1G { get; set; }

    /// <summary>Amount of 2M hugepages.</summary>
    [JsonPropertyName("hugepageSize2M")]
    public double? HugepageSize2M { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters that can be configured on Linux nodes. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodeConfigLinuxNodeConfig
{
    /// <summary>Possible cgroup modes that can be used. Accepted values are:</summary>
    [JsonPropertyName("cgroupMode")]
    public string? CgroupMode { get; set; }

    /// <summary>Amounts for 2M and 1G hugepages. Structure is documented below.</summary>
    [JsonPropertyName("hugepagesConfig")]
    public V1beta1ClusterStatusAtProviderNodeConfigLinuxNodeConfigHugepagesConfig? HugepagesConfig { get; set; }

    /// <summary>The Linux kernel parameters to be applied to the nodes and all pods running on the nodes. Specified as a map from the key, such as net.core.wmem_max, to a string value. Currently supported attributes can be found here. Note that validations happen all server side. All attributes are optional.</summary>
    [JsonPropertyName("sysctls")]
    public IDictionary<string, string>? Sysctls { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters for the local NVMe SSDs. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodeConfigLocalNvmeSsdBlockConfig
{
    /// <summary>The amount of local SSD disks that will be attached to each cluster node. Defaults to 0.</summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The configuration of the desired reservation which instances could take capacity from. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodeConfigReservationAffinity
{
    /// <summary>The type of reservation consumption Accepted values are:</summary>
    [JsonPropertyName("consumeReservationType")]
    public string? ConsumeReservationType { get; set; }

    /// <summary>Key for taint.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>name"</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodeConfigSecondaryBootDisks
{
    /// <summary>Path to disk image to create the secondary boot disk from. After using the gke-disk-image-builder, this argument should be global/images/DISK_IMAGE_NAME.</summary>
    [JsonPropertyName("diskImage")]
    public string? DiskImage { get; set; }

    /// <summary>How to expose the node metadata to the workload running on the node. Accepted values are:</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Shielded Instance options. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodeConfigShieldedInstanceConfig
{
    /// <summary>Defines if the instance has integrity monitoring enabled.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>Defines if the instance has Secure Boot enabled.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodeConfigSoleTenantConfigNodeAffinity
{
    /// <summary>Key for taint.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies affinity or anti-affinity. Accepted values are "IN" or "NOT_IN"</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>name"</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Allows specifying multiple node affinities useful for running workloads on sole tenant nodes. node_affinity structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodeConfigSoleTenantConfig
{
    /// <summary></summary>
    [JsonPropertyName("nodeAffinity")]
    public IList<V1beta1ClusterStatusAtProviderNodeConfigSoleTenantConfigNodeAffinity>? NodeAffinity { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodeConfigTaint
{
    /// <summary>Effect for taint. Accepted values are NO_SCHEDULE, PREFER_NO_SCHEDULE, and NO_EXECUTE.</summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>Key for taint.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value for taint.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Windows node configuration, currently supporting OSVersion attribute. The value must be one of [OS_VERSION_UNSPECIFIED, OS_VERSION_LTSC2019, OS_VERSION_LTSC2022]. For example:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodeConfigWindowsNodeConfig
{
    /// <summary></summary>
    [JsonPropertyName("osversion")]
    public string? Osversion { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Metadata configuration to expose to workloads on the node pool. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodeConfigWorkloadMetadataConfig
{
    /// <summary>How to expose the node metadata to the workload running on the node. Accepted values are:</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters used in creating the default node pool. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodeConfig
{
    /// <summary>Specifies options for controlling advanced machine features. Structure is documented below.</summary>
    [JsonPropertyName("advancedMachineFeatures")]
    public V1beta1ClusterStatusAtProviderNodeConfigAdvancedMachineFeatures? AdvancedMachineFeatures { get; set; }

    /// <summary>The Customer Managed Encryption Key used to encrypt the boot disk attached to each node in the node pool. This should be of the form projects/[KEY_PROJECT_ID]/locations/[LOCATION]/keyRings/[RING_NAME]/cryptoKeys/[KEY_NAME]. For more information about protecting resources with Cloud KMS Keys please see: https://cloud.google.com/compute/docs/disks/customer-managed-encryption</summary>
    [JsonPropertyName("bootDiskKmsKey")]
    public string? BootDiskKmsKey { get; set; }

    /// <summary>Configuration for Confidential Nodes feature. Structure is documented below.</summary>
    [JsonPropertyName("confidentialNodes")]
    public V1beta1ClusterStatusAtProviderNodeConfigConfidentialNodes? ConfidentialNodes { get; set; }

    /// <summary>Parameters to customize containerd runtime. Structure is documented below.</summary>
    [JsonPropertyName("containerdConfig")]
    public V1beta1ClusterStatusAtProviderNodeConfigContainerdConfig? ContainerdConfig { get; set; }

    /// <summary>Size of the disk attached to each node, specified in GB. The smallest allowed disk size is 10GB. Defaults to 100GB.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>Type of the disk attached to each node (e.g. 'pd-standard', 'pd-balanced' or 'pd-ssd'). If unspecified, the default disk type is 'pd-balanced'</summary>
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    /// <summary>List of kubernetes taints applied to each node. Structure is documented above.</summary>
    [JsonPropertyName("effectiveTaints")]
    public IList<V1beta1ClusterStatusAtProviderNodeConfigEffectiveTaints>? EffectiveTaints { get; set; }

    /// <summary>Enabling Confidential Storage will create boot disk with confidential mode. It is disabled by default.</summary>
    [JsonPropertyName("enableConfidentialStorage")]
    public bool? EnableConfidentialStorage { get; set; }

    /// <summary>Parameters for the ephemeral storage filesystem. If unspecified, ephemeral storage is backed by the boot disk. Structure is documented below.</summary>
    [JsonPropertyName("ephemeralStorageLocalSsdConfig")]
    public V1beta1ClusterStatusAtProviderNodeConfigEphemeralStorageLocalSsdConfig? EphemeralStorageLocalSsdConfig { get; set; }

    /// <summary>Parameters for the NCCL Fast Socket feature. If unspecified, NCCL Fast Socket will not be enabled on the node pool. Node Pool must enable gvnic. GKE version 1.25.2-gke.1700 or later. Structure is documented below.</summary>
    [JsonPropertyName("fastSocket")]
    public V1beta1ClusterStatusAtProviderNodeConfigFastSocket? FastSocket { get; set; }

    /// <summary>Enables Flex Start provisioning model for the node pool.</summary>
    [JsonPropertyName("flexStart")]
    public bool? FlexStart { get; set; }

    /// <summary>Parameters for the Google Container Filesystem (GCFS). If unspecified, GCFS will not be enabled on the node pool. When enabling this feature you must specify image_type = "COS_CONTAINERD" and node_version from GKE versions 1.19 or later to use it. For GKE versions 1.19, 1.20, and 1.21, the recommended minimum node_version would be 1.19.15-gke.1300, 1.20.11-gke.1300, and 1.21.5-gke.1300 respectively. A machine_type that has more than 16 GiB of memory is also recommended. GCFS must be enabled in order to use image streaming. Structure is documented below.</summary>
    [JsonPropertyName("gcfsConfig")]
    public V1beta1ClusterStatusAtProviderNodeConfigGcfsConfig? GcfsConfig { get; set; }

    /// <summary>List of the type and count of accelerator cards attached to the instance. Structure documented below. Note: As of 6.0.0, argument syntax is no longer supported for this field in favor of block syntax. To dynamically set a list of guest accelerators, use dynamic blocks. To set an empty list, use a single guest_accelerator block with count = 0.</summary>
    [JsonPropertyName("guestAccelerator")]
    public IList<V1beta1ClusterStatusAtProviderNodeConfigGuestAccelerator>? GuestAccelerator { get; set; }

    /// <summary>Google Virtual NIC (gVNIC) is a virtual network interface. Installing the gVNIC driver allows for more efficient traffic transmission across the Google network infrastructure. gVNIC is an alternative to the virtIO-based ethernet driver. GKE nodes must use a Container-Optimized OS node image. GKE node version 1.15.11-gke.15 or later Structure is documented below.</summary>
    [JsonPropertyName("gvnic")]
    public V1beta1ClusterStatusAtProviderNodeConfigGvnic? Gvnic { get; set; }

    /// <summary>The maintenance policy to use for the cluster. Structure is documented below.</summary>
    [JsonPropertyName("hostMaintenancePolicy")]
    public V1beta1ClusterStatusAtProviderNodeConfigHostMaintenancePolicy? HostMaintenancePolicy { get; set; }

    /// <summary>The image type to use for this node. Note that changing the image type will delete and recreate all nodes in the node pool.</summary>
    [JsonPropertyName("imageType")]
    public string? ImageType { get; set; }

    /// <summary>Kubelet configuration, currently supported attributes can be found here. Structure is documented below.</summary>
    [JsonPropertyName("kubeletConfig")]
    public V1beta1ClusterStatusAtProviderNodeConfigKubeletConfig? KubeletConfig { get; set; }

    /// <summary>The Kubernetes labels (key/value pairs) to be applied to each node. The kubernetes.io/ and k8s.io/ prefixes are reserved by Kubernetes Core components and cannot be specified.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Parameters that can be configured on Linux nodes. Structure is documented below.</summary>
    [JsonPropertyName("linuxNodeConfig")]
    public V1beta1ClusterStatusAtProviderNodeConfigLinuxNodeConfig? LinuxNodeConfig { get; set; }

    /// <summary>Parameters for the local NVMe SSDs. Structure is documented below.</summary>
    [JsonPropertyName("localNvmeSsdBlockConfig")]
    public V1beta1ClusterStatusAtProviderNodeConfigLocalNvmeSsdBlockConfig? LocalNvmeSsdBlockConfig { get; set; }

    /// <summary>The amount of local SSD disks that will be attached to each cluster node. Defaults to 0.</summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary>Possible Local SSD encryption modes: Accepted values are:</summary>
    [JsonPropertyName("localSsdEncryptionMode")]
    public string? LocalSsdEncryptionMode { get; set; }

    /// <summary>wide default value. Valid values include DEFAULT and MAX_THROUGHPUT. See Increasing logging agent throughput for more information.</summary>
    [JsonPropertyName("loggingVariant")]
    public string? LoggingVariant { get; set; }

    /// <summary>The name of a Google Compute Engine machine type. Defaults to e2-medium. To create a custom machine type, value should be set as specified here.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>The runtime of each node in the node pool in seconds, terminated by 's'. Example: "3600s".</summary>
    [JsonPropertyName("maxRunDuration")]
    public string? MaxRunDuration { get; set; }

    /// <summary>The metadata key/value pairs assigned to instances in the cluster. From GKE 1. To avoid this, set the value in your config.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Minimum CPU platform to be used by this instance. The instance may be scheduled on the specified or newer CPU platform. Applicable values are the friendly names of CPU platforms, such as Intel Haswell. See the official documentation for more information.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>Setting this field will assign instances of this pool to run on the specified node group. This is useful for running workloads on sole tenant nodes.</summary>
    [JsonPropertyName("nodeGroup")]
    public string? NodeGroup { get; set; }

    /// <summary>The set of Google API scopes to be made available on all of the node VMs under the "default" service account. Use the "https://www.googleapis.com/auth/cloud-platform" scope to grant access to all APIs. It is recommended that you set service_account to a non-default service account and grant IAM roles to that service account for only the resources that it needs.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }

    /// <summary>A boolean that represents whether or not the underlying node VMs are preemptible. See the official documentation for more information. Defaults to false.</summary>
    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    /// <summary>The configuration of the desired reservation which instances could take capacity from. Structure is documented below.</summary>
    [JsonPropertyName("reservationAffinity")]
    public V1beta1ClusterStatusAtProviderNodeConfigReservationAffinity? ReservationAffinity { get; set; }

    /// <summary>The GCP labels (key/value pairs) to be applied to each node. Refer here for how these labels are applied to clusters, node pools and nodes.</summary>
    [JsonPropertyName("resourceLabels")]
    public IDictionary<string, string>? ResourceLabels { get; set; }

    /// <summary>A map of resource manager tag keys and values to be attached to the nodes for managing Compute Engine firewalls using Network Firewall Policies. Tags must be according to specifications found here. A maximum of 5 tag key-value pairs can be specified. Existing tags will be replaced with new values. Tags must be in one of the following formats ([KEY]=[VALUE]) 1. tagKeys/{tag_key_id}=tagValues/{tag_value_id} 2. {org_id}/{tag_key_name}={tag_value_name} 3. {project_id}/{tag_key_name}={tag_value_name}.</summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }

    /// <summary>Parameters for secondary boot disks to preload container images and data on new nodes. Structure is documented below. gcfs_config must be enabled=true for this feature to work. min_master_version must also be set to use GKE 1.28.3-gke.106700 or later versions.</summary>
    [JsonPropertyName("secondaryBootDisks")]
    public IList<V1beta1ClusterStatusAtProviderNodeConfigSecondaryBootDisks>? SecondaryBootDisks { get; set; }

    /// <summary>The service account to be used by the Node VMs. If not specified, the "default" service account is used.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Shielded Instance options. Structure is documented below.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta1ClusterStatusAtProviderNodeConfigShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    /// <summary>Allows specifying multiple node affinities useful for running workloads on sole tenant nodes. node_affinity structure is documented below.</summary>
    [JsonPropertyName("soleTenantConfig")]
    public V1beta1ClusterStatusAtProviderNodeConfigSoleTenantConfig? SoleTenantConfig { get; set; }

    /// <summary>A boolean that represents whether the underlying node VMs are spot. See the official documentation for more information. Defaults to false.</summary>
    [JsonPropertyName("spot")]
    public bool? Spot { get; set; }

    /// <summary>The list of Storage Pools where boot disks are provisioned.</summary>
    [JsonPropertyName("storagePools")]
    public IList<string>? StoragePools { get; set; }

    /// <summary>The list of instance tags applied to all nodes. Tags are used to identify valid sources or targets for network firewalls.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>A list of Kubernetes taints to apply to nodes. Structure is documented below.</summary>
    [JsonPropertyName("taint")]
    public IList<V1beta1ClusterStatusAtProviderNodeConfigTaint>? Taint { get; set; }

    /// <summary>Windows node configuration, currently supporting OSVersion attribute. The value must be one of [OS_VERSION_UNSPECIFIED, OS_VERSION_LTSC2019, OS_VERSION_LTSC2022]. For example:</summary>
    [JsonPropertyName("windowsNodeConfig")]
    public V1beta1ClusterStatusAtProviderNodeConfigWindowsNodeConfig? WindowsNodeConfig { get; set; }

    /// <summary>Metadata configuration to expose to workloads on the node pool. Structure is documented below.</summary>
    [JsonPropertyName("workloadMetadataConfig")]
    public V1beta1ClusterStatusAtProviderNodeConfigWorkloadMetadataConfig? WorkloadMetadataConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolAutoscaling
{
    /// <summary></summary>
    [JsonPropertyName("locationPolicy")]
    public string? LocationPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxNodeCount")]
    public double? MaxNodeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minNodeCount")]
    public double? MinNodeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("totalMaxNodeCount")]
    public double? TotalMaxNodeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("totalMinNodeCount")]
    public double? TotalMinNodeCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary>NodeManagement configuration for this NodePool. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolManagement
{
    /// <summary>Specifies whether the node auto-repair is enabled for the node pool. If enabled, the nodes in this node pool will be monitored and, if they fail health checks too many times, an automatic repair action will be triggered.</summary>
    [JsonPropertyName("autoRepair")]
    public bool? AutoRepair { get; set; }

    /// <summary>Specifies whether node auto-upgrade is enabled for the node pool. If enabled, node auto-upgrade helps keep the nodes in your node pool up to date with the latest release version of Kubernetes.</summary>
    [JsonPropertyName("autoUpgrade")]
    public bool? AutoUpgrade { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNetworkConfigAdditionalNodeNetworkConfigs
{
    /// <summary>The name or self_link of the Google Compute Engine network to which the cluster is connected. For Shared VPC, set this to the self link of the shared network.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>The name or self_link of the Google Compute Engine subnetwork in which the cluster's instances are launched.</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNetworkConfigAdditionalPodNetworkConfigs
{
    /// <summary></summary>
    [JsonPropertyName("maxPodsPerNode")]
    public double? MaxPodsPerNode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secondaryPodRange")]
    public string? SecondaryPodRange { get; set; }

    /// <summary>The name or self_link of the Google Compute Engine subnetwork in which the cluster's instances are launched.</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Network bandwidth tier configuration. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNetworkConfigNetworkPerformanceConfig
{
    /// <summary>Specifies the total network bandwidth tier for NodePools in the cluster.</summary>
    [JsonPropertyName("totalEgressBandwidthTier")]
    public string? TotalEgressBandwidthTier { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNetworkConfigPodCidrOverprovisionConfig
{
    /// <summary>The status of the Istio addon, which makes it easy to set up Istio for services in a cluster. It is disabled by default. Set disabled = false to enable.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNetworkConfig
{
    /// <summary></summary>
    [JsonPropertyName("additionalNodeNetworkConfigs")]
    public IList<V1beta1ClusterStatusAtProviderNodePoolNetworkConfigAdditionalNodeNetworkConfigs>? AdditionalNodeNetworkConfigs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalPodNetworkConfigs")]
    public IList<V1beta1ClusterStatusAtProviderNodePoolNetworkConfigAdditionalPodNetworkConfigs>? AdditionalPodNetworkConfigs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createPodRange")]
    public bool? CreatePodRange { get; set; }

    /// <summary>Enables the private cluster feature, creating a private endpoint on the cluster. In a private cluster, nodes only have RFC 1918 private addresses and communicate with the master's private endpoint via private networking.</summary>
    [JsonPropertyName("enablePrivateNodes")]
    public bool? EnablePrivateNodes { get; set; }

    /// <summary>Network bandwidth tier configuration. Structure is documented below.</summary>
    [JsonPropertyName("networkPerformanceConfig")]
    public V1beta1ClusterStatusAtProviderNodePoolNetworkConfigNetworkPerformanceConfig? NetworkPerformanceConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podCidrOverprovisionConfig")]
    public V1beta1ClusterStatusAtProviderNodePoolNetworkConfigPodCidrOverprovisionConfig? PodCidrOverprovisionConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podIpv4CidrBlock")]
    public string? PodIpv4CidrBlock { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podRange")]
    public string? PodRange { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies options for controlling advanced machine features. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNodeConfigAdvancedMachineFeatures
{
    /// <summary>Defines whether the instance should have nested virtualization enabled. Defaults to false.</summary>
    [JsonPropertyName("enableNestedVirtualization")]
    public bool? EnableNestedVirtualization { get; set; }

    /// <summary>Defines the performance monitoring unit PMU level. Valid values are ARCHITECTURAL, STANDARD, or ENHANCED. Defaults to off.</summary>
    [JsonPropertyName("performanceMonitoringUnit")]
    public string? PerformanceMonitoringUnit { get; set; }

    /// <summary>The number of threads per physical core. To disable simultaneous multithreading (SMT) set this to 1. If unset, the maximum number of threads supported per core by the underlying processor is assumed.</summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for Confidential Nodes feature. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNodeConfigConfidentialNodes
{
    /// <summary>Defines the type of technology used by the confidential node.</summary>
    [JsonPropertyName("confidentialInstanceType")]
    public string? ConfidentialInstanceType { get; set; }

    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig
{
    /// <summary></summary>
    [JsonPropertyName("secretUri")]
    public string? SecretUri { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig
{
    /// <summary></summary>
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpSecretManagerCertificateConfig")]
    public V1beta1ClusterStatusAtProviderNodePoolNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig? GcpSecretManagerCertificateConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for private container registries. There are two fields in this config:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNodeConfigContainerdConfigPrivateRegistryAccessConfig
{
    /// <summary>List of configuration objects for CA and domains. Each object identifies a certificate and its assigned domains. See how to configure for private container registries for more detail. Example:</summary>
    [JsonPropertyName("certificateAuthorityDomainConfig")]
    public IList<V1beta1ClusterStatusAtProviderNodePoolNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig>? CertificateAuthorityDomainConfig { get; set; }

    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters to customize containerd runtime. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNodeConfigContainerdConfig
{
    /// <summary>Configuration for private container registries. There are two fields in this config:</summary>
    [JsonPropertyName("privateRegistryAccessConfig")]
    public V1beta1ClusterStatusAtProviderNodePoolNodeConfigContainerdConfigPrivateRegistryAccessConfig? PrivateRegistryAccessConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNodeConfigEffectiveTaints
{
    /// <summary>Effect for taint. Accepted values are NO_SCHEDULE, PREFER_NO_SCHEDULE, and NO_EXECUTE.</summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>Key for taint.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value for taint.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters for the ephemeral storage filesystem. If unspecified, ephemeral storage is backed by the boot disk. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNodeConfigEphemeralStorageLocalSsdConfig
{
    /// <summary>Number of raw-block local NVMe SSD disks to be attached to the node utilized for GKE Data Cache. If zero, then GKE Data Cache will not be enabled in the nodes.</summary>
    [JsonPropertyName("dataCacheCount")]
    public double? DataCacheCount { get; set; }

    /// <summary>The amount of local SSD disks that will be attached to each cluster node. Defaults to 0.</summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters for the NCCL Fast Socket feature. If unspecified, NCCL Fast Socket will not be enabled on the node pool. Node Pool must enable gvnic. GKE version 1.25.2-gke.1700 or later. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNodeConfigFastSocket
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The default Google Container Filesystem (GCFS) configuration at the cluster level. e.g. enable image streaming across all the node pools within the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNodeConfigGcfsConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for auto installation of GPU driver. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNodeConfigGuestAcceleratorGpuDriverInstallationConfig
{
    /// <summary>Mode for how the GPU driver is installed. Accepted values are:</summary>
    [JsonPropertyName("gpuDriverVersion")]
    public string? GpuDriverVersion { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for GPU sharing. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNodeConfigGuestAcceleratorGpuSharingConfig
{
    /// <summary>The type of GPU sharing strategy to enable on the GPU node. Accepted values are:</summary>
    [JsonPropertyName("gpuSharingStrategy")]
    public string? GpuSharingStrategy { get; set; }

    /// <summary>The maximum number of containers that can share a GPU.</summary>
    [JsonPropertyName("maxSharedClientsPerGpu")]
    public double? MaxSharedClientsPerGpu { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNodeConfigGuestAccelerator
{
    /// <summary>The number of the guest accelerator cards exposed to this instance.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>Configuration for auto installation of GPU driver. Structure is documented below.</summary>
    [JsonPropertyName("gpuDriverInstallationConfig")]
    public V1beta1ClusterStatusAtProviderNodePoolNodeConfigGuestAcceleratorGpuDriverInstallationConfig? GpuDriverInstallationConfig { get; set; }

    /// <summary>Size of partitions to create on the GPU. Valid values are described in the NVIDIA mig user guide.</summary>
    [JsonPropertyName("gpuPartitionSize")]
    public string? GpuPartitionSize { get; set; }

    /// <summary>Configuration for GPU sharing. Structure is documented below.</summary>
    [JsonPropertyName("gpuSharingConfig")]
    public V1beta1ClusterStatusAtProviderNodePoolNodeConfigGuestAcceleratorGpuSharingConfig? GpuSharingConfig { get; set; }

    /// <summary>The accelerator type resource to expose to this instance. E.g. nvidia-tesla-k80.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Google Virtual NIC (gVNIC) is a virtual network interface. Installing the gVNIC driver allows for more efficient traffic transmission across the Google network infrastructure. gVNIC is an alternative to the virtIO-based ethernet driver. GKE nodes must use a Container-Optimized OS node image. GKE node version 1.15.11-gke.15 or later Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNodeConfigGvnic
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The maintenance policy to use for the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNodeConfigHostMaintenancePolicy
{
    /// <summary></summary>
    [JsonPropertyName("maintenanceInterval")]
    public string? MaintenanceInterval { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Kubelet configuration, currently supported attributes can be found here. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNodeConfigKubeletConfig
{
    /// <summary>Defines a comma-separated allowlist of unsafe sysctls or sysctl patterns which can be set on the Pods. The allowed sysctl groups are kernel.shm*, kernel.msg*, kernel.sem, fs.mqueue.*, and net.*.</summary>
    [JsonPropertyName("allowedUnsafeSysctls")]
    public IList<string>? AllowedUnsafeSysctls { get; set; }

    /// <summary>Defines the maximum number of container log files that can be present for a container. The integer must be between 2 and 10, inclusive.</summary>
    [JsonPropertyName("containerLogMaxFiles")]
    public double? ContainerLogMaxFiles { get; set; }

    /// <summary>Defines the maximum size of the container log file before it is rotated. Specified as a positive number and a unit suffix, such as "100Ki", "10Mi". Valid units are "Ki", "Mi", "Gi". The value must be between "10Mi" and "500Mi", inclusive. And the total container log size (container_log_max_size * container_log_max_files) cannot exceed 1% of the total storage of the node.</summary>
    [JsonPropertyName("containerLogMaxSize")]
    public string? ContainerLogMaxSize { get; set; }

    /// <summary>If true, enables CPU CFS quota enforcement for containers that specify CPU limits.</summary>
    [JsonPropertyName("cpuCfsQuota")]
    public bool? CpuCfsQuota { get; set; }

    /// <summary>The CPU CFS quota period value. Specified as a sequence of decimal numbers, each with optional fraction and a unit suffix, such as "300ms". Valid time units are "ns", "us" (or "µs"), "ms", "s", "m", "h". The value must be a positive duration.</summary>
    [JsonPropertyName("cpuCfsQuotaPeriod")]
    public string? CpuCfsQuotaPeriod { get; set; }

    /// <summary>The CPU management policy on the node. See K8S CPU Management Policies. One of "none" or "static". If unset (or set to the empty string ""), the API will treat the field as if set to "none". Prior to the 6.4.0 this field was marked as required. The workaround for the required field is setting the empty string "", which will function identically to not setting this field.</summary>
    [JsonPropertyName("cpuManagerPolicy")]
    public string? CpuManagerPolicy { get; set; }

    /// <summary>Defines the percent of disk usage after which image garbage collection is always run. The integer must be between 10 and 85, inclusive.</summary>
    [JsonPropertyName("imageGcHighThresholdPercent")]
    public double? ImageGcHighThresholdPercent { get; set; }

    /// <summary>Defines the percent of disk usage before which image garbage collection is never run. Lowest disk usage to garbage collect to. The integer must be between 10 and 85, inclusive.</summary>
    [JsonPropertyName("imageGcLowThresholdPercent")]
    public double? ImageGcLowThresholdPercent { get; set; }

    /// <summary>Defines the maximum age an image can be unused before it is garbage collected. Specified as a sequence of decimal numbers, each with optional fraction and a unit suffix, such as "300s", "1.5m", and "2h45m". Valid time units are "ns", "us" (or "µs"), "ms", "s", "m", "h". The value must be a positive duration.</summary>
    [JsonPropertyName("imageMaximumGcAge")]
    public string? ImageMaximumGcAge { get; set; }

    /// <summary>Defines the minimum age for an unused image before it is garbage collected. Specified as a sequence of decimal numbers, each with optional fraction and a unit suffix, such as "300s", "1.5m". The value cannot be greater than "2m".</summary>
    [JsonPropertyName("imageMinimumGcAge")]
    public string? ImageMinimumGcAge { get; set; }

    /// <summary>only port is enabled for newly created node pools in the cluster. It is strongly recommended to set this to FALSE. Possible values: TRUE, FALSE.</summary>
    [JsonPropertyName("insecureKubeletReadonlyPortEnabled")]
    public string? InsecureKubeletReadonlyPortEnabled { get; set; }

    /// <summary>Controls the maximum number of processes allowed to run in a pod. The value must be greater than or equal to 1024 and less than 4194304.</summary>
    [JsonPropertyName("podPidsLimit")]
    public double? PodPidsLimit { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Amounts for 2M and 1G hugepages. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNodeConfigLinuxNodeConfigHugepagesConfig
{
    /// <summary>Amount of 1G hugepages.</summary>
    [JsonPropertyName("hugepageSize1G")]
    public double? HugepageSize1G { get; set; }

    /// <summary>Amount of 2M hugepages.</summary>
    [JsonPropertyName("hugepageSize2M")]
    public double? HugepageSize2M { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Linux system configuration for the cluster's automatically provisioned node pools. Only cgroup_mode field is supported in node_pool_auto_config. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNodeConfigLinuxNodeConfig
{
    /// <summary>Possible cgroup modes that can be used. Accepted values are:</summary>
    [JsonPropertyName("cgroupMode")]
    public string? CgroupMode { get; set; }

    /// <summary>Amounts for 2M and 1G hugepages. Structure is documented below.</summary>
    [JsonPropertyName("hugepagesConfig")]
    public V1beta1ClusterStatusAtProviderNodePoolNodeConfigLinuxNodeConfigHugepagesConfig? HugepagesConfig { get; set; }

    /// <summary>The Linux kernel parameters to be applied to the nodes and all pods running on the nodes. Specified as a map from the key, such as net.core.wmem_max, to a string value. Currently supported attributes can be found here. Note that validations happen all server side. All attributes are optional.</summary>
    [JsonPropertyName("sysctls")]
    public IDictionary<string, string>? Sysctls { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters for the local NVMe SSDs. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNodeConfigLocalNvmeSsdBlockConfig
{
    /// <summary>The amount of local SSD disks that will be attached to each cluster node. Defaults to 0.</summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The configuration of the desired reservation which instances could take capacity from. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNodeConfigReservationAffinity
{
    /// <summary>The type of reservation consumption Accepted values are:</summary>
    [JsonPropertyName("consumeReservationType")]
    public string? ConsumeReservationType { get; set; }

    /// <summary>Key for taint.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>name"</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNodeConfigSecondaryBootDisks
{
    /// <summary>Path to disk image to create the secondary boot disk from. After using the gke-disk-image-builder, this argument should be global/images/DISK_IMAGE_NAME.</summary>
    [JsonPropertyName("diskImage")]
    public string? DiskImage { get; set; }

    /// <summary>How to expose the node metadata to the workload running on the node. Accepted values are:</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Shielded Instance options. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNodeConfigShieldedInstanceConfig
{
    /// <summary>Defines if the instance has integrity monitoring enabled.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>Defines if the instance has Secure Boot enabled.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNodeConfigSoleTenantConfigNodeAffinity
{
    /// <summary>Key for taint.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Specifies affinity or anti-affinity. Accepted values are "IN" or "NOT_IN"</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>name"</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Allows specifying multiple node affinities useful for running workloads on sole tenant nodes. node_affinity structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNodeConfigSoleTenantConfig
{
    /// <summary></summary>
    [JsonPropertyName("nodeAffinity")]
    public IList<V1beta1ClusterStatusAtProviderNodePoolNodeConfigSoleTenantConfigNodeAffinity>? NodeAffinity { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNodeConfigTaint
{
    /// <summary>Effect for taint. Accepted values are NO_SCHEDULE, PREFER_NO_SCHEDULE, and NO_EXECUTE.</summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>Key for taint.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Value for taint.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Windows node configuration, currently supporting OSVersion attribute. The value must be one of [OS_VERSION_UNSPECIFIED, OS_VERSION_LTSC2019, OS_VERSION_LTSC2022]. For example:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNodeConfigWindowsNodeConfig
{
    /// <summary></summary>
    [JsonPropertyName("osversion")]
    public string? Osversion { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Metadata configuration to expose to workloads on the node pool. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNodeConfigWorkloadMetadataConfig
{
    /// <summary>How to expose the node metadata to the workload running on the node. Accepted values are:</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters used in creating the default node pool. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolNodeConfig
{
    /// <summary>Specifies options for controlling advanced machine features. Structure is documented below.</summary>
    [JsonPropertyName("advancedMachineFeatures")]
    public V1beta1ClusterStatusAtProviderNodePoolNodeConfigAdvancedMachineFeatures? AdvancedMachineFeatures { get; set; }

    /// <summary>The Customer Managed Encryption Key used to encrypt the boot disk attached to each node in the node pool. This should be of the form projects/[KEY_PROJECT_ID]/locations/[LOCATION]/keyRings/[RING_NAME]/cryptoKeys/[KEY_NAME]. For more information about protecting resources with Cloud KMS Keys please see: https://cloud.google.com/compute/docs/disks/customer-managed-encryption</summary>
    [JsonPropertyName("bootDiskKmsKey")]
    public string? BootDiskKmsKey { get; set; }

    /// <summary>Configuration for Confidential Nodes feature. Structure is documented below.</summary>
    [JsonPropertyName("confidentialNodes")]
    public V1beta1ClusterStatusAtProviderNodePoolNodeConfigConfidentialNodes? ConfidentialNodes { get; set; }

    /// <summary>Parameters to customize containerd runtime. Structure is documented below.</summary>
    [JsonPropertyName("containerdConfig")]
    public V1beta1ClusterStatusAtProviderNodePoolNodeConfigContainerdConfig? ContainerdConfig { get; set; }

    /// <summary>Size of the disk attached to each node, specified in GB. The smallest allowed disk size is 10GB. Defaults to 100GB.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>Type of the disk attached to each node (e.g. 'pd-standard', 'pd-balanced' or 'pd-ssd'). If unspecified, the default disk type is 'pd-balanced'</summary>
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    /// <summary>List of kubernetes taints applied to each node. Structure is documented above.</summary>
    [JsonPropertyName("effectiveTaints")]
    public IList<V1beta1ClusterStatusAtProviderNodePoolNodeConfigEffectiveTaints>? EffectiveTaints { get; set; }

    /// <summary>Enabling Confidential Storage will create boot disk with confidential mode. It is disabled by default.</summary>
    [JsonPropertyName("enableConfidentialStorage")]
    public bool? EnableConfidentialStorage { get; set; }

    /// <summary>Parameters for the ephemeral storage filesystem. If unspecified, ephemeral storage is backed by the boot disk. Structure is documented below.</summary>
    [JsonPropertyName("ephemeralStorageLocalSsdConfig")]
    public V1beta1ClusterStatusAtProviderNodePoolNodeConfigEphemeralStorageLocalSsdConfig? EphemeralStorageLocalSsdConfig { get; set; }

    /// <summary>Parameters for the NCCL Fast Socket feature. If unspecified, NCCL Fast Socket will not be enabled on the node pool. Node Pool must enable gvnic. GKE version 1.25.2-gke.1700 or later. Structure is documented below.</summary>
    [JsonPropertyName("fastSocket")]
    public V1beta1ClusterStatusAtProviderNodePoolNodeConfigFastSocket? FastSocket { get; set; }

    /// <summary>Enables Flex Start provisioning model for the node pool.</summary>
    [JsonPropertyName("flexStart")]
    public bool? FlexStart { get; set; }

    /// <summary>The default Google Container Filesystem (GCFS) configuration at the cluster level. e.g. enable image streaming across all the node pools within the cluster. Structure is documented below.</summary>
    [JsonPropertyName("gcfsConfig")]
    public V1beta1ClusterStatusAtProviderNodePoolNodeConfigGcfsConfig? GcfsConfig { get; set; }

    /// <summary>List of the type and count of accelerator cards attached to the instance. Structure documented below. Note: As of 6.0.0, argument syntax is no longer supported for this field in favor of block syntax. To dynamically set a list of guest accelerators, use dynamic blocks. To set an empty list, use a single guest_accelerator block with count = 0.</summary>
    [JsonPropertyName("guestAccelerator")]
    public IList<V1beta1ClusterStatusAtProviderNodePoolNodeConfigGuestAccelerator>? GuestAccelerator { get; set; }

    /// <summary>Google Virtual NIC (gVNIC) is a virtual network interface. Installing the gVNIC driver allows for more efficient traffic transmission across the Google network infrastructure. gVNIC is an alternative to the virtIO-based ethernet driver. GKE nodes must use a Container-Optimized OS node image. GKE node version 1.15.11-gke.15 or later Structure is documented below.</summary>
    [JsonPropertyName("gvnic")]
    public V1beta1ClusterStatusAtProviderNodePoolNodeConfigGvnic? Gvnic { get; set; }

    /// <summary>The maintenance policy to use for the cluster. Structure is documented below.</summary>
    [JsonPropertyName("hostMaintenancePolicy")]
    public V1beta1ClusterStatusAtProviderNodePoolNodeConfigHostMaintenancePolicy? HostMaintenancePolicy { get; set; }

    /// <summary>The image type to use for this node. Note that changing the image type will delete and recreate all nodes in the node pool.</summary>
    [JsonPropertyName("imageType")]
    public string? ImageType { get; set; }

    /// <summary>Kubelet configuration, currently supported attributes can be found here. Structure is documented below.</summary>
    [JsonPropertyName("kubeletConfig")]
    public V1beta1ClusterStatusAtProviderNodePoolNodeConfigKubeletConfig? KubeletConfig { get; set; }

    /// <summary>The Kubernetes labels (key/value pairs) to be applied to each node. The kubernetes.io/ and k8s.io/ prefixes are reserved by Kubernetes Core components and cannot be specified.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Linux system configuration for the cluster's automatically provisioned node pools. Only cgroup_mode field is supported in node_pool_auto_config. Structure is documented below.</summary>
    [JsonPropertyName("linuxNodeConfig")]
    public V1beta1ClusterStatusAtProviderNodePoolNodeConfigLinuxNodeConfig? LinuxNodeConfig { get; set; }

    /// <summary>Parameters for the local NVMe SSDs. Structure is documented below.</summary>
    [JsonPropertyName("localNvmeSsdBlockConfig")]
    public V1beta1ClusterStatusAtProviderNodePoolNodeConfigLocalNvmeSsdBlockConfig? LocalNvmeSsdBlockConfig { get; set; }

    /// <summary>The amount of local SSD disks that will be attached to each cluster node. Defaults to 0.</summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary>Possible Local SSD encryption modes: Accepted values are:</summary>
    [JsonPropertyName("localSsdEncryptionMode")]
    public string? LocalSsdEncryptionMode { get; set; }

    /// <summary>The type of logging agent that is deployed by default for newly created node pools in the cluster. Valid values include DEFAULT and MAX_THROUGHPUT. See Increasing logging agent throughput for more information.</summary>
    [JsonPropertyName("loggingVariant")]
    public string? LoggingVariant { get; set; }

    /// <summary>The name of a Google Compute Engine machine type. Defaults to e2-medium. To create a custom machine type, value should be set as specified here.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>The runtime of each node in the node pool in seconds, terminated by 's'. Example: "3600s".</summary>
    [JsonPropertyName("maxRunDuration")]
    public string? MaxRunDuration { get; set; }

    /// <summary>The metadata key/value pairs assigned to instances in the cluster. From GKE 1. To avoid this, set the value in your config.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Minimum CPU platform to be used by this instance. The instance may be scheduled on the specified or newer CPU platform. Applicable values are the friendly names of CPU platforms, such as Intel Haswell. See the official documentation for more information.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>Setting this field will assign instances of this pool to run on the specified node group. This is useful for running workloads on sole tenant nodes.</summary>
    [JsonPropertyName("nodeGroup")]
    public string? NodeGroup { get; set; }

    /// <summary>The set of Google API scopes to be made available on all of the node VMs under the "default" service account. Use the "https://www.googleapis.com/auth/cloud-platform" scope to grant access to all APIs. It is recommended that you set service_account to a non-default service account and grant IAM roles to that service account for only the resources that it needs.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }

    /// <summary>A boolean that represents whether or not the underlying node VMs are preemptible. See the official documentation for more information. Defaults to false.</summary>
    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    /// <summary>The configuration of the desired reservation which instances could take capacity from. Structure is documented below.</summary>
    [JsonPropertyName("reservationAffinity")]
    public V1beta1ClusterStatusAtProviderNodePoolNodeConfigReservationAffinity? ReservationAffinity { get; set; }

    /// <summary>The GCE resource labels (a map of key/value pairs) to be applied to the cluster.</summary>
    [JsonPropertyName("resourceLabels")]
    public IDictionary<string, string>? ResourceLabels { get; set; }

    /// <summary>A map of resource manager tag keys and values to be attached to the nodes for managing Compute Engine firewalls using Network Firewall Policies. Tags must be according to specifications found here. A maximum of 5 tag key-value pairs can be specified. Existing tags will be replaced with new values. Tags must be in one of the following formats ([KEY]=[VALUE]) 1. tagKeys/{tag_key_id}=tagValues/{tag_value_id} 2. {org_id}/{tag_key_name}={tag_value_name} 3. {project_id}/{tag_key_name}={tag_value_name}.</summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }

    /// <summary>Parameters for secondary boot disks to preload container images and data on new nodes. Structure is documented below. gcfs_config must be enabled=true for this feature to work. min_master_version must also be set to use GKE 1.28.3-gke.106700 or later versions.</summary>
    [JsonPropertyName("secondaryBootDisks")]
    public IList<V1beta1ClusterStatusAtProviderNodePoolNodeConfigSecondaryBootDisks>? SecondaryBootDisks { get; set; }

    /// <summary>The service account to be used by the Node VMs. If not specified, the "default" service account is used.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Shielded Instance options. Structure is documented below.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta1ClusterStatusAtProviderNodePoolNodeConfigShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    /// <summary>Allows specifying multiple node affinities useful for running workloads on sole tenant nodes. node_affinity structure is documented below.</summary>
    [JsonPropertyName("soleTenantConfig")]
    public V1beta1ClusterStatusAtProviderNodePoolNodeConfigSoleTenantConfig? SoleTenantConfig { get; set; }

    /// <summary>A boolean that represents whether the underlying node VMs are spot. See the official documentation for more information. Defaults to false.</summary>
    [JsonPropertyName("spot")]
    public bool? Spot { get; set; }

    /// <summary>The list of Storage Pools where boot disks are provisioned.</summary>
    [JsonPropertyName("storagePools")]
    public IList<string>? StoragePools { get; set; }

    /// <summary>The list of instance tags applied to all nodes. Tags are used to identify valid sources or targets for network firewalls.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>A list of Kubernetes taints to apply to nodes. Structure is documented below.</summary>
    [JsonPropertyName("taint")]
    public IList<V1beta1ClusterStatusAtProviderNodePoolNodeConfigTaint>? Taint { get; set; }

    /// <summary>Windows node configuration, currently supporting OSVersion attribute. The value must be one of [OS_VERSION_UNSPECIFIED, OS_VERSION_LTSC2019, OS_VERSION_LTSC2022]. For example:</summary>
    [JsonPropertyName("windowsNodeConfig")]
    public V1beta1ClusterStatusAtProviderNodePoolNodeConfigWindowsNodeConfig? WindowsNodeConfig { get; set; }

    /// <summary>Metadata configuration to expose to workloads on the node pool. Structure is documented below.</summary>
    [JsonPropertyName("workloadMetadataConfig")]
    public V1beta1ClusterStatusAtProviderNodePoolNodeConfigWorkloadMetadataConfig? WorkloadMetadataConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolPlacementPolicy
{
    /// <summary>The name of the cluster, unique within the project and location.</summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tpuTopology")]
    public string? TpuTopology { get; set; }

    /// <summary>The accelerator type resource to expose to this instance. E.g. nvidia-tesla-k80.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolQueuedProvisioning
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>green upgrade. To be specified when strategy is set to BLUE_GREEN. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy
{
    /// <summary>Number of blue nodes to drain in a batch. Only one of the batch_percentage or batch_node_count can be specified.</summary>
    [JsonPropertyName("batchNodeCount")]
    public double? BatchNodeCount { get; set; }

    /// <summary>:  Percentage of the bool pool nodes to drain in a batch. The range of this field should be (0.0, 1.0). Only one of the batch_percentage or batch_node_count can be specified.</summary>
    [JsonPropertyName("batchPercentage")]
    public double? BatchPercentage { get; set; }

    /// <summary>Soak time after each batch gets drained. A duration in seconds with up to nine fractional digits, ending with 's'. Example: "3.5s".`.</summary>
    [JsonPropertyName("batchSoakDuration")]
    public string? BatchSoakDuration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Settings for blue-green upgrade strategy. To be specified when strategy is set to BLUE_GREEN. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolUpgradeSettingsBlueGreenSettings
{
    /// <summary>Time needed after draining entire blue pool. After this period, blue pool will be cleaned up. A duration in seconds with up to nine fractional digits, ending with 's'. Example: "3.5s".</summary>
    [JsonPropertyName("nodePoolSoakDuration")]
    public string? NodePoolSoakDuration { get; set; }

    /// <summary>green upgrade. To be specified when strategy is set to BLUE_GREEN. Structure is documented below.</summary>
    [JsonPropertyName("standardRolloutPolicy")]
    public V1beta1ClusterStatusAtProviderNodePoolUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy? StandardRolloutPolicy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Specifies the upgrade settings for NAP created node pools. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolUpgradeSettings
{
    /// <summary>Settings for blue-green upgrade strategy. To be specified when strategy is set to BLUE_GREEN. Structure is documented below.</summary>
    [JsonPropertyName("blueGreenSettings")]
    public V1beta1ClusterStatusAtProviderNodePoolUpgradeSettingsBlueGreenSettings? BlueGreenSettings { get; set; }

    /// <summary>The maximum number of nodes that can be created beyond the current size of the node pool during the upgrade process. To be used when strategy is set to SURGE. Default is 0.</summary>
    [JsonPropertyName("maxSurge")]
    public double? MaxSurge { get; set; }

    /// <summary>The maximum number of nodes that can be simultaneously unavailable during the upgrade process. To be used when strategy is set to SURGE. Default is 0.</summary>
    [JsonPropertyName("maxUnavailable")]
    public double? MaxUnavailable { get; set; }

    /// <summary>Strategy used for node pool update. Strategy can only be one of BLUE_GREEN or SURGE. The default is value is SURGE.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePool
{
    /// <summary></summary>
    [JsonPropertyName("autoscaling")]
    public V1beta1ClusterStatusAtProviderNodePoolAutoscaling? Autoscaling { get; set; }

    /// <summary>The number of nodes to create in this cluster's default node pool. In regional or multi-zonal clusters, this is the number of nodes per zone. Must be set if node_pool is not set. If you're using google_container_node_pool objects with no default node pool, you'll need to set this to a value of at least 1, alongside setting remove_default_node_pool to true.</summary>
    [JsonPropertyName("initialNodeCount")]
    public double? InitialNodeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("instanceGroupUrls")]
    public IList<string>? InstanceGroupUrls { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedInstanceGroupUrls")]
    public IList<string>? ManagedInstanceGroupUrls { get; set; }

    /// <summary>NodeManagement configuration for this NodePool. Structure is documented below.</summary>
    [JsonPropertyName("management")]
    public V1beta1ClusterStatusAtProviderNodePoolManagement? Management { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxPodsPerNode")]
    public double? MaxPodsPerNode { get; set; }

    /// <summary>The name of the cluster, unique within the project and location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkConfig")]
    public V1beta1ClusterStatusAtProviderNodePoolNetworkConfig? NetworkConfig { get; set; }

    /// <summary>Parameters used in creating the default node pool. Structure is documented below.</summary>
    [JsonPropertyName("nodeConfig")]
    public V1beta1ClusterStatusAtProviderNodePoolNodeConfig? NodeConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>The list of zones in which the cluster's nodes are located. Nodes must be in the region of their regional cluster or in the same region as their cluster's zone for zonal clusters. If this is specified for a zonal cluster, omit the cluster's zone.</summary>
    [JsonPropertyName("nodeLocations")]
    public IList<string>? NodeLocations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("placementPolicy")]
    public V1beta1ClusterStatusAtProviderNodePoolPlacementPolicy? PlacementPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("queuedProvisioning")]
    public V1beta1ClusterStatusAtProviderNodePoolQueuedProvisioning? QueuedProvisioning { get; set; }

    /// <summary>Specifies the upgrade settings for NAP created node pools. Structure is documented below.</summary>
    [JsonPropertyName("upgradeSettings")]
    public V1beta1ClusterStatusAtProviderNodePoolUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Linux system configuration for the cluster's automatically provisioned node pools. Only cgroup_mode field is supported in node_pool_auto_config. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolAutoConfigLinuxNodeConfig
{
    /// <summary>Possible cgroup modes that can be used. Accepted values are:</summary>
    [JsonPropertyName("cgroupMode")]
    public string? CgroupMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The network tag config for the cluster's automatically provisioned node pools. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolAutoConfigNetworkTags
{
    /// <summary>The list of instance tags applied to all nodes. Tags are used to identify valid sources or targets for network firewalls.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Kubelet configuration for Autopilot clusters. Currently, only insecure_kubelet_readonly_port_enabled is supported here. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolAutoConfigNodeKubeletConfig
{
    /// <summary>only port is enabled for newly created node pools in the cluster. It is strongly recommended to set this to FALSE. Possible values: TRUE, FALSE.</summary>
    [JsonPropertyName("insecureKubeletReadonlyPortEnabled")]
    public string? InsecureKubeletReadonlyPortEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Node pool configs that apply to auto-provisioned node pools in autopilot clusters and node auto-provisioning-enabled clusters. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolAutoConfig
{
    /// <summary>Linux system configuration for the cluster's automatically provisioned node pools. Only cgroup_mode field is supported in node_pool_auto_config. Structure is documented below.</summary>
    [JsonPropertyName("linuxNodeConfig")]
    public V1beta1ClusterStatusAtProviderNodePoolAutoConfigLinuxNodeConfig? LinuxNodeConfig { get; set; }

    /// <summary>The network tag config for the cluster's automatically provisioned node pools. Structure is documented below.</summary>
    [JsonPropertyName("networkTags")]
    public V1beta1ClusterStatusAtProviderNodePoolAutoConfigNetworkTags? NetworkTags { get; set; }

    /// <summary>Kubelet configuration for Autopilot clusters. Currently, only insecure_kubelet_readonly_port_enabled is supported here. Structure is documented below.</summary>
    [JsonPropertyName("nodeKubeletConfig")]
    public V1beta1ClusterStatusAtProviderNodePoolAutoConfigNodeKubeletConfig? NodeKubeletConfig { get; set; }

    /// <summary>A map of resource manager tag keys and values to be attached to the nodes for managing Compute Engine firewalls using Network Firewall Policies. Tags must be according to specifications found here. A maximum of 5 tag key-value pairs can be specified. Existing tags will be replaced with new values. Tags must be in one of the following formats ([KEY]=[VALUE]) 1. tagKeys/{tag_key_id}=tagValues/{tag_value_id} 2. {org_id}/{tag_key_name}={tag_value_name} 3. {project_id}/{tag_key_name}={tag_value_name}.</summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolDefaultsNodeConfigDefaultsContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig
{
    /// <summary></summary>
    [JsonPropertyName("secretUri")]
    public string? SecretUri { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolDefaultsNodeConfigDefaultsContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig
{
    /// <summary></summary>
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpSecretManagerCertificateConfig")]
    public V1beta1ClusterStatusAtProviderNodePoolDefaultsNodeConfigDefaultsContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig? GcpSecretManagerCertificateConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for private container registries. There are two fields in this config:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolDefaultsNodeConfigDefaultsContainerdConfigPrivateRegistryAccessConfig
{
    /// <summary>List of configuration objects for CA and domains. Each object identifies a certificate and its assigned domains. See how to configure for private container registries for more detail. Example:</summary>
    [JsonPropertyName("certificateAuthorityDomainConfig")]
    public IList<V1beta1ClusterStatusAtProviderNodePoolDefaultsNodeConfigDefaultsContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig>? CertificateAuthorityDomainConfig { get; set; }

    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters to customize containerd runtime. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolDefaultsNodeConfigDefaultsContainerdConfig
{
    /// <summary>Configuration for private container registries. There are two fields in this config:</summary>
    [JsonPropertyName("privateRegistryAccessConfig")]
    public V1beta1ClusterStatusAtProviderNodePoolDefaultsNodeConfigDefaultsContainerdConfigPrivateRegistryAccessConfig? PrivateRegistryAccessConfig { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The default Google Container Filesystem (GCFS) configuration at the cluster level. e.g. enable image streaming across all the node pools within the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolDefaultsNodeConfigDefaultsGcfsConfig
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Subset of NodeConfig message that has defaults.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolDefaultsNodeConfigDefaults
{
    /// <summary>Parameters to customize containerd runtime. Structure is documented below.</summary>
    [JsonPropertyName("containerdConfig")]
    public V1beta1ClusterStatusAtProviderNodePoolDefaultsNodeConfigDefaultsContainerdConfig? ContainerdConfig { get; set; }

    /// <summary>The default Google Container Filesystem (GCFS) configuration at the cluster level. e.g. enable image streaming across all the node pools within the cluster. Structure is documented below.</summary>
    [JsonPropertyName("gcfsConfig")]
    public V1beta1ClusterStatusAtProviderNodePoolDefaultsNodeConfigDefaultsGcfsConfig? GcfsConfig { get; set; }

    /// <summary>only port is enabled for newly created node pools in the cluster. It is strongly recommended to set this to FALSE. Possible values: TRUE, FALSE.</summary>
    [JsonPropertyName("insecureKubeletReadonlyPortEnabled")]
    public string? InsecureKubeletReadonlyPortEnabled { get; set; }

    /// <summary>The type of logging agent that is deployed by default for newly created node pools in the cluster. Valid values include DEFAULT and MAX_THROUGHPUT. See Increasing logging agent throughput for more information.</summary>
    [JsonPropertyName("loggingVariant")]
    public string? LoggingVariant { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Default NodePool settings for the entire cluster. These settings are overridden if specified on the specific NodePool object. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNodePoolDefaults
{
    /// <summary>Subset of NodeConfig message that has defaults.</summary>
    [JsonPropertyName("nodeConfigDefaults")]
    public V1beta1ClusterStatusAtProviderNodePoolDefaultsNodeConfigDefaults? NodeConfigDefaults { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Choose what type of notifications you want to receive. If no filters are applied, you'll receive all notification types. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNotificationConfigPubsubFilter
{
    /// <summary>Can be used to filter what notifications are sent. Accepted values are UPGRADE_AVAILABLE_EVENT, UPGRADE_EVENT, SECURITY_BULLETIN_EVENT and UPGRADE_INFO_EVENT. See Filtering notifications for more details.</summary>
    [JsonPropertyName("eventType")]
    public IList<string>? EventType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The pubsub config for the cluster's upgrade notifications.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNotificationConfigPubsub
{
    /// <summary>Whether or not the notification config is enabled</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Choose what type of notifications you want to receive. If no filters are applied, you'll receive all notification types. Structure is documented below.</summary>
    [JsonPropertyName("filter")]
    public V1beta1ClusterStatusAtProviderNotificationConfigPubsubFilter? Filter { get; set; }

    /// <summary>The pubsub topic to push upgrade notifications to. Must be in the same project as the cluster. Must be in the format: projects/{project}/topics/{topic}.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the cluster upgrade notifications feature. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderNotificationConfig
{
    /// <summary>The pubsub config for the cluster's upgrade notifications.</summary>
    [JsonPropertyName("pubsub")]
    public V1beta1ClusterStatusAtProviderNotificationConfigPubsub? Pubsub { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderPodAutoscaling
{
    /// <summary>Enable the Horizontal Pod Autoscaling profile for this cluster. Acceptable values are:</summary>
    [JsonPropertyName("hpaProfile")]
    public string? HpaProfile { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Controls cluster master global access settings. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderPrivateClusterConfigMasterGlobalAccessConfig
{
    /// <summary>Whether the cluster master is accessible globally or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for private clusters, clusters with private nodes. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderPrivateClusterConfig
{
    /// <summary>When true, the cluster's private endpoint is used as the cluster endpoint and access through the public endpoint is disabled. When false, either endpoint can be used. This field only applies to private clusters, when enable_private_nodes is true.</summary>
    [JsonPropertyName("enablePrivateEndpoint")]
    public bool? EnablePrivateEndpoint { get; set; }

    /// <summary>Enables the private cluster feature, creating a private endpoint on the cluster. In a private cluster, nodes only have RFC 1918 private addresses and communicate with the master's private endpoint via private networking.</summary>
    [JsonPropertyName("enablePrivateNodes")]
    public bool? EnablePrivateNodes { get; set; }

    /// <summary>Controls cluster master global access settings. Structure is documented below.</summary>
    [JsonPropertyName("masterGlobalAccessConfig")]
    public V1beta1ClusterStatusAtProviderPrivateClusterConfigMasterGlobalAccessConfig? MasterGlobalAccessConfig { get; set; }

    /// <summary>The IP range in CIDR notation to use for the hosted master network. This range will be used for assigning private IP addresses to the cluster master(s) and the ILB VIP. This range must not overlap with any other ranges in use within the cluster's network, and it must be a /28 subnet. See Private Cluster Limitations for more details. This field only applies to private clusters, when enable_private_nodes is true.</summary>
    [JsonPropertyName("masterIpv4CidrBlock")]
    public string? MasterIpv4CidrBlock { get; set; }

    /// <summary>The name of the peering between this cluster and the Google owned VPC.</summary>
    [JsonPropertyName("peeringName")]
    public string? PeeringName { get; set; }

    /// <summary>The internal IP address of this cluster's master endpoint.</summary>
    [JsonPropertyName("privateEndpoint")]
    public string? PrivateEndpoint { get; set; }

    /// <summary>Subnetwork in cluster's network where master's endpoint will be provisioned.</summary>
    [JsonPropertyName("privateEndpointSubnetwork")]
    public string? PrivateEndpointSubnetwork { get; set; }

    /// <summary>The external IP address of this cluster's master endpoint.</summary>
    [JsonPropertyName("publicEndpoint")]
    public string? PublicEndpoint { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration options for the Release channel feature, which provide more control over automatic upgrades of your GKE clusters. When updating this field, GKE imposes specific version requirements. See Selecting a new release channel for more details; the google_container_engine_versions datasource can provide the default version for a channel. Instead, use the "UNSPECIFIED" channel. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderReleaseChannel
{
    /// <summary>The selected release channel. Accepted values are:</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Parameters for using BigQuery as the destination of resource usage export.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderResourceUsageExportConfigBigqueryDestination
{
    /// <summary>The ID of a BigQuery Dataset. For Example:</summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the ResourceUsageExportConfig feature. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderResourceUsageExportConfig
{
    /// <summary>Parameters for using BigQuery as the destination of resource usage export.</summary>
    [JsonPropertyName("bigqueryDestination")]
    public V1beta1ClusterStatusAtProviderResourceUsageExportConfigBigqueryDestination? BigqueryDestination { get; set; }

    /// <summary>Whether to enable network egress metering for this cluster. If enabled, a daemonset will be created in the cluster to meter network egress traffic.</summary>
    [JsonPropertyName("enableNetworkEgressMetering")]
    public bool? EnableNetworkEgressMetering { get; set; }

    /// <summary>Whether to enable resource consumption metering on this cluster. When enabled, a table will be created in the resource export BigQuery dataset to store resource consumption data. The resulting table can be joined with the resource usage table or with BigQuery billing export. Defaults to true.</summary>
    [JsonPropertyName("enableResourceConsumptionMetering")]
    public bool? EnableResourceConsumptionMetering { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Configuration for the SecretManagerConfig feature. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderSecretManagerConfig
{
    /// <summary>Enable the Secret Manager add-on for this cluster.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Enable/Disable Security Posture API features for the cluster. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderSecurityPostureConfig
{
    /// <summary>Sets the mode of the Kubernetes security posture API's off-cluster features. Available options include DISABLED, BASIC, and ENTERPRISE.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Sets the mode of the Kubernetes security posture API's workload vulnerability scanning. Available options include VULNERABILITY_DISABLED, VULNERABILITY_BASIC and VULNERABILITY_ENTERPRISE.</summary>
    [JsonPropertyName("vulnerabilityMode")]
    public string? VulnerabilityMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderServiceExternalIpsConfig
{
    /// <summary>Controls whether external ips specified by a service will be allowed. It is enabled by default.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The custom keys configuration of the cluster Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderUserManagedKeysConfig
{
    /// <summary>The Certificate Authority Service caPool to use for the aggreation CA in this cluster.</summary>
    [JsonPropertyName("aggregationCa")]
    public string? AggregationCa { get; set; }

    /// <summary>The Certificate Authority Service caPool to use for the cluster CA in this cluster.</summary>
    [JsonPropertyName("clusterCa")]
    public string? ClusterCa { get; set; }

    /// <summary>The Cloud KMS cryptoKey to use for Confidential Hyperdisk on the control plane nodes.</summary>
    [JsonPropertyName("controlPlaneDiskEncryptionKey")]
    public string? ControlPlaneDiskEncryptionKey { get; set; }

    /// <summary>The Certificate Authority Service caPool to use for the etcd API CA in this cluster.</summary>
    [JsonPropertyName("etcdApiCa")]
    public string? EtcdApiCa { get; set; }

    /// <summary>The Certificate Authority Service caPool to use for the etcd peer CA in this cluster.</summary>
    [JsonPropertyName("etcdPeerCa")]
    public string? EtcdPeerCa { get; set; }

    /// <summary>Resource path of the Cloud KMS cryptoKey to use for encryption of internal etcd backups.</summary>
    [JsonPropertyName("gkeopsEtcdBackupEncryptionKey")]
    public string? GkeopsEtcdBackupEncryptionKey { get; set; }

    /// <summary>The Cloud KMS cryptoKeyVersions to use for signing service account JWTs issued by this cluster.</summary>
    [JsonPropertyName("serviceAccountSigningKeys")]
    public IList<string>? ServiceAccountSigningKeys { get; set; }

    /// <summary>The Cloud KMS cryptoKeyVersions to use for verifying service account JWTs issued by this cluster.</summary>
    [JsonPropertyName("serviceAccountVerificationKeys")]
    public IList<string>? ServiceAccountVerificationKeys { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Vertical Pod Autoscaling automatically adjusts the resources of pods controlled by it. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderVerticalPodAutoscaling
{
    /// <summary>Enables vertical pod autoscaling</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Workload Identity allows Kubernetes service accounts to act as a user-managed Google IAM Service Account. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProviderWorkloadIdentityConfig
{
    /// <summary>The workload pool to attach all Kubernetes service accounts to.</summary>
    [JsonPropertyName("workloadPool")]
    public string? WorkloadPool { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ClusterStatusAtProvider
{
    /// <summary>The configuration for addons supported by GKE. Structure is documented below.</summary>
    [JsonPropertyName("addonsConfig")]
    public V1beta1ClusterStatusAtProviderAddonsConfig? AddonsConfig { get; set; }

    /// <summary>Enable NET_ADMIN for the cluster. Defaults to false. This field should only be enabled for Autopilot clusters (enable_autopilot set to true).</summary>
    [JsonPropertyName("allowNetAdmin")]
    public bool? AllowNetAdmin { get; set; }

    /// <summary>Configuration for anonymous authentication restrictions. Structure is documented below.</summary>
    [JsonPropertyName("anonymousAuthenticationConfig")]
    public V1beta1ClusterStatusAtProviderAnonymousAuthenticationConfig? AnonymousAuthenticationConfig { get; set; }

    /// <summary>Configuration for the Google Groups for GKE feature. Structure is documented below.</summary>
    [JsonPropertyName("authenticatorGroupsConfig")]
    public V1beta1ClusterStatusAtProviderAuthenticatorGroupsConfig? AuthenticatorGroupsConfig { get; set; }

    /// <summary>Configuration options for the Binary Authorization feature. Structure is documented below.</summary>
    [JsonPropertyName("binaryAuthorization")]
    public V1beta1ClusterStatusAtProviderBinaryAuthorization? BinaryAuthorization { get; set; }

    /// <summary>Per-cluster configuration of Node Auto-Provisioning with Cluster Autoscaler to automatically adjust the size of the cluster and create/delete node pools based on the current needs of the cluster's workload. See the guide to using Node Auto-Provisioning for more details. Structure is documented below.</summary>
    [JsonPropertyName("clusterAutoscaling")]
    public V1beta1ClusterStatusAtProviderClusterAutoscaling? ClusterAutoscaling { get; set; }

    /// <summary>The IP address range of the Kubernetes pods in this cluster in CIDR notation (e.g. 10.96.0.0/14). Leave blank to have one automatically chosen or specify a /14 block in 10.0.0.0/8. This field will default a new cluster to routes-based, where ip_allocation_policy is not defined.</summary>
    [JsonPropertyName("clusterIpv4Cidr")]
    public string? ClusterIpv4Cidr { get; set; }

    /// <summary>Configuration for Confidential Nodes feature. Structure is documented below documented below.</summary>
    [JsonPropertyName("confidentialNodes")]
    public V1beta1ClusterStatusAtProviderConfidentialNodes? ConfidentialNodes { get; set; }

    /// <summary>Configuration for all of the cluster's control plane endpoints. Structure is documented below.</summary>
    [JsonPropertyName("controlPlaneEndpointsConfig")]
    public V1beta1ClusterStatusAtProviderControlPlaneEndpointsConfig? ControlPlaneEndpointsConfig { get; set; }

    /// <summary>Configuration for the Cost Allocation feature. Structure is documented below.</summary>
    [JsonPropertyName("costManagementConfig")]
    public V1beta1ClusterStatusAtProviderCostManagementConfig? CostManagementConfig { get; set; }

    /// <summary>Structure is documented below.</summary>
    [JsonPropertyName("databaseEncryption")]
    public V1beta1ClusterStatusAtProviderDatabaseEncryption? DatabaseEncryption { get; set; }

    /// <summary>The desired datapath provider for this cluster. This is set to LEGACY_DATAPATH by default, which uses the IPTables-based kube-proxy implementation. Set to ADVANCED_DATAPATH to enable Dataplane v2.</summary>
    [JsonPropertyName("datapathProvider")]
    public string? DatapathProvider { get; set; }

    /// <summary>The default maximum number of pods per node in this cluster. This doesn't work on "routes-based" clusters, clusters that don't have IP Aliasing enabled. See the official documentation for more information.</summary>
    [JsonPropertyName("defaultMaxPodsPerNode")]
    public double? DefaultMaxPodsPerNode { get; set; }

    /// <summary>GKE SNAT DefaultSnatStatus contains the desired state of whether default sNAT should be disabled on the cluster, API doc. Structure is documented below</summary>
    [JsonPropertyName("defaultSnatStatus")]
    public V1beta1ClusterStatusAtProviderDefaultSnatStatus? DefaultSnatStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>Description of the cluster.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Disable L4 load balancer VPC firewalls to enable firewall policies.</summary>
    [JsonPropertyName("disableL4LbFirewallReconciliation")]
    public bool? DisableL4LbFirewallReconciliation { get; set; }

    /// <summary>Configuration for Using Cloud DNS for GKE. Structure is documented below.</summary>
    [JsonPropertyName("dnsConfig")]
    public V1beta1ClusterStatusAtProviderDnsConfig? DnsConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>Enable Autopilot for this cluster. Defaults to false. Note that when this option is enabled, certain features of Standard GKE are not available. See the official documentation for available features.</summary>
    [JsonPropertyName("enableAutopilot")]
    public bool? EnableAutopilot { get; set; }

    /// <summary>Whether CiliumClusterWideNetworkPolicy is enabled on this cluster. Defaults to false.</summary>
    [JsonPropertyName("enableCiliumClusterwideNetworkPolicy")]
    public bool? EnableCiliumClusterwideNetworkPolicy { get; set; }

    /// <summary>Whether FQDN Network Policy is enabled on this cluster. Users who enable this feature for existing Standard clusters must restart the GKE Dataplane V2 anetd DaemonSet after enabling it. See the Enable FQDN Network Policy in an existing cluster for more information.</summary>
    [JsonPropertyName("enableFqdnNetworkPolicy")]
    public bool? EnableFqdnNetworkPolicy { get; set; }

    /// <summary>Whether Intra-node visibility is enabled for this cluster. This makes same node pod to pod traffic visible for VPC network.</summary>
    [JsonPropertyName("enableIntranodeVisibility")]
    public bool? EnableIntranodeVisibility { get; set; }

    /// <summary>Configuration for Kubernetes Beta APIs. Structure is documented below.</summary>
    [JsonPropertyName("enableK8SBetaApis")]
    public V1beta1ClusterStatusAtProviderEnableK8SBetaApis? EnableK8SBetaApis { get; set; }

    /// <summary>Whether to enable Kubernetes Alpha features for this cluster. Note that when this option is enabled, the cluster cannot be upgraded and will be automatically deleted after 30 days.</summary>
    [JsonPropertyName("enableKubernetesAlpha")]
    public bool? EnableKubernetesAlpha { get; set; }

    /// <summary>Whether L4ILB Subsetting is enabled for this cluster.</summary>
    [JsonPropertyName("enableL4IlbSubsetting")]
    public bool? EnableL4IlbSubsetting { get; set; }

    /// <summary>Whether the ABAC authorizer is enabled for this cluster. When enabled, identities in the system, including service accounts, nodes, and controllers, will have statically granted permissions beyond those provided by the RBAC configuration or IAM. Defaults to false</summary>
    [JsonPropertyName("enableLegacyAbac")]
    public bool? EnableLegacyAbac { get; set; }

    /// <summary>Whether multi-networking is enabled for this cluster.</summary>
    [JsonPropertyName("enableMultiNetworking")]
    public bool? EnableMultiNetworking { get; set; }

    /// <summary>Enable Shielded Nodes features on all nodes in this cluster.  Defaults to true.</summary>
    [JsonPropertyName("enableShieldedNodes")]
    public bool? EnableShieldedNodes { get; set; }

    /// <summary>Whether to enable Cloud TPU resources in this cluster. See the official documentation.</summary>
    [JsonPropertyName("enableTpu")]
    public bool? EnableTpu { get; set; }

    /// <summary>The IP address of this cluster's Kubernetes master.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>Configuration for [Enterprise edition].(https://cloud.google.com/kubernetes-engine/enterprise/docs/concepts/gke-editions). Structure is documented below.</summary>
    [JsonPropertyName("enterpriseConfig")]
    public V1beta1ClusterStatusAtProviderEnterpriseConfig? EnterpriseConfig { get; set; }

    /// <summary>Fleet configuration for the cluster. Structure is documented below.</summary>
    [JsonPropertyName("fleet")]
    public V1beta1ClusterStatusAtProviderFleet? Fleet { get; set; }

    /// <summary>Configuration for GKE Gateway API controller. Structure is documented below.</summary>
    [JsonPropertyName("gatewayApiConfig")]
    public V1beta1ClusterStatusAtProviderGatewayApiConfig? GatewayApiConfig { get; set; }

    /// <summary>Configuration options for the auto-upgrade patch type feature, which provide more control over the speed of automatic upgrades of your GKE clusters. Structure is documented below.</summary>
    [JsonPropertyName("gkeAutoUpgradeConfig")]
    public V1beta1ClusterStatusAtProviderGkeAutoUpgradeConfig? GkeAutoUpgradeConfig { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{zone}}/clusters/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>. Structure is documented below.</summary>
    [JsonPropertyName("identityServiceConfig")]
    public V1beta1ClusterStatusAtProviderIdentityServiceConfig? IdentityServiceConfig { get; set; }

    /// <summary>Defines the config of in-transit encryption. Valid values are IN_TRANSIT_ENCRYPTION_DISABLED and IN_TRANSIT_ENCRYPTION_INTER_NODE_TRANSPARENT.</summary>
    [JsonPropertyName("inTransitEncryptionConfig")]
    public string? InTransitEncryptionConfig { get; set; }

    /// <summary>The number of nodes to create in this cluster's default node pool. In regional or multi-zonal clusters, this is the number of nodes per zone. Must be set if node_pool is not set. If you're using google_container_node_pool objects with no default node pool, you'll need to set this to a value of at least 1, alongside setting remove_default_node_pool to true.</summary>
    [JsonPropertyName("initialNodeCount")]
    public double? InitialNodeCount { get; set; }

    /// <summary>Configuration of cluster IP allocation for VPC-native clusters. If this block is unset during creation, it will be set by the GKE backend. Structure is documented below.</summary>
    [JsonPropertyName("ipAllocationPolicy")]
    public V1beta1ClusterStatusAtProviderIpAllocationPolicy? IpAllocationPolicy { get; set; }

    /// <summary>The fingerprint of the set of labels for this cluster.</summary>
    [JsonPropertyName("labelFingerprint")]
    public string? LabelFingerprint { get; set; }

    /// <summary>The location (region or zone) in which the cluster master will be created, as well as the default node location. If you specify a zone (such as us-central1-a), the cluster will be a zonal cluster with a single cluster master. If you specify a region (such as us-west1), the cluster will be a regional cluster with multiple masters spread across zones in the region, and with default node locations in those zones as well</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Logging configuration for the cluster. Structure is documented below.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta1ClusterStatusAtProviderLoggingConfig? LoggingConfig { get; set; }

    /// <summary>The logging service that the cluster should write logs to. Available options include logging.googleapis.com(Legacy Stackdriver), logging.googleapis.com/kubernetes(Stackdriver Kubernetes Engine Logging), and none. Defaults to logging.googleapis.com/kubernetes</summary>
    [JsonPropertyName("loggingService")]
    public string? LoggingService { get; set; }

    /// <summary>The maintenance policy to use for the cluster. Structure is documented below.</summary>
    [JsonPropertyName("maintenancePolicy")]
    public V1beta1ClusterStatusAtProviderMaintenancePolicy? MaintenancePolicy { get; set; }

    /// <summary>The authentication information for accessing the Kubernetes master. Some values in this block are only returned by the API if your service account has permission to get credentials for your GKE cluster. If you see an unexpected diff unsetting your client cert, ensure you have the container.clusters.getCredentials permission. Structure is documented below.</summary>
    [JsonPropertyName("masterAuth")]
    public V1beta1ClusterStatusAtProviderMasterAuth? MasterAuth { get; set; }

    /// <summary>The desired configuration options for master authorized networks. Omit the nested cidr_blocks attribute to disallow external access (except the cluster node IPs, which GKE automatically whitelists). Structure is documented below.</summary>
    [JsonPropertyName("masterAuthorizedNetworksConfig")]
    public V1beta1ClusterStatusAtProviderMasterAuthorizedNetworksConfig? MasterAuthorizedNetworksConfig { get; set; }

    /// <summary>The current version of the master in the cluster. This may be different than the min_master_version set in the config if the master has been updated by GKE.</summary>
    [JsonPropertyName("masterVersion")]
    public string? MasterVersion { get; set; }

    /// <summary>Structure is documented below.</summary>
    [JsonPropertyName("meshCertificates")]
    public V1beta1ClusterStatusAtProviderMeshCertificates? MeshCertificates { get; set; }

    /// <summary>The minimum version of the master. GKE will auto-update the master to new versions, so this does not guarantee the current master version--use the read-only master_version field to obtain that. If unset, the cluster's version will be set by GKE to the version of the most recent official release (which is not necessarily the latest version). If you intend to specify versions manually, the docs describe the various acceptable formats for this field.</summary>
    [JsonPropertyName("minMasterVersion")]
    public string? MinMasterVersion { get; set; }

    /// <summary>Monitoring configuration for the cluster. Structure is documented below.</summary>
    [JsonPropertyName("monitoringConfig")]
    public V1beta1ClusterStatusAtProviderMonitoringConfig? MonitoringConfig { get; set; }

    /// <summary>The monitoring service that the cluster should write metrics to. Automatically send metrics from pods in the cluster to the Google Cloud Monitoring API. VM metrics will be collected by Google Compute Engine regardless of this setting Available options include monitoring.googleapis.com(Legacy Stackdriver), monitoring.googleapis.com/kubernetes(Stackdriver Kubernetes Engine Monitoring), and none. Defaults to monitoring.googleapis.com/kubernetes</summary>
    [JsonPropertyName("monitoringService")]
    public string? MonitoringService { get; set; }

    /// <summary>The name or self_link of the Google Compute Engine network to which the cluster is connected. For Shared VPC, set this to the self link of the shared network.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Network bandwidth tier configuration. Structure is documented below.</summary>
    [JsonPropertyName("networkPerformanceConfig")]
    public V1beta1ClusterStatusAtProviderNetworkPerformanceConfig? NetworkPerformanceConfig { get; set; }

    /// <summary>Configuration options for the NetworkPolicy feature. Structure is documented below.</summary>
    [JsonPropertyName("networkPolicy")]
    public V1beta1ClusterStatusAtProviderNetworkPolicy? NetworkPolicy { get; set; }

    /// <summary>Determines whether alias IPs or routes will be used for pod IPs in the cluster. Options are VPC_NATIVE or ROUTES. VPC_NATIVE enables IP aliasing. Newly created clusters will default to VPC_NATIVE.</summary>
    [JsonPropertyName("networkingMode")]
    public string? NetworkingMode { get; set; }

    /// <summary>Parameters used in creating the default node pool. Structure is documented below.</summary>
    [JsonPropertyName("nodeConfig")]
    public V1beta1ClusterStatusAtProviderNodeConfig? NodeConfig { get; set; }

    /// <summary>The list of zones in which the cluster's nodes are located. Nodes must be in the region of their regional cluster or in the same region as their cluster's zone for zonal clusters. If this is specified for a zonal cluster, omit the cluster's zone.</summary>
    [JsonPropertyName("nodeLocations")]
    public IList<string>? NodeLocations { get; set; }

    /// <summary>List of node pools associated with this cluster. See google_container_node_pool for schema. Warning: node pools defined inside a cluster can't be changed (or added/removed) after cluster creation without deleting and recreating the entire cluster. Unless you absolutely need the ability to say "these are the only node pools associated with this cluster", use the google_container_node_pool resource instead of this property.</summary>
    [JsonPropertyName("nodePool")]
    public IList<V1beta1ClusterStatusAtProviderNodePool>? NodePool { get; set; }

    /// <summary>Node pool configs that apply to auto-provisioned node pools in autopilot clusters and node auto-provisioning-enabled clusters. Structure is documented below.</summary>
    [JsonPropertyName("nodePoolAutoConfig")]
    public V1beta1ClusterStatusAtProviderNodePoolAutoConfig? NodePoolAutoConfig { get; set; }

    /// <summary>Default NodePool settings for the entire cluster. These settings are overridden if specified on the specific NodePool object. Structure is documented below.</summary>
    [JsonPropertyName("nodePoolDefaults")]
    public V1beta1ClusterStatusAtProviderNodePoolDefaults? NodePoolDefaults { get; set; }

    /// <summary>The Kubernetes version on the nodes. Must either be unset or set to the same value as min_master_version on create. Defaults to the default version set by GKE which is not necessarily the latest version. This only affects nodes in the default node pool. To update nodes in other node pools, use the version attribute on the node pool.</summary>
    [JsonPropertyName("nodeVersion")]
    public string? NodeVersion { get; set; }

    /// <summary>Configuration for the cluster upgrade notifications feature. Structure is documented below.</summary>
    [JsonPropertyName("notificationConfig")]
    public V1beta1ClusterStatusAtProviderNotificationConfig? NotificationConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>Configuration for the Structure is documented below.</summary>
    [JsonPropertyName("podAutoscaling")]
    public V1beta1ClusterStatusAtProviderPodAutoscaling? PodAutoscaling { get; set; }

    /// <summary>Configuration for private clusters, clusters with private nodes. Structure is documented below.</summary>
    [JsonPropertyName("privateClusterConfig")]
    public V1beta1ClusterStatusAtProviderPrivateClusterConfig? PrivateClusterConfig { get; set; }

    /// <summary>The desired state of IPv6 connectivity to Google Services. By default, no private IPv6 access to or from Google Services (all access will be via IPv4).</summary>
    [JsonPropertyName("privateIpv6GoogleAccess")]
    public string? PrivateIpv6GoogleAccess { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Configuration options for the Release channel feature, which provide more control over automatic upgrades of your GKE clusters. When updating this field, GKE imposes specific version requirements. See Selecting a new release channel for more details; the google_container_engine_versions datasource can provide the default version for a channel. Instead, use the "UNSPECIFIED" channel. Structure is documented below.</summary>
    [JsonPropertyName("releaseChannel")]
    public V1beta1ClusterStatusAtProviderReleaseChannel? ReleaseChannel { get; set; }

    /// <summary>If true, deletes the default node pool upon cluster creation. If you're using google_container_node_pool resources with no default node pool, this should be set to true, alongside setting initial_node_count to at least 1.</summary>
    [JsonPropertyName("removeDefaultNodePool")]
    public bool? RemoveDefaultNodePool { get; set; }

    /// <summary>The GCE resource labels (a map of key/value pairs) to be applied to the cluster.</summary>
    [JsonPropertyName("resourceLabels")]
    public IDictionary<string, string>? ResourceLabels { get; set; }

    /// <summary>Configuration for the ResourceUsageExportConfig feature. Structure is documented below.</summary>
    [JsonPropertyName("resourceUsageExportConfig")]
    public V1beta1ClusterStatusAtProviderResourceUsageExportConfig? ResourceUsageExportConfig { get; set; }

    /// <summary>Configuration for the SecretManagerConfig feature. Structure is documented below.</summary>
    [JsonPropertyName("secretManagerConfig")]
    public V1beta1ClusterStatusAtProviderSecretManagerConfig? SecretManagerConfig { get; set; }

    /// <summary>Enable/Disable Security Posture API features for the cluster. Structure is documented below.</summary>
    [JsonPropertyName("securityPostureConfig")]
    public V1beta1ClusterStatusAtProviderSecurityPostureConfig? SecurityPostureConfig { get; set; }

    /// <summary>The server-defined URL for the resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>Structure is documented below.</summary>
    [JsonPropertyName("serviceExternalIpsConfig")]
    public V1beta1ClusterStatusAtProviderServiceExternalIpsConfig? ServiceExternalIpsConfig { get; set; }

    /// <summary>The IP address range of the Kubernetes services in this cluster, in CIDR notation (e.g. 1.2.3.4/29). Service addresses are typically put in the last /16 from the container CIDR.</summary>
    [JsonPropertyName("servicesIpv4Cidr")]
    public string? ServicesIpv4Cidr { get; set; }

    /// <summary>The name or self_link of the Google Compute Engine subnetwork in which the cluster's instances are launched.</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>The IP address range of the Cloud TPUs in this cluster, in CIDR notation (e.g. 1.2.3.4/29).</summary>
    [JsonPropertyName("tpuIpv4CidrBlock")]
    public string? TpuIpv4CidrBlock { get; set; }

    /// <summary>The custom keys configuration of the cluster Structure is documented below.</summary>
    [JsonPropertyName("userManagedKeysConfig")]
    public V1beta1ClusterStatusAtProviderUserManagedKeysConfig? UserManagedKeysConfig { get; set; }

    /// <summary>Vertical Pod Autoscaling automatically adjusts the resources of pods controlled by it. Structure is documented below.</summary>
    [JsonPropertyName("verticalPodAutoscaling")]
    public V1beta1ClusterStatusAtProviderVerticalPodAutoscaling? VerticalPodAutoscaling { get; set; }

    /// <summary>Workload Identity allows Kubernetes service accounts to act as a user-managed Google IAM Service Account. Structure is documented below.</summary>
    [JsonPropertyName("workloadIdentityConfig")]
    public V1beta1ClusterStatusAtProviderWorkloadIdentityConfig? WorkloadIdentityConfig { get; set; }
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
/// <summary>Cluster is the Schema for the Clusters API. Creates a Google Kubernetes Engine (GKE) cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Cluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ClusterSpec>, IStatus<V1beta1ClusterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Cluster";
    public const string KubeGroup = "container.gcp.m.upbound.io";
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
