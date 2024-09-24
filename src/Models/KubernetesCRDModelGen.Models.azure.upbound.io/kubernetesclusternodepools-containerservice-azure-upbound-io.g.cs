using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containerservice.azure.upbound.io;
public enum V1beta1KubernetesClusterNodePoolSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1KubernetesClusterNodePoolSpecForProviderKubeletConfig
{
    /// <summary>Specifies the allow list of unsafe sysctls command or patterns (ending in *). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("allowedUnsafeSysctls")]
    public IList<string>? AllowedUnsafeSysctls { get; set; }

    /// <summary>Specifies the maximum number of container log files that can be present for a container. must be at least 2. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("containerLogMaxLine")]
    public double? ContainerLogMaxLine { get; set; }

    /// <summary>Specifies the maximum size (e.g. 10MB) of container log file before it is rotated. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("containerLogMaxSizeMb")]
    public double? ContainerLogMaxSizeMb { get; set; }

    /// <summary>Is CPU CFS quota enforcement for containers enabled? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cpuCfsQuotaEnabled")]
    public bool? CpuCfsQuotaEnabled { get; set; }

    /// <summary>Specifies the CPU CFS quota period value. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cpuCfsQuotaPeriod")]
    public string? CpuCfsQuotaPeriod { get; set; }

    /// <summary>Specifies the CPU Manager policy to use. Possible values are none and static, Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cpuManagerPolicy")]
    public string? CpuManagerPolicy { get; set; }

    /// <summary>Specifies the percent of disk usage above which image garbage collection is always run. Must be between 0 and 100. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("imageGcHighThreshold")]
    public double? ImageGcHighThreshold { get; set; }

    /// <summary>Specifies the percent of disk usage lower than which image garbage collection is never run. Must be between 0 and 100. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("imageGcLowThreshold")]
    public double? ImageGcLowThreshold { get; set; }

    /// <summary>Specifies the maximum number of processes per pod. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("podMaxPid")]
    public double? PodMaxPid { get; set; }

    /// <summary>Specifies the Topology Manager policy to use. Possible values are none, best-effort, restricted or single-numa-node. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("topologyManagerPolicy")]
    public string? TopologyManagerPolicy { get; set; }
}

public enum V1beta1KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdRefPolicyResolutionEnum>))]
    public V1beta1KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdRefPolicyResolveEnum>))]
    public V1beta1KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a KubernetesCluster in containerservice to populate kubernetesClusterId.</summary>
public partial class V1beta1KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdRefPolicy? Policy { get; set; }
}

public enum V1beta1KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdSelectorPolicyResolutionEnum>))]
    public V1beta1KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdSelectorPolicyResolveEnum>))]
    public V1beta1KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a KubernetesCluster in containerservice to populate kubernetesClusterId.</summary>
public partial class V1beta1KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1KubernetesClusterNodePoolSpecForProviderLinuxOsConfigSysctlConfig
{
    /// <summary>The sysctl setting fs.aio-max-nr. Must be between 65536 and 6553500. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("fsAioMaxNr")]
    public double? FsAioMaxNr { get; set; }

    /// <summary>The sysctl setting fs.file-max. Must be between 8192 and 12000500. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("fsFileMax")]
    public double? FsFileMax { get; set; }

    /// <summary>The sysctl setting fs.inotify.max_user_watches. Must be between 781250 and 2097152. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("fsInotifyMaxUserWatches")]
    public double? FsInotifyMaxUserWatches { get; set; }

    /// <summary>The sysctl setting fs.nr_open. Must be between 8192 and 20000500. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("fsNrOpen")]
    public double? FsNrOpen { get; set; }

    /// <summary>The sysctl setting kernel.threads-max. Must be between 20 and 513785. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("kernelThreadsMax")]
    public double? KernelThreadsMax { get; set; }

    /// <summary>The sysctl setting net.core.netdev_max_backlog. Must be between 1000 and 3240000. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netCoreNetdevMaxBacklog")]
    public double? NetCoreNetdevMaxBacklog { get; set; }

    /// <summary>The sysctl setting net.core.optmem_max. Must be between 20480 and 4194304. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netCoreOptmemMax")]
    public double? NetCoreOptmemMax { get; set; }

    /// <summary>The sysctl setting net.core.rmem_default. Must be between 212992 and 134217728. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netCoreRmemDefault")]
    public double? NetCoreRmemDefault { get; set; }

    /// <summary>The sysctl setting net.core.rmem_max. Must be between 212992 and 134217728. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netCoreRmemMax")]
    public double? NetCoreRmemMax { get; set; }

    /// <summary>The sysctl setting net.core.somaxconn. Must be between 4096 and 3240000. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netCoreSomaxconn")]
    public double? NetCoreSomaxconn { get; set; }

    /// <summary>The sysctl setting net.core.wmem_default. Must be between 212992 and 134217728. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netCoreWmemDefault")]
    public double? NetCoreWmemDefault { get; set; }

    /// <summary>The sysctl setting net.core.wmem_max. Must be between 212992 and 134217728. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netCoreWmemMax")]
    public double? NetCoreWmemMax { get; set; }

    /// <summary>The sysctl setting net.ipv4.ip_local_port_range max value. Must be between 32768 and 65535. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4IpLocalPortRangeMax")]
    public double? NetIpv4IpLocalPortRangeMax { get; set; }

    /// <summary>The sysctl setting net.ipv4.ip_local_port_range min value. Must be between 1024 and 60999. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4IpLocalPortRangeMin")]
    public double? NetIpv4IpLocalPortRangeMin { get; set; }

    /// <summary>The sysctl setting net.ipv4.neigh.default.gc_thresh1. Must be between 128 and 80000. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh1")]
    public double? NetIpv4NeighDefaultGcThresh1 { get; set; }

    /// <summary>The sysctl setting net.ipv4.neigh.default.gc_thresh2. Must be between 512 and 90000. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh2")]
    public double? NetIpv4NeighDefaultGcThresh2 { get; set; }

