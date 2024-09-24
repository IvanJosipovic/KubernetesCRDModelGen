using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudtasks.cnrm.cloud.google.com;
/// <summary>Overrides for task-level appEngineRouting. These settings apply only to App Engine tasks in this queue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudTasksQueueSpecAppEngineRoutingOverride
{
    /// <summary>The host that the task is sent to.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>App instance.  By default, the task is sent to an instance which is available when the task is attempted.</summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>App service.  By default, the task is sent to the service which is the default service when the task is attempted.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>App version.  By default, the task is sent to the version which is the default version when the task is attempted.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudTasksQueueSpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Rate limits for task dispatches.  The queue's actual dispatch rate is the result of:  * Number of tasks in the queue * User-specified throttling: rateLimits, retryConfig, and the queue's state. * System throttling due to 429 (Too Many Requests) or 503 (Service   Unavailable) responses from the worker, high error rates, or to   smooth sudden large traffic spikes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudTasksQueueSpecRateLimits
{
    /// <summary>The max burst size.  Max burst size limits how fast tasks in queue are processed when many tasks are in the queue and the rate is high. This field allows the queue to have a high rate so processing starts shortly after a task is enqueued, but still limits resource usage when many tasks are enqueued in a short period of time.</summary>
    [JsonPropertyName("maxBurstSize")]
    public int? MaxBurstSize { get; set; }

    /// <summary>The maximum number of concurrent tasks that Cloud Tasks allows to be dispatched for this queue. After this threshold has been reached, Cloud Tasks stops dispatching tasks until the number of concurrent requests decreases.</summary>
    [JsonPropertyName("maxConcurrentDispatches")]
    public int? MaxConcurrentDispatches { get; set; }

    /// <summary>The maximum rate at which tasks are dispatched from this queue.  If unspecified when the queue is created, Cloud Tasks will pick the default.</summary>
    [JsonPropertyName("maxDispatchesPerSecond")]
    public double? MaxDispatchesPerSecond { get; set; }
}

/// <summary>Settings that determine the retry behavior.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudTasksQueueSpecRetryConfig
{
    /// <summary>Number of attempts per task.  Cloud Tasks will attempt the task maxAttempts times (that is, if the first attempt fails, then there will be maxAttempts - 1 retries). Must be &gt;= -1.  If unspecified when the queue is created, Cloud Tasks will pick the default.  -1 indicates unlimited attempts.</summary>
    [JsonPropertyName("maxAttempts")]
    public int? MaxAttempts { get; set; }

    /// <summary>A task will be scheduled for retry between minBackoff and maxBackoff duration after it fails, if the queue's RetryConfig specifies that the task should be retried.</summary>
    [JsonPropertyName("maxBackoff")]
    public string? MaxBackoff { get; set; }

    /// <summary>The time between retries will double maxDoublings times.  A task's retry interval starts at minBackoff, then doubles maxDoublings times, then increases linearly, and finally retries retries at intervals of maxBackoff up to maxAttempts times.</summary>
    [JsonPropertyName("maxDoublings")]
    public int? MaxDoublings { get; set; }

    /// <summary>If positive, maxRetryDuration specifies the time limit for retrying a failed task, measured from when the task was first attempted. Once maxRetryDuration time has passed and the task has been attempted maxAttempts times, no further attempts will be made and the task will be deleted.  If zero, then the task age is unlimited.</summary>
    [JsonPropertyName("maxRetryDuration")]
    public string? MaxRetryDuration { get; set; }

    /// <summary>A task will be scheduled for retry between minBackoff and maxBackoff duration after it fails, if the queue's RetryConfig specifies that the task should be retried.</summary>
    [JsonPropertyName("minBackoff")]
    public string? MinBackoff { get; set; }
}

/// <summary>Configuration options for writing logs to Stackdriver Logging.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudTasksQueueSpecStackdriverLoggingConfig
{
    /// <summary>Specifies the fraction of operations to write to Stackdriver Logging. This field may contain any value between 0.0 and 1.0, inclusive. 0.0 is the default and means that no operations are logged.</summary>
    [JsonPropertyName("samplingRatio")]
    public double SamplingRatio { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudTasksQueueSpec
{
    /// <summary>Overrides for task-level appEngineRouting. These settings apply only to App Engine tasks in this queue.</summary>
    [JsonPropertyName("appEngineRoutingOverride")]
    public V1alpha1CloudTasksQueueSpecAppEngineRoutingOverride? AppEngineRoutingOverride { get; set; }

    /// <summary>Immutable. The location of the queue.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1CloudTasksQueueSpecProjectRef ProjectRef { get; set; }

    /// <summary>Rate limits for task dispatches.  The queue's actual dispatch rate is the result of:  * Number of tasks in the queue * User-specified throttling: rateLimits, retryConfig, and the queue's state. * System throttling due to 429 (Too Many Requests) or 503 (Service   Unavailable) responses from the worker, high error rates, or to   smooth sudden large traffic spikes.</summary>
    [JsonPropertyName("rateLimits")]
    public V1alpha1CloudTasksQueueSpecRateLimits? RateLimits { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Settings that determine the retry behavior.</summary>
    [JsonPropertyName("retryConfig")]
    public V1alpha1CloudTasksQueueSpecRetryConfig? RetryConfig { get; set; }

    /// <summary>Configuration options for writing logs to Stackdriver Logging.</summary>
    [JsonPropertyName("stackdriverLoggingConfig")]
    public V1alpha1CloudTasksQueueSpecStackdriverLoggingConfig? StackdriverLoggingConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudTasksQueueStatusConditions
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudTasksQueueStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CloudTasksQueueStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudTasksQueue : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CloudTasksQueueSpec>, IStatus<V1alpha1CloudTasksQueueStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudTasksQueue";
    public const string KubeGroup = "cloudtasks.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudtasksqueues";
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
    public V1alpha1CloudTasksQueueSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1CloudTasksQueueStatus? Status { get; set; }
}