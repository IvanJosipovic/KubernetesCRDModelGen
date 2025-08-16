using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.workflowexecutions.cnrm.cloud.google.com;
/// <summary>WorkflowsExecution is the Schema for the WorkflowsExecution API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1WorkflowsExecutionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1WorkflowsExecution>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "WorkflowsExecutionList";
    public const string KubeGroup = "workflowexecutions.cnrm.cloud.google.com";
    public const string KubePluralName = "workflowsexecutions";
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
    public IList<V1alpha1WorkflowsExecution> Items { get; set; }
}

/// <summary>Required. The host project of the application.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowsExecutionSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowsExecutionSpecWorkflowRef
{
    /// <summary>A reference to an externally managed WorkflowsWorkflow resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/workflows/{{workflowID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a WorkflowsWorkflow resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a WorkflowsWorkflow resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>WorkflowsExecutionSpec defines the desired state of WorkflowsExecution</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowsExecutionSpec
{
    /// <summary>Input parameters of the execution represented as a JSON string.  The size limit is 32KB.   *Note*: If you are using the REST API directly to run your workflow, you  must escape any JSON string value of `argument`. Example:  `'{"argument":"{\"firstName\":\"FIRST\",\"lastName\":\"LAST\"}"}'`</summary>
    [JsonPropertyName("argument")]
    public string? Argument { get; set; }

    /// <summary>The call logging level associated to this execution.</summary>
    [JsonPropertyName("callLogLevel")]
    public string? CallLogLevel { get; set; }

    /// <summary>Labels associated with this execution. Labels can contain at most 64 entries. Keys and values can be no longer than 63 characters and can only contain lowercase letters, numeric characters, underscores, and dashes. Label keys must start with a letter. International characters are allowed. By default, labels are inherited from the workflow but are overridden by any labels associated with the execution.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Required. The location of the application.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Required. The host project of the application.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1WorkflowsExecutionSpecProjectRef? ProjectRef { get; set; }

    /// <summary>The WorkflowsExecution name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required.</summary>
    [JsonPropertyName("workflowRef")]
    public V1alpha1WorkflowsExecutionSpecWorkflowRef? WorkflowRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowsExecutionStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The source position information of the stack trace element.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowsExecutionStatusObservedStateErrorStackTraceElementsPosition
{
    /// <summary>The source code column position (of the line) the current instruction was generated from.</summary>
    [JsonPropertyName("column")]
    public long? Column { get; set; }

    /// <summary>The number of bytes of source code making up this stack trace element.</summary>
    [JsonPropertyName("length")]
    public long? Length { get; set; }

    /// <summary>The source code line number the current instruction was generated from.</summary>
    [JsonPropertyName("line")]
    public long? Line { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowsExecutionStatusObservedStateErrorStackTraceElements
{
    /// <summary>The source position information of the stack trace element.</summary>
    [JsonPropertyName("position")]
    public V1alpha1WorkflowsExecutionStatusObservedStateErrorStackTraceElementsPosition? Position { get; set; }

    /// <summary>The routine where the error occurred.</summary>
    [JsonPropertyName("routine")]
    public string? Routine { get; set; }

    /// <summary>The step the error occurred at.</summary>
    [JsonPropertyName("step")]
    public string? Step { get; set; }
}

/// <summary>Stack trace with detailed information of where error was generated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowsExecutionStatusObservedStateErrorStackTrace
{
    /// <summary>An array of stack elements.</summary>
    [JsonPropertyName("elements")]
    public IList<V1alpha1WorkflowsExecutionStatusObservedStateErrorStackTraceElements>? Elements { get; set; }
}

/// <summary>Output only. The error which caused the execution to finish prematurely. The value is only present if the execution's state is `FAILED` or `CANCELLED`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowsExecutionStatusObservedStateError
{
    /// <summary>Human-readable stack trace string.</summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    /// <summary>Error message and data returned represented as a JSON string.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>Stack trace with detailed information of where error was generated.</summary>
    [JsonPropertyName("stackTrace")]
    public V1alpha1WorkflowsExecutionStatusObservedStateErrorStackTrace? StackTrace { get; set; }
}

/// <summary>Output only. Error regarding the state of the Execution resource. For example, this field will have error details if the execution data is unavailable due to revoked KMS key permissions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowsExecutionStatusObservedStateStateError
{
    /// <summary>Provides specifics about the error.</summary>
    [JsonPropertyName("details")]
    public string? Details { get; set; }

    /// <summary>The type of this state error.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowsExecutionStatusObservedStateStatusCurrentSteps
{
    /// <summary>Name of a routine within the workflow.</summary>
    [JsonPropertyName("routine")]
    public string? Routine { get; set; }

    /// <summary>Name of a step within the routine.</summary>
    [JsonPropertyName("step")]
    public string? Step { get; set; }
}

/// <summary>Output only. Status tracks the current steps and progress data of this execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowsExecutionStatusObservedStateStatus
{
    /// <summary>A list of currently executing or last executed step names for the workflow execution currently running. If the workflow has succeeded or failed, this is the last attempted or executed step. Presently, if the current step is inside a subworkflow, the list only includes that step. In the future, the list will contain items for each step in the call stack, starting with the outermost step in the `main` subworkflow, and ending with the most deeply nested step.</summary>
    [JsonPropertyName("currentSteps")]
    public IList<V1alpha1WorkflowsExecutionStatusObservedStateStatusCurrentSteps>? CurrentSteps { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowsExecutionStatusObservedState
{
    /// <summary>Output only. Measures the duration of the execution.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>Output only. Marks the end of execution, successful or not.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Output only. The error which caused the execution to finish prematurely. The value is only present if the execution's state is `FAILED` or `CANCELLED`.</summary>
    [JsonPropertyName("error")]
    public V1alpha1WorkflowsExecutionStatusObservedStateError? Error { get; set; }

    /// <summary>Output only. Output of the execution represented as a JSON string. The value can only be present if the execution's state is `SUCCEEDED`.</summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }

    /// <summary>Output only. Marks the beginning of execution.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Output only. Current state of the execution.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Error regarding the state of the Execution resource. For example, this field will have error details if the execution data is unavailable due to revoked KMS key permissions.</summary>
    [JsonPropertyName("stateError")]
    public V1alpha1WorkflowsExecutionStatusObservedStateStateError? StateError { get; set; }

    /// <summary>Output only. Status tracks the current steps and progress data of this execution.</summary>
    [JsonPropertyName("status")]
    public V1alpha1WorkflowsExecutionStatusObservedStateStatus? Status { get; set; }

    /// <summary>Output only. Revision of the workflow this execution is using.</summary>
    [JsonPropertyName("workflowRevisionID")]
    public string? WorkflowRevisionID { get; set; }
}

/// <summary>WorkflowsExecutionStatus defines the config connector machine state of WorkflowsExecution</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1WorkflowsExecutionStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1WorkflowsExecutionStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the WorkflowsExecution resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1WorkflowsExecutionStatusObservedState? ObservedState { get; set; }
}

/// <summary>WorkflowsExecution is the Schema for the WorkflowsExecution API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1WorkflowsExecution : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1WorkflowsExecutionSpec>, IStatus<V1alpha1WorkflowsExecutionStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "WorkflowsExecution";
    public const string KubeGroup = "workflowexecutions.cnrm.cloud.google.com";
    public const string KubePluralName = "workflowsexecutions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WorkflowsExecutionSpec defines the desired state of WorkflowsExecution</summary>
    [JsonPropertyName("spec")]
    public V1alpha1WorkflowsExecutionSpec Spec { get; set; }

    /// <summary>WorkflowsExecutionStatus defines the config connector machine state of WorkflowsExecution</summary>
    [JsonPropertyName("status")]
    public V1alpha1WorkflowsExecutionStatus? Status { get; set; }
}