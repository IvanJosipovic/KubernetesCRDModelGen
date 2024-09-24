using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.logic.azure.upbound.io;
public enum V1beta1AppIntegrationAccountBatchConfigurationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderIntegrationAccountNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderIntegrationAccountNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderIntegrationAccountNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderIntegrationAccountNameRefPolicyResolutionEnum>))]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderIntegrationAccountNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderIntegrationAccountNameRefPolicyResolveEnum>))]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderIntegrationAccountNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AppIntegrationAccount in logic to populate integrationAccountName.</summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderIntegrationAccountNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderIntegrationAccountNameRefPolicy? Policy { get; set; }
}

public enum V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderIntegrationAccountNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderIntegrationAccountNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderIntegrationAccountNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderIntegrationAccountNameSelectorPolicyResolutionEnum>))]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderIntegrationAccountNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderIntegrationAccountNameSelectorPolicyResolveEnum>))]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderIntegrationAccountNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AppIntegrationAccount in logic to populate integrationAccountName.</summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderIntegrationAccountNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderIntegrationAccountNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderReleaseCriteriaRecurrenceScheduleMonthly
{
    /// <summary>The occurrence of the week within the month.</summary>
    [JsonPropertyName("week")]
    public double? Week { get; set; }

    /// <summary>The day of the occurrence. Possible values are Sunday, Monday, Tuesday, Wednesday, Thursday, Friday and Saturday.</summary>
    [JsonPropertyName("weekday")]
    public string? Weekday { get; set; }
}

/// <summary></summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderReleaseCriteriaRecurrenceSchedule
{
    /// <summary>A list containing a single item, which specifies the Hour interval at which this recurrence should be triggered.</summary>
    [JsonPropertyName("hours")]
    public IList<double>? Hours { get; set; }

    /// <summary>A list containing a single item which specifies the Minute interval at which this recurrence should be triggered.</summary>
    [JsonPropertyName("minutes")]
    public IList<double>? Minutes { get; set; }

    /// <summary>A list of days of the month that the job should execute on.</summary>
    [JsonPropertyName("monthDays")]
    public IList<double>? MonthDays { get; set; }

    /// <summary>A monthly block as documented below.</summary>
    [JsonPropertyName("monthly")]
    public IList<V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderReleaseCriteriaRecurrenceScheduleMonthly>? Monthly { get; set; }

    /// <summary>A list of days of the week that the job should execute on. Possible values are Sunday, Monday, Tuesday, Wednesday, Thursday, Friday and Saturday.</summary>
    [JsonPropertyName("weekDays")]
    public IList<string>? WeekDays { get; set; }
}

/// <summary></summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderReleaseCriteriaRecurrence
{
    /// <summary>The end time of the schedule, formatted as an RFC3339 string.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>The frequency of the schedule. Possible values are Day, Hour, Minute, Month, NotSpecified, Second, Week and Year.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>The number of frequencys between runs.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>A schedule block as documented below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderReleaseCriteriaRecurrenceSchedule>? Schedule { get; set; }

    /// <summary>The start time of the schedule, formatted as an RFC3339 string.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>The timezone of the start/end time.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary></summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderReleaseCriteria
{
    /// <summary>The batch size in bytes for the Logic App Integration Batch Configuration.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>The message count for the Logic App Integration Batch Configuration.</summary>
    [JsonPropertyName("messageCount")]
    public double? MessageCount { get; set; }

    /// <summary>A recurrence block as documented below.</summary>
    [JsonPropertyName("recurrence")]
    public IList<V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderReleaseCriteriaRecurrence>? Recurrence { get; set; }
}

public enum V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecForProvider
{
    /// <summary>The batch group name of the Logic App Integration Batch Configuration. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("batchGroupName")]
    public string? BatchGroupName { get; set; }

    /// <summary>The name of the Logic App Integration Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("integrationAccountName")]
    public string? IntegrationAccountName { get; set; }

    /// <summary>Reference to a AppIntegrationAccount in logic to populate integrationAccountName.</summary>
    [JsonPropertyName("integrationAccountNameRef")]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderIntegrationAccountNameRef? IntegrationAccountNameRef { get; set; }

    /// <summary>Selector for a AppIntegrationAccount in logic to populate integrationAccountName.</summary>
    [JsonPropertyName("integrationAccountNameSelector")]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderIntegrationAccountNameSelector? IntegrationAccountNameSelector { get; set; }

    /// <summary>A JSON mapping of any Metadata for this Logic App Integration Account Batch Configuration.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The name which should be used for this Logic App Integration Account Batch Configuration. Only Alphanumeric characters allowed. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A release_criteria block as documented below, which is used to select the criteria to meet before processing each batch.</summary>
    [JsonPropertyName("releaseCriteria")]
    public IList<V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderReleaseCriteria>? ReleaseCriteria { get; set; }

    /// <summary>The name of the Resource Group where the Logic App Integration Account Batch Configuration should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }
}

public enum V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderIntegrationAccountNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderIntegrationAccountNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderIntegrationAccountNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderIntegrationAccountNameRefPolicyResolutionEnum>))]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderIntegrationAccountNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderIntegrationAccountNameRefPolicyResolveEnum>))]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderIntegrationAccountNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AppIntegrationAccount in logic to populate integrationAccountName.</summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderIntegrationAccountNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderIntegrationAccountNameRefPolicy? Policy { get; set; }
}

public enum V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderIntegrationAccountNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderIntegrationAccountNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderIntegrationAccountNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderIntegrationAccountNameSelectorPolicyResolutionEnum>))]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderIntegrationAccountNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderIntegrationAccountNameSelectorPolicyResolveEnum>))]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderIntegrationAccountNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AppIntegrationAccount in logic to populate integrationAccountName.</summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderIntegrationAccountNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderIntegrationAccountNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderReleaseCriteriaRecurrenceScheduleMonthly
{
    /// <summary>The occurrence of the week within the month.</summary>
    [JsonPropertyName("week")]
    public double? Week { get; set; }

    /// <summary>The day of the occurrence. Possible values are Sunday, Monday, Tuesday, Wednesday, Thursday, Friday and Saturday.</summary>
    [JsonPropertyName("weekday")]
    public string? Weekday { get; set; }
}

/// <summary></summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderReleaseCriteriaRecurrenceSchedule
{
    /// <summary>A list containing a single item, which specifies the Hour interval at which this recurrence should be triggered.</summary>
    [JsonPropertyName("hours")]
    public IList<double>? Hours { get; set; }

    /// <summary>A list containing a single item which specifies the Minute interval at which this recurrence should be triggered.</summary>
    [JsonPropertyName("minutes")]
    public IList<double>? Minutes { get; set; }

    /// <summary>A list of days of the month that the job should execute on.</summary>
    [JsonPropertyName("monthDays")]
    public IList<double>? MonthDays { get; set; }

    /// <summary>A monthly block as documented below.</summary>
    [JsonPropertyName("monthly")]
    public IList<V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderReleaseCriteriaRecurrenceScheduleMonthly>? Monthly { get; set; }

    /// <summary>A list of days of the week that the job should execute on. Possible values are Sunday, Monday, Tuesday, Wednesday, Thursday, Friday and Saturday.</summary>
    [JsonPropertyName("weekDays")]
    public IList<string>? WeekDays { get; set; }
}

/// <summary></summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderReleaseCriteriaRecurrence
{
    /// <summary>The end time of the schedule, formatted as an RFC3339 string.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>The frequency of the schedule. Possible values are Day, Hour, Minute, Month, NotSpecified, Second, Week and Year.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>The number of frequencys between runs.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>A schedule block as documented below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderReleaseCriteriaRecurrenceSchedule>? Schedule { get; set; }

    /// <summary>The start time of the schedule, formatted as an RFC3339 string.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>The timezone of the start/end time.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary></summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderReleaseCriteria
{
    /// <summary>The batch size in bytes for the Logic App Integration Batch Configuration.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>The message count for the Logic App Integration Batch Configuration.</summary>
    [JsonPropertyName("messageCount")]
    public double? MessageCount { get; set; }

    /// <summary>A recurrence block as documented below.</summary>
    [JsonPropertyName("recurrence")]
    public IList<V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderReleaseCriteriaRecurrence>? Recurrence { get; set; }
}

public enum V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecInitProvider
{
    /// <summary>The batch group name of the Logic App Integration Batch Configuration. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("batchGroupName")]
    public string? BatchGroupName { get; set; }

    /// <summary>The name of the Logic App Integration Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("integrationAccountName")]
    public string? IntegrationAccountName { get; set; }

    /// <summary>Reference to a AppIntegrationAccount in logic to populate integrationAccountName.</summary>
    [JsonPropertyName("integrationAccountNameRef")]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderIntegrationAccountNameRef? IntegrationAccountNameRef { get; set; }

    /// <summary>Selector for a AppIntegrationAccount in logic to populate integrationAccountName.</summary>
    [JsonPropertyName("integrationAccountNameSelector")]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderIntegrationAccountNameSelector? IntegrationAccountNameSelector { get; set; }

    /// <summary>A JSON mapping of any Metadata for this Logic App Integration Account Batch Configuration.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The name which should be used for this Logic App Integration Account Batch Configuration. Only Alphanumeric characters allowed. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A release_criteria block as documented below, which is used to select the criteria to meet before processing each batch.</summary>
    [JsonPropertyName("releaseCriteria")]
    public IList<V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderReleaseCriteria>? ReleaseCriteria { get; set; }

    /// <summary>The name of the Resource Group where the Logic App Integration Account Batch Configuration should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecInitProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }
}

public enum V1beta1AppIntegrationAccountBatchConfigurationSpecManagementPoliciesEnum
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

public enum V1beta1AppIntegrationAccountBatchConfigurationSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AppIntegrationAccountBatchConfigurationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AppIntegrationAccountBatchConfigurationSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AppIntegrationAccountBatchConfigurationSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1AppIntegrationAccountBatchConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1AppIntegrationAccountBatchConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AppIntegrationAccountBatchConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AppIntegrationAccountBatchConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>AppIntegrationAccountBatchConfigurationSpec defines the desired state of AppIntegrationAccountBatchConfiguration</summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1AppIntegrationAccountBatchConfigurationSpecDeletionPolicyEnum>))]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1AppIntegrationAccountBatchConfigurationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AppIntegrationAccountBatchConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationStatusAtProviderReleaseCriteriaRecurrenceScheduleMonthly
{
    /// <summary>The occurrence of the week within the month.</summary>
    [JsonPropertyName("week")]
    public double? Week { get; set; }

    /// <summary>The day of the occurrence. Possible values are Sunday, Monday, Tuesday, Wednesday, Thursday, Friday and Saturday.</summary>
    [JsonPropertyName("weekday")]
    public string? Weekday { get; set; }
}

/// <summary></summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationStatusAtProviderReleaseCriteriaRecurrenceSchedule
{
    /// <summary>A list containing a single item, which specifies the Hour interval at which this recurrence should be triggered.</summary>
    [JsonPropertyName("hours")]
    public IList<double>? Hours { get; set; }

    /// <summary>A list containing a single item which specifies the Minute interval at which this recurrence should be triggered.</summary>
    [JsonPropertyName("minutes")]
    public IList<double>? Minutes { get; set; }

    /// <summary>A list of days of the month that the job should execute on.</summary>
    [JsonPropertyName("monthDays")]
    public IList<double>? MonthDays { get; set; }

    /// <summary>A monthly block as documented below.</summary>
    [JsonPropertyName("monthly")]
    public IList<V1beta1AppIntegrationAccountBatchConfigurationStatusAtProviderReleaseCriteriaRecurrenceScheduleMonthly>? Monthly { get; set; }

    /// <summary>A list of days of the week that the job should execute on. Possible values are Sunday, Monday, Tuesday, Wednesday, Thursday, Friday and Saturday.</summary>
    [JsonPropertyName("weekDays")]
    public IList<string>? WeekDays { get; set; }
}

/// <summary></summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationStatusAtProviderReleaseCriteriaRecurrence
{
    /// <summary>The end time of the schedule, formatted as an RFC3339 string.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>The frequency of the schedule. Possible values are Day, Hour, Minute, Month, NotSpecified, Second, Week and Year.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>The number of frequencys between runs.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>A schedule block as documented below.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1AppIntegrationAccountBatchConfigurationStatusAtProviderReleaseCriteriaRecurrenceSchedule>? Schedule { get; set; }

    /// <summary>The start time of the schedule, formatted as an RFC3339 string.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>The timezone of the start/end time.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary></summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationStatusAtProviderReleaseCriteria
{
    /// <summary>The batch size in bytes for the Logic App Integration Batch Configuration.</summary>
    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    /// <summary>The message count for the Logic App Integration Batch Configuration.</summary>
    [JsonPropertyName("messageCount")]
    public double? MessageCount { get; set; }

    /// <summary>A recurrence block as documented below.</summary>
    [JsonPropertyName("recurrence")]
    public IList<V1beta1AppIntegrationAccountBatchConfigurationStatusAtProviderReleaseCriteriaRecurrence>? Recurrence { get; set; }
}

/// <summary></summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationStatusAtProvider
{
    /// <summary>The batch group name of the Logic App Integration Batch Configuration. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("batchGroupName")]
    public string? BatchGroupName { get; set; }

    /// <summary>The ID of the Logic App Integration Account Batch Configuration.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the Logic App Integration Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("integrationAccountName")]
    public string? IntegrationAccountName { get; set; }

    /// <summary>A JSON mapping of any Metadata for this Logic App Integration Account Batch Configuration.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The name which should be used for this Logic App Integration Account Batch Configuration. Only Alphanumeric characters allowed. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A release_criteria block as documented below, which is used to select the criteria to meet before processing each batch.</summary>
    [JsonPropertyName("releaseCriteria")]
    public IList<V1beta1AppIntegrationAccountBatchConfigurationStatusAtProviderReleaseCriteria>? ReleaseCriteria { get; set; }

    /// <summary>The name of the Resource Group where the Logic App Integration Account Batch Configuration should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationStatusConditions
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

/// <summary>AppIntegrationAccountBatchConfigurationStatus defines the observed state of AppIntegrationAccountBatchConfiguration.</summary>
public partial class V1beta1AppIntegrationAccountBatchConfigurationStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1AppIntegrationAccountBatchConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AppIntegrationAccountBatchConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>AppIntegrationAccountBatchConfiguration is the Schema for the AppIntegrationAccountBatchConfigurations API. Manages a Logic App Integration Account Batch Configuration.</summary>
public partial class V1beta1AppIntegrationAccountBatchConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AppIntegrationAccountBatchConfigurationSpec>, IStatus<V1beta1AppIntegrationAccountBatchConfigurationStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AppIntegrationAccountBatchConfiguration";
    public const string KubeGroup = "logic.azure.upbound.io";
    public const string KubePluralName = "appintegrationaccountbatchconfigurations";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AppIntegrationAccountBatchConfigurationSpec defines the desired state of AppIntegrationAccountBatchConfiguration</summary>
    [JsonPropertyName("spec")]
    public V1beta1AppIntegrationAccountBatchConfigurationSpec Spec { get; set; }

    /// <summary>AppIntegrationAccountBatchConfigurationStatus defines the observed state of AppIntegrationAccountBatchConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta1AppIntegrationAccountBatchConfigurationStatus? Status { get; set; }
}