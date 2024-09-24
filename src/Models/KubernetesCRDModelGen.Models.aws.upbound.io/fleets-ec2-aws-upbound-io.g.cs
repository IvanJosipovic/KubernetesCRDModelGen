using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.upbound.io;
public enum V1beta1FleetSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1FleetSpecForProviderFleetInstanceSet
{
    /// <summary>The IDs of the instances.</summary>
    [JsonPropertyName("instanceIds")]
    public IList<string>? InstanceIds { get; set; }

    /// <summary>Instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Indicates if the instance that was launched is a Spot Instance or On-Demand Instance.</summary>
    [JsonPropertyName("lifecycle")]
    public string? Lifecycle { get; set; }

    /// <summary>The value is Windows for Windows instances. Otherwise, the value is blank.</summary>
    [JsonPropertyName("platform")]
    public string? Platform { get; set; }
}

public enum V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdRefPolicyResolutionEnum>))]
    public V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdRefPolicyResolveEnum>))]
    public V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdRefPolicy? Policy { get; set; }
}

public enum V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicyResolutionEnum>))]
    public V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicyResolveEnum>))]
    public V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolutionEnum>))]
    public V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolveEnum>))]
    public V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicy? Policy { get; set; }
}

public enum V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolutionEnum>))]
    public V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolveEnum>))]
    public V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecification
{
    /// <summary>The ID of the launch template.</summary>
    [JsonPropertyName("launchTemplateId")]
    public string? LaunchTemplateId { get; set; }

    /// <summary>Reference to a LaunchTemplate in ec2 to populate launchTemplateId.</summary>
    [JsonPropertyName("launchTemplateIdRef")]
    public V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdRef? LaunchTemplateIdRef { get; set; }

    /// <summary>Selector for a LaunchTemplate in ec2 to populate launchTemplateId.</summary>
    [JsonPropertyName("launchTemplateIdSelector")]
    public V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdSelector? LaunchTemplateIdSelector { get; set; }

    /// <summary>The name of the launch template.</summary>
    [JsonPropertyName("launchTemplateName")]
    public string? LaunchTemplateName { get; set; }

    /// <summary>The launch template version number, $Latest, or $Default.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>Reference to a LaunchTemplate in ec2 to populate version.</summary>
    [JsonPropertyName("versionRef")]
    public V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRef? VersionRef { get; set; }

    /// <summary>Selector for a LaunchTemplate in ec2 to populate version.</summary>
    [JsonPropertyName("versionSelector")]
    public V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelector? VersionSelector { get; set; }
}

