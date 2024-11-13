using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containerservice.azure.com;
/// <summary>Storage version of v1api20230315preview.ManagedClusterUpgradeSpec The upgrade to apply to a ManagedCluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunSpecManagedClusterUpdateUpgrade
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kubernetesVersion")]
    public string? KubernetesVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20230315preview.ManagedClusterUpdate The update to be applied to the ManagedClusters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunSpecManagedClusterUpdate
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230315preview.ManagedClusterUpgradeSpec The upgrade to apply to a ManagedCluster.</summary>
    [JsonPropertyName("upgrade")]
    public V1api20230315previewstorageFleetsUpdateRunSpecManagedClusterUpdateUpgrade? Upgrade { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20230315previewstorageFleetsUpdateRunSpecOperatorSpecSecretExpressions
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

/// <summary>Storage version of v1api20230315preview.FleetsUpdateRunOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20230315previewstorageFleetsUpdateRunSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20230315previewstorageFleetsUpdateRunSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a containerservice.azure.com/Fleet resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230315preview.UpdateGroup A group to be updated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunSpecStrategyStagesGroups
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230315preview.UpdateStage Defines a stage which contains the groups to update and the steps to take (e.g., wait for a time period) before starting the next stage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunSpecStrategyStages
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("afterStageWaitInSeconds")]
    public int? AfterStageWaitInSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("groups")]
    public IList<V1api20230315previewstorageFleetsUpdateRunSpecStrategyStagesGroups>? Groups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230315preview.UpdateRunStrategy Defines the update sequence of the clusters via stages and groups. Stages within a run are executed sequentially one after another. Groups within a stage are executed in parallel. Member clusters within a group are updated sequentially one after another. A valid strategy contains no duplicate groups within or across stages.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunSpecStrategy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stages")]
    public IList<V1api20230315previewstorageFleetsUpdateRunSpecStrategyStages>? Stages { get; set; }
}

/// <summary>Storage version of v1api20230315preview.FleetsUpdateRun_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Storage version of v1api20230315preview.ManagedClusterUpdate The update to be applied to the ManagedClusters.</summary>
    [JsonPropertyName("managedClusterUpdate")]
    public V1api20230315previewstorageFleetsUpdateRunSpecManagedClusterUpdate? ManagedClusterUpdate { get; set; }

    /// <summary>Storage version of v1api20230315preview.FleetsUpdateRunOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20230315previewstorageFleetsUpdateRunSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a containerservice.azure.com/Fleet resource</summary>
    [JsonPropertyName("owner")]
    public V1api20230315previewstorageFleetsUpdateRunSpecOwner Owner { get; set; }

    /// <summary>Storage version of v1api20230315preview.UpdateRunStrategy Defines the update sequence of the clusters via stages and groups. Stages within a run are executed sequentially one after another. Groups within a stage are executed in parallel. Member clusters within a group are updated sequentially one after another. A valid strategy contains no duplicate groups within or across stages.</summary>
    [JsonPropertyName("strategy")]
    public V1api20230315previewstorageFleetsUpdateRunSpecStrategy? Strategy { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusConditions
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

/// <summary>Storage version of v1api20230315preview.ManagedClusterUpgradeSpec_STATUS The upgrade to apply to a ManagedCluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusManagedClusterUpdateUpgrade
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kubernetesVersion")]
    public string? KubernetesVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20230315preview.ManagedClusterUpdate_STATUS The update to be applied to the ManagedClusters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusManagedClusterUpdate
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230315preview.ManagedClusterUpgradeSpec_STATUS The upgrade to apply to a ManagedCluster.</summary>
    [JsonPropertyName("upgrade")]
    public V1api20230315previewstorageFleetsUpdateRunStatusManagedClusterUpdateUpgrade? Upgrade { get; set; }
}

/// <summary>Storage version of v1api20230315preview.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesAfterStageWaitStatusStatusErrorAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20230315preview.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesAfterStageWaitStatusStatusErrorDetailsAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20230315preview.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesAfterStageWaitStatusStatusErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesAfterStageWaitStatusStatusErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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

