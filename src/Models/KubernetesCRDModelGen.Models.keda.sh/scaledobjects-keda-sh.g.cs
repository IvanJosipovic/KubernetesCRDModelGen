using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.keda.sh;
/// <summary>HPAScalingPolicy is a single policy which must hold true for a specified past interval.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectSpecAdvancedHorizontalPodAutoscalerConfigBehaviorScaleDownPolicies
{
    /// <summary>periodSeconds specifies the window of time for which the policy should hold true. PeriodSeconds must be greater than zero and less than or equal to 1800 (30 min).</summary>
    [JsonPropertyName("periodSeconds")]
    public int PeriodSeconds { get; set; }

    /// <summary>type is used to specify the scaling policy.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>value contains the amount of change which is permitted by the policy. It must be greater than zero</summary>
    [JsonPropertyName("value")]
    public int Value { get; set; }
}

/// <summary>scaleDown is scaling policy for scaling Down. If not set, the default value is to allow to scale down to minReplicas pods, with a 300 second stabilization window (i.e., the highest recommendation for the last 300sec is used).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectSpecAdvancedHorizontalPodAutoscalerConfigBehaviorScaleDown
{
    /// <summary>policies is a list of potential scaling polices which can be used during scaling. At least one policy must be specified, otherwise the HPAScalingRules will be discarded as invalid</summary>
    [JsonPropertyName("policies")]
    public IList<V1alpha1ScaledObjectSpecAdvancedHorizontalPodAutoscalerConfigBehaviorScaleDownPolicies>? Policies { get; set; }

    /// <summary>selectPolicy is used to specify which policy should be used. If not set, the default value Max is used.</summary>
    [JsonPropertyName("selectPolicy")]
    public string? SelectPolicy { get; set; }

    /// <summary>stabilizationWindowSeconds is the number of seconds for which past recommendations should be considered while scaling up or scaling down. StabilizationWindowSeconds must be greater than or equal to zero and less than or equal to 3600 (one hour). If not set, use the default values: - For scale up: 0 (i.e. no stabilization is done). - For scale down: 300 (i.e. the stabilization window is 300 seconds long).</summary>
    [JsonPropertyName("stabilizationWindowSeconds")]
    public int? StabilizationWindowSeconds { get; set; }
}

/// <summary>HPAScalingPolicy is a single policy which must hold true for a specified past interval.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectSpecAdvancedHorizontalPodAutoscalerConfigBehaviorScaleUpPolicies
{
    /// <summary>periodSeconds specifies the window of time for which the policy should hold true. PeriodSeconds must be greater than zero and less than or equal to 1800 (30 min).</summary>
    [JsonPropertyName("periodSeconds")]
    public int PeriodSeconds { get; set; }

    /// <summary>type is used to specify the scaling policy.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>value contains the amount of change which is permitted by the policy. It must be greater than zero</summary>
    [JsonPropertyName("value")]
    public int Value { get; set; }
}

/// <summary>scaleUp is scaling policy for scaling Up. If not set, the default value is the higher of:   * increase no more than 4 pods per 60 seconds   * double the number of pods per 60 seconds No stabilization is used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectSpecAdvancedHorizontalPodAutoscalerConfigBehaviorScaleUp
{
    /// <summary>policies is a list of potential scaling polices which can be used during scaling. At least one policy must be specified, otherwise the HPAScalingRules will be discarded as invalid</summary>
    [JsonPropertyName("policies")]
    public IList<V1alpha1ScaledObjectSpecAdvancedHorizontalPodAutoscalerConfigBehaviorScaleUpPolicies>? Policies { get; set; }

    /// <summary>selectPolicy is used to specify which policy should be used. If not set, the default value Max is used.</summary>
    [JsonPropertyName("selectPolicy")]
    public string? SelectPolicy { get; set; }

    /// <summary>stabilizationWindowSeconds is the number of seconds for which past recommendations should be considered while scaling up or scaling down. StabilizationWindowSeconds must be greater than or equal to zero and less than or equal to 3600 (one hour). If not set, use the default values: - For scale up: 0 (i.e. no stabilization is done). - For scale down: 300 (i.e. the stabilization window is 300 seconds long).</summary>
    [JsonPropertyName("stabilizationWindowSeconds")]
    public int? StabilizationWindowSeconds { get; set; }
}

