using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containerservice.azure.com;
#nullable enable
/// <summary>Storage version of v1api20240901.ManagedClustersAgentPool Generator information: - Generated from: /containerservice/resource-manager/Microsoft.ContainerService/aks/stable/2024-09-01/managedClusters.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/agentPools/{agentPoolName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240901storageManagedClustersAgentPoolList : IKubernetesObject<V1ListMeta>, IItems<V1api20240901storageManagedClustersAgentPool>
{
    public const string KubeApiVersion = "v1api20240901storage";
    public const string KubeKind = "ManagedClustersAgentPoolList";
    public const string KubeGroup = "containerservice.azure.com";
    public const string KubePluralName = "managedclustersagentpools";
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
    public IList<V1api20240901storageManagedClustersAgentPool> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>CapacityReservationGroupReference: AKS will associate the specified agent pool with the Capacity Reservation Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolSpecCapacityReservationGroupReference
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
#nullable disable

#nullable enable
/// <summary>SourceResourceReference: This is the ARM ID of the source object to be used to create the target object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolSpecCreationDataSourceResourceReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240901.CreationData Data used when creating a target resource from a source resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolSpecCreationData
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SourceResourceReference: This is the ARM ID of the source object to be used to create the target object.</summary>
    [JsonPropertyName("sourceResourceReference")]
    public V1api20240901storageManagedClustersAgentPoolSpecCreationDataSourceResourceReference? SourceResourceReference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>HostGroupReference: This is of the form: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}. For more information see [Azure dedicated hosts](https://docs.microsoft.com/azure/virtual-machines/dedicated-hosts).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolSpecHostGroupReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240901.KubeletConfig See [AKS custom node configuration](https://docs.microsoft.com/azure/aks/custom-node-configuration) for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolSpecKubeletConfig
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240901.SysctlConfig Sysctl settings for Linux agent nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolSpecLinuxOSConfigSysctls
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240901.LinuxOSConfig See [AKS custom node configuration](https://docs.microsoft.com/azure/aks/custom-node-configuration) for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolSpecLinuxOSConfig
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("swapFileSizeMB")]
    public int? SwapFileSizeMB { get; set; }

    /// <summary>Storage version of v1api20240901.SysctlConfig Sysctl settings for Linux agent nodes.</summary>
    [JsonPropertyName("sysctls")]
    public V1api20240901storageManagedClustersAgentPoolSpecLinuxOSConfigSysctls? Sysctls { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transparentHugePageDefrag")]
    public string? TransparentHugePageDefrag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transparentHugePageEnabled")]
    public string? TransparentHugePageEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240901.PortRange The port range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolSpecNetworkProfileAllowedHostPorts
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
#nullable disable

#nullable enable
/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolSpecNetworkProfileApplicationSecurityGroupsReferences
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240901.IPTag Contains the IPTag associated with the object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolSpecNetworkProfileNodePublicIPTags
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240901.AgentPoolNetworkProfile Network settings of an agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolSpecNetworkProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedHostPorts")]
    public IList<V1api20240901storageManagedClustersAgentPoolSpecNetworkProfileAllowedHostPorts>? AllowedHostPorts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applicationSecurityGroupsReferences")]
    public IList<V1api20240901storageManagedClustersAgentPoolSpecNetworkProfileApplicationSecurityGroupsReferences>? ApplicationSecurityGroupsReferences { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodePublicIPTags")]
    public IList<V1api20240901storageManagedClustersAgentPoolSpecNetworkProfileNodePublicIPTags>? NodePublicIPTags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>NodePublicIPPrefixReference: This is of the form: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes/{publicIPPrefixName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolSpecNodePublicIPPrefixReference
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
#nullable disable

#nullable enable
/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolSpecOperatorSpecConfigMapExpressions
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
#nullable disable

#nullable enable
/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolSpecOperatorSpecSecretExpressions
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240901.ManagedClustersAgentPoolOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240901storageManagedClustersAgentPoolSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240901storageManagedClustersAgentPoolSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a containerservice.azure.com/ManagedCluster resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>PodSubnetReference: If omitted, pod IPs are statically assigned on the node subnet (see vnetSubnetID for more details). This is of the form: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolSpecPodSubnetReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240901.PowerState Describes the Power State of the cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolSpecPowerState
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProximityPlacementGroupReference: The ID for Proximity Placement Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolSpecProximityPlacementGroupReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240901.AgentPoolSecurityProfile The security settings of an agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolSpecSecurityProfile
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240901.AgentPoolUpgradeSettings Settings for upgrading an agentpool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolSpecUpgradeSettings
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
#nullable disable

#nullable enable
/// <summary>VnetSubnetReference: If this is not specified, a VNET and subnet will be generated and used. If no podSubnetID is specified, this applies to nodes and pods, otherwise it applies to just nodes. This is of the form: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolSpecVnetSubnetReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240901.AgentPoolWindowsProfile The Windows agent pool's specific profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolSpecWindowsProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableOutboundNat")]
    public bool? DisableOutboundNat { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240901.ManagedClustersAgentPool_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>CapacityReservationGroupReference: AKS will associate the specified agent pool with the Capacity Reservation Group.</summary>
    [JsonPropertyName("capacityReservationGroupReference")]
    public V1api20240901storageManagedClustersAgentPoolSpecCapacityReservationGroupReference? CapacityReservationGroupReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>Storage version of v1api20240901.CreationData Data used when creating a target resource from a source resource.</summary>
    [JsonPropertyName("creationData")]
    public V1api20240901storageManagedClustersAgentPoolSpecCreationData? CreationData { get; set; }

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
    public V1api20240901storageManagedClustersAgentPoolSpecHostGroupReference? HostGroupReference { get; set; }

    /// <summary>Storage version of v1api20240901.KubeletConfig See [AKS custom node configuration](https://docs.microsoft.com/azure/aks/custom-node-configuration) for more details.</summary>
    [JsonPropertyName("kubeletConfig")]
    public V1api20240901storageManagedClustersAgentPoolSpecKubeletConfig? KubeletConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kubeletDiskType")]
    public string? KubeletDiskType { get; set; }

    /// <summary>Storage version of v1api20240901.LinuxOSConfig See [AKS custom node configuration](https://docs.microsoft.com/azure/aks/custom-node-configuration) for more details.</summary>
    [JsonPropertyName("linuxOSConfig")]
    public V1api20240901storageManagedClustersAgentPoolSpecLinuxOSConfig? LinuxOSConfig { get; set; }

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

    /// <summary>Storage version of v1api20240901.AgentPoolNetworkProfile Network settings of an agent pool.</summary>
    [JsonPropertyName("networkProfile")]
    public V1api20240901storageManagedClustersAgentPoolSpecNetworkProfile? NetworkProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeLabels")]
    public IDictionary<string, string>? NodeLabels { get; set; }

    /// <summary>NodePublicIPPrefixReference: This is of the form: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes/{publicIPPrefixName}</summary>
    [JsonPropertyName("nodePublicIPPrefixReference")]
    public V1api20240901storageManagedClustersAgentPoolSpecNodePublicIPPrefixReference? NodePublicIPPrefixReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeTaints")]
    public IList<string>? NodeTaints { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClustersAgentPoolOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240901storageManagedClustersAgentPoolSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("orchestratorVersion")]
    public string? OrchestratorVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

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

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a containerservice.azure.com/ManagedCluster resource</summary>
    [JsonPropertyName("owner")]
    public V1api20240901storageManagedClustersAgentPoolSpecOwner Owner { get; set; }

    /// <summary>PodSubnetReference: If omitted, pod IPs are statically assigned on the node subnet (see vnetSubnetID for more details). This is of the form: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}</summary>
    [JsonPropertyName("podSubnetReference")]
    public V1api20240901storageManagedClustersAgentPoolSpecPodSubnetReference? PodSubnetReference { get; set; }

    /// <summary>Storage version of v1api20240901.PowerState Describes the Power State of the cluster</summary>
    [JsonPropertyName("powerState")]
    public V1api20240901storageManagedClustersAgentPoolSpecPowerState? PowerState { get; set; }

    /// <summary>ProximityPlacementGroupReference: The ID for Proximity Placement Group.</summary>
    [JsonPropertyName("proximityPlacementGroupReference")]
    public V1api20240901storageManagedClustersAgentPoolSpecProximityPlacementGroupReference? ProximityPlacementGroupReference { get; set; }

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
    public V1api20240901storageManagedClustersAgentPoolSpecSecurityProfile? SecurityProfile { get; set; }

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
    public V1api20240901storageManagedClustersAgentPoolSpecUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }

    /// <summary>VnetSubnetReference: If this is not specified, a VNET and subnet will be generated and used. If no podSubnetID is specified, this applies to nodes and pods, otherwise it applies to just nodes. This is of the form: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}</summary>
    [JsonPropertyName("vnetSubnetReference")]
    public V1api20240901storageManagedClustersAgentPoolSpecVnetSubnetReference? VnetSubnetReference { get; set; }

    /// <summary>Storage version of v1api20240901.AgentPoolWindowsProfile The Windows agent pool's specific profile.</summary>
    [JsonPropertyName("windowsProfile")]
    public V1api20240901storageManagedClustersAgentPoolSpecWindowsProfile? WindowsProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workloadRuntime")]
    public string? WorkloadRuntime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolStatusConditions
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240901.CreationData_STATUS Data used when creating a target resource from a source resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolStatusCreationData
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceResourceId")]
    public string? SourceResourceId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240901.KubeletConfig_STATUS See [AKS custom node configuration](https://docs.microsoft.com/azure/aks/custom-node-configuration) for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolStatusKubeletConfig
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240901.SysctlConfig_STATUS Sysctl settings for Linux agent nodes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolStatusLinuxOSConfigSysctls
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240901.LinuxOSConfig_STATUS See [AKS custom node configuration](https://docs.microsoft.com/azure/aks/custom-node-configuration) for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolStatusLinuxOSConfig
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("swapFileSizeMB")]
    public int? SwapFileSizeMB { get; set; }

    /// <summary>Storage version of v1api20240901.SysctlConfig_STATUS Sysctl settings for Linux agent nodes.</summary>
    [JsonPropertyName("sysctls")]
    public V1api20240901storageManagedClustersAgentPoolStatusLinuxOSConfigSysctls? Sysctls { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transparentHugePageDefrag")]
    public string? TransparentHugePageDefrag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transparentHugePageEnabled")]
    public string? TransparentHugePageEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240901.PortRange_STATUS The port range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolStatusNetworkProfileAllowedHostPorts
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240901.IPTag_STATUS Contains the IPTag associated with the object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolStatusNetworkProfileNodePublicIPTags
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240901.AgentPoolNetworkProfile_STATUS Network settings of an agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolStatusNetworkProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedHostPorts")]
    public IList<V1api20240901storageManagedClustersAgentPoolStatusNetworkProfileAllowedHostPorts>? AllowedHostPorts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applicationSecurityGroups")]
    public IList<string>? ApplicationSecurityGroups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodePublicIPTags")]
    public IList<V1api20240901storageManagedClustersAgentPoolStatusNetworkProfileNodePublicIPTags>? NodePublicIPTags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240901.PowerState_STATUS Describes the Power State of the cluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolStatusPowerState
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240901.AgentPoolSecurityProfile_STATUS The security settings of an agent pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolStatusSecurityProfile
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240901.AgentPoolUpgradeSettings_STATUS Settings for upgrading an agentpool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolStatusUpgradeSettings
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240901.AgentPoolWindowsProfile_STATUS The Windows agent pool's specific profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolStatusWindowsProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableOutboundNat")]
    public bool? DisableOutboundNat { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240901.ManagedClustersAgentPool_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageManagedClustersAgentPoolStatus
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
    [JsonPropertyName("conditions")]
    public IList<V1api20240901storageManagedClustersAgentPoolStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>Storage version of v1api20240901.CreationData_STATUS Data used when creating a target resource from a source resource.</summary>
    [JsonPropertyName("creationData")]
    public V1api20240901storageManagedClustersAgentPoolStatusCreationData? CreationData { get; set; }

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

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20240901.KubeletConfig_STATUS See [AKS custom node configuration](https://docs.microsoft.com/azure/aks/custom-node-configuration) for more details.</summary>
    [JsonPropertyName("kubeletConfig")]
    public V1api20240901storageManagedClustersAgentPoolStatusKubeletConfig? KubeletConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kubeletDiskType")]
    public string? KubeletDiskType { get; set; }

    /// <summary>Storage version of v1api20240901.LinuxOSConfig_STATUS See [AKS custom node configuration](https://docs.microsoft.com/azure/aks/custom-node-configuration) for more details.</summary>
    [JsonPropertyName("linuxOSConfig")]
    public V1api20240901storageManagedClustersAgentPoolStatusLinuxOSConfig? LinuxOSConfig { get; set; }

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
    public V1api20240901storageManagedClustersAgentPoolStatusNetworkProfile? NetworkProfile { get; set; }

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
    public V1api20240901storageManagedClustersAgentPoolStatusPowerState? PowerState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("properties_type")]
    public string? PropertiesType { get; set; }

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
    public V1api20240901storageManagedClustersAgentPoolStatusSecurityProfile? SecurityProfile { get; set; }

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
    public V1api20240901storageManagedClustersAgentPoolStatusUpgradeSettings? UpgradeSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vnetSubnetID")]
    public string? VnetSubnetID { get; set; }

    /// <summary>Storage version of v1api20240901.AgentPoolWindowsProfile_STATUS The Windows agent pool's specific profile.</summary>
    [JsonPropertyName("windowsProfile")]
    public V1api20240901storageManagedClustersAgentPoolStatusWindowsProfile? WindowsProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workloadRuntime")]
    public string? WorkloadRuntime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20240901.ManagedClustersAgentPool Generator information: - Generated from: /containerservice/resource-manager/Microsoft.ContainerService/aks/stable/2024-09-01/managedClusters.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/agentPools/{agentPoolName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240901storageManagedClustersAgentPool : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240901storageManagedClustersAgentPoolSpec>, IStatus<V1api20240901storageManagedClustersAgentPoolStatus>
{
    public const string KubeApiVersion = "v1api20240901storage";
    public const string KubeKind = "ManagedClustersAgentPool";
    public const string KubeGroup = "containerservice.azure.com";
    public const string KubePluralName = "managedclustersagentpools";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClustersAgentPool_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20240901storageManagedClustersAgentPoolSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20240901.ManagedClustersAgentPool_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20240901storageManagedClustersAgentPoolStatus? Status { get; set; }
}
#nullable disable