public partial class V1beta1FleetSpecForProviderLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorCount
{
    /// <summary>The maximum number of vCPUs. To specify no maximum limit, omit this parameter.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>The minimum number of vCPUs. To specify no minimum limit, specify 0.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1FleetSpecForProviderLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorTotalMemoryMib
{
    /// <summary>The maximum number of vCPUs. To specify no maximum limit, omit this parameter.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>The minimum number of vCPUs. To specify no minimum limit, specify 0.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1FleetSpecForProviderLaunchTemplateConfigOverrideInstanceRequirementsBaselineEbsBandwidthMbps
{
    /// <summary>The maximum number of vCPUs. To specify no maximum limit, omit this parameter.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>The minimum number of vCPUs. To specify no minimum limit, specify 0.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1FleetSpecForProviderLaunchTemplateConfigOverrideInstanceRequirementsMemoryGibPerVcpu
{
    /// <summary>The maximum number of vCPUs. To specify no maximum limit, omit this parameter.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>The minimum number of vCPUs. To specify no minimum limit, specify 0.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1FleetSpecForProviderLaunchTemplateConfigOverrideInstanceRequirementsMemoryMib
{
    /// <summary>The maximum number of vCPUs. To specify no maximum limit, omit this parameter.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>The minimum number of vCPUs. To specify no minimum limit, specify 0.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1FleetSpecForProviderLaunchTemplateConfigOverrideInstanceRequirementsNetworkBandwidthGbps
{
    /// <summary>The maximum number of vCPUs. To specify no maximum limit, omit this parameter.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>The minimum number of vCPUs. To specify no minimum limit, specify 0.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1FleetSpecForProviderLaunchTemplateConfigOverrideInstanceRequirementsNetworkInterfaceCount
{
    /// <summary>The maximum number of vCPUs. To specify no maximum limit, omit this parameter.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>The minimum number of vCPUs. To specify no minimum limit, specify 0.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1FleetSpecForProviderLaunchTemplateConfigOverrideInstanceRequirementsTotalLocalStorageGb
{
    /// <summary>The maximum number of vCPUs. To specify no maximum limit, omit this parameter.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>The minimum number of vCPUs. To specify no minimum limit, specify 0.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1FleetSpecForProviderLaunchTemplateConfigOverrideInstanceRequirementsVcpuCount
{
    /// <summary>The maximum number of vCPUs. To specify no maximum limit, omit this parameter.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>The minimum number of vCPUs. To specify no minimum limit, specify 0.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1FleetSpecForProviderLaunchTemplateConfigOverrideInstanceRequirements
{
    /// <summary>Block describing the minimum and maximum number of accelerators (GPUs, FPGAs, or AWS Inferentia chips). Default is no minimum or maximum limits.</summary>
    [JsonPropertyName("acceleratorCount")]
    public V1beta1FleetSpecForProviderLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorCount? AcceleratorCount { get; set; }

    /// <summary>List of accelerator manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("acceleratorManufacturers")]
    public IList<string>? AcceleratorManufacturers { get; set; }

    /// <summary>List of accelerator names. Default is any acclerator.</summary>
    [JsonPropertyName("acceleratorNames")]
    public IList<string>? AcceleratorNames { get; set; }

    /// <summary>Block describing the minimum and maximum total memory of the accelerators. Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorTotalMemoryMib")]
    public V1beta1FleetSpecForProviderLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorTotalMemoryMib? AcceleratorTotalMemoryMib { get; set; }

    /// <summary>The accelerator types that must be on the instance type. Default is any accelerator type.</summary>
    [JsonPropertyName("acceleratorTypes")]
    public IList<string>? AcceleratorTypes { get; set; }

    /// <summary>The instance types to apply your specified attributes against. All other instance types are ignored, even if they match your specified attributes. You can use strings with one or more wild cards,represented by an asterisk (*). The following are examples: c5*, m5a.*, r*, *3*. For example, if you specify c5*, you are excluding the entire C5 instance family, which includes all C5a and C5n instance types. If you specify m5a.*, you are excluding all the M5a instance types, but not the M5n instance types. Maximum of 400 entries in the list; each entry is limited to 30 characters. Default is no excluded instance types. Default is any instance type.</summary>
    [JsonPropertyName("allowedInstanceTypes")]
    public IList<string>? AllowedInstanceTypes { get; set; }

    /// <summary>Indicate whether bare metal instace types should be included, excluded, or required. Default is excluded.</summary>
    [JsonPropertyName("bareMetal")]
    public string? BareMetal { get; set; }

    /// <summary>Block describing the minimum and maximum baseline EBS bandwidth, in Mbps. Default is no minimum or maximum.</summary>
    [JsonPropertyName("baselineEbsBandwidthMbps")]
    public V1beta1FleetSpecForProviderLaunchTemplateConfigOverrideInstanceRequirementsBaselineEbsBandwidthMbps? BaselineEbsBandwidthMbps { get; set; }

    /// <summary>Indicates whether burstable performance T instance types are included, excluded, or required. Default is excluded.</summary>
    [JsonPropertyName("burstablePerformance")]
    public string? BurstablePerformance { get; set; }

    /// <summary>The CPU manufacturers to include. Default is any manufacturer. ~> NOTE: Don't confuse the CPU hardware manufacturer with the CPU hardware architecture. Instances will be launched with a compatible CPU architecture based on the Amazon Machine Image (AMI) that you specify in your launch template.</summary>
    [JsonPropertyName("cpuManufacturers")]
    public IList<string>? CpuManufacturers { get; set; }

    /// <summary>The instance types to exclude. You can use strings with one or more wild cards, represented by an asterisk (*). The following are examples: c5*, m5a.*, r*, *3*. For example, if you specify c5*, you are excluding the entire C5 instance family, which includes all C5a and C5n instance types. If you specify m5a.*, you are excluding all the M5a instance types, but not the M5n instance types. Maximum of 400 entries in the list; each entry is limited to 30 characters. Default is no excluded instance types.</summary>
    [JsonPropertyName("excludedInstanceTypes")]
    public IList<string>? ExcludedInstanceTypes { get; set; }

    /// <summary>Indicates whether current or previous generation instance types are included. The current generation instance types are recommended for use. Valid values are current and previous. Default is current and previous generation instance types.</summary>
    [JsonPropertyName("instanceGenerations")]
    public IList<string>? InstanceGenerations { get; set; }

    /// <summary>Indicate whether instance types with local storage volumes are included, excluded, or required. Default is included.</summary>
    [JsonPropertyName("localStorage")]
    public string? LocalStorage { get; set; }

    /// <summary>List of local storage type names. Valid values are hdd and ssd. Default any storage type.</summary>
    [JsonPropertyName("localStorageTypes")]
    public IList<string>? LocalStorageTypes { get; set; }

    /// <summary>The price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Conflicts with spot_max_price_percentage_over_lowest_price</summary>
    [JsonPropertyName("maxSpotPriceAsPercentageOfOptimalOnDemandPrice")]
    public double? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (GiB) per vCPU. Default is no minimum or maximum.</summary>
    [JsonPropertyName("memoryGibPerVcpu")]
    public V1beta1FleetSpecForProviderLaunchTemplateConfigOverrideInstanceRequirementsMemoryGibPerVcpu? MemoryGibPerVcpu { get; set; }

    /// <summary>The minimum and maximum amount of memory per vCPU, in GiB. Default is no minimum or maximum limits.</summary>
    [JsonPropertyName("memoryMib")]
    public V1beta1FleetSpecForProviderLaunchTemplateConfigOverrideInstanceRequirementsMemoryMib? MemoryMib { get; set; }

    /// <summary>The minimum and maximum amount of network bandwidth, in gigabits per second (Gbps). Default is No minimum or maximum.</summary>
    [JsonPropertyName("networkBandwidthGbps")]
    public V1beta1FleetSpecForProviderLaunchTemplateConfigOverrideInstanceRequirementsNetworkBandwidthGbps? NetworkBandwidthGbps { get; set; }

    /// <summary>Block describing the minimum and maximum number of network interfaces. Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkInterfaceCount")]
    public V1beta1FleetSpecForProviderLaunchTemplateConfigOverrideInstanceRequirementsNetworkInterfaceCount? NetworkInterfaceCount { get; set; }

    /// <summary>The price protection threshold for On-Demand Instances. This is the maximum you’ll pay for an On-Demand Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 20.</summary>
    [JsonPropertyName("onDemandMaxPricePercentageOverLowestPrice")]
    public double? OnDemandMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Indicate whether instance types must support On-Demand Instance Hibernation, either true or false. Default is false.</summary>
    [JsonPropertyName("requireHibernateSupport")]
    public bool? RequireHibernateSupport { get; set; }

    /// <summary>The price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 100. Conflicts with max_spot_price_as_percentage_of_optimal_on_demand_price</summary>
    [JsonPropertyName("spotMaxPricePercentageOverLowestPrice")]
    public double? SpotMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Block describing the minimum and maximum total local storage (GB). Default is no minimum or maximum.</summary>
    [JsonPropertyName("totalLocalStorageGb")]
    public V1beta1FleetSpecForProviderLaunchTemplateConfigOverrideInstanceRequirementsTotalLocalStorageGb? TotalLocalStorageGb { get; set; }

    /// <summary>Block describing the minimum and maximum number of vCPUs. Default is no maximum.</summary>
    [JsonPropertyName("vcpuCount")]
    public V1beta1FleetSpecForProviderLaunchTemplateConfigOverrideInstanceRequirementsVcpuCount? VcpuCount { get; set; }
}

public partial class V1beta1FleetSpecForProviderLaunchTemplateConfigOverride
{
    /// <summary>Availability Zone in which to launch the instances.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>Override the instance type in the Launch Template with instance types that satisfy the requirements.</summary>
    [JsonPropertyName("instanceRequirements")]
    public V1beta1FleetSpecForProviderLaunchTemplateConfigOverrideInstanceRequirements? InstanceRequirements { get; set; }

    /// <summary>Instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Maximum price per unit hour that you are willing to pay for a Spot Instance.</summary>
    [JsonPropertyName("maxPrice")]
    public string? MaxPrice { get; set; }

    /// <summary>Priority for the launch template override. If on_demand_options allocation_strategy is set to prioritized, EC2 Fleet uses priority to determine which launch template override to use first in fulfilling On-Demand capacity. The highest priority is launched first. The lower the number, the higher the priority. If no number is set, the launch template override has the lowest priority. Valid values are whole numbers starting at 0.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>ID of the subnet in which to launch the instances.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Number of units provided by the specified instance type.</summary>
    [JsonPropertyName("weightedCapacity")]
    public double? WeightedCapacity { get; set; }
}

public partial class V1beta1FleetSpecForProviderLaunchTemplateConfig
{
    /// <summary>Nested argument containing EC2 Launch Template to use. Defined below.</summary>
    [JsonPropertyName("launchTemplateSpecification")]
    public V1beta1FleetSpecForProviderLaunchTemplateConfigLaunchTemplateSpecification? LaunchTemplateSpecification { get; set; }

    /// <summary>Nested argument(s) containing parameters to override the same parameters in the Launch Template. Defined below.</summary>
    [JsonPropertyName("override")]
    public IList<V1beta1FleetSpecForProviderLaunchTemplateConfigOverride>? Override { get; set; }
}

public partial class V1beta1FleetSpecForProviderOnDemandOptionsCapacityReservationOptions
{
    /// <summary>Indicates whether to use unused Capacity Reservations for fulfilling On-Demand capacity. Valid values: use-capacity-reservations-first.</summary>
    [JsonPropertyName("usageStrategy")]
    public string? UsageStrategy { get; set; }
}

public partial class V1beta1FleetSpecForProviderOnDemandOptions
{
    /// <summary>The order of the launch template overrides to use in fulfilling On-Demand capacity. Valid values: lowestPrice, prioritized. Default: lowestPrice.</summary>
    [JsonPropertyName("allocationStrategy")]
    public string? AllocationStrategy { get; set; }

    /// <summary>Demand capacity. Supported only for fleets of type instant.</summary>
    [JsonPropertyName("capacityReservationOptions")]
    public V1beta1FleetSpecForProviderOnDemandOptionsCapacityReservationOptions? CapacityReservationOptions { get; set; }

    /// <summary>The maximum amount per hour for On-Demand Instances that you're willing to pay.</summary>
    [JsonPropertyName("maxTotalPrice")]
    public string? MaxTotalPrice { get; set; }

    /// <summary>The minimum target capacity for On-Demand Instances in the fleet. If the minimum target capacity is not reached, the fleet launches no instances. Supported only for fleets of type instant. If you specify min_target_capacity, at least one of the following must be specified: single_availability_zone or single_instance_type.</summary>
    [JsonPropertyName("minTargetCapacity")]
    public double? MinTargetCapacity { get; set; }

    /// <summary>Indicates that the fleet launches all On-Demand Instances into a single Availability Zone. Supported only for fleets of type instant.</summary>
    [JsonPropertyName("singleAvailabilityZone")]
    public bool? SingleAvailabilityZone { get; set; }

    /// <summary>Indicates that the fleet uses a single instance type to launch all On-Demand Instances in the fleet. Supported only for fleets of type instant.</summary>
    [JsonPropertyName("singleInstanceType")]
    public bool? SingleInstanceType { get; set; }
}

public partial class V1beta1FleetSpecForProviderSpotOptionsMaintenanceStrategiesCapacityRebalance
{
    /// <summary>The replacement strategy to use. Only available for fleets of type set to maintain. Valid values: launch.</summary>
    [JsonPropertyName("replacementStrategy")]
    public string? ReplacementStrategy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationDelay")]
    public double? TerminationDelay { get; set; }
}

public partial class V1beta1FleetSpecForProviderSpotOptionsMaintenanceStrategies
{
    /// <summary>Nested argument containing the capacity rebalance for your fleet request. Defined below.</summary>
    [JsonPropertyName("capacityRebalance")]
    public V1beta1FleetSpecForProviderSpotOptionsMaintenanceStrategiesCapacityRebalance? CapacityRebalance { get; set; }
}

public partial class V1beta1FleetSpecForProviderSpotOptions
{
    /// <summary>How to allocate the target capacity across the Spot pools. Valid values: diversified, lowestPrice, capacity-optimized, capacity-optimized-prioritized and price-capacity-optimized. Default: lowestPrice.</summary>
    [JsonPropertyName("allocationStrategy")]
    public string? AllocationStrategy { get; set; }

    /// <summary>Behavior when a Spot Instance is interrupted. Valid values: hibernate, stop, terminate. Default: terminate.</summary>
    [JsonPropertyName("instanceInterruptionBehavior")]
    public string? InstanceInterruptionBehavior { get; set; }

    /// <summary>Number of Spot pools across which to allocate your target Spot capacity. Valid only when Spot allocation_strategy is set to lowestPrice. Default: 1.</summary>
    [JsonPropertyName("instancePoolsToUseCount")]
    public double? InstancePoolsToUseCount { get; set; }

    /// <summary>Nested argument containing maintenance strategies for managing your Spot Instances that are at an elevated risk of being interrupted. Defined below.</summary>
    [JsonPropertyName("maintenanceStrategies")]
    public V1beta1FleetSpecForProviderSpotOptionsMaintenanceStrategies? MaintenanceStrategies { get; set; }
}

public partial class V1beta1FleetSpecForProviderTargetCapacitySpecification
{
    /// <summary>Default target capacity type. Valid values: on-demand, spot.</summary>
    [JsonPropertyName("defaultTargetCapacityType")]
    public string? DefaultTargetCapacityType { get; set; }

    /// <summary>The number of On-Demand units to request.</summary>
    [JsonPropertyName("onDemandTargetCapacity")]
    public double? OnDemandTargetCapacity { get; set; }

    /// <summary>The number of Spot units to request.</summary>
    [JsonPropertyName("spotTargetCapacity")]
    public double? SpotTargetCapacity { get; set; }

    /// <summary>The unit for the target capacity. If you specify target_capacity_unit_type, instance_requirements must be specified.</summary>
    [JsonPropertyName("targetCapacityUnitType")]
    public string? TargetCapacityUnitType { get; set; }

    /// <summary>The number of units to request, filled using default_target_capacity_type.</summary>
    [JsonPropertyName("totalTargetCapacity")]
    public double? TotalTargetCapacity { get; set; }
}

public partial class V1beta1FleetSpecForProvider
{
    /// <summary>Reserved.</summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    /// <summary>Whether running instances should be terminated if the total target capacity of the EC2 Fleet is decreased below the current size of the EC2. Valid values: no-termination, termination. Defaults to termination. Supported only for fleets of type maintain.</summary>
    [JsonPropertyName("excessCapacityTerminationPolicy")]
    public string? ExcessCapacityTerminationPolicy { get; set; }

    /// <summary>Information about the instances that were launched by the fleet. Available only when type is set to instant.</summary>
    [JsonPropertyName("fleetInstanceSet")]
    public IList<V1beta1FleetSpecForProviderFleetInstanceSet>? FleetInstanceSet { get; set; }

    /// <summary>The state of the EC2 Fleet.</summary>
    [JsonPropertyName("fleetState")]
    public string? FleetState { get; set; }

    /// <summary>The number of units fulfilled by this request compared to the set target capacity.</summary>
    [JsonPropertyName("fulfilledCapacity")]
    public double? FulfilledCapacity { get; set; }

    /// <summary>The number of units fulfilled by this request compared to the set target On-Demand capacity.</summary>
    [JsonPropertyName("fulfilledOnDemandCapacity")]
    public double? FulfilledOnDemandCapacity { get; set; }

    /// <summary>Nested argument containing EC2 Launch Template configurations. Defined below.</summary>
    [JsonPropertyName("launchTemplateConfig")]
    public IList<V1beta1FleetSpecForProviderLaunchTemplateConfig>? LaunchTemplateConfig { get; set; }

    /// <summary>Nested argument containing On-Demand configurations. Defined below.</summary>
    [JsonPropertyName("onDemandOptions")]
    public V1beta1FleetSpecForProviderOnDemandOptions? OnDemandOptions { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Whether EC2 Fleet should replace unhealthy instances. Defaults to false. Supported only for fleets of type maintain.</summary>
    [JsonPropertyName("replaceUnhealthyInstances")]
    public bool? ReplaceUnhealthyInstances { get; set; }

    /// <summary>Nested argument containing Spot configurations. Defined below.</summary>
    [JsonPropertyName("spotOptions")]
    public V1beta1FleetSpecForProviderSpotOptions? SpotOptions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Nested argument containing target capacity configurations. Defined below.</summary>
    [JsonPropertyName("targetCapacitySpecification")]
    public V1beta1FleetSpecForProviderTargetCapacitySpecification? TargetCapacitySpecification { get; set; }

    /// <summary>Whether to terminate instances for an EC2 Fleet if it is deleted successfully. Defaults to false.</summary>
    [JsonPropertyName("terminateInstances")]
    public bool? TerminateInstances { get; set; }

    /// <summary>Whether running instances should be terminated when the EC2 Fleet expires. Defaults to false.</summary>
    [JsonPropertyName("terminateInstancesWithExpiration")]
    public bool? TerminateInstancesWithExpiration { get; set; }

    /// <summary>The type of request. Indicates whether the EC2 Fleet only requests the target capacity, or also attempts to maintain it. Valid values: maintain, request, instant. Defaults to maintain.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The start date and time of the request, in UTC format (for example, YYYY-MM-DDTHH:MM:SSZ). The default is to start fulfilling the request immediately.</summary>
    [JsonPropertyName("validFrom")]
    public string? ValidFrom { get; set; }

    /// <summary>The end date and time of the request, in UTC format (for example, YYYY-MM-DDTHH:MM:SSZ). At this point, no new EC2 Fleet requests are placed or able to fulfill the request. If no value is specified, the request remains until you cancel it.</summary>
    [JsonPropertyName("validUntil")]
    public string? ValidUntil { get; set; }
}

public partial class V1beta1FleetSpecInitProviderFleetInstanceSet
{
    /// <summary>The IDs of the instances.</summary>
    [JsonPropertyName("instanceIds")]
    public IList<string>? InstanceIds { get; set; }

    /// <summary>Instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Indicates if the instance that was launched is a Spot Instance or On-Demand Instance.</summary>
    [JsonPropertyName("lifecycle")]
    public string? Lifecycle { get; set; }

    /// <summary>The value is Windows for Windows instances. Otherwise, the value is blank.</summary>
    [JsonPropertyName("platform")]
    public string? Platform { get; set; }
}

public enum V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdRefPolicyResolutionEnum>))]
    public V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdRefPolicyResolveEnum>))]
    public V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdRefPolicy? Policy { get; set; }
}

public enum V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicyResolutionEnum>))]
    public V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicyResolveEnum>))]
    public V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolutionEnum>))]
    public V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolveEnum>))]
    public V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicy? Policy { get; set; }
}

