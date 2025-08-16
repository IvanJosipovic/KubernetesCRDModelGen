using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ops.crossplane.io;
/// <summary>A WatchOperation creates Operations when watched resources change.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1WatchOperationList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1WatchOperation>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "WatchOperationList";
    public const string KubeGroup = "ops.crossplane.io";
    public const string KubePluralName = "watchoperations";
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
    public IList<V1alpha1WatchOperation> Items { get; set; }
}

/// <summary>Standard object metadata.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WatchOperationSpecOperationTemplateMetadata
{
}

/// <summary>A SecretRef is a reference to a secret containing credentials that should be supplied to the function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WatchOperationSpecOperationTemplateSpecPipelineCredentialsSecretRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>FunctionCredentials are optional credentials that a function needs to run.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WatchOperationSpecOperationTemplateSpecPipelineCredentials
{
    /// <summary>Name of this set of credentials.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>A SecretRef is a reference to a secret containing credentials that should be supplied to the function.</summary>
    [JsonPropertyName("secretRef")]
    public V1alpha1WatchOperationSpecOperationTemplateSpecPipelineCredentialsSecretRef? SecretRef { get; set; }

    /// <summary>Source of the function credentials.</summary>
    [JsonPropertyName("source")]
    public string Source { get; set; }
}

/// <summary>FunctionRef is a reference to the function this step should execute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WatchOperationSpecOperationTemplateSpecPipelineFunctionRef
{
    /// <summary>Name of the referenced function.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>RequiredResourceSelector selects resources that should be fetched before a pipeline step runs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WatchOperationSpecOperationTemplateSpecPipelineRequirementsRequiredResources
{
    /// <summary>APIVersion of resources to select.</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary>Kind of resources to select.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>MatchLabels matches resources by label selector. Only one of Name or MatchLabels may be specified.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Name matches a single resource by name. Only one of Name or MatchLabels may be specified.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace to search for resources. Optional for cluster-scoped resources.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>RequirementName uniquely identifies this group of resources. This name will be used as the key in RunFunctionRequest.required_resources.</summary>
    [JsonPropertyName("requirementName")]
    public string RequirementName { get; set; }
}

/// <summary>Requirements are resource requirements that will be satisfied before this pipeline step is called for the first time. This allows pre-populating required resources without requiring a function to request them first.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WatchOperationSpecOperationTemplateSpecPipelineRequirements
{
    /// <summary>RequiredResources that will be fetched before this pipeline step is called for the first time.</summary>
    [JsonPropertyName("requiredResources")]
    public IList<V1alpha1WatchOperationSpecOperationTemplateSpecPipelineRequirementsRequiredResources>? RequiredResources { get; set; }
}

/// <summary>A PipelineStep in an operation function pipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WatchOperationSpecOperationTemplateSpecPipeline
{
    /// <summary>Credentials are optional credentials that the operation function needs.</summary>
    [JsonPropertyName("credentials")]
    public IList<V1alpha1WatchOperationSpecOperationTemplateSpecPipelineCredentials>? Credentials { get; set; }

    /// <summary>FunctionRef is a reference to the function this step should execute.</summary>
    [JsonPropertyName("functionRef")]
    public V1alpha1WatchOperationSpecOperationTemplateSpecPipelineFunctionRef FunctionRef { get; set; }

    /// <summary>Input is an optional, arbitrary Kubernetes resource (i.e. a resource with an apiVersion and kind) that will be passed to the unction as the 'input' of its RunFunctionRequest.</summary>
    [JsonPropertyName("input")]
    public JsonNode? Input { get; set; }

    /// <summary>Requirements are resource requirements that will be satisfied before this pipeline step is called for the first time. This allows pre-populating required resources without requiring a function to request them first.</summary>
    [JsonPropertyName("requirements")]
    public V1alpha1WatchOperationSpecOperationTemplateSpecPipelineRequirements? Requirements { get; set; }

    /// <summary>Step name. Must be unique within its Pipeline.</summary>
    [JsonPropertyName("step")]
    public string Step { get; set; }
}

/// <summary>Spec is the specification of the Operation to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WatchOperationSpecOperationTemplateSpec
{
    /// <summary>Mode controls what type or "mode" of operation will be used.  "Pipeline" indicates that an Operation specifies a pipeline of functions, each of which is responsible for implementing its logic.</summary>
    [JsonPropertyName("mode")]
    public string Mode { get; set; }

    /// <summary>Pipeline is a list of operation function steps that will be used when this operation runs.</summary>
    [JsonPropertyName("pipeline")]
    public IList<V1alpha1WatchOperationSpecOperationTemplateSpecPipeline> Pipeline { get; set; }

    /// <summary>RetryLimit configures how many times the operation may fail. When the failure limit is exceeded, the operation will not be retried.</summary>
    [JsonPropertyName("retryLimit")]
    public long? RetryLimit { get; set; }
}

/// <summary>OperationTemplate is the template for the Operation to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WatchOperationSpecOperationTemplate
{
    /// <summary>Standard object metadata.</summary>
    [JsonPropertyName("metadata")]
    public V1alpha1WatchOperationSpecOperationTemplateMetadata? Metadata { get; set; }

    /// <summary>Spec is the specification of the Operation to be created.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1WatchOperationSpecOperationTemplateSpec Spec { get; set; }
}

/// <summary>Watch specifies the resource to watch.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WatchOperationSpecWatch
{
    /// <summary>APIVersion of the resource to watch.</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary>Kind of the resource to watch.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>MatchLabels selects resources by label. If empty, all resources of the specified kind are watched.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace selects resources in a specific namespace. If empty, all namespaces are watched. Only applicable for namespaced resources.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>WatchOperationSpec specifies the desired state of a WatchOperation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WatchOperationSpec
{
    /// <summary>ConcurrencyPolicy specifies how to treat concurrent executions of an operation.</summary>
    [JsonPropertyName("concurrencyPolicy")]
    public string? ConcurrencyPolicy { get; set; }

    /// <summary>FailedHistoryLimit is the number of failed Operations to retain.</summary>
    [JsonPropertyName("failedHistoryLimit")]
    public int? FailedHistoryLimit { get; set; }

    /// <summary>OperationTemplate is the template for the Operation to be created.</summary>
    [JsonPropertyName("operationTemplate")]
    public V1alpha1WatchOperationSpecOperationTemplate OperationTemplate { get; set; }

    /// <summary>SuccessfulHistoryLimit is the number of successful Operations to retain.</summary>
    [JsonPropertyName("successfulHistoryLimit")]
    public int? SuccessfulHistoryLimit { get; set; }

    /// <summary>Watch specifies the resource to watch.</summary>
    [JsonPropertyName("watch")]
    public V1alpha1WatchOperationSpecWatch Watch { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WatchOperationStatusConditions
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

/// <summary>A RunningOperationRef is a reference to a running operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WatchOperationStatusRunningOperationRefs
{
    /// <summary>Name of the active operation.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WatchOperationStatus represents the observed state of a WatchOperation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WatchOperationStatus
{
    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1WatchOperationStatusConditions>? Conditions { get; set; }

    /// <summary>LastScheduleTime is the last time the WatchOperation created an Operation.</summary>
    [JsonPropertyName("lastScheduleTime")]
    public string? LastScheduleTime { get; set; }

    /// <summary>LastSuccessfulTime is the last time the WatchOperation successfully completed an Operation.</summary>
    [JsonPropertyName("lastSuccessfulTime")]
    public string? LastSuccessfulTime { get; set; }

    /// <summary>RunningOperationRefs is a list of currently running Operations.</summary>
    [JsonPropertyName("runningOperationRefs")]
    public IList<V1alpha1WatchOperationStatusRunningOperationRefs>? RunningOperationRefs { get; set; }

    /// <summary>WatchingResources is the number of resources this WatchOperation is currently watching.</summary>
    [JsonPropertyName("watchingResources")]
    public long? WatchingResources { get; set; }
}

/// <summary>A WatchOperation creates Operations when watched resources change.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1WatchOperation : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1WatchOperationSpec>, IStatus<V1alpha1WatchOperationStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "WatchOperation";
    public const string KubeGroup = "ops.crossplane.io";
    public const string KubePluralName = "watchoperations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WatchOperationSpec specifies the desired state of a WatchOperation.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1WatchOperationSpec? Spec { get; set; }

    /// <summary>WatchOperationStatus represents the observed state of a WatchOperation.</summary>
    [JsonPropertyName("status")]
    public V1alpha1WatchOperationStatus? Status { get; set; }
}