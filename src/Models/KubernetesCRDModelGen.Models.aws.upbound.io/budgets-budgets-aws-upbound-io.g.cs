using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.budgets.aws.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecForProviderAutoAdjustDataHistoricalOptions
{
    /// <summary>The number of budget periods included in the moving-average calculation that determines your auto-adjusted budget amount.</summary>
    [JsonPropertyName("budgetAdjustmentPeriod")]
    public double? BudgetAdjustmentPeriod { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecForProviderAutoAdjustData
{
    /// <summary>The string that defines whether your budget auto-adjusts based on historical or forecasted data. Valid values: FORECAST,HISTORICAL</summary>
    [JsonPropertyName("autoAdjustType")]
    public string? AutoAdjustType { get; set; }

    /// <summary>Configuration block of Historical Options. Required for auto_adjust_type of HISTORICAL Configuration block that defines the historical data that your auto-adjusting budget is based on.</summary>
    [JsonPropertyName("historicalOptions")]
    public IList<V1beta1BudgetSpecForProviderAutoAdjustDataHistoricalOptions>? HistoricalOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecForProviderCostFilter
{
    /// <summary>The name of a budget. Unique within accounts.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecForProviderCostTypes
{
    /// <summary>A boolean value whether to include credits in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeCredit")]
    public bool? IncludeCredit { get; set; }

    /// <summary>Whether a budget includes discounts. Defaults to true</summary>
    [JsonPropertyName("includeDiscount")]
    public bool? IncludeDiscount { get; set; }

    /// <summary>A boolean value whether to include other subscription costs in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeOtherSubscription")]
    public bool? IncludeOtherSubscription { get; set; }

    /// <summary>A boolean value whether to include recurring costs in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeRecurring")]
    public bool? IncludeRecurring { get; set; }

    /// <summary>A boolean value whether to include refunds in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeRefund")]
    public bool? IncludeRefund { get; set; }

    /// <summary>A boolean value whether to include subscriptions in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeSubscription")]
    public bool? IncludeSubscription { get; set; }

    /// <summary>A boolean value whether to include support costs in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeSupport")]
    public bool? IncludeSupport { get; set; }

    /// <summary>A boolean value whether to include tax in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeTax")]
    public bool? IncludeTax { get; set; }

    /// <summary>A boolean value whether to include upfront costs in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeUpfront")]
    public bool? IncludeUpfront { get; set; }

    /// <summary>Whether a budget uses the amortized rate. Defaults to false</summary>
    [JsonPropertyName("useAmortized")]
    public bool? UseAmortized { get; set; }

    /// <summary>A boolean value whether to use blended costs in the cost budget. Defaults to false</summary>
    [JsonPropertyName("useBlended")]
    public bool? UseBlended { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecForProviderNotification
{
    /// <summary>Comparison operator to use to evaluate the condition. Can be LESS_THAN, EQUAL_TO or GREATER_THAN.</summary>
    [JsonPropertyName("comparisonOperator")]
    public string? ComparisonOperator { get; set; }

    /// <summary>What kind of budget value to notify on. Can be ACTUAL or FORECASTED</summary>
    [JsonPropertyName("notificationType")]
    public string? NotificationType { get; set; }

    /// <summary>E-Mail addresses to notify. Either this or subscriber_sns_topic_arns is required.</summary>
    [JsonPropertyName("subscriberEmailAddresses")]
    public IList<string>? SubscriberEmailAddresses { get; set; }

    /// <summary>SNS topics to notify. Either this or subscriber_email_addresses is required.</summary>
    [JsonPropertyName("subscriberSnsTopicArns")]
    public IList<string>? SubscriberSnsTopicArns { get; set; }

    /// <summary>Threshold when the notification should be sent.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>What kind of threshold is defined. Can be PERCENTAGE OR ABSOLUTE_VALUE.</summary>
    [JsonPropertyName("thresholdType")]
    public string? ThresholdType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecForProviderPlannedLimit
{
    /// <summary>The amount of cost or usage being measured for a budget.</summary>
    [JsonPropertyName("amount")]
    public string? Amount { get; set; }

    /// <summary>The start time of the budget limit. Format: 2017-01-01_12:00. See PlannedBudgetLimits documentation.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>The unit of measurement used for the budget forecast, actual spend, or budget threshold, such as dollars or GB. See Spend documentation.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecForProvider
{
    /// <summary>The ID of the target account for budget. Will use current user's account_id by default if omitted.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Object containing AutoAdjustData which determines the budget amount for an auto-adjusting budget.</summary>
    [JsonPropertyName("autoAdjustData")]
    public IList<V1beta1BudgetSpecForProviderAutoAdjustData>? AutoAdjustData { get; set; }

    /// <summary>Whether this budget tracks monetary cost or usage.</summary>
    [JsonPropertyName("budgetType")]
    public string? BudgetType { get; set; }

    /// <summary>A list of CostFilter name/values pair to apply to budget.</summary>
    [JsonPropertyName("costFilter")]
    public IList<V1beta1BudgetSpecForProviderCostFilter>? CostFilter { get; set; }

    /// <summary>Object containing CostTypes The types of cost included in a budget, such as tax and subscriptions.</summary>
    [JsonPropertyName("costTypes")]
    public IList<V1beta1BudgetSpecForProviderCostTypes>? CostTypes { get; set; }

    /// <summary>The amount of cost or usage being measured for a budget.</summary>
    [JsonPropertyName("limitAmount")]
    public string? LimitAmount { get; set; }

    /// <summary>The unit of measurement used for the budget forecast, actual spend, or budget threshold, such as dollars or GB. See Spend documentation.</summary>
    [JsonPropertyName("limitUnit")]
    public string? LimitUnit { get; set; }

    /// <summary>Object containing Budget Notifications. Can be used multiple times to define more than one budget notification.</summary>
    [JsonPropertyName("notification")]
    public IList<V1beta1BudgetSpecForProviderNotification>? Notification { get; set; }

    /// <summary>Object containing Planned Budget Limits. Can be used multiple times to plan more than one budget limit. See PlannedBudgetLimits documentation.</summary>
    [JsonPropertyName("plannedLimit")]
    public IList<V1beta1BudgetSpecForProviderPlannedLimit>? PlannedLimit { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The end of the time period covered by the budget. There are no restrictions on the end date. Format: 2017-01-01_12:00.</summary>
    [JsonPropertyName("timePeriodEnd")]
    public string? TimePeriodEnd { get; set; }

    /// <summary>The start of the time period covered by the budget. If you don't specify a start date, AWS defaults to the start of your chosen time period. The start date must come before the end date. Format: 2017-01-01_12:00.</summary>
    [JsonPropertyName("timePeriodStart")]
    public string? TimePeriodStart { get; set; }

    /// <summary>The length of time until a budget resets the actual and forecasted spend. Valid values: MONTHLY, QUARTERLY, ANNUALLY, and DAILY.</summary>
    [JsonPropertyName("timeUnit")]
    public string? TimeUnit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecInitProviderAutoAdjustDataHistoricalOptions
{
    /// <summary>The number of budget periods included in the moving-average calculation that determines your auto-adjusted budget amount.</summary>
    [JsonPropertyName("budgetAdjustmentPeriod")]
    public double? BudgetAdjustmentPeriod { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecInitProviderAutoAdjustData
{
    /// <summary>The string that defines whether your budget auto-adjusts based on historical or forecasted data. Valid values: FORECAST,HISTORICAL</summary>
    [JsonPropertyName("autoAdjustType")]
    public string? AutoAdjustType { get; set; }

    /// <summary>Configuration block of Historical Options. Required for auto_adjust_type of HISTORICAL Configuration block that defines the historical data that your auto-adjusting budget is based on.</summary>
    [JsonPropertyName("historicalOptions")]
    public IList<V1beta1BudgetSpecInitProviderAutoAdjustDataHistoricalOptions>? HistoricalOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecInitProviderCostFilter
{
    /// <summary>The name of a budget. Unique within accounts.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecInitProviderCostTypes
{
    /// <summary>A boolean value whether to include credits in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeCredit")]
    public bool? IncludeCredit { get; set; }

    /// <summary>Whether a budget includes discounts. Defaults to true</summary>
    [JsonPropertyName("includeDiscount")]
    public bool? IncludeDiscount { get; set; }

    /// <summary>A boolean value whether to include other subscription costs in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeOtherSubscription")]
    public bool? IncludeOtherSubscription { get; set; }

    /// <summary>A boolean value whether to include recurring costs in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeRecurring")]
    public bool? IncludeRecurring { get; set; }

    /// <summary>A boolean value whether to include refunds in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeRefund")]
    public bool? IncludeRefund { get; set; }

    /// <summary>A boolean value whether to include subscriptions in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeSubscription")]
    public bool? IncludeSubscription { get; set; }

    /// <summary>A boolean value whether to include support costs in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeSupport")]
    public bool? IncludeSupport { get; set; }

    /// <summary>A boolean value whether to include tax in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeTax")]
    public bool? IncludeTax { get; set; }

    /// <summary>A boolean value whether to include upfront costs in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeUpfront")]
    public bool? IncludeUpfront { get; set; }

    /// <summary>Whether a budget uses the amortized rate. Defaults to false</summary>
    [JsonPropertyName("useAmortized")]
    public bool? UseAmortized { get; set; }

    /// <summary>A boolean value whether to use blended costs in the cost budget. Defaults to false</summary>
    [JsonPropertyName("useBlended")]
    public bool? UseBlended { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecInitProviderNotification
{
    /// <summary>Comparison operator to use to evaluate the condition. Can be LESS_THAN, EQUAL_TO or GREATER_THAN.</summary>
    [JsonPropertyName("comparisonOperator")]
    public string? ComparisonOperator { get; set; }

    /// <summary>What kind of budget value to notify on. Can be ACTUAL or FORECASTED</summary>
    [JsonPropertyName("notificationType")]
    public string? NotificationType { get; set; }

    /// <summary>E-Mail addresses to notify. Either this or subscriber_sns_topic_arns is required.</summary>
    [JsonPropertyName("subscriberEmailAddresses")]
    public IList<string>? SubscriberEmailAddresses { get; set; }

    /// <summary>SNS topics to notify. Either this or subscriber_email_addresses is required.</summary>
    [JsonPropertyName("subscriberSnsTopicArns")]
    public IList<string>? SubscriberSnsTopicArns { get; set; }

    /// <summary>Threshold when the notification should be sent.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>What kind of threshold is defined. Can be PERCENTAGE OR ABSOLUTE_VALUE.</summary>
    [JsonPropertyName("thresholdType")]
    public string? ThresholdType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecInitProviderPlannedLimit
{
    /// <summary>The amount of cost or usage being measured for a budget.</summary>
    [JsonPropertyName("amount")]
    public string? Amount { get; set; }

    /// <summary>The start time of the budget limit. Format: 2017-01-01_12:00. See PlannedBudgetLimits documentation.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>The unit of measurement used for the budget forecast, actual spend, or budget threshold, such as dollars or GB. See Spend documentation.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecInitProvider
{
    /// <summary>The ID of the target account for budget. Will use current user's account_id by default if omitted.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>Object containing AutoAdjustData which determines the budget amount for an auto-adjusting budget.</summary>
    [JsonPropertyName("autoAdjustData")]
    public IList<V1beta1BudgetSpecInitProviderAutoAdjustData>? AutoAdjustData { get; set; }

    /// <summary>Whether this budget tracks monetary cost or usage.</summary>
    [JsonPropertyName("budgetType")]
    public string? BudgetType { get; set; }

    /// <summary>A list of CostFilter name/values pair to apply to budget.</summary>
    [JsonPropertyName("costFilter")]
    public IList<V1beta1BudgetSpecInitProviderCostFilter>? CostFilter { get; set; }

    /// <summary>Object containing CostTypes The types of cost included in a budget, such as tax and subscriptions.</summary>
    [JsonPropertyName("costTypes")]
    public IList<V1beta1BudgetSpecInitProviderCostTypes>? CostTypes { get; set; }

    /// <summary>The amount of cost or usage being measured for a budget.</summary>
    [JsonPropertyName("limitAmount")]
    public string? LimitAmount { get; set; }

    /// <summary>The unit of measurement used for the budget forecast, actual spend, or budget threshold, such as dollars or GB. See Spend documentation.</summary>
    [JsonPropertyName("limitUnit")]
    public string? LimitUnit { get; set; }

    /// <summary>Object containing Budget Notifications. Can be used multiple times to define more than one budget notification.</summary>
    [JsonPropertyName("notification")]
    public IList<V1beta1BudgetSpecInitProviderNotification>? Notification { get; set; }

    /// <summary>Object containing Planned Budget Limits. Can be used multiple times to plan more than one budget limit. See PlannedBudgetLimits documentation.</summary>
    [JsonPropertyName("plannedLimit")]
    public IList<V1beta1BudgetSpecInitProviderPlannedLimit>? PlannedLimit { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The end of the time period covered by the budget. There are no restrictions on the end date. Format: 2017-01-01_12:00.</summary>
    [JsonPropertyName("timePeriodEnd")]
    public string? TimePeriodEnd { get; set; }

    /// <summary>The start of the time period covered by the budget. If you don't specify a start date, AWS defaults to the start of your chosen time period. The start date must come before the end date. Format: 2017-01-01_12:00.</summary>
    [JsonPropertyName("timePeriodStart")]
    public string? TimePeriodStart { get; set; }

    /// <summary>The length of time until a budget resets the actual and forecasted spend. Valid values: MONTHLY, QUARTERLY, ANNUALLY, and DAILY.</summary>
    [JsonPropertyName("timeUnit")]
    public string? TimeUnit { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecProviderConfigRefPolicy
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
public partial class V1beta1BudgetSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BudgetSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1BudgetSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BudgetSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1BudgetSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1BudgetSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1BudgetSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>BudgetSpec defines the desired state of Budget</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1BudgetSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1BudgetSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BudgetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1BudgetSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BudgetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetStatusAtProviderAutoAdjustDataHistoricalOptions
{
    /// <summary>The number of budget periods included in the moving-average calculation that determines your auto-adjusted budget amount.</summary>
    [JsonPropertyName("budgetAdjustmentPeriod")]
    public double? BudgetAdjustmentPeriod { get; set; }

    /// <summary>The integer that describes how many budget periods in your BudgetAdjustmentPeriod are included in the calculation of your current budget limit. If the first budget period in your BudgetAdjustmentPeriod has no cost data, then that budget period isn’t included in the average that determines your budget limit. You can’t set your own LookBackAvailablePeriods. The value is automatically calculated from the budget_adjustment_period and your historical cost data.</summary>
    [JsonPropertyName("lookbackAvailablePeriods")]
    public double? LookbackAvailablePeriods { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetStatusAtProviderAutoAdjustData
{
    /// <summary>The string that defines whether your budget auto-adjusts based on historical or forecasted data. Valid values: FORECAST,HISTORICAL</summary>
    [JsonPropertyName("autoAdjustType")]
    public string? AutoAdjustType { get; set; }

    /// <summary>Configuration block of Historical Options. Required for auto_adjust_type of HISTORICAL Configuration block that defines the historical data that your auto-adjusting budget is based on.</summary>
    [JsonPropertyName("historicalOptions")]
    public IList<V1beta1BudgetStatusAtProviderAutoAdjustDataHistoricalOptions>? HistoricalOptions { get; set; }

    /// <summary>The last time that your budget was auto-adjusted.</summary>
    [JsonPropertyName("lastAutoAdjustTime")]
    public string? LastAutoAdjustTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetStatusAtProviderCostFilter
{
    /// <summary>The name of a budget. Unique within accounts.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetStatusAtProviderCostTypes
{
    /// <summary>A boolean value whether to include credits in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeCredit")]
    public bool? IncludeCredit { get; set; }

    /// <summary>Whether a budget includes discounts. Defaults to true</summary>
    [JsonPropertyName("includeDiscount")]
    public bool? IncludeDiscount { get; set; }

    /// <summary>A boolean value whether to include other subscription costs in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeOtherSubscription")]
    public bool? IncludeOtherSubscription { get; set; }

    /// <summary>A boolean value whether to include recurring costs in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeRecurring")]
    public bool? IncludeRecurring { get; set; }

    /// <summary>A boolean value whether to include refunds in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeRefund")]
    public bool? IncludeRefund { get; set; }

    /// <summary>A boolean value whether to include subscriptions in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeSubscription")]
    public bool? IncludeSubscription { get; set; }

    /// <summary>A boolean value whether to include support costs in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeSupport")]
    public bool? IncludeSupport { get; set; }

    /// <summary>A boolean value whether to include tax in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeTax")]
    public bool? IncludeTax { get; set; }

    /// <summary>A boolean value whether to include upfront costs in the cost budget. Defaults to true</summary>
    [JsonPropertyName("includeUpfront")]
    public bool? IncludeUpfront { get; set; }

    /// <summary>Whether a budget uses the amortized rate. Defaults to false</summary>
    [JsonPropertyName("useAmortized")]
    public bool? UseAmortized { get; set; }

    /// <summary>A boolean value whether to use blended costs in the cost budget. Defaults to false</summary>
    [JsonPropertyName("useBlended")]
    public bool? UseBlended { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetStatusAtProviderNotification
{
    /// <summary>Comparison operator to use to evaluate the condition. Can be LESS_THAN, EQUAL_TO or GREATER_THAN.</summary>
    [JsonPropertyName("comparisonOperator")]
    public string? ComparisonOperator { get; set; }

    /// <summary>What kind of budget value to notify on. Can be ACTUAL or FORECASTED</summary>
    [JsonPropertyName("notificationType")]
    public string? NotificationType { get; set; }

    /// <summary>E-Mail addresses to notify. Either this or subscriber_sns_topic_arns is required.</summary>
    [JsonPropertyName("subscriberEmailAddresses")]
    public IList<string>? SubscriberEmailAddresses { get; set; }

    /// <summary>SNS topics to notify. Either this or subscriber_email_addresses is required.</summary>
    [JsonPropertyName("subscriberSnsTopicArns")]
    public IList<string>? SubscriberSnsTopicArns { get; set; }

    /// <summary>Threshold when the notification should be sent.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>What kind of threshold is defined. Can be PERCENTAGE OR ABSOLUTE_VALUE.</summary>
    [JsonPropertyName("thresholdType")]
    public string? ThresholdType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetStatusAtProviderPlannedLimit
{
    /// <summary>The amount of cost or usage being measured for a budget.</summary>
    [JsonPropertyName("amount")]
    public string? Amount { get; set; }

    /// <summary>The start time of the budget limit. Format: 2017-01-01_12:00. See PlannedBudgetLimits documentation.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>The unit of measurement used for the budget forecast, actual spend, or budget threshold, such as dollars or GB. See Spend documentation.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetStatusAtProvider
{
    /// <summary>The ID of the target account for budget. Will use current user's account_id by default if omitted.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>The ARN of the budget.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Object containing AutoAdjustData which determines the budget amount for an auto-adjusting budget.</summary>
    [JsonPropertyName("autoAdjustData")]
    public IList<V1beta1BudgetStatusAtProviderAutoAdjustData>? AutoAdjustData { get; set; }

    /// <summary>Whether this budget tracks monetary cost or usage.</summary>
    [JsonPropertyName("budgetType")]
    public string? BudgetType { get; set; }

    /// <summary>A list of CostFilter name/values pair to apply to budget.</summary>
    [JsonPropertyName("costFilter")]
    public IList<V1beta1BudgetStatusAtProviderCostFilter>? CostFilter { get; set; }

    /// <summary>Object containing CostTypes The types of cost included in a budget, such as tax and subscriptions.</summary>
    [JsonPropertyName("costTypes")]
    public IList<V1beta1BudgetStatusAtProviderCostTypes>? CostTypes { get; set; }

    /// <summary>id of resource.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The amount of cost or usage being measured for a budget.</summary>
    [JsonPropertyName("limitAmount")]
    public string? LimitAmount { get; set; }

    /// <summary>The unit of measurement used for the budget forecast, actual spend, or budget threshold, such as dollars or GB. See Spend documentation.</summary>
    [JsonPropertyName("limitUnit")]
    public string? LimitUnit { get; set; }

    /// <summary>Object containing Budget Notifications. Can be used multiple times to define more than one budget notification.</summary>
    [JsonPropertyName("notification")]
    public IList<V1beta1BudgetStatusAtProviderNotification>? Notification { get; set; }

    /// <summary>Object containing Planned Budget Limits. Can be used multiple times to plan more than one budget limit. See PlannedBudgetLimits documentation.</summary>
    [JsonPropertyName("plannedLimit")]
    public IList<V1beta1BudgetStatusAtProviderPlannedLimit>? PlannedLimit { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The end of the time period covered by the budget. There are no restrictions on the end date. Format: 2017-01-01_12:00.</summary>
    [JsonPropertyName("timePeriodEnd")]
    public string? TimePeriodEnd { get; set; }

    /// <summary>The start of the time period covered by the budget. If you don't specify a start date, AWS defaults to the start of your chosen time period. The start date must come before the end date. Format: 2017-01-01_12:00.</summary>
    [JsonPropertyName("timePeriodStart")]
    public string? TimePeriodStart { get; set; }

    /// <summary>The length of time until a budget resets the actual and forecasted spend. Valid values: MONTHLY, QUARTERLY, ANNUALLY, and DAILY.</summary>
    [JsonPropertyName("timeUnit")]
    public string? TimeUnit { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetStatusConditions
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

/// <summary>BudgetStatus defines the observed state of Budget.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1BudgetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BudgetStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Budget is the Schema for the Budgets API. Provides a budgets budget resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Budget : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BudgetSpec>, IStatus<V1beta1BudgetStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Budget";
    public const string KubeGroup = "budgets.aws.upbound.io";
    public const string KubePluralName = "budgets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BudgetSpec defines the desired state of Budget</summary>
    [JsonPropertyName("spec")]
    public V1beta1BudgetSpec Spec { get; set; }

    /// <summary>BudgetStatus defines the observed state of Budget.</summary>
    [JsonPropertyName("status")]
    public V1beta1BudgetStatus? Status { get; set; }
}

/// <summary>Budget is the Schema for the Budgets API. Provides a budgets budget resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BudgetList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Budget>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BudgetList";
    public const string KubeGroup = "budgets.aws.upbound.io";
    public const string KubePluralName = "budgets";
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
    public IList<V1beta1Budget> Items { get; set; }
}