    /// <summary>The sysctl setting net.ipv4.neigh.default.gc_thresh3. Must be between 1024 and 100000. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh3")]
    public double? NetIpv4NeighDefaultGcThresh3 { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_fin_timeout. Must be between 5 and 120. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4TcpFinTimeout")]
    public double? NetIpv4TcpFinTimeout { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_keepalive_intvl. Must be between 10 and 90. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4TcpKeepaliveIntvl")]
    public double? NetIpv4TcpKeepaliveIntvl { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_keepalive_probes. Must be between 1 and 15. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4TcpKeepaliveProbes")]
    public double? NetIpv4TcpKeepaliveProbes { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_keepalive_time. Must be between 30 and 432000. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4TcpKeepaliveTime")]
    public double? NetIpv4TcpKeepaliveTime { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_max_syn_backlog. Must be between 128 and 3240000. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4TcpMaxSynBacklog")]
    public double? NetIpv4TcpMaxSynBacklog { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_max_tw_buckets. Must be between 8000 and 1440000. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4TcpMaxTwBuckets")]
    public double? NetIpv4TcpMaxTwBuckets { get; set; }

    /// <summary>Is sysctl setting net.ipv4.tcp_tw_reuse enabled? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4TcpTwReuse")]
    public bool? NetIpv4TcpTwReuse { get; set; }

    /// <summary>The sysctl setting net.netfilter.nf_conntrack_buckets. Must be between 65536 and 524288. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netNetfilterNfConntrackBuckets")]
    public double? NetNetfilterNfConntrackBuckets { get; set; }

    /// <summary>The sysctl setting net.netfilter.nf_conntrack_max. Must be between 131072 and 2097152. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netNetfilterNfConntrackMax")]
    public double? NetNetfilterNfConntrackMax { get; set; }

    /// <summary>The sysctl setting vm.max_map_count. Must be between 65530 and 262144. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmMaxMapCount")]
    public double? VmMaxMapCount { get; set; }

    /// <summary>The sysctl setting vm.swappiness. Must be between 0 and 100. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSwappiness")]
    public double? VmSwappiness { get; set; }

    /// <summary>The sysctl setting vm.vfs_cache_pressure. Must be between 0 and 100. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmVfsCachePressure")]
    public double? VmVfsCachePressure { get; set; }
}

/// <summary></summary>
public partial class V1beta1KubernetesClusterNodePoolSpecForProviderLinuxOsConfig
{
    /// <summary>Specifies the size of swap file on each node in MB. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("swapFileSizeMb")]
    public double? SwapFileSizeMb { get; set; }

    /// <summary>A sysctl_config block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sysctlConfig")]
    public IList<V1beta1KubernetesClusterNodePoolSpecForProviderLinuxOsConfigSysctlConfig>? SysctlConfig { get; set; }

    /// <summary>specifies the defrag configuration for Transparent Huge Page. Possible values are always, defer, defer+madvise, madvise and never. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("transparentHugePageDefrag")]
    public string? TransparentHugePageDefrag { get; set; }

    /// <summary>Specifies the Transparent Huge Page enabled configuration. Possible values are always, madvise and never. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("transparentHugePageEnabled")]
    public string? TransparentHugePageEnabled { get; set; }
}

/// <summary></summary>
public partial class V1beta1KubernetesClusterNodePoolSpecForProviderNodeNetworkProfileAllowedHostPorts
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
public partial class V1beta1KubernetesClusterNodePoolSpecForProviderNodeNetworkProfile
{
    /// <summary>One or more allowed_host_ports blocks as defined below.</summary>
    [JsonPropertyName("allowedHostPorts")]
    public IList<V1beta1KubernetesClusterNodePoolSpecForProviderNodeNetworkProfileAllowedHostPorts>? AllowedHostPorts { get; set; }

    /// <summary>A list of Application Security Group IDs which should be associated with this Node Pool.</summary>
    [JsonPropertyName("applicationSecurityGroupIds")]
    public IList<string>? ApplicationSecurityGroupIds { get; set; }

    /// <summary>Specifies a mapping of tags to the instance-level public IPs. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("nodePublicIpTags")]
    public IDictionary<string, string>? NodePublicIpTags { get; set; }
}

public enum V1beta1KubernetesClusterNodePoolSpecForProviderPodSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1KubernetesClusterNodePoolSpecForProviderPodSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1KubernetesClusterNodePoolSpecForProviderPodSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1KubernetesClusterNodePoolSpecForProviderPodSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1KubernetesClusterNodePoolSpecForProviderPodSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1KubernetesClusterNodePoolSpecForProviderPodSubnetIdRefPolicyResolveEnum>))]
    public V1beta1KubernetesClusterNodePoolSpecForProviderPodSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate podSubnetId.</summary>
public partial class V1beta1KubernetesClusterNodePoolSpecForProviderPodSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterNodePoolSpecForProviderPodSubnetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1KubernetesClusterNodePoolSpecForProviderPodSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1KubernetesClusterNodePoolSpecForProviderPodSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1KubernetesClusterNodePoolSpecForProviderPodSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1KubernetesClusterNodePoolSpecForProviderPodSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1KubernetesClusterNodePoolSpecForProviderPodSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1KubernetesClusterNodePoolSpecForProviderPodSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1KubernetesClusterNodePoolSpecForProviderPodSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate podSubnetId.</summary>
public partial class V1beta1KubernetesClusterNodePoolSpecForProviderPodSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterNodePoolSpecForProviderPodSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1KubernetesClusterNodePoolSpecForProviderUpgradeSettings
{
    /// <summary>The maximum number or percentage of nodes which will be added to the Node Pool size during an upgrade.</summary>
    [JsonPropertyName("maxSurge")]
    public string? MaxSurge { get; set; }
}

public enum V1beta1KubernetesClusterNodePoolSpecForProviderVnetSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1KubernetesClusterNodePoolSpecForProviderVnetSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1KubernetesClusterNodePoolSpecForProviderVnetSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1KubernetesClusterNodePoolSpecForProviderVnetSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1KubernetesClusterNodePoolSpecForProviderVnetSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1KubernetesClusterNodePoolSpecForProviderVnetSubnetIdRefPolicyResolveEnum>))]
    public V1beta1KubernetesClusterNodePoolSpecForProviderVnetSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate vnetSubnetId.</summary>
public partial class V1beta1KubernetesClusterNodePoolSpecForProviderVnetSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterNodePoolSpecForProviderVnetSubnetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1KubernetesClusterNodePoolSpecForProviderVnetSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1KubernetesClusterNodePoolSpecForProviderVnetSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1KubernetesClusterNodePoolSpecForProviderVnetSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1KubernetesClusterNodePoolSpecForProviderVnetSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1KubernetesClusterNodePoolSpecForProviderVnetSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1KubernetesClusterNodePoolSpecForProviderVnetSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1KubernetesClusterNodePoolSpecForProviderVnetSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate vnetSubnetId.</summary>
public partial class V1beta1KubernetesClusterNodePoolSpecForProviderVnetSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterNodePoolSpecForProviderVnetSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1KubernetesClusterNodePoolSpecForProviderWindowsProfile
{
    /// <summary>Should the Windows nodes in this Node Pool have outbound NAT enabled? Defaults to true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("outboundNatEnabled")]
    public bool? OutboundNatEnabled { get; set; }
}

/// <summary></summary>
public partial class V1beta1KubernetesClusterNodePoolSpecForProvider
{
    /// <summary>Specifies the ID of the Capacity Reservation Group where this Node Pool should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("capacityReservationGroupId")]
    public string? CapacityReservationGroupId { get; set; }

    /// <summary>Specifies whether to trust a Custom CA.</summary>
    [JsonPropertyName("customCaTrustEnabled")]
    public bool? CustomCaTrustEnabled { get; set; }

    /// <summary>Whether to enable auto-scaler.</summary>
    [JsonPropertyName("enableAutoScaling")]
    public bool? EnableAutoScaling { get; set; }

    /// <summary>Should the nodes in this Node Pool have host encryption enabled? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("enableHostEncryption")]
    public bool? EnableHostEncryption { get; set; }

    /// <summary>Should each node have a Public IP Address? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("enableNodePublicIp")]
    public bool? EnableNodePublicIp { get; set; }

    /// <summary>The Eviction Policy which should be used for Virtual Machines within the Virtual Machine Scale Set powering this Node Pool. Possible values are Deallocate and Delete. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>Should the nodes in this Node Pool have Federal Information Processing Standard enabled? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("fipsEnabled")]
    public bool? FipsEnabled { get; set; }

    /// <summary>Specifies the GPU MIG instance profile for supported GPU VM SKU. The allowed values are MIG1g, MIG2g, MIG3g, MIG4g and MIG7g. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("gpuInstance")]
    public string? GpuInstance { get; set; }

    /// <summary>The fully qualified resource ID of the Dedicated Host Group to provision virtual machines from. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hostGroupId")]
    public string? HostGroupId { get; set; }

    /// <summary>A kubelet_config block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("kubeletConfig")]
    public IList<V1beta1KubernetesClusterNodePoolSpecForProviderKubeletConfig>? KubeletConfig { get; set; }

    /// <summary>The type of disk used by kubelet. Possible values are OS and Temporary.</summary>
    [JsonPropertyName("kubeletDiskType")]
    public string? KubeletDiskType { get; set; }

    /// <summary>The ID of the Kubernetes Cluster where this Node Pool should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("kubernetesClusterId")]
    public string? KubernetesClusterId { get; set; }

    /// <summary>Reference to a KubernetesCluster in containerservice to populate kubernetesClusterId.</summary>
    [JsonPropertyName("kubernetesClusterIdRef")]
    public V1beta1KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdRef? KubernetesClusterIdRef { get; set; }

    /// <summary>Selector for a KubernetesCluster in containerservice to populate kubernetesClusterId.</summary>
    [JsonPropertyName("kubernetesClusterIdSelector")]
    public V1beta1KubernetesClusterNodePoolSpecForProviderKubernetesClusterIdSelector? KubernetesClusterIdSelector { get; set; }