/// <summary>Storage version of v1api20230315preview.ErrorDetail_STATUS The error detail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesAfterStageWaitStatusStatusError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesAfterStageWaitStatusStatusErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesAfterStageWaitStatusStatusErrorDetails>? Details { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20230315preview.UpdateStatus_STATUS The status for an operation or group of operations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesAfterStageWaitStatusStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("completedTime")]
    public string? CompletedTime { get; set; }

    /// <summary>Storage version of v1api20230315preview.ErrorDetail_STATUS The error detail.</summary>
    [JsonPropertyName("error")]
    public V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesAfterStageWaitStatusStatusError? Error { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Storage version of v1api20230315preview.WaitStatus_STATUS The status of the wait duration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesAfterStageWaitStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230315preview.UpdateStatus_STATUS The status for an operation or group of operations.</summary>
    [JsonPropertyName("status")]
    public V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesAfterStageWaitStatusStatus? Status { get; set; }

    /// <summary></summary>
    [JsonPropertyName("waitDurationInSeconds")]
    public int? WaitDurationInSeconds { get; set; }
}

/// <summary>Storage version of v1api20230315preview.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesGroupsMembersStatusErrorAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20230315preview.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesGroupsMembersStatusErrorDetailsAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20230315preview.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesGroupsMembersStatusErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesGroupsMembersStatusErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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

/// <summary>Storage version of v1api20230315preview.ErrorDetail_STATUS The error detail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesGroupsMembersStatusError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesGroupsMembersStatusErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesGroupsMembersStatusErrorDetails>? Details { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20230315preview.UpdateStatus_STATUS The status for an operation or group of operations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesGroupsMembersStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("completedTime")]
    public string? CompletedTime { get; set; }

    /// <summary>Storage version of v1api20230315preview.ErrorDetail_STATUS The error detail.</summary>
    [JsonPropertyName("error")]
    public V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesGroupsMembersStatusError? Error { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Storage version of v1api20230315preview.MemberUpdateStatus_STATUS The status of a member update operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesGroupsMembers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterResourceId")]
    public string? ClusterResourceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operationId")]
    public string? OperationId { get; set; }

    /// <summary>Storage version of v1api20230315preview.UpdateStatus_STATUS The status for an operation or group of operations.</summary>
    [JsonPropertyName("status")]
    public V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesGroupsMembersStatus? Status { get; set; }
}

/// <summary>Storage version of v1api20230315preview.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesGroupsStatusErrorAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20230315preview.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesGroupsStatusErrorDetailsAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20230315preview.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesGroupsStatusErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesGroupsStatusErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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

/// <summary>Storage version of v1api20230315preview.ErrorDetail_STATUS The error detail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesGroupsStatusError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesGroupsStatusErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesGroupsStatusErrorDetails>? Details { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20230315preview.UpdateStatus_STATUS The status for an operation or group of operations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesGroupsStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("completedTime")]
    public string? CompletedTime { get; set; }

    /// <summary>Storage version of v1api20230315preview.ErrorDetail_STATUS The error detail.</summary>
    [JsonPropertyName("error")]
    public V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesGroupsStatusError? Error { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Storage version of v1api20230315preview.UpdateGroupStatus_STATUS The status of a UpdateGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesGroups
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("members")]
    public IList<V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesGroupsMembers>? Members { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230315preview.UpdateStatus_STATUS The status for an operation or group of operations.</summary>
    [JsonPropertyName("status")]
    public V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesGroupsStatus? Status { get; set; }
}

/// <summary>Storage version of v1api20230315preview.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesStatusErrorAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20230315preview.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesStatusErrorDetailsAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20230315preview.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesStatusErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesStatusErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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

/// <summary>Storage version of v1api20230315preview.ErrorDetail_STATUS The error detail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesStatusError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesStatusErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesStatusErrorDetails>? Details { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20230315preview.UpdateStatus_STATUS The status for an operation or group of operations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("completedTime")]
    public string? CompletedTime { get; set; }

    /// <summary>Storage version of v1api20230315preview.ErrorDetail_STATUS The error detail.</summary>
    [JsonPropertyName("error")]
    public V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesStatusError? Error { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Storage version of v1api20230315preview.UpdateStageStatus_STATUS The status of a UpdateStage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStatusStages
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20230315preview.WaitStatus_STATUS The status of the wait duration.</summary>
    [JsonPropertyName("afterStageWaitStatus")]
    public V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesAfterStageWaitStatus? AfterStageWaitStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("groups")]
    public IList<V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesGroups>? Groups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20230315preview.UpdateStatus_STATUS The status for an operation or group of operations.</summary>
    [JsonPropertyName("status")]
    public V1api20230315previewstorageFleetsUpdateRunStatusStatusStagesStatus? Status { get; set; }
}

/// <summary>Storage version of v1api20230315preview.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStatusStatusErrorAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20230315preview.ErrorAdditionalInfo_STATUS The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStatusStatusErrorDetailsAdditionalInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20230315preview.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStatusStatusErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20230315previewstorageFleetsUpdateRunStatusStatusStatusErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

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

