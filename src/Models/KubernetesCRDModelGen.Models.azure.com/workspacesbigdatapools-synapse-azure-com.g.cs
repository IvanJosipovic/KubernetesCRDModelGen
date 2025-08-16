using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.synapse.azure.com;
/// <summary>Storage version of v1api20210601.WorkspacesBigDataPool Generator information: - Generated from: /synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/bigDataPool.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/bigDataPools/{bigDataPoolName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210601storageWorkspacesBigDataPoolList : IKubernetesObject<V1ListMeta>, IItems<V1api20210601storageWorkspacesBigDataPool>
{
    public const string KubeApiVersion = "v1api20210601storage";
    public const string KubeKind = "WorkspacesBigDataPoolList";
    public const string KubeGroup = "synapse.azure.com";
    public const string KubePluralName = "workspacesbigdatapools";
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
    public IList<V1api20210601storageWorkspacesBigDataPool> Items { get; set; }
}

/// <summary>Storage version of v1api20210601.AutoPauseProperties Auto-pausing properties of a Big Data pool powered by Apache Spark</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolSpecAutoPause
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("delayInMinutes")]
    public int? DelayInMinutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20210601.AutoScaleProperties Auto-scaling properties of a Big Data pool powered by Apache Spark</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolSpecAutoScale
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxNodeCount")]
    public int? MaxNodeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minNodeCount")]
    public int? MinNodeCount { get; set; }
}

/// <summary>Storage version of v1api20210601.LibraryInfo Library/package information of a Big Data pool powered by Apache Spark</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolSpecCustomLibraries
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20210601.DynamicExecutorAllocation Dynamic Executor Allocation Properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolSpecDynamicExecutorAllocation
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxExecutors")]
    public int? MaxExecutors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minExecutors")]
    public int? MinExecutors { get; set; }
}

/// <summary>Storage version of v1api20210601.LibraryRequirements Library requirements for a Big Data pool powered by Apache Spark</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolSpecLibraryRequirements
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolSpecOperatorSpecConfigMapExpressions
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

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolSpecOperatorSpecSecretExpressions
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

/// <summary>Storage version of v1api20210601.WorkspacesBigDataPoolOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20210601storageWorkspacesBigDataPoolSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20210601storageWorkspacesBigDataPoolSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a synapse.azure.com/Workspace resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20210601.SparkConfigProperties SparkConfig Properties for a Big Data pool powered by Apache Spark</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolSpecSparkConfigProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configurationType")]
    public string? ConfigurationType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }
}

/// <summary>Storage version of v1api20210601.WorkspacesBigDataPool_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210601.AutoPauseProperties Auto-pausing properties of a Big Data pool powered by Apache Spark</summary>
    [JsonPropertyName("autoPause")]
    public V1api20210601storageWorkspacesBigDataPoolSpecAutoPause? AutoPause { get; set; }

    /// <summary>Storage version of v1api20210601.AutoScaleProperties Auto-scaling properties of a Big Data pool powered by Apache Spark</summary>
    [JsonPropertyName("autoScale")]
    public V1api20210601storageWorkspacesBigDataPoolSpecAutoScale? AutoScale { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cacheSize")]
    public int? CacheSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customLibraries")]
    public IList<V1api20210601storageWorkspacesBigDataPoolSpecCustomLibraries>? CustomLibraries { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultSparkLogFolder")]
    public string? DefaultSparkLogFolder { get; set; }

    /// <summary>Storage version of v1api20210601.DynamicExecutorAllocation Dynamic Executor Allocation Properties</summary>
    [JsonPropertyName("dynamicExecutorAllocation")]
    public V1api20210601storageWorkspacesBigDataPoolSpecDynamicExecutorAllocation? DynamicExecutorAllocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isAutotuneEnabled")]
    public bool? IsAutotuneEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isComputeIsolationEnabled")]
    public bool? IsComputeIsolationEnabled { get; set; }

    /// <summary>Storage version of v1api20210601.LibraryRequirements Library requirements for a Big Data pool powered by Apache Spark</summary>
    [JsonPropertyName("libraryRequirements")]
    public V1api20210601storageWorkspacesBigDataPoolSpecLibraryRequirements? LibraryRequirements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeCount")]
    public int? NodeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeSize")]
    public string? NodeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeSizeFamily")]
    public string? NodeSizeFamily { get; set; }

    /// <summary>Storage version of v1api20210601.WorkspacesBigDataPoolOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20210601storageWorkspacesBigDataPoolSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a synapse.azure.com/Workspace resource</summary>
    [JsonPropertyName("owner")]
    public V1api20210601storageWorkspacesBigDataPoolSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sessionLevelPackagesEnabled")]
    public bool? SessionLevelPackagesEnabled { get; set; }

    /// <summary>Storage version of v1api20210601.SparkConfigProperties SparkConfig Properties for a Big Data pool powered by Apache Spark</summary>
    [JsonPropertyName("sparkConfigProperties")]
    public V1api20210601storageWorkspacesBigDataPoolSpecSparkConfigProperties? SparkConfigProperties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkEventsFolder")]
    public string? SparkEventsFolder { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Storage version of v1api20210601.AutoPauseProperties_STATUS Auto-pausing properties of a Big Data pool powered by Apache Spark</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolStatusAutoPause
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("delayInMinutes")]
    public int? DelayInMinutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Storage version of v1api20210601.AutoScaleProperties_STATUS Auto-scaling properties of a Big Data pool powered by Apache Spark</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolStatusAutoScale
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxNodeCount")]
    public int? MaxNodeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minNodeCount")]
    public int? MinNodeCount { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolStatusConditions
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

/// <summary>Storage version of v1api20210601.LibraryInfo_STATUS Library/package information of a Big Data pool powered by Apache Spark</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolStatusCustomLibraries
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("creatorId")]
    public string? CreatorId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningStatus")]
    public string? ProvisioningStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("uploadedTimestamp")]
    public string? UploadedTimestamp { get; set; }
}

