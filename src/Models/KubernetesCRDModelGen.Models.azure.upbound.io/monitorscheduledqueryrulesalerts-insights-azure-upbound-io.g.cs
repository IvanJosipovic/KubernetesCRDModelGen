using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.insights.azure.upbound.io;
public enum V1beta1MonitorScheduledQueryRulesAlertSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1MonitorScheduledQueryRulesAlertSpecForProviderActionActionGroupRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MonitorScheduledQueryRulesAlertSpecForProviderActionActionGroupRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderActionActionGroupRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertSpecForProviderActionActionGroupRefsPolicyResolutionEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderActionActionGroupRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertSpecForProviderActionActionGroupRefsPolicyResolveEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderActionActionGroupRefsPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderActionActionGroupRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderActionActionGroupRefsPolicy? Policy { get; set; }
}

public enum V1beta1MonitorScheduledQueryRulesAlertSpecForProviderActionActionGroupSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MonitorScheduledQueryRulesAlertSpecForProviderActionActionGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderActionActionGroupSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertSpecForProviderActionActionGroupSelectorPolicyResolutionEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderActionActionGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertSpecForProviderActionActionGroupSelectorPolicyResolveEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderActionActionGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderActionActionGroupSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderActionActionGroupSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderAction
{
    /// <summary>List of action group reference resource IDs.</summary>
    [JsonPropertyName("actionGroup")]
    public IList<string>? ActionGroup { get; set; }

    /// <summary>References to MonitorActionGroup in insights to populate actionGroup.</summary>
    [JsonPropertyName("actionGroupRefs")]
    public IList<V1beta1MonitorScheduledQueryRulesAlertSpecForProviderActionActionGroupRefs>? ActionGroupRefs { get; set; }

    /// <summary>Selector for a list of MonitorActionGroup in insights to populate actionGroup.</summary>
    [JsonPropertyName("actionGroupSelector")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderActionActionGroupSelector? ActionGroupSelector { get; set; }

    /// <summary>Custom payload to be sent for all webhook payloads in alerting action.</summary>
    [JsonPropertyName("customWebhookPayload")]
    public string? CustomWebhookPayload { get; set; }

    /// <summary>Custom subject override for all email ids in Azure action group.</summary>
    [JsonPropertyName("emailSubject")]
    public string? EmailSubject { get; set; }
}

public enum V1beta1MonitorScheduledQueryRulesAlertSpecForProviderDataSourceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MonitorScheduledQueryRulesAlertSpecForProviderDataSourceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderDataSourceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertSpecForProviderDataSourceIdRefPolicyResolutionEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderDataSourceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertSpecForProviderDataSourceIdRefPolicyResolveEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderDataSourceIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderDataSourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderDataSourceIdRefPolicy? Policy { get; set; }
}

public enum V1beta1MonitorScheduledQueryRulesAlertSpecForProviderDataSourceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MonitorScheduledQueryRulesAlertSpecForProviderDataSourceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderDataSourceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertSpecForProviderDataSourceIdSelectorPolicyResolutionEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderDataSourceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertSpecForProviderDataSourceIdSelectorPolicyResolveEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderDataSourceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderDataSourceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderDataSourceIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1MonitorScheduledQueryRulesAlertSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MonitorScheduledQueryRulesAlertSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1MonitorScheduledQueryRulesAlertSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MonitorScheduledQueryRulesAlertSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderTriggerMetricTrigger
{
    /// <summary>Evaluation of metric on a particular column.</summary>
    [JsonPropertyName("metricColumn")]
    public string? MetricColumn { get; set; }

    /// <summary>Metric Trigger Type - 'Consecutive' or 'Total'.</summary>
    [JsonPropertyName("metricTriggerType")]
    public string? MetricTriggerType { get; set; }

    /// <summary>Evaluation operation for rule - 'GreaterThan', GreaterThanOrEqual', 'LessThan', or 'LessThanOrEqual'.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Result or count threshold based on which rule should be triggered. Values must be between 0 and 10000 inclusive.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderTrigger
{
    /// <summary>A metric_trigger block as defined above. Trigger condition for metric query rule.</summary>
    [JsonPropertyName("metricTrigger")]
    public IList<V1beta1MonitorScheduledQueryRulesAlertSpecForProviderTriggerMetricTrigger>? MetricTrigger { get; set; }

    /// <summary>Evaluation operation for rule - 'GreaterThan', GreaterThanOrEqual', 'LessThan', or 'LessThanOrEqual'.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Result or count threshold based on which rule should be triggered. Values must be between 0 and 10000 inclusive.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProvider
{
    /// <summary>An action block as defined below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1MonitorScheduledQueryRulesAlertSpecForProviderAction>? Action { get; set; }

    /// <summary>List of Resource IDs referred into query.</summary>
    [JsonPropertyName("authorizedResourceIds")]
    public IList<string>? AuthorizedResourceIds { get; set; }

    /// <summary>Should the alerts in this Metric Alert be auto resolved? Defaults to false. -&gt; NOTE auto_mitigation_enabled and throttling are mutually exclusive and cannot both be set.</summary>
    [JsonPropertyName("autoMitigationEnabled")]
    public bool? AutoMitigationEnabled { get; set; }

    /// <summary>The resource URI over which log search query is to be run. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataSourceId")]
    public string? DataSourceId { get; set; }

    /// <summary>Reference to a ApplicationInsights in insights to populate dataSourceId.</summary>
    [JsonPropertyName("dataSourceIdRef")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderDataSourceIdRef? DataSourceIdRef { get; set; }

    /// <summary>Selector for a ApplicationInsights in insights to populate dataSourceId.</summary>
    [JsonPropertyName("dataSourceIdSelector")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderDataSourceIdSelector? DataSourceIdSelector { get; set; }

    /// <summary>The description of the scheduled query rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether this scheduled query rule is enabled. Default is true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Frequency (in minutes) at which rule condition should be evaluated. Values must be between 5 and 1440 (inclusive).</summary>
    [JsonPropertyName("frequency")]
    public double? Frequency { get; set; }

    /// <summary>Specifies the Azure Region where the resource should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the scheduled query rule. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Log search query.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>The type of query results. Possible values are ResultCount and Number. Default is ResultCount. If set to ResultCount, query must include an AggregatedValue column of a numeric type, for example, Heartbeat | summarize AggregatedValue = count() by bin(TimeGenerated, 5m).</summary>
    [JsonPropertyName("queryType")]
    public string? QueryType { get; set; }

    /// <summary>The name of the resource group in which to create the scheduled query rule instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Severity of the alert. Possible values include: 0, 1, 2, 3, or 4.</summary>
    [JsonPropertyName("severity")]
    public double? Severity { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Time (in minutes) for which Alerts should be throttled or suppressed. Values must be between 0 and 10000 (inclusive).</summary>
    [JsonPropertyName("throttling")]
    public double? Throttling { get; set; }

    /// <summary>Time window for which data needs to be fetched for query (must be greater than or equal to frequency). Values must be between 5 and 2880 (inclusive).</summary>
    [JsonPropertyName("timeWindow")]
    public double? TimeWindow { get; set; }

    /// <summary>A trigger block as defined below.</summary>
    [JsonPropertyName("trigger")]
    public IList<V1beta1MonitorScheduledQueryRulesAlertSpecForProviderTrigger>? Trigger { get; set; }
}

public enum V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderActionActionGroupRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderActionActionGroupRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderActionActionGroupRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderActionActionGroupRefsPolicyResolutionEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderActionActionGroupRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderActionActionGroupRefsPolicyResolveEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderActionActionGroupRefsPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderActionActionGroupRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderActionActionGroupRefsPolicy? Policy { get; set; }
}

public enum V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderActionActionGroupSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderActionActionGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderActionActionGroupSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderActionActionGroupSelectorPolicyResolutionEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderActionActionGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderActionActionGroupSelectorPolicyResolveEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderActionActionGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderActionActionGroupSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderActionActionGroupSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderAction
{
    /// <summary>List of action group reference resource IDs.</summary>
    [JsonPropertyName("actionGroup")]
    public IList<string>? ActionGroup { get; set; }

    /// <summary>References to MonitorActionGroup in insights to populate actionGroup.</summary>
    [JsonPropertyName("actionGroupRefs")]
    public IList<V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderActionActionGroupRefs>? ActionGroupRefs { get; set; }

    /// <summary>Selector for a list of MonitorActionGroup in insights to populate actionGroup.</summary>
    [JsonPropertyName("actionGroupSelector")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderActionActionGroupSelector? ActionGroupSelector { get; set; }

    /// <summary>Custom payload to be sent for all webhook payloads in alerting action.</summary>
    [JsonPropertyName("customWebhookPayload")]
    public string? CustomWebhookPayload { get; set; }

    /// <summary>Custom subject override for all email ids in Azure action group.</summary>
    [JsonPropertyName("emailSubject")]
    public string? EmailSubject { get; set; }
}

public enum V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderDataSourceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderDataSourceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderDataSourceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderDataSourceIdRefPolicyResolutionEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderDataSourceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderDataSourceIdRefPolicyResolveEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderDataSourceIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderDataSourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderDataSourceIdRefPolicy? Policy { get; set; }
}

public enum V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderDataSourceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderDataSourceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderDataSourceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderDataSourceIdSelectorPolicyResolutionEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderDataSourceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderDataSourceIdSelectorPolicyResolveEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderDataSourceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderDataSourceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderDataSourceIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderTriggerMetricTrigger
{
    /// <summary>Evaluation of metric on a particular column.</summary>
    [JsonPropertyName("metricColumn")]
    public string? MetricColumn { get; set; }

    /// <summary>Metric Trigger Type - 'Consecutive' or 'Total'.</summary>
    [JsonPropertyName("metricTriggerType")]
    public string? MetricTriggerType { get; set; }

    /// <summary>Evaluation operation for rule - 'GreaterThan', GreaterThanOrEqual', 'LessThan', or 'LessThanOrEqual'.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Result or count threshold based on which rule should be triggered. Values must be between 0 and 10000 inclusive.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderTrigger
{
    /// <summary>A metric_trigger block as defined above. Trigger condition for metric query rule.</summary>
    [JsonPropertyName("metricTrigger")]
    public IList<V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderTriggerMetricTrigger>? MetricTrigger { get; set; }

    /// <summary>Evaluation operation for rule - 'GreaterThan', GreaterThanOrEqual', 'LessThan', or 'LessThanOrEqual'.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Result or count threshold based on which rule should be triggered. Values must be between 0 and 10000 inclusive.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProvider
{
    /// <summary>An action block as defined below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderAction>? Action { get; set; }

    /// <summary>List of Resource IDs referred into query.</summary>
    [JsonPropertyName("authorizedResourceIds")]
    public IList<string>? AuthorizedResourceIds { get; set; }

    /// <summary>Should the alerts in this Metric Alert be auto resolved? Defaults to false. -&gt; NOTE auto_mitigation_enabled and throttling are mutually exclusive and cannot both be set.</summary>
    [JsonPropertyName("autoMitigationEnabled")]
    public bool? AutoMitigationEnabled { get; set; }

    /// <summary>The resource URI over which log search query is to be run. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataSourceId")]
    public string? DataSourceId { get; set; }

    /// <summary>Reference to a ApplicationInsights in insights to populate dataSourceId.</summary>
    [JsonPropertyName("dataSourceIdRef")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderDataSourceIdRef? DataSourceIdRef { get; set; }

    /// <summary>Selector for a ApplicationInsights in insights to populate dataSourceId.</summary>
    [JsonPropertyName("dataSourceIdSelector")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderDataSourceIdSelector? DataSourceIdSelector { get; set; }

    /// <summary>The description of the scheduled query rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether this scheduled query rule is enabled. Default is true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Frequency (in minutes) at which rule condition should be evaluated. Values must be between 5 and 1440 (inclusive).</summary>
    [JsonPropertyName("frequency")]
    public double? Frequency { get; set; }

    /// <summary>Specifies the Azure Region where the resource should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the scheduled query rule. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Log search query.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>The type of query results. Possible values are ResultCount and Number. Default is ResultCount. If set to ResultCount, query must include an AggregatedValue column of a numeric type, for example, Heartbeat | summarize AggregatedValue = count() by bin(TimeGenerated, 5m).</summary>
    [JsonPropertyName("queryType")]
    public string? QueryType { get; set; }

    /// <summary>The name of the resource group in which to create the scheduled query rule instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Severity of the alert. Possible values include: 0, 1, 2, 3, or 4.</summary>
    [JsonPropertyName("severity")]
    public double? Severity { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Time (in minutes) for which Alerts should be throttled or suppressed. Values must be between 0 and 10000 (inclusive).</summary>
    [JsonPropertyName("throttling")]
    public double? Throttling { get; set; }

    /// <summary>Time window for which data needs to be fetched for query (must be greater than or equal to frequency). Values must be between 5 and 2880 (inclusive).</summary>
    [JsonPropertyName("timeWindow")]
    public double? TimeWindow { get; set; }

    /// <summary>A trigger block as defined below.</summary>
    [JsonPropertyName("trigger")]
    public IList<V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderTrigger>? Trigger { get; set; }
}

public enum V1beta1MonitorScheduledQueryRulesAlertSpecManagementPoliciesEnum
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

public enum V1beta1MonitorScheduledQueryRulesAlertSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MonitorScheduledQueryRulesAlertSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1MonitorScheduledQueryRulesAlertSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MonitorScheduledQueryRulesAlertSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1MonitorScheduledQueryRulesAlertSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorScheduledQueryRulesAlertSpecDeletionPolicyEnum>))]
    public V1beta1MonitorScheduledQueryRulesAlertSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1MonitorScheduledQueryRulesAlertSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1MonitorScheduledQueryRulesAlertStatusAtProviderAction
{
    /// <summary>List of action group reference resource IDs.</summary>
    [JsonPropertyName("actionGroup")]
    public IList<string>? ActionGroup { get; set; }

    /// <summary>Custom payload to be sent for all webhook payloads in alerting action.</summary>
    [JsonPropertyName("customWebhookPayload")]
    public string? CustomWebhookPayload { get; set; }

    /// <summary>Custom subject override for all email ids in Azure action group.</summary>
    [JsonPropertyName("emailSubject")]
    public string? EmailSubject { get; set; }
}

public partial class V1beta1MonitorScheduledQueryRulesAlertStatusAtProviderTriggerMetricTrigger
{
    /// <summary>Evaluation of metric on a particular column.</summary>
    [JsonPropertyName("metricColumn")]
    public string? MetricColumn { get; set; }

    /// <summary>Metric Trigger Type - 'Consecutive' or 'Total'.</summary>
    [JsonPropertyName("metricTriggerType")]
    public string? MetricTriggerType { get; set; }

    /// <summary>Evaluation operation for rule - 'GreaterThan', GreaterThanOrEqual', 'LessThan', or 'LessThanOrEqual'.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Result or count threshold based on which rule should be triggered. Values must be between 0 and 10000 inclusive.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }
}

public partial class V1beta1MonitorScheduledQueryRulesAlertStatusAtProviderTrigger
{
    /// <summary>A metric_trigger block as defined above. Trigger condition for metric query rule.</summary>
    [JsonPropertyName("metricTrigger")]
    public IList<V1beta1MonitorScheduledQueryRulesAlertStatusAtProviderTriggerMetricTrigger>? MetricTrigger { get; set; }

    /// <summary>Evaluation operation for rule - 'GreaterThan', GreaterThanOrEqual', 'LessThan', or 'LessThanOrEqual'.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Result or count threshold based on which rule should be triggered. Values must be between 0 and 10000 inclusive.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }
}

public partial class V1beta1MonitorScheduledQueryRulesAlertStatusAtProvider
{
    /// <summary>An action block as defined below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1MonitorScheduledQueryRulesAlertStatusAtProviderAction>? Action { get; set; }

    /// <summary>List of Resource IDs referred into query.</summary>
    [JsonPropertyName("authorizedResourceIds")]
    public IList<string>? AuthorizedResourceIds { get; set; }

    /// <summary>Should the alerts in this Metric Alert be auto resolved? Defaults to false. -&gt; NOTE auto_mitigation_enabled and throttling are mutually exclusive and cannot both be set.</summary>
    [JsonPropertyName("autoMitigationEnabled")]
    public bool? AutoMitigationEnabled { get; set; }

    /// <summary>The resource URI over which log search query is to be run. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataSourceId")]
    public string? DataSourceId { get; set; }

    /// <summary>The description of the scheduled query rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Whether this scheduled query rule is enabled. Default is true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Frequency (in minutes) at which rule condition should be evaluated. Values must be between 5 and 1440 (inclusive).</summary>
    [JsonPropertyName("frequency")]
    public double? Frequency { get; set; }

    /// <summary>The ID of the scheduled query rule.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the Azure Region where the resource should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the scheduled query rule. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Log search query.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>The type of query results. Possible values are ResultCount and Number. Default is ResultCount. If set to ResultCount, query must include an AggregatedValue column of a numeric type, for example, Heartbeat | summarize AggregatedValue = count() by bin(TimeGenerated, 5m).</summary>
    [JsonPropertyName("queryType")]
    public string? QueryType { get; set; }

    /// <summary>The name of the resource group in which to create the scheduled query rule instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Severity of the alert. Possible values include: 0, 1, 2, 3, or 4.</summary>
    [JsonPropertyName("severity")]
    public double? Severity { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Time (in minutes) for which Alerts should be throttled or suppressed. Values must be between 0 and 10000 (inclusive).</summary>
    [JsonPropertyName("throttling")]
    public double? Throttling { get; set; }

    /// <summary>Time window for which data needs to be fetched for query (must be greater than or equal to frequency). Values must be between 5 and 2880 (inclusive).</summary>
    [JsonPropertyName("timeWindow")]
    public double? TimeWindow { get; set; }

    /// <summary>A trigger block as defined below.</summary>
    [JsonPropertyName("trigger")]
    public IList<V1beta1MonitorScheduledQueryRulesAlertStatusAtProviderTrigger>? Trigger { get; set; }
}

public partial class V1beta1MonitorScheduledQueryRulesAlertStatusConditions
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

public partial class V1beta1MonitorScheduledQueryRulesAlertStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1MonitorScheduledQueryRulesAlertStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MonitorScheduledQueryRulesAlertStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MonitorScheduledQueryRulesAlert : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MonitorScheduledQueryRulesAlertSpec>, IStatus<V1beta1MonitorScheduledQueryRulesAlertStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MonitorScheduledQueryRulesAlert";
    public const string KubeGroup = "insights.azure.upbound.io";
    public const string KubePluralName = "monitorscheduledqueryrulesalerts";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MonitorScheduledQueryRulesAlertSpec defines the desired state of MonitorScheduledQueryRulesAlert</summary>
    [JsonPropertyName("spec")]
    public V1beta1MonitorScheduledQueryRulesAlertSpec Spec { get; set; }

    /// <summary>MonitorScheduledQueryRulesAlertStatus defines the observed state of MonitorScheduledQueryRulesAlert.</summary>
    [JsonPropertyName("status")]
    public V1beta1MonitorScheduledQueryRulesAlertStatus? Status { get; set; }
}