using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.autoscaling.aws.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderAvailabilityZoneDistribution
{
    /// <summary>The strategy to use for distributing capacity across the Availability Zones. Valid values are balanced-only and balanced-best-effort. Default is balanced-best-effort.</summary>
    [JsonPropertyName("capacityDistributionStrategy")]
    public string? CapacityDistributionStrategy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderInitialLifecycleHook
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderInstanceMaintenancePolicy
{
    /// <summary>Amount of capacity in the Auto Scaling group that can be in service and healthy, or pending, to support your workload when an instance refresh is in place, as a percentage of the desired capacity of the Auto Scaling group. Values must be between 100 and 200, defaults to 100.</summary>
    [JsonPropertyName("maxHealthyPercentage")]
    public double? MaxHealthyPercentage { get; set; }

    /// <summary>Amount of capacity in the Auto Scaling group that must remain healthy during an instance refresh to allow the operation to continue, as a percentage of the desired capacity of the Auto Scaling group. Defaults to 90.</summary>
    [JsonPropertyName("minHealthyPercentage")]
    public double? MinHealthyPercentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderInstanceRefreshPreferencesAlarmSpecification
{
    /// <summary>List of Cloudwatch alarms. If any of these alarms goes into ALARM state, Instance Refresh is failed.</summary>
    [JsonPropertyName("alarms")]
    public IList<string>? Alarms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderInstanceRefreshPreferences
{
    /// <summary>Alarm Specification for Instance Refresh.</summary>
    [JsonPropertyName("alarmSpecification")]
    public IList<V1beta2AutoscalingGroupSpecForProviderInstanceRefreshPreferencesAlarmSpecification>? AlarmSpecification { get; set; }

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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderInstanceRefresh
{
    /// <summary>Override default parameters for Instance Refresh.</summary>
    [JsonPropertyName("preferences")]
    public IList<V1beta2AutoscalingGroupSpecForProviderInstanceRefreshPreferences>? Preferences { get; set; }

    /// <summary>Strategy to use for instance refresh. The only allowed value is Rolling. See StartInstanceRefresh Action for more information.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }

    /// <summary>Set of additional property names that will trigger an Instance Refresh. A refresh will always be triggered by a change in any of launch_configuration, launch_template, or mixed_instances_policy.</summary>
    [JsonPropertyName("triggers")]
    public IList<string>? Triggers { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderLaunchConfigurationRefPolicy
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
public partial class V1beta2AutoscalingGroupSpecForProviderLaunchConfigurationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AutoscalingGroupSpecForProviderLaunchConfigurationRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderLaunchConfigurationSelectorPolicy
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
public partial class V1beta2AutoscalingGroupSpecForProviderLaunchConfigurationSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AutoscalingGroupSpecForProviderLaunchConfigurationSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderLaunchTemplateIdRefPolicy
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
public partial class V1beta2AutoscalingGroupSpecForProviderLaunchTemplateIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AutoscalingGroupSpecForProviderLaunchTemplateIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderLaunchTemplateIdSelectorPolicy
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
public partial class V1beta2AutoscalingGroupSpecForProviderLaunchTemplateIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AutoscalingGroupSpecForProviderLaunchTemplateIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderLaunchTemplate
{
    /// <summary>ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Reference to a LaunchTemplate in ec2 to populate id.</summary>
    [JsonPropertyName("idRef")]
    public V1beta2AutoscalingGroupSpecForProviderLaunchTemplateIdRef? IdRef { get; set; }

    /// <summary>Selector for a LaunchTemplate in ec2 to populate id.</summary>
    [JsonPropertyName("idSelector")]
    public V1beta2AutoscalingGroupSpecForProviderLaunchTemplateIdSelector? IdSelector { get; set; }

    /// <summary>Name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Template version. Can be version number, $Latest, or $Default. (Default: $Default).</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyInstancesDistribution
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
public partial class V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdRefPolicy
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
public partial class V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicy
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
public partial class V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification
{
    /// <summary>ID of the launch template. Conflicts with launch_template_name.</summary>
    [JsonPropertyName("launchTemplateId")]
    public string? LaunchTemplateId { get; set; }

    /// <summary>Reference to a LaunchTemplate in ec2 to populate launchTemplateId.</summary>
    [JsonPropertyName("launchTemplateIdRef")]
    public V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdRef? LaunchTemplateIdRef { get; set; }

    /// <summary>Selector for a LaunchTemplate in ec2 to populate launchTemplateId.</summary>
    [JsonPropertyName("launchTemplateIdSelector")]
    public V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdSelector? LaunchTemplateIdSelector { get; set; }

    /// <summary>Name of the launch template. Conflicts with launch_template_id.</summary>
    [JsonPropertyName("launchTemplateName")]
    public string? LaunchTemplateName { get; set; }

    /// <summary>Template version. Can be version number, $Latest, or $Default. (Default: $Default).</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsAcceleratorCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsAcceleratorTotalMemoryMib
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsBaselineEbsBandwidthMbps
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsMemoryGibPerVcpu
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsMemoryMib
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsNetworkBandwidthGbps
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsNetworkInterfaceCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsTotalLocalStorageGb
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsVcpuCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirements
{
    /// <summary>Block describing the minimum and maximum number of accelerators (GPUs, FPGAs, or AWS Inferentia chips). Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorCount")]
    public IList<V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsAcceleratorCount>? AcceleratorCount { get; set; }

    /// <summary>List of accelerator manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("acceleratorManufacturers")]
    public IList<string>? AcceleratorManufacturers { get; set; }

    /// <summary>List of accelerator names. Default is any acclerator.</summary>
    [JsonPropertyName("acceleratorNames")]
    public IList<string>? AcceleratorNames { get; set; }

    /// <summary>Block describing the minimum and maximum total memory of the accelerators. Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorTotalMemoryMib")]
    public IList<V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsAcceleratorTotalMemoryMib>? AcceleratorTotalMemoryMib { get; set; }

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
    public IList<V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsBaselineEbsBandwidthMbps>? BaselineEbsBandwidthMbps { get; set; }

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
    public IList<V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsMemoryGibPerVcpu>? MemoryGibPerVcpu { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (MiB). Default is no maximum.</summary>
    [JsonPropertyName("memoryMib")]
    public IList<V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsMemoryMib>? MemoryMib { get; set; }

    /// <summary>Block describing the minimum and maximum amount of network bandwidth, in gigabits per second (Gbps). Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkBandwidthGbps")]
    public IList<V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsNetworkBandwidthGbps>? NetworkBandwidthGbps { get; set; }

    /// <summary>Block describing the minimum and maximum number of network interfaces. Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkInterfaceCount")]
    public IList<V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsNetworkInterfaceCount>? NetworkInterfaceCount { get; set; }

    /// <summary>Price protection threshold for On-Demand Instances. This is the maximum you’ll pay for an On-Demand Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 20.</summary>
    [JsonPropertyName("onDemandMaxPricePercentageOverLowestPrice")]
    public double? OnDemandMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Indicate whether instance types must support On-Demand Instance Hibernation, either true or false. Default is false.</summary>
    [JsonPropertyName("requireHibernateSupport")]
    public bool? RequireHibernateSupport { get; set; }

    /// <summary>Price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 100.</summary>
    [JsonPropertyName("spotMaxPricePercentageOverLowestPrice")]
    public double? SpotMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Block describing the minimum and maximum total local storage (GB). Default is no minimum or maximum.</summary>
    [JsonPropertyName("totalLocalStorageGb")]
    public IList<V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsTotalLocalStorageGb>? TotalLocalStorageGb { get; set; }

    /// <summary>Block describing the minimum and maximum number of vCPUs. Default is no maximum.</summary>
    [JsonPropertyName("vcpuCount")]
    public IList<V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsVcpuCount>? VcpuCount { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdRefPolicy
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
public partial class V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicy
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
public partial class V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecification
{
    /// <summary>ID of the launch template. Conflicts with launch_template_name.</summary>
    [JsonPropertyName("launchTemplateId")]
    public string? LaunchTemplateId { get; set; }

    /// <summary>Reference to a LaunchTemplate in ec2 to populate launchTemplateId.</summary>
    [JsonPropertyName("launchTemplateIdRef")]
    public V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdRef? LaunchTemplateIdRef { get; set; }

    /// <summary>Selector for a LaunchTemplate in ec2 to populate launchTemplateId.</summary>
    [JsonPropertyName("launchTemplateIdSelector")]
    public V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdSelector? LaunchTemplateIdSelector { get; set; }

    /// <summary>Name of the launch template. Conflicts with launch_template_id.</summary>
    [JsonPropertyName("launchTemplateName")]
    public string? LaunchTemplateName { get; set; }

    /// <summary>Template version. Can be version number, $Latest, or $Default. (Default: $Default).</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverride
{
    /// <summary>Override the instance type in the Launch Template with instance types that satisfy the requirements.</summary>
    [JsonPropertyName("instanceRequirements")]
    public IList<V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirements>? InstanceRequirements { get; set; }

    /// <summary>Override the instance type in the Launch Template.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Nested argument defines the Launch Template. Defined below.</summary>
    [JsonPropertyName("launchTemplateSpecification")]
    public IList<V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecification>? LaunchTemplateSpecification { get; set; }

    /// <summary>Number of capacity units, which gives the instance type a proportional weight to other instance types.</summary>
    [JsonPropertyName("weightedCapacity")]
    public string? WeightedCapacity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplate
{
    /// <summary>Nested argument defines the Launch Template. Defined below.</summary>
    [JsonPropertyName("launchTemplateSpecification")]
    public IList<V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification>? LaunchTemplateSpecification { get; set; }

    /// <summary>List of nested arguments provides the ability to specify multiple instance types. This will override the same parameter in the launch template. For on-demand instances, Auto Scaling considers the order of preference of instance types to launch based on the order specified in the overrides list. Defined below.</summary>
    [JsonPropertyName("override")]
    public IList<V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplateOverride>? Override { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicy
{
    /// <summary>Nested argument containing settings on how to mix on-demand and Spot instances in the Auto Scaling group. Defined below.</summary>
    [JsonPropertyName("instancesDistribution")]
    public IList<V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyInstancesDistribution>? InstancesDistribution { get; set; }

    /// <summary>Nested argument containing launch template settings along with the overrides to specify multiple instance types and weights. Defined below.</summary>
    [JsonPropertyName("launchTemplate")]
    public IList<V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicyLaunchTemplate>? LaunchTemplate { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderPlacementGroupRefPolicy
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
public partial class V1beta2AutoscalingGroupSpecForProviderPlacementGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AutoscalingGroupSpecForProviderPlacementGroupRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderPlacementGroupSelectorPolicy
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
public partial class V1beta2AutoscalingGroupSpecForProviderPlacementGroupSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AutoscalingGroupSpecForProviderPlacementGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderServiceLinkedRoleArnRefPolicy
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
public partial class V1beta2AutoscalingGroupSpecForProviderServiceLinkedRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AutoscalingGroupSpecForProviderServiceLinkedRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderServiceLinkedRoleArnSelectorPolicy
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
public partial class V1beta2AutoscalingGroupSpecForProviderServiceLinkedRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AutoscalingGroupSpecForProviderServiceLinkedRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderTag
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
public partial class V1beta2AutoscalingGroupSpecForProviderTrafficSource
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
public partial class V1beta2AutoscalingGroupSpecForProviderVpcZoneIdentifierRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderVpcZoneIdentifierRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AutoscalingGroupSpecForProviderVpcZoneIdentifierRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderVpcZoneIdentifierSelectorPolicy
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
public partial class V1beta2AutoscalingGroupSpecForProviderVpcZoneIdentifierSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AutoscalingGroupSpecForProviderVpcZoneIdentifierSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderWarmPoolInstanceReusePolicy
{
    /// <summary>Whether instances in the Auto Scaling group can be returned to the warm pool on scale in.</summary>
    [JsonPropertyName("reuseOnScaleIn")]
    public bool? ReuseOnScaleIn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecForProviderWarmPool
{
    /// <summary>Whether instances in the Auto Scaling group can be returned to the warm pool on scale in. The default is to terminate instances in the Auto Scaling group when the group scales in.</summary>
    [JsonPropertyName("instanceReusePolicy")]
    public IList<V1beta2AutoscalingGroupSpecForProviderWarmPoolInstanceReusePolicy>? InstanceReusePolicy { get; set; }

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
public partial class V1beta2AutoscalingGroupSpecForProvider
{
    /// <summary>The instance capacity distribution across Availability Zones. See Availability Zone Distribution below for more details.</summary>
    [JsonPropertyName("availabilityZoneDistribution")]
    public IList<V1beta2AutoscalingGroupSpecForProviderAvailabilityZoneDistribution>? AvailabilityZoneDistribution { get; set; }

    /// <summary>A list of Availability Zones where instances in the Auto Scaling group can be created. Used for launching into the default VPC subnet in each Availability Zone when not using the vpc_zone_identifier attribute, or for attaching a network interface when an existing network interface ID is specified in a launch template. Conflicts with vpc_zone_identifier.</summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>Whether capacity rebalance is enabled. Otherwise, capacity rebalance is disabled.</summary>
    [JsonPropertyName("capacityRebalance")]
    public bool? CapacityRebalance { get; set; }

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
    public IList<V1beta2AutoscalingGroupSpecForProviderInitialLifecycleHook>? InitialLifecycleHook { get; set; }

    /// <summary>If this block is configured, add a instance maintenance policy to the specified Auto Scaling group. Defined below.</summary>
    [JsonPropertyName("instanceMaintenancePolicy")]
    public IList<V1beta2AutoscalingGroupSpecForProviderInstanceMaintenancePolicy>? InstanceMaintenancePolicy { get; set; }

    /// <summary>If this block is configured, start an Instance Refresh when this Auto Scaling Group is updated. Defined below.</summary>
    [JsonPropertyName("instanceRefresh")]
    public IList<V1beta2AutoscalingGroupSpecForProviderInstanceRefresh>? InstanceRefresh { get; set; }

    /// <summary>Name of the launch configuration to use.</summary>
    [JsonPropertyName("launchConfiguration")]
    public string? LaunchConfiguration { get; set; }

    /// <summary>Reference to a LaunchConfiguration in autoscaling to populate launchConfiguration.</summary>
    [JsonPropertyName("launchConfigurationRef")]
    public V1beta2AutoscalingGroupSpecForProviderLaunchConfigurationRef? LaunchConfigurationRef { get; set; }

    /// <summary>Selector for a LaunchConfiguration in autoscaling to populate launchConfiguration.</summary>
    [JsonPropertyName("launchConfigurationSelector")]
    public V1beta2AutoscalingGroupSpecForProviderLaunchConfigurationSelector? LaunchConfigurationSelector { get; set; }

    /// <summary>Nested argument with Launch template specification to use to launch instances. See Launch Template below for more details.</summary>
    [JsonPropertyName("launchTemplate")]
    public IList<V1beta2AutoscalingGroupSpecForProviderLaunchTemplate>? LaunchTemplate { get; set; }

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
    public IList<V1beta2AutoscalingGroupSpecForProviderMixedInstancesPolicy>? MixedInstancesPolicy { get; set; }

    /// <summary>Name of the placement group into which you'll launch your instances, if any.</summary>
    [JsonPropertyName("placementGroup")]
    public string? PlacementGroup { get; set; }

    /// <summary>Reference to a PlacementGroup in ec2 to populate placementGroup.</summary>
    [JsonPropertyName("placementGroupRef")]
    public V1beta2AutoscalingGroupSpecForProviderPlacementGroupRef? PlacementGroupRef { get; set; }

    /// <summary>Selector for a PlacementGroup in ec2 to populate placementGroup.</summary>
    [JsonPropertyName("placementGroupSelector")]
    public V1beta2AutoscalingGroupSpecForProviderPlacementGroupSelector? PlacementGroupSelector { get; set; }

    /// <summary>Whether newly launched instances are automatically protected from termination by Amazon EC2 Auto Scaling when scaling in. For more information about preventing instances from terminating on scale in, see Using instance scale-in protection in the Amazon EC2 Auto Scaling User Guide.</summary>
    [JsonPropertyName("protectFromScaleIn")]
    public bool? ProtectFromScaleIn { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>ARN of the service-linked role that the ASG will use to call other AWS services</summary>
    [JsonPropertyName("serviceLinkedRoleArn")]
    public string? ServiceLinkedRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceLinkedRoleArn.</summary>
    [JsonPropertyName("serviceLinkedRoleArnRef")]
    public V1beta2AutoscalingGroupSpecForProviderServiceLinkedRoleArnRef? ServiceLinkedRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceLinkedRoleArn.</summary>
    [JsonPropertyName("serviceLinkedRoleArnSelector")]
    public V1beta2AutoscalingGroupSpecForProviderServiceLinkedRoleArnSelector? ServiceLinkedRoleArnSelector { get; set; }

    /// <summary>List of processes to suspend for the Auto Scaling Group. The allowed values are Launch, Terminate, HealthCheck, ReplaceUnhealthy, AZRebalance, AlarmNotification, ScheduledActions, AddToLoadBalancer, InstanceRefresh. Note that if you suspend either the Launch or Terminate process types, it can prevent your Auto Scaling Group from functioning properly.</summary>
    [JsonPropertyName("suspendedProcesses")]
    public IList<string>? SuspendedProcesses { get; set; }

    /// <summary>Configuration block(s) containing resource tags. See Tag below for more details.</summary>
    [JsonPropertyName("tag")]
    public IList<V1beta2AutoscalingGroupSpecForProviderTag>? Tag { get; set; }

    /// <summary>List of policies to decide how the instances in the Auto Scaling Group should be terminated. The allowed values are OldestInstance, NewestInstance, OldestLaunchConfiguration, ClosestToNextInstanceHour, OldestLaunchTemplate, AllocationStrategy, Default. Additionally, the ARN of a Lambda function can be specified for custom termination policies.</summary>
    [JsonPropertyName("terminationPolicies")]
    public IList<string>? TerminationPolicies { get; set; }

    /// <summary>Attaches one or more traffic sources to the specified Auto Scaling group.</summary>
    [JsonPropertyName("trafficSource")]
    public IList<V1beta2AutoscalingGroupSpecForProviderTrafficSource>? TrafficSource { get; set; }

    /// <summary>List of subnet IDs to launch resources in. Subnets automatically determine which availability zones the group will reside. Conflicts with availability_zones.</summary>
    [JsonPropertyName("vpcZoneIdentifier")]
    public IList<string>? VpcZoneIdentifier { get; set; }

    /// <summary>References to Subnet in ec2 to populate vpcZoneIdentifier.</summary>
    [JsonPropertyName("vpcZoneIdentifierRefs")]
    public IList<V1beta2AutoscalingGroupSpecForProviderVpcZoneIdentifierRefs>? VpcZoneIdentifierRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate vpcZoneIdentifier.</summary>
    [JsonPropertyName("vpcZoneIdentifierSelector")]
    public V1beta2AutoscalingGroupSpecForProviderVpcZoneIdentifierSelector? VpcZoneIdentifierSelector { get; set; }

    /// <summary>(See also Waiting for Capacity below.</summary>
    [JsonPropertyName("waitForCapacityTimeout")]
    public string? WaitForCapacityTimeout { get; set; }

    /// <summary>(Takes precedence over min_elb_capacity behavior.) (See also Waiting for Capacity below.)</summary>
    [JsonPropertyName("waitForElbCapacity")]
    public double? WaitForElbCapacity { get; set; }

    /// <summary>If this block is configured, add a Warm Pool to the specified Auto Scaling group. Defined below</summary>
    [JsonPropertyName("warmPool")]
    public IList<V1beta2AutoscalingGroupSpecForProviderWarmPool>? WarmPool { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderAvailabilityZoneDistribution
{
    /// <summary>The strategy to use for distributing capacity across the Availability Zones. Valid values are balanced-only and balanced-best-effort. Default is balanced-best-effort.</summary>
    [JsonPropertyName("capacityDistributionStrategy")]
    public string? CapacityDistributionStrategy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderInitialLifecycleHook
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderInstanceMaintenancePolicy
{
    /// <summary>Amount of capacity in the Auto Scaling group that can be in service and healthy, or pending, to support your workload when an instance refresh is in place, as a percentage of the desired capacity of the Auto Scaling group. Values must be between 100 and 200, defaults to 100.</summary>
    [JsonPropertyName("maxHealthyPercentage")]
    public double? MaxHealthyPercentage { get; set; }

    /// <summary>Amount of capacity in the Auto Scaling group that must remain healthy during an instance refresh to allow the operation to continue, as a percentage of the desired capacity of the Auto Scaling group. Defaults to 90.</summary>
    [JsonPropertyName("minHealthyPercentage")]
    public double? MinHealthyPercentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderInstanceRefreshPreferencesAlarmSpecification
{
    /// <summary>List of Cloudwatch alarms. If any of these alarms goes into ALARM state, Instance Refresh is failed.</summary>
    [JsonPropertyName("alarms")]
    public IList<string>? Alarms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderInstanceRefreshPreferences
{
    /// <summary>Alarm Specification for Instance Refresh.</summary>
    [JsonPropertyName("alarmSpecification")]
    public IList<V1beta2AutoscalingGroupSpecInitProviderInstanceRefreshPreferencesAlarmSpecification>? AlarmSpecification { get; set; }

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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderInstanceRefresh
{
    /// <summary>Override default parameters for Instance Refresh.</summary>
    [JsonPropertyName("preferences")]
    public IList<V1beta2AutoscalingGroupSpecInitProviderInstanceRefreshPreferences>? Preferences { get; set; }

    /// <summary>Strategy to use for instance refresh. The only allowed value is Rolling. See StartInstanceRefresh Action for more information.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }

    /// <summary>Set of additional property names that will trigger an Instance Refresh. A refresh will always be triggered by a change in any of launch_configuration, launch_template, or mixed_instances_policy.</summary>
    [JsonPropertyName("triggers")]
    public IList<string>? Triggers { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderLaunchConfigurationRefPolicy
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
public partial class V1beta2AutoscalingGroupSpecInitProviderLaunchConfigurationRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AutoscalingGroupSpecInitProviderLaunchConfigurationRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderLaunchConfigurationSelectorPolicy
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
public partial class V1beta2AutoscalingGroupSpecInitProviderLaunchConfigurationSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AutoscalingGroupSpecInitProviderLaunchConfigurationSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderLaunchTemplateIdRefPolicy
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
public partial class V1beta2AutoscalingGroupSpecInitProviderLaunchTemplateIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AutoscalingGroupSpecInitProviderLaunchTemplateIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderLaunchTemplateIdSelectorPolicy
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
public partial class V1beta2AutoscalingGroupSpecInitProviderLaunchTemplateIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AutoscalingGroupSpecInitProviderLaunchTemplateIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderLaunchTemplate
{
    /// <summary>ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Reference to a LaunchTemplate in ec2 to populate id.</summary>
    [JsonPropertyName("idRef")]
    public V1beta2AutoscalingGroupSpecInitProviderLaunchTemplateIdRef? IdRef { get; set; }

    /// <summary>Selector for a LaunchTemplate in ec2 to populate id.</summary>
    [JsonPropertyName("idSelector")]
    public V1beta2AutoscalingGroupSpecInitProviderLaunchTemplateIdSelector? IdSelector { get; set; }

    /// <summary>Name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Template version. Can be version number, $Latest, or $Default. (Default: $Default).</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyInstancesDistribution
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
public partial class V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdRefPolicy
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
public partial class V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicy
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
public partial class V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification
{
    /// <summary>ID of the launch template. Conflicts with launch_template_name.</summary>
    [JsonPropertyName("launchTemplateId")]
    public string? LaunchTemplateId { get; set; }

    /// <summary>Reference to a LaunchTemplate in ec2 to populate launchTemplateId.</summary>
    [JsonPropertyName("launchTemplateIdRef")]
    public V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdRef? LaunchTemplateIdRef { get; set; }

    /// <summary>Selector for a LaunchTemplate in ec2 to populate launchTemplateId.</summary>
    [JsonPropertyName("launchTemplateIdSelector")]
    public V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecificationLaunchTemplateIdSelector? LaunchTemplateIdSelector { get; set; }

    /// <summary>Name of the launch template. Conflicts with launch_template_id.</summary>
    [JsonPropertyName("launchTemplateName")]
    public string? LaunchTemplateName { get; set; }

    /// <summary>Template version. Can be version number, $Latest, or $Default. (Default: $Default).</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsAcceleratorCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsAcceleratorTotalMemoryMib
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsBaselineEbsBandwidthMbps
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsMemoryGibPerVcpu
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsMemoryMib
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsNetworkBandwidthGbps
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsNetworkInterfaceCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsTotalLocalStorageGb
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsVcpuCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirements
{
    /// <summary>Block describing the minimum and maximum number of accelerators (GPUs, FPGAs, or AWS Inferentia chips). Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorCount")]
    public IList<V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsAcceleratorCount>? AcceleratorCount { get; set; }

    /// <summary>List of accelerator manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("acceleratorManufacturers")]
    public IList<string>? AcceleratorManufacturers { get; set; }

    /// <summary>List of accelerator names. Default is any acclerator.</summary>
    [JsonPropertyName("acceleratorNames")]
    public IList<string>? AcceleratorNames { get; set; }

    /// <summary>Block describing the minimum and maximum total memory of the accelerators. Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorTotalMemoryMib")]
    public IList<V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsAcceleratorTotalMemoryMib>? AcceleratorTotalMemoryMib { get; set; }

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
    public IList<V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsBaselineEbsBandwidthMbps>? BaselineEbsBandwidthMbps { get; set; }

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
    public IList<V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsMemoryGibPerVcpu>? MemoryGibPerVcpu { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (MiB). Default is no maximum.</summary>
    [JsonPropertyName("memoryMib")]
    public IList<V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsMemoryMib>? MemoryMib { get; set; }

    /// <summary>Block describing the minimum and maximum amount of network bandwidth, in gigabits per second (Gbps). Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkBandwidthGbps")]
    public IList<V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsNetworkBandwidthGbps>? NetworkBandwidthGbps { get; set; }

    /// <summary>Block describing the minimum and maximum number of network interfaces. Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkInterfaceCount")]
    public IList<V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsNetworkInterfaceCount>? NetworkInterfaceCount { get; set; }

    /// <summary>Price protection threshold for On-Demand Instances. This is the maximum you’ll pay for an On-Demand Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 20.</summary>
    [JsonPropertyName("onDemandMaxPricePercentageOverLowestPrice")]
    public double? OnDemandMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Indicate whether instance types must support On-Demand Instance Hibernation, either true or false. Default is false.</summary>
    [JsonPropertyName("requireHibernateSupport")]
    public bool? RequireHibernateSupport { get; set; }

    /// <summary>Price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 100.</summary>
    [JsonPropertyName("spotMaxPricePercentageOverLowestPrice")]
    public double? SpotMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Block describing the minimum and maximum total local storage (GB). Default is no minimum or maximum.</summary>
    [JsonPropertyName("totalLocalStorageGb")]
    public IList<V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsTotalLocalStorageGb>? TotalLocalStorageGb { get; set; }

    /// <summary>Block describing the minimum and maximum number of vCPUs. Default is no maximum.</summary>
    [JsonPropertyName("vcpuCount")]
    public IList<V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsVcpuCount>? VcpuCount { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdRefPolicy
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
public partial class V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicy
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
public partial class V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecification
{
    /// <summary>ID of the launch template. Conflicts with launch_template_name.</summary>
    [JsonPropertyName("launchTemplateId")]
    public string? LaunchTemplateId { get; set; }

    /// <summary>Reference to a LaunchTemplate in ec2 to populate launchTemplateId.</summary>
    [JsonPropertyName("launchTemplateIdRef")]
    public V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdRef? LaunchTemplateIdRef { get; set; }

    /// <summary>Selector for a LaunchTemplate in ec2 to populate launchTemplateId.</summary>
    [JsonPropertyName("launchTemplateIdSelector")]
    public V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecificationLaunchTemplateIdSelector? LaunchTemplateIdSelector { get; set; }

    /// <summary>Name of the launch template. Conflicts with launch_template_id.</summary>
    [JsonPropertyName("launchTemplateName")]
    public string? LaunchTemplateName { get; set; }

    /// <summary>Template version. Can be version number, $Latest, or $Default. (Default: $Default).</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverride
{
    /// <summary>Override the instance type in the Launch Template with instance types that satisfy the requirements.</summary>
    [JsonPropertyName("instanceRequirements")]
    public IList<V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirements>? InstanceRequirements { get; set; }

    /// <summary>Override the instance type in the Launch Template.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Nested argument defines the Launch Template. Defined below.</summary>
    [JsonPropertyName("launchTemplateSpecification")]
    public IList<V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecification>? LaunchTemplateSpecification { get; set; }

    /// <summary>Number of capacity units, which gives the instance type a proportional weight to other instance types.</summary>
    [JsonPropertyName("weightedCapacity")]
    public string? WeightedCapacity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplate
{
    /// <summary>Nested argument defines the Launch Template. Defined below.</summary>
    [JsonPropertyName("launchTemplateSpecification")]
    public IList<V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification>? LaunchTemplateSpecification { get; set; }

    /// <summary>List of nested arguments provides the ability to specify multiple instance types. This will override the same parameter in the launch template. For on-demand instances, Auto Scaling considers the order of preference of instance types to launch based on the order specified in the overrides list. Defined below.</summary>
    [JsonPropertyName("override")]
    public IList<V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplateOverride>? Override { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicy
{
    /// <summary>Nested argument containing settings on how to mix on-demand and Spot instances in the Auto Scaling group. Defined below.</summary>
    [JsonPropertyName("instancesDistribution")]
    public IList<V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyInstancesDistribution>? InstancesDistribution { get; set; }

    /// <summary>Nested argument containing launch template settings along with the overrides to specify multiple instance types and weights. Defined below.</summary>
    [JsonPropertyName("launchTemplate")]
    public IList<V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicyLaunchTemplate>? LaunchTemplate { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderPlacementGroupRefPolicy
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
public partial class V1beta2AutoscalingGroupSpecInitProviderPlacementGroupRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AutoscalingGroupSpecInitProviderPlacementGroupRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderPlacementGroupSelectorPolicy
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
public partial class V1beta2AutoscalingGroupSpecInitProviderPlacementGroupSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AutoscalingGroupSpecInitProviderPlacementGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderServiceLinkedRoleArnRefPolicy
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
public partial class V1beta2AutoscalingGroupSpecInitProviderServiceLinkedRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AutoscalingGroupSpecInitProviderServiceLinkedRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderServiceLinkedRoleArnSelectorPolicy
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
public partial class V1beta2AutoscalingGroupSpecInitProviderServiceLinkedRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AutoscalingGroupSpecInitProviderServiceLinkedRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderTag
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
public partial class V1beta2AutoscalingGroupSpecInitProviderTrafficSource
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
public partial class V1beta2AutoscalingGroupSpecInitProviderVpcZoneIdentifierRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderVpcZoneIdentifierRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AutoscalingGroupSpecInitProviderVpcZoneIdentifierRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderVpcZoneIdentifierSelectorPolicy
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
public partial class V1beta2AutoscalingGroupSpecInitProviderVpcZoneIdentifierSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AutoscalingGroupSpecInitProviderVpcZoneIdentifierSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderWarmPoolInstanceReusePolicy
{
    /// <summary>Whether instances in the Auto Scaling group can be returned to the warm pool on scale in.</summary>
    [JsonPropertyName("reuseOnScaleIn")]
    public bool? ReuseOnScaleIn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecInitProviderWarmPool
{
    /// <summary>Whether instances in the Auto Scaling group can be returned to the warm pool on scale in. The default is to terminate instances in the Auto Scaling group when the group scales in.</summary>
    [JsonPropertyName("instanceReusePolicy")]
    public IList<V1beta2AutoscalingGroupSpecInitProviderWarmPoolInstanceReusePolicy>? InstanceReusePolicy { get; set; }

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
public partial class V1beta2AutoscalingGroupSpecInitProvider
{
    /// <summary>The instance capacity distribution across Availability Zones. See Availability Zone Distribution below for more details.</summary>
    [JsonPropertyName("availabilityZoneDistribution")]
    public IList<V1beta2AutoscalingGroupSpecInitProviderAvailabilityZoneDistribution>? AvailabilityZoneDistribution { get; set; }

    /// <summary>A list of Availability Zones where instances in the Auto Scaling group can be created. Used for launching into the default VPC subnet in each Availability Zone when not using the vpc_zone_identifier attribute, or for attaching a network interface when an existing network interface ID is specified in a launch template. Conflicts with vpc_zone_identifier.</summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>Whether capacity rebalance is enabled. Otherwise, capacity rebalance is disabled.</summary>
    [JsonPropertyName("capacityRebalance")]
    public bool? CapacityRebalance { get; set; }

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
    public IList<V1beta2AutoscalingGroupSpecInitProviderInitialLifecycleHook>? InitialLifecycleHook { get; set; }

    /// <summary>If this block is configured, add a instance maintenance policy to the specified Auto Scaling group. Defined below.</summary>
    [JsonPropertyName("instanceMaintenancePolicy")]
    public IList<V1beta2AutoscalingGroupSpecInitProviderInstanceMaintenancePolicy>? InstanceMaintenancePolicy { get; set; }

    /// <summary>If this block is configured, start an Instance Refresh when this Auto Scaling Group is updated. Defined below.</summary>
    [JsonPropertyName("instanceRefresh")]
    public IList<V1beta2AutoscalingGroupSpecInitProviderInstanceRefresh>? InstanceRefresh { get; set; }

    /// <summary>Name of the launch configuration to use.</summary>
    [JsonPropertyName("launchConfiguration")]
    public string? LaunchConfiguration { get; set; }

    /// <summary>Reference to a LaunchConfiguration in autoscaling to populate launchConfiguration.</summary>
    [JsonPropertyName("launchConfigurationRef")]
    public V1beta2AutoscalingGroupSpecInitProviderLaunchConfigurationRef? LaunchConfigurationRef { get; set; }

    /// <summary>Selector for a LaunchConfiguration in autoscaling to populate launchConfiguration.</summary>
    [JsonPropertyName("launchConfigurationSelector")]
    public V1beta2AutoscalingGroupSpecInitProviderLaunchConfigurationSelector? LaunchConfigurationSelector { get; set; }

    /// <summary>Nested argument with Launch template specification to use to launch instances. See Launch Template below for more details.</summary>
    [JsonPropertyName("launchTemplate")]
    public IList<V1beta2AutoscalingGroupSpecInitProviderLaunchTemplate>? LaunchTemplate { get; set; }

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
    public IList<V1beta2AutoscalingGroupSpecInitProviderMixedInstancesPolicy>? MixedInstancesPolicy { get; set; }

    /// <summary>Name of the placement group into which you'll launch your instances, if any.</summary>
    [JsonPropertyName("placementGroup")]
    public string? PlacementGroup { get; set; }

    /// <summary>Reference to a PlacementGroup in ec2 to populate placementGroup.</summary>
    [JsonPropertyName("placementGroupRef")]
    public V1beta2AutoscalingGroupSpecInitProviderPlacementGroupRef? PlacementGroupRef { get; set; }

    /// <summary>Selector for a PlacementGroup in ec2 to populate placementGroup.</summary>
    [JsonPropertyName("placementGroupSelector")]
    public V1beta2AutoscalingGroupSpecInitProviderPlacementGroupSelector? PlacementGroupSelector { get; set; }

    /// <summary>Whether newly launched instances are automatically protected from termination by Amazon EC2 Auto Scaling when scaling in. For more information about preventing instances from terminating on scale in, see Using instance scale-in protection in the Amazon EC2 Auto Scaling User Guide.</summary>
    [JsonPropertyName("protectFromScaleIn")]
    public bool? ProtectFromScaleIn { get; set; }

    /// <summary>ARN of the service-linked role that the ASG will use to call other AWS services</summary>
    [JsonPropertyName("serviceLinkedRoleArn")]
    public string? ServiceLinkedRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceLinkedRoleArn.</summary>
    [JsonPropertyName("serviceLinkedRoleArnRef")]
    public V1beta2AutoscalingGroupSpecInitProviderServiceLinkedRoleArnRef? ServiceLinkedRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceLinkedRoleArn.</summary>
    [JsonPropertyName("serviceLinkedRoleArnSelector")]
    public V1beta2AutoscalingGroupSpecInitProviderServiceLinkedRoleArnSelector? ServiceLinkedRoleArnSelector { get; set; }

    /// <summary>List of processes to suspend for the Auto Scaling Group. The allowed values are Launch, Terminate, HealthCheck, ReplaceUnhealthy, AZRebalance, AlarmNotification, ScheduledActions, AddToLoadBalancer, InstanceRefresh. Note that if you suspend either the Launch or Terminate process types, it can prevent your Auto Scaling Group from functioning properly.</summary>
    [JsonPropertyName("suspendedProcesses")]
    public IList<string>? SuspendedProcesses { get; set; }

    /// <summary>Configuration block(s) containing resource tags. See Tag below for more details.</summary>
    [JsonPropertyName("tag")]
    public IList<V1beta2AutoscalingGroupSpecInitProviderTag>? Tag { get; set; }

    /// <summary>List of policies to decide how the instances in the Auto Scaling Group should be terminated. The allowed values are OldestInstance, NewestInstance, OldestLaunchConfiguration, ClosestToNextInstanceHour, OldestLaunchTemplate, AllocationStrategy, Default. Additionally, the ARN of a Lambda function can be specified for custom termination policies.</summary>
    [JsonPropertyName("terminationPolicies")]
    public IList<string>? TerminationPolicies { get; set; }

    /// <summary>Attaches one or more traffic sources to the specified Auto Scaling group.</summary>
    [JsonPropertyName("trafficSource")]
    public IList<V1beta2AutoscalingGroupSpecInitProviderTrafficSource>? TrafficSource { get; set; }

    /// <summary>List of subnet IDs to launch resources in. Subnets automatically determine which availability zones the group will reside. Conflicts with availability_zones.</summary>
    [JsonPropertyName("vpcZoneIdentifier")]
    public IList<string>? VpcZoneIdentifier { get; set; }

    /// <summary>References to Subnet in ec2 to populate vpcZoneIdentifier.</summary>
    [JsonPropertyName("vpcZoneIdentifierRefs")]
    public IList<V1beta2AutoscalingGroupSpecInitProviderVpcZoneIdentifierRefs>? VpcZoneIdentifierRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate vpcZoneIdentifier.</summary>
    [JsonPropertyName("vpcZoneIdentifierSelector")]
    public V1beta2AutoscalingGroupSpecInitProviderVpcZoneIdentifierSelector? VpcZoneIdentifierSelector { get; set; }

    /// <summary>(See also Waiting for Capacity below.</summary>
    [JsonPropertyName("waitForCapacityTimeout")]
    public string? WaitForCapacityTimeout { get; set; }

    /// <summary>(Takes precedence over min_elb_capacity behavior.) (See also Waiting for Capacity below.)</summary>
    [JsonPropertyName("waitForElbCapacity")]
    public double? WaitForElbCapacity { get; set; }

    /// <summary>If this block is configured, add a Warm Pool to the specified Auto Scaling group. Defined below</summary>
    [JsonPropertyName("warmPool")]
    public IList<V1beta2AutoscalingGroupSpecInitProviderWarmPool>? WarmPool { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AutoscalingGroupSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AutoscalingGroupSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta2AutoscalingGroupSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta2AutoscalingGroupSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta2AutoscalingGroupSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>AutoscalingGroupSpec defines the desired state of AutoscalingGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta2AutoscalingGroupSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta2AutoscalingGroupSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2AutoscalingGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta2AutoscalingGroupSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2AutoscalingGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupStatusAtProviderAvailabilityZoneDistribution
{
    /// <summary>The strategy to use for distributing capacity across the Availability Zones. Valid values are balanced-only and balanced-best-effort. Default is balanced-best-effort.</summary>
    [JsonPropertyName("capacityDistributionStrategy")]
    public string? CapacityDistributionStrategy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupStatusAtProviderInitialLifecycleHook
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupStatusAtProviderInstanceMaintenancePolicy
{
    /// <summary>Amount of capacity in the Auto Scaling group that can be in service and healthy, or pending, to support your workload when an instance refresh is in place, as a percentage of the desired capacity of the Auto Scaling group. Values must be between 100 and 200, defaults to 100.</summary>
    [JsonPropertyName("maxHealthyPercentage")]
    public double? MaxHealthyPercentage { get; set; }

    /// <summary>Amount of capacity in the Auto Scaling group that must remain healthy during an instance refresh to allow the operation to continue, as a percentage of the desired capacity of the Auto Scaling group. Defaults to 90.</summary>
    [JsonPropertyName("minHealthyPercentage")]
    public double? MinHealthyPercentage { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupStatusAtProviderInstanceRefreshPreferencesAlarmSpecification
{
    /// <summary>List of Cloudwatch alarms. If any of these alarms goes into ALARM state, Instance Refresh is failed.</summary>
    [JsonPropertyName("alarms")]
    public IList<string>? Alarms { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupStatusAtProviderInstanceRefreshPreferences
{
    /// <summary>Alarm Specification for Instance Refresh.</summary>
    [JsonPropertyName("alarmSpecification")]
    public IList<V1beta2AutoscalingGroupStatusAtProviderInstanceRefreshPreferencesAlarmSpecification>? AlarmSpecification { get; set; }

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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupStatusAtProviderInstanceRefresh
{
    /// <summary>Override default parameters for Instance Refresh.</summary>
    [JsonPropertyName("preferences")]
    public IList<V1beta2AutoscalingGroupStatusAtProviderInstanceRefreshPreferences>? Preferences { get; set; }

    /// <summary>Strategy to use for instance refresh. The only allowed value is Rolling. See StartInstanceRefresh Action for more information.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }

    /// <summary>Set of additional property names that will trigger an Instance Refresh. A refresh will always be triggered by a change in any of launch_configuration, launch_template, or mixed_instances_policy.</summary>
    [JsonPropertyName("triggers")]
    public IList<string>? Triggers { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupStatusAtProviderLaunchTemplate
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicyInstancesDistribution
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification
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
public partial class V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsAcceleratorCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsAcceleratorTotalMemoryMib
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsBaselineEbsBandwidthMbps
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsMemoryGibPerVcpu
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsMemoryMib
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsNetworkBandwidthGbps
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsNetworkInterfaceCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsTotalLocalStorageGb
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsVcpuCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirements
{
    /// <summary>Block describing the minimum and maximum number of accelerators (GPUs, FPGAs, or AWS Inferentia chips). Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorCount")]
    public IList<V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsAcceleratorCount>? AcceleratorCount { get; set; }

    /// <summary>List of accelerator manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("acceleratorManufacturers")]
    public IList<string>? AcceleratorManufacturers { get; set; }

    /// <summary>List of accelerator names. Default is any acclerator.</summary>
    [JsonPropertyName("acceleratorNames")]
    public IList<string>? AcceleratorNames { get; set; }

    /// <summary>Block describing the minimum and maximum total memory of the accelerators. Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorTotalMemoryMib")]
    public IList<V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsAcceleratorTotalMemoryMib>? AcceleratorTotalMemoryMib { get; set; }

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
    public IList<V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsBaselineEbsBandwidthMbps>? BaselineEbsBandwidthMbps { get; set; }

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
    public IList<V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsMemoryGibPerVcpu>? MemoryGibPerVcpu { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (MiB). Default is no maximum.</summary>
    [JsonPropertyName("memoryMib")]
    public IList<V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsMemoryMib>? MemoryMib { get; set; }

    /// <summary>Block describing the minimum and maximum amount of network bandwidth, in gigabits per second (Gbps). Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkBandwidthGbps")]
    public IList<V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsNetworkBandwidthGbps>? NetworkBandwidthGbps { get; set; }

    /// <summary>Block describing the minimum and maximum number of network interfaces. Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkInterfaceCount")]
    public IList<V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsNetworkInterfaceCount>? NetworkInterfaceCount { get; set; }

    /// <summary>Price protection threshold for On-Demand Instances. This is the maximum you’ll pay for an On-Demand Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 20.</summary>
    [JsonPropertyName("onDemandMaxPricePercentageOverLowestPrice")]
    public double? OnDemandMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Indicate whether instance types must support On-Demand Instance Hibernation, either true or false. Default is false.</summary>
    [JsonPropertyName("requireHibernateSupport")]
    public bool? RequireHibernateSupport { get; set; }

    /// <summary>Price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 100.</summary>
    [JsonPropertyName("spotMaxPricePercentageOverLowestPrice")]
    public double? SpotMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Block describing the minimum and maximum total local storage (GB). Default is no minimum or maximum.</summary>
    [JsonPropertyName("totalLocalStorageGb")]
    public IList<V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsTotalLocalStorageGb>? TotalLocalStorageGb { get; set; }

    /// <summary>Block describing the minimum and maximum number of vCPUs. Default is no maximum.</summary>
    [JsonPropertyName("vcpuCount")]
    public IList<V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirementsVcpuCount>? VcpuCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecification
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
public partial class V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverride
{
    /// <summary>Override the instance type in the Launch Template with instance types that satisfy the requirements.</summary>
    [JsonPropertyName("instanceRequirements")]
    public IList<V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideInstanceRequirements>? InstanceRequirements { get; set; }

    /// <summary>Override the instance type in the Launch Template.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Nested argument defines the Launch Template. Defined below.</summary>
    [JsonPropertyName("launchTemplateSpecification")]
    public IList<V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverrideLaunchTemplateSpecification>? LaunchTemplateSpecification { get; set; }

    /// <summary>Number of capacity units, which gives the instance type a proportional weight to other instance types.</summary>
    [JsonPropertyName("weightedCapacity")]
    public string? WeightedCapacity { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplate
{
    /// <summary>Nested argument defines the Launch Template. Defined below.</summary>
    [JsonPropertyName("launchTemplateSpecification")]
    public IList<V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateLaunchTemplateSpecification>? LaunchTemplateSpecification { get; set; }

    /// <summary>List of nested arguments provides the ability to specify multiple instance types. This will override the same parameter in the launch template. For on-demand instances, Auto Scaling considers the order of preference of instance types to launch based on the order specified in the overrides list. Defined below.</summary>
    [JsonPropertyName("override")]
    public IList<V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplateOverride>? Override { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicy
{
    /// <summary>Nested argument containing settings on how to mix on-demand and Spot instances in the Auto Scaling group. Defined below.</summary>
    [JsonPropertyName("instancesDistribution")]
    public IList<V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicyInstancesDistribution>? InstancesDistribution { get; set; }

    /// <summary>Nested argument containing launch template settings along with the overrides to specify multiple instance types and weights. Defined below.</summary>
    [JsonPropertyName("launchTemplate")]
    public IList<V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicyLaunchTemplate>? LaunchTemplate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupStatusAtProviderTag
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
public partial class V1beta2AutoscalingGroupStatusAtProviderTrafficSource
{
    /// <summary>Identifies the traffic source. For Application Load Balancers, Gateway Load Balancers, Network Load Balancers, and VPC Lattice, this will be the Amazon Resource Name (ARN) for a target group in this account and Region. For Classic Load Balancers, this will be the name of the Classic Load Balancer in this account and Region.</summary>
    [JsonPropertyName("identifier")]
    public string? Identifier { get; set; }

    /// <summary>Provides additional context for the value of Identifier. The following lists the valid values: elb if identifier is the name of a Classic Load Balancer. elbv2 if identifier is the ARN of an Application Load Balancer, Gateway Load Balancer, or Network Load Balancer target group. vpc-lattice if identifier is the ARN of a VPC Lattice target group.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupStatusAtProviderWarmPoolInstanceReusePolicy
{
    /// <summary>Whether instances in the Auto Scaling group can be returned to the warm pool on scale in.</summary>
    [JsonPropertyName("reuseOnScaleIn")]
    public bool? ReuseOnScaleIn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupStatusAtProviderWarmPool
{
    /// <summary>Whether instances in the Auto Scaling group can be returned to the warm pool on scale in. The default is to terminate instances in the Auto Scaling group when the group scales in.</summary>
    [JsonPropertyName("instanceReusePolicy")]
    public IList<V1beta2AutoscalingGroupStatusAtProviderWarmPoolInstanceReusePolicy>? InstanceReusePolicy { get; set; }

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
public partial class V1beta2AutoscalingGroupStatusAtProvider
{
    /// <summary>ARN for this Auto Scaling Group</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The instance capacity distribution across Availability Zones. See Availability Zone Distribution below for more details.</summary>
    [JsonPropertyName("availabilityZoneDistribution")]
    public IList<V1beta2AutoscalingGroupStatusAtProviderAvailabilityZoneDistribution>? AvailabilityZoneDistribution { get; set; }

    /// <summary>A list of Availability Zones where instances in the Auto Scaling group can be created. Used for launching into the default VPC subnet in each Availability Zone when not using the vpc_zone_identifier attribute, or for attaching a network interface when an existing network interface ID is specified in a launch template. Conflicts with vpc_zone_identifier.</summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>Whether capacity rebalance is enabled. Otherwise, capacity rebalance is disabled.</summary>
    [JsonPropertyName("capacityRebalance")]
    public bool? CapacityRebalance { get; set; }

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
    public IList<V1beta2AutoscalingGroupStatusAtProviderInitialLifecycleHook>? InitialLifecycleHook { get; set; }

    /// <summary>If this block is configured, add a instance maintenance policy to the specified Auto Scaling group. Defined below.</summary>
    [JsonPropertyName("instanceMaintenancePolicy")]
    public IList<V1beta2AutoscalingGroupStatusAtProviderInstanceMaintenancePolicy>? InstanceMaintenancePolicy { get; set; }

    /// <summary>If this block is configured, start an Instance Refresh when this Auto Scaling Group is updated. Defined below.</summary>
    [JsonPropertyName("instanceRefresh")]
    public IList<V1beta2AutoscalingGroupStatusAtProviderInstanceRefresh>? InstanceRefresh { get; set; }

    /// <summary>Name of the launch configuration to use.</summary>
    [JsonPropertyName("launchConfiguration")]
    public string? LaunchConfiguration { get; set; }

    /// <summary>Nested argument with Launch template specification to use to launch instances. See Launch Template below for more details.</summary>
    [JsonPropertyName("launchTemplate")]
    public IList<V1beta2AutoscalingGroupStatusAtProviderLaunchTemplate>? LaunchTemplate { get; set; }

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
    public IList<V1beta2AutoscalingGroupStatusAtProviderMixedInstancesPolicy>? MixedInstancesPolicy { get; set; }

    /// <summary>Name of the placement group into which you'll launch your instances, if any.</summary>
    [JsonPropertyName("placementGroup")]
    public string? PlacementGroup { get; set; }

    /// <summary>Predicted capacity of the group.</summary>
    [JsonPropertyName("predictedCapacity")]
    public double? PredictedCapacity { get; set; }

    /// <summary>Whether newly launched instances are automatically protected from termination by Amazon EC2 Auto Scaling when scaling in. For more information about preventing instances from terminating on scale in, see Using instance scale-in protection in the Amazon EC2 Auto Scaling User Guide.</summary>
    [JsonPropertyName("protectFromScaleIn")]
    public bool? ProtectFromScaleIn { get; set; }

    /// <summary>ARN of the service-linked role that the ASG will use to call other AWS services</summary>
    [JsonPropertyName("serviceLinkedRoleArn")]
    public string? ServiceLinkedRoleArn { get; set; }

    /// <summary>List of processes to suspend for the Auto Scaling Group. The allowed values are Launch, Terminate, HealthCheck, ReplaceUnhealthy, AZRebalance, AlarmNotification, ScheduledActions, AddToLoadBalancer, InstanceRefresh. Note that if you suspend either the Launch or Terminate process types, it can prevent your Auto Scaling Group from functioning properly.</summary>
    [JsonPropertyName("suspendedProcesses")]
    public IList<string>? SuspendedProcesses { get; set; }

    /// <summary>Configuration block(s) containing resource tags. See Tag below for more details.</summary>
    [JsonPropertyName("tag")]
    public IList<V1beta2AutoscalingGroupStatusAtProviderTag>? Tag { get; set; }

    /// <summary>Set of aws_alb_target_group ARNs, for use with Application or Network Load Balancing. To remove all target group attachments an empty list should be specified.</summary>
    [JsonPropertyName("targetGroupArns")]
    public IList<string>? TargetGroupArns { get; set; }

    /// <summary>List of policies to decide how the instances in the Auto Scaling Group should be terminated. The allowed values are OldestInstance, NewestInstance, OldestLaunchConfiguration, ClosestToNextInstanceHour, OldestLaunchTemplate, AllocationStrategy, Default. Additionally, the ARN of a Lambda function can be specified for custom termination policies.</summary>
    [JsonPropertyName("terminationPolicies")]
    public IList<string>? TerminationPolicies { get; set; }

    /// <summary>Attaches one or more traffic sources to the specified Auto Scaling group.</summary>
    [JsonPropertyName("trafficSource")]
    public IList<V1beta2AutoscalingGroupStatusAtProviderTrafficSource>? TrafficSource { get; set; }

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
    public IList<V1beta2AutoscalingGroupStatusAtProviderWarmPool>? WarmPool { get; set; }

    /// <summary>Current size of the warm pool.</summary>
    [JsonPropertyName("warmPoolSize")]
    public double? WarmPoolSize { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AutoscalingGroupStatusConditions
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
public partial class V1beta2AutoscalingGroupStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta2AutoscalingGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2AutoscalingGroupStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>AutoscalingGroup is the Schema for the AutoscalingGroups API. Provides an Auto Scaling Group resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2AutoscalingGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2AutoscalingGroupSpec>, IStatus<V1beta2AutoscalingGroupStatus>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "AutoscalingGroup";
    public const string KubeGroup = "autoscaling.aws.upbound.io";
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
    public V1beta2AutoscalingGroupSpec Spec { get; set; }

    /// <summary>AutoscalingGroupStatus defines the observed state of AutoscalingGroup.</summary>
    [JsonPropertyName("status")]
    public V1beta2AutoscalingGroupStatus? Status { get; set; }
}

/// <summary>AutoscalingGroup is the Schema for the AutoscalingGroups API. Provides an Auto Scaling Group resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2AutoscalingGroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta2AutoscalingGroup>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "AutoscalingGroupList";
    public const string KubeGroup = "autoscaling.aws.upbound.io";
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
    public IList<V1beta2AutoscalingGroup> Items { get; set; }
}