    /// <summary>A linux_os_config block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("linuxOsConfig")]
    public IList<V1beta1KubernetesClusterNodePoolSpecForProviderLinuxOsConfig>? LinuxOsConfig { get; set; }

    /// <summary>The maximum number of nodes which should exist within this Node Pool. Valid values are between 0 and 1000 and must be greater than or equal to min_count.</summary>
    [JsonPropertyName("maxCount")]
    public double? MaxCount { get; set; }

    /// <summary>The maximum number of pods that can run on each agent. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("maxPods")]
    public double? MaxPods { get; set; }

    /// <summary>A base64-encoded string which will be written to /etc/motd after decoding. This allows customization of the message of the day for Linux nodes. It cannot be specified for Windows nodes and must be a static string (i.e. will be printed raw and not executed as a script). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("messageOfTheDay")]
    public string? MessageOfTheDay { get; set; }

    /// <summary>The minimum number of nodes which should exist within this Node Pool. Valid values are between 0 and 1000 and must be less than or equal to max_count.</summary>
    [JsonPropertyName("minCount")]
    public double? MinCount { get; set; }

    /// <summary>Should this Node Pool be used for System or User resources? Possible values are System and User. Defaults to User.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The initial number of nodes which should exist within this Node Pool. Valid values are between 0 and 1000 (inclusive) for user pools and between 1 and 1000 (inclusive) for system pools and must be a value in the range min_count - max_count.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>A map of Kubernetes labels which should be applied to nodes in this Node Pool.</summary>
    [JsonPropertyName("nodeLabels")]
    public IDictionary<string, string>? NodeLabels { get; set; }

    /// <summary>A node_network_profile block as documented below.</summary>
    [JsonPropertyName("nodeNetworkProfile")]
    public IList<V1beta1KubernetesClusterNodePoolSpecForProviderNodeNetworkProfile>? NodeNetworkProfile { get; set; }

    /// <summary>Resource ID for the Public IP Addresses Prefix for the nodes in this Node Pool. enable_node_public_ip should be true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("nodePublicIpPrefixId")]
    public string? NodePublicIpPrefixId { get; set; }

    /// <summary>A list of Kubernetes taints which should be applied to nodes in the agent pool (e.g key=value:NoSchedule).</summary>
    [JsonPropertyName("nodeTaints")]
    public IList<string>? NodeTaints { get; set; }

    /// <summary>Version of Kubernetes used for the Agents. If not specified, the latest recommended version will be used at provisioning time (but won't auto-upgrade). AKS does not require an exact patch version to be specified, minor version aliases such as 1.22 are also supported. - The minor version's latest GA patch is automatically chosen in that case. More details can be found in the documentation.</summary>
    [JsonPropertyName("orchestratorVersion")]
    public string? OrchestratorVersion { get; set; }

    /// <summary>The Agent Operating System disk size in GB. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("osDiskSizeGb")]
    public double? OsDiskSizeGb { get; set; }

    /// <summary>The type of disk which should be used for the Operating System. Possible values are Ephemeral and Managed. Defaults to Managed. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("osDiskType")]
    public string? OsDiskType { get; set; }

    /// <summary>Specifies the OS SKU used by the agent pool. Possible values are AzureLinux, Ubuntu, Windows2019 and Windows2022. If not specified, the default is Ubuntu if OSType=Linux or Windows2019 if OSType=Windows. And the default Windows OSSKU will be changed to Windows2022 after Windows2019 is deprecated. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("osSku")]
    public string? OsSku { get; set; }

    /// <summary>The Operating System which should be used for this Node Pool. Changing this forces a new resource to be created. Possible values are Linux and Windows. Defaults to Linux.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>The ID of the Subnet where the pods in the Node Pool should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("podSubnetId")]
    public string? PodSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate podSubnetId.</summary>
    [JsonPropertyName("podSubnetIdRef")]
    public V1beta1KubernetesClusterNodePoolSpecForProviderPodSubnetIdRef? PodSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate podSubnetId.</summary>
    [JsonPropertyName("podSubnetIdSelector")]
    public V1beta1KubernetesClusterNodePoolSpecForProviderPodSubnetIdSelector? PodSubnetIdSelector { get; set; }

    /// <summary>The Priority for Virtual Machines within the Virtual Machine Scale Set that powers this Node Pool. Possible values are Regular and Spot. Defaults to Regular. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>The ID of the Proximity Placement Group where the Virtual Machine Scale Set that powers this Node Pool will be placed. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("proximityPlacementGroupId")]
    public string? ProximityPlacementGroupId { get; set; }

    /// <summary>Specifies how the node pool should deal with scaled-down nodes. Allowed values are Delete and Deallocate. Defaults to Delete.</summary>
    [JsonPropertyName("scaleDownMode")]
    public string? ScaleDownMode { get; set; }

