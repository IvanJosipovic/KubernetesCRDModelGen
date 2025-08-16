using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containerservice.azure.upbound.io;
/// <summary>KubernetesCluster is the Schema for the KubernetesClusters API. Manages a managed Kubernetes Cluster (also known as AKS / Azure Kubernetes Service)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1KubernetesClusterList : IKubernetesObject<V1ListMeta>, IItems<V1beta1KubernetesCluster>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "KubernetesClusterList";
    public const string KubeGroup = "containerservice.azure.upbound.io";
    public const string KubePluralName = "kubernetesclusters";
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
    public IList<V1beta1KubernetesCluster> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderAciConnectorLinuxSubnetNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderAciConnectorLinuxSubnetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterSpecForProviderAciConnectorLinuxSubnetNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderAciConnectorLinuxSubnetNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderAciConnectorLinuxSubnetNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterSpecForProviderAciConnectorLinuxSubnetNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderAciConnectorLinux
{
    /// <summary>The subnet name for the virtual nodes to run.</summary>
    [JsonPropertyName("subnetName")]
    public string? SubnetName { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetName.</summary>
    [JsonPropertyName("subnetNameRef")]
    public V1beta1KubernetesClusterSpecForProviderAciConnectorLinuxSubnetNameRef? SubnetNameRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetName.</summary>
    [JsonPropertyName("subnetNameSelector")]
    public V1beta1KubernetesClusterSpecForProviderAciConnectorLinuxSubnetNameSelector? SubnetNameSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderApiServerAccessProfile
{
    /// <summary>Set of authorized IP ranges to allow access to API server, e.g. ["198.51.100.0/24"].</summary>
    [JsonPropertyName("authorizedIpRanges")]
    public IList<string>? AuthorizedIpRanges { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderAutoScalerProfile
{
    /// <summary>Detect similar node groups and balance the number of nodes between them. Defaults to false.</summary>
    [JsonPropertyName("balanceSimilarNodeGroups")]
    public bool? BalanceSimilarNodeGroups { get; set; }

    /// <summary>Whether DaemonSet pods will be gracefully terminated from empty nodes. Defaults to false.</summary>
    [JsonPropertyName("daemonsetEvictionForEmptyNodesEnabled")]
    public bool? DaemonsetEvictionForEmptyNodesEnabled { get; set; }

    /// <summary>Whether DaemonSet pods will be gracefully terminated from non-empty nodes. Defaults to true.</summary>
    [JsonPropertyName("daemonsetEvictionForOccupiedNodesEnabled")]
    public bool? DaemonsetEvictionForOccupiedNodesEnabled { get; set; }

    /// <summary>Maximum number of empty nodes that can be deleted at the same time. Defaults to 10.</summary>
    [JsonPropertyName("emptyBulkDeleteMax")]
    public string? EmptyBulkDeleteMax { get; set; }

    /// <summary>Expander to use. Possible values are least-waste, priority, most-pods and random. Defaults to random.</summary>
    [JsonPropertyName("expander")]
    public string? Expander { get; set; }

    /// <summary>Whether DaemonSet pods will be ignored when calculating resource utilization for scale down. Defaults to false.</summary>
    [JsonPropertyName("ignoreDaemonsetsUtilizationEnabled")]
    public bool? IgnoreDaemonsetsUtilizationEnabled { get; set; }

    /// <summary>Maximum number of seconds the cluster autoscaler waits for pod termination when trying to scale down a node. Defaults to 600.</summary>
    [JsonPropertyName("maxGracefulTerminationSec")]
    public string? MaxGracefulTerminationSec { get; set; }

    /// <summary>Maximum time the autoscaler waits for a node to be provisioned. Defaults to 15m.</summary>
    [JsonPropertyName("maxNodeProvisioningTime")]
    public string? MaxNodeProvisioningTime { get; set; }

    /// <summary>Maximum Number of allowed unready nodes. Defaults to 3.</summary>
    [JsonPropertyName("maxUnreadyNodes")]
    public double? MaxUnreadyNodes { get; set; }

    /// <summary>Maximum percentage of unready nodes the cluster autoscaler will stop if the percentage is exceeded. Defaults to 45.</summary>
    [JsonPropertyName("maxUnreadyPercentage")]
    public double? MaxUnreadyPercentage { get; set; }

    /// <summary>For scenarios like burst/batch scale where you don't want CA to act before the kubernetes scheduler could schedule all the pods, you can tell CA to ignore unscheduled pods before they're a certain age. Defaults to 10s.</summary>
    [JsonPropertyName("newPodScaleUpDelay")]
    public string? NewPodScaleUpDelay { get; set; }

    /// <summary>How long after the scale up of AKS nodes the scale down evaluation resumes. Defaults to 10m.</summary>
    [JsonPropertyName("scaleDownDelayAfterAdd")]
    public string? ScaleDownDelayAfterAdd { get; set; }

    /// <summary>How long after node deletion that scale down evaluation resumes. Defaults to the value used for scan_interval.</summary>
    [JsonPropertyName("scaleDownDelayAfterDelete")]
    public string? ScaleDownDelayAfterDelete { get; set; }

    /// <summary>How long after scale down failure that scale down evaluation resumes. Defaults to 3m.</summary>
    [JsonPropertyName("scaleDownDelayAfterFailure")]
    public string? ScaleDownDelayAfterFailure { get; set; }

    /// <summary>How long a node should be unneeded before it is eligible for scale down. Defaults to 10m.</summary>
    [JsonPropertyName("scaleDownUnneeded")]
    public string? ScaleDownUnneeded { get; set; }

    /// <summary>How long an unready node should be unneeded before it is eligible for scale down. Defaults to 20m.</summary>
    [JsonPropertyName("scaleDownUnready")]
    public string? ScaleDownUnready { get; set; }

    /// <summary>Node utilization level, defined as sum of requested resources divided by capacity, below which a node can be considered for scale down. Defaults to 0.5.</summary>
    [JsonPropertyName("scaleDownUtilizationThreshold")]
    public string? ScaleDownUtilizationThreshold { get; set; }

    /// <summary>How often the AKS Cluster should be re-evaluated for scale up/down. Defaults to 10s.</summary>
    [JsonPropertyName("scanInterval")]
    public string? ScanInterval { get; set; }

    /// <summary>If true cluster autoscaler will never delete nodes with pods with local storage, for example, EmptyDir or HostPath. Defaults to true.</summary>
    [JsonPropertyName("skipNodesWithLocalStorage")]
    public bool? SkipNodesWithLocalStorage { get; set; }

    /// <summary>If true cluster autoscaler will never delete nodes with pods from kube-system (except for DaemonSet or mirror pods). Defaults to true.</summary>
    [JsonPropertyName("skipNodesWithSystemPods")]
    public bool? SkipNodesWithSystemPods { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderAzureActiveDirectoryRoleBasedAccessControl
{
    /// <summary>A list of Object IDs of Azure Active Directory Groups which should have Admin Role on the Cluster.</summary>
    [JsonPropertyName("adminGroupObjectIds")]
    public IList<string>? AdminGroupObjectIds { get; set; }

    /// <summary>Is Role Based Access Control based on Azure AD enabled?</summary>
    [JsonPropertyName("azureRbacEnabled")]
    public bool? AzureRbacEnabled { get; set; }

    /// <summary>The Tenant ID used for Azure Active Directory Application. If this isn't specified the Tenant ID of the current Subscription is used.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderConfidentialComputing
{
    /// <summary>Should the SGX quote helper be enabled?</summary>
    [JsonPropertyName("sgxQuoteHelperEnabled")]
    public bool? SgxQuoteHelperEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderDefaultNodePoolKubeletConfig
{
    /// <summary>Specifies the allow list of unsafe sysctls command or patterns (ending in *).</summary>
    [JsonPropertyName("allowedUnsafeSysctls")]
    public IList<string>? AllowedUnsafeSysctls { get; set; }

    /// <summary>Specifies the maximum number of container log files that can be present for a container. must be at least 2.</summary>
    [JsonPropertyName("containerLogMaxLine")]
    public double? ContainerLogMaxLine { get; set; }

    /// <summary>Specifies the maximum size (e.g. 10MB) of container log file before it is rotated.</summary>
    [JsonPropertyName("containerLogMaxSizeMb")]
    public double? ContainerLogMaxSizeMb { get; set; }

    /// <summary>Is CPU CFS quota enforcement for containers enabled? Defaults to true.</summary>
    [JsonPropertyName("cpuCfsQuotaEnabled")]
    public bool? CpuCfsQuotaEnabled { get; set; }

    /// <summary>Specifies the CPU CFS quota period value.</summary>
    [JsonPropertyName("cpuCfsQuotaPeriod")]
    public string? CpuCfsQuotaPeriod { get; set; }

    /// <summary>Specifies the CPU Manager policy to use. Possible values are none and static,.</summary>
    [JsonPropertyName("cpuManagerPolicy")]
    public string? CpuManagerPolicy { get; set; }

    /// <summary>Specifies the percent of disk usage above which image garbage collection is always run. Must be between 0 and 100.</summary>
    [JsonPropertyName("imageGcHighThreshold")]
    public double? ImageGcHighThreshold { get; set; }

    /// <summary>Specifies the percent of disk usage lower than which image garbage collection is never run. Must be between 0 and 100.</summary>
    [JsonPropertyName("imageGcLowThreshold")]
    public double? ImageGcLowThreshold { get; set; }

    /// <summary>Specifies the maximum number of processes per pod.</summary>
    [JsonPropertyName("podMaxPid")]
    public double? PodMaxPid { get; set; }

    /// <summary>Specifies the Topology Manager policy to use. Possible values are none, best-effort, restricted or single-numa-node.</summary>
    [JsonPropertyName("topologyManagerPolicy")]
    public string? TopologyManagerPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderDefaultNodePoolLinuxOsConfigSysctlConfig
{
    /// <summary>The sysctl setting fs.aio-max-nr. Must be between 65536 and 6553500.</summary>
    [JsonPropertyName("fsAioMaxNr")]
    public double? FsAioMaxNr { get; set; }

    /// <summary>The sysctl setting fs.file-max. Must be between 8192 and 12000500.</summary>
    [JsonPropertyName("fsFileMax")]
    public double? FsFileMax { get; set; }

    /// <summary>The sysctl setting fs.inotify.max_user_watches. Must be between 781250 and 2097152.</summary>
    [JsonPropertyName("fsInotifyMaxUserWatches")]
    public double? FsInotifyMaxUserWatches { get; set; }

    /// <summary>The sysctl setting fs.nr_open. Must be between 8192 and 20000500.</summary>
    [JsonPropertyName("fsNrOpen")]
    public double? FsNrOpen { get; set; }

    /// <summary>The sysctl setting kernel.threads-max. Must be between 20 and 513785.</summary>
    [JsonPropertyName("kernelThreadsMax")]
    public double? KernelThreadsMax { get; set; }

    /// <summary>The sysctl setting net.core.netdev_max_backlog. Must be between 1000 and 3240000.</summary>
    [JsonPropertyName("netCoreNetdevMaxBacklog")]
    public double? NetCoreNetdevMaxBacklog { get; set; }

    /// <summary>The sysctl setting net.core.optmem_max. Must be between 20480 and 4194304.</summary>
    [JsonPropertyName("netCoreOptmemMax")]
    public double? NetCoreOptmemMax { get; set; }

    /// <summary>The sysctl setting net.core.rmem_default. Must be between 212992 and 134217728.</summary>
    [JsonPropertyName("netCoreRmemDefault")]
    public double? NetCoreRmemDefault { get; set; }

    /// <summary>The sysctl setting net.core.rmem_max. Must be between 212992 and 134217728.</summary>
    [JsonPropertyName("netCoreRmemMax")]
    public double? NetCoreRmemMax { get; set; }

    /// <summary>The sysctl setting net.core.somaxconn. Must be between 4096 and 3240000.</summary>
    [JsonPropertyName("netCoreSomaxconn")]
    public double? NetCoreSomaxconn { get; set; }

    /// <summary>The sysctl setting net.core.wmem_default. Must be between 212992 and 134217728.</summary>
    [JsonPropertyName("netCoreWmemDefault")]
    public double? NetCoreWmemDefault { get; set; }

    /// <summary>The sysctl setting net.core.wmem_max. Must be between 212992 and 134217728.</summary>
    [JsonPropertyName("netCoreWmemMax")]
    public double? NetCoreWmemMax { get; set; }

    /// <summary>The sysctl setting net.ipv4.ip_local_port_range max value. Must be between 32768 and 65535.</summary>
    [JsonPropertyName("netIpv4IpLocalPortRangeMax")]
    public double? NetIpv4IpLocalPortRangeMax { get; set; }

    /// <summary>The sysctl setting net.ipv4.ip_local_port_range min value. Must be between 1024 and 60999.</summary>
    [JsonPropertyName("netIpv4IpLocalPortRangeMin")]
    public double? NetIpv4IpLocalPortRangeMin { get; set; }

    /// <summary>The sysctl setting net.ipv4.neigh.default.gc_thresh1. Must be between 128 and 80000.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh1")]
    public double? NetIpv4NeighDefaultGcThresh1 { get; set; }

    /// <summary>The sysctl setting net.ipv4.neigh.default.gc_thresh2. Must be between 512 and 90000.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh2")]
    public double? NetIpv4NeighDefaultGcThresh2 { get; set; }

    /// <summary>The sysctl setting net.ipv4.neigh.default.gc_thresh3. Must be between 1024 and 100000.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh3")]
    public double? NetIpv4NeighDefaultGcThresh3 { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_fin_timeout. Must be between 5 and 120.</summary>
    [JsonPropertyName("netIpv4TcpFinTimeout")]
    public double? NetIpv4TcpFinTimeout { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_keepalive_intvl. Must be between 10 and 90.</summary>
    [JsonPropertyName("netIpv4TcpKeepaliveIntvl")]
    public double? NetIpv4TcpKeepaliveIntvl { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_keepalive_probes. Must be between 1 and 15.</summary>
    [JsonPropertyName("netIpv4TcpKeepaliveProbes")]
    public double? NetIpv4TcpKeepaliveProbes { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_keepalive_time. Must be between 30 and 432000.</summary>
    [JsonPropertyName("netIpv4TcpKeepaliveTime")]
    public double? NetIpv4TcpKeepaliveTime { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_max_syn_backlog. Must be between 128 and 3240000.</summary>
    [JsonPropertyName("netIpv4TcpMaxSynBacklog")]
    public double? NetIpv4TcpMaxSynBacklog { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_max_tw_buckets. Must be between 8000 and 1440000.</summary>
    [JsonPropertyName("netIpv4TcpMaxTwBuckets")]
    public double? NetIpv4TcpMaxTwBuckets { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_tw_reuse.</summary>
    [JsonPropertyName("netIpv4TcpTwReuse")]
    public bool? NetIpv4TcpTwReuse { get; set; }

    /// <summary>The sysctl setting net.netfilter.nf_conntrack_buckets. Must be between 65536 and 524288.</summary>
    [JsonPropertyName("netNetfilterNfConntrackBuckets")]
    public double? NetNetfilterNfConntrackBuckets { get; set; }

    /// <summary>The sysctl setting net.netfilter.nf_conntrack_max. Must be between 131072 and 2097152.</summary>
    [JsonPropertyName("netNetfilterNfConntrackMax")]
    public double? NetNetfilterNfConntrackMax { get; set; }

    /// <summary>The sysctl setting vm.max_map_count. Must be between 65530 and 262144.</summary>
    [JsonPropertyName("vmMaxMapCount")]
    public double? VmMaxMapCount { get; set; }

    /// <summary>The sysctl setting vm.swappiness. Must be between 0 and 100.</summary>
    [JsonPropertyName("vmSwappiness")]
    public double? VmSwappiness { get; set; }

    /// <summary>The sysctl setting vm.vfs_cache_pressure. Must be between 0 and 100.</summary>
    [JsonPropertyName("vmVfsCachePressure")]
    public double? VmVfsCachePressure { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderDefaultNodePoolLinuxOsConfig
{
    /// <summary>Specifies the size of the swap file on each node in MB.</summary>
    [JsonPropertyName("swapFileSizeMb")]
    public double? SwapFileSizeMb { get; set; }

    /// <summary>A sysctl_config block as defined below.</summary>
    [JsonPropertyName("sysctlConfig")]
    public IList<V1beta1KubernetesClusterSpecForProviderDefaultNodePoolLinuxOsConfigSysctlConfig>? SysctlConfig { get; set; }

    /// <summary>specifies the defrag configuration for Transparent Huge Page. Possible values are always, defer, defer+madvise, madvise and never.</summary>
    [JsonPropertyName("transparentHugePageDefrag")]
    public string? TransparentHugePageDefrag { get; set; }

    /// <summary>Specifies the Transparent Huge Page enabled configuration. Possible values are always, madvise and never.</summary>
    [JsonPropertyName("transparentHugePageEnabled")]
    public string? TransparentHugePageEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderDefaultNodePoolNodeNetworkProfileAllowedHostPorts
{
    /// <summary>Specifies the end of the port range.</summary>
    [JsonPropertyName("portEnd")]
    public double? PortEnd { get; set; }

    /// <summary>Specifies the start of the port range.</summary>
    [JsonPropertyName("portStart")]
    public double? PortStart { get; set; }

    /// <summary>Specifies the protocol of the port range. Possible values are TCP and UDP.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderDefaultNodePoolNodeNetworkProfile
{
    /// <summary>One or more allowed_host_ports blocks as defined below.</summary>
    [JsonPropertyName("allowedHostPorts")]
    public IList<V1beta1KubernetesClusterSpecForProviderDefaultNodePoolNodeNetworkProfileAllowedHostPorts>? AllowedHostPorts { get; set; }

    /// <summary>A list of Application Security Group IDs which should be associated with this Node Pool.</summary>
    [JsonPropertyName("applicationSecurityGroupIds")]
    public IList<string>? ApplicationSecurityGroupIds { get; set; }

    /// <summary>Specifies a mapping of tags to the instance-level public IPs. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("nodePublicIpTags")]
    public IDictionary<string, string>? NodePublicIpTags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderDefaultNodePoolPodSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate podSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderDefaultNodePoolPodSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterSpecForProviderDefaultNodePoolPodSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderDefaultNodePoolPodSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate podSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderDefaultNodePoolPodSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterSpecForProviderDefaultNodePoolPodSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderDefaultNodePoolUpgradeSettings
{
    /// <summary>The amount of time in minutes to wait on eviction of pods and graceful termination per node. This eviction wait time honors pod disruption budgets for upgrades. If this time is exceeded, the upgrade fails. Unsetting this after configuring it will force a new resource to be created.</summary>
    [JsonPropertyName("drainTimeoutInMinutes")]
    public double? DrainTimeoutInMinutes { get; set; }

    /// <summary>The maximum number or percentage of nodes which will be added to the Node Pool size during an upgrade.</summary>
    [JsonPropertyName("maxSurge")]
    public string? MaxSurge { get; set; }

    /// <summary>The amount of time in minutes to wait after draining a node and before reimaging and moving on to next node. Defaults to 0.</summary>
    [JsonPropertyName("nodeSoakDurationInMinutes")]
    public double? NodeSoakDurationInMinutes { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderDefaultNodePoolVnetSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate vnetSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderDefaultNodePoolVnetSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterSpecForProviderDefaultNodePoolVnetSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderDefaultNodePoolVnetSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate vnetSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderDefaultNodePoolVnetSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterSpecForProviderDefaultNodePoolVnetSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderDefaultNodePool
{
    /// <summary>Should the Kubernetes Auto Scaler be enabled for this Node Pool?</summary>
    [JsonPropertyName("autoScalingEnabled")]
    public bool? AutoScalingEnabled { get; set; }

    /// <summary>Specifies the ID of the Capacity Reservation Group within which this AKS Cluster should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("capacityReservationGroupId")]
    public string? CapacityReservationGroupId { get; set; }

    /// <summary>Should the nodes in this Node Pool have Federal Information Processing Standard enabled? temporary_name_for_rotation must be specified when changing this block. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("fipsEnabled")]
    public bool? FipsEnabled { get; set; }

    /// <summary>Specifies the GPU MIG instance profile for supported GPU VM SKU. The allowed values are MIG1g, MIG2g, MIG3g, MIG4g and MIG7g. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("gpuInstance")]
    public string? GpuInstance { get; set; }

    /// <summary>Should the nodes in the Default Node Pool have host encryption enabled? temporary_name_for_rotation must be specified when changing this property.</summary>
    [JsonPropertyName("hostEncryptionEnabled")]
    public bool? HostEncryptionEnabled { get; set; }

    /// <summary>Specifies the ID of the Host Group within which this AKS Cluster should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hostGroupId")]
    public string? HostGroupId { get; set; }

    /// <summary>A kubelet_config block as defined below. temporary_name_for_rotation must be specified when changing this block.</summary>
    [JsonPropertyName("kubeletConfig")]
    public IList<V1beta1KubernetesClusterSpecForProviderDefaultNodePoolKubeletConfig>? KubeletConfig { get; set; }

    /// <summary>The type of disk used by kubelet. Possible values are OS and Temporary. temporary_name_for_rotation must be specified when changing this block.</summary>
    [JsonPropertyName("kubeletDiskType")]
    public string? KubeletDiskType { get; set; }

    /// <summary>A linux_os_config block as defined below. temporary_name_for_rotation must be specified when changing this block.</summary>
    [JsonPropertyName("linuxOsConfig")]
    public IList<V1beta1KubernetesClusterSpecForProviderDefaultNodePoolLinuxOsConfig>? LinuxOsConfig { get; set; }

    /// <summary>The maximum number of nodes which should exist in this Node Pool. If specified this must be between 1 and 1000.</summary>
    [JsonPropertyName("maxCount")]
    public double? MaxCount { get; set; }

    /// <summary>The maximum number of pods that can run on each agent. temporary_name_for_rotation must be specified when changing this property.</summary>
    [JsonPropertyName("maxPods")]
    public double? MaxPods { get; set; }

    /// <summary>The minimum number of nodes which should exist in this Node Pool. If specified this must be between 1 and 1000.</summary>
    [JsonPropertyName("minCount")]
    public double? MinCount { get; set; }

    /// <summary>The name which should be used for the default Kubernetes Node Pool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The initial number of nodes which should exist in this Node Pool. If specified this must be between 1 and 1000 and between min_count and max_count.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>A map of Kubernetes labels which should be applied to nodes in the Default Node Pool.</summary>
    [JsonPropertyName("nodeLabels")]
    public IDictionary<string, string>? NodeLabels { get; set; }

    /// <summary>A node_network_profile block as documented below.</summary>
    [JsonPropertyName("nodeNetworkProfile")]
    public IList<V1beta1KubernetesClusterSpecForProviderDefaultNodePoolNodeNetworkProfile>? NodeNetworkProfile { get; set; }

    /// <summary>Should nodes in this Node Pool have a Public IP Address? temporary_name_for_rotation must be specified when changing this property.</summary>
    [JsonPropertyName("nodePublicIpEnabled")]
    public bool? NodePublicIpEnabled { get; set; }

    /// <summary>Resource ID for the Public IP Addresses Prefix for the nodes in this Node Pool. node_public_ip_enabled should be true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("nodePublicIpPrefixId")]
    public string? NodePublicIpPrefixId { get; set; }

    /// <summary>Enabling this option will taint default node pool with CriticalAddonsOnly=true:NoSchedule taint. temporary_name_for_rotation must be specified when changing this property.</summary>
    [JsonPropertyName("onlyCriticalAddonsEnabled")]
    public bool? OnlyCriticalAddonsEnabled { get; set; }

    /// <summary>Version of Kubernetes used for the Agents. If not specified, the default node pool will be created with the version specified by kubernetes_version. If both are unspecified, the latest recommended version will be used at provisioning time (but won't auto-upgrade). AKS does not require an exact patch version to be specified, minor version aliases such as 1.22 are also supported. - The minor version's latest GA patch is automatically chosen in that case. More details can be found in the documentation.</summary>
    [JsonPropertyName("orchestratorVersion")]
    public string? OrchestratorVersion { get; set; }

    /// <summary>The size of the OS Disk which should be used for each agent in the Node Pool. temporary_name_for_rotation must be specified when attempting a change.</summary>
    [JsonPropertyName("osDiskSizeGb")]
    public double? OsDiskSizeGb { get; set; }

    /// <summary>The type of disk which should be used for the Operating System. Possible values are Ephemeral and Managed. Defaults to Managed. temporary_name_for_rotation must be specified when attempting a change.</summary>
    [JsonPropertyName("osDiskType")]
    public string? OsDiskType { get; set; }

    /// <summary>Specifies the OS SKU used by the agent pool. Possible values are AzureLinux, Ubuntu, Windows2019 and Windows2022. If not specified, the default is Ubuntu if OSType=Linux or Windows2019 if OSType=Windows. And the default Windows OSSKU will be changed to Windows2022 after Windows2019 is deprecated. Changing this from AzureLinux or Ubuntu to AzureLinux or Ubuntu will not replace the resource, otherwise temporary_name_for_rotation must be specified when attempting a change.</summary>
    [JsonPropertyName("osSku")]
    public string? OsSku { get; set; }

    /// <summary>The ID of the Subnet where the pods in the default Node Pool should exist.</summary>
    [JsonPropertyName("podSubnetId")]
    public string? PodSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate podSubnetId.</summary>
    [JsonPropertyName("podSubnetIdRef")]
    public V1beta1KubernetesClusterSpecForProviderDefaultNodePoolPodSubnetIdRef? PodSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate podSubnetId.</summary>
    [JsonPropertyName("podSubnetIdSelector")]
    public V1beta1KubernetesClusterSpecForProviderDefaultNodePoolPodSubnetIdSelector? PodSubnetIdSelector { get; set; }

    /// <summary>The ID of the Proximity Placement Group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("proximityPlacementGroupId")]
    public string? ProximityPlacementGroupId { get; set; }

    /// <summary>Specifies the autoscaling behaviour of the Kubernetes Cluster. Allowed values are Delete and Deallocate. Defaults to Delete.</summary>
    [JsonPropertyName("scaleDownMode")]
    public string? ScaleDownMode { get; set; }

    /// <summary>The ID of the Snapshot which should be used to create this default Node Pool. temporary_name_for_rotation must be specified when changing this property.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>A mapping of tags to assign to the Node Pool.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the name of the temporary node pool used to cycle the default node pool for VM resizing.</summary>
    [JsonPropertyName("temporaryNameForRotation")]
    public string? TemporaryNameForRotation { get; set; }

    /// <summary>The type of Node Pool which should be created. Possible values are VirtualMachineScaleSets. Defaults to VirtualMachineScaleSets. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Used to specify whether the UltraSSD is enabled in the Default Node Pool. Defaults to false. See the documentation for more information. temporary_name_for_rotation must be specified when attempting a change.</summary>
    [JsonPropertyName("ultraSsdEnabled")]
    public bool? UltraSsdEnabled { get; set; }

    /// <summary>A upgrade_settings block as documented below.</summary>
    [JsonPropertyName("upgradeSettings")]
    public IList<V1beta1KubernetesClusterSpecForProviderDefaultNodePoolUpgradeSettings>? UpgradeSettings { get; set; }

    /// <summary>The size of the Virtual Machine, such as Standard_DS2_v2. temporary_name_for_rotation must be specified when attempting a resize.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }

    /// <summary>The ID of a Subnet where the Kubernetes Node Pool should exist.</summary>
    [JsonPropertyName("vnetSubnetId")]
    public string? VnetSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate vnetSubnetId.</summary>
    [JsonPropertyName("vnetSubnetIdRef")]
    public V1beta1KubernetesClusterSpecForProviderDefaultNodePoolVnetSubnetIdRef? VnetSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate vnetSubnetId.</summary>
    [JsonPropertyName("vnetSubnetIdSelector")]
    public V1beta1KubernetesClusterSpecForProviderDefaultNodePoolVnetSubnetIdSelector? VnetSubnetIdSelector { get; set; }

    /// <summary>Specifies the workload runtime used by the node pool. Possible value is OCIContainer.</summary>
    [JsonPropertyName("workloadRuntime")]
    public string? WorkloadRuntime { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this Kubernetes Cluster should be located. temporary_name_for_rotation must be specified when changing this property.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>The base64 encoded alternative CA certificate content in PEM format.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderHttpProxyConfigTrustedCaSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderHttpProxyConfig
{
    /// <summary>The proxy address to be used when communicating over HTTP.</summary>
    [JsonPropertyName("httpProxy")]
    public string? HttpProxy { get; set; }

    /// <summary>The proxy address to be used when communicating over HTTPS.</summary>
    [JsonPropertyName("httpsProxy")]
    public string? HttpsProxy { get; set; }

    /// <summary>The list of domains that will not use the proxy for communication.</summary>
    [JsonPropertyName("noProxy")]
    public IList<string>? NoProxy { get; set; }

    /// <summary>The base64 encoded alternative CA certificate content in PEM format.</summary>
    [JsonPropertyName("trustedCaSecretRef")]
    public V1beta1KubernetesClusterSpecForProviderHttpProxyConfigTrustedCaSecretRef? TrustedCaSecretRef { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderIdentityIdentityIdsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderIdentityIdentityIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterSpecForProviderIdentityIdentityIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderIdentityIdentityIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of UserAssignedIdentity in managedidentity to populate identityIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderIdentityIdentityIdsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterSpecForProviderIdentityIdentityIdsSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Kubernetes Cluster.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>References to UserAssignedIdentity in managedidentity to populate identityIds.</summary>
    [JsonPropertyName("identityIdsRefs")]
    public IList<V1beta1KubernetesClusterSpecForProviderIdentityIdentityIdsRefs>? IdentityIdsRefs { get; set; }

    /// <summary>Selector for a list of UserAssignedIdentity in managedidentity to populate identityIds.</summary>
    [JsonPropertyName("identityIdsSelector")]
    public V1beta1KubernetesClusterSpecForProviderIdentityIdentityIdsSelector? IdentityIdsSelector { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Kubernetes Cluster. Possible values are SystemAssigned or UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderIngressApplicationGatewaySubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderIngressApplicationGatewaySubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterSpecForProviderIngressApplicationGatewaySubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderIngressApplicationGatewaySubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderIngressApplicationGatewaySubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterSpecForProviderIngressApplicationGatewaySubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderIngressApplicationGateway
{
    /// <summary>The ID of the Application Gateway to integrate with the ingress controller of this Kubernetes Cluster. See this page for further details.</summary>
    [JsonPropertyName("gatewayId")]
    public string? GatewayId { get; set; }

    /// <summary>The name of the Application Gateway to be used or created in the Nodepool Resource Group, which in turn will be integrated with the ingress controller of this Kubernetes Cluster. See this page for further details.</summary>
    [JsonPropertyName("gatewayName")]
    public string? GatewayName { get; set; }

    /// <summary>The subnet CIDR to be used to create an Application Gateway, which in turn will be integrated with the ingress controller of this Kubernetes Cluster. See this page for further details.</summary>
    [JsonPropertyName("subnetCidr")]
    public string? SubnetCidr { get; set; }

    /// <summary>The ID of the subnet on which to create an Application Gateway, which in turn will be integrated with the ingress controller of this Kubernetes Cluster. See this page for further details.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1KubernetesClusterSpecForProviderIngressApplicationGatewaySubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1KubernetesClusterSpecForProviderIngressApplicationGatewaySubnetIdSelector? SubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderKeyManagementService
{
    /// <summary>Identifier of Azure Key Vault key. See key identifier format for more details.</summary>
    [JsonPropertyName("keyVaultKeyId")]
    public string? KeyVaultKeyId { get; set; }

    /// <summary>Network access of the key vault Network access of key vault. The possible values are Public and Private. Public means the key vault allows public access from all networks. Private means the key vault disables public access and enables private link. Defaults to Public.</summary>
    [JsonPropertyName("keyVaultNetworkAccess")]
    public string? KeyVaultNetworkAccess { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderKeyVaultSecretsProvider
{
    /// <summary>Should the secret store CSI driver on the AKS cluster be enabled?</summary>
    [JsonPropertyName("secretRotationEnabled")]
    public bool? SecretRotationEnabled { get; set; }

    /// <summary>The interval to poll for secret rotation. This attribute is only set when secret_rotation_enabled is true. Defaults to 2m.</summary>
    [JsonPropertyName("secretRotationInterval")]
    public string? SecretRotationInterval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderKubeletIdentity
{
    /// <summary>The Client ID of the user-defined Managed Identity to be assigned to the Kubelets. If not specified a Managed Identity is created automatically. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The Object ID of the user-defined Managed Identity assigned to the Kubelets.If not specified a Managed Identity is created automatically. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>The ID of the User Assigned Identity assigned to the Kubelets. If not specified a Managed Identity is created automatically. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("userAssignedIdentityId")]
    public string? UserAssignedIdentityId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderLinuxProfileSshKey
{
    /// <summary>The Public SSH Key used to access the cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("keyData")]
    public string? KeyData { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderLinuxProfile
{
    /// <summary>The Admin Username for the Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>An ssh_key block as defined below. Only one is currently allowed. Changing this will update the key on all node pools. More information can be found in the documentation.</summary>
    [JsonPropertyName("sshKey")]
    public IList<V1beta1KubernetesClusterSpecForProviderLinuxProfileSshKey>? SshKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderMaintenanceWindowAllowed
{
    /// <summary>A day in a week. Possible values are Sunday, Monday, Tuesday, Wednesday, Thursday, Friday and Saturday.</summary>
    [JsonPropertyName("day")]
    public string? Day { get; set; }

    /// <summary>An array of hour slots in a day. For example, specifying 1 will allow maintenance from 1:00am to 2:00am. Specifying 1, 2 will allow maintenance from 1:00am to 3:00m. Possible values are between 0 and 23.</summary>
    [JsonPropertyName("hours")]
    public IList<double>? Hours { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderMaintenanceWindowNotAllowed
{
    /// <summary>The end of a time span, formatted as an RFC3339 string.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>The start of a time span, formatted as an RFC3339 string.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderMaintenanceWindow
{
    /// <summary>One or more allowed blocks as defined below.</summary>
    [JsonPropertyName("allowed")]
    public IList<V1beta1KubernetesClusterSpecForProviderMaintenanceWindowAllowed>? Allowed { get; set; }

    /// <summary>One or more not_allowed block as defined below.</summary>
    [JsonPropertyName("notAllowed")]
    public IList<V1beta1KubernetesClusterSpecForProviderMaintenanceWindowNotAllowed>? NotAllowed { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderMaintenanceWindowAutoUpgradeNotAllowed
{
    /// <summary>The end of a time span, formatted as an RFC3339 string.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>The start of a time span, formatted as an RFC3339 string.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderMaintenanceWindowAutoUpgrade
{
    /// <summary>The day of the month for the maintenance run. Required in combination with AbsoluteMonthly frequency. Value between 0 and 31 (inclusive).</summary>
    [JsonPropertyName("dayOfMonth")]
    public double? DayOfMonth { get; set; }

    /// <summary>The day of the week for the maintenance run. Required in combination with weekly frequency. Possible values are Friday, Monday, Saturday, Sunday, Thursday, Tuesday and Wednesday.</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>The duration of the window for maintenance to run in hours. Possible options are between 4 to 24.</summary>
    [JsonPropertyName("duration")]
    public double? Duration { get; set; }

    /// <summary>Frequency of maintenance. Possible options are Weekly, AbsoluteMonthly and RelativeMonthly.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>The interval for maintenance runs. Depending on the frequency this interval is week or month based.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>One or more not_allowed block as defined below.</summary>
    [JsonPropertyName("notAllowed")]
    public IList<V1beta1KubernetesClusterSpecForProviderMaintenanceWindowAutoUpgradeNotAllowed>? NotAllowed { get; set; }

    /// <summary>The date on which the maintenance window begins to take effect.</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }

    /// <summary>The time for maintenance to begin, based on the timezone determined by utc_offset. Format is HH:mm.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Used to determine the timezone for cluster maintenance.</summary>
    [JsonPropertyName("utcOffset")]
    public string? UtcOffset { get; set; }

    /// <summary>Specifies on which instance of the allowed days specified in day_of_week the maintenance occurs. Options are First, Second, Third, Fourth, and Last. Required in combination with relative monthly frequency.</summary>
    [JsonPropertyName("weekIndex")]
    public string? WeekIndex { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderMaintenanceWindowNodeOsNotAllowed
{
    /// <summary>The end of a time span, formatted as an RFC3339 string.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>The start of a time span, formatted as an RFC3339 string.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderMaintenanceWindowNodeOs
{
    /// <summary>The day of the month for the maintenance run. Required in combination with AbsoluteMonthly frequency. Value between 0 and 31 (inclusive).</summary>
    [JsonPropertyName("dayOfMonth")]
    public double? DayOfMonth { get; set; }

    /// <summary>The day of the week for the maintenance run. Required in combination with weekly frequency. Possible values are Friday, Monday, Saturday, Sunday, Thursday, Tuesday and Wednesday.</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>The duration of the window for maintenance to run in hours. Possible options are between 4 to 24.</summary>
    [JsonPropertyName("duration")]
    public double? Duration { get; set; }

    /// <summary>Frequency of maintenance. Possible options are Daily, Weekly, AbsoluteMonthly and RelativeMonthly.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>The interval for maintenance runs. Depending on the frequency this interval is week or month based.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>One or more not_allowed block as defined below.</summary>
    [JsonPropertyName("notAllowed")]
    public IList<V1beta1KubernetesClusterSpecForProviderMaintenanceWindowNodeOsNotAllowed>? NotAllowed { get; set; }

    /// <summary>The date on which the maintenance window begins to take effect.</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }

    /// <summary>The time for maintenance to begin, based on the timezone determined by utc_offset. Format is HH:mm.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Used to determine the timezone for cluster maintenance.</summary>
    [JsonPropertyName("utcOffset")]
    public string? UtcOffset { get; set; }

    /// <summary>The week in the month used for the maintenance run. Options are First, Second, Third, Fourth, and Last.</summary>
    [JsonPropertyName("weekIndex")]
    public string? WeekIndex { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderMicrosoftDefender
{
    /// <summary>Specifies the ID of the Log Analytics Workspace where the audit logs collected by Microsoft Defender should be sent to.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderMonitorMetrics
{
    /// <summary>Specifies a comma-separated list of Kubernetes annotation keys that will be used in the resource's labels metric.</summary>
    [JsonPropertyName("annotationsAllowed")]
    public string? AnnotationsAllowed { get; set; }

    /// <summary>Specifies a Comma-separated list of additional Kubernetes label keys that will be used in the resource's labels metric.</summary>
    [JsonPropertyName("labelsAllowed")]
    public string? LabelsAllowed { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderNetworkProfileLoadBalancerProfile
{
    /// <summary>The type of the managed inbound Load Balancer Backend Pool. Possible values are NodeIP and NodeIPConfiguration. Defaults to NodeIPConfiguration. See the documentation for more information.</summary>
    [JsonPropertyName("backendPoolType")]
    public string? BackendPoolType { get; set; }

    /// <summary>Desired outbound flow idle timeout in minutes for the managed nat gateway. Must be between 4 and 120 inclusive. Defaults to 4.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>Count of desired managed outbound IPs for the managed nat gateway. Must be between 1 and 16 inclusive.</summary>
    [JsonPropertyName("managedOutboundIpCount")]
    public double? ManagedOutboundIpCount { get; set; }

    /// <summary>The desired number of IPv6 outbound IPs created and managed by Azure for the cluster load balancer. Must be in the range of 1 to 100 (inclusive). The default value is 0 for single-stack and 1 for dual-stack.</summary>
    [JsonPropertyName("managedOutboundIpv6Count")]
    public double? ManagedOutboundIpv6Count { get; set; }

    /// <summary>The ID of the Public IP Addresses which should be used for outbound communication for the cluster load balancer.</summary>
    [JsonPropertyName("outboundIpAddressIds")]
    public IList<string>? OutboundIpAddressIds { get; set; }

    /// <summary>The ID of the outbound Public IP Address Prefixes which should be used for the cluster load balancer.</summary>
    [JsonPropertyName("outboundIpPrefixIds")]
    public IList<string>? OutboundIpPrefixIds { get; set; }

    /// <summary>Number of desired SNAT port for each VM in the clusters load balancer. Must be between 0 and 64000 inclusive. Defaults to 0.</summary>
    [JsonPropertyName("outboundPortsAllocated")]
    public double? OutboundPortsAllocated { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderNetworkProfileNatGatewayProfile
{
    /// <summary>Desired outbound flow idle timeout in minutes for the managed nat gateway. Must be between 4 and 120 inclusive. Defaults to 4.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>Count of desired managed outbound IPs for the managed nat gateway. Must be between 1 and 16 inclusive.</summary>
    [JsonPropertyName("managedOutboundIpCount")]
    public double? ManagedOutboundIpCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderNetworkProfile
{
    /// <summary>IP address within the Kubernetes service address range that will be used by cluster service discovery (kube-dns). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dnsServiceIp")]
    public string? DnsServiceIp { get; set; }

    /// <summary>Specifies a list of IP versions the Kubernetes Cluster will use to assign IP addresses to its nodes and pods. Possible values are IPv4 and/or IPv6. IPv4 must always be specified. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ipVersions")]
    public IList<string>? IpVersions { get; set; }

    /// <summary>A load_balancer_profile block as defined below. This can only be specified when load_balancer_sku is set to standard. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("loadBalancerProfile")]
    public IList<V1beta1KubernetesClusterSpecForProviderNetworkProfileLoadBalancerProfile>? LoadBalancerProfile { get; set; }

    /// <summary>Specifies the SKU of the Load Balancer used for this Kubernetes Cluster. Possible values are basic and standard. Defaults to standard. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("loadBalancerSku")]
    public string? LoadBalancerSku { get; set; }

    /// <summary>A nat_gateway_profile block as defined below. This can only be specified when load_balancer_sku is set to standard and outbound_type is set to managedNATGateway or userAssignedNATGateway. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("natGatewayProfile")]
    public IList<V1beta1KubernetesClusterSpecForProviderNetworkProfileNatGatewayProfile>? NatGatewayProfile { get; set; }

    /// <summary>Specifies the data plane used for building the Kubernetes network. Possible values are azure and cilium. Defaults to azure. Disabling this forces a new resource to be created.</summary>
    [JsonPropertyName("networkDataPlane")]
    public string? NetworkDataPlane { get; set; }

    /// <summary>Network mode to be used with Azure CNI. Possible values are bridge and transparent. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("networkMode")]
    public string? NetworkMode { get; set; }

    /// <summary>Network plugin to use for networking. Currently supported values are azure, kubenet and none. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("networkPlugin")]
    public string? NetworkPlugin { get; set; }

    /// <summary>Specifies the network plugin mode used for building the Kubernetes network. Possible value is overlay.</summary>
    [JsonPropertyName("networkPluginMode")]
    public string? NetworkPluginMode { get; set; }

    /// <summary>Sets up network policy to be used with Azure CNI. Network policy allows us to control the traffic flow between pods. Currently supported values are calico, azure and cilium.</summary>
    [JsonPropertyName("networkPolicy")]
    public string? NetworkPolicy { get; set; }

    /// <summary>The outbound (egress) routing method which should be used for this Kubernetes Cluster. Possible values are loadBalancer, userDefinedRouting, managedNATGateway and userAssignedNATGateway. Defaults to loadBalancer. More information on supported migration paths for outbound_type can be found in this documentation.</summary>
    [JsonPropertyName("outboundType")]
    public string? OutboundType { get; set; }

    /// <summary>The CIDR to use for pod IP addresses. This field can only be set when network_plugin is set to kubenet or network_plugin_mode is set to overlay. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("podCidr")]
    public string? PodCidr { get; set; }

    /// <summary>A list of CIDRs to use for pod IP addresses. For single-stack networking a single IPv4 CIDR is expected. For dual-stack networking an IPv4 and IPv6 CIDR are expected. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("podCidrs")]
    public IList<string>? PodCidrs { get; set; }

    /// <summary>The Network Range used by the Kubernetes service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("serviceCidr")]
    public string? ServiceCidr { get; set; }

    /// <summary>A list of CIDRs to use for Kubernetes services. For single-stack networking a single IPv4 CIDR is expected. For dual-stack networking an IPv4 and IPv6 CIDR are expected. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("serviceCidrs")]
    public IList<string>? ServiceCidrs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderOmsAgent
{
    /// <summary>The ID of the Log Analytics Workspace which the OMS Agent should send data to.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>Is managed identity authentication for monitoring enabled?</summary>
    [JsonPropertyName("msiAuthForMonitoringEnabled")]
    public bool? MsiAuthForMonitoringEnabled { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderPrivateDnsZoneIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a PrivateDNSZone in network to populate privateDnsZoneId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderPrivateDnsZoneIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterSpecForProviderPrivateDnsZoneIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderPrivateDnsZoneIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a PrivateDNSZone in network to populate privateDnsZoneId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderPrivateDnsZoneIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterSpecForProviderPrivateDnsZoneIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderServiceMeshProfileCertificateAuthority
{
    /// <summary>The certificate chain object name in Azure Key Vault.</summary>
    [JsonPropertyName("certChainObjectName")]
    public string? CertChainObjectName { get; set; }

    /// <summary>The intermediate certificate object name in Azure Key Vault.</summary>
    [JsonPropertyName("certObjectName")]
    public string? CertObjectName { get; set; }

    /// <summary>The intermediate certificate private key object name in Azure Key Vault.</summary>
    [JsonPropertyName("keyObjectName")]
    public string? KeyObjectName { get; set; }

    /// <summary>The resource ID of the Key Vault.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>The root certificate object name in Azure Key Vault.</summary>
    [JsonPropertyName("rootCertObjectName")]
    public string? RootCertObjectName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderServiceMeshProfile
{
    /// <summary>A certificate_authority block as defined below. When this property is specified, key_vault_secrets_provider is also required to be set. This configuration allows you to bring your own root certificate and keys for Istio CA in the Istio-based service mesh add-on for Azure Kubernetes Service.</summary>
    [JsonPropertyName("certificateAuthority")]
    public IList<V1beta1KubernetesClusterSpecForProviderServiceMeshProfileCertificateAuthority>? CertificateAuthority { get; set; }

    /// <summary>Is Istio External Ingress Gateway enabled?</summary>
    [JsonPropertyName("externalIngressGatewayEnabled")]
    public bool? ExternalIngressGatewayEnabled { get; set; }

    /// <summary>Is Istio Internal Ingress Gateway enabled?</summary>
    [JsonPropertyName("internalIngressGatewayEnabled")]
    public bool? InternalIngressGatewayEnabled { get; set; }

    /// <summary>The mode of the service mesh. Possible value is Istio.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Specify 1 or 2 Istio control plane revisions for managing minor upgrades using the canary upgrade process. For example, create the resource with revisions set to ["asm-1-20"], or leave it empty (the revisions will only be known after apply). To start the canary upgrade, change revisions to ["asm-1-20", "asm-1-21"]. To roll back the canary upgrade, revert to ["asm-1-20"]. To confirm the upgrade, change to ["asm-1-21"].</summary>
    [JsonPropertyName("revisions")]
    public IList<string>? Revisions { get; set; }
}

/// <summary>The Client Secret for the Service Principal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderServicePrincipalClientSecretSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderServicePrincipal
{
    /// <summary>The Client ID for the Service Principal.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The Client Secret for the Service Principal.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1KubernetesClusterSpecForProviderServicePrincipalClientSecretSecretRef? ClientSecretSecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderStorageProfile
{
    /// <summary>Is the Blob CSI driver enabled? Defaults to false.</summary>
    [JsonPropertyName("blobDriverEnabled")]
    public bool? BlobDriverEnabled { get; set; }

    /// <summary>Is the Disk CSI driver enabled? Defaults to true.</summary>
    [JsonPropertyName("diskDriverEnabled")]
    public bool? DiskDriverEnabled { get; set; }

    /// <summary>Is the File CSI driver enabled? Defaults to true.</summary>
    [JsonPropertyName("fileDriverEnabled")]
    public bool? FileDriverEnabled { get; set; }

    /// <summary>Is the Snapshot Controller enabled? Defaults to true.</summary>
    [JsonPropertyName("snapshotControllerEnabled")]
    public bool? SnapshotControllerEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderUpgradeOverride
{
    /// <summary>Specifies the duration, in RFC 3339 format (e.g., 2025-10-01T13:00:00Z), the upgrade_override values are effective. This field must be set for the upgrade_override values to take effect. The date-time must be within the next 30 days.</summary>
    [JsonPropertyName("effectiveUntil")]
    public string? EffectiveUntil { get; set; }

    /// <summary>Whether to force upgrade the cluster. Possible values are true or false.</summary>
    [JsonPropertyName("forceUpgradeEnabled")]
    public bool? ForceUpgradeEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderWebAppRouting
{
    /// <summary>Specifies the list of the DNS Zone IDs in which DNS entries are created for applications deployed to the cluster when Web App Routing is enabled. If not using Bring-Your-Own DNS zones this property should be set to an empty list.</summary>
    [JsonPropertyName("dnsZoneIds")]
    public IList<string>? DnsZoneIds { get; set; }
}

/// <summary>The Admin Password for Windows VMs. Length must be between 14 and 123 characters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderWindowsProfileAdminPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderWindowsProfileGmsa
{
    /// <summary>Specifies the DNS server for Windows gMSA. Set this to an empty string if you have configured the DNS server in the VNet which was used to create the managed cluster.</summary>
    [JsonPropertyName("dnsServer")]
    public string? DnsServer { get; set; }

    /// <summary>Specifies the root domain name for Windows gMSA. Set this to an empty string if you have configured the DNS server in the VNet which was used to create the managed cluster.</summary>
    [JsonPropertyName("rootDomain")]
    public string? RootDomain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderWindowsProfile
{
    /// <summary>The Admin Password for Windows VMs. Length must be between 14 and 123 characters.</summary>
    [JsonPropertyName("adminPasswordSecretRef")]
    public V1beta1KubernetesClusterSpecForProviderWindowsProfileAdminPasswordSecretRef? AdminPasswordSecretRef { get; set; }

    /// <summary>The Admin Username for Windows VMs. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>A gmsa block as defined below.</summary>
    [JsonPropertyName("gmsa")]
    public IList<V1beta1KubernetesClusterSpecForProviderWindowsProfileGmsa>? Gmsa { get; set; }

    /// <summary>Specifies the type of on-premise license which should be used for Node Pool Windows Virtual Machine. At this time the only possible value is Windows_Server.</summary>
    [JsonPropertyName("license")]
    public string? License { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProviderWorkloadAutoscalerProfile
{
    /// <summary>Specifies whether KEDA Autoscaler can be used for workloads.</summary>
    [JsonPropertyName("kedaEnabled")]
    public bool? KedaEnabled { get; set; }

    /// <summary>Specifies whether Vertical Pod Autoscaler should be enabled.</summary>
    [JsonPropertyName("verticalPodAutoscalerEnabled")]
    public bool? VerticalPodAutoscalerEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecForProvider
{
    /// <summary>A aci_connector_linux block as defined below. For more details, please visit Create and configure an AKS cluster to use virtual nodes.</summary>
    [JsonPropertyName("aciConnectorLinux")]
    public IList<V1beta1KubernetesClusterSpecForProviderAciConnectorLinux>? AciConnectorLinux { get; set; }

    /// <summary>An api_server_access_profile block as defined below.</summary>
    [JsonPropertyName("apiServerAccessProfile")]
    public IList<V1beta1KubernetesClusterSpecForProviderApiServerAccessProfile>? ApiServerAccessProfile { get; set; }

    /// <summary>A auto_scaler_profile block as defined below.</summary>
    [JsonPropertyName("autoScalerProfile")]
    public IList<V1beta1KubernetesClusterSpecForProviderAutoScalerProfile>? AutoScalerProfile { get; set; }

    /// <summary>The upgrade channel for this Kubernetes Cluster. Possible values are patch, rapid, node-image and stable. Omitting this field sets this value to none.</summary>
    [JsonPropertyName("automaticUpgradeChannel")]
    public string? AutomaticUpgradeChannel { get; set; }

    /// <summary>A azure_active_directory_role_based_access_control block as defined below.</summary>
    [JsonPropertyName("azureActiveDirectoryRoleBasedAccessControl")]
    public IList<V1beta1KubernetesClusterSpecForProviderAzureActiveDirectoryRoleBasedAccessControl>? AzureActiveDirectoryRoleBasedAccessControl { get; set; }

    /// <summary>Should the Azure Policy Add-On be enabled? For more details please visit Understand Azure Policy for Azure Kubernetes Service</summary>
    [JsonPropertyName("azurePolicyEnabled")]
    public bool? AzurePolicyEnabled { get; set; }

    /// <summary>A confidential_computing block as defined below. For more details please the documentation</summary>
    [JsonPropertyName("confidentialComputing")]
    public IList<V1beta1KubernetesClusterSpecForProviderConfidentialComputing>? ConfidentialComputing { get; set; }

    /// <summary>Should cost analysis be enabled for this Kubernetes Cluster? Defaults to false. The sku_tier must be set to Standard or Premium to enable this feature. Enabling this will add Kubernetes Namespace and Deployment details to the Cost Analysis views in the Azure portal.</summary>
    [JsonPropertyName("costAnalysisEnabled")]
    public bool? CostAnalysisEnabled { get; set; }

    /// <summary>Specifies configuration for "System" mode node pool. A default_node_pool block as defined below.</summary>
    [JsonPropertyName("defaultNodePool")]
    public IList<V1beta1KubernetesClusterSpecForProviderDefaultNodePool>? DefaultNodePool { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used for the Nodes and Volumes. More information can be found in the documentation. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>DNS prefix specified when creating the managed cluster. Possible values must begin and end with a letter or number, contain only letters, numbers, and hyphens and be between 1 and 54 characters in length. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dnsPrefix")]
    public string? DnsPrefix { get; set; }

    /// <summary>Specifies the DNS prefix to use with private clusters. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dnsPrefixPrivateCluster")]
    public string? DnsPrefixPrivateCluster { get; set; }

    /// <summary>Specifies the Extended Zone (formerly called Edge Zone) within the Azure Region where this Managed Kubernetes Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("edgeZone")]
    public string? EdgeZone { get; set; }

    /// <summary>Should HTTP Application Routing be enabled?</summary>
    [JsonPropertyName("httpApplicationRoutingEnabled")]
    public bool? HttpApplicationRoutingEnabled { get; set; }

    /// <summary>A http_proxy_config block as defined below.</summary>
    [JsonPropertyName("httpProxyConfig")]
    public IList<V1beta1KubernetesClusterSpecForProviderHttpProxyConfig>? HttpProxyConfig { get; set; }

    /// <summary>An identity block as defined below. One of either identity or service_principal must be specified.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1KubernetesClusterSpecForProviderIdentity>? Identity { get; set; }

    /// <summary>Specifies whether Image Cleaner is enabled.</summary>
    [JsonPropertyName("imageCleanerEnabled")]
    public bool? ImageCleanerEnabled { get; set; }

    /// <summary>Specifies the interval in hours when images should be cleaned up. Defaults to 0.</summary>
    [JsonPropertyName("imageCleanerIntervalHours")]
    public double? ImageCleanerIntervalHours { get; set; }

    /// <summary>An ingress_application_gateway block as defined below.</summary>
    [JsonPropertyName("ingressApplicationGateway")]
    public IList<V1beta1KubernetesClusterSpecForProviderIngressApplicationGateway>? IngressApplicationGateway { get; set; }

    /// <summary>A key_management_service block as defined below. For more details, please visit Key Management Service (KMS) etcd encryption to an AKS cluster.</summary>
    [JsonPropertyName("keyManagementService")]
    public IList<V1beta1KubernetesClusterSpecForProviderKeyManagementService>? KeyManagementService { get; set; }

    /// <summary>A key_vault_secrets_provider block as defined below.</summary>
    [JsonPropertyName("keyVaultSecretsProvider")]
    public IList<V1beta1KubernetesClusterSpecForProviderKeyVaultSecretsProvider>? KeyVaultSecretsProvider { get; set; }

    /// <summary>A kubelet_identity block as defined below.</summary>
    [JsonPropertyName("kubeletIdentity")]
    public IList<V1beta1KubernetesClusterSpecForProviderKubeletIdentity>? KubeletIdentity { get; set; }

    /// <summary>Version of Kubernetes specified when creating the AKS managed cluster. If not specified, the latest recommended version will be used at provisioning time (but won't auto-upgrade). AKS does not require an exact patch version to be specified, minor version aliases such as 1.22 are also supported. - The minor version's latest GA patch is automatically chosen in that case. More details can be found in the documentation.</summary>
    [JsonPropertyName("kubernetesVersion")]
    public string? KubernetesVersion { get; set; }

    /// <summary>A linux_profile block as defined below.</summary>
    [JsonPropertyName("linuxProfile")]
    public IList<V1beta1KubernetesClusterSpecForProviderLinuxProfile>? LinuxProfile { get; set; }

    /// <summary>If true local accounts will be disabled. See the documentation for more information.</summary>
    [JsonPropertyName("localAccountDisabled")]
    public bool? LocalAccountDisabled { get; set; }

    /// <summary>The location where the Managed Kubernetes Cluster should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A maintenance_window block as defined below.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public IList<V1beta1KubernetesClusterSpecForProviderMaintenanceWindow>? MaintenanceWindow { get; set; }

    /// <summary>A maintenance_window_auto_upgrade block as defined below.</summary>
    [JsonPropertyName("maintenanceWindowAutoUpgrade")]
    public IList<V1beta1KubernetesClusterSpecForProviderMaintenanceWindowAutoUpgrade>? MaintenanceWindowAutoUpgrade { get; set; }

    /// <summary>A maintenance_window_node_os block as defined below.</summary>
    [JsonPropertyName("maintenanceWindowNodeOs")]
    public IList<V1beta1KubernetesClusterSpecForProviderMaintenanceWindowNodeOs>? MaintenanceWindowNodeOs { get; set; }

    /// <summary>A microsoft_defender block as defined below.</summary>
    [JsonPropertyName("microsoftDefender")]
    public IList<V1beta1KubernetesClusterSpecForProviderMicrosoftDefender>? MicrosoftDefender { get; set; }

    /// <summary>Specifies a Prometheus add-on profile for the Kubernetes Cluster. A monitor_metrics block as defined below.</summary>
    [JsonPropertyName("monitorMetrics")]
    public IList<V1beta1KubernetesClusterSpecForProviderMonitorMetrics>? MonitorMetrics { get; set; }

    /// <summary>A network_profile block as defined below.</summary>
    [JsonPropertyName("networkProfile")]
    public IList<V1beta1KubernetesClusterSpecForProviderNetworkProfile>? NetworkProfile { get; set; }

    /// <summary>The upgrade channel for this Kubernetes Cluster Nodes' OS Image. Possible values are Unmanaged, SecurityPatch, NodeImage and None. Defaults to NodeImage.</summary>
    [JsonPropertyName("nodeOsUpgradeChannel")]
    public string? NodeOsUpgradeChannel { get; set; }

    /// <summary>The auto-generated Resource Group which contains the resources for this Managed Kubernetes Cluster.</summary>
    [JsonPropertyName("nodeResourceGroup")]
    public string? NodeResourceGroup { get; set; }

    /// <summary>Enable or Disable the OIDC issuer URL</summary>
    [JsonPropertyName("oidcIssuerEnabled")]
    public bool? OidcIssuerEnabled { get; set; }

    /// <summary>An oms_agent block as defined below.</summary>
    [JsonPropertyName("omsAgent")]
    public IList<V1beta1KubernetesClusterSpecForProviderOmsAgent>? OmsAgent { get; set; }

    /// <summary>Is Open Service Mesh enabled? For more details, please visit Open Service Mesh for AKS.</summary>
    [JsonPropertyName("openServiceMeshEnabled")]
    public bool? OpenServiceMeshEnabled { get; set; }

    /// <summary>Should this Kubernetes Cluster have its API server only exposed on internal IP addresses? This provides a Private IP Address for the Kubernetes API on the Virtual Network where the Kubernetes Cluster is located. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateClusterEnabled")]
    public bool? PrivateClusterEnabled { get; set; }

    /// <summary>Specifies whether a Public FQDN for this Private Cluster should be added. Defaults to false.</summary>
    [JsonPropertyName("privateClusterPublicFqdnEnabled")]
    public bool? PrivateClusterPublicFqdnEnabled { get; set; }

    /// <summary>Either the ID of Private DNS Zone which should be delegated to this Cluster, System to have AKS manage this or None. In case of None you will need to bring your own DNS server and set up resolving, otherwise, the cluster will have issues after provisioning. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateDnsZoneId")]
    public string? PrivateDnsZoneId { get; set; }

    /// <summary>Reference to a PrivateDNSZone in network to populate privateDnsZoneId.</summary>
    [JsonPropertyName("privateDnsZoneIdRef")]
    public V1beta1KubernetesClusterSpecForProviderPrivateDnsZoneIdRef? PrivateDnsZoneIdRef { get; set; }

    /// <summary>Selector for a PrivateDNSZone in network to populate privateDnsZoneId.</summary>
    [JsonPropertyName("privateDnsZoneIdSelector")]
    public V1beta1KubernetesClusterSpecForProviderPrivateDnsZoneIdSelector? PrivateDnsZoneIdSelector { get; set; }

    /// <summary>Specifies the Resource Group where the Managed Kubernetes Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1KubernetesClusterSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1KubernetesClusterSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Whether Role Based Access Control for the Kubernetes Cluster should be enabled. Defaults to true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("roleBasedAccessControlEnabled")]
    public bool? RoleBasedAccessControlEnabled { get; set; }

    /// <summary>Whether to enable run command for the cluster or not. Defaults to true.</summary>
    [JsonPropertyName("runCommandEnabled")]
    public bool? RunCommandEnabled { get; set; }

    /// <summary>A service_mesh_profile block as defined below.</summary>
    [JsonPropertyName("serviceMeshProfile")]
    public IList<V1beta1KubernetesClusterSpecForProviderServiceMeshProfile>? ServiceMeshProfile { get; set; }

    /// <summary>A service_principal block as documented below. One of either identity or service_principal must be specified.</summary>
    [JsonPropertyName("servicePrincipal")]
    public IList<V1beta1KubernetesClusterSpecForProviderServicePrincipal>? ServicePrincipal { get; set; }

    /// <summary>The SKU Tier that should be used for this Kubernetes Cluster. Possible values are Free, Standard (which includes the Uptime SLA) and Premium. Defaults to Free.</summary>
    [JsonPropertyName("skuTier")]
    public string? SkuTier { get; set; }

    /// <summary>A storage_profile block as defined below.</summary>
    [JsonPropertyName("storageProfile")]
    public IList<V1beta1KubernetesClusterSpecForProviderStorageProfile>? StorageProfile { get; set; }

    /// <summary>Specifies the support plan which should be used for this Kubernetes Cluster. Possible values are KubernetesOfficial and AKSLongTermSupport. Defaults to KubernetesOfficial.</summary>
    [JsonPropertyName("supportPlan")]
    public string? SupportPlan { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A upgrade_override block as defined below.</summary>
    [JsonPropertyName("upgradeOverride")]
    public IList<V1beta1KubernetesClusterSpecForProviderUpgradeOverride>? UpgradeOverride { get; set; }

    /// <summary>A web_app_routing block as defined below.</summary>
    [JsonPropertyName("webAppRouting")]
    public IList<V1beta1KubernetesClusterSpecForProviderWebAppRouting>? WebAppRouting { get; set; }

    /// <summary>A windows_profile block as defined below.</summary>
    [JsonPropertyName("windowsProfile")]
    public IList<V1beta1KubernetesClusterSpecForProviderWindowsProfile>? WindowsProfile { get; set; }

    /// <summary>A workload_autoscaler_profile block defined below.</summary>
    [JsonPropertyName("workloadAutoscalerProfile")]
    public IList<V1beta1KubernetesClusterSpecForProviderWorkloadAutoscalerProfile>? WorkloadAutoscalerProfile { get; set; }

    /// <summary>Specifies whether Azure AD Workload Identity should be enabled for the Cluster. Defaults to false.</summary>
    [JsonPropertyName("workloadIdentityEnabled")]
    public bool? WorkloadIdentityEnabled { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderAciConnectorLinuxSubnetNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderAciConnectorLinuxSubnetNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterSpecInitProviderAciConnectorLinuxSubnetNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderAciConnectorLinuxSubnetNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderAciConnectorLinuxSubnetNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterSpecInitProviderAciConnectorLinuxSubnetNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderAciConnectorLinux
{
    /// <summary>The subnet name for the virtual nodes to run.</summary>
    [JsonPropertyName("subnetName")]
    public string? SubnetName { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetName.</summary>
    [JsonPropertyName("subnetNameRef")]
    public V1beta1KubernetesClusterSpecInitProviderAciConnectorLinuxSubnetNameRef? SubnetNameRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetName.</summary>
    [JsonPropertyName("subnetNameSelector")]
    public V1beta1KubernetesClusterSpecInitProviderAciConnectorLinuxSubnetNameSelector? SubnetNameSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderApiServerAccessProfile
{
    /// <summary>Set of authorized IP ranges to allow access to API server, e.g. ["198.51.100.0/24"].</summary>
    [JsonPropertyName("authorizedIpRanges")]
    public IList<string>? AuthorizedIpRanges { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderAutoScalerProfile
{
    /// <summary>Detect similar node groups and balance the number of nodes between them. Defaults to false.</summary>
    [JsonPropertyName("balanceSimilarNodeGroups")]
    public bool? BalanceSimilarNodeGroups { get; set; }

    /// <summary>Whether DaemonSet pods will be gracefully terminated from empty nodes. Defaults to false.</summary>
    [JsonPropertyName("daemonsetEvictionForEmptyNodesEnabled")]
    public bool? DaemonsetEvictionForEmptyNodesEnabled { get; set; }

    /// <summary>Whether DaemonSet pods will be gracefully terminated from non-empty nodes. Defaults to true.</summary>
    [JsonPropertyName("daemonsetEvictionForOccupiedNodesEnabled")]
    public bool? DaemonsetEvictionForOccupiedNodesEnabled { get; set; }

    /// <summary>Maximum number of empty nodes that can be deleted at the same time. Defaults to 10.</summary>
    [JsonPropertyName("emptyBulkDeleteMax")]
    public string? EmptyBulkDeleteMax { get; set; }

    /// <summary>Expander to use. Possible values are least-waste, priority, most-pods and random. Defaults to random.</summary>
    [JsonPropertyName("expander")]
    public string? Expander { get; set; }

    /// <summary>Whether DaemonSet pods will be ignored when calculating resource utilization for scale down. Defaults to false.</summary>
    [JsonPropertyName("ignoreDaemonsetsUtilizationEnabled")]
    public bool? IgnoreDaemonsetsUtilizationEnabled { get; set; }

    /// <summary>Maximum number of seconds the cluster autoscaler waits for pod termination when trying to scale down a node. Defaults to 600.</summary>
    [JsonPropertyName("maxGracefulTerminationSec")]
    public string? MaxGracefulTerminationSec { get; set; }

    /// <summary>Maximum time the autoscaler waits for a node to be provisioned. Defaults to 15m.</summary>
    [JsonPropertyName("maxNodeProvisioningTime")]
    public string? MaxNodeProvisioningTime { get; set; }

    /// <summary>Maximum Number of allowed unready nodes. Defaults to 3.</summary>
    [JsonPropertyName("maxUnreadyNodes")]
    public double? MaxUnreadyNodes { get; set; }

    /// <summary>Maximum percentage of unready nodes the cluster autoscaler will stop if the percentage is exceeded. Defaults to 45.</summary>
    [JsonPropertyName("maxUnreadyPercentage")]
    public double? MaxUnreadyPercentage { get; set; }

    /// <summary>For scenarios like burst/batch scale where you don't want CA to act before the kubernetes scheduler could schedule all the pods, you can tell CA to ignore unscheduled pods before they're a certain age. Defaults to 10s.</summary>
    [JsonPropertyName("newPodScaleUpDelay")]
    public string? NewPodScaleUpDelay { get; set; }

    /// <summary>How long after the scale up of AKS nodes the scale down evaluation resumes. Defaults to 10m.</summary>
    [JsonPropertyName("scaleDownDelayAfterAdd")]
    public string? ScaleDownDelayAfterAdd { get; set; }

    /// <summary>How long after node deletion that scale down evaluation resumes. Defaults to the value used for scan_interval.</summary>
    [JsonPropertyName("scaleDownDelayAfterDelete")]
    public string? ScaleDownDelayAfterDelete { get; set; }

    /// <summary>How long after scale down failure that scale down evaluation resumes. Defaults to 3m.</summary>
    [JsonPropertyName("scaleDownDelayAfterFailure")]
    public string? ScaleDownDelayAfterFailure { get; set; }

    /// <summary>How long a node should be unneeded before it is eligible for scale down. Defaults to 10m.</summary>
    [JsonPropertyName("scaleDownUnneeded")]
    public string? ScaleDownUnneeded { get; set; }

    /// <summary>How long an unready node should be unneeded before it is eligible for scale down. Defaults to 20m.</summary>
    [JsonPropertyName("scaleDownUnready")]
    public string? ScaleDownUnready { get; set; }

    /// <summary>Node utilization level, defined as sum of requested resources divided by capacity, below which a node can be considered for scale down. Defaults to 0.5.</summary>
    [JsonPropertyName("scaleDownUtilizationThreshold")]
    public string? ScaleDownUtilizationThreshold { get; set; }

    /// <summary>How often the AKS Cluster should be re-evaluated for scale up/down. Defaults to 10s.</summary>
    [JsonPropertyName("scanInterval")]
    public string? ScanInterval { get; set; }

    /// <summary>If true cluster autoscaler will never delete nodes with pods with local storage, for example, EmptyDir or HostPath. Defaults to true.</summary>
    [JsonPropertyName("skipNodesWithLocalStorage")]
    public bool? SkipNodesWithLocalStorage { get; set; }

    /// <summary>If true cluster autoscaler will never delete nodes with pods from kube-system (except for DaemonSet or mirror pods). Defaults to true.</summary>
    [JsonPropertyName("skipNodesWithSystemPods")]
    public bool? SkipNodesWithSystemPods { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderAzureActiveDirectoryRoleBasedAccessControl
{
    /// <summary>A list of Object IDs of Azure Active Directory Groups which should have Admin Role on the Cluster.</summary>
    [JsonPropertyName("adminGroupObjectIds")]
    public IList<string>? AdminGroupObjectIds { get; set; }

    /// <summary>Is Role Based Access Control based on Azure AD enabled?</summary>
    [JsonPropertyName("azureRbacEnabled")]
    public bool? AzureRbacEnabled { get; set; }

    /// <summary>The Tenant ID used for Azure Active Directory Application. If this isn't specified the Tenant ID of the current Subscription is used.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderConfidentialComputing
{
    /// <summary>Should the SGX quote helper be enabled?</summary>
    [JsonPropertyName("sgxQuoteHelperEnabled")]
    public bool? SgxQuoteHelperEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderDefaultNodePoolKubeletConfig
{
    /// <summary>Specifies the allow list of unsafe sysctls command or patterns (ending in *).</summary>
    [JsonPropertyName("allowedUnsafeSysctls")]
    public IList<string>? AllowedUnsafeSysctls { get; set; }

    /// <summary>Specifies the maximum number of container log files that can be present for a container. must be at least 2.</summary>
    [JsonPropertyName("containerLogMaxLine")]
    public double? ContainerLogMaxLine { get; set; }

    /// <summary>Specifies the maximum size (e.g. 10MB) of container log file before it is rotated.</summary>
    [JsonPropertyName("containerLogMaxSizeMb")]
    public double? ContainerLogMaxSizeMb { get; set; }

    /// <summary>Is CPU CFS quota enforcement for containers enabled? Defaults to true.</summary>
    [JsonPropertyName("cpuCfsQuotaEnabled")]
    public bool? CpuCfsQuotaEnabled { get; set; }

    /// <summary>Specifies the CPU CFS quota period value.</summary>
    [JsonPropertyName("cpuCfsQuotaPeriod")]
    public string? CpuCfsQuotaPeriod { get; set; }

    /// <summary>Specifies the CPU Manager policy to use. Possible values are none and static,.</summary>
    [JsonPropertyName("cpuManagerPolicy")]
    public string? CpuManagerPolicy { get; set; }

    /// <summary>Specifies the percent of disk usage above which image garbage collection is always run. Must be between 0 and 100.</summary>
    [JsonPropertyName("imageGcHighThreshold")]
    public double? ImageGcHighThreshold { get; set; }

    /// <summary>Specifies the percent of disk usage lower than which image garbage collection is never run. Must be between 0 and 100.</summary>
    [JsonPropertyName("imageGcLowThreshold")]
    public double? ImageGcLowThreshold { get; set; }

    /// <summary>Specifies the maximum number of processes per pod.</summary>
    [JsonPropertyName("podMaxPid")]
    public double? PodMaxPid { get; set; }

    /// <summary>Specifies the Topology Manager policy to use. Possible values are none, best-effort, restricted or single-numa-node.</summary>
    [JsonPropertyName("topologyManagerPolicy")]
    public string? TopologyManagerPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderDefaultNodePoolLinuxOsConfigSysctlConfig
{
    /// <summary>The sysctl setting fs.aio-max-nr. Must be between 65536 and 6553500.</summary>
    [JsonPropertyName("fsAioMaxNr")]
    public double? FsAioMaxNr { get; set; }

    /// <summary>The sysctl setting fs.file-max. Must be between 8192 and 12000500.</summary>
    [JsonPropertyName("fsFileMax")]
    public double? FsFileMax { get; set; }

    /// <summary>The sysctl setting fs.inotify.max_user_watches. Must be between 781250 and 2097152.</summary>
    [JsonPropertyName("fsInotifyMaxUserWatches")]
    public double? FsInotifyMaxUserWatches { get; set; }

    /// <summary>The sysctl setting fs.nr_open. Must be between 8192 and 20000500.</summary>
    [JsonPropertyName("fsNrOpen")]
    public double? FsNrOpen { get; set; }

    /// <summary>The sysctl setting kernel.threads-max. Must be between 20 and 513785.</summary>
    [JsonPropertyName("kernelThreadsMax")]
    public double? KernelThreadsMax { get; set; }

    /// <summary>The sysctl setting net.core.netdev_max_backlog. Must be between 1000 and 3240000.</summary>
    [JsonPropertyName("netCoreNetdevMaxBacklog")]
    public double? NetCoreNetdevMaxBacklog { get; set; }

    /// <summary>The sysctl setting net.core.optmem_max. Must be between 20480 and 4194304.</summary>
    [JsonPropertyName("netCoreOptmemMax")]
    public double? NetCoreOptmemMax { get; set; }

    /// <summary>The sysctl setting net.core.rmem_default. Must be between 212992 and 134217728.</summary>
    [JsonPropertyName("netCoreRmemDefault")]
    public double? NetCoreRmemDefault { get; set; }

    /// <summary>The sysctl setting net.core.rmem_max. Must be between 212992 and 134217728.</summary>
    [JsonPropertyName("netCoreRmemMax")]
    public double? NetCoreRmemMax { get; set; }

    /// <summary>The sysctl setting net.core.somaxconn. Must be between 4096 and 3240000.</summary>
    [JsonPropertyName("netCoreSomaxconn")]
    public double? NetCoreSomaxconn { get; set; }

    /// <summary>The sysctl setting net.core.wmem_default. Must be between 212992 and 134217728.</summary>
    [JsonPropertyName("netCoreWmemDefault")]
    public double? NetCoreWmemDefault { get; set; }

    /// <summary>The sysctl setting net.core.wmem_max. Must be between 212992 and 134217728.</summary>
    [JsonPropertyName("netCoreWmemMax")]
    public double? NetCoreWmemMax { get; set; }

    /// <summary>The sysctl setting net.ipv4.ip_local_port_range max value. Must be between 32768 and 65535.</summary>
    [JsonPropertyName("netIpv4IpLocalPortRangeMax")]
    public double? NetIpv4IpLocalPortRangeMax { get; set; }

    /// <summary>The sysctl setting net.ipv4.ip_local_port_range min value. Must be between 1024 and 60999.</summary>
    [JsonPropertyName("netIpv4IpLocalPortRangeMin")]
    public double? NetIpv4IpLocalPortRangeMin { get; set; }

    /// <summary>The sysctl setting net.ipv4.neigh.default.gc_thresh1. Must be between 128 and 80000.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh1")]
    public double? NetIpv4NeighDefaultGcThresh1 { get; set; }

    /// <summary>The sysctl setting net.ipv4.neigh.default.gc_thresh2. Must be between 512 and 90000.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh2")]
    public double? NetIpv4NeighDefaultGcThresh2 { get; set; }

    /// <summary>The sysctl setting net.ipv4.neigh.default.gc_thresh3. Must be between 1024 and 100000.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh3")]
    public double? NetIpv4NeighDefaultGcThresh3 { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_fin_timeout. Must be between 5 and 120.</summary>
    [JsonPropertyName("netIpv4TcpFinTimeout")]
    public double? NetIpv4TcpFinTimeout { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_keepalive_intvl. Must be between 10 and 90.</summary>
    [JsonPropertyName("netIpv4TcpKeepaliveIntvl")]
    public double? NetIpv4TcpKeepaliveIntvl { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_keepalive_probes. Must be between 1 and 15.</summary>
    [JsonPropertyName("netIpv4TcpKeepaliveProbes")]
    public double? NetIpv4TcpKeepaliveProbes { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_keepalive_time. Must be between 30 and 432000.</summary>
    [JsonPropertyName("netIpv4TcpKeepaliveTime")]
    public double? NetIpv4TcpKeepaliveTime { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_max_syn_backlog. Must be between 128 and 3240000.</summary>
    [JsonPropertyName("netIpv4TcpMaxSynBacklog")]
    public double? NetIpv4TcpMaxSynBacklog { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_max_tw_buckets. Must be between 8000 and 1440000.</summary>
    [JsonPropertyName("netIpv4TcpMaxTwBuckets")]
    public double? NetIpv4TcpMaxTwBuckets { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_tw_reuse.</summary>
    [JsonPropertyName("netIpv4TcpTwReuse")]
    public bool? NetIpv4TcpTwReuse { get; set; }

    /// <summary>The sysctl setting net.netfilter.nf_conntrack_buckets. Must be between 65536 and 524288.</summary>
    [JsonPropertyName("netNetfilterNfConntrackBuckets")]
    public double? NetNetfilterNfConntrackBuckets { get; set; }

    /// <summary>The sysctl setting net.netfilter.nf_conntrack_max. Must be between 131072 and 2097152.</summary>
    [JsonPropertyName("netNetfilterNfConntrackMax")]
    public double? NetNetfilterNfConntrackMax { get; set; }

    /// <summary>The sysctl setting vm.max_map_count. Must be between 65530 and 262144.</summary>
    [JsonPropertyName("vmMaxMapCount")]
    public double? VmMaxMapCount { get; set; }

    /// <summary>The sysctl setting vm.swappiness. Must be between 0 and 100.</summary>
    [JsonPropertyName("vmSwappiness")]
    public double? VmSwappiness { get; set; }

    /// <summary>The sysctl setting vm.vfs_cache_pressure. Must be between 0 and 100.</summary>
    [JsonPropertyName("vmVfsCachePressure")]
    public double? VmVfsCachePressure { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderDefaultNodePoolLinuxOsConfig
{
    /// <summary>Specifies the size of the swap file on each node in MB.</summary>
    [JsonPropertyName("swapFileSizeMb")]
    public double? SwapFileSizeMb { get; set; }

    /// <summary>A sysctl_config block as defined below.</summary>
    [JsonPropertyName("sysctlConfig")]
    public IList<V1beta1KubernetesClusterSpecInitProviderDefaultNodePoolLinuxOsConfigSysctlConfig>? SysctlConfig { get; set; }

    /// <summary>specifies the defrag configuration for Transparent Huge Page. Possible values are always, defer, defer+madvise, madvise and never.</summary>
    [JsonPropertyName("transparentHugePageDefrag")]
    public string? TransparentHugePageDefrag { get; set; }

    /// <summary>Specifies the Transparent Huge Page enabled configuration. Possible values are always, madvise and never.</summary>
    [JsonPropertyName("transparentHugePageEnabled")]
    public string? TransparentHugePageEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderDefaultNodePoolNodeNetworkProfileAllowedHostPorts
{
    /// <summary>Specifies the end of the port range.</summary>
    [JsonPropertyName("portEnd")]
    public double? PortEnd { get; set; }

    /// <summary>Specifies the start of the port range.</summary>
    [JsonPropertyName("portStart")]
    public double? PortStart { get; set; }

    /// <summary>Specifies the protocol of the port range. Possible values are TCP and UDP.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderDefaultNodePoolNodeNetworkProfile
{
    /// <summary>One or more allowed_host_ports blocks as defined below.</summary>
    [JsonPropertyName("allowedHostPorts")]
    public IList<V1beta1KubernetesClusterSpecInitProviderDefaultNodePoolNodeNetworkProfileAllowedHostPorts>? AllowedHostPorts { get; set; }

    /// <summary>A list of Application Security Group IDs which should be associated with this Node Pool.</summary>
    [JsonPropertyName("applicationSecurityGroupIds")]
    public IList<string>? ApplicationSecurityGroupIds { get; set; }

    /// <summary>Specifies a mapping of tags to the instance-level public IPs. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("nodePublicIpTags")]
    public IDictionary<string, string>? NodePublicIpTags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderDefaultNodePoolPodSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate podSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderDefaultNodePoolPodSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterSpecInitProviderDefaultNodePoolPodSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderDefaultNodePoolPodSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate podSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderDefaultNodePoolPodSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterSpecInitProviderDefaultNodePoolPodSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderDefaultNodePoolUpgradeSettings
{
    /// <summary>The amount of time in minutes to wait on eviction of pods and graceful termination per node. This eviction wait time honors pod disruption budgets for upgrades. If this time is exceeded, the upgrade fails. Unsetting this after configuring it will force a new resource to be created.</summary>
    [JsonPropertyName("drainTimeoutInMinutes")]
    public double? DrainTimeoutInMinutes { get; set; }

    /// <summary>The maximum number or percentage of nodes which will be added to the Node Pool size during an upgrade.</summary>
    [JsonPropertyName("maxSurge")]
    public string? MaxSurge { get; set; }

    /// <summary>The amount of time in minutes to wait after draining a node and before reimaging and moving on to next node. Defaults to 0.</summary>
    [JsonPropertyName("nodeSoakDurationInMinutes")]
    public double? NodeSoakDurationInMinutes { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderDefaultNodePoolVnetSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate vnetSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderDefaultNodePoolVnetSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterSpecInitProviderDefaultNodePoolVnetSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderDefaultNodePoolVnetSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate vnetSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderDefaultNodePoolVnetSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterSpecInitProviderDefaultNodePoolVnetSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderDefaultNodePool
{
    /// <summary>Should the Kubernetes Auto Scaler be enabled for this Node Pool?</summary>
    [JsonPropertyName("autoScalingEnabled")]
    public bool? AutoScalingEnabled { get; set; }

    /// <summary>Specifies the ID of the Capacity Reservation Group within which this AKS Cluster should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("capacityReservationGroupId")]
    public string? CapacityReservationGroupId { get; set; }

    /// <summary>Should the nodes in this Node Pool have Federal Information Processing Standard enabled? temporary_name_for_rotation must be specified when changing this block. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("fipsEnabled")]
    public bool? FipsEnabled { get; set; }

    /// <summary>Specifies the GPU MIG instance profile for supported GPU VM SKU. The allowed values are MIG1g, MIG2g, MIG3g, MIG4g and MIG7g. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("gpuInstance")]
    public string? GpuInstance { get; set; }

    /// <summary>Should the nodes in the Default Node Pool have host encryption enabled? temporary_name_for_rotation must be specified when changing this property.</summary>
    [JsonPropertyName("hostEncryptionEnabled")]
    public bool? HostEncryptionEnabled { get; set; }

    /// <summary>Specifies the ID of the Host Group within which this AKS Cluster should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hostGroupId")]
    public string? HostGroupId { get; set; }

    /// <summary>A kubelet_config block as defined below. temporary_name_for_rotation must be specified when changing this block.</summary>
    [JsonPropertyName("kubeletConfig")]
    public IList<V1beta1KubernetesClusterSpecInitProviderDefaultNodePoolKubeletConfig>? KubeletConfig { get; set; }

    /// <summary>The type of disk used by kubelet. Possible values are OS and Temporary. temporary_name_for_rotation must be specified when changing this block.</summary>
    [JsonPropertyName("kubeletDiskType")]
    public string? KubeletDiskType { get; set; }

    /// <summary>A linux_os_config block as defined below. temporary_name_for_rotation must be specified when changing this block.</summary>
    [JsonPropertyName("linuxOsConfig")]
    public IList<V1beta1KubernetesClusterSpecInitProviderDefaultNodePoolLinuxOsConfig>? LinuxOsConfig { get; set; }

    /// <summary>The maximum number of nodes which should exist in this Node Pool. If specified this must be between 1 and 1000.</summary>
    [JsonPropertyName("maxCount")]
    public double? MaxCount { get; set; }

    /// <summary>The maximum number of pods that can run on each agent. temporary_name_for_rotation must be specified when changing this property.</summary>
    [JsonPropertyName("maxPods")]
    public double? MaxPods { get; set; }

    /// <summary>The minimum number of nodes which should exist in this Node Pool. If specified this must be between 1 and 1000.</summary>
    [JsonPropertyName("minCount")]
    public double? MinCount { get; set; }

    /// <summary>The name which should be used for the default Kubernetes Node Pool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The initial number of nodes which should exist in this Node Pool. If specified this must be between 1 and 1000 and between min_count and max_count.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>A map of Kubernetes labels which should be applied to nodes in the Default Node Pool.</summary>
    [JsonPropertyName("nodeLabels")]
    public IDictionary<string, string>? NodeLabels { get; set; }

    /// <summary>A node_network_profile block as documented below.</summary>
    [JsonPropertyName("nodeNetworkProfile")]
    public IList<V1beta1KubernetesClusterSpecInitProviderDefaultNodePoolNodeNetworkProfile>? NodeNetworkProfile { get; set; }

    /// <summary>Should nodes in this Node Pool have a Public IP Address? temporary_name_for_rotation must be specified when changing this property.</summary>
    [JsonPropertyName("nodePublicIpEnabled")]
    public bool? NodePublicIpEnabled { get; set; }

    /// <summary>Resource ID for the Public IP Addresses Prefix for the nodes in this Node Pool. node_public_ip_enabled should be true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("nodePublicIpPrefixId")]
    public string? NodePublicIpPrefixId { get; set; }

    /// <summary>Enabling this option will taint default node pool with CriticalAddonsOnly=true:NoSchedule taint. temporary_name_for_rotation must be specified when changing this property.</summary>
    [JsonPropertyName("onlyCriticalAddonsEnabled")]
    public bool? OnlyCriticalAddonsEnabled { get; set; }

    /// <summary>Version of Kubernetes used for the Agents. If not specified, the default node pool will be created with the version specified by kubernetes_version. If both are unspecified, the latest recommended version will be used at provisioning time (but won't auto-upgrade). AKS does not require an exact patch version to be specified, minor version aliases such as 1.22 are also supported. - The minor version's latest GA patch is automatically chosen in that case. More details can be found in the documentation.</summary>
    [JsonPropertyName("orchestratorVersion")]
    public string? OrchestratorVersion { get; set; }

    /// <summary>The size of the OS Disk which should be used for each agent in the Node Pool. temporary_name_for_rotation must be specified when attempting a change.</summary>
    [JsonPropertyName("osDiskSizeGb")]
    public double? OsDiskSizeGb { get; set; }

    /// <summary>The type of disk which should be used for the Operating System. Possible values are Ephemeral and Managed. Defaults to Managed. temporary_name_for_rotation must be specified when attempting a change.</summary>
    [JsonPropertyName("osDiskType")]
    public string? OsDiskType { get; set; }

    /// <summary>Specifies the OS SKU used by the agent pool. Possible values are AzureLinux, Ubuntu, Windows2019 and Windows2022. If not specified, the default is Ubuntu if OSType=Linux or Windows2019 if OSType=Windows. And the default Windows OSSKU will be changed to Windows2022 after Windows2019 is deprecated. Changing this from AzureLinux or Ubuntu to AzureLinux or Ubuntu will not replace the resource, otherwise temporary_name_for_rotation must be specified when attempting a change.</summary>
    [JsonPropertyName("osSku")]
    public string? OsSku { get; set; }

    /// <summary>The ID of the Subnet where the pods in the default Node Pool should exist.</summary>
    [JsonPropertyName("podSubnetId")]
    public string? PodSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate podSubnetId.</summary>
    [JsonPropertyName("podSubnetIdRef")]
    public V1beta1KubernetesClusterSpecInitProviderDefaultNodePoolPodSubnetIdRef? PodSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate podSubnetId.</summary>
    [JsonPropertyName("podSubnetIdSelector")]
    public V1beta1KubernetesClusterSpecInitProviderDefaultNodePoolPodSubnetIdSelector? PodSubnetIdSelector { get; set; }

    /// <summary>The ID of the Proximity Placement Group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("proximityPlacementGroupId")]
    public string? ProximityPlacementGroupId { get; set; }

    /// <summary>Specifies the autoscaling behaviour of the Kubernetes Cluster. Allowed values are Delete and Deallocate. Defaults to Delete.</summary>
    [JsonPropertyName("scaleDownMode")]
    public string? ScaleDownMode { get; set; }

    /// <summary>The ID of the Snapshot which should be used to create this default Node Pool. temporary_name_for_rotation must be specified when changing this property.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>A mapping of tags to assign to the Node Pool.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the name of the temporary node pool used to cycle the default node pool for VM resizing.</summary>
    [JsonPropertyName("temporaryNameForRotation")]
    public string? TemporaryNameForRotation { get; set; }

    /// <summary>The type of Node Pool which should be created. Possible values are VirtualMachineScaleSets. Defaults to VirtualMachineScaleSets. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Used to specify whether the UltraSSD is enabled in the Default Node Pool. Defaults to false. See the documentation for more information. temporary_name_for_rotation must be specified when attempting a change.</summary>
    [JsonPropertyName("ultraSsdEnabled")]
    public bool? UltraSsdEnabled { get; set; }

    /// <summary>A upgrade_settings block as documented below.</summary>
    [JsonPropertyName("upgradeSettings")]
    public IList<V1beta1KubernetesClusterSpecInitProviderDefaultNodePoolUpgradeSettings>? UpgradeSettings { get; set; }

    /// <summary>The size of the Virtual Machine, such as Standard_DS2_v2. temporary_name_for_rotation must be specified when attempting a resize.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }

    /// <summary>The ID of a Subnet where the Kubernetes Node Pool should exist.</summary>
    [JsonPropertyName("vnetSubnetId")]
    public string? VnetSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate vnetSubnetId.</summary>
    [JsonPropertyName("vnetSubnetIdRef")]
    public V1beta1KubernetesClusterSpecInitProviderDefaultNodePoolVnetSubnetIdRef? VnetSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate vnetSubnetId.</summary>
    [JsonPropertyName("vnetSubnetIdSelector")]
    public V1beta1KubernetesClusterSpecInitProviderDefaultNodePoolVnetSubnetIdSelector? VnetSubnetIdSelector { get; set; }

    /// <summary>Specifies the workload runtime used by the node pool. Possible value is OCIContainer.</summary>
    [JsonPropertyName("workloadRuntime")]
    public string? WorkloadRuntime { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this Kubernetes Cluster should be located. temporary_name_for_rotation must be specified when changing this property.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>The base64 encoded alternative CA certificate content in PEM format.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderHttpProxyConfigTrustedCaSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderHttpProxyConfig
{
    /// <summary>The proxy address to be used when communicating over HTTP.</summary>
    [JsonPropertyName("httpProxy")]
    public string? HttpProxy { get; set; }

    /// <summary>The proxy address to be used when communicating over HTTPS.</summary>
    [JsonPropertyName("httpsProxy")]
    public string? HttpsProxy { get; set; }

    /// <summary>The list of domains that will not use the proxy for communication.</summary>
    [JsonPropertyName("noProxy")]
    public IList<string>? NoProxy { get; set; }

    /// <summary>The base64 encoded alternative CA certificate content in PEM format.</summary>
    [JsonPropertyName("trustedCaSecretRef")]
    public V1beta1KubernetesClusterSpecInitProviderHttpProxyConfigTrustedCaSecretRef? TrustedCaSecretRef { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderIdentityIdentityIdsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderIdentityIdentityIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterSpecInitProviderIdentityIdentityIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderIdentityIdentityIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of UserAssignedIdentity in managedidentity to populate identityIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderIdentityIdentityIdsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterSpecInitProviderIdentityIdentityIdsSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Kubernetes Cluster.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>References to UserAssignedIdentity in managedidentity to populate identityIds.</summary>
    [JsonPropertyName("identityIdsRefs")]
    public IList<V1beta1KubernetesClusterSpecInitProviderIdentityIdentityIdsRefs>? IdentityIdsRefs { get; set; }

    /// <summary>Selector for a list of UserAssignedIdentity in managedidentity to populate identityIds.</summary>
    [JsonPropertyName("identityIdsSelector")]
    public V1beta1KubernetesClusterSpecInitProviderIdentityIdentityIdsSelector? IdentityIdsSelector { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Kubernetes Cluster. Possible values are SystemAssigned or UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderIngressApplicationGatewaySubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderIngressApplicationGatewaySubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterSpecInitProviderIngressApplicationGatewaySubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderIngressApplicationGatewaySubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderIngressApplicationGatewaySubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterSpecInitProviderIngressApplicationGatewaySubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderIngressApplicationGateway
{
    /// <summary>The ID of the Application Gateway to integrate with the ingress controller of this Kubernetes Cluster. See this page for further details.</summary>
    [JsonPropertyName("gatewayId")]
    public string? GatewayId { get; set; }

    /// <summary>The name of the Application Gateway to be used or created in the Nodepool Resource Group, which in turn will be integrated with the ingress controller of this Kubernetes Cluster. See this page for further details.</summary>
    [JsonPropertyName("gatewayName")]
    public string? GatewayName { get; set; }

    /// <summary>The subnet CIDR to be used to create an Application Gateway, which in turn will be integrated with the ingress controller of this Kubernetes Cluster. See this page for further details.</summary>
    [JsonPropertyName("subnetCidr")]
    public string? SubnetCidr { get; set; }

    /// <summary>The ID of the subnet on which to create an Application Gateway, which in turn will be integrated with the ingress controller of this Kubernetes Cluster. See this page for further details.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1KubernetesClusterSpecInitProviderIngressApplicationGatewaySubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1KubernetesClusterSpecInitProviderIngressApplicationGatewaySubnetIdSelector? SubnetIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderKeyManagementService
{
    /// <summary>Identifier of Azure Key Vault key. See key identifier format for more details.</summary>
    [JsonPropertyName("keyVaultKeyId")]
    public string? KeyVaultKeyId { get; set; }

    /// <summary>Network access of the key vault Network access of key vault. The possible values are Public and Private. Public means the key vault allows public access from all networks. Private means the key vault disables public access and enables private link. Defaults to Public.</summary>
    [JsonPropertyName("keyVaultNetworkAccess")]
    public string? KeyVaultNetworkAccess { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderKeyVaultSecretsProvider
{
    /// <summary>Should the secret store CSI driver on the AKS cluster be enabled?</summary>
    [JsonPropertyName("secretRotationEnabled")]
    public bool? SecretRotationEnabled { get; set; }

    /// <summary>The interval to poll for secret rotation. This attribute is only set when secret_rotation_enabled is true. Defaults to 2m.</summary>
    [JsonPropertyName("secretRotationInterval")]
    public string? SecretRotationInterval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderKubeletIdentity
{
    /// <summary>The Client ID of the user-defined Managed Identity to be assigned to the Kubelets. If not specified a Managed Identity is created automatically. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The Object ID of the user-defined Managed Identity assigned to the Kubelets.If not specified a Managed Identity is created automatically. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>The ID of the User Assigned Identity assigned to the Kubelets. If not specified a Managed Identity is created automatically. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("userAssignedIdentityId")]
    public string? UserAssignedIdentityId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderLinuxProfileSshKey
{
    /// <summary>The Public SSH Key used to access the cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("keyData")]
    public string? KeyData { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderLinuxProfile
{
    /// <summary>The Admin Username for the Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>An ssh_key block as defined below. Only one is currently allowed. Changing this will update the key on all node pools. More information can be found in the documentation.</summary>
    [JsonPropertyName("sshKey")]
    public IList<V1beta1KubernetesClusterSpecInitProviderLinuxProfileSshKey>? SshKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderMaintenanceWindowAllowed
{
    /// <summary>A day in a week. Possible values are Sunday, Monday, Tuesday, Wednesday, Thursday, Friday and Saturday.</summary>
    [JsonPropertyName("day")]
    public string? Day { get; set; }

    /// <summary>An array of hour slots in a day. For example, specifying 1 will allow maintenance from 1:00am to 2:00am. Specifying 1, 2 will allow maintenance from 1:00am to 3:00m. Possible values are between 0 and 23.</summary>
    [JsonPropertyName("hours")]
    public IList<double>? Hours { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderMaintenanceWindowNotAllowed
{
    /// <summary>The end of a time span, formatted as an RFC3339 string.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>The start of a time span, formatted as an RFC3339 string.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderMaintenanceWindow
{
    /// <summary>One or more allowed blocks as defined below.</summary>
    [JsonPropertyName("allowed")]
    public IList<V1beta1KubernetesClusterSpecInitProviderMaintenanceWindowAllowed>? Allowed { get; set; }

    /// <summary>One or more not_allowed block as defined below.</summary>
    [JsonPropertyName("notAllowed")]
    public IList<V1beta1KubernetesClusterSpecInitProviderMaintenanceWindowNotAllowed>? NotAllowed { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderMaintenanceWindowAutoUpgradeNotAllowed
{
    /// <summary>The end of a time span, formatted as an RFC3339 string.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>The start of a time span, formatted as an RFC3339 string.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderMaintenanceWindowAutoUpgrade
{
    /// <summary>The day of the month for the maintenance run. Required in combination with AbsoluteMonthly frequency. Value between 0 and 31 (inclusive).</summary>
    [JsonPropertyName("dayOfMonth")]
    public double? DayOfMonth { get; set; }

    /// <summary>The day of the week for the maintenance run. Required in combination with weekly frequency. Possible values are Friday, Monday, Saturday, Sunday, Thursday, Tuesday and Wednesday.</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>The duration of the window for maintenance to run in hours. Possible options are between 4 to 24.</summary>
    [JsonPropertyName("duration")]
    public double? Duration { get; set; }

    /// <summary>Frequency of maintenance. Possible options are Weekly, AbsoluteMonthly and RelativeMonthly.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>The interval for maintenance runs. Depending on the frequency this interval is week or month based.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>One or more not_allowed block as defined below.</summary>
    [JsonPropertyName("notAllowed")]
    public IList<V1beta1KubernetesClusterSpecInitProviderMaintenanceWindowAutoUpgradeNotAllowed>? NotAllowed { get; set; }

    /// <summary>The date on which the maintenance window begins to take effect.</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }

    /// <summary>The time for maintenance to begin, based on the timezone determined by utc_offset. Format is HH:mm.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Used to determine the timezone for cluster maintenance.</summary>
    [JsonPropertyName("utcOffset")]
    public string? UtcOffset { get; set; }

    /// <summary>Specifies on which instance of the allowed days specified in day_of_week the maintenance occurs. Options are First, Second, Third, Fourth, and Last. Required in combination with relative monthly frequency.</summary>
    [JsonPropertyName("weekIndex")]
    public string? WeekIndex { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderMaintenanceWindowNodeOsNotAllowed
{
    /// <summary>The end of a time span, formatted as an RFC3339 string.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>The start of a time span, formatted as an RFC3339 string.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderMaintenanceWindowNodeOs
{
    /// <summary>The day of the month for the maintenance run. Required in combination with AbsoluteMonthly frequency. Value between 0 and 31 (inclusive).</summary>
    [JsonPropertyName("dayOfMonth")]
    public double? DayOfMonth { get; set; }

    /// <summary>The day of the week for the maintenance run. Required in combination with weekly frequency. Possible values are Friday, Monday, Saturday, Sunday, Thursday, Tuesday and Wednesday.</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>The duration of the window for maintenance to run in hours. Possible options are between 4 to 24.</summary>
    [JsonPropertyName("duration")]
    public double? Duration { get; set; }

    /// <summary>Frequency of maintenance. Possible options are Daily, Weekly, AbsoluteMonthly and RelativeMonthly.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>The interval for maintenance runs. Depending on the frequency this interval is week or month based.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>One or more not_allowed block as defined below.</summary>
    [JsonPropertyName("notAllowed")]
    public IList<V1beta1KubernetesClusterSpecInitProviderMaintenanceWindowNodeOsNotAllowed>? NotAllowed { get; set; }

    /// <summary>The date on which the maintenance window begins to take effect.</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }

    /// <summary>The time for maintenance to begin, based on the timezone determined by utc_offset. Format is HH:mm.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Used to determine the timezone for cluster maintenance.</summary>
    [JsonPropertyName("utcOffset")]
    public string? UtcOffset { get; set; }

    /// <summary>The week in the month used for the maintenance run. Options are First, Second, Third, Fourth, and Last.</summary>
    [JsonPropertyName("weekIndex")]
    public string? WeekIndex { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderMicrosoftDefender
{
    /// <summary>Specifies the ID of the Log Analytics Workspace where the audit logs collected by Microsoft Defender should be sent to.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderMonitorMetrics
{
    /// <summary>Specifies a comma-separated list of Kubernetes annotation keys that will be used in the resource's labels metric.</summary>
    [JsonPropertyName("annotationsAllowed")]
    public string? AnnotationsAllowed { get; set; }

    /// <summary>Specifies a Comma-separated list of additional Kubernetes label keys that will be used in the resource's labels metric.</summary>
    [JsonPropertyName("labelsAllowed")]
    public string? LabelsAllowed { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderNetworkProfileLoadBalancerProfile
{
    /// <summary>The type of the managed inbound Load Balancer Backend Pool. Possible values are NodeIP and NodeIPConfiguration. Defaults to NodeIPConfiguration. See the documentation for more information.</summary>
    [JsonPropertyName("backendPoolType")]
    public string? BackendPoolType { get; set; }

    /// <summary>Desired outbound flow idle timeout in minutes for the managed nat gateway. Must be between 4 and 120 inclusive. Defaults to 4.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>Count of desired managed outbound IPs for the managed nat gateway. Must be between 1 and 16 inclusive.</summary>
    [JsonPropertyName("managedOutboundIpCount")]
    public double? ManagedOutboundIpCount { get; set; }

    /// <summary>The desired number of IPv6 outbound IPs created and managed by Azure for the cluster load balancer. Must be in the range of 1 to 100 (inclusive). The default value is 0 for single-stack and 1 for dual-stack.</summary>
    [JsonPropertyName("managedOutboundIpv6Count")]
    public double? ManagedOutboundIpv6Count { get; set; }

    /// <summary>The ID of the Public IP Addresses which should be used for outbound communication for the cluster load balancer.</summary>
    [JsonPropertyName("outboundIpAddressIds")]
    public IList<string>? OutboundIpAddressIds { get; set; }

    /// <summary>The ID of the outbound Public IP Address Prefixes which should be used for the cluster load balancer.</summary>
    [JsonPropertyName("outboundIpPrefixIds")]
    public IList<string>? OutboundIpPrefixIds { get; set; }

    /// <summary>Number of desired SNAT port for each VM in the clusters load balancer. Must be between 0 and 64000 inclusive. Defaults to 0.</summary>
    [JsonPropertyName("outboundPortsAllocated")]
    public double? OutboundPortsAllocated { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderNetworkProfileNatGatewayProfile
{
    /// <summary>Desired outbound flow idle timeout in minutes for the managed nat gateway. Must be between 4 and 120 inclusive. Defaults to 4.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>Count of desired managed outbound IPs for the managed nat gateway. Must be between 1 and 16 inclusive.</summary>
    [JsonPropertyName("managedOutboundIpCount")]
    public double? ManagedOutboundIpCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderNetworkProfile
{
    /// <summary>IP address within the Kubernetes service address range that will be used by cluster service discovery (kube-dns). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dnsServiceIp")]
    public string? DnsServiceIp { get; set; }

    /// <summary>Specifies a list of IP versions the Kubernetes Cluster will use to assign IP addresses to its nodes and pods. Possible values are IPv4 and/or IPv6. IPv4 must always be specified. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ipVersions")]
    public IList<string>? IpVersions { get; set; }

    /// <summary>A load_balancer_profile block as defined below. This can only be specified when load_balancer_sku is set to standard. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("loadBalancerProfile")]
    public IList<V1beta1KubernetesClusterSpecInitProviderNetworkProfileLoadBalancerProfile>? LoadBalancerProfile { get; set; }

    /// <summary>Specifies the SKU of the Load Balancer used for this Kubernetes Cluster. Possible values are basic and standard. Defaults to standard. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("loadBalancerSku")]
    public string? LoadBalancerSku { get; set; }

    /// <summary>A nat_gateway_profile block as defined below. This can only be specified when load_balancer_sku is set to standard and outbound_type is set to managedNATGateway or userAssignedNATGateway. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("natGatewayProfile")]
    public IList<V1beta1KubernetesClusterSpecInitProviderNetworkProfileNatGatewayProfile>? NatGatewayProfile { get; set; }

    /// <summary>Specifies the data plane used for building the Kubernetes network. Possible values are azure and cilium. Defaults to azure. Disabling this forces a new resource to be created.</summary>
    [JsonPropertyName("networkDataPlane")]
    public string? NetworkDataPlane { get; set; }

    /// <summary>Network mode to be used with Azure CNI. Possible values are bridge and transparent. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("networkMode")]
    public string? NetworkMode { get; set; }

    /// <summary>Network plugin to use for networking. Currently supported values are azure, kubenet and none. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("networkPlugin")]
    public string? NetworkPlugin { get; set; }

    /// <summary>Specifies the network plugin mode used for building the Kubernetes network. Possible value is overlay.</summary>
    [JsonPropertyName("networkPluginMode")]
    public string? NetworkPluginMode { get; set; }

    /// <summary>Sets up network policy to be used with Azure CNI. Network policy allows us to control the traffic flow between pods. Currently supported values are calico, azure and cilium.</summary>
    [JsonPropertyName("networkPolicy")]
    public string? NetworkPolicy { get; set; }

    /// <summary>The outbound (egress) routing method which should be used for this Kubernetes Cluster. Possible values are loadBalancer, userDefinedRouting, managedNATGateway and userAssignedNATGateway. Defaults to loadBalancer. More information on supported migration paths for outbound_type can be found in this documentation.</summary>
    [JsonPropertyName("outboundType")]
    public string? OutboundType { get; set; }

    /// <summary>The CIDR to use for pod IP addresses. This field can only be set when network_plugin is set to kubenet or network_plugin_mode is set to overlay. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("podCidr")]
    public string? PodCidr { get; set; }

    /// <summary>A list of CIDRs to use for pod IP addresses. For single-stack networking a single IPv4 CIDR is expected. For dual-stack networking an IPv4 and IPv6 CIDR are expected. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("podCidrs")]
    public IList<string>? PodCidrs { get; set; }

    /// <summary>The Network Range used by the Kubernetes service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("serviceCidr")]
    public string? ServiceCidr { get; set; }

    /// <summary>A list of CIDRs to use for Kubernetes services. For single-stack networking a single IPv4 CIDR is expected. For dual-stack networking an IPv4 and IPv6 CIDR are expected. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("serviceCidrs")]
    public IList<string>? ServiceCidrs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderOmsAgent
{
    /// <summary>The ID of the Log Analytics Workspace which the OMS Agent should send data to.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>Is managed identity authentication for monitoring enabled?</summary>
    [JsonPropertyName("msiAuthForMonitoringEnabled")]
    public bool? MsiAuthForMonitoringEnabled { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderPrivateDnsZoneIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a PrivateDNSZone in network to populate privateDnsZoneId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderPrivateDnsZoneIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterSpecInitProviderPrivateDnsZoneIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderPrivateDnsZoneIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a PrivateDNSZone in network to populate privateDnsZoneId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderPrivateDnsZoneIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterSpecInitProviderPrivateDnsZoneIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderServiceMeshProfileCertificateAuthority
{
    /// <summary>The certificate chain object name in Azure Key Vault.</summary>
    [JsonPropertyName("certChainObjectName")]
    public string? CertChainObjectName { get; set; }

    /// <summary>The intermediate certificate object name in Azure Key Vault.</summary>
    [JsonPropertyName("certObjectName")]
    public string? CertObjectName { get; set; }

    /// <summary>The intermediate certificate private key object name in Azure Key Vault.</summary>
    [JsonPropertyName("keyObjectName")]
    public string? KeyObjectName { get; set; }

    /// <summary>The resource ID of the Key Vault.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>The root certificate object name in Azure Key Vault.</summary>
    [JsonPropertyName("rootCertObjectName")]
    public string? RootCertObjectName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderServiceMeshProfile
{
    /// <summary>A certificate_authority block as defined below. When this property is specified, key_vault_secrets_provider is also required to be set. This configuration allows you to bring your own root certificate and keys for Istio CA in the Istio-based service mesh add-on for Azure Kubernetes Service.</summary>
    [JsonPropertyName("certificateAuthority")]
    public IList<V1beta1KubernetesClusterSpecInitProviderServiceMeshProfileCertificateAuthority>? CertificateAuthority { get; set; }

    /// <summary>Is Istio External Ingress Gateway enabled?</summary>
    [JsonPropertyName("externalIngressGatewayEnabled")]
    public bool? ExternalIngressGatewayEnabled { get; set; }

    /// <summary>Is Istio Internal Ingress Gateway enabled?</summary>
    [JsonPropertyName("internalIngressGatewayEnabled")]
    public bool? InternalIngressGatewayEnabled { get; set; }

    /// <summary>The mode of the service mesh. Possible value is Istio.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Specify 1 or 2 Istio control plane revisions for managing minor upgrades using the canary upgrade process. For example, create the resource with revisions set to ["asm-1-20"], or leave it empty (the revisions will only be known after apply). To start the canary upgrade, change revisions to ["asm-1-20", "asm-1-21"]. To roll back the canary upgrade, revert to ["asm-1-20"]. To confirm the upgrade, change to ["asm-1-21"].</summary>
    [JsonPropertyName("revisions")]
    public IList<string>? Revisions { get; set; }
}

/// <summary>The Client Secret for the Service Principal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderServicePrincipalClientSecretSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderServicePrincipal
{
    /// <summary>The Client ID for the Service Principal.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The Client Secret for the Service Principal.</summary>
    [JsonPropertyName("clientSecretSecretRef")]
    public V1beta1KubernetesClusterSpecInitProviderServicePrincipalClientSecretSecretRef ClientSecretSecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderStorageProfile
{
    /// <summary>Is the Blob CSI driver enabled? Defaults to false.</summary>
    [JsonPropertyName("blobDriverEnabled")]
    public bool? BlobDriverEnabled { get; set; }

    /// <summary>Is the Disk CSI driver enabled? Defaults to true.</summary>
    [JsonPropertyName("diskDriverEnabled")]
    public bool? DiskDriverEnabled { get; set; }

    /// <summary>Is the File CSI driver enabled? Defaults to true.</summary>
    [JsonPropertyName("fileDriverEnabled")]
    public bool? FileDriverEnabled { get; set; }

    /// <summary>Is the Snapshot Controller enabled? Defaults to true.</summary>
    [JsonPropertyName("snapshotControllerEnabled")]
    public bool? SnapshotControllerEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderUpgradeOverride
{
    /// <summary>Specifies the duration, in RFC 3339 format (e.g., 2025-10-01T13:00:00Z), the upgrade_override values are effective. This field must be set for the upgrade_override values to take effect. The date-time must be within the next 30 days.</summary>
    [JsonPropertyName("effectiveUntil")]
    public string? EffectiveUntil { get; set; }

    /// <summary>Whether to force upgrade the cluster. Possible values are true or false.</summary>
    [JsonPropertyName("forceUpgradeEnabled")]
    public bool? ForceUpgradeEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderWebAppRouting
{
    /// <summary>Specifies the list of the DNS Zone IDs in which DNS entries are created for applications deployed to the cluster when Web App Routing is enabled. If not using Bring-Your-Own DNS zones this property should be set to an empty list.</summary>
    [JsonPropertyName("dnsZoneIds")]
    public IList<string>? DnsZoneIds { get; set; }
}

/// <summary>The Admin Password for Windows VMs. Length must be between 14 and 123 characters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderWindowsProfileAdminPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderWindowsProfileGmsa
{
    /// <summary>Specifies the DNS server for Windows gMSA. Set this to an empty string if you have configured the DNS server in the VNet which was used to create the managed cluster.</summary>
    [JsonPropertyName("dnsServer")]
    public string? DnsServer { get; set; }

    /// <summary>Specifies the root domain name for Windows gMSA. Set this to an empty string if you have configured the DNS server in the VNet which was used to create the managed cluster.</summary>
    [JsonPropertyName("rootDomain")]
    public string? RootDomain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderWindowsProfile
{
    /// <summary>The Admin Password for Windows VMs. Length must be between 14 and 123 characters.</summary>
    [JsonPropertyName("adminPasswordSecretRef")]
    public V1beta1KubernetesClusterSpecInitProviderWindowsProfileAdminPasswordSecretRef AdminPasswordSecretRef { get; set; }

    /// <summary>The Admin Username for Windows VMs. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>A gmsa block as defined below.</summary>
    [JsonPropertyName("gmsa")]
    public IList<V1beta1KubernetesClusterSpecInitProviderWindowsProfileGmsa>? Gmsa { get; set; }

    /// <summary>Specifies the type of on-premise license which should be used for Node Pool Windows Virtual Machine. At this time the only possible value is Windows_Server.</summary>
    [JsonPropertyName("license")]
    public string? License { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProviderWorkloadAutoscalerProfile
{
    /// <summary>Specifies whether KEDA Autoscaler can be used for workloads.</summary>
    [JsonPropertyName("kedaEnabled")]
    public bool? KedaEnabled { get; set; }

    /// <summary>Specifies whether Vertical Pod Autoscaler should be enabled.</summary>
    [JsonPropertyName("verticalPodAutoscalerEnabled")]
    public bool? VerticalPodAutoscalerEnabled { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecInitProvider
{
    /// <summary>A aci_connector_linux block as defined below. For more details, please visit Create and configure an AKS cluster to use virtual nodes.</summary>
    [JsonPropertyName("aciConnectorLinux")]
    public IList<V1beta1KubernetesClusterSpecInitProviderAciConnectorLinux>? AciConnectorLinux { get; set; }

    /// <summary>An api_server_access_profile block as defined below.</summary>
    [JsonPropertyName("apiServerAccessProfile")]
    public IList<V1beta1KubernetesClusterSpecInitProviderApiServerAccessProfile>? ApiServerAccessProfile { get; set; }

    /// <summary>A auto_scaler_profile block as defined below.</summary>
    [JsonPropertyName("autoScalerProfile")]
    public IList<V1beta1KubernetesClusterSpecInitProviderAutoScalerProfile>? AutoScalerProfile { get; set; }

    /// <summary>The upgrade channel for this Kubernetes Cluster. Possible values are patch, rapid, node-image and stable. Omitting this field sets this value to none.</summary>
    [JsonPropertyName("automaticUpgradeChannel")]
    public string? AutomaticUpgradeChannel { get; set; }

    /// <summary>A azure_active_directory_role_based_access_control block as defined below.</summary>
    [JsonPropertyName("azureActiveDirectoryRoleBasedAccessControl")]
    public IList<V1beta1KubernetesClusterSpecInitProviderAzureActiveDirectoryRoleBasedAccessControl>? AzureActiveDirectoryRoleBasedAccessControl { get; set; }

    /// <summary>Should the Azure Policy Add-On be enabled? For more details please visit Understand Azure Policy for Azure Kubernetes Service</summary>
    [JsonPropertyName("azurePolicyEnabled")]
    public bool? AzurePolicyEnabled { get; set; }

    /// <summary>A confidential_computing block as defined below. For more details please the documentation</summary>
    [JsonPropertyName("confidentialComputing")]
    public IList<V1beta1KubernetesClusterSpecInitProviderConfidentialComputing>? ConfidentialComputing { get; set; }

    /// <summary>Should cost analysis be enabled for this Kubernetes Cluster? Defaults to false. The sku_tier must be set to Standard or Premium to enable this feature. Enabling this will add Kubernetes Namespace and Deployment details to the Cost Analysis views in the Azure portal.</summary>
    [JsonPropertyName("costAnalysisEnabled")]
    public bool? CostAnalysisEnabled { get; set; }

    /// <summary>Specifies configuration for "System" mode node pool. A default_node_pool block as defined below.</summary>
    [JsonPropertyName("defaultNodePool")]
    public IList<V1beta1KubernetesClusterSpecInitProviderDefaultNodePool>? DefaultNodePool { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used for the Nodes and Volumes. More information can be found in the documentation. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>DNS prefix specified when creating the managed cluster. Possible values must begin and end with a letter or number, contain only letters, numbers, and hyphens and be between 1 and 54 characters in length. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dnsPrefix")]
    public string? DnsPrefix { get; set; }

    /// <summary>Specifies the DNS prefix to use with private clusters. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dnsPrefixPrivateCluster")]
    public string? DnsPrefixPrivateCluster { get; set; }

    /// <summary>Specifies the Extended Zone (formerly called Edge Zone) within the Azure Region where this Managed Kubernetes Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("edgeZone")]
    public string? EdgeZone { get; set; }

    /// <summary>Should HTTP Application Routing be enabled?</summary>
    [JsonPropertyName("httpApplicationRoutingEnabled")]
    public bool? HttpApplicationRoutingEnabled { get; set; }

    /// <summary>A http_proxy_config block as defined below.</summary>
    [JsonPropertyName("httpProxyConfig")]
    public IList<V1beta1KubernetesClusterSpecInitProviderHttpProxyConfig>? HttpProxyConfig { get; set; }

    /// <summary>An identity block as defined below. One of either identity or service_principal must be specified.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1KubernetesClusterSpecInitProviderIdentity>? Identity { get; set; }

    /// <summary>Specifies whether Image Cleaner is enabled.</summary>
    [JsonPropertyName("imageCleanerEnabled")]
    public bool? ImageCleanerEnabled { get; set; }

    /// <summary>Specifies the interval in hours when images should be cleaned up. Defaults to 0.</summary>
    [JsonPropertyName("imageCleanerIntervalHours")]
    public double? ImageCleanerIntervalHours { get; set; }

    /// <summary>An ingress_application_gateway block as defined below.</summary>
    [JsonPropertyName("ingressApplicationGateway")]
    public IList<V1beta1KubernetesClusterSpecInitProviderIngressApplicationGateway>? IngressApplicationGateway { get; set; }

    /// <summary>A key_management_service block as defined below. For more details, please visit Key Management Service (KMS) etcd encryption to an AKS cluster.</summary>
    [JsonPropertyName("keyManagementService")]
    public IList<V1beta1KubernetesClusterSpecInitProviderKeyManagementService>? KeyManagementService { get; set; }

    /// <summary>A key_vault_secrets_provider block as defined below.</summary>
    [JsonPropertyName("keyVaultSecretsProvider")]
    public IList<V1beta1KubernetesClusterSpecInitProviderKeyVaultSecretsProvider>? KeyVaultSecretsProvider { get; set; }

    /// <summary>A kubelet_identity block as defined below.</summary>
    [JsonPropertyName("kubeletIdentity")]
    public IList<V1beta1KubernetesClusterSpecInitProviderKubeletIdentity>? KubeletIdentity { get; set; }

    /// <summary>Version of Kubernetes specified when creating the AKS managed cluster. If not specified, the latest recommended version will be used at provisioning time (but won't auto-upgrade). AKS does not require an exact patch version to be specified, minor version aliases such as 1.22 are also supported. - The minor version's latest GA patch is automatically chosen in that case. More details can be found in the documentation.</summary>
    [JsonPropertyName("kubernetesVersion")]
    public string? KubernetesVersion { get; set; }

    /// <summary>A linux_profile block as defined below.</summary>
    [JsonPropertyName("linuxProfile")]
    public IList<V1beta1KubernetesClusterSpecInitProviderLinuxProfile>? LinuxProfile { get; set; }

    /// <summary>If true local accounts will be disabled. See the documentation for more information.</summary>
    [JsonPropertyName("localAccountDisabled")]
    public bool? LocalAccountDisabled { get; set; }

    /// <summary>The location where the Managed Kubernetes Cluster should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A maintenance_window block as defined below.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public IList<V1beta1KubernetesClusterSpecInitProviderMaintenanceWindow>? MaintenanceWindow { get; set; }

    /// <summary>A maintenance_window_auto_upgrade block as defined below.</summary>
    [JsonPropertyName("maintenanceWindowAutoUpgrade")]
    public IList<V1beta1KubernetesClusterSpecInitProviderMaintenanceWindowAutoUpgrade>? MaintenanceWindowAutoUpgrade { get; set; }

    /// <summary>A maintenance_window_node_os block as defined below.</summary>
    [JsonPropertyName("maintenanceWindowNodeOs")]
    public IList<V1beta1KubernetesClusterSpecInitProviderMaintenanceWindowNodeOs>? MaintenanceWindowNodeOs { get; set; }

    /// <summary>A microsoft_defender block as defined below.</summary>
    [JsonPropertyName("microsoftDefender")]
    public IList<V1beta1KubernetesClusterSpecInitProviderMicrosoftDefender>? MicrosoftDefender { get; set; }

    /// <summary>Specifies a Prometheus add-on profile for the Kubernetes Cluster. A monitor_metrics block as defined below.</summary>
    [JsonPropertyName("monitorMetrics")]
    public IList<V1beta1KubernetesClusterSpecInitProviderMonitorMetrics>? MonitorMetrics { get; set; }

    /// <summary>A network_profile block as defined below.</summary>
    [JsonPropertyName("networkProfile")]
    public IList<V1beta1KubernetesClusterSpecInitProviderNetworkProfile>? NetworkProfile { get; set; }

    /// <summary>The upgrade channel for this Kubernetes Cluster Nodes' OS Image. Possible values are Unmanaged, SecurityPatch, NodeImage and None. Defaults to NodeImage.</summary>
    [JsonPropertyName("nodeOsUpgradeChannel")]
    public string? NodeOsUpgradeChannel { get; set; }

    /// <summary>The auto-generated Resource Group which contains the resources for this Managed Kubernetes Cluster.</summary>
    [JsonPropertyName("nodeResourceGroup")]
    public string? NodeResourceGroup { get; set; }

    /// <summary>Enable or Disable the OIDC issuer URL</summary>
    [JsonPropertyName("oidcIssuerEnabled")]
    public bool? OidcIssuerEnabled { get; set; }

    /// <summary>An oms_agent block as defined below.</summary>
    [JsonPropertyName("omsAgent")]
    public IList<V1beta1KubernetesClusterSpecInitProviderOmsAgent>? OmsAgent { get; set; }

    /// <summary>Is Open Service Mesh enabled? For more details, please visit Open Service Mesh for AKS.</summary>
    [JsonPropertyName("openServiceMeshEnabled")]
    public bool? OpenServiceMeshEnabled { get; set; }

    /// <summary>Should this Kubernetes Cluster have its API server only exposed on internal IP addresses? This provides a Private IP Address for the Kubernetes API on the Virtual Network where the Kubernetes Cluster is located. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateClusterEnabled")]
    public bool? PrivateClusterEnabled { get; set; }

    /// <summary>Specifies whether a Public FQDN for this Private Cluster should be added. Defaults to false.</summary>
    [JsonPropertyName("privateClusterPublicFqdnEnabled")]
    public bool? PrivateClusterPublicFqdnEnabled { get; set; }

    /// <summary>Either the ID of Private DNS Zone which should be delegated to this Cluster, System to have AKS manage this or None. In case of None you will need to bring your own DNS server and set up resolving, otherwise, the cluster will have issues after provisioning. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateDnsZoneId")]
    public string? PrivateDnsZoneId { get; set; }

    /// <summary>Reference to a PrivateDNSZone in network to populate privateDnsZoneId.</summary>
    [JsonPropertyName("privateDnsZoneIdRef")]
    public V1beta1KubernetesClusterSpecInitProviderPrivateDnsZoneIdRef? PrivateDnsZoneIdRef { get; set; }

    /// <summary>Selector for a PrivateDNSZone in network to populate privateDnsZoneId.</summary>
    [JsonPropertyName("privateDnsZoneIdSelector")]
    public V1beta1KubernetesClusterSpecInitProviderPrivateDnsZoneIdSelector? PrivateDnsZoneIdSelector { get; set; }

    /// <summary>Whether Role Based Access Control for the Kubernetes Cluster should be enabled. Defaults to true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("roleBasedAccessControlEnabled")]
    public bool? RoleBasedAccessControlEnabled { get; set; }

    /// <summary>Whether to enable run command for the cluster or not. Defaults to true.</summary>
    [JsonPropertyName("runCommandEnabled")]
    public bool? RunCommandEnabled { get; set; }

    /// <summary>A service_mesh_profile block as defined below.</summary>
    [JsonPropertyName("serviceMeshProfile")]
    public IList<V1beta1KubernetesClusterSpecInitProviderServiceMeshProfile>? ServiceMeshProfile { get; set; }

    /// <summary>A service_principal block as documented below. One of either identity or service_principal must be specified.</summary>
    [JsonPropertyName("servicePrincipal")]
    public IList<V1beta1KubernetesClusterSpecInitProviderServicePrincipal>? ServicePrincipal { get; set; }

    /// <summary>The SKU Tier that should be used for this Kubernetes Cluster. Possible values are Free, Standard (which includes the Uptime SLA) and Premium. Defaults to Free.</summary>
    [JsonPropertyName("skuTier")]
    public string? SkuTier { get; set; }

    /// <summary>A storage_profile block as defined below.</summary>
    [JsonPropertyName("storageProfile")]
    public IList<V1beta1KubernetesClusterSpecInitProviderStorageProfile>? StorageProfile { get; set; }

    /// <summary>Specifies the support plan which should be used for this Kubernetes Cluster. Possible values are KubernetesOfficial and AKSLongTermSupport. Defaults to KubernetesOfficial.</summary>
    [JsonPropertyName("supportPlan")]
    public string? SupportPlan { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A upgrade_override block as defined below.</summary>
    [JsonPropertyName("upgradeOverride")]
    public IList<V1beta1KubernetesClusterSpecInitProviderUpgradeOverride>? UpgradeOverride { get; set; }

    /// <summary>A web_app_routing block as defined below.</summary>
    [JsonPropertyName("webAppRouting")]
    public IList<V1beta1KubernetesClusterSpecInitProviderWebAppRouting>? WebAppRouting { get; set; }

    /// <summary>A windows_profile block as defined below.</summary>
    [JsonPropertyName("windowsProfile")]
    public IList<V1beta1KubernetesClusterSpecInitProviderWindowsProfile>? WindowsProfile { get; set; }

    /// <summary>A workload_autoscaler_profile block defined below.</summary>
    [JsonPropertyName("workloadAutoscalerProfile")]
    public IList<V1beta1KubernetesClusterSpecInitProviderWorkloadAutoscalerProfile>? WorkloadAutoscalerProfile { get; set; }

    /// <summary>Specifies whether Azure AD Workload Identity should be enabled for the Cluster. Defaults to false.</summary>
    [JsonPropertyName("workloadIdentityEnabled")]
    public bool? WorkloadIdentityEnabled { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecProviderConfigRefPolicy
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
public partial class V1beta1KubernetesClusterSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>KubernetesClusterSpec defines the desired state of KubernetesCluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1KubernetesClusterSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1KubernetesClusterSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1KubernetesClusterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1KubernetesClusterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderAciConnectorLinuxConnectorIdentity
{
    /// <summary>The Client ID of the user-defined Managed Identity used by the ACI Connector.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The Object ID of the user-defined Managed Identity used by the ACI Connector.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>The ID of the User Assigned Identity used by the ACI Connector.</summary>
    [JsonPropertyName("userAssignedIdentityId")]
    public string? UserAssignedIdentityId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderAciConnectorLinux
{
    /// <summary>A connector_identity block is exported. The exported attributes are defined below.</summary>
    [JsonPropertyName("connectorIdentity")]
    public IList<V1beta1KubernetesClusterStatusAtProviderAciConnectorLinuxConnectorIdentity>? ConnectorIdentity { get; set; }

    /// <summary>The subnet name for the virtual nodes to run.</summary>
    [JsonPropertyName("subnetName")]
    public string? SubnetName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderApiServerAccessProfile
{
    /// <summary>Set of authorized IP ranges to allow access to API server, e.g. ["198.51.100.0/24"].</summary>
    [JsonPropertyName("authorizedIpRanges")]
    public IList<string>? AuthorizedIpRanges { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderAutoScalerProfile
{
    /// <summary>Detect similar node groups and balance the number of nodes between them. Defaults to false.</summary>
    [JsonPropertyName("balanceSimilarNodeGroups")]
    public bool? BalanceSimilarNodeGroups { get; set; }

    /// <summary>Whether DaemonSet pods will be gracefully terminated from empty nodes. Defaults to false.</summary>
    [JsonPropertyName("daemonsetEvictionForEmptyNodesEnabled")]
    public bool? DaemonsetEvictionForEmptyNodesEnabled { get; set; }

    /// <summary>Whether DaemonSet pods will be gracefully terminated from non-empty nodes. Defaults to true.</summary>
    [JsonPropertyName("daemonsetEvictionForOccupiedNodesEnabled")]
    public bool? DaemonsetEvictionForOccupiedNodesEnabled { get; set; }

    /// <summary>Maximum number of empty nodes that can be deleted at the same time. Defaults to 10.</summary>
    [JsonPropertyName("emptyBulkDeleteMax")]
    public string? EmptyBulkDeleteMax { get; set; }

    /// <summary>Expander to use. Possible values are least-waste, priority, most-pods and random. Defaults to random.</summary>
    [JsonPropertyName("expander")]
    public string? Expander { get; set; }

    /// <summary>Whether DaemonSet pods will be ignored when calculating resource utilization for scale down. Defaults to false.</summary>
    [JsonPropertyName("ignoreDaemonsetsUtilizationEnabled")]
    public bool? IgnoreDaemonsetsUtilizationEnabled { get; set; }

    /// <summary>Maximum number of seconds the cluster autoscaler waits for pod termination when trying to scale down a node. Defaults to 600.</summary>
    [JsonPropertyName("maxGracefulTerminationSec")]
    public string? MaxGracefulTerminationSec { get; set; }

    /// <summary>Maximum time the autoscaler waits for a node to be provisioned. Defaults to 15m.</summary>
    [JsonPropertyName("maxNodeProvisioningTime")]
    public string? MaxNodeProvisioningTime { get; set; }

    /// <summary>Maximum Number of allowed unready nodes. Defaults to 3.</summary>
    [JsonPropertyName("maxUnreadyNodes")]
    public double? MaxUnreadyNodes { get; set; }

    /// <summary>Maximum percentage of unready nodes the cluster autoscaler will stop if the percentage is exceeded. Defaults to 45.</summary>
    [JsonPropertyName("maxUnreadyPercentage")]
    public double? MaxUnreadyPercentage { get; set; }

    /// <summary>For scenarios like burst/batch scale where you don't want CA to act before the kubernetes scheduler could schedule all the pods, you can tell CA to ignore unscheduled pods before they're a certain age. Defaults to 10s.</summary>
    [JsonPropertyName("newPodScaleUpDelay")]
    public string? NewPodScaleUpDelay { get; set; }

    /// <summary>How long after the scale up of AKS nodes the scale down evaluation resumes. Defaults to 10m.</summary>
    [JsonPropertyName("scaleDownDelayAfterAdd")]
    public string? ScaleDownDelayAfterAdd { get; set; }

    /// <summary>How long after node deletion that scale down evaluation resumes. Defaults to the value used for scan_interval.</summary>
    [JsonPropertyName("scaleDownDelayAfterDelete")]
    public string? ScaleDownDelayAfterDelete { get; set; }

    /// <summary>How long after scale down failure that scale down evaluation resumes. Defaults to 3m.</summary>
    [JsonPropertyName("scaleDownDelayAfterFailure")]
    public string? ScaleDownDelayAfterFailure { get; set; }

    /// <summary>How long a node should be unneeded before it is eligible for scale down. Defaults to 10m.</summary>
    [JsonPropertyName("scaleDownUnneeded")]
    public string? ScaleDownUnneeded { get; set; }

    /// <summary>How long an unready node should be unneeded before it is eligible for scale down. Defaults to 20m.</summary>
    [JsonPropertyName("scaleDownUnready")]
    public string? ScaleDownUnready { get; set; }

    /// <summary>Node utilization level, defined as sum of requested resources divided by capacity, below which a node can be considered for scale down. Defaults to 0.5.</summary>
    [JsonPropertyName("scaleDownUtilizationThreshold")]
    public string? ScaleDownUtilizationThreshold { get; set; }

    /// <summary>How often the AKS Cluster should be re-evaluated for scale up/down. Defaults to 10s.</summary>
    [JsonPropertyName("scanInterval")]
    public string? ScanInterval { get; set; }

    /// <summary>If true cluster autoscaler will never delete nodes with pods with local storage, for example, EmptyDir or HostPath. Defaults to true.</summary>
    [JsonPropertyName("skipNodesWithLocalStorage")]
    public bool? SkipNodesWithLocalStorage { get; set; }

    /// <summary>If true cluster autoscaler will never delete nodes with pods from kube-system (except for DaemonSet or mirror pods). Defaults to true.</summary>
    [JsonPropertyName("skipNodesWithSystemPods")]
    public bool? SkipNodesWithSystemPods { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderAzureActiveDirectoryRoleBasedAccessControl
{
    /// <summary>A list of Object IDs of Azure Active Directory Groups which should have Admin Role on the Cluster.</summary>
    [JsonPropertyName("adminGroupObjectIds")]
    public IList<string>? AdminGroupObjectIds { get; set; }

    /// <summary>Is Role Based Access Control based on Azure AD enabled?</summary>
    [JsonPropertyName("azureRbacEnabled")]
    public bool? AzureRbacEnabled { get; set; }

    /// <summary>The Tenant ID used for Azure Active Directory Application. If this isn't specified the Tenant ID of the current Subscription is used.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderConfidentialComputing
{
    /// <summary>Should the SGX quote helper be enabled?</summary>
    [JsonPropertyName("sgxQuoteHelperEnabled")]
    public bool? SgxQuoteHelperEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderDefaultNodePoolKubeletConfig
{
    /// <summary>Specifies the allow list of unsafe sysctls command or patterns (ending in *).</summary>
    [JsonPropertyName("allowedUnsafeSysctls")]
    public IList<string>? AllowedUnsafeSysctls { get; set; }

    /// <summary>Specifies the maximum number of container log files that can be present for a container. must be at least 2.</summary>
    [JsonPropertyName("containerLogMaxLine")]
    public double? ContainerLogMaxLine { get; set; }

    /// <summary>Specifies the maximum size (e.g. 10MB) of container log file before it is rotated.</summary>
    [JsonPropertyName("containerLogMaxSizeMb")]
    public double? ContainerLogMaxSizeMb { get; set; }

    /// <summary>Is CPU CFS quota enforcement for containers enabled? Defaults to true.</summary>
    [JsonPropertyName("cpuCfsQuotaEnabled")]
    public bool? CpuCfsQuotaEnabled { get; set; }

    /// <summary>Specifies the CPU CFS quota period value.</summary>
    [JsonPropertyName("cpuCfsQuotaPeriod")]
    public string? CpuCfsQuotaPeriod { get; set; }

    /// <summary>Specifies the CPU Manager policy to use. Possible values are none and static,.</summary>
    [JsonPropertyName("cpuManagerPolicy")]
    public string? CpuManagerPolicy { get; set; }

    /// <summary>Specifies the percent of disk usage above which image garbage collection is always run. Must be between 0 and 100.</summary>
    [JsonPropertyName("imageGcHighThreshold")]
    public double? ImageGcHighThreshold { get; set; }

    /// <summary>Specifies the percent of disk usage lower than which image garbage collection is never run. Must be between 0 and 100.</summary>
    [JsonPropertyName("imageGcLowThreshold")]
    public double? ImageGcLowThreshold { get; set; }

    /// <summary>Specifies the maximum number of processes per pod.</summary>
    [JsonPropertyName("podMaxPid")]
    public double? PodMaxPid { get; set; }

    /// <summary>Specifies the Topology Manager policy to use. Possible values are none, best-effort, restricted or single-numa-node.</summary>
    [JsonPropertyName("topologyManagerPolicy")]
    public string? TopologyManagerPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderDefaultNodePoolLinuxOsConfigSysctlConfig
{
    /// <summary>The sysctl setting fs.aio-max-nr. Must be between 65536 and 6553500.</summary>
    [JsonPropertyName("fsAioMaxNr")]
    public double? FsAioMaxNr { get; set; }

    /// <summary>The sysctl setting fs.file-max. Must be between 8192 and 12000500.</summary>
    [JsonPropertyName("fsFileMax")]
    public double? FsFileMax { get; set; }

    /// <summary>The sysctl setting fs.inotify.max_user_watches. Must be between 781250 and 2097152.</summary>
    [JsonPropertyName("fsInotifyMaxUserWatches")]
    public double? FsInotifyMaxUserWatches { get; set; }

    /// <summary>The sysctl setting fs.nr_open. Must be between 8192 and 20000500.</summary>
    [JsonPropertyName("fsNrOpen")]
    public double? FsNrOpen { get; set; }

    /// <summary>The sysctl setting kernel.threads-max. Must be between 20 and 513785.</summary>
    [JsonPropertyName("kernelThreadsMax")]
    public double? KernelThreadsMax { get; set; }

    /// <summary>The sysctl setting net.core.netdev_max_backlog. Must be between 1000 and 3240000.</summary>
    [JsonPropertyName("netCoreNetdevMaxBacklog")]
    public double? NetCoreNetdevMaxBacklog { get; set; }

    /// <summary>The sysctl setting net.core.optmem_max. Must be between 20480 and 4194304.</summary>
    [JsonPropertyName("netCoreOptmemMax")]
    public double? NetCoreOptmemMax { get; set; }

    /// <summary>The sysctl setting net.core.rmem_default. Must be between 212992 and 134217728.</summary>
    [JsonPropertyName("netCoreRmemDefault")]
    public double? NetCoreRmemDefault { get; set; }

    /// <summary>The sysctl setting net.core.rmem_max. Must be between 212992 and 134217728.</summary>
    [JsonPropertyName("netCoreRmemMax")]
    public double? NetCoreRmemMax { get; set; }

    /// <summary>The sysctl setting net.core.somaxconn. Must be between 4096 and 3240000.</summary>
    [JsonPropertyName("netCoreSomaxconn")]
    public double? NetCoreSomaxconn { get; set; }

    /// <summary>The sysctl setting net.core.wmem_default. Must be between 212992 and 134217728.</summary>
    [JsonPropertyName("netCoreWmemDefault")]
    public double? NetCoreWmemDefault { get; set; }

    /// <summary>The sysctl setting net.core.wmem_max. Must be between 212992 and 134217728.</summary>
    [JsonPropertyName("netCoreWmemMax")]
    public double? NetCoreWmemMax { get; set; }

    /// <summary>The sysctl setting net.ipv4.ip_local_port_range max value. Must be between 32768 and 65535.</summary>
    [JsonPropertyName("netIpv4IpLocalPortRangeMax")]
    public double? NetIpv4IpLocalPortRangeMax { get; set; }

    /// <summary>The sysctl setting net.ipv4.ip_local_port_range min value. Must be between 1024 and 60999.</summary>
    [JsonPropertyName("netIpv4IpLocalPortRangeMin")]
    public double? NetIpv4IpLocalPortRangeMin { get; set; }

    /// <summary>The sysctl setting net.ipv4.neigh.default.gc_thresh1. Must be between 128 and 80000.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh1")]
    public double? NetIpv4NeighDefaultGcThresh1 { get; set; }

    /// <summary>The sysctl setting net.ipv4.neigh.default.gc_thresh2. Must be between 512 and 90000.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh2")]
    public double? NetIpv4NeighDefaultGcThresh2 { get; set; }

    /// <summary>The sysctl setting net.ipv4.neigh.default.gc_thresh3. Must be between 1024 and 100000.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh3")]
    public double? NetIpv4NeighDefaultGcThresh3 { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_fin_timeout. Must be between 5 and 120.</summary>
    [JsonPropertyName("netIpv4TcpFinTimeout")]
    public double? NetIpv4TcpFinTimeout { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_keepalive_intvl. Must be between 10 and 90.</summary>
    [JsonPropertyName("netIpv4TcpKeepaliveIntvl")]
    public double? NetIpv4TcpKeepaliveIntvl { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_keepalive_probes. Must be between 1 and 15.</summary>
    [JsonPropertyName("netIpv4TcpKeepaliveProbes")]
    public double? NetIpv4TcpKeepaliveProbes { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_keepalive_time. Must be between 30 and 432000.</summary>
    [JsonPropertyName("netIpv4TcpKeepaliveTime")]
    public double? NetIpv4TcpKeepaliveTime { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_max_syn_backlog. Must be between 128 and 3240000.</summary>
    [JsonPropertyName("netIpv4TcpMaxSynBacklog")]
    public double? NetIpv4TcpMaxSynBacklog { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_max_tw_buckets. Must be between 8000 and 1440000.</summary>
    [JsonPropertyName("netIpv4TcpMaxTwBuckets")]
    public double? NetIpv4TcpMaxTwBuckets { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_tw_reuse.</summary>
    [JsonPropertyName("netIpv4TcpTwReuse")]
    public bool? NetIpv4TcpTwReuse { get; set; }

    /// <summary>The sysctl setting net.netfilter.nf_conntrack_buckets. Must be between 65536 and 524288.</summary>
    [JsonPropertyName("netNetfilterNfConntrackBuckets")]
    public double? NetNetfilterNfConntrackBuckets { get; set; }

    /// <summary>The sysctl setting net.netfilter.nf_conntrack_max. Must be between 131072 and 2097152.</summary>
    [JsonPropertyName("netNetfilterNfConntrackMax")]
    public double? NetNetfilterNfConntrackMax { get; set; }

    /// <summary>The sysctl setting vm.max_map_count. Must be between 65530 and 262144.</summary>
    [JsonPropertyName("vmMaxMapCount")]
    public double? VmMaxMapCount { get; set; }

    /// <summary>The sysctl setting vm.swappiness. Must be between 0 and 100.</summary>
    [JsonPropertyName("vmSwappiness")]
    public double? VmSwappiness { get; set; }

    /// <summary>The sysctl setting vm.vfs_cache_pressure. Must be between 0 and 100.</summary>
    [JsonPropertyName("vmVfsCachePressure")]
    public double? VmVfsCachePressure { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderDefaultNodePoolLinuxOsConfig
{
    /// <summary>Specifies the size of the swap file on each node in MB.</summary>
    [JsonPropertyName("swapFileSizeMb")]
    public double? SwapFileSizeMb { get; set; }

    /// <summary>A sysctl_config block as defined below.</summary>
    [JsonPropertyName("sysctlConfig")]
    public IList<V1beta1KubernetesClusterStatusAtProviderDefaultNodePoolLinuxOsConfigSysctlConfig>? SysctlConfig { get; set; }

    /// <summary>specifies the defrag configuration for Transparent Huge Page. Possible values are always, defer, defer+madvise, madvise and never.</summary>
    [JsonPropertyName("transparentHugePageDefrag")]
    public string? TransparentHugePageDefrag { get; set; }

    /// <summary>Specifies the Transparent Huge Page enabled configuration. Possible values are always, madvise and never.</summary>
    [JsonPropertyName("transparentHugePageEnabled")]
    public string? TransparentHugePageEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderDefaultNodePoolNodeNetworkProfileAllowedHostPorts
{
    /// <summary>Specifies the end of the port range.</summary>
    [JsonPropertyName("portEnd")]
    public double? PortEnd { get; set; }

    /// <summary>Specifies the start of the port range.</summary>
    [JsonPropertyName("portStart")]
    public double? PortStart { get; set; }

    /// <summary>Specifies the protocol of the port range. Possible values are TCP and UDP.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderDefaultNodePoolNodeNetworkProfile
{
    /// <summary>One or more allowed_host_ports blocks as defined below.</summary>
    [JsonPropertyName("allowedHostPorts")]
    public IList<V1beta1KubernetesClusterStatusAtProviderDefaultNodePoolNodeNetworkProfileAllowedHostPorts>? AllowedHostPorts { get; set; }

    /// <summary>A list of Application Security Group IDs which should be associated with this Node Pool.</summary>
    [JsonPropertyName("applicationSecurityGroupIds")]
    public IList<string>? ApplicationSecurityGroupIds { get; set; }

    /// <summary>Specifies a mapping of tags to the instance-level public IPs. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("nodePublicIpTags")]
    public IDictionary<string, string>? NodePublicIpTags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderDefaultNodePoolUpgradeSettings
{
    /// <summary>The amount of time in minutes to wait on eviction of pods and graceful termination per node. This eviction wait time honors pod disruption budgets for upgrades. If this time is exceeded, the upgrade fails. Unsetting this after configuring it will force a new resource to be created.</summary>
    [JsonPropertyName("drainTimeoutInMinutes")]
    public double? DrainTimeoutInMinutes { get; set; }

    /// <summary>The maximum number or percentage of nodes which will be added to the Node Pool size during an upgrade.</summary>
    [JsonPropertyName("maxSurge")]
    public string? MaxSurge { get; set; }

    /// <summary>The amount of time in minutes to wait after draining a node and before reimaging and moving on to next node. Defaults to 0.</summary>
    [JsonPropertyName("nodeSoakDurationInMinutes")]
    public double? NodeSoakDurationInMinutes { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderDefaultNodePool
{
    /// <summary>Should the Kubernetes Auto Scaler be enabled for this Node Pool?</summary>
    [JsonPropertyName("autoScalingEnabled")]
    public bool? AutoScalingEnabled { get; set; }

    /// <summary>Specifies the ID of the Capacity Reservation Group within which this AKS Cluster should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("capacityReservationGroupId")]
    public string? CapacityReservationGroupId { get; set; }

    /// <summary>Should the nodes in this Node Pool have Federal Information Processing Standard enabled? temporary_name_for_rotation must be specified when changing this block. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("fipsEnabled")]
    public bool? FipsEnabled { get; set; }

    /// <summary>Specifies the GPU MIG instance profile for supported GPU VM SKU. The allowed values are MIG1g, MIG2g, MIG3g, MIG4g and MIG7g. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("gpuInstance")]
    public string? GpuInstance { get; set; }

    /// <summary>Should the nodes in the Default Node Pool have host encryption enabled? temporary_name_for_rotation must be specified when changing this property.</summary>
    [JsonPropertyName("hostEncryptionEnabled")]
    public bool? HostEncryptionEnabled { get; set; }

    /// <summary>Specifies the ID of the Host Group within which this AKS Cluster should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hostGroupId")]
    public string? HostGroupId { get; set; }

    /// <summary>A kubelet_config block as defined below. temporary_name_for_rotation must be specified when changing this block.</summary>
    [JsonPropertyName("kubeletConfig")]
    public IList<V1beta1KubernetesClusterStatusAtProviderDefaultNodePoolKubeletConfig>? KubeletConfig { get; set; }

    /// <summary>The type of disk used by kubelet. Possible values are OS and Temporary. temporary_name_for_rotation must be specified when changing this block.</summary>
    [JsonPropertyName("kubeletDiskType")]
    public string? KubeletDiskType { get; set; }

    /// <summary>A linux_os_config block as defined below. temporary_name_for_rotation must be specified when changing this block.</summary>
    [JsonPropertyName("linuxOsConfig")]
    public IList<V1beta1KubernetesClusterStatusAtProviderDefaultNodePoolLinuxOsConfig>? LinuxOsConfig { get; set; }

    /// <summary>The maximum number of nodes which should exist in this Node Pool. If specified this must be between 1 and 1000.</summary>
    [JsonPropertyName("maxCount")]
    public double? MaxCount { get; set; }

    /// <summary>The maximum number of pods that can run on each agent. temporary_name_for_rotation must be specified when changing this property.</summary>
    [JsonPropertyName("maxPods")]
    public double? MaxPods { get; set; }

    /// <summary>The minimum number of nodes which should exist in this Node Pool. If specified this must be between 1 and 1000.</summary>
    [JsonPropertyName("minCount")]
    public double? MinCount { get; set; }

    /// <summary>The name which should be used for the default Kubernetes Node Pool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The initial number of nodes which should exist in this Node Pool. If specified this must be between 1 and 1000 and between min_count and max_count.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>A map of Kubernetes labels which should be applied to nodes in the Default Node Pool.</summary>
    [JsonPropertyName("nodeLabels")]
    public IDictionary<string, string>? NodeLabels { get; set; }

    /// <summary>A node_network_profile block as documented below.</summary>
    [JsonPropertyName("nodeNetworkProfile")]
    public IList<V1beta1KubernetesClusterStatusAtProviderDefaultNodePoolNodeNetworkProfile>? NodeNetworkProfile { get; set; }

    /// <summary>Should nodes in this Node Pool have a Public IP Address? temporary_name_for_rotation must be specified when changing this property.</summary>
    [JsonPropertyName("nodePublicIpEnabled")]
    public bool? NodePublicIpEnabled { get; set; }

    /// <summary>Resource ID for the Public IP Addresses Prefix for the nodes in this Node Pool. node_public_ip_enabled should be true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("nodePublicIpPrefixId")]
    public string? NodePublicIpPrefixId { get; set; }

    /// <summary>Enabling this option will taint default node pool with CriticalAddonsOnly=true:NoSchedule taint. temporary_name_for_rotation must be specified when changing this property.</summary>
    [JsonPropertyName("onlyCriticalAddonsEnabled")]
    public bool? OnlyCriticalAddonsEnabled { get; set; }

    /// <summary>Version of Kubernetes used for the Agents. If not specified, the default node pool will be created with the version specified by kubernetes_version. If both are unspecified, the latest recommended version will be used at provisioning time (but won't auto-upgrade). AKS does not require an exact patch version to be specified, minor version aliases such as 1.22 are also supported. - The minor version's latest GA patch is automatically chosen in that case. More details can be found in the documentation.</summary>
    [JsonPropertyName("orchestratorVersion")]
    public string? OrchestratorVersion { get; set; }

    /// <summary>The size of the OS Disk which should be used for each agent in the Node Pool. temporary_name_for_rotation must be specified when attempting a change.</summary>
    [JsonPropertyName("osDiskSizeGb")]
    public double? OsDiskSizeGb { get; set; }

    /// <summary>The type of disk which should be used for the Operating System. Possible values are Ephemeral and Managed. Defaults to Managed. temporary_name_for_rotation must be specified when attempting a change.</summary>
    [JsonPropertyName("osDiskType")]
    public string? OsDiskType { get; set; }

    /// <summary>Specifies the OS SKU used by the agent pool. Possible values are AzureLinux, Ubuntu, Windows2019 and Windows2022. If not specified, the default is Ubuntu if OSType=Linux or Windows2019 if OSType=Windows. And the default Windows OSSKU will be changed to Windows2022 after Windows2019 is deprecated. Changing this from AzureLinux or Ubuntu to AzureLinux or Ubuntu will not replace the resource, otherwise temporary_name_for_rotation must be specified when attempting a change.</summary>
    [JsonPropertyName("osSku")]
    public string? OsSku { get; set; }

    /// <summary>The ID of the Subnet where the pods in the default Node Pool should exist.</summary>
    [JsonPropertyName("podSubnetId")]
    public string? PodSubnetId { get; set; }

    /// <summary>The ID of the Proximity Placement Group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("proximityPlacementGroupId")]
    public string? ProximityPlacementGroupId { get; set; }

    /// <summary>Specifies the autoscaling behaviour of the Kubernetes Cluster. Allowed values are Delete and Deallocate. Defaults to Delete.</summary>
    [JsonPropertyName("scaleDownMode")]
    public string? ScaleDownMode { get; set; }

    /// <summary>The ID of the Snapshot which should be used to create this default Node Pool. temporary_name_for_rotation must be specified when changing this property.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>A mapping of tags to assign to the Node Pool.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the name of the temporary node pool used to cycle the default node pool for VM resizing.</summary>
    [JsonPropertyName("temporaryNameForRotation")]
    public string? TemporaryNameForRotation { get; set; }

    /// <summary>The type of Node Pool which should be created. Possible values are VirtualMachineScaleSets. Defaults to VirtualMachineScaleSets. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Used to specify whether the UltraSSD is enabled in the Default Node Pool. Defaults to false. See the documentation for more information. temporary_name_for_rotation must be specified when attempting a change.</summary>
    [JsonPropertyName("ultraSsdEnabled")]
    public bool? UltraSsdEnabled { get; set; }

    /// <summary>A upgrade_settings block as documented below.</summary>
    [JsonPropertyName("upgradeSettings")]
    public IList<V1beta1KubernetesClusterStatusAtProviderDefaultNodePoolUpgradeSettings>? UpgradeSettings { get; set; }

    /// <summary>The size of the Virtual Machine, such as Standard_DS2_v2. temporary_name_for_rotation must be specified when attempting a resize.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }

    /// <summary>The ID of a Subnet where the Kubernetes Node Pool should exist.</summary>
    [JsonPropertyName("vnetSubnetId")]
    public string? VnetSubnetId { get; set; }

    /// <summary>Specifies the workload runtime used by the node pool. Possible value is OCIContainer.</summary>
    [JsonPropertyName("workloadRuntime")]
    public string? WorkloadRuntime { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this Kubernetes Cluster should be located. temporary_name_for_rotation must be specified when changing this property.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderHttpProxyConfig
{
    /// <summary>The proxy address to be used when communicating over HTTP.</summary>
    [JsonPropertyName("httpProxy")]
    public string? HttpProxy { get; set; }

    /// <summary>The proxy address to be used when communicating over HTTPS.</summary>
    [JsonPropertyName("httpsProxy")]
    public string? HttpsProxy { get; set; }

    /// <summary>The list of domains that will not use the proxy for communication.</summary>
    [JsonPropertyName("noProxy")]
    public IList<string>? NoProxy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Kubernetes Cluster.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Kubernetes Cluster. Possible values are SystemAssigned or UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderIngressApplicationGatewayIngressApplicationGatewayIdentity
{
    /// <summary>The Client ID of the user-defined Managed Identity used for Web App Routing.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The Object ID of the user-defined Managed Identity used for Web App Routing</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>The ID of the User Assigned Identity used for Web App Routing.</summary>
    [JsonPropertyName("userAssignedIdentityId")]
    public string? UserAssignedIdentityId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderIngressApplicationGateway
{
    /// <summary>The ID of the Application Gateway associated with the ingress controller deployed to this Kubernetes Cluster.</summary>
    [JsonPropertyName("effectiveGatewayId")]
    public string? EffectiveGatewayId { get; set; }

    /// <summary>The ID of the Application Gateway to integrate with the ingress controller of this Kubernetes Cluster. See this page for further details.</summary>
    [JsonPropertyName("gatewayId")]
    public string? GatewayId { get; set; }

    /// <summary>The name of the Application Gateway to be used or created in the Nodepool Resource Group, which in turn will be integrated with the ingress controller of this Kubernetes Cluster. See this page for further details.</summary>
    [JsonPropertyName("gatewayName")]
    public string? GatewayName { get; set; }

    /// <summary>An ingress_application_gateway_identity block is exported. The exported attributes are defined below.</summary>
    [JsonPropertyName("ingressApplicationGatewayIdentity")]
    public IList<V1beta1KubernetesClusterStatusAtProviderIngressApplicationGatewayIngressApplicationGatewayIdentity>? IngressApplicationGatewayIdentity { get; set; }

    /// <summary>The subnet CIDR to be used to create an Application Gateway, which in turn will be integrated with the ingress controller of this Kubernetes Cluster. See this page for further details.</summary>
    [JsonPropertyName("subnetCidr")]
    public string? SubnetCidr { get; set; }

    /// <summary>The ID of the subnet on which to create an Application Gateway, which in turn will be integrated with the ingress controller of this Kubernetes Cluster. See this page for further details.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderKeyManagementService
{
    /// <summary>Identifier of Azure Key Vault key. See key identifier format for more details.</summary>
    [JsonPropertyName("keyVaultKeyId")]
    public string? KeyVaultKeyId { get; set; }

    /// <summary>Network access of the key vault Network access of key vault. The possible values are Public and Private. Public means the key vault allows public access from all networks. Private means the key vault disables public access and enables private link. Defaults to Public.</summary>
    [JsonPropertyName("keyVaultNetworkAccess")]
    public string? KeyVaultNetworkAccess { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderKeyVaultSecretsProviderSecretIdentity
{
    /// <summary>The Client ID of the user-defined Managed Identity used by the Secret Provider.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The Object ID of the user-defined Managed Identity used by the Secret Provider.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>The ID of the User Assigned Identity used by the Secret Provider.</summary>
    [JsonPropertyName("userAssignedIdentityId")]
    public string? UserAssignedIdentityId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderKeyVaultSecretsProvider
{
    /// <summary>An secret_identity block is exported. The exported attributes are defined below.</summary>
    [JsonPropertyName("secretIdentity")]
    public IList<V1beta1KubernetesClusterStatusAtProviderKeyVaultSecretsProviderSecretIdentity>? SecretIdentity { get; set; }

    /// <summary>Should the secret store CSI driver on the AKS cluster be enabled?</summary>
    [JsonPropertyName("secretRotationEnabled")]
    public bool? SecretRotationEnabled { get; set; }

    /// <summary>The interval to poll for secret rotation. This attribute is only set when secret_rotation_enabled is true. Defaults to 2m.</summary>
    [JsonPropertyName("secretRotationInterval")]
    public string? SecretRotationInterval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderKubeletIdentity
{
    /// <summary>The Client ID of the user-defined Managed Identity to be assigned to the Kubelets. If not specified a Managed Identity is created automatically. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The Object ID of the user-defined Managed Identity assigned to the Kubelets.If not specified a Managed Identity is created automatically. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>The ID of the User Assigned Identity assigned to the Kubelets. If not specified a Managed Identity is created automatically. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("userAssignedIdentityId")]
    public string? UserAssignedIdentityId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderLinuxProfileSshKey
{
    /// <summary>The Public SSH Key used to access the cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("keyData")]
    public string? KeyData { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderLinuxProfile
{
    /// <summary>The Admin Username for the Cluster. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>An ssh_key block as defined below. Only one is currently allowed. Changing this will update the key on all node pools. More information can be found in the documentation.</summary>
    [JsonPropertyName("sshKey")]
    public IList<V1beta1KubernetesClusterStatusAtProviderLinuxProfileSshKey>? SshKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderMaintenanceWindowAllowed
{
    /// <summary>A day in a week. Possible values are Sunday, Monday, Tuesday, Wednesday, Thursday, Friday and Saturday.</summary>
    [JsonPropertyName("day")]
    public string? Day { get; set; }

    /// <summary>An array of hour slots in a day. For example, specifying 1 will allow maintenance from 1:00am to 2:00am. Specifying 1, 2 will allow maintenance from 1:00am to 3:00m. Possible values are between 0 and 23.</summary>
    [JsonPropertyName("hours")]
    public IList<double>? Hours { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderMaintenanceWindowNotAllowed
{
    /// <summary>The end of a time span, formatted as an RFC3339 string.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>The start of a time span, formatted as an RFC3339 string.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderMaintenanceWindow
{
    /// <summary>One or more allowed blocks as defined below.</summary>
    [JsonPropertyName("allowed")]
    public IList<V1beta1KubernetesClusterStatusAtProviderMaintenanceWindowAllowed>? Allowed { get; set; }

    /// <summary>One or more not_allowed block as defined below.</summary>
    [JsonPropertyName("notAllowed")]
    public IList<V1beta1KubernetesClusterStatusAtProviderMaintenanceWindowNotAllowed>? NotAllowed { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderMaintenanceWindowAutoUpgradeNotAllowed
{
    /// <summary>The end of a time span, formatted as an RFC3339 string.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>The start of a time span, formatted as an RFC3339 string.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderMaintenanceWindowAutoUpgrade
{
    /// <summary>The day of the month for the maintenance run. Required in combination with AbsoluteMonthly frequency. Value between 0 and 31 (inclusive).</summary>
    [JsonPropertyName("dayOfMonth")]
    public double? DayOfMonth { get; set; }

    /// <summary>The day of the week for the maintenance run. Required in combination with weekly frequency. Possible values are Friday, Monday, Saturday, Sunday, Thursday, Tuesday and Wednesday.</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>The duration of the window for maintenance to run in hours. Possible options are between 4 to 24.</summary>
    [JsonPropertyName("duration")]
    public double? Duration { get; set; }

    /// <summary>Frequency of maintenance. Possible options are Weekly, AbsoluteMonthly and RelativeMonthly.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>The interval for maintenance runs. Depending on the frequency this interval is week or month based.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>One or more not_allowed block as defined below.</summary>
    [JsonPropertyName("notAllowed")]
    public IList<V1beta1KubernetesClusterStatusAtProviderMaintenanceWindowAutoUpgradeNotAllowed>? NotAllowed { get; set; }

    /// <summary>The date on which the maintenance window begins to take effect.</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }

    /// <summary>The time for maintenance to begin, based on the timezone determined by utc_offset. Format is HH:mm.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Used to determine the timezone for cluster maintenance.</summary>
    [JsonPropertyName("utcOffset")]
    public string? UtcOffset { get; set; }

    /// <summary>Specifies on which instance of the allowed days specified in day_of_week the maintenance occurs. Options are First, Second, Third, Fourth, and Last. Required in combination with relative monthly frequency.</summary>
    [JsonPropertyName("weekIndex")]
    public string? WeekIndex { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderMaintenanceWindowNodeOsNotAllowed
{
    /// <summary>The end of a time span, formatted as an RFC3339 string.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>The start of a time span, formatted as an RFC3339 string.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderMaintenanceWindowNodeOs
{
    /// <summary>The day of the month for the maintenance run. Required in combination with AbsoluteMonthly frequency. Value between 0 and 31 (inclusive).</summary>
    [JsonPropertyName("dayOfMonth")]
    public double? DayOfMonth { get; set; }

    /// <summary>The day of the week for the maintenance run. Required in combination with weekly frequency. Possible values are Friday, Monday, Saturday, Sunday, Thursday, Tuesday and Wednesday.</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>The duration of the window for maintenance to run in hours. Possible options are between 4 to 24.</summary>
    [JsonPropertyName("duration")]
    public double? Duration { get; set; }

    /// <summary>Frequency of maintenance. Possible options are Daily, Weekly, AbsoluteMonthly and RelativeMonthly.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>The interval for maintenance runs. Depending on the frequency this interval is week or month based.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>One or more not_allowed block as defined below.</summary>
    [JsonPropertyName("notAllowed")]
    public IList<V1beta1KubernetesClusterStatusAtProviderMaintenanceWindowNodeOsNotAllowed>? NotAllowed { get; set; }

    /// <summary>The date on which the maintenance window begins to take effect.</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }

    /// <summary>The time for maintenance to begin, based on the timezone determined by utc_offset. Format is HH:mm.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Used to determine the timezone for cluster maintenance.</summary>
    [JsonPropertyName("utcOffset")]
    public string? UtcOffset { get; set; }

    /// <summary>The week in the month used for the maintenance run. Options are First, Second, Third, Fourth, and Last.</summary>
    [JsonPropertyName("weekIndex")]
    public string? WeekIndex { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderMicrosoftDefender
{
    /// <summary>Specifies the ID of the Log Analytics Workspace where the audit logs collected by Microsoft Defender should be sent to.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderMonitorMetrics
{
    /// <summary>Specifies a comma-separated list of Kubernetes annotation keys that will be used in the resource's labels metric.</summary>
    [JsonPropertyName("annotationsAllowed")]
    public string? AnnotationsAllowed { get; set; }

    /// <summary>Specifies a Comma-separated list of additional Kubernetes label keys that will be used in the resource's labels metric.</summary>
    [JsonPropertyName("labelsAllowed")]
    public string? LabelsAllowed { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderNetworkProfileLoadBalancerProfile
{
    /// <summary>The type of the managed inbound Load Balancer Backend Pool. Possible values are NodeIP and NodeIPConfiguration. Defaults to NodeIPConfiguration. See the documentation for more information.</summary>
    [JsonPropertyName("backendPoolType")]
    public string? BackendPoolType { get; set; }

    /// <summary>The outcome (resource IDs) of the specified arguments.</summary>
    [JsonPropertyName("effectiveOutboundIps")]
    public IList<string>? EffectiveOutboundIps { get; set; }

    /// <summary>Desired outbound flow idle timeout in minutes for the managed nat gateway. Must be between 4 and 120 inclusive. Defaults to 4.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>Count of desired managed outbound IPs for the managed nat gateway. Must be between 1 and 16 inclusive.</summary>
    [JsonPropertyName("managedOutboundIpCount")]
    public double? ManagedOutboundIpCount { get; set; }

    /// <summary>The desired number of IPv6 outbound IPs created and managed by Azure for the cluster load balancer. Must be in the range of 1 to 100 (inclusive). The default value is 0 for single-stack and 1 for dual-stack.</summary>
    [JsonPropertyName("managedOutboundIpv6Count")]
    public double? ManagedOutboundIpv6Count { get; set; }

    /// <summary>The ID of the Public IP Addresses which should be used for outbound communication for the cluster load balancer.</summary>
    [JsonPropertyName("outboundIpAddressIds")]
    public IList<string>? OutboundIpAddressIds { get; set; }

    /// <summary>The ID of the outbound Public IP Address Prefixes which should be used for the cluster load balancer.</summary>
    [JsonPropertyName("outboundIpPrefixIds")]
    public IList<string>? OutboundIpPrefixIds { get; set; }

    /// <summary>Number of desired SNAT port for each VM in the clusters load balancer. Must be between 0 and 64000 inclusive. Defaults to 0.</summary>
    [JsonPropertyName("outboundPortsAllocated")]
    public double? OutboundPortsAllocated { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderNetworkProfileNatGatewayProfile
{
    /// <summary>The outcome (resource IDs) of the specified arguments.</summary>
    [JsonPropertyName("effectiveOutboundIps")]
    public IList<string>? EffectiveOutboundIps { get; set; }

    /// <summary>Desired outbound flow idle timeout in minutes for the managed nat gateway. Must be between 4 and 120 inclusive. Defaults to 4.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>Count of desired managed outbound IPs for the managed nat gateway. Must be between 1 and 16 inclusive.</summary>
    [JsonPropertyName("managedOutboundIpCount")]
    public double? ManagedOutboundIpCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderNetworkProfile
{
    /// <summary>IP address within the Kubernetes service address range that will be used by cluster service discovery (kube-dns). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dnsServiceIp")]
    public string? DnsServiceIp { get; set; }

    /// <summary>Specifies a list of IP versions the Kubernetes Cluster will use to assign IP addresses to its nodes and pods. Possible values are IPv4 and/or IPv6. IPv4 must always be specified. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ipVersions")]
    public IList<string>? IpVersions { get; set; }

    /// <summary>A load_balancer_profile block as defined below. This can only be specified when load_balancer_sku is set to standard. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("loadBalancerProfile")]
    public IList<V1beta1KubernetesClusterStatusAtProviderNetworkProfileLoadBalancerProfile>? LoadBalancerProfile { get; set; }

    /// <summary>Specifies the SKU of the Load Balancer used for this Kubernetes Cluster. Possible values are basic and standard. Defaults to standard. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("loadBalancerSku")]
    public string? LoadBalancerSku { get; set; }

    /// <summary>A nat_gateway_profile block as defined below. This can only be specified when load_balancer_sku is set to standard and outbound_type is set to managedNATGateway or userAssignedNATGateway. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("natGatewayProfile")]
    public IList<V1beta1KubernetesClusterStatusAtProviderNetworkProfileNatGatewayProfile>? NatGatewayProfile { get; set; }

    /// <summary>Specifies the data plane used for building the Kubernetes network. Possible values are azure and cilium. Defaults to azure. Disabling this forces a new resource to be created.</summary>
    [JsonPropertyName("networkDataPlane")]
    public string? NetworkDataPlane { get; set; }

    /// <summary>Network mode to be used with Azure CNI. Possible values are bridge and transparent. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("networkMode")]
    public string? NetworkMode { get; set; }

    /// <summary>Network plugin to use for networking. Currently supported values are azure, kubenet and none. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("networkPlugin")]
    public string? NetworkPlugin { get; set; }

    /// <summary>Specifies the network plugin mode used for building the Kubernetes network. Possible value is overlay.</summary>
    [JsonPropertyName("networkPluginMode")]
    public string? NetworkPluginMode { get; set; }

    /// <summary>Sets up network policy to be used with Azure CNI. Network policy allows us to control the traffic flow between pods. Currently supported values are calico, azure and cilium.</summary>
    [JsonPropertyName("networkPolicy")]
    public string? NetworkPolicy { get; set; }

    /// <summary>The outbound (egress) routing method which should be used for this Kubernetes Cluster. Possible values are loadBalancer, userDefinedRouting, managedNATGateway and userAssignedNATGateway. Defaults to loadBalancer. More information on supported migration paths for outbound_type can be found in this documentation.</summary>
    [JsonPropertyName("outboundType")]
    public string? OutboundType { get; set; }

    /// <summary>The CIDR to use for pod IP addresses. This field can only be set when network_plugin is set to kubenet or network_plugin_mode is set to overlay. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("podCidr")]
    public string? PodCidr { get; set; }

    /// <summary>A list of CIDRs to use for pod IP addresses. For single-stack networking a single IPv4 CIDR is expected. For dual-stack networking an IPv4 and IPv6 CIDR are expected. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("podCidrs")]
    public IList<string>? PodCidrs { get; set; }

    /// <summary>The Network Range used by the Kubernetes service. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("serviceCidr")]
    public string? ServiceCidr { get; set; }

    /// <summary>A list of CIDRs to use for Kubernetes services. For single-stack networking a single IPv4 CIDR is expected. For dual-stack networking an IPv4 and IPv6 CIDR are expected. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("serviceCidrs")]
    public IList<string>? ServiceCidrs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderOmsAgentOmsAgentIdentity
{
    /// <summary>The Client ID of the user-defined Managed Identity used by the OMS Agents.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The Object ID of the user-defined Managed Identity used by the OMS Agents.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>The ID of the User Assigned Identity used by the OMS Agents.</summary>
    [JsonPropertyName("userAssignedIdentityId")]
    public string? UserAssignedIdentityId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderOmsAgent
{
    /// <summary>The ID of the Log Analytics Workspace which the OMS Agent should send data to.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceId")]
    public string? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>Is managed identity authentication for monitoring enabled?</summary>
    [JsonPropertyName("msiAuthForMonitoringEnabled")]
    public bool? MsiAuthForMonitoringEnabled { get; set; }

    /// <summary>An oms_agent_identity block is exported. The exported attributes are defined below.</summary>
    [JsonPropertyName("omsAgentIdentity")]
    public IList<V1beta1KubernetesClusterStatusAtProviderOmsAgentOmsAgentIdentity>? OmsAgentIdentity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderServiceMeshProfileCertificateAuthority
{
    /// <summary>The certificate chain object name in Azure Key Vault.</summary>
    [JsonPropertyName("certChainObjectName")]
    public string? CertChainObjectName { get; set; }

    /// <summary>The intermediate certificate object name in Azure Key Vault.</summary>
    [JsonPropertyName("certObjectName")]
    public string? CertObjectName { get; set; }

    /// <summary>The intermediate certificate private key object name in Azure Key Vault.</summary>
    [JsonPropertyName("keyObjectName")]
    public string? KeyObjectName { get; set; }

    /// <summary>The resource ID of the Key Vault.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>The root certificate object name in Azure Key Vault.</summary>
    [JsonPropertyName("rootCertObjectName")]
    public string? RootCertObjectName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderServiceMeshProfile
{
    /// <summary>A certificate_authority block as defined below. When this property is specified, key_vault_secrets_provider is also required to be set. This configuration allows you to bring your own root certificate and keys for Istio CA in the Istio-based service mesh add-on for Azure Kubernetes Service.</summary>
    [JsonPropertyName("certificateAuthority")]
    public IList<V1beta1KubernetesClusterStatusAtProviderServiceMeshProfileCertificateAuthority>? CertificateAuthority { get; set; }

    /// <summary>Is Istio External Ingress Gateway enabled?</summary>
    [JsonPropertyName("externalIngressGatewayEnabled")]
    public bool? ExternalIngressGatewayEnabled { get; set; }

    /// <summary>Is Istio Internal Ingress Gateway enabled?</summary>
    [JsonPropertyName("internalIngressGatewayEnabled")]
    public bool? InternalIngressGatewayEnabled { get; set; }

    /// <summary>The mode of the service mesh. Possible value is Istio.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Specify 1 or 2 Istio control plane revisions for managing minor upgrades using the canary upgrade process. For example, create the resource with revisions set to ["asm-1-20"], or leave it empty (the revisions will only be known after apply). To start the canary upgrade, change revisions to ["asm-1-20", "asm-1-21"]. To roll back the canary upgrade, revert to ["asm-1-20"]. To confirm the upgrade, change to ["asm-1-21"].</summary>
    [JsonPropertyName("revisions")]
    public IList<string>? Revisions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderServicePrincipal
{
    /// <summary>The Client ID for the Service Principal.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderStorageProfile
{
    /// <summary>Is the Blob CSI driver enabled? Defaults to false.</summary>
    [JsonPropertyName("blobDriverEnabled")]
    public bool? BlobDriverEnabled { get; set; }

    /// <summary>Is the Disk CSI driver enabled? Defaults to true.</summary>
    [JsonPropertyName("diskDriverEnabled")]
    public bool? DiskDriverEnabled { get; set; }

    /// <summary>Is the File CSI driver enabled? Defaults to true.</summary>
    [JsonPropertyName("fileDriverEnabled")]
    public bool? FileDriverEnabled { get; set; }

    /// <summary>Is the Snapshot Controller enabled? Defaults to true.</summary>
    [JsonPropertyName("snapshotControllerEnabled")]
    public bool? SnapshotControllerEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderUpgradeOverride
{
    /// <summary>Specifies the duration, in RFC 3339 format (e.g., 2025-10-01T13:00:00Z), the upgrade_override values are effective. This field must be set for the upgrade_override values to take effect. The date-time must be within the next 30 days.</summary>
    [JsonPropertyName("effectiveUntil")]
    public string? EffectiveUntil { get; set; }

    /// <summary>Whether to force upgrade the cluster. Possible values are true or false.</summary>
    [JsonPropertyName("forceUpgradeEnabled")]
    public bool? ForceUpgradeEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderWebAppRoutingWebAppRoutingIdentity
{
    /// <summary>The Client ID of the user-defined Managed Identity used for Web App Routing.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>The Object ID of the user-defined Managed Identity used for Web App Routing</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>The ID of the User Assigned Identity used for Web App Routing.</summary>
    [JsonPropertyName("userAssignedIdentityId")]
    public string? UserAssignedIdentityId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderWebAppRouting
{
    /// <summary>Specifies the list of the DNS Zone IDs in which DNS entries are created for applications deployed to the cluster when Web App Routing is enabled. If not using Bring-Your-Own DNS zones this property should be set to an empty list.</summary>
    [JsonPropertyName("dnsZoneIds")]
    public IList<string>? DnsZoneIds { get; set; }

    /// <summary>A web_app_routing_identity block is exported. The exported attributes are defined below.</summary>
    [JsonPropertyName("webAppRoutingIdentity")]
    public IList<V1beta1KubernetesClusterStatusAtProviderWebAppRoutingWebAppRoutingIdentity>? WebAppRoutingIdentity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderWindowsProfileGmsa
{
    /// <summary>Specifies the DNS server for Windows gMSA. Set this to an empty string if you have configured the DNS server in the VNet which was used to create the managed cluster.</summary>
    [JsonPropertyName("dnsServer")]
    public string? DnsServer { get; set; }

    /// <summary>Specifies the root domain name for Windows gMSA. Set this to an empty string if you have configured the DNS server in the VNet which was used to create the managed cluster.</summary>
    [JsonPropertyName("rootDomain")]
    public string? RootDomain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderWindowsProfile
{
    /// <summary>The Admin Username for Windows VMs. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>A gmsa block as defined below.</summary>
    [JsonPropertyName("gmsa")]
    public IList<V1beta1KubernetesClusterStatusAtProviderWindowsProfileGmsa>? Gmsa { get; set; }

    /// <summary>Specifies the type of on-premise license which should be used for Node Pool Windows Virtual Machine. At this time the only possible value is Windows_Server.</summary>
    [JsonPropertyName("license")]
    public string? License { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProviderWorkloadAutoscalerProfile
{
    /// <summary>Specifies whether KEDA Autoscaler can be used for workloads.</summary>
    [JsonPropertyName("kedaEnabled")]
    public bool? KedaEnabled { get; set; }

    /// <summary>Specifies whether Vertical Pod Autoscaler should be enabled.</summary>
    [JsonPropertyName("verticalPodAutoscalerEnabled")]
    public bool? VerticalPodAutoscalerEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusAtProvider
{
    /// <summary>A aci_connector_linux block as defined below. For more details, please visit Create and configure an AKS cluster to use virtual nodes.</summary>
    [JsonPropertyName("aciConnectorLinux")]
    public IList<V1beta1KubernetesClusterStatusAtProviderAciConnectorLinux>? AciConnectorLinux { get; set; }

    /// <summary>An api_server_access_profile block as defined below.</summary>
    [JsonPropertyName("apiServerAccessProfile")]
    public IList<V1beta1KubernetesClusterStatusAtProviderApiServerAccessProfile>? ApiServerAccessProfile { get; set; }

    /// <summary>A auto_scaler_profile block as defined below.</summary>
    [JsonPropertyName("autoScalerProfile")]
    public IList<V1beta1KubernetesClusterStatusAtProviderAutoScalerProfile>? AutoScalerProfile { get; set; }

    /// <summary>The upgrade channel for this Kubernetes Cluster. Possible values are patch, rapid, node-image and stable. Omitting this field sets this value to none.</summary>
    [JsonPropertyName("automaticUpgradeChannel")]
    public string? AutomaticUpgradeChannel { get; set; }

    /// <summary>A azure_active_directory_role_based_access_control block as defined below.</summary>
    [JsonPropertyName("azureActiveDirectoryRoleBasedAccessControl")]
    public IList<V1beta1KubernetesClusterStatusAtProviderAzureActiveDirectoryRoleBasedAccessControl>? AzureActiveDirectoryRoleBasedAccessControl { get; set; }

    /// <summary>Should the Azure Policy Add-On be enabled? For more details please visit Understand Azure Policy for Azure Kubernetes Service</summary>
    [JsonPropertyName("azurePolicyEnabled")]
    public bool? AzurePolicyEnabled { get; set; }

    /// <summary>A confidential_computing block as defined below. For more details please the documentation</summary>
    [JsonPropertyName("confidentialComputing")]
    public IList<V1beta1KubernetesClusterStatusAtProviderConfidentialComputing>? ConfidentialComputing { get; set; }

    /// <summary>Should cost analysis be enabled for this Kubernetes Cluster? Defaults to false. The sku_tier must be set to Standard or Premium to enable this feature. Enabling this will add Kubernetes Namespace and Deployment details to the Cost Analysis views in the Azure portal.</summary>
    [JsonPropertyName("costAnalysisEnabled")]
    public bool? CostAnalysisEnabled { get; set; }

    /// <summary>The current version running on the Azure Kubernetes Managed Cluster.</summary>
    [JsonPropertyName("currentKubernetesVersion")]
    public string? CurrentKubernetesVersion { get; set; }

    /// <summary>Specifies configuration for "System" mode node pool. A default_node_pool block as defined below.</summary>
    [JsonPropertyName("defaultNodePool")]
    public IList<V1beta1KubernetesClusterStatusAtProviderDefaultNodePool>? DefaultNodePool { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used for the Nodes and Volumes. More information can be found in the documentation. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>DNS prefix specified when creating the managed cluster. Possible values must begin and end with a letter or number, contain only letters, numbers, and hyphens and be between 1 and 54 characters in length. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dnsPrefix")]
    public string? DnsPrefix { get; set; }

    /// <summary>Specifies the DNS prefix to use with private clusters. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dnsPrefixPrivateCluster")]
    public string? DnsPrefixPrivateCluster { get; set; }

    /// <summary>Specifies the Extended Zone (formerly called Edge Zone) within the Azure Region where this Managed Kubernetes Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("edgeZone")]
    public string? EdgeZone { get; set; }

    /// <summary>The FQDN of the Azure Kubernetes Managed Cluster.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>Should HTTP Application Routing be enabled?</summary>
    [JsonPropertyName("httpApplicationRoutingEnabled")]
    public bool? HttpApplicationRoutingEnabled { get; set; }

    /// <summary>The Zone Name of the HTTP Application Routing.</summary>
    [JsonPropertyName("httpApplicationRoutingZoneName")]
    public string? HttpApplicationRoutingZoneName { get; set; }

    /// <summary>A http_proxy_config block as defined below.</summary>
    [JsonPropertyName("httpProxyConfig")]
    public IList<V1beta1KubernetesClusterStatusAtProviderHttpProxyConfig>? HttpProxyConfig { get; set; }

    /// <summary>The Kubernetes Managed Cluster ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below. One of either identity or service_principal must be specified.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1KubernetesClusterStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>Specifies whether Image Cleaner is enabled.</summary>
    [JsonPropertyName("imageCleanerEnabled")]
    public bool? ImageCleanerEnabled { get; set; }

    /// <summary>Specifies the interval in hours when images should be cleaned up. Defaults to 0.</summary>
    [JsonPropertyName("imageCleanerIntervalHours")]
    public double? ImageCleanerIntervalHours { get; set; }

    /// <summary>An ingress_application_gateway block as defined below.</summary>
    [JsonPropertyName("ingressApplicationGateway")]
    public IList<V1beta1KubernetesClusterStatusAtProviderIngressApplicationGateway>? IngressApplicationGateway { get; set; }

    /// <summary>A key_management_service block as defined below. For more details, please visit Key Management Service (KMS) etcd encryption to an AKS cluster.</summary>
    [JsonPropertyName("keyManagementService")]
    public IList<V1beta1KubernetesClusterStatusAtProviderKeyManagementService>? KeyManagementService { get; set; }

    /// <summary>A key_vault_secrets_provider block as defined below.</summary>
    [JsonPropertyName("keyVaultSecretsProvider")]
    public IList<V1beta1KubernetesClusterStatusAtProviderKeyVaultSecretsProvider>? KeyVaultSecretsProvider { get; set; }

    /// <summary>A kubelet_identity block as defined below.</summary>
    [JsonPropertyName("kubeletIdentity")]
    public IList<V1beta1KubernetesClusterStatusAtProviderKubeletIdentity>? KubeletIdentity { get; set; }

    /// <summary>Version of Kubernetes specified when creating the AKS managed cluster. If not specified, the latest recommended version will be used at provisioning time (but won't auto-upgrade). AKS does not require an exact patch version to be specified, minor version aliases such as 1.22 are also supported. - The minor version's latest GA patch is automatically chosen in that case. More details can be found in the documentation.</summary>
    [JsonPropertyName("kubernetesVersion")]
    public string? KubernetesVersion { get; set; }

    /// <summary>A linux_profile block as defined below.</summary>
    [JsonPropertyName("linuxProfile")]
    public IList<V1beta1KubernetesClusterStatusAtProviderLinuxProfile>? LinuxProfile { get; set; }

    /// <summary>If true local accounts will be disabled. See the documentation for more information.</summary>
    [JsonPropertyName("localAccountDisabled")]
    public bool? LocalAccountDisabled { get; set; }

    /// <summary>The location where the Managed Kubernetes Cluster should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A maintenance_window block as defined below.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public IList<V1beta1KubernetesClusterStatusAtProviderMaintenanceWindow>? MaintenanceWindow { get; set; }

    /// <summary>A maintenance_window_auto_upgrade block as defined below.</summary>
    [JsonPropertyName("maintenanceWindowAutoUpgrade")]
    public IList<V1beta1KubernetesClusterStatusAtProviderMaintenanceWindowAutoUpgrade>? MaintenanceWindowAutoUpgrade { get; set; }

    /// <summary>A maintenance_window_node_os block as defined below.</summary>
    [JsonPropertyName("maintenanceWindowNodeOs")]
    public IList<V1beta1KubernetesClusterStatusAtProviderMaintenanceWindowNodeOs>? MaintenanceWindowNodeOs { get; set; }

    /// <summary>A microsoft_defender block as defined below.</summary>
    [JsonPropertyName("microsoftDefender")]
    public IList<V1beta1KubernetesClusterStatusAtProviderMicrosoftDefender>? MicrosoftDefender { get; set; }

    /// <summary>Specifies a Prometheus add-on profile for the Kubernetes Cluster. A monitor_metrics block as defined below.</summary>
    [JsonPropertyName("monitorMetrics")]
    public IList<V1beta1KubernetesClusterStatusAtProviderMonitorMetrics>? MonitorMetrics { get; set; }

    /// <summary>A network_profile block as defined below.</summary>
    [JsonPropertyName("networkProfile")]
    public IList<V1beta1KubernetesClusterStatusAtProviderNetworkProfile>? NetworkProfile { get; set; }

    /// <summary>The upgrade channel for this Kubernetes Cluster Nodes' OS Image. Possible values are Unmanaged, SecurityPatch, NodeImage and None. Defaults to NodeImage.</summary>
    [JsonPropertyName("nodeOsUpgradeChannel")]
    public string? NodeOsUpgradeChannel { get; set; }

    /// <summary>The auto-generated Resource Group which contains the resources for this Managed Kubernetes Cluster.</summary>
    [JsonPropertyName("nodeResourceGroup")]
    public string? NodeResourceGroup { get; set; }

    /// <summary>The ID of the Resource Group containing the resources for this Managed Kubernetes Cluster.</summary>
    [JsonPropertyName("nodeResourceGroupId")]
    public string? NodeResourceGroupId { get; set; }

    /// <summary>Enable or Disable the OIDC issuer URL</summary>
    [JsonPropertyName("oidcIssuerEnabled")]
    public bool? OidcIssuerEnabled { get; set; }

    /// <summary>The OIDC issuer URL that is associated with the cluster.</summary>
    [JsonPropertyName("oidcIssuerUrl")]
    public string? OidcIssuerUrl { get; set; }

    /// <summary>An oms_agent block as defined below.</summary>
    [JsonPropertyName("omsAgent")]
    public IList<V1beta1KubernetesClusterStatusAtProviderOmsAgent>? OmsAgent { get; set; }

    /// <summary>Is Open Service Mesh enabled? For more details, please visit Open Service Mesh for AKS.</summary>
    [JsonPropertyName("openServiceMeshEnabled")]
    public bool? OpenServiceMeshEnabled { get; set; }

    /// <summary>The FQDN for the Azure Portal resources when private link has been enabled, which is only resolvable inside the Virtual Network used by the Kubernetes Cluster.</summary>
    [JsonPropertyName("portalFqdn")]
    public string? PortalFqdn { get; set; }

    /// <summary>Should this Kubernetes Cluster have its API server only exposed on internal IP addresses? This provides a Private IP Address for the Kubernetes API on the Virtual Network where the Kubernetes Cluster is located. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateClusterEnabled")]
    public bool? PrivateClusterEnabled { get; set; }

    /// <summary>Specifies whether a Public FQDN for this Private Cluster should be added. Defaults to false.</summary>
    [JsonPropertyName("privateClusterPublicFqdnEnabled")]
    public bool? PrivateClusterPublicFqdnEnabled { get; set; }

    /// <summary>Either the ID of Private DNS Zone which should be delegated to this Cluster, System to have AKS manage this or None. In case of None you will need to bring your own DNS server and set up resolving, otherwise, the cluster will have issues after provisioning. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateDnsZoneId")]
    public string? PrivateDnsZoneId { get; set; }

    /// <summary>The FQDN for the Kubernetes Cluster when private link has been enabled, which is only resolvable inside the Virtual Network used by the Kubernetes Cluster.</summary>
    [JsonPropertyName("privateFqdn")]
    public string? PrivateFqdn { get; set; }

    /// <summary>Specifies the Resource Group where the Managed Kubernetes Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Whether Role Based Access Control for the Kubernetes Cluster should be enabled. Defaults to true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("roleBasedAccessControlEnabled")]
    public bool? RoleBasedAccessControlEnabled { get; set; }

    /// <summary>Whether to enable run command for the cluster or not. Defaults to true.</summary>
    [JsonPropertyName("runCommandEnabled")]
    public bool? RunCommandEnabled { get; set; }

    /// <summary>A service_mesh_profile block as defined below.</summary>
    [JsonPropertyName("serviceMeshProfile")]
    public IList<V1beta1KubernetesClusterStatusAtProviderServiceMeshProfile>? ServiceMeshProfile { get; set; }

    /// <summary>A service_principal block as documented below. One of either identity or service_principal must be specified.</summary>
    [JsonPropertyName("servicePrincipal")]
    public IList<V1beta1KubernetesClusterStatusAtProviderServicePrincipal>? ServicePrincipal { get; set; }

    /// <summary>The SKU Tier that should be used for this Kubernetes Cluster. Possible values are Free, Standard (which includes the Uptime SLA) and Premium. Defaults to Free.</summary>
    [JsonPropertyName("skuTier")]
    public string? SkuTier { get; set; }

    /// <summary>A storage_profile block as defined below.</summary>
    [JsonPropertyName("storageProfile")]
    public IList<V1beta1KubernetesClusterStatusAtProviderStorageProfile>? StorageProfile { get; set; }

    /// <summary>Specifies the support plan which should be used for this Kubernetes Cluster. Possible values are KubernetesOfficial and AKSLongTermSupport. Defaults to KubernetesOfficial.</summary>
    [JsonPropertyName("supportPlan")]
    public string? SupportPlan { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A upgrade_override block as defined below.</summary>
    [JsonPropertyName("upgradeOverride")]
    public IList<V1beta1KubernetesClusterStatusAtProviderUpgradeOverride>? UpgradeOverride { get; set; }

    /// <summary>A web_app_routing block as defined below.</summary>
    [JsonPropertyName("webAppRouting")]
    public IList<V1beta1KubernetesClusterStatusAtProviderWebAppRouting>? WebAppRouting { get; set; }

    /// <summary>A windows_profile block as defined below.</summary>
    [JsonPropertyName("windowsProfile")]
    public IList<V1beta1KubernetesClusterStatusAtProviderWindowsProfile>? WindowsProfile { get; set; }

    /// <summary>A workload_autoscaler_profile block defined below.</summary>
    [JsonPropertyName("workloadAutoscalerProfile")]
    public IList<V1beta1KubernetesClusterStatusAtProviderWorkloadAutoscalerProfile>? WorkloadAutoscalerProfile { get; set; }

    /// <summary>Specifies whether Azure AD Workload Identity should be enabled for the Cluster. Defaults to false.</summary>
    [JsonPropertyName("workloadIdentityEnabled")]
    public bool? WorkloadIdentityEnabled { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatusConditions
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

/// <summary>KubernetesClusterStatus defines the observed state of KubernetesCluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KubernetesClusterStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1KubernetesClusterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1KubernetesClusterStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>KubernetesCluster is the Schema for the KubernetesClusters API. Manages a managed Kubernetes Cluster (also known as AKS / Azure Kubernetes Service)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1KubernetesCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1KubernetesClusterSpec>, IStatus<V1beta1KubernetesClusterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "KubernetesCluster";
    public const string KubeGroup = "containerservice.azure.upbound.io";
    public const string KubePluralName = "kubernetesclusters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>KubernetesClusterSpec defines the desired state of KubernetesCluster</summary>
    [JsonPropertyName("spec")]
    public V1beta1KubernetesClusterSpec Spec { get; set; }

    /// <summary>KubernetesClusterStatus defines the observed state of KubernetesCluster.</summary>
    [JsonPropertyName("status")]
    public V1beta1KubernetesClusterStatus? Status { get; set; }
}