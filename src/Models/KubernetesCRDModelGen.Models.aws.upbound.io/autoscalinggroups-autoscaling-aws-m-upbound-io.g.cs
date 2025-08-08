using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.autoscaling.aws.m.upbound.io;
/// <summary>The instance capacity distribution across Availability Zones. See Availability Zone Distribution below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderAvailabilityZoneDistribution
{
    /// <summary>The strategy to use for distributing capacity across the Availability Zones. Valid values are balanced-only and balanced-best-effort. Default is balanced-best-effort.</summary>
    [JsonPropertyName("capacityDistributionStrategy")]
    public string? CapacityDistributionStrategy { get; set; }
}

/// <summary>Describes a target Capacity Reservation or Capacity Reservation resource group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderCapacityReservationSpecificationCapacityReservationTarget
{
    /// <summary>List of On-Demand Capacity Reservation Ids. Conflicts with capacity_reservation_resource_group_arns.</summary>
    [JsonPropertyName("capacityReservationIds")]
    public IList<string>? CapacityReservationIds { get; set; }

    /// <summary>List of On-Demand Capacity Reservation Resource Group Arns. Conflicts with capacity_reservation_ids.</summary>
    [JsonPropertyName("capacityReservationResourceGroupArns")]
    public IList<string>? CapacityReservationResourceGroupArns { get; set; }
}

