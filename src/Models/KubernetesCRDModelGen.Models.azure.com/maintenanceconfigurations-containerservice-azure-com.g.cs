using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containerservice.azure.com;
/// <summary>Storage version of v1api20240901.DateSpan For example, between '2022-12-23' and '2023-01-05'.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageMaintenanceConfigurationSpecMaintenanceWindowNotAllowedDates
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary></summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary>Storage version of v1api20240901.AbsoluteMonthlySchedule For schedules like: 'recur every month on the 15th' or 'recur every 3 months on the 20th'.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageMaintenanceConfigurationSpecMaintenanceWindowScheduleAbsoluteMonthly
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dayOfMonth")]
    public int? DayOfMonth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("intervalMonths")]
    public int? IntervalMonths { get; set; }
}

/// <summary>Storage version of v1api20240901.DailySchedule For schedules like: 'recur every day' or 'recur every 3 days'.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageMaintenanceConfigurationSpecMaintenanceWindowScheduleDaily
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("intervalDays")]
    public int? IntervalDays { get; set; }
}

/// <summary>Storage version of v1api20240901.RelativeMonthlySchedule For schedules like: 'recur every month on the first Monday' or 'recur every 3 months on last Friday'.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageMaintenanceConfigurationSpecMaintenanceWindowScheduleRelativeMonthly
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary></summary>
    [JsonPropertyName("intervalMonths")]
    public int? IntervalMonths { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weekIndex")]
    public string? WeekIndex { get; set; }
}

/// <summary>Storage version of v1api20240901.WeeklySchedule For schedules like: 'recur every Monday' or 'recur every 3 weeks on Wednesday'.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageMaintenanceConfigurationSpecMaintenanceWindowScheduleWeekly
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary></summary>
    [JsonPropertyName("intervalWeeks")]
    public int? IntervalWeeks { get; set; }
}

/// <summary>Storage version of v1api20240901.Schedule One and only one of the schedule types should be specified. Choose either 'daily', 'weekly', 'absoluteMonthly' or 'relativeMonthly' for your maintenance schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageMaintenanceConfigurationSpecMaintenanceWindowSchedule
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240901.AbsoluteMonthlySchedule For schedules like: 'recur every month on the 15th' or 'recur every 3 months on the 20th'.</summary>
    [JsonPropertyName("absoluteMonthly")]
    public V1api20240901storageMaintenanceConfigurationSpecMaintenanceWindowScheduleAbsoluteMonthly? AbsoluteMonthly { get; set; }

    /// <summary>Storage version of v1api20240901.DailySchedule For schedules like: 'recur every day' or 'recur every 3 days'.</summary>
    [JsonPropertyName("daily")]
    public V1api20240901storageMaintenanceConfigurationSpecMaintenanceWindowScheduleDaily? Daily { get; set; }

    /// <summary>Storage version of v1api20240901.RelativeMonthlySchedule For schedules like: 'recur every month on the first Monday' or 'recur every 3 months on last Friday'.</summary>
    [JsonPropertyName("relativeMonthly")]
    public V1api20240901storageMaintenanceConfigurationSpecMaintenanceWindowScheduleRelativeMonthly? RelativeMonthly { get; set; }

    /// <summary>Storage version of v1api20240901.WeeklySchedule For schedules like: 'recur every Monday' or 'recur every 3 weeks on Wednesday'.</summary>
    [JsonPropertyName("weekly")]
    public V1api20240901storageMaintenanceConfigurationSpecMaintenanceWindowScheduleWeekly? Weekly { get; set; }
}

/// <summary>Storage version of v1api20240901.MaintenanceWindow Maintenance window used to configure scheduled auto-upgrade for a Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageMaintenanceConfigurationSpecMaintenanceWindow
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("durationHours")]
    public int? DurationHours { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notAllowedDates")]
    public IList<V1api20240901storageMaintenanceConfigurationSpecMaintenanceWindowNotAllowedDates>? NotAllowedDates { get; set; }

    /// <summary>Storage version of v1api20240901.Schedule One and only one of the schedule types should be specified. Choose either 'daily', 'weekly', 'absoluteMonthly' or 'relativeMonthly' for your maintenance schedule.</summary>
    [JsonPropertyName("schedule")]
    public V1api20240901storageMaintenanceConfigurationSpecMaintenanceWindowSchedule? Schedule { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("utcOffset")]
    public string? UtcOffset { get; set; }
}

