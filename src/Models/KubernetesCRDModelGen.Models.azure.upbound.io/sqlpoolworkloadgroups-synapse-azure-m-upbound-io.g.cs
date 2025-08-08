using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.synapse.azure.m.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolWorkloadGroupSpecForProviderSqlPoolIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a SQLPool in synapse to populate sqlPoolId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolWorkloadGroupSpecForProviderSqlPoolIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SQLPoolWorkloadGroupSpecForProviderSqlPoolIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolWorkloadGroupSpecForProviderSqlPoolIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a SQLPool in synapse to populate sqlPoolId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolWorkloadGroupSpecForProviderSqlPoolIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SQLPoolWorkloadGroupSpecForProviderSqlPoolIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolWorkloadGroupSpecForProvider
{
    /// <summary>The workload group importance level. Defaults to normal.</summary>
    [JsonPropertyName("importance")]
    public string? Importance { get; set; }

    /// <summary>The workload group cap percentage resource.</summary>
    [JsonPropertyName("maxResourcePercent")]
    public double? MaxResourcePercent { get; set; }

    /// <summary>The workload group request maximum grant percentage. Defaults to 3.</summary>
    [JsonPropertyName("maxResourcePercentPerRequest")]
    public double? MaxResourcePercentPerRequest { get; set; }

    /// <summary>The workload group minimum percentage resource.</summary>
    [JsonPropertyName("minResourcePercent")]
    public double? MinResourcePercent { get; set; }

    /// <summary>The workload group request minimum grant percentage.</summary>
    [JsonPropertyName("minResourcePercentPerRequest")]
    public double? MinResourcePercentPerRequest { get; set; }

    /// <summary>The workload group query execution timeout.</summary>
    [JsonPropertyName("queryExecutionTimeoutInSeconds")]
    public double? QueryExecutionTimeoutInSeconds { get; set; }

    /// <summary>The ID of the Synapse SQL Pool. Changing this forces a new Synapse SQL Pool Workload Group to be created.</summary>
    [JsonPropertyName("sqlPoolId")]
    public string? SqlPoolId { get; set; }

    /// <summary>Reference to a SQLPool in synapse to populate sqlPoolId.</summary>
    [JsonPropertyName("sqlPoolIdRef")]
    public V1beta1SQLPoolWorkloadGroupSpecForProviderSqlPoolIdRef? SqlPoolIdRef { get; set; }

    /// <summary>Selector for a SQLPool in synapse to populate sqlPoolId.</summary>
    [JsonPropertyName("sqlPoolIdSelector")]
    public V1beta1SQLPoolWorkloadGroupSpecForProviderSqlPoolIdSelector? SqlPoolIdSelector { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolWorkloadGroupSpecInitProvider
{
    /// <summary>The workload group importance level. Defaults to normal.</summary>
    [JsonPropertyName("importance")]
    public string? Importance { get; set; }

    /// <summary>The workload group cap percentage resource.</summary>
    [JsonPropertyName("maxResourcePercent")]
    public double? MaxResourcePercent { get; set; }

    /// <summary>The workload group request maximum grant percentage. Defaults to 3.</summary>
    [JsonPropertyName("maxResourcePercentPerRequest")]
    public double? MaxResourcePercentPerRequest { get; set; }

    /// <summary>The workload group minimum percentage resource.</summary>
    [JsonPropertyName("minResourcePercent")]
    public double? MinResourcePercent { get; set; }

    /// <summary>The workload group request minimum grant percentage.</summary>
    [JsonPropertyName("minResourcePercentPerRequest")]
    public double? MinResourcePercentPerRequest { get; set; }

    /// <summary>The workload group query execution timeout.</summary>
    [JsonPropertyName("queryExecutionTimeoutInSeconds")]
    public double? QueryExecutionTimeoutInSeconds { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolWorkloadGroupSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolWorkloadGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SQLPoolWorkloadGroupSpec defines the desired state of SQLPoolWorkloadGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolWorkloadGroupSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SQLPoolWorkloadGroupSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SQLPoolWorkloadGroupSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SQLPoolWorkloadGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SQLPoolWorkloadGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolWorkloadGroupStatusAtProvider
{
    /// <summary>The ID of the Synapse SQL Pool Workload Group.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The workload group importance level. Defaults to normal.</summary>
    [JsonPropertyName("importance")]
    public string? Importance { get; set; }

    /// <summary>The workload group cap percentage resource.</summary>
    [JsonPropertyName("maxResourcePercent")]
    public double? MaxResourcePercent { get; set; }

    /// <summary>The workload group request maximum grant percentage. Defaults to 3.</summary>
    [JsonPropertyName("maxResourcePercentPerRequest")]
    public double? MaxResourcePercentPerRequest { get; set; }

    /// <summary>The workload group minimum percentage resource.</summary>
    [JsonPropertyName("minResourcePercent")]
    public double? MinResourcePercent { get; set; }

    /// <summary>The workload group request minimum grant percentage.</summary>
    [JsonPropertyName("minResourcePercentPerRequest")]
    public double? MinResourcePercentPerRequest { get; set; }

    /// <summary>The workload group query execution timeout.</summary>
    [JsonPropertyName("queryExecutionTimeoutInSeconds")]
    public double? QueryExecutionTimeoutInSeconds { get; set; }

    /// <summary>The ID of the Synapse SQL Pool. Changing this forces a new Synapse SQL Pool Workload Group to be created.</summary>
    [JsonPropertyName("sqlPoolId")]
    public string? SqlPoolId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolWorkloadGroupStatusConditions
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

/// <summary>SQLPoolWorkloadGroupStatus defines the observed state of SQLPoolWorkloadGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolWorkloadGroupStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SQLPoolWorkloadGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SQLPoolWorkloadGroupStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SQLPoolWorkloadGroup is the Schema for the SQLPoolWorkloadGroups API. Manages a Synapse SQL Pool Workload Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SQLPoolWorkloadGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SQLPoolWorkloadGroupSpec>, IStatus<V1beta1SQLPoolWorkloadGroupStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SQLPoolWorkloadGroup";
    public const string KubeGroup = "synapse.azure.m.upbound.io";
    public const string KubePluralName = "sqlpoolworkloadgroups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SQLPoolWorkloadGroupSpec defines the desired state of SQLPoolWorkloadGroup</summary>
    [JsonPropertyName("spec")]
    public V1beta1SQLPoolWorkloadGroupSpec Spec { get; set; }

    /// <summary>SQLPoolWorkloadGroupStatus defines the observed state of SQLPoolWorkloadGroup.</summary>
    [JsonPropertyName("status")]
    public V1beta1SQLPoolWorkloadGroupStatus? Status { get; set; }
}

/// <summary>SQLPoolWorkloadGroup is the Schema for the SQLPoolWorkloadGroups API. Manages a Synapse SQL Pool Workload Group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SQLPoolWorkloadGroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SQLPoolWorkloadGroup>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SQLPoolWorkloadGroupList";
    public const string KubeGroup = "synapse.azure.m.upbound.io";
    public const string KubePluralName = "sqlpoolworkloadgroups";
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
    public IList<V1beta1SQLPoolWorkloadGroup> Items { get; set; }
}