/// <summary>HorizontalPodAutoscalerBehavior configures the scaling behavior of the target in both Up and Down directions (scaleUp and scaleDown fields respectively).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectSpecAdvancedHorizontalPodAutoscalerConfigBehavior
{
    /// <summary>scaleDown is scaling policy for scaling Down. If not set, the default value is to allow to scale down to minReplicas pods, with a 300 second stabilization window (i.e., the highest recommendation for the last 300sec is used).</summary>
    [JsonPropertyName("scaleDown")]
    public V1alpha1ScaledObjectSpecAdvancedHorizontalPodAutoscalerConfigBehaviorScaleDown? ScaleDown { get; set; }

    /// <summary>scaleUp is scaling policy for scaling Up. If not set, the default value is the higher of:   * increase no more than 4 pods per 60 seconds   * double the number of pods per 60 seconds No stabilization is used.</summary>
    [JsonPropertyName("scaleUp")]
    public V1alpha1ScaledObjectSpecAdvancedHorizontalPodAutoscalerConfigBehaviorScaleUp? ScaleUp { get; set; }
}

/// <summary>HorizontalPodAutoscalerConfig specifies horizontal scale config</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectSpecAdvancedHorizontalPodAutoscalerConfig
{
    /// <summary>HorizontalPodAutoscalerBehavior configures the scaling behavior of the target in both Up and Down directions (scaleUp and scaleDown fields respectively).</summary>
    [JsonPropertyName("behavior")]
    public V1alpha1ScaledObjectSpecAdvancedHorizontalPodAutoscalerConfigBehavior? Behavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ScalingModifiers describes advanced scaling logic options like formula</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectSpecAdvancedScalingModifiers
{
    /// <summary></summary>
    [JsonPropertyName("activationTarget")]
    public string? ActivationTarget { get; set; }

    /// <summary></summary>
    [JsonPropertyName("formula")]
    public string? Formula { get; set; }

    /// <summary>MetricTargetType specifies the type of metric being targeted, and should be either "Value", "AverageValue", or "Utilization"</summary>
    [JsonPropertyName("metricType")]
    public string? MetricType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>AdvancedConfig specifies advance scaling options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectSpecAdvanced
{
    /// <summary>HorizontalPodAutoscalerConfig specifies horizontal scale config</summary>
    [JsonPropertyName("horizontalPodAutoscalerConfig")]
    public V1alpha1ScaledObjectSpecAdvancedHorizontalPodAutoscalerConfig? HorizontalPodAutoscalerConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restoreToOriginalReplicaCount")]
    public bool? RestoreToOriginalReplicaCount { get; set; }

    /// <summary>ScalingModifiers describes advanced scaling logic options like formula</summary>
    [JsonPropertyName("scalingModifiers")]
    public V1alpha1ScaledObjectSpecAdvancedScalingModifiers? ScalingModifiers { get; set; }
}

/// <summary>Fallback is the spec for fallback options</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectSpecFallback
{
    /// <summary></summary>
    [JsonPropertyName("behavior")]
    public string? Behavior { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failureThreshold")]
    public int FailureThreshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("replicas")]
    public int Replicas { get; set; }
}

/// <summary>ScaleTarget holds the reference to the scale target Object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectSpecScaleTargetRef
{
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("envSourceContainerName")]
    public string? EnvSourceContainerName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>AuthenticationRef points to the TriggerAuthentication or ClusterTriggerAuthentication object that is used to authenticate the scaler with the environment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectSpecTriggersAuthenticationRef
{
    /// <summary>Kind of the resource being referred to. Defaults to TriggerAuthentication.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ScaleTriggers reference the scaler that will be used</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectSpecTriggers
{
    /// <summary>AuthenticationRef points to the TriggerAuthentication or ClusterTriggerAuthentication object that is used to authenticate the scaler with the environment</summary>
    [JsonPropertyName("authenticationRef")]
    public V1alpha1ScaledObjectSpecTriggersAuthenticationRef? AuthenticationRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string> Metadata { get; set; }

    /// <summary>MetricTargetType specifies the type of metric being targeted, and should be either "Value", "AverageValue", or "Utilization"</summary>
    [JsonPropertyName("metricType")]
    public string? MetricType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useCachedMetrics")]
    public bool? UseCachedMetrics { get; set; }
}

/// <summary>ScaledObjectSpec is the spec for a ScaledObject resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectSpec
{
    /// <summary>AdvancedConfig specifies advance scaling options</summary>
    [JsonPropertyName("advanced")]
    public V1alpha1ScaledObjectSpecAdvanced? Advanced { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cooldownPeriod")]
    public int? CooldownPeriod { get; set; }

    /// <summary>Fallback is the spec for fallback options</summary>
    [JsonPropertyName("fallback")]
    public V1alpha1ScaledObjectSpecFallback? Fallback { get; set; }

    /// <summary></summary>
    [JsonPropertyName("idleReplicaCount")]
    public int? IdleReplicaCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initialCooldownPeriod")]
    public int? InitialCooldownPeriod { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxReplicaCount")]
    public int? MaxReplicaCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minReplicaCount")]
    public int? MinReplicaCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pollingInterval")]
    public int? PollingInterval { get; set; }

    /// <summary>ScaleTarget holds the reference to the scale target Object</summary>
    [JsonPropertyName("scaleTargetRef")]
    public V1alpha1ScaledObjectSpecScaleTargetRef ScaleTargetRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("triggers")]
    public IList<V1alpha1ScaledObjectSpecTriggers> Triggers { get; set; }
}

/// <summary>Condition to store the condition state</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectStatusConditions
{
    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of condition</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>HealthStatus is the status for a ScaledObject's health</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectStatusHealth
{
    /// <summary></summary>
    [JsonPropertyName("numberOfFailures")]
    public int? NumberOfFailures { get; set; }

    /// <summary>HealthStatusType is an indication of whether the health status is happy or failing</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>GroupVersionKindResource provides unified structure for schema.GroupVersionKind and Resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectStatusScaleTargetGVKR
{
    /// <summary></summary>
    [JsonPropertyName("group")]
    public string Group { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resource")]
    public string Resource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string Version { get; set; }
}

/// <summary>ScaledObjectStatus is the status for a ScaledObject resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScaledObjectStatus
{
    /// <summary></summary>
    [JsonPropertyName("authenticationsTypes")]
    public string? AuthenticationsTypes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("compositeScalerName")]
    public string? CompositeScalerName { get; set; }

    /// <summary>Conditions an array representation to store multiple Conditions</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ScaledObjectStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("externalMetricNames")]
    public IList<string>? ExternalMetricNames { get; set; }

    /// <summary></summary>
    [JsonPropertyName("health")]
    public IDictionary<string, V1alpha1ScaledObjectStatusHealth>? Health { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hpaName")]
    public string? HpaName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastActiveTime")]
    public string? LastActiveTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalReplicaCount")]
    public int? OriginalReplicaCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pausedReplicaCount")]
    public int? PausedReplicaCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceMetricNames")]
    public IList<string>? ResourceMetricNames { get; set; }

    /// <summary>GroupVersionKindResource provides unified structure for schema.GroupVersionKind and Resource</summary>
    [JsonPropertyName("scaleTargetGVKR")]
    public V1alpha1ScaledObjectStatusScaleTargetGVKR? ScaleTargetGVKR { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scaleTargetKind")]
    public string? ScaleTargetKind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("triggersTypes")]
    public string? TriggersTypes { get; set; }
}

/// <summary>ScaledObject is a specification for a ScaledObject resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ScaledObject : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ScaledObjectSpec>, IStatus<V1alpha1ScaledObjectStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ScaledObject";
    public const string KubeGroup = "keda.sh";
    public const string KubePluralName = "scaledobjects";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ScaledObjectSpec is the spec for a ScaledObject resource</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ScaledObjectSpec Spec { get; set; }

    /// <summary>ScaledObjectStatus is the status for a ScaledObject resource</summary>
    [JsonPropertyName("status")]
    public V1alpha1ScaledObjectStatus? Status { get; set; }
}

/// <summary>ScaledObject is a specification for a ScaledObject resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ScaledObjectList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ScaledObject>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ScaledObjectList";
    public const string KubeGroup = "keda.sh";
    public const string KubePluralName = "scaledobjects";
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
    public IList<V1alpha1ScaledObject> Items { get; set; }
}