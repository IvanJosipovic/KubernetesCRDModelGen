using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.container.gcp.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1NodePoolSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderAutoscaling
{
    /// <summary>Location policy specifies the algorithm used when scaling-up the node pool. Location policy is supported only in 1.24.1+ clusters.</summary>
    [JsonPropertyName("locationPolicy")]
    public string? LocationPolicy { get; set; }

    /// <summary>Maximum number of nodes per zone in the NodePool. Must be &gt;= min_node_count. Cannot be used with total limits.</summary>
    [JsonPropertyName("maxNodeCount")]
    public double? MaxNodeCount { get; set; }

    /// <summary>Minimum number of nodes per zone in the NodePool. Must be &gt;=0 and &lt;= max_node_count. Cannot be used with total limits.</summary>
    [JsonPropertyName("minNodeCount")]
    public double? MinNodeCount { get; set; }

    /// <summary>Total maximum number of nodes in the NodePool. Must be &gt;= total_min_node_count. Cannot be used with per zone limits. Total size limits are supported only in 1.24.1+ clusters.</summary>
    [JsonPropertyName("totalMaxNodeCount")]
    public double? TotalMaxNodeCount { get; set; }

    /// <summary>Total minimum number of nodes in the NodePool. Must be &gt;=0 and &lt;= total_max_node_count. Cannot be used with per zone limits. Total size limits are supported only in 1.24.1+ clusters.</summary>
    [JsonPropertyName("totalMinNodeCount")]
    public double? TotalMinNodeCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1NodePoolSpecForProviderClusterRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1NodePoolSpecForProviderClusterRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderClusterRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecForProviderClusterRefPolicyResolutionEnum>))]
    public V1beta1NodePoolSpecForProviderClusterRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecForProviderClusterRefPolicyResolveEnum>))]
    public V1beta1NodePoolSpecForProviderClusterRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in container to populate cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderClusterRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodePoolSpecForProviderClusterRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1NodePoolSpecForProviderClusterSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1NodePoolSpecForProviderClusterSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderClusterSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecForProviderClusterSelectorPolicyResolutionEnum>))]
    public V1beta1NodePoolSpecForProviderClusterSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecForProviderClusterSelectorPolicyResolveEnum>))]
    public V1beta1NodePoolSpecForProviderClusterSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in container to populate cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderClusterSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodePoolSpecForProviderClusterSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderManagement
{
    /// <summary>Whether the nodes will be automatically repaired. Enabled by default.</summary>
    [JsonPropertyName("autoRepair")]
    public bool? AutoRepair { get; set; }

    /// <summary>Whether the nodes will be automatically upgraded. Enabled by default.</summary>
    [JsonPropertyName("autoUpgrade")]
    public bool? AutoUpgrade { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNetworkConfigNetworkPerformanceConfig
{
    /// <summary></summary>
    [JsonPropertyName("totalEgressBandwidthTier")]
    public string? TotalEgressBandwidthTier { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNetworkConfigPodCidrOverprovisionConfig
{
    /// <summary></summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNetworkConfig
{
    /// <summary>Whether to create a new range for pod IPs in this node pool. Defaults are provided for pod_range and pod_ipv4_cidr_block if they are not specified.</summary>
    [JsonPropertyName("createPodRange")]
    public bool? CreatePodRange { get; set; }

    /// <summary>Whether nodes have internal IP addresses only.</summary>
    [JsonPropertyName("enablePrivateNodes")]
    public bool? EnablePrivateNodes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkPerformanceConfig")]
    public IList<V1beta1NodePoolSpecForProviderNetworkConfigNetworkPerformanceConfig>? NetworkPerformanceConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podCidrOverprovisionConfig")]
    public IList<V1beta1NodePoolSpecForProviderNetworkConfigPodCidrOverprovisionConfig>? PodCidrOverprovisionConfig { get; set; }

    /// <summary>The IP address range for pod IPs in this node pool. Only applicable if createPodRange is true. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) to pick a specific range to use.</summary>
    [JsonPropertyName("podIpv4CidrBlock")]
    public string? PodIpv4CidrBlock { get; set; }

    /// <summary>The ID of the secondary range for pod IPs. If create_pod_range is true, this ID is used for the new range. If create_pod_range is false, uses an existing secondary range with this ID.</summary>
    [JsonPropertyName("podRange")]
    public string? PodRange { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigAdvancedMachineFeatures
{
    /// <summary></summary>
    [JsonPropertyName("enableNestedVirtualization")]
    public bool? EnableNestedVirtualization { get; set; }

    /// <summary></summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigConfidentialNodes
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig
{
    /// <summary></summary>
    [JsonPropertyName("secretUri")]
    public string? SecretUri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig
{
    /// <summary></summary>
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpSecretManagerCertificateConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig>? GcpSecretManagerCertificateConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigPrivateRegistryAccessConfig
{
    /// <summary></summary>
    [JsonPropertyName("certificateAuthorityDomainConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig>? CertificateAuthorityDomainConfig { get; set; }

    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigContainerdConfig
{
    /// <summary></summary>
    [JsonPropertyName("privateRegistryAccessConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigContainerdConfigPrivateRegistryAccessConfig>? PrivateRegistryAccessConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigEphemeralStorageLocalSsdConfig
{
    /// <summary></summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigFastSocket
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigGcfsConfig
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigGuestAcceleratorGpuDriverInstallationConfig
{
    /// <summary>The Kubernetes version for the nodes in this pool. Note that if this field and auto_upgrade are both specified, they will fight each other for what the node version should be, so setting both is highly discouraged.</summary>
    [JsonPropertyName("gpuDriverVersion")]
    public string? GpuDriverVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigGuestAcceleratorGpuSharingConfig
{
    /// <summary></summary>
    [JsonPropertyName("gpuSharingStrategy")]
    public string? GpuSharingStrategy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxSharedClientsPerGpu")]
    public double? MaxSharedClientsPerGpu { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigGuestAccelerator
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gpuDriverInstallationConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigGuestAcceleratorGpuDriverInstallationConfig>? GpuDriverInstallationConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gpuPartitionSize")]
    public string? GpuPartitionSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gpuSharingConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigGuestAcceleratorGpuSharingConfig>? GpuSharingConfig { get; set; }

    /// <summary>The type of the policy. Supports a single value: COMPACT. Specifying COMPACT placement policy type places node pool's nodes in a closer physical proximity in order to reduce network latency between nodes.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigGvnic
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigHostMaintenancePolicy
{
    /// <summary></summary>
    [JsonPropertyName("maintenanceInterval")]
    public string? MaintenanceInterval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigKubeletConfig
{
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
    [JsonPropertyName("podPidsLimit")]
    public double? PodPidsLimit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigLinuxNodeConfig
{
    /// <summary></summary>
    [JsonPropertyName("cgroupMode")]
    public string? CgroupMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sysctls")]
    public IDictionary<string, string>? Sysctls { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigLocalNvmeSsdBlockConfig
{
    /// <summary></summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigReservationAffinity
{
    /// <summary></summary>
    [JsonPropertyName("consumeReservationType")]
    public string? ConsumeReservationType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigSecondaryBootDisks
{
    /// <summary></summary>
    [JsonPropertyName("diskImage")]
    public string? DiskImage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1NodePoolSpecForProviderNodeConfigServiceAccountRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1NodePoolSpecForProviderNodeConfigServiceAccountRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigServiceAccountRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecForProviderNodeConfigServiceAccountRefPolicyResolutionEnum>))]
    public V1beta1NodePoolSpecForProviderNodeConfigServiceAccountRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecForProviderNodeConfigServiceAccountRefPolicyResolveEnum>))]
    public V1beta1NodePoolSpecForProviderNodeConfigServiceAccountRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigServiceAccountRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodePoolSpecForProviderNodeConfigServiceAccountRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1NodePoolSpecForProviderNodeConfigServiceAccountSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1NodePoolSpecForProviderNodeConfigServiceAccountSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigServiceAccountSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecForProviderNodeConfigServiceAccountSelectorPolicyResolutionEnum>))]
    public V1beta1NodePoolSpecForProviderNodeConfigServiceAccountSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecForProviderNodeConfigServiceAccountSelectorPolicyResolveEnum>))]
    public V1beta1NodePoolSpecForProviderNodeConfigServiceAccountSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigServiceAccountSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodePoolSpecForProviderNodeConfigServiceAccountSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigShieldedInstanceConfig
{
    /// <summary></summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigSoleTenantConfigNodeAffinity
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigSoleTenantConfig
{
    /// <summary></summary>
    [JsonPropertyName("nodeAffinity")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigSoleTenantConfigNodeAffinity>? NodeAffinity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigTaint
{
    /// <summary></summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfigWorkloadMetadataConfig
{
    /// <summary></summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderNodeConfig
{
    /// <summary></summary>
    [JsonPropertyName("advancedMachineFeatures")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigAdvancedMachineFeatures>? AdvancedMachineFeatures { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bootDiskKmsKey")]
    public string? BootDiskKmsKey { get; set; }

    /// <summary>Configuration for Confidential Nodes feature. Structure is documented below.</summary>
    [JsonPropertyName("confidentialNodes")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigConfidentialNodes>? ConfidentialNodes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("containerdConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigContainerdConfig>? ContainerdConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableConfidentialStorage")]
    public bool? EnableConfidentialStorage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ephemeralStorageLocalSsdConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigEphemeralStorageLocalSsdConfig>? EphemeralStorageLocalSsdConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fastSocket")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigFastSocket>? FastSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcfsConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigGcfsConfig>? GcfsConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("guestAccelerator")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigGuestAccelerator>? GuestAccelerator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gvnic")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigGvnic>? Gvnic { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostMaintenancePolicy")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigHostMaintenancePolicy>? HostMaintenancePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imageType")]
    public string? ImageType { get; set; }

    /// <summary>This is an injected field with a default value for being able to merge items of the parent object list.</summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kubeletConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigKubeletConfig>? KubeletConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Parameters used in creating the node pool. See google_container_cluster for schema.</summary>
    [JsonPropertyName("linuxNodeConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigLinuxNodeConfig>? LinuxNodeConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localNvmeSsdBlockConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigLocalNvmeSsdBlockConfig>? LocalNvmeSsdBlockConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loggingVariant")]
    public string? LoggingVariant { get; set; }

    /// <summary></summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeGroup")]
    public string? NodeGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    /// <summary></summary>
    [JsonPropertyName("reservationAffinity")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigReservationAffinity>? ReservationAffinity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceLabels")]
    public IDictionary<string, string>? ResourceLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secondaryBootDisks")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigSecondaryBootDisks>? SecondaryBootDisks { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1NodePoolSpecForProviderNodeConfigServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountSelector")]
    public V1beta1NodePoolSpecForProviderNodeConfigServiceAccountSelector? ServiceAccountSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigShieldedInstanceConfig>? ShieldedInstanceConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("soleTenantConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigSoleTenantConfig>? SoleTenantConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spot")]
    public bool? Spot { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("taint")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigTaint>? Taint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workloadMetadataConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfigWorkloadMetadataConfig>? WorkloadMetadataConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderPlacementPolicy
{
    /// <summary>If set, refers to the name of a custom resource policy supplied by the user. The resource policy must be in the same project and region as the node pool. If not found, InvalidArgument error is returned.</summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary>The TPU placement topology for pod slice node pool.</summary>
    [JsonPropertyName("tpuTopology")]
    public string? TpuTopology { get; set; }

    /// <summary>The type of the policy. Supports a single value: COMPACT. Specifying COMPACT placement policy type places node pool's nodes in a closer physical proximity in order to reduce network latency between nodes.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderQueuedProvisioning
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy
{
    /// <summary>Number of blue nodes to drain in a batch.</summary>
    [JsonPropertyName("batchNodeCount")]
    public double? BatchNodeCount { get; set; }

    /// <summary>Percentage of the blue pool nodes to drain in a batch.</summary>
    [JsonPropertyName("batchPercentage")]
    public double? BatchPercentage { get; set; }

    /// <summary>(Optionial) Soak time after each batch gets drained.</summary>
    [JsonPropertyName("batchSoakDuration")]
    public string? BatchSoakDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderUpgradeSettingsBlueGreenSettings
{
    /// <summary>Time needed after draining the entire blue pool. After this period, the blue pool will be cleaned up.</summary>
    [JsonPropertyName("nodePoolSoakDuration")]
    public string? NodePoolSoakDuration { get; set; }

    /// <summary>Specifies the standard policy settings for blue-green upgrades.</summary>
    [JsonPropertyName("standardRolloutPolicy")]
    public IList<V1beta1NodePoolSpecForProviderUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy>? StandardRolloutPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProviderUpgradeSettings
{
    /// <summary>The settings to adjust blue green upgrades. Structure is documented below</summary>
    [JsonPropertyName("blueGreenSettings")]
    public IList<V1beta1NodePoolSpecForProviderUpgradeSettingsBlueGreenSettings>? BlueGreenSettings { get; set; }

    /// <summary>The number of additional nodes that can be added to the node pool during an upgrade. Increasing max_surge raises the number of nodes that can be upgraded simultaneously. Can be set to 0 or greater.</summary>
    [JsonPropertyName("maxSurge")]
    public double? MaxSurge { get; set; }

    /// <summary>The number of nodes that can be simultaneously unavailable during an upgrade. Increasing max_unavailable raises the number of nodes that can be upgraded in parallel. Can be set to 0 or greater.</summary>
    [JsonPropertyName("maxUnavailable")]
    public double? MaxUnavailable { get; set; }

    /// <summary>(Default SURGE) The upgrade stragey to be used for upgrading the nodes.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecForProvider
{
    /// <summary>Configuration required by cluster autoscaler to adjust the size of the node pool to the current cluster usage. Structure is documented below.</summary>
    [JsonPropertyName("autoscaling")]
    public IList<V1beta1NodePoolSpecForProviderAutoscaling>? Autoscaling { get; set; }

    /// <summary>The cluster to create the node pool for. Cluster must be present in location provided for clusters. May be specified in the format projects/{{project}}/locations/{{location}}/clusters/{{cluster}} or as just the name of the cluster.</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>Reference to a Cluster in container to populate cluster.</summary>
    [JsonPropertyName("clusterRef")]
    public V1beta1NodePoolSpecForProviderClusterRef? ClusterRef { get; set; }

    /// <summary>Selector for a Cluster in container to populate cluster.</summary>
    [JsonPropertyName("clusterSelector")]
    public V1beta1NodePoolSpecForProviderClusterSelector? ClusterSelector { get; set; }

    /// <summary>The initial number of nodes for the pool. In regional or multi-zonal clusters, this is the number of nodes per zone. Changing this will force recreation of the resource.  If you don't need this value, don't set it.  If you do need it, you can use a lifecycle block to ignore subsequent changes to this field.</summary>
    [JsonPropertyName("initialNodeCount")]
    public double? InitialNodeCount { get; set; }

    /// <summary>The location (region or zone) of the cluster.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Node management configuration, wherein auto-repair and auto-upgrade is configured. Structure is documented below.</summary>
    [JsonPropertyName("management")]
    public IList<V1beta1NodePoolSpecForProviderManagement>? Management { get; set; }

    /// <summary>The maximum number of pods per node in this node pool. Note that this does not work on node pools which are "route-based" - that is, node pools belonging to clusters that do not have IP Aliasing enabled. See the official documentation for more information.</summary>
    [JsonPropertyName("maxPodsPerNode")]
    public double? MaxPodsPerNode { get; set; }

    /// <summary>The network configuration of the pool. Such as configuration for Adding Pod IP address ranges) to the node pool. Or enabling private nodes. Structure is documented below</summary>
    [JsonPropertyName("networkConfig")]
    public IList<V1beta1NodePoolSpecForProviderNetworkConfig>? NetworkConfig { get; set; }

    /// <summary>Parameters used in creating the node pool. See google_container_cluster for schema.</summary>
    [JsonPropertyName("nodeConfig")]
    public IList<V1beta1NodePoolSpecForProviderNodeConfig>? NodeConfig { get; set; }

    /// <summary>The number of nodes per instance group. This field can be used to update the number of nodes per instance group but should not be used alongside autoscaling.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>The list of zones in which the node pool's nodes should be located. Nodes must be in the region of their regional cluster or in the same region as their cluster's zone for zonal clusters. If unspecified, the cluster-level node_locations will be used.</summary>
    [JsonPropertyName("nodeLocations")]
    public IList<string>? NodeLocations { get; set; }

    /// <summary>Specifies a custom placement policy for the nodes.</summary>
    [JsonPropertyName("placementPolicy")]
    public IList<V1beta1NodePoolSpecForProviderPlacementPolicy>? PlacementPolicy { get; set; }

    /// <summary>The ID of the project in which to create the node pool. If blank, the provider-configured project will be used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Specifies node pool-level settings of queued provisioning. Structure is documented below.</summary>
    [JsonPropertyName("queuedProvisioning")]
    public IList<V1beta1NodePoolSpecForProviderQueuedProvisioning>? QueuedProvisioning { get; set; }

    /// <summary>Specify node upgrade settings to change how GKE upgrades nodes. The maximum number of nodes upgraded simultaneously is limited to 20. Structure is documented below.</summary>
    [JsonPropertyName("upgradeSettings")]
    public IList<V1beta1NodePoolSpecForProviderUpgradeSettings>? UpgradeSettings { get; set; }

    /// <summary>The Kubernetes version for the nodes in this pool. Note that if this field and auto_upgrade are both specified, they will fight each other for what the node version should be, so setting both is highly discouraged.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderAutoscaling
{
    /// <summary>Location policy specifies the algorithm used when scaling-up the node pool. Location policy is supported only in 1.24.1+ clusters.</summary>
    [JsonPropertyName("locationPolicy")]
    public string? LocationPolicy { get; set; }

    /// <summary>Maximum number of nodes per zone in the NodePool. Must be &gt;= min_node_count. Cannot be used with total limits.</summary>
    [JsonPropertyName("maxNodeCount")]
    public double? MaxNodeCount { get; set; }

    /// <summary>Minimum number of nodes per zone in the NodePool. Must be &gt;=0 and &lt;= max_node_count. Cannot be used with total limits.</summary>
    [JsonPropertyName("minNodeCount")]
    public double? MinNodeCount { get; set; }

    /// <summary>Total maximum number of nodes in the NodePool. Must be &gt;= total_min_node_count. Cannot be used with per zone limits. Total size limits are supported only in 1.24.1+ clusters.</summary>
    [JsonPropertyName("totalMaxNodeCount")]
    public double? TotalMaxNodeCount { get; set; }

    /// <summary>Total minimum number of nodes in the NodePool. Must be &gt;=0 and &lt;= total_max_node_count. Cannot be used with per zone limits. Total size limits are supported only in 1.24.1+ clusters.</summary>
    [JsonPropertyName("totalMinNodeCount")]
    public double? TotalMinNodeCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderManagement
{
    /// <summary>Whether the nodes will be automatically repaired. Enabled by default.</summary>
    [JsonPropertyName("autoRepair")]
    public bool? AutoRepair { get; set; }

    /// <summary>Whether the nodes will be automatically upgraded. Enabled by default.</summary>
    [JsonPropertyName("autoUpgrade")]
    public bool? AutoUpgrade { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNetworkConfigNetworkPerformanceConfig
{
    /// <summary></summary>
    [JsonPropertyName("totalEgressBandwidthTier")]
    public string? TotalEgressBandwidthTier { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNetworkConfigPodCidrOverprovisionConfig
{
    /// <summary></summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNetworkConfig
{
    /// <summary>Whether to create a new range for pod IPs in this node pool. Defaults are provided for pod_range and pod_ipv4_cidr_block if they are not specified.</summary>
    [JsonPropertyName("createPodRange")]
    public bool? CreatePodRange { get; set; }

    /// <summary>Whether nodes have internal IP addresses only.</summary>
    [JsonPropertyName("enablePrivateNodes")]
    public bool? EnablePrivateNodes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkPerformanceConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNetworkConfigNetworkPerformanceConfig>? NetworkPerformanceConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podCidrOverprovisionConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNetworkConfigPodCidrOverprovisionConfig>? PodCidrOverprovisionConfig { get; set; }

    /// <summary>The IP address range for pod IPs in this node pool. Only applicable if createPodRange is true. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) to pick a specific range to use.</summary>
    [JsonPropertyName("podIpv4CidrBlock")]
    public string? PodIpv4CidrBlock { get; set; }

    /// <summary>The ID of the secondary range for pod IPs. If create_pod_range is true, this ID is used for the new range. If create_pod_range is false, uses an existing secondary range with this ID.</summary>
    [JsonPropertyName("podRange")]
    public string? PodRange { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigAdvancedMachineFeatures
{
    /// <summary></summary>
    [JsonPropertyName("enableNestedVirtualization")]
    public bool? EnableNestedVirtualization { get; set; }

    /// <summary></summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigConfidentialNodes
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig
{
    /// <summary></summary>
    [JsonPropertyName("secretUri")]
    public string? SecretUri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig
{
    /// <summary></summary>
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpSecretManagerCertificateConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig>? GcpSecretManagerCertificateConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigPrivateRegistryAccessConfig
{
    /// <summary></summary>
    [JsonPropertyName("certificateAuthorityDomainConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig>? CertificateAuthorityDomainConfig { get; set; }

    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfig
{
    /// <summary></summary>
    [JsonPropertyName("privateRegistryAccessConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfigPrivateRegistryAccessConfig>? PrivateRegistryAccessConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigEphemeralStorageLocalSsdConfig
{
    /// <summary></summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigFastSocket
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigGcfsConfig
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigGuestAcceleratorGpuDriverInstallationConfig
{
    /// <summary>The Kubernetes version for the nodes in this pool. Note that if this field and auto_upgrade are both specified, they will fight each other for what the node version should be, so setting both is highly discouraged.</summary>
    [JsonPropertyName("gpuDriverVersion")]
    public string? GpuDriverVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigGuestAcceleratorGpuSharingConfig
{
    /// <summary></summary>
    [JsonPropertyName("gpuSharingStrategy")]
    public string? GpuSharingStrategy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxSharedClientsPerGpu")]
    public double? MaxSharedClientsPerGpu { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigGuestAccelerator
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gpuDriverInstallationConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigGuestAcceleratorGpuDriverInstallationConfig>? GpuDriverInstallationConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gpuPartitionSize")]
    public string? GpuPartitionSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gpuSharingConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigGuestAcceleratorGpuSharingConfig>? GpuSharingConfig { get; set; }

    /// <summary>The type of the policy. Supports a single value: COMPACT. Specifying COMPACT placement policy type places node pool's nodes in a closer physical proximity in order to reduce network latency between nodes.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigGvnic
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigHostMaintenancePolicy
{
    /// <summary></summary>
    [JsonPropertyName("maintenanceInterval")]
    public string? MaintenanceInterval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigKubeletConfig
{
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
    [JsonPropertyName("podPidsLimit")]
    public double? PodPidsLimit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigLinuxNodeConfig
{
    /// <summary></summary>
    [JsonPropertyName("cgroupMode")]
    public string? CgroupMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sysctls")]
    public IDictionary<string, string>? Sysctls { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigLocalNvmeSsdBlockConfig
{
    /// <summary></summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigReservationAffinity
{
    /// <summary></summary>
    [JsonPropertyName("consumeReservationType")]
    public string? ConsumeReservationType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigSecondaryBootDisks
{
    /// <summary></summary>
    [JsonPropertyName("diskImage")]
    public string? DiskImage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountRefPolicyResolutionEnum>))]
    public V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountRefPolicyResolveEnum>))]
    public V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountSelectorPolicyResolutionEnum>))]
    public V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountSelectorPolicyResolveEnum>))]
    public V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigShieldedInstanceConfig
{
    /// <summary></summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigSoleTenantConfigNodeAffinity
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigSoleTenantConfig
{
    /// <summary></summary>
    [JsonPropertyName("nodeAffinity")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigSoleTenantConfigNodeAffinity>? NodeAffinity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigTaint
{
    /// <summary></summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfigWorkloadMetadataConfig
{
    /// <summary></summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderNodeConfig
{
    /// <summary></summary>
    [JsonPropertyName("advancedMachineFeatures")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigAdvancedMachineFeatures>? AdvancedMachineFeatures { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bootDiskKmsKey")]
    public string? BootDiskKmsKey { get; set; }

    /// <summary>Configuration for Confidential Nodes feature. Structure is documented below.</summary>
    [JsonPropertyName("confidentialNodes")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigConfidentialNodes>? ConfidentialNodes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("containerdConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigContainerdConfig>? ContainerdConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableConfidentialStorage")]
    public bool? EnableConfidentialStorage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ephemeralStorageLocalSsdConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigEphemeralStorageLocalSsdConfig>? EphemeralStorageLocalSsdConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fastSocket")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigFastSocket>? FastSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcfsConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigGcfsConfig>? GcfsConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("guestAccelerator")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigGuestAccelerator>? GuestAccelerator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gvnic")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigGvnic>? Gvnic { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostMaintenancePolicy")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigHostMaintenancePolicy>? HostMaintenancePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imageType")]
    public string? ImageType { get; set; }

    /// <summary>This is an injected field with a default value for being able to merge items of the parent object list.</summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kubeletConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigKubeletConfig>? KubeletConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Parameters used in creating the node pool. See google_container_cluster for schema.</summary>
    [JsonPropertyName("linuxNodeConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigLinuxNodeConfig>? LinuxNodeConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localNvmeSsdBlockConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigLocalNvmeSsdBlockConfig>? LocalNvmeSsdBlockConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loggingVariant")]
    public string? LoggingVariant { get; set; }

    /// <summary></summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeGroup")]
    public string? NodeGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    /// <summary></summary>
    [JsonPropertyName("reservationAffinity")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigReservationAffinity>? ReservationAffinity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceLabels")]
    public IDictionary<string, string>? ResourceLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secondaryBootDisks")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigSecondaryBootDisks>? SecondaryBootDisks { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountSelector")]
    public V1beta1NodePoolSpecInitProviderNodeConfigServiceAccountSelector? ServiceAccountSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigShieldedInstanceConfig>? ShieldedInstanceConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("soleTenantConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigSoleTenantConfig>? SoleTenantConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spot")]
    public bool? Spot { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("taint")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigTaint>? Taint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workloadMetadataConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfigWorkloadMetadataConfig>? WorkloadMetadataConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderPlacementPolicy
{
    /// <summary>If set, refers to the name of a custom resource policy supplied by the user. The resource policy must be in the same project and region as the node pool. If not found, InvalidArgument error is returned.</summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary>The TPU placement topology for pod slice node pool.</summary>
    [JsonPropertyName("tpuTopology")]
    public string? TpuTopology { get; set; }

    /// <summary>The type of the policy. Supports a single value: COMPACT. Specifying COMPACT placement policy type places node pool's nodes in a closer physical proximity in order to reduce network latency between nodes.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderQueuedProvisioning
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy
{
    /// <summary>Number of blue nodes to drain in a batch.</summary>
    [JsonPropertyName("batchNodeCount")]
    public double? BatchNodeCount { get; set; }

    /// <summary>Percentage of the blue pool nodes to drain in a batch.</summary>
    [JsonPropertyName("batchPercentage")]
    public double? BatchPercentage { get; set; }

    /// <summary>(Optionial) Soak time after each batch gets drained.</summary>
    [JsonPropertyName("batchSoakDuration")]
    public string? BatchSoakDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderUpgradeSettingsBlueGreenSettings
{
    /// <summary>Time needed after draining the entire blue pool. After this period, the blue pool will be cleaned up.</summary>
    [JsonPropertyName("nodePoolSoakDuration")]
    public string? NodePoolSoakDuration { get; set; }

    /// <summary>Specifies the standard policy settings for blue-green upgrades.</summary>
    [JsonPropertyName("standardRolloutPolicy")]
    public IList<V1beta1NodePoolSpecInitProviderUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy>? StandardRolloutPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProviderUpgradeSettings
{
    /// <summary>The settings to adjust blue green upgrades. Structure is documented below</summary>
    [JsonPropertyName("blueGreenSettings")]
    public IList<V1beta1NodePoolSpecInitProviderUpgradeSettingsBlueGreenSettings>? BlueGreenSettings { get; set; }

    /// <summary>The number of additional nodes that can be added to the node pool during an upgrade. Increasing max_surge raises the number of nodes that can be upgraded simultaneously. Can be set to 0 or greater.</summary>
    [JsonPropertyName("maxSurge")]
    public double? MaxSurge { get; set; }

    /// <summary>The number of nodes that can be simultaneously unavailable during an upgrade. Increasing max_unavailable raises the number of nodes that can be upgraded in parallel. Can be set to 0 or greater.</summary>
    [JsonPropertyName("maxUnavailable")]
    public double? MaxUnavailable { get; set; }

    /// <summary>(Default SURGE) The upgrade stragey to be used for upgrading the nodes.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecInitProvider
{
    /// <summary>Configuration required by cluster autoscaler to adjust the size of the node pool to the current cluster usage. Structure is documented below.</summary>
    [JsonPropertyName("autoscaling")]
    public IList<V1beta1NodePoolSpecInitProviderAutoscaling>? Autoscaling { get; set; }

    /// <summary>The initial number of nodes for the pool. In regional or multi-zonal clusters, this is the number of nodes per zone. Changing this will force recreation of the resource.  If you don't need this value, don't set it.  If you do need it, you can use a lifecycle block to ignore subsequent changes to this field.</summary>
    [JsonPropertyName("initialNodeCount")]
    public double? InitialNodeCount { get; set; }

    /// <summary>Node management configuration, wherein auto-repair and auto-upgrade is configured. Structure is documented below.</summary>
    [JsonPropertyName("management")]
    public IList<V1beta1NodePoolSpecInitProviderManagement>? Management { get; set; }

    /// <summary>The maximum number of pods per node in this node pool. Note that this does not work on node pools which are "route-based" - that is, node pools belonging to clusters that do not have IP Aliasing enabled. See the official documentation for more information.</summary>
    [JsonPropertyName("maxPodsPerNode")]
    public double? MaxPodsPerNode { get; set; }

    /// <summary>The network configuration of the pool. Such as configuration for Adding Pod IP address ranges) to the node pool. Or enabling private nodes. Structure is documented below</summary>
    [JsonPropertyName("networkConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNetworkConfig>? NetworkConfig { get; set; }

    /// <summary>Parameters used in creating the node pool. See google_container_cluster for schema.</summary>
    [JsonPropertyName("nodeConfig")]
    public IList<V1beta1NodePoolSpecInitProviderNodeConfig>? NodeConfig { get; set; }

    /// <summary>The number of nodes per instance group. This field can be used to update the number of nodes per instance group but should not be used alongside autoscaling.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>The list of zones in which the node pool's nodes should be located. Nodes must be in the region of their regional cluster or in the same region as their cluster's zone for zonal clusters. If unspecified, the cluster-level node_locations will be used.</summary>
    [JsonPropertyName("nodeLocations")]
    public IList<string>? NodeLocations { get; set; }

    /// <summary>Specifies a custom placement policy for the nodes.</summary>
    [JsonPropertyName("placementPolicy")]
    public IList<V1beta1NodePoolSpecInitProviderPlacementPolicy>? PlacementPolicy { get; set; }

    /// <summary>The ID of the project in which to create the node pool. If blank, the provider-configured project will be used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Specifies node pool-level settings of queued provisioning. Structure is documented below.</summary>
    [JsonPropertyName("queuedProvisioning")]
    public IList<V1beta1NodePoolSpecInitProviderQueuedProvisioning>? QueuedProvisioning { get; set; }

    /// <summary>Specify node upgrade settings to change how GKE upgrades nodes. The maximum number of nodes upgraded simultaneously is limited to 20. Structure is documented below.</summary>
    [JsonPropertyName("upgradeSettings")]
    public IList<V1beta1NodePoolSpecInitProviderUpgradeSettings>? UpgradeSettings { get; set; }

    /// <summary>The Kubernetes version for the nodes in this pool. Note that if this field and auto_upgrade are both specified, they will fight each other for what the node version should be, so setting both is highly discouraged.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1NodePoolSpecManagementPoliciesEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1NodePoolSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1NodePoolSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1NodePoolSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1NodePoolSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodePoolSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1NodePoolSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1NodePoolSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1NodePoolSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1NodePoolSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1NodePoolSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecPublishConnectionDetailsToMetadata
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1NodePoolSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1NodePoolSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>NodePoolSpec defines the desired state of NodePool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1NodePoolSpecDeletionPolicyEnum>))]
    public V1beta1NodePoolSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1NodePoolSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1NodePoolSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1NodePoolSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1NodePoolSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1NodePoolSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1NodePoolSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderAutoscaling
{
    /// <summary>Location policy specifies the algorithm used when scaling-up the node pool. Location policy is supported only in 1.24.1+ clusters.</summary>
    [JsonPropertyName("locationPolicy")]
    public string? LocationPolicy { get; set; }

    /// <summary>Maximum number of nodes per zone in the NodePool. Must be &gt;= min_node_count. Cannot be used with total limits.</summary>
    [JsonPropertyName("maxNodeCount")]
    public double? MaxNodeCount { get; set; }

    /// <summary>Minimum number of nodes per zone in the NodePool. Must be &gt;=0 and &lt;= max_node_count. Cannot be used with total limits.</summary>
    [JsonPropertyName("minNodeCount")]
    public double? MinNodeCount { get; set; }

    /// <summary>Total maximum number of nodes in the NodePool. Must be &gt;= total_min_node_count. Cannot be used with per zone limits. Total size limits are supported only in 1.24.1+ clusters.</summary>
    [JsonPropertyName("totalMaxNodeCount")]
    public double? TotalMaxNodeCount { get; set; }

    /// <summary>Total minimum number of nodes in the NodePool. Must be &gt;=0 and &lt;= total_max_node_count. Cannot be used with per zone limits. Total size limits are supported only in 1.24.1+ clusters.</summary>
    [JsonPropertyName("totalMinNodeCount")]
    public double? TotalMinNodeCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderManagement
{
    /// <summary>Whether the nodes will be automatically repaired. Enabled by default.</summary>
    [JsonPropertyName("autoRepair")]
    public bool? AutoRepair { get; set; }

    /// <summary>Whether the nodes will be automatically upgraded. Enabled by default.</summary>
    [JsonPropertyName("autoUpgrade")]
    public bool? AutoUpgrade { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNetworkConfigNetworkPerformanceConfig
{
    /// <summary></summary>
    [JsonPropertyName("totalEgressBandwidthTier")]
    public string? TotalEgressBandwidthTier { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNetworkConfigPodCidrOverprovisionConfig
{
    /// <summary></summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNetworkConfig
{
    /// <summary>Whether to create a new range for pod IPs in this node pool. Defaults are provided for pod_range and pod_ipv4_cidr_block if they are not specified.</summary>
    [JsonPropertyName("createPodRange")]
    public bool? CreatePodRange { get; set; }

    /// <summary>Whether nodes have internal IP addresses only.</summary>
    [JsonPropertyName("enablePrivateNodes")]
    public bool? EnablePrivateNodes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkPerformanceConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNetworkConfigNetworkPerformanceConfig>? NetworkPerformanceConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("podCidrOverprovisionConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNetworkConfigPodCidrOverprovisionConfig>? PodCidrOverprovisionConfig { get; set; }

    /// <summary>The IP address range for pod IPs in this node pool. Only applicable if createPodRange is true. Set to blank to have a range chosen with the default size. Set to /netmask (e.g. /14) to have a range chosen with a specific netmask. Set to a CIDR notation (e.g. 10.96.0.0/14) to pick a specific range to use.</summary>
    [JsonPropertyName("podIpv4CidrBlock")]
    public string? PodIpv4CidrBlock { get; set; }

    /// <summary>The ID of the secondary range for pod IPs. If create_pod_range is true, this ID is used for the new range. If create_pod_range is false, uses an existing secondary range with this ID.</summary>
    [JsonPropertyName("podRange")]
    public string? PodRange { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigAdvancedMachineFeatures
{
    /// <summary></summary>
    [JsonPropertyName("enableNestedVirtualization")]
    public bool? EnableNestedVirtualization { get; set; }

    /// <summary></summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigConfidentialNodes
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig
{
    /// <summary></summary>
    [JsonPropertyName("secretUri")]
    public string? SecretUri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig
{
    /// <summary></summary>
    [JsonPropertyName("fqdns")]
    public IList<string>? Fqdns { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcpSecretManagerCertificateConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfigGcpSecretManagerCertificateConfig>? GcpSecretManagerCertificateConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigPrivateRegistryAccessConfig
{
    /// <summary></summary>
    [JsonPropertyName("certificateAuthorityDomainConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigPrivateRegistryAccessConfigCertificateAuthorityDomainConfig>? CertificateAuthorityDomainConfig { get; set; }

    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfig
{
    /// <summary></summary>
    [JsonPropertyName("privateRegistryAccessConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfigPrivateRegistryAccessConfig>? PrivateRegistryAccessConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigEffectiveTaints
{
    /// <summary></summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigEphemeralStorageLocalSsdConfig
{
    /// <summary></summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigFastSocket
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigGcfsConfig
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigGuestAcceleratorGpuDriverInstallationConfig
{
    /// <summary>The Kubernetes version for the nodes in this pool. Note that if this field and auto_upgrade are both specified, they will fight each other for what the node version should be, so setting both is highly discouraged.</summary>
    [JsonPropertyName("gpuDriverVersion")]
    public string? GpuDriverVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigGuestAcceleratorGpuSharingConfig
{
    /// <summary></summary>
    [JsonPropertyName("gpuSharingStrategy")]
    public string? GpuSharingStrategy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxSharedClientsPerGpu")]
    public double? MaxSharedClientsPerGpu { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigGuestAccelerator
{
    /// <summary></summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gpuDriverInstallationConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigGuestAcceleratorGpuDriverInstallationConfig>? GpuDriverInstallationConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gpuPartitionSize")]
    public string? GpuPartitionSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gpuSharingConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigGuestAcceleratorGpuSharingConfig>? GpuSharingConfig { get; set; }

    /// <summary>The type of the policy. Supports a single value: COMPACT. Specifying COMPACT placement policy type places node pool's nodes in a closer physical proximity in order to reduce network latency between nodes.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigGvnic
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigHostMaintenancePolicy
{
    /// <summary></summary>
    [JsonPropertyName("maintenanceInterval")]
    public string? MaintenanceInterval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigKubeletConfig
{
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
    [JsonPropertyName("podPidsLimit")]
    public double? PodPidsLimit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigLinuxNodeConfig
{
    /// <summary></summary>
    [JsonPropertyName("cgroupMode")]
    public string? CgroupMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sysctls")]
    public IDictionary<string, string>? Sysctls { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigLocalNvmeSsdBlockConfig
{
    /// <summary></summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigReservationAffinity
{
    /// <summary></summary>
    [JsonPropertyName("consumeReservationType")]
    public string? ConsumeReservationType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigSecondaryBootDisks
{
    /// <summary></summary>
    [JsonPropertyName("diskImage")]
    public string? DiskImage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigShieldedInstanceConfig
{
    /// <summary></summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigSoleTenantConfigNodeAffinity
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigSoleTenantConfig
{
    /// <summary></summary>
    [JsonPropertyName("nodeAffinity")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigSoleTenantConfigNodeAffinity>? NodeAffinity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigTaint
{
    /// <summary></summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary></summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfigWorkloadMetadataConfig
{
    /// <summary></summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderNodeConfig
{
    /// <summary></summary>
    [JsonPropertyName("advancedMachineFeatures")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigAdvancedMachineFeatures>? AdvancedMachineFeatures { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bootDiskKmsKey")]
    public string? BootDiskKmsKey { get; set; }

    /// <summary>Configuration for Confidential Nodes feature. Structure is documented below.</summary>
    [JsonPropertyName("confidentialNodes")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigConfidentialNodes>? ConfidentialNodes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("containerdConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigContainerdConfig>? ContainerdConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveTaints")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigEffectiveTaints>? EffectiveTaints { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableConfidentialStorage")]
    public bool? EnableConfidentialStorage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ephemeralStorageLocalSsdConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigEphemeralStorageLocalSsdConfig>? EphemeralStorageLocalSsdConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fastSocket")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigFastSocket>? FastSocket { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gcfsConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigGcfsConfig>? GcfsConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("guestAccelerator")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigGuestAccelerator>? GuestAccelerator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gvnic")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigGvnic>? Gvnic { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostMaintenancePolicy")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigHostMaintenancePolicy>? HostMaintenancePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imageType")]
    public string? ImageType { get; set; }

    /// <summary>This is an injected field with a default value for being able to merge items of the parent object list.</summary>
    [JsonPropertyName("index")]
    public string? Index { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kubeletConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigKubeletConfig>? KubeletConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Parameters used in creating the node pool. See google_container_cluster for schema.</summary>
    [JsonPropertyName("linuxNodeConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigLinuxNodeConfig>? LinuxNodeConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localNvmeSsdBlockConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigLocalNvmeSsdBlockConfig>? LocalNvmeSsdBlockConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("localSsdCount")]
    public double? LocalSsdCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loggingVariant")]
    public string? LoggingVariant { get; set; }

    /// <summary></summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeGroup")]
    public string? NodeGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("oauthScopes")]
    public IList<string>? OauthScopes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    /// <summary></summary>
    [JsonPropertyName("reservationAffinity")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigReservationAffinity>? ReservationAffinity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceLabels")]
    public IDictionary<string, string>? ResourceLabels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secondaryBootDisks")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigSecondaryBootDisks>? SecondaryBootDisks { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigShieldedInstanceConfig>? ShieldedInstanceConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("soleTenantConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigSoleTenantConfig>? SoleTenantConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spot")]
    public bool? Spot { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("taint")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigTaint>? Taint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workloadMetadataConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfigWorkloadMetadataConfig>? WorkloadMetadataConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderPlacementPolicy
{
    /// <summary>If set, refers to the name of a custom resource policy supplied by the user. The resource policy must be in the same project and region as the node pool. If not found, InvalidArgument error is returned.</summary>
    [JsonPropertyName("policyName")]
    public string? PolicyName { get; set; }

    /// <summary>The TPU placement topology for pod slice node pool.</summary>
    [JsonPropertyName("tpuTopology")]
    public string? TpuTopology { get; set; }

    /// <summary>The type of the policy. Supports a single value: COMPACT. Specifying COMPACT placement policy type places node pool's nodes in a closer physical proximity in order to reduce network latency between nodes.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderQueuedProvisioning
{
    /// <summary>Makes nodes obtainable through the ProvisioningRequest API exclusively.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy
{
    /// <summary>Number of blue nodes to drain in a batch.</summary>
    [JsonPropertyName("batchNodeCount")]
    public double? BatchNodeCount { get; set; }

    /// <summary>Percentage of the blue pool nodes to drain in a batch.</summary>
    [JsonPropertyName("batchPercentage")]
    public double? BatchPercentage { get; set; }

    /// <summary>(Optionial) Soak time after each batch gets drained.</summary>
    [JsonPropertyName("batchSoakDuration")]
    public string? BatchSoakDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderUpgradeSettingsBlueGreenSettings
{
    /// <summary>Time needed after draining the entire blue pool. After this period, the blue pool will be cleaned up.</summary>
    [JsonPropertyName("nodePoolSoakDuration")]
    public string? NodePoolSoakDuration { get; set; }

    /// <summary>Specifies the standard policy settings for blue-green upgrades.</summary>
    [JsonPropertyName("standardRolloutPolicy")]
    public IList<V1beta1NodePoolStatusAtProviderUpgradeSettingsBlueGreenSettingsStandardRolloutPolicy>? StandardRolloutPolicy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProviderUpgradeSettings
{
    /// <summary>The settings to adjust blue green upgrades. Structure is documented below</summary>
    [JsonPropertyName("blueGreenSettings")]
    public IList<V1beta1NodePoolStatusAtProviderUpgradeSettingsBlueGreenSettings>? BlueGreenSettings { get; set; }

    /// <summary>The number of additional nodes that can be added to the node pool during an upgrade. Increasing max_surge raises the number of nodes that can be upgraded simultaneously. Can be set to 0 or greater.</summary>
    [JsonPropertyName("maxSurge")]
    public double? MaxSurge { get; set; }

    /// <summary>The number of nodes that can be simultaneously unavailable during an upgrade. Increasing max_unavailable raises the number of nodes that can be upgraded in parallel. Can be set to 0 or greater.</summary>
    [JsonPropertyName("maxUnavailable")]
    public double? MaxUnavailable { get; set; }

    /// <summary>(Default SURGE) The upgrade stragey to be used for upgrading the nodes.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusAtProvider
{
    /// <summary>Configuration required by cluster autoscaler to adjust the size of the node pool to the current cluster usage. Structure is documented below.</summary>
    [JsonPropertyName("autoscaling")]
    public IList<V1beta1NodePoolStatusAtProviderAutoscaling>? Autoscaling { get; set; }

    /// <summary>The cluster to create the node pool for. Cluster must be present in location provided for clusters. May be specified in the format projects/{{project}}/locations/{{location}}/clusters/{{cluster}} or as just the name of the cluster.</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>an identifier for the resource with format {{project}}/{{location}}/{{cluster}}/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The initial number of nodes for the pool. In regional or multi-zonal clusters, this is the number of nodes per zone. Changing this will force recreation of the resource.  If you don't need this value, don't set it.  If you do need it, you can use a lifecycle block to ignore subsequent changes to this field.</summary>
    [JsonPropertyName("initialNodeCount")]
    public double? InitialNodeCount { get; set; }

    /// <summary>The resource URLs of the managed instance groups associated with this node pool.</summary>
    [JsonPropertyName("instanceGroupUrls")]
    public IList<string>? InstanceGroupUrls { get; set; }

    /// <summary>The location (region or zone) of the cluster.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>List of instance group URLs which have been assigned to this node pool.</summary>
    [JsonPropertyName("managedInstanceGroupUrls")]
    public IList<string>? ManagedInstanceGroupUrls { get; set; }

    /// <summary>Node management configuration, wherein auto-repair and auto-upgrade is configured. Structure is documented below.</summary>
    [JsonPropertyName("management")]
    public IList<V1beta1NodePoolStatusAtProviderManagement>? Management { get; set; }

    /// <summary>The maximum number of pods per node in this node pool. Note that this does not work on node pools which are "route-based" - that is, node pools belonging to clusters that do not have IP Aliasing enabled. See the official documentation for more information.</summary>
    [JsonPropertyName("maxPodsPerNode")]
    public double? MaxPodsPerNode { get; set; }

    /// <summary>The network configuration of the pool. Such as configuration for Adding Pod IP address ranges) to the node pool. Or enabling private nodes. Structure is documented below</summary>
    [JsonPropertyName("networkConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNetworkConfig>? NetworkConfig { get; set; }

    /// <summary>Parameters used in creating the node pool. See google_container_cluster for schema.</summary>
    [JsonPropertyName("nodeConfig")]
    public IList<V1beta1NodePoolStatusAtProviderNodeConfig>? NodeConfig { get; set; }

    /// <summary>The number of nodes per instance group. This field can be used to update the number of nodes per instance group but should not be used alongside autoscaling.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>The list of zones in which the node pool's nodes should be located. Nodes must be in the region of their regional cluster or in the same region as their cluster's zone for zonal clusters. If unspecified, the cluster-level node_locations will be used.</summary>
    [JsonPropertyName("nodeLocations")]
    public IList<string>? NodeLocations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>Specifies a custom placement policy for the nodes.</summary>
    [JsonPropertyName("placementPolicy")]
    public IList<V1beta1NodePoolStatusAtProviderPlacementPolicy>? PlacementPolicy { get; set; }

    /// <summary>The ID of the project in which to create the node pool. If blank, the provider-configured project will be used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Specifies node pool-level settings of queued provisioning. Structure is documented below.</summary>
    [JsonPropertyName("queuedProvisioning")]
    public IList<V1beta1NodePoolStatusAtProviderQueuedProvisioning>? QueuedProvisioning { get; set; }

    /// <summary>Specify node upgrade settings to change how GKE upgrades nodes. The maximum number of nodes upgraded simultaneously is limited to 20. Structure is documented below.</summary>
    [JsonPropertyName("upgradeSettings")]
    public IList<V1beta1NodePoolStatusAtProviderUpgradeSettings>? UpgradeSettings { get; set; }

    /// <summary>The Kubernetes version for the nodes in this pool. Note that if this field and auto_upgrade are both specified, they will fight each other for what the node version should be, so setting both is highly discouraged.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatusConditions
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

/// <summary>NodePoolStatus defines the observed state of NodePool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NodePoolStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1NodePoolStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1NodePoolStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>NodePool is the Schema for the NodePools API. Manages a GKE NodePool resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NodePool : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1NodePoolSpec>, IStatus<V1beta1NodePoolStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NodePool";
    public const string KubeGroup = "container.gcp.upbound.io";
    public const string KubePluralName = "nodepools";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NodePoolSpec defines the desired state of NodePool</summary>
    [JsonPropertyName("spec")]
    public V1beta1NodePoolSpec Spec { get; set; }

    /// <summary>NodePoolStatus defines the observed state of NodePool.</summary>
    [JsonPropertyName("status")]
    public V1beta1NodePoolStatus? Status { get; set; }
}