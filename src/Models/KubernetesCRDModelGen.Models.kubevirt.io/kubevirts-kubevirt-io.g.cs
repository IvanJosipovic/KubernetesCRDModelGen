using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kubevirt.io;
/// <summary>CA configuration CA certs are kept in the CA bundle as long as they are valid</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecCertificateRotateStrategySelfSignedCa
{
    /// <summary>The requested 'duration' (i.e. lifetime) of the Certificate.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>The amount of time before the currently issued certificate's "notAfter" time that we will begin to attempt to renew the certificate.</summary>
    [JsonPropertyName("renewBefore")]
    public string? RenewBefore { get; set; }
}

/// <summary>Server configuration Certs are rotated and discarded</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecCertificateRotateStrategySelfSignedServer
{
    /// <summary>The requested 'duration' (i.e. lifetime) of the Certificate.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>The amount of time before the currently issued certificate's "notAfter" time that we will begin to attempt to renew the certificate.</summary>
    [JsonPropertyName("renewBefore")]
    public string? RenewBefore { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecCertificateRotateStrategySelfSigned
{
    /// <summary>CA configuration CA certs are kept in the CA bundle as long as they are valid</summary>
    [JsonPropertyName("ca")]
    public V1KubeVirtSpecCertificateRotateStrategySelfSignedCa? Ca { get; set; }

    /// <summary>Deprecated. Use CA.Duration and CA.RenewBefore instead</summary>
    [JsonPropertyName("caOverlapInterval")]
    public string? CaOverlapInterval { get; set; }

    /// <summary>Deprecated. Use CA.Duration instead</summary>
    [JsonPropertyName("caRotateInterval")]
    public string? CaRotateInterval { get; set; }

    /// <summary>Deprecated. Use Server.Duration instead</summary>
    [JsonPropertyName("certRotateInterval")]
    public string? CertRotateInterval { get; set; }

    /// <summary>Server configuration Certs are rotated and discarded</summary>
    [JsonPropertyName("server")]
    public V1KubeVirtSpecCertificateRotateStrategySelfSignedServer? Server { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecCertificateRotateStrategy
{
    /// <summary></summary>
    [JsonPropertyName("selfSigned")]
    public V1KubeVirtSpecCertificateRotateStrategySelfSigned? SelfSigned { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationApiConfigurationRestClientRateLimiterTokenBucketRateLimiter
{
    /// <summary>Maximum burst for throttle. If it's zero, the component default will be used</summary>
    [JsonPropertyName("burst")]
    public int Burst { get; set; }

    /// <summary>QPS indicates the maximum QPS to the apiserver from this client. If it's zero, the component default will be used</summary>
    [JsonPropertyName("qps")]
    public double Qps { get; set; }
}

/// <summary>RateLimiter allows selecting and configuring different rate limiters for the k8s client.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationApiConfigurationRestClientRateLimiter
{
    /// <summary></summary>
    [JsonPropertyName("tokenBucketRateLimiter")]
    public V1KubeVirtSpecConfigurationApiConfigurationRestClientRateLimiterTokenBucketRateLimiter? TokenBucketRateLimiter { get; set; }
}

/// <summary>RestClient can be used to tune certain aspects of the k8s client in use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationApiConfigurationRestClient
{
    /// <summary>RateLimiter allows selecting and configuring different rate limiters for the k8s client.</summary>
    [JsonPropertyName("rateLimiter")]
    public V1KubeVirtSpecConfigurationApiConfigurationRestClientRateLimiter? RateLimiter { get; set; }
}

/// <summary>ReloadableComponentConfiguration holds all generic k8s configuration options which can be reloaded by components without requiring a restart.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationApiConfiguration
{
    /// <summary>RestClient can be used to tune certain aspects of the k8s client in use.</summary>
    [JsonPropertyName("restClient")]
    public V1KubeVirtSpecConfigurationApiConfigurationRestClient? RestClient { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationArchitectureConfigurationAmd64
{
    /// <summary></summary>
    [JsonPropertyName("emulatedMachines")]
    public IList<string>? EmulatedMachines { get; set; }

    /// <summary></summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ovmfPath")]
    public string? OvmfPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationArchitectureConfigurationArm64
{
    /// <summary></summary>
    [JsonPropertyName("emulatedMachines")]
    public IList<string>? EmulatedMachines { get; set; }

    /// <summary></summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ovmfPath")]
    public string? OvmfPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationArchitectureConfigurationPpc64le
{
    /// <summary></summary>
    [JsonPropertyName("emulatedMachines")]
    public IList<string>? EmulatedMachines { get; set; }

    /// <summary></summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ovmfPath")]
    public string? OvmfPath { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationArchitectureConfiguration
{
    /// <summary></summary>
    [JsonPropertyName("amd64")]
    public V1KubeVirtSpecConfigurationArchitectureConfigurationAmd64? Amd64 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("arm64")]
    public V1KubeVirtSpecConfigurationArchitectureConfigurationArm64? Arm64 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultArchitecture")]
    public string? DefaultArchitecture { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ppc64le")]
    public V1KubeVirtSpecConfigurationArchitectureConfigurationPpc64le? Ppc64le { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationAutoCPULimitNamespaceLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>When set, AutoCPULimitNamespaceLabelSelector will set a CPU limit on virt-launcher for VMIs running inside namespaces that match the label selector. The CPU limit will equal the number of requested vCPUs. This setting does not apply to VMIs with dedicated CPUs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationAutoCPULimitNamespaceLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1KubeVirtSpecConfigurationAutoCPULimitNamespaceLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationControllerConfigurationRestClientRateLimiterTokenBucketRateLimiter
{
    /// <summary>Maximum burst for throttle. If it's zero, the component default will be used</summary>
    [JsonPropertyName("burst")]
    public int Burst { get; set; }

    /// <summary>QPS indicates the maximum QPS to the apiserver from this client. If it's zero, the component default will be used</summary>
    [JsonPropertyName("qps")]
    public double Qps { get; set; }
}

/// <summary>RateLimiter allows selecting and configuring different rate limiters for the k8s client.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationControllerConfigurationRestClientRateLimiter
{
    /// <summary></summary>
    [JsonPropertyName("tokenBucketRateLimiter")]
    public V1KubeVirtSpecConfigurationControllerConfigurationRestClientRateLimiterTokenBucketRateLimiter? TokenBucketRateLimiter { get; set; }
}

/// <summary>RestClient can be used to tune certain aspects of the k8s client in use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationControllerConfigurationRestClient
{
    /// <summary>RateLimiter allows selecting and configuring different rate limiters for the k8s client.</summary>
    [JsonPropertyName("rateLimiter")]
    public V1KubeVirtSpecConfigurationControllerConfigurationRestClientRateLimiter? RateLimiter { get; set; }
}

/// <summary>ReloadableComponentConfiguration holds all generic k8s configuration options which can be reloaded by components without requiring a restart.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationControllerConfiguration
{
    /// <summary>RestClient can be used to tune certain aspects of the k8s client in use.</summary>
    [JsonPropertyName("restClient")]
    public V1KubeVirtSpecConfigurationControllerConfigurationRestClient? RestClient { get; set; }
}

/// <summary>DiskVerification holds container disks verification limits</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationDeveloperConfigurationDiskVerification
{
    /// <summary></summary>
    [JsonPropertyName("memoryLimit")]
    public IntstrIntOrString MemoryLimit { get; set; }
}

/// <summary>LogVerbosity sets log verbosity level of  various components</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationDeveloperConfigurationLogVerbosity
{
    /// <summary>NodeVerbosity represents a map of nodes with a specific verbosity level</summary>
    [JsonPropertyName("nodeVerbosity")]
    public IDictionary<string, int>? NodeVerbosity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("virtAPI")]
    public int? VirtAPI { get; set; }

    /// <summary></summary>
    [JsonPropertyName("virtController")]
    public int? VirtController { get; set; }

    /// <summary></summary>
    [JsonPropertyName("virtHandler")]
    public int? VirtHandler { get; set; }

    /// <summary></summary>
    [JsonPropertyName("virtLauncher")]
    public int? VirtLauncher { get; set; }

    /// <summary></summary>
    [JsonPropertyName("virtOperator")]
    public int? VirtOperator { get; set; }
}

/// <summary>DeveloperConfiguration holds developer options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationDeveloperConfiguration
{
    /// <summary>For each requested virtual CPU, CPUAllocationRatio defines how much physical CPU to request per VMI from the hosting node. The value is in fraction of a CPU thread (or core on non-hyperthreaded nodes). For example, a value of 1 means 1 physical CPU thread per VMI CPU thread. A value of 100 would be 1% of a physical thread allocated for each requested VMI thread. This option has no effect on VMIs that request dedicated CPUs. More information at: https://kubevirt.io/user-guide/operations/node_overcommit/#node-cpu-allocation-ratio Defaults to 10</summary>
    [JsonPropertyName("cpuAllocationRatio")]
    public int? CpuAllocationRatio { get; set; }

    /// <summary>DiskVerification holds container disks verification limits</summary>
    [JsonPropertyName("diskVerification")]
    public V1KubeVirtSpecConfigurationDeveloperConfigurationDiskVerification? DiskVerification { get; set; }

    /// <summary>FeatureGates is the list of experimental features to enable. Defaults to none</summary>
    [JsonPropertyName("featureGates")]
    public IList<string>? FeatureGates { get; set; }

    /// <summary>LogVerbosity sets log verbosity level of  various components</summary>
    [JsonPropertyName("logVerbosity")]
    public V1KubeVirtSpecConfigurationDeveloperConfigurationLogVerbosity? LogVerbosity { get; set; }

    /// <summary>MemoryOvercommit is the percentage of memory we want to give VMIs compared to the amount given to its parent pod (virt-launcher). For example, a value of 102 means the VMI will "see" 2% more memory than its parent pod. Values under 100 are effectively "undercommits". Overcommits can lead to memory exhaustion, which in turn can lead to crashes. Use carefully. Defaults to 100</summary>
    [JsonPropertyName("memoryOvercommit")]
    public int? MemoryOvercommit { get; set; }

    /// <summary>Allow overriding the automatically determined minimum TSC frequency of the cluster and fixate the minimum to this frequency.</summary>
    [JsonPropertyName("minimumClusterTSCFrequency")]
    public long? MinimumClusterTSCFrequency { get; set; }

    /// <summary>MinimumReservePVCBytes is the amount of space, in bytes, to leave unused on disks. Defaults to 131072 (128KiB)</summary>
    [JsonPropertyName("minimumReservePVCBytes")]
    public long? MinimumReservePVCBytes { get; set; }

    /// <summary>NodeSelectors allows restricting VMI creation to nodes that match a set of labels. Defaults to none</summary>
    [JsonPropertyName("nodeSelectors")]
    public IDictionary<string, string>? NodeSelectors { get; set; }

    /// <summary>LessPVCSpaceToleration determines how much smaller, in percentage, disk PVCs are allowed to be compared to the requested size (to account for various overheads). Defaults to 10</summary>
    [JsonPropertyName("pvcTolerateLessSpaceUpToPercent")]
    public int? PvcTolerateLessSpaceUpToPercent { get; set; }

    /// <summary>UseEmulation can be set to true to allow fallback to software emulation in case hardware-assisted emulation is not available. Defaults to false</summary>
    [JsonPropertyName("useEmulation")]
    public bool? UseEmulation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationHandlerConfigurationRestClientRateLimiterTokenBucketRateLimiter
{
    /// <summary>Maximum burst for throttle. If it's zero, the component default will be used</summary>
    [JsonPropertyName("burst")]
    public int Burst { get; set; }

    /// <summary>QPS indicates the maximum QPS to the apiserver from this client. If it's zero, the component default will be used</summary>
    [JsonPropertyName("qps")]
    public double Qps { get; set; }
}

/// <summary>RateLimiter allows selecting and configuring different rate limiters for the k8s client.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationHandlerConfigurationRestClientRateLimiter
{
    /// <summary></summary>
    [JsonPropertyName("tokenBucketRateLimiter")]
    public V1KubeVirtSpecConfigurationHandlerConfigurationRestClientRateLimiterTokenBucketRateLimiter? TokenBucketRateLimiter { get; set; }
}

/// <summary>RestClient can be used to tune certain aspects of the k8s client in use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationHandlerConfigurationRestClient
{
    /// <summary>RateLimiter allows selecting and configuring different rate limiters for the k8s client.</summary>
    [JsonPropertyName("rateLimiter")]
    public V1KubeVirtSpecConfigurationHandlerConfigurationRestClientRateLimiter? RateLimiter { get; set; }
}

/// <summary>ReloadableComponentConfiguration holds all generic k8s configuration options which can be reloaded by components without requiring a restart.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationHandlerConfiguration
{
    /// <summary>RestClient can be used to tune certain aspects of the k8s client in use.</summary>
    [JsonPropertyName("restClient")]
    public V1KubeVirtSpecConfigurationHandlerConfigurationRestClient? RestClient { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationKsmConfigurationNodeLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>NodeLabelSelector is a selector that filters in which nodes the KSM will be enabled. Empty NodeLabelSelector will enable ksm for every node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationKsmConfigurationNodeLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1KubeVirtSpecConfigurationKsmConfigurationNodeLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>KSMConfiguration holds the information regarding the enabling the KSM in the nodes (if available).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationKsmConfiguration
{
    /// <summary>NodeLabelSelector is a selector that filters in which nodes the KSM will be enabled. Empty NodeLabelSelector will enable ksm for every node.</summary>
    [JsonPropertyName("nodeLabelSelector")]
    public V1KubeVirtSpecConfigurationKsmConfigurationNodeLabelSelector? NodeLabelSelector { get; set; }
}

/// <summary>LiveUpdateConfiguration holds defaults for live update features</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationLiveUpdateConfiguration
{
    /// <summary>MaxCpuSockets holds the maximum amount of sockets that can be hotplugged</summary>
    [JsonPropertyName("maxCpuSockets")]
    public int? MaxCpuSockets { get; set; }

    /// <summary>MaxGuest defines the maximum amount memory that can be allocated to the guest using hotplug.</summary>
    [JsonPropertyName("maxGuest")]
    public IntstrIntOrString? MaxGuest { get; set; }

    /// <summary>MaxHotplugRatio is the ratio used to define the max amount of a hotplug resource that can be made available to a VM when the specific Max* setting is not defined (MaxCpuSockets, MaxGuest) Example: VM is configured with 512Mi of guest memory, if MaxGuest is not defined and MaxHotplugRatio is 2 then MaxGuest = 1Gi defaults to 4</summary>
    [JsonPropertyName("maxHotplugRatio")]
    public int? MaxHotplugRatio { get; set; }
}

/// <summary>NodeMediatedDeviceTypesConfig holds information about MDEV types to be defined in a specific node that matches the NodeSelector field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationMediatedDevicesConfigurationNodeMediatedDeviceTypes
{
    /// <summary></summary>
    [JsonPropertyName("mediatedDeviceTypes")]
    public IList<string>? MediatedDeviceTypes { get; set; }

    /// <summary>Deprecated. Use mediatedDeviceTypes instead.</summary>
    [JsonPropertyName("mediatedDevicesTypes")]
    public IList<string>? MediatedDevicesTypes { get; set; }

    /// <summary>NodeSelector is a selector which must be true for the vmi to fit on a node. Selector which must match a node's labels for the vmi to be scheduled on that node. More info: https://kubernetes.io/docs/concepts/configuration/assign-pod-node/</summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string> NodeSelector { get; set; }
}

/// <summary>MediatedDevicesConfiguration holds information about MDEV types to be defined, if available</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationMediatedDevicesConfiguration
{
    /// <summary></summary>
    [JsonPropertyName("mediatedDeviceTypes")]
    public IList<string>? MediatedDeviceTypes { get; set; }

    /// <summary>Deprecated. Use mediatedDeviceTypes instead.</summary>
    [JsonPropertyName("mediatedDevicesTypes")]
    public IList<string>? MediatedDevicesTypes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeMediatedDeviceTypes")]
    public IList<V1KubeVirtSpecConfigurationMediatedDevicesConfigurationNodeMediatedDeviceTypes>? NodeMediatedDeviceTypes { get; set; }
}

/// <summary>MigrationConfiguration holds migration options. Can be overridden for specific groups of VMs though migration policies. Visit https://kubevirt.io/user-guide/operations/migration_policies/ for more information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationMigrations
{
    /// <summary>AllowAutoConverge allows the platform to compromise performance/availability of VMIs to guarantee successful VMI live migrations. Defaults to false</summary>
    [JsonPropertyName("allowAutoConverge")]
    public bool? AllowAutoConverge { get; set; }

    /// <summary>AllowPostCopy enables post-copy live migrations. Such migrations allow even the busiest VMIs to successfully live-migrate. However, events like a network failure can cause a VMI crash. If set to true, migrations will still start in pre-copy, but switch to post-copy when CompletionTimeoutPerGiB triggers. Defaults to false</summary>
    [JsonPropertyName("allowPostCopy")]
    public bool? AllowPostCopy { get; set; }

    /// <summary>BandwidthPerMigration limits the amount of network bandwidth live migrations are allowed to use. The value is in quantity per second. Defaults to 0 (no limit)</summary>
    [JsonPropertyName("bandwidthPerMigration")]
    public IntstrIntOrString? BandwidthPerMigration { get; set; }

    /// <summary>CompletionTimeoutPerGiB is the maximum number of seconds per GiB a migration is allowed to take. If a live-migration takes longer to migrate than this value multiplied by the size of the VMI, the migration will be cancelled, unless AllowPostCopy is true. Defaults to 800</summary>
    [JsonPropertyName("completionTimeoutPerGiB")]
    public long? CompletionTimeoutPerGiB { get; set; }

    /// <summary>When set to true, DisableTLS will disable the additional layer of live migration encryption provided by KubeVirt. This is usually a bad idea. Defaults to false</summary>
    [JsonPropertyName("disableTLS")]
    public bool? DisableTLS { get; set; }

    /// <summary>By default, the SELinux level of target virt-launcher pods is forced to the level of the source virt-launcher. When set to true, MatchSELinuxLevelOnMigration lets the CRI auto-assign a random level to the target. That will ensure the target virt-launcher doesn't share categories with another pod on the node. However, migrations will fail when using RWX volumes that don't automatically deal with SELinux levels.</summary>
    [JsonPropertyName("matchSELinuxLevelOnMigration")]
    public bool? MatchSELinuxLevelOnMigration { get; set; }

    /// <summary>Network is the name of the CNI network to use for live migrations. By default, migrations go through the pod network.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>NodeDrainTaintKey defines the taint key that indicates a node should be drained. Note: this option relies on the deprecated node taint feature. Default: kubevirt.io/drain</summary>
    [JsonPropertyName("nodeDrainTaintKey")]
    public string? NodeDrainTaintKey { get; set; }

    /// <summary>ParallelMigrationsPerCluster is the total number of concurrent live migrations allowed cluster-wide. Defaults to 5</summary>
    [JsonPropertyName("parallelMigrationsPerCluster")]
    public int? ParallelMigrationsPerCluster { get; set; }

    /// <summary>ParallelOutboundMigrationsPerNode is the maximum number of concurrent outgoing live migrations allowed per node. Defaults to 2</summary>
    [JsonPropertyName("parallelOutboundMigrationsPerNode")]
    public int? ParallelOutboundMigrationsPerNode { get; set; }

    /// <summary>ProgressTimeout is the maximum number of seconds a live migration is allowed to make no progress. Hitting this timeout means a migration transferred 0 data for that many seconds. The migration is then considered stuck and therefore cancelled. Defaults to 150</summary>
    [JsonPropertyName("progressTimeout")]
    public long? ProgressTimeout { get; set; }

    /// <summary>UnsafeMigrationOverride allows live migrations to occur even if the compatibility check indicates the migration will be unsafe to the guest. Defaults to false</summary>
    [JsonPropertyName("unsafeMigrationOverride")]
    public bool? UnsafeMigrationOverride { get; set; }
}

/// <summary>ResourceClaim references one entry in PodSpec.ResourceClaims.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationNetworkBindingComputeResourceOverheadClaims
{
    /// <summary>Name must match the name of one entry in pod.spec.resourceClaims of the Pod where this field is used. It makes that resource available inside a container.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ComputeResourceOverhead specifies the resource overhead that should be added to the compute container when using the binding. version: v1alphav1</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationNetworkBindingComputeResourceOverhead
{
    /// <summary>Claims lists the names of resources, defined in spec.resourceClaims, that are used by this container.   This is an alpha field and requires enabling the DynamicResourceAllocation feature gate.   This field is immutable. It can only be set for containers.</summary>
    [JsonPropertyName("claims")]
    public IList<V1KubeVirtSpecConfigurationNetworkBindingComputeResourceOverheadClaims>? Claims { get; set; }

    /// <summary>Limits describes the maximum amount of compute resources allowed. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, IntstrIntOrString>? Limits { get; set; }

    /// <summary>Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. Requests cannot exceed Limits. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
    [JsonPropertyName("requests")]
    public IDictionary<string, IntstrIntOrString>? Requests { get; set; }
}

/// <summary>Migration means the VM using the plugin can be safely migrated version: 1alphav1</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationNetworkBindingMigration
{
    /// <summary>Method defines a pre-defined migration methodology version: 1alphav1</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationNetworkBinding
{
    /// <summary>ComputeResourceOverhead specifies the resource overhead that should be added to the compute container when using the binding. version: v1alphav1</summary>
    [JsonPropertyName("computeResourceOverhead")]
    public V1KubeVirtSpecConfigurationNetworkBindingComputeResourceOverhead? ComputeResourceOverhead { get; set; }

    /// <summary>DomainAttachmentType is a standard domain network attachment method kubevirt supports. Supported values: "tap". The standard domain attachment can be used instead or in addition to the sidecarImage. version: 1alphav1</summary>
    [JsonPropertyName("domainAttachmentType")]
    public string? DomainAttachmentType { get; set; }

    /// <summary>DownwardAPI specifies what kind of data should be exposed to the binding plugin sidecar. Supported values: "device-info" version: v1alphav1</summary>
    [JsonPropertyName("downwardAPI")]
    public string? DownwardAPI { get; set; }

    /// <summary>Migration means the VM using the plugin can be safely migrated version: 1alphav1</summary>
    [JsonPropertyName("migration")]
    public V1KubeVirtSpecConfigurationNetworkBindingMigration? Migration { get; set; }

    /// <summary>NetworkAttachmentDefinition references to a NetworkAttachmentDefinition CR object. Format: &lt;name&gt;, &lt;namespace&gt;/&lt;name&gt;. If namespace is not specified, VMI namespace is assumed. version: 1alphav1</summary>
    [JsonPropertyName("networkAttachmentDefinition")]
    public string? NetworkAttachmentDefinition { get; set; }

    /// <summary>SidecarImage references a container image that runs in the virt-launcher pod. The sidecar handles (libvirt) domain configuration and optional services. version: 1alphav1</summary>
    [JsonPropertyName("sidecarImage")]
    public string? SidecarImage { get; set; }
}

/// <summary>NetworkConfiguration holds network options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationNetwork
{
    /// <summary></summary>
    [JsonPropertyName("binding")]
    public IDictionary<string, V1KubeVirtSpecConfigurationNetworkBinding>? Binding { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultNetworkInterface")]
    public string? DefaultNetworkInterface { get; set; }

    /// <summary></summary>
    [JsonPropertyName("permitBridgeInterfaceOnPodNetwork")]
    public bool? PermitBridgeInterfaceOnPodNetwork { get; set; }

    /// <summary>DeprecatedPermitSlirpInterface is an alias for the deprecated PermitSlirpInterface. Deprecated: Removed in v1.3.</summary>
    [JsonPropertyName("permitSlirpInterface")]
    public bool? PermitSlirpInterface { get; set; }
}

/// <summary>MediatedHostDevice represents a host mediated device allowed for passthrough</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationPermittedHostDevicesMediatedDevices
{
    /// <summary></summary>
    [JsonPropertyName("externalResourceProvider")]
    public bool? ExternalResourceProvider { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mdevNameSelector")]
    public string MdevNameSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceName")]
    public string ResourceName { get; set; }
}

/// <summary>PciHostDevice represents a host PCI device allowed for passthrough</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationPermittedHostDevicesPciHostDevices
{
    /// <summary>If true, KubeVirt will leave the allocation and monitoring to an external device plugin</summary>
    [JsonPropertyName("externalResourceProvider")]
    public bool? ExternalResourceProvider { get; set; }

    /// <summary>The vendor_id:product_id tuple of the PCI device</summary>
    [JsonPropertyName("pciVendorSelector")]
    public string PciVendorSelector { get; set; }

    /// <summary>The name of the resource that is representing the device. Exposed by a device plugin and requested by VMs. Typically of the form vendor.com/product_name</summary>
    [JsonPropertyName("resourceName")]
    public string ResourceName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationPermittedHostDevicesUsbSelectors
{
    /// <summary></summary>
    [JsonPropertyName("product")]
    public string Product { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vendor")]
    public string Vendor { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationPermittedHostDevicesUsb
{
    /// <summary>If true, KubeVirt will leave the allocation and monitoring to an external device plugin</summary>
    [JsonPropertyName("externalResourceProvider")]
    public bool? ExternalResourceProvider { get; set; }

    /// <summary>Identifies the list of USB host devices. e.g: kubevirt.io/storage, kubevirt.io/bootable-usb, etc</summary>
    [JsonPropertyName("resourceName")]
    public string ResourceName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selectors")]
    public IList<V1KubeVirtSpecConfigurationPermittedHostDevicesUsbSelectors>? Selectors { get; set; }
}

/// <summary>PermittedHostDevices holds information about devices allowed for passthrough</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationPermittedHostDevices
{
    /// <summary></summary>
    [JsonPropertyName("mediatedDevices")]
    public IList<V1KubeVirtSpecConfigurationPermittedHostDevicesMediatedDevices>? MediatedDevices { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pciHostDevices")]
    public IList<V1KubeVirtSpecConfigurationPermittedHostDevicesPciHostDevices>? PciHostDevices { get; set; }

    /// <summary></summary>
    [JsonPropertyName("usb")]
    public IList<V1KubeVirtSpecConfigurationPermittedHostDevicesUsb>? Usb { get; set; }
}

/// <summary>CustomProfile allows to request arbitrary profile for virt-launcher</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationSeccompConfigurationVirtualMachineInstanceProfileCustomProfile
{
    /// <summary></summary>
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("runtimeDefaultProfile")]
    public bool? RuntimeDefaultProfile { get; set; }
}

/// <summary>VirtualMachineInstanceProfile defines what profile should be used with virt-launcher. Defaults to none</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationSeccompConfigurationVirtualMachineInstanceProfile
{
    /// <summary>CustomProfile allows to request arbitrary profile for virt-launcher</summary>
    [JsonPropertyName("customProfile")]
    public V1KubeVirtSpecConfigurationSeccompConfigurationVirtualMachineInstanceProfileCustomProfile? CustomProfile { get; set; }
}

/// <summary>SeccompConfiguration holds Seccomp configuration for Kubevirt components</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationSeccompConfiguration
{
    /// <summary>VirtualMachineInstanceProfile defines what profile should be used with virt-launcher. Defaults to none</summary>
    [JsonPropertyName("virtualMachineInstanceProfile")]
    public V1KubeVirtSpecConfigurationSeccompConfigurationVirtualMachineInstanceProfile? VirtualMachineInstanceProfile { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationSmbios
{
    /// <summary></summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary></summary>
    [JsonPropertyName("manufacturer")]
    public string? Manufacturer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>ResourceClaim references one entry in PodSpec.ResourceClaims.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationSupportContainerResourcesResourcesClaims
{
    /// <summary>Name must match the name of one entry in pod.spec.resourceClaims of the Pod where this field is used. It makes that resource available inside a container.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ResourceRequirements describes the compute resource requirements.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationSupportContainerResourcesResources
{
    /// <summary>Claims lists the names of resources, defined in spec.resourceClaims, that are used by this container.   This is an alpha field and requires enabling the DynamicResourceAllocation feature gate.   This field is immutable. It can only be set for containers.</summary>
    [JsonPropertyName("claims")]
    public IList<V1KubeVirtSpecConfigurationSupportContainerResourcesResourcesClaims>? Claims { get; set; }

    /// <summary>Limits describes the maximum amount of compute resources allowed. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, IntstrIntOrString>? Limits { get; set; }

    /// <summary>Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. Requests cannot exceed Limits. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/</summary>
    [JsonPropertyName("requests")]
    public IDictionary<string, IntstrIntOrString>? Requests { get; set; }
}

/// <summary>SupportContainerResources are used to specify the cpu/memory request and limits for the containers that support various features of Virtual Machines. These containers are usually idle and don't require a lot of memory or cpu.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationSupportContainerResources
{
    /// <summary>ResourceRequirements describes the compute resource requirements.</summary>
    [JsonPropertyName("resources")]
    public V1KubeVirtSpecConfigurationSupportContainerResourcesResources Resources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>MinTLSVersion is a way to specify the minimum protocol version that is acceptable for TLS connections. Protocol versions are based on the following most common TLS configurations:     https://ssl-config.mozilla.org/   Note that SSLv3.0 is not a supported protocol version due to well known vulnerabilities such as POODLE: https://en.wikipedia.org/wiki/POODLE</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1KubeVirtSpecConfigurationTlsConfigurationMinTLSVersionEnum
{
    [EnumMember(Value = "VersionTLS10"), JsonStringEnumMemberName("VersionTLS10")]
    /// <summary>VersionTLS10</summary>
    VersionTLS10,
    [EnumMember(Value = "VersionTLS11"), JsonStringEnumMemberName("VersionTLS11")]
    /// <summary>VersionTLS11</summary>
    VersionTLS11,
    [EnumMember(Value = "VersionTLS12"), JsonStringEnumMemberName("VersionTLS12")]
    /// <summary>VersionTLS12</summary>
    VersionTLS12,
    [EnumMember(Value = "VersionTLS13"), JsonStringEnumMemberName("VersionTLS13")]
    /// <summary>VersionTLS13</summary>
    VersionTLS13
}

/// <summary>TLSConfiguration holds TLS options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationTlsConfiguration
{
    /// <summary></summary>
    [JsonPropertyName("ciphers")]
    public IList<string>? Ciphers { get; set; }

    /// <summary>MinTLSVersion is a way to specify the minimum protocol version that is acceptable for TLS connections. Protocol versions are based on the following most common TLS configurations:     https://ssl-config.mozilla.org/   Note that SSLv3.0 is not a supported protocol version due to well known vulnerabilities such as POODLE: https://en.wikipedia.org/wiki/POODLE</summary>
    [JsonPropertyName("minTLSVersion")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1KubeVirtSpecConfigurationTlsConfigurationMinTLSVersionEnum>))]
    public V1KubeVirtSpecConfigurationTlsConfigurationMinTLSVersionEnum? MinTLSVersion { get; set; }
}

/// <summary>DisableFreePageReporting disable the free page reporting of memory balloon device https://libvirt.org/formatdomain.html#memory-balloon-device. This will have effect only if AutoattachMemBalloon is not false and the vmi is not requesting any high performance feature (dedicatedCPU/realtime/hugePages), in which free page reporting is always disabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationVirtualMachineOptionsDisableFreePageReporting
{
}

/// <summary>DisableSerialConsoleLog disables logging the auto-attached default serial console. If not set, serial console logs will be written to a file and then streamed from a container named 'guest-console-log'. The value can be individually overridden for each VM, not relevant if AutoattachSerialConsole is disabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationVirtualMachineOptionsDisableSerialConsoleLog
{
}

/// <summary>VirtualMachineOptions holds the cluster level information regarding the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationVirtualMachineOptions
{
    /// <summary>DisableFreePageReporting disable the free page reporting of memory balloon device https://libvirt.org/formatdomain.html#memory-balloon-device. This will have effect only if AutoattachMemBalloon is not false and the vmi is not requesting any high performance feature (dedicatedCPU/realtime/hugePages), in which free page reporting is always disabled.</summary>
    [JsonPropertyName("disableFreePageReporting")]
    public V1KubeVirtSpecConfigurationVirtualMachineOptionsDisableFreePageReporting? DisableFreePageReporting { get; set; }

    /// <summary>DisableSerialConsoleLog disables logging the auto-attached default serial console. If not set, serial console logs will be written to a file and then streamed from a container named 'guest-console-log'. The value can be individually overridden for each VM, not relevant if AutoattachSerialConsole is disabled.</summary>
    [JsonPropertyName("disableSerialConsoleLog")]
    public V1KubeVirtSpecConfigurationVirtualMachineOptionsDisableSerialConsoleLog? DisableSerialConsoleLog { get; set; }
}

/// <summary>VMRolloutStrategy defines how changes to a VM object propagate to its VMI</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1KubeVirtSpecConfigurationVmRolloutStrategyEnum
{
    [EnumMember(Value = "Stage"), JsonStringEnumMemberName("Stage")]
    /// <summary>Stage</summary>
    Stage,
    [EnumMember(Value = "LiveUpdate"), JsonStringEnumMemberName("LiveUpdate")]
    /// <summary>LiveUpdate</summary>
    LiveUpdate
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationWebhookConfigurationRestClientRateLimiterTokenBucketRateLimiter
{
    /// <summary>Maximum burst for throttle. If it's zero, the component default will be used</summary>
    [JsonPropertyName("burst")]
    public int Burst { get; set; }

    /// <summary>QPS indicates the maximum QPS to the apiserver from this client. If it's zero, the component default will be used</summary>
    [JsonPropertyName("qps")]
    public double Qps { get; set; }
}

/// <summary>RateLimiter allows selecting and configuring different rate limiters for the k8s client.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationWebhookConfigurationRestClientRateLimiter
{
    /// <summary></summary>
    [JsonPropertyName("tokenBucketRateLimiter")]
    public V1KubeVirtSpecConfigurationWebhookConfigurationRestClientRateLimiterTokenBucketRateLimiter? TokenBucketRateLimiter { get; set; }
}

/// <summary>RestClient can be used to tune certain aspects of the k8s client in use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationWebhookConfigurationRestClient
{
    /// <summary>RateLimiter allows selecting and configuring different rate limiters for the k8s client.</summary>
    [JsonPropertyName("rateLimiter")]
    public V1KubeVirtSpecConfigurationWebhookConfigurationRestClientRateLimiter? RateLimiter { get; set; }
}

/// <summary>ReloadableComponentConfiguration holds all generic k8s configuration options which can be reloaded by components without requiring a restart.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfigurationWebhookConfiguration
{
    /// <summary>RestClient can be used to tune certain aspects of the k8s client in use.</summary>
    [JsonPropertyName("restClient")]
    public V1KubeVirtSpecConfigurationWebhookConfigurationRestClient? RestClient { get; set; }
}

/// <summary>holds kubevirt configurations. same as the virt-configMap</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecConfiguration
{
    /// <summary>AdditionalGuestMemoryOverheadRatio can be used to increase the virtualization infrastructure overhead. This is useful, since the calculation of this overhead is not accurate and cannot be entirely known in advance. The ratio that is being set determines by which factor to increase the overhead calculated by Kubevirt. A higher ratio means that the VMs would be less compromised by node pressures, but would mean that fewer VMs could be scheduled to a node. If not set, the default is 1.</summary>
    [JsonPropertyName("additionalGuestMemoryOverheadRatio")]
    public string? AdditionalGuestMemoryOverheadRatio { get; set; }

    /// <summary>ReloadableComponentConfiguration holds all generic k8s configuration options which can be reloaded by components without requiring a restart.</summary>
    [JsonPropertyName("apiConfiguration")]
    public V1KubeVirtSpecConfigurationApiConfiguration? ApiConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("architectureConfiguration")]
    public V1KubeVirtSpecConfigurationArchitectureConfiguration? ArchitectureConfiguration { get; set; }

    /// <summary>When set, AutoCPULimitNamespaceLabelSelector will set a CPU limit on virt-launcher for VMIs running inside namespaces that match the label selector. The CPU limit will equal the number of requested vCPUs. This setting does not apply to VMIs with dedicated CPUs.</summary>
    [JsonPropertyName("autoCPULimitNamespaceLabelSelector")]
    public V1KubeVirtSpecConfigurationAutoCPULimitNamespaceLabelSelector? AutoCPULimitNamespaceLabelSelector { get; set; }

    /// <summary>ReloadableComponentConfiguration holds all generic k8s configuration options which can be reloaded by components without requiring a restart.</summary>
    [JsonPropertyName("controllerConfiguration")]
    public V1KubeVirtSpecConfigurationControllerConfiguration? ControllerConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cpuModel")]
    public string? CpuModel { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cpuRequest")]
    public IntstrIntOrString? CpuRequest { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultRuntimeClass")]
    public string? DefaultRuntimeClass { get; set; }

    /// <summary>DeveloperConfiguration holds developer options</summary>
    [JsonPropertyName("developerConfiguration")]
    public V1KubeVirtSpecConfigurationDeveloperConfiguration? DeveloperConfiguration { get; set; }

    /// <summary>Deprecated. Use architectureConfiguration instead.</summary>
    [JsonPropertyName("emulatedMachines")]
    public IList<string>? EmulatedMachines { get; set; }

    /// <summary>EvictionStrategy defines at the cluster level if the VirtualMachineInstance should be migrated instead of shut-off in case of a node drain. If the VirtualMachineInstance specific field is set it overrides the cluster level one.</summary>
    [JsonPropertyName("evictionStrategy")]
    public string? EvictionStrategy { get; set; }

    /// <summary>ReloadableComponentConfiguration holds all generic k8s configuration options which can be reloaded by components without requiring a restart.</summary>
    [JsonPropertyName("handlerConfiguration")]
    public V1KubeVirtSpecConfigurationHandlerConfiguration? HandlerConfiguration { get; set; }

    /// <summary>PullPolicy describes a policy for if/when to pull a container image</summary>
    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    /// <summary>KSMConfiguration holds the information regarding the enabling the KSM in the nodes (if available).</summary>
    [JsonPropertyName("ksmConfiguration")]
    public V1KubeVirtSpecConfigurationKsmConfiguration? KsmConfiguration { get; set; }

    /// <summary>LiveUpdateConfiguration holds defaults for live update features</summary>
    [JsonPropertyName("liveUpdateConfiguration")]
    public V1KubeVirtSpecConfigurationLiveUpdateConfiguration? LiveUpdateConfiguration { get; set; }

    /// <summary>Deprecated. Use architectureConfiguration instead.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>MediatedDevicesConfiguration holds information about MDEV types to be defined, if available</summary>
    [JsonPropertyName("mediatedDevicesConfiguration")]
    public V1KubeVirtSpecConfigurationMediatedDevicesConfiguration? MediatedDevicesConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("memBalloonStatsPeriod")]
    public int? MemBalloonStatsPeriod { get; set; }

    /// <summary>MigrationConfiguration holds migration options. Can be overridden for specific groups of VMs though migration policies. Visit https://kubevirt.io/user-guide/operations/migration_policies/ for more information.</summary>
    [JsonPropertyName("migrations")]
    public V1KubeVirtSpecConfigurationMigrations? Migrations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minCPUModel")]
    public string? MinCPUModel { get; set; }

    /// <summary>NetworkConfiguration holds network options</summary>
    [JsonPropertyName("network")]
    public V1KubeVirtSpecConfigurationNetwork? Network { get; set; }

    /// <summary></summary>
    [JsonPropertyName("obsoleteCPUModels")]
    public IDictionary<string, bool>? ObsoleteCPUModels { get; set; }

    /// <summary>Deprecated. Use architectureConfiguration instead.</summary>
    [JsonPropertyName("ovmfPath")]
    public string? OvmfPath { get; set; }

    /// <summary>PermittedHostDevices holds information about devices allowed for passthrough</summary>
    [JsonPropertyName("permittedHostDevices")]
    public V1KubeVirtSpecConfigurationPermittedHostDevices? PermittedHostDevices { get; set; }

    /// <summary>SeccompConfiguration holds Seccomp configuration for Kubevirt components</summary>
    [JsonPropertyName("seccompConfiguration")]
    public V1KubeVirtSpecConfigurationSeccompConfiguration? SeccompConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selinuxLauncherType")]
    public string? SelinuxLauncherType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("smbios")]
    public V1KubeVirtSpecConfigurationSmbios? Smbios { get; set; }

    /// <summary>SupportContainerResources specifies the resource requirements for various types of supporting containers such as container disks/virtiofs/sidecars and hotplug attachment pods. If omitted a sensible default will be supplied.</summary>
    [JsonPropertyName("supportContainerResources")]
    public IList<V1KubeVirtSpecConfigurationSupportContainerResources>? SupportContainerResources { get; set; }

    /// <summary>deprecated</summary>
    [JsonPropertyName("supportedGuestAgentVersions")]
    public IList<string>? SupportedGuestAgentVersions { get; set; }

    /// <summary>TLSConfiguration holds TLS options</summary>
    [JsonPropertyName("tlsConfiguration")]
    public V1KubeVirtSpecConfigurationTlsConfiguration? TlsConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("virtualMachineInstancesPerNode")]
    public int? VirtualMachineInstancesPerNode { get; set; }

    /// <summary>VirtualMachineOptions holds the cluster level information regarding the virtual machine.</summary>
    [JsonPropertyName("virtualMachineOptions")]
    public V1KubeVirtSpecConfigurationVirtualMachineOptions? VirtualMachineOptions { get; set; }

    /// <summary>VMRolloutStrategy defines how changes to a VM object propagate to its VMI</summary>
    [JsonPropertyName("vmRolloutStrategy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1KubeVirtSpecConfigurationVmRolloutStrategyEnum>))]
    public V1KubeVirtSpecConfigurationVmRolloutStrategyEnum? VmRolloutStrategy { get; set; }

    /// <summary>VMStateStorageClass is the name of the storage class to use for the PVCs created to preserve VM state, like TPM. The storage class must support RWX in filesystem mode.</summary>
    [JsonPropertyName("vmStateStorageClass")]
    public string? VmStateStorageClass { get; set; }

    /// <summary>ReloadableComponentConfiguration holds all generic k8s configuration options which can be reloaded by components without requiring a restart.</summary>
    [JsonPropertyName("webhookConfiguration")]
    public V1KubeVirtSpecConfigurationWebhookConfiguration? WebhookConfiguration { get; set; }
}

/// <summary>Configure the value used for deployment and daemonset resources</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecCustomizeComponentsFlags
{
    /// <summary></summary>
    [JsonPropertyName("api")]
    public IDictionary<string, string>? Api { get; set; }

    /// <summary></summary>
    [JsonPropertyName("controller")]
    public IDictionary<string, string>? Controller { get; set; }

    /// <summary></summary>
    [JsonPropertyName("handler")]
    public IDictionary<string, string>? Handler { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecCustomizeComponentsPatches
{
    /// <summary></summary>
    [JsonPropertyName("patch")]
    public string Patch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceName")]
    public string ResourceName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceType")]
    public string ResourceType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecCustomizeComponents
{
    /// <summary>Configure the value used for deployment and daemonset resources</summary>
    [JsonPropertyName("flags")]
    public V1KubeVirtSpecCustomizeComponentsFlags? Flags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patches")]
    public IList<V1KubeVirtSpecCustomizeComponentsPatches>? Patches { get; set; }
}

/// <summary>LocalObjectReference contains enough information to let you locate the referenced object inside the same namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecImagePullSecrets
{
    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A node selector term, associated with the corresponding weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    /// <summary>A list of node selector requirements by node's labels.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1KubeVirtSpecInfraNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>A list of node selector requirements by node's fields.</summary>
    [JsonPropertyName("matchFields")]
    public IList<V1KubeVirtSpecInfraNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

/// <summary>An empty preferred scheduling term matches all objects with implicit weight 0 (i.e. it's a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>A node selector term, associated with the corresponding weight.</summary>
    [JsonPropertyName("preference")]
    public V1KubeVirtSpecInfraNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference Preference { get; set; }

    /// <summary>Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.</summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary>A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A null or empty node selector term matches no objects. The requirements of them are ANDed. The TopologySelectorTerm type implements a subset of the NodeSelectorTerm.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    /// <summary>A list of node selector requirements by node's labels.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1KubeVirtSpecInfraNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>A list of node selector requirements by node's fields.</summary>
    [JsonPropertyName("matchFields")]
    public IList<V1KubeVirtSpecInfraNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
}

/// <summary>If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to an update), the system may or may not try to eventually evict the pod from its node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A list of node selector terms. The terms are ORed.</summary>
    [JsonPropertyName("nodeSelectorTerms")]
    public IList<V1KubeVirtSpecInfraNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms> NodeSelectorTerms { get; set; }
}

/// <summary>Describes node affinity scheduling rules for the pod.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityNodeAffinity
{
    /// <summary>The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node matches the corresponding matchExpressions; the node(s) with the highest sum are the most preferred.</summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KubeVirtSpecInfraNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to an update), the system may or may not try to eventually evict the pod from its node.</summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1KubeVirtSpecInfraNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1KubeVirtSpecInfraNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1KubeVirtSpecInfraNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
    [JsonPropertyName("labelSelector")]
    public V1KubeVirtSpecInfraNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    /// <summary>MatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key in (value)' to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both matchLabelKeys and labelSelector. Also, matchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>MismatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key notin (value)' to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both mismatchLabelKeys and labelSelector. Also, mismatchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1KubeVirtSpecInfraNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>namespaces specifies a static list of namespace names that the term applies to. The term is applied to the union of the namespaces listed in this field and the ones selected by namespaceSelector. null or empty namespaces list and null namespaceSelector means "this pod's namespace".</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.</summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary>The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
    [JsonPropertyName("podAffinityTerm")]
    public V1KubeVirtSpecInfraNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary>weight associated with matching the corresponding podAffinityTerm, in the range 1-100.</summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1KubeVirtSpecInfraNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1KubeVirtSpecInfraNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Defines a set of pods (namely those matching the labelSelector relative to the given namespace(s)) that this pod should be co-located (affinity) or not co-located (anti-affinity) with, where co-located is defined as running on a node whose value of the label with key &lt;topologyKey&gt; matches that of any node on which a pod of the set of pods is running</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
    [JsonPropertyName("labelSelector")]
    public V1KubeVirtSpecInfraNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    /// <summary>MatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key in (value)' to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both matchLabelKeys and labelSelector. Also, matchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>MismatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key notin (value)' to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both mismatchLabelKeys and labelSelector. Also, mismatchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1KubeVirtSpecInfraNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>namespaces specifies a static list of namespace names that the term applies to. The term is applied to the union of the namespaces listed in this field and the ones selected by namespaceSelector. null or empty namespaces list and null namespaceSelector means "this pod's namespace".</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.</summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary>Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityPodAffinity
{
    /// <summary>The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node has pods which matches the corresponding podAffinityTerm; the node(s) with the highest sum are the most preferred.</summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KubeVirtSpecInfraNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system may or may not try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied.</summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KubeVirtSpecInfraNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
    [JsonPropertyName("labelSelector")]
    public V1KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    /// <summary>MatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key in (value)' to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both matchLabelKeys and labelSelector. Also, matchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>MismatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key notin (value)' to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both mismatchLabelKeys and labelSelector. Also, mismatchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>namespaces specifies a static list of namespace names that the term applies to. The term is applied to the union of the namespaces listed in this field and the ones selected by namespaceSelector. null or empty namespaces list and null namespaceSelector means "this pod's namespace".</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.</summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary>The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
    [JsonPropertyName("podAffinityTerm")]
    public V1KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary>weight associated with matching the corresponding podAffinityTerm, in the range 1-100.</summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Defines a set of pods (namely those matching the labelSelector relative to the given namespace(s)) that this pod should be co-located (affinity) or not co-located (anti-affinity) with, where co-located is defined as running on a node whose value of the label with key &lt;topologyKey&gt; matches that of any node on which a pod of the set of pods is running</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
    [JsonPropertyName("labelSelector")]
    public V1KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    /// <summary>MatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key in (value)' to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both matchLabelKeys and labelSelector. Also, matchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>MismatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key notin (value)' to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both mismatchLabelKeys and labelSelector. Also, mismatchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>namespaces specifies a static list of namespace names that the term applies to. The term is applied to the union of the namespaces listed in this field and the ones selected by namespaceSelector. null or empty namespaces list and null namespaceSelector means "this pod's namespace".</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.</summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary>Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinity
{
    /// <summary>The scheduler will prefer to schedule pods to nodes that satisfy the anti-affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling anti-affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node has pods which matches the corresponding podAffinityTerm; the node(s) with the highest sum are the most preferred.</summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>If the anti-affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the anti-affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system may or may not try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied.</summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>affinity enables pod affinity/anti-affinity placement expanding the types of constraints that can be expressed with nodeSelector. affinity is going to be applied to the relevant kind of pods in parallel with nodeSelector See https://kubernetes.io/docs/concepts/scheduling-eviction/assign-pod-node/#affinity-and-anti-affinity</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementAffinity
{
    /// <summary>Describes node affinity scheduling rules for the pod.</summary>
    [JsonPropertyName("nodeAffinity")]
    public V1KubeVirtSpecInfraNodePlacementAffinityNodeAffinity? NodeAffinity { get; set; }

    /// <summary>Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).</summary>
    [JsonPropertyName("podAffinity")]
    public V1KubeVirtSpecInfraNodePlacementAffinityPodAffinity? PodAffinity { get; set; }

    /// <summary>Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).</summary>
    [JsonPropertyName("podAntiAffinity")]
    public V1KubeVirtSpecInfraNodePlacementAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

/// <summary>The pod this Toleration is attached to tolerates any taint that matches the triple &lt;key,value,effect&gt; using the matching operator &lt;operator&gt;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacementTolerations
{
    /// <summary>Effect indicates the taint effect to match. Empty means match all taint effects. When specified, allowed values are NoSchedule, PreferNoSchedule and NoExecute.</summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>Key is the taint key that the toleration applies to. Empty means match all taint keys. If the key is empty, operator must be Exists; this combination means to match all values and all keys.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Operator represents a key's relationship to the value. Valid operators are Exists and Equal. Defaults to Equal. Exists is equivalent to wildcard for value, so that a pod can tolerate all taints of a particular category.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>TolerationSeconds represents the period of time the toleration (which must be of effect NoExecute, otherwise this field is ignored) tolerates the taint. By default, it is not set, which means tolerate the taint forever (do not evict). Zero and negative values will be treated as 0 (evict immediately) by the system.</summary>
    [JsonPropertyName("tolerationSeconds")]
    public long? TolerationSeconds { get; set; }

    /// <summary>Value is the taint value the toleration matches to. If the operator is Exists, the value should be empty, otherwise just a regular string.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>nodePlacement describes scheduling configuration for specific KubeVirt components</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfraNodePlacement
{
    /// <summary>affinity enables pod affinity/anti-affinity placement expanding the types of constraints that can be expressed with nodeSelector. affinity is going to be applied to the relevant kind of pods in parallel with nodeSelector See https://kubernetes.io/docs/concepts/scheduling-eviction/assign-pod-node/#affinity-and-anti-affinity</summary>
    [JsonPropertyName("affinity")]
    public V1KubeVirtSpecInfraNodePlacementAffinity? Affinity { get; set; }

    /// <summary>nodeSelector is the node selector applied to the relevant kind of pods It specifies a map of key-value pairs: for the pod to be eligible to run on a node, the node must have each of the indicated key-value pairs as labels (it can have additional labels as well). See https://kubernetes.io/docs/concepts/configuration/assign-pod-node/#nodeselector</summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary>tolerations is a list of tolerations applied to the relevant kind of pods See https://kubernetes.io/docs/concepts/configuration/taint-and-toleration/ for more info. These are additional tolerations other than default ones.</summary>
    [JsonPropertyName("tolerations")]
    public IList<V1KubeVirtSpecInfraNodePlacementTolerations>? Tolerations { get; set; }
}

/// <summary>selectors and tolerations that should apply to KubeVirt infrastructure components</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecInfra
{
    /// <summary>nodePlacement describes scheduling configuration for specific KubeVirt components</summary>
    [JsonPropertyName("nodePlacement")]
    public V1KubeVirtSpecInfraNodePlacement? NodePlacement { get; set; }

    /// <summary>replicas indicates how many replicas should be created for each KubeVirt infrastructure component (like virt-api or virt-controller). Defaults to 2. WARNING: this is an advanced feature that prevents auto-scaling for core kubevirt components. Please use with caution!</summary>
    [JsonPropertyName("replicas")]
    public int? Replicas { get; set; }
}

/// <summary>WorkloadUpdateStrategy defines at the cluster level how to handle automated workload updates</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadUpdateStrategy
{
    /// <summary>BatchEvictionInterval Represents the interval to wait before issuing the next batch of shutdowns   Defaults to 1 minute</summary>
    [JsonPropertyName("batchEvictionInterval")]
    public string? BatchEvictionInterval { get; set; }

    /// <summary>BatchEvictionSize Represents the number of VMIs that can be forced updated per the BatchShutdownInteral interval   Defaults to 10</summary>
    [JsonPropertyName("batchEvictionSize")]
    public int? BatchEvictionSize { get; set; }

    /// <summary>WorkloadUpdateMethods defines the methods that can be used to disrupt workloads during automated workload updates. When multiple methods are present, the least disruptive method takes precedence over more disruptive methods. For example if both LiveMigrate and Shutdown methods are listed, only VMs which are not live migratable will be restarted/shutdown   An empty list defaults to no automated workload updating</summary>
    [JsonPropertyName("workloadUpdateMethods")]
    public IList<string>? WorkloadUpdateMethods { get; set; }
}

/// <summary>A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A node selector term, associated with the corresponding weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    /// <summary>A list of node selector requirements by node's labels.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>A list of node selector requirements by node's fields.</summary>
    [JsonPropertyName("matchFields")]
    public IList<V1KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

/// <summary>An empty preferred scheduling term matches all objects with implicit weight 0 (i.e. it's a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>A node selector term, associated with the corresponding weight.</summary>
    [JsonPropertyName("preference")]
    public V1KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference Preference { get; set; }

    /// <summary>Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.</summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary>A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A null or empty node selector term matches no objects. The requirements of them are ANDed. The TopologySelectorTerm type implements a subset of the NodeSelectorTerm.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    /// <summary>A list of node selector requirements by node's labels.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>A list of node selector requirements by node's fields.</summary>
    [JsonPropertyName("matchFields")]
    public IList<V1KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
}

/// <summary>If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to an update), the system may or may not try to eventually evict the pod from its node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A list of node selector terms. The terms are ORed.</summary>
    [JsonPropertyName("nodeSelectorTerms")]
    public IList<V1KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms> NodeSelectorTerms { get; set; }
}

/// <summary>Describes node affinity scheduling rules for the pod.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinity
{
    /// <summary>The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node matches the corresponding matchExpressions; the node(s) with the highest sum are the most preferred.</summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to an update), the system may or may not try to eventually evict the pod from its node.</summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
    [JsonPropertyName("labelSelector")]
    public V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    /// <summary>MatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key in (value)' to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both matchLabelKeys and labelSelector. Also, matchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>MismatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key notin (value)' to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both mismatchLabelKeys and labelSelector. Also, mismatchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>namespaces specifies a static list of namespace names that the term applies to. The term is applied to the union of the namespaces listed in this field and the ones selected by namespaceSelector. null or empty namespaces list and null namespaceSelector means "this pod's namespace".</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.</summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary>The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
    [JsonPropertyName("podAffinityTerm")]
    public V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary>weight associated with matching the corresponding podAffinityTerm, in the range 1-100.</summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Defines a set of pods (namely those matching the labelSelector relative to the given namespace(s)) that this pod should be co-located (affinity) or not co-located (anti-affinity) with, where co-located is defined as running on a node whose value of the label with key &lt;topologyKey&gt; matches that of any node on which a pod of the set of pods is running</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
    [JsonPropertyName("labelSelector")]
    public V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    /// <summary>MatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key in (value)' to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both matchLabelKeys and labelSelector. Also, matchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>MismatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key notin (value)' to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both mismatchLabelKeys and labelSelector. Also, mismatchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>namespaces specifies a static list of namespace names that the term applies to. The term is applied to the union of the namespaces listed in this field and the ones selected by namespaceSelector. null or empty namespaces list and null namespaceSelector means "this pod's namespace".</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.</summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary>Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinity
{
    /// <summary>The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node has pods which matches the corresponding podAffinityTerm; the node(s) with the highest sum are the most preferred.</summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system may or may not try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied.</summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    /// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
    [JsonPropertyName("labelSelector")]
    public V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    /// <summary>MatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key in (value)' to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both matchLabelKeys and labelSelector. Also, matchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>MismatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key notin (value)' to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both mismatchLabelKeys and labelSelector. Also, mismatchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>namespaces specifies a static list of namespace names that the term applies to. The term is applied to the union of the namespaces listed in this field and the ones selected by namespaceSelector. null or empty namespaces list and null namespaceSelector means "this pod's namespace".</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.</summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary>The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>Required. A pod affinity term, associated with the corresponding weight.</summary>
    [JsonPropertyName("podAffinityTerm")]
    public V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm PodAffinityTerm { get; set; }

    /// <summary>weight associated with matching the corresponding podAffinityTerm, in the range 1-100.</summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.</summary>
    [JsonPropertyName("operator")]
    public string Operator { get; set; }

    /// <summary>values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>Defines a set of pods (namely those matching the labelSelector relative to the given namespace(s)) that this pod should be co-located (affinity) or not co-located (anti-affinity) with, where co-located is defined as running on a node whose value of the label with key &lt;topologyKey&gt; matches that of any node on which a pod of the set of pods is running</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    /// <summary>A label query over a set of resources, in this case pods. If it's null, this PodAffinityTerm matches with no Pods.</summary>
    [JsonPropertyName("labelSelector")]
    public V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    /// <summary>MatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key in (value)' to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both matchLabelKeys and labelSelector. Also, matchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    /// <summary>MismatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration. The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with 'labelSelector' as 'key notin (value)' to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both mismatchLabelKeys and labelSelector. Also, mismatchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.</summary>
    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    /// <summary>A label query over the set of namespaces that the term applies to. The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.</summary>
    [JsonPropertyName("namespaceSelector")]
    public V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>namespaces specifies a static list of namespace names that the term applies to. The term is applied to the union of the namespaces listed in this field and the ones selected by namespaceSelector. null or empty namespaces list and null namespaceSelector means "this pod's namespace".</summary>
    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    /// <summary>This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.</summary>
    [JsonPropertyName("topologyKey")]
    public string TopologyKey { get; set; }
}

/// <summary>Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinity
{
    /// <summary>The scheduler will prefer to schedule pods to nodes that satisfy the anti-affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling anti-affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node has pods which matches the corresponding podAffinityTerm; the node(s) with the highest sum are the most preferred.</summary>
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    /// <summary>If the anti-affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the anti-affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system may or may not try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied.</summary>
    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>affinity enables pod affinity/anti-affinity placement expanding the types of constraints that can be expressed with nodeSelector. affinity is going to be applied to the relevant kind of pods in parallel with nodeSelector See https://kubernetes.io/docs/concepts/scheduling-eviction/assign-pod-node/#affinity-and-anti-affinity</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementAffinity
{
    /// <summary>Describes node affinity scheduling rules for the pod.</summary>
    [JsonPropertyName("nodeAffinity")]
    public V1KubeVirtSpecWorkloadsNodePlacementAffinityNodeAffinity? NodeAffinity { get; set; }

    /// <summary>Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).</summary>
    [JsonPropertyName("podAffinity")]
    public V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAffinity? PodAffinity { get; set; }

    /// <summary>Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).</summary>
    [JsonPropertyName("podAntiAffinity")]
    public V1KubeVirtSpecWorkloadsNodePlacementAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

/// <summary>The pod this Toleration is attached to tolerates any taint that matches the triple &lt;key,value,effect&gt; using the matching operator &lt;operator&gt;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacementTolerations
{
    /// <summary>Effect indicates the taint effect to match. Empty means match all taint effects. When specified, allowed values are NoSchedule, PreferNoSchedule and NoExecute.</summary>
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    /// <summary>Key is the taint key that the toleration applies to. Empty means match all taint keys. If the key is empty, operator must be Exists; this combination means to match all values and all keys.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Operator represents a key's relationship to the value. Valid operators are Exists and Equal. Defaults to Equal. Exists is equivalent to wildcard for value, so that a pod can tolerate all taints of a particular category.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>TolerationSeconds represents the period of time the toleration (which must be of effect NoExecute, otherwise this field is ignored) tolerates the taint. By default, it is not set, which means tolerate the taint forever (do not evict). Zero and negative values will be treated as 0 (evict immediately) by the system.</summary>
    [JsonPropertyName("tolerationSeconds")]
    public long? TolerationSeconds { get; set; }

    /// <summary>Value is the taint value the toleration matches to. If the operator is Exists, the value should be empty, otherwise just a regular string.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>nodePlacement describes scheduling configuration for specific KubeVirt components</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloadsNodePlacement
{
    /// <summary>affinity enables pod affinity/anti-affinity placement expanding the types of constraints that can be expressed with nodeSelector. affinity is going to be applied to the relevant kind of pods in parallel with nodeSelector See https://kubernetes.io/docs/concepts/scheduling-eviction/assign-pod-node/#affinity-and-anti-affinity</summary>
    [JsonPropertyName("affinity")]
    public V1KubeVirtSpecWorkloadsNodePlacementAffinity? Affinity { get; set; }

    /// <summary>nodeSelector is the node selector applied to the relevant kind of pods It specifies a map of key-value pairs: for the pod to be eligible to run on a node, the node must have each of the indicated key-value pairs as labels (it can have additional labels as well). See https://kubernetes.io/docs/concepts/configuration/assign-pod-node/#nodeselector</summary>
    [JsonPropertyName("nodeSelector")]
    public IDictionary<string, string>? NodeSelector { get; set; }

    /// <summary>tolerations is a list of tolerations applied to the relevant kind of pods See https://kubernetes.io/docs/concepts/configuration/taint-and-toleration/ for more info. These are additional tolerations other than default ones.</summary>
    [JsonPropertyName("tolerations")]
    public IList<V1KubeVirtSpecWorkloadsNodePlacementTolerations>? Tolerations { get; set; }
}

/// <summary>selectors and tolerations that should apply to KubeVirt workloads</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpecWorkloads
{
    /// <summary>nodePlacement describes scheduling configuration for specific KubeVirt components</summary>
    [JsonPropertyName("nodePlacement")]
    public V1KubeVirtSpecWorkloadsNodePlacement? NodePlacement { get; set; }

    /// <summary>replicas indicates how many replicas should be created for each KubeVirt infrastructure component (like virt-api or virt-controller). Defaults to 2. WARNING: this is an advanced feature that prevents auto-scaling for core kubevirt components. Please use with caution!</summary>
    [JsonPropertyName("replicas")]
    public int? Replicas { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtSpec
{
    /// <summary></summary>
    [JsonPropertyName("certificateRotateStrategy")]
    public V1KubeVirtSpecCertificateRotateStrategy? CertificateRotateStrategy { get; set; }

    /// <summary>holds kubevirt configurations. same as the virt-configMap</summary>
    [JsonPropertyName("configuration")]
    public V1KubeVirtSpecConfiguration? Configuration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customizeComponents")]
    public V1KubeVirtSpecCustomizeComponents? CustomizeComponents { get; set; }

    /// <summary>The ImagePullPolicy to use.</summary>
    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    /// <summary>The imagePullSecrets to pull the container images from Defaults to none</summary>
    [JsonPropertyName("imagePullSecrets")]
    public IList<V1KubeVirtSpecImagePullSecrets>? ImagePullSecrets { get; set; }

    /// <summary>The image registry to pull the container images from Defaults to the same registry the operator's container image is pulled from.</summary>
    [JsonPropertyName("imageRegistry")]
    public string? ImageRegistry { get; set; }

    /// <summary>The image tag to use for the continer images installed. Defaults to the same tag as the operator's container image.</summary>
    [JsonPropertyName("imageTag")]
    public string? ImageTag { get; set; }

    /// <summary>selectors and tolerations that should apply to KubeVirt infrastructure components</summary>
    [JsonPropertyName("infra")]
    public V1KubeVirtSpecInfra? Infra { get; set; }

    /// <summary>The name of the Prometheus service account that needs read-access to KubeVirt endpoints Defaults to prometheus-k8s</summary>
    [JsonPropertyName("monitorAccount")]
    public string? MonitorAccount { get; set; }

    /// <summary>The namespace Prometheus is deployed in Defaults to openshift-monitor</summary>
    [JsonPropertyName("monitorNamespace")]
    public string? MonitorNamespace { get; set; }

    /// <summary>Designate the apps.kubevirt.io/component label for KubeVirt components. Useful if KubeVirt is included as part of a product. If ProductComponent is not specified, the component label default value is kubevirt.</summary>
    [JsonPropertyName("productComponent")]
    public string? ProductComponent { get; set; }

    /// <summary>Designate the apps.kubevirt.io/part-of label for KubeVirt components. Useful if KubeVirt is included as part of a product. If ProductName is not specified, the part-of label will be omitted.</summary>
    [JsonPropertyName("productName")]
    public string? ProductName { get; set; }

    /// <summary>Designate the apps.kubevirt.io/version label for KubeVirt components. Useful if KubeVirt is included as part of a product. If ProductVersion is not specified, KubeVirt's version will be used.</summary>
    [JsonPropertyName("productVersion")]
    public string? ProductVersion { get; set; }

    /// <summary>The namespace the service monitor will be deployed  When ServiceMonitorNamespace is set, then we'll install the service monitor object in that namespace otherwise we will use the monitoring namespace.</summary>
    [JsonPropertyName("serviceMonitorNamespace")]
    public string? ServiceMonitorNamespace { get; set; }

    /// <summary>Specifies if kubevirt can be deleted if workloads are still present. This is mainly a precaution to avoid accidental data loss</summary>
    [JsonPropertyName("uninstallStrategy")]
    public string? UninstallStrategy { get; set; }

    /// <summary>WorkloadUpdateStrategy defines at the cluster level how to handle automated workload updates</summary>
    [JsonPropertyName("workloadUpdateStrategy")]
    public V1KubeVirtSpecWorkloadUpdateStrategy? WorkloadUpdateStrategy { get; set; }

    /// <summary>selectors and tolerations that should apply to KubeVirt workloads</summary>
    [JsonPropertyName("workloads")]
    public V1KubeVirtSpecWorkloads? Workloads { get; set; }
}

/// <summary>KubeVirtCondition represents a condition of a KubeVirt deployment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtStatusConditions
{
    /// <summary></summary>
    [JsonPropertyName("lastProbeTime")]
    public string? LastProbeTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>GenerationStatus keeps track of the generation for a given resource so that decisions about forced updates can be made.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtStatusGenerations
{
    /// <summary>group is the group of the thing you're tracking</summary>
    [JsonPropertyName("group")]
    public string Group { get; set; }

    /// <summary>hash is an optional field set for resources without generation that are content sensitive like secrets and configmaps</summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }

    /// <summary>lastGeneration is the last generation of the workload controller involved</summary>
    [JsonPropertyName("lastGeneration")]
    public long LastGeneration { get; set; }

    /// <summary>name is the name of the thing you're tracking</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>namespace is where the thing you're tracking is</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>resource is the resource type of the thing you're tracking</summary>
    [JsonPropertyName("resource")]
    public string Resource { get; set; }
}

/// <summary>KubeVirtStatus represents information pertaining to a KubeVirt deployment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeVirtStatus
{
    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1KubeVirtStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultArchitecture")]
    public string? DefaultArchitecture { get; set; }

    /// <summary></summary>
    [JsonPropertyName("generations")]
    public IList<V1KubeVirtStatusGenerations>? Generations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("observedDeploymentConfig")]
    public string? ObservedDeploymentConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("observedDeploymentID")]
    public string? ObservedDeploymentID { get; set; }

    /// <summary></summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("observedKubeVirtRegistry")]
    public string? ObservedKubeVirtRegistry { get; set; }

    /// <summary></summary>
    [JsonPropertyName("observedKubeVirtVersion")]
    public string? ObservedKubeVirtVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operatorVersion")]
    public string? OperatorVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("outdatedVirtualMachineInstanceWorkloads")]
    public int? OutdatedVirtualMachineInstanceWorkloads { get; set; }

    /// <summary>KubeVirtPhase is a label for the phase of a KubeVirt deployment at the current time.</summary>
    [JsonPropertyName("phase")]
    public string? Phase { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetDeploymentConfig")]
    public string? TargetDeploymentConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetDeploymentID")]
    public string? TargetDeploymentID { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetKubeVirtRegistry")]
    public string? TargetKubeVirtRegistry { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetKubeVirtVersion")]
    public string? TargetKubeVirtVersion { get; set; }
}

/// <summary>KubeVirt represents the object deploying all KubeVirt resources</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1KubeVirt : IKubernetesObject<V1ObjectMeta>, ISpec<V1KubeVirtSpec>, IStatus<V1KubeVirtStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "KubeVirt";
    public const string KubeGroup = "kubevirt.io";
    public const string KubePluralName = "kubevirts";
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
    public V1KubeVirtSpec Spec { get; set; }

    /// <summary>KubeVirtStatus represents information pertaining to a KubeVirt deployment.</summary>
    [JsonPropertyName("status")]
    public V1KubeVirtStatus? Status { get; set; }
}