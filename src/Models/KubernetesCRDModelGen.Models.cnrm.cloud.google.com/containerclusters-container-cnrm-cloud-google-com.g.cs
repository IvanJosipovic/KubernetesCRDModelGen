using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.container.cnrm.cloud.google.com;
/// <summary>The status of the CloudRun addon. It is disabled by default. Set disabled = false to enable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecAddonsConfigCloudrunConfig
{
    /// <summary></summary>
    [JsonPropertyName("disabled")]
    public bool Disabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loadBalancerType")]
    public string? LoadBalancerType { get; set; }
}

/// <summary>The of the Config Connector addon.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecAddonsConfigConfigConnectorConfig
{
    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }
}

/// <summary>The status of the NodeLocal DNSCache addon. It is disabled by default. Set enabled = true to enable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecAddonsConfigDnsCacheConfig
{
    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }
}

/// <summary>Whether this cluster should enable the Google Compute Engine Persistent Disk Container Storage Interface (CSI) Driver. Set enabled = true to enable. The Compute Engine persistent disk CSI Driver is enabled by default on newly created clusters for the following versions: Linux clusters: GKE version 1.18.10-gke.2100 or later, or 1.19.3-gke.2100 or later.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecAddonsConfigGcePersistentDiskCsiDriverConfig
{
    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }
}

/// <summary>The status of the Filestore CSI driver addon, which allows the usage of filestore instance as volumes. Defaults to disabled; set enabled = true to enable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecAddonsConfigGcpFilestoreCsiDriverConfig
{
    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }
}

/// <summary>The status of the GCS Fuse CSI driver addon, which allows the usage of gcs bucket as volumes. Defaults to disabled; set enabled = true to enable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecAddonsConfigGcsFuseCsiDriverConfig
{
    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }
}

/// <summary>The status of the Backup for GKE Agent addon. It is disabled by default. Set enabled = true to enable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecAddonsConfigGkeBackupAgentConfig
{
    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }
}

/// <summary>The status of the Horizontal Pod Autoscaling addon, which increases or decreases the number of replica pods a replication controller has based on the resource usage of the existing pods. It ensures that a Heapster pod is running in the cluster, which is also used by the Cloud Monitoring service. It is enabled by default; set disabled = true to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecAddonsConfigHorizontalPodAutoscaling
{
    /// <summary></summary>
    [JsonPropertyName("disabled")]
    public bool Disabled { get; set; }
}

/// <summary>The status of the HTTP (L7) load balancing controller addon, which makes it easy to set up HTTP load balancers for services in a cluster. It is enabled by default; set disabled = true to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecAddonsConfigHttpLoadBalancing
{
    /// <summary></summary>
    [JsonPropertyName("disabled")]
    public bool Disabled { get; set; }
}

/// <summary>The status of the Istio addon.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecAddonsConfigIstioConfig
{
    /// <summary>The authentication type between services in Istio. Available options include AUTH_MUTUAL_TLS.</summary>
    [JsonPropertyName("auth")]
    public string? Auth { get; set; }

    /// <summary>The status of the Istio addon, which makes it easy to set up Istio for services in a cluster. It is disabled by default. Set disabled = false to enable.</summary>
    [JsonPropertyName("disabled")]
    public bool Disabled { get; set; }
}

/// <summary>Configuration for the KALM addon, which manages the lifecycle of k8s. It is disabled by default; Set enabled = true to enable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecAddonsConfigKalmConfig
{
    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }
}

/// <summary>Whether we should enable the network policy addon for the master. This must be enabled in order to enable network policy for the nodes. To enable this, you must also define a network_policy block, otherwise nothing will happen. It can only be disabled if the nodes already do not have network policies enabled. Defaults to disabled; set disabled = false to enable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecAddonsConfigNetworkPolicyConfig
{
    /// <summary></summary>
    [JsonPropertyName("disabled")]
    public bool Disabled { get; set; }
}

/// <summary>The configuration for addons supported by GKE.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecAddonsConfig
{
    /// <summary>The status of the CloudRun addon. It is disabled by default. Set disabled = false to enable.</summary>
    [JsonPropertyName("cloudrunConfig")]
    public V1beta1ContainerClusterSpecAddonsConfigCloudrunConfig? CloudrunConfig { get; set; }

    /// <summary>The of the Config Connector addon.</summary>
    [JsonPropertyName("configConnectorConfig")]
    public V1beta1ContainerClusterSpecAddonsConfigConfigConnectorConfig? ConfigConnectorConfig { get; set; }

    /// <summary>The status of the NodeLocal DNSCache addon. It is disabled by default. Set enabled = true to enable.</summary>
    [JsonPropertyName("dnsCacheConfig")]
    public V1beta1ContainerClusterSpecAddonsConfigDnsCacheConfig? DnsCacheConfig { get; set; }

    /// <summary>Whether this cluster should enable the Google Compute Engine Persistent Disk Container Storage Interface (CSI) Driver. Set enabled = true to enable. The Compute Engine persistent disk CSI Driver is enabled by default on newly created clusters for the following versions: Linux clusters: GKE version 1.18.10-gke.2100 or later, or 1.19.3-gke.2100 or later.</summary>
    [JsonPropertyName("gcePersistentDiskCsiDriverConfig")]
    public V1beta1ContainerClusterSpecAddonsConfigGcePersistentDiskCsiDriverConfig? GcePersistentDiskCsiDriverConfig { get; set; }

    /// <summary>The status of the Filestore CSI driver addon, which allows the usage of filestore instance as volumes. Defaults to disabled; set enabled = true to enable.</summary>
    [JsonPropertyName("gcpFilestoreCsiDriverConfig")]
    public V1beta1ContainerClusterSpecAddonsConfigGcpFilestoreCsiDriverConfig? GcpFilestoreCsiDriverConfig { get; set; }

    /// <summary>The status of the GCS Fuse CSI driver addon, which allows the usage of gcs bucket as volumes. Defaults to disabled; set enabled = true to enable.</summary>
    [JsonPropertyName("gcsFuseCsiDriverConfig")]
    public V1beta1ContainerClusterSpecAddonsConfigGcsFuseCsiDriverConfig? GcsFuseCsiDriverConfig { get; set; }

    /// <summary>The status of the Backup for GKE Agent addon. It is disabled by default. Set enabled = true to enable.</summary>
    [JsonPropertyName("gkeBackupAgentConfig")]
    public V1beta1ContainerClusterSpecAddonsConfigGkeBackupAgentConfig? GkeBackupAgentConfig { get; set; }

    /// <summary>The status of the Horizontal Pod Autoscaling addon, which increases or decreases the number of replica pods a replication controller has based on the resource usage of the existing pods. It ensures that a Heapster pod is running in the cluster, which is also used by the Cloud Monitoring service. It is enabled by default; set disabled = true to disable.</summary>
    [JsonPropertyName("horizontalPodAutoscaling")]
    public V1beta1ContainerClusterSpecAddonsConfigHorizontalPodAutoscaling? HorizontalPodAutoscaling { get; set; }

    /// <summary>The status of the HTTP (L7) load balancing controller addon, which makes it easy to set up HTTP load balancers for services in a cluster. It is enabled by default; set disabled = true to disable.</summary>
    [JsonPropertyName("httpLoadBalancing")]
    public V1beta1ContainerClusterSpecAddonsConfigHttpLoadBalancing? HttpLoadBalancing { get; set; }

    /// <summary>The status of the Istio addon.</summary>
    [JsonPropertyName("istioConfig")]
    public V1beta1ContainerClusterSpecAddonsConfigIstioConfig? IstioConfig { get; set; }

    /// <summary>Configuration for the KALM addon, which manages the lifecycle of k8s. It is disabled by default; Set enabled = true to enable.</summary>
    [JsonPropertyName("kalmConfig")]
    public V1beta1ContainerClusterSpecAddonsConfigKalmConfig? KalmConfig { get; set; }

    /// <summary>Whether we should enable the network policy addon for the master. This must be enabled in order to enable network policy for the nodes. To enable this, you must also define a network_policy block, otherwise nothing will happen. It can only be disabled if the nodes already do not have network policies enabled. Defaults to disabled; set disabled = false to enable.</summary>
    [JsonPropertyName("networkPolicyConfig")]
    public V1beta1ContainerClusterSpecAddonsConfigNetworkPolicyConfig? NetworkPolicyConfig { get; set; }
}

/// <summary>Configuration for the Google Groups for GKE feature.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecAuthenticatorGroupsConfig
{
    /// <summary>The name of the RBAC security group for use with Google security groups in Kubernetes RBAC. Group name must be in format gke-security-groups@yourdomain.com.</summary>
    [JsonPropertyName("securityGroup")]
    public string SecurityGroup { get; set; }
}

/// <summary>Configuration options for the Binary Authorization feature.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecBinaryAuthorization
{
    /// <summary>DEPRECATED. Deprecated in favor of evaluation_mode. Enable Binary Authorization for this cluster.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Mode of operation for Binary Authorization policy evaluation.</summary>
    [JsonPropertyName("evaluationMode")]
    public string? EvaluationMode { get; set; }
}

/// <summary>Immutable. The Customer Managed Encryption Key used to encrypt the boot disk attached to each node in the node pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecClusterAutoscalingAutoProvisioningDefaultsBootDiskKMSKeyRef
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecClusterAutoscalingAutoProvisioningDefaultsManagementUpgradeOptions
{
    /// <summary>This field is set when upgrades are about to commence with the approximate start time for the upgrades, in RFC3339 text format.</summary>
    [JsonPropertyName("autoUpgradeStartTime")]
    public string? AutoUpgradeStartTime { get; set; }

    /// <summary>This field is set when upgrades are about to commence with the description of the upgrade.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }
}