public enum V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolutionEnum>))]
    public V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolveEnum>))]
    public V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecification
{
    /// <summary>The ID of the launch template.</summary>
    [JsonPropertyName("launchTemplateId")]
    public string? LaunchTemplateId { get; set; }

    /// <summary>Reference to a LaunchTemplate in ec2 to populate launchTemplateId.</summary>
    [JsonPropertyName("launchTemplateIdRef")]
    public V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdRef? LaunchTemplateIdRef { get; set; }

    /// <summary>Selector for a LaunchTemplate in ec2 to populate launchTemplateId.</summary>
    [JsonPropertyName("launchTemplateIdSelector")]
    public V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationLaunchTemplateIdSelector? LaunchTemplateIdSelector { get; set; }

    /// <summary>The name of the launch template.</summary>
    [JsonPropertyName("launchTemplateName")]
    public string? LaunchTemplateName { get; set; }

    /// <summary>The launch template version number, $Latest, or $Default.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>Reference to a LaunchTemplate in ec2 to populate version.</summary>
    [JsonPropertyName("versionRef")]
    public V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRef? VersionRef { get; set; }

    /// <summary>Selector for a LaunchTemplate in ec2 to populate version.</summary>
    [JsonPropertyName("versionSelector")]
    public V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelector? VersionSelector { get; set; }
}

