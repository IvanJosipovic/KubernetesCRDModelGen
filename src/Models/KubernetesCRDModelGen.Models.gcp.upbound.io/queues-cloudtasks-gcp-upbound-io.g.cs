using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudtasks.gcp.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1QueueSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpecForProviderAppEngineRoutingOverride
{
    /// <summary>App instance. By default, the task is sent to an instance which is available when the task is attempted.</summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>App service. By default, the task is sent to the service which is the default service when the task is attempted.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>App version. By default, the task is sent to the version which is the default version when the task is attempted.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1QueueSpecForProviderProjectRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1QueueSpecForProviderProjectRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpecForProviderProjectRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1QueueSpecForProviderProjectRefPolicyResolutionEnum>))]
    public V1beta1QueueSpecForProviderProjectRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1QueueSpecForProviderProjectRefPolicyResolveEnum>))]
    public V1beta1QueueSpecForProviderProjectRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Project in cloudplatform to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpecForProviderProjectRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1QueueSpecForProviderProjectRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1QueueSpecForProviderProjectSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1QueueSpecForProviderProjectSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpecForProviderProjectSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1QueueSpecForProviderProjectSelectorPolicyResolutionEnum>))]
    public V1beta1QueueSpecForProviderProjectSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1QueueSpecForProviderProjectSelectorPolicyResolveEnum>))]
    public V1beta1QueueSpecForProviderProjectSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Project in cloudplatform to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpecForProviderProjectSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1QueueSpecForProviderProjectSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpecForProviderRateLimits
{
    /// <summary>The maximum number of concurrent tasks that Cloud Tasks allows to be dispatched for this queue. After this threshold has been reached, Cloud Tasks stops dispatching tasks until the number of concurrent requests decreases.</summary>
    [JsonPropertyName("maxConcurrentDispatches")]
    public double? MaxConcurrentDispatches { get; set; }

    /// <summary>The maximum rate at which tasks are dispatched from this queue. If unspecified when the queue is created, Cloud Tasks will pick the default.</summary>
    [JsonPropertyName("maxDispatchesPerSecond")]
    public double? MaxDispatchesPerSecond { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpecForProviderRetryConfig
{
    /// <summary>Number of attempts per task. Cloud Tasks will attempt the task maxAttempts times (that is, if the first attempt fails, then there will be maxAttempts - 1 retries). Must be &gt;= -1. If unspecified when the queue is created, Cloud Tasks will pick the default. -1 indicates unlimited attempts.</summary>
    [JsonPropertyName("maxAttempts")]
    public double? MaxAttempts { get; set; }

    /// <summary>A task will be scheduled for retry between minBackoff and maxBackoff duration after it fails, if the queue's RetryConfig specifies that the task should be retried.</summary>
    [JsonPropertyName("maxBackoff")]
    public string? MaxBackoff { get; set; }

    /// <summary>The time between retries will double maxDoublings times. A task's retry interval starts at minBackoff, then doubles maxDoublings times, then increases linearly, and finally retries retries at intervals of maxBackoff up to maxAttempts times.</summary>
    [JsonPropertyName("maxDoublings")]
    public double? MaxDoublings { get; set; }

    /// <summary>If positive, maxRetryDuration specifies the time limit for retrying a failed task, measured from when the task was first attempted. Once maxRetryDuration time has passed and the task has been attempted maxAttempts times, no further attempts will be made and the task will be deleted. If zero, then the task age is unlimited.</summary>
    [JsonPropertyName("maxRetryDuration")]
    public string? MaxRetryDuration { get; set; }

    /// <summary>A task will be scheduled for retry between minBackoff and maxBackoff duration after it fails, if the queue's RetryConfig specifies that the task should be retried.</summary>
    [JsonPropertyName("minBackoff")]
    public string? MinBackoff { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpecForProviderStackdriverLoggingConfig
{
    /// <summary>Specifies the fraction of operations to write to Stackdriver Logging. This field may contain any value between 0.0 and 1.0, inclusive. 0.0 is the default and means that no operations are logged.</summary>
    [JsonPropertyName("samplingRatio")]
    public double? SamplingRatio { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpecForProvider
{
    /// <summary>Overrides for task-level appEngineRouting. These settings apply only to App Engine tasks in this queue Structure is documented below.</summary>
    [JsonPropertyName("appEngineRoutingOverride")]
    public IList<V1beta1QueueSpecForProviderAppEngineRoutingOverride>? AppEngineRoutingOverride { get; set; }

    /// <summary>The location of the queue</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Reference to a Project in cloudplatform to populate project.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1QueueSpecForProviderProjectRef? ProjectRef { get; set; }

    /// <summary>Selector for a Project in cloudplatform to populate project.</summary>
    [JsonPropertyName("projectSelector")]
    public V1beta1QueueSpecForProviderProjectSelector? ProjectSelector { get; set; }

    /// <summary>Rate limits for task dispatches. The queue's actual dispatch rate is the result of:</summary>
    [JsonPropertyName("rateLimits")]
    public IList<V1beta1QueueSpecForProviderRateLimits>? RateLimits { get; set; }

    /// <summary>Settings that determine the retry behavior. Structure is documented below.</summary>
    [JsonPropertyName("retryConfig")]
    public IList<V1beta1QueueSpecForProviderRetryConfig>? RetryConfig { get; set; }

    /// <summary>Configuration options for writing logs to Stackdriver Logging. Structure is documented below.</summary>
    [JsonPropertyName("stackdriverLoggingConfig")]
    public IList<V1beta1QueueSpecForProviderStackdriverLoggingConfig>? StackdriverLoggingConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpecInitProviderAppEngineRoutingOverride
{
    /// <summary>App instance. By default, the task is sent to an instance which is available when the task is attempted.</summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>App service. By default, the task is sent to the service which is the default service when the task is attempted.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>App version. By default, the task is sent to the version which is the default version when the task is attempted.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1QueueSpecInitProviderProjectRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1QueueSpecInitProviderProjectRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpecInitProviderProjectRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1QueueSpecInitProviderProjectRefPolicyResolutionEnum>))]
    public V1beta1QueueSpecInitProviderProjectRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1QueueSpecInitProviderProjectRefPolicyResolveEnum>))]
    public V1beta1QueueSpecInitProviderProjectRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Project in cloudplatform to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpecInitProviderProjectRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1QueueSpecInitProviderProjectRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1QueueSpecInitProviderProjectSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1QueueSpecInitProviderProjectSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpecInitProviderProjectSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1QueueSpecInitProviderProjectSelectorPolicyResolutionEnum>))]
    public V1beta1QueueSpecInitProviderProjectSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1QueueSpecInitProviderProjectSelectorPolicyResolveEnum>))]
    public V1beta1QueueSpecInitProviderProjectSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Project in cloudplatform to populate project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpecInitProviderProjectSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1QueueSpecInitProviderProjectSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpecInitProviderRateLimits
{
    /// <summary>The maximum number of concurrent tasks that Cloud Tasks allows to be dispatched for this queue. After this threshold has been reached, Cloud Tasks stops dispatching tasks until the number of concurrent requests decreases.</summary>
    [JsonPropertyName("maxConcurrentDispatches")]
    public double? MaxConcurrentDispatches { get; set; }

    /// <summary>The maximum rate at which tasks are dispatched from this queue. If unspecified when the queue is created, Cloud Tasks will pick the default.</summary>
    [JsonPropertyName("maxDispatchesPerSecond")]
    public double? MaxDispatchesPerSecond { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpecInitProviderRetryConfig
{
    /// <summary>Number of attempts per task. Cloud Tasks will attempt the task maxAttempts times (that is, if the first attempt fails, then there will be maxAttempts - 1 retries). Must be &gt;= -1. If unspecified when the queue is created, Cloud Tasks will pick the default. -1 indicates unlimited attempts.</summary>
    [JsonPropertyName("maxAttempts")]
    public double? MaxAttempts { get; set; }

    /// <summary>A task will be scheduled for retry between minBackoff and maxBackoff duration after it fails, if the queue's RetryConfig specifies that the task should be retried.</summary>
    [JsonPropertyName("maxBackoff")]
    public string? MaxBackoff { get; set; }

    /// <summary>The time between retries will double maxDoublings times. A task's retry interval starts at minBackoff, then doubles maxDoublings times, then increases linearly, and finally retries retries at intervals of maxBackoff up to maxAttempts times.</summary>
    [JsonPropertyName("maxDoublings")]
    public double? MaxDoublings { get; set; }

    /// <summary>If positive, maxRetryDuration specifies the time limit for retrying a failed task, measured from when the task was first attempted. Once maxRetryDuration time has passed and the task has been attempted maxAttempts times, no further attempts will be made and the task will be deleted. If zero, then the task age is unlimited.</summary>
    [JsonPropertyName("maxRetryDuration")]
    public string? MaxRetryDuration { get; set; }

    /// <summary>A task will be scheduled for retry between minBackoff and maxBackoff duration after it fails, if the queue's RetryConfig specifies that the task should be retried.</summary>
    [JsonPropertyName("minBackoff")]
    public string? MinBackoff { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpecInitProviderStackdriverLoggingConfig
{
    /// <summary>Specifies the fraction of operations to write to Stackdriver Logging. This field may contain any value between 0.0 and 1.0, inclusive. 0.0 is the default and means that no operations are logged.</summary>
    [JsonPropertyName("samplingRatio")]
    public double? SamplingRatio { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpecInitProvider
{
    /// <summary>Overrides for task-level appEngineRouting. These settings apply only to App Engine tasks in this queue Structure is documented below.</summary>
    [JsonPropertyName("appEngineRoutingOverride")]
    public IList<V1beta1QueueSpecInitProviderAppEngineRoutingOverride>? AppEngineRoutingOverride { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Reference to a Project in cloudplatform to populate project.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1QueueSpecInitProviderProjectRef? ProjectRef { get; set; }

    /// <summary>Selector for a Project in cloudplatform to populate project.</summary>
    [JsonPropertyName("projectSelector")]
    public V1beta1QueueSpecInitProviderProjectSelector? ProjectSelector { get; set; }

    /// <summary>Rate limits for task dispatches. The queue's actual dispatch rate is the result of:</summary>
    [JsonPropertyName("rateLimits")]
    public IList<V1beta1QueueSpecInitProviderRateLimits>? RateLimits { get; set; }

    /// <summary>Settings that determine the retry behavior. Structure is documented below.</summary>
    [JsonPropertyName("retryConfig")]
    public IList<V1beta1QueueSpecInitProviderRetryConfig>? RetryConfig { get; set; }

    /// <summary>Configuration options for writing logs to Stackdriver Logging. Structure is documented below.</summary>
    [JsonPropertyName("stackdriverLoggingConfig")]
    public IList<V1beta1QueueSpecInitProviderStackdriverLoggingConfig>? StackdriverLoggingConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1QueueSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    /// <summary>Observe</summary>
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    /// <summary>Create</summary>
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    /// <summary>Update</summary>
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    /// <summary>LateInitialize</summary>
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    /// <summary>*</summary>
    Option5
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1QueueSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1QueueSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1QueueSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1QueueSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1QueueSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1QueueSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1QueueSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1QueueSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1QueueSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1QueueSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1QueueSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1QueueSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1QueueSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1QueueSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpecPublishConnectionDetailsToMetadata
{
    /// <summary>Annotations are the annotations to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.annotations". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels are the labels/tags to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.labels". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Type is the SecretType for the connection secret. - Only valid for Kubernetes Secret Stores.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1QueueSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1QueueSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>QueueSpec defines the desired state of Queue</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1QueueSpecDeletionPolicyEnum>))]
    public V1beta1QueueSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1QueueSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1QueueSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1QueueSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1QueueSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1QueueSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1QueueSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueStatusAtProviderAppEngineRoutingOverride
{
    /// <summary>(Output) The host that the task is sent to.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>App instance. By default, the task is sent to an instance which is available when the task is attempted.</summary>
    [JsonPropertyName("instance")]
    public string? Instance { get; set; }

    /// <summary>App service. By default, the task is sent to the service which is the default service when the task is attempted.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>App version. By default, the task is sent to the version which is the default version when the task is attempted.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueStatusAtProviderRateLimits
{
    /// <summary>(Output) The max burst size. Max burst size limits how fast tasks in queue are processed when many tasks are in the queue and the rate is high. This field allows the queue to have a high rate so processing starts shortly after a task is enqueued, but still limits resource usage when many tasks are enqueued in a short period of time.</summary>
    [JsonPropertyName("maxBurstSize")]
    public double? MaxBurstSize { get; set; }

    /// <summary>The maximum number of concurrent tasks that Cloud Tasks allows to be dispatched for this queue. After this threshold has been reached, Cloud Tasks stops dispatching tasks until the number of concurrent requests decreases.</summary>
    [JsonPropertyName("maxConcurrentDispatches")]
    public double? MaxConcurrentDispatches { get; set; }

    /// <summary>The maximum rate at which tasks are dispatched from this queue. If unspecified when the queue is created, Cloud Tasks will pick the default.</summary>
    [JsonPropertyName("maxDispatchesPerSecond")]
    public double? MaxDispatchesPerSecond { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueStatusAtProviderRetryConfig
{
    /// <summary>Number of attempts per task. Cloud Tasks will attempt the task maxAttempts times (that is, if the first attempt fails, then there will be maxAttempts - 1 retries). Must be &gt;= -1. If unspecified when the queue is created, Cloud Tasks will pick the default. -1 indicates unlimited attempts.</summary>
    [JsonPropertyName("maxAttempts")]
    public double? MaxAttempts { get; set; }

    /// <summary>A task will be scheduled for retry between minBackoff and maxBackoff duration after it fails, if the queue's RetryConfig specifies that the task should be retried.</summary>
    [JsonPropertyName("maxBackoff")]
    public string? MaxBackoff { get; set; }

    /// <summary>The time between retries will double maxDoublings times. A task's retry interval starts at minBackoff, then doubles maxDoublings times, then increases linearly, and finally retries retries at intervals of maxBackoff up to maxAttempts times.</summary>
    [JsonPropertyName("maxDoublings")]
    public double? MaxDoublings { get; set; }

    /// <summary>If positive, maxRetryDuration specifies the time limit for retrying a failed task, measured from when the task was first attempted. Once maxRetryDuration time has passed and the task has been attempted maxAttempts times, no further attempts will be made and the task will be deleted. If zero, then the task age is unlimited.</summary>
    [JsonPropertyName("maxRetryDuration")]
    public string? MaxRetryDuration { get; set; }

    /// <summary>A task will be scheduled for retry between minBackoff and maxBackoff duration after it fails, if the queue's RetryConfig specifies that the task should be retried.</summary>
    [JsonPropertyName("minBackoff")]
    public string? MinBackoff { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueStatusAtProviderStackdriverLoggingConfig
{
    /// <summary>Specifies the fraction of operations to write to Stackdriver Logging. This field may contain any value between 0.0 and 1.0, inclusive. 0.0 is the default and means that no operations are logged.</summary>
    [JsonPropertyName("samplingRatio")]
    public double? SamplingRatio { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueStatusAtProvider
{
    /// <summary>Overrides for task-level appEngineRouting. These settings apply only to App Engine tasks in this queue Structure is documented below.</summary>
    [JsonPropertyName("appEngineRoutingOverride")]
    public IList<V1beta1QueueStatusAtProviderAppEngineRoutingOverride>? AppEngineRoutingOverride { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/queues/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The location of the queue</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Rate limits for task dispatches. The queue's actual dispatch rate is the result of:</summary>
    [JsonPropertyName("rateLimits")]
    public IList<V1beta1QueueStatusAtProviderRateLimits>? RateLimits { get; set; }

    /// <summary>Settings that determine the retry behavior. Structure is documented below.</summary>
    [JsonPropertyName("retryConfig")]
    public IList<V1beta1QueueStatusAtProviderRetryConfig>? RetryConfig { get; set; }

    /// <summary>Configuration options for writing logs to Stackdriver Logging. Structure is documented below.</summary>
    [JsonPropertyName("stackdriverLoggingConfig")]
    public IList<V1beta1QueueStatusAtProviderStackdriverLoggingConfig>? StackdriverLoggingConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueStatusConditions
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

/// <summary>QueueStatus defines the observed state of Queue.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1QueueStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1QueueStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1QueueStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Queue is the Schema for the Queues API. A named resource to which messages are sent by publishers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Queue : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1QueueSpec>, IStatus<V1beta1QueueStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Queue";
    public const string KubeGroup = "cloudtasks.gcp.upbound.io";
    public const string KubePluralName = "queues";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>QueueSpec defines the desired state of Queue</summary>
    [JsonPropertyName("spec")]
    public V1beta1QueueSpec Spec { get; set; }

    /// <summary>QueueStatus defines the observed state of Queue.</summary>
    [JsonPropertyName("status")]
    public V1beta1QueueStatus? Status { get; set; }
}