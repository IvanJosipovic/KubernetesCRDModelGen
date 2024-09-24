using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.upbound.io;
public enum V1beta1AutoscalerSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1AutoscalerSpecForProviderAutoscalingPolicyCpuUtilization
{
    /// <summary>Indicates whether predictive autoscaling based on CPU metric is enabled. Valid values are:</summary>
    [JsonPropertyName("predictiveMethod")]
    public string? PredictiveMethod { get; set; }

    /// <summary>URL of the managed instance group that this autoscaler will scale.</summary>
    [JsonPropertyName("target")]
    public double? Target { get; set; }
}

/// <summary></summary>
public partial class V1beta1AutoscalerSpecForProviderAutoscalingPolicyLoadBalancingUtilization
{
    /// <summary>URL of the managed instance group that this autoscaler will scale.</summary>
    [JsonPropertyName("target")]
    public double? Target { get; set; }
}

/// <summary></summary>
public partial class V1beta1AutoscalerSpecForProviderAutoscalingPolicyMetric
{
    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>URL of the managed instance group that this autoscaler will scale.</summary>
    [JsonPropertyName("target")]
    public double? Target { get; set; }

    /// <summary>Defines how target utilization value is expressed for a Stackdriver Monitoring metric. Possible values are: GAUGE, DELTA_PER_SECOND, DELTA_PER_MINUTE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1AutoscalerSpecForProviderAutoscalingPolicyScaleInControlMaxScaledInReplicas
{
    /// <summary>Specifies a fixed number of VM instances. This must be a positive integer.</summary>
    [JsonPropertyName("fixed")]
    public double? Fixed { get; set; }

    /// <summary>Specifies a percentage of instances between 0 to 100%, inclusive. For example, specify 80 for 80%.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary></summary>
public partial class V1beta1AutoscalerSpecForProviderAutoscalingPolicyScaleInControl
{
    /// <summary>A nested object resource Structure is documented below.</summary>
    [JsonPropertyName("maxScaledInReplicas")]
    public IList<V1beta1AutoscalerSpecForProviderAutoscalingPolicyScaleInControlMaxScaledInReplicas>? MaxScaledInReplicas { get; set; }

    /// <summary>How long back autoscaling should look when computing recommendations to include directives regarding slower scale down, as described above.</summary>
    [JsonPropertyName("timeWindowSec")]
    public double? TimeWindowSec { get; set; }
}

/// <summary></summary>
public partial class V1beta1AutoscalerSpecForProviderAutoscalingPolicyScalingSchedules
{
    /// <summary>A description of a scaling schedule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A boolean value that specifies if a scaling schedule can influence autoscaler recommendations. If set to true, then a scaling schedule has no effect.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>The duration of time intervals (in seconds) for which this scaling schedule will be running. The minimum allowed value is 300.</summary>
    [JsonPropertyName("durationSec")]
    public double? DurationSec { get; set; }

    /// <summary>Minimum number of VM instances that autoscaler will recommend in time intervals starting according to schedule.</summary>
    [JsonPropertyName("minRequiredReplicas")]
    public double? MinRequiredReplicas { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The start timestamps of time intervals when this scaling schedule should provide a scaling signal. This field uses the extended cron format (with an optional year field).</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>The time zone to be used when interpreting the schedule. The value of this field must be a time zone name from the tz database: http://en.wikipedia.org/wiki/Tz_database.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary></summary>
public partial class V1beta1AutoscalerSpecForProviderAutoscalingPolicy
{
    /// <summary>The number of seconds that the autoscaler should wait before it starts collecting information from a new instance. This prevents the autoscaler from collecting information when the instance is initializing, during which the collected usage would not be reliable. The default time autoscaler waits is 60 seconds. Virtual machine initialization times might vary because of numerous factors. We recommend that you test how long an instance may take to initialize. To do this, create an instance and time the startup process.</summary>
    [JsonPropertyName("cooldownPeriod")]
    public double? CooldownPeriod { get; set; }

    /// <summary>Defines the CPU utilization policy that allows the autoscaler to scale based on the average CPU utilization of a managed instance group. Structure is documented below.</summary>
    [JsonPropertyName("cpuUtilization")]
    public IList<V1beta1AutoscalerSpecForProviderAutoscalingPolicyCpuUtilization>? CpuUtilization { get; set; }

    /// <summary>Configuration parameters of autoscaling based on a load balancer. Structure is documented below.</summary>
    [JsonPropertyName("loadBalancingUtilization")]
    public IList<V1beta1AutoscalerSpecForProviderAutoscalingPolicyLoadBalancingUtilization>? LoadBalancingUtilization { get; set; }

    /// <summary>The maximum number of instances that the autoscaler can scale up to. This is required when creating or updating an autoscaler. The maximum number of replicas should not be lower than minimal number of replicas.</summary>
    [JsonPropertyName("maxReplicas")]
    public double? MaxReplicas { get; set; }

    /// <summary>Configuration parameters of autoscaling based on a custom metric. Structure is documented below.</summary>
    [JsonPropertyName("metric")]
    public IList<V1beta1AutoscalerSpecForProviderAutoscalingPolicyMetric>? Metric { get; set; }

    /// <summary>The minimum number of replicas that the autoscaler can scale down to. This cannot be less than 0. If not provided, autoscaler will choose a default value depending on maximum number of instances allowed.</summary>
    [JsonPropertyName("minReplicas")]
    public double? MinReplicas { get; set; }

    /// <summary>Defines operating mode for this policy.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Defines scale in controls to reduce the risk of response latency and outages due to abrupt scale-in events Structure is documented below.</summary>
    [JsonPropertyName("scaleInControl")]
    public IList<V1beta1AutoscalerSpecForProviderAutoscalingPolicyScaleInControl>? ScaleInControl { get; set; }

    /// <summary>Scaling schedules defined for an autoscaler. Multiple schedules can be set on an autoscaler and they can overlap. Structure is documented below.</summary>
    [JsonPropertyName("scalingSchedules")]
    public IList<V1beta1AutoscalerSpecForProviderAutoscalingPolicyScalingSchedules>? ScalingSchedules { get; set; }
}

public enum V1beta1AutoscalerSpecForProviderTargetRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AutoscalerSpecForProviderTargetRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AutoscalerSpecForProviderTargetRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutoscalerSpecForProviderTargetRefPolicyResolutionEnum>))]
    public V1beta1AutoscalerSpecForProviderTargetRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutoscalerSpecForProviderTargetRefPolicyResolveEnum>))]
    public V1beta1AutoscalerSpecForProviderTargetRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InstanceGroupManager in compute to populate target.</summary>
public partial class V1beta1AutoscalerSpecForProviderTargetRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AutoscalerSpecForProviderTargetRefPolicy? Policy { get; set; }
}

public enum V1beta1AutoscalerSpecForProviderTargetSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AutoscalerSpecForProviderTargetSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1AutoscalerSpecForProviderTargetSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutoscalerSpecForProviderTargetSelectorPolicyResolutionEnum>))]
    public V1beta1AutoscalerSpecForProviderTargetSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutoscalerSpecForProviderTargetSelectorPolicyResolveEnum>))]
    public V1beta1AutoscalerSpecForProviderTargetSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InstanceGroupManager in compute to populate target.</summary>
public partial class V1beta1AutoscalerSpecForProviderTargetSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AutoscalerSpecForProviderTargetSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1AutoscalerSpecForProvider
{
    /// <summary>The configuration parameters for the autoscaling algorithm. You can define one or more of the policies for an autoscaler: cpuUtilization, customMetricUtilizations, and loadBalancingUtilization. If none of these are specified, the default will be to autoscale based on cpuUtilization to 0.6 or 60%. Structure is documented below.</summary>
    [JsonPropertyName("autoscalingPolicy")]
    public IList<V1beta1AutoscalerSpecForProviderAutoscalingPolicy>? AutoscalingPolicy { get; set; }

    /// <summary>A description of a scaling schedule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>URL of the managed instance group that this autoscaler will scale.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Reference to a InstanceGroupManager in compute to populate target.</summary>
    [JsonPropertyName("targetRef")]
    public V1beta1AutoscalerSpecForProviderTargetRef? TargetRef { get; set; }

    /// <summary>Selector for a InstanceGroupManager in compute to populate target.</summary>
    [JsonPropertyName("targetSelector")]
    public V1beta1AutoscalerSpecForProviderTargetSelector? TargetSelector { get; set; }

    /// <summary>URL of the zone where the instance group resides.</summary>
    [JsonPropertyName("zone")]
    public string Zone { get; set; }
}

/// <summary></summary>
public partial class V1beta1AutoscalerSpecInitProviderAutoscalingPolicyCpuUtilization
{
    /// <summary>Indicates whether predictive autoscaling based on CPU metric is enabled. Valid values are:</summary>
    [JsonPropertyName("predictiveMethod")]
    public string? PredictiveMethod { get; set; }

    /// <summary>URL of the managed instance group that this autoscaler will scale.</summary>
    [JsonPropertyName("target")]
    public double? Target { get; set; }
}

/// <summary></summary>
public partial class V1beta1AutoscalerSpecInitProviderAutoscalingPolicyLoadBalancingUtilization
{
    /// <summary>URL of the managed instance group that this autoscaler will scale.</summary>
    [JsonPropertyName("target")]
    public double? Target { get; set; }
}

/// <summary></summary>
public partial class V1beta1AutoscalerSpecInitProviderAutoscalingPolicyMetric
{
    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>URL of the managed instance group that this autoscaler will scale.</summary>
    [JsonPropertyName("target")]
    public double? Target { get; set; }

    /// <summary>Defines how target utilization value is expressed for a Stackdriver Monitoring metric. Possible values are: GAUGE, DELTA_PER_SECOND, DELTA_PER_MINUTE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1AutoscalerSpecInitProviderAutoscalingPolicyScaleInControlMaxScaledInReplicas
{
    /// <summary>Specifies a fixed number of VM instances. This must be a positive integer.</summary>
    [JsonPropertyName("fixed")]
    public double? Fixed { get; set; }

    /// <summary>Specifies a percentage of instances between 0 to 100%, inclusive. For example, specify 80 for 80%.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary></summary>
public partial class V1beta1AutoscalerSpecInitProviderAutoscalingPolicyScaleInControl
{
    /// <summary>A nested object resource Structure is documented below.</summary>
    [JsonPropertyName("maxScaledInReplicas")]
    public IList<V1beta1AutoscalerSpecInitProviderAutoscalingPolicyScaleInControlMaxScaledInReplicas>? MaxScaledInReplicas { get; set; }

    /// <summary>How long back autoscaling should look when computing recommendations to include directives regarding slower scale down, as described above.</summary>
    [JsonPropertyName("timeWindowSec")]
    public double? TimeWindowSec { get; set; }
}

/// <summary></summary>
public partial class V1beta1AutoscalerSpecInitProviderAutoscalingPolicyScalingSchedules
{
    /// <summary>A description of a scaling schedule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A boolean value that specifies if a scaling schedule can influence autoscaler recommendations. If set to true, then a scaling schedule has no effect.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>The duration of time intervals (in seconds) for which this scaling schedule will be running. The minimum allowed value is 300.</summary>
    [JsonPropertyName("durationSec")]
    public double? DurationSec { get; set; }

    /// <summary>Minimum number of VM instances that autoscaler will recommend in time intervals starting according to schedule.</summary>
    [JsonPropertyName("minRequiredReplicas")]
    public double? MinRequiredReplicas { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The start timestamps of time intervals when this scaling schedule should provide a scaling signal. This field uses the extended cron format (with an optional year field).</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>The time zone to be used when interpreting the schedule. The value of this field must be a time zone name from the tz database: http://en.wikipedia.org/wiki/Tz_database.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary></summary>
public partial class V1beta1AutoscalerSpecInitProviderAutoscalingPolicy
{
    /// <summary>The number of seconds that the autoscaler should wait before it starts collecting information from a new instance. This prevents the autoscaler from collecting information when the instance is initializing, during which the collected usage would not be reliable. The default time autoscaler waits is 60 seconds. Virtual machine initialization times might vary because of numerous factors. We recommend that you test how long an instance may take to initialize. To do this, create an instance and time the startup process.</summary>
    [JsonPropertyName("cooldownPeriod")]
    public double? CooldownPeriod { get; set; }

    /// <summary>Defines the CPU utilization policy that allows the autoscaler to scale based on the average CPU utilization of a managed instance group. Structure is documented below.</summary>
    [JsonPropertyName("cpuUtilization")]
    public IList<V1beta1AutoscalerSpecInitProviderAutoscalingPolicyCpuUtilization>? CpuUtilization { get; set; }

    /// <summary>Configuration parameters of autoscaling based on a load balancer. Structure is documented below.</summary>
    [JsonPropertyName("loadBalancingUtilization")]
    public IList<V1beta1AutoscalerSpecInitProviderAutoscalingPolicyLoadBalancingUtilization>? LoadBalancingUtilization { get; set; }

    /// <summary>The maximum number of instances that the autoscaler can scale up to. This is required when creating or updating an autoscaler. The maximum number of replicas should not be lower than minimal number of replicas.</summary>
    [JsonPropertyName("maxReplicas")]
    public double? MaxReplicas { get; set; }

    /// <summary>Configuration parameters of autoscaling based on a custom metric. Structure is documented below.</summary>
    [JsonPropertyName("metric")]
    public IList<V1beta1AutoscalerSpecInitProviderAutoscalingPolicyMetric>? Metric { get; set; }

    /// <summary>The minimum number of replicas that the autoscaler can scale down to. This cannot be less than 0. If not provided, autoscaler will choose a default value depending on maximum number of instances allowed.</summary>
    [JsonPropertyName("minReplicas")]
    public double? MinReplicas { get; set; }

    /// <summary>Defines operating mode for this policy.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Defines scale in controls to reduce the risk of response latency and outages due to abrupt scale-in events Structure is documented below.</summary>
    [JsonPropertyName("scaleInControl")]
    public IList<V1beta1AutoscalerSpecInitProviderAutoscalingPolicyScaleInControl>? ScaleInControl { get; set; }

    /// <summary>Scaling schedules defined for an autoscaler. Multiple schedules can be set on an autoscaler and they can overlap. Structure is documented below.</summary>
    [JsonPropertyName("scalingSchedules")]
    public IList<V1beta1AutoscalerSpecInitProviderAutoscalingPolicyScalingSchedules>? ScalingSchedules { get; set; }
}

public enum V1beta1AutoscalerSpecInitProviderTargetRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AutoscalerSpecInitProviderTargetRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AutoscalerSpecInitProviderTargetRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutoscalerSpecInitProviderTargetRefPolicyResolutionEnum>))]
    public V1beta1AutoscalerSpecInitProviderTargetRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutoscalerSpecInitProviderTargetRefPolicyResolveEnum>))]
    public V1beta1AutoscalerSpecInitProviderTargetRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InstanceGroupManager in compute to populate target.</summary>
public partial class V1beta1AutoscalerSpecInitProviderTargetRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AutoscalerSpecInitProviderTargetRefPolicy? Policy { get; set; }
}

public enum V1beta1AutoscalerSpecInitProviderTargetSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AutoscalerSpecInitProviderTargetSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1AutoscalerSpecInitProviderTargetSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutoscalerSpecInitProviderTargetSelectorPolicyResolutionEnum>))]
    public V1beta1AutoscalerSpecInitProviderTargetSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutoscalerSpecInitProviderTargetSelectorPolicyResolveEnum>))]
    public V1beta1AutoscalerSpecInitProviderTargetSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InstanceGroupManager in compute to populate target.</summary>
public partial class V1beta1AutoscalerSpecInitProviderTargetSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AutoscalerSpecInitProviderTargetSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1AutoscalerSpecInitProvider
{
    /// <summary>The configuration parameters for the autoscaling algorithm. You can define one or more of the policies for an autoscaler: cpuUtilization, customMetricUtilizations, and loadBalancingUtilization. If none of these are specified, the default will be to autoscale based on cpuUtilization to 0.6 or 60%. Structure is documented below.</summary>
    [JsonPropertyName("autoscalingPolicy")]
    public IList<V1beta1AutoscalerSpecInitProviderAutoscalingPolicy>? AutoscalingPolicy { get; set; }

    /// <summary>A description of a scaling schedule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>URL of the managed instance group that this autoscaler will scale.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Reference to a InstanceGroupManager in compute to populate target.</summary>
    [JsonPropertyName("targetRef")]
    public V1beta1AutoscalerSpecInitProviderTargetRef? TargetRef { get; set; }

    /// <summary>Selector for a InstanceGroupManager in compute to populate target.</summary>
    [JsonPropertyName("targetSelector")]
    public V1beta1AutoscalerSpecInitProviderTargetSelector? TargetSelector { get; set; }
}

public enum V1beta1AutoscalerSpecManagementPoliciesEnum
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

public enum V1beta1AutoscalerSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AutoscalerSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AutoscalerSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutoscalerSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1AutoscalerSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutoscalerSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1AutoscalerSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1AutoscalerSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AutoscalerSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1AutoscalerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AutoscalerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AutoscalerSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutoscalerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1AutoscalerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutoscalerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1AutoscalerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1AutoscalerSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AutoscalerSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1AutoscalerSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1AutoscalerSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1AutoscalerSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1AutoscalerSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1AutoscalerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>AutoscalerSpec defines the desired state of Autoscaler</summary>
public partial class V1beta1AutoscalerSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AutoscalerSpecDeletionPolicyEnum>))]
    public V1beta1AutoscalerSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1AutoscalerSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1AutoscalerSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1AutoscalerSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AutoscalerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1AutoscalerSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AutoscalerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1AutoscalerStatusAtProviderAutoscalingPolicyCpuUtilization
{
    /// <summary>Indicates whether predictive autoscaling based on CPU metric is enabled. Valid values are:</summary>
    [JsonPropertyName("predictiveMethod")]
    public string? PredictiveMethod { get; set; }

    /// <summary>URL of the managed instance group that this autoscaler will scale.</summary>
    [JsonPropertyName("target")]
    public double? Target { get; set; }
}

/// <summary></summary>
public partial class V1beta1AutoscalerStatusAtProviderAutoscalingPolicyLoadBalancingUtilization
{
    /// <summary>URL of the managed instance group that this autoscaler will scale.</summary>
    [JsonPropertyName("target")]
    public double? Target { get; set; }
}

/// <summary></summary>
public partial class V1beta1AutoscalerStatusAtProviderAutoscalingPolicyMetric
{
    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>URL of the managed instance group that this autoscaler will scale.</summary>
    [JsonPropertyName("target")]
    public double? Target { get; set; }

    /// <summary>Defines how target utilization value is expressed for a Stackdriver Monitoring metric. Possible values are: GAUGE, DELTA_PER_SECOND, DELTA_PER_MINUTE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1AutoscalerStatusAtProviderAutoscalingPolicyScaleInControlMaxScaledInReplicas
{
    /// <summary>Specifies a fixed number of VM instances. This must be a positive integer.</summary>
    [JsonPropertyName("fixed")]
    public double? Fixed { get; set; }

    /// <summary>Specifies a percentage of instances between 0 to 100%, inclusive. For example, specify 80 for 80%.</summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary></summary>
public partial class V1beta1AutoscalerStatusAtProviderAutoscalingPolicyScaleInControl
{
    /// <summary>A nested object resource Structure is documented below.</summary>
    [JsonPropertyName("maxScaledInReplicas")]
    public IList<V1beta1AutoscalerStatusAtProviderAutoscalingPolicyScaleInControlMaxScaledInReplicas>? MaxScaledInReplicas { get; set; }

    /// <summary>How long back autoscaling should look when computing recommendations to include directives regarding slower scale down, as described above.</summary>
    [JsonPropertyName("timeWindowSec")]
    public double? TimeWindowSec { get; set; }
}

/// <summary></summary>
public partial class V1beta1AutoscalerStatusAtProviderAutoscalingPolicyScalingSchedules
{
    /// <summary>A description of a scaling schedule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A boolean value that specifies if a scaling schedule can influence autoscaler recommendations. If set to true, then a scaling schedule has no effect.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>The duration of time intervals (in seconds) for which this scaling schedule will be running. The minimum allowed value is 300.</summary>
    [JsonPropertyName("durationSec")]
    public double? DurationSec { get; set; }

    /// <summary>Minimum number of VM instances that autoscaler will recommend in time intervals starting according to schedule.</summary>
    [JsonPropertyName("minRequiredReplicas")]
    public double? MinRequiredReplicas { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The start timestamps of time intervals when this scaling schedule should provide a scaling signal. This field uses the extended cron format (with an optional year field).</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>The time zone to be used when interpreting the schedule. The value of this field must be a time zone name from the tz database: http://en.wikipedia.org/wiki/Tz_database.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary></summary>
public partial class V1beta1AutoscalerStatusAtProviderAutoscalingPolicy
{
    /// <summary>The number of seconds that the autoscaler should wait before it starts collecting information from a new instance. This prevents the autoscaler from collecting information when the instance is initializing, during which the collected usage would not be reliable. The default time autoscaler waits is 60 seconds. Virtual machine initialization times might vary because of numerous factors. We recommend that you test how long an instance may take to initialize. To do this, create an instance and time the startup process.</summary>
    [JsonPropertyName("cooldownPeriod")]
    public double? CooldownPeriod { get; set; }

    /// <summary>Defines the CPU utilization policy that allows the autoscaler to scale based on the average CPU utilization of a managed instance group. Structure is documented below.</summary>
    [JsonPropertyName("cpuUtilization")]
    public IList<V1beta1AutoscalerStatusAtProviderAutoscalingPolicyCpuUtilization>? CpuUtilization { get; set; }

    /// <summary>Configuration parameters of autoscaling based on a load balancer. Structure is documented below.</summary>
    [JsonPropertyName("loadBalancingUtilization")]
    public IList<V1beta1AutoscalerStatusAtProviderAutoscalingPolicyLoadBalancingUtilization>? LoadBalancingUtilization { get; set; }

    /// <summary>The maximum number of instances that the autoscaler can scale up to. This is required when creating or updating an autoscaler. The maximum number of replicas should not be lower than minimal number of replicas.</summary>
    [JsonPropertyName("maxReplicas")]
    public double? MaxReplicas { get; set; }

    /// <summary>Configuration parameters of autoscaling based on a custom metric. Structure is documented below.</summary>
    [JsonPropertyName("metric")]
    public IList<V1beta1AutoscalerStatusAtProviderAutoscalingPolicyMetric>? Metric { get; set; }

    /// <summary>The minimum number of replicas that the autoscaler can scale down to. This cannot be less than 0. If not provided, autoscaler will choose a default value depending on maximum number of instances allowed.</summary>
    [JsonPropertyName("minReplicas")]
    public double? MinReplicas { get; set; }

    /// <summary>Defines operating mode for this policy.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Defines scale in controls to reduce the risk of response latency and outages due to abrupt scale-in events Structure is documented below.</summary>
    [JsonPropertyName("scaleInControl")]
    public IList<V1beta1AutoscalerStatusAtProviderAutoscalingPolicyScaleInControl>? ScaleInControl { get; set; }

    /// <summary>Scaling schedules defined for an autoscaler. Multiple schedules can be set on an autoscaler and they can overlap. Structure is documented below.</summary>
    [JsonPropertyName("scalingSchedules")]
    public IList<V1beta1AutoscalerStatusAtProviderAutoscalingPolicyScalingSchedules>? ScalingSchedules { get; set; }
}

/// <summary></summary>
public partial class V1beta1AutoscalerStatusAtProvider
{
    /// <summary>The configuration parameters for the autoscaling algorithm. You can define one or more of the policies for an autoscaler: cpuUtilization, customMetricUtilizations, and loadBalancingUtilization. If none of these are specified, the default will be to autoscale based on cpuUtilization to 0.6 or 60%. Structure is documented below.</summary>
    [JsonPropertyName("autoscalingPolicy")]
    public IList<V1beta1AutoscalerStatusAtProviderAutoscalingPolicy>? AutoscalingPolicy { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>A description of a scaling schedule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/zones/{{zone}}/autoscalers/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>URL of the managed instance group that this autoscaler will scale.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>URL of the zone where the instance group resides.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1AutoscalerStatusConditions
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

/// <summary>AutoscalerStatus defines the observed state of Autoscaler.</summary>
public partial class V1beta1AutoscalerStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1AutoscalerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AutoscalerStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Autoscaler is the Schema for the Autoscalers API. Represents an Autoscaler resource.</summary>
public partial class V1beta1Autoscaler : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AutoscalerSpec>, IStatus<V1beta1AutoscalerStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Autoscaler";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "autoscalers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AutoscalerSpec defines the desired state of Autoscaler</summary>
    [JsonPropertyName("spec")]
    public V1beta1AutoscalerSpec Spec { get; set; }

    /// <summary>AutoscalerStatus defines the observed state of Autoscaler.</summary>
    [JsonPropertyName("status")]
    public V1beta1AutoscalerStatus? Status { get; set; }
}