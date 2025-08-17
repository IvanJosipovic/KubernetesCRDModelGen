using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ops.crossplane.io;
#nullable enable
/// <summary>An Operation defines a pipeline of functions that together constitute a day two operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1OperationList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Operation>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "OperationList";
    public const string KubeGroup = "ops.crossplane.io";
    public const string KubePluralName = "operations";
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
    public IList<V1alpha1Operation> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A SecretRef is a reference to a secret containing credentials that should be supplied to the function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OperationSpecPipelineCredentialsSecretRef
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
/// <summary>FunctionCredentials are optional credentials that a function needs to run.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OperationSpecPipelineCredentials
{
    /// <summary>Name of this set of credentials.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>A SecretRef is a reference to a secret containing credentials that should be supplied to the function.</summary>
    [JsonPropertyName("secretRef")]
    public V1alpha1OperationSpecPipelineCredentialsSecretRef? SecretRef { get; set; }

    /// <summary>Source of the function credentials.</summary>
    [JsonPropertyName("source")]
    public string Source { get; set; }
}
#nullable disable

#nullable enable
/// <summary>FunctionRef is a reference to the function this step should execute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OperationSpecPipelineFunctionRef
{
    /// <summary>Name of the referenced function.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>RequiredResourceSelector selects resources that should be fetched before a pipeline step runs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OperationSpecPipelineRequirementsRequiredResources
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
#nullable disable

#nullable enable
/// <summary>Requirements are resource requirements that will be satisfied before this pipeline step is called for the first time. This allows pre-populating required resources without requiring a function to request them first.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OperationSpecPipelineRequirements
{
    /// <summary>RequiredResources that will be fetched before this pipeline step is called for the first time.</summary>
    [JsonPropertyName("requiredResources")]
    public IList<V1alpha1OperationSpecPipelineRequirementsRequiredResources>? RequiredResources { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A PipelineStep in an operation function pipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OperationSpecPipeline
{
    /// <summary>Credentials are optional credentials that the operation function needs.</summary>
    [JsonPropertyName("credentials")]
    public IList<V1alpha1OperationSpecPipelineCredentials>? Credentials { get; set; }

    /// <summary>FunctionRef is a reference to the function this step should execute.</summary>
    [JsonPropertyName("functionRef")]
    public V1alpha1OperationSpecPipelineFunctionRef FunctionRef { get; set; }

    /// <summary>Input is an optional, arbitrary Kubernetes resource (i.e. a resource with an apiVersion and kind) that will be passed to the unction as the 'input' of its RunFunctionRequest.</summary>
    [JsonPropertyName("input")]
    public JsonNode? Input { get; set; }

    /// <summary>Requirements are resource requirements that will be satisfied before this pipeline step is called for the first time. This allows pre-populating required resources without requiring a function to request them first.</summary>
    [JsonPropertyName("requirements")]
    public V1alpha1OperationSpecPipelineRequirements? Requirements { get; set; }

    /// <summary>Step name. Must be unique within its Pipeline.</summary>
    [JsonPropertyName("step")]
    public string Step { get; set; }
}
#nullable disable

#nullable enable
/// <summary>OperationSpec specifies desired state of an operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OperationSpec
{
    /// <summary>Mode controls what type or "mode" of operation will be used.  "Pipeline" indicates that an Operation specifies a pipeline of functions, each of which is responsible for implementing its logic.</summary>
    [JsonPropertyName("mode")]
    public string Mode { get; set; }

    /// <summary>Pipeline is a list of operation function steps that will be used when this operation runs.</summary>
    [JsonPropertyName("pipeline")]
    public IList<V1alpha1OperationSpecPipeline> Pipeline { get; set; }

    /// <summary>RetryLimit configures how many times the operation may fail. When the failure limit is exceeded, the operation will not be retried.</summary>
    [JsonPropertyName("retryLimit")]
    public long? RetryLimit { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An AppliedResourceRef is a reference to a resource an Operation applied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OperationStatusAppliedResourceRefs
{
    /// <summary>APIVersion of the applied resource.</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary>Kind of the applied resource.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the applied resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the applied resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OperationStatusConditions
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
/// <summary>PipelineStepStatus represents the status of an individual pipeline step.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OperationStatusPipeline
{
    /// <summary>Output of this step.</summary>
    [JsonPropertyName("output")]
    public JsonNode? Output { get; set; }

    /// <summary>Step name. Unique within its Pipeline.</summary>
    [JsonPropertyName("step")]
    public string Step { get; set; }
}
#nullable disable

#nullable enable
/// <summary>OperationStatus represents the observed state of an operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1OperationStatus
{
    /// <summary>AppliedResourceRefs references all resources the Operation applied.</summary>
    [JsonPropertyName("appliedResourceRefs")]
    public IList<V1alpha1OperationStatusAppliedResourceRefs>? AppliedResourceRefs { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1OperationStatusConditions>? Conditions { get; set; }

    /// <summary>Number of operation failures.</summary>
    [JsonPropertyName("failures")]
    public long? Failures { get; set; }

    /// <summary>Pipeline represents the output of the pipeline steps that this operation ran.</summary>
    [JsonPropertyName("pipeline")]
    public IList<V1alpha1OperationStatusPipeline>? Pipeline { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An Operation defines a pipeline of functions that together constitute a day two operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Operation : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1OperationSpec>, IStatus<V1alpha1OperationStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Operation";
    public const string KubeGroup = "ops.crossplane.io";
    public const string KubePluralName = "operations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>OperationSpec specifies desired state of an operation.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1OperationSpec? Spec { get; set; }

    /// <summary>OperationStatus represents the observed state of an operation.</summary>
    [JsonPropertyName("status")]
    public V1alpha1OperationStatus? Status { get; set; }
}
#nullable disable