/// <summary>NodeManagement configuration for this NodePool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecClusterAutoscalingAutoProvisioningDefaultsManagement
{
    /// <summary>Specifies whether the node auto-repair is enabled for the node pool. If enabled, the nodes in this node pool will be monitored and, if they fail health checks too many times, an automatic repair action will be triggered.</summary>
    [JsonPropertyName("autoRepair")]
    public bool? AutoRepair { get; set; }

    /// <summary>Specifies whether node auto-upgrade is enabled for the node pool. If enabled, node auto-upgrade helps keep the nodes in your node pool up to date with the latest release version of Kubernetes.</summary>
    [JsonPropertyName("autoUpgrade")]
    public bool? AutoUpgrade { get; set; }

    /// <summary>Specifies the Auto Upgrade knobs for the node pool.</summary>
    [JsonPropertyName("upgradeOptions")]
    public IList<V1beta1ContainerClusterSpecClusterAutoscalingAutoProvisioningDefaultsManagementUpgradeOptions>? UpgradeOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecClusterAutoscalingAutoProvisioningDefaultsServiceAccountRef
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

/// <summary>Shielded Instance options.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecClusterAutoscalingAutoProvisioningDefaultsShieldedInstanceConfig
{
    /// <summary>Defines whether the instance has integrity monitoring enabled.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>Defines whether the instance has Secure Boot enabled.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }
}

/// <summary>Standard policy for the blue-green upgrade.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecClusterAutoscalingAutoProvisioningDefaultsUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy
{
    /// <summary>Number of blue nodes to drain in a batch.</summary>
    [JsonPropertyName("batchNodeCount")]
    public int? BatchNodeCount { get; set; }

    /// <summary>Percentage of the bool pool nodes to drain in a batch. The range of this field should be (0.0, 1.0].</summary>
    [JsonPropertyName("batchPercentage")]
    public double? BatchPercentage { get; set; }

    /// <summary>Soak time after each batch gets drained.  																			A duration in seconds with up to nine fractional digits, ending with 's'. Example: "3.5s".</summary>
    [JsonPropertyName("batchSoakDuration")]
    public string? BatchSoakDuration { get; set; }
}

/// <summary>Settings for blue-green upgrade strategy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecClusterAutoscalingAutoProvisioningDefaultsUpgradeSettingsBlueGreenSettings
{
    /// <summary>Time needed after draining entire blue pool. After this period, blue pool will be cleaned up.  																A duration in seconds with up to nine fractional digits, ending with 's'. Example: "3.5s".</summary>
    [JsonPropertyName("nodePoolSoakDuration")]
    public string? NodePoolSoakDuration { get; set; }

    /// <summary>Standard policy for the blue-green upgrade.</summary>
    [JsonPropertyName("standardRolloutPolicy")]
    public V1beta1ContainerClusterSpecClusterAutoscalingAutoProvisioningDefaultsUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy? StandardRolloutPolicy { get; set; }
}

/// <summary>Specifies the upgrade settings for NAP created node pools.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecClusterAutoscalingAutoProvisioningDefaultsUpgradeSettings
{
    /// <summary>Settings for blue-green upgrade strategy.</summary>
    [JsonPropertyName("blueGreenSettings")]
    public V1beta1ContainerClusterSpecClusterAutoscalingAutoProvisioningDefaultsUpgradeSettingsBlueGreenSettings? BlueGreenSettings { get; set; }

    /// <summary>The maximum number of nodes that can be created beyond the current size of the node pool during the upgrade process.</summary>
    [JsonPropertyName("maxSurge")]
    public int? MaxSurge { get; set; }

    /// <summary>The maximum number of nodes that can be simultaneously unavailable during the upgrade process.</summary>
    [JsonPropertyName("maxUnavailable")]
    public int? MaxUnavailable { get; set; }

    /// <summary>Update strategy of the node pool.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}

/// <summary>Contains defaults for a node pool created by NAP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecClusterAutoscalingAutoProvisioningDefaults
{
    /// <summary>Immutable. The Customer Managed Encryption Key used to encrypt the boot disk attached to each node in the node pool.</summary>
    [JsonPropertyName("bootDiskKMSKeyRef")]
    public V1beta1ContainerClusterSpecClusterAutoscalingAutoProvisioningDefaultsBootDiskKMSKeyRef? BootDiskKMSKeyRef { get; set; }

    /// <summary>Size of the disk attached to each node, specified in GB. The smallest allowed disk size is 10GB.</summary>
    [JsonPropertyName("diskSize")]
    public int? DiskSize { get; set; }

    /// <summary>The default image type used by NAP once a new node pool is being created.</summary>
    [JsonPropertyName("imageType")]
    public string? ImageType { get; set; }

    /// <summary>NodeManagement configuration for this NodePool.</summary>
    [JsonPropertyName("management")]
    public V1beta1ContainerClusterSpecClusterAutoscalingAutoProvisioningDefaultsManagement? Management { get; set; }

    /// <summary>Minimum CPU platform to be used by this instance. The instance may be scheduled on the specified or newer CPU platform. Applicable values are the friendly names of CPU platforms, such as Intel Haswell.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>Scopes that are used by NAP when creating node pools.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1ContainerClusterSpecClusterAutoscalingAutoProvisioningDefaultsServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Shielded Instance options.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta1ContainerClusterSpecClusterAutoscalingAutoProvisioningDefaultsShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    /// <summary>Specifies the upgrade settings for NAP created node pools.</summary>
    [JsonPropertyName("upgradeSettings")]
    public V1beta1ContainerClusterSpecClusterAutoscalingAutoProvisioningDefaultsUpgradeSettings? UpgradeSettings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecClusterAutoscalingResourceLimits
{
    /// <summary>Maximum amount of the resource in the cluster.</summary>
    [JsonPropertyName("maximum")]
    public int? Maximum { get; set; }

    /// <summary>Minimum amount of the resource in the cluster.</summary>
    [JsonPropertyName("minimum")]
    public int? Minimum { get; set; }

    /// <summary>The type of the resource. For example, cpu and memory. See the guide to using Node Auto-Provisioning for a list of types.</summary>
    [JsonPropertyName("resourceType")]
    public string ResourceType { get; set; }
}

/// <summary>Per-cluster configuration of Node Auto-Provisioning with Cluster Autoscaler to automatically adjust the size of the cluster and create/delete node pools based on the current needs of the cluster's workload. See the guide to using Node Auto-Provisioning for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecClusterAutoscaling
{
    /// <summary>Contains defaults for a node pool created by NAP.</summary>
    [JsonPropertyName("autoProvisioningDefaults")]
    public V1beta1ContainerClusterSpecClusterAutoscalingAutoProvisioningDefaults? AutoProvisioningDefaults { get; set; }

    /// <summary>Configuration options for the Autoscaling profile feature, which lets you choose whether the cluster autoscaler should optimize for resource utilization or resource availability when deciding to remove nodes from a cluster. Can be BALANCED or OPTIMIZE_UTILIZATION. Defaults to BALANCED.</summary>
    [JsonPropertyName("autoscalingProfile")]
    public string? AutoscalingProfile { get; set; }

    /// <summary>Whether node auto-provisioning is enabled. Resource limits for cpu and memory must be defined to enable node auto-provisioning.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Global constraints for machine resources in the cluster. Configuring the cpu and memory types is required if node auto-provisioning is enabled. These limits will apply to node pool autoscaling in addition to node auto-provisioning.</summary>
    [JsonPropertyName("resourceLimits")]
    public IList<V1beta1ContainerClusterSpecClusterAutoscalingResourceLimits>? ResourceLimits { get; set; }
}

/// <summary>Telemetry integration for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecClusterTelemetry
{
    /// <summary>Type of the integration.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Immutable. Configuration for the confidential nodes feature, which makes nodes run on confidential VMs. Warning: This configuration can't be changed (or added/removed) after cluster creation without deleting and recreating the entire cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecConfidentialNodes
{
    /// <summary>Immutable. Whether Confidential Nodes feature is enabled for all nodes in this cluster.</summary>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }
}

/// <summary>Cost management configuration for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecCostManagementConfig
{
    /// <summary>Whether to enable GKE cost allocation. When you enable GKE cost allocation, the cluster name and namespace of your GKE workloads appear in the labels field of the billing export to BigQuery. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }
}

/// <summary>Application-layer Secrets Encryption settings. The object format is {state = string, key_name = string}. Valid values of state are: "ENCRYPTED"; "DECRYPTED". key_name is the name of a CloudKMS key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecDatabaseEncryption
{
    /// <summary>The key to use to encrypt/decrypt secrets.</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>ENCRYPTED or DECRYPTED.</summary>
    [JsonPropertyName("state")]
    public string State { get; set; }
}

/// <summary>Whether the cluster disables default in-node sNAT rules. In-node sNAT rules will be disabled when defaultSnatStatus is disabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecDefaultSnatStatus
{
    /// <summary>When disabled is set to false, default IP masquerade rules will be applied to the nodes to prevent sNAT on cluster internal traffic.</summary>
    [JsonPropertyName("disabled")]
    public bool Disabled { get; set; }
}

/// <summary>Immutable. Configuration for Cloud DNS for Kubernetes Engine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecDnsConfig
{
    /// <summary>Which in-cluster DNS provider should be used.</summary>
    [JsonPropertyName("clusterDns")]
    public string? ClusterDns { get; set; }

    /// <summary>The suffix used for all cluster service records.</summary>
    [JsonPropertyName("clusterDnsDomain")]
    public string? ClusterDnsDomain { get; set; }

    /// <summary>The scope of access to cluster DNS records.</summary>
    [JsonPropertyName("clusterDnsScope")]
    public string? ClusterDnsScope { get; set; }
}

/// <summary>Configuration for Kubernetes Beta APIs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecEnableK8sBetaApis
{
    /// <summary>Enabled Kubernetes Beta APIs.</summary>
    [JsonPropertyName("enabledApis")]
    public IList<string> EnabledApis { get; set; }
}

/// <summary>Configuration for GKE Gateway API controller.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecGatewayApiConfig
{
    /// <summary>The Gateway API release channel to use for Gateway API.</summary>
    [JsonPropertyName("channel")]
    public string Channel { get; set; }
}

/// <summary>Configuration for Identity Service which allows customers to use external identity providers with the K8S API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecIdentityServiceConfig
{
    /// <summary>Whether to enable the Identity Service component.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>AdditionalPodRangesConfig is the configuration for additional pod secondary ranges supporting the ClusterUpdate message.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecIpAllocationPolicyAdditionalPodRangesConfig
{
    /// <summary>Name for pod secondary ipv4 range which has the actual range defined ahead.</summary>
    [JsonPropertyName("podRangeNames")]
    public IList<string> PodRangeNames { get; set; }
}

/// <summary>Immutable. Configuration for cluster level pod cidr overprovision. Default is disabled=false.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecIpAllocationPolicyPodCidrOverprovisionConfig
{
    /// <summary></summary>
    [JsonPropertyName("disabled")]
    public bool Disabled { get; set; }
}

/// <summary>Immutable. Configuration of cluster IP allocation for VPC-native clusters. Adding this block enables IP aliasing, making the cluster VPC-native instead of routes-based.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecIpAllocationPolicy
{
    /// <summary>AdditionalPodRangesConfig is the configuration for additional pod secondary ranges supporting the ClusterUpdate message.</summary>
    [JsonPropertyName("additionalPodRangesConfig")]
    public V1beta1ContainerClusterSpecIpAllocationPolicyAdditionalPodRangesConfig? AdditionalPodRangesConfig { get; set; }

    /// <summary>Immutable. The IP address range for the cluster pod IPs. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use.</summary>
    [JsonPropertyName("clusterIpv4CidrBlock")]
    public string? ClusterIpv4CidrBlock { get; set; }

    /// <summary>Immutable. The name of the existing secondary range in the cluster's subnetwork to use for pod IP addresses. Alternatively, cluster_ipv4_cidr_block can be used to automatically create a GKE-managed one.</summary>
    [JsonPropertyName("clusterSecondaryRangeName")]
    public string? ClusterSecondaryRangeName { get; set; }

    /// <summary>Immutable. Configuration for cluster level pod cidr overprovision. Default is disabled=false.</summary>
    [JsonPropertyName("podCidrOverprovisionConfig")]
    public V1beta1ContainerClusterSpecIpAllocationPolicyPodCidrOverprovisionConfig? PodCidrOverprovisionConfig { get; set; }

    /// <summary>Immutable. The IP address range of the services IPs in this cluster. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) from the RFC-1918 private networks (e.g. 10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16) to pick a specific range to use.</summary>
    [JsonPropertyName("servicesIpv4CidrBlock")]
    public string? ServicesIpv4CidrBlock { get; set; }

    /// <summary>Immutable. The name of the existing secondary range in the cluster's subnetwork to use for service ClusterIPs. Alternatively, services_ipv4_cidr_block can be used to automatically create a GKE-managed one.</summary>
    [JsonPropertyName("servicesSecondaryRangeName")]
    public string? ServicesSecondaryRangeName { get; set; }

    /// <summary>Immutable. The IP Stack type of the cluster. Choose between IPV4 and IPV4_IPV6. Default type is IPV4 Only if not set.</summary>
    [JsonPropertyName("stackType")]
    public string? StackType { get; set; }
}

/// <summary>Logging configuration for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecLoggingConfig
{
    /// <summary>GKE components exposing logs. Valid values include SYSTEM_COMPONENTS, APISERVER, CONTROLLER_MANAGER, SCHEDULER, and WORKLOADS.</summary>
    [JsonPropertyName("enableComponents")]
    public IList<string> EnableComponents { get; set; }
}

/// <summary>Time window specified for daily maintenance operations. Specify start_time in RFC3339 format "HH:MM”, where HH : [00-23] and MM : [00-59] GMT.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecMaintenancePolicyDailyMaintenanceWindow
{
    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string StartTime { get; set; }
}

/// <summary>Maintenance exclusion related options.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecMaintenancePolicyMaintenanceExclusionExclusionOptions
{
    /// <summary>The scope of automatic upgrades to restrict in the exclusion window.</summary>
    [JsonPropertyName("scope")]
    public string Scope { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecMaintenancePolicyMaintenanceExclusion
{
    /// <summary></summary>
    [JsonPropertyName("endTime")]
    public string EndTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exclusionName")]
    public string ExclusionName { get; set; }

    /// <summary>Maintenance exclusion related options.</summary>
    [JsonPropertyName("exclusionOptions")]
    public V1beta1ContainerClusterSpecMaintenancePolicyMaintenanceExclusionExclusionOptions? ExclusionOptions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string StartTime { get; set; }
}

/// <summary>Time window for recurring maintenance operations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecMaintenancePolicyRecurringWindow
{
    /// <summary></summary>
    [JsonPropertyName("endTime")]
    public string EndTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recurrence")]
    public string Recurrence { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string StartTime { get; set; }
}

/// <summary>The maintenance policy to use for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecMaintenancePolicy
{
    /// <summary>Time window specified for daily maintenance operations. Specify start_time in RFC3339 format "HH:MM”, where HH : [00-23] and MM : [00-59] GMT.</summary>
    [JsonPropertyName("dailyMaintenanceWindow")]
    public V1beta1ContainerClusterSpecMaintenancePolicyDailyMaintenanceWindow? DailyMaintenanceWindow { get; set; }

    /// <summary>Exceptions to maintenance window. Non-emergency maintenance should not occur in these windows.</summary>
    [JsonPropertyName("maintenanceExclusion")]
    public IList<V1beta1ContainerClusterSpecMaintenancePolicyMaintenanceExclusion>? MaintenanceExclusion { get; set; }

    /// <summary>Time window for recurring maintenance operations.</summary>
    [JsonPropertyName("recurringWindow")]
    public V1beta1ContainerClusterSpecMaintenancePolicyRecurringWindow? RecurringWindow { get; set; }
}

/// <summary>Immutable. Whether client certificate authorization is enabled for this cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecMasterAuthClientCertificateConfig
{
    /// <summary>Immutable. Whether client certificate authorization is enabled for this cluster.</summary>
    [JsonPropertyName("issueClientCertificate")]
    public bool IssueClientCertificate { get; set; }
}

/// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecMasterAuthPasswordValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecMasterAuthPasswordValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1ContainerClusterSpecMasterAuthPasswordValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>The password to use for HTTP basic authentication when accessing the Kubernetes master endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecMasterAuthPassword
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1ContainerClusterSpecMasterAuthPasswordValueFrom? ValueFrom { get; set; }
}

/// <summary>DEPRECATED. Basic authentication was removed for GKE cluster versions &gt;= 1.19. The authentication information for accessing the Kubernetes master. Some values in this block are only returned by the API if your service account has permission to get credentials for your GKE cluster. If you see an unexpected diff unsetting your client cert, ensure you have the container.clusters.getCredentials permission.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecMasterAuth
{
    /// <summary>Base64 encoded public certificate used by clients to authenticate to the cluster endpoint.</summary>
    [JsonPropertyName("clientCertificate")]
    public string? ClientCertificate { get; set; }

    /// <summary>Immutable. Whether client certificate authorization is enabled for this cluster.</summary>
    [JsonPropertyName("clientCertificateConfig")]
    public V1beta1ContainerClusterSpecMasterAuthClientCertificateConfig? ClientCertificateConfig { get; set; }

    /// <summary>Base64 encoded private key used by clients to authenticate to the cluster endpoint.</summary>
    [JsonPropertyName("clientKey")]
    public string? ClientKey { get; set; }

    /// <summary>Base64 encoded public certificate that is the root of trust for the cluster.</summary>
    [JsonPropertyName("clusterCaCertificate")]
    public string? ClusterCaCertificate { get; set; }

    /// <summary>The password to use for HTTP basic authentication when accessing the Kubernetes master endpoint.</summary>
    [JsonPropertyName("password")]
    public V1beta1ContainerClusterSpecMasterAuthPassword? Password { get; set; }

    /// <summary>The username to use for HTTP basic authentication when accessing the Kubernetes master endpoint. If not present basic auth will be disabled.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecMasterAuthorizedNetworksConfigCidrBlocks
{
    /// <summary>External network that can access Kubernetes master through HTTPS. Must be specified in CIDR notation.</summary>
    [JsonPropertyName("cidrBlock")]
    public string CidrBlock { get; set; }

    /// <summary>Field for users to identify CIDR blocks.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }
}

/// <summary>The desired configuration options for master authorized networks. Omit the nested cidr_blocks attribute to disallow external access (except the cluster node IPs, which GKE automatically whitelists).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecMasterAuthorizedNetworksConfig
{
    /// <summary>External networks that can access the Kubernetes cluster master through HTTPS.</summary>
    [JsonPropertyName("cidrBlocks")]
    public IList<V1beta1ContainerClusterSpecMasterAuthorizedNetworksConfigCidrBlocks>? CidrBlocks { get; set; }

    /// <summary>Whether master is accessbile via Google Compute Engine Public IP addresses.</summary>
    [JsonPropertyName("gcpPublicCidrsAccessEnabled")]
    public bool? GcpPublicCidrsAccessEnabled { get; set; }
}

/// <summary>If set, and enable_certificates=true, the GKE Workload Identity Certificates controller and node agent will be deployed in the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecMeshCertificates
{
    /// <summary>When enabled the GKE Workload Identity Certificates controller and node agent will be deployed in the cluster.</summary>
    [JsonPropertyName("enableCertificates")]
    public bool EnableCertificates { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecMonitoringConfigAdvancedDatapathObservabilityConfig
{
    /// <summary>Whether or not the advanced datapath metrics are enabled.</summary>
    [JsonPropertyName("enableMetrics")]
    public bool EnableMetrics { get; set; }

    /// <summary>Mode used to make Relay available.</summary>
    [JsonPropertyName("relayMode")]
    public string? RelayMode { get; set; }
}

/// <summary>Configuration for Google Cloud Managed Services for Prometheus.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecMonitoringConfigManagedPrometheus
{
    /// <summary>Whether or not the managed collection is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }
}

/// <summary>Monitoring configuration for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecMonitoringConfig
{
    /// <summary>Configuration of Advanced Datapath Observability features.</summary>
    [JsonPropertyName("advancedDatapathObservabilityConfig")]
    public IList<V1beta1ContainerClusterSpecMonitoringConfigAdvancedDatapathObservabilityConfig>? AdvancedDatapathObservabilityConfig { get; set; }

    /// <summary>GKE components exposing metrics. Valid values include SYSTEM_COMPONENTS, APISERVER, SCHEDULER, CONTROLLER_MANAGER, STORAGE, HPA, POD, DAEMONSET, DEPLOYMENT, STATEFULSET and WORKLOADS.</summary>
    [JsonPropertyName("enableComponents")]
    public IList<string>? EnableComponents { get; set; }

    /// <summary>Configuration for Google Cloud Managed Services for Prometheus.</summary>
    [JsonPropertyName("managedPrometheus")]
    public V1beta1ContainerClusterSpecMonitoringConfigManagedPrometheus? ManagedPrometheus { get; set; }
}

/// <summary>Configuration options for the NetworkPolicy feature.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNetworkPolicy
{
    /// <summary>Whether network policy is enabled on the cluster.</summary>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }

    /// <summary>The selected network policy provider. Defaults to PROVIDER_UNSPECIFIED.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNetworkRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Specifies options for controlling advanced machine features.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNodeConfigAdvancedMachineFeatures
{
    /// <summary>Immutable. The number of threads per physical core. To disable simultaneous multithreading (SMT) set this to 1. If unset, the maximum number of threads supported per core by the underlying processor is assumed.</summary>
    [JsonPropertyName("threadsPerCore")]
    public int ThreadsPerCore { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNodeConfigBootDiskKMSCryptoKeyRef
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

/// <summary>Immutable. Configuration for the confidential nodes feature, which makes nodes run on confidential VMs. Warning: This configuration can't be changed (or added/removed) after pool creation without deleting and recreating the entire pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNodeConfigConfidentialNodes
{
    /// <summary>Immutable. Whether Confidential Nodes feature is enabled for all nodes in this pool.</summary>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }
}

/// <summary>Immutable. Parameters for the ephemeral storage filesystem. If unspecified, ephemeral storage is backed by the boot disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNodeConfigEphemeralStorageConfig
{
    /// <summary>Immutable. Number of local SSDs to use to back ephemeral storage. Uses NVMe interfaces. Each local SSD must be 375 or 3000 GB in size, and all local SSDs must share the same size.</summary>
    [JsonPropertyName("localSsdCount")]
    public int LocalSsdCount { get; set; }
}

/// <summary>Immutable. Parameters for the ephemeral storage filesystem. If unspecified, ephemeral storage is backed by the boot disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNodeConfigEphemeralStorageLocalSsdConfig
{
    /// <summary>Immutable. Number of local SSDs to use to back ephemeral storage. Uses NVMe interfaces. Each local SSD must be 375 or 3000 GB in size, and all local SSDs must share the same size.</summary>
    [JsonPropertyName("localSsdCount")]
    public int LocalSsdCount { get; set; }
}

/// <summary>Enable or disable NCCL Fast Socket in the node pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNodeConfigFastSocket
{
    /// <summary>Whether or not NCCL Fast Socket is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }
}

/// <summary>Immutable. GCFS configuration for this node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNodeConfigGcfsConfig
{
    /// <summary>Immutable. Whether or not GCFS is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }
}

/// <summary>Immutable. Configuration for auto installation of GPU driver.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNodeConfigGuestAcceleratorGpuDriverInstallationConfig
{
    /// <summary>Immutable. Mode for how the GPU driver is installed.</summary>
    [JsonPropertyName("gpuDriverVersion")]
    public string GpuDriverVersion { get; set; }
}

/// <summary>Immutable. Configuration for GPU sharing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNodeConfigGuestAcceleratorGpuSharingConfig
{
    /// <summary>Immutable. The type of GPU sharing strategy to enable on the GPU node. Possible values are described in the API package (https://pkg.go.dev/google.golang.org/api/container/v1#GPUSharingConfig).</summary>
    [JsonPropertyName("gpuSharingStrategy")]
    public string GpuSharingStrategy { get; set; }

    /// <summary>Immutable. The maximum number of containers that can share a GPU.</summary>
    [JsonPropertyName("maxSharedClientsPerGpu")]
    public int MaxSharedClientsPerGpu { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNodeConfigGuestAccelerator
{
    /// <summary>Immutable. The number of the accelerator cards exposed to an instance.</summary>
    [JsonPropertyName("count")]
    public int Count { get; set; }

    /// <summary>Immutable. Configuration for auto installation of GPU driver.</summary>
    [JsonPropertyName("gpuDriverInstallationConfig")]
    public V1beta1ContainerClusterSpecNodeConfigGuestAcceleratorGpuDriverInstallationConfig? GpuDriverInstallationConfig { get; set; }

    /// <summary>Immutable. Size of partitions to create on the GPU. Valid values are described in the NVIDIA mig user guide (https://docs.nvidia.com/datacenter/tesla/mig-user-guide/#partitioning).</summary>
    [JsonPropertyName("gpuPartitionSize")]
    public string? GpuPartitionSize { get; set; }

    /// <summary>Immutable. Configuration for GPU sharing.</summary>
    [JsonPropertyName("gpuSharingConfig")]
    public V1beta1ContainerClusterSpecNodeConfigGuestAcceleratorGpuSharingConfig? GpuSharingConfig { get; set; }

    /// <summary>Immutable. The accelerator type resource name.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Immutable. Enable or disable gvnic in the node pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNodeConfigGvnic
{
    /// <summary>Immutable. Whether or not gvnic is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }
}

/// <summary>Immutable. The maintenance policy for the hosts on which the GKE VMs run on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNodeConfigHostMaintenancePolicy
{
    /// <summary>Immutable. .</summary>
    [JsonPropertyName("maintenanceInterval")]
    public string MaintenanceInterval { get; set; }
}

/// <summary>Node kubelet configs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNodeConfigKubeletConfig
{
    /// <summary>Enable CPU CFS quota enforcement for containers that specify CPU limits.</summary>
    [JsonPropertyName("cpuCfsQuota")]
    public bool? CpuCfsQuota { get; set; }

    /// <summary>Set the CPU CFS quota period value 'cpu.cfs_period_us'.</summary>
    [JsonPropertyName("cpuCfsQuotaPeriod")]
    public string? CpuCfsQuotaPeriod { get; set; }

    /// <summary>Control the CPU management policy on the node.</summary>
    [JsonPropertyName("cpuManagerPolicy")]
    public string CpuManagerPolicy { get; set; }

    /// <summary>Controls the maximum number of processes allowed to run in a pod.</summary>
    [JsonPropertyName("podPidsLimit")]
    public int? PodPidsLimit { get; set; }
}

/// <summary>Parameters that can be configured on Linux nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNodeConfigLinuxNodeConfig
{
    /// <summary>cgroupMode specifies the cgroup mode to be used on the node.</summary>
    [JsonPropertyName("cgroupMode")]
    public string? CgroupMode { get; set; }

    /// <summary>The Linux kernel parameters to be applied to the nodes and all pods running on the nodes.</summary>
    [JsonPropertyName("sysctls")]
    public IDictionary<string, string>? Sysctls { get; set; }
}

/// <summary>Immutable. Parameters for raw-block local NVMe SSDs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNodeConfigLocalNvmeSsdBlockConfig
{
    /// <summary>Immutable. Number of raw-block local NVMe SSD disks to be attached to the node. Each local SSD is 375 GB in size.</summary>
    [JsonPropertyName("localSsdCount")]
    public int LocalSsdCount { get; set; }
}

/// <summary>Immutable. Setting this field will assign instances of this pool to run on the specified node group. This is useful for running workloads on sole tenant nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNodeConfigNodeGroupRef
{
    /// <summary>Allowed value: The `name` field of a `ComputeNodeGroup` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. The reservation affinity configuration for the node pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNodeConfigReservationAffinity
{
    /// <summary>Immutable. Corresponds to the type of reservation consumption.</summary>
    [JsonPropertyName("consumeReservationType")]
    public string ConsumeReservationType { get; set; }

    /// <summary>Immutable. The label key of a reservation resource.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Immutable. The label values of the reservation resource.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Immutable. Sandbox configuration for this node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNodeConfigSandboxConfig
{
    /// <summary>Type of the sandbox to use for the node (e.g. 'gvisor').</summary>
    [JsonPropertyName("sandboxType")]
    public string SandboxType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNodeConfigServiceAccountRef
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

/// <summary>Immutable. Shielded Instance options.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNodeConfigShieldedInstanceConfig
{
    /// <summary>Immutable. Defines whether the instance has integrity monitoring enabled.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>Immutable. Defines whether the instance has Secure Boot enabled.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNodeConfigSoleTenantConfigNodeAffinity
{
    /// <summary>Immutable. .</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Immutable. .</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>Immutable. .</summary>
    [JsonPropertyName("values")]
    public IList<string> Values { get; set; }
}

/// <summary>Immutable. Node affinity options for sole tenant node pools.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNodeConfigSoleTenantConfig
{
    /// <summary>Immutable. .</summary>
    [JsonPropertyName("nodeAffinity")]
    public IList<V1beta1ContainerClusterSpecNodeConfigSoleTenantConfigNodeAffinity> NodeAffinity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNodeConfigTaint
{
    /// <summary>Effect for taint.</summary>
    [JsonPropertyName("effect")]
    public string Effect { get; set; }

    /// <summary>Key for taint.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Value for taint.</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>Immutable. The workload metadata configuration for this node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNodeConfigWorkloadMetadataConfig
{
    /// <summary>Mode is the configuration for how to expose metadata to workloads running on the node.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>DEPRECATED. Deprecated in favor of mode. NodeMetadata is the configuration for how to expose metadata to the workloads running on the node.</summary>
    [JsonPropertyName("nodeMetadata")]
    public string? NodeMetadata { get; set; }
}

/// <summary>Immutable. The configuration of the nodepool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNodeConfig
{
    /// <summary>Immutable. Specifies options for controlling advanced machine features.</summary>
    [JsonPropertyName("advancedMachineFeatures")]
    public V1beta1ContainerClusterSpecNodeConfigAdvancedMachineFeatures? AdvancedMachineFeatures { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bootDiskKMSCryptoKeyRef")]
    public V1beta1ContainerClusterSpecNodeConfigBootDiskKMSCryptoKeyRef? BootDiskKMSCryptoKeyRef { get; set; }

    /// <summary>Immutable. Configuration for the confidential nodes feature, which makes nodes run on confidential VMs. Warning: This configuration can't be changed (or added/removed) after pool creation without deleting and recreating the entire pool.</summary>
    [JsonPropertyName("confidentialNodes")]
    public V1beta1ContainerClusterSpecNodeConfigConfidentialNodes? ConfidentialNodes { get; set; }

    /// <summary>Immutable. Size of the disk attached to each node, specified in GB. The smallest allowed disk size is 10GB.</summary>
    [JsonPropertyName("diskSizeGb")]
    public int? DiskSizeGb { get; set; }

    /// <summary>Immutable. Type of the disk attached to each node. Such as pd-standard, pd-balanced or pd-ssd.</summary>
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    /// <summary>Immutable. Parameters for the ephemeral storage filesystem. If unspecified, ephemeral storage is backed by the boot disk.</summary>
    [JsonPropertyName("ephemeralStorageConfig")]
    public V1beta1ContainerClusterSpecNodeConfigEphemeralStorageConfig? EphemeralStorageConfig { get; set; }

    /// <summary>Immutable. Parameters for the ephemeral storage filesystem. If unspecified, ephemeral storage is backed by the boot disk.</summary>
    [JsonPropertyName("ephemeralStorageLocalSsdConfig")]
    public V1beta1ContainerClusterSpecNodeConfigEphemeralStorageLocalSsdConfig? EphemeralStorageLocalSsdConfig { get; set; }

    /// <summary>Enable or disable NCCL Fast Socket in the node pool.</summary>
    [JsonPropertyName("fastSocket")]
    public V1beta1ContainerClusterSpecNodeConfigFastSocket? FastSocket { get; set; }

    /// <summary>Immutable. GCFS configuration for this node.</summary>
    [JsonPropertyName("gcfsConfig")]
    public V1beta1ContainerClusterSpecNodeConfigGcfsConfig? GcfsConfig { get; set; }

    /// <summary>Immutable. List of the type and count of accelerator cards attached to the instance.</summary>
    [JsonPropertyName("guestAccelerator")]
    public IList<V1beta1ContainerClusterSpecNodeConfigGuestAccelerator>? GuestAccelerator { get; set; }

    /// <summary>Immutable. Enable or disable gvnic in the node pool.</summary>
    [JsonPropertyName("gvnic")]
    public V1beta1ContainerClusterSpecNodeConfigGvnic? Gvnic { get; set; }

    /// <summary>Immutable. The maintenance policy for the hosts on which the GKE VMs run on.</summary>
    [JsonPropertyName("hostMaintenancePolicy")]
    public V1beta1ContainerClusterSpecNodeConfigHostMaintenancePolicy? HostMaintenancePolicy { get; set; }

    /// <summary>The image type to use for this node. Note that for a given image type, the latest version of it will be used.</summary>
    [JsonPropertyName("imageType")]
    public string? ImageType { get; set; }

    /// <summary>Node kubelet configs.</summary>
    [JsonPropertyName("kubeletConfig")]
    public V1beta1ContainerClusterSpecNodeConfigKubeletConfig? KubeletConfig { get; set; }

    /// <summary>Immutable. The map of Kubernetes labels (key/value pairs) to be applied to each node. These will added in addition to any default label(s) that Kubernetes may apply to the node.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Parameters that can be configured on Linux nodes.</summary>
    [JsonPropertyName("linuxNodeConfig")]
    public V1beta1ContainerClusterSpecNodeConfigLinuxNodeConfig? LinuxNodeConfig { get; set; }

    /// <summary>Immutable. Parameters for raw-block local NVMe SSDs.</summary>
    [JsonPropertyName("localNvmeSsdBlockConfig")]
    public V1beta1ContainerClusterSpecNodeConfigLocalNvmeSsdBlockConfig? LocalNvmeSsdBlockConfig { get; set; }

    /// <summary>Immutable. The number of local SSD disks to be attached to the node.</summary>
    [JsonPropertyName("localSsdCount")]
    public int? LocalSsdCount { get; set; }

    /// <summary>Type of logging agent that is used as the default value for node pools in the cluster. Valid values include DEFAULT and MAX_THROUGHPUT.</summary>
    [JsonPropertyName("loggingVariant")]
    public string? LoggingVariant { get; set; }

    /// <summary>Immutable. The name of a Google Compute Engine machine type.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Immutable. The metadata key/value pairs assigned to instances in the cluster.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>Immutable. Minimum CPU platform to be used by this instance. The instance may be scheduled on the specified or newer CPU platform.</summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>Immutable. Setting this field will assign instances of this pool to run on the specified node group. This is useful for running workloads on sole tenant nodes.</summary>
    [JsonPropertyName("nodeGroupRef")]
    public V1beta1ContainerClusterSpecNodeConfigNodeGroupRef? NodeGroupRef { get; set; }

    /// <summary>Immutable. The set of Google API scopes to be made available on all of the node VMs.</summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }

    /// <summary>Immutable. Whether the nodes are created as preemptible VM instances.</summary>
    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    /// <summary>Immutable. The reservation affinity configuration for the node pool.</summary>
    [JsonPropertyName("reservationAffinity")]
    public V1beta1ContainerClusterSpecNodeConfigReservationAffinity? ReservationAffinity { get; set; }

    /// <summary>The GCE resource labels (a map of key/value pairs) to be applied to the node pool.</summary>
    [JsonPropertyName("resourceLabels")]
    public IDictionary<string, string>? ResourceLabels { get; set; }

    /// <summary>Immutable. Sandbox configuration for this node.</summary>
    [JsonPropertyName("sandboxConfig")]
    public V1beta1ContainerClusterSpecNodeConfigSandboxConfig? SandboxConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1ContainerClusterSpecNodeConfigServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Immutable. Shielded Instance options.</summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta1ContainerClusterSpecNodeConfigShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    /// <summary>Immutable. Node affinity options for sole tenant node pools.</summary>
    [JsonPropertyName("soleTenantConfig")]
    public V1beta1ContainerClusterSpecNodeConfigSoleTenantConfig? SoleTenantConfig { get; set; }

    /// <summary>Immutable. Whether the nodes are created as spot VM instances.</summary>
    [JsonPropertyName("spot")]
    public bool? Spot { get; set; }

    /// <summary>The list of instance tags applied to all nodes.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>List of Kubernetes taints to be applied to each node.</summary>
    [JsonPropertyName("taint")]
    public IList<V1beta1ContainerClusterSpecNodeConfigTaint>? Taint { get; set; }

    /// <summary>Immutable. The workload metadata configuration for this node.</summary>
    [JsonPropertyName("workloadMetadataConfig")]
    public V1beta1ContainerClusterSpecNodeConfigWorkloadMetadataConfig? WorkloadMetadataConfig { get; set; }
}

/// <summary>Collection of Compute Engine network tags that can be applied to a node's underlying VM instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNodePoolAutoConfigNetworkTags
{
    /// <summary>List of network tags applied to auto-provisioned node pools.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}

/// <summary>Node pool configs that apply to all auto-provisioned node pools in autopilot clusters and node auto-provisioning enabled clusters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNodePoolAutoConfig
{
    /// <summary>Collection of Compute Engine network tags that can be applied to a node's underlying VM instance.</summary>
    [JsonPropertyName("networkTags")]
    public V1beta1ContainerClusterSpecNodePoolAutoConfigNetworkTags? NetworkTags { get; set; }
}

/// <summary>GCFS configuration for this node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNodePoolDefaultsNodeConfigDefaultsGcfsConfig
{
    /// <summary>Whether or not GCFS is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }
}

/// <summary>Subset of NodeConfig message that has defaults.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNodePoolDefaultsNodeConfigDefaults
{
    /// <summary>GCFS configuration for this node.</summary>
    [JsonPropertyName("gcfsConfig")]
    public V1beta1ContainerClusterSpecNodePoolDefaultsNodeConfigDefaultsGcfsConfig? GcfsConfig { get; set; }

    /// <summary>Type of logging agent that is used as the default value for node pools in the cluster. Valid values include DEFAULT and MAX_THROUGHPUT.</summary>
    [JsonPropertyName("loggingVariant")]
    public string? LoggingVariant { get; set; }
}

/// <summary>The default nodel pool settings for the entire cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNodePoolDefaults
{
    /// <summary>Subset of NodeConfig message that has defaults.</summary>
    [JsonPropertyName("nodeConfigDefaults")]
    public V1beta1ContainerClusterSpecNodePoolDefaultsNodeConfigDefaults? NodeConfigDefaults { get; set; }
}

/// <summary>Allows filtering to one or more specific event types. If event types are present, those and only those event types will be transmitted to the cluster. Other types will be skipped. If no filter is specified, or no event types are present, all event types will be sent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNotificationConfigPubsubFilter
{
    /// <summary>Can be used to filter what notifications are sent. Valid values include include UPGRADE_AVAILABLE_EVENT, UPGRADE_EVENT and SECURITY_BULLETIN_EVENT.</summary>
    [JsonPropertyName("eventType")]
    public IList<string> EventType { get; set; }
}

/// <summary>The PubSubTopic to send the notification to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNotificationConfigPubsubTopicRef
{
    /// <summary>Allowed value: string of the format `projects/{{project}}/topics/{{value}}`, where {{value}} is the `name` field of a `PubSubTopic` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Notification config for Cloud Pub/Sub.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNotificationConfigPubsub
{
    /// <summary>Whether or not the notification config is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }

    /// <summary>Allows filtering to one or more specific event types. If event types are present, those and only those event types will be transmitted to the cluster. Other types will be skipped. If no filter is specified, or no event types are present, all event types will be sent.</summary>
    [JsonPropertyName("filter")]
    public V1beta1ContainerClusterSpecNotificationConfigPubsubFilter? Filter { get; set; }

    /// <summary>The PubSubTopic to send the notification to.</summary>
    [JsonPropertyName("topicRef")]
    public V1beta1ContainerClusterSpecNotificationConfigPubsubTopicRef? TopicRef { get; set; }
}

/// <summary>The notification config for sending cluster upgrade notifications.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecNotificationConfig
{
    /// <summary>Notification config for Cloud Pub/Sub.</summary>
    [JsonPropertyName("pubsub")]
    public V1beta1ContainerClusterSpecNotificationConfigPubsub Pubsub { get; set; }
}

/// <summary>Configuration for the PodSecurityPolicy feature.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecPodSecurityPolicyConfig
{
    /// <summary>Enable the PodSecurityPolicy controller for this cluster. If enabled, pods must be valid under a PodSecurityPolicy to be created.</summary>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }
}

/// <summary>Controls cluster master global access settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecPrivateClusterConfigMasterGlobalAccessConfig
{
    /// <summary>Whether the cluster master is accessible globally or not.</summary>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }
}

/// <summary>Immutable. Subnetwork in cluster's network where master's endpoint will be provisioned.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecPrivateClusterConfigPrivateEndpointSubnetworkRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Configuration for private clusters, clusters with private nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecPrivateClusterConfig
{
    /// <summary>When true, the cluster's private endpoint is used as the cluster endpoint and access through the public endpoint is disabled. When false, either endpoint can be used.</summary>
    [JsonPropertyName("enablePrivateEndpoint")]
    public bool? EnablePrivateEndpoint { get; set; }

    /// <summary>Immutable. Enables the private cluster feature, creating a private endpoint on the cluster. In a private cluster, nodes only have RFC 1918 private addresses and communicate with the master's private endpoint via private networking.</summary>
    [JsonPropertyName("enablePrivateNodes")]
    public bool? EnablePrivateNodes { get; set; }

    /// <summary>Controls cluster master global access settings.</summary>
    [JsonPropertyName("masterGlobalAccessConfig")]
    public V1beta1ContainerClusterSpecPrivateClusterConfigMasterGlobalAccessConfig? MasterGlobalAccessConfig { get; set; }

    /// <summary>Immutable. The IP range in CIDR notation to use for the hosted master network. This range will be used for assigning private IP addresses to the cluster master(s) and the ILB VIP. This range must not overlap with any other ranges in use within the cluster's network, and it must be a /28 subnet. See Private Cluster Limitations for more details. This field only applies to private clusters, when enable_private_nodes is true.</summary>
    [JsonPropertyName("masterIpv4CidrBlock")]
    public string? MasterIpv4CidrBlock { get; set; }

    /// <summary>The name of the peering between this cluster and the Google owned VPC.</summary>
    [JsonPropertyName("peeringName")]
    public string? PeeringName { get; set; }

    /// <summary>The internal IP address of this cluster's master endpoint.</summary>
    [JsonPropertyName("privateEndpoint")]
    public string? PrivateEndpoint { get; set; }

    /// <summary>Immutable. Subnetwork in cluster's network where master's endpoint will be provisioned.</summary>
    [JsonPropertyName("privateEndpointSubnetworkRef")]
    public V1beta1ContainerClusterSpecPrivateClusterConfigPrivateEndpointSubnetworkRef? PrivateEndpointSubnetworkRef { get; set; }

    /// <summary>The external IP address of this cluster's master endpoint.</summary>
    [JsonPropertyName("publicEndpoint")]
    public string? PublicEndpoint { get; set; }
}

/// <summary>WorkloadConfig defines which actions are enabled for a cluster's workload configurations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecProtectConfigWorkloadConfig
{
    /// <summary>Sets which mode of auditing should be used for the cluster's workloads. Accepted values are DISABLED, BASIC.</summary>
    [JsonPropertyName("auditMode")]
    public string AuditMode { get; set; }
}

/// <summary>Enable/Disable Protect API features for the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecProtectConfig
{
    /// <summary>WorkloadConfig defines which actions are enabled for a cluster's workload configurations.</summary>
    [JsonPropertyName("workloadConfig")]
    public V1beta1ContainerClusterSpecProtectConfigWorkloadConfig? WorkloadConfig { get; set; }

    /// <summary>Sets which mode to use for Protect workload vulnerability scanning feature. Accepted values are DISABLED, BASIC.</summary>
    [JsonPropertyName("workloadVulnerabilityMode")]
    public string? WorkloadVulnerabilityMode { get; set; }
}

/// <summary>Configuration options for the Release channel feature, which provide more control over automatic upgrades of your GKE clusters. Note that removing this field from your config will not unenroll it. Instead, use the "UNSPECIFIED" channel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecReleaseChannel
{
    /// <summary>The selected release channel. Accepted values are: * UNSPECIFIED: Not set. * RAPID: Weekly upgrade cadence; Early testers and developers who requires new features. * REGULAR: Multiple per month upgrade cadence; Production users who need features not yet offered in the Stable channel. * STABLE: Every few months upgrade cadence; Production users who need stability above all else, and for whom frequent upgrades are too risky.</summary>
    [JsonPropertyName("channel")]
    public string Channel { get; set; }
}

/// <summary>Parameters for using BigQuery as the destination of resource usage export.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecResourceUsageExportConfigBigqueryDestination
{
    /// <summary>The ID of a BigQuery Dataset.</summary>
    [JsonPropertyName("datasetId")]
    public string DatasetId { get; set; }
}

/// <summary>Configuration for the ResourceUsageExportConfig feature.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecResourceUsageExportConfig
{
    /// <summary>Parameters for using BigQuery as the destination of resource usage export.</summary>
    [JsonPropertyName("bigqueryDestination")]
    public V1beta1ContainerClusterSpecResourceUsageExportConfigBigqueryDestination BigqueryDestination { get; set; }

    /// <summary>Whether to enable network egress metering for this cluster. If enabled, a daemonset will be created in the cluster to meter network egress traffic.</summary>
    [JsonPropertyName("enableNetworkEgressMetering")]
    public bool? EnableNetworkEgressMetering { get; set; }

    /// <summary>Whether to enable resource consumption metering on this cluster. When enabled, a table will be created in the resource export BigQuery dataset to store resource consumption data. The resulting table can be joined with the resource usage table or with BigQuery billing export. Defaults to true.</summary>
    [JsonPropertyName("enableResourceConsumptionMetering")]
    public bool? EnableResourceConsumptionMetering { get; set; }
}

/// <summary>Defines the config needed to enable/disable features for the Security Posture API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecSecurityPostureConfig
{
    /// <summary>Sets the mode of the Kubernetes security posture API's off-cluster features. Available options include DISABLED and BASIC.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Sets the mode of the Kubernetes security posture API's workload vulnerability scanning. Available options include VULNERABILITY_DISABLED and VULNERABILITY_BASIC.</summary>
    [JsonPropertyName("vulnerabilityMode")]
    public string? VulnerabilityMode { get; set; }
}

/// <summary>If set, and enabled=true, services with external ips field will not be blocked.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecServiceExternalIpsConfig
{
    /// <summary>When enabled, services with exterenal ips specified will be allowed.</summary>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecSubnetworkRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Vertical Pod Autoscaling automatically adjusts the resources of pods controlled by it.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecVerticalPodAutoscaling
{
    /// <summary>Enables vertical pod autoscaling.</summary>
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }
}

/// <summary>Configuration for the use of Kubernetes Service Accounts in GCP IAM policies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpecWorkloadIdentityConfig
{
    /// <summary>DEPRECATED. This field will be removed in a future major release as it has been deprecated in the API. Use `workloadPool` instead; `workloadPool` field will supersede this field. Enables workload identity.</summary>
    [JsonPropertyName("identityNamespace")]
    public string? IdentityNamespace { get; set; }

    /// <summary>The workload pool to attach all Kubernetes service accounts to.</summary>
    [JsonPropertyName("workloadPool")]
    public string? WorkloadPool { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterSpec
{
    /// <summary>The configuration for addons supported by GKE.</summary>
    [JsonPropertyName("addonsConfig")]
    public V1beta1ContainerClusterSpecAddonsConfig? AddonsConfig { get; set; }

    /// <summary>Enable NET_ADMIN for this cluster.</summary>
    [JsonPropertyName("allowNetAdmin")]
    public bool? AllowNetAdmin { get; set; }

    /// <summary>Configuration for the Google Groups for GKE feature.</summary>
    [JsonPropertyName("authenticatorGroupsConfig")]
    public V1beta1ContainerClusterSpecAuthenticatorGroupsConfig? AuthenticatorGroupsConfig { get; set; }

    /// <summary>Configuration options for the Binary Authorization feature.</summary>
    [JsonPropertyName("binaryAuthorization")]
    public V1beta1ContainerClusterSpecBinaryAuthorization? BinaryAuthorization { get; set; }

    /// <summary>Per-cluster configuration of Node Auto-Provisioning with Cluster Autoscaler to automatically adjust the size of the cluster and create/delete node pools based on the current needs of the cluster's workload. See the guide to using Node Auto-Provisioning for more details.</summary>
    [JsonPropertyName("clusterAutoscaling")]
    public V1beta1ContainerClusterSpecClusterAutoscaling? ClusterAutoscaling { get; set; }

    /// <summary>Immutable. The IP address range of the Kubernetes pods in this cluster in CIDR notation (e.g. 10.96.0.0/14). Leave blank to have one automatically chosen or specify a /14 block in 10.0.0.0/8. This field will only work for routes-based clusters, where ip_allocation_policy is not defined.</summary>
    [JsonPropertyName("clusterIpv4Cidr")]
    public string? ClusterIpv4Cidr { get; set; }

    /// <summary>Telemetry integration for the cluster.</summary>
    [JsonPropertyName("clusterTelemetry")]
    public V1beta1ContainerClusterSpecClusterTelemetry? ClusterTelemetry { get; set; }

    /// <summary>Immutable. Configuration for the confidential nodes feature, which makes nodes run on confidential VMs. Warning: This configuration can't be changed (or added/removed) after cluster creation without deleting and recreating the entire cluster.</summary>
    [JsonPropertyName("confidentialNodes")]
    public V1beta1ContainerClusterSpecConfidentialNodes? ConfidentialNodes { get; set; }

    /// <summary>Cost management configuration for the cluster.</summary>
    [JsonPropertyName("costManagementConfig")]
    public V1beta1ContainerClusterSpecCostManagementConfig? CostManagementConfig { get; set; }

    /// <summary>Application-layer Secrets Encryption settings. The object format is {state = string, key_name = string}. Valid values of state are: "ENCRYPTED"; "DECRYPTED". key_name is the name of a CloudKMS key.</summary>
    [JsonPropertyName("databaseEncryption")]
    public V1beta1ContainerClusterSpecDatabaseEncryption? DatabaseEncryption { get; set; }

    /// <summary>Immutable. The desired datapath provider for this cluster. By default, uses the IPTables-based kube-proxy implementation.</summary>
    [JsonPropertyName("datapathProvider")]
    public string? DatapathProvider { get; set; }

    /// <summary>Immutable. The default maximum number of pods per node in this cluster. This doesn't work on "routes-based" clusters, clusters that don't have IP Aliasing enabled.</summary>
    [JsonPropertyName("defaultMaxPodsPerNode")]
    public int? DefaultMaxPodsPerNode { get; set; }

    /// <summary>Whether the cluster disables default in-node sNAT rules. In-node sNAT rules will be disabled when defaultSnatStatus is disabled.</summary>
    [JsonPropertyName("defaultSnatStatus")]
    public V1beta1ContainerClusterSpecDefaultSnatStatus? DefaultSnatStatus { get; set; }

    /// <summary>Immutable.  Description of the cluster.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. Configuration for Cloud DNS for Kubernetes Engine.</summary>
    [JsonPropertyName("dnsConfig")]
    public V1beta1ContainerClusterSpecDnsConfig? DnsConfig { get; set; }

    /// <summary>Immutable. Enable Autopilot for this cluster.</summary>
    [JsonPropertyName("enableAutopilot")]
    public bool? EnableAutopilot { get; set; }

    /// <summary>DEPRECATED. Deprecated in favor of binary_authorization. Enable Binary Authorization for this cluster. If enabled, all container images will be validated by Google Binary Authorization.</summary>
    [JsonPropertyName("enableBinaryAuthorization")]
    public bool? EnableBinaryAuthorization { get; set; }

    /// <summary>Whether FQDN Network Policy is enabled on this cluster.</summary>
    [JsonPropertyName("enableFqdnNetworkPolicy")]
    public bool? EnableFqdnNetworkPolicy { get; set; }

    /// <summary>Whether Intra-node visibility is enabled for this cluster. This makes same node pod to pod traffic visible for VPC network.</summary>
    [JsonPropertyName("enableIntranodeVisibility")]
    public bool? EnableIntranodeVisibility { get; set; }

    /// <summary>Configuration for Kubernetes Beta APIs.</summary>
    [JsonPropertyName("enableK8sBetaApis")]
    public V1beta1ContainerClusterSpecEnableK8sBetaApis? EnableK8sBetaApis { get; set; }

    /// <summary>Immutable. Whether to enable Kubernetes Alpha features for this cluster. Note that when this option is enabled, the cluster cannot be upgraded and will be automatically deleted after 30 days.</summary>
    [JsonPropertyName("enableKubernetesAlpha")]
    public bool? EnableKubernetesAlpha { get; set; }

    /// <summary>Whether L4ILB Subsetting is enabled for this cluster.</summary>
    [JsonPropertyName("enableL4IlbSubsetting")]
    public bool? EnableL4IlbSubsetting { get; set; }

    /// <summary>Whether the ABAC authorizer is enabled for this cluster. When enabled, identities in the system, including service accounts, nodes, and controllers, will have statically granted permissions beyond those provided by the RBAC configuration or IAM. Defaults to false.</summary>
    [JsonPropertyName("enableLegacyAbac")]
    public bool? EnableLegacyAbac { get; set; }

    /// <summary>Immutable. Whether multi-networking is enabled for this cluster.</summary>
    [JsonPropertyName("enableMultiNetworking")]
    public bool? EnableMultiNetworking { get; set; }

    /// <summary>Enable Shielded Nodes features on all nodes in this cluster. Defaults to true.</summary>
    [JsonPropertyName("enableShieldedNodes")]
    public bool? EnableShieldedNodes { get; set; }

    /// <summary>Immutable. Whether to enable Cloud TPU resources in this cluster.</summary>
    [JsonPropertyName("enableTpu")]
    public bool? EnableTpu { get; set; }

    /// <summary>Configuration for GKE Gateway API controller.</summary>
    [JsonPropertyName("gatewayApiConfig")]
    public V1beta1ContainerClusterSpecGatewayApiConfig? GatewayApiConfig { get; set; }

    /// <summary>Configuration for Identity Service which allows customers to use external identity providers with the K8S API.</summary>
    [JsonPropertyName("identityServiceConfig")]
    public V1beta1ContainerClusterSpecIdentityServiceConfig? IdentityServiceConfig { get; set; }

    /// <summary>Immutable. The number of nodes to create in this cluster's default node pool. In regional or multi-zonal clusters, this is the number of nodes per zone. Must be set if node_pool is not set. If you're using google_container_node_pool objects with no default node pool, you'll need to set this to a value of at least 1, alongside setting remove_default_node_pool to true.</summary>
    [JsonPropertyName("initialNodeCount")]
    public int? InitialNodeCount { get; set; }

    /// <summary>Immutable. Configuration of cluster IP allocation for VPC-native clusters. Adding this block enables IP aliasing, making the cluster VPC-native instead of routes-based.</summary>
    [JsonPropertyName("ipAllocationPolicy")]
    public V1beta1ContainerClusterSpecIpAllocationPolicy? IpAllocationPolicy { get; set; }

    /// <summary>Immutable. The location (region or zone) in which the cluster master will be created, as well as the default node location. If you specify a zone (such as us-central1-a), the cluster will be a zonal cluster with a single cluster master. If you specify a region (such as us-west1), the cluster will be a regional cluster with multiple masters spread across zones in the region, and with default node locations in those zones as well.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Logging configuration for the cluster.</summary>
    [JsonPropertyName("loggingConfig")]
    public V1beta1ContainerClusterSpecLoggingConfig? LoggingConfig { get; set; }

    /// <summary>The logging service that the cluster should write logs to. Available options include logging.googleapis.com(Legacy Stackdriver), logging.googleapis.com/kubernetes(Stackdriver Kubernetes Engine Logging), and none. Defaults to logging.googleapis.com/kubernetes.</summary>
    [JsonPropertyName("loggingService")]
    public string? LoggingService { get; set; }

    /// <summary>The maintenance policy to use for the cluster.</summary>
    [JsonPropertyName("maintenancePolicy")]
    public V1beta1ContainerClusterSpecMaintenancePolicy? MaintenancePolicy { get; set; }

    /// <summary>DEPRECATED. Basic authentication was removed for GKE cluster versions &gt;= 1.19. The authentication information for accessing the Kubernetes master. Some values in this block are only returned by the API if your service account has permission to get credentials for your GKE cluster. If you see an unexpected diff unsetting your client cert, ensure you have the container.clusters.getCredentials permission.</summary>
    [JsonPropertyName("masterAuth")]
    public V1beta1ContainerClusterSpecMasterAuth? MasterAuth { get; set; }

    /// <summary>The desired configuration options for master authorized networks. Omit the nested cidr_blocks attribute to disallow external access (except the cluster node IPs, which GKE automatically whitelists).</summary>
    [JsonPropertyName("masterAuthorizedNetworksConfig")]
    public V1beta1ContainerClusterSpecMasterAuthorizedNetworksConfig? MasterAuthorizedNetworksConfig { get; set; }

    /// <summary>If set, and enable_certificates=true, the GKE Workload Identity Certificates controller and node agent will be deployed in the cluster.</summary>
    [JsonPropertyName("meshCertificates")]
    public V1beta1ContainerClusterSpecMeshCertificates? MeshCertificates { get; set; }

    /// <summary>The minimum version of the master. GKE will auto-update the master to new versions, so this does not guarantee the current master version--use the read-only master_version field to obtain that. If unset, the cluster's version will be set by GKE to the version of the most recent official release (which is not necessarily the latest version).</summary>
    [JsonPropertyName("minMasterVersion")]
    public string? MinMasterVersion { get; set; }

    /// <summary>Monitoring configuration for the cluster.</summary>
    [JsonPropertyName("monitoringConfig")]
    public V1beta1ContainerClusterSpecMonitoringConfig? MonitoringConfig { get; set; }

    /// <summary>The monitoring service that the cluster should write metrics to. Automatically send metrics from pods in the cluster to the Google Cloud Monitoring API. VM metrics will be collected by Google Compute Engine regardless of this setting Available options include monitoring.googleapis.com(Legacy Stackdriver), monitoring.googleapis.com/kubernetes(Stackdriver Kubernetes Engine Monitoring), and none. Defaults to monitoring.googleapis.com/kubernetes.</summary>
    [JsonPropertyName("monitoringService")]
    public string? MonitoringService { get; set; }

    /// <summary>Configuration options for the NetworkPolicy feature.</summary>
    [JsonPropertyName("networkPolicy")]
    public V1beta1ContainerClusterSpecNetworkPolicy? NetworkPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkRef")]
    public V1beta1ContainerClusterSpecNetworkRef? NetworkRef { get; set; }

    /// <summary>Immutable. Determines whether alias IPs or routes will be used for pod IPs in the cluster.</summary>
    [JsonPropertyName("networkingMode")]
    public string? NetworkingMode { get; set; }

    /// <summary>Immutable. The configuration of the nodepool.</summary>
    [JsonPropertyName("nodeConfig")]
    public V1beta1ContainerClusterSpecNodeConfig? NodeConfig { get; set; }

    /// <summary>The list of zones in which the cluster's nodes are located. Nodes must be in the region of their regional cluster or in the same region as their cluster's zone for zonal clusters. If this is specified for a zonal cluster, omit the cluster's zone.</summary>
    [JsonPropertyName("nodeLocations")]
    public IList<string>? NodeLocations { get; set; }

    /// <summary>Node pool configs that apply to all auto-provisioned node pools in autopilot clusters and node auto-provisioning enabled clusters.</summary>
    [JsonPropertyName("nodePoolAutoConfig")]
    public V1beta1ContainerClusterSpecNodePoolAutoConfig? NodePoolAutoConfig { get; set; }

    /// <summary>The default nodel pool settings for the entire cluster.</summary>
    [JsonPropertyName("nodePoolDefaults")]
    public V1beta1ContainerClusterSpecNodePoolDefaults? NodePoolDefaults { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeVersion")]
    public string? NodeVersion { get; set; }

    /// <summary>The notification config for sending cluster upgrade notifications.</summary>
    [JsonPropertyName("notificationConfig")]
    public V1beta1ContainerClusterSpecNotificationConfig? NotificationConfig { get; set; }

    /// <summary>Configuration for the PodSecurityPolicy feature.</summary>
    [JsonPropertyName("podSecurityPolicyConfig")]
    public V1beta1ContainerClusterSpecPodSecurityPolicyConfig? PodSecurityPolicyConfig { get; set; }

    /// <summary>Configuration for private clusters, clusters with private nodes.</summary>
    [JsonPropertyName("privateClusterConfig")]
    public V1beta1ContainerClusterSpecPrivateClusterConfig? PrivateClusterConfig { get; set; }

    /// <summary>The desired state of IPv6 connectivity to Google Services. By default, no private IPv6 access to or from Google Services (all access will be via IPv4).</summary>
    [JsonPropertyName("privateIpv6GoogleAccess")]
    public string? PrivateIpv6GoogleAccess { get; set; }

    /// <summary>Enable/Disable Protect API features for the cluster.</summary>
    [JsonPropertyName("protectConfig")]
    public V1beta1ContainerClusterSpecProtectConfig? ProtectConfig { get; set; }

    /// <summary>Configuration options for the Release channel feature, which provide more control over automatic upgrades of your GKE clusters. Note that removing this field from your config will not unenroll it. Instead, use the "UNSPECIFIED" channel.</summary>
    [JsonPropertyName("releaseChannel")]
    public V1beta1ContainerClusterSpecReleaseChannel? ReleaseChannel { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Configuration for the ResourceUsageExportConfig feature.</summary>
    [JsonPropertyName("resourceUsageExportConfig")]
    public V1beta1ContainerClusterSpecResourceUsageExportConfig? ResourceUsageExportConfig { get; set; }

    /// <summary>Defines the config needed to enable/disable features for the Security Posture API.</summary>
    [JsonPropertyName("securityPostureConfig")]
    public V1beta1ContainerClusterSpecSecurityPostureConfig? SecurityPostureConfig { get; set; }

    /// <summary>If set, and enabled=true, services with external ips field will not be blocked.</summary>
    [JsonPropertyName("serviceExternalIpsConfig")]
    public V1beta1ContainerClusterSpecServiceExternalIpsConfig? ServiceExternalIpsConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta1ContainerClusterSpecSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>Vertical Pod Autoscaling automatically adjusts the resources of pods controlled by it.</summary>
    [JsonPropertyName("verticalPodAutoscaling")]
    public V1beta1ContainerClusterSpecVerticalPodAutoscaling? VerticalPodAutoscaling { get; set; }

    /// <summary>Configuration for the use of Kubernetes Service Accounts in GCP IAM policies.</summary>
    [JsonPropertyName("workloadIdentityConfig")]
    public V1beta1ContainerClusterSpecWorkloadIdentityConfig? WorkloadIdentityConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterStatusConditions
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

/// <summary>DEPRECATED. Basic authentication was removed for GKE cluster versions &gt;= 1.19. The authentication information for accessing the Kubernetes master. Some values in this block are only returned by the API if your service account has permission to get credentials for your GKE cluster. If you see an unexpected diff unsetting your client cert, ensure you have the container.clusters.getCredentials permission.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterStatusObservedStateMasterAuth
{
    /// <summary>Base64 encoded public certificate used by clients to authenticate to the cluster endpoint.</summary>
    [JsonPropertyName("clientCertificate")]
    public string? ClientCertificate { get; set; }

    /// <summary>Base64 encoded public certificate that is the root of trust for the cluster.</summary>
    [JsonPropertyName("clusterCaCertificate")]
    public string? ClusterCaCertificate { get; set; }
}

/// <summary>Configuration for private clusters, clusters with private nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterStatusObservedStatePrivateClusterConfig
{
    /// <summary>The internal IP address of this cluster's master endpoint.</summary>
    [JsonPropertyName("privateEndpoint")]
    public string? PrivateEndpoint { get; set; }

    /// <summary>The external IP address of this cluster's master endpoint.</summary>
    [JsonPropertyName("publicEndpoint")]
    public string? PublicEndpoint { get; set; }
}

/// <summary>The observed state of the underlying GCP resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterStatusObservedState
{
    /// <summary>DEPRECATED. Basic authentication was removed for GKE cluster versions &gt;= 1.19. The authentication information for accessing the Kubernetes master. Some values in this block are only returned by the API if your service account has permission to get credentials for your GKE cluster. If you see an unexpected diff unsetting your client cert, ensure you have the container.clusters.getCredentials permission.</summary>
    [JsonPropertyName("masterAuth")]
    public V1beta1ContainerClusterStatusObservedStateMasterAuth? MasterAuth { get; set; }

    /// <summary>Configuration for private clusters, clusters with private nodes.</summary>
    [JsonPropertyName("privateClusterConfig")]
    public V1beta1ContainerClusterStatusObservedStatePrivateClusterConfig? PrivateClusterConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerClusterStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ContainerClusterStatusConditions>? Conditions { get; set; }

    /// <summary>The IP address of this cluster's Kubernetes master.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>The fingerprint of the set of labels for this cluster.</summary>
    [JsonPropertyName("labelFingerprint")]
    public string? LabelFingerprint { get; set; }

    /// <summary>The current version of the master in the cluster. This may be different than the min_master_version set in the config if the master has been updated by GKE.</summary>
    [JsonPropertyName("masterVersion")]
    public string? MasterVersion { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The observed state of the underlying GCP resource.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1ContainerClusterStatusObservedState? ObservedState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>Server-defined URL for the resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>The IP address range of the Kubernetes services in this cluster, in CIDR notation (e.g. 1.2.3.4/29). Service addresses are typically put in the last /16 from the container CIDR.</summary>
    [JsonPropertyName("servicesIpv4Cidr")]
    public string? ServicesIpv4Cidr { get; set; }

    /// <summary>The IP address range of the Cloud TPUs in this cluster, in CIDR notation (e.g. 1.2.3.4/29).</summary>
    [JsonPropertyName("tpuIpv4CidrBlock")]
    public string? TpuIpv4CidrBlock { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ContainerCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ContainerClusterSpec>, IStatus<V1beta1ContainerClusterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ContainerCluster";
    public const string KubeGroup = "container.cnrm.cloud.google.com";
    public const string KubePluralName = "containerclusters";
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
    public V1beta1ContainerClusterSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ContainerClusterStatus? Status { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ContainerClusterList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ContainerCluster>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ContainerClusterList";
    public const string KubeGroup = "container.cnrm.cloud.google.com";
    public const string KubePluralName = "containerclusters";
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
    public IList<V1beta1ContainerCluster> Items { get; set; }
}