using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.batch.cnrm.cloud.google.com;
#nullable enable
/// <summary>BatchTask is the Schema for the BatchTask API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BatchTaskList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1BatchTask>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BatchTaskList";
    public const string KubeGroup = "batch.cnrm.cloud.google.com";
    public const string KubePluralName = "batchtasks";
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
    public IList<V1alpha1BatchTask> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchTaskSpecProjectRef
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
#nullable disable

#nullable enable
/// <summary>BatchTaskSpec defines the desired state of BatchTask</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchTaskSpec
{
    /// <summary>Immutable. The location where the alloydb cluster should reside.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1BatchTaskSpecProjectRef ProjectRef { get; set; }

    /// <summary>The BatchTask name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchTaskStatusConditions
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
#nullable disable

#nullable enable
/// <summary>Task Execution. This field is only defined for task-level status events where the task fails.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchTaskStatusObservedStateStatusStatusEventsTaskExecution
{
    /// <summary>The exit code of a finished task.   If the task succeeded, the exit code will be 0. If the task failed but not  due to the following reasons, the exit code will be 50000.   Otherwise, it can be from different sources:  * Batch known failures:  https://cloud.google.com/batch/docs/troubleshooting#reserved-exit-codes.  * Batch runnable execution failures; you can rely on Batch logs to further  diagnose: https://cloud.google.com/batch/docs/analyze-job-using-logs. If  there are multiple runnables failures, Batch only exposes the first error.</summary>
    [JsonPropertyName("exitCode")]
    public int? ExitCode { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchTaskStatusObservedStateStatusStatusEvents
{
    /// <summary>Description of the event.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The time this event occurred.</summary>
    [JsonPropertyName("eventTime")]
    public string? EventTime { get; set; }

    /// <summary>Task Execution. This field is only defined for task-level status events where the task fails.</summary>
    [JsonPropertyName("taskExecution")]
    public V1alpha1BatchTaskStatusObservedStateStatusStatusEventsTaskExecution? TaskExecution { get; set; }

    /// <summary>Task State. This field is only defined for task-level status events.</summary>
    [JsonPropertyName("taskState")]
    public string? TaskState { get; set; }

    /// <summary>Type of the event.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Task Status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchTaskStatusObservedStateStatus
{
    /// <summary>Task state.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Detailed info about why the state is reached.</summary>
    [JsonPropertyName("statusEvents")]
    public IList<V1alpha1BatchTaskStatusObservedStateStatusStatusEvents>? StatusEvents { get; set; }
}
#nullable disable

#nullable enable
/// <summary>BatchTaskObservedState is the state of the BatchTask resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchTaskStatusObservedState
{
    /// <summary>Task Status.</summary>
    [JsonPropertyName("status")]
    public V1alpha1BatchTaskStatusObservedStateStatus? Status { get; set; }
}
#nullable disable

#nullable enable
/// <summary>BatchTaskStatus defines the config connector machine state of BatchTask</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BatchTaskStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BatchTaskStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the BatchTask resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>Task name. The name is generated from the parent TaskGroup name and 'id' field. For example: "projects/123456/locations/us-west1/jobs/job01/taskGroups/group01/tasks/task01".</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>BatchTaskObservedState is the state of the BatchTask resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1BatchTaskStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>BatchTask is the Schema for the BatchTask API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BatchTask : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BatchTaskSpec>, IStatus<V1alpha1BatchTaskStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BatchTask";
    public const string KubeGroup = "batch.cnrm.cloud.google.com";
    public const string KubePluralName = "batchtasks";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BatchTaskSpec defines the desired state of BatchTask</summary>
    [JsonPropertyName("spec")]
    public V1alpha1BatchTaskSpec Spec { get; set; }

    /// <summary>BatchTaskStatus defines the config connector machine state of BatchTask</summary>
    [JsonPropertyName("status")]
    public V1alpha1BatchTaskStatus? Status { get; set; }
}
#nullable disable