/// <summary>Storage version of v1api20210601.DynamicExecutorAllocation_STATUS Dynamic Executor Allocation Properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolStatusDynamicExecutorAllocation
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxExecutors")]
    public int? MaxExecutors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minExecutors")]
    public int? MinExecutors { get; set; }
}

/// <summary>Storage version of v1api20210601.LibraryRequirements_STATUS Library requirements for a Big Data pool powered by Apache Spark</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolStatusLibraryRequirements
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary></summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>Storage version of v1api20210601.SparkConfigProperties_STATUS SparkConfig Properties for a Big Data pool powered by Apache Spark</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolStatusSparkConfigProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configurationType")]
    public string? ConfigurationType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary></summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>Storage version of v1api20210601.WorkspacesBigDataPool_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210601.AutoPauseProperties_STATUS Auto-pausing properties of a Big Data pool powered by Apache Spark</summary>
    [JsonPropertyName("autoPause")]
    public V1api20210601storageWorkspacesBigDataPoolStatusAutoPause? AutoPause { get; set; }

    /// <summary>Storage version of v1api20210601.AutoScaleProperties_STATUS Auto-scaling properties of a Big Data pool powered by Apache Spark</summary>
    [JsonPropertyName("autoScale")]
    public V1api20210601storageWorkspacesBigDataPoolStatusAutoScale? AutoScale { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cacheSize")]
    public int? CacheSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20210601storageWorkspacesBigDataPoolStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("creationDate")]
    public string? CreationDate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customLibraries")]
    public IList<V1api20210601storageWorkspacesBigDataPoolStatusCustomLibraries>? CustomLibraries { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultSparkLogFolder")]
    public string? DefaultSparkLogFolder { get; set; }

    /// <summary>Storage version of v1api20210601.DynamicExecutorAllocation_STATUS Dynamic Executor Allocation Properties</summary>
    [JsonPropertyName("dynamicExecutorAllocation")]
    public V1api20210601storageWorkspacesBigDataPoolStatusDynamicExecutorAllocation? DynamicExecutorAllocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isAutotuneEnabled")]
    public bool? IsAutotuneEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isComputeIsolationEnabled")]
    public bool? IsComputeIsolationEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastSucceededTimestamp")]
    public string? LastSucceededTimestamp { get; set; }

    /// <summary>Storage version of v1api20210601.LibraryRequirements_STATUS Library requirements for a Big Data pool powered by Apache Spark</summary>
    [JsonPropertyName("libraryRequirements")]
    public V1api20210601storageWorkspacesBigDataPoolStatusLibraryRequirements? LibraryRequirements { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeCount")]
    public int? NodeCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeSize")]
    public string? NodeSize { get; set; }

    /// <summary></summary>
    [JsonPropertyName("nodeSizeFamily")]
    public string? NodeSizeFamily { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sessionLevelPackagesEnabled")]
    public bool? SessionLevelPackagesEnabled { get; set; }

    /// <summary>Storage version of v1api20210601.SparkConfigProperties_STATUS SparkConfig Properties for a Big Data pool powered by Apache Spark</summary>
    [JsonPropertyName("sparkConfigProperties")]
    public V1api20210601storageWorkspacesBigDataPoolStatusSparkConfigProperties? SparkConfigProperties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkEventsFolder")]
    public string? SparkEventsFolder { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20210601.WorkspacesBigDataPool Generator information: - Generated from: /synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/bigDataPool.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/bigDataPools/{bigDataPoolName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210601storageWorkspacesBigDataPool : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20210601storageWorkspacesBigDataPoolSpec>, IStatus<V1api20210601storageWorkspacesBigDataPoolStatus>
{
    public const string KubeApiVersion = "v1api20210601storage";
    public const string KubeKind = "WorkspacesBigDataPool";
    public const string KubeGroup = "synapse.azure.com";
    public const string KubePluralName = "workspacesbigdatapools";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20210601.WorkspacesBigDataPool_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20210601storageWorkspacesBigDataPoolSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20210601.WorkspacesBigDataPool_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20210601storageWorkspacesBigDataPoolStatus? Status { get; set; }
}