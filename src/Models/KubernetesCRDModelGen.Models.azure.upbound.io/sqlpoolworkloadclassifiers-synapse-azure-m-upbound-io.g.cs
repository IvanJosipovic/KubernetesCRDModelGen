using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.synapse.azure.m.upbound.io;
/// <summary>SQLPoolWorkloadClassifier is the Schema for the SQLPoolWorkloadClassifiers API. Manages a Synapse SQL Pool Workload Classifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SQLPoolWorkloadClassifierList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SQLPoolWorkloadClassifier>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SQLPoolWorkloadClassifierList";
    public const string KubeGroup = "synapse.azure.m.upbound.io";
    public const string KubePluralName = "sqlpoolworkloadclassifiers";
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
    public IList<V1beta1SQLPoolWorkloadClassifier> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolWorkloadClassifierSpecForProviderWorkloadGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a SQLPoolWorkloadGroup in synapse to populate workloadGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolWorkloadClassifierSpecForProviderWorkloadGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SQLPoolWorkloadClassifierSpecForProviderWorkloadGroupIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolWorkloadClassifierSpecForProviderWorkloadGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a SQLPoolWorkloadGroup in synapse to populate workloadGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolWorkloadClassifierSpecForProviderWorkloadGroupIdSelector
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
    public V1beta1SQLPoolWorkloadClassifierSpecForProviderWorkloadGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolWorkloadClassifierSpecForProvider
{
    /// <summary>Specifies the session context value that a request can be classified against.</summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    /// <summary>The workload classifier end time for classification. It's of the HH:MM format in UTC time zone.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>The workload classifier importance. The allowed values are low, below_normal, normal, above_normal and high.</summary>
    [JsonPropertyName("importance")]
    public string? Importance { get; set; }

    /// <summary>Specifies the label value that a request can be classified against.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The workload classifier member name used to classified against.</summary>
    [JsonPropertyName("memberName")]
    public string? MemberName { get; set; }

    /// <summary>The workload classifier start time for classification. It's of the HH:MM format in UTC time zone.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>The ID of the Synapse SQL Pool Workload Group. Changing this forces a new Synapse SQL Pool Workload Classifier to be created.</summary>
    [JsonPropertyName("workloadGroupId")]
    public string? WorkloadGroupId { get; set; }

    /// <summary>Reference to a SQLPoolWorkloadGroup in synapse to populate workloadGroupId.</summary>
    [JsonPropertyName("workloadGroupIdRef")]
    public V1beta1SQLPoolWorkloadClassifierSpecForProviderWorkloadGroupIdRef? WorkloadGroupIdRef { get; set; }

    /// <summary>Selector for a SQLPoolWorkloadGroup in synapse to populate workloadGroupId.</summary>
    [JsonPropertyName("workloadGroupIdSelector")]
    public V1beta1SQLPoolWorkloadClassifierSpecForProviderWorkloadGroupIdSelector? WorkloadGroupIdSelector { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolWorkloadClassifierSpecInitProvider
{
    /// <summary>Specifies the session context value that a request can be classified against.</summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    /// <summary>The workload classifier end time for classification. It's of the HH:MM format in UTC time zone.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>The workload classifier importance. The allowed values are low, below_normal, normal, above_normal and high.</summary>
    [JsonPropertyName("importance")]
    public string? Importance { get; set; }

    /// <summary>Specifies the label value that a request can be classified against.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The workload classifier member name used to classified against.</summary>
    [JsonPropertyName("memberName")]
    public string? MemberName { get; set; }

    /// <summary>The workload classifier start time for classification. It's of the HH:MM format in UTC time zone.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolWorkloadClassifierSpecProviderConfigRef
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
public partial class V1beta1SQLPoolWorkloadClassifierSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SQLPoolWorkloadClassifierSpec defines the desired state of SQLPoolWorkloadClassifier</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolWorkloadClassifierSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SQLPoolWorkloadClassifierSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SQLPoolWorkloadClassifierSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SQLPoolWorkloadClassifierSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SQLPoolWorkloadClassifierSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolWorkloadClassifierStatusAtProvider
{
    /// <summary>Specifies the session context value that a request can be classified against.</summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    /// <summary>The workload classifier end time for classification. It's of the HH:MM format in UTC time zone.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>The ID of the Synapse SQL Pool Workload Classifier.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The workload classifier importance. The allowed values are low, below_normal, normal, above_normal and high.</summary>
    [JsonPropertyName("importance")]
    public string? Importance { get; set; }

    /// <summary>Specifies the label value that a request can be classified against.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The workload classifier member name used to classified against.</summary>
    [JsonPropertyName("memberName")]
    public string? MemberName { get; set; }

    /// <summary>The workload classifier start time for classification. It's of the HH:MM format in UTC time zone.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>The ID of the Synapse SQL Pool Workload Group. Changing this forces a new Synapse SQL Pool Workload Classifier to be created.</summary>
    [JsonPropertyName("workloadGroupId")]
    public string? WorkloadGroupId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolWorkloadClassifierStatusConditions
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

/// <summary>SQLPoolWorkloadClassifierStatus defines the observed state of SQLPoolWorkloadClassifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLPoolWorkloadClassifierStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SQLPoolWorkloadClassifierStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SQLPoolWorkloadClassifierStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SQLPoolWorkloadClassifier is the Schema for the SQLPoolWorkloadClassifiers API. Manages a Synapse SQL Pool Workload Classifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SQLPoolWorkloadClassifier : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SQLPoolWorkloadClassifierSpec>, IStatus<V1beta1SQLPoolWorkloadClassifierStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SQLPoolWorkloadClassifier";
    public const string KubeGroup = "synapse.azure.m.upbound.io";
    public const string KubePluralName = "sqlpoolworkloadclassifiers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SQLPoolWorkloadClassifierSpec defines the desired state of SQLPoolWorkloadClassifier</summary>
    [JsonPropertyName("spec")]
    public V1beta1SQLPoolWorkloadClassifierSpec Spec { get; set; }

    /// <summary>SQLPoolWorkloadClassifierStatus defines the observed state of SQLPoolWorkloadClassifier.</summary>
    [JsonPropertyName("status")]
    public V1beta1SQLPoolWorkloadClassifierStatus? Status { get; set; }
}