using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.billingbudgets.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BillingBudgetsBudgetList : IKubernetesObject<V1ListMeta>, IItems<V1beta1BillingBudgetsBudget>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BillingBudgetsBudgetList";
    public const string KubeGroup = "billingbudgets.cnrm.cloud.google.com";
    public const string KubePluralName = "billingbudgetsbudgets";
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
    public IList<V1beta1BillingBudgetsBudget> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BillingBudgetsBudgetSpecAllUpdatesRuleMonitoringNotificationChannels
{
    /// <summary>Allowed value: The Google Cloud resource name of a `MonitoringNotificationChannel` resource (format: `projects/{{project}}/notificationChannels/{{name}}`).</summary>
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BillingBudgetsBudgetSpecAllUpdatesRulePubsubTopicRef
{
    /// <summary>Optional. The name of the Pub/Sub topic where budget related messages will be published, in the form `projects/{project_id}/topics/{topic_id}`. Updates are sent at regular intervals to the topic. The topic needs to be created before the budget is created; see https://cloud.google.com/billing/docs/how-to/budgets-programmatic-notifications for more details. Caller is expected to have `pubsub.topics.setIamPolicy` permission on the topic when it's set for a budget, otherwise, the API call will fail with PERMISSION_DENIED. See https://cloud.google.com/billing/docs/how-to/budgets-programmatic-notifications#permissions_required_for_this_task for more details on Pub/Sub roles and permissions.  Allowed value: The Google Cloud resource name of a `PubSubTopic` resource (format: `projects/{{project}}/topics/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Rules to apply to notifications sent based on budget spend and thresholds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BillingBudgetsBudgetSpecAllUpdatesRule
{
    /// <summary>Optional. When set to true, disables default notifications sent when a threshold is exceeded. Default notifications are sent to those with Billing Account Administrator and Billing Account User IAM roles for the target account.</summary>
    [JsonPropertyName("disableDefaultIamRecipients")]
    public bool? DisableDefaultIamRecipients { get; set; }

    /// <summary></summary>
    [JsonPropertyName("monitoringNotificationChannels")]
    public IList<V1beta1BillingBudgetsBudgetSpecAllUpdatesRuleMonitoringNotificationChannels>? MonitoringNotificationChannels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pubsubTopicRef")]
    public V1beta1BillingBudgetsBudgetSpecAllUpdatesRulePubsubTopicRef? PubsubTopicRef { get; set; }

    /// <summary>Optional. Required when NotificationsRule.pubsub_topic is set. The schema version of the notification sent to NotificationsRule.pubsub_topic. Only "1.0" is accepted. It represents the JSON schema as defined in https://cloud.google.com/billing/docs/how-to/budgets-programmatic-notifications#notification_format.</summary>
    [JsonPropertyName("schemaVersion")]
    public string? SchemaVersion { get; set; }
}

/// <summary>A specified amount to use as the budget. `currency_code` is optional. If specified when creating a budget, it must match the currency of the billing account. If specified when updating a budget, it must match the currency_code of the existing budget. The `currency_code` is provided on output.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BillingBudgetsBudgetSpecAmountSpecifiedAmount
{
    /// <summary>Immutable. The three-letter currency code defined in ISO 4217.</summary>
    [JsonPropertyName("currencyCode")]
    public string? CurrencyCode { get; set; }

    /// <summary>Number of nano (10^-9) units of the amount. The value must be between -999,999,999 and +999,999,999 inclusive. If `units` is positive, `nanos` must be positive or zero. If `units` is zero, `nanos` can be positive, zero, or negative. If `units` is negative, `nanos` must be negative or zero. For example $-1.75 is represented as `units`=-1 and `nanos`=-750,000,000.</summary>
    [JsonPropertyName("nanos")]
    public long? Nanos { get; set; }

    /// <summary>The whole units of the amount. For example if `currencyCode` is `"USD"`, then 1 unit is one US dollar.</summary>
    [JsonPropertyName("units")]
    public long? Units { get; set; }
}

/// <summary>Required. Budgeted amount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BillingBudgetsBudgetSpecAmount
{
    /// <summary>Use the last period's actual spend as the budget for the present period. LastPeriodAmount can only be set when the budget's time period is a .</summary>
    [JsonPropertyName("lastPeriodAmount")]
    public JsonNode? LastPeriodAmount { get; set; }

    /// <summary>A specified amount to use as the budget. `currency_code` is optional. If specified when creating a budget, it must match the currency of the billing account. If specified when updating a budget, it must match the currency_code of the existing budget. The `currency_code` is provided on output.</summary>
    [JsonPropertyName("specifiedAmount")]
    public V1beta1BillingBudgetsBudgetSpecAmountSpecifiedAmount? SpecifiedAmount { get; set; }
}

/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BillingBudgetsBudgetSpecBillingAccountRef
{
    /// <summary>The billing account of the resource  Allowed value: The Google Cloud resource name of a Google Cloud Billing Account (format: `billingAccounts/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>[WARNING] BillingAccount not yet supported in Config Connector, use 'external' field to reference existing resources. Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Optional. The end date of the time period. Budgets with elapsed end date won't be processed. If unset, specifies to track all usage incurred since the start_date.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BillingBudgetsBudgetSpecBudgetFilterCustomPeriodEndDate
{
    /// <summary>Immutable. Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn't significant.</summary>
    [JsonPropertyName("day")]
    public long? Day { get; set; }

    /// <summary>Immutable. Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public long? Month { get; set; }

    /// <summary>Immutable. Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
    [JsonPropertyName("year")]
    public long? Year { get; set; }
}

/// <summary>Immutable. Required. The start date must be after January 1, 2017.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BillingBudgetsBudgetSpecBudgetFilterCustomPeriodStartDate
{
    /// <summary>Immutable. Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn't significant.</summary>
    [JsonPropertyName("day")]
    public long? Day { get; set; }

    /// <summary>Immutable. Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public long? Month { get; set; }

    /// <summary>Immutable. Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
    [JsonPropertyName("year")]
    public long? Year { get; set; }
}

/// <summary>Optional. Specifies to track usage from any start date (required) to any end date (optional). This time period is static, it does not recur.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BillingBudgetsBudgetSpecBudgetFilterCustomPeriod
{
    /// <summary>Immutable. Optional. The end date of the time period. Budgets with elapsed end date won't be processed. If unset, specifies to track all usage incurred since the start_date.</summary>
    [JsonPropertyName("endDate")]
    public V1beta1BillingBudgetsBudgetSpecBudgetFilterCustomPeriodEndDate? EndDate { get; set; }

    /// <summary>Immutable. Required. The start date must be after January 1, 2017.</summary>
    [JsonPropertyName("startDate")]
    public V1beta1BillingBudgetsBudgetSpecBudgetFilterCustomPeriodStartDate StartDate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BillingBudgetsBudgetSpecBudgetFilterLabels
{
    /// <summary>Immutable. The values of the label</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BillingBudgetsBudgetSpecBudgetFilterProjects
{
    /// <summary>Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).</summary>
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BillingBudgetsBudgetSpecBudgetFilterSubaccounts
{
    /// <summary></summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>[WARNING] CloudBillingBillingAccount not yet supported in Config Connector, use 'external' field to reference existing resources. Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Filters that define which resources are used to compute the actual spend against the budget amount, such as projects, services, and the budget's time period, as well as other filters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BillingBudgetsBudgetSpecBudgetFilter
{
    /// <summary>Optional. Specifies to track usage for recurring calendar period. For example, assume that CalendarPeriod.QUARTER is set. The budget will track usage from April 1 to June 30, when the current calendar month is April, May, June. After that, it will track usage from July 1 to September 30 when the current calendar month is July, August, September, so on. Possible values: CALENDAR_PERIOD_UNSPECIFIED, MONTH, QUARTER, YEAR</summary>
    [JsonPropertyName("calendarPeriod")]
    public string? CalendarPeriod { get; set; }

    /// <summary>Optional. If Filter.credit_types_treatment is INCLUDE_SPECIFIED_CREDITS, this is a list of credit types to be subtracted from gross cost to determine the spend for threshold calculations. See a list of acceptable credit type values. If Filter.credit_types_treatment is not INCLUDE_SPECIFIED_CREDITS, this field must be empty.</summary>
    [JsonPropertyName("creditTypes")]
    public IList<string>? CreditTypes { get; set; }

    /// <summary>Optional. If not set, default behavior is `INCLUDE_ALL_CREDITS`.</summary>
    [JsonPropertyName("creditTypesTreatment")]
    public string? CreditTypesTreatment { get; set; }

    /// <summary>Optional. Specifies to track usage from any start date (required) to any end date (optional). This time period is static, it does not recur.</summary>
    [JsonPropertyName("customPeriod")]
    public V1beta1BillingBudgetsBudgetSpecBudgetFilterCustomPeriod? CustomPeriod { get; set; }

    /// <summary>Optional. A single label and value pair specifying that usage from only this set of labeled resources should be included in the budget. Currently, multiple entries or multiple values per entry are not allowed. If omitted, the report will include all labeled and unlabeled usage.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, V1beta1BillingBudgetsBudgetSpecBudgetFilterLabels>? Labels { get; set; }

    /// <summary></summary>
    [JsonPropertyName("projects")]
    public IList<V1beta1BillingBudgetsBudgetSpecBudgetFilterProjects>? Projects { get; set; }

    /// <summary>Optional. A set of services of the form `services/{service_id}`, specifying that usage from only this set of services should be included in the budget. If omitted, the report will include usage for all the services. The service names are available through the Catalog API: https://cloud.google.com/billing/v1/how-tos/catalog-api.</summary>
    [JsonPropertyName("services")]
    public IList<string>? Services { get; set; }

    /// <summary></summary>
    [JsonPropertyName("subaccounts")]
    public IList<V1beta1BillingBudgetsBudgetSpecBudgetFilterSubaccounts>? Subaccounts { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BillingBudgetsBudgetSpecThresholdRules
{
    /// <summary>Optional. The type of basis used to determine if spend has passed the threshold. Behavior defaults to CURRENT_SPEND if not set. Possible values: BASIS_UNSPECIFIED, CURRENT_SPEND, FORECASTED_SPEND</summary>
    [JsonPropertyName("spendBasis")]
    public string? SpendBasis { get; set; }

    /// <summary>Required. Send an alert when this threshold is exceeded. This is a 1.0-based percentage, so 0.5 = 50%. Validation: non-negative number.</summary>
    [JsonPropertyName("thresholdPercent")]
    public double ThresholdPercent { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BillingBudgetsBudgetSpec
{
    /// <summary>Optional. Rules to apply to notifications sent based on budget spend and thresholds.</summary>
    [JsonPropertyName("allUpdatesRule")]
    public V1beta1BillingBudgetsBudgetSpecAllUpdatesRule? AllUpdatesRule { get; set; }

    /// <summary>Required. Budgeted amount.</summary>
    [JsonPropertyName("amount")]
    public V1beta1BillingBudgetsBudgetSpecAmount Amount { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("billingAccountRef")]
    public V1beta1BillingBudgetsBudgetSpecBillingAccountRef BillingAccountRef { get; set; }

    /// <summary>Optional. Filters that define which resources are used to compute the actual spend against the budget amount, such as projects, services, and the budget's time period, as well as other filters.</summary>
    [JsonPropertyName("budgetFilter")]
    public V1beta1BillingBudgetsBudgetSpecBudgetFilter? BudgetFilter { get; set; }

    /// <summary>User data for display name in UI. The name must be less than or equal to 60 characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. Rules that trigger alerts (notifications of thresholds being crossed) when spend exceeds the specified percentages of the budget.</summary>
    [JsonPropertyName("thresholdRules")]
    public IList<V1beta1BillingBudgetsBudgetSpecThresholdRules>? ThresholdRules { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BillingBudgetsBudgetStatusConditions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BillingBudgetsBudgetStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BillingBudgetsBudgetStatusConditions>? Conditions { get; set; }

    /// <summary>Optional. Etag to validate that the object is unchanged for a read-modify-write operation. An empty etag will cause an update to overwrite other changes.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BillingBudgetsBudget : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BillingBudgetsBudgetSpec>, IStatus<V1beta1BillingBudgetsBudgetStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BillingBudgetsBudget";
    public const string KubeGroup = "billingbudgets.cnrm.cloud.google.com";
    public const string KubePluralName = "billingbudgetsbudgets";
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
    public V1beta1BillingBudgetsBudgetSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1BillingBudgetsBudgetStatus? Status { get; set; }
}