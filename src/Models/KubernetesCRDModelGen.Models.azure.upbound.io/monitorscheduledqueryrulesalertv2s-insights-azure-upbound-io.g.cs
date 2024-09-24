using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.insights.azure.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorScheduledQueryRulesAlertV2SpecDeletionPolicyEnum
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
public partial class V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderAction
{
    /// <summary>List of Action Group resource IDs to invoke when the alert fires.</summary>
    [JsonPropertyName("actionGroups")]
    public IList<string>? ActionGroups { get; set; }

    /// <summary>Specifies the properties of an alert payload.</summary>
    [JsonPropertyName("customProperties")]
    public IDictionary<string, string>? CustomProperties { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderCriteriaDimension
{
    /// <summary>Specifies the name which should be used for this Monitor Scheduled Query Rule. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Operator for dimension values. Possible values are Exclude,and Include.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>List of dimension values. Use a wildcard * to collect all.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderCriteriaFailingPeriods
{
    /// <summary>Specifies the number of violations to trigger an alert. Should be smaller or equal to number_of_evaluation_periods. Possible value is integer between 1 and 6.</summary>
    [JsonPropertyName("minimumFailingPeriodsToTriggerAlert")]
    public double? MinimumFailingPeriodsToTriggerAlert { get; set; }

    /// <summary>Specifies the number of aggregated look-back points. The look-back time window is calculated based on the aggregation granularity window_duration and the selected number of aggregated points. Possible value is integer between 1 and 6.</summary>
    [JsonPropertyName("numberOfEvaluationPeriods")]
    public double? NumberOfEvaluationPeriods { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderCriteria
{
    /// <summary>A dimension block as defined below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderCriteriaDimension>? Dimension { get; set; }

    /// <summary>A failing_periods block as defined below.</summary>
    [JsonPropertyName("failingPeriods")]
    public IList<V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderCriteriaFailingPeriods>? FailingPeriods { get; set; }

    /// <summary>Specifies the column containing the metric measure number.</summary>
    [JsonPropertyName("metricMeasureColumn")]
    public string? MetricMeasureColumn { get; set; }

    /// <summary>Specifies the criteria operator. Possible values are Equal, GreaterThan, GreaterThanOrEqual, LessThan,and LessThanOrEqual.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The query to run on logs. The results returned by this query are used to populate the alert.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>Specifies the column containing the resource ID. The content of the column must be an uri formatted as resource ID.</summary>
    [JsonPropertyName("resourceIdColumn")]
    public string? ResourceIdColumn { get; set; }

    /// <summary>Specifies the criteria threshold value that activates the alert.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>The type of aggregation to apply to the data points in aggregation granularity. Possible values are Average, Count, Maximum, Minimum,and Total.</summary>
    [JsonPropertyName("timeAggregationMethod")]
    public string? TimeAggregationMethod { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderResourceGroupNameRefPolicyResolveEnum
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
public partial class V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderResourceGroupNameSelectorPolicyResolveEnum
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
public partial class V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderScopesRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderScopesRefsPolicyResolveEnum
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
public partial class V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderScopesRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderScopesRefsPolicyResolutionEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderScopesRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderScopesRefsPolicyResolveEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderScopesRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderScopesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderScopesRefsPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderScopesSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderScopesSelectorPolicyResolveEnum
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
public partial class V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderScopesSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderScopesSelectorPolicyResolutionEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderScopesSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderScopesSelectorPolicyResolveEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderScopesSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of ApplicationInsights in insights to populate scopes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderScopesSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderScopesSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertV2SpecForProvider
{
    /// <summary>An action block as defined below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderAction>? Action { get; set; }

    /// <summary>Specifies the flag that indicates whether the alert should be automatically resolved or not. Value should be true or false. The default is false.</summary>
    [JsonPropertyName("autoMitigationEnabled")]
    public bool? AutoMitigationEnabled { get; set; }

    /// <summary>A criteria block as defined below.</summary>
    [JsonPropertyName("criteria")]
    public IList<V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderCriteria>? Criteria { get; set; }

    /// <summary>Specifies the description of the scheduled query rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies the display name of the alert rule.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Specifies the flag which indicates whether this scheduled query rule is enabled. Value should be true or false. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>How often the scheduled query rule is evaluated, represented in ISO 8601 duration format. Possible values are PT1M, PT5M, PT10M, PT15M, PT30M, PT45M, PT1H, PT2H, PT3H, PT4H, PT5H, PT6H, P1D.</summary>
    [JsonPropertyName("evaluationFrequency")]
    public string? EvaluationFrequency { get; set; }

    /// <summary>Specifies the Azure Region where the Monitor Scheduled Query Rule should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Mute actions for the chosen period of time in ISO 8601 duration format after the alert is fired. Possible values are PT5M, PT10M, PT15M, PT30M, PT45M, PT1H, PT2H, PT3H, PT4H, PT5H, PT6H, P1D and P2D.</summary>
    [JsonPropertyName("muteActionsAfterAlertDuration")]
    public string? MuteActionsAfterAlertDuration { get; set; }

    /// <summary>Set this if the alert evaluation period is different from the query time range. If not specified, the value is window_duration*number_of_evaluation_periods. Possible values are PT5M, PT10M, PT15M, PT20M, PT30M, PT45M, PT1H, PT2H, PT3H, PT4H, PT5H, PT6H, P1D and P2D.</summary>
    [JsonPropertyName("queryTimeRangeOverride")]
    public string? QueryTimeRangeOverride { get; set; }

    /// <summary>Specifies the name of the Resource Group where the Monitor Scheduled Query Rule should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Specifies the list of resource IDs that this scheduled query rule is scoped to. Changing this forces a new resource to be created. Currently, the API supports exactly 1 resource ID in the scopes list.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>References to ApplicationInsights in insights to populate scopes.</summary>
    [JsonPropertyName("scopesRefs")]
    public IList<V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderScopesRefs>? ScopesRefs { get; set; }

    /// <summary>Selector for a list of ApplicationInsights in insights to populate scopes.</summary>
    [JsonPropertyName("scopesSelector")]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecForProviderScopesSelector? ScopesSelector { get; set; }

    /// <summary>Severity of the alert. Should be an integer between 0 and 4. Value of 0 is severest.</summary>
    [JsonPropertyName("severity")]
    public double? Severity { get; set; }

    /// <summary>Specifies the flag which indicates whether the provided query should be validated or not. The default is false.</summary>
    [JsonPropertyName("skipQueryValidation")]
    public bool? SkipQueryValidation { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Monitor Scheduled Query Rule.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>List of resource type of the target resource(s) on which the alert is created/updated. For example if the scope is a resource group and targetResourceTypes is Microsoft.Compute/virtualMachines, then a different alert will be fired for each virtual machine in the resource group which meet the alert criteria.</summary>
    [JsonPropertyName("targetResourceTypes")]
    public IList<string>? TargetResourceTypes { get; set; }

    /// <summary>Specifies the period of time in ISO 8601 duration format on which the Scheduled Query Rule will be executed (bin size). If evaluation_frequency is PT1M, possible values are PT1M, PT5M, PT10M, PT15M, PT30M, PT45M, PT1H, PT2H, PT3H, PT4H, PT5H, and PT6H. Otherwise, possible values are PT5M, PT10M, PT15M, PT30M, PT45M, PT1H, PT2H, PT3H, PT4H, PT5H, PT6H, P1D, and P2D.</summary>
    [JsonPropertyName("windowDuration")]
    public string? WindowDuration { get; set; }

    /// <summary>Specifies the flag which indicates whether this scheduled query rule check if storage is configured. Value should be true or false. The default is false.</summary>
    [JsonPropertyName("workspaceAlertsStorageEnabled")]
    public bool? WorkspaceAlertsStorageEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertV2SpecInitProviderAction
{
    /// <summary>List of Action Group resource IDs to invoke when the alert fires.</summary>
    [JsonPropertyName("actionGroups")]
    public IList<string>? ActionGroups { get; set; }

    /// <summary>Specifies the properties of an alert payload.</summary>
    [JsonPropertyName("customProperties")]
    public IDictionary<string, string>? CustomProperties { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertV2SpecInitProviderCriteriaDimension
{
    /// <summary>Specifies the name which should be used for this Monitor Scheduled Query Rule. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Operator for dimension values. Possible values are Exclude,and Include.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>List of dimension values. Use a wildcard * to collect all.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertV2SpecInitProviderCriteriaFailingPeriods
{
    /// <summary>Specifies the number of violations to trigger an alert. Should be smaller or equal to number_of_evaluation_periods. Possible value is integer between 1 and 6.</summary>
    [JsonPropertyName("minimumFailingPeriodsToTriggerAlert")]
    public double? MinimumFailingPeriodsToTriggerAlert { get; set; }

    /// <summary>Specifies the number of aggregated look-back points. The look-back time window is calculated based on the aggregation granularity window_duration and the selected number of aggregated points. Possible value is integer between 1 and 6.</summary>
    [JsonPropertyName("numberOfEvaluationPeriods")]
    public double? NumberOfEvaluationPeriods { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertV2SpecInitProviderCriteria
{
    /// <summary>A dimension block as defined below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1MonitorScheduledQueryRulesAlertV2SpecInitProviderCriteriaDimension>? Dimension { get; set; }

    /// <summary>A failing_periods block as defined below.</summary>
    [JsonPropertyName("failingPeriods")]
    public IList<V1beta1MonitorScheduledQueryRulesAlertV2SpecInitProviderCriteriaFailingPeriods>? FailingPeriods { get; set; }

    /// <summary>Specifies the column containing the metric measure number.</summary>
    [JsonPropertyName("metricMeasureColumn")]
    public string? MetricMeasureColumn { get; set; }

    /// <summary>Specifies the criteria operator. Possible values are Equal, GreaterThan, GreaterThanOrEqual, LessThan,and LessThanOrEqual.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The query to run on logs. The results returned by this query are used to populate the alert.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>Specifies the column containing the resource ID. The content of the column must be an uri formatted as resource ID.</summary>
    [JsonPropertyName("resourceIdColumn")]
    public string? ResourceIdColumn { get; set; }

    /// <summary>Specifies the criteria threshold value that activates the alert.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>The type of aggregation to apply to the data points in aggregation granularity. Possible values are Average, Count, Maximum, Minimum,and Total.</summary>
    [JsonPropertyName("timeAggregationMethod")]
    public string? TimeAggregationMethod { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorScheduledQueryRulesAlertV2SpecInitProviderScopesRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorScheduledQueryRulesAlertV2SpecInitProviderScopesRefsPolicyResolveEnum
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
public partial class V1beta1MonitorScheduledQueryRulesAlertV2SpecInitProviderScopesRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertV2SpecInitProviderScopesRefsPolicyResolutionEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecInitProviderScopesRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertV2SpecInitProviderScopesRefsPolicyResolveEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecInitProviderScopesRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertV2SpecInitProviderScopesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecInitProviderScopesRefsPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorScheduledQueryRulesAlertV2SpecInitProviderScopesSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorScheduledQueryRulesAlertV2SpecInitProviderScopesSelectorPolicyResolveEnum
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
public partial class V1beta1MonitorScheduledQueryRulesAlertV2SpecInitProviderScopesSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertV2SpecInitProviderScopesSelectorPolicyResolutionEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecInitProviderScopesSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertV2SpecInitProviderScopesSelectorPolicyResolveEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecInitProviderScopesSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of ApplicationInsights in insights to populate scopes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertV2SpecInitProviderScopesSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecInitProviderScopesSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertV2SpecInitProvider
{
    /// <summary>An action block as defined below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1MonitorScheduledQueryRulesAlertV2SpecInitProviderAction>? Action { get; set; }

    /// <summary>Specifies the flag that indicates whether the alert should be automatically resolved or not. Value should be true or false. The default is false.</summary>
    [JsonPropertyName("autoMitigationEnabled")]
    public bool? AutoMitigationEnabled { get; set; }

    /// <summary>A criteria block as defined below.</summary>
    [JsonPropertyName("criteria")]
    public IList<V1beta1MonitorScheduledQueryRulesAlertV2SpecInitProviderCriteria>? Criteria { get; set; }

    /// <summary>Specifies the description of the scheduled query rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies the display name of the alert rule.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Specifies the flag which indicates whether this scheduled query rule is enabled. Value should be true or false. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>How often the scheduled query rule is evaluated, represented in ISO 8601 duration format. Possible values are PT1M, PT5M, PT10M, PT15M, PT30M, PT45M, PT1H, PT2H, PT3H, PT4H, PT5H, PT6H, P1D.</summary>
    [JsonPropertyName("evaluationFrequency")]
    public string? EvaluationFrequency { get; set; }

    /// <summary>Specifies the Azure Region where the Monitor Scheduled Query Rule should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Mute actions for the chosen period of time in ISO 8601 duration format after the alert is fired. Possible values are PT5M, PT10M, PT15M, PT30M, PT45M, PT1H, PT2H, PT3H, PT4H, PT5H, PT6H, P1D and P2D.</summary>
    [JsonPropertyName("muteActionsAfterAlertDuration")]
    public string? MuteActionsAfterAlertDuration { get; set; }

    /// <summary>Set this if the alert evaluation period is different from the query time range. If not specified, the value is window_duration*number_of_evaluation_periods. Possible values are PT5M, PT10M, PT15M, PT20M, PT30M, PT45M, PT1H, PT2H, PT3H, PT4H, PT5H, PT6H, P1D and P2D.</summary>
    [JsonPropertyName("queryTimeRangeOverride")]
    public string? QueryTimeRangeOverride { get; set; }

    /// <summary>Specifies the list of resource IDs that this scheduled query rule is scoped to. Changing this forces a new resource to be created. Currently, the API supports exactly 1 resource ID in the scopes list.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>References to ApplicationInsights in insights to populate scopes.</summary>
    [JsonPropertyName("scopesRefs")]
    public IList<V1beta1MonitorScheduledQueryRulesAlertV2SpecInitProviderScopesRefs>? ScopesRefs { get; set; }

    /// <summary>Selector for a list of ApplicationInsights in insights to populate scopes.</summary>
    [JsonPropertyName("scopesSelector")]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecInitProviderScopesSelector? ScopesSelector { get; set; }

    /// <summary>Severity of the alert. Should be an integer between 0 and 4. Value of 0 is severest.</summary>
    [JsonPropertyName("severity")]
    public double? Severity { get; set; }

    /// <summary>Specifies the flag which indicates whether the provided query should be validated or not. The default is false.</summary>
    [JsonPropertyName("skipQueryValidation")]
    public bool? SkipQueryValidation { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Monitor Scheduled Query Rule.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>List of resource type of the target resource(s) on which the alert is created/updated. For example if the scope is a resource group and targetResourceTypes is Microsoft.Compute/virtualMachines, then a different alert will be fired for each virtual machine in the resource group which meet the alert criteria.</summary>
    [JsonPropertyName("targetResourceTypes")]
    public IList<string>? TargetResourceTypes { get; set; }

    /// <summary>Specifies the period of time in ISO 8601 duration format on which the Scheduled Query Rule will be executed (bin size). If evaluation_frequency is PT1M, possible values are PT1M, PT5M, PT10M, PT15M, PT30M, PT45M, PT1H, PT2H, PT3H, PT4H, PT5H, and PT6H. Otherwise, possible values are PT5M, PT10M, PT15M, PT30M, PT45M, PT1H, PT2H, PT3H, PT4H, PT5H, PT6H, P1D, and P2D.</summary>
    [JsonPropertyName("windowDuration")]
    public string? WindowDuration { get; set; }

    /// <summary>Specifies the flag which indicates whether this scheduled query rule check if storage is configured. Value should be true or false. The default is false.</summary>
    [JsonPropertyName("workspaceAlertsStorageEnabled")]
    public bool? WorkspaceAlertsStorageEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorScheduledQueryRulesAlertV2SpecManagementPoliciesEnum
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
public enum V1beta1MonitorScheduledQueryRulesAlertV2SpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorScheduledQueryRulesAlertV2SpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1MonitorScheduledQueryRulesAlertV2SpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertV2SpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertV2SpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertV2SpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorScheduledQueryRulesAlertV2SpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorScheduledQueryRulesAlertV2SpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1MonitorScheduledQueryRulesAlertV2SpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertV2SpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertV2SpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertV2SpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertV2SpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1MonitorScheduledQueryRulesAlertV2SpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertV2SpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>MonitorScheduledQueryRulesAlertV2Spec defines the desired state of MonitorScheduledQueryRulesAlertV2</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertV2Spec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertV2SpecDeletionPolicyEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1MonitorScheduledQueryRulesAlertV2SpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MonitorScheduledQueryRulesAlertV2SpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertV2StatusAtProviderAction
{
    /// <summary>List of Action Group resource IDs to invoke when the alert fires.</summary>
    [JsonPropertyName("actionGroups")]
    public IList<string>? ActionGroups { get; set; }

    /// <summary>Specifies the properties of an alert payload.</summary>
    [JsonPropertyName("customProperties")]
    public IDictionary<string, string>? CustomProperties { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertV2StatusAtProviderCriteriaDimension
{
    /// <summary>Specifies the name which should be used for this Monitor Scheduled Query Rule. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Operator for dimension values. Possible values are Exclude,and Include.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>List of dimension values. Use a wildcard * to collect all.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertV2StatusAtProviderCriteriaFailingPeriods
{
    /// <summary>Specifies the number of violations to trigger an alert. Should be smaller or equal to number_of_evaluation_periods. Possible value is integer between 1 and 6.</summary>
    [JsonPropertyName("minimumFailingPeriodsToTriggerAlert")]
    public double? MinimumFailingPeriodsToTriggerAlert { get; set; }

    /// <summary>Specifies the number of aggregated look-back points. The look-back time window is calculated based on the aggregation granularity window_duration and the selected number of aggregated points. Possible value is integer between 1 and 6.</summary>
    [JsonPropertyName("numberOfEvaluationPeriods")]
    public double? NumberOfEvaluationPeriods { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertV2StatusAtProviderCriteria
{
    /// <summary>A dimension block as defined below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1MonitorScheduledQueryRulesAlertV2StatusAtProviderCriteriaDimension>? Dimension { get; set; }

    /// <summary>A failing_periods block as defined below.</summary>
    [JsonPropertyName("failingPeriods")]
    public IList<V1beta1MonitorScheduledQueryRulesAlertV2StatusAtProviderCriteriaFailingPeriods>? FailingPeriods { get; set; }

    /// <summary>Specifies the column containing the metric measure number.</summary>
    [JsonPropertyName("metricMeasureColumn")]
    public string? MetricMeasureColumn { get; set; }

    /// <summary>Specifies the criteria operator. Possible values are Equal, GreaterThan, GreaterThanOrEqual, LessThan,and LessThanOrEqual.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The query to run on logs. The results returned by this query are used to populate the alert.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>Specifies the column containing the resource ID. The content of the column must be an uri formatted as resource ID.</summary>
    [JsonPropertyName("resourceIdColumn")]
    public string? ResourceIdColumn { get; set; }

    /// <summary>Specifies the criteria threshold value that activates the alert.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>The type of aggregation to apply to the data points in aggregation granularity. Possible values are Average, Count, Maximum, Minimum,and Total.</summary>
    [JsonPropertyName("timeAggregationMethod")]
    public string? TimeAggregationMethod { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertV2StatusAtProvider
{
    /// <summary>An action block as defined below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1MonitorScheduledQueryRulesAlertV2StatusAtProviderAction>? Action { get; set; }

    /// <summary>Specifies the flag that indicates whether the alert should be automatically resolved or not. Value should be true or false. The default is false.</summary>
    [JsonPropertyName("autoMitigationEnabled")]
    public bool? AutoMitigationEnabled { get; set; }

    /// <summary>The api-version used when creating this alert rule.</summary>
    [JsonPropertyName("createdWithApiVersion")]
    public string? CreatedWithApiVersion { get; set; }

    /// <summary>A criteria block as defined below.</summary>
    [JsonPropertyName("criteria")]
    public IList<V1beta1MonitorScheduledQueryRulesAlertV2StatusAtProviderCriteria>? Criteria { get; set; }

    /// <summary>Specifies the description of the scheduled query rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies the display name of the alert rule.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Specifies the flag which indicates whether this scheduled query rule is enabled. Value should be true or false. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>How often the scheduled query rule is evaluated, represented in ISO 8601 duration format. Possible values are PT1M, PT5M, PT10M, PT15M, PT30M, PT45M, PT1H, PT2H, PT3H, PT4H, PT5H, PT6H, P1D.</summary>
    [JsonPropertyName("evaluationFrequency")]
    public string? EvaluationFrequency { get; set; }

    /// <summary>The ID of the Monitor Scheduled Query Rule.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>True if this alert rule is a legacy Log Analytic Rule.</summary>
    [JsonPropertyName("isALegacyLogAnalyticsRule")]
    public bool? IsALegacyLogAnalyticsRule { get; set; }

    /// <summary>The flag indicates whether this Scheduled Query Rule has been configured to be stored in the customer's storage.</summary>
    [JsonPropertyName("isWorkspaceAlertsStorageConfigured")]
    public bool? IsWorkspaceAlertsStorageConfigured { get; set; }

    /// <summary>Specifies the Azure Region where the Monitor Scheduled Query Rule should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Mute actions for the chosen period of time in ISO 8601 duration format after the alert is fired. Possible values are PT5M, PT10M, PT15M, PT30M, PT45M, PT1H, PT2H, PT3H, PT4H, PT5H, PT6H, P1D and P2D.</summary>
    [JsonPropertyName("muteActionsAfterAlertDuration")]
    public string? MuteActionsAfterAlertDuration { get; set; }

    /// <summary>Set this if the alert evaluation period is different from the query time range. If not specified, the value is window_duration*number_of_evaluation_periods. Possible values are PT5M, PT10M, PT15M, PT20M, PT30M, PT45M, PT1H, PT2H, PT3H, PT4H, PT5H, PT6H, P1D and P2D.</summary>
    [JsonPropertyName("queryTimeRangeOverride")]
    public string? QueryTimeRangeOverride { get; set; }

    /// <summary>Specifies the name of the Resource Group where the Monitor Scheduled Query Rule should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Specifies the list of resource IDs that this scheduled query rule is scoped to. Changing this forces a new resource to be created. Currently, the API supports exactly 1 resource ID in the scopes list.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>Severity of the alert. Should be an integer between 0 and 4. Value of 0 is severest.</summary>
    [JsonPropertyName("severity")]
    public double? Severity { get; set; }

    /// <summary>Specifies the flag which indicates whether the provided query should be validated or not. The default is false.</summary>
    [JsonPropertyName("skipQueryValidation")]
    public bool? SkipQueryValidation { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Monitor Scheduled Query Rule.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>List of resource type of the target resource(s) on which the alert is created/updated. For example if the scope is a resource group and targetResourceTypes is Microsoft.Compute/virtualMachines, then a different alert will be fired for each virtual machine in the resource group which meet the alert criteria.</summary>
    [JsonPropertyName("targetResourceTypes")]
    public IList<string>? TargetResourceTypes { get; set; }

    /// <summary>Specifies the period of time in ISO 8601 duration format on which the Scheduled Query Rule will be executed (bin size). If evaluation_frequency is PT1M, possible values are PT1M, PT5M, PT10M, PT15M, PT30M, PT45M, PT1H, PT2H, PT3H, PT4H, PT5H, and PT6H. Otherwise, possible values are PT5M, PT10M, PT15M, PT30M, PT45M, PT1H, PT2H, PT3H, PT4H, PT5H, PT6H, P1D, and P2D.</summary>
    [JsonPropertyName("windowDuration")]
    public string? WindowDuration { get; set; }

    /// <summary>Specifies the flag which indicates whether this scheduled query rule check if storage is configured. Value should be true or false. The default is false.</summary>
    [JsonPropertyName("workspaceAlertsStorageEnabled")]
    public bool? WorkspaceAlertsStorageEnabled { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertV2StatusConditions
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

/// <summary>MonitorScheduledQueryRulesAlertV2Status defines the observed state of MonitorScheduledQueryRulesAlertV2.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertV2Status
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1MonitorScheduledQueryRulesAlertV2StatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MonitorScheduledQueryRulesAlertV2StatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MonitorScheduledQueryRulesAlertV2 is the Schema for the MonitorScheduledQueryRulesAlertV2s API. Manages an AlertingAction Scheduled Query Rules Version 2 resource within Azure Monitor</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MonitorScheduledQueryRulesAlertV2 : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MonitorScheduledQueryRulesAlertV2Spec>, IStatus<V1beta1MonitorScheduledQueryRulesAlertV2Status>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MonitorScheduledQueryRulesAlertV2";
    public const string KubeGroup = "insights.azure.upbound.io";
    public const string KubePluralName = "monitorscheduledqueryrulesalertv2s";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MonitorScheduledQueryRulesAlertV2Spec defines the desired state of MonitorScheduledQueryRulesAlertV2</summary>
    [JsonPropertyName("spec")]
    public V1beta1MonitorScheduledQueryRulesAlertV2Spec Spec { get; set; }

    /// <summary>MonitorScheduledQueryRulesAlertV2Status defines the observed state of MonitorScheduledQueryRulesAlertV2.</summary>
    [JsonPropertyName("status")]
    public V1beta1MonitorScheduledQueryRulesAlertV2Status? Status { get; set; }
}