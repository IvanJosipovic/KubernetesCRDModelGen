using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containerservice.azure.com;
/// <summary>Storage version of v1api20240901.ManagedClusterAADProfile For more details see [managed AAD on AKS](https://docs.microsoft.com/azure/aks/managed-aad).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecAadProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("adminGroupObjectIDs")]
    public IList<string>? AdminGroupObjectIDs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientAppID")]
    public string? ClientAppID { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableAzureRBAC")]
    public bool? EnableAzureRBAC { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managed")]
    public bool? Managed { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serverAppID")]
    public string? ServerAppID { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serverAppSecret")]
    public string? ServerAppSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantID")]
    public string? TenantID { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterAddonProfile A Kubernetes add-on profile for a managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecAddonProfiles
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("config")]
    public IDictionary<string, string>? Config { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>CapacityReservationGroupReference: AKS will associate the specified agent pool with the Capacity Reservation Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecAgentPoolProfilesCapacityReservationGroupReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>SourceResourceReference: This is the ARM ID of the source object to be used to create the target object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecAgentPoolProfilesCreationDataSourceResourceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240901.CreationData Data used when creating a target resource from a source resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecAgentPoolProfilesCreationData
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SourceResourceReference: This is the ARM ID of the source object to be used to create the target object.</summary>
    [JsonPropertyName("sourceResourceReference")]
    public V1api20240901storageManagedClusterSpecAgentPoolProfilesCreationDataSourceResourceReference? SourceResourceReference { get; set; }
}

/// <summary>HostGroupReference: This is of the form: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}. For more information see [Azure dedicated hosts](https://docs.microsoft.com/azure/virtual-machines/dedicated-hosts).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecAgentPoolProfilesHostGroupReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240901.KubeletConfig See [AKS custom node configuration](https://docs.microsoft.com/azure/aks/custom-node-configuration) for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecAgentPoolProfilesKubeletConfig
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedUnsafeSysctls")]
    public IList<string>? AllowedUnsafeSysctls { get; set; }

    /// <summary></summary>
    [JsonPropertyName("containerLogMaxFiles")]
    public int? ContainerLogMaxFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("containerLogMaxSizeMB")]
    public int? ContainerLogMaxSizeMB { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cpuCfsQuota")]
    public bool? CpuCfsQuota { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cpuCfsQuotaPeriod")]
    public string? CpuCfsQuotaPeriod { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cpuManagerPolicy")]
    public string? CpuManagerPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failSwapOn")]
    public bool? FailSwapOn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imageGcHighThreshold")]
    public int? ImageGcHighThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imageGcLowThreshold")]
    public int? ImageGcLowThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podMaxPids")]
    public int? PodMaxPids { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topologyManagerPolicy")]
    public string? TopologyManagerPolicy { get; set; }
}

/// <summary>Storage version of v1api20240901.SysctlConfig Sysctl settings for Linux agent nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecAgentPoolProfilesLinuxOSConfigSysctls
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fsAioMaxNr")]
    public int? FsAioMaxNr { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fsFileMax")]
    public int? FsFileMax { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fsInotifyMaxUserWatches")]
    public int? FsInotifyMaxUserWatches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fsNrOpen")]
    public int? FsNrOpen { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kernelThreadsMax")]
    public int? KernelThreadsMax { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netCoreNetdevMaxBacklog")]
    public int? NetCoreNetdevMaxBacklog { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netCoreOptmemMax")]
    public int? NetCoreOptmemMax { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netCoreRmemDefault")]
    public int? NetCoreRmemDefault { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netCoreRmemMax")]
    public int? NetCoreRmemMax { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netCoreSomaxconn")]
    public int? NetCoreSomaxconn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netCoreWmemDefault")]
    public int? NetCoreWmemDefault { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netCoreWmemMax")]
    public int? NetCoreWmemMax { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netIpv4IpLocalPortRange")]
    public string? NetIpv4IpLocalPortRange { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh1")]
    public int? NetIpv4NeighDefaultGcThresh1 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh2")]
    public int? NetIpv4NeighDefaultGcThresh2 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh3")]
    public int? NetIpv4NeighDefaultGcThresh3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netIpv4TcpFinTimeout")]
    public int? NetIpv4TcpFinTimeout { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netIpv4TcpKeepaliveProbes")]
    public int? NetIpv4TcpKeepaliveProbes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netIpv4TcpKeepaliveTime")]
    public int? NetIpv4TcpKeepaliveTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netIpv4TcpMaxSynBacklog")]
    public int? NetIpv4TcpMaxSynBacklog { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netIpv4TcpMaxTwBuckets")]
    public int? NetIpv4TcpMaxTwBuckets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netIpv4TcpTwReuse")]
    public bool? NetIpv4TcpTwReuse { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netIpv4TcpkeepaliveIntvl")]
    public int? NetIpv4TcpkeepaliveIntvl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netNetfilterNfConntrackBuckets")]
    public int? NetNetfilterNfConntrackBuckets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netNetfilterNfConntrackMax")]
    public int? NetNetfilterNfConntrackMax { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmMaxMapCount")]
    public int? VmMaxMapCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmSwappiness")]
    public int? VmSwappiness { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmVfsCachePressure")]
    public int? VmVfsCachePressure { get; set; }
}

/// <summary>Storage version of v1api20240901.LinuxOSConfig See [AKS custom node configuration](https://docs.microsoft.com/azure/aks/custom-node-configuration) for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecAgentPoolProfilesLinuxOSConfig
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("swapFileSizeMB")]
    public int? SwapFileSizeMB { get; set; }

    /// <summary>Storage version of v1api20240901.SysctlConfig Sysctl settings for Linux agent nodes.</summary>
    [JsonPropertyName("sysctls")]
    public V1api20240901storageManagedClusterSpecAgentPoolProfilesLinuxOSConfigSysctls? Sysctls { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transparentHugePageDefrag")]
    public string? TransparentHugePageDefrag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transparentHugePageEnabled")]
    public string? TransparentHugePageEnabled { get; set; }
}

/// <summary>Storage version of v1api20240901.PortRange The port range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecAgentPoolProfilesNetworkProfileAllowedHostPorts
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("portEnd")]
    public int? PortEnd { get; set; }

    /// <summary></summary>
    [JsonPropertyName("portStart")]
    public int? PortStart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecAgentPoolProfilesNetworkProfileApplicationSecurityGroupsReferences
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240901.IPTag Contains the IPTag associated with the object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecAgentPoolProfilesNetworkProfileNodePublicIPTags
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipTagType")]
    public string? IpTagType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>Storage version of v1api20240901.AgentPoolNetworkProfile Network settings of an agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecAgentPoolProfilesNetworkProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedHostPorts")]
    public IList<V1api20240901storageManagedClusterSpecAgentPoolProfilesNetworkProfileAllowedHostPorts>? AllowedHostPorts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applicationSecurityGroupsReferences")]
    public IList<V1api20240901storageManagedClusterSpecAgentPoolProfilesNetworkProfileApplicationSecurityGroupsReferences>? ApplicationSecurityGroupsReferences { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodePublicIPTags")]
    public IList<V1api20240901storageManagedClusterSpecAgentPoolProfilesNetworkProfileNodePublicIPTags>? NodePublicIPTags { get; set; }
}

/// <summary>NodePublicIPPrefixReference: This is of the form: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes/{publicIPPrefixName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecAgentPoolProfilesNodePublicIPPrefixReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PodSubnetReference: If omitted, pod IPs are statically assigned on the node subnet (see vnetSubnetID for more details). This is of the form: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecAgentPoolProfilesPodSubnetReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240901.PowerState Describes the Power State of the cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecAgentPoolProfilesPowerState
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

/// <summary>ProximityPlacementGroupReference: The ID for Proximity Placement Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecAgentPoolProfilesProximityPlacementGroupReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240901.AgentPoolSecurityProfile The security settings of an agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecAgentPoolProfilesSecurityProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableVTPM")]
    public bool? EnableVTPM { get; set; }
}

/// <summary>Storage version of v1api20240901.AgentPoolUpgradeSettings Settings for upgrading an agentpool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecAgentPoolProfilesUpgradeSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("drainTimeoutInMinutes")]
    public int? DrainTimeoutInMinutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxSurge")]
    public string? MaxSurge { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeSoakDurationInMinutes")]
    public int? NodeSoakDurationInMinutes { get; set; }
}

/// <summary>VnetSubnetReference: If this is not specified, a VNET and subnet will be generated and used. If no podSubnetID is specified, this applies to nodes and pods, otherwise it applies to just nodes. This is of the form: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecAgentPoolProfilesVnetSubnetReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240901.AgentPoolWindowsProfile The Windows agent pool's specific profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecAgentPoolProfilesWindowsProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableOutboundNat")]
    public bool? DisableOutboundNat { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterAgentPoolProfile Profile for the container service agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecAgentPoolProfiles
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>CapacityReservationGroupReference: AKS will associate the specified agent pool with the Capacity Reservation Group.</summary>
    [JsonPropertyName("capacityReservationGroupReference")]
    public V1api20240901storageManagedClusterSpecAgentPoolProfilesCapacityReservationGroupReference? CapacityReservationGroupReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>Storage version of v1api20240901.CreationData Data used when creating a target resource from a source resource.</summary>
    [JsonPropertyName("creationData")]
    public V1api20240901storageManagedClusterSpecAgentPoolProfilesCreationData? CreationData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableAutoScaling")]
    public bool? EnableAutoScaling { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryptionAtHost")]
    public bool? EnableEncryptionAtHost { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableFIPS")]
    public bool? EnableFIPS { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableNodePublicIP")]
    public bool? EnableNodePublicIP { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableUltraSSD")]
    public bool? EnableUltraSSD { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gpuInstanceProfile")]
    public string? GpuInstanceProfile { get; set; }

    /// <summary>HostGroupReference: This is of the form: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}. For more information see [Azure dedicated hosts](https://docs.microsoft.com/azure/virtual-machines/dedicated-hosts).</summary>
    [JsonPropertyName("hostGroupReference")]
    public V1api20240901storageManagedClusterSpecAgentPoolProfilesHostGroupReference? HostGroupReference { get; set; }

    /// <summary>Storage version of v1api20240901.KubeletConfig See [AKS custom node configuration](https://docs.microsoft.com/azure/aks/custom-node-configuration) for more details.</summary>
    [JsonPropertyName("kubeletConfig")]
    public V1api20240901storageManagedClusterSpecAgentPoolProfilesKubeletConfig? KubeletConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kubeletDiskType")]
    public string? KubeletDiskType { get; set; }

    /// <summary>Storage version of v1api20240901.LinuxOSConfig See [AKS custom node configuration](https://docs.microsoft.com/azure/aks/custom-node-configuration) for more details.</summary>
    [JsonPropertyName("linuxOSConfig")]
    public V1api20240901storageManagedClusterSpecAgentPoolProfilesLinuxOSConfig? LinuxOSConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxCount")]
    public int? MaxCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxPods")]
    public int? MaxPods { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minCount")]
    public int? MinCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20240901.AgentPoolNetworkProfile Network settings of an agent pool.</summary>
    [JsonPropertyName("networkProfile")]
    public V1api20240901storageManagedClusterSpecAgentPoolProfilesNetworkProfile? NetworkProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeLabels")]
    public IDictionary<string, string>? NodeLabels { get; set; }

    /// <summary>NodePublicIPPrefixReference: This is of the form: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes/{publicIPPrefixName}</summary>
    [JsonPropertyName("nodePublicIPPrefixReference")]
    public V1api20240901storageManagedClusterSpecAgentPoolProfilesNodePublicIPPrefixReference? NodePublicIPPrefixReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeTaints")]
    public IList<string>? NodeTaints { get; set; }

    /// <summary></summary>
    [JsonPropertyName("orchestratorVersion")]
    public string? OrchestratorVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("osDiskSizeGB")]
    public int? OsDiskSizeGB { get; set; }

    /// <summary></summary>
    [JsonPropertyName("osDiskType")]
    public string? OsDiskType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("osSKU")]
    public string? OsSKU { get; set; }

    /// <summary></summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>PodSubnetReference: If omitted, pod IPs are statically assigned on the node subnet (see vnetSubnetID for more details). This is of the form: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}</summary>
    [JsonPropertyName("podSubnetReference")]
    public V1api20240901storageManagedClusterSpecAgentPoolProfilesPodSubnetReference? PodSubnetReference { get; set; }

    /// <summary>Storage version of v1api20240901.PowerState Describes the Power State of the cluster</summary>
    [JsonPropertyName("powerState")]
    public V1api20240901storageManagedClusterSpecAgentPoolProfilesPowerState? PowerState { get; set; }

    /// <summary>ProximityPlacementGroupReference: The ID for Proximity Placement Group.</summary>
    [JsonPropertyName("proximityPlacementGroupReference")]
    public V1api20240901storageManagedClusterSpecAgentPoolProfilesProximityPlacementGroupReference? ProximityPlacementGroupReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scaleDownMode")]
    public string? ScaleDownMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scaleSetEvictionPolicy")]
    public string? ScaleSetEvictionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scaleSetPriority")]
    public string? ScaleSetPriority { get; set; }

    /// <summary>Storage version of v1api20240901.AgentPoolSecurityProfile The security settings of an agent pool.</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20240901storageManagedClusterSpecAgentPoolProfilesSecurityProfile? SecurityProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotMaxPrice")]
    public double? SpotMaxPrice { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Storage version of v1api20240901.AgentPoolUpgradeSettings Settings for upgrading an agentpool</summary>
    [JsonPropertyName("upgradeSettings")]
    public V1api20240901storageManagedClusterSpecAgentPoolProfilesUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }

    /// <summary>VnetSubnetReference: If this is not specified, a VNET and subnet will be generated and used. If no podSubnetID is specified, this applies to nodes and pods, otherwise it applies to just nodes. This is of the form: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}</summary>
    [JsonPropertyName("vnetSubnetReference")]
    public V1api20240901storageManagedClusterSpecAgentPoolProfilesVnetSubnetReference? VnetSubnetReference { get; set; }

    /// <summary>Storage version of v1api20240901.AgentPoolWindowsProfile The Windows agent pool's specific profile.</summary>
    [JsonPropertyName("windowsProfile")]
    public V1api20240901storageManagedClusterSpecAgentPoolProfilesWindowsProfile? WindowsProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workloadRuntime")]
    public string? WorkloadRuntime { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterAPIServerAccessProfile Access profile for managed cluster API server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecApiServerAccessProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authorizedIPRanges")]
    public IList<string>? AuthorizedIPRanges { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableRunCommand")]
    public bool? DisableRunCommand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enablePrivateCluster")]
    public bool? EnablePrivateCluster { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enablePrivateClusterPublicFQDN")]
    public bool? EnablePrivateClusterPublicFQDN { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateDNSZone")]
    public string? PrivateDNSZone { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterProperties_AutoScalerProfile</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecAutoScalerProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("balance-similar-node-groups")]
    public string? BalanceSimilarNodeGroups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daemonset-eviction-for-empty-nodes")]
    public bool? DaemonsetEvictionForEmptyNodes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daemonset-eviction-for-occupied-nodes")]
    public bool? DaemonsetEvictionForOccupiedNodes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expander")]
    public string? Expander { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignore-daemonsets-utilization")]
    public bool? IgnoreDaemonsetsUtilization { get; set; }

    /// <summary></summary>
    [JsonPropertyName("max-empty-bulk-delete")]
    public string? MaxEmptyBulkDelete { get; set; }

    /// <summary></summary>
    [JsonPropertyName("max-graceful-termination-sec")]
    public string? MaxGracefulTerminationSec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("max-node-provision-time")]
    public string? MaxNodeProvisionTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("max-total-unready-percentage")]
    public string? MaxTotalUnreadyPercentage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("new-pod-scale-up-delay")]
    public string? NewPodScaleUpDelay { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ok-total-unready-count")]
    public string? OkTotalUnreadyCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scale-down-delay-after-add")]
    public string? ScaleDownDelayAfterAdd { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scale-down-delay-after-delete")]
    public string? ScaleDownDelayAfterDelete { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scale-down-delay-after-failure")]
    public string? ScaleDownDelayAfterFailure { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scale-down-unneeded-time")]
    public string? ScaleDownUnneededTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scale-down-unready-time")]
    public string? ScaleDownUnreadyTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scale-down-utilization-threshold")]
    public string? ScaleDownUtilizationThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scan-interval")]
    public string? ScanInterval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skip-nodes-with-local-storage")]
    public string? SkipNodesWithLocalStorage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skip-nodes-with-system-pods")]
    public string? SkipNodesWithSystemPods { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterAutoUpgradeProfile Auto upgrade profile for a managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecAutoUpgradeProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeOSUpgradeChannel")]
    public string? NodeOSUpgradeChannel { get; set; }

    /// <summary></summary>
    [JsonPropertyName("upgradeChannel")]
    public string? UpgradeChannel { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterAzureMonitorProfileKubeStateMetrics Kube State Metrics profile for the Azure Managed Prometheus addon. These optional settings are for the kube-state-metrics pod that is deployed with the addon. See aka.ms/AzureManagedPrometheus-optional-parameters for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecAzureMonitorProfileMetricsKubeStateMetrics
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metricAnnotationsAllowList")]
    public string? MetricAnnotationsAllowList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metricLabelsAllowlist")]
    public string? MetricLabelsAllowlist { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterAzureMonitorProfileMetrics Metrics profile for the Azure Monitor managed service for Prometheus addon. Collect out-of-the-box Kubernetes infrastructure metrics to send to an Azure Monitor Workspace and configure additional scraping for custom targets. See aka.ms/AzureManagedPrometheus for an overview.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecAzureMonitorProfileMetrics
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterAzureMonitorProfileKubeStateMetrics Kube State Metrics profile for the Azure Managed Prometheus addon. These optional settings are for the kube-state-metrics pod that is deployed with the addon. See aka.ms/AzureManagedPrometheus-optional-parameters for details.</summary>
    [JsonPropertyName("kubeStateMetrics")]
    public V1api20240901storageManagedClusterSpecAzureMonitorProfileMetricsKubeStateMetrics? KubeStateMetrics { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterAzureMonitorProfile Azure Monitor addon profiles for monitoring the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecAzureMonitorProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterAzureMonitorProfileMetrics Metrics profile for the Azure Monitor managed service for Prometheus addon. Collect out-of-the-box Kubernetes infrastructure metrics to send to an Azure Monitor Workspace and configure additional scraping for custom targets. See aka.ms/AzureManagedPrometheus for an overview.</summary>
    [JsonPropertyName("metrics")]
    public V1api20240901storageManagedClusterSpecAzureMonitorProfileMetrics? Metrics { get; set; }
}

/// <summary>DiskEncryptionSetReference: This is of the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{encryptionSetName}'</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecDiskEncryptionSetReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240901.ExtendedLocation The complex type of the extended location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecExtendedLocation
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterHTTPProxyConfig Cluster HTTP proxy configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecHttpProxyConfig
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpProxy")]
    public string? HttpProxy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpsProxy")]
    public string? HttpsProxy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("noProxy")]
    public IList<string>? NoProxy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("trustedCa")]
    public string? TrustedCa { get; set; }
}

/// <summary>ResourceReference: The ARM resource id of the delegated resource - internal use only.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecIdentityDelegatedResourcesResourceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240901.DelegatedResource Delegated resource properties - internal use only.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecIdentityDelegatedResources
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("referralResource")]
    public string? ReferralResource { get; set; }

    /// <summary>ResourceReference: The ARM resource id of the delegated resource - internal use only.</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20240901storageManagedClusterSpecIdentityDelegatedResourcesResourceReference? ResourceReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecIdentityUserAssignedIdentitiesReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240901.UserAssignedIdentityDetails Information about the user assigned identity for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecIdentityUserAssignedIdentities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID nolint:recvcheck</summary>
    [JsonPropertyName("reference")]
    public V1api20240901storageManagedClusterSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterIdentity Identity for the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("delegatedResources")]
    public IDictionary<string, V1api20240901storageManagedClusterSpecIdentityDelegatedResources>? DelegatedResources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20240901storageManagedClusterSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>ResourceReference: The resource ID of the user assigned identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecIdentityProfileResourceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240901.UserAssignedIdentity Details about a user assigned identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecIdentityProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>ResourceReference: The resource ID of the user assigned identity.</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20240901storageManagedClusterSpecIdentityProfileResourceReference? ResourceReference { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecIngressProfileWebAppRoutingDnsZoneResourceReferences
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterIngressProfileWebAppRouting Application Routing add-on settings for the ingress profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecIngressProfileWebAppRouting
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dnsZoneResourceReferences")]
    public IList<V1api20240901storageManagedClusterSpecIngressProfileWebAppRoutingDnsZoneResourceReferences>? DnsZoneResourceReferences { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterIngressProfile Ingress profile for the container service cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecIngressProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterIngressProfileWebAppRouting Application Routing add-on settings for the ingress profile.</summary>
    [JsonPropertyName("webAppRouting")]
    public V1api20240901storageManagedClusterSpecIngressProfileWebAppRouting? WebAppRouting { get; set; }
}

/// <summary>Storage version of v1api20240901.ContainerServiceSshPublicKey Contains information about SSH certificate public key data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecLinuxProfileSshPublicKeys
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyData")]
    public string? KeyData { get; set; }
}

/// <summary>Storage version of v1api20240901.ContainerServiceSshConfiguration SSH configuration for Linux-based VMs running on Azure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecLinuxProfileSsh
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicKeys")]
    public IList<V1api20240901storageManagedClusterSpecLinuxProfileSshPublicKeys>? PublicKeys { get; set; }
}

/// <summary>Storage version of v1api20240901.ContainerServiceLinuxProfile Profile for Linux VMs in the container service cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecLinuxProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>Storage version of v1api20240901.ContainerServiceSshConfiguration SSH configuration for Linux-based VMs running on Azure.</summary>
    [JsonPropertyName("ssh")]
    public V1api20240901storageManagedClusterSpecLinuxProfileSsh? Ssh { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterCostAnalysis The cost analysis configuration for the cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecMetricsProfileCostAnalysis
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterMetricsProfile The metrics profile for the ManagedCluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecMetricsProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterCostAnalysis The cost analysis configuration for the cluster</summary>
    [JsonPropertyName("costAnalysis")]
    public V1api20240901storageManagedClusterSpecMetricsProfileCostAnalysis? CostAnalysis { get; set; }
}

/// <summary>Storage version of v1api20240901.AdvancedNetworkingObservability Observability profile to enable advanced network metrics and flow logs with historical contexts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecNetworkProfileAdvancedNetworkingObservability
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20240901.AdvancedNetworkingSecurity Security profile to enable security features on cilium based cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecNetworkProfileAdvancedNetworkingSecurity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20240901.AdvancedNetworking Advanced Networking profile for enabling observability and security feature suite on a cluster. For more information see aka.ms/aksadvancednetworking.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecNetworkProfileAdvancedNetworking
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Storage version of v1api20240901.AdvancedNetworkingObservability Observability profile to enable advanced network metrics and flow logs with historical contexts.</summary>
    [JsonPropertyName("observability")]
    public V1api20240901storageManagedClusterSpecNetworkProfileAdvancedNetworkingObservability? Observability { get; set; }

    /// <summary>Storage version of v1api20240901.AdvancedNetworkingSecurity Security profile to enable security features on cilium based cluster.</summary>
    [JsonPropertyName("security")]
    public V1api20240901storageManagedClusterSpecNetworkProfileAdvancedNetworkingSecurity? Security { get; set; }
}

/// <summary>Reference: The fully qualified Azure resource id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecNetworkProfileLoadBalancerProfileEffectiveOutboundIPsReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240901.ResourceReference A reference to an Azure resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecNetworkProfileLoadBalancerProfileEffectiveOutboundIPs
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: The fully qualified Azure resource id.</summary>
    [JsonPropertyName("reference")]
    public V1api20240901storageManagedClusterSpecNetworkProfileLoadBalancerProfileEffectiveOutboundIPsReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterLoadBalancerProfile_ManagedOutboundIPs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecNetworkProfileLoadBalancerProfileManagedOutboundIPs
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("countIPv6")]
    public int? CountIPv6 { get; set; }
}

/// <summary>Reference: The fully qualified Azure resource id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPPrefixesPublicIPPrefixesReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240901.ResourceReference A reference to an Azure resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPPrefixesPublicIPPrefixes
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: The fully qualified Azure resource id.</summary>
    [JsonPropertyName("reference")]
    public V1api20240901storageManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPPrefixesPublicIPPrefixesReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterLoadBalancerProfile_OutboundIPPrefixes</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPPrefixes
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicIPPrefixes")]
    public IList<V1api20240901storageManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPPrefixesPublicIPPrefixes>? PublicIPPrefixes { get; set; }
}

/// <summary>Reference: The fully qualified Azure resource id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPsPublicIPsReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240901.ResourceReference A reference to an Azure resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPsPublicIPs
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: The fully qualified Azure resource id.</summary>
    [JsonPropertyName("reference")]
    public V1api20240901storageManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPsPublicIPsReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterLoadBalancerProfile_OutboundIPs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPs
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicIPs")]
    public IList<V1api20240901storageManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPsPublicIPs>? PublicIPs { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterLoadBalancerProfile Profile of the managed cluster load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecNetworkProfileLoadBalancerProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allocatedOutboundPorts")]
    public int? AllocatedOutboundPorts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backendPoolType")]
    public string? BackendPoolType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveOutboundIPs")]
    public IList<V1api20240901storageManagedClusterSpecNetworkProfileLoadBalancerProfileEffectiveOutboundIPs>? EffectiveOutboundIPs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableMultipleStandardLoadBalancers")]
    public bool? EnableMultipleStandardLoadBalancers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterLoadBalancerProfile_ManagedOutboundIPs</summary>
    [JsonPropertyName("managedOutboundIPs")]
    public V1api20240901storageManagedClusterSpecNetworkProfileLoadBalancerProfileManagedOutboundIPs? ManagedOutboundIPs { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterLoadBalancerProfile_OutboundIPPrefixes</summary>
    [JsonPropertyName("outboundIPPrefixes")]
    public V1api20240901storageManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPPrefixes? OutboundIPPrefixes { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterLoadBalancerProfile_OutboundIPs</summary>
    [JsonPropertyName("outboundIPs")]
    public V1api20240901storageManagedClusterSpecNetworkProfileLoadBalancerProfileOutboundIPs? OutboundIPs { get; set; }
}

/// <summary>Reference: The fully qualified Azure resource id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecNetworkProfileNatGatewayProfileEffectiveOutboundIPsReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240901.ResourceReference A reference to an Azure resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecNetworkProfileNatGatewayProfileEffectiveOutboundIPs
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: The fully qualified Azure resource id.</summary>
    [JsonPropertyName("reference")]
    public V1api20240901storageManagedClusterSpecNetworkProfileNatGatewayProfileEffectiveOutboundIPsReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterManagedOutboundIPProfile Profile of the managed outbound IP resources of the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecNetworkProfileNatGatewayProfileManagedOutboundIPProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterNATGatewayProfile Profile of the managed cluster NAT gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecNetworkProfileNatGatewayProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveOutboundIPs")]
    public IList<V1api20240901storageManagedClusterSpecNetworkProfileNatGatewayProfileEffectiveOutboundIPs>? EffectiveOutboundIPs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterManagedOutboundIPProfile Profile of the managed outbound IP resources of the managed cluster.</summary>
    [JsonPropertyName("managedOutboundIPProfile")]
    public V1api20240901storageManagedClusterSpecNetworkProfileNatGatewayProfileManagedOutboundIPProfile? ManagedOutboundIPProfile { get; set; }
}

/// <summary>Storage version of v1api20240901.ContainerServiceNetworkProfile Profile of network configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecNetworkProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240901.AdvancedNetworking Advanced Networking profile for enabling observability and security feature suite on a cluster. For more information see aka.ms/aksadvancednetworking.</summary>
    [JsonPropertyName("advancedNetworking")]
    public V1api20240901storageManagedClusterSpecNetworkProfileAdvancedNetworking? AdvancedNetworking { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dnsServiceIP")]
    public string? DnsServiceIP { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipFamilies")]
    public IList<string>? IpFamilies { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterLoadBalancerProfile Profile of the managed cluster load balancer.</summary>
    [JsonPropertyName("loadBalancerProfile")]
    public V1api20240901storageManagedClusterSpecNetworkProfileLoadBalancerProfile? LoadBalancerProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loadBalancerSku")]
    public string? LoadBalancerSku { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterNATGatewayProfile Profile of the managed cluster NAT gateway.</summary>
    [JsonPropertyName("natGatewayProfile")]
    public V1api20240901storageManagedClusterSpecNetworkProfileNatGatewayProfile? NatGatewayProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkDataplane")]
    public string? NetworkDataplane { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkMode")]
    public string? NetworkMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkPlugin")]
    public string? NetworkPlugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkPluginMode")]
    public string? NetworkPluginMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkPolicy")]
    public string? NetworkPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("outboundType")]
    public string? OutboundType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podCidr")]
    public string? PodCidr { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podCidrs")]
    public IList<string>? PodCidrs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceCidr")]
    public string? ServiceCidr { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceCidrs")]
    public IList<string>? ServiceCidrs { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterNodeResourceGroupProfile Node resource group lockdown profile for a managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecNodeResourceGroupProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restrictionLevel")]
    public string? RestrictionLevel { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterOIDCIssuerProfile The OIDC issuer profile of the Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecOidcIssuerProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting map[string]string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap or secret to write to. The configmap or secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>ConfigMapDestination describes the location to store a single configmap value Note: This is similar to: SecretDestination in secrets.go. Changes to one may need to be made to the others as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecOperatorSpecConfigMapsOidcIssuerProfile
{
    /// <summary>Key is the key in the ConfigMap being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes ConfigMap to write to. The ConfigMap will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterOperatorConfigMaps</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecOperatorSpecConfigMaps
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ConfigMapDestination describes the location to store a single configmap value Note: This is similar to: SecretDestination in secrets.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("oidcIssuerProfile")]
    public V1api20240901storageManagedClusterSpecOperatorSpecConfigMapsOidcIssuerProfile? OidcIssuerProfile { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecOperatorSpecSecretExpressions
{
    /// <summary>Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting map[string]string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap or secret to write to. The configmap or secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecOperatorSpecSecretsAdminCredentials
{
    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret to write to. The secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecOperatorSpecSecretsUserCredentials
{
    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret to write to. The secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterOperatorSecrets</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecOperatorSpecSecrets
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("adminCredentials")]
    public V1api20240901storageManagedClusterSpecOperatorSpecSecretsAdminCredentials? AdminCredentials { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to: ConfigMapDestination in configmaps.go. Changes to one may need to be made to the others as well.</summary>
    [JsonPropertyName("userCredentials")]
    public V1api20240901storageManagedClusterSpecOperatorSpecSecretsUserCredentials? UserCredentials { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240901storageManagedClusterSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterOperatorConfigMaps</summary>
    [JsonPropertyName("configMaps")]
    public V1api20240901storageManagedClusterSpecOperatorSpecConfigMaps? ConfigMaps { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240901storageManagedClusterSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterOperatorSecrets</summary>
    [JsonPropertyName("secrets")]
    public V1api20240901storageManagedClusterSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ResourceReference: The resource ID of the user assigned identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentityResourceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240901.UserAssignedIdentity Details about a user assigned identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>ResourceReference: The resource ID of the user assigned identity.</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20240901storageManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentityResourceReference? ResourceReference { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterPodIdentity Details about the pod identity assigned to the Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecPodIdentityProfileUserAssignedIdentities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bindingSelector")]
    public string? BindingSelector { get; set; }

    /// <summary>Storage version of v1api20240901.UserAssignedIdentity Details about a user assigned identity.</summary>
    [JsonPropertyName("identity")]
    public V1api20240901storageManagedClusterSpecPodIdentityProfileUserAssignedIdentitiesIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterPodIdentityException See [disable AAD Pod Identity for a specific Pod/Application](https://azure.github.io/aad-pod-identity/docs/configure/application_exception/) for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecPodIdentityProfileUserAssignedIdentityExceptions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podLabels")]
    public IDictionary<string, string>? PodLabels { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterPodIdentityProfile See [use AAD pod identity](https://docs.microsoft.com/azure/aks/use-azure-ad-pod-identity) for more details on pod identity integration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecPodIdentityProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowNetworkPluginKubenet")]
    public bool? AllowNetworkPluginKubenet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20240901storageManagedClusterSpecPodIdentityProfileUserAssignedIdentities>? UserAssignedIdentities { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentityExceptions")]
    public IList<V1api20240901storageManagedClusterSpecPodIdentityProfileUserAssignedIdentityExceptions>? UserAssignedIdentityExceptions { get; set; }
}

/// <summary>Reference: The ID of the private link resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecPrivateLinkResourcesReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240901.PrivateLinkResource A private link resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecPrivateLinkResources
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference: The ID of the private link resource.</summary>
    [JsonPropertyName("reference")]
    public V1api20240901storageManagedClusterSpecPrivateLinkResourcesReference? Reference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiredMembers")]
    public IList<string>? RequiredMembers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>KeyVaultResourceReference: Resource ID of key vault. When keyVaultNetworkAccess is `Private`, this field is required and must be a valid resource ID. When keyVaultNetworkAccess is `Public`, leave the field empty.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecSecurityProfileAzureKeyVaultKmsKeyVaultResourceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240901.AzureKeyVaultKms Azure Key Vault key management service settings for the security profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecSecurityProfileAzureKeyVaultKms
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyVaultNetworkAccess")]
    public string? KeyVaultNetworkAccess { get; set; }

    /// <summary>KeyVaultResourceReference: Resource ID of key vault. When keyVaultNetworkAccess is `Private`, this field is required and must be a valid resource ID. When keyVaultNetworkAccess is `Public`, leave the field empty.</summary>
    [JsonPropertyName("keyVaultResourceReference")]
    public V1api20240901storageManagedClusterSpecSecurityProfileAzureKeyVaultKmsKeyVaultResourceReference? KeyVaultResourceReference { get; set; }
}

/// <summary>LogAnalyticsWorkspaceResourceReference: Resource ID of the Log Analytics workspace to be associated with Microsoft Defender. When Microsoft Defender is enabled, this field is required and must be a valid workspace resource ID. When Microsoft Defender is disabled, leave the field empty.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecSecurityProfileDefenderLogAnalyticsWorkspaceResourceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterSecurityProfileDefenderSecurityMonitoring Microsoft Defender settings for the security profile threat detection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecSecurityProfileDefenderSecurityMonitoring
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterSecurityProfileDefender Microsoft Defender settings for the security profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecSecurityProfileDefender
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>LogAnalyticsWorkspaceResourceReference: Resource ID of the Log Analytics workspace to be associated with Microsoft Defender. When Microsoft Defender is enabled, this field is required and must be a valid workspace resource ID. When Microsoft Defender is disabled, leave the field empty.</summary>
    [JsonPropertyName("logAnalyticsWorkspaceResourceReference")]
    public V1api20240901storageManagedClusterSpecSecurityProfileDefenderLogAnalyticsWorkspaceResourceReference? LogAnalyticsWorkspaceResourceReference { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterSecurityProfileDefenderSecurityMonitoring Microsoft Defender settings for the security profile threat detection.</summary>
    [JsonPropertyName("securityMonitoring")]
    public V1api20240901storageManagedClusterSpecSecurityProfileDefenderSecurityMonitoring? SecurityMonitoring { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterSecurityProfileImageCleaner Image Cleaner removes unused images from nodes, freeing up disk space and helping to reduce attack surface area. Here are settings for the security profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecSecurityProfileImageCleaner
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("intervalHours")]
    public int? IntervalHours { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterSecurityProfileWorkloadIdentity Workload identity settings for the security profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecSecurityProfileWorkloadIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterSecurityProfile Security profile for the container service cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecSecurityProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240901.AzureKeyVaultKms Azure Key Vault key management service settings for the security profile.</summary>
    [JsonPropertyName("azureKeyVaultKms")]
    public V1api20240901storageManagedClusterSpecSecurityProfileAzureKeyVaultKms? AzureKeyVaultKms { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterSecurityProfileDefender Microsoft Defender settings for the security profile.</summary>
    [JsonPropertyName("defender")]
    public V1api20240901storageManagedClusterSpecSecurityProfileDefender? Defender { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterSecurityProfileImageCleaner Image Cleaner removes unused images from nodes, freeing up disk space and helping to reduce attack surface area. Here are settings for the security profile.</summary>
    [JsonPropertyName("imageCleaner")]
    public V1api20240901storageManagedClusterSpecSecurityProfileImageCleaner? ImageCleaner { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterSecurityProfileWorkloadIdentity Workload identity settings for the security profile.</summary>
    [JsonPropertyName("workloadIdentity")]
    public V1api20240901storageManagedClusterSpecSecurityProfileWorkloadIdentity? WorkloadIdentity { get; set; }
}

/// <summary>KeyVaultReference: The resource ID of the Key Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecServiceMeshProfileIstioCertificateAuthorityPluginKeyVaultReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240901.IstioPluginCertificateAuthority Plugin certificates information for Service Mesh.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecServiceMeshProfileIstioCertificateAuthorityPlugin
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("certChainObjectName")]
    public string? CertChainObjectName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("certObjectName")]
    public string? CertObjectName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyObjectName")]
    public string? KeyObjectName { get; set; }

    /// <summary>KeyVaultReference: The resource ID of the Key Vault.</summary>
    [JsonPropertyName("keyVaultReference")]
    public V1api20240901storageManagedClusterSpecServiceMeshProfileIstioCertificateAuthorityPluginKeyVaultReference? KeyVaultReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rootCertObjectName")]
    public string? RootCertObjectName { get; set; }
}

/// <summary>Storage version of v1api20240901.IstioCertificateAuthority Istio Service Mesh Certificate Authority (CA) configuration. For now, we only support plugin certificates as described here https://aka.ms/asm-plugin-ca</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecServiceMeshProfileIstioCertificateAuthority
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240901.IstioPluginCertificateAuthority Plugin certificates information for Service Mesh.</summary>
    [JsonPropertyName("plugin")]
    public V1api20240901storageManagedClusterSpecServiceMeshProfileIstioCertificateAuthorityPlugin? Plugin { get; set; }
}

/// <summary>Storage version of v1api20240901.IstioEgressGateway Istio egress gateway configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecServiceMeshProfileIstioComponentsEgressGateways
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20240901.IstioIngressGateway Istio ingress gateway configuration. For now, we support up to one external ingress gateway named `aks-istio-ingressgateway-external` and one internal ingress gateway named `aks-istio-ingressgateway-internal`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecServiceMeshProfileIstioComponentsIngressGateways
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>Storage version of v1api20240901.IstioComponents Istio components configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecServiceMeshProfileIstioComponents
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("egressGateways")]
    public IList<V1api20240901storageManagedClusterSpecServiceMeshProfileIstioComponentsEgressGateways>? EgressGateways { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ingressGateways")]
    public IList<V1api20240901storageManagedClusterSpecServiceMeshProfileIstioComponentsIngressGateways>? IngressGateways { get; set; }
}

/// <summary>Storage version of v1api20240901.IstioServiceMesh Istio service mesh configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecServiceMeshProfileIstio
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240901.IstioCertificateAuthority Istio Service Mesh Certificate Authority (CA) configuration. For now, we only support plugin certificates as described here https://aka.ms/asm-plugin-ca</summary>
    [JsonPropertyName("certificateAuthority")]
    public V1api20240901storageManagedClusterSpecServiceMeshProfileIstioCertificateAuthority? CertificateAuthority { get; set; }

    /// <summary>Storage version of v1api20240901.IstioComponents Istio components configuration.</summary>
    [JsonPropertyName("components")]
    public V1api20240901storageManagedClusterSpecServiceMeshProfileIstioComponents? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revisions")]
    public IList<string>? Revisions { get; set; }
}

/// <summary>Storage version of v1api20240901.ServiceMeshProfile Service mesh profile for a managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecServiceMeshProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240901.IstioServiceMesh Istio service mesh configuration.</summary>
    [JsonPropertyName("istio")]
    public V1api20240901storageManagedClusterSpecServiceMeshProfileIstio? Istio { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecServicePrincipalProfileSecret
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterServicePrincipalProfile Information about a service principal identity for the cluster to use for manipulating Azure APIs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecServicePrincipalProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
    [JsonPropertyName("secret")]
    public V1api20240901storageManagedClusterSpecServicePrincipalProfileSecret? Secret { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterSKU The SKU of a Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecSku
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterStorageProfileBlobCSIDriver AzureBlob CSI Driver settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecStorageProfileBlobCSIDriver
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterStorageProfileDiskCSIDriver AzureDisk CSI Driver settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecStorageProfileDiskCSIDriver
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterStorageProfileFileCSIDriver AzureFile CSI Driver settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecStorageProfileFileCSIDriver
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterStorageProfileSnapshotController Snapshot Controller settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecStorageProfileSnapshotController
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterStorageProfile Storage profile for the container service cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecStorageProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterStorageProfileBlobCSIDriver AzureBlob CSI Driver settings for the storage profile.</summary>
    [JsonPropertyName("blobCSIDriver")]
    public V1api20240901storageManagedClusterSpecStorageProfileBlobCSIDriver? BlobCSIDriver { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterStorageProfileDiskCSIDriver AzureDisk CSI Driver settings for the storage profile.</summary>
    [JsonPropertyName("diskCSIDriver")]
    public V1api20240901storageManagedClusterSpecStorageProfileDiskCSIDriver? DiskCSIDriver { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterStorageProfileFileCSIDriver AzureFile CSI Driver settings for the storage profile.</summary>
    [JsonPropertyName("fileCSIDriver")]
    public V1api20240901storageManagedClusterSpecStorageProfileFileCSIDriver? FileCSIDriver { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterStorageProfileSnapshotController Snapshot Controller settings for the storage profile.</summary>
    [JsonPropertyName("snapshotController")]
    public V1api20240901storageManagedClusterSpecStorageProfileSnapshotController? SnapshotController { get; set; }
}

/// <summary>Storage version of v1api20240901.UpgradeOverrideSettings Settings for overrides when upgrading a cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecUpgradeSettingsOverrideSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceUpgrade")]
    public bool? ForceUpgrade { get; set; }

    /// <summary></summary>
    [JsonPropertyName("until")]
    public string? Until { get; set; }
}

/// <summary>Storage version of v1api20240901.ClusterUpgradeSettings Settings for upgrading a cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecUpgradeSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240901.UpgradeOverrideSettings Settings for overrides when upgrading a cluster.</summary>
    [JsonPropertyName("overrideSettings")]
    public V1api20240901storageManagedClusterSpecUpgradeSettingsOverrideSettings? OverrideSettings { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecWindowsProfileAdminPassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20240901.WindowsGmsaProfile Windows gMSA Profile in the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecWindowsProfileGmsaProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dnsServer")]
    public string? DnsServer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rootDomainName")]
    public string? RootDomainName { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterWindowsProfile Profile for Windows VMs in the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecWindowsProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on. nolint:recvcheck</summary>
    [JsonPropertyName("adminPassword")]
    public V1api20240901storageManagedClusterSpecWindowsProfileAdminPassword? AdminPassword { get; set; }

    /// <summary></summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableCSIProxy")]
    public bool? EnableCSIProxy { get; set; }

    /// <summary>Storage version of v1api20240901.WindowsGmsaProfile Windows gMSA Profile in the managed cluster.</summary>
    [JsonPropertyName("gmsaProfile")]
    public V1api20240901storageManagedClusterSpecWindowsProfileGmsaProfile? GmsaProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterWorkloadAutoScalerProfileKeda KEDA (Kubernetes Event-driven Autoscaling) settings for the workload auto-scaler profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecWorkloadAutoScalerProfileKeda
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterWorkloadAutoScalerProfileVerticalPodAutoscaler VPA (Vertical Pod Autoscaler) settings for the workload auto-scaler profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecWorkloadAutoScalerProfileVerticalPodAutoscaler
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterWorkloadAutoScalerProfile Workload Auto-scaler profile for the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpecWorkloadAutoScalerProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterWorkloadAutoScalerProfileKeda KEDA (Kubernetes Event-driven Autoscaling) settings for the workload auto-scaler profile.</summary>
    [JsonPropertyName("keda")]
    public V1api20240901storageManagedClusterSpecWorkloadAutoScalerProfileKeda? Keda { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterWorkloadAutoScalerProfileVerticalPodAutoscaler VPA (Vertical Pod Autoscaler) settings for the workload auto-scaler profile.</summary>
    [JsonPropertyName("verticalPodAutoscaler")]
    public V1api20240901storageManagedClusterSpecWorkloadAutoScalerProfileVerticalPodAutoscaler? VerticalPodAutoscaler { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedCluster_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterAADProfile For more details see [managed AAD on AKS](https://docs.microsoft.com/azure/aks/managed-aad).</summary>
    [JsonPropertyName("aadProfile")]
    public V1api20240901storageManagedClusterSpecAadProfile? AadProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("addonProfiles")]
    public IDictionary<string, V1api20240901storageManagedClusterSpecAddonProfiles>? AddonProfiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("agentPoolProfiles")]
    public IList<V1api20240901storageManagedClusterSpecAgentPoolProfiles>? AgentPoolProfiles { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterAPIServerAccessProfile Access profile for managed cluster API server.</summary>
    [JsonPropertyName("apiServerAccessProfile")]
    public V1api20240901storageManagedClusterSpecApiServerAccessProfile? ApiServerAccessProfile { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterProperties_AutoScalerProfile</summary>
    [JsonPropertyName("autoScalerProfile")]
    public V1api20240901storageManagedClusterSpecAutoScalerProfile? AutoScalerProfile { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterAutoUpgradeProfile Auto upgrade profile for a managed cluster.</summary>
    [JsonPropertyName("autoUpgradeProfile")]
    public V1api20240901storageManagedClusterSpecAutoUpgradeProfile? AutoUpgradeProfile { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterAzureMonitorProfile Azure Monitor addon profiles for monitoring the managed cluster.</summary>
    [JsonPropertyName("azureMonitorProfile")]
    public V1api20240901storageManagedClusterSpecAzureMonitorProfile? AzureMonitorProfile { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableLocalAccounts")]
    public bool? DisableLocalAccounts { get; set; }

    /// <summary>DiskEncryptionSetReference: This is of the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/diskEncryptionSets/{encryptionSetName}'</summary>
    [JsonPropertyName("diskEncryptionSetReference")]
    public V1api20240901storageManagedClusterSpecDiskEncryptionSetReference? DiskEncryptionSetReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dnsPrefix")]
    public string? DnsPrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enablePodSecurityPolicy")]
    public bool? EnablePodSecurityPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableRBAC")]
    public bool? EnableRBAC { get; set; }

    /// <summary>Storage version of v1api20240901.ExtendedLocation The complex type of the extended location.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20240901storageManagedClusterSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fqdnSubdomain")]
    public string? FqdnSubdomain { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterHTTPProxyConfig Cluster HTTP proxy configuration.</summary>
    [JsonPropertyName("httpProxyConfig")]
    public V1api20240901storageManagedClusterSpecHttpProxyConfig? HttpProxyConfig { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterIdentity Identity for the managed cluster.</summary>
    [JsonPropertyName("identity")]
    public V1api20240901storageManagedClusterSpecIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("identityProfile")]
    public IDictionary<string, V1api20240901storageManagedClusterSpecIdentityProfile>? IdentityProfile { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterIngressProfile Ingress profile for the container service cluster.</summary>
    [JsonPropertyName("ingressProfile")]
    public V1api20240901storageManagedClusterSpecIngressProfile? IngressProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kubernetesVersion")]
    public string? KubernetesVersion { get; set; }

    /// <summary>Storage version of v1api20240901.ContainerServiceLinuxProfile Profile for Linux VMs in the container service cluster.</summary>
    [JsonPropertyName("linuxProfile")]
    public V1api20240901storageManagedClusterSpecLinuxProfile? LinuxProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterMetricsProfile The metrics profile for the ManagedCluster.</summary>
    [JsonPropertyName("metricsProfile")]
    public V1api20240901storageManagedClusterSpecMetricsProfile? MetricsProfile { get; set; }

    /// <summary>Storage version of v1api20240901.ContainerServiceNetworkProfile Profile of network configuration.</summary>
    [JsonPropertyName("networkProfile")]
    public V1api20240901storageManagedClusterSpecNetworkProfile? NetworkProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeResourceGroup")]
    public string? NodeResourceGroup { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterNodeResourceGroupProfile Node resource group lockdown profile for a managed cluster.</summary>
    [JsonPropertyName("nodeResourceGroupProfile")]
    public V1api20240901storageManagedClusterSpecNodeResourceGroupProfile? NodeResourceGroupProfile { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterOIDCIssuerProfile The OIDC issuer profile of the Managed Cluster.</summary>
    [JsonPropertyName("oidcIssuerProfile")]
    public V1api20240901storageManagedClusterSpecOidcIssuerProfile? OidcIssuerProfile { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240901storageManagedClusterSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20240901storageManagedClusterSpecOwner Owner { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterPodIdentityProfile See [use AAD pod identity](https://docs.microsoft.com/azure/aks/use-azure-ad-pod-identity) for more details on pod identity integration.</summary>
    [JsonPropertyName("podIdentityProfile")]
    public V1api20240901storageManagedClusterSpecPodIdentityProfile? PodIdentityProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateLinkResources")]
    public IList<V1api20240901storageManagedClusterSpecPrivateLinkResources>? PrivateLinkResources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterSecurityProfile Security profile for the container service cluster.</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20240901storageManagedClusterSpecSecurityProfile? SecurityProfile { get; set; }

    /// <summary>Storage version of v1api20240901.ServiceMeshProfile Service mesh profile for a managed cluster.</summary>
    [JsonPropertyName("serviceMeshProfile")]
    public V1api20240901storageManagedClusterSpecServiceMeshProfile? ServiceMeshProfile { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterServicePrincipalProfile Information about a service principal identity for the cluster to use for manipulating Azure APIs.</summary>
    [JsonPropertyName("servicePrincipalProfile")]
    public V1api20240901storageManagedClusterSpecServicePrincipalProfile? ServicePrincipalProfile { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterSKU The SKU of a Managed Cluster.</summary>
    [JsonPropertyName("sku")]
    public V1api20240901storageManagedClusterSpecSku? Sku { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterStorageProfile Storage profile for the container service cluster.</summary>
    [JsonPropertyName("storageProfile")]
    public V1api20240901storageManagedClusterSpecStorageProfile? StorageProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("supportPlan")]
    public string? SupportPlan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Storage version of v1api20240901.ClusterUpgradeSettings Settings for upgrading a cluster.</summary>
    [JsonPropertyName("upgradeSettings")]
    public V1api20240901storageManagedClusterSpecUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterWindowsProfile Profile for Windows VMs in the managed cluster.</summary>
    [JsonPropertyName("windowsProfile")]
    public V1api20240901storageManagedClusterSpecWindowsProfile? WindowsProfile { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterWorkloadAutoScalerProfile Workload Auto-scaler profile for the managed cluster.</summary>
    [JsonPropertyName("workloadAutoScalerProfile")]
    public V1api20240901storageManagedClusterSpecWorkloadAutoScalerProfile? WorkloadAutoScalerProfile { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterAADProfile_STATUS For more details see [managed AAD on AKS](https://docs.microsoft.com/azure/aks/managed-aad).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusAadProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("adminGroupObjectIDs")]
    public IList<string>? AdminGroupObjectIDs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientAppID")]
    public string? ClientAppID { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableAzureRBAC")]
    public bool? EnableAzureRBAC { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managed")]
    public bool? Managed { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serverAppID")]
    public string? ServerAppID { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serverAppSecret")]
    public string? ServerAppSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantID")]
    public string? TenantID { get; set; }
}

/// <summary>Storage version of v1api20240901.UserAssignedIdentity_STATUS Details about a user assigned identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusAddonProfilesIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterAddonProfile_STATUS A Kubernetes add-on profile for a managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusAddonProfiles
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("config")]
    public IDictionary<string, string>? Config { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Storage version of v1api20240901.UserAssignedIdentity_STATUS Details about a user assigned identity.</summary>
    [JsonPropertyName("identity")]
    public V1api20240901storageManagedClusterStatusAddonProfilesIdentity? Identity { get; set; }
}

/// <summary>Storage version of v1api20240901.CreationData_STATUS Data used when creating a target resource from a source resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusAgentPoolProfilesCreationData
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceResourceId")]
    public string? SourceResourceId { get; set; }
}

/// <summary>Storage version of v1api20240901.KubeletConfig_STATUS See [AKS custom node configuration](https://docs.microsoft.com/azure/aks/custom-node-configuration) for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusAgentPoolProfilesKubeletConfig
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedUnsafeSysctls")]
    public IList<string>? AllowedUnsafeSysctls { get; set; }

    /// <summary></summary>
    [JsonPropertyName("containerLogMaxFiles")]
    public int? ContainerLogMaxFiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("containerLogMaxSizeMB")]
    public int? ContainerLogMaxSizeMB { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cpuCfsQuota")]
    public bool? CpuCfsQuota { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cpuCfsQuotaPeriod")]
    public string? CpuCfsQuotaPeriod { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cpuManagerPolicy")]
    public string? CpuManagerPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failSwapOn")]
    public bool? FailSwapOn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imageGcHighThreshold")]
    public int? ImageGcHighThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imageGcLowThreshold")]
    public int? ImageGcLowThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podMaxPids")]
    public int? PodMaxPids { get; set; }

    /// <summary></summary>
    [JsonPropertyName("topologyManagerPolicy")]
    public string? TopologyManagerPolicy { get; set; }
}

/// <summary>Storage version of v1api20240901.SysctlConfig_STATUS Sysctl settings for Linux agent nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusAgentPoolProfilesLinuxOSConfigSysctls
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fsAioMaxNr")]
    public int? FsAioMaxNr { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fsFileMax")]
    public int? FsFileMax { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fsInotifyMaxUserWatches")]
    public int? FsInotifyMaxUserWatches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fsNrOpen")]
    public int? FsNrOpen { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kernelThreadsMax")]
    public int? KernelThreadsMax { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netCoreNetdevMaxBacklog")]
    public int? NetCoreNetdevMaxBacklog { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netCoreOptmemMax")]
    public int? NetCoreOptmemMax { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netCoreRmemDefault")]
    public int? NetCoreRmemDefault { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netCoreRmemMax")]
    public int? NetCoreRmemMax { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netCoreSomaxconn")]
    public int? NetCoreSomaxconn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netCoreWmemDefault")]
    public int? NetCoreWmemDefault { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netCoreWmemMax")]
    public int? NetCoreWmemMax { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netIpv4IpLocalPortRange")]
    public string? NetIpv4IpLocalPortRange { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh1")]
    public int? NetIpv4NeighDefaultGcThresh1 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh2")]
    public int? NetIpv4NeighDefaultGcThresh2 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netIpv4NeighDefaultGcThresh3")]
    public int? NetIpv4NeighDefaultGcThresh3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netIpv4TcpFinTimeout")]
    public int? NetIpv4TcpFinTimeout { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netIpv4TcpKeepaliveProbes")]
    public int? NetIpv4TcpKeepaliveProbes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netIpv4TcpKeepaliveTime")]
    public int? NetIpv4TcpKeepaliveTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netIpv4TcpMaxSynBacklog")]
    public int? NetIpv4TcpMaxSynBacklog { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netIpv4TcpMaxTwBuckets")]
    public int? NetIpv4TcpMaxTwBuckets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netIpv4TcpTwReuse")]
    public bool? NetIpv4TcpTwReuse { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netIpv4TcpkeepaliveIntvl")]
    public int? NetIpv4TcpkeepaliveIntvl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netNetfilterNfConntrackBuckets")]
    public int? NetNetfilterNfConntrackBuckets { get; set; }

    /// <summary></summary>
    [JsonPropertyName("netNetfilterNfConntrackMax")]
    public int? NetNetfilterNfConntrackMax { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmMaxMapCount")]
    public int? VmMaxMapCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmSwappiness")]
    public int? VmSwappiness { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmVfsCachePressure")]
    public int? VmVfsCachePressure { get; set; }
}

/// <summary>Storage version of v1api20240901.LinuxOSConfig_STATUS See [AKS custom node configuration](https://docs.microsoft.com/azure/aks/custom-node-configuration) for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusAgentPoolProfilesLinuxOSConfig
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("swapFileSizeMB")]
    public int? SwapFileSizeMB { get; set; }

    /// <summary>Storage version of v1api20240901.SysctlConfig_STATUS Sysctl settings for Linux agent nodes.</summary>
    [JsonPropertyName("sysctls")]
    public V1api20240901storageManagedClusterStatusAgentPoolProfilesLinuxOSConfigSysctls? Sysctls { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transparentHugePageDefrag")]
    public string? TransparentHugePageDefrag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transparentHugePageEnabled")]
    public string? TransparentHugePageEnabled { get; set; }
}

/// <summary>Storage version of v1api20240901.PortRange_STATUS The port range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusAgentPoolProfilesNetworkProfileAllowedHostPorts
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("portEnd")]
    public int? PortEnd { get; set; }

    /// <summary></summary>
    [JsonPropertyName("portStart")]
    public int? PortStart { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>Storage version of v1api20240901.IPTag_STATUS Contains the IPTag associated with the object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusAgentPoolProfilesNetworkProfileNodePublicIPTags
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipTagType")]
    public string? IpTagType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>Storage version of v1api20240901.AgentPoolNetworkProfile_STATUS Network settings of an agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusAgentPoolProfilesNetworkProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedHostPorts")]
    public IList<V1api20240901storageManagedClusterStatusAgentPoolProfilesNetworkProfileAllowedHostPorts>? AllowedHostPorts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applicationSecurityGroups")]
    public IList<string>? ApplicationSecurityGroups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodePublicIPTags")]
    public IList<V1api20240901storageManagedClusterStatusAgentPoolProfilesNetworkProfileNodePublicIPTags>? NodePublicIPTags { get; set; }
}

/// <summary>Storage version of v1api20240901.PowerState_STATUS Describes the Power State of the cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusAgentPoolProfilesPowerState
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

/// <summary>Storage version of v1api20240901.AgentPoolSecurityProfile_STATUS The security settings of an agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusAgentPoolProfilesSecurityProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableVTPM")]
    public bool? EnableVTPM { get; set; }
}

/// <summary>Storage version of v1api20240901.AgentPoolUpgradeSettings_STATUS Settings for upgrading an agentpool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusAgentPoolProfilesUpgradeSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("drainTimeoutInMinutes")]
    public int? DrainTimeoutInMinutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxSurge")]
    public string? MaxSurge { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeSoakDurationInMinutes")]
    public int? NodeSoakDurationInMinutes { get; set; }
}

/// <summary>Storage version of v1api20240901.AgentPoolWindowsProfile_STATUS The Windows agent pool's specific profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusAgentPoolProfilesWindowsProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableOutboundNat")]
    public bool? DisableOutboundNat { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterAgentPoolProfile_STATUS Profile for the container service agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusAgentPoolProfiles
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capacityReservationGroupID")]
    public string? CapacityReservationGroupID { get; set; }

    /// <summary></summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>Storage version of v1api20240901.CreationData_STATUS Data used when creating a target resource from a source resource.</summary>
    [JsonPropertyName("creationData")]
    public V1api20240901storageManagedClusterStatusAgentPoolProfilesCreationData? CreationData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("currentOrchestratorVersion")]
    public string? CurrentOrchestratorVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableAutoScaling")]
    public bool? EnableAutoScaling { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableEncryptionAtHost")]
    public bool? EnableEncryptionAtHost { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableFIPS")]
    public bool? EnableFIPS { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableNodePublicIP")]
    public bool? EnableNodePublicIP { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableUltraSSD")]
    public bool? EnableUltraSSD { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gpuInstanceProfile")]
    public string? GpuInstanceProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostGroupID")]
    public string? HostGroupID { get; set; }

    /// <summary>Storage version of v1api20240901.KubeletConfig_STATUS See [AKS custom node configuration](https://docs.microsoft.com/azure/aks/custom-node-configuration) for more details.</summary>
    [JsonPropertyName("kubeletConfig")]
    public V1api20240901storageManagedClusterStatusAgentPoolProfilesKubeletConfig? KubeletConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kubeletDiskType")]
    public string? KubeletDiskType { get; set; }

    /// <summary>Storage version of v1api20240901.LinuxOSConfig_STATUS See [AKS custom node configuration](https://docs.microsoft.com/azure/aks/custom-node-configuration) for more details.</summary>
    [JsonPropertyName("linuxOSConfig")]
    public V1api20240901storageManagedClusterStatusAgentPoolProfilesLinuxOSConfig? LinuxOSConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxCount")]
    public int? MaxCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxPods")]
    public int? MaxPods { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minCount")]
    public int? MinCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20240901.AgentPoolNetworkProfile_STATUS Network settings of an agent pool.</summary>
    [JsonPropertyName("networkProfile")]
    public V1api20240901storageManagedClusterStatusAgentPoolProfilesNetworkProfile? NetworkProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeImageVersion")]
    public string? NodeImageVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeLabels")]
    public IDictionary<string, string>? NodeLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodePublicIPPrefixID")]
    public string? NodePublicIPPrefixID { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeTaints")]
    public IList<string>? NodeTaints { get; set; }

    /// <summary></summary>
    [JsonPropertyName("orchestratorVersion")]
    public string? OrchestratorVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("osDiskSizeGB")]
    public int? OsDiskSizeGB { get; set; }

    /// <summary></summary>
    [JsonPropertyName("osDiskType")]
    public string? OsDiskType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("osSKU")]
    public string? OsSKU { get; set; }

    /// <summary></summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podSubnetID")]
    public string? PodSubnetID { get; set; }

    /// <summary>Storage version of v1api20240901.PowerState_STATUS Describes the Power State of the cluster</summary>
    [JsonPropertyName("powerState")]
    public V1api20240901storageManagedClusterStatusAgentPoolProfilesPowerState? PowerState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("proximityPlacementGroupID")]
    public string? ProximityPlacementGroupID { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scaleDownMode")]
    public string? ScaleDownMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scaleSetEvictionPolicy")]
    public string? ScaleSetEvictionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scaleSetPriority")]
    public string? ScaleSetPriority { get; set; }

    /// <summary>Storage version of v1api20240901.AgentPoolSecurityProfile_STATUS The security settings of an agent pool.</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20240901storageManagedClusterStatusAgentPoolProfilesSecurityProfile? SecurityProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spotMaxPrice")]
    public double? SpotMaxPrice { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Storage version of v1api20240901.AgentPoolUpgradeSettings_STATUS Settings for upgrading an agentpool</summary>
    [JsonPropertyName("upgradeSettings")]
    public V1api20240901storageManagedClusterStatusAgentPoolProfilesUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vnetSubnetID")]
    public string? VnetSubnetID { get; set; }

    /// <summary>Storage version of v1api20240901.AgentPoolWindowsProfile_STATUS The Windows agent pool's specific profile.</summary>
    [JsonPropertyName("windowsProfile")]
    public V1api20240901storageManagedClusterStatusAgentPoolProfilesWindowsProfile? WindowsProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workloadRuntime")]
    public string? WorkloadRuntime { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterAPIServerAccessProfile_STATUS Access profile for managed cluster API server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusApiServerAccessProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authorizedIPRanges")]
    public IList<string>? AuthorizedIPRanges { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableRunCommand")]
    public bool? DisableRunCommand { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enablePrivateCluster")]
    public bool? EnablePrivateCluster { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enablePrivateClusterPublicFQDN")]
    public bool? EnablePrivateClusterPublicFQDN { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateDNSZone")]
    public string? PrivateDNSZone { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterProperties_AutoScalerProfile_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusAutoScalerProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("balance-similar-node-groups")]
    public string? BalanceSimilarNodeGroups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daemonset-eviction-for-empty-nodes")]
    public bool? DaemonsetEvictionForEmptyNodes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daemonset-eviction-for-occupied-nodes")]
    public bool? DaemonsetEvictionForOccupiedNodes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("expander")]
    public string? Expander { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ignore-daemonsets-utilization")]
    public bool? IgnoreDaemonsetsUtilization { get; set; }

    /// <summary></summary>
    [JsonPropertyName("max-empty-bulk-delete")]
    public string? MaxEmptyBulkDelete { get; set; }

    /// <summary></summary>
    [JsonPropertyName("max-graceful-termination-sec")]
    public string? MaxGracefulTerminationSec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("max-node-provision-time")]
    public string? MaxNodeProvisionTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("max-total-unready-percentage")]
    public string? MaxTotalUnreadyPercentage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("new-pod-scale-up-delay")]
    public string? NewPodScaleUpDelay { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ok-total-unready-count")]
    public string? OkTotalUnreadyCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scale-down-delay-after-add")]
    public string? ScaleDownDelayAfterAdd { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scale-down-delay-after-delete")]
    public string? ScaleDownDelayAfterDelete { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scale-down-delay-after-failure")]
    public string? ScaleDownDelayAfterFailure { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scale-down-unneeded-time")]
    public string? ScaleDownUnneededTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scale-down-unready-time")]
    public string? ScaleDownUnreadyTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scale-down-utilization-threshold")]
    public string? ScaleDownUtilizationThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scan-interval")]
    public string? ScanInterval { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skip-nodes-with-local-storage")]
    public string? SkipNodesWithLocalStorage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("skip-nodes-with-system-pods")]
    public string? SkipNodesWithSystemPods { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterAutoUpgradeProfile_STATUS Auto upgrade profile for a managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusAutoUpgradeProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeOSUpgradeChannel")]
    public string? NodeOSUpgradeChannel { get; set; }

    /// <summary></summary>
    [JsonPropertyName("upgradeChannel")]
    public string? UpgradeChannel { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterAzureMonitorProfileKubeStateMetrics_STATUS Kube State Metrics profile for the Azure Managed Prometheus addon. These optional settings are for the kube-state-metrics pod that is deployed with the addon. See aka.ms/AzureManagedPrometheus-optional-parameters for details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusAzureMonitorProfileMetricsKubeStateMetrics
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metricAnnotationsAllowList")]
    public string? MetricAnnotationsAllowList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metricLabelsAllowlist")]
    public string? MetricLabelsAllowlist { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterAzureMonitorProfileMetrics_STATUS Metrics profile for the Azure Monitor managed service for Prometheus addon. Collect out-of-the-box Kubernetes infrastructure metrics to send to an Azure Monitor Workspace and configure additional scraping for custom targets. See aka.ms/AzureManagedPrometheus for an overview.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusAzureMonitorProfileMetrics
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterAzureMonitorProfileKubeStateMetrics_STATUS Kube State Metrics profile for the Azure Managed Prometheus addon. These optional settings are for the kube-state-metrics pod that is deployed with the addon. See aka.ms/AzureManagedPrometheus-optional-parameters for details.</summary>
    [JsonPropertyName("kubeStateMetrics")]
    public V1api20240901storageManagedClusterStatusAzureMonitorProfileMetricsKubeStateMetrics? KubeStateMetrics { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterAzureMonitorProfile_STATUS Azure Monitor addon profiles for monitoring the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusAzureMonitorProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterAzureMonitorProfileMetrics_STATUS Metrics profile for the Azure Monitor managed service for Prometheus addon. Collect out-of-the-box Kubernetes infrastructure metrics to send to an Azure Monitor Workspace and configure additional scraping for custom targets. See aka.ms/AzureManagedPrometheus for an overview.</summary>
    [JsonPropertyName("metrics")]
    public V1api20240901storageManagedClusterStatusAzureMonitorProfileMetrics? Metrics { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Reason for the condition's last transition. Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Severity with which to treat failures of this type of condition. For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False. This is omitted in all cases when Status == Unknown</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Storage version of v1api20240901.ExtendedLocation_STATUS The complex type of the extended location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusExtendedLocation
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterHTTPProxyConfig_STATUS Cluster HTTP proxy configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusHttpProxyConfig
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpProxy")]
    public string? HttpProxy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpsProxy")]
    public string? HttpsProxy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("noProxy")]
    public IList<string>? NoProxy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("trustedCa")]
    public string? TrustedCa { get; set; }
}

/// <summary>Storage version of v1api20240901.DelegatedResource_STATUS Delegated resource properties - internal use only.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusIdentityDelegatedResources
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("referralResource")]
    public string? ReferralResource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterIdentity_UserAssignedIdentities_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusIdentityUserAssignedIdentities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterIdentity_STATUS Identity for the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("delegatedResources")]
    public IDictionary<string, V1api20240901storageManagedClusterStatusIdentityDelegatedResources>? DelegatedResources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20240901storageManagedClusterStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Storage version of v1api20240901.UserAssignedIdentity_STATUS Details about a user assigned identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusIdentityProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v1api20240901.UserAssignedIdentity_STATUS Details about a user assigned identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusIngressProfileWebAppRoutingIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterIngressProfileWebAppRouting_STATUS Application Routing add-on settings for the ingress profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusIngressProfileWebAppRouting
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dnsZoneResourceIds")]
    public IList<string>? DnsZoneResourceIds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Storage version of v1api20240901.UserAssignedIdentity_STATUS Details about a user assigned identity.</summary>
    [JsonPropertyName("identity")]
    public V1api20240901storageManagedClusterStatusIngressProfileWebAppRoutingIdentity? Identity { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterIngressProfile_STATUS Ingress profile for the container service cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusIngressProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterIngressProfileWebAppRouting_STATUS Application Routing add-on settings for the ingress profile.</summary>
    [JsonPropertyName("webAppRouting")]
    public V1api20240901storageManagedClusterStatusIngressProfileWebAppRouting? WebAppRouting { get; set; }
}

/// <summary>Storage version of v1api20240901.ContainerServiceSshPublicKey_STATUS Contains information about SSH certificate public key data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusLinuxProfileSshPublicKeys
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyData")]
    public string? KeyData { get; set; }
}

/// <summary>Storage version of v1api20240901.ContainerServiceSshConfiguration_STATUS SSH configuration for Linux-based VMs running on Azure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusLinuxProfileSsh
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicKeys")]
    public IList<V1api20240901storageManagedClusterStatusLinuxProfileSshPublicKeys>? PublicKeys { get; set; }
}

/// <summary>Storage version of v1api20240901.ContainerServiceLinuxProfile_STATUS Profile for Linux VMs in the container service cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusLinuxProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>Storage version of v1api20240901.ContainerServiceSshConfiguration_STATUS SSH configuration for Linux-based VMs running on Azure.</summary>
    [JsonPropertyName("ssh")]
    public V1api20240901storageManagedClusterStatusLinuxProfileSsh? Ssh { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterCostAnalysis_STATUS The cost analysis configuration for the cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusMetricsProfileCostAnalysis
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterMetricsProfile_STATUS The metrics profile for the ManagedCluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusMetricsProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterCostAnalysis_STATUS The cost analysis configuration for the cluster</summary>
    [JsonPropertyName("costAnalysis")]
    public V1api20240901storageManagedClusterStatusMetricsProfileCostAnalysis? CostAnalysis { get; set; }
}

/// <summary>Storage version of v1api20240901.AdvancedNetworkingObservability_STATUS Observability profile to enable advanced network metrics and flow logs with historical contexts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusNetworkProfileAdvancedNetworkingObservability
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20240901.AdvancedNetworkingSecurity_STATUS Security profile to enable security features on cilium based cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusNetworkProfileAdvancedNetworkingSecurity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20240901.AdvancedNetworking_STATUS Advanced Networking profile for enabling observability and security feature suite on a cluster. For more information see aka.ms/aksadvancednetworking.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusNetworkProfileAdvancedNetworking
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Storage version of v1api20240901.AdvancedNetworkingObservability_STATUS Observability profile to enable advanced network metrics and flow logs with historical contexts.</summary>
    [JsonPropertyName("observability")]
    public V1api20240901storageManagedClusterStatusNetworkProfileAdvancedNetworkingObservability? Observability { get; set; }

    /// <summary>Storage version of v1api20240901.AdvancedNetworkingSecurity_STATUS Security profile to enable security features on cilium based cluster.</summary>
    [JsonPropertyName("security")]
    public V1api20240901storageManagedClusterStatusNetworkProfileAdvancedNetworkingSecurity? Security { get; set; }
}

/// <summary>Storage version of v1api20240901.ResourceReference_STATUS A reference to an Azure resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusNetworkProfileLoadBalancerProfileEffectiveOutboundIPs
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterLoadBalancerProfile_ManagedOutboundIPs_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusNetworkProfileLoadBalancerProfileManagedOutboundIPs
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("countIPv6")]
    public int? CountIPv6 { get; set; }
}

/// <summary>Storage version of v1api20240901.ResourceReference_STATUS A reference to an Azure resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPPrefixesPublicIPPrefixes
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterLoadBalancerProfile_OutboundIPPrefixes_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPPrefixes
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicIPPrefixes")]
    public IList<V1api20240901storageManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPPrefixesPublicIPPrefixes>? PublicIPPrefixes { get; set; }
}

/// <summary>Storage version of v1api20240901.ResourceReference_STATUS A reference to an Azure resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPsPublicIPs
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterLoadBalancerProfile_OutboundIPs_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPs
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicIPs")]
    public IList<V1api20240901storageManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPsPublicIPs>? PublicIPs { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterLoadBalancerProfile_STATUS Profile of the managed cluster load balancer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusNetworkProfileLoadBalancerProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allocatedOutboundPorts")]
    public int? AllocatedOutboundPorts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backendPoolType")]
    public string? BackendPoolType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveOutboundIPs")]
    public IList<V1api20240901storageManagedClusterStatusNetworkProfileLoadBalancerProfileEffectiveOutboundIPs>? EffectiveOutboundIPs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableMultipleStandardLoadBalancers")]
    public bool? EnableMultipleStandardLoadBalancers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterLoadBalancerProfile_ManagedOutboundIPs_STATUS</summary>
    [JsonPropertyName("managedOutboundIPs")]
    public V1api20240901storageManagedClusterStatusNetworkProfileLoadBalancerProfileManagedOutboundIPs? ManagedOutboundIPs { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterLoadBalancerProfile_OutboundIPPrefixes_STATUS</summary>
    [JsonPropertyName("outboundIPPrefixes")]
    public V1api20240901storageManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPPrefixes? OutboundIPPrefixes { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterLoadBalancerProfile_OutboundIPs_STATUS</summary>
    [JsonPropertyName("outboundIPs")]
    public V1api20240901storageManagedClusterStatusNetworkProfileLoadBalancerProfileOutboundIPs? OutboundIPs { get; set; }
}

/// <summary>Storage version of v1api20240901.ResourceReference_STATUS A reference to an Azure resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusNetworkProfileNatGatewayProfileEffectiveOutboundIPs
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterManagedOutboundIPProfile_STATUS Profile of the managed outbound IP resources of the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusNetworkProfileNatGatewayProfileManagedOutboundIPProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterNATGatewayProfile_STATUS Profile of the managed cluster NAT gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusNetworkProfileNatGatewayProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveOutboundIPs")]
    public IList<V1api20240901storageManagedClusterStatusNetworkProfileNatGatewayProfileEffectiveOutboundIPs>? EffectiveOutboundIPs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterManagedOutboundIPProfile_STATUS Profile of the managed outbound IP resources of the managed cluster.</summary>
    [JsonPropertyName("managedOutboundIPProfile")]
    public V1api20240901storageManagedClusterStatusNetworkProfileNatGatewayProfileManagedOutboundIPProfile? ManagedOutboundIPProfile { get; set; }
}

/// <summary>Storage version of v1api20240901.ContainerServiceNetworkProfile_STATUS Profile of network configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusNetworkProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240901.AdvancedNetworking_STATUS Advanced Networking profile for enabling observability and security feature suite on a cluster. For more information see aka.ms/aksadvancednetworking.</summary>
    [JsonPropertyName("advancedNetworking")]
    public V1api20240901storageManagedClusterStatusNetworkProfileAdvancedNetworking? AdvancedNetworking { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dnsServiceIP")]
    public string? DnsServiceIP { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipFamilies")]
    public IList<string>? IpFamilies { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterLoadBalancerProfile_STATUS Profile of the managed cluster load balancer.</summary>
    [JsonPropertyName("loadBalancerProfile")]
    public V1api20240901storageManagedClusterStatusNetworkProfileLoadBalancerProfile? LoadBalancerProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loadBalancerSku")]
    public string? LoadBalancerSku { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterNATGatewayProfile_STATUS Profile of the managed cluster NAT gateway.</summary>
    [JsonPropertyName("natGatewayProfile")]
    public V1api20240901storageManagedClusterStatusNetworkProfileNatGatewayProfile? NatGatewayProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkDataplane")]
    public string? NetworkDataplane { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkMode")]
    public string? NetworkMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkPlugin")]
    public string? NetworkPlugin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkPluginMode")]
    public string? NetworkPluginMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkPolicy")]
    public string? NetworkPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("outboundType")]
    public string? OutboundType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podCidr")]
    public string? PodCidr { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podCidrs")]
    public IList<string>? PodCidrs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceCidr")]
    public string? ServiceCidr { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceCidrs")]
    public IList<string>? ServiceCidrs { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterNodeResourceGroupProfile_STATUS Node resource group lockdown profile for a managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusNodeResourceGroupProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restrictionLevel")]
    public string? RestrictionLevel { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterOIDCIssuerProfile_STATUS The OIDC issuer profile of the Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusOidcIssuerProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("issuerURL")]
    public string? IssuerURL { get; set; }
}

/// <summary>Storage version of v1api20240901.UserAssignedIdentity_STATUS Details about a user assigned identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterPodIdentityProvisioningErrorBody_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfoErrorErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterPodIdentityProvisioningErrorBody_STATUS An error response from the pod identity provisioning.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfoErrorError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20240901storageManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfoErrorErrorDetails>? Details { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterPodIdentityProvisioningError_STATUS An error response from the pod identity provisioning.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfoError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterPodIdentityProvisioningErrorBody_STATUS An error response from the pod identity provisioning.</summary>
    [JsonPropertyName("error")]
    public V1api20240901storageManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfoErrorError? Error { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterPodIdentity_ProvisioningInfo_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterPodIdentityProvisioningError_STATUS An error response from the pod identity provisioning.</summary>
    [JsonPropertyName("error")]
    public V1api20240901storageManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfoError? Error { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterPodIdentity_STATUS Details about the pod identity assigned to the Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusPodIdentityProfileUserAssignedIdentities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bindingSelector")]
    public string? BindingSelector { get; set; }

    /// <summary>Storage version of v1api20240901.UserAssignedIdentity_STATUS Details about a user assigned identity.</summary>
    [JsonPropertyName("identity")]
    public V1api20240901storageManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterPodIdentity_ProvisioningInfo_STATUS</summary>
    [JsonPropertyName("provisioningInfo")]
    public V1api20240901storageManagedClusterStatusPodIdentityProfileUserAssignedIdentitiesProvisioningInfo? ProvisioningInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterPodIdentityException_STATUS See [disable AAD Pod Identity for a specific Pod/Application](https://azure.github.io/aad-pod-identity/docs/configure/application_exception/) for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusPodIdentityProfileUserAssignedIdentityExceptions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podLabels")]
    public IDictionary<string, string>? PodLabels { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterPodIdentityProfile_STATUS See [use AAD pod identity](https://docs.microsoft.com/azure/aks/use-azure-ad-pod-identity) for more details on pod identity integration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusPodIdentityProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowNetworkPluginKubenet")]
    public bool? AllowNetworkPluginKubenet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20240901storageManagedClusterStatusPodIdentityProfileUserAssignedIdentities>? UserAssignedIdentities { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentityExceptions")]
    public IList<V1api20240901storageManagedClusterStatusPodIdentityProfileUserAssignedIdentityExceptions>? UserAssignedIdentityExceptions { get; set; }
}

/// <summary>Storage version of v1api20240901.PowerState_STATUS Describes the Power State of the cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusPowerState
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

/// <summary>Storage version of v1api20240901.PrivateLinkResource_STATUS A private link resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusPrivateLinkResources
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateLinkServiceID")]
    public string? PrivateLinkServiceID { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requiredMembers")]
    public IList<string>? RequiredMembers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20240901.AzureKeyVaultKms_STATUS Azure Key Vault key management service settings for the security profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusSecurityProfileAzureKeyVaultKms
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyVaultNetworkAccess")]
    public string? KeyVaultNetworkAccess { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyVaultResourceId")]
    public string? KeyVaultResourceId { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterSecurityProfileDefenderSecurityMonitoring_STATUS Microsoft Defender settings for the security profile threat detection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusSecurityProfileDefenderSecurityMonitoring
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterSecurityProfileDefender_STATUS Microsoft Defender settings for the security profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusSecurityProfileDefender
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("logAnalyticsWorkspaceResourceId")]
    public string? LogAnalyticsWorkspaceResourceId { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterSecurityProfileDefenderSecurityMonitoring_STATUS Microsoft Defender settings for the security profile threat detection.</summary>
    [JsonPropertyName("securityMonitoring")]
    public V1api20240901storageManagedClusterStatusSecurityProfileDefenderSecurityMonitoring? SecurityMonitoring { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterSecurityProfileImageCleaner_STATUS Image Cleaner removes unused images from nodes, freeing up disk space and helping to reduce attack surface area. Here are settings for the security profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusSecurityProfileImageCleaner
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("intervalHours")]
    public int? IntervalHours { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterSecurityProfileWorkloadIdentity_STATUS Workload identity settings for the security profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusSecurityProfileWorkloadIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterSecurityProfile_STATUS Security profile for the container service cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusSecurityProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240901.AzureKeyVaultKms_STATUS Azure Key Vault key management service settings for the security profile.</summary>
    [JsonPropertyName("azureKeyVaultKms")]
    public V1api20240901storageManagedClusterStatusSecurityProfileAzureKeyVaultKms? AzureKeyVaultKms { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterSecurityProfileDefender_STATUS Microsoft Defender settings for the security profile.</summary>
    [JsonPropertyName("defender")]
    public V1api20240901storageManagedClusterStatusSecurityProfileDefender? Defender { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterSecurityProfileImageCleaner_STATUS Image Cleaner removes unused images from nodes, freeing up disk space and helping to reduce attack surface area. Here are settings for the security profile.</summary>
    [JsonPropertyName("imageCleaner")]
    public V1api20240901storageManagedClusterStatusSecurityProfileImageCleaner? ImageCleaner { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterSecurityProfileWorkloadIdentity_STATUS Workload identity settings for the security profile.</summary>
    [JsonPropertyName("workloadIdentity")]
    public V1api20240901storageManagedClusterStatusSecurityProfileWorkloadIdentity? WorkloadIdentity { get; set; }
}

/// <summary>Storage version of v1api20240901.IstioPluginCertificateAuthority_STATUS Plugin certificates information for Service Mesh.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusServiceMeshProfileIstioCertificateAuthorityPlugin
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("certChainObjectName")]
    public string? CertChainObjectName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("certObjectName")]
    public string? CertObjectName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyObjectName")]
    public string? KeyObjectName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rootCertObjectName")]
    public string? RootCertObjectName { get; set; }
}

/// <summary>Storage version of v1api20240901.IstioCertificateAuthority_STATUS Istio Service Mesh Certificate Authority (CA) configuration. For now, we only support plugin certificates as described here https://aka.ms/asm-plugin-ca</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusServiceMeshProfileIstioCertificateAuthority
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240901.IstioPluginCertificateAuthority_STATUS Plugin certificates information for Service Mesh.</summary>
    [JsonPropertyName("plugin")]
    public V1api20240901storageManagedClusterStatusServiceMeshProfileIstioCertificateAuthorityPlugin? Plugin { get; set; }
}

/// <summary>Storage version of v1api20240901.IstioEgressGateway_STATUS Istio egress gateway configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusServiceMeshProfileIstioComponentsEgressGateways
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20240901.IstioIngressGateway_STATUS Istio ingress gateway configuration. For now, we support up to one external ingress gateway named `aks-istio-ingressgateway-external` and one internal ingress gateway named `aks-istio-ingressgateway-internal`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusServiceMeshProfileIstioComponentsIngressGateways
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>Storage version of v1api20240901.IstioComponents_STATUS Istio components configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusServiceMeshProfileIstioComponents
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("egressGateways")]
    public IList<V1api20240901storageManagedClusterStatusServiceMeshProfileIstioComponentsEgressGateways>? EgressGateways { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ingressGateways")]
    public IList<V1api20240901storageManagedClusterStatusServiceMeshProfileIstioComponentsIngressGateways>? IngressGateways { get; set; }
}

/// <summary>Storage version of v1api20240901.IstioServiceMesh_STATUS Istio service mesh configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusServiceMeshProfileIstio
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240901.IstioCertificateAuthority_STATUS Istio Service Mesh Certificate Authority (CA) configuration. For now, we only support plugin certificates as described here https://aka.ms/asm-plugin-ca</summary>
    [JsonPropertyName("certificateAuthority")]
    public V1api20240901storageManagedClusterStatusServiceMeshProfileIstioCertificateAuthority? CertificateAuthority { get; set; }

    /// <summary>Storage version of v1api20240901.IstioComponents_STATUS Istio components configuration.</summary>
    [JsonPropertyName("components")]
    public V1api20240901storageManagedClusterStatusServiceMeshProfileIstioComponents? Components { get; set; }

    /// <summary></summary>
    [JsonPropertyName("revisions")]
    public IList<string>? Revisions { get; set; }
}

/// <summary>Storage version of v1api20240901.ServiceMeshProfile_STATUS Service mesh profile for a managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusServiceMeshProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240901.IstioServiceMesh_STATUS Istio service mesh configuration.</summary>
    [JsonPropertyName("istio")]
    public V1api20240901storageManagedClusterStatusServiceMeshProfileIstio? Istio { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterServicePrincipalProfile_STATUS Information about a service principal identity for the cluster to use for manipulating Azure APIs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusServicePrincipalProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterSKU_STATUS The SKU of a Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusSku
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterStorageProfileBlobCSIDriver_STATUS AzureBlob CSI Driver settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusStorageProfileBlobCSIDriver
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterStorageProfileDiskCSIDriver_STATUS AzureDisk CSI Driver settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusStorageProfileDiskCSIDriver
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterStorageProfileFileCSIDriver_STATUS AzureFile CSI Driver settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusStorageProfileFileCSIDriver
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterStorageProfileSnapshotController_STATUS Snapshot Controller settings for the storage profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusStorageProfileSnapshotController
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterStorageProfile_STATUS Storage profile for the container service cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusStorageProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterStorageProfileBlobCSIDriver_STATUS AzureBlob CSI Driver settings for the storage profile.</summary>
    [JsonPropertyName("blobCSIDriver")]
    public V1api20240901storageManagedClusterStatusStorageProfileBlobCSIDriver? BlobCSIDriver { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterStorageProfileDiskCSIDriver_STATUS AzureDisk CSI Driver settings for the storage profile.</summary>
    [JsonPropertyName("diskCSIDriver")]
    public V1api20240901storageManagedClusterStatusStorageProfileDiskCSIDriver? DiskCSIDriver { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterStorageProfileFileCSIDriver_STATUS AzureFile CSI Driver settings for the storage profile.</summary>
    [JsonPropertyName("fileCSIDriver")]
    public V1api20240901storageManagedClusterStatusStorageProfileFileCSIDriver? FileCSIDriver { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterStorageProfileSnapshotController_STATUS Snapshot Controller settings for the storage profile.</summary>
    [JsonPropertyName("snapshotController")]
    public V1api20240901storageManagedClusterStatusStorageProfileSnapshotController? SnapshotController { get; set; }
}

/// <summary>Storage version of v1api20240901.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusSystemData
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>Storage version of v1api20240901.UpgradeOverrideSettings_STATUS Settings for overrides when upgrading a cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusUpgradeSettingsOverrideSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceUpgrade")]
    public bool? ForceUpgrade { get; set; }

    /// <summary></summary>
    [JsonPropertyName("until")]
    public string? Until { get; set; }
}

/// <summary>Storage version of v1api20240901.ClusterUpgradeSettings_STATUS Settings for upgrading a cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusUpgradeSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240901.UpgradeOverrideSettings_STATUS Settings for overrides when upgrading a cluster.</summary>
    [JsonPropertyName("overrideSettings")]
    public V1api20240901storageManagedClusterStatusUpgradeSettingsOverrideSettings? OverrideSettings { get; set; }
}

/// <summary>Storage version of v1api20240901.WindowsGmsaProfile_STATUS Windows gMSA Profile in the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusWindowsProfileGmsaProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dnsServer")]
    public string? DnsServer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rootDomainName")]
    public string? RootDomainName { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterWindowsProfile_STATUS Profile for Windows VMs in the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusWindowsProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableCSIProxy")]
    public bool? EnableCSIProxy { get; set; }

    /// <summary>Storage version of v1api20240901.WindowsGmsaProfile_STATUS Windows gMSA Profile in the managed cluster.</summary>
    [JsonPropertyName("gmsaProfile")]
    public V1api20240901storageManagedClusterStatusWindowsProfileGmsaProfile? GmsaProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterWorkloadAutoScalerProfileKeda_STATUS KEDA (Kubernetes Event-driven Autoscaling) settings for the workload auto-scaler profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusWorkloadAutoScalerProfileKeda
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterWorkloadAutoScalerProfileVerticalPodAutoscaler_STATUS VPA (Vertical Pod Autoscaler) settings for the workload auto-scaler profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusWorkloadAutoScalerProfileVerticalPodAutoscaler
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedClusterWorkloadAutoScalerProfile_STATUS Workload Auto-scaler profile for the managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatusWorkloadAutoScalerProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterWorkloadAutoScalerProfileKeda_STATUS KEDA (Kubernetes Event-driven Autoscaling) settings for the workload auto-scaler profile.</summary>
    [JsonPropertyName("keda")]
    public V1api20240901storageManagedClusterStatusWorkloadAutoScalerProfileKeda? Keda { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterWorkloadAutoScalerProfileVerticalPodAutoscaler_STATUS VPA (Vertical Pod Autoscaler) settings for the workload auto-scaler profile.</summary>
    [JsonPropertyName("verticalPodAutoscaler")]
    public V1api20240901storageManagedClusterStatusWorkloadAutoScalerProfileVerticalPodAutoscaler? VerticalPodAutoscaler { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedCluster_STATUS Managed cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClusterStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterAADProfile_STATUS For more details see [managed AAD on AKS](https://docs.microsoft.com/azure/aks/managed-aad).</summary>
    [JsonPropertyName("aadProfile")]
    public V1api20240901storageManagedClusterStatusAadProfile? AadProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("addonProfiles")]
    public IDictionary<string, V1api20240901storageManagedClusterStatusAddonProfiles>? AddonProfiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("agentPoolProfiles")]
    public IList<V1api20240901storageManagedClusterStatusAgentPoolProfiles>? AgentPoolProfiles { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterAPIServerAccessProfile_STATUS Access profile for managed cluster API server.</summary>
    [JsonPropertyName("apiServerAccessProfile")]
    public V1api20240901storageManagedClusterStatusApiServerAccessProfile? ApiServerAccessProfile { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterProperties_AutoScalerProfile_STATUS</summary>
    [JsonPropertyName("autoScalerProfile")]
    public V1api20240901storageManagedClusterStatusAutoScalerProfile? AutoScalerProfile { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterAutoUpgradeProfile_STATUS Auto upgrade profile for a managed cluster.</summary>
    [JsonPropertyName("autoUpgradeProfile")]
    public V1api20240901storageManagedClusterStatusAutoUpgradeProfile? AutoUpgradeProfile { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterAzureMonitorProfile_STATUS Azure Monitor addon profiles for monitoring the managed cluster.</summary>
    [JsonPropertyName("azureMonitorProfile")]
    public V1api20240901storageManagedClusterStatusAzureMonitorProfile? AzureMonitorProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azurePortalFQDN")]
    public string? AzurePortalFQDN { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240901storageManagedClusterStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("currentKubernetesVersion")]
    public string? CurrentKubernetesVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableLocalAccounts")]
    public bool? DisableLocalAccounts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskEncryptionSetID")]
    public string? DiskEncryptionSetID { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dnsPrefix")]
    public string? DnsPrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enablePodSecurityPolicy")]
    public bool? EnablePodSecurityPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableRBAC")]
    public bool? EnableRBAC { get; set; }

    /// <summary>Storage version of v1api20240901.ExtendedLocation_STATUS The complex type of the extended location.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20240901storageManagedClusterStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fqdnSubdomain")]
    public string? FqdnSubdomain { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterHTTPProxyConfig_STATUS Cluster HTTP proxy configuration.</summary>
    [JsonPropertyName("httpProxyConfig")]
    public V1api20240901storageManagedClusterStatusHttpProxyConfig? HttpProxyConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterIdentity_STATUS Identity for the managed cluster.</summary>
    [JsonPropertyName("identity")]
    public V1api20240901storageManagedClusterStatusIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("identityProfile")]
    public IDictionary<string, V1api20240901storageManagedClusterStatusIdentityProfile>? IdentityProfile { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterIngressProfile_STATUS Ingress profile for the container service cluster.</summary>
    [JsonPropertyName("ingressProfile")]
    public V1api20240901storageManagedClusterStatusIngressProfile? IngressProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kubernetesVersion")]
    public string? KubernetesVersion { get; set; }

    /// <summary>Storage version of v1api20240901.ContainerServiceLinuxProfile_STATUS Profile for Linux VMs in the container service cluster.</summary>
    [JsonPropertyName("linuxProfile")]
    public V1api20240901storageManagedClusterStatusLinuxProfile? LinuxProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxAgentPools")]
    public int? MaxAgentPools { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterMetricsProfile_STATUS The metrics profile for the ManagedCluster.</summary>
    [JsonPropertyName("metricsProfile")]
    public V1api20240901storageManagedClusterStatusMetricsProfile? MetricsProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20240901.ContainerServiceNetworkProfile_STATUS Profile of network configuration.</summary>
    [JsonPropertyName("networkProfile")]
    public V1api20240901storageManagedClusterStatusNetworkProfile? NetworkProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeResourceGroup")]
    public string? NodeResourceGroup { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterNodeResourceGroupProfile_STATUS Node resource group lockdown profile for a managed cluster.</summary>
    [JsonPropertyName("nodeResourceGroupProfile")]
    public V1api20240901storageManagedClusterStatusNodeResourceGroupProfile? NodeResourceGroupProfile { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterOIDCIssuerProfile_STATUS The OIDC issuer profile of the Managed Cluster.</summary>
    [JsonPropertyName("oidcIssuerProfile")]
    public V1api20240901storageManagedClusterStatusOidcIssuerProfile? OidcIssuerProfile { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterPodIdentityProfile_STATUS See [use AAD pod identity](https://docs.microsoft.com/azure/aks/use-azure-ad-pod-identity) for more details on pod identity integration.</summary>
    [JsonPropertyName("podIdentityProfile")]
    public V1api20240901storageManagedClusterStatusPodIdentityProfile? PodIdentityProfile { get; set; }

    /// <summary>Storage version of v1api20240901.PowerState_STATUS Describes the Power State of the cluster</summary>
    [JsonPropertyName("powerState")]
    public V1api20240901storageManagedClusterStatusPowerState? PowerState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateFQDN")]
    public string? PrivateFQDN { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateLinkResources")]
    public IList<V1api20240901storageManagedClusterStatusPrivateLinkResources>? PrivateLinkResources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceUID")]
    public string? ResourceUID { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterSecurityProfile_STATUS Security profile for the container service cluster.</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20240901storageManagedClusterStatusSecurityProfile? SecurityProfile { get; set; }

    /// <summary>Storage version of v1api20240901.ServiceMeshProfile_STATUS Service mesh profile for a managed cluster.</summary>
    [JsonPropertyName("serviceMeshProfile")]
    public V1api20240901storageManagedClusterStatusServiceMeshProfile? ServiceMeshProfile { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterServicePrincipalProfile_STATUS Information about a service principal identity for the cluster to use for manipulating Azure APIs.</summary>
    [JsonPropertyName("servicePrincipalProfile")]
    public V1api20240901storageManagedClusterStatusServicePrincipalProfile? ServicePrincipalProfile { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterSKU_STATUS The SKU of a Managed Cluster.</summary>
    [JsonPropertyName("sku")]
    public V1api20240901storageManagedClusterStatusSku? Sku { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterStorageProfile_STATUS Storage profile for the container service cluster.</summary>
    [JsonPropertyName("storageProfile")]
    public V1api20240901storageManagedClusterStatusStorageProfile? StorageProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("supportPlan")]
    public string? SupportPlan { get; set; }

    /// <summary>Storage version of v1api20240901.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20240901storageManagedClusterStatusSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Storage version of v1api20240901.ClusterUpgradeSettings_STATUS Settings for upgrading a cluster.</summary>
    [JsonPropertyName("upgradeSettings")]
    public V1api20240901storageManagedClusterStatusUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterWindowsProfile_STATUS Profile for Windows VMs in the managed cluster.</summary>
    [JsonPropertyName("windowsProfile")]
    public V1api20240901storageManagedClusterStatusWindowsProfile? WindowsProfile { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClusterWorkloadAutoScalerProfile_STATUS Workload Auto-scaler profile for the managed cluster.</summary>
    [JsonPropertyName("workloadAutoScalerProfile")]
    public V1api20240901storageManagedClusterStatusWorkloadAutoScalerProfile? WorkloadAutoScalerProfile { get; set; }
}

/// <summary>Storage version of v1api20240901.ManagedCluster Generator information: - Generated from: /containerservice/resource-manager/Microsoft.ContainerService/aks/stable/2024-09-01/managedClusters.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240901storageManagedCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240901storageManagedClusterSpec>, IStatus<V1api20240901storageManagedClusterStatus>
{
    public const string KubeApiVersion = "v1api20240901storage";
    public const string KubeKind = "ManagedCluster";
    public const string KubeGroup = "containerservice.azure.com";
    public const string KubePluralName = "managedclusters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedCluster_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20240901storageManagedClusterSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedCluster_STATUS Managed cluster.</summary>
    [JsonPropertyName("status")]
    public V1api20240901storageManagedClusterStatus? Status { get; set; }
}