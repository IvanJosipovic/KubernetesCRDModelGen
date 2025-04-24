using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.insights.azure.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecForProviderActionActionGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a MonitorActionGroup in insights to populate actionGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecForProviderActionActionGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorMetricAlertSpecForProviderActionActionGroupIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecForProviderActionActionGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a MonitorActionGroup in insights to populate actionGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecForProviderActionActionGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorMetricAlertSpecForProviderActionActionGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecForProviderAction
{
    /// <summary>The ID of the Action Group can be sourced from the</summary>
    [JsonPropertyName("actionGroupId")]
    public string? ActionGroupId { get; set; }

    /// <summary>Reference to a MonitorActionGroup in insights to populate actionGroupId.</summary>
    [JsonPropertyName("actionGroupIdRef")]
    public V1beta1MonitorMetricAlertSpecForProviderActionActionGroupIdRef? ActionGroupIdRef { get; set; }

    /// <summary>Selector for a MonitorActionGroup in insights to populate actionGroupId.</summary>
    [JsonPropertyName("actionGroupIdSelector")]
    public V1beta1MonitorMetricAlertSpecForProviderActionActionGroupIdSelector? ActionGroupIdSelector { get; set; }

    /// <summary>The map of custom string properties to include with the post operation. These data are appended to the webhook payload.</summary>
    [JsonPropertyName("webhookProperties")]
    public IDictionary<string, string>? WebhookProperties { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecForProviderApplicationInsightsWebTestLocationAvailabilityCriteria
{
    /// <summary>The ID of the Application Insights Resource.</summary>
    [JsonPropertyName("componentId")]
    public string? ComponentId { get; set; }

    /// <summary>The number of failed locations.</summary>
    [JsonPropertyName("failedLocationCount")]
    public double? FailedLocationCount { get; set; }

    /// <summary>The ID of the Application Insights Web Test.</summary>
    [JsonPropertyName("webTestId")]
    public string? WebTestId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecForProviderCriteriaDimension
{
    /// <summary>The name of the Metric Alert. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The criteria operator. Possible values are LessThan, GreaterThan and GreaterOrLessThan.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The list of dimension values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecForProviderCriteria
{
    /// <summary>The statistic that runs over the metric values. Possible values are Average, Count, Minimum, Maximum and Total.</summary>
    [JsonPropertyName("aggregation")]
    public string? Aggregation { get; set; }

    /// <summary>One or more dimension blocks as defined below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1MonitorMetricAlertSpecForProviderCriteriaDimension>? Dimension { get; set; }

    /// <summary>One of the metric names to be monitored.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>One of the metric namespaces to be monitored.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>The criteria operator. Possible values are Equals, GreaterThan, GreaterThanOrEqual, LessThan and LessThanOrEqual.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Skip the metric validation to allow creating an alert rule on a custom metric that isn't yet emitted? Defaults to false.</summary>
    [JsonPropertyName("skipMetricValidation")]
    public bool? SkipMetricValidation { get; set; }

    /// <summary>The criteria threshold value that activates the alert.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecForProviderDynamicCriteriaDimension
{
    /// <summary>The name of the Metric Alert. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The criteria operator. Possible values are LessThan, GreaterThan and GreaterOrLessThan.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The list of dimension values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecForProviderDynamicCriteria
{
    /// <summary>The statistic that runs over the metric values. Possible values are Average, Count, Minimum, Maximum and Total.</summary>
    [JsonPropertyName("aggregation")]
    public string? Aggregation { get; set; }

    /// <summary>The extent of deviation required to trigger an alert. Possible values are Low, Medium and High.</summary>
    [JsonPropertyName("alertSensitivity")]
    public string? AlertSensitivity { get; set; }

    /// <summary>One or more dimension blocks as defined below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1MonitorMetricAlertSpecForProviderDynamicCriteriaDimension>? Dimension { get; set; }

    /// <summary>The number of violations to trigger an alert. Should be smaller or equal to evaluation_total_count. Defaults to 4.</summary>
    [JsonPropertyName("evaluationFailureCount")]
    public double? EvaluationFailureCount { get; set; }

    /// <summary>The number of aggregated lookback points. The lookback time window is calculated based on the aggregation granularity (window_size) and the selected number of aggregated points. Defaults to 4.</summary>
    [JsonPropertyName("evaluationTotalCount")]
    public double? EvaluationTotalCount { get; set; }

    /// <summary>The ISO8601 date from which to start learning the metric historical data and calculate the dynamic thresholds.</summary>
    [JsonPropertyName("ignoreDataBefore")]
    public string? IgnoreDataBefore { get; set; }

    /// <summary>One of the metric names to be monitored.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>One of the metric namespaces to be monitored.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>The criteria operator. Possible values are LessThan, GreaterThan and GreaterOrLessThan.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Skip the metric validation to allow creating an alert rule on a custom metric that isn't yet emitted?</summary>
    [JsonPropertyName("skipMetricValidation")]
    public bool? SkipMetricValidation { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1MonitorMetricAlertSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorMetricAlertSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1MonitorMetricAlertSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorMetricAlertSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecForProviderScopesRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecForProviderScopesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorMetricAlertSpecForProviderScopesRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecForProviderScopesSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Account in storage to populate scopes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecForProviderScopesSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorMetricAlertSpecForProviderScopesSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecForProvider
{
    /// <summary>One or more action blocks as defined below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1MonitorMetricAlertSpecForProviderAction>? Action { get; set; }

    /// <summary>A application_insights_web_test_location_availability_criteria block as defined below.</summary>
    [JsonPropertyName("applicationInsightsWebTestLocationAvailabilityCriteria")]
    public IList<V1beta1MonitorMetricAlertSpecForProviderApplicationInsightsWebTestLocationAvailabilityCriteria>? ApplicationInsightsWebTestLocationAvailabilityCriteria { get; set; }

    /// <summary>Should the alerts in this Metric Alert be auto resolved? Defaults to true.</summary>
    [JsonPropertyName("autoMitigate")]
    public bool? AutoMitigate { get; set; }

    /// <summary>One or more (static) criteria blocks as defined below.</summary>
    [JsonPropertyName("criteria")]
    public IList<V1beta1MonitorMetricAlertSpecForProviderCriteria>? Criteria { get; set; }

    /// <summary>The description of this Metric Alert.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A dynamic_criteria block as defined below.</summary>
    [JsonPropertyName("dynamicCriteria")]
    public IList<V1beta1MonitorMetricAlertSpecForProviderDynamicCriteria>? DynamicCriteria { get; set; }

    /// <summary>Should this Metric Alert be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The evaluation frequency of this Metric Alert, represented in ISO 8601 duration format. Possible values are PT1M, PT5M, PT15M, PT30M and PT1H. Defaults to PT1M.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>The name of the resource group in which to create the Metric Alert instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1MonitorMetricAlertSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1MonitorMetricAlertSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A set of strings of resource IDs at which the metric criteria should be applied.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>References to Account in storage to populate scopes.</summary>
    [JsonPropertyName("scopesRefs")]
    public IList<V1beta1MonitorMetricAlertSpecForProviderScopesRefs>? ScopesRefs { get; set; }

    /// <summary>Selector for a list of Account in storage to populate scopes.</summary>
    [JsonPropertyName("scopesSelector")]
    public V1beta1MonitorMetricAlertSpecForProviderScopesSelector? ScopesSelector { get; set; }

    /// <summary>The severity of this Metric Alert. Possible values are 0, 1, 2, 3 and 4. Defaults to 3.</summary>
    [JsonPropertyName("severity")]
    public double? Severity { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The location of the target resource. The location of the target pluginsdk. Required when using subscription, resource group scope or multiple scopes.</summary>
    [JsonPropertyName("targetResourceLocation")]
    public string? TargetResourceLocation { get; set; }

    /// <summary>The resource type (e.g. Microsoft.Compute/virtualMachines) of the target resource. The resource type (e.g. Microsoft.Compute/virtualMachines) of the target pluginsdk. Required when using subscription, resource group scope or multiple scopes.</summary>
    [JsonPropertyName("targetResourceType")]
    public string? TargetResourceType { get; set; }

    /// <summary>The period of time that is used to monitor alert activity, represented in ISO 8601 duration format. This value must be greater than frequency. Possible values are PT1M, PT5M, PT15M, PT30M, PT1H, PT6H, PT12H and P1D. Defaults to PT5M.</summary>
    [JsonPropertyName("windowSize")]
    public string? WindowSize { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecInitProviderActionActionGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a MonitorActionGroup in insights to populate actionGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecInitProviderActionActionGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorMetricAlertSpecInitProviderActionActionGroupIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecInitProviderActionActionGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a MonitorActionGroup in insights to populate actionGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecInitProviderActionActionGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorMetricAlertSpecInitProviderActionActionGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecInitProviderAction
{
    /// <summary>The ID of the Action Group can be sourced from the</summary>
    [JsonPropertyName("actionGroupId")]
    public string? ActionGroupId { get; set; }

    /// <summary>Reference to a MonitorActionGroup in insights to populate actionGroupId.</summary>
    [JsonPropertyName("actionGroupIdRef")]
    public V1beta1MonitorMetricAlertSpecInitProviderActionActionGroupIdRef? ActionGroupIdRef { get; set; }

    /// <summary>Selector for a MonitorActionGroup in insights to populate actionGroupId.</summary>
    [JsonPropertyName("actionGroupIdSelector")]
    public V1beta1MonitorMetricAlertSpecInitProviderActionActionGroupIdSelector? ActionGroupIdSelector { get; set; }

    /// <summary>The map of custom string properties to include with the post operation. These data are appended to the webhook payload.</summary>
    [JsonPropertyName("webhookProperties")]
    public IDictionary<string, string>? WebhookProperties { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecInitProviderApplicationInsightsWebTestLocationAvailabilityCriteria
{
    /// <summary>The ID of the Application Insights Resource.</summary>
    [JsonPropertyName("componentId")]
    public string? ComponentId { get; set; }

    /// <summary>The number of failed locations.</summary>
    [JsonPropertyName("failedLocationCount")]
    public double? FailedLocationCount { get; set; }

    /// <summary>The ID of the Application Insights Web Test.</summary>
    [JsonPropertyName("webTestId")]
    public string? WebTestId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecInitProviderCriteriaDimension
{
    /// <summary>The name of the Metric Alert. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The criteria operator. Possible values are LessThan, GreaterThan and GreaterOrLessThan.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The list of dimension values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecInitProviderCriteria
{
    /// <summary>The statistic that runs over the metric values. Possible values are Average, Count, Minimum, Maximum and Total.</summary>
    [JsonPropertyName("aggregation")]
    public string? Aggregation { get; set; }

    /// <summary>One or more dimension blocks as defined below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1MonitorMetricAlertSpecInitProviderCriteriaDimension>? Dimension { get; set; }

    /// <summary>One of the metric names to be monitored.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>One of the metric namespaces to be monitored.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>The criteria operator. Possible values are Equals, GreaterThan, GreaterThanOrEqual, LessThan and LessThanOrEqual.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Skip the metric validation to allow creating an alert rule on a custom metric that isn't yet emitted? Defaults to false.</summary>
    [JsonPropertyName("skipMetricValidation")]
    public bool? SkipMetricValidation { get; set; }

    /// <summary>The criteria threshold value that activates the alert.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecInitProviderDynamicCriteriaDimension
{
    /// <summary>The name of the Metric Alert. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The criteria operator. Possible values are LessThan, GreaterThan and GreaterOrLessThan.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The list of dimension values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecInitProviderDynamicCriteria
{
    /// <summary>The statistic that runs over the metric values. Possible values are Average, Count, Minimum, Maximum and Total.</summary>
    [JsonPropertyName("aggregation")]
    public string? Aggregation { get; set; }

    /// <summary>The extent of deviation required to trigger an alert. Possible values are Low, Medium and High.</summary>
    [JsonPropertyName("alertSensitivity")]
    public string? AlertSensitivity { get; set; }

    /// <summary>One or more dimension blocks as defined below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1MonitorMetricAlertSpecInitProviderDynamicCriteriaDimension>? Dimension { get; set; }

    /// <summary>The number of violations to trigger an alert. Should be smaller or equal to evaluation_total_count. Defaults to 4.</summary>
    [JsonPropertyName("evaluationFailureCount")]
    public double? EvaluationFailureCount { get; set; }

    /// <summary>The number of aggregated lookback points. The lookback time window is calculated based on the aggregation granularity (window_size) and the selected number of aggregated points. Defaults to 4.</summary>
    [JsonPropertyName("evaluationTotalCount")]
    public double? EvaluationTotalCount { get; set; }

    /// <summary>The ISO8601 date from which to start learning the metric historical data and calculate the dynamic thresholds.</summary>
    [JsonPropertyName("ignoreDataBefore")]
    public string? IgnoreDataBefore { get; set; }

    /// <summary>One of the metric names to be monitored.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>One of the metric namespaces to be monitored.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>The criteria operator. Possible values are LessThan, GreaterThan and GreaterOrLessThan.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Skip the metric validation to allow creating an alert rule on a custom metric that isn't yet emitted?</summary>
    [JsonPropertyName("skipMetricValidation")]
    public bool? SkipMetricValidation { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecInitProviderScopesRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecInitProviderScopesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorMetricAlertSpecInitProviderScopesRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecInitProviderScopesSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of Account in storage to populate scopes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecInitProviderScopesSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorMetricAlertSpecInitProviderScopesSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecInitProvider
{
    /// <summary>One or more action blocks as defined below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1MonitorMetricAlertSpecInitProviderAction>? Action { get; set; }

    /// <summary>A application_insights_web_test_location_availability_criteria block as defined below.</summary>
    [JsonPropertyName("applicationInsightsWebTestLocationAvailabilityCriteria")]
    public IList<V1beta1MonitorMetricAlertSpecInitProviderApplicationInsightsWebTestLocationAvailabilityCriteria>? ApplicationInsightsWebTestLocationAvailabilityCriteria { get; set; }

    /// <summary>Should the alerts in this Metric Alert be auto resolved? Defaults to true.</summary>
    [JsonPropertyName("autoMitigate")]
    public bool? AutoMitigate { get; set; }

    /// <summary>One or more (static) criteria blocks as defined below.</summary>
    [JsonPropertyName("criteria")]
    public IList<V1beta1MonitorMetricAlertSpecInitProviderCriteria>? Criteria { get; set; }

    /// <summary>The description of this Metric Alert.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A dynamic_criteria block as defined below.</summary>
    [JsonPropertyName("dynamicCriteria")]
    public IList<V1beta1MonitorMetricAlertSpecInitProviderDynamicCriteria>? DynamicCriteria { get; set; }

    /// <summary>Should this Metric Alert be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The evaluation frequency of this Metric Alert, represented in ISO 8601 duration format. Possible values are PT1M, PT5M, PT15M, PT30M and PT1H. Defaults to PT1M.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>A set of strings of resource IDs at which the metric criteria should be applied.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>References to Account in storage to populate scopes.</summary>
    [JsonPropertyName("scopesRefs")]
    public IList<V1beta1MonitorMetricAlertSpecInitProviderScopesRefs>? ScopesRefs { get; set; }

    /// <summary>Selector for a list of Account in storage to populate scopes.</summary>
    [JsonPropertyName("scopesSelector")]
    public V1beta1MonitorMetricAlertSpecInitProviderScopesSelector? ScopesSelector { get; set; }

    /// <summary>The severity of this Metric Alert. Possible values are 0, 1, 2, 3 and 4. Defaults to 3.</summary>
    [JsonPropertyName("severity")]
    public double? Severity { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The location of the target resource. The location of the target pluginsdk. Required when using subscription, resource group scope or multiple scopes.</summary>
    [JsonPropertyName("targetResourceLocation")]
    public string? TargetResourceLocation { get; set; }

    /// <summary>The resource type (e.g. Microsoft.Compute/virtualMachines) of the target resource. The resource type (e.g. Microsoft.Compute/virtualMachines) of the target pluginsdk. Required when using subscription, resource group scope or multiple scopes.</summary>
    [JsonPropertyName("targetResourceType")]
    public string? TargetResourceType { get; set; }

    /// <summary>The period of time that is used to monitor alert activity, represented in ISO 8601 duration format. This value must be greater than frequency. Possible values are PT1M, PT5M, PT15M, PT30M, PT1H, PT6H, PT12H and P1D. Defaults to PT5M.</summary>
    [JsonPropertyName("windowSize")]
    public string? WindowSize { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecProviderConfigRefPolicy
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
public partial class V1beta1MonitorMetricAlertSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorMetricAlertSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1MonitorMetricAlertSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorMetricAlertSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1MonitorMetricAlertSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1MonitorMetricAlertSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1MonitorMetricAlertSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>MonitorMetricAlertSpec defines the desired state of MonitorMetricAlert</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1MonitorMetricAlertSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1MonitorMetricAlertSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MonitorMetricAlertSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1MonitorMetricAlertSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MonitorMetricAlertSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertStatusAtProviderAction
{
    /// <summary>The ID of the Action Group can be sourced from the</summary>
    [JsonPropertyName("actionGroupId")]
    public string? ActionGroupId { get; set; }

    /// <summary>The map of custom string properties to include with the post operation. These data are appended to the webhook payload.</summary>
    [JsonPropertyName("webhookProperties")]
    public IDictionary<string, string>? WebhookProperties { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertStatusAtProviderApplicationInsightsWebTestLocationAvailabilityCriteria
{
    /// <summary>The ID of the Application Insights Resource.</summary>
    [JsonPropertyName("componentId")]
    public string? ComponentId { get; set; }

    /// <summary>The number of failed locations.</summary>
    [JsonPropertyName("failedLocationCount")]
    public double? FailedLocationCount { get; set; }

    /// <summary>The ID of the Application Insights Web Test.</summary>
    [JsonPropertyName("webTestId")]
    public string? WebTestId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertStatusAtProviderCriteriaDimension
{
    /// <summary>The name of the Metric Alert. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The criteria operator. Possible values are LessThan, GreaterThan and GreaterOrLessThan.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The list of dimension values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertStatusAtProviderCriteria
{
    /// <summary>The statistic that runs over the metric values. Possible values are Average, Count, Minimum, Maximum and Total.</summary>
    [JsonPropertyName("aggregation")]
    public string? Aggregation { get; set; }

    /// <summary>One or more dimension blocks as defined below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1MonitorMetricAlertStatusAtProviderCriteriaDimension>? Dimension { get; set; }

    /// <summary>One of the metric names to be monitored.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>One of the metric namespaces to be monitored.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>The criteria operator. Possible values are Equals, GreaterThan, GreaterThanOrEqual, LessThan and LessThanOrEqual.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Skip the metric validation to allow creating an alert rule on a custom metric that isn't yet emitted? Defaults to false.</summary>
    [JsonPropertyName("skipMetricValidation")]
    public bool? SkipMetricValidation { get; set; }

    /// <summary>The criteria threshold value that activates the alert.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertStatusAtProviderDynamicCriteriaDimension
{
    /// <summary>The name of the Metric Alert. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The criteria operator. Possible values are LessThan, GreaterThan and GreaterOrLessThan.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>The list of dimension values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertStatusAtProviderDynamicCriteria
{
    /// <summary>The statistic that runs over the metric values. Possible values are Average, Count, Minimum, Maximum and Total.</summary>
    [JsonPropertyName("aggregation")]
    public string? Aggregation { get; set; }

    /// <summary>The extent of deviation required to trigger an alert. Possible values are Low, Medium and High.</summary>
    [JsonPropertyName("alertSensitivity")]
    public string? AlertSensitivity { get; set; }

    /// <summary>One or more dimension blocks as defined below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1MonitorMetricAlertStatusAtProviderDynamicCriteriaDimension>? Dimension { get; set; }

    /// <summary>The number of violations to trigger an alert. Should be smaller or equal to evaluation_total_count. Defaults to 4.</summary>
    [JsonPropertyName("evaluationFailureCount")]
    public double? EvaluationFailureCount { get; set; }

    /// <summary>The number of aggregated lookback points. The lookback time window is calculated based on the aggregation granularity (window_size) and the selected number of aggregated points. Defaults to 4.</summary>
    [JsonPropertyName("evaluationTotalCount")]
    public double? EvaluationTotalCount { get; set; }

    /// <summary>The ISO8601 date from which to start learning the metric historical data and calculate the dynamic thresholds.</summary>
    [JsonPropertyName("ignoreDataBefore")]
    public string? IgnoreDataBefore { get; set; }

    /// <summary>One of the metric names to be monitored.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>One of the metric namespaces to be monitored.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>The criteria operator. Possible values are LessThan, GreaterThan and GreaterOrLessThan.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Skip the metric validation to allow creating an alert rule on a custom metric that isn't yet emitted?</summary>
    [JsonPropertyName("skipMetricValidation")]
    public bool? SkipMetricValidation { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertStatusAtProvider
{
    /// <summary>One or more action blocks as defined below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1MonitorMetricAlertStatusAtProviderAction>? Action { get; set; }

    /// <summary>A application_insights_web_test_location_availability_criteria block as defined below.</summary>
    [JsonPropertyName("applicationInsightsWebTestLocationAvailabilityCriteria")]
    public IList<V1beta1MonitorMetricAlertStatusAtProviderApplicationInsightsWebTestLocationAvailabilityCriteria>? ApplicationInsightsWebTestLocationAvailabilityCriteria { get; set; }

    /// <summary>Should the alerts in this Metric Alert be auto resolved? Defaults to true.</summary>
    [JsonPropertyName("autoMitigate")]
    public bool? AutoMitigate { get; set; }

    /// <summary>One or more (static) criteria blocks as defined below.</summary>
    [JsonPropertyName("criteria")]
    public IList<V1beta1MonitorMetricAlertStatusAtProviderCriteria>? Criteria { get; set; }

    /// <summary>The description of this Metric Alert.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A dynamic_criteria block as defined below.</summary>
    [JsonPropertyName("dynamicCriteria")]
    public IList<V1beta1MonitorMetricAlertStatusAtProviderDynamicCriteria>? DynamicCriteria { get; set; }

    /// <summary>Should this Metric Alert be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The evaluation frequency of this Metric Alert, represented in ISO 8601 duration format. Possible values are PT1M, PT5M, PT15M, PT30M and PT1H. Defaults to PT1M.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>The ID of the metric alert.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the resource group in which to create the Metric Alert instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A set of strings of resource IDs at which the metric criteria should be applied.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>The severity of this Metric Alert. Possible values are 0, 1, 2, 3 and 4. Defaults to 3.</summary>
    [JsonPropertyName("severity")]
    public double? Severity { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The location of the target resource. The location of the target pluginsdk. Required when using subscription, resource group scope or multiple scopes.</summary>
    [JsonPropertyName("targetResourceLocation")]
    public string? TargetResourceLocation { get; set; }

    /// <summary>The resource type (e.g. Microsoft.Compute/virtualMachines) of the target resource. The resource type (e.g. Microsoft.Compute/virtualMachines) of the target pluginsdk. Required when using subscription, resource group scope or multiple scopes.</summary>
    [JsonPropertyName("targetResourceType")]
    public string? TargetResourceType { get; set; }

    /// <summary>The period of time that is used to monitor alert activity, represented in ISO 8601 duration format. This value must be greater than frequency. Possible values are PT1M, PT5M, PT15M, PT30M, PT1H, PT6H, PT12H and P1D. Defaults to PT5M.</summary>
    [JsonPropertyName("windowSize")]
    public string? WindowSize { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertStatusConditions
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

/// <summary>MonitorMetricAlertStatus defines the observed state of MonitorMetricAlert.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorMetricAlertStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1MonitorMetricAlertStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MonitorMetricAlertStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MonitorMetricAlert is the Schema for the MonitorMetricAlerts API. Manages a Metric Alert within Azure Monitor</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MonitorMetricAlert : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MonitorMetricAlertSpec>, IStatus<V1beta1MonitorMetricAlertStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MonitorMetricAlert";
    public const string KubeGroup = "insights.azure.upbound.io";
    public const string KubePluralName = "monitormetricalerts";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MonitorMetricAlertSpec defines the desired state of MonitorMetricAlert</summary>
    [JsonPropertyName("spec")]
    public V1beta1MonitorMetricAlertSpec Spec { get; set; }

    /// <summary>MonitorMetricAlertStatus defines the observed state of MonitorMetricAlert.</summary>
    [JsonPropertyName("status")]
    public V1beta1MonitorMetricAlertStatus? Status { get; set; }
}

/// <summary>MonitorMetricAlert is the Schema for the MonitorMetricAlerts API. Manages a Metric Alert within Azure Monitor</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MonitorMetricAlertList : IKubernetesObject<V1ListMeta>, IItems<V1beta1MonitorMetricAlert>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MonitorMetricAlertList";
    public const string KubeGroup = "insights.azure.upbound.io";
    public const string KubePluralName = "monitormetricalerts";
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
    public IList<V1beta1MonitorMetricAlert> Items { get; set; }
}