    /// <summary>The ID of the Snapshot which should be used to create this Node Pool. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>The maximum price you're willing to pay in USD per Virtual Machine. Valid values are -1 (the current on-demand price for a Virtual Machine) or a positive value with up to five decimal places. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("spotMaxPrice")]
    public double? SpotMaxPrice { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Used to specify whether the UltraSSD is enabled in the Node Pool. Defaults to false. See the documentation for more information. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ultraSsdEnabled")]
    public bool? UltraSsdEnabled { get; set; }

    /// <summary>A upgrade_settings block as documented below.</summary>
    [JsonPropertyName("upgradeSettings")]
    public IList<V1beta1KubernetesClusterNodePoolSpecForProviderUpgradeSettings>? UpgradeSettings { get; set; }

    /// <summary>The SKU which should be used for the Virtual Machines used in this Node Pool. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }

    /// <summary>The ID of the Subnet where this Node Pool should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vnetSubnetId")]
    public string? VnetSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate vnetSubnetId.</summary>
    [JsonPropertyName("vnetSubnetIdRef")]
    public V1beta1KubernetesClusterNodePoolSpecForProviderVnetSubnetIdRef? VnetSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate vnetSubnetId.</summary>
    [JsonPropertyName("vnetSubnetIdSelector")]
    public V1beta1KubernetesClusterNodePoolSpecForProviderVnetSubnetIdSelector? VnetSubnetIdSelector { get; set; }

    /// <summary>A windows_profile block as documented below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("windowsProfile")]
    public IList<V1beta1KubernetesClusterNodePoolSpecForProviderWindowsProfile>? WindowsProfile { get; set; }

    /// <summary>Used to specify the workload runtime. Allowed values are OCIContainer, WasmWasi and KataMshvVmIsolation.</summary>
    [JsonPropertyName("workloadRuntime")]
    public string? WorkloadRuntime { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this Kubernetes Cluster Node Pool should be located. Changing this forces a new Kubernetes Cluster Node Pool to be created.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary></summary>
public partial class V1beta1KubernetesClusterNodePoolSpecInitProviderKubeletConfig
{
    /// <summary>Specifies the allow list of unsafe sysctls command or patterns (ending in *). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("allowedUnsafeSysctls")]
    public IList<string>? AllowedUnsafeSysctls { get; set; }

    /// <summary>Specifies the maximum number of container log files that can be present for a container. must be at least 2. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("containerLogMaxLine")]
    public double? ContainerLogMaxLine { get; set; }

    /// <summary>Specifies the maximum size (e.g. 10MB) of container log file before it is rotated. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("containerLogMaxSizeMb")]
    public double? ContainerLogMaxSizeMb { get; set; }

    /// <summary>Is CPU CFS quota enforcement for containers enabled? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cpuCfsQuotaEnabled")]
    public bool? CpuCfsQuotaEnabled { get; set; }

    /// <summary>Specifies the CPU CFS quota period value. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cpuCfsQuotaPeriod")]
    public string? CpuCfsQuotaPeriod { get; set; }

    /// <summary>Specifies the CPU Manager policy to use. Possible values are none and static, Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cpuManagerPolicy")]
    public string? CpuManagerPolicy { get; set; }

    /// <summary>Specifies the percent of disk usage above which image garbage collection is always run. Must be between 0 and 100. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("imageGcHighThreshold")]
    public double? ImageGcHighThreshold { get; set; }

    /// <summary>Specifies the percent of disk usage lower than which image garbage collection is never run. Must be between 0 and 100. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("imageGcLowThreshold")]
    public double? ImageGcLowThreshold { get; set; }

    /// <summary>Specifies the maximum number of processes per pod. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("podMaxPid")]
    public double? PodMaxPid { get; set; }

    /// <summary>Specifies the Topology Manager policy to use. Possible values are none, best-effort, restricted or single-numa-node. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("topologyManagerPolicy")]
    public string? TopologyManagerPolicy { get; set; }
}

/// <summary></summary>
public partial class V1beta1KubernetesClusterNodePoolSpecInitProviderLinuxOsConfigSysctlConfig
{
    /// <summary>The sysctl setting fs.aio-max-nr. Must be between 65536 and 6553500. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("fsAioMaxNr")]
    public double? FsAioMaxNr { get; set; }

    /// <summary>The sysctl setting fs.file-max. Must be between 8192 and 12000500. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("fsFileMax")]
    public double? FsFileMax { get; set; }

    /// <summary>The sysctl setting fs.inotify.max_user_watches. Must be between 781250 and 2097152. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("fsInotifyMaxUserWatches")]
    public double? FsInotifyMaxUserWatches { get; set; }

    /// <summary>The sysctl setting fs.nr_open. Must be between 8192 and 20000500. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("fsNrOpen")]
    public double? FsNrOpen { get; set; }

    /// <summary>The sysctl setting kernel.threads-max. Must be between 20 and 513785. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("kernelThreadsMax")]
    public double? KernelThreadsMax { get; set; }

    /// <summary>The sysctl setting net.core.netdev_max_backlog. Must be between 1000 and 3240000. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netCoreNetdevMaxBacklog")]
    public double? NetCoreNetdevMaxBacklog { get; set; }

    /// <summary>The sysctl setting net.core.optmem_max. Must be between 20480 and 4194304. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netCoreOptmemMax")]
    public double? NetCoreOptmemMax { get; set; }

    /// <summary>The sysctl setting net.core.rmem_default. Must be between 212992 and 134217728. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netCoreRmemDefault")]
    public double? NetCoreRmemDefault { get; set; }

    /// <summary>The sysctl setting net.core.rmem_max. Must be between 212992 and 134217728. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netCoreRmemMax")]
    public double? NetCoreRmemMax { get; set; }

    /// <summary>The sysctl setting net.core.somaxconn. Must be between 4096 and 3240000. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netCoreSomaxconn")]
    public double? NetCoreSomaxconn { get; set; }

    /// <summary>The sysctl setting net.core.wmem_default. Must be between 212992 and 134217728. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netCoreWmemDefault")]
    public double? NetCoreWmemDefault { get; set; }

    /// <summary>The sysctl setting net.core.wmem_max. Must be between 212992 and 134217728. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netCoreWmemMax")]
    public double? NetCoreWmemMax { get; set; }

    /// <summary>The sysctl setting net.ipv4.ip_local_port_range max value. Must be between 32768 and 65535. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4IpLocalPortRangeMax")]
    public double? NetIpv4IpLocalPortRangeMax { get; set; }

    /// <summary>The sysctl setting net.ipv4.ip_local_port_range min value. Must be between 1024 and 60999. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4IpLocalPortRangeMin")]
    public double? NetIpv4IpLocalPortRangeMin { get; set; }

    /// <summary>The sysctl setting net.ipv4.neigh.default.gc_thresh1. Must be between 128 and 80000. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh1")]
    public double? NetIpv4NeighDefaultGcThresh1 { get; set; }

    /// <summary>The sysctl setting net.ipv4.neigh.default.gc_thresh2. Must be between 512 and 90000. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh2")]
    public double? NetIpv4NeighDefaultGcThresh2 { get; set; }

    /// <summary>The sysctl setting net.ipv4.neigh.default.gc_thresh3. Must be between 1024 and 100000. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh3")]
    public double? NetIpv4NeighDefaultGcThresh3 { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_fin_timeout. Must be between 5 and 120. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4TcpFinTimeout")]
    public double? NetIpv4TcpFinTimeout { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_keepalive_intvl. Must be between 10 and 90. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4TcpKeepaliveIntvl")]
    public double? NetIpv4TcpKeepaliveIntvl { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_keepalive_probes. Must be between 1 and 15. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4TcpKeepaliveProbes")]
    public double? NetIpv4TcpKeepaliveProbes { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_keepalive_time. Must be between 30 and 432000. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4TcpKeepaliveTime")]
    public double? NetIpv4TcpKeepaliveTime { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_max_syn_backlog. Must be between 128 and 3240000. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4TcpMaxSynBacklog")]
    public double? NetIpv4TcpMaxSynBacklog { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_max_tw_buckets. Must be between 8000 and 1440000. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4TcpMaxTwBuckets")]
    public double? NetIpv4TcpMaxTwBuckets { get; set; }

    /// <summary>Is sysctl setting net.ipv4.tcp_tw_reuse enabled? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4TcpTwReuse")]
    public bool? NetIpv4TcpTwReuse { get; set; }

    /// <summary>The sysctl setting net.netfilter.nf_conntrack_buckets. Must be between 65536 and 524288. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netNetfilterNfConntrackBuckets")]
    public double? NetNetfilterNfConntrackBuckets { get; set; }

    /// <summary>The sysctl setting net.netfilter.nf_conntrack_max. Must be between 131072 and 2097152. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netNetfilterNfConntrackMax")]
    public double? NetNetfilterNfConntrackMax { get; set; }

    /// <summary>The sysctl setting vm.max_map_count. Must be between 65530 and 262144. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmMaxMapCount")]
    public double? VmMaxMapCount { get; set; }

    /// <summary>The sysctl setting vm.swappiness. Must be between 0 and 100. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSwappiness")]
    public double? VmSwappiness { get; set; }

    /// <summary>The sysctl setting vm.vfs_cache_pressure. Must be between 0 and 100. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmVfsCachePressure")]
    public double? VmVfsCachePressure { get; set; }
}

/// <summary></summary>
public partial class V1beta1KubernetesClusterNodePoolSpecInitProviderLinuxOsConfig
{
    /// <summary>Specifies the size of swap file on each node in MB. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("swapFileSizeMb")]
    public double? SwapFileSizeMb { get; set; }

    /// <summary>A sysctl_config block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sysctlConfig")]
    public IList<V1beta1KubernetesClusterNodePoolSpecInitProviderLinuxOsConfigSysctlConfig>? SysctlConfig { get; set; }

    /// <summary>specifies the defrag configuration for Transparent Huge Page. Possible values are always, defer, defer+madvise, madvise and never. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("transparentHugePageDefrag")]
    public string? TransparentHugePageDefrag { get; set; }

    /// <summary>Specifies the Transparent Huge Page enabled configuration. Possible values are always, madvise and never. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("transparentHugePageEnabled")]
    public string? TransparentHugePageEnabled { get; set; }
}

/// <summary></summary>
public partial class V1beta1KubernetesClusterNodePoolSpecInitProviderNodeNetworkProfileAllowedHostPorts
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
public partial class V1beta1KubernetesClusterNodePoolSpecInitProviderNodeNetworkProfile
{
    /// <summary>One or more allowed_host_ports blocks as defined below.</summary>
    [JsonPropertyName("allowedHostPorts")]
    public IList<V1beta1KubernetesClusterNodePoolSpecInitProviderNodeNetworkProfileAllowedHostPorts>? AllowedHostPorts { get; set; }

    /// <summary>A list of Application Security Group IDs which should be associated with this Node Pool.</summary>
    [JsonPropertyName("applicationSecurityGroupIds")]
    public IList<string>? ApplicationSecurityGroupIds { get; set; }

    /// <summary>Specifies a mapping of tags to the instance-level public IPs. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("nodePublicIpTags")]
    public IDictionary<string, string>? NodePublicIpTags { get; set; }
}

public enum V1beta1KubernetesClusterNodePoolSpecInitProviderPodSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1KubernetesClusterNodePoolSpecInitProviderPodSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1KubernetesClusterNodePoolSpecInitProviderPodSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1KubernetesClusterNodePoolSpecInitProviderPodSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1KubernetesClusterNodePoolSpecInitProviderPodSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1KubernetesClusterNodePoolSpecInitProviderPodSubnetIdRefPolicyResolveEnum>))]
    public V1beta1KubernetesClusterNodePoolSpecInitProviderPodSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate podSubnetId.</summary>
public partial class V1beta1KubernetesClusterNodePoolSpecInitProviderPodSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterNodePoolSpecInitProviderPodSubnetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1KubernetesClusterNodePoolSpecInitProviderPodSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1KubernetesClusterNodePoolSpecInitProviderPodSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1KubernetesClusterNodePoolSpecInitProviderPodSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1KubernetesClusterNodePoolSpecInitProviderPodSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1KubernetesClusterNodePoolSpecInitProviderPodSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1KubernetesClusterNodePoolSpecInitProviderPodSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1KubernetesClusterNodePoolSpecInitProviderPodSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate podSubnetId.</summary>
public partial class V1beta1KubernetesClusterNodePoolSpecInitProviderPodSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterNodePoolSpecInitProviderPodSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1KubernetesClusterNodePoolSpecInitProviderUpgradeSettings
{
    /// <summary>The maximum number or percentage of nodes which will be added to the Node Pool size during an upgrade.</summary>
    [JsonPropertyName("maxSurge")]
    public string? MaxSurge { get; set; }
}

public enum V1beta1KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdRefPolicyResolveEnum>))]
    public V1beta1KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate vnetSubnetId.</summary>
public partial class V1beta1KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate vnetSubnetId.</summary>
public partial class V1beta1KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1KubernetesClusterNodePoolSpecInitProviderWindowsProfile
{
    /// <summary>Should the Windows nodes in this Node Pool have outbound NAT enabled? Defaults to true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("outboundNatEnabled")]
    public bool? OutboundNatEnabled { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1KubernetesClusterNodePoolSpecInitProvider
{
    /// <summary>Specifies the ID of the Capacity Reservation Group where this Node Pool should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("capacityReservationGroupId")]
    public string? CapacityReservationGroupId { get; set; }

    /// <summary>Specifies whether to trust a Custom CA.</summary>
    [JsonPropertyName("customCaTrustEnabled")]
    public bool? CustomCaTrustEnabled { get; set; }

    /// <summary>Whether to enable auto-scaler.</summary>
    [JsonPropertyName("enableAutoScaling")]
    public bool? EnableAutoScaling { get; set; }

    /// <summary>Should the nodes in this Node Pool have host encryption enabled? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("enableHostEncryption")]
    public bool? EnableHostEncryption { get; set; }

    /// <summary>Should each node have a Public IP Address? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("enableNodePublicIp")]
    public bool? EnableNodePublicIp { get; set; }

    /// <summary>The Eviction Policy which should be used for Virtual Machines within the Virtual Machine Scale Set powering this Node Pool. Possible values are Deallocate and Delete. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>Should the nodes in this Node Pool have Federal Information Processing Standard enabled? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("fipsEnabled")]
    public bool? FipsEnabled { get; set; }

    /// <summary>Specifies the GPU MIG instance profile for supported GPU VM SKU. The allowed values are MIG1g, MIG2g, MIG3g, MIG4g and MIG7g. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("gpuInstance")]
    public string? GpuInstance { get; set; }

    /// <summary>The fully qualified resource ID of the Dedicated Host Group to provision virtual machines from. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hostGroupId")]
    public string? HostGroupId { get; set; }

    /// <summary>A kubelet_config block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("kubeletConfig")]
    public IList<V1beta1KubernetesClusterNodePoolSpecInitProviderKubeletConfig>? KubeletConfig { get; set; }

    /// <summary>The type of disk used by kubelet. Possible values are OS and Temporary.</summary>
    [JsonPropertyName("kubeletDiskType")]
    public string? KubeletDiskType { get; set; }

    /// <summary>A linux_os_config block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("linuxOsConfig")]
    public IList<V1beta1KubernetesClusterNodePoolSpecInitProviderLinuxOsConfig>? LinuxOsConfig { get; set; }

    /// <summary>The maximum number of nodes which should exist within this Node Pool. Valid values are between 0 and 1000 and must be greater than or equal to min_count.</summary>
    [JsonPropertyName("maxCount")]
    public double? MaxCount { get; set; }

    /// <summary>The maximum number of pods that can run on each agent. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("maxPods")]
    public double? MaxPods { get; set; }

    /// <summary>A base64-encoded string which will be written to /etc/motd after decoding. This allows customization of the message of the day for Linux nodes. It cannot be specified for Windows nodes and must be a static string (i.e. will be printed raw and not executed as a script). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("messageOfTheDay")]
    public string? MessageOfTheDay { get; set; }

    /// <summary>The minimum number of nodes which should exist within this Node Pool. Valid values are between 0 and 1000 and must be less than or equal to max_count.</summary>
    [JsonPropertyName("minCount")]
    public double? MinCount { get; set; }

    /// <summary>Should this Node Pool be used for System or User resources? Possible values are System and User. Defaults to User.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The initial number of nodes which should exist within this Node Pool. Valid values are between 0 and 1000 (inclusive) for user pools and between 1 and 1000 (inclusive) for system pools and must be a value in the range min_count - max_count.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>A map of Kubernetes labels which should be applied to nodes in this Node Pool.</summary>
    [JsonPropertyName("nodeLabels")]
    public IDictionary<string, string>? NodeLabels { get; set; }

    /// <summary>A node_network_profile block as documented below.</summary>
    [JsonPropertyName("nodeNetworkProfile")]
    public IList<V1beta1KubernetesClusterNodePoolSpecInitProviderNodeNetworkProfile>? NodeNetworkProfile { get; set; }

    /// <summary>Resource ID for the Public IP Addresses Prefix for the nodes in this Node Pool. enable_node_public_ip should be true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("nodePublicIpPrefixId")]
    public string? NodePublicIpPrefixId { get; set; }

    /// <summary>A list of Kubernetes taints which should be applied to nodes in the agent pool (e.g key=value:NoSchedule).</summary>
    [JsonPropertyName("nodeTaints")]
    public IList<string>? NodeTaints { get; set; }

    /// <summary>Version of Kubernetes used for the Agents. If not specified, the latest recommended version will be used at provisioning time (but won't auto-upgrade). AKS does not require an exact patch version to be specified, minor version aliases such as 1.22 are also supported. - The minor version's latest GA patch is automatically chosen in that case. More details can be found in the documentation.</summary>
    [JsonPropertyName("orchestratorVersion")]
    public string? OrchestratorVersion { get; set; }

    /// <summary>The Agent Operating System disk size in GB. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("osDiskSizeGb")]
    public double? OsDiskSizeGb { get; set; }

    /// <summary>The type of disk which should be used for the Operating System. Possible values are Ephemeral and Managed. Defaults to Managed. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("osDiskType")]
    public string? OsDiskType { get; set; }

    /// <summary>Specifies the OS SKU used by the agent pool. Possible values are AzureLinux, Ubuntu, Windows2019 and Windows2022. If not specified, the default is Ubuntu if OSType=Linux or Windows2019 if OSType=Windows. And the default Windows OSSKU will be changed to Windows2022 after Windows2019 is deprecated. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("osSku")]
    public string? OsSku { get; set; }

    /// <summary>The Operating System which should be used for this Node Pool. Changing this forces a new resource to be created. Possible values are Linux and Windows. Defaults to Linux.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>The ID of the Subnet where the pods in the Node Pool should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("podSubnetId")]
    public string? PodSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate podSubnetId.</summary>
    [JsonPropertyName("podSubnetIdRef")]
    public V1beta1KubernetesClusterNodePoolSpecInitProviderPodSubnetIdRef? PodSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate podSubnetId.</summary>
    [JsonPropertyName("podSubnetIdSelector")]
    public V1beta1KubernetesClusterNodePoolSpecInitProviderPodSubnetIdSelector? PodSubnetIdSelector { get; set; }

    /// <summary>The Priority for Virtual Machines within the Virtual Machine Scale Set that powers this Node Pool. Possible values are Regular and Spot. Defaults to Regular. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>The ID of the Proximity Placement Group where the Virtual Machine Scale Set that powers this Node Pool will be placed. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("proximityPlacementGroupId")]
    public string? ProximityPlacementGroupId { get; set; }

    /// <summary>Specifies how the node pool should deal with scaled-down nodes. Allowed values are Delete and Deallocate. Defaults to Delete.</summary>
    [JsonPropertyName("scaleDownMode")]
    public string? ScaleDownMode { get; set; }

    /// <summary>The ID of the Snapshot which should be used to create this Node Pool. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>The maximum price you're willing to pay in USD per Virtual Machine. Valid values are -1 (the current on-demand price for a Virtual Machine) or a positive value with up to five decimal places. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("spotMaxPrice")]
    public double? SpotMaxPrice { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Used to specify whether the UltraSSD is enabled in the Node Pool. Defaults to false. See the documentation for more information. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ultraSsdEnabled")]
    public bool? UltraSsdEnabled { get; set; }

    /// <summary>A upgrade_settings block as documented below.</summary>
    [JsonPropertyName("upgradeSettings")]
    public IList<V1beta1KubernetesClusterNodePoolSpecInitProviderUpgradeSettings>? UpgradeSettings { get; set; }

    /// <summary>The SKU which should be used for the Virtual Machines used in this Node Pool. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }

    /// <summary>The ID of the Subnet where this Node Pool should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vnetSubnetId")]
    public string? VnetSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate vnetSubnetId.</summary>
    [JsonPropertyName("vnetSubnetIdRef")]
    public V1beta1KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdRef? VnetSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate vnetSubnetId.</summary>
    [JsonPropertyName("vnetSubnetIdSelector")]
    public V1beta1KubernetesClusterNodePoolSpecInitProviderVnetSubnetIdSelector? VnetSubnetIdSelector { get; set; }

    /// <summary>A windows_profile block as documented below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("windowsProfile")]
    public IList<V1beta1KubernetesClusterNodePoolSpecInitProviderWindowsProfile>? WindowsProfile { get; set; }

    /// <summary>Used to specify the workload runtime. Allowed values are OCIContainer, WasmWasi and KataMshvVmIsolation.</summary>
    [JsonPropertyName("workloadRuntime")]
    public string? WorkloadRuntime { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this Kubernetes Cluster Node Pool should be located. Changing this forces a new Kubernetes Cluster Node Pool to be created.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

public enum V1beta1KubernetesClusterNodePoolSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    /// <summary>Observe</summary>
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    /// <summary>Create</summary>
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    /// <summary>Update</summary>
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    /// <summary>LateInitialize</summary>
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    /// <summary>*</summary>
    Option5
}

public enum V1beta1KubernetesClusterNodePoolSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1KubernetesClusterNodePoolSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1KubernetesClusterNodePoolSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1KubernetesClusterNodePoolSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1KubernetesClusterNodePoolSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1KubernetesClusterNodePoolSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1KubernetesClusterNodePoolSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1KubernetesClusterNodePoolSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterNodePoolSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1KubernetesClusterNodePoolSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1KubernetesClusterNodePoolSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1KubernetesClusterNodePoolSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1KubernetesClusterNodePoolSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1KubernetesClusterNodePoolSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1KubernetesClusterNodePoolSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1KubernetesClusterNodePoolSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1KubernetesClusterNodePoolSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KubernetesClusterNodePoolSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1KubernetesClusterNodePoolSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1KubernetesClusterNodePoolSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1KubernetesClusterNodePoolSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1KubernetesClusterNodePoolSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1KubernetesClusterNodePoolSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>KubernetesClusterNodePoolSpec defines the desired state of KubernetesClusterNodePool</summary>
public partial class V1beta1KubernetesClusterNodePoolSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1KubernetesClusterNodePoolSpecDeletionPolicyEnum>))]
    public V1beta1KubernetesClusterNodePoolSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1KubernetesClusterNodePoolSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1KubernetesClusterNodePoolSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1KubernetesClusterNodePoolSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1KubernetesClusterNodePoolSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1KubernetesClusterNodePoolSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1KubernetesClusterNodePoolSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1KubernetesClusterNodePoolStatusAtProviderKubeletConfig
{
    /// <summary>Specifies the allow list of unsafe sysctls command or patterns (ending in *). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("allowedUnsafeSysctls")]
    public IList<string>? AllowedUnsafeSysctls { get; set; }

    /// <summary>Specifies the maximum number of container log files that can be present for a container. must be at least 2. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("containerLogMaxLine")]
    public double? ContainerLogMaxLine { get; set; }

    /// <summary>Specifies the maximum size (e.g. 10MB) of container log file before it is rotated. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("containerLogMaxSizeMb")]
    public double? ContainerLogMaxSizeMb { get; set; }

    /// <summary>Is CPU CFS quota enforcement for containers enabled? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cpuCfsQuotaEnabled")]
    public bool? CpuCfsQuotaEnabled { get; set; }

    /// <summary>Specifies the CPU CFS quota period value. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cpuCfsQuotaPeriod")]
    public string? CpuCfsQuotaPeriod { get; set; }

    /// <summary>Specifies the CPU Manager policy to use. Possible values are none and static, Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("cpuManagerPolicy")]
    public string? CpuManagerPolicy { get; set; }

    /// <summary>Specifies the percent of disk usage above which image garbage collection is always run. Must be between 0 and 100. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("imageGcHighThreshold")]
    public double? ImageGcHighThreshold { get; set; }

    /// <summary>Specifies the percent of disk usage lower than which image garbage collection is never run. Must be between 0 and 100. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("imageGcLowThreshold")]
    public double? ImageGcLowThreshold { get; set; }

    /// <summary>Specifies the maximum number of processes per pod. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("podMaxPid")]
    public double? PodMaxPid { get; set; }

    /// <summary>Specifies the Topology Manager policy to use. Possible values are none, best-effort, restricted or single-numa-node. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("topologyManagerPolicy")]
    public string? TopologyManagerPolicy { get; set; }
}

/// <summary></summary>
public partial class V1beta1KubernetesClusterNodePoolStatusAtProviderLinuxOsConfigSysctlConfig
{
    /// <summary>The sysctl setting fs.aio-max-nr. Must be between 65536 and 6553500. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("fsAioMaxNr")]
    public double? FsAioMaxNr { get; set; }

    /// <summary>The sysctl setting fs.file-max. Must be between 8192 and 12000500. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("fsFileMax")]
    public double? FsFileMax { get; set; }

    /// <summary>The sysctl setting fs.inotify.max_user_watches. Must be between 781250 and 2097152. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("fsInotifyMaxUserWatches")]
    public double? FsInotifyMaxUserWatches { get; set; }

    /// <summary>The sysctl setting fs.nr_open. Must be between 8192 and 20000500. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("fsNrOpen")]
    public double? FsNrOpen { get; set; }

    /// <summary>The sysctl setting kernel.threads-max. Must be between 20 and 513785. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("kernelThreadsMax")]
    public double? KernelThreadsMax { get; set; }

    /// <summary>The sysctl setting net.core.netdev_max_backlog. Must be between 1000 and 3240000. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netCoreNetdevMaxBacklog")]
    public double? NetCoreNetdevMaxBacklog { get; set; }

    /// <summary>The sysctl setting net.core.optmem_max. Must be between 20480 and 4194304. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netCoreOptmemMax")]
    public double? NetCoreOptmemMax { get; set; }

    /// <summary>The sysctl setting net.core.rmem_default. Must be between 212992 and 134217728. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netCoreRmemDefault")]
    public double? NetCoreRmemDefault { get; set; }

    /// <summary>The sysctl setting net.core.rmem_max. Must be between 212992 and 134217728. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netCoreRmemMax")]
    public double? NetCoreRmemMax { get; set; }

    /// <summary>The sysctl setting net.core.somaxconn. Must be between 4096 and 3240000. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netCoreSomaxconn")]
    public double? NetCoreSomaxconn { get; set; }

    /// <summary>The sysctl setting net.core.wmem_default. Must be between 212992 and 134217728. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netCoreWmemDefault")]
    public double? NetCoreWmemDefault { get; set; }

    /// <summary>The sysctl setting net.core.wmem_max. Must be between 212992 and 134217728. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netCoreWmemMax")]
    public double? NetCoreWmemMax { get; set; }

    /// <summary>The sysctl setting net.ipv4.ip_local_port_range max value. Must be between 32768 and 65535. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4IpLocalPortRangeMax")]
    public double? NetIpv4IpLocalPortRangeMax { get; set; }

    /// <summary>The sysctl setting net.ipv4.ip_local_port_range min value. Must be between 1024 and 60999. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4IpLocalPortRangeMin")]
    public double? NetIpv4IpLocalPortRangeMin { get; set; }

    /// <summary>The sysctl setting net.ipv4.neigh.default.gc_thresh1. Must be between 128 and 80000. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh1")]
    public double? NetIpv4NeighDefaultGcThresh1 { get; set; }

    /// <summary>The sysctl setting net.ipv4.neigh.default.gc_thresh2. Must be between 512 and 90000. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh2")]
    public double? NetIpv4NeighDefaultGcThresh2 { get; set; }

    /// <summary>The sysctl setting net.ipv4.neigh.default.gc_thresh3. Must be between 1024 and 100000. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh3")]
    public double? NetIpv4NeighDefaultGcThresh3 { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_fin_timeout. Must be between 5 and 120. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4TcpFinTimeout")]
    public double? NetIpv4TcpFinTimeout { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_keepalive_intvl. Must be between 10 and 90. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4TcpKeepaliveIntvl")]
    public double? NetIpv4TcpKeepaliveIntvl { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_keepalive_probes. Must be between 1 and 15. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4TcpKeepaliveProbes")]
    public double? NetIpv4TcpKeepaliveProbes { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_keepalive_time. Must be between 30 and 432000. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4TcpKeepaliveTime")]
    public double? NetIpv4TcpKeepaliveTime { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_max_syn_backlog. Must be between 128 and 3240000. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4TcpMaxSynBacklog")]
    public double? NetIpv4TcpMaxSynBacklog { get; set; }

    /// <summary>The sysctl setting net.ipv4.tcp_max_tw_buckets. Must be between 8000 and 1440000. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4TcpMaxTwBuckets")]
    public double? NetIpv4TcpMaxTwBuckets { get; set; }

    /// <summary>Is sysctl setting net.ipv4.tcp_tw_reuse enabled? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netIpv4TcpTwReuse")]
    public bool? NetIpv4TcpTwReuse { get; set; }

    /// <summary>The sysctl setting net.netfilter.nf_conntrack_buckets. Must be between 65536 and 524288. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netNetfilterNfConntrackBuckets")]
    public double? NetNetfilterNfConntrackBuckets { get; set; }

    /// <summary>The sysctl setting net.netfilter.nf_conntrack_max. Must be between 131072 and 2097152. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("netNetfilterNfConntrackMax")]
    public double? NetNetfilterNfConntrackMax { get; set; }

    /// <summary>The sysctl setting vm.max_map_count. Must be between 65530 and 262144. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmMaxMapCount")]
    public double? VmMaxMapCount { get; set; }

    /// <summary>The sysctl setting vm.swappiness. Must be between 0 and 100. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSwappiness")]
    public double? VmSwappiness { get; set; }

    /// <summary>The sysctl setting vm.vfs_cache_pressure. Must be between 0 and 100. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmVfsCachePressure")]
    public double? VmVfsCachePressure { get; set; }
}

/// <summary></summary>
public partial class V1beta1KubernetesClusterNodePoolStatusAtProviderLinuxOsConfig
{
    /// <summary>Specifies the size of swap file on each node in MB. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("swapFileSizeMb")]
    public double? SwapFileSizeMb { get; set; }

    /// <summary>A sysctl_config block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sysctlConfig")]
    public IList<V1beta1KubernetesClusterNodePoolStatusAtProviderLinuxOsConfigSysctlConfig>? SysctlConfig { get; set; }

    /// <summary>specifies the defrag configuration for Transparent Huge Page. Possible values are always, defer, defer+madvise, madvise and never. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("transparentHugePageDefrag")]
    public string? TransparentHugePageDefrag { get; set; }

    /// <summary>Specifies the Transparent Huge Page enabled configuration. Possible values are always, madvise and never. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("transparentHugePageEnabled")]
    public string? TransparentHugePageEnabled { get; set; }
}

/// <summary></summary>
public partial class V1beta1KubernetesClusterNodePoolStatusAtProviderNodeNetworkProfileAllowedHostPorts
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
public partial class V1beta1KubernetesClusterNodePoolStatusAtProviderNodeNetworkProfile
{
    /// <summary>One or more allowed_host_ports blocks as defined below.</summary>
    [JsonPropertyName("allowedHostPorts")]
    public IList<V1beta1KubernetesClusterNodePoolStatusAtProviderNodeNetworkProfileAllowedHostPorts>? AllowedHostPorts { get; set; }

    /// <summary>A list of Application Security Group IDs which should be associated with this Node Pool.</summary>
    [JsonPropertyName("applicationSecurityGroupIds")]
    public IList<string>? ApplicationSecurityGroupIds { get; set; }

    /// <summary>Specifies a mapping of tags to the instance-level public IPs. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("nodePublicIpTags")]
    public IDictionary<string, string>? NodePublicIpTags { get; set; }
}

/// <summary></summary>
public partial class V1beta1KubernetesClusterNodePoolStatusAtProviderUpgradeSettings
{
    /// <summary>The maximum number or percentage of nodes which will be added to the Node Pool size during an upgrade.</summary>
    [JsonPropertyName("maxSurge")]
    public string? MaxSurge { get; set; }
}

/// <summary></summary>
public partial class V1beta1KubernetesClusterNodePoolStatusAtProviderWindowsProfile
{
    /// <summary>Should the Windows nodes in this Node Pool have outbound NAT enabled? Defaults to true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("outboundNatEnabled")]
    public bool? OutboundNatEnabled { get; set; }
}

/// <summary></summary>
public partial class V1beta1KubernetesClusterNodePoolStatusAtProvider
{
    /// <summary>Specifies the ID of the Capacity Reservation Group where this Node Pool should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("capacityReservationGroupId")]
    public string? CapacityReservationGroupId { get; set; }

    /// <summary>Specifies whether to trust a Custom CA.</summary>
    [JsonPropertyName("customCaTrustEnabled")]
    public bool? CustomCaTrustEnabled { get; set; }

    /// <summary>Whether to enable auto-scaler.</summary>
    [JsonPropertyName("enableAutoScaling")]
    public bool? EnableAutoScaling { get; set; }

    /// <summary>Should the nodes in this Node Pool have host encryption enabled? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("enableHostEncryption")]
    public bool? EnableHostEncryption { get; set; }

    /// <summary>Should each node have a Public IP Address? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("enableNodePublicIp")]
    public bool? EnableNodePublicIp { get; set; }

    /// <summary>The Eviction Policy which should be used for Virtual Machines within the Virtual Machine Scale Set powering this Node Pool. Possible values are Deallocate and Delete. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>Should the nodes in this Node Pool have Federal Information Processing Standard enabled? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("fipsEnabled")]
    public bool? FipsEnabled { get; set; }

    /// <summary>Specifies the GPU MIG instance profile for supported GPU VM SKU. The allowed values are MIG1g, MIG2g, MIG3g, MIG4g and MIG7g. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("gpuInstance")]
    public string? GpuInstance { get; set; }

    /// <summary>The fully qualified resource ID of the Dedicated Host Group to provision virtual machines from. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hostGroupId")]
    public string? HostGroupId { get; set; }

    /// <summary>The ID of the Kubernetes Cluster Node Pool.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A kubelet_config block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("kubeletConfig")]
    public IList<V1beta1KubernetesClusterNodePoolStatusAtProviderKubeletConfig>? KubeletConfig { get; set; }

    /// <summary>The type of disk used by kubelet. Possible values are OS and Temporary.</summary>
    [JsonPropertyName("kubeletDiskType")]
    public string? KubeletDiskType { get; set; }

    /// <summary>The ID of the Kubernetes Cluster where this Node Pool should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("kubernetesClusterId")]
    public string? KubernetesClusterId { get; set; }

    /// <summary>A linux_os_config block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("linuxOsConfig")]
    public IList<V1beta1KubernetesClusterNodePoolStatusAtProviderLinuxOsConfig>? LinuxOsConfig { get; set; }

    /// <summary>The maximum number of nodes which should exist within this Node Pool. Valid values are between 0 and 1000 and must be greater than or equal to min_count.</summary>
    [JsonPropertyName("maxCount")]
    public double? MaxCount { get; set; }

    /// <summary>The maximum number of pods that can run on each agent. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("maxPods")]
    public double? MaxPods { get; set; }

    /// <summary>A base64-encoded string which will be written to /etc/motd after decoding. This allows customization of the message of the day for Linux nodes. It cannot be specified for Windows nodes and must be a static string (i.e. will be printed raw and not executed as a script). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("messageOfTheDay")]
    public string? MessageOfTheDay { get; set; }

    /// <summary>The minimum number of nodes which should exist within this Node Pool. Valid values are between 0 and 1000 and must be less than or equal to max_count.</summary>
    [JsonPropertyName("minCount")]
    public double? MinCount { get; set; }

    /// <summary>Should this Node Pool be used for System or User resources? Possible values are System and User. Defaults to User.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>The initial number of nodes which should exist within this Node Pool. Valid values are between 0 and 1000 (inclusive) for user pools and between 1 and 1000 (inclusive) for system pools and must be a value in the range min_count - max_count.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>A map of Kubernetes labels which should be applied to nodes in this Node Pool.</summary>
    [JsonPropertyName("nodeLabels")]
    public IDictionary<string, string>? NodeLabels { get; set; }

    /// <summary>A node_network_profile block as documented below.</summary>
    [JsonPropertyName("nodeNetworkProfile")]
    public IList<V1beta1KubernetesClusterNodePoolStatusAtProviderNodeNetworkProfile>? NodeNetworkProfile { get; set; }

    /// <summary>Resource ID for the Public IP Addresses Prefix for the nodes in this Node Pool. enable_node_public_ip should be true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("nodePublicIpPrefixId")]
    public string? NodePublicIpPrefixId { get; set; }

    /// <summary>A list of Kubernetes taints which should be applied to nodes in the agent pool (e.g key=value:NoSchedule).</summary>
    [JsonPropertyName("nodeTaints")]
    public IList<string>? NodeTaints { get; set; }

    /// <summary>Version of Kubernetes used for the Agents. If not specified, the latest recommended version will be used at provisioning time (but won't auto-upgrade). AKS does not require an exact patch version to be specified, minor version aliases such as 1.22 are also supported. - The minor version's latest GA patch is automatically chosen in that case. More details can be found in the documentation.</summary>
    [JsonPropertyName("orchestratorVersion")]
    public string? OrchestratorVersion { get; set; }

    /// <summary>The Agent Operating System disk size in GB. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("osDiskSizeGb")]
    public double? OsDiskSizeGb { get; set; }

    /// <summary>The type of disk which should be used for the Operating System. Possible values are Ephemeral and Managed. Defaults to Managed. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("osDiskType")]
    public string? OsDiskType { get; set; }

    /// <summary>Specifies the OS SKU used by the agent pool. Possible values are AzureLinux, Ubuntu, Windows2019 and Windows2022. If not specified, the default is Ubuntu if OSType=Linux or Windows2019 if OSType=Windows. And the default Windows OSSKU will be changed to Windows2022 after Windows2019 is deprecated. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("osSku")]
    public string? OsSku { get; set; }

    /// <summary>The Operating System which should be used for this Node Pool. Changing this forces a new resource to be created. Possible values are Linux and Windows. Defaults to Linux.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>The ID of the Subnet where the pods in the Node Pool should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("podSubnetId")]
    public string? PodSubnetId { get; set; }

    /// <summary>The Priority for Virtual Machines within the Virtual Machine Scale Set that powers this Node Pool. Possible values are Regular and Spot. Defaults to Regular. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>The ID of the Proximity Placement Group where the Virtual Machine Scale Set that powers this Node Pool will be placed. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("proximityPlacementGroupId")]
    public string? ProximityPlacementGroupId { get; set; }

    /// <summary>Specifies how the node pool should deal with scaled-down nodes. Allowed values are Delete and Deallocate. Defaults to Delete.</summary>
    [JsonPropertyName("scaleDownMode")]
    public string? ScaleDownMode { get; set; }

    /// <summary>The ID of the Snapshot which should be used to create this Node Pool. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>The maximum price you're willing to pay in USD per Virtual Machine. Valid values are -1 (the current on-demand price for a Virtual Machine) or a positive value with up to five decimal places. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("spotMaxPrice")]
    public double? SpotMaxPrice { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Used to specify whether the UltraSSD is enabled in the Node Pool. Defaults to false. See the documentation for more information. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ultraSsdEnabled")]
    public bool? UltraSsdEnabled { get; set; }

    /// <summary>A upgrade_settings block as documented below.</summary>
    [JsonPropertyName("upgradeSettings")]
    public IList<V1beta1KubernetesClusterNodePoolStatusAtProviderUpgradeSettings>? UpgradeSettings { get; set; }

    /// <summary>The SKU which should be used for the Virtual Machines used in this Node Pool. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }

    /// <summary>The ID of the Subnet where this Node Pool should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vnetSubnetId")]
    public string? VnetSubnetId { get; set; }

    /// <summary>A windows_profile block as documented below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("windowsProfile")]
    public IList<V1beta1KubernetesClusterNodePoolStatusAtProviderWindowsProfile>? WindowsProfile { get; set; }

    /// <summary>Used to specify the workload runtime. Allowed values are OCIContainer, WasmWasi and KataMshvVmIsolation.</summary>
    [JsonPropertyName("workloadRuntime")]
    public string? WorkloadRuntime { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this Kubernetes Cluster Node Pool should be located. Changing this forces a new Kubernetes Cluster Node Pool to be created.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1KubernetesClusterNodePoolStatusConditions
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

/// <summary>KubernetesClusterNodePoolStatus defines the observed state of KubernetesClusterNodePool.</summary>
public partial class V1beta1KubernetesClusterNodePoolStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1KubernetesClusterNodePoolStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1KubernetesClusterNodePoolStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>KubernetesClusterNodePool is the Schema for the KubernetesClusterNodePools API. Manages a Node Pool within a Kubernetes Cluster</summary>
public partial class V1beta1KubernetesClusterNodePool : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1KubernetesClusterNodePoolSpec>, IStatus<V1beta1KubernetesClusterNodePoolStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "KubernetesClusterNodePool";
    public const string KubeGroup = "containerservice.azure.upbound.io";
    public const string KubePluralName = "kubernetesclusternodepools";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>KubernetesClusterNodePoolSpec defines the desired state of KubernetesClusterNodePool</summary>
    [JsonPropertyName("spec")]
    public V1beta1KubernetesClusterNodePoolSpec Spec { get; set; }

    /// <summary>KubernetesClusterNodePoolStatus defines the observed state of KubernetesClusterNodePool.</summary>
    [JsonPropertyName("status")]
    public V1beta1KubernetesClusterNodePoolStatus? Status { get; set; }
}