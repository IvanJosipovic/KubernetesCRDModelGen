using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.synapse.azure.upbound.io;
#nullable enable
/// <summary>SparkPool is the Schema for the SparkPools API. Manages a Synapse Spark Pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SparkPoolList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SparkPool>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SparkPoolList";
    public const string KubeGroup = "synapse.azure.upbound.io";
    public const string KubePluralName = "sparkpools";
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
    public IList<V1beta1SparkPool> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SparkPoolSpecForProviderAutoPause
{
    /// <summary>Number of minutes of idle time before the Spark Pool is automatically paused. Must be between 5 and 10080.</summary>
    [JsonPropertyName("delayInMinutes")]
    public double? DelayInMinutes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SparkPoolSpecForProviderAutoScale
{
    /// <summary>The maximum number of nodes the Spark Pool can support. Must be between 3 and 200.</summary>
    [JsonPropertyName("maxNodeCount")]
    public double? MaxNodeCount { get; set; }

    /// <summary>The minimum number of nodes the Spark Pool can support. Must be between 3 and 200.</summary>
    [JsonPropertyName("minNodeCount")]
    public double? MinNodeCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SparkPoolSpecForProviderLibraryRequirement
{
    /// <summary>The content of library requirements.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The name of the library requirements file.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SparkPoolSpecForProviderSparkConfig
{
    /// <summary>The contents of a spark configuration.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The name of the file where the spark configuration content will be stored.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SparkPoolSpecForProviderSynapseWorkspaceIdRefPolicy
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
/// <summary>Reference to a Workspace in synapse to populate synapseWorkspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SparkPoolSpecForProviderSynapseWorkspaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SparkPoolSpecForProviderSynapseWorkspaceIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SparkPoolSpecForProviderSynapseWorkspaceIdSelectorPolicy
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
/// <summary>Selector for a Workspace in synapse to populate synapseWorkspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SparkPoolSpecForProviderSynapseWorkspaceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SparkPoolSpecForProviderSynapseWorkspaceIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SparkPoolSpecForProvider
{
    /// <summary>An auto_pause block as defined below.</summary>
    [JsonPropertyName("autoPause")]
    public IList<V1beta1SparkPoolSpecForProviderAutoPause>? AutoPause { get; set; }

    /// <summary>An auto_scale block as defined below. Exactly one of node_count or auto_scale must be specified.</summary>
    [JsonPropertyName("autoScale")]
    public IList<V1beta1SparkPoolSpecForProviderAutoScale>? AutoScale { get; set; }

    /// <summary>The cache size in the Spark Pool.</summary>
    [JsonPropertyName("cacheSize")]
    public double? CacheSize { get; set; }

    /// <summary>Indicates whether compute isolation is enabled or not. Defaults to false.</summary>
    [JsonPropertyName("computeIsolationEnabled")]
    public bool? ComputeIsolationEnabled { get; set; }

    /// <summary>Indicates whether Dynamic Executor Allocation is enabled or not. Defaults to false.</summary>
    [JsonPropertyName("dynamicExecutorAllocationEnabled")]
    public bool? DynamicExecutorAllocationEnabled { get; set; }

    /// <summary>A library_requirement block as defined below.</summary>
    [JsonPropertyName("libraryRequirement")]
    public IList<V1beta1SparkPoolSpecForProviderLibraryRequirement>? LibraryRequirement { get; set; }

    /// <summary>The maximum number of executors allocated only when dynamic_executor_allocation_enabled set to true.</summary>
    [JsonPropertyName("maxExecutors")]
    public double? MaxExecutors { get; set; }

    /// <summary>The minimum number of executors allocated only when dynamic_executor_allocation_enabled set to true.</summary>
    [JsonPropertyName("minExecutors")]
    public double? MinExecutors { get; set; }

    /// <summary>The number of nodes in the Spark Pool. Exactly one of node_count or auto_scale must be specified.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>The level of node in the Spark Pool. Possible values are Small, Medium, Large, None, XLarge, XXLarge and XXXLarge.</summary>
    [JsonPropertyName("nodeSize")]
    public string? NodeSize { get; set; }

    /// <summary>The kind of nodes that the Spark Pool provides. Possible values are HardwareAcceleratedFPGA, HardwareAcceleratedGPU, MemoryOptimized, and None.</summary>
    [JsonPropertyName("nodeSizeFamily")]
    public string? NodeSizeFamily { get; set; }

    /// <summary>Indicates whether session level packages are enabled or not. Defaults to false.</summary>
    [JsonPropertyName("sessionLevelPackagesEnabled")]
    public bool? SessionLevelPackagesEnabled { get; set; }

    /// <summary>A spark_config block as defined below.</summary>
    [JsonPropertyName("sparkConfig")]
    public IList<V1beta1SparkPoolSpecForProviderSparkConfig>? SparkConfig { get; set; }

    /// <summary>The Spark events folder. Defaults to /events.</summary>
    [JsonPropertyName("sparkEventsFolder")]
    public string? SparkEventsFolder { get; set; }

    /// <summary>The default folder where Spark logs will be written. Defaults to /logs.</summary>
    [JsonPropertyName("sparkLogFolder")]
    public string? SparkLogFolder { get; set; }

    /// <summary>The Apache Spark version. Possible values are 3.2, 3.3, and 3.4.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary>The ID of the Synapse Workspace where the Synapse Spark Pool should exist. Changing this forces a new Synapse Spark Pool to be created.</summary>
    [JsonPropertyName("synapseWorkspaceId")]
    public string? SynapseWorkspaceId { get; set; }

    /// <summary>Reference to a Workspace in synapse to populate synapseWorkspaceId.</summary>
    [JsonPropertyName("synapseWorkspaceIdRef")]
    public V1beta1SparkPoolSpecForProviderSynapseWorkspaceIdRef? SynapseWorkspaceIdRef { get; set; }

    /// <summary>Selector for a Workspace in synapse to populate synapseWorkspaceId.</summary>
    [JsonPropertyName("synapseWorkspaceIdSelector")]
    public V1beta1SparkPoolSpecForProviderSynapseWorkspaceIdSelector? SynapseWorkspaceIdSelector { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Synapse Spark Pool.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SparkPoolSpecInitProviderAutoPause
{
    /// <summary>Number of minutes of idle time before the Spark Pool is automatically paused. Must be between 5 and 10080.</summary>
    [JsonPropertyName("delayInMinutes")]
    public double? DelayInMinutes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SparkPoolSpecInitProviderAutoScale
{
    /// <summary>The maximum number of nodes the Spark Pool can support. Must be between 3 and 200.</summary>
    [JsonPropertyName("maxNodeCount")]
    public double? MaxNodeCount { get; set; }

    /// <summary>The minimum number of nodes the Spark Pool can support. Must be between 3 and 200.</summary>
    [JsonPropertyName("minNodeCount")]
    public double? MinNodeCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SparkPoolSpecInitProviderLibraryRequirement
{
    /// <summary>The content of library requirements.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The name of the library requirements file.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SparkPoolSpecInitProviderSparkConfig
{
    /// <summary>The contents of a spark configuration.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The name of the file where the spark configuration content will be stored.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SparkPoolSpecInitProvider
{
    /// <summary>An auto_pause block as defined below.</summary>
    [JsonPropertyName("autoPause")]
    public IList<V1beta1SparkPoolSpecInitProviderAutoPause>? AutoPause { get; set; }

    /// <summary>An auto_scale block as defined below. Exactly one of node_count or auto_scale must be specified.</summary>
    [JsonPropertyName("autoScale")]
    public IList<V1beta1SparkPoolSpecInitProviderAutoScale>? AutoScale { get; set; }

    /// <summary>The cache size in the Spark Pool.</summary>
    [JsonPropertyName("cacheSize")]
    public double? CacheSize { get; set; }

    /// <summary>Indicates whether compute isolation is enabled or not. Defaults to false.</summary>
    [JsonPropertyName("computeIsolationEnabled")]
    public bool? ComputeIsolationEnabled { get; set; }

    /// <summary>Indicates whether Dynamic Executor Allocation is enabled or not. Defaults to false.</summary>
    [JsonPropertyName("dynamicExecutorAllocationEnabled")]
    public bool? DynamicExecutorAllocationEnabled { get; set; }

    /// <summary>A library_requirement block as defined below.</summary>
    [JsonPropertyName("libraryRequirement")]
    public IList<V1beta1SparkPoolSpecInitProviderLibraryRequirement>? LibraryRequirement { get; set; }

    /// <summary>The maximum number of executors allocated only when dynamic_executor_allocation_enabled set to true.</summary>
    [JsonPropertyName("maxExecutors")]
    public double? MaxExecutors { get; set; }

    /// <summary>The minimum number of executors allocated only when dynamic_executor_allocation_enabled set to true.</summary>
    [JsonPropertyName("minExecutors")]
    public double? MinExecutors { get; set; }

    /// <summary>The number of nodes in the Spark Pool. Exactly one of node_count or auto_scale must be specified.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>The level of node in the Spark Pool. Possible values are Small, Medium, Large, None, XLarge, XXLarge and XXXLarge.</summary>
    [JsonPropertyName("nodeSize")]
    public string? NodeSize { get; set; }

    /// <summary>The kind of nodes that the Spark Pool provides. Possible values are HardwareAcceleratedFPGA, HardwareAcceleratedGPU, MemoryOptimized, and None.</summary>
    [JsonPropertyName("nodeSizeFamily")]
    public string? NodeSizeFamily { get; set; }

    /// <summary>Indicates whether session level packages are enabled or not. Defaults to false.</summary>
    [JsonPropertyName("sessionLevelPackagesEnabled")]
    public bool? SessionLevelPackagesEnabled { get; set; }

    /// <summary>A spark_config block as defined below.</summary>
    [JsonPropertyName("sparkConfig")]
    public IList<V1beta1SparkPoolSpecInitProviderSparkConfig>? SparkConfig { get; set; }

    /// <summary>The Spark events folder. Defaults to /events.</summary>
    [JsonPropertyName("sparkEventsFolder")]
    public string? SparkEventsFolder { get; set; }

    /// <summary>The default folder where Spark logs will be written. Defaults to /logs.</summary>
    [JsonPropertyName("sparkLogFolder")]
    public string? SparkLogFolder { get; set; }

    /// <summary>The Apache Spark version. Possible values are 3.2, 3.3, and 3.4.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Synapse Spark Pool.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SparkPoolSpecProviderConfigRefPolicy
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
public partial class V1beta1SparkPoolSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SparkPoolSpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SparkPoolSpecWriteConnectionSecretToRef
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
/// <summary>SparkPoolSpec defines the desired state of SparkPool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SparkPoolSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SparkPoolSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SparkPoolSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SparkPoolSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SparkPoolSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SparkPoolStatusAtProviderAutoPause
{
    /// <summary>Number of minutes of idle time before the Spark Pool is automatically paused. Must be between 5 and 10080.</summary>
    [JsonPropertyName("delayInMinutes")]
    public double? DelayInMinutes { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SparkPoolStatusAtProviderAutoScale
{
    /// <summary>The maximum number of nodes the Spark Pool can support. Must be between 3 and 200.</summary>
    [JsonPropertyName("maxNodeCount")]
    public double? MaxNodeCount { get; set; }

    /// <summary>The minimum number of nodes the Spark Pool can support. Must be between 3 and 200.</summary>
    [JsonPropertyName("minNodeCount")]
    public double? MinNodeCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SparkPoolStatusAtProviderLibraryRequirement
{
    /// <summary>The content of library requirements.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The name of the library requirements file.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SparkPoolStatusAtProviderSparkConfig
{
    /// <summary>The contents of a spark configuration.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The name of the file where the spark configuration content will be stored.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SparkPoolStatusAtProvider
{
    /// <summary>An auto_pause block as defined below.</summary>
    [JsonPropertyName("autoPause")]
    public IList<V1beta1SparkPoolStatusAtProviderAutoPause>? AutoPause { get; set; }

    /// <summary>An auto_scale block as defined below. Exactly one of node_count or auto_scale must be specified.</summary>
    [JsonPropertyName("autoScale")]
    public IList<V1beta1SparkPoolStatusAtProviderAutoScale>? AutoScale { get; set; }

    /// <summary>The cache size in the Spark Pool.</summary>
    [JsonPropertyName("cacheSize")]
    public double? CacheSize { get; set; }

    /// <summary>Indicates whether compute isolation is enabled or not. Defaults to false.</summary>
    [JsonPropertyName("computeIsolationEnabled")]
    public bool? ComputeIsolationEnabled { get; set; }

    /// <summary>Indicates whether Dynamic Executor Allocation is enabled or not. Defaults to false.</summary>
    [JsonPropertyName("dynamicExecutorAllocationEnabled")]
    public bool? DynamicExecutorAllocationEnabled { get; set; }

    /// <summary>The ID of the Synapse Spark Pool.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A library_requirement block as defined below.</summary>
    [JsonPropertyName("libraryRequirement")]
    public IList<V1beta1SparkPoolStatusAtProviderLibraryRequirement>? LibraryRequirement { get; set; }

    /// <summary>The maximum number of executors allocated only when dynamic_executor_allocation_enabled set to true.</summary>
    [JsonPropertyName("maxExecutors")]
    public double? MaxExecutors { get; set; }

    /// <summary>The minimum number of executors allocated only when dynamic_executor_allocation_enabled set to true.</summary>
    [JsonPropertyName("minExecutors")]
    public double? MinExecutors { get; set; }

    /// <summary>The number of nodes in the Spark Pool. Exactly one of node_count or auto_scale must be specified.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>The level of node in the Spark Pool. Possible values are Small, Medium, Large, None, XLarge, XXLarge and XXXLarge.</summary>
    [JsonPropertyName("nodeSize")]
    public string? NodeSize { get; set; }

    /// <summary>The kind of nodes that the Spark Pool provides. Possible values are HardwareAcceleratedFPGA, HardwareAcceleratedGPU, MemoryOptimized, and None.</summary>
    [JsonPropertyName("nodeSizeFamily")]
    public string? NodeSizeFamily { get; set; }

    /// <summary>Indicates whether session level packages are enabled or not. Defaults to false.</summary>
    [JsonPropertyName("sessionLevelPackagesEnabled")]
    public bool? SessionLevelPackagesEnabled { get; set; }

    /// <summary>A spark_config block as defined below.</summary>
    [JsonPropertyName("sparkConfig")]
    public IList<V1beta1SparkPoolStatusAtProviderSparkConfig>? SparkConfig { get; set; }

    /// <summary>The Spark events folder. Defaults to /events.</summary>
    [JsonPropertyName("sparkEventsFolder")]
    public string? SparkEventsFolder { get; set; }

    /// <summary>The default folder where Spark logs will be written. Defaults to /logs.</summary>
    [JsonPropertyName("sparkLogFolder")]
    public string? SparkLogFolder { get; set; }

    /// <summary>The Apache Spark version. Possible values are 3.2, 3.3, and 3.4.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary>The ID of the Synapse Workspace where the Synapse Spark Pool should exist. Changing this forces a new Synapse Spark Pool to be created.</summary>
    [JsonPropertyName("synapseWorkspaceId")]
    public string? SynapseWorkspaceId { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Synapse Spark Pool.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SparkPoolStatusConditions
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
/// <summary>SparkPoolStatus defines the observed state of SparkPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SparkPoolStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SparkPoolStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SparkPoolStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SparkPool is the Schema for the SparkPools API. Manages a Synapse Spark Pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SparkPool : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SparkPoolSpec>, IStatus<V1beta1SparkPoolStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SparkPool";
    public const string KubeGroup = "synapse.azure.upbound.io";
    public const string KubePluralName = "sparkpools";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SparkPoolSpec defines the desired state of SparkPool</summary>
    [JsonPropertyName("spec")]
    public V1beta1SparkPoolSpec Spec { get; set; }

    /// <summary>SparkPoolStatus defines the observed state of SparkPool.</summary>
    [JsonPropertyName("status")]
    public V1beta1SparkPoolStatus? Status { get; set; }
}
#nullable disable