/// <summary>Storage version of v1api20230315preview.ErrorDetail_STATUS The error detail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStatusStatusError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20230315previewstorageFleetsUpdateRunStatusStatusStatusErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20230315previewstorageFleetsUpdateRunStatusStatusStatusErrorDetails>? Details { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20230315preview.UpdateStatus_STATUS The status for an operation or group of operations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStatusStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("completedTime")]
    public string? CompletedTime { get; set; }

    /// <summary>Storage version of v1api20230315preview.ErrorDetail_STATUS The error detail.</summary>
    [JsonPropertyName("error")]
    public V1api20230315previewstorageFleetsUpdateRunStatusStatusStatusError? Error { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Storage version of v1api20230315preview.UpdateRunStatus_STATUS The status of a UpdateRun.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stages")]
    public IList<V1api20230315previewstorageFleetsUpdateRunStatusStatusStages>? Stages { get; set; }

    /// <summary>Storage version of v1api20230315preview.UpdateStatus_STATUS The status for an operation or group of operations.</summary>
    [JsonPropertyName("status")]
    public V1api20230315previewstorageFleetsUpdateRunStatusStatusStatus? Status { get; set; }
}

/// <summary>Storage version of v1api20230315preview.UpdateGroup_STATUS A group to be updated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStrategyStagesGroups
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230315preview.UpdateStage_STATUS Defines a stage which contains the groups to update and the steps to take (e.g., wait for a time period) before starting the next stage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStrategyStages
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("afterStageWaitInSeconds")]
    public int? AfterStageWaitInSeconds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("groups")]
    public IList<V1api20230315previewstorageFleetsUpdateRunStatusStrategyStagesGroups>? Groups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20230315preview.UpdateRunStrategy_STATUS Defines the update sequence of the clusters via stages and groups. Stages within a run are executed sequentially one after another. Groups within a stage are executed in parallel. Member clusters within a group are updated sequentially one after another. A valid strategy contains no duplicate groups within or across stages.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusStrategy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("stages")]
    public IList<V1api20230315previewstorageFleetsUpdateRunStatusStrategyStages>? Stages { get; set; }
}

/// <summary>Storage version of v1api20230315preview.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatusSystemData
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

/// <summary>Storage version of v1api20230315preview.FleetsUpdateRun_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230315previewstorageFleetsUpdateRunStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20230315previewstorageFleetsUpdateRunStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20230315preview.ManagedClusterUpdate_STATUS The update to be applied to the ManagedClusters.</summary>
    [JsonPropertyName("managedClusterUpdate")]
    public V1api20230315previewstorageFleetsUpdateRunStatusManagedClusterUpdate? ManagedClusterUpdate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>Storage version of v1api20230315preview.UpdateRunStatus_STATUS The status of a UpdateRun.</summary>
    [JsonPropertyName("status")]
    public V1api20230315previewstorageFleetsUpdateRunStatusStatus? Status { get; set; }

    /// <summary>Storage version of v1api20230315preview.UpdateRunStrategy_STATUS Defines the update sequence of the clusters via stages and groups. Stages within a run are executed sequentially one after another. Groups within a stage are executed in parallel. Member clusters within a group are updated sequentially one after another. A valid strategy contains no duplicate groups within or across stages.</summary>
    [JsonPropertyName("strategy")]
    public V1api20230315previewstorageFleetsUpdateRunStatusStrategy? Strategy { get; set; }

    /// <summary>Storage version of v1api20230315preview.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20230315previewstorageFleetsUpdateRunStatusSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20230315preview.FleetsUpdateRun Generator information: - Generated from: /containerservice/resource-manager/Microsoft.ContainerService/fleet/preview/2023-03-15-preview/fleets.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/updateRuns/{updateRunName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230315previewstorageFleetsUpdateRun : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230315previewstorageFleetsUpdateRunSpec>, IStatus<V1api20230315previewstorageFleetsUpdateRunStatus>
{
    public const string KubeApiVersion = "v1api20230315previewstorage";
    public const string KubeKind = "FleetsUpdateRun";
    public const string KubeGroup = "containerservice.azure.com";
    public const string KubePluralName = "fleetsupdateruns";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20230315preview.FleetsUpdateRun_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20230315previewstorageFleetsUpdateRunSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20230315preview.FleetsUpdateRun_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20230315previewstorageFleetsUpdateRunStatus? Status { get; set; }
}