/// <summary>Storage version of v1api20240901.TimeSpan For example, between 2021-05-25T13:00:00Z and 2021-05-25T14:00:00Z.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageMaintenanceConfigurationSpecNotAllowedTime
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary></summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageMaintenanceConfigurationSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting map[string]string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap or secret to write to. The configmap or secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageMaintenanceConfigurationSpecOperatorSpecSecretExpressions
{
    /// <summary>Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting map[string]string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap or secret to write to. The configmap or secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>Storage version of v1api20240901.MaintenanceConfigurationOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageMaintenanceConfigurationSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240901storageMaintenanceConfigurationSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240901storageMaintenanceConfigurationSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a containerservice.azure.com/ManagedCluster resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageMaintenanceConfigurationSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240901.TimeInWeek Time in a week.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageMaintenanceConfigurationSpecTimeInWeek
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("day")]
    public string? Day { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hourSlots")]
    public IList<int>? HourSlots { get; set; }
}

/// <summary>Storage version of v1api20240901.MaintenanceConfiguration_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageMaintenanceConfigurationSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Storage version of v1api20240901.MaintenanceWindow Maintenance window used to configure scheduled auto-upgrade for a Managed Cluster.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1api20240901storageMaintenanceConfigurationSpecMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notAllowedTime")]
    public IList<V1api20240901storageMaintenanceConfigurationSpecNotAllowedTime>? NotAllowedTime { get; set; }

    /// <summary>Storage version of v1api20240901.MaintenanceConfigurationOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240901storageMaintenanceConfigurationSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a containerservice.azure.com/ManagedCluster resource</summary>
    [JsonPropertyName("owner")]
    public V1api20240901storageMaintenanceConfigurationSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeInWeek")]
    public IList<V1api20240901storageMaintenanceConfigurationSpecTimeInWeek>? TimeInWeek { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageMaintenanceConfigurationStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Reason for the condition's last transition. Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Severity with which to treat failures of this type of condition. For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False. This is omitted in all cases when Status == Unknown</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Storage version of v1api20240901.DateSpan_STATUS For example, between '2022-12-23' and '2023-01-05'.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageMaintenanceConfigurationStatusMaintenanceWindowNotAllowedDates
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary></summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary>Storage version of v1api20240901.AbsoluteMonthlySchedule_STATUS For schedules like: 'recur every month on the 15th' or 'recur every 3 months on the 20th'.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageMaintenanceConfigurationStatusMaintenanceWindowScheduleAbsoluteMonthly
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dayOfMonth")]
    public int? DayOfMonth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("intervalMonths")]
    public int? IntervalMonths { get; set; }
}

/// <summary>Storage version of v1api20240901.DailySchedule_STATUS For schedules like: 'recur every day' or 'recur every 3 days'.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageMaintenanceConfigurationStatusMaintenanceWindowScheduleDaily
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("intervalDays")]
    public int? IntervalDays { get; set; }
}

/// <summary>Storage version of v1api20240901.RelativeMonthlySchedule_STATUS For schedules like: 'recur every month on the first Monday' or 'recur every 3 months on last Friday'.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageMaintenanceConfigurationStatusMaintenanceWindowScheduleRelativeMonthly
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary></summary>
    [JsonPropertyName("intervalMonths")]
    public int? IntervalMonths { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weekIndex")]
    public string? WeekIndex { get; set; }
}

/// <summary>Storage version of v1api20240901.WeeklySchedule_STATUS For schedules like: 'recur every Monday' or 'recur every 3 weeks on Wednesday'.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageMaintenanceConfigurationStatusMaintenanceWindowScheduleWeekly
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary></summary>
    [JsonPropertyName("intervalWeeks")]
    public int? IntervalWeeks { get; set; }
}

/// <summary>Storage version of v1api20240901.Schedule_STATUS One and only one of the schedule types should be specified. Choose either 'daily', 'weekly', 'absoluteMonthly' or 'relativeMonthly' for your maintenance schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageMaintenanceConfigurationStatusMaintenanceWindowSchedule
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240901.AbsoluteMonthlySchedule_STATUS For schedules like: 'recur every month on the 15th' or 'recur every 3 months on the 20th'.</summary>
    [JsonPropertyName("absoluteMonthly")]
    public V1api20240901storageMaintenanceConfigurationStatusMaintenanceWindowScheduleAbsoluteMonthly? AbsoluteMonthly { get; set; }

    /// <summary>Storage version of v1api20240901.DailySchedule_STATUS For schedules like: 'recur every day' or 'recur every 3 days'.</summary>
    [JsonPropertyName("daily")]
    public V1api20240901storageMaintenanceConfigurationStatusMaintenanceWindowScheduleDaily? Daily { get; set; }

    /// <summary>Storage version of v1api20240901.RelativeMonthlySchedule_STATUS For schedules like: 'recur every month on the first Monday' or 'recur every 3 months on last Friday'.</summary>
    [JsonPropertyName("relativeMonthly")]
    public V1api20240901storageMaintenanceConfigurationStatusMaintenanceWindowScheduleRelativeMonthly? RelativeMonthly { get; set; }

    /// <summary>Storage version of v1api20240901.WeeklySchedule_STATUS For schedules like: 'recur every Monday' or 'recur every 3 weeks on Wednesday'.</summary>
    [JsonPropertyName("weekly")]
    public V1api20240901storageMaintenanceConfigurationStatusMaintenanceWindowScheduleWeekly? Weekly { get; set; }
}

/// <summary>Storage version of v1api20240901.MaintenanceWindow_STATUS Maintenance window used to configure scheduled auto-upgrade for a Managed Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageMaintenanceConfigurationStatusMaintenanceWindow
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("durationHours")]
    public int? DurationHours { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notAllowedDates")]
    public IList<V1api20240901storageMaintenanceConfigurationStatusMaintenanceWindowNotAllowedDates>? NotAllowedDates { get; set; }

    /// <summary>Storage version of v1api20240901.Schedule_STATUS One and only one of the schedule types should be specified. Choose either 'daily', 'weekly', 'absoluteMonthly' or 'relativeMonthly' for your maintenance schedule.</summary>
    [JsonPropertyName("schedule")]
    public V1api20240901storageMaintenanceConfigurationStatusMaintenanceWindowSchedule? Schedule { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("utcOffset")]
    public string? UtcOffset { get; set; }
}

/// <summary>Storage version of v1api20240901.TimeSpan_STATUS For example, between 2021-05-25T13:00:00Z and 2021-05-25T14:00:00Z.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageMaintenanceConfigurationStatusNotAllowedTime
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary></summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary>Storage version of v1api20240901.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageMaintenanceConfigurationStatusSystemData
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>Storage version of v1api20240901.TimeInWeek_STATUS Time in a week.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageMaintenanceConfigurationStatusTimeInWeek
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("day")]
    public string? Day { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hourSlots")]
    public IList<int>? HourSlots { get; set; }
}

/// <summary>Storage version of v1api20240901.MaintenanceConfiguration_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240901storageMaintenanceConfigurationStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240901storageMaintenanceConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20240901.MaintenanceWindow_STATUS Maintenance window used to configure scheduled auto-upgrade for a Managed Cluster.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1api20240901storageMaintenanceConfigurationStatusMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notAllowedTime")]
    public IList<V1api20240901storageMaintenanceConfigurationStatusNotAllowedTime>? NotAllowedTime { get; set; }

    /// <summary>Storage version of v1api20240901.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20240901storageMaintenanceConfigurationStatusSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeInWeek")]
    public IList<V1api20240901storageMaintenanceConfigurationStatusTimeInWeek>? TimeInWeek { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20240901.MaintenanceConfiguration Generator information: - Generated from: /containerservice/resource-manager/Microsoft.ContainerService/aks/stable/2024-09-01/managedClusters.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/maintenanceConfigurations/{configName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240901storageMaintenanceConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240901storageMaintenanceConfigurationSpec>, IStatus<V1api20240901storageMaintenanceConfigurationStatus>
{
    public const string KubeApiVersion = "v1api20240901storage";
    public const string KubeKind = "MaintenanceConfiguration";
    public const string KubeGroup = "containerservice.azure.com";
    public const string KubePluralName = "maintenanceconfigurations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20240901.MaintenanceConfiguration_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20240901storageMaintenanceConfigurationSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20240901.MaintenanceConfiguration_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20240901storageMaintenanceConfigurationStatus? Status { get; set; }
}