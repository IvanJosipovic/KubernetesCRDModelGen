using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.consumption.azure.m.upbound.io;
#nullable enable
/// <summary>BudgetSubscription is the Schema for the BudgetSubscriptions API. Manages a Subscription Consumption Budget.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BudgetSubscriptionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1BudgetSubscription>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BudgetSubscriptionList";
    public const string KubeGroup = "consumption.azure.m.upbound.io";
    public const string KubePluralName = "budgetsubscriptions";
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
    public IList<V1beta1BudgetSubscription> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionSpecForProviderFilterDimensionValuesRefsPolicy
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
/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionSpecForProviderFilterDimensionValuesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BudgetSubscriptionSpecForProviderFilterDimensionValuesRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionSpecForProviderFilterDimensionValuesSelectorPolicy
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
/// <summary>Selector for a list of ResourceGroup in azure to populate values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionSpecForProviderFilterDimensionValuesSelector
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
    public V1beta1BudgetSubscriptionSpecForProviderFilterDimensionValuesSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionSpecForProviderFilterDimension
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

    /// <summary>References to ResourceGroup in azure to populate values.</summary>
    [JsonPropertyName("valuesRefs")]
    public IList<V1beta1BudgetSubscriptionSpecForProviderFilterDimensionValuesRefs>? ValuesRefs { get; set; }

    /// <summary>Selector for a list of ResourceGroup in azure to populate values.</summary>
    [JsonPropertyName("valuesSelector")]
    public V1beta1BudgetSubscriptionSpecForProviderFilterDimensionValuesSelector? ValuesSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionSpecForProviderFilterTag
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
#nullable disable

#nullable enable
/// <summary>A filter block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionSpecForProviderFilter
{
    /// <summary>One or more dimension blocks as defined below to filter the budget on.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1BudgetSubscriptionSpecForProviderFilterDimension>? Dimension { get; set; }

    /// <summary>One or more tag blocks as defined below to filter the budget on.</summary>
    [JsonPropertyName("tag")]
    public IList<V1beta1BudgetSubscriptionSpecForProviderFilterTag>? Tag { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionSpecForProviderNotificationContactGroupsRefsPolicy
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
/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionSpecForProviderNotificationContactGroupsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BudgetSubscriptionSpecForProviderNotificationContactGroupsRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionSpecForProviderNotificationContactGroupsSelectorPolicy
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
/// <summary>Selector for a list of MonitorActionGroup in insights to populate contactGroups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionSpecForProviderNotificationContactGroupsSelector
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
    public V1beta1BudgetSubscriptionSpecForProviderNotificationContactGroupsSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionSpecForProviderNotification
{
    /// <summary>Specifies a list of email addresses to send the budget notification to when the threshold is exceeded.</summary>
    [JsonPropertyName("contactEmails")]
    public IList<string>? ContactEmails { get; set; }

    /// <summary>Specifies a list of Action Group IDs to send the budget notification to when the threshold is exceeded.</summary>
    [JsonPropertyName("contactGroups")]
    public IList<string>? ContactGroups { get; set; }

    /// <summary>References to MonitorActionGroup in insights to populate contactGroups.</summary>
    [JsonPropertyName("contactGroupsRefs")]
    public IList<V1beta1BudgetSubscriptionSpecForProviderNotificationContactGroupsRefs>? ContactGroupsRefs { get; set; }

    /// <summary>Selector for a list of MonitorActionGroup in insights to populate contactGroups.</summary>
    [JsonPropertyName("contactGroupsSelector")]
    public V1beta1BudgetSubscriptionSpecForProviderNotificationContactGroupsSelector? ContactGroupsSelector { get; set; }

    /// <summary>Specifies a list of contact roles to send the budget notification to when the threshold is exceeded.</summary>
    [JsonPropertyName("contactRoles")]
    public IList<string>? ContactRoles { get; set; }

    /// <summary>Should the notification be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The comparison operator for the notification. Must be one of EqualTo, GreaterThan, or GreaterThanOrEqualTo.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Threshold value associated with a notification. Notification is sent when the cost exceeded the threshold. It is always percent and has to be between 0 and 1000.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>The type of threshold for the notification. This determines whether the notification is triggered by forecasted costs or actual costs. The allowed values are Actual and Forecasted. Default is Actual.</summary>
    [JsonPropertyName("thresholdType")]
    public string? ThresholdType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A time_period block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionSpecForProviderTimePeriod
{
    /// <summary>The end date for the budget. If not set this will be 10 years after the start date.</summary>
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    /// <summary>The start date for the budget. The start date must be first of the month and should be less than the end date. Budget start date must be on or after June 1, 2017. Future start date should not be more than twelve months. Past start date should be selected within the timegrain period. Changing this forces a new Subscription Consumption Budget to be created.</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionSpecForProvider
{
    /// <summary>The total amount of cost to track with the budget.</summary>
    [JsonPropertyName("amount")]
    public double? Amount { get; set; }

    /// <summary>The ETag of the Subscription Consumption Budget.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>A filter block as defined below.</summary>
    [JsonPropertyName("filter")]
    public V1beta1BudgetSubscriptionSpecForProviderFilter? Filter { get; set; }

    /// <summary>One or more notification blocks as defined below.</summary>
    [JsonPropertyName("notification")]
    public IList<V1beta1BudgetSubscriptionSpecForProviderNotification>? Notification { get; set; }

    /// <summary>The ID of the Subscription for which to create a Consumption Budget. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary>The time covered by a budget. Tracking of the amount will be reset based on the time grain. Must be one of BillingAnnual, BillingMonth, BillingQuarter, Annually, Monthly and Quarterly. Defaults to Monthly. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("timeGrain")]
    public string? TimeGrain { get; set; }

    /// <summary>A time_period block as defined below.</summary>
    [JsonPropertyName("timePeriod")]
    public V1beta1BudgetSubscriptionSpecForProviderTimePeriod? TimePeriod { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionSpecInitProviderFilterDimensionValuesRefsPolicy
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
/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionSpecInitProviderFilterDimensionValuesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BudgetSubscriptionSpecInitProviderFilterDimensionValuesRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionSpecInitProviderFilterDimensionValuesSelectorPolicy
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
/// <summary>Selector for a list of ResourceGroup in azure to populate values.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionSpecInitProviderFilterDimensionValuesSelector
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
    public V1beta1BudgetSubscriptionSpecInitProviderFilterDimensionValuesSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionSpecInitProviderFilterDimension
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

    /// <summary>References to ResourceGroup in azure to populate values.</summary>
    [JsonPropertyName("valuesRefs")]
    public IList<V1beta1BudgetSubscriptionSpecInitProviderFilterDimensionValuesRefs>? ValuesRefs { get; set; }

    /// <summary>Selector for a list of ResourceGroup in azure to populate values.</summary>
    [JsonPropertyName("valuesSelector")]
    public V1beta1BudgetSubscriptionSpecInitProviderFilterDimensionValuesSelector? ValuesSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionSpecInitProviderFilterTag
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
#nullable disable

#nullable enable
/// <summary>A filter block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionSpecInitProviderFilter
{
    /// <summary>One or more dimension blocks as defined below to filter the budget on.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1BudgetSubscriptionSpecInitProviderFilterDimension>? Dimension { get; set; }

    /// <summary>One or more tag blocks as defined below to filter the budget on.</summary>
    [JsonPropertyName("tag")]
    public IList<V1beta1BudgetSubscriptionSpecInitProviderFilterTag>? Tag { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionSpecInitProviderNotificationContactGroupsRefsPolicy
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
/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionSpecInitProviderNotificationContactGroupsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BudgetSubscriptionSpecInitProviderNotificationContactGroupsRefsPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionSpecInitProviderNotificationContactGroupsSelectorPolicy
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
/// <summary>Selector for a list of MonitorActionGroup in insights to populate contactGroups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionSpecInitProviderNotificationContactGroupsSelector
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
    public V1beta1BudgetSubscriptionSpecInitProviderNotificationContactGroupsSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionSpecInitProviderNotification
{
    /// <summary>Specifies a list of email addresses to send the budget notification to when the threshold is exceeded.</summary>
    [JsonPropertyName("contactEmails")]
    public IList<string>? ContactEmails { get; set; }

    /// <summary>Specifies a list of Action Group IDs to send the budget notification to when the threshold is exceeded.</summary>
    [JsonPropertyName("contactGroups")]
    public IList<string>? ContactGroups { get; set; }

    /// <summary>References to MonitorActionGroup in insights to populate contactGroups.</summary>
    [JsonPropertyName("contactGroupsRefs")]
    public IList<V1beta1BudgetSubscriptionSpecInitProviderNotificationContactGroupsRefs>? ContactGroupsRefs { get; set; }

    /// <summary>Selector for a list of MonitorActionGroup in insights to populate contactGroups.</summary>
    [JsonPropertyName("contactGroupsSelector")]
    public V1beta1BudgetSubscriptionSpecInitProviderNotificationContactGroupsSelector? ContactGroupsSelector { get; set; }

    /// <summary>Specifies a list of contact roles to send the budget notification to when the threshold is exceeded.</summary>
    [JsonPropertyName("contactRoles")]
    public IList<string>? ContactRoles { get; set; }

    /// <summary>Should the notification be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The comparison operator for the notification. Must be one of EqualTo, GreaterThan, or GreaterThanOrEqualTo.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Threshold value associated with a notification. Notification is sent when the cost exceeded the threshold. It is always percent and has to be between 0 and 1000.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>The type of threshold for the notification. This determines whether the notification is triggered by forecasted costs or actual costs. The allowed values are Actual and Forecasted. Default is Actual.</summary>
    [JsonPropertyName("thresholdType")]
    public string? ThresholdType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A time_period block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionSpecInitProviderTimePeriod
{
    /// <summary>The end date for the budget. If not set this will be 10 years after the start date.</summary>
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    /// <summary>The start date for the budget. The start date must be first of the month and should be less than the end date. Budget start date must be on or after June 1, 2017. Future start date should not be more than twelve months. Past start date should be selected within the timegrain period. Changing this forces a new Subscription Consumption Budget to be created.</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionSpecInitProvider
{
    /// <summary>The total amount of cost to track with the budget.</summary>
    [JsonPropertyName("amount")]
    public double? Amount { get; set; }

    /// <summary>The ETag of the Subscription Consumption Budget.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>A filter block as defined below.</summary>
    [JsonPropertyName("filter")]
    public V1beta1BudgetSubscriptionSpecInitProviderFilter? Filter { get; set; }

    /// <summary>One or more notification blocks as defined below.</summary>
    [JsonPropertyName("notification")]
    public IList<V1beta1BudgetSubscriptionSpecInitProviderNotification>? Notification { get; set; }

    /// <summary>The ID of the Subscription for which to create a Consumption Budget. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary>The time covered by a budget. Tracking of the amount will be reset based on the time grain. Must be one of BillingAnnual, BillingMonth, BillingQuarter, Annually, Monthly and Quarterly. Defaults to Monthly. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("timeGrain")]
    public string? TimeGrain { get; set; }

    /// <summary>A time_period block as defined below.</summary>
    [JsonPropertyName("timePeriod")]
    public V1beta1BudgetSubscriptionSpecInitProviderTimePeriod? TimePeriod { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>BudgetSubscriptionSpec defines the desired state of BudgetSubscription</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1BudgetSubscriptionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1BudgetSubscriptionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BudgetSubscriptionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BudgetSubscriptionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionStatusAtProviderFilterDimension
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionStatusAtProviderFilterTag
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
#nullable disable

#nullable enable
/// <summary>A filter block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionStatusAtProviderFilter
{
    /// <summary>One or more dimension blocks as defined below to filter the budget on.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1BudgetSubscriptionStatusAtProviderFilterDimension>? Dimension { get; set; }

    /// <summary>One or more tag blocks as defined below to filter the budget on.</summary>
    [JsonPropertyName("tag")]
    public IList<V1beta1BudgetSubscriptionStatusAtProviderFilterTag>? Tag { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionStatusAtProviderNotification
{
    /// <summary>Specifies a list of email addresses to send the budget notification to when the threshold is exceeded.</summary>
    [JsonPropertyName("contactEmails")]
    public IList<string>? ContactEmails { get; set; }

    /// <summary>Specifies a list of Action Group IDs to send the budget notification to when the threshold is exceeded.</summary>
    [JsonPropertyName("contactGroups")]
    public IList<string>? ContactGroups { get; set; }

    /// <summary>Specifies a list of contact roles to send the budget notification to when the threshold is exceeded.</summary>
    [JsonPropertyName("contactRoles")]
    public IList<string>? ContactRoles { get; set; }

    /// <summary>Should the notification be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The comparison operator for the notification. Must be one of EqualTo, GreaterThan, or GreaterThanOrEqualTo.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Threshold value associated with a notification. Notification is sent when the cost exceeded the threshold. It is always percent and has to be between 0 and 1000.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>The type of threshold for the notification. This determines whether the notification is triggered by forecasted costs or actual costs. The allowed values are Actual and Forecasted. Default is Actual.</summary>
    [JsonPropertyName("thresholdType")]
    public string? ThresholdType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A time_period block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionStatusAtProviderTimePeriod
{
    /// <summary>The end date for the budget. If not set this will be 10 years after the start date.</summary>
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    /// <summary>The start date for the budget. The start date must be first of the month and should be less than the end date. Budget start date must be on or after June 1, 2017. Future start date should not be more than twelve months. Past start date should be selected within the timegrain period. Changing this forces a new Subscription Consumption Budget to be created.</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionStatusAtProvider
{
    /// <summary>The total amount of cost to track with the budget.</summary>
    [JsonPropertyName("amount")]
    public double? Amount { get; set; }

    /// <summary>The ETag of the Subscription Consumption Budget.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>A filter block as defined below.</summary>
    [JsonPropertyName("filter")]
    public V1beta1BudgetSubscriptionStatusAtProviderFilter? Filter { get; set; }

    /// <summary>The ID of the Subscription Consumption Budget.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>One or more notification blocks as defined below.</summary>
    [JsonPropertyName("notification")]
    public IList<V1beta1BudgetSubscriptionStatusAtProviderNotification>? Notification { get; set; }

    /// <summary>The ID of the Subscription for which to create a Consumption Budget. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subscriptionId")]
    public string? SubscriptionId { get; set; }

    /// <summary>The time covered by a budget. Tracking of the amount will be reset based on the time grain. Must be one of BillingAnnual, BillingMonth, BillingQuarter, Annually, Monthly and Quarterly. Defaults to Monthly. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("timeGrain")]
    public string? TimeGrain { get; set; }

    /// <summary>A time_period block as defined below.</summary>
    [JsonPropertyName("timePeriod")]
    public V1beta1BudgetSubscriptionStatusAtProviderTimePeriod? TimePeriod { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionStatusConditions
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
/// <summary>BudgetSubscriptionStatus defines the observed state of BudgetSubscription.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetSubscriptionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1BudgetSubscriptionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BudgetSubscriptionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>BudgetSubscription is the Schema for the BudgetSubscriptions API. Manages a Subscription Consumption Budget.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BudgetSubscription : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BudgetSubscriptionSpec>, IStatus<V1beta1BudgetSubscriptionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BudgetSubscription";
    public const string KubeGroup = "consumption.azure.m.upbound.io";
    public const string KubePluralName = "budgetsubscriptions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BudgetSubscriptionSpec defines the desired state of BudgetSubscription</summary>
    [JsonPropertyName("spec")]
    public V1beta1BudgetSubscriptionSpec Spec { get; set; }

    /// <summary>BudgetSubscriptionStatus defines the observed state of BudgetSubscription.</summary>
    [JsonPropertyName("status")]
    public V1beta1BudgetSubscriptionStatus? Status { get; set; }
}
#nullable disable