public partial class V1beta1FleetSpecInitProviderLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorCount
{
    /// <summary>The maximum number of vCPUs. To specify no maximum limit, omit this parameter.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>The minimum number of vCPUs. To specify no minimum limit, specify 0.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1FleetSpecInitProviderLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorTotalMemoryMib
{
    /// <summary>The maximum number of vCPUs. To specify no maximum limit, omit this parameter.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>The minimum number of vCPUs. To specify no minimum limit, specify 0.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1FleetSpecInitProviderLaunchTemplateConfigOverrideInstanceRequirementsBaselineEbsBandwidthMbps
{
    /// <summary>The maximum number of vCPUs. To specify no maximum limit, omit this parameter.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>The minimum number of vCPUs. To specify no minimum limit, specify 0.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1FleetSpecInitProviderLaunchTemplateConfigOverrideInstanceRequirementsMemoryGibPerVcpu
{
    /// <summary>The maximum number of vCPUs. To specify no maximum limit, omit this parameter.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>The minimum number of vCPUs. To specify no minimum limit, specify 0.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1FleetSpecInitProviderLaunchTemplateConfigOverrideInstanceRequirementsMemoryMib
{
    /// <summary>The maximum number of vCPUs. To specify no maximum limit, omit this parameter.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>The minimum number of vCPUs. To specify no minimum limit, specify 0.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1FleetSpecInitProviderLaunchTemplateConfigOverrideInstanceRequirementsNetworkBandwidthGbps
{
    /// <summary>The maximum number of vCPUs. To specify no maximum limit, omit this parameter.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>The minimum number of vCPUs. To specify no minimum limit, specify 0.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1FleetSpecInitProviderLaunchTemplateConfigOverrideInstanceRequirementsNetworkInterfaceCount
{
    /// <summary>The maximum number of vCPUs. To specify no maximum limit, omit this parameter.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>The minimum number of vCPUs. To specify no minimum limit, specify 0.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1FleetSpecInitProviderLaunchTemplateConfigOverrideInstanceRequirementsTotalLocalStorageGb
{
    /// <summary>The maximum number of vCPUs. To specify no maximum limit, omit this parameter.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>The minimum number of vCPUs. To specify no minimum limit, specify 0.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1FleetSpecInitProviderLaunchTemplateConfigOverrideInstanceRequirementsVcpuCount
{
    /// <summary>The maximum number of vCPUs. To specify no maximum limit, omit this parameter.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>The minimum number of vCPUs. To specify no minimum limit, specify 0.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1FleetSpecInitProviderLaunchTemplateConfigOverrideInstanceRequirements
{
    /// <summary>Block describing the minimum and maximum number of accelerators (GPUs, FPGAs, or AWS Inferentia chips). Default is no minimum or maximum limits.</summary>
    [JsonPropertyName("acceleratorCount")]
    public V1beta1FleetSpecInitProviderLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorCount? AcceleratorCount { get; set; }

    /// <summary>List of accelerator manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("acceleratorManufacturers")]
    public IList<string>? AcceleratorManufacturers { get; set; }

    /// <summary>List of accelerator names. Default is any acclerator.</summary>
    [JsonPropertyName("acceleratorNames")]
    public IList<string>? AcceleratorNames { get; set; }

    /// <summary>Block describing the minimum and maximum total memory of the accelerators. Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorTotalMemoryMib")]
    public V1beta1FleetSpecInitProviderLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorTotalMemoryMib? AcceleratorTotalMemoryMib { get; set; }

    /// <summary>The accelerator types that must be on the instance type. Default is any accelerator type.</summary>
    [JsonPropertyName("acceleratorTypes")]
    public IList<string>? AcceleratorTypes { get; set; }

    /// <summary>The instance types to apply your specified attributes against. All other instance types are ignored, even if they match your specified attributes. You can use strings with one or more wild cards,represented by an asterisk (*). The following are examples: c5*, m5a.*, r*, *3*. For example, if you specify c5*, you are excluding the entire C5 instance family, which includes all C5a and C5n instance types. If you specify m5a.*, you are excluding all the M5a instance types, but not the M5n instance types. Maximum of 400 entries in the list; each entry is limited to 30 characters. Default is no excluded instance types. Default is any instance type.</summary>
    [JsonPropertyName("allowedInstanceTypes")]
    public IList<string>? AllowedInstanceTypes { get; set; }

    /// <summary>Indicate whether bare metal instace types should be included, excluded, or required. Default is excluded.</summary>
    [JsonPropertyName("bareMetal")]
    public string? BareMetal { get; set; }

    /// <summary>Block describing the minimum and maximum baseline EBS bandwidth, in Mbps. Default is no minimum or maximum.</summary>
    [JsonPropertyName("baselineEbsBandwidthMbps")]
    public V1beta1FleetSpecInitProviderLaunchTemplateConfigOverrideInstanceRequirementsBaselineEbsBandwidthMbps? BaselineEbsBandwidthMbps { get; set; }

    /// <summary>Indicates whether burstable performance T instance types are included, excluded, or required. Default is excluded.</summary>
    [JsonPropertyName("burstablePerformance")]
    public string? BurstablePerformance { get; set; }

    /// <summary>The CPU manufacturers to include. Default is any manufacturer. ~> NOTE: Don't confuse the CPU hardware manufacturer with the CPU hardware architecture. Instances will be launched with a compatible CPU architecture based on the Amazon Machine Image (AMI) that you specify in your launch template.</summary>
    [JsonPropertyName("cpuManufacturers")]
    public IList<string>? CpuManufacturers { get; set; }

    /// <summary>The instance types to exclude. You can use strings with one or more wild cards, represented by an asterisk (*). The following are examples: c5*, m5a.*, r*, *3*. For example, if you specify c5*, you are excluding the entire C5 instance family, which includes all C5a and C5n instance types. If you specify m5a.*, you are excluding all the M5a instance types, but not the M5n instance types. Maximum of 400 entries in the list; each entry is limited to 30 characters. Default is no excluded instance types.</summary>
    [JsonPropertyName("excludedInstanceTypes")]
    public IList<string>? ExcludedInstanceTypes { get; set; }

    /// <summary>Indicates whether current or previous generation instance types are included. The current generation instance types are recommended for use. Valid values are current and previous. Default is current and previous generation instance types.</summary>
    [JsonPropertyName("instanceGenerations")]
    public IList<string>? InstanceGenerations { get; set; }

    /// <summary>Indicate whether instance types with local storage volumes are included, excluded, or required. Default is included.</summary>
    [JsonPropertyName("localStorage")]
    public string? LocalStorage { get; set; }

    /// <summary>List of local storage type names. Valid values are hdd and ssd. Default any storage type.</summary>
    [JsonPropertyName("localStorageTypes")]
    public IList<string>? LocalStorageTypes { get; set; }

    /// <summary>The price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Conflicts with spot_max_price_percentage_over_lowest_price</summary>
    [JsonPropertyName("maxSpotPriceAsPercentageOfOptimalOnDemandPrice")]
    public double? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (GiB) per vCPU. Default is no minimum or maximum.</summary>
    [JsonPropertyName("memoryGibPerVcpu")]
    public V1beta1FleetSpecInitProviderLaunchTemplateConfigOverrideInstanceRequirementsMemoryGibPerVcpu? MemoryGibPerVcpu { get; set; }

    /// <summary>The minimum and maximum amount of memory per vCPU, in GiB. Default is no minimum or maximum limits.</summary>
    [JsonPropertyName("memoryMib")]
    public V1beta1FleetSpecInitProviderLaunchTemplateConfigOverrideInstanceRequirementsMemoryMib? MemoryMib { get; set; }

    /// <summary>The minimum and maximum amount of network bandwidth, in gigabits per second (Gbps). Default is No minimum or maximum.</summary>
    [JsonPropertyName("networkBandwidthGbps")]
    public V1beta1FleetSpecInitProviderLaunchTemplateConfigOverrideInstanceRequirementsNetworkBandwidthGbps? NetworkBandwidthGbps { get; set; }

    /// <summary>Block describing the minimum and maximum number of network interfaces. Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkInterfaceCount")]
    public V1beta1FleetSpecInitProviderLaunchTemplateConfigOverrideInstanceRequirementsNetworkInterfaceCount? NetworkInterfaceCount { get; set; }

    /// <summary>The price protection threshold for On-Demand Instances. This is the maximum you’ll pay for an On-Demand Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 20.</summary>
    [JsonPropertyName("onDemandMaxPricePercentageOverLowestPrice")]
    public double? OnDemandMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Indicate whether instance types must support On-Demand Instance Hibernation, either true or false. Default is false.</summary>
    [JsonPropertyName("requireHibernateSupport")]
    public bool? RequireHibernateSupport { get; set; }

    /// <summary>The price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 100. Conflicts with max_spot_price_as_percentage_of_optimal_on_demand_price</summary>
    [JsonPropertyName("spotMaxPricePercentageOverLowestPrice")]
    public double? SpotMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Block describing the minimum and maximum total local storage (GB). Default is no minimum or maximum.</summary>
    [JsonPropertyName("totalLocalStorageGb")]
    public V1beta1FleetSpecInitProviderLaunchTemplateConfigOverrideInstanceRequirementsTotalLocalStorageGb? TotalLocalStorageGb { get; set; }

    /// <summary>Block describing the minimum and maximum number of vCPUs. Default is no maximum.</summary>
    [JsonPropertyName("vcpuCount")]
    public V1beta1FleetSpecInitProviderLaunchTemplateConfigOverrideInstanceRequirementsVcpuCount? VcpuCount { get; set; }
}

public partial class V1beta1FleetSpecInitProviderLaunchTemplateConfigOverride
{
    /// <summary>Availability Zone in which to launch the instances.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>Override the instance type in the Launch Template with instance types that satisfy the requirements.</summary>
    [JsonPropertyName("instanceRequirements")]
    public V1beta1FleetSpecInitProviderLaunchTemplateConfigOverrideInstanceRequirements? InstanceRequirements { get; set; }

    /// <summary>Instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Maximum price per unit hour that you are willing to pay for a Spot Instance.</summary>
    [JsonPropertyName("maxPrice")]
    public string? MaxPrice { get; set; }

    /// <summary>Priority for the launch template override. If on_demand_options allocation_strategy is set to prioritized, EC2 Fleet uses priority to determine which launch template override to use first in fulfilling On-Demand capacity. The highest priority is launched first. The lower the number, the higher the priority. If no number is set, the launch template override has the lowest priority. Valid values are whole numbers starting at 0.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>ID of the subnet in which to launch the instances.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Number of units provided by the specified instance type.</summary>
    [JsonPropertyName("weightedCapacity")]
    public double? WeightedCapacity { get; set; }
}

public partial class V1beta1FleetSpecInitProviderLaunchTemplateConfig
{
    /// <summary>Nested argument containing EC2 Launch Template to use. Defined below.</summary>
    [JsonPropertyName("launchTemplateSpecification")]
    public V1beta1FleetSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecification? LaunchTemplateSpecification { get; set; }

    /// <summary>Nested argument(s) containing parameters to override the same parameters in the Launch Template. Defined below.</summary>
    [JsonPropertyName("override")]
    public IList<V1beta1FleetSpecInitProviderLaunchTemplateConfigOverride>? Override { get; set; }
}

public partial class V1beta1FleetSpecInitProviderOnDemandOptionsCapacityReservationOptions
{
    /// <summary>Indicates whether to use unused Capacity Reservations for fulfilling On-Demand capacity. Valid values: use-capacity-reservations-first.</summary>
    [JsonPropertyName("usageStrategy")]
    public string? UsageStrategy { get; set; }
}

public partial class V1beta1FleetSpecInitProviderOnDemandOptions
{
    /// <summary>The order of the launch template overrides to use in fulfilling On-Demand capacity. Valid values: lowestPrice, prioritized. Default: lowestPrice.</summary>
    [JsonPropertyName("allocationStrategy")]
    public string? AllocationStrategy { get; set; }

    /// <summary>Demand capacity. Supported only for fleets of type instant.</summary>
    [JsonPropertyName("capacityReservationOptions")]
    public V1beta1FleetSpecInitProviderOnDemandOptionsCapacityReservationOptions? CapacityReservationOptions { get; set; }

    /// <summary>The maximum amount per hour for On-Demand Instances that you're willing to pay.</summary>
    [JsonPropertyName("maxTotalPrice")]
    public string? MaxTotalPrice { get; set; }

    /// <summary>The minimum target capacity for On-Demand Instances in the fleet. If the minimum target capacity is not reached, the fleet launches no instances. Supported only for fleets of type instant. If you specify min_target_capacity, at least one of the following must be specified: single_availability_zone or single_instance_type.</summary>
    [JsonPropertyName("minTargetCapacity")]
    public double? MinTargetCapacity { get; set; }

    /// <summary>Indicates that the fleet launches all On-Demand Instances into a single Availability Zone. Supported only for fleets of type instant.</summary>
    [JsonPropertyName("singleAvailabilityZone")]
    public bool? SingleAvailabilityZone { get; set; }

    /// <summary>Indicates that the fleet uses a single instance type to launch all On-Demand Instances in the fleet. Supported only for fleets of type instant.</summary>
    [JsonPropertyName("singleInstanceType")]
    public bool? SingleInstanceType { get; set; }
}

public partial class V1beta1FleetSpecInitProviderSpotOptionsMaintenanceStrategiesCapacityRebalance
{
    /// <summary>The replacement strategy to use. Only available for fleets of type set to maintain. Valid values: launch.</summary>
    [JsonPropertyName("replacementStrategy")]
    public string? ReplacementStrategy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationDelay")]
    public double? TerminationDelay { get; set; }
}

public partial class V1beta1FleetSpecInitProviderSpotOptionsMaintenanceStrategies
{
    /// <summary>Nested argument containing the capacity rebalance for your fleet request. Defined below.</summary>
    [JsonPropertyName("capacityRebalance")]
    public V1beta1FleetSpecInitProviderSpotOptionsMaintenanceStrategiesCapacityRebalance? CapacityRebalance { get; set; }
}

public partial class V1beta1FleetSpecInitProviderSpotOptions
{
    /// <summary>How to allocate the target capacity across the Spot pools. Valid values: diversified, lowestPrice, capacity-optimized, capacity-optimized-prioritized and price-capacity-optimized. Default: lowestPrice.</summary>
    [JsonPropertyName("allocationStrategy")]
    public string? AllocationStrategy { get; set; }

    /// <summary>Behavior when a Spot Instance is interrupted. Valid values: hibernate, stop, terminate. Default: terminate.</summary>
    [JsonPropertyName("instanceInterruptionBehavior")]
    public string? InstanceInterruptionBehavior { get; set; }

    /// <summary>Number of Spot pools across which to allocate your target Spot capacity. Valid only when Spot allocation_strategy is set to lowestPrice. Default: 1.</summary>
    [JsonPropertyName("instancePoolsToUseCount")]
    public double? InstancePoolsToUseCount { get; set; }

    /// <summary>Nested argument containing maintenance strategies for managing your Spot Instances that are at an elevated risk of being interrupted. Defined below.</summary>
    [JsonPropertyName("maintenanceStrategies")]
    public V1beta1FleetSpecInitProviderSpotOptionsMaintenanceStrategies? MaintenanceStrategies { get; set; }
}

public partial class V1beta1FleetSpecInitProviderTargetCapacitySpecification
{
    /// <summary>Default target capacity type. Valid values: on-demand, spot.</summary>
    [JsonPropertyName("defaultTargetCapacityType")]
    public string? DefaultTargetCapacityType { get; set; }

    /// <summary>The number of On-Demand units to request.</summary>
    [JsonPropertyName("onDemandTargetCapacity")]
    public double? OnDemandTargetCapacity { get; set; }

    /// <summary>The number of Spot units to request.</summary>
    [JsonPropertyName("spotTargetCapacity")]
    public double? SpotTargetCapacity { get; set; }

    /// <summary>The unit for the target capacity. If you specify target_capacity_unit_type, instance_requirements must be specified.</summary>
    [JsonPropertyName("targetCapacityUnitType")]
    public string? TargetCapacityUnitType { get; set; }

    /// <summary>The number of units to request, filled using default_target_capacity_type.</summary>
    [JsonPropertyName("totalTargetCapacity")]
    public double? TotalTargetCapacity { get; set; }
}

public partial class V1beta1FleetSpecInitProvider
{
    /// <summary>Reserved.</summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    /// <summary>Whether running instances should be terminated if the total target capacity of the EC2 Fleet is decreased below the current size of the EC2. Valid values: no-termination, termination. Defaults to termination. Supported only for fleets of type maintain.</summary>
    [JsonPropertyName("excessCapacityTerminationPolicy")]
    public string? ExcessCapacityTerminationPolicy { get; set; }

    /// <summary>Information about the instances that were launched by the fleet. Available only when type is set to instant.</summary>
    [JsonPropertyName("fleetInstanceSet")]
    public IList<V1beta1FleetSpecInitProviderFleetInstanceSet>? FleetInstanceSet { get; set; }

    /// <summary>The state of the EC2 Fleet.</summary>
    [JsonPropertyName("fleetState")]
    public string? FleetState { get; set; }

    /// <summary>The number of units fulfilled by this request compared to the set target capacity.</summary>
    [JsonPropertyName("fulfilledCapacity")]
    public double? FulfilledCapacity { get; set; }

    /// <summary>The number of units fulfilled by this request compared to the set target On-Demand capacity.</summary>
    [JsonPropertyName("fulfilledOnDemandCapacity")]
    public double? FulfilledOnDemandCapacity { get; set; }

    /// <summary>Nested argument containing EC2 Launch Template configurations. Defined below.</summary>
    [JsonPropertyName("launchTemplateConfig")]
    public IList<V1beta1FleetSpecInitProviderLaunchTemplateConfig>? LaunchTemplateConfig { get; set; }

    /// <summary>Nested argument containing On-Demand configurations. Defined below.</summary>
    [JsonPropertyName("onDemandOptions")]
    public V1beta1FleetSpecInitProviderOnDemandOptions? OnDemandOptions { get; set; }

    /// <summary>Whether EC2 Fleet should replace unhealthy instances. Defaults to false. Supported only for fleets of type maintain.</summary>
    [JsonPropertyName("replaceUnhealthyInstances")]
    public bool? ReplaceUnhealthyInstances { get; set; }

    /// <summary>Nested argument containing Spot configurations. Defined below.</summary>
    [JsonPropertyName("spotOptions")]
    public V1beta1FleetSpecInitProviderSpotOptions? SpotOptions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Nested argument containing target capacity configurations. Defined below.</summary>
    [JsonPropertyName("targetCapacitySpecification")]
    public V1beta1FleetSpecInitProviderTargetCapacitySpecification? TargetCapacitySpecification { get; set; }

    /// <summary>Whether to terminate instances for an EC2 Fleet if it is deleted successfully. Defaults to false.</summary>
    [JsonPropertyName("terminateInstances")]
    public bool? TerminateInstances { get; set; }

    /// <summary>Whether running instances should be terminated when the EC2 Fleet expires. Defaults to false.</summary>
    [JsonPropertyName("terminateInstancesWithExpiration")]
    public bool? TerminateInstancesWithExpiration { get; set; }

    /// <summary>The type of request. Indicates whether the EC2 Fleet only requests the target capacity, or also attempts to maintain it. Valid values: maintain, request, instant. Defaults to maintain.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The start date and time of the request, in UTC format (for example, YYYY-MM-DDTHH:MM:SSZ). The default is to start fulfilling the request immediately.</summary>
    [JsonPropertyName("validFrom")]
    public string? ValidFrom { get; set; }

    /// <summary>The end date and time of the request, in UTC format (for example, YYYY-MM-DDTHH:MM:SSZ). At this point, no new EC2 Fleet requests are placed or able to fulfill the request. If no value is specified, the request remains until you cancel it.</summary>
    [JsonPropertyName("validUntil")]
    public string? ValidUntil { get; set; }
}

public enum V1beta1FleetSpecManagementPoliciesEnum
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

public enum V1beta1FleetSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FleetSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1FleetSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1FleetSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1FleetSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1FleetSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FleetSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1FleetSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1FleetSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1FleetSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1FleetSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1FleetSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1FleetSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FleetSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1FleetSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1FleetSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1FleetSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1FleetSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1FleetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1FleetSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1FleetSpecDeletionPolicyEnum>))]
    public V1beta1FleetSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FleetSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FleetSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1FleetSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FleetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1FleetSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FleetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1FleetStatusAtProviderFleetInstanceSet
{
    /// <summary>The IDs of the instances.</summary>
    [JsonPropertyName("instanceIds")]
    public IList<string>? InstanceIds { get; set; }

    /// <summary>Instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Indicates if the instance that was launched is a Spot Instance or On-Demand Instance.</summary>
    [JsonPropertyName("lifecycle")]
    public string? Lifecycle { get; set; }

    /// <summary>The value is Windows for Windows instances. Otherwise, the value is blank.</summary>
    [JsonPropertyName("platform")]
    public string? Platform { get; set; }
}

public partial class V1beta1FleetStatusAtProviderLaunchTemplateConfigLaunchTemplateSpecification
{
    /// <summary>The ID of the launch template.</summary>
    [JsonPropertyName("launchTemplateId")]
    public string? LaunchTemplateId { get; set; }

    /// <summary>The name of the launch template.</summary>
    [JsonPropertyName("launchTemplateName")]
    public string? LaunchTemplateName { get; set; }

    /// <summary>The launch template version number, $Latest, or $Default.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public partial class V1beta1FleetStatusAtProviderLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorCount
{
    /// <summary>The maximum number of vCPUs. To specify no maximum limit, omit this parameter.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>The minimum number of vCPUs. To specify no minimum limit, specify 0.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1FleetStatusAtProviderLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorTotalMemoryMib
{
    /// <summary>The maximum number of vCPUs. To specify no maximum limit, omit this parameter.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>The minimum number of vCPUs. To specify no minimum limit, specify 0.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1FleetStatusAtProviderLaunchTemplateConfigOverrideInstanceRequirementsBaselineEbsBandwidthMbps
{
    /// <summary>The maximum number of vCPUs. To specify no maximum limit, omit this parameter.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>The minimum number of vCPUs. To specify no minimum limit, specify 0.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1FleetStatusAtProviderLaunchTemplateConfigOverrideInstanceRequirementsMemoryGibPerVcpu
{
    /// <summary>The maximum number of vCPUs. To specify no maximum limit, omit this parameter.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>The minimum number of vCPUs. To specify no minimum limit, specify 0.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1FleetStatusAtProviderLaunchTemplateConfigOverrideInstanceRequirementsMemoryMib
{
    /// <summary>The maximum number of vCPUs. To specify no maximum limit, omit this parameter.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>The minimum number of vCPUs. To specify no minimum limit, specify 0.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1FleetStatusAtProviderLaunchTemplateConfigOverrideInstanceRequirementsNetworkBandwidthGbps
{
    /// <summary>The maximum number of vCPUs. To specify no maximum limit, omit this parameter.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>The minimum number of vCPUs. To specify no minimum limit, specify 0.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1FleetStatusAtProviderLaunchTemplateConfigOverrideInstanceRequirementsNetworkInterfaceCount
{
    /// <summary>The maximum number of vCPUs. To specify no maximum limit, omit this parameter.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>The minimum number of vCPUs. To specify no minimum limit, specify 0.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1FleetStatusAtProviderLaunchTemplateConfigOverrideInstanceRequirementsTotalLocalStorageGb
{
    /// <summary>The maximum number of vCPUs. To specify no maximum limit, omit this parameter.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>The minimum number of vCPUs. To specify no minimum limit, specify 0.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1FleetStatusAtProviderLaunchTemplateConfigOverrideInstanceRequirementsVcpuCount
{
    /// <summary>The maximum number of vCPUs. To specify no maximum limit, omit this parameter.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>The minimum number of vCPUs. To specify no minimum limit, specify 0.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

public partial class V1beta1FleetStatusAtProviderLaunchTemplateConfigOverrideInstanceRequirements
{
    /// <summary>Block describing the minimum and maximum number of accelerators (GPUs, FPGAs, or AWS Inferentia chips). Default is no minimum or maximum limits.</summary>
    [JsonPropertyName("acceleratorCount")]
    public V1beta1FleetStatusAtProviderLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorCount? AcceleratorCount { get; set; }

    /// <summary>List of accelerator manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("acceleratorManufacturers")]
    public IList<string>? AcceleratorManufacturers { get; set; }

    /// <summary>List of accelerator names. Default is any acclerator.</summary>
    [JsonPropertyName("acceleratorNames")]
    public IList<string>? AcceleratorNames { get; set; }

    /// <summary>Block describing the minimum and maximum total memory of the accelerators. Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorTotalMemoryMib")]
    public V1beta1FleetStatusAtProviderLaunchTemplateConfigOverrideInstanceRequirementsAcceleratorTotalMemoryMib? AcceleratorTotalMemoryMib { get; set; }

    /// <summary>The accelerator types that must be on the instance type. Default is any accelerator type.</summary>
    [JsonPropertyName("acceleratorTypes")]
    public IList<string>? AcceleratorTypes { get; set; }

    /// <summary>The instance types to apply your specified attributes against. All other instance types are ignored, even if they match your specified attributes. You can use strings with one or more wild cards,represented by an asterisk (*). The following are examples: c5*, m5a.*, r*, *3*. For example, if you specify c5*, you are excluding the entire C5 instance family, which includes all C5a and C5n instance types. If you specify m5a.*, you are excluding all the M5a instance types, but not the M5n instance types. Maximum of 400 entries in the list; each entry is limited to 30 characters. Default is no excluded instance types. Default is any instance type.</summary>
    [JsonPropertyName("allowedInstanceTypes")]
    public IList<string>? AllowedInstanceTypes { get; set; }

    /// <summary>Indicate whether bare metal instace types should be included, excluded, or required. Default is excluded.</summary>
    [JsonPropertyName("bareMetal")]
    public string? BareMetal { get; set; }

    /// <summary>Block describing the minimum and maximum baseline EBS bandwidth, in Mbps. Default is no minimum or maximum.</summary>
    [JsonPropertyName("baselineEbsBandwidthMbps")]
    public V1beta1FleetStatusAtProviderLaunchTemplateConfigOverrideInstanceRequirementsBaselineEbsBandwidthMbps? BaselineEbsBandwidthMbps { get; set; }

    /// <summary>Indicates whether burstable performance T instance types are included, excluded, or required. Default is excluded.</summary>
    [JsonPropertyName("burstablePerformance")]
    public string? BurstablePerformance { get; set; }

    /// <summary>The CPU manufacturers to include. Default is any manufacturer. ~> NOTE: Don't confuse the CPU hardware manufacturer with the CPU hardware architecture. Instances will be launched with a compatible CPU architecture based on the Amazon Machine Image (AMI) that you specify in your launch template.</summary>
    [JsonPropertyName("cpuManufacturers")]
    public IList<string>? CpuManufacturers { get; set; }

    /// <summary>The instance types to exclude. You can use strings with one or more wild cards, represented by an asterisk (*). The following are examples: c5*, m5a.*, r*, *3*. For example, if you specify c5*, you are excluding the entire C5 instance family, which includes all C5a and C5n instance types. If you specify m5a.*, you are excluding all the M5a instance types, but not the M5n instance types. Maximum of 400 entries in the list; each entry is limited to 30 characters. Default is no excluded instance types.</summary>
    [JsonPropertyName("excludedInstanceTypes")]
    public IList<string>? ExcludedInstanceTypes { get; set; }

    /// <summary>Indicates whether current or previous generation instance types are included. The current generation instance types are recommended for use. Valid values are current and previous. Default is current and previous generation instance types.</summary>
    [JsonPropertyName("instanceGenerations")]
    public IList<string>? InstanceGenerations { get; set; }

    /// <summary>Indicate whether instance types with local storage volumes are included, excluded, or required. Default is included.</summary>
    [JsonPropertyName("localStorage")]
    public string? LocalStorage { get; set; }

    /// <summary>List of local storage type names. Valid values are hdd and ssd. Default any storage type.</summary>
    [JsonPropertyName("localStorageTypes")]
    public IList<string>? LocalStorageTypes { get; set; }

    /// <summary>The price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Conflicts with spot_max_price_percentage_over_lowest_price</summary>
    [JsonPropertyName("maxSpotPriceAsPercentageOfOptimalOnDemandPrice")]
    public double? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (GiB) per vCPU. Default is no minimum or maximum.</summary>
    [JsonPropertyName("memoryGibPerVcpu")]
    public V1beta1FleetStatusAtProviderLaunchTemplateConfigOverrideInstanceRequirementsMemoryGibPerVcpu? MemoryGibPerVcpu { get; set; }

    /// <summary>The minimum and maximum amount of memory per vCPU, in GiB. Default is no minimum or maximum limits.</summary>
    [JsonPropertyName("memoryMib")]
    public V1beta1FleetStatusAtProviderLaunchTemplateConfigOverrideInstanceRequirementsMemoryMib? MemoryMib { get; set; }

    /// <summary>The minimum and maximum amount of network bandwidth, in gigabits per second (Gbps). Default is No minimum or maximum.</summary>
    [JsonPropertyName("networkBandwidthGbps")]
    public V1beta1FleetStatusAtProviderLaunchTemplateConfigOverrideInstanceRequirementsNetworkBandwidthGbps? NetworkBandwidthGbps { get; set; }

    /// <summary>Block describing the minimum and maximum number of network interfaces. Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkInterfaceCount")]
    public V1beta1FleetStatusAtProviderLaunchTemplateConfigOverrideInstanceRequirementsNetworkInterfaceCount? NetworkInterfaceCount { get; set; }

    /// <summary>The price protection threshold for On-Demand Instances. This is the maximum you’ll pay for an On-Demand Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 20.</summary>
    [JsonPropertyName("onDemandMaxPricePercentageOverLowestPrice")]
    public double? OnDemandMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Indicate whether instance types must support On-Demand Instance Hibernation, either true or false. Default is false.</summary>
    [JsonPropertyName("requireHibernateSupport")]
    public bool? RequireHibernateSupport { get; set; }

    /// <summary>The price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 100. Conflicts with max_spot_price_as_percentage_of_optimal_on_demand_price</summary>
    [JsonPropertyName("spotMaxPricePercentageOverLowestPrice")]
    public double? SpotMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Block describing the minimum and maximum total local storage (GB). Default is no minimum or maximum.</summary>
    [JsonPropertyName("totalLocalStorageGb")]
    public V1beta1FleetStatusAtProviderLaunchTemplateConfigOverrideInstanceRequirementsTotalLocalStorageGb? TotalLocalStorageGb { get; set; }

    /// <summary>Block describing the minimum and maximum number of vCPUs. Default is no maximum.</summary>
    [JsonPropertyName("vcpuCount")]
    public V1beta1FleetStatusAtProviderLaunchTemplateConfigOverrideInstanceRequirementsVcpuCount? VcpuCount { get; set; }
}

public partial class V1beta1FleetStatusAtProviderLaunchTemplateConfigOverride
{
    /// <summary>Availability Zone in which to launch the instances.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>Override the instance type in the Launch Template with instance types that satisfy the requirements.</summary>
    [JsonPropertyName("instanceRequirements")]
    public V1beta1FleetStatusAtProviderLaunchTemplateConfigOverrideInstanceRequirements? InstanceRequirements { get; set; }

    /// <summary>Instance type.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Maximum price per unit hour that you are willing to pay for a Spot Instance.</summary>
    [JsonPropertyName("maxPrice")]
    public string? MaxPrice { get; set; }

    /// <summary>Priority for the launch template override. If on_demand_options allocation_strategy is set to prioritized, EC2 Fleet uses priority to determine which launch template override to use first in fulfilling On-Demand capacity. The highest priority is launched first. The lower the number, the higher the priority. If no number is set, the launch template override has the lowest priority. Valid values are whole numbers starting at 0.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>ID of the subnet in which to launch the instances.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Number of units provided by the specified instance type.</summary>
    [JsonPropertyName("weightedCapacity")]
    public double? WeightedCapacity { get; set; }
}

public partial class V1beta1FleetStatusAtProviderLaunchTemplateConfig
{
    /// <summary>Nested argument containing EC2 Launch Template to use. Defined below.</summary>
    [JsonPropertyName("launchTemplateSpecification")]
    public V1beta1FleetStatusAtProviderLaunchTemplateConfigLaunchTemplateSpecification? LaunchTemplateSpecification { get; set; }

    /// <summary>Nested argument(s) containing parameters to override the same parameters in the Launch Template. Defined below.</summary>
    [JsonPropertyName("override")]
    public IList<V1beta1FleetStatusAtProviderLaunchTemplateConfigOverride>? Override { get; set; }
}

public partial class V1beta1FleetStatusAtProviderOnDemandOptionsCapacityReservationOptions
{
    /// <summary>Indicates whether to use unused Capacity Reservations for fulfilling On-Demand capacity. Valid values: use-capacity-reservations-first.</summary>
    [JsonPropertyName("usageStrategy")]
    public string? UsageStrategy { get; set; }
}

public partial class V1beta1FleetStatusAtProviderOnDemandOptions
{
    /// <summary>The order of the launch template overrides to use in fulfilling On-Demand capacity. Valid values: lowestPrice, prioritized. Default: lowestPrice.</summary>
    [JsonPropertyName("allocationStrategy")]
    public string? AllocationStrategy { get; set; }

    /// <summary>Demand capacity. Supported only for fleets of type instant.</summary>
    [JsonPropertyName("capacityReservationOptions")]
    public V1beta1FleetStatusAtProviderOnDemandOptionsCapacityReservationOptions? CapacityReservationOptions { get; set; }

    /// <summary>The maximum amount per hour for On-Demand Instances that you're willing to pay.</summary>
    [JsonPropertyName("maxTotalPrice")]
    public string? MaxTotalPrice { get; set; }

    /// <summary>The minimum target capacity for On-Demand Instances in the fleet. If the minimum target capacity is not reached, the fleet launches no instances. Supported only for fleets of type instant. If you specify min_target_capacity, at least one of the following must be specified: single_availability_zone or single_instance_type.</summary>
    [JsonPropertyName("minTargetCapacity")]
    public double? MinTargetCapacity { get; set; }

    /// <summary>Indicates that the fleet launches all On-Demand Instances into a single Availability Zone. Supported only for fleets of type instant.</summary>
    [JsonPropertyName("singleAvailabilityZone")]
    public bool? SingleAvailabilityZone { get; set; }

    /// <summary>Indicates that the fleet uses a single instance type to launch all On-Demand Instances in the fleet. Supported only for fleets of type instant.</summary>
    [JsonPropertyName("singleInstanceType")]
    public bool? SingleInstanceType { get; set; }
}

public partial class V1beta1FleetStatusAtProviderSpotOptionsMaintenanceStrategiesCapacityRebalance
{
    /// <summary>The replacement strategy to use. Only available for fleets of type set to maintain. Valid values: launch.</summary>
    [JsonPropertyName("replacementStrategy")]
    public string? ReplacementStrategy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("terminationDelay")]
    public double? TerminationDelay { get; set; }
}

public partial class V1beta1FleetStatusAtProviderSpotOptionsMaintenanceStrategies
{
    /// <summary>Nested argument containing the capacity rebalance for your fleet request. Defined below.</summary>
    [JsonPropertyName("capacityRebalance")]
    public V1beta1FleetStatusAtProviderSpotOptionsMaintenanceStrategiesCapacityRebalance? CapacityRebalance { get; set; }
}

public partial class V1beta1FleetStatusAtProviderSpotOptions
{
    /// <summary>How to allocate the target capacity across the Spot pools. Valid values: diversified, lowestPrice, capacity-optimized, capacity-optimized-prioritized and price-capacity-optimized. Default: lowestPrice.</summary>
    [JsonPropertyName("allocationStrategy")]
    public string? AllocationStrategy { get; set; }

    /// <summary>Behavior when a Spot Instance is interrupted. Valid values: hibernate, stop, terminate. Default: terminate.</summary>
    [JsonPropertyName("instanceInterruptionBehavior")]
    public string? InstanceInterruptionBehavior { get; set; }

    /// <summary>Number of Spot pools across which to allocate your target Spot capacity. Valid only when Spot allocation_strategy is set to lowestPrice. Default: 1.</summary>
    [JsonPropertyName("instancePoolsToUseCount")]
    public double? InstancePoolsToUseCount { get; set; }

    /// <summary>Nested argument containing maintenance strategies for managing your Spot Instances that are at an elevated risk of being interrupted. Defined below.</summary>
    [JsonPropertyName("maintenanceStrategies")]
    public V1beta1FleetStatusAtProviderSpotOptionsMaintenanceStrategies? MaintenanceStrategies { get; set; }
}

public partial class V1beta1FleetStatusAtProviderTargetCapacitySpecification
{
    /// <summary>Default target capacity type. Valid values: on-demand, spot.</summary>
    [JsonPropertyName("defaultTargetCapacityType")]
    public string? DefaultTargetCapacityType { get; set; }

    /// <summary>The number of On-Demand units to request.</summary>
    [JsonPropertyName("onDemandTargetCapacity")]
    public double? OnDemandTargetCapacity { get; set; }

    /// <summary>The number of Spot units to request.</summary>
    [JsonPropertyName("spotTargetCapacity")]
    public double? SpotTargetCapacity { get; set; }

    /// <summary>The unit for the target capacity. If you specify target_capacity_unit_type, instance_requirements must be specified.</summary>
    [JsonPropertyName("targetCapacityUnitType")]
    public string? TargetCapacityUnitType { get; set; }

    /// <summary>The number of units to request, filled using default_target_capacity_type.</summary>
    [JsonPropertyName("totalTargetCapacity")]
    public double? TotalTargetCapacity { get; set; }
}

public partial class V1beta1FleetStatusAtProvider
{
    /// <summary>The ARN of the fleet</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reserved.</summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    /// <summary>Whether running instances should be terminated if the total target capacity of the EC2 Fleet is decreased below the current size of the EC2. Valid values: no-termination, termination. Defaults to termination. Supported only for fleets of type maintain.</summary>
    [JsonPropertyName("excessCapacityTerminationPolicy")]
    public string? ExcessCapacityTerminationPolicy { get; set; }

    /// <summary>Information about the instances that were launched by the fleet. Available only when type is set to instant.</summary>
    [JsonPropertyName("fleetInstanceSet")]
    public IList<V1beta1FleetStatusAtProviderFleetInstanceSet>? FleetInstanceSet { get; set; }

    /// <summary>The state of the EC2 Fleet.</summary>
    [JsonPropertyName("fleetState")]
    public string? FleetState { get; set; }

    /// <summary>The number of units fulfilled by this request compared to the set target capacity.</summary>
    [JsonPropertyName("fulfilledCapacity")]
    public double? FulfilledCapacity { get; set; }

    /// <summary>The number of units fulfilled by this request compared to the set target On-Demand capacity.</summary>
    [JsonPropertyName("fulfilledOnDemandCapacity")]
    public double? FulfilledOnDemandCapacity { get; set; }

    /// <summary>Fleet identifier</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Nested argument containing EC2 Launch Template configurations. Defined below.</summary>
    [JsonPropertyName("launchTemplateConfig")]
    public IList<V1beta1FleetStatusAtProviderLaunchTemplateConfig>? LaunchTemplateConfig { get; set; }

    /// <summary>Nested argument containing On-Demand configurations. Defined below.</summary>
    [JsonPropertyName("onDemandOptions")]
    public V1beta1FleetStatusAtProviderOnDemandOptions? OnDemandOptions { get; set; }

    /// <summary>Whether EC2 Fleet should replace unhealthy instances. Defaults to false. Supported only for fleets of type maintain.</summary>
    [JsonPropertyName("replaceUnhealthyInstances")]
    public bool? ReplaceUnhealthyInstances { get; set; }

    /// <summary>Nested argument containing Spot configurations. Defined below.</summary>
    [JsonPropertyName("spotOptions")]
    public V1beta1FleetStatusAtProviderSpotOptions? SpotOptions { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Nested argument containing target capacity configurations. Defined below.</summary>
    [JsonPropertyName("targetCapacitySpecification")]
    public V1beta1FleetStatusAtProviderTargetCapacitySpecification? TargetCapacitySpecification { get; set; }

    /// <summary>Whether to terminate instances for an EC2 Fleet if it is deleted successfully. Defaults to false.</summary>
    [JsonPropertyName("terminateInstances")]
    public bool? TerminateInstances { get; set; }

    /// <summary>Whether running instances should be terminated when the EC2 Fleet expires. Defaults to false.</summary>
    [JsonPropertyName("terminateInstancesWithExpiration")]
    public bool? TerminateInstancesWithExpiration { get; set; }

    /// <summary>The type of request. Indicates whether the EC2 Fleet only requests the target capacity, or also attempts to maintain it. Valid values: maintain, request, instant. Defaults to maintain.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The start date and time of the request, in UTC format (for example, YYYY-MM-DDTHH:MM:SSZ). The default is to start fulfilling the request immediately.</summary>
    [JsonPropertyName("validFrom")]
    public string? ValidFrom { get; set; }

    /// <summary>The end date and time of the request, in UTC format (for example, YYYY-MM-DDTHH:MM:SSZ). At this point, no new EC2 Fleet requests are placed or able to fulfill the request. If no value is specified, the request remains until you cancel it.</summary>
    [JsonPropertyName("validUntil")]
    public string? ValidUntil { get; set; }
}

public partial class V1beta1FleetStatusConditions
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

public partial class V1beta1FleetStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FleetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FleetStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Fleet : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FleetSpec>, IStatus<V1beta1FleetStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Fleet";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "fleets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FleetSpec defines the desired state of Fleet</summary>
    [JsonPropertyName("spec")]
    public V1beta1FleetSpec Spec { get; set; }

    /// <summary>FleetStatus defines the observed state of Fleet.</summary>
    [JsonPropertyName("status")]
    public V1beta1FleetStatus? Status { get; set; }
}