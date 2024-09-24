using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.consumption.azure.upbound.io;
public enum V1beta1BudgetManagementGroupSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1BudgetManagementGroupSpecForProviderFilterDimension
{
    /// <summary>The name of the tag to use for the filter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The operator to use for comparison. The allowed values are In. Defaults to In.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Specifies a list of values for the tag.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
public partial class V1beta1BudgetManagementGroupSpecForProviderFilterNotDimension
{
    /// <summary>The name of the tag to use for the filter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The operator to use for comparison. The allowed values are In. Defaults to In.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Specifies a list of values for the tag.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
public partial class V1beta1BudgetManagementGroupSpecForProviderFilterNotTag
{
    /// <summary>The name of the tag to use for the filter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The operator to use for comparison. The allowed values are In. Defaults to In.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Specifies a list of values for the tag.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
public partial class V1beta1BudgetManagementGroupSpecForProviderFilterNot
{
    /// <summary>One dimension block as defined below to filter the budget on. Conflicts with tag.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1BudgetManagementGroupSpecForProviderFilterNotDimension>? Dimension { get; set; }

    /// <summary>One tag block as defined below to filter the budget on. Conflicts with dimension.</summary>
    [JsonPropertyName("tag")]
    public IList<V1beta1BudgetManagementGroupSpecForProviderFilterNotTag>? Tag { get; set; }
}

/// <summary></summary>
public partial class V1beta1BudgetManagementGroupSpecForProviderFilterTag
{
    /// <summary>The name of the tag to use for the filter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The operator to use for comparison. The allowed values are In. Defaults to In.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Specifies a list of values for the tag.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
public partial class V1beta1BudgetManagementGroupSpecForProviderFilter
{
    /// <summary>One or more dimension blocks as defined below to filter the budget on.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1BudgetManagementGroupSpecForProviderFilterDimension>? Dimension { get; set; }

    /// <summary>A not block as defined below to filter the budget on. This is deprecated as the API no longer supports it and will be removed in version 4.0 of the provider.</summary>
    [JsonPropertyName("not")]
    public IList<V1beta1BudgetManagementGroupSpecForProviderFilterNot>? Not { get; set; }

    /// <summary>One or more tag blocks as defined below to filter the budget on.</summary>
    [JsonPropertyName("tag")]
    public IList<V1beta1BudgetManagementGroupSpecForProviderFilterTag>? Tag { get; set; }
}

public enum V1beta1BudgetManagementGroupSpecForProviderManagementGroupIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BudgetManagementGroupSpecForProviderManagementGroupIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BudgetManagementGroupSpecForProviderManagementGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BudgetManagementGroupSpecForProviderManagementGroupIdRefPolicyResolutionEnum>))]
    public V1beta1BudgetManagementGroupSpecForProviderManagementGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BudgetManagementGroupSpecForProviderManagementGroupIdRefPolicyResolveEnum>))]
    public V1beta1BudgetManagementGroupSpecForProviderManagementGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ManagementGroup in management to populate managementGroupId.</summary>
public partial class V1beta1BudgetManagementGroupSpecForProviderManagementGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BudgetManagementGroupSpecForProviderManagementGroupIdRefPolicy? Policy { get; set; }
}

public enum V1beta1BudgetManagementGroupSpecForProviderManagementGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BudgetManagementGroupSpecForProviderManagementGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1BudgetManagementGroupSpecForProviderManagementGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BudgetManagementGroupSpecForProviderManagementGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1BudgetManagementGroupSpecForProviderManagementGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BudgetManagementGroupSpecForProviderManagementGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1BudgetManagementGroupSpecForProviderManagementGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ManagementGroup in management to populate managementGroupId.</summary>
public partial class V1beta1BudgetManagementGroupSpecForProviderManagementGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BudgetManagementGroupSpecForProviderManagementGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1BudgetManagementGroupSpecForProviderNotification
{
    /// <summary>Specifies a list of email addresses to send the budget notification to when the threshold is exceeded.</summary>
    [JsonPropertyName("contactEmails")]
    public IList<string>? ContactEmails { get; set; }

    /// <summary>Should the notification be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The comparison operator for the notification. Must be one of EqualTo, GreaterThan, or GreaterThanOrEqualTo.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Threshold value associated with a notification. Notification is sent when the cost exceeded the threshold. It is always percent and has to be between 0 and 1000.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>The type of threshold for the notification. This determines whether the notification is triggered by forecasted costs or actual costs. The allowed values are Actual and Forecasted. Default is Actual. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("thresholdType")]
    public string? ThresholdType { get; set; }
}

/// <summary></summary>
public partial class V1beta1BudgetManagementGroupSpecForProviderTimePeriod
{
    /// <summary>The end date for the budget. If not set this will be 10 years after the start date.</summary>
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    /// <summary>The start date for the budget. The start date must be first of the month and should be less than the end date. Budget start date must be on or after June 1, 2017. Future start date should not be more than twelve months. Past start date should be selected within the timegrain period. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }
}

/// <summary></summary>
public partial class V1beta1BudgetManagementGroupSpecForProvider
{
    /// <summary>The total amount of cost to track with the budget.</summary>
    [JsonPropertyName("amount")]
    public double? Amount { get; set; }

    /// <summary>The ETag of the Management Group Consumption Budget.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>A filter block as defined below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1BudgetManagementGroupSpecForProviderFilter>? Filter { get; set; }

    /// <summary>The ID of the Management Group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managementGroupId")]
    public string? ManagementGroupId { get; set; }

    /// <summary>Reference to a ManagementGroup in management to populate managementGroupId.</summary>
    [JsonPropertyName("managementGroupIdRef")]
    public V1beta1BudgetManagementGroupSpecForProviderManagementGroupIdRef? ManagementGroupIdRef { get; set; }

    /// <summary>Selector for a ManagementGroup in management to populate managementGroupId.</summary>
    [JsonPropertyName("managementGroupIdSelector")]
    public V1beta1BudgetManagementGroupSpecForProviderManagementGroupIdSelector? ManagementGroupIdSelector { get; set; }

    /// <summary>The name which should be used for this Management Group Consumption Budget. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more notification blocks as defined below.</summary>
    [JsonPropertyName("notification")]
    public IList<V1beta1BudgetManagementGroupSpecForProviderNotification>? Notification { get; set; }

    /// <summary>The time covered by a budget. Tracking of the amount will be reset based on the time grain. Must be one of BillingAnnual, BillingMonth, BillingQuarter, Annually, Monthly and Quarterly. Defaults to Monthly. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("timeGrain")]
    public string? TimeGrain { get; set; }

    /// <summary>A time_period block as defined below.</summary>
    [JsonPropertyName("timePeriod")]
    public IList<V1beta1BudgetManagementGroupSpecForProviderTimePeriod>? TimePeriod { get; set; }
}

/// <summary></summary>
public partial class V1beta1BudgetManagementGroupSpecInitProviderFilterDimension
{
    /// <summary>The name of the tag to use for the filter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The operator to use for comparison. The allowed values are In. Defaults to In.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Specifies a list of values for the tag.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
public partial class V1beta1BudgetManagementGroupSpecInitProviderFilterNotDimension
{
    /// <summary>The name of the tag to use for the filter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The operator to use for comparison. The allowed values are In. Defaults to In.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Specifies a list of values for the tag.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
public partial class V1beta1BudgetManagementGroupSpecInitProviderFilterNotTag
{
    /// <summary>The name of the tag to use for the filter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The operator to use for comparison. The allowed values are In. Defaults to In.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Specifies a list of values for the tag.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
public partial class V1beta1BudgetManagementGroupSpecInitProviderFilterNot
{
    /// <summary>One dimension block as defined below to filter the budget on. Conflicts with tag.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1BudgetManagementGroupSpecInitProviderFilterNotDimension>? Dimension { get; set; }

    /// <summary>One tag block as defined below to filter the budget on. Conflicts with dimension.</summary>
    [JsonPropertyName("tag")]
    public IList<V1beta1BudgetManagementGroupSpecInitProviderFilterNotTag>? Tag { get; set; }
}

/// <summary></summary>
public partial class V1beta1BudgetManagementGroupSpecInitProviderFilterTag
{
    /// <summary>The name of the tag to use for the filter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The operator to use for comparison. The allowed values are In. Defaults to In.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Specifies a list of values for the tag.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
public partial class V1beta1BudgetManagementGroupSpecInitProviderFilter
{
    /// <summary>One or more dimension blocks as defined below to filter the budget on.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1BudgetManagementGroupSpecInitProviderFilterDimension>? Dimension { get; set; }

    /// <summary>A not block as defined below to filter the budget on. This is deprecated as the API no longer supports it and will be removed in version 4.0 of the provider.</summary>
    [JsonPropertyName("not")]
    public IList<V1beta1BudgetManagementGroupSpecInitProviderFilterNot>? Not { get; set; }

    /// <summary>One or more tag blocks as defined below to filter the budget on.</summary>
    [JsonPropertyName("tag")]
    public IList<V1beta1BudgetManagementGroupSpecInitProviderFilterTag>? Tag { get; set; }
}

public enum V1beta1BudgetManagementGroupSpecInitProviderManagementGroupIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BudgetManagementGroupSpecInitProviderManagementGroupIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BudgetManagementGroupSpecInitProviderManagementGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BudgetManagementGroupSpecInitProviderManagementGroupIdRefPolicyResolutionEnum>))]
    public V1beta1BudgetManagementGroupSpecInitProviderManagementGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BudgetManagementGroupSpecInitProviderManagementGroupIdRefPolicyResolveEnum>))]
    public V1beta1BudgetManagementGroupSpecInitProviderManagementGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ManagementGroup in management to populate managementGroupId.</summary>
public partial class V1beta1BudgetManagementGroupSpecInitProviderManagementGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BudgetManagementGroupSpecInitProviderManagementGroupIdRefPolicy? Policy { get; set; }
}

public enum V1beta1BudgetManagementGroupSpecInitProviderManagementGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BudgetManagementGroupSpecInitProviderManagementGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1BudgetManagementGroupSpecInitProviderManagementGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BudgetManagementGroupSpecInitProviderManagementGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1BudgetManagementGroupSpecInitProviderManagementGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BudgetManagementGroupSpecInitProviderManagementGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1BudgetManagementGroupSpecInitProviderManagementGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ManagementGroup in management to populate managementGroupId.</summary>
public partial class V1beta1BudgetManagementGroupSpecInitProviderManagementGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BudgetManagementGroupSpecInitProviderManagementGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1BudgetManagementGroupSpecInitProviderNotification
{
    /// <summary>Specifies a list of email addresses to send the budget notification to when the threshold is exceeded.</summary>
    [JsonPropertyName("contactEmails")]
    public IList<string>? ContactEmails { get; set; }

    /// <summary>Should the notification be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The comparison operator for the notification. Must be one of EqualTo, GreaterThan, or GreaterThanOrEqualTo.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Threshold value associated with a notification. Notification is sent when the cost exceeded the threshold. It is always percent and has to be between 0 and 1000.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>The type of threshold for the notification. This determines whether the notification is triggered by forecasted costs or actual costs. The allowed values are Actual and Forecasted. Default is Actual. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("thresholdType")]
    public string? ThresholdType { get; set; }
}

/// <summary></summary>
public partial class V1beta1BudgetManagementGroupSpecInitProviderTimePeriod
{
    /// <summary>The end date for the budget. If not set this will be 10 years after the start date.</summary>
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    /// <summary>The start date for the budget. The start date must be first of the month and should be less than the end date. Budget start date must be on or after June 1, 2017. Future start date should not be more than twelve months. Past start date should be selected within the timegrain period. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1BudgetManagementGroupSpecInitProvider
{
    /// <summary>The total amount of cost to track with the budget.</summary>
    [JsonPropertyName("amount")]
    public double? Amount { get; set; }

    /// <summary>The ETag of the Management Group Consumption Budget.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>A filter block as defined below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1BudgetManagementGroupSpecInitProviderFilter>? Filter { get; set; }

    /// <summary>The ID of the Management Group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managementGroupId")]
    public string? ManagementGroupId { get; set; }

    /// <summary>Reference to a ManagementGroup in management to populate managementGroupId.</summary>
    [JsonPropertyName("managementGroupIdRef")]
    public V1beta1BudgetManagementGroupSpecInitProviderManagementGroupIdRef? ManagementGroupIdRef { get; set; }

    /// <summary>Selector for a ManagementGroup in management to populate managementGroupId.</summary>
    [JsonPropertyName("managementGroupIdSelector")]
    public V1beta1BudgetManagementGroupSpecInitProviderManagementGroupIdSelector? ManagementGroupIdSelector { get; set; }

    /// <summary>The name which should be used for this Management Group Consumption Budget. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more notification blocks as defined below.</summary>
    [JsonPropertyName("notification")]
    public IList<V1beta1BudgetManagementGroupSpecInitProviderNotification>? Notification { get; set; }

    /// <summary>The time covered by a budget. Tracking of the amount will be reset based on the time grain. Must be one of BillingAnnual, BillingMonth, BillingQuarter, Annually, Monthly and Quarterly. Defaults to Monthly. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("timeGrain")]
    public string? TimeGrain { get; set; }

    /// <summary>A time_period block as defined below.</summary>
    [JsonPropertyName("timePeriod")]
    public IList<V1beta1BudgetManagementGroupSpecInitProviderTimePeriod>? TimePeriod { get; set; }
}

public enum V1beta1BudgetManagementGroupSpecManagementPoliciesEnum
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

public enum V1beta1BudgetManagementGroupSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BudgetManagementGroupSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BudgetManagementGroupSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BudgetManagementGroupSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1BudgetManagementGroupSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BudgetManagementGroupSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1BudgetManagementGroupSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1BudgetManagementGroupSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BudgetManagementGroupSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1BudgetManagementGroupSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1BudgetManagementGroupSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1BudgetManagementGroupSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BudgetManagementGroupSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1BudgetManagementGroupSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BudgetManagementGroupSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1BudgetManagementGroupSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1BudgetManagementGroupSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BudgetManagementGroupSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1BudgetManagementGroupSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1BudgetManagementGroupSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1BudgetManagementGroupSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1BudgetManagementGroupSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1BudgetManagementGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>BudgetManagementGroupSpec defines the desired state of BudgetManagementGroup</summary>
public partial class V1beta1BudgetManagementGroupSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BudgetManagementGroupSpecDeletionPolicyEnum>))]
    public V1beta1BudgetManagementGroupSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1BudgetManagementGroupSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1BudgetManagementGroupSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1BudgetManagementGroupSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BudgetManagementGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1BudgetManagementGroupSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BudgetManagementGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1BudgetManagementGroupStatusAtProviderFilterDimension
{
    /// <summary>The name of the tag to use for the filter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The operator to use for comparison. The allowed values are In. Defaults to In.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Specifies a list of values for the tag.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
public partial class V1beta1BudgetManagementGroupStatusAtProviderFilterNotDimension
{
    /// <summary>The name of the tag to use for the filter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The operator to use for comparison. The allowed values are In. Defaults to In.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Specifies a list of values for the tag.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
public partial class V1beta1BudgetManagementGroupStatusAtProviderFilterNotTag
{
    /// <summary>The name of the tag to use for the filter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The operator to use for comparison. The allowed values are In. Defaults to In.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Specifies a list of values for the tag.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
public partial class V1beta1BudgetManagementGroupStatusAtProviderFilterNot
{
    /// <summary>One dimension block as defined below to filter the budget on. Conflicts with tag.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1BudgetManagementGroupStatusAtProviderFilterNotDimension>? Dimension { get; set; }

    /// <summary>One tag block as defined below to filter the budget on. Conflicts with dimension.</summary>
    [JsonPropertyName("tag")]
    public IList<V1beta1BudgetManagementGroupStatusAtProviderFilterNotTag>? Tag { get; set; }
}

/// <summary></summary>
public partial class V1beta1BudgetManagementGroupStatusAtProviderFilterTag
{
    /// <summary>The name of the tag to use for the filter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The operator to use for comparison. The allowed values are In. Defaults to In.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Specifies a list of values for the tag.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
public partial class V1beta1BudgetManagementGroupStatusAtProviderFilter
{
    /// <summary>One or more dimension blocks as defined below to filter the budget on.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1BudgetManagementGroupStatusAtProviderFilterDimension>? Dimension { get; set; }

    /// <summary>A not block as defined below to filter the budget on. This is deprecated as the API no longer supports it and will be removed in version 4.0 of the provider.</summary>
    [JsonPropertyName("not")]
    public IList<V1beta1BudgetManagementGroupStatusAtProviderFilterNot>? Not { get; set; }

    /// <summary>One or more tag blocks as defined below to filter the budget on.</summary>
    [JsonPropertyName("tag")]
    public IList<V1beta1BudgetManagementGroupStatusAtProviderFilterTag>? Tag { get; set; }
}

/// <summary></summary>
public partial class V1beta1BudgetManagementGroupStatusAtProviderNotification
{
    /// <summary>Specifies a list of email addresses to send the budget notification to when the threshold is exceeded.</summary>
    [JsonPropertyName("contactEmails")]
    public IList<string>? ContactEmails { get; set; }

    /// <summary>Should the notification be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The comparison operator for the notification. Must be one of EqualTo, GreaterThan, or GreaterThanOrEqualTo.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Threshold value associated with a notification. Notification is sent when the cost exceeded the threshold. It is always percent and has to be between 0 and 1000.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>The type of threshold for the notification. This determines whether the notification is triggered by forecasted costs or actual costs. The allowed values are Actual and Forecasted. Default is Actual. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("thresholdType")]
    public string? ThresholdType { get; set; }
}

/// <summary></summary>
public partial class V1beta1BudgetManagementGroupStatusAtProviderTimePeriod
{
    /// <summary>The end date for the budget. If not set this will be 10 years after the start date.</summary>
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    /// <summary>The start date for the budget. The start date must be first of the month and should be less than the end date. Budget start date must be on or after June 1, 2017. Future start date should not be more than twelve months. Past start date should be selected within the timegrain period. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }
}

/// <summary></summary>
public partial class V1beta1BudgetManagementGroupStatusAtProvider
{
    /// <summary>The total amount of cost to track with the budget.</summary>
    [JsonPropertyName("amount")]
    public double? Amount { get; set; }

    /// <summary>The ETag of the Management Group Consumption Budget.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>A filter block as defined below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1BudgetManagementGroupStatusAtProviderFilter>? Filter { get; set; }

    /// <summary>The ID of the Management Group Consumption Budget.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The ID of the Management Group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managementGroupId")]
    public string? ManagementGroupId { get; set; }

    /// <summary>The name which should be used for this Management Group Consumption Budget. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more notification blocks as defined below.</summary>
    [JsonPropertyName("notification")]
    public IList<V1beta1BudgetManagementGroupStatusAtProviderNotification>? Notification { get; set; }

    /// <summary>The time covered by a budget. Tracking of the amount will be reset based on the time grain. Must be one of BillingAnnual, BillingMonth, BillingQuarter, Annually, Monthly and Quarterly. Defaults to Monthly. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("timeGrain")]
    public string? TimeGrain { get; set; }

    /// <summary>A time_period block as defined below.</summary>
    [JsonPropertyName("timePeriod")]
    public IList<V1beta1BudgetManagementGroupStatusAtProviderTimePeriod>? TimePeriod { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1BudgetManagementGroupStatusConditions
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

/// <summary>BudgetManagementGroupStatus defines the observed state of BudgetManagementGroup.</summary>
public partial class V1beta1BudgetManagementGroupStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1BudgetManagementGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BudgetManagementGroupStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>BudgetManagementGroup is the Schema for the BudgetManagementGroups API. Manages a Consumption Budget for a Management Group.</summary>
public partial class V1beta1BudgetManagementGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BudgetManagementGroupSpec>, IStatus<V1beta1BudgetManagementGroupStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BudgetManagementGroup";
    public const string KubeGroup = "consumption.azure.upbound.io";
    public const string KubePluralName = "budgetmanagementgroups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BudgetManagementGroupSpec defines the desired state of BudgetManagementGroup</summary>
    [JsonPropertyName("spec")]
    public V1beta1BudgetManagementGroupSpec Spec { get; set; }

    /// <summary>BudgetManagementGroupStatus defines the observed state of BudgetManagementGroup.</summary>
    [JsonPropertyName("status")]
    public V1beta1BudgetManagementGroupStatus? Status { get; set; }
}