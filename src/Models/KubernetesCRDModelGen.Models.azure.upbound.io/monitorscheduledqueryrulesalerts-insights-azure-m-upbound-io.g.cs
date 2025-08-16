using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.insights.azure.m.upbound.io;
/// <summary>MonitorScheduledQueryRulesAlert is the Schema for the MonitorScheduledQueryRulesAlerts API. Manages an AlertingAction Scheduled Query Rules resource within Azure Monitor</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MonitorScheduledQueryRulesAlertList : IKubernetesObject<V1ListMeta>, IItems<V1beta1MonitorScheduledQueryRulesAlert>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MonitorScheduledQueryRulesAlertList";
    public const string KubeGroup = "insights.azure.m.upbound.io";
    public const string KubePluralName = "monitorscheduledqueryrulesalerts";
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
    public IList<V1beta1MonitorScheduledQueryRulesAlert> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderActionActionGroupRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderActionActionGroupRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderActionActionGroupRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderActionActionGroupSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of MonitorActionGroup in insights to populate actionGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderActionActionGroupSelector
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
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderActionActionGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>An action block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderAuthorizedResourceIdsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderAuthorizedResourceIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderAuthorizedResourceIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderAuthorizedResourceIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of ApplicationInsights in insights to populate authorizedResourceIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderAuthorizedResourceIdsSelector
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
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderAuthorizedResourceIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderDataSourceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ApplicationInsights in insights to populate dataSourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderDataSourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderDataSourceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderDataSourceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ApplicationInsights in insights to populate dataSourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderDataSourceIdSelector
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
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderDataSourceIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderResourceGroupNameSelector
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
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A metric_trigger block as defined above. Trigger condition for metric query rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>A trigger block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProviderTrigger
{
    /// <summary>A metric_trigger block as defined above. Trigger condition for metric query rule.</summary>
    [JsonPropertyName("metricTrigger")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderTriggerMetricTrigger? MetricTrigger { get; set; }

    /// <summary>Evaluation operation for rule - 'GreaterThan', GreaterThanOrEqual', 'LessThan', or 'LessThanOrEqual'.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Result or count threshold based on which rule should be triggered. Values must be between 0 and 10000 inclusive.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecForProvider
{
    /// <summary>An action block as defined below.</summary>
    [JsonPropertyName("action")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderAction? Action { get; set; }

    /// <summary>List of Resource IDs referred into query.</summary>
    [JsonPropertyName("authorizedResourceIds")]
    public IList<string>? AuthorizedResourceIds { get; set; }

    /// <summary>References to ApplicationInsights in insights to populate authorizedResourceIds.</summary>
    [JsonPropertyName("authorizedResourceIdsRefs")]
    public IList<V1beta1MonitorScheduledQueryRulesAlertSpecForProviderAuthorizedResourceIdsRefs>? AuthorizedResourceIdsRefs { get; set; }

    /// <summary>Selector for a list of ApplicationInsights in insights to populate authorizedResourceIds.</summary>
    [JsonPropertyName("authorizedResourceIdsSelector")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderAuthorizedResourceIdsSelector? AuthorizedResourceIdsSelector { get; set; }

    /// <summary>Should the alerts in this Metric Alert be auto resolved? Defaults to false. -&gt; Note: auto_mitigation_enabled and throttling are mutually exclusive and cannot both be set.</summary>
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
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProviderTrigger? Trigger { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderActionActionGroupRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderActionActionGroupRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderActionActionGroupRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderActionActionGroupSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of MonitorActionGroup in insights to populate actionGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderActionActionGroupSelector
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
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderActionActionGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>An action block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderAuthorizedResourceIdsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderAuthorizedResourceIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderAuthorizedResourceIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderAuthorizedResourceIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of ApplicationInsights in insights to populate authorizedResourceIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderAuthorizedResourceIdsSelector
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
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderAuthorizedResourceIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderDataSourceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ApplicationInsights in insights to populate dataSourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderDataSourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderDataSourceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderDataSourceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ApplicationInsights in insights to populate dataSourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderDataSourceIdSelector
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
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderDataSourceIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderResourceGroupNameSelector
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
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A metric_trigger block as defined above. Trigger condition for metric query rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>A trigger block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderTrigger
{
    /// <summary>A metric_trigger block as defined above. Trigger condition for metric query rule.</summary>
    [JsonPropertyName("metricTrigger")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderTriggerMetricTrigger? MetricTrigger { get; set; }

    /// <summary>Evaluation operation for rule - 'GreaterThan', GreaterThanOrEqual', 'LessThan', or 'LessThanOrEqual'.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Result or count threshold based on which rule should be triggered. Values must be between 0 and 10000 inclusive.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecInitProvider
{
    /// <summary>An action block as defined below.</summary>
    [JsonPropertyName("action")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderAction? Action { get; set; }

    /// <summary>List of Resource IDs referred into query.</summary>
    [JsonPropertyName("authorizedResourceIds")]
    public IList<string>? AuthorizedResourceIds { get; set; }

    /// <summary>References to ApplicationInsights in insights to populate authorizedResourceIds.</summary>
    [JsonPropertyName("authorizedResourceIdsRefs")]
    public IList<V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderAuthorizedResourceIdsRefs>? AuthorizedResourceIdsRefs { get; set; }

    /// <summary>Selector for a list of ApplicationInsights in insights to populate authorizedResourceIds.</summary>
    [JsonPropertyName("authorizedResourceIdsSelector")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderAuthorizedResourceIdsSelector? AuthorizedResourceIdsSelector { get; set; }

    /// <summary>Should the alerts in this Metric Alert be auto resolved? Defaults to false. -&gt; Note: auto_mitigation_enabled and throttling are mutually exclusive and cannot both be set.</summary>
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
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProviderTrigger? Trigger { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>MonitorScheduledQueryRulesAlertSpec defines the desired state of MonitorScheduledQueryRulesAlert</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MonitorScheduledQueryRulesAlertSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An action block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>A metric_trigger block as defined above. Trigger condition for metric query rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>A trigger block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertStatusAtProviderTrigger
{
    /// <summary>A metric_trigger block as defined above. Trigger condition for metric query rule.</summary>
    [JsonPropertyName("metricTrigger")]
    public V1beta1MonitorScheduledQueryRulesAlertStatusAtProviderTriggerMetricTrigger? MetricTrigger { get; set; }

    /// <summary>Evaluation operation for rule - 'GreaterThan', GreaterThanOrEqual', 'LessThan', or 'LessThanOrEqual'.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Result or count threshold based on which rule should be triggered. Values must be between 0 and 10000 inclusive.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorScheduledQueryRulesAlertStatusAtProvider
{
    /// <summary>An action block as defined below.</summary>
    [JsonPropertyName("action")]
    public V1beta1MonitorScheduledQueryRulesAlertStatusAtProviderAction? Action { get; set; }

    /// <summary>List of Resource IDs referred into query.</summary>
    [JsonPropertyName("authorizedResourceIds")]
    public IList<string>? AuthorizedResourceIds { get; set; }

    /// <summary>Should the alerts in this Metric Alert be auto resolved? Defaults to false. -&gt; Note: auto_mitigation_enabled and throttling are mutually exclusive and cannot both be set.</summary>
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
    public V1beta1MonitorScheduledQueryRulesAlertStatusAtProviderTrigger? Trigger { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>MonitorScheduledQueryRulesAlertStatus defines the observed state of MonitorScheduledQueryRulesAlert.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>MonitorScheduledQueryRulesAlert is the Schema for the MonitorScheduledQueryRulesAlerts API. Manages an AlertingAction Scheduled Query Rules resource within Azure Monitor</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MonitorScheduledQueryRulesAlert : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MonitorScheduledQueryRulesAlertSpec>, IStatus<V1beta1MonitorScheduledQueryRulesAlertStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MonitorScheduledQueryRulesAlert";
    public const string KubeGroup = "insights.azure.m.upbound.io";
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