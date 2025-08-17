using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.upbound.io;
#nullable enable
/// <summary>ResourcePolicy is the Schema for the ResourcePolicys API. A policy that can be attached to a resource to specify or schedule actions on that resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ResourcePolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ResourcePolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ResourcePolicyList";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "resourcepolicies";
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
    public IList<V1beta1ResourcePolicy> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecForProviderDiskConsistencyGroupPolicy
{
    /// <summary>Enable disk consistency on the resource policy.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecForProviderGroupPlacementPolicy
{
    /// <summary>The number of availability domains instances will be spread across. If two instances are in different availability domain, they will not be put in the same low latency network</summary>
    [JsonPropertyName("availabilityDomainCount")]
    public double? AvailabilityDomainCount { get; set; }

    /// <summary>Collocation specifies whether to place VMs inside the same availability domain on the same low-latency network. Specify COLLOCATED to enable collocation. Can only be specified with vm_count. If compute instances are created with a COLLOCATED policy, then exactly vm_count instances must be created at the same time with the resource policy attached. Possible values are: COLLOCATED.</summary>
    [JsonPropertyName("collocation")]
    public string? Collocation { get; set; }

    /// <summary>Specifies the shape of the GPU slice, in slice based GPU families eg. A4X.</summary>
    [JsonPropertyName("gpuTopology")]
    public string? GpuTopology { get; set; }

    /// <summary>Number of VMs in this placement group. Google does not recommend that you use this field unless you use a compact policy and you want your policy to work only if it contains this exact number of VMs.</summary>
    [JsonPropertyName("vmCount")]
    public double? VmCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecForProviderInstanceSchedulePolicyVmStartSchedule
{
    /// <summary>Specifies the frequency for the operation, using the unix-cron format.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecForProviderInstanceSchedulePolicyVmStopSchedule
{
    /// <summary>Specifies the frequency for the operation, using the unix-cron format.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecForProviderInstanceSchedulePolicy
{
    /// <summary>The expiration time of the schedule. The timestamp is an RFC3339 string.</summary>
    [JsonPropertyName("expirationTime")]
    public string? ExpirationTime { get; set; }

    /// <summary>The start time of the schedule. The timestamp is an RFC3339 string.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Specifies the time zone to be used in interpreting the schedule. The value of this field must be a time zone name from the tz database: http://en.wikipedia.org/wiki/Tz_database.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>Specifies the schedule for starting instances. Structure is documented below.</summary>
    [JsonPropertyName("vmStartSchedule")]
    public IList<V1beta1ResourcePolicySpecForProviderInstanceSchedulePolicyVmStartSchedule>? VmStartSchedule { get; set; }

    /// <summary>Specifies the schedule for stopping instances. Structure is documented below.</summary>
    [JsonPropertyName("vmStopSchedule")]
    public IList<V1beta1ResourcePolicySpecForProviderInstanceSchedulePolicyVmStopSchedule>? VmStopSchedule { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecForProviderSnapshotSchedulePolicyRetentionPolicy
{
    /// <summary>Maximum age of the snapshot that is allowed to be kept.</summary>
    [JsonPropertyName("maxRetentionDays")]
    public double? MaxRetentionDays { get; set; }

    /// <summary>Specifies the behavior to apply to scheduled snapshots when the source disk is deleted. Default value is KEEP_AUTO_SNAPSHOTS. Possible values are: KEEP_AUTO_SNAPSHOTS, APPLY_RETENTION_POLICY.</summary>
    [JsonPropertyName("onSourceDiskDelete")]
    public string? OnSourceDiskDelete { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecForProviderSnapshotSchedulePolicyScheduleDailySchedule
{
    /// <summary>Defines a schedule with units measured in days. The value determines how many days pass between the start of each cycle. Days in cycle for snapshot schedule policy must be 1.</summary>
    [JsonPropertyName("daysInCycle")]
    public double? DaysInCycle { get; set; }

    /// <summary>Time within the window to start the operations. It must be in format "HH:MM", where HH : [00-23] and MM : [00-00] GMT.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecForProviderSnapshotSchedulePolicyScheduleHourlySchedule
{
    /// <summary>The number of hours between snapshots.</summary>
    [JsonPropertyName("hoursInCycle")]
    public double? HoursInCycle { get; set; }

    /// <summary>Time within the window to start the operations. It must be in format "HH:MM", where HH : [00-23] and MM : [00-00] GMT.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecForProviderSnapshotSchedulePolicyScheduleWeeklyScheduleDayOfWeeks
{
    /// <summary>The day of the week to create the snapshot. e.g. MONDAY Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("day")]
    public string? Day { get; set; }

    /// <summary>Time within the window to start the operations. It must be in format "HH:MM", where HH : [00-23] and MM : [00-00] GMT.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecForProviderSnapshotSchedulePolicyScheduleWeeklySchedule
{
    /// <summary>May contain up to seven (one for each day of the week) snapshot times. Structure is documented below.</summary>
    [JsonPropertyName("dayOfWeeks")]
    public IList<V1beta1ResourcePolicySpecForProviderSnapshotSchedulePolicyScheduleWeeklyScheduleDayOfWeeks>? DayOfWeeks { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecForProviderSnapshotSchedulePolicySchedule
{
    /// <summary>The policy will execute every nth day at the specified time. Structure is documented below.</summary>
    [JsonPropertyName("dailySchedule")]
    public IList<V1beta1ResourcePolicySpecForProviderSnapshotSchedulePolicyScheduleDailySchedule>? DailySchedule { get; set; }

    /// <summary>The policy will execute every nth hour starting at the specified time. Structure is documented below.</summary>
    [JsonPropertyName("hourlySchedule")]
    public IList<V1beta1ResourcePolicySpecForProviderSnapshotSchedulePolicyScheduleHourlySchedule>? HourlySchedule { get; set; }

    /// <summary>Allows specifying a snapshot time for each day of the week. Structure is documented below.</summary>
    [JsonPropertyName("weeklySchedule")]
    public IList<V1beta1ResourcePolicySpecForProviderSnapshotSchedulePolicyScheduleWeeklySchedule>? WeeklySchedule { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecForProviderSnapshotSchedulePolicySnapshotProperties
{
    /// <summary>Creates the new snapshot in the snapshot chain labeled with the specified name. The chain name must be 1-63 characters long and comply with RFC1035.</summary>
    [JsonPropertyName("chainName")]
    public string? ChainName { get; set; }

    /// <summary>Whether to perform a 'guest aware' snapshot.</summary>
    [JsonPropertyName("guestFlush")]
    public bool? GuestFlush { get; set; }

    /// <summary>A set of key-value pairs.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Cloud Storage bucket location to store the auto snapshot (regional or multi-regional)</summary>
    [JsonPropertyName("storageLocations")]
    public IList<string>? StorageLocations { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecForProviderSnapshotSchedulePolicy
{
    /// <summary>Retention policy applied to snapshots created by this resource policy. Structure is documented below.</summary>
    [JsonPropertyName("retentionPolicy")]
    public IList<V1beta1ResourcePolicySpecForProviderSnapshotSchedulePolicyRetentionPolicy>? RetentionPolicy { get; set; }

    /// <summary>Contains one of an hourlySchedule, dailySchedule, or weeklySchedule. Structure is documented below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1ResourcePolicySpecForProviderSnapshotSchedulePolicySchedule>? Schedule { get; set; }

    /// <summary>Properties with which the snapshots are created, such as labels. Structure is documented below.</summary>
    [JsonPropertyName("snapshotProperties")]
    public IList<V1beta1ResourcePolicySpecForProviderSnapshotSchedulePolicySnapshotProperties>? SnapshotProperties { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecForProviderWorkloadPolicy
{
    /// <summary>The accelerator topology. This field can be set only when the workload policy type is HIGH_THROUGHPUT and cannot be set if max topology distance is set.</summary>
    [JsonPropertyName("acceleratorTopology")]
    public string? AcceleratorTopology { get; set; }

    /// <summary>The maximum topology distance. This field can be set only when the workload policy type is HIGH_THROUGHPUT and cannot be set if accelerator topology is set. Possible values are: BLOCK, CLUSTER, SUBBLOCK.</summary>
    [JsonPropertyName("maxTopologyDistance")]
    public string? MaxTopologyDistance { get; set; }

    /// <summary>The type of workload policy. Possible values are: HIGH_AVAILABILITY, HIGH_THROUGHPUT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecForProvider
{
    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Replication consistency group for asynchronous disk replication. Structure is documented below.</summary>
    [JsonPropertyName("diskConsistencyGroupPolicy")]
    public IList<V1beta1ResourcePolicySpecForProviderDiskConsistencyGroupPolicy>? DiskConsistencyGroupPolicy { get; set; }

    /// <summary>Resource policy for instances used for placement configuration. Structure is documented below.</summary>
    [JsonPropertyName("groupPlacementPolicy")]
    public IList<V1beta1ResourcePolicySpecForProviderGroupPlacementPolicy>? GroupPlacementPolicy { get; set; }

    /// <summary>Resource policy for scheduling instance operations. Structure is documented below.</summary>
    [JsonPropertyName("instanceSchedulePolicy")]
    public IList<V1beta1ResourcePolicySpecForProviderInstanceSchedulePolicy>? InstanceSchedulePolicy { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Region where resource policy resides.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Policy for creating snapshots of persistent disks. Structure is documented below.</summary>
    [JsonPropertyName("snapshotSchedulePolicy")]
    public IList<V1beta1ResourcePolicySpecForProviderSnapshotSchedulePolicy>? SnapshotSchedulePolicy { get; set; }

    /// <summary>Represents the workload policy. Structure is documented below.</summary>
    [JsonPropertyName("workloadPolicy")]
    public IList<V1beta1ResourcePolicySpecForProviderWorkloadPolicy>? WorkloadPolicy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecInitProviderDiskConsistencyGroupPolicy
{
    /// <summary>Enable disk consistency on the resource policy.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecInitProviderGroupPlacementPolicy
{
    /// <summary>The number of availability domains instances will be spread across. If two instances are in different availability domain, they will not be put in the same low latency network</summary>
    [JsonPropertyName("availabilityDomainCount")]
    public double? AvailabilityDomainCount { get; set; }

    /// <summary>Collocation specifies whether to place VMs inside the same availability domain on the same low-latency network. Specify COLLOCATED to enable collocation. Can only be specified with vm_count. If compute instances are created with a COLLOCATED policy, then exactly vm_count instances must be created at the same time with the resource policy attached. Possible values are: COLLOCATED.</summary>
    [JsonPropertyName("collocation")]
    public string? Collocation { get; set; }

    /// <summary>Specifies the shape of the GPU slice, in slice based GPU families eg. A4X.</summary>
    [JsonPropertyName("gpuTopology")]
    public string? GpuTopology { get; set; }

    /// <summary>Number of VMs in this placement group. Google does not recommend that you use this field unless you use a compact policy and you want your policy to work only if it contains this exact number of VMs.</summary>
    [JsonPropertyName("vmCount")]
    public double? VmCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecInitProviderInstanceSchedulePolicyVmStartSchedule
{
    /// <summary>Specifies the frequency for the operation, using the unix-cron format.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecInitProviderInstanceSchedulePolicyVmStopSchedule
{
    /// <summary>Specifies the frequency for the operation, using the unix-cron format.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecInitProviderInstanceSchedulePolicy
{
    /// <summary>The expiration time of the schedule. The timestamp is an RFC3339 string.</summary>
    [JsonPropertyName("expirationTime")]
    public string? ExpirationTime { get; set; }

    /// <summary>The start time of the schedule. The timestamp is an RFC3339 string.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Specifies the time zone to be used in interpreting the schedule. The value of this field must be a time zone name from the tz database: http://en.wikipedia.org/wiki/Tz_database.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>Specifies the schedule for starting instances. Structure is documented below.</summary>
    [JsonPropertyName("vmStartSchedule")]
    public IList<V1beta1ResourcePolicySpecInitProviderInstanceSchedulePolicyVmStartSchedule>? VmStartSchedule { get; set; }

    /// <summary>Specifies the schedule for stopping instances. Structure is documented below.</summary>
    [JsonPropertyName("vmStopSchedule")]
    public IList<V1beta1ResourcePolicySpecInitProviderInstanceSchedulePolicyVmStopSchedule>? VmStopSchedule { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecInitProviderSnapshotSchedulePolicyRetentionPolicy
{
    /// <summary>Maximum age of the snapshot that is allowed to be kept.</summary>
    [JsonPropertyName("maxRetentionDays")]
    public double? MaxRetentionDays { get; set; }

    /// <summary>Specifies the behavior to apply to scheduled snapshots when the source disk is deleted. Default value is KEEP_AUTO_SNAPSHOTS. Possible values are: KEEP_AUTO_SNAPSHOTS, APPLY_RETENTION_POLICY.</summary>
    [JsonPropertyName("onSourceDiskDelete")]
    public string? OnSourceDiskDelete { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecInitProviderSnapshotSchedulePolicyScheduleDailySchedule
{
    /// <summary>Defines a schedule with units measured in days. The value determines how many days pass between the start of each cycle. Days in cycle for snapshot schedule policy must be 1.</summary>
    [JsonPropertyName("daysInCycle")]
    public double? DaysInCycle { get; set; }

    /// <summary>Time within the window to start the operations. It must be in format "HH:MM", where HH : [00-23] and MM : [00-00] GMT.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecInitProviderSnapshotSchedulePolicyScheduleHourlySchedule
{
    /// <summary>The number of hours between snapshots.</summary>
    [JsonPropertyName("hoursInCycle")]
    public double? HoursInCycle { get; set; }

    /// <summary>Time within the window to start the operations. It must be in format "HH:MM", where HH : [00-23] and MM : [00-00] GMT.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecInitProviderSnapshotSchedulePolicyScheduleWeeklyScheduleDayOfWeeks
{
    /// <summary>The day of the week to create the snapshot. e.g. MONDAY Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("day")]
    public string? Day { get; set; }

    /// <summary>Time within the window to start the operations. It must be in format "HH:MM", where HH : [00-23] and MM : [00-00] GMT.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecInitProviderSnapshotSchedulePolicyScheduleWeeklySchedule
{
    /// <summary>May contain up to seven (one for each day of the week) snapshot times. Structure is documented below.</summary>
    [JsonPropertyName("dayOfWeeks")]
    public IList<V1beta1ResourcePolicySpecInitProviderSnapshotSchedulePolicyScheduleWeeklyScheduleDayOfWeeks>? DayOfWeeks { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecInitProviderSnapshotSchedulePolicySchedule
{
    /// <summary>The policy will execute every nth day at the specified time. Structure is documented below.</summary>
    [JsonPropertyName("dailySchedule")]
    public IList<V1beta1ResourcePolicySpecInitProviderSnapshotSchedulePolicyScheduleDailySchedule>? DailySchedule { get; set; }

    /// <summary>The policy will execute every nth hour starting at the specified time. Structure is documented below.</summary>
    [JsonPropertyName("hourlySchedule")]
    public IList<V1beta1ResourcePolicySpecInitProviderSnapshotSchedulePolicyScheduleHourlySchedule>? HourlySchedule { get; set; }

    /// <summary>Allows specifying a snapshot time for each day of the week. Structure is documented below.</summary>
    [JsonPropertyName("weeklySchedule")]
    public IList<V1beta1ResourcePolicySpecInitProviderSnapshotSchedulePolicyScheduleWeeklySchedule>? WeeklySchedule { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecInitProviderSnapshotSchedulePolicySnapshotProperties
{
    /// <summary>Creates the new snapshot in the snapshot chain labeled with the specified name. The chain name must be 1-63 characters long and comply with RFC1035.</summary>
    [JsonPropertyName("chainName")]
    public string? ChainName { get; set; }

    /// <summary>Whether to perform a 'guest aware' snapshot.</summary>
    [JsonPropertyName("guestFlush")]
    public bool? GuestFlush { get; set; }

    /// <summary>A set of key-value pairs.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Cloud Storage bucket location to store the auto snapshot (regional or multi-regional)</summary>
    [JsonPropertyName("storageLocations")]
    public IList<string>? StorageLocations { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecInitProviderSnapshotSchedulePolicy
{
    /// <summary>Retention policy applied to snapshots created by this resource policy. Structure is documented below.</summary>
    [JsonPropertyName("retentionPolicy")]
    public IList<V1beta1ResourcePolicySpecInitProviderSnapshotSchedulePolicyRetentionPolicy>? RetentionPolicy { get; set; }

    /// <summary>Contains one of an hourlySchedule, dailySchedule, or weeklySchedule. Structure is documented below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1ResourcePolicySpecInitProviderSnapshotSchedulePolicySchedule>? Schedule { get; set; }

    /// <summary>Properties with which the snapshots are created, such as labels. Structure is documented below.</summary>
    [JsonPropertyName("snapshotProperties")]
    public IList<V1beta1ResourcePolicySpecInitProviderSnapshotSchedulePolicySnapshotProperties>? SnapshotProperties { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecInitProviderWorkloadPolicy
{
    /// <summary>The accelerator topology. This field can be set only when the workload policy type is HIGH_THROUGHPUT and cannot be set if max topology distance is set.</summary>
    [JsonPropertyName("acceleratorTopology")]
    public string? AcceleratorTopology { get; set; }

    /// <summary>The maximum topology distance. This field can be set only when the workload policy type is HIGH_THROUGHPUT and cannot be set if accelerator topology is set. Possible values are: BLOCK, CLUSTER, SUBBLOCK.</summary>
    [JsonPropertyName("maxTopologyDistance")]
    public string? MaxTopologyDistance { get; set; }

    /// <summary>The type of workload policy. Possible values are: HIGH_AVAILABILITY, HIGH_THROUGHPUT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecInitProvider
{
    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Replication consistency group for asynchronous disk replication. Structure is documented below.</summary>
    [JsonPropertyName("diskConsistencyGroupPolicy")]
    public IList<V1beta1ResourcePolicySpecInitProviderDiskConsistencyGroupPolicy>? DiskConsistencyGroupPolicy { get; set; }

    /// <summary>Resource policy for instances used for placement configuration. Structure is documented below.</summary>
    [JsonPropertyName("groupPlacementPolicy")]
    public IList<V1beta1ResourcePolicySpecInitProviderGroupPlacementPolicy>? GroupPlacementPolicy { get; set; }

    /// <summary>Resource policy for scheduling instance operations. Structure is documented below.</summary>
    [JsonPropertyName("instanceSchedulePolicy")]
    public IList<V1beta1ResourcePolicySpecInitProviderInstanceSchedulePolicy>? InstanceSchedulePolicy { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Policy for creating snapshots of persistent disks. Structure is documented below.</summary>
    [JsonPropertyName("snapshotSchedulePolicy")]
    public IList<V1beta1ResourcePolicySpecInitProviderSnapshotSchedulePolicy>? SnapshotSchedulePolicy { get; set; }

    /// <summary>Represents the workload policy. Structure is documented below.</summary>
    [JsonPropertyName("workloadPolicy")]
    public IList<V1beta1ResourcePolicySpecInitProviderWorkloadPolicy>? WorkloadPolicy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ResourcePolicySpecProviderConfigRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ResourcePolicySpec defines the desired state of ResourcePolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ResourcePolicySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ResourcePolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ResourcePolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ResourcePolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyStatusAtProviderDiskConsistencyGroupPolicy
{
    /// <summary>Enable disk consistency on the resource policy.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyStatusAtProviderGroupPlacementPolicy
{
    /// <summary>The number of availability domains instances will be spread across. If two instances are in different availability domain, they will not be put in the same low latency network</summary>
    [JsonPropertyName("availabilityDomainCount")]
    public double? AvailabilityDomainCount { get; set; }

    /// <summary>Collocation specifies whether to place VMs inside the same availability domain on the same low-latency network. Specify COLLOCATED to enable collocation. Can only be specified with vm_count. If compute instances are created with a COLLOCATED policy, then exactly vm_count instances must be created at the same time with the resource policy attached. Possible values are: COLLOCATED.</summary>
    [JsonPropertyName("collocation")]
    public string? Collocation { get; set; }

    /// <summary>Specifies the shape of the GPU slice, in slice based GPU families eg. A4X.</summary>
    [JsonPropertyName("gpuTopology")]
    public string? GpuTopology { get; set; }

    /// <summary>Number of VMs in this placement group. Google does not recommend that you use this field unless you use a compact policy and you want your policy to work only if it contains this exact number of VMs.</summary>
    [JsonPropertyName("vmCount")]
    public double? VmCount { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyStatusAtProviderInstanceSchedulePolicyVmStartSchedule
{
    /// <summary>Specifies the frequency for the operation, using the unix-cron format.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyStatusAtProviderInstanceSchedulePolicyVmStopSchedule
{
    /// <summary>Specifies the frequency for the operation, using the unix-cron format.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyStatusAtProviderInstanceSchedulePolicy
{
    /// <summary>The expiration time of the schedule. The timestamp is an RFC3339 string.</summary>
    [JsonPropertyName("expirationTime")]
    public string? ExpirationTime { get; set; }

    /// <summary>The start time of the schedule. The timestamp is an RFC3339 string.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Specifies the time zone to be used in interpreting the schedule. The value of this field must be a time zone name from the tz database: http://en.wikipedia.org/wiki/Tz_database.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>Specifies the schedule for starting instances. Structure is documented below.</summary>
    [JsonPropertyName("vmStartSchedule")]
    public IList<V1beta1ResourcePolicyStatusAtProviderInstanceSchedulePolicyVmStartSchedule>? VmStartSchedule { get; set; }

    /// <summary>Specifies the schedule for stopping instances. Structure is documented below.</summary>
    [JsonPropertyName("vmStopSchedule")]
    public IList<V1beta1ResourcePolicyStatusAtProviderInstanceSchedulePolicyVmStopSchedule>? VmStopSchedule { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyStatusAtProviderSnapshotSchedulePolicyRetentionPolicy
{
    /// <summary>Maximum age of the snapshot that is allowed to be kept.</summary>
    [JsonPropertyName("maxRetentionDays")]
    public double? MaxRetentionDays { get; set; }

    /// <summary>Specifies the behavior to apply to scheduled snapshots when the source disk is deleted. Default value is KEEP_AUTO_SNAPSHOTS. Possible values are: KEEP_AUTO_SNAPSHOTS, APPLY_RETENTION_POLICY.</summary>
    [JsonPropertyName("onSourceDiskDelete")]
    public string? OnSourceDiskDelete { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyStatusAtProviderSnapshotSchedulePolicyScheduleDailySchedule
{
    /// <summary>Defines a schedule with units measured in days. The value determines how many days pass between the start of each cycle. Days in cycle for snapshot schedule policy must be 1.</summary>
    [JsonPropertyName("daysInCycle")]
    public double? DaysInCycle { get; set; }

    /// <summary>Time within the window to start the operations. It must be in format "HH:MM", where HH : [00-23] and MM : [00-00] GMT.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyStatusAtProviderSnapshotSchedulePolicyScheduleHourlySchedule
{
    /// <summary>The number of hours between snapshots.</summary>
    [JsonPropertyName("hoursInCycle")]
    public double? HoursInCycle { get; set; }

    /// <summary>Time within the window to start the operations. It must be in format "HH:MM", where HH : [00-23] and MM : [00-00] GMT.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyStatusAtProviderSnapshotSchedulePolicyScheduleWeeklyScheduleDayOfWeeks
{
    /// <summary>The day of the week to create the snapshot. e.g. MONDAY Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("day")]
    public string? Day { get; set; }

    /// <summary>Time within the window to start the operations. It must be in format "HH:MM", where HH : [00-23] and MM : [00-00] GMT.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyStatusAtProviderSnapshotSchedulePolicyScheduleWeeklySchedule
{
    /// <summary>May contain up to seven (one for each day of the week) snapshot times. Structure is documented below.</summary>
    [JsonPropertyName("dayOfWeeks")]
    public IList<V1beta1ResourcePolicyStatusAtProviderSnapshotSchedulePolicyScheduleWeeklyScheduleDayOfWeeks>? DayOfWeeks { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyStatusAtProviderSnapshotSchedulePolicySchedule
{
    /// <summary>The policy will execute every nth day at the specified time. Structure is documented below.</summary>
    [JsonPropertyName("dailySchedule")]
    public IList<V1beta1ResourcePolicyStatusAtProviderSnapshotSchedulePolicyScheduleDailySchedule>? DailySchedule { get; set; }

    /// <summary>The policy will execute every nth hour starting at the specified time. Structure is documented below.</summary>
    [JsonPropertyName("hourlySchedule")]
    public IList<V1beta1ResourcePolicyStatusAtProviderSnapshotSchedulePolicyScheduleHourlySchedule>? HourlySchedule { get; set; }

    /// <summary>Allows specifying a snapshot time for each day of the week. Structure is documented below.</summary>
    [JsonPropertyName("weeklySchedule")]
    public IList<V1beta1ResourcePolicyStatusAtProviderSnapshotSchedulePolicyScheduleWeeklySchedule>? WeeklySchedule { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyStatusAtProviderSnapshotSchedulePolicySnapshotProperties
{
    /// <summary>Creates the new snapshot in the snapshot chain labeled with the specified name. The chain name must be 1-63 characters long and comply with RFC1035.</summary>
    [JsonPropertyName("chainName")]
    public string? ChainName { get; set; }

    /// <summary>Whether to perform a 'guest aware' snapshot.</summary>
    [JsonPropertyName("guestFlush")]
    public bool? GuestFlush { get; set; }

    /// <summary>A set of key-value pairs.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Cloud Storage bucket location to store the auto snapshot (regional or multi-regional)</summary>
    [JsonPropertyName("storageLocations")]
    public IList<string>? StorageLocations { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyStatusAtProviderSnapshotSchedulePolicy
{
    /// <summary>Retention policy applied to snapshots created by this resource policy. Structure is documented below.</summary>
    [JsonPropertyName("retentionPolicy")]
    public IList<V1beta1ResourcePolicyStatusAtProviderSnapshotSchedulePolicyRetentionPolicy>? RetentionPolicy { get; set; }

    /// <summary>Contains one of an hourlySchedule, dailySchedule, or weeklySchedule. Structure is documented below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1ResourcePolicyStatusAtProviderSnapshotSchedulePolicySchedule>? Schedule { get; set; }

    /// <summary>Properties with which the snapshots are created, such as labels. Structure is documented below.</summary>
    [JsonPropertyName("snapshotProperties")]
    public IList<V1beta1ResourcePolicyStatusAtProviderSnapshotSchedulePolicySnapshotProperties>? SnapshotProperties { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyStatusAtProviderWorkloadPolicy
{
    /// <summary>The accelerator topology. This field can be set only when the workload policy type is HIGH_THROUGHPUT and cannot be set if max topology distance is set.</summary>
    [JsonPropertyName("acceleratorTopology")]
    public string? AcceleratorTopology { get; set; }

    /// <summary>The maximum topology distance. This field can be set only when the workload policy type is HIGH_THROUGHPUT and cannot be set if accelerator topology is set. Possible values are: BLOCK, CLUSTER, SUBBLOCK.</summary>
    [JsonPropertyName("maxTopologyDistance")]
    public string? MaxTopologyDistance { get; set; }

    /// <summary>The type of workload policy. Possible values are: HIGH_AVAILABILITY, HIGH_THROUGHPUT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyStatusAtProvider
{
    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Replication consistency group for asynchronous disk replication. Structure is documented below.</summary>
    [JsonPropertyName("diskConsistencyGroupPolicy")]
    public IList<V1beta1ResourcePolicyStatusAtProviderDiskConsistencyGroupPolicy>? DiskConsistencyGroupPolicy { get; set; }

    /// <summary>Resource policy for instances used for placement configuration. Structure is documented below.</summary>
    [JsonPropertyName("groupPlacementPolicy")]
    public IList<V1beta1ResourcePolicyStatusAtProviderGroupPlacementPolicy>? GroupPlacementPolicy { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/regions/{{region}}/resourcePolicies/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Resource policy for scheduling instance operations. Structure is documented below.</summary>
    [JsonPropertyName("instanceSchedulePolicy")]
    public IList<V1beta1ResourcePolicyStatusAtProviderInstanceSchedulePolicy>? InstanceSchedulePolicy { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Region where resource policy resides.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>Policy for creating snapshots of persistent disks. Structure is documented below.</summary>
    [JsonPropertyName("snapshotSchedulePolicy")]
    public IList<V1beta1ResourcePolicyStatusAtProviderSnapshotSchedulePolicy>? SnapshotSchedulePolicy { get; set; }

    /// <summary>Represents the workload policy. Structure is documented below.</summary>
    [JsonPropertyName("workloadPolicy")]
    public IList<V1beta1ResourcePolicyStatusAtProviderWorkloadPolicy>? WorkloadPolicy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyStatusConditions
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
#nullable disable

#nullable enable
/// <summary>ResourcePolicyStatus defines the observed state of ResourcePolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ResourcePolicyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ResourcePolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ResourcePolicyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ResourcePolicy is the Schema for the ResourcePolicys API. A policy that can be attached to a resource to specify or schedule actions on that resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ResourcePolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ResourcePolicySpec>, IStatus<V1beta1ResourcePolicyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ResourcePolicy";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "resourcepolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ResourcePolicySpec defines the desired state of ResourcePolicy</summary>
    [JsonPropertyName("spec")]
    public V1beta1ResourcePolicySpec Spec { get; set; }

    /// <summary>ResourcePolicyStatus defines the observed state of ResourcePolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta1ResourcePolicyStatus? Status { get; set; }
}
#nullable disable