/// <summary>Demand Capacity Reservations. See Capacity Reservation Specification below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderCapacityReservationSpecification
{
    /// <summary>Capacity Reservation preference helps you use Capacity Reservations efficiently by prioritizing reserved capacity in a Capacity Reservation before using On-Demand capacity. Valid values are default, capacity-reservations-only, capacity-reservations-first and none. Default is default.</summary>
    [JsonPropertyName("capacityReservationPreference")]
    public string? CapacityReservationPreference { get; set; }

    /// <summary>Describes a target Capacity Reservation or Capacity Reservation resource group.</summary>
    [JsonPropertyName("capacityReservationTarget")]
    public V1beta1AutoscalingGroupSpecForProviderCapacityReservationSpecificationCapacityReservationTarget? CapacityReservationTarget { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderInitialLifecycleHook
{
    /// <summary></summary>
    [JsonPropertyName("defaultResult")]
    public string? DefaultResult { get; set; }

    /// <summary></summary>
    [JsonPropertyName("heartbeatTimeout")]
    public double? HeartbeatTimeout { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lifecycleTransition")]
    public string? LifecycleTransition { get; set; }

    /// <summary>Name of the Auto Scaling Group. Conflicts with name_prefix.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notificationMetadata")]
    public string? NotificationMetadata { get; set; }

    /// <summary>ARN for this Auto Scaling Group</summary>
    [JsonPropertyName("notificationTargetArn")]
    public string? NotificationTargetArn { get; set; }

    /// <summary>ARN for this Auto Scaling Group</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>If this block is configured, add a instance maintenance policy to the specified Auto Scaling group. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderInstanceMaintenancePolicy
{
    /// <summary>Amount of capacity in the Auto Scaling group that can be in service and healthy, or pending, to support your workload when an instance refresh is in place, as a percentage of the desired capacity of the Auto Scaling group. Values must be between 100 and 200, defaults to 100.</summary>
    [JsonPropertyName("maxHealthyPercentage")]
    public double? MaxHealthyPercentage { get; set; }

    /// <summary>Amount of capacity in the Auto Scaling group that must remain healthy during an instance refresh to allow the operation to continue, as a percentage of the desired capacity of the Auto Scaling group. Defaults to 90.</summary>
    [JsonPropertyName("minHealthyPercentage")]
    public double? MinHealthyPercentage { get; set; }
}

/// <summary>Alarm Specification for Instance Refresh.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderInstanceRefreshPreferencesAlarmSpecification
{
    /// <summary>List of Cloudwatch alarms. If any of these alarms goes into ALARM state, Instance Refresh is failed.</summary>
    [JsonPropertyName("alarms")]
    public IList<string>? Alarms { get; set; }
}

/// <summary>Override default parameters for Instance Refresh.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderInstanceRefreshPreferences
{
    /// <summary>Alarm Specification for Instance Refresh.</summary>
    [JsonPropertyName("alarmSpecification")]
    public V1beta1AutoscalingGroupSpecForProviderInstanceRefreshPreferencesAlarmSpecification? AlarmSpecification { get; set; }

    /// <summary>Automatically rollback if instance refresh fails. Defaults to false. This option may only be set to true when specifying a launch_template or mixed_instances_policy.</summary>
    [JsonPropertyName("autoRollback")]
    public bool? AutoRollback { get; set; }

    /// <summary>Number of seconds to wait after a checkpoint. Defaults to 3600.</summary>
    [JsonPropertyName("checkpointDelay")]
    public string? CheckpointDelay { get; set; }

    /// <summary>List of percentages for each checkpoint. Values must be unique and in ascending order. To replace all instances, the final number must be 100.</summary>
    [JsonPropertyName("checkpointPercentages")]
    public IList<double>? CheckpointPercentages { get; set; }

    /// <summary>Number of seconds until a newly launched instance is configured and ready to use. Default behavior is to use the Auto Scaling Group's health check grace period.</summary>
    [JsonPropertyName("instanceWarmup")]
    public string? InstanceWarmup { get; set; }

    /// <summary>Amount of capacity in the Auto Scaling group that can be in service and healthy, or pending, to support your workload when an instance refresh is in place, as a percentage of the desired capacity of the Auto Scaling group. Values must be between 100 and 200, defaults to 100.</summary>
    [JsonPropertyName("maxHealthyPercentage")]
    public double? MaxHealthyPercentage { get; set; }

    /// <summary>Amount of capacity in the Auto Scaling group that must remain healthy during an instance refresh to allow the operation to continue, as a percentage of the desired capacity of the Auto Scaling group. Defaults to 90.</summary>
    [JsonPropertyName("minHealthyPercentage")]
    public double? MinHealthyPercentage { get; set; }

    /// <summary>Behavior when encountering instances protected from scale in are found. Available behaviors are Refresh, Ignore, and Wait. Default is Ignore.</summary>
    [JsonPropertyName("scaleInProtectedInstances")]
    public string? ScaleInProtectedInstances { get; set; }

    /// <summary>Replace instances that already have your desired configuration. Defaults to false.</summary>
    [JsonPropertyName("skipMatching")]
    public bool? SkipMatching { get; set; }

    /// <summary>Behavior when encountering instances in the Standby state in are found. Available behaviors are Terminate, Ignore, and Wait. Default is Ignore.</summary>
    [JsonPropertyName("standbyInstances")]
    public string? StandbyInstances { get; set; }
}

/// <summary>If this block is configured, start an Instance Refresh when this Auto Scaling Group is updated. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderInstanceRefresh
{
    /// <summary>Override default parameters for Instance Refresh.</summary>
    [JsonPropertyName("preferences")]
    public V1beta1AutoscalingGroupSpecForProviderInstanceRefreshPreferences? Preferences { get; set; }

    /// <summary>Strategy to use for instance refresh. The only allowed value is Rolling. See StartInstanceRefresh Action for more information.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }

    /// <summary>Set of additional property names that will trigger an Instance Refresh. A refresh will always be triggered by a change in any of launch_configuration, launch_template, or mixed_instances_policy.</summary>
    [JsonPropertyName("triggers")]
    public IList<string>? Triggers { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderLaunchConfigurationRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LaunchConfiguration in autoscaling to populate launchConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderLaunchConfigurationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AutoscalingGroupSpecForProviderLaunchConfigurationRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderLaunchConfigurationSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LaunchConfiguration in autoscaling to populate launchConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderLaunchConfigurationSelector
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
    public V1beta1AutoscalingGroupSpecForProviderLaunchConfigurationSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderLaunchTemplateIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LaunchTemplate in ec2 to populate id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderLaunchTemplateIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AutoscalingGroupSpecForProviderLaunchTemplateIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderLaunchTemplateIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LaunchTemplate in ec2 to populate id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderLaunchTemplateIdSelector
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
    public V1beta1AutoscalingGroupSpecForProviderLaunchTemplateIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Nested argument with Launch template specification to use to launch instances. See Launch Template below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderLaunchTemplate
{
    /// <summary>ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Reference to a LaunchTemplate in ec2 to populate id.</summary>
    [JsonPropertyName("idRef")]
    public V1beta1AutoscalingGroupSpecForProviderLaunchTemplateIdRef? IdRef { get; set; }

    /// <summary>Selector for a LaunchTemplate in ec2 to populate id.</summary>
    [JsonPropertyName("idSelector")]
    public V1beta1AutoscalingGroupSpecForProviderLaunchTemplateIdSelector? IdSelector { get; set; }

    /// <summary>Name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Template version. Can be version number, $Latest, or $Default. (Default: $Default).</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Nested argument containing settings on how to mix on-demand and Spot instances in the Auto Scaling group. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyInstancesDistribution
{
    /// <summary>Strategy to use when launching on-demand instances. Valid values: prioritized, lowest-price. Default: prioritized.</summary>
    [JsonPropertyName("onDemandAllocationStrategy")]
    public string? OnDemandAllocationStrategy { get; set; }

    /// <summary>Absolute minimum amount of desired capacity that must be fulfilled by on-demand instances. Default: 0.</summary>
    [JsonPropertyName("onDemandBaseCapacity")]
    public double? OnDemandBaseCapacity { get; set; }

    /// <summary>Percentage split between on-demand and Spot instances above the base on-demand capacity. Default: 100.</summary>
    [JsonPropertyName("onDemandPercentageAboveBaseCapacity")]
    public double? OnDemandPercentageAboveBaseCapacity { get; set; }

    /// <summary>How to allocate capacity across the Spot pools. Valid values: lowest-price, capacity-optimized, capacity-optimized-prioritized, and price-capacity-optimized. Default: lowest-price.</summary>
    [JsonPropertyName("spotAllocationStrategy")]
    public string? SpotAllocationStrategy { get; set; }

    /// <summary>Number of Spot pools per availability zone to allocate capacity. EC2 Auto Scaling selects the cheapest Spot pools and evenly allocates Spot capacity across the number of Spot pools that you specify. Only available with spot_allocation_strategy set to lowest-price. Otherwise it must be set to 0, if it has been defined before. Default: 2.</summary>
    [JsonPropertyName("spotInstancePools")]
    public double? SpotInstancePools { get; set; }

    /// <summary>Maximum price per unit hour that the user is willing to pay for the Spot instances. Default: an empty string which means the on-demand price.</summary>
    [JsonPropertyName("spotMaxPrice")]
    public string? SpotMaxPrice { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LaunchTemplate in ec2 to populate launchTemplateId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LaunchTemplate in ec2 to populate launchTemplateId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdSelector
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
    public V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Nested argument defines the Launch Template. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification
{
    /// <summary>ID of the launch template. Conflicts with launch_template_name.</summary>
    [JsonPropertyName("launchTemplateId")]
    public string? LaunchTemplateId { get; set; }

    /// <summary>Reference to a LaunchTemplate in ec2 to populate launchTemplateId.</summary>
    [JsonPropertyName("launchTemplateIdRef")]
    public V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdRef? LaunchTemplateIdRef { get; set; }

    /// <summary>Selector for a LaunchTemplate in ec2 to populate launchTemplateId.</summary>
    [JsonPropertyName("launchTemplateIdSelector")]
    public V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdSelector? LaunchTemplateIdSelector { get; set; }

    /// <summary>Name of the launch template. Conflicts with launch_template_id.</summary>
    [JsonPropertyName("launchTemplateName")]
    public string? LaunchTemplateName { get; set; }

    /// <summary>Template version. Can be version number, $Latest, or $Default. (Default: $Default).</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Block describing the minimum and maximum number of accelerators (GPUs, FPGAs, or AWS Inferentia chips). Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsAcceleratorCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum total memory of the accelerators. Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsAcceleratorTotalMemoryMib
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum baseline EBS bandwidth, in Mbps. Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsBaselineEbsBandwidthMbps
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum amount of memory (GiB) per vCPU. Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsMemoryGibPerVcpu
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum amount of memory (MiB). Default is no maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsMemoryMib
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum amount of network bandwidth, in gigabits per second (Gbps). Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsNetworkBandwidthGbps
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum number of network interfaces. Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsNetworkInterfaceCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum total local storage (GB). Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsTotalLocalStorageGb
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum number of vCPUs. Default is no maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsVcpuCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Override the instance type in the Launch Template with instance types that satisfy the requirements.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirements
{
    /// <summary>Block describing the minimum and maximum number of accelerators (GPUs, FPGAs, or AWS Inferentia chips). Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorCount")]
    public V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsAcceleratorCount? AcceleratorCount { get; set; }

    /// <summary>List of accelerator manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("acceleratorManufacturers")]
    public IList<string>? AcceleratorManufacturers { get; set; }

    /// <summary>List of accelerator names. Default is any acclerator.</summary>
    [JsonPropertyName("acceleratorNames")]
    public IList<string>? AcceleratorNames { get; set; }

    /// <summary>Block describing the minimum and maximum total memory of the accelerators. Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorTotalMemoryMib")]
    public V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsAcceleratorTotalMemoryMib? AcceleratorTotalMemoryMib { get; set; }

    /// <summary>List of accelerator types. Default is any accelerator type.</summary>
    [JsonPropertyName("acceleratorTypes")]
    public IList<string>? AcceleratorTypes { get; set; }

    /// <summary>List of instance types to apply your specified attributes against. All other instance types are ignored, even if they match your specified attributes. You can use strings with one or more wild cards, represented by an asterisk (*), to allow an instance type, size, or generation. The following are examples: m5.8xlarge, c5*.*, m5a.*, r*, *3*. For example, if you specify c5*, you are allowing the entire C5 instance family, which includes all C5a and C5n instance types. If you specify m5a.*, you are allowing all the M5a instance types, but not the M5n instance types. Maximum of 400 entries in the list; each entry is limited to 30 characters. Default is all instance types.</summary>
    [JsonPropertyName("allowedInstanceTypes")]
    public IList<string>? AllowedInstanceTypes { get; set; }

    /// <summary>Indicate whether bare metal instace types should be included, excluded, or required. Default is excluded.</summary>
    [JsonPropertyName("bareMetal")]
    public string? BareMetal { get; set; }

    /// <summary>Block describing the minimum and maximum baseline EBS bandwidth, in Mbps. Default is no minimum or maximum.</summary>
    [JsonPropertyName("baselineEbsBandwidthMbps")]
    public V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsBaselineEbsBandwidthMbps? BaselineEbsBandwidthMbps { get; set; }

    /// <summary>Indicate whether burstable performance instance types should be included, excluded, or required. Default is excluded.</summary>
    [JsonPropertyName("burstablePerformance")]
    public string? BurstablePerformance { get; set; }

    /// <summary>List of CPU manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("cpuManufacturers")]
    public IList<string>? CpuManufacturers { get; set; }

    /// <summary>List of instance types to exclude. You can use strings with one or more wild cards, represented by an asterisk (*), to exclude an instance type, size, or generation. The following are examples: m5.8xlarge, c5*.*, m5a.*, r*, *3*. For example, if you specify c5*, you are excluding the entire C5 instance family, which includes all C5a and C5n instance types. If you specify m5a.*, you are excluding all the M5a instance types, but not the M5n instance types. Maximum of 400 entries in the list; each entry is limited to 30 characters. Default is no excluded instance types.</summary>
    [JsonPropertyName("excludedInstanceTypes")]
    public IList<string>? ExcludedInstanceTypes { get; set; }

    /// <summary>List of instance generation names. Default is any generation.</summary>
    [JsonPropertyName("instanceGenerations")]
    public IList<string>? InstanceGenerations { get; set; }

    /// <summary>Indicate whether instance types with local storage volumes are included, excluded, or required. Default is included.</summary>
    [JsonPropertyName("localStorage")]
    public string? LocalStorage { get; set; }

    /// <summary>List of local storage type names. Default any storage type.</summary>
    [JsonPropertyName("localStorageTypes")]
    public IList<string>? LocalStorageTypes { get; set; }

    /// <summary>The price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Conflicts with spot_max_price_percentage_over_lowest_price</summary>
    [JsonPropertyName("maxSpotPriceAsPercentageOfOptimalOnDemandPrice")]
    public double? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (GiB) per vCPU. Default is no minimum or maximum.</summary>
    [JsonPropertyName("memoryGibPerVcpu")]
    public V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsMemoryGibPerVcpu? MemoryGibPerVcpu { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (MiB). Default is no maximum.</summary>
    [JsonPropertyName("memoryMib")]
    public V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsMemoryMib? MemoryMib { get; set; }

    /// <summary>Block describing the minimum and maximum amount of network bandwidth, in gigabits per second (Gbps). Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkBandwidthGbps")]
    public V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsNetworkBandwidthGbps? NetworkBandwidthGbps { get; set; }

    /// <summary>Block describing the minimum and maximum number of network interfaces. Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkInterfaceCount")]
    public V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsNetworkInterfaceCount? NetworkInterfaceCount { get; set; }

    /// <summary>Price protection threshold for On-Demand Instances. This is the maximum you’ll pay for an On-Demand Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 20.</summary>
    [JsonPropertyName("onDemandMaxPricePercentageOverLowestPrice")]
    public double? OnDemandMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Indicate whether instance types must support On-Demand Instance Hibernation, either true or false. Default is false.</summary>
    [JsonPropertyName("requireHibernateSupport")]
    public bool? RequireHibernateSupport { get; set; }

    /// <summary>Price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 100. Conflicts with max_spot_price_as_percentage_of_optimal_on_demand_price</summary>
    [JsonPropertyName("spotMaxPricePercentageOverLowestPrice")]
    public double? SpotMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Block describing the minimum and maximum total local storage (GB). Default is no minimum or maximum.</summary>
    [JsonPropertyName("totalLocalStorageGb")]
    public V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsTotalLocalStorageGb? TotalLocalStorageGb { get; set; }

    /// <summary>Block describing the minimum and maximum number of vCPUs. Default is no maximum.</summary>
    [JsonPropertyName("vcpuCount")]
    public V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsVcpuCount? VcpuCount { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LaunchTemplate in ec2 to populate launchTemplateId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LaunchTemplate in ec2 to populate launchTemplateId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdSelector
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
    public V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Nested argument defines the Launch Template. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecification
{
    /// <summary>ID of the launch template. Conflicts with launch_template_name.</summary>
    [JsonPropertyName("launchTemplateId")]
    public string? LaunchTemplateId { get; set; }

    /// <summary>Reference to a LaunchTemplate in ec2 to populate launchTemplateId.</summary>
    [JsonPropertyName("launchTemplateIdRef")]
    public V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdRef? LaunchTemplateIdRef { get; set; }

    /// <summary>Selector for a LaunchTemplate in ec2 to populate launchTemplateId.</summary>
    [JsonPropertyName("launchTemplateIdSelector")]
    public V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdSelector? LaunchTemplateIdSelector { get; set; }

    /// <summary>Name of the launch template. Conflicts with launch_template_id.</summary>
    [JsonPropertyName("launchTemplateName")]
    public string? LaunchTemplateName { get; set; }

    /// <summary>Template version. Can be version number, $Latest, or $Default. (Default: $Default).</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverride
{
    /// <summary>Override the instance type in the Launch Template with instance types that satisfy the requirements.</summary>
    [JsonPropertyName("instanceRequirements")]
    public V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirements? InstanceRequirements { get; set; }

    /// <summary>Override the instance type in the Launch Template.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Nested argument defines the Launch Template. Defined below.</summary>
    [JsonPropertyName("launchTemplateSpecification")]
    public V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecification? LaunchTemplateSpecification { get; set; }

    /// <summary>Number of capacity units, which gives the instance type a proportional weight to other instance types.</summary>
    [JsonPropertyName("weightedCapacity")]
    public string? WeightedCapacity { get; set; }
}

/// <summary>Nested argument containing launch template settings along with the overrides to specify multiple instance types and weights. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplate
{
    /// <summary>Nested argument defines the Launch Template. Defined below.</summary>
    [JsonPropertyName("launchTemplateSpecification")]
    public V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification? LaunchTemplateSpecification { get; set; }

    /// <summary>List of nested arguments provides the ability to specify multiple instance types. This will override the same parameter in the launch template. For on-demand instances, Auto Scaling considers the order of preference of instance types to launch based on the order specified in the overrides list. Defined below.</summary>
    [JsonPropertyName("override")]
    public IList<V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverride>? Override { get; set; }
}

/// <summary>Configuration block containing settings to define launch targets for Auto Scaling groups. See Mixed Instances Policy below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicy
{
    /// <summary>Nested argument containing settings on how to mix on-demand and Spot instances in the Auto Scaling group. Defined below.</summary>
    [JsonPropertyName("instancesDistribution")]
    public V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyInstancesDistribution? InstancesDistribution { get; set; }

    /// <summary>Nested argument containing launch template settings along with the overrides to specify multiple instance types and weights. Defined below.</summary>
    [JsonPropertyName("launchTemplate")]
    public V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplate? LaunchTemplate { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderPlacementGroupRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a PlacementGroup in ec2 to populate placementGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderPlacementGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AutoscalingGroupSpecForProviderPlacementGroupRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderPlacementGroupSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a PlacementGroup in ec2 to populate placementGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderPlacementGroupSelector
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
    public V1beta1AutoscalingGroupSpecForProviderPlacementGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderServiceLinkedRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceLinkedRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderServiceLinkedRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AutoscalingGroupSpecForProviderServiceLinkedRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderServiceLinkedRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceLinkedRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderServiceLinkedRoleArnSelector
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
    public V1beta1AutoscalingGroupSpecForProviderServiceLinkedRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderTag
{
    /// <summary>Key</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Enables propagation of the tag to Amazon EC2 instances launched via this ASG</summary>
    [JsonPropertyName("propagateAtLaunch")]
    public bool? PropagateAtLaunch { get; set; }

    /// <summary>Value</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderTrafficSource
{
    /// <summary>Identifies the traffic source. For Application Load Balancers, Gateway Load Balancers, Network Load Balancers, and VPC Lattice, this will be the Amazon Resource Name (ARN) for a target group in this account and Region. For Classic Load Balancers, this will be the name of the Classic Load Balancer in this account and Region.</summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }

    /// <summary>Provides additional context for the value of Identifier. The following lists the valid values: elb if identifier is the name of a Classic Load Balancer. elbv2 if identifier is the ARN of an Application Load Balancer, Gateway Load Balancer, or Network Load Balancer target group. vpc-lattice if identifier is the ARN of a VPC Lattice target group.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderVpcZoneIdentifierRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderVpcZoneIdentifierRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AutoscalingGroupSpecForProviderVpcZoneIdentifierRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderVpcZoneIdentifierSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate vpcZoneIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderVpcZoneIdentifierSelector
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
    public V1beta1AutoscalingGroupSpecForProviderVpcZoneIdentifierSelectorPolicy? Policy { get; set; }
}

/// <summary>Whether instances in the Auto Scaling group can be returned to the warm pool on scale in. The default is to terminate instances in the Auto Scaling group when the group scales in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderWarmPoolInstanceReusePolicy
{
    /// <summary>Whether instances in the Auto Scaling group can be returned to the warm pool on scale in.</summary>
    [JsonPropertyName("reuseOnScaleIn")]
    public bool? ReuseOnScaleIn { get; set; }
}

/// <summary>If this block is configured, add a Warm Pool to the specified Auto Scaling group. Defined below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProviderWarmPool
{
    /// <summary>Whether instances in the Auto Scaling group can be returned to the warm pool on scale in. The default is to terminate instances in the Auto Scaling group when the group scales in.</summary>
    [JsonPropertyName("instanceReusePolicy")]
    public V1beta1AutoscalingGroupSpecForProviderWarmPoolInstanceReusePolicy? InstanceReusePolicy { get; set; }

    /// <summary>Total maximum number of instances that are allowed to be in the warm pool or in any state except Terminated for the Auto Scaling group.</summary>
    [JsonPropertyName("maxGroupPreparedCapacity")]
    public double? MaxGroupPreparedCapacity { get; set; }

    /// <summary>Minimum size of the Auto Scaling Group. (See also Waiting for Capacity below.)</summary>
    [JsonPropertyName("minSize")]
    public double? MinSize { get; set; }

    /// <summary>Sets the instance state to transition to after the lifecycle hooks finish. Valid values are: Stopped (default), Running or Hibernated.</summary>
    [JsonPropertyName("poolState")]
    public string? PoolState { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecForProvider
{
    /// <summary>The instance capacity distribution across Availability Zones. See Availability Zone Distribution below for more details.</summary>
    [JsonPropertyName("availabilityZoneDistribution")]
    public V1beta1AutoscalingGroupSpecForProviderAvailabilityZoneDistribution? AvailabilityZoneDistribution { get; set; }

    /// <summary>A list of Availability Zones where instances in the Auto Scaling group can be created. Used for launching into the default VPC subnet in each Availability Zone when not using the vpc_zone_identifier attribute, or for attaching a network interface when an existing network interface ID is specified in a launch template. Conflicts with vpc_zone_identifier.</summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>Whether capacity rebalance is enabled. Otherwise, capacity rebalance is disabled.</summary>
    [JsonPropertyName("capacityRebalance")]
    public bool? CapacityRebalance { get; set; }

    /// <summary>Demand Capacity Reservations. See Capacity Reservation Specification below for more details.</summary>
    [JsonPropertyName("capacityReservationSpecification")]
    public V1beta1AutoscalingGroupSpecForProviderCapacityReservationSpecification? CapacityReservationSpecification { get; set; }

    /// <summary>Reserved.</summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    /// <summary>Amount of time, in seconds, after a scaling activity completes before another scaling activity can start.</summary>
    [JsonPropertyName("defaultCooldown")]
    public double? DefaultCooldown { get; set; }

    /// <summary>Amount of time, in seconds, until a newly launched instance can contribute to the Amazon CloudWatch metrics. This delay lets an instance finish initializing before Amazon EC2 Auto Scaling aggregates instance metrics, resulting in more reliable usage data. Set this value equal to the amount of time that it takes for resource consumption to become stable after an instance reaches the InService state. (See Set the default instance warmup for an Auto Scaling group)</summary>
    [JsonPropertyName("defaultInstanceWarmup")]
    public double? DefaultInstanceWarmup { get; set; }

    /// <summary>Number of Amazon EC2 instances that should be running in the group. (See also Waiting for Capacity below.)</summary>
    [JsonPropertyName("desiredCapacity")]
    public double? DesiredCapacity { get; set; }

    /// <summary>The unit of measurement for the value specified for desired_capacity. Supported for attribute-based instance type selection only. Valid values: "units", "vcpu", "memory-mib".</summary>
    [JsonPropertyName("desiredCapacityType")]
    public string? DesiredCapacityType { get; set; }

    /// <summary>List of metrics to collect. The allowed values are defined by the underlying AWS API.</summary>
    [JsonPropertyName("enabledMetrics")]
    public IList<string>? EnabledMetrics { get; set; }

    /// <summary>Allows deleting the Auto Scaling Group without waiting for all instances in the pool to terminate. You can force an Auto Scaling Group to delete even if it's in the process of scaling a resource. This bypasses that behavior and potentially leaves resources dangling.</summary>
    [JsonPropertyName("forceDelete")]
    public bool? ForceDelete { get; set; }

    /// <summary>Allows deleting the Auto Scaling Group without waiting for all instances in the warm pool to terminate.</summary>
    [JsonPropertyName("forceDeleteWarmPool")]
    public bool? ForceDeleteWarmPool { get; set; }

    /// <summary>Time (in seconds) after instance comes into service before checking health.</summary>
    [JsonPropertyName("healthCheckGracePeriod")]
    public double? HealthCheckGracePeriod { get; set; }

    /// <summary>"EC2" or "ELB". Controls how health checking is done.</summary>
    [JsonPropertyName("healthCheckType")]
    public string? HealthCheckType { get; set; }

    /// <summary>Whether to ignore failed Auto Scaling scaling activities while waiting for capacity. The default is false -- failed scaling activities cause errors to be returned.</summary>
    [JsonPropertyName("ignoreFailedScalingActivities")]
    public bool? IgnoreFailedScalingActivities { get; set; }

    /// <summary>One or more Lifecycle Hooks to attach to the Auto Scaling Group before instances are launched. The syntax is exactly the same as the separate aws_autoscaling_lifecycle_hook resource, without the autoscaling_group_name attribute. Please note that this will only work when creating a new Auto Scaling Group. For all other use-cases, please use aws_autoscaling_lifecycle_hook resource.</summary>
    [JsonPropertyName("initialLifecycleHook")]
    public IList<V1beta1AutoscalingGroupSpecForProviderInitialLifecycleHook>? InitialLifecycleHook { get; set; }

    /// <summary>If this block is configured, add a instance maintenance policy to the specified Auto Scaling group. Defined below.</summary>
    [JsonPropertyName("instanceMaintenancePolicy")]
    public V1beta1AutoscalingGroupSpecForProviderInstanceMaintenancePolicy? InstanceMaintenancePolicy { get; set; }

    /// <summary>If this block is configured, start an Instance Refresh when this Auto Scaling Group is updated. Defined below.</summary>
    [JsonPropertyName("instanceRefresh")]
    public V1beta1AutoscalingGroupSpecForProviderInstanceRefresh? InstanceRefresh { get; set; }

    /// <summary>Name of the launch configuration to use.</summary>
    [JsonPropertyName("launchConfiguration")]
    public string? LaunchConfiguration { get; set; }

    /// <summary>Reference to a LaunchConfiguration in autoscaling to populate launchConfiguration.</summary>
    [JsonPropertyName("launchConfigurationRef")]
    public V1beta1AutoscalingGroupSpecForProviderLaunchConfigurationRef? LaunchConfigurationRef { get; set; }

    /// <summary>Selector for a LaunchConfiguration in autoscaling to populate launchConfiguration.</summary>
    [JsonPropertyName("launchConfigurationSelector")]
    public V1beta1AutoscalingGroupSpecForProviderLaunchConfigurationSelector? LaunchConfigurationSelector { get; set; }

    /// <summary>Nested argument with Launch template specification to use to launch instances. See Launch Template below for more details.</summary>
    [JsonPropertyName("launchTemplate")]
    public V1beta1AutoscalingGroupSpecForProviderLaunchTemplate? LaunchTemplate { get; set; }

    /// <summary>Maximum amount of time, in seconds, that an instance can be in service, values must be either equal to 0 or between 86400 and 31536000 seconds.</summary>
    [JsonPropertyName("maxInstanceLifetime")]
    public double? MaxInstanceLifetime { get; set; }

    /// <summary>Maximum size of the Auto Scaling Group.</summary>
    [JsonPropertyName("maxSize")]
    public double? MaxSize { get; set; }

    /// <summary>Granularity to associate with the metrics to collect. The only valid value is 1Minute. Default is 1Minute.</summary>
    [JsonPropertyName("metricsGranularity")]
    public string? MetricsGranularity { get; set; }

    /// <summary>Updates will not wait on ELB instance number changes. (See also Waiting for Capacity below.)</summary>
    [JsonPropertyName("minElbCapacity")]
    public double? MinElbCapacity { get; set; }

    /// <summary>Minimum size of the Auto Scaling Group. (See also Waiting for Capacity below.)</summary>
    [JsonPropertyName("minSize")]
    public double? MinSize { get; set; }

    /// <summary>Configuration block containing settings to define launch targets for Auto Scaling groups. See Mixed Instances Policy below for more details.</summary>
    [JsonPropertyName("mixedInstancesPolicy")]
    public V1beta1AutoscalingGroupSpecForProviderMixedInstancesPolicy? MixedInstancesPolicy { get; set; }

    /// <summary>Name of the placement group into which you'll launch your instances, if any.</summary>
    [JsonPropertyName("placementGroup")]
    public string? PlacementGroup { get; set; }

    /// <summary>Reference to a PlacementGroup in ec2 to populate placementGroup.</summary>
    [JsonPropertyName("placementGroupRef")]
    public V1beta1AutoscalingGroupSpecForProviderPlacementGroupRef? PlacementGroupRef { get; set; }

    /// <summary>Selector for a PlacementGroup in ec2 to populate placementGroup.</summary>
    [JsonPropertyName("placementGroupSelector")]
    public V1beta1AutoscalingGroupSpecForProviderPlacementGroupSelector? PlacementGroupSelector { get; set; }

    /// <summary>Whether newly launched instances are automatically protected from termination by Amazon EC2 Auto Scaling when scaling in. For more information about preventing instances from terminating on scale in, see Using instance scale-in protection in the Amazon EC2 Auto Scaling User Guide.</summary>
    [JsonPropertyName("protectFromScaleIn")]
    public bool? ProtectFromScaleIn { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>ARN of the service-linked role that the ASG will use to call other AWS services</summary>
    [JsonPropertyName("serviceLinkedRoleArn")]
    public string? ServiceLinkedRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceLinkedRoleArn.</summary>
    [JsonPropertyName("serviceLinkedRoleArnRef")]
    public V1beta1AutoscalingGroupSpecForProviderServiceLinkedRoleArnRef? ServiceLinkedRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceLinkedRoleArn.</summary>
    [JsonPropertyName("serviceLinkedRoleArnSelector")]
    public V1beta1AutoscalingGroupSpecForProviderServiceLinkedRoleArnSelector? ServiceLinkedRoleArnSelector { get; set; }

    /// <summary>List of processes to suspend for the Auto Scaling Group. The allowed values are Launch, Terminate, HealthCheck, ReplaceUnhealthy, AZRebalance, AlarmNotification, ScheduledActions, AddToLoadBalancer, InstanceRefresh. Note that if you suspend either the Launch or Terminate process types, it can prevent your Auto Scaling Group from functioning properly.</summary>
    [JsonPropertyName("suspendedProcesses")]
    public IList<string>? SuspendedProcesses { get; set; }

    /// <summary>Configuration block(s) containing resource tags. See Tag below for more details.</summary>
    [JsonPropertyName("tag")]
    public IList<V1beta1AutoscalingGroupSpecForProviderTag>? Tag { get; set; }

    /// <summary>List of policies to decide how the instances in the Auto Scaling Group should be terminated. The allowed values are OldestInstance, NewestInstance, OldestLaunchConfiguration, ClosestToNextInstanceHour, OldestLaunchTemplate, AllocationStrategy, Default. Additionally, the ARN of a Lambda function can be specified for custom termination policies.</summary>
    [JsonPropertyName("terminationPolicies")]
    public IList<string>? TerminationPolicies { get; set; }

    /// <summary>Attaches one or more traffic sources to the specified Auto Scaling group.</summary>
    [JsonPropertyName("trafficSource")]
    public IList<V1beta1AutoscalingGroupSpecForProviderTrafficSource>? TrafficSource { get; set; }

    /// <summary>List of subnet IDs to launch resources in. Subnets automatically determine which availability zones the group will reside. Conflicts with availability_zones.</summary>
    [JsonPropertyName("vpcZoneIdentifier")]
    public IList<string>? VpcZoneIdentifier { get; set; }

    /// <summary>References to Subnet in ec2 to populate vpcZoneIdentifier.</summary>
    [JsonPropertyName("vpcZoneIdentifierRefs")]
    public IList<V1beta1AutoscalingGroupSpecForProviderVpcZoneIdentifierRefs>? VpcZoneIdentifierRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate vpcZoneIdentifier.</summary>
    [JsonPropertyName("vpcZoneIdentifierSelector")]
    public V1beta1AutoscalingGroupSpecForProviderVpcZoneIdentifierSelector? VpcZoneIdentifierSelector { get; set; }

    /// <summary>(See also Waiting for Capacity below.</summary>
    [JsonPropertyName("waitForCapacityTimeout")]
    public string? WaitForCapacityTimeout { get; set; }

    /// <summary>(Takes precedence over min_elb_capacity behavior.) (See also Waiting for Capacity below.)</summary>
    [JsonPropertyName("waitForElbCapacity")]
    public double? WaitForElbCapacity { get; set; }

    /// <summary>If this block is configured, add a Warm Pool to the specified Auto Scaling group. Defined below</summary>
    [JsonPropertyName("warmPool")]
    public V1beta1AutoscalingGroupSpecForProviderWarmPool? WarmPool { get; set; }
}

/// <summary>The instance capacity distribution across Availability Zones. See Availability Zone Distribution below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderAvailabilityZoneDistribution
{
    /// <summary>The strategy to use for distributing capacity across the Availability Zones. Valid values are balanced-only and balanced-best-effort. Default is balanced-best-effort.</summary>
    [JsonPropertyName("capacityDistributionStrategy")]
    public string? CapacityDistributionStrategy { get; set; }
}

/// <summary>Describes a target Capacity Reservation or Capacity Reservation resource group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderCapacityReservationSpecificationCapacityReservationTarget
{
    /// <summary>List of On-Demand Capacity Reservation Ids. Conflicts with capacity_reservation_resource_group_arns.</summary>
    [JsonPropertyName("capacityReservationIds")]
    public IList<string>? CapacityReservationIds { get; set; }

    /// <summary>List of On-Demand Capacity Reservation Resource Group Arns. Conflicts with capacity_reservation_ids.</summary>
    [JsonPropertyName("capacityReservationResourceGroupArns")]
    public IList<string>? CapacityReservationResourceGroupArns { get; set; }
}

/// <summary>Demand Capacity Reservations. See Capacity Reservation Specification below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderCapacityReservationSpecification
{
    /// <summary>Capacity Reservation preference helps you use Capacity Reservations efficiently by prioritizing reserved capacity in a Capacity Reservation before using On-Demand capacity. Valid values are default, capacity-reservations-only, capacity-reservations-first and none. Default is default.</summary>
    [JsonPropertyName("capacityReservationPreference")]
    public string? CapacityReservationPreference { get; set; }

    /// <summary>Describes a target Capacity Reservation or Capacity Reservation resource group.</summary>
    [JsonPropertyName("capacityReservationTarget")]
    public V1beta1AutoscalingGroupSpecInitProviderCapacityReservationSpecificationCapacityReservationTarget? CapacityReservationTarget { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderInitialLifecycleHook
{
    /// <summary></summary>
    [JsonPropertyName("defaultResult")]
    public string? DefaultResult { get; set; }

    /// <summary></summary>
    [JsonPropertyName("heartbeatTimeout")]
    public double? HeartbeatTimeout { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lifecycleTransition")]
    public string? LifecycleTransition { get; set; }

    /// <summary>Name of the Auto Scaling Group. Conflicts with name_prefix.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notificationMetadata")]
    public string? NotificationMetadata { get; set; }

    /// <summary>ARN for this Auto Scaling Group</summary>
    [JsonPropertyName("notificationTargetArn")]
    public string? NotificationTargetArn { get; set; }

    /// <summary>ARN for this Auto Scaling Group</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>If this block is configured, add a instance maintenance policy to the specified Auto Scaling group. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderInstanceMaintenancePolicy
{
    /// <summary>Amount of capacity in the Auto Scaling group that can be in service and healthy, or pending, to support your workload when an instance refresh is in place, as a percentage of the desired capacity of the Auto Scaling group. Values must be between 100 and 200, defaults to 100.</summary>
    [JsonPropertyName("maxHealthyPercentage")]
    public double? MaxHealthyPercentage { get; set; }

    /// <summary>Amount of capacity in the Auto Scaling group that must remain healthy during an instance refresh to allow the operation to continue, as a percentage of the desired capacity of the Auto Scaling group. Defaults to 90.</summary>
    [JsonPropertyName("minHealthyPercentage")]
    public double? MinHealthyPercentage { get; set; }
}

/// <summary>Alarm Specification for Instance Refresh.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderInstanceRefreshPreferencesAlarmSpecification
{
    /// <summary>List of Cloudwatch alarms. If any of these alarms goes into ALARM state, Instance Refresh is failed.</summary>
    [JsonPropertyName("alarms")]
    public IList<string>? Alarms { get; set; }
}

/// <summary>Override default parameters for Instance Refresh.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderInstanceRefreshPreferences
{
    /// <summary>Alarm Specification for Instance Refresh.</summary>
    [JsonPropertyName("alarmSpecification")]
    public V1beta1AutoscalingGroupSpecInitProviderInstanceRefreshPreferencesAlarmSpecification? AlarmSpecification { get; set; }

    /// <summary>Automatically rollback if instance refresh fails. Defaults to false. This option may only be set to true when specifying a launch_template or mixed_instances_policy.</summary>
    [JsonPropertyName("autoRollback")]
    public bool? AutoRollback { get; set; }

    /// <summary>Number of seconds to wait after a checkpoint. Defaults to 3600.</summary>
    [JsonPropertyName("checkpointDelay")]
    public string? CheckpointDelay { get; set; }

    /// <summary>List of percentages for each checkpoint. Values must be unique and in ascending order. To replace all instances, the final number must be 100.</summary>
    [JsonPropertyName("checkpointPercentages")]
    public IList<double>? CheckpointPercentages { get; set; }

    /// <summary>Number of seconds until a newly launched instance is configured and ready to use. Default behavior is to use the Auto Scaling Group's health check grace period.</summary>
    [JsonPropertyName("instanceWarmup")]
    public string? InstanceWarmup { get; set; }

    /// <summary>Amount of capacity in the Auto Scaling group that can be in service and healthy, or pending, to support your workload when an instance refresh is in place, as a percentage of the desired capacity of the Auto Scaling group. Values must be between 100 and 200, defaults to 100.</summary>
    [JsonPropertyName("maxHealthyPercentage")]
    public double? MaxHealthyPercentage { get; set; }

    /// <summary>Amount of capacity in the Auto Scaling group that must remain healthy during an instance refresh to allow the operation to continue, as a percentage of the desired capacity of the Auto Scaling group. Defaults to 90.</summary>
    [JsonPropertyName("minHealthyPercentage")]
    public double? MinHealthyPercentage { get; set; }

    /// <summary>Behavior when encountering instances protected from scale in are found. Available behaviors are Refresh, Ignore, and Wait. Default is Ignore.</summary>
    [JsonPropertyName("scaleInProtectedInstances")]
    public string? ScaleInProtectedInstances { get; set; }

    /// <summary>Replace instances that already have your desired configuration. Defaults to false.</summary>
    [JsonPropertyName("skipMatching")]
    public bool? SkipMatching { get; set; }

    /// <summary>Behavior when encountering instances in the Standby state in are found. Available behaviors are Terminate, Ignore, and Wait. Default is Ignore.</summary>
    [JsonPropertyName("standbyInstances")]
    public string? StandbyInstances { get; set; }
}

/// <summary>If this block is configured, start an Instance Refresh when this Auto Scaling Group is updated. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderInstanceRefresh
{
    /// <summary>Override default parameters for Instance Refresh.</summary>
    [JsonPropertyName("preferences")]
    public V1beta1AutoscalingGroupSpecInitProviderInstanceRefreshPreferences? Preferences { get; set; }

    /// <summary>Strategy to use for instance refresh. The only allowed value is Rolling. See StartInstanceRefresh Action for more information.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }

    /// <summary>Set of additional property names that will trigger an Instance Refresh. A refresh will always be triggered by a change in any of launch_configuration, launch_template, or mixed_instances_policy.</summary>
    [JsonPropertyName("triggers")]
    public IList<string>? Triggers { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderLaunchConfigurationRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LaunchConfiguration in autoscaling to populate launchConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderLaunchConfigurationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AutoscalingGroupSpecInitProviderLaunchConfigurationRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderLaunchConfigurationSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LaunchConfiguration in autoscaling to populate launchConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderLaunchConfigurationSelector
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
    public V1beta1AutoscalingGroupSpecInitProviderLaunchConfigurationSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderLaunchTemplateIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LaunchTemplate in ec2 to populate id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderLaunchTemplateIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AutoscalingGroupSpecInitProviderLaunchTemplateIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderLaunchTemplateIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LaunchTemplate in ec2 to populate id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderLaunchTemplateIdSelector
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
    public V1beta1AutoscalingGroupSpecInitProviderLaunchTemplateIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Nested argument with Launch template specification to use to launch instances. See Launch Template below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderLaunchTemplate
{
    /// <summary>ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Reference to a LaunchTemplate in ec2 to populate id.</summary>
    [JsonPropertyName("idRef")]
    public V1beta1AutoscalingGroupSpecInitProviderLaunchTemplateIdRef? IdRef { get; set; }

    /// <summary>Selector for a LaunchTemplate in ec2 to populate id.</summary>
    [JsonPropertyName("idSelector")]
    public V1beta1AutoscalingGroupSpecInitProviderLaunchTemplateIdSelector? IdSelector { get; set; }

    /// <summary>Name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Template version. Can be version number, $Latest, or $Default. (Default: $Default).</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Nested argument containing settings on how to mix on-demand and Spot instances in the Auto Scaling group. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyInstancesDistribution
{
    /// <summary>Strategy to use when launching on-demand instances. Valid values: prioritized, lowest-price. Default: prioritized.</summary>
    [JsonPropertyName("onDemandAllocationStrategy")]
    public string? OnDemandAllocationStrategy { get; set; }

    /// <summary>Absolute minimum amount of desired capacity that must be fulfilled by on-demand instances. Default: 0.</summary>
    [JsonPropertyName("onDemandBaseCapacity")]
    public double? OnDemandBaseCapacity { get; set; }

    /// <summary>Percentage split between on-demand and Spot instances above the base on-demand capacity. Default: 100.</summary>
    [JsonPropertyName("onDemandPercentageAboveBaseCapacity")]
    public double? OnDemandPercentageAboveBaseCapacity { get; set; }

    /// <summary>How to allocate capacity across the Spot pools. Valid values: lowest-price, capacity-optimized, capacity-optimized-prioritized, and price-capacity-optimized. Default: lowest-price.</summary>
    [JsonPropertyName("spotAllocationStrategy")]
    public string? SpotAllocationStrategy { get; set; }

    /// <summary>Number of Spot pools per availability zone to allocate capacity. EC2 Auto Scaling selects the cheapest Spot pools and evenly allocates Spot capacity across the number of Spot pools that you specify. Only available with spot_allocation_strategy set to lowest-price. Otherwise it must be set to 0, if it has been defined before. Default: 2.</summary>
    [JsonPropertyName("spotInstancePools")]
    public double? SpotInstancePools { get; set; }

    /// <summary>Maximum price per unit hour that the user is willing to pay for the Spot instances. Default: an empty string which means the on-demand price.</summary>
    [JsonPropertyName("spotMaxPrice")]
    public string? SpotMaxPrice { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LaunchTemplate in ec2 to populate launchTemplateId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LaunchTemplate in ec2 to populate launchTemplateId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdSelector
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
    public V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Nested argument defines the Launch Template. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification
{
    /// <summary>ID of the launch template. Conflicts with launch_template_name.</summary>
    [JsonPropertyName("launchTemplateId")]
    public string? LaunchTemplateId { get; set; }

    /// <summary>Reference to a LaunchTemplate in ec2 to populate launchTemplateId.</summary>
    [JsonPropertyName("launchTemplateIdRef")]
    public V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdRef? LaunchTemplateIdRef { get; set; }

    /// <summary>Selector for a LaunchTemplate in ec2 to populate launchTemplateId.</summary>
    [JsonPropertyName("launchTemplateIdSelector")]
    public V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdSelector? LaunchTemplateIdSelector { get; set; }

    /// <summary>Name of the launch template. Conflicts with launch_template_id.</summary>
    [JsonPropertyName("launchTemplateName")]
    public string? LaunchTemplateName { get; set; }

    /// <summary>Template version. Can be version number, $Latest, or $Default. (Default: $Default).</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Block describing the minimum and maximum number of accelerators (GPUs, FPGAs, or AWS Inferentia chips). Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsAcceleratorCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum total memory of the accelerators. Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsAcceleratorTotalMemoryMib
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum baseline EBS bandwidth, in Mbps. Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsBaselineEbsBandwidthMbps
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum amount of memory (GiB) per vCPU. Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsMemoryGibPerVcpu
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum amount of memory (MiB). Default is no maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsMemoryMib
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum amount of network bandwidth, in gigabits per second (Gbps). Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsNetworkBandwidthGbps
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum number of network interfaces. Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsNetworkInterfaceCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum total local storage (GB). Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsTotalLocalStorageGb
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum number of vCPUs. Default is no maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsVcpuCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Override the instance type in the Launch Template with instance types that satisfy the requirements.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirements
{
    /// <summary>Block describing the minimum and maximum number of accelerators (GPUs, FPGAs, or AWS Inferentia chips). Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorCount")]
    public V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsAcceleratorCount? AcceleratorCount { get; set; }

    /// <summary>List of accelerator manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("acceleratorManufacturers")]
    public IList<string>? AcceleratorManufacturers { get; set; }

    /// <summary>List of accelerator names. Default is any acclerator.</summary>
    [JsonPropertyName("acceleratorNames")]
    public IList<string>? AcceleratorNames { get; set; }

    /// <summary>Block describing the minimum and maximum total memory of the accelerators. Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorTotalMemoryMib")]
    public V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsAcceleratorTotalMemoryMib? AcceleratorTotalMemoryMib { get; set; }

    /// <summary>List of accelerator types. Default is any accelerator type.</summary>
    [JsonPropertyName("acceleratorTypes")]
    public IList<string>? AcceleratorTypes { get; set; }

    /// <summary>List of instance types to apply your specified attributes against. All other instance types are ignored, even if they match your specified attributes. You can use strings with one or more wild cards, represented by an asterisk (*), to allow an instance type, size, or generation. The following are examples: m5.8xlarge, c5*.*, m5a.*, r*, *3*. For example, if you specify c5*, you are allowing the entire C5 instance family, which includes all C5a and C5n instance types. If you specify m5a.*, you are allowing all the M5a instance types, but not the M5n instance types. Maximum of 400 entries in the list; each entry is limited to 30 characters. Default is all instance types.</summary>
    [JsonPropertyName("allowedInstanceTypes")]
    public IList<string>? AllowedInstanceTypes { get; set; }

    /// <summary>Indicate whether bare metal instace types should be included, excluded, or required. Default is excluded.</summary>
    [JsonPropertyName("bareMetal")]
    public string? BareMetal { get; set; }

    /// <summary>Block describing the minimum and maximum baseline EBS bandwidth, in Mbps. Default is no minimum or maximum.</summary>
    [JsonPropertyName("baselineEbsBandwidthMbps")]
    public V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsBaselineEbsBandwidthMbps? BaselineEbsBandwidthMbps { get; set; }

    /// <summary>Indicate whether burstable performance instance types should be included, excluded, or required. Default is excluded.</summary>
    [JsonPropertyName("burstablePerformance")]
    public string? BurstablePerformance { get; set; }

    /// <summary>List of CPU manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("cpuManufacturers")]
    public IList<string>? CpuManufacturers { get; set; }

    /// <summary>List of instance types to exclude. You can use strings with one or more wild cards, represented by an asterisk (*), to exclude an instance type, size, or generation. The following are examples: m5.8xlarge, c5*.*, m5a.*, r*, *3*. For example, if you specify c5*, you are excluding the entire C5 instance family, which includes all C5a and C5n instance types. If you specify m5a.*, you are excluding all the M5a instance types, but not the M5n instance types. Maximum of 400 entries in the list; each entry is limited to 30 characters. Default is no excluded instance types.</summary>
    [JsonPropertyName("excludedInstanceTypes")]
    public IList<string>? ExcludedInstanceTypes { get; set; }

    /// <summary>List of instance generation names. Default is any generation.</summary>
    [JsonPropertyName("instanceGenerations")]
    public IList<string>? InstanceGenerations { get; set; }

    /// <summary>Indicate whether instance types with local storage volumes are included, excluded, or required. Default is included.</summary>
    [JsonPropertyName("localStorage")]
    public string? LocalStorage { get; set; }

    /// <summary>List of local storage type names. Default any storage type.</summary>
    [JsonPropertyName("localStorageTypes")]
    public IList<string>? LocalStorageTypes { get; set; }

    /// <summary>The price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Conflicts with spot_max_price_percentage_over_lowest_price</summary>
    [JsonPropertyName("maxSpotPriceAsPercentageOfOptimalOnDemandPrice")]
    public double? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (GiB) per vCPU. Default is no minimum or maximum.</summary>
    [JsonPropertyName("memoryGibPerVcpu")]
    public V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsMemoryGibPerVcpu? MemoryGibPerVcpu { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (MiB). Default is no maximum.</summary>
    [JsonPropertyName("memoryMib")]
    public V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsMemoryMib? MemoryMib { get; set; }

    /// <summary>Block describing the minimum and maximum amount of network bandwidth, in gigabits per second (Gbps). Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkBandwidthGbps")]
    public V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsNetworkBandwidthGbps? NetworkBandwidthGbps { get; set; }

    /// <summary>Block describing the minimum and maximum number of network interfaces. Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkInterfaceCount")]
    public V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsNetworkInterfaceCount? NetworkInterfaceCount { get; set; }

    /// <summary>Price protection threshold for On-Demand Instances. This is the maximum you’ll pay for an On-Demand Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 20.</summary>
    [JsonPropertyName("onDemandMaxPricePercentageOverLowestPrice")]
    public double? OnDemandMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Indicate whether instance types must support On-Demand Instance Hibernation, either true or false. Default is false.</summary>
    [JsonPropertyName("requireHibernateSupport")]
    public bool? RequireHibernateSupport { get; set; }

    /// <summary>Price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 100. Conflicts with max_spot_price_as_percentage_of_optimal_on_demand_price</summary>
    [JsonPropertyName("spotMaxPricePercentageOverLowestPrice")]
    public double? SpotMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Block describing the minimum and maximum total local storage (GB). Default is no minimum or maximum.</summary>
    [JsonPropertyName("totalLocalStorageGb")]
    public V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsTotalLocalStorageGb? TotalLocalStorageGb { get; set; }

    /// <summary>Block describing the minimum and maximum number of vCPUs. Default is no maximum.</summary>
    [JsonPropertyName("vcpuCount")]
    public V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsVcpuCount? VcpuCount { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LaunchTemplate in ec2 to populate launchTemplateId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LaunchTemplate in ec2 to populate launchTemplateId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdSelector
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
    public V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Nested argument defines the Launch Template. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecification
{
    /// <summary>ID of the launch template. Conflicts with launch_template_name.</summary>
    [JsonPropertyName("launchTemplateId")]
    public string? LaunchTemplateId { get; set; }

    /// <summary>Reference to a LaunchTemplate in ec2 to populate launchTemplateId.</summary>
    [JsonPropertyName("launchTemplateIdRef")]
    public V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdRef? LaunchTemplateIdRef { get; set; }

    /// <summary>Selector for a LaunchTemplate in ec2 to populate launchTemplateId.</summary>
    [JsonPropertyName("launchTemplateIdSelector")]
    public V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdSelector? LaunchTemplateIdSelector { get; set; }

    /// <summary>Name of the launch template. Conflicts with launch_template_id.</summary>
    [JsonPropertyName("launchTemplateName")]
    public string? LaunchTemplateName { get; set; }

    /// <summary>Template version. Can be version number, $Latest, or $Default. (Default: $Default).</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverride
{
    /// <summary>Override the instance type in the Launch Template with instance types that satisfy the requirements.</summary>
    [JsonPropertyName("instanceRequirements")]
    public V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirements? InstanceRequirements { get; set; }

    /// <summary>Override the instance type in the Launch Template.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Nested argument defines the Launch Template. Defined below.</summary>
    [JsonPropertyName("launchTemplateSpecification")]
    public V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecification? LaunchTemplateSpecification { get; set; }

    /// <summary>Number of capacity units, which gives the instance type a proportional weight to other instance types.</summary>
    [JsonPropertyName("weightedCapacity")]
    public string? WeightedCapacity { get; set; }
}

/// <summary>Nested argument containing launch template settings along with the overrides to specify multiple instance types and weights. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplate
{
    /// <summary>Nested argument defines the Launch Template. Defined below.</summary>
    [JsonPropertyName("launchTemplateSpecification")]
    public V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification? LaunchTemplateSpecification { get; set; }

    /// <summary>List of nested arguments provides the ability to specify multiple instance types. This will override the same parameter in the launch template. For on-demand instances, Auto Scaling considers the order of preference of instance types to launch based on the order specified in the overrides list. Defined below.</summary>
    [JsonPropertyName("override")]
    public IList<V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverride>? Override { get; set; }
}

/// <summary>Configuration block containing settings to define launch targets for Auto Scaling groups. See Mixed Instances Policy below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicy
{
    /// <summary>Nested argument containing settings on how to mix on-demand and Spot instances in the Auto Scaling group. Defined below.</summary>
    [JsonPropertyName("instancesDistribution")]
    public V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyInstancesDistribution? InstancesDistribution { get; set; }

    /// <summary>Nested argument containing launch template settings along with the overrides to specify multiple instance types and weights. Defined below.</summary>
    [JsonPropertyName("launchTemplate")]
    public V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplate? LaunchTemplate { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderPlacementGroupRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a PlacementGroup in ec2 to populate placementGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderPlacementGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AutoscalingGroupSpecInitProviderPlacementGroupRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderPlacementGroupSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a PlacementGroup in ec2 to populate placementGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderPlacementGroupSelector
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
    public V1beta1AutoscalingGroupSpecInitProviderPlacementGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderServiceLinkedRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceLinkedRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderServiceLinkedRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AutoscalingGroupSpecInitProviderServiceLinkedRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderServiceLinkedRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceLinkedRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderServiceLinkedRoleArnSelector
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
    public V1beta1AutoscalingGroupSpecInitProviderServiceLinkedRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderTag
{
    /// <summary>Key</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Enables propagation of the tag to Amazon EC2 instances launched via this ASG</summary>
    [JsonPropertyName("propagateAtLaunch")]
    public bool? PropagateAtLaunch { get; set; }

    /// <summary>Value</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderTrafficSource
{
    /// <summary>Identifies the traffic source. For Application Load Balancers, Gateway Load Balancers, Network Load Balancers, and VPC Lattice, this will be the Amazon Resource Name (ARN) for a target group in this account and Region. For Classic Load Balancers, this will be the name of the Classic Load Balancer in this account and Region.</summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }

    /// <summary>Provides additional context for the value of Identifier. The following lists the valid values: elb if identifier is the name of a Classic Load Balancer. elbv2 if identifier is the ARN of an Application Load Balancer, Gateway Load Balancer, or Network Load Balancer target group. vpc-lattice if identifier is the ARN of a VPC Lattice target group.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderVpcZoneIdentifierRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderVpcZoneIdentifierRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AutoscalingGroupSpecInitProviderVpcZoneIdentifierRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderVpcZoneIdentifierSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate vpcZoneIdentifier.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderVpcZoneIdentifierSelector
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
    public V1beta1AutoscalingGroupSpecInitProviderVpcZoneIdentifierSelectorPolicy? Policy { get; set; }
}

/// <summary>Whether instances in the Auto Scaling group can be returned to the warm pool on scale in. The default is to terminate instances in the Auto Scaling group when the group scales in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderWarmPoolInstanceReusePolicy
{
    /// <summary>Whether instances in the Auto Scaling group can be returned to the warm pool on scale in.</summary>
    [JsonPropertyName("reuseOnScaleIn")]
    public bool? ReuseOnScaleIn { get; set; }
}

/// <summary>If this block is configured, add a Warm Pool to the specified Auto Scaling group. Defined below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProviderWarmPool
{
    /// <summary>Whether instances in the Auto Scaling group can be returned to the warm pool on scale in. The default is to terminate instances in the Auto Scaling group when the group scales in.</summary>
    [JsonPropertyName("instanceReusePolicy")]
    public V1beta1AutoscalingGroupSpecInitProviderWarmPoolInstanceReusePolicy? InstanceReusePolicy { get; set; }

    /// <summary>Total maximum number of instances that are allowed to be in the warm pool or in any state except Terminated for the Auto Scaling group.</summary>
    [JsonPropertyName("maxGroupPreparedCapacity")]
    public double? MaxGroupPreparedCapacity { get; set; }

    /// <summary>Minimum size of the Auto Scaling Group. (See also Waiting for Capacity below.)</summary>
    [JsonPropertyName("minSize")]
    public double? MinSize { get; set; }

    /// <summary>Sets the instance state to transition to after the lifecycle hooks finish. Valid values are: Stopped (default), Running or Hibernated.</summary>
    [JsonPropertyName("poolState")]
    public string? PoolState { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecInitProvider
{
    /// <summary>The instance capacity distribution across Availability Zones. See Availability Zone Distribution below for more details.</summary>
    [JsonPropertyName("availabilityZoneDistribution")]
    public V1beta1AutoscalingGroupSpecInitProviderAvailabilityZoneDistribution? AvailabilityZoneDistribution { get; set; }

    /// <summary>A list of Availability Zones where instances in the Auto Scaling group can be created. Used for launching into the default VPC subnet in each Availability Zone when not using the vpc_zone_identifier attribute, or for attaching a network interface when an existing network interface ID is specified in a launch template. Conflicts with vpc_zone_identifier.</summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>Whether capacity rebalance is enabled. Otherwise, capacity rebalance is disabled.</summary>
    [JsonPropertyName("capacityRebalance")]
    public bool? CapacityRebalance { get; set; }

    /// <summary>Demand Capacity Reservations. See Capacity Reservation Specification below for more details.</summary>
    [JsonPropertyName("capacityReservationSpecification")]
    public V1beta1AutoscalingGroupSpecInitProviderCapacityReservationSpecification? CapacityReservationSpecification { get; set; }

    /// <summary>Reserved.</summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    /// <summary>Amount of time, in seconds, after a scaling activity completes before another scaling activity can start.</summary>
    [JsonPropertyName("defaultCooldown")]
    public double? DefaultCooldown { get; set; }

    /// <summary>Amount of time, in seconds, until a newly launched instance can contribute to the Amazon CloudWatch metrics. This delay lets an instance finish initializing before Amazon EC2 Auto Scaling aggregates instance metrics, resulting in more reliable usage data. Set this value equal to the amount of time that it takes for resource consumption to become stable after an instance reaches the InService state. (See Set the default instance warmup for an Auto Scaling group)</summary>
    [JsonPropertyName("defaultInstanceWarmup")]
    public double? DefaultInstanceWarmup { get; set; }

    /// <summary>Number of Amazon EC2 instances that should be running in the group. (See also Waiting for Capacity below.)</summary>
    [JsonPropertyName("desiredCapacity")]
    public double? DesiredCapacity { get; set; }

    /// <summary>The unit of measurement for the value specified for desired_capacity. Supported for attribute-based instance type selection only. Valid values: "units", "vcpu", "memory-mib".</summary>
    [JsonPropertyName("desiredCapacityType")]
    public string? DesiredCapacityType { get; set; }

    /// <summary>List of metrics to collect. The allowed values are defined by the underlying AWS API.</summary>
    [JsonPropertyName("enabledMetrics")]
    public IList<string>? EnabledMetrics { get; set; }

    /// <summary>Allows deleting the Auto Scaling Group without waiting for all instances in the pool to terminate. You can force an Auto Scaling Group to delete even if it's in the process of scaling a resource. This bypasses that behavior and potentially leaves resources dangling.</summary>
    [JsonPropertyName("forceDelete")]
    public bool? ForceDelete { get; set; }

    /// <summary>Allows deleting the Auto Scaling Group without waiting for all instances in the warm pool to terminate.</summary>
    [JsonPropertyName("forceDeleteWarmPool")]
    public bool? ForceDeleteWarmPool { get; set; }

    /// <summary>Time (in seconds) after instance comes into service before checking health.</summary>
    [JsonPropertyName("healthCheckGracePeriod")]
    public double? HealthCheckGracePeriod { get; set; }

    /// <summary>"EC2" or "ELB". Controls how health checking is done.</summary>
    [JsonPropertyName("healthCheckType")]
    public string? HealthCheckType { get; set; }

    /// <summary>Whether to ignore failed Auto Scaling scaling activities while waiting for capacity. The default is false -- failed scaling activities cause errors to be returned.</summary>
    [JsonPropertyName("ignoreFailedScalingActivities")]
    public bool? IgnoreFailedScalingActivities { get; set; }

    /// <summary>One or more Lifecycle Hooks to attach to the Auto Scaling Group before instances are launched. The syntax is exactly the same as the separate aws_autoscaling_lifecycle_hook resource, without the autoscaling_group_name attribute. Please note that this will only work when creating a new Auto Scaling Group. For all other use-cases, please use aws_autoscaling_lifecycle_hook resource.</summary>
    [JsonPropertyName("initialLifecycleHook")]
    public IList<V1beta1AutoscalingGroupSpecInitProviderInitialLifecycleHook>? InitialLifecycleHook { get; set; }

    /// <summary>If this block is configured, add a instance maintenance policy to the specified Auto Scaling group. Defined below.</summary>
    [JsonPropertyName("instanceMaintenancePolicy")]
    public V1beta1AutoscalingGroupSpecInitProviderInstanceMaintenancePolicy? InstanceMaintenancePolicy { get; set; }

    /// <summary>If this block is configured, start an Instance Refresh when this Auto Scaling Group is updated. Defined below.</summary>
    [JsonPropertyName("instanceRefresh")]
    public V1beta1AutoscalingGroupSpecInitProviderInstanceRefresh? InstanceRefresh { get; set; }

    /// <summary>Name of the launch configuration to use.</summary>
    [JsonPropertyName("launchConfiguration")]
    public string? LaunchConfiguration { get; set; }

    /// <summary>Reference to a LaunchConfiguration in autoscaling to populate launchConfiguration.</summary>
    [JsonPropertyName("launchConfigurationRef")]
    public V1beta1AutoscalingGroupSpecInitProviderLaunchConfigurationRef? LaunchConfigurationRef { get; set; }

    /// <summary>Selector for a LaunchConfiguration in autoscaling to populate launchConfiguration.</summary>
    [JsonPropertyName("launchConfigurationSelector")]
    public V1beta1AutoscalingGroupSpecInitProviderLaunchConfigurationSelector? LaunchConfigurationSelector { get; set; }

    /// <summary>Nested argument with Launch template specification to use to launch instances. See Launch Template below for more details.</summary>
    [JsonPropertyName("launchTemplate")]
    public V1beta1AutoscalingGroupSpecInitProviderLaunchTemplate? LaunchTemplate { get; set; }

    /// <summary>Maximum amount of time, in seconds, that an instance can be in service, values must be either equal to 0 or between 86400 and 31536000 seconds.</summary>
    [JsonPropertyName("maxInstanceLifetime")]
    public double? MaxInstanceLifetime { get; set; }

    /// <summary>Maximum size of the Auto Scaling Group.</summary>
    [JsonPropertyName("maxSize")]
    public double? MaxSize { get; set; }

    /// <summary>Granularity to associate with the metrics to collect. The only valid value is 1Minute. Default is 1Minute.</summary>
    [JsonPropertyName("metricsGranularity")]
    public string? MetricsGranularity { get; set; }

    /// <summary>Updates will not wait on ELB instance number changes. (See also Waiting for Capacity below.)</summary>
    [JsonPropertyName("minElbCapacity")]
    public double? MinElbCapacity { get; set; }

    /// <summary>Minimum size of the Auto Scaling Group. (See also Waiting for Capacity below.)</summary>
    [JsonPropertyName("minSize")]
    public double? MinSize { get; set; }

    /// <summary>Configuration block containing settings to define launch targets for Auto Scaling groups. See Mixed Instances Policy below for more details.</summary>
    [JsonPropertyName("mixedInstancesPolicy")]
    public V1beta1AutoscalingGroupSpecInitProviderMixedInstancesPolicy? MixedInstancesPolicy { get; set; }

    /// <summary>Name of the placement group into which you'll launch your instances, if any.</summary>
    [JsonPropertyName("placementGroup")]
    public string? PlacementGroup { get; set; }

    /// <summary>Reference to a PlacementGroup in ec2 to populate placementGroup.</summary>
    [JsonPropertyName("placementGroupRef")]
    public V1beta1AutoscalingGroupSpecInitProviderPlacementGroupRef? PlacementGroupRef { get; set; }

    /// <summary>Selector for a PlacementGroup in ec2 to populate placementGroup.</summary>
    [JsonPropertyName("placementGroupSelector")]
    public V1beta1AutoscalingGroupSpecInitProviderPlacementGroupSelector? PlacementGroupSelector { get; set; }

    /// <summary>Whether newly launched instances are automatically protected from termination by Amazon EC2 Auto Scaling when scaling in. For more information about preventing instances from terminating on scale in, see Using instance scale-in protection in the Amazon EC2 Auto Scaling User Guide.</summary>
    [JsonPropertyName("protectFromScaleIn")]
    public bool? ProtectFromScaleIn { get; set; }

    /// <summary>ARN of the service-linked role that the ASG will use to call other AWS services</summary>
    [JsonPropertyName("serviceLinkedRoleArn")]
    public string? ServiceLinkedRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceLinkedRoleArn.</summary>
    [JsonPropertyName("serviceLinkedRoleArnRef")]
    public V1beta1AutoscalingGroupSpecInitProviderServiceLinkedRoleArnRef? ServiceLinkedRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceLinkedRoleArn.</summary>
    [JsonPropertyName("serviceLinkedRoleArnSelector")]
    public V1beta1AutoscalingGroupSpecInitProviderServiceLinkedRoleArnSelector? ServiceLinkedRoleArnSelector { get; set; }

    /// <summary>List of processes to suspend for the Auto Scaling Group. The allowed values are Launch, Terminate, HealthCheck, ReplaceUnhealthy, AZRebalance, AlarmNotification, ScheduledActions, AddToLoadBalancer, InstanceRefresh. Note that if you suspend either the Launch or Terminate process types, it can prevent your Auto Scaling Group from functioning properly.</summary>
    [JsonPropertyName("suspendedProcesses")]
    public IList<string>? SuspendedProcesses { get; set; }

    /// <summary>Configuration block(s) containing resource tags. See Tag below for more details.</summary>
    [JsonPropertyName("tag")]
    public IList<V1beta1AutoscalingGroupSpecInitProviderTag>? Tag { get; set; }

    /// <summary>List of policies to decide how the instances in the Auto Scaling Group should be terminated. The allowed values are OldestInstance, NewestInstance, OldestLaunchConfiguration, ClosestToNextInstanceHour, OldestLaunchTemplate, AllocationStrategy, Default. Additionally, the ARN of a Lambda function can be specified for custom termination policies.</summary>
    [JsonPropertyName("terminationPolicies")]
    public IList<string>? TerminationPolicies { get; set; }

    /// <summary>Attaches one or more traffic sources to the specified Auto Scaling group.</summary>
    [JsonPropertyName("trafficSource")]
    public IList<V1beta1AutoscalingGroupSpecInitProviderTrafficSource>? TrafficSource { get; set; }

    /// <summary>List of subnet IDs to launch resources in. Subnets automatically determine which availability zones the group will reside. Conflicts with availability_zones.</summary>
    [JsonPropertyName("vpcZoneIdentifier")]
    public IList<string>? VpcZoneIdentifier { get; set; }

    /// <summary>References to Subnet in ec2 to populate vpcZoneIdentifier.</summary>
    [JsonPropertyName("vpcZoneIdentifierRefs")]
    public IList<V1beta1AutoscalingGroupSpecInitProviderVpcZoneIdentifierRefs>? VpcZoneIdentifierRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate vpcZoneIdentifier.</summary>
    [JsonPropertyName("vpcZoneIdentifierSelector")]
    public V1beta1AutoscalingGroupSpecInitProviderVpcZoneIdentifierSelector? VpcZoneIdentifierSelector { get; set; }

    /// <summary>(See also Waiting for Capacity below.</summary>
    [JsonPropertyName("waitForCapacityTimeout")]
    public string? WaitForCapacityTimeout { get; set; }

    /// <summary>(Takes precedence over min_elb_capacity behavior.) (See also Waiting for Capacity below.)</summary>
    [JsonPropertyName("waitForElbCapacity")]
    public double? WaitForElbCapacity { get; set; }

    /// <summary>If this block is configured, add a Warm Pool to the specified Auto Scaling group. Defined below</summary>
    [JsonPropertyName("warmPool")]
    public V1beta1AutoscalingGroupSpecInitProviderWarmPool? WarmPool { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpecProviderConfigRef
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
public partial class V1beta1AutoscalingGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>AutoscalingGroupSpec defines the desired state of AutoscalingGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1AutoscalingGroupSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1AutoscalingGroupSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AutoscalingGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AutoscalingGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>The instance capacity distribution across Availability Zones. See Availability Zone Distribution below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatusAtProviderAvailabilityZoneDistribution
{
    /// <summary>The strategy to use for distributing capacity across the Availability Zones. Valid values are balanced-only and balanced-best-effort. Default is balanced-best-effort.</summary>
    [JsonPropertyName("capacityDistributionStrategy")]
    public string? CapacityDistributionStrategy { get; set; }
}

/// <summary>Describes a target Capacity Reservation or Capacity Reservation resource group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatusAtProviderCapacityReservationSpecificationCapacityReservationTarget
{
    /// <summary>List of On-Demand Capacity Reservation Ids. Conflicts with capacity_reservation_resource_group_arns.</summary>
    [JsonPropertyName("capacityReservationIds")]
    public IList<string>? CapacityReservationIds { get; set; }

    /// <summary>List of On-Demand Capacity Reservation Resource Group Arns. Conflicts with capacity_reservation_ids.</summary>
    [JsonPropertyName("capacityReservationResourceGroupArns")]
    public IList<string>? CapacityReservationResourceGroupArns { get; set; }
}

/// <summary>Demand Capacity Reservations. See Capacity Reservation Specification below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatusAtProviderCapacityReservationSpecification
{
    /// <summary>Capacity Reservation preference helps you use Capacity Reservations efficiently by prioritizing reserved capacity in a Capacity Reservation before using On-Demand capacity. Valid values are default, capacity-reservations-only, capacity-reservations-first and none. Default is default.</summary>
    [JsonPropertyName("capacityReservationPreference")]
    public string? CapacityReservationPreference { get; set; }

    /// <summary>Describes a target Capacity Reservation or Capacity Reservation resource group.</summary>
    [JsonPropertyName("capacityReservationTarget")]
    public V1beta1AutoscalingGroupStatusAtProviderCapacityReservationSpecificationCapacityReservationTarget? CapacityReservationTarget { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatusAtProviderInitialLifecycleHook
{
    /// <summary></summary>
    [JsonPropertyName("defaultResult")]
    public string? DefaultResult { get; set; }

    /// <summary></summary>
    [JsonPropertyName("heartbeatTimeout")]
    public double? HeartbeatTimeout { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lifecycleTransition")]
    public string? LifecycleTransition { get; set; }

    /// <summary>Name of the Auto Scaling Group. Conflicts with name_prefix.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notificationMetadata")]
    public string? NotificationMetadata { get; set; }

    /// <summary>ARN for this Auto Scaling Group</summary>
    [JsonPropertyName("notificationTargetArn")]
    public string? NotificationTargetArn { get; set; }

    /// <summary>ARN for this Auto Scaling Group</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>If this block is configured, add a instance maintenance policy to the specified Auto Scaling group. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatusAtProviderInstanceMaintenancePolicy
{
    /// <summary>Amount of capacity in the Auto Scaling group that can be in service and healthy, or pending, to support your workload when an instance refresh is in place, as a percentage of the desired capacity of the Auto Scaling group. Values must be between 100 and 200, defaults to 100.</summary>
    [JsonPropertyName("maxHealthyPercentage")]
    public double? MaxHealthyPercentage { get; set; }

    /// <summary>Amount of capacity in the Auto Scaling group that must remain healthy during an instance refresh to allow the operation to continue, as a percentage of the desired capacity of the Auto Scaling group. Defaults to 90.</summary>
    [JsonPropertyName("minHealthyPercentage")]
    public double? MinHealthyPercentage { get; set; }
}

/// <summary>Alarm Specification for Instance Refresh.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatusAtProviderInstanceRefreshPreferencesAlarmSpecification
{
    /// <summary>List of Cloudwatch alarms. If any of these alarms goes into ALARM state, Instance Refresh is failed.</summary>
    [JsonPropertyName("alarms")]
    public IList<string>? Alarms { get; set; }
}

/// <summary>Override default parameters for Instance Refresh.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatusAtProviderInstanceRefreshPreferences
{
    /// <summary>Alarm Specification for Instance Refresh.</summary>
    [JsonPropertyName("alarmSpecification")]
    public V1beta1AutoscalingGroupStatusAtProviderInstanceRefreshPreferencesAlarmSpecification? AlarmSpecification { get; set; }

    /// <summary>Automatically rollback if instance refresh fails. Defaults to false. This option may only be set to true when specifying a launch_template or mixed_instances_policy.</summary>
    [JsonPropertyName("autoRollback")]
    public bool? AutoRollback { get; set; }

    /// <summary>Number of seconds to wait after a checkpoint. Defaults to 3600.</summary>
    [JsonPropertyName("checkpointDelay")]
    public string? CheckpointDelay { get; set; }

    /// <summary>List of percentages for each checkpoint. Values must be unique and in ascending order. To replace all instances, the final number must be 100.</summary>
    [JsonPropertyName("checkpointPercentages")]
    public IList<double>? CheckpointPercentages { get; set; }

    /// <summary>Number of seconds until a newly launched instance is configured and ready to use. Default behavior is to use the Auto Scaling Group's health check grace period.</summary>
    [JsonPropertyName("instanceWarmup")]
    public string? InstanceWarmup { get; set; }

    /// <summary>Amount of capacity in the Auto Scaling group that can be in service and healthy, or pending, to support your workload when an instance refresh is in place, as a percentage of the desired capacity of the Auto Scaling group. Values must be between 100 and 200, defaults to 100.</summary>
    [JsonPropertyName("maxHealthyPercentage")]
    public double? MaxHealthyPercentage { get; set; }

    /// <summary>Amount of capacity in the Auto Scaling group that must remain healthy during an instance refresh to allow the operation to continue, as a percentage of the desired capacity of the Auto Scaling group. Defaults to 90.</summary>
    [JsonPropertyName("minHealthyPercentage")]
    public double? MinHealthyPercentage { get; set; }

    /// <summary>Behavior when encountering instances protected from scale in are found. Available behaviors are Refresh, Ignore, and Wait. Default is Ignore.</summary>
    [JsonPropertyName("scaleInProtectedInstances")]
    public string? ScaleInProtectedInstances { get; set; }

    /// <summary>Replace instances that already have your desired configuration. Defaults to false.</summary>
    [JsonPropertyName("skipMatching")]
    public bool? SkipMatching { get; set; }

    /// <summary>Behavior when encountering instances in the Standby state in are found. Available behaviors are Terminate, Ignore, and Wait. Default is Ignore.</summary>
    [JsonPropertyName("standbyInstances")]
    public string? StandbyInstances { get; set; }
}

/// <summary>If this block is configured, start an Instance Refresh when this Auto Scaling Group is updated. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatusAtProviderInstanceRefresh
{
    /// <summary>Override default parameters for Instance Refresh.</summary>
    [JsonPropertyName("preferences")]
    public V1beta1AutoscalingGroupStatusAtProviderInstanceRefreshPreferences? Preferences { get; set; }

    /// <summary>Strategy to use for instance refresh. The only allowed value is Rolling. See StartInstanceRefresh Action for more information.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }

    /// <summary>Set of additional property names that will trigger an Instance Refresh. A refresh will always be triggered by a change in any of launch_configuration, launch_template, or mixed_instances_policy.</summary>
    [JsonPropertyName("triggers")]
    public IList<string>? Triggers { get; set; }
}

/// <summary>Nested argument with Launch template specification to use to launch instances. See Launch Template below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatusAtProviderLaunchTemplate
{
    /// <summary>ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Template version. Can be version number, $Latest, or $Default. (Default: $Default).</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Nested argument containing settings on how to mix on-demand and Spot instances in the Auto Scaling group. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicyInstancesDistribution
{
    /// <summary>Strategy to use when launching on-demand instances. Valid values: prioritized, lowest-price. Default: prioritized.</summary>
    [JsonPropertyName("onDemandAllocationStrategy")]
    public string? OnDemandAllocationStrategy { get; set; }

    /// <summary>Absolute minimum amount of desired capacity that must be fulfilled by on-demand instances. Default: 0.</summary>
    [JsonPropertyName("onDemandBaseCapacity")]
    public double? OnDemandBaseCapacity { get; set; }

    /// <summary>Percentage split between on-demand and Spot instances above the base on-demand capacity. Default: 100.</summary>
    [JsonPropertyName("onDemandPercentageAboveBaseCapacity")]
    public double? OnDemandPercentageAboveBaseCapacity { get; set; }

    /// <summary>How to allocate capacity across the Spot pools. Valid values: lowest-price, capacity-optimized, capacity-optimized-prioritized, and price-capacity-optimized. Default: lowest-price.</summary>
    [JsonPropertyName("spotAllocationStrategy")]
    public string? SpotAllocationStrategy { get; set; }

    /// <summary>Number of Spot pools per availability zone to allocate capacity. EC2 Auto Scaling selects the cheapest Spot pools and evenly allocates Spot capacity across the number of Spot pools that you specify. Only available with spot_allocation_strategy set to lowest-price. Otherwise it must be set to 0, if it has been defined before. Default: 2.</summary>
    [JsonPropertyName("spotInstancePools")]
    public double? SpotInstancePools { get; set; }

    /// <summary>Maximum price per unit hour that the user is willing to pay for the Spot instances. Default: an empty string which means the on-demand price.</summary>
    [JsonPropertyName("spotMaxPrice")]
    public string? SpotMaxPrice { get; set; }
}

/// <summary>Nested argument defines the Launch Template. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification
{
    /// <summary>ID of the launch template. Conflicts with launch_template_name.</summary>
    [JsonPropertyName("launchTemplateId")]
    public string? LaunchTemplateId { get; set; }

    /// <summary>Name of the launch template. Conflicts with launch_template_id.</summary>
    [JsonPropertyName("launchTemplateName")]
    public string? LaunchTemplateName { get; set; }

    /// <summary>Template version. Can be version number, $Latest, or $Default. (Default: $Default).</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Block describing the minimum and maximum number of accelerators (GPUs, FPGAs, or AWS Inferentia chips). Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsAcceleratorCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum total memory of the accelerators. Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsAcceleratorTotalMemoryMib
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum baseline EBS bandwidth, in Mbps. Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsBaselineEbsBandwidthMbps
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum amount of memory (GiB) per vCPU. Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsMemoryGibPerVcpu
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum amount of memory (MiB). Default is no maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsMemoryMib
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum amount of network bandwidth, in gigabits per second (Gbps). Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsNetworkBandwidthGbps
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum number of network interfaces. Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsNetworkInterfaceCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum total local storage (GB). Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsTotalLocalStorageGb
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum number of vCPUs. Default is no maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsVcpuCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Override the instance type in the Launch Template with instance types that satisfy the requirements.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirements
{
    /// <summary>Block describing the minimum and maximum number of accelerators (GPUs, FPGAs, or AWS Inferentia chips). Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorCount")]
    public V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsAcceleratorCount? AcceleratorCount { get; set; }

    /// <summary>List of accelerator manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("acceleratorManufacturers")]
    public IList<string>? AcceleratorManufacturers { get; set; }

    /// <summary>List of accelerator names. Default is any acclerator.</summary>
    [JsonPropertyName("acceleratorNames")]
    public IList<string>? AcceleratorNames { get; set; }

    /// <summary>Block describing the minimum and maximum total memory of the accelerators. Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorTotalMemoryMib")]
    public V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsAcceleratorTotalMemoryMib? AcceleratorTotalMemoryMib { get; set; }

    /// <summary>List of accelerator types. Default is any accelerator type.</summary>
    [JsonPropertyName("acceleratorTypes")]
    public IList<string>? AcceleratorTypes { get; set; }

    /// <summary>List of instance types to apply your specified attributes against. All other instance types are ignored, even if they match your specified attributes. You can use strings with one or more wild cards, represented by an asterisk (*), to allow an instance type, size, or generation. The following are examples: m5.8xlarge, c5*.*, m5a.*, r*, *3*. For example, if you specify c5*, you are allowing the entire C5 instance family, which includes all C5a and C5n instance types. If you specify m5a.*, you are allowing all the M5a instance types, but not the M5n instance types. Maximum of 400 entries in the list; each entry is limited to 30 characters. Default is all instance types.</summary>
    [JsonPropertyName("allowedInstanceTypes")]
    public IList<string>? AllowedInstanceTypes { get; set; }

    /// <summary>Indicate whether bare metal instace types should be included, excluded, or required. Default is excluded.</summary>
    [JsonPropertyName("bareMetal")]
    public string? BareMetal { get; set; }

    /// <summary>Block describing the minimum and maximum baseline EBS bandwidth, in Mbps. Default is no minimum or maximum.</summary>
    [JsonPropertyName("baselineEbsBandwidthMbps")]
    public V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsBaselineEbsBandwidthMbps? BaselineEbsBandwidthMbps { get; set; }

    /// <summary>Indicate whether burstable performance instance types should be included, excluded, or required. Default is excluded.</summary>
    [JsonPropertyName("burstablePerformance")]
    public string? BurstablePerformance { get; set; }

    /// <summary>List of CPU manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("cpuManufacturers")]
    public IList<string>? CpuManufacturers { get; set; }

    /// <summary>List of instance types to exclude. You can use strings with one or more wild cards, represented by an asterisk (*), to exclude an instance type, size, or generation. The following are examples: m5.8xlarge, c5*.*, m5a.*, r*, *3*. For example, if you specify c5*, you are excluding the entire C5 instance family, which includes all C5a and C5n instance types. If you specify m5a.*, you are excluding all the M5a instance types, but not the M5n instance types. Maximum of 400 entries in the list; each entry is limited to 30 characters. Default is no excluded instance types.</summary>
    [JsonPropertyName("excludedInstanceTypes")]
    public IList<string>? ExcludedInstanceTypes { get; set; }

    /// <summary>List of instance generation names. Default is any generation.</summary>
    [JsonPropertyName("instanceGenerations")]
    public IList<string>? InstanceGenerations { get; set; }

    /// <summary>Indicate whether instance types with local storage volumes are included, excluded, or required. Default is included.</summary>
    [JsonPropertyName("localStorage")]
    public string? LocalStorage { get; set; }

    /// <summary>List of local storage type names. Default any storage type.</summary>
    [JsonPropertyName("localStorageTypes")]
    public IList<string>? LocalStorageTypes { get; set; }

    /// <summary>The price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Conflicts with spot_max_price_percentage_over_lowest_price</summary>
    [JsonPropertyName("maxSpotPriceAsPercentageOfOptimalOnDemandPrice")]
    public double? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (GiB) per vCPU. Default is no minimum or maximum.</summary>
    [JsonPropertyName("memoryGibPerVcpu")]
    public V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsMemoryGibPerVcpu? MemoryGibPerVcpu { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (MiB). Default is no maximum.</summary>
    [JsonPropertyName("memoryMib")]
    public V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsMemoryMib? MemoryMib { get; set; }

    /// <summary>Block describing the minimum and maximum amount of network bandwidth, in gigabits per second (Gbps). Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkBandwidthGbps")]
    public V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsNetworkBandwidthGbps? NetworkBandwidthGbps { get; set; }

    /// <summary>Block describing the minimum and maximum number of network interfaces. Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkInterfaceCount")]
    public V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsNetworkInterfaceCount? NetworkInterfaceCount { get; set; }

    /// <summary>Price protection threshold for On-Demand Instances. This is the maximum you’ll pay for an On-Demand Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 20.</summary>
    [JsonPropertyName("onDemandMaxPricePercentageOverLowestPrice")]
    public double? OnDemandMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Indicate whether instance types must support On-Demand Instance Hibernation, either true or false. Default is false.</summary>
    [JsonPropertyName("requireHibernateSupport")]
    public bool? RequireHibernateSupport { get; set; }

    /// <summary>Price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 100. Conflicts with max_spot_price_as_percentage_of_optimal_on_demand_price</summary>
    [JsonPropertyName("spotMaxPricePercentageOverLowestPrice")]
    public double? SpotMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Block describing the minimum and maximum total local storage (GB). Default is no minimum or maximum.</summary>
    [JsonPropertyName("totalLocalStorageGb")]
    public V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsTotalLocalStorageGb? TotalLocalStorageGb { get; set; }

    /// <summary>Block describing the minimum and maximum number of vCPUs. Default is no maximum.</summary>
    [JsonPropertyName("vcpuCount")]
    public V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsVcpuCount? VcpuCount { get; set; }
}

/// <summary>Nested argument defines the Launch Template. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecification
{
    /// <summary>ID of the launch template. Conflicts with launch_template_name.</summary>
    [JsonPropertyName("launchTemplateId")]
    public string? LaunchTemplateId { get; set; }

    /// <summary>Name of the launch template. Conflicts with launch_template_id.</summary>
    [JsonPropertyName("launchTemplateName")]
    public string? LaunchTemplateName { get; set; }

    /// <summary>Template version. Can be version number, $Latest, or $Default. (Default: $Default).</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverride
{
    /// <summary>Override the instance type in the Launch Template with instance types that satisfy the requirements.</summary>
    [JsonPropertyName("instanceRequirements")]
    public V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirements? InstanceRequirements { get; set; }

    /// <summary>Override the instance type in the Launch Template.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Nested argument defines the Launch Template. Defined below.</summary>
    [JsonPropertyName("launchTemplateSpecification")]
    public V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecification? LaunchTemplateSpecification { get; set; }

    /// <summary>Number of capacity units, which gives the instance type a proportional weight to other instance types.</summary>
    [JsonPropertyName("weightedCapacity")]
    public string? WeightedCapacity { get; set; }
}

/// <summary>Nested argument containing launch template settings along with the overrides to specify multiple instance types and weights. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplate
{
    /// <summary>Nested argument defines the Launch Template. Defined below.</summary>
    [JsonPropertyName("launchTemplateSpecification")]
    public V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification? LaunchTemplateSpecification { get; set; }

    /// <summary>List of nested arguments provides the ability to specify multiple instance types. This will override the same parameter in the launch template. For on-demand instances, Auto Scaling considers the order of preference of instance types to launch based on the order specified in the overrides list. Defined below.</summary>
    [JsonPropertyName("override")]
    public IList<V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverride>? Override { get; set; }
}

/// <summary>Configuration block containing settings to define launch targets for Auto Scaling groups. See Mixed Instances Policy below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicy
{
    /// <summary>Nested argument containing settings on how to mix on-demand and Spot instances in the Auto Scaling group. Defined below.</summary>
    [JsonPropertyName("instancesDistribution")]
    public V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicyInstancesDistribution? InstancesDistribution { get; set; }

    /// <summary>Nested argument containing launch template settings along with the overrides to specify multiple instance types and weights. Defined below.</summary>
    [JsonPropertyName("launchTemplate")]
    public V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplate? LaunchTemplate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatusAtProviderTag
{
    /// <summary>Key</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Enables propagation of the tag to Amazon EC2 instances launched via this ASG</summary>
    [JsonPropertyName("propagateAtLaunch")]
    public bool? PropagateAtLaunch { get; set; }

    /// <summary>Value</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatusAtProviderTrafficSource
{
    /// <summary>Identifies the traffic source. For Application Load Balancers, Gateway Load Balancers, Network Load Balancers, and VPC Lattice, this will be the Amazon Resource Name (ARN) for a target group in this account and Region. For Classic Load Balancers, this will be the name of the Classic Load Balancer in this account and Region.</summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }

    /// <summary>Provides additional context for the value of Identifier. The following lists the valid values: elb if identifier is the name of a Classic Load Balancer. elbv2 if identifier is the ARN of an Application Load Balancer, Gateway Load Balancer, or Network Load Balancer target group. vpc-lattice if identifier is the ARN of a VPC Lattice target group.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Whether instances in the Auto Scaling group can be returned to the warm pool on scale in. The default is to terminate instances in the Auto Scaling group when the group scales in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatusAtProviderWarmPoolInstanceReusePolicy
{
    /// <summary>Whether instances in the Auto Scaling group can be returned to the warm pool on scale in.</summary>
    [JsonPropertyName("reuseOnScaleIn")]
    public bool? ReuseOnScaleIn { get; set; }
}

/// <summary>If this block is configured, add a Warm Pool to the specified Auto Scaling group. Defined below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatusAtProviderWarmPool
{
    /// <summary>Whether instances in the Auto Scaling group can be returned to the warm pool on scale in. The default is to terminate instances in the Auto Scaling group when the group scales in.</summary>
    [JsonPropertyName("instanceReusePolicy")]
    public V1beta1AutoscalingGroupStatusAtProviderWarmPoolInstanceReusePolicy? InstanceReusePolicy { get; set; }

    /// <summary>Total maximum number of instances that are allowed to be in the warm pool or in any state except Terminated for the Auto Scaling group.</summary>
    [JsonPropertyName("maxGroupPreparedCapacity")]
    public double? MaxGroupPreparedCapacity { get; set; }

    /// <summary>Minimum size of the Auto Scaling Group. (See also Waiting for Capacity below.)</summary>
    [JsonPropertyName("minSize")]
    public double? MinSize { get; set; }

    /// <summary>Sets the instance state to transition to after the lifecycle hooks finish. Valid values are: Stopped (default), Running or Hibernated.</summary>
    [JsonPropertyName("poolState")]
    public string? PoolState { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatusAtProvider
{
    /// <summary>ARN for this Auto Scaling Group</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The instance capacity distribution across Availability Zones. See Availability Zone Distribution below for more details.</summary>
    [JsonPropertyName("availabilityZoneDistribution")]
    public V1beta1AutoscalingGroupStatusAtProviderAvailabilityZoneDistribution? AvailabilityZoneDistribution { get; set; }

    /// <summary>A list of Availability Zones where instances in the Auto Scaling group can be created. Used for launching into the default VPC subnet in each Availability Zone when not using the vpc_zone_identifier attribute, or for attaching a network interface when an existing network interface ID is specified in a launch template. Conflicts with vpc_zone_identifier.</summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>Whether capacity rebalance is enabled. Otherwise, capacity rebalance is disabled.</summary>
    [JsonPropertyName("capacityRebalance")]
    public bool? CapacityRebalance { get; set; }

    /// <summary>Demand Capacity Reservations. See Capacity Reservation Specification below for more details.</summary>
    [JsonPropertyName("capacityReservationSpecification")]
    public V1beta1AutoscalingGroupStatusAtProviderCapacityReservationSpecification? CapacityReservationSpecification { get; set; }

    /// <summary>Reserved.</summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    /// <summary>Amount of time, in seconds, after a scaling activity completes before another scaling activity can start.</summary>
    [JsonPropertyName("defaultCooldown")]
    public double? DefaultCooldown { get; set; }

    /// <summary>Amount of time, in seconds, until a newly launched instance can contribute to the Amazon CloudWatch metrics. This delay lets an instance finish initializing before Amazon EC2 Auto Scaling aggregates instance metrics, resulting in more reliable usage data. Set this value equal to the amount of time that it takes for resource consumption to become stable after an instance reaches the InService state. (See Set the default instance warmup for an Auto Scaling group)</summary>
    [JsonPropertyName("defaultInstanceWarmup")]
    public double? DefaultInstanceWarmup { get; set; }

    /// <summary>Number of Amazon EC2 instances that should be running in the group. (See also Waiting for Capacity below.)</summary>
    [JsonPropertyName("desiredCapacity")]
    public double? DesiredCapacity { get; set; }

    /// <summary>The unit of measurement for the value specified for desired_capacity. Supported for attribute-based instance type selection only. Valid values: "units", "vcpu", "memory-mib".</summary>
    [JsonPropertyName("desiredCapacityType")]
    public string? DesiredCapacityType { get; set; }

    /// <summary>List of metrics to collect. The allowed values are defined by the underlying AWS API.</summary>
    [JsonPropertyName("enabledMetrics")]
    public IList<string>? EnabledMetrics { get; set; }

    /// <summary>Allows deleting the Auto Scaling Group without waiting for all instances in the pool to terminate. You can force an Auto Scaling Group to delete even if it's in the process of scaling a resource. This bypasses that behavior and potentially leaves resources dangling.</summary>
    [JsonPropertyName("forceDelete")]
    public bool? ForceDelete { get; set; }

    /// <summary>Allows deleting the Auto Scaling Group without waiting for all instances in the warm pool to terminate.</summary>
    [JsonPropertyName("forceDeleteWarmPool")]
    public bool? ForceDeleteWarmPool { get; set; }

    /// <summary>Time (in seconds) after instance comes into service before checking health.</summary>
    [JsonPropertyName("healthCheckGracePeriod")]
    public double? HealthCheckGracePeriod { get; set; }

    /// <summary>"EC2" or "ELB". Controls how health checking is done.</summary>
    [JsonPropertyName("healthCheckType")]
    public string? HealthCheckType { get; set; }

    /// <summary>Auto Scaling Group id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Whether to ignore failed Auto Scaling scaling activities while waiting for capacity. The default is false -- failed scaling activities cause errors to be returned.</summary>
    [JsonPropertyName("ignoreFailedScalingActivities")]
    public bool? IgnoreFailedScalingActivities { get; set; }

    /// <summary>One or more Lifecycle Hooks to attach to the Auto Scaling Group before instances are launched. The syntax is exactly the same as the separate aws_autoscaling_lifecycle_hook resource, without the autoscaling_group_name attribute. Please note that this will only work when creating a new Auto Scaling Group. For all other use-cases, please use aws_autoscaling_lifecycle_hook resource.</summary>
    [JsonPropertyName("initialLifecycleHook")]
    public IList<V1beta1AutoscalingGroupStatusAtProviderInitialLifecycleHook>? InitialLifecycleHook { get; set; }

    /// <summary>If this block is configured, add a instance maintenance policy to the specified Auto Scaling group. Defined below.</summary>
    [JsonPropertyName("instanceMaintenancePolicy")]
    public V1beta1AutoscalingGroupStatusAtProviderInstanceMaintenancePolicy? InstanceMaintenancePolicy { get; set; }

    /// <summary>If this block is configured, start an Instance Refresh when this Auto Scaling Group is updated. Defined below.</summary>
    [JsonPropertyName("instanceRefresh")]
    public V1beta1AutoscalingGroupStatusAtProviderInstanceRefresh? InstanceRefresh { get; set; }

    /// <summary>Name of the launch configuration to use.</summary>
    [JsonPropertyName("launchConfiguration")]
    public string? LaunchConfiguration { get; set; }

    /// <summary>Nested argument with Launch template specification to use to launch instances. See Launch Template below for more details.</summary>
    [JsonPropertyName("launchTemplate")]
    public V1beta1AutoscalingGroupStatusAtProviderLaunchTemplate? LaunchTemplate { get; set; }

    /// <summary>List of elastic load balancer names to add to the autoscaling group names. Only valid for classic load balancers. For ALBs, use target_group_arns instead. To remove all load balancer attachments an empty list should be specified.</summary>
    [JsonPropertyName("loadBalancers")]
    public IList<string>? LoadBalancers { get; set; }

    /// <summary>Maximum amount of time, in seconds, that an instance can be in service, values must be either equal to 0 or between 86400 and 31536000 seconds.</summary>
    [JsonPropertyName("maxInstanceLifetime")]
    public double? MaxInstanceLifetime { get; set; }

    /// <summary>Maximum size of the Auto Scaling Group.</summary>
    [JsonPropertyName("maxSize")]
    public double? MaxSize { get; set; }

    /// <summary>Granularity to associate with the metrics to collect. The only valid value is 1Minute. Default is 1Minute.</summary>
    [JsonPropertyName("metricsGranularity")]
    public string? MetricsGranularity { get; set; }

    /// <summary>Updates will not wait on ELB instance number changes. (See also Waiting for Capacity below.)</summary>
    [JsonPropertyName("minElbCapacity")]
    public double? MinElbCapacity { get; set; }

    /// <summary>Minimum size of the Auto Scaling Group. (See also Waiting for Capacity below.)</summary>
    [JsonPropertyName("minSize")]
    public double? MinSize { get; set; }

    /// <summary>Configuration block containing settings to define launch targets for Auto Scaling groups. See Mixed Instances Policy below for more details.</summary>
    [JsonPropertyName("mixedInstancesPolicy")]
    public V1beta1AutoscalingGroupStatusAtProviderMixedInstancesPolicy? MixedInstancesPolicy { get; set; }

    /// <summary>Name of the placement group into which you'll launch your instances, if any.</summary>
    [JsonPropertyName("placementGroup")]
    public string? PlacementGroup { get; set; }

    /// <summary>Predicted capacity of the group.</summary>
    [JsonPropertyName("predictedCapacity")]
    public double? PredictedCapacity { get; set; }

    /// <summary>Whether newly launched instances are automatically protected from termination by Amazon EC2 Auto Scaling when scaling in. For more information about preventing instances from terminating on scale in, see Using instance scale-in protection in the Amazon EC2 Auto Scaling User Guide.</summary>
    [JsonPropertyName("protectFromScaleIn")]
    public bool? ProtectFromScaleIn { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>ARN of the service-linked role that the ASG will use to call other AWS services</summary>
    [JsonPropertyName("serviceLinkedRoleArn")]
    public string? ServiceLinkedRoleArn { get; set; }

    /// <summary>List of processes to suspend for the Auto Scaling Group. The allowed values are Launch, Terminate, HealthCheck, ReplaceUnhealthy, AZRebalance, AlarmNotification, ScheduledActions, AddToLoadBalancer, InstanceRefresh. Note that if you suspend either the Launch or Terminate process types, it can prevent your Auto Scaling Group from functioning properly.</summary>
    [JsonPropertyName("suspendedProcesses")]
    public IList<string>? SuspendedProcesses { get; set; }

    /// <summary>Configuration block(s) containing resource tags. See Tag below for more details.</summary>
    [JsonPropertyName("tag")]
    public IList<V1beta1AutoscalingGroupStatusAtProviderTag>? Tag { get; set; }

    /// <summary>Set of aws_alb_target_group ARNs, for use with Application or Network Load Balancing. To remove all target group attachments an empty list should be specified.</summary>
    [JsonPropertyName("targetGroupArns")]
    public IList<string>? TargetGroupArns { get; set; }

    /// <summary>List of policies to decide how the instances in the Auto Scaling Group should be terminated. The allowed values are OldestInstance, NewestInstance, OldestLaunchConfiguration, ClosestToNextInstanceHour, OldestLaunchTemplate, AllocationStrategy, Default. Additionally, the ARN of a Lambda function can be specified for custom termination policies.</summary>
    [JsonPropertyName("terminationPolicies")]
    public IList<string>? TerminationPolicies { get; set; }

    /// <summary>Attaches one or more traffic sources to the specified Auto Scaling group.</summary>
    [JsonPropertyName("trafficSource")]
    public IList<V1beta1AutoscalingGroupStatusAtProviderTrafficSource>? TrafficSource { get; set; }

    /// <summary>List of subnet IDs to launch resources in. Subnets automatically determine which availability zones the group will reside. Conflicts with availability_zones.</summary>
    [JsonPropertyName("vpcZoneIdentifier")]
    public IList<string>? VpcZoneIdentifier { get; set; }

    /// <summary>(See also Waiting for Capacity below.</summary>
    [JsonPropertyName("waitForCapacityTimeout")]
    public string? WaitForCapacityTimeout { get; set; }

    /// <summary>(Takes precedence over min_elb_capacity behavior.) (See also Waiting for Capacity below.)</summary>
    [JsonPropertyName("waitForElbCapacity")]
    public double? WaitForElbCapacity { get; set; }

    /// <summary>If this block is configured, add a Warm Pool to the specified Auto Scaling group. Defined below</summary>
    [JsonPropertyName("warmPool")]
    public V1beta1AutoscalingGroupStatusAtProviderWarmPool? WarmPool { get; set; }

    /// <summary>Current size of the warm pool.</summary>
    [JsonPropertyName("warmPoolSize")]
    public double? WarmPoolSize { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatusConditions
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

/// <summary>AutoscalingGroupStatus defines the observed state of AutoscalingGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AutoscalingGroupStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1AutoscalingGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AutoscalingGroupStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>AutoscalingGroup is the Schema for the AutoscalingGroups API. Provides an Auto Scaling Group resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AutoscalingGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AutoscalingGroupSpec>, IStatus<V1beta1AutoscalingGroupStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AutoscalingGroup";
    public const string KubeGroup = "autoscaling.aws.m.upbound.io";
    public const string KubePluralName = "autoscalinggroups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AutoscalingGroupSpec defines the desired state of AutoscalingGroup</summary>
    [JsonPropertyName("spec")]
    public V1beta1AutoscalingGroupSpec Spec { get; set; }

    /// <summary>AutoscalingGroupStatus defines the observed state of AutoscalingGroup.</summary>
    [JsonPropertyName("status")]
    public V1beta1AutoscalingGroupStatus? Status { get; set; }
}

/// <summary>AutoscalingGroup is the Schema for the AutoscalingGroups API. Provides an Auto Scaling Group resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AutoscalingGroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta1AutoscalingGroup>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AutoscalingGroupList";
    public const string KubeGroup = "autoscaling.aws.m.upbound.io";
    public const string KubePluralName = "autoscalinggroups";
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
    public IList<V1beta1AutoscalingGroup> Items { get; set; }
}