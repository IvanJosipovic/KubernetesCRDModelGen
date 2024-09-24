using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.consumption.azure.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BudgetResourceGroupSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecForProviderFilterDimension
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecForProviderFilterNotDimension
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecForProviderFilterNotTag
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecForProviderFilterNot
{
    /// <summary>One dimension block as defined below to filter the budget on. Conflicts with tag.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1BudgetResourceGroupSpecForProviderFilterNotDimension>? Dimension { get; set; }

    /// <summary>One tag block as defined below to filter the budget on. Conflicts with dimension.</summary>
    [JsonPropertyName("tag")]
    public IList<V1beta1BudgetResourceGroupSpecForProviderFilterNotTag>? Tag { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecForProviderFilterTag
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecForProviderFilter
{
    /// <summary>One or more dimension blocks as defined below to filter the budget on.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1BudgetResourceGroupSpecForProviderFilterDimension>? Dimension { get; set; }

    /// <summary>A not block as defined below to filter the budget on. This is deprecated as the API no longer supports it and will be removed in version 4.0 of the provider.</summary>
    [JsonPropertyName("not")]
    public IList<V1beta1BudgetResourceGroupSpecForProviderFilterNot>? Not { get; set; }

    /// <summary>One or more tag blocks as defined below to filter the budget on.</summary>
    [JsonPropertyName("tag")]
    public IList<V1beta1BudgetResourceGroupSpecForProviderFilterTag>? Tag { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecForProviderNotification
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

    /// <summary>The type of threshold for the notification. This determines whether the notification is triggered by forecasted costs or actual costs. The allowed values are Actual and Forecasted. Default is Actual. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("thresholdType")]
    public string? ThresholdType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BudgetResourceGroupSpecForProviderResourceGroupIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BudgetResourceGroupSpecForProviderResourceGroupIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecForProviderResourceGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BudgetResourceGroupSpecForProviderResourceGroupIdRefPolicyResolutionEnum>))]
    public V1beta1BudgetResourceGroupSpecForProviderResourceGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BudgetResourceGroupSpecForProviderResourceGroupIdRefPolicyResolveEnum>))]
    public V1beta1BudgetResourceGroupSpecForProviderResourceGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecForProviderResourceGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BudgetResourceGroupSpecForProviderResourceGroupIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BudgetResourceGroupSpecForProviderResourceGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BudgetResourceGroupSpecForProviderResourceGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecForProviderResourceGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BudgetResourceGroupSpecForProviderResourceGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1BudgetResourceGroupSpecForProviderResourceGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BudgetResourceGroupSpecForProviderResourceGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1BudgetResourceGroupSpecForProviderResourceGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecForProviderResourceGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BudgetResourceGroupSpecForProviderResourceGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecForProviderTimePeriod
{
    /// <summary>The end date for the budget. If not set this will be 10 years after the start date.</summary>
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    /// <summary>The start date for the budget. The start date must be first of the month and should be less than the end date. Budget start date must be on or after June 1, 2017. Future start date should not be more than twelve months. Past start date should be selected within the timegrain period. Changing this forces a new Resource Group Consumption Budget to be created.</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecForProvider
{
    /// <summary>The total amount of cost to track with the budget.</summary>
    [JsonPropertyName("amount")]
    public double? Amount { get; set; }

    /// <summary>The ETag of the Resource Group Consumption Budget</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>A filter block as defined below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1BudgetResourceGroupSpecForProviderFilter>? Filter { get; set; }

    /// <summary>The name which should be used for this Resource Group Consumption Budget. Changing this forces a new Resource Group Consumption Budget to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more notification blocks as defined below.</summary>
    [JsonPropertyName("notification")]
    public IList<V1beta1BudgetResourceGroupSpecForProviderNotification>? Notification { get; set; }

    /// <summary>The ID of the Resource Group to create the consumption budget for in the form of /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/resourceGroup1. Changing this forces a new Resource Group Consumption Budget to be created.</summary>
    [JsonPropertyName("resourceGroupId")]
    public string? ResourceGroupId { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupId.</summary>
    [JsonPropertyName("resourceGroupIdRef")]
    public V1beta1BudgetResourceGroupSpecForProviderResourceGroupIdRef? ResourceGroupIdRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupId.</summary>
    [JsonPropertyName("resourceGroupIdSelector")]
    public V1beta1BudgetResourceGroupSpecForProviderResourceGroupIdSelector? ResourceGroupIdSelector { get; set; }

    /// <summary>The time covered by a budget. Tracking of the amount will be reset based on the time grain. Must be one of BillingAnnual, BillingMonth, BillingQuarter, Annually, Monthly and Quarterly. Defaults to Monthly. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("timeGrain")]
    public string? TimeGrain { get; set; }

    /// <summary>A time_period block as defined below.</summary>
    [JsonPropertyName("timePeriod")]
    public IList<V1beta1BudgetResourceGroupSpecForProviderTimePeriod>? TimePeriod { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecInitProviderFilterDimension
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecInitProviderFilterNotDimension
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecInitProviderFilterNotTag
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecInitProviderFilterNot
{
    /// <summary>One dimension block as defined below to filter the budget on. Conflicts with tag.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1BudgetResourceGroupSpecInitProviderFilterNotDimension>? Dimension { get; set; }

    /// <summary>One tag block as defined below to filter the budget on. Conflicts with dimension.</summary>
    [JsonPropertyName("tag")]
    public IList<V1beta1BudgetResourceGroupSpecInitProviderFilterNotTag>? Tag { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecInitProviderFilterTag
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecInitProviderFilter
{
    /// <summary>One or more dimension blocks as defined below to filter the budget on.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1BudgetResourceGroupSpecInitProviderFilterDimension>? Dimension { get; set; }

    /// <summary>A not block as defined below to filter the budget on. This is deprecated as the API no longer supports it and will be removed in version 4.0 of the provider.</summary>
    [JsonPropertyName("not")]
    public IList<V1beta1BudgetResourceGroupSpecInitProviderFilterNot>? Not { get; set; }

    /// <summary>One or more tag blocks as defined below to filter the budget on.</summary>
    [JsonPropertyName("tag")]
    public IList<V1beta1BudgetResourceGroupSpecInitProviderFilterTag>? Tag { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecInitProviderNotification
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

    /// <summary>The type of threshold for the notification. This determines whether the notification is triggered by forecasted costs or actual costs. The allowed values are Actual and Forecasted. Default is Actual. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("thresholdType")]
    public string? ThresholdType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BudgetResourceGroupSpecInitProviderResourceGroupIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BudgetResourceGroupSpecInitProviderResourceGroupIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecInitProviderResourceGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BudgetResourceGroupSpecInitProviderResourceGroupIdRefPolicyResolutionEnum>))]
    public V1beta1BudgetResourceGroupSpecInitProviderResourceGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BudgetResourceGroupSpecInitProviderResourceGroupIdRefPolicyResolveEnum>))]
    public V1beta1BudgetResourceGroupSpecInitProviderResourceGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecInitProviderResourceGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BudgetResourceGroupSpecInitProviderResourceGroupIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BudgetResourceGroupSpecInitProviderResourceGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BudgetResourceGroupSpecInitProviderResourceGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecInitProviderResourceGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BudgetResourceGroupSpecInitProviderResourceGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1BudgetResourceGroupSpecInitProviderResourceGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BudgetResourceGroupSpecInitProviderResourceGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1BudgetResourceGroupSpecInitProviderResourceGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecInitProviderResourceGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BudgetResourceGroupSpecInitProviderResourceGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecInitProviderTimePeriod
{
    /// <summary>The end date for the budget. If not set this will be 10 years after the start date.</summary>
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    /// <summary>The start date for the budget. The start date must be first of the month and should be less than the end date. Budget start date must be on or after June 1, 2017. Future start date should not be more than twelve months. Past start date should be selected within the timegrain period. Changing this forces a new Resource Group Consumption Budget to be created.</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecInitProvider
{
    /// <summary>The total amount of cost to track with the budget.</summary>
    [JsonPropertyName("amount")]
    public double? Amount { get; set; }

    /// <summary>The ETag of the Resource Group Consumption Budget</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>A filter block as defined below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1BudgetResourceGroupSpecInitProviderFilter>? Filter { get; set; }

    /// <summary>The name which should be used for this Resource Group Consumption Budget. Changing this forces a new Resource Group Consumption Budget to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more notification blocks as defined below.</summary>
    [JsonPropertyName("notification")]
    public IList<V1beta1BudgetResourceGroupSpecInitProviderNotification>? Notification { get; set; }

    /// <summary>The ID of the Resource Group to create the consumption budget for in the form of /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/resourceGroup1. Changing this forces a new Resource Group Consumption Budget to be created.</summary>
    [JsonPropertyName("resourceGroupId")]
    public string? ResourceGroupId { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupId.</summary>
    [JsonPropertyName("resourceGroupIdRef")]
    public V1beta1BudgetResourceGroupSpecInitProviderResourceGroupIdRef? ResourceGroupIdRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupId.</summary>
    [JsonPropertyName("resourceGroupIdSelector")]
    public V1beta1BudgetResourceGroupSpecInitProviderResourceGroupIdSelector? ResourceGroupIdSelector { get; set; }

    /// <summary>The time covered by a budget. Tracking of the amount will be reset based on the time grain. Must be one of BillingAnnual, BillingMonth, BillingQuarter, Annually, Monthly and Quarterly. Defaults to Monthly. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("timeGrain")]
    public string? TimeGrain { get; set; }

    /// <summary>A time_period block as defined below.</summary>
    [JsonPropertyName("timePeriod")]
    public IList<V1beta1BudgetResourceGroupSpecInitProviderTimePeriod>? TimePeriod { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BudgetResourceGroupSpecManagementPoliciesEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BudgetResourceGroupSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BudgetResourceGroupSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BudgetResourceGroupSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1BudgetResourceGroupSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BudgetResourceGroupSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1BudgetResourceGroupSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BudgetResourceGroupSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BudgetResourceGroupSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BudgetResourceGroupSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BudgetResourceGroupSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1BudgetResourceGroupSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BudgetResourceGroupSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1BudgetResourceGroupSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BudgetResourceGroupSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1BudgetResourceGroupSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1BudgetResourceGroupSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1BudgetResourceGroupSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>BudgetResourceGroupSpec defines the desired state of BudgetResourceGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BudgetResourceGroupSpecDeletionPolicyEnum>))]
    public V1beta1BudgetResourceGroupSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1BudgetResourceGroupSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1BudgetResourceGroupSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1BudgetResourceGroupSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BudgetResourceGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1BudgetResourceGroupSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BudgetResourceGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupStatusAtProviderFilterDimension
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupStatusAtProviderFilterNotDimension
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupStatusAtProviderFilterNotTag
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupStatusAtProviderFilterNot
{
    /// <summary>One dimension block as defined below to filter the budget on. Conflicts with tag.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1BudgetResourceGroupStatusAtProviderFilterNotDimension>? Dimension { get; set; }

    /// <summary>One tag block as defined below to filter the budget on. Conflicts with dimension.</summary>
    [JsonPropertyName("tag")]
    public IList<V1beta1BudgetResourceGroupStatusAtProviderFilterNotTag>? Tag { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupStatusAtProviderFilterTag
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupStatusAtProviderFilter
{
    /// <summary>One or more dimension blocks as defined below to filter the budget on.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1BudgetResourceGroupStatusAtProviderFilterDimension>? Dimension { get; set; }

    /// <summary>A not block as defined below to filter the budget on. This is deprecated as the API no longer supports it and will be removed in version 4.0 of the provider.</summary>
    [JsonPropertyName("not")]
    public IList<V1beta1BudgetResourceGroupStatusAtProviderFilterNot>? Not { get; set; }

    /// <summary>One or more tag blocks as defined below to filter the budget on.</summary>
    [JsonPropertyName("tag")]
    public IList<V1beta1BudgetResourceGroupStatusAtProviderFilterTag>? Tag { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupStatusAtProviderNotification
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

    /// <summary>The type of threshold for the notification. This determines whether the notification is triggered by forecasted costs or actual costs. The allowed values are Actual and Forecasted. Default is Actual. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("thresholdType")]
    public string? ThresholdType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupStatusAtProviderTimePeriod
{
    /// <summary>The end date for the budget. If not set this will be 10 years after the start date.</summary>
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    /// <summary>The start date for the budget. The start date must be first of the month and should be less than the end date. Budget start date must be on or after June 1, 2017. Future start date should not be more than twelve months. Past start date should be selected within the timegrain period. Changing this forces a new Resource Group Consumption Budget to be created.</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupStatusAtProvider
{
    /// <summary>The total amount of cost to track with the budget.</summary>
    [JsonPropertyName("amount")]
    public double? Amount { get; set; }

    /// <summary>The ETag of the Resource Group Consumption Budget</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>A filter block as defined below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1BudgetResourceGroupStatusAtProviderFilter>? Filter { get; set; }

    /// <summary>The ID of the Resource Group Consumption Budget.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name which should be used for this Resource Group Consumption Budget. Changing this forces a new Resource Group Consumption Budget to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>One or more notification blocks as defined below.</summary>
    [JsonPropertyName("notification")]
    public IList<V1beta1BudgetResourceGroupStatusAtProviderNotification>? Notification { get; set; }

    /// <summary>The ID of the Resource Group to create the consumption budget for in the form of /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/resourceGroup1. Changing this forces a new Resource Group Consumption Budget to be created.</summary>
    [JsonPropertyName("resourceGroupId")]
    public string? ResourceGroupId { get; set; }

    /// <summary>The time covered by a budget. Tracking of the amount will be reset based on the time grain. Must be one of BillingAnnual, BillingMonth, BillingQuarter, Annually, Monthly and Quarterly. Defaults to Monthly. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("timeGrain")]
    public string? TimeGrain { get; set; }

    /// <summary>A time_period block as defined below.</summary>
    [JsonPropertyName("timePeriod")]
    public IList<V1beta1BudgetResourceGroupStatusAtProviderTimePeriod>? TimePeriod { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupStatusConditions
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

/// <summary>BudgetResourceGroupStatus defines the observed state of BudgetResourceGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BudgetResourceGroupStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1BudgetResourceGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BudgetResourceGroupStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>BudgetResourceGroup is the Schema for the BudgetResourceGroups API. Manages a Resource Group Consumption Budget.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BudgetResourceGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BudgetResourceGroupSpec>, IStatus<V1beta1BudgetResourceGroupStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BudgetResourceGroup";
    public const string KubeGroup = "consumption.azure.upbound.io";
    public const string KubePluralName = "budgetresourcegroups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BudgetResourceGroupSpec defines the desired state of BudgetResourceGroup</summary>
    [JsonPropertyName("spec")]
    public V1beta1BudgetResourceGroupSpec Spec { get; set; }

    /// <summary>BudgetResourceGroupStatus defines the observed state of BudgetResourceGroup.</summary>
    [JsonPropertyName("status")]
    public V1beta1BudgetResourceGroupStatus? Status { get; set; }
}