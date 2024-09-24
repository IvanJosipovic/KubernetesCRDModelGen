using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
/// <summary>Defines the CPU utilization policy that allows the autoscaler to scale based on the average CPU utilization of a managed instance group.</summary>
public partial class V1alpha1ComputeAutoscalerSpecAutoscalingPolicyCpuUtilization
{
    /// <summary>Indicates whether predictive autoscaling based on CPU metric is enabled. Valid values are:  - NONE (default). No predictive method is used. The autoscaler scales the group to meet current demand based on real-time metrics.  - OPTIMIZE_AVAILABILITY. Predictive autoscaling improves availability by monitoring daily and weekly load patterns and scaling out ahead of anticipated demand.</summary>
    [JsonPropertyName("predictiveMethod")]
    public string? PredictiveMethod { get; set; }

    /// <summary>The target CPU utilization that the autoscaler should maintain. Must be a float value in the range (0, 1]. If not specified, the default is 0.6.  If the CPU level is below the target utilization, the autoscaler scales down the number of instances until it reaches the minimum number of instances you specified or until the average CPU of your instances reaches the target utilization.  If the average CPU is above the target utilization, the autoscaler scales up until it reaches the maximum number of instances you specified or until the average utilization reaches the target utilization.</summary>
    [JsonPropertyName("target")]
    public double Target { get; set; }
}

/// <summary>Configuration parameters of autoscaling based on a load balancer.</summary>
public partial class V1alpha1ComputeAutoscalerSpecAutoscalingPolicyLoadBalancingUtilization
{
    /// <summary>Fraction of backend capacity utilization (set in HTTP(s) load balancing configuration) that autoscaler should maintain. Must be a positive float value. If not defined, the default is 0.8.</summary>
    [JsonPropertyName("target")]
    public double Target { get; set; }
}

/// <summary></summary>
public partial class V1alpha1ComputeAutoscalerSpecAutoscalingPolicyMetric
{
    /// <summary>A filter string to be used as the filter string for a Stackdriver Monitoring TimeSeries.list API call. This filter is used to select a specific TimeSeries for the purpose of autoscaling and to determine whether the metric is exporting per-instance or per-group data.  You can only use the AND operator for joining selectors. You can only use direct equality comparison operator (=) without any functions for each selector. You can specify the metric in both the filter string and in the metric field. However, if specified in both places, the metric must be identical.  The monitored resource type determines what kind of values are expected for the metric. If it is a gce_instance, the autoscaler expects the metric to include a separate TimeSeries for each instance in a group. In such a case, you cannot filter on resource labels.  If the resource type is any other value, the autoscaler expects this metric to contain values that apply to the entire autoscaled instance group and resource label filtering can be performed to point autoscaler at the correct TimeSeries to scale upon. This is called a per-group metric for the purpose of autoscaling.  If not specified, the type defaults to gce_instance.  You should provide a filter that is selective enough to pick just one TimeSeries for the autoscaled group or for each of the instances (if you are using gce_instance resource type). If multiple TimeSeries are returned upon the query execution, the autoscaler will sum their respective values to obtain its scaling value.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>The identifier (type) of the Stackdriver Monitoring metric. The metric cannot have negative values.  The metric must have a value type of INT64 or DOUBLE.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>If scaling is based on a per-group metric value that represents the total amount of work to be done or resource usage, set this value to an amount assigned for a single instance of the scaled group. The autoscaler will keep the number of instances proportional to the value of this metric, the metric itself should not change value due to group resizing.  For example, a good metric to use with the target is 'pubsub.googleapis.com/subscription/num_undelivered_messages' or a custom metric exporting the total number of requests coming to your instances.  A bad example would be a metric exporting an average or median latency, since this value can't include a chunk assignable to a single instance, it could be better used with utilization_target instead.</summary>
    [JsonPropertyName("singleInstanceAssignment")]
    public double? SingleInstanceAssignment { get; set; }

    /// <summary>The target value of the metric that autoscaler should maintain. This must be a positive value. A utilization metric scales number of virtual machines handling requests to increase or decrease proportionally to the metric.  For example, a good metric to use as a utilizationTarget is www.googleapis.com/compute/instance/network/received_bytes_count. The autoscaler will work to keep this value constant for each of the instances.</summary>
    [JsonPropertyName("target")]
    public double? Target { get; set; }

    /// <summary>Defines how target utilization value is expressed for a Stackdriver Monitoring metric. Possible values: ["GAUGE", "DELTA_PER_SECOND", "DELTA_PER_MINUTE"].</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A nested object resource.</summary>
public partial class V1alpha1ComputeAutoscalerSpecAutoscalingPolicyScaleDownControlMaxScaledDownReplicas
{
    /// <summary>Specifies a fixed number of VM instances. This must be a positive integer.</summary>
    [JsonPropertyName("fixed")]
    public int? Fixed { get; set; }

    /// <summary>Specifies a percentage of instances between 0 to 100%, inclusive. For example, specify 80 for 80%.</summary>
    [JsonPropertyName("percent")]
    public int? Percent { get; set; }
}

/// <summary>Defines scale down controls to reduce the risk of response latency and outages due to abrupt scale-in events.</summary>
public partial class V1alpha1ComputeAutoscalerSpecAutoscalingPolicyScaleDownControl
{
    /// <summary>A nested object resource.</summary>
    [JsonPropertyName("maxScaledDownReplicas")]
    public V1alpha1ComputeAutoscalerSpecAutoscalingPolicyScaleDownControlMaxScaledDownReplicas? MaxScaledDownReplicas { get; set; }

    /// <summary>How long back autoscaling should look when computing recommendations to include directives regarding slower scale down, as described above.</summary>
    [JsonPropertyName("timeWindowSec")]
    public int? TimeWindowSec { get; set; }
}

/// <summary>A nested object resource.</summary>
public partial class V1alpha1ComputeAutoscalerSpecAutoscalingPolicyScaleInControlMaxScaledInReplicas
{
    /// <summary>Specifies a fixed number of VM instances. This must be a positive integer.</summary>
    [JsonPropertyName("fixed")]
    public int? Fixed { get; set; }

    /// <summary>Specifies a percentage of instances between 0 to 100%, inclusive. For example, specify 80 for 80%.</summary>
    [JsonPropertyName("percent")]
    public int? Percent { get; set; }
}

/// <summary>Defines scale in controls to reduce the risk of response latency and outages due to abrupt scale-in events.</summary>
public partial class V1alpha1ComputeAutoscalerSpecAutoscalingPolicyScaleInControl
{
    /// <summary>A nested object resource.</summary>
    [JsonPropertyName("maxScaledInReplicas")]
    public V1alpha1ComputeAutoscalerSpecAutoscalingPolicyScaleInControlMaxScaledInReplicas? MaxScaledInReplicas { get; set; }

    /// <summary>How long back autoscaling should look when computing recommendations to include directives regarding slower scale down, as described above.</summary>
    [JsonPropertyName("timeWindowSec")]
    public int? TimeWindowSec { get; set; }
}

/// <summary></summary>
public partial class V1alpha1ComputeAutoscalerSpecAutoscalingPolicyScalingSchedules
{
    /// <summary>A description of a scaling schedule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A boolean value that specifies if a scaling schedule can influence autoscaler recommendations. If set to true, then a scaling schedule has no effect.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>The duration of time intervals (in seconds) for which this scaling schedule will be running. The minimum allowed value is 300.</summary>
    [JsonPropertyName("durationSec")]
    public int DurationSec { get; set; }

    /// <summary>Minimum number of VM instances that autoscaler will recommend in time intervals starting according to schedule.</summary>
    [JsonPropertyName("minRequiredReplicas")]
    public int MinRequiredReplicas { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>The start timestamps of time intervals when this scaling schedule should provide a scaling signal. This field uses the extended cron format (with an optional year field).</summary>
    [JsonPropertyName("schedule")]
    public string Schedule { get; set; }

    /// <summary>The time zone to be used when interpreting the schedule. The value of this field must be a time zone name from the tz database: http://en.wikipedia.org/wiki/Tz_database.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>The configuration parameters for the autoscaling algorithm. You can define one or more of the policies for an autoscaler: cpuUtilization, customMetricUtilizations, and loadBalancingUtilization.  If none of these are specified, the default will be to autoscale based on cpuUtilization to 0.6 or 60%.</summary>
public partial class V1alpha1ComputeAutoscalerSpecAutoscalingPolicy
{
    /// <summary>The number of seconds that the autoscaler should wait before it starts collecting information from a new instance. This prevents the autoscaler from collecting information when the instance is initializing, during which the collected usage would not be reliable. The default time autoscaler waits is 60 seconds.  Virtual machine initialization times might vary because of numerous factors. We recommend that you test how long an instance may take to initialize. To do this, create an instance and time the startup process.</summary>
    [JsonPropertyName("cooldownPeriod")]
    public int? CooldownPeriod { get; set; }

    /// <summary>Defines the CPU utilization policy that allows the autoscaler to scale based on the average CPU utilization of a managed instance group.</summary>
    [JsonPropertyName("cpuUtilization")]
    public V1alpha1ComputeAutoscalerSpecAutoscalingPolicyCpuUtilization? CpuUtilization { get; set; }

    /// <summary>Configuration parameters of autoscaling based on a load balancer.</summary>
    [JsonPropertyName("loadBalancingUtilization")]
    public V1alpha1ComputeAutoscalerSpecAutoscalingPolicyLoadBalancingUtilization? LoadBalancingUtilization { get; set; }

    /// <summary>The maximum number of instances that the autoscaler can scale up to. This is required when creating or updating an autoscaler. The maximum number of replicas should not be lower than minimal number of replicas.</summary>
    [JsonPropertyName("maxReplicas")]
    public int MaxReplicas { get; set; }

    /// <summary>Configuration parameters of autoscaling based on a custom metric.</summary>
    [JsonPropertyName("metric")]
    public IList<V1alpha1ComputeAutoscalerSpecAutoscalingPolicyMetric>? Metric { get; set; }

    /// <summary>The minimum number of replicas that the autoscaler can scale down to. This cannot be less than 0. If not provided, autoscaler will choose a default value depending on maximum number of instances allowed.</summary>
    [JsonPropertyName("minReplicas")]
    public int MinReplicas { get; set; }

    /// <summary>Defines operating mode for this policy.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Defines scale down controls to reduce the risk of response latency and outages due to abrupt scale-in events.</summary>
    [JsonPropertyName("scaleDownControl")]
    public V1alpha1ComputeAutoscalerSpecAutoscalingPolicyScaleDownControl? ScaleDownControl { get; set; }

    /// <summary>Defines scale in controls to reduce the risk of response latency and outages due to abrupt scale-in events.</summary>
    [JsonPropertyName("scaleInControl")]
    public V1alpha1ComputeAutoscalerSpecAutoscalingPolicyScaleInControl? ScaleInControl { get; set; }

    /// <summary>Scaling schedules defined for an autoscaler. Multiple schedules can be set on an autoscaler and they can overlap.</summary>
    [JsonPropertyName("scalingSchedules")]
    public IList<V1alpha1ComputeAutoscalerSpecAutoscalingPolicyScalingSchedules>? ScalingSchedules { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
public partial class V1alpha1ComputeAutoscalerSpecProjectRef
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

/// <summary></summary>
public partial class V1alpha1ComputeAutoscalerSpecTargetRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeInstanceGroupManager` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
public partial class V1alpha1ComputeAutoscalerSpec
{
    /// <summary>The configuration parameters for the autoscaling algorithm. You can define one or more of the policies for an autoscaler: cpuUtilization, customMetricUtilizations, and loadBalancingUtilization.  If none of these are specified, the default will be to autoscale based on cpuUtilization to 0.6 or 60%.</summary>
    [JsonPropertyName("autoscalingPolicy")]
    public V1alpha1ComputeAutoscalerSpecAutoscalingPolicy AutoscalingPolicy { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1ComputeAutoscalerSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetRef")]
    public V1alpha1ComputeAutoscalerSpecTargetRef TargetRef { get; set; }

    /// <summary>Immutable. URL of the zone where the instance group resides.</summary>
    [JsonPropertyName("zone")]
    public string Zone { get; set; }
}

/// <summary></summary>
public partial class V1alpha1ComputeAutoscalerStatusConditions
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
public partial class V1alpha1ComputeAutoscalerStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ComputeAutoscalerStatusConditions>? Conditions { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1alpha1ComputeAutoscaler : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ComputeAutoscalerSpec>, IStatus<V1alpha1ComputeAutoscalerStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ComputeAutoscaler";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computeautoscalers";
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
    public V1alpha1ComputeAutoscalerSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1ComputeAutoscalerStatus? Status { get; set; }
}