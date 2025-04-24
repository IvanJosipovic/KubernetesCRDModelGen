using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.insights.azure.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecForProviderNotificationEmail
{
    /// <summary>Specifies a list of custom email addresses to which the email notifications will be sent.</summary>
    [JsonPropertyName("customEmails")]
    public IList<string>? CustomEmails { get; set; }

    /// <summary>Should email notifications be sent to the subscription administrator? Defaults to false.</summary>
    [JsonPropertyName("sendToSubscriptionAdministrator")]
    public bool? SendToSubscriptionAdministrator { get; set; }

    /// <summary>Should email notifications be sent to the subscription co-administrator? Defaults to false.</summary>
    [JsonPropertyName("sendToSubscriptionCoAdministrator")]
    public bool? SendToSubscriptionCoAdministrator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecForProviderNotificationWebhook
{
    /// <summary>A map of settings.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HTTPS URI which should receive scale notifications.</summary>
    [JsonPropertyName("serviceUri")]
    public string? ServiceUri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecForProviderNotification
{
    /// <summary>A email block as defined below.</summary>
    [JsonPropertyName("email")]
    public IList<V1beta1MonitorAutoscaleSettingSpecForProviderNotificationEmail>? Email { get; set; }

    /// <summary>One or more webhook blocks as defined below.</summary>
    [JsonPropertyName("webhook")]
    public IList<V1beta1MonitorAutoscaleSettingSpecForProviderNotificationWebhook>? Webhook { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecForProviderPredictive
{
    /// <summary>Specifies the amount of time by which instances are launched in advance. It must be between PT1M and PT1H in ISO 8601 format.</summary>
    [JsonPropertyName("lookAheadTime")]
    public string? LookAheadTime { get; set; }

    /// <summary>Specifies the predictive scale mode. Possible values are Enabled or ForecastOnly.</summary>
    [JsonPropertyName("scaleMode")]
    public string? ScaleMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecForProviderProfileCapacity
{
    /// <summary>The number of instances that are available for scaling if metrics are not available for evaluation. The default is only used if the current instance count is lower than the default. Valid values are between 0 and 1000.</summary>
    [JsonPropertyName("default")]
    public double? Default { get; set; }

    /// <summary>The maximum number of instances for this resource. Valid values are between 0 and 1000.</summary>
    [JsonPropertyName("maximum")]
    public double? Maximum { get; set; }

    /// <summary>The minimum number of instances for this resource. Valid values are between 0 and 1000.</summary>
    [JsonPropertyName("minimum")]
    public double? Minimum { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecForProviderProfileFixedDate
{
    /// <summary>Specifies the end date for the profile, formatted as an RFC3339 date string.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>Specifies the start date for the profile, formatted as an RFC3339 date string.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }

    /// <summary>The Time Zone used for the hours field. A list of possible values can be found here. Defaults to UTC.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecForProviderProfileRecurrence
{
    /// <summary>A list of days that this profile takes effect on. Possible values include Monday, Tuesday, Wednesday, Thursday, Friday, Saturday and Sunday.</summary>
    [JsonPropertyName("days")]
    public IList<string>? Days { get; set; }

    /// <summary>A list containing a single item, which specifies the Hour interval at which this recurrence should be triggered (in 24-hour time). Possible values are from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public IList<double>? Hours { get; set; }

    /// <summary>A list containing a single item which specifies the Minute interval at which this recurrence should be triggered.</summary>
    [JsonPropertyName("minutes")]
    public IList<double>? Minutes { get; set; }

    /// <summary>The Time Zone used for the hours field. A list of possible values can be found here. Defaults to UTC.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerDimensions
{
    /// <summary>Specifies the name of the profile.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the operator used to compare the metric data and threshold. Possible values are: Equals, NotEquals, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of dimension values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerMetricResourceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LinuxVirtualMachineScaleSet in compute to populate metricResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerMetricResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerMetricResourceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerMetricResourceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LinuxVirtualMachineScaleSet in compute to populate metricResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerMetricResourceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerMetricResourceIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTrigger
{
    /// <summary>One or more dimensions block as defined below.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta1MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerDimensions>? Dimensions { get; set; }

    /// <summary>Whether to enable metric divide by instance count.</summary>
    [JsonPropertyName("divideByInstanceCount")]
    public bool? DivideByInstanceCount { get; set; }

    /// <summary>The name of the metric that defines what the rule monitors, such as Percentage CPU for Virtual Machine Scale Sets and CpuPercentage for App Service Plan.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The namespace of the metric that defines what the rule monitors, such as microsoft.compute/virtualmachinescalesets for Virtual Machine Scale Sets.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>The ID of the Resource which the Rule monitors.</summary>
    [JsonPropertyName("metricResourceId")]
    public string? MetricResourceId { get; set; }

    /// <summary>Reference to a LinuxVirtualMachineScaleSet in compute to populate metricResourceId.</summary>
    [JsonPropertyName("metricResourceIdRef")]
    public V1beta1MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerMetricResourceIdRef? MetricResourceIdRef { get; set; }

    /// <summary>Selector for a LinuxVirtualMachineScaleSet in compute to populate metricResourceId.</summary>
    [JsonPropertyName("metricResourceIdSelector")]
    public V1beta1MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTriggerMetricResourceIdSelector? MetricResourceIdSelector { get; set; }

    /// <summary>Specifies the operator used to compare the metric data and threshold. Possible values are: Equals, NotEquals, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Specifies how the metrics from multiple instances are combined. Possible values are Average, Max, Min and Sum.</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Specifies the threshold of the metric that triggers the scale action.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>Specifies how the data that's collected should be combined over time. Possible values include Average, Count, Maximum, Minimum, Last and Total.</summary>
    [JsonPropertyName("timeAggregation")]
    public string? TimeAggregation { get; set; }

    /// <summary>Specifies the granularity of metrics that the rule monitors, which must be one of the pre-defined values returned from the metric definitions for the metric. This value must be between 1 minute and 12 hours an be formatted as an ISO 8601 string.</summary>
    [JsonPropertyName("timeGrain")]
    public string? TimeGrain { get; set; }

    /// <summary>Specifies the time range for which data is collected, which must be greater than the delay in metric collection (which varies from resource to resource). This value must be between 5 minutes and 12 hours and be formatted as an ISO 8601 string.</summary>
    [JsonPropertyName("timeWindow")]
    public string? TimeWindow { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecForProviderProfileRuleScaleAction
{
    /// <summary>The amount of time to wait since the last scaling action before this action occurs. Must be between 1 minute and 1 week and formatted as a ISO 8601 string.</summary>
    [JsonPropertyName("cooldown")]
    public string? Cooldown { get; set; }

    /// <summary>The scale direction. Possible values are Increase and Decrease.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>The type of action that should occur. Possible values are ChangeCount, ExactCount, PercentChangeCount and ServiceAllowedNextValue.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The number of instances involved in the scaling action.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecForProviderProfileRule
{
    /// <summary>A metric_trigger block as defined below.</summary>
    [JsonPropertyName("metricTrigger")]
    public IList<V1beta1MonitorAutoscaleSettingSpecForProviderProfileRuleMetricTrigger>? MetricTrigger { get; set; }

    /// <summary>A scale_action block as defined below.</summary>
    [JsonPropertyName("scaleAction")]
    public IList<V1beta1MonitorAutoscaleSettingSpecForProviderProfileRuleScaleAction>? ScaleAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecForProviderProfile
{
    /// <summary>A capacity block as defined below.</summary>
    [JsonPropertyName("capacity")]
    public IList<V1beta1MonitorAutoscaleSettingSpecForProviderProfileCapacity>? Capacity { get; set; }

    /// <summary>A fixed_date block as defined below. This cannot be specified if a recurrence block is specified.</summary>
    [JsonPropertyName("fixedDate")]
    public IList<V1beta1MonitorAutoscaleSettingSpecForProviderProfileFixedDate>? FixedDate { get; set; }

    /// <summary>Specifies the name of the profile.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A recurrence block as defined below. This cannot be specified if a fixed_date block is specified.</summary>
    [JsonPropertyName("recurrence")]
    public IList<V1beta1MonitorAutoscaleSettingSpecForProviderProfileRecurrence>? Recurrence { get; set; }

    /// <summary>One or more (up to 10) rule blocks as defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1MonitorAutoscaleSettingSpecForProviderProfileRule>? Rule { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1MonitorAutoscaleSettingSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorAutoscaleSettingSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1MonitorAutoscaleSettingSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorAutoscaleSettingSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecForProviderTargetResourceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LinuxVirtualMachineScaleSet in compute to populate targetResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecForProviderTargetResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorAutoscaleSettingSpecForProviderTargetResourceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecForProviderTargetResourceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LinuxVirtualMachineScaleSet in compute to populate targetResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecForProviderTargetResourceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorAutoscaleSettingSpecForProviderTargetResourceIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecForProvider
{
    /// <summary>Specifies whether automatic scaling is enabled for the target resource. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the supported Azure location where the AutoScale Setting should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the AutoScale Setting. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a notification block as defined below.</summary>
    [JsonPropertyName("notification")]
    public IList<V1beta1MonitorAutoscaleSettingSpecForProviderNotification>? Notification { get; set; }

    /// <summary>A predictive block as defined below.</summary>
    [JsonPropertyName("predictive")]
    public IList<V1beta1MonitorAutoscaleSettingSpecForProviderPredictive>? Predictive { get; set; }

    /// <summary>Specifies one or more (up to 20) profile blocks as defined below.</summary>
    [JsonPropertyName("profile")]
    public IList<V1beta1MonitorAutoscaleSettingSpecForProviderProfile>? Profile { get; set; }

    /// <summary>The name of the Resource Group in the AutoScale Setting should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1MonitorAutoscaleSettingSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1MonitorAutoscaleSettingSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the resource ID of the resource that the autoscale setting should be added to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("targetResourceId")]
    public string? TargetResourceId { get; set; }

    /// <summary>Reference to a LinuxVirtualMachineScaleSet in compute to populate targetResourceId.</summary>
    [JsonPropertyName("targetResourceIdRef")]
    public V1beta1MonitorAutoscaleSettingSpecForProviderTargetResourceIdRef? TargetResourceIdRef { get; set; }

    /// <summary>Selector for a LinuxVirtualMachineScaleSet in compute to populate targetResourceId.</summary>
    [JsonPropertyName("targetResourceIdSelector")]
    public V1beta1MonitorAutoscaleSettingSpecForProviderTargetResourceIdSelector? TargetResourceIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecInitProviderNotificationEmail
{
    /// <summary>Specifies a list of custom email addresses to which the email notifications will be sent.</summary>
    [JsonPropertyName("customEmails")]
    public IList<string>? CustomEmails { get; set; }

    /// <summary>Should email notifications be sent to the subscription administrator? Defaults to false.</summary>
    [JsonPropertyName("sendToSubscriptionAdministrator")]
    public bool? SendToSubscriptionAdministrator { get; set; }

    /// <summary>Should email notifications be sent to the subscription co-administrator? Defaults to false.</summary>
    [JsonPropertyName("sendToSubscriptionCoAdministrator")]
    public bool? SendToSubscriptionCoAdministrator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecInitProviderNotificationWebhook
{
    /// <summary>A map of settings.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HTTPS URI which should receive scale notifications.</summary>
    [JsonPropertyName("serviceUri")]
    public string? ServiceUri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecInitProviderNotification
{
    /// <summary>A email block as defined below.</summary>
    [JsonPropertyName("email")]
    public IList<V1beta1MonitorAutoscaleSettingSpecInitProviderNotificationEmail>? Email { get; set; }

    /// <summary>One or more webhook blocks as defined below.</summary>
    [JsonPropertyName("webhook")]
    public IList<V1beta1MonitorAutoscaleSettingSpecInitProviderNotificationWebhook>? Webhook { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecInitProviderPredictive
{
    /// <summary>Specifies the amount of time by which instances are launched in advance. It must be between PT1M and PT1H in ISO 8601 format.</summary>
    [JsonPropertyName("lookAheadTime")]
    public string? LookAheadTime { get; set; }

    /// <summary>Specifies the predictive scale mode. Possible values are Enabled or ForecastOnly.</summary>
    [JsonPropertyName("scaleMode")]
    public string? ScaleMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecInitProviderProfileCapacity
{
    /// <summary>The number of instances that are available for scaling if metrics are not available for evaluation. The default is only used if the current instance count is lower than the default. Valid values are between 0 and 1000.</summary>
    [JsonPropertyName("default")]
    public double? Default { get; set; }

    /// <summary>The maximum number of instances for this resource. Valid values are between 0 and 1000.</summary>
    [JsonPropertyName("maximum")]
    public double? Maximum { get; set; }

    /// <summary>The minimum number of instances for this resource. Valid values are between 0 and 1000.</summary>
    [JsonPropertyName("minimum")]
    public double? Minimum { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecInitProviderProfileFixedDate
{
    /// <summary>Specifies the end date for the profile, formatted as an RFC3339 date string.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>Specifies the start date for the profile, formatted as an RFC3339 date string.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }

    /// <summary>The Time Zone used for the hours field. A list of possible values can be found here. Defaults to UTC.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecInitProviderProfileRecurrence
{
    /// <summary>A list of days that this profile takes effect on. Possible values include Monday, Tuesday, Wednesday, Thursday, Friday, Saturday and Sunday.</summary>
    [JsonPropertyName("days")]
    public IList<string>? Days { get; set; }

    /// <summary>A list containing a single item, which specifies the Hour interval at which this recurrence should be triggered (in 24-hour time). Possible values are from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public IList<double>? Hours { get; set; }

    /// <summary>A list containing a single item which specifies the Minute interval at which this recurrence should be triggered.</summary>
    [JsonPropertyName("minutes")]
    public IList<double>? Minutes { get; set; }

    /// <summary>The Time Zone used for the hours field. A list of possible values can be found here. Defaults to UTC.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerDimensions
{
    /// <summary>Specifies the name of the profile.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the operator used to compare the metric data and threshold. Possible values are: Equals, NotEquals, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of dimension values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerMetricResourceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LinuxVirtualMachineScaleSet in compute to populate metricResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerMetricResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerMetricResourceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerMetricResourceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LinuxVirtualMachineScaleSet in compute to populate metricResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerMetricResourceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerMetricResourceIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTrigger
{
    /// <summary>One or more dimensions block as defined below.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta1MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerDimensions>? Dimensions { get; set; }

    /// <summary>Whether to enable metric divide by instance count.</summary>
    [JsonPropertyName("divideByInstanceCount")]
    public bool? DivideByInstanceCount { get; set; }

    /// <summary>The name of the metric that defines what the rule monitors, such as Percentage CPU for Virtual Machine Scale Sets and CpuPercentage for App Service Plan.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The namespace of the metric that defines what the rule monitors, such as microsoft.compute/virtualmachinescalesets for Virtual Machine Scale Sets.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>The ID of the Resource which the Rule monitors.</summary>
    [JsonPropertyName("metricResourceId")]
    public string? MetricResourceId { get; set; }

    /// <summary>Reference to a LinuxVirtualMachineScaleSet in compute to populate metricResourceId.</summary>
    [JsonPropertyName("metricResourceIdRef")]
    public V1beta1MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerMetricResourceIdRef? MetricResourceIdRef { get; set; }

    /// <summary>Selector for a LinuxVirtualMachineScaleSet in compute to populate metricResourceId.</summary>
    [JsonPropertyName("metricResourceIdSelector")]
    public V1beta1MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTriggerMetricResourceIdSelector? MetricResourceIdSelector { get; set; }

    /// <summary>Specifies the operator used to compare the metric data and threshold. Possible values are: Equals, NotEquals, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Specifies how the metrics from multiple instances are combined. Possible values are Average, Max, Min and Sum.</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Specifies the threshold of the metric that triggers the scale action.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>Specifies how the data that's collected should be combined over time. Possible values include Average, Count, Maximum, Minimum, Last and Total.</summary>
    [JsonPropertyName("timeAggregation")]
    public string? TimeAggregation { get; set; }

    /// <summary>Specifies the granularity of metrics that the rule monitors, which must be one of the pre-defined values returned from the metric definitions for the metric. This value must be between 1 minute and 12 hours an be formatted as an ISO 8601 string.</summary>
    [JsonPropertyName("timeGrain")]
    public string? TimeGrain { get; set; }

    /// <summary>Specifies the time range for which data is collected, which must be greater than the delay in metric collection (which varies from resource to resource). This value must be between 5 minutes and 12 hours and be formatted as an ISO 8601 string.</summary>
    [JsonPropertyName("timeWindow")]
    public string? TimeWindow { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecInitProviderProfileRuleScaleAction
{
    /// <summary>The amount of time to wait since the last scaling action before this action occurs. Must be between 1 minute and 1 week and formatted as a ISO 8601 string.</summary>
    [JsonPropertyName("cooldown")]
    public string? Cooldown { get; set; }

    /// <summary>The scale direction. Possible values are Increase and Decrease.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>The type of action that should occur. Possible values are ChangeCount, ExactCount, PercentChangeCount and ServiceAllowedNextValue.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The number of instances involved in the scaling action.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecInitProviderProfileRule
{
    /// <summary>A metric_trigger block as defined below.</summary>
    [JsonPropertyName("metricTrigger")]
    public IList<V1beta1MonitorAutoscaleSettingSpecInitProviderProfileRuleMetricTrigger>? MetricTrigger { get; set; }

    /// <summary>A scale_action block as defined below.</summary>
    [JsonPropertyName("scaleAction")]
    public IList<V1beta1MonitorAutoscaleSettingSpecInitProviderProfileRuleScaleAction>? ScaleAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecInitProviderProfile
{
    /// <summary>A capacity block as defined below.</summary>
    [JsonPropertyName("capacity")]
    public IList<V1beta1MonitorAutoscaleSettingSpecInitProviderProfileCapacity>? Capacity { get; set; }

    /// <summary>A fixed_date block as defined below. This cannot be specified if a recurrence block is specified.</summary>
    [JsonPropertyName("fixedDate")]
    public IList<V1beta1MonitorAutoscaleSettingSpecInitProviderProfileFixedDate>? FixedDate { get; set; }

    /// <summary>Specifies the name of the profile.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A recurrence block as defined below. This cannot be specified if a fixed_date block is specified.</summary>
    [JsonPropertyName("recurrence")]
    public IList<V1beta1MonitorAutoscaleSettingSpecInitProviderProfileRecurrence>? Recurrence { get; set; }

    /// <summary>One or more (up to 10) rule blocks as defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1MonitorAutoscaleSettingSpecInitProviderProfileRule>? Rule { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecInitProviderResourceGroupNameRefPolicy
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
public partial class V1beta1MonitorAutoscaleSettingSpecInitProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorAutoscaleSettingSpecInitProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecInitProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1MonitorAutoscaleSettingSpecInitProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorAutoscaleSettingSpecInitProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecInitProviderTargetResourceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LinuxVirtualMachineScaleSet in compute to populate targetResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecInitProviderTargetResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorAutoscaleSettingSpecInitProviderTargetResourceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecInitProviderTargetResourceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LinuxVirtualMachineScaleSet in compute to populate targetResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecInitProviderTargetResourceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorAutoscaleSettingSpecInitProviderTargetResourceIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecInitProvider
{
    /// <summary>Specifies whether automatic scaling is enabled for the target resource. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the supported Azure location where the AutoScale Setting should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the AutoScale Setting. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a notification block as defined below.</summary>
    [JsonPropertyName("notification")]
    public IList<V1beta1MonitorAutoscaleSettingSpecInitProviderNotification>? Notification { get; set; }

    /// <summary>A predictive block as defined below.</summary>
    [JsonPropertyName("predictive")]
    public IList<V1beta1MonitorAutoscaleSettingSpecInitProviderPredictive>? Predictive { get; set; }

    /// <summary>Specifies one or more (up to 20) profile blocks as defined below.</summary>
    [JsonPropertyName("profile")]
    public IList<V1beta1MonitorAutoscaleSettingSpecInitProviderProfile>? Profile { get; set; }

    /// <summary>The name of the Resource Group in the AutoScale Setting should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1MonitorAutoscaleSettingSpecInitProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1MonitorAutoscaleSettingSpecInitProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the resource ID of the resource that the autoscale setting should be added to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("targetResourceId")]
    public string? TargetResourceId { get; set; }

    /// <summary>Reference to a LinuxVirtualMachineScaleSet in compute to populate targetResourceId.</summary>
    [JsonPropertyName("targetResourceIdRef")]
    public V1beta1MonitorAutoscaleSettingSpecInitProviderTargetResourceIdRef? TargetResourceIdRef { get; set; }

    /// <summary>Selector for a LinuxVirtualMachineScaleSet in compute to populate targetResourceId.</summary>
    [JsonPropertyName("targetResourceIdSelector")]
    public V1beta1MonitorAutoscaleSettingSpecInitProviderTargetResourceIdSelector? TargetResourceIdSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecProviderConfigRefPolicy
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
public partial class V1beta1MonitorAutoscaleSettingSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorAutoscaleSettingSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1MonitorAutoscaleSettingSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorAutoscaleSettingSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1MonitorAutoscaleSettingSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1MonitorAutoscaleSettingSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1MonitorAutoscaleSettingSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>MonitorAutoscaleSettingSpec defines the desired state of MonitorAutoscaleSetting</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1MonitorAutoscaleSettingSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1MonitorAutoscaleSettingSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MonitorAutoscaleSettingSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1MonitorAutoscaleSettingSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MonitorAutoscaleSettingSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingStatusAtProviderNotificationEmail
{
    /// <summary>Specifies a list of custom email addresses to which the email notifications will be sent.</summary>
    [JsonPropertyName("customEmails")]
    public IList<string>? CustomEmails { get; set; }

    /// <summary>Should email notifications be sent to the subscription administrator? Defaults to false.</summary>
    [JsonPropertyName("sendToSubscriptionAdministrator")]
    public bool? SendToSubscriptionAdministrator { get; set; }

    /// <summary>Should email notifications be sent to the subscription co-administrator? Defaults to false.</summary>
    [JsonPropertyName("sendToSubscriptionCoAdministrator")]
    public bool? SendToSubscriptionCoAdministrator { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingStatusAtProviderNotificationWebhook
{
    /// <summary>A map of settings.</summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary>The HTTPS URI which should receive scale notifications.</summary>
    [JsonPropertyName("serviceUri")]
    public string? ServiceUri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingStatusAtProviderNotification
{
    /// <summary>A email block as defined below.</summary>
    [JsonPropertyName("email")]
    public IList<V1beta1MonitorAutoscaleSettingStatusAtProviderNotificationEmail>? Email { get; set; }

    /// <summary>One or more webhook blocks as defined below.</summary>
    [JsonPropertyName("webhook")]
    public IList<V1beta1MonitorAutoscaleSettingStatusAtProviderNotificationWebhook>? Webhook { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingStatusAtProviderPredictive
{
    /// <summary>Specifies the amount of time by which instances are launched in advance. It must be between PT1M and PT1H in ISO 8601 format.</summary>
    [JsonPropertyName("lookAheadTime")]
    public string? LookAheadTime { get; set; }

    /// <summary>Specifies the predictive scale mode. Possible values are Enabled or ForecastOnly.</summary>
    [JsonPropertyName("scaleMode")]
    public string? ScaleMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingStatusAtProviderProfileCapacity
{
    /// <summary>The number of instances that are available for scaling if metrics are not available for evaluation. The default is only used if the current instance count is lower than the default. Valid values are between 0 and 1000.</summary>
    [JsonPropertyName("default")]
    public double? Default { get; set; }

    /// <summary>The maximum number of instances for this resource. Valid values are between 0 and 1000.</summary>
    [JsonPropertyName("maximum")]
    public double? Maximum { get; set; }

    /// <summary>The minimum number of instances for this resource. Valid values are between 0 and 1000.</summary>
    [JsonPropertyName("minimum")]
    public double? Minimum { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingStatusAtProviderProfileFixedDate
{
    /// <summary>Specifies the end date for the profile, formatted as an RFC3339 date string.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>Specifies the start date for the profile, formatted as an RFC3339 date string.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }

    /// <summary>The Time Zone used for the hours field. A list of possible values can be found here. Defaults to UTC.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingStatusAtProviderProfileRecurrence
{
    /// <summary>A list of days that this profile takes effect on. Possible values include Monday, Tuesday, Wednesday, Thursday, Friday, Saturday and Sunday.</summary>
    [JsonPropertyName("days")]
    public IList<string>? Days { get; set; }

    /// <summary>A list containing a single item, which specifies the Hour interval at which this recurrence should be triggered (in 24-hour time). Possible values are from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public IList<double>? Hours { get; set; }

    /// <summary>A list containing a single item which specifies the Minute interval at which this recurrence should be triggered.</summary>
    [JsonPropertyName("minutes")]
    public IList<double>? Minutes { get; set; }

    /// <summary>The Time Zone used for the hours field. A list of possible values can be found here. Defaults to UTC.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingStatusAtProviderProfileRuleMetricTriggerDimensions
{
    /// <summary>Specifies the name of the profile.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the operator used to compare the metric data and threshold. Possible values are: Equals, NotEquals, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of dimension values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingStatusAtProviderProfileRuleMetricTrigger
{
    /// <summary>One or more dimensions block as defined below.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta1MonitorAutoscaleSettingStatusAtProviderProfileRuleMetricTriggerDimensions>? Dimensions { get; set; }

    /// <summary>Whether to enable metric divide by instance count.</summary>
    [JsonPropertyName("divideByInstanceCount")]
    public bool? DivideByInstanceCount { get; set; }

    /// <summary>The name of the metric that defines what the rule monitors, such as Percentage CPU for Virtual Machine Scale Sets and CpuPercentage for App Service Plan.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>The namespace of the metric that defines what the rule monitors, such as microsoft.compute/virtualmachinescalesets for Virtual Machine Scale Sets.</summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>The ID of the Resource which the Rule monitors.</summary>
    [JsonPropertyName("metricResourceId")]
    public string? MetricResourceId { get; set; }

    /// <summary>Specifies the operator used to compare the metric data and threshold. Possible values are: Equals, NotEquals, GreaterThan, GreaterThanOrEqual, LessThan, LessThanOrEqual.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Specifies how the metrics from multiple instances are combined. Possible values are Average, Max, Min and Sum.</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Specifies the threshold of the metric that triggers the scale action.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>Specifies how the data that's collected should be combined over time. Possible values include Average, Count, Maximum, Minimum, Last and Total.</summary>
    [JsonPropertyName("timeAggregation")]
    public string? TimeAggregation { get; set; }

    /// <summary>Specifies the granularity of metrics that the rule monitors, which must be one of the pre-defined values returned from the metric definitions for the metric. This value must be between 1 minute and 12 hours an be formatted as an ISO 8601 string.</summary>
    [JsonPropertyName("timeGrain")]
    public string? TimeGrain { get; set; }

    /// <summary>Specifies the time range for which data is collected, which must be greater than the delay in metric collection (which varies from resource to resource). This value must be between 5 minutes and 12 hours and be formatted as an ISO 8601 string.</summary>
    [JsonPropertyName("timeWindow")]
    public string? TimeWindow { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingStatusAtProviderProfileRuleScaleAction
{
    /// <summary>The amount of time to wait since the last scaling action before this action occurs. Must be between 1 minute and 1 week and formatted as a ISO 8601 string.</summary>
    [JsonPropertyName("cooldown")]
    public string? Cooldown { get; set; }

    /// <summary>The scale direction. Possible values are Increase and Decrease.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>The type of action that should occur. Possible values are ChangeCount, ExactCount, PercentChangeCount and ServiceAllowedNextValue.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The number of instances involved in the scaling action.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingStatusAtProviderProfileRule
{
    /// <summary>A metric_trigger block as defined below.</summary>
    [JsonPropertyName("metricTrigger")]
    public IList<V1beta1MonitorAutoscaleSettingStatusAtProviderProfileRuleMetricTrigger>? MetricTrigger { get; set; }

    /// <summary>A scale_action block as defined below.</summary>
    [JsonPropertyName("scaleAction")]
    public IList<V1beta1MonitorAutoscaleSettingStatusAtProviderProfileRuleScaleAction>? ScaleAction { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingStatusAtProviderProfile
{
    /// <summary>A capacity block as defined below.</summary>
    [JsonPropertyName("capacity")]
    public IList<V1beta1MonitorAutoscaleSettingStatusAtProviderProfileCapacity>? Capacity { get; set; }

    /// <summary>A fixed_date block as defined below. This cannot be specified if a recurrence block is specified.</summary>
    [JsonPropertyName("fixedDate")]
    public IList<V1beta1MonitorAutoscaleSettingStatusAtProviderProfileFixedDate>? FixedDate { get; set; }

    /// <summary>Specifies the name of the profile.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A recurrence block as defined below. This cannot be specified if a fixed_date block is specified.</summary>
    [JsonPropertyName("recurrence")]
    public IList<V1beta1MonitorAutoscaleSettingStatusAtProviderProfileRecurrence>? Recurrence { get; set; }

    /// <summary>One or more (up to 10) rule blocks as defined below.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1MonitorAutoscaleSettingStatusAtProviderProfileRule>? Rule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingStatusAtProvider
{
    /// <summary>Specifies whether automatic scaling is enabled for the target resource. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The ID of the AutoScale Setting.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the supported Azure location where the AutoScale Setting should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the AutoScale Setting. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies a notification block as defined below.</summary>
    [JsonPropertyName("notification")]
    public IList<V1beta1MonitorAutoscaleSettingStatusAtProviderNotification>? Notification { get; set; }

    /// <summary>A predictive block as defined below.</summary>
    [JsonPropertyName("predictive")]
    public IList<V1beta1MonitorAutoscaleSettingStatusAtProviderPredictive>? Predictive { get; set; }

    /// <summary>Specifies one or more (up to 20) profile blocks as defined below.</summary>
    [JsonPropertyName("profile")]
    public IList<V1beta1MonitorAutoscaleSettingStatusAtProviderProfile>? Profile { get; set; }

    /// <summary>The name of the Resource Group in the AutoScale Setting should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the resource ID of the resource that the autoscale setting should be added to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("targetResourceId")]
    public string? TargetResourceId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingStatusConditions
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

/// <summary>MonitorAutoscaleSettingStatus defines the observed state of MonitorAutoscaleSetting.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAutoscaleSettingStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1MonitorAutoscaleSettingStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MonitorAutoscaleSettingStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MonitorAutoscaleSetting is the Schema for the MonitorAutoscaleSettings API. Manages an AutoScale Setting which can be applied to Virtual Machine Scale Sets, App Services and other scalable resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MonitorAutoscaleSetting : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MonitorAutoscaleSettingSpec>, IStatus<V1beta1MonitorAutoscaleSettingStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MonitorAutoscaleSetting";
    public const string KubeGroup = "insights.azure.upbound.io";
    public const string KubePluralName = "monitorautoscalesettings";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MonitorAutoscaleSettingSpec defines the desired state of MonitorAutoscaleSetting</summary>
    [JsonPropertyName("spec")]
    public V1beta1MonitorAutoscaleSettingSpec Spec { get; set; }

    /// <summary>MonitorAutoscaleSettingStatus defines the observed state of MonitorAutoscaleSetting.</summary>
    [JsonPropertyName("status")]
    public V1beta1MonitorAutoscaleSettingStatus? Status { get; set; }
}

/// <summary>MonitorAutoscaleSetting is the Schema for the MonitorAutoscaleSettings API. Manages an AutoScale Setting which can be applied to Virtual Machine Scale Sets, App Services and other scalable resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MonitorAutoscaleSettingList : IKubernetesObject<V1ListMeta>, IItems<V1beta1MonitorAutoscaleSetting>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MonitorAutoscaleSettingList";
    public const string KubeGroup = "insights.azure.upbound.io";
    public const string KubePluralName = "monitorautoscalesettings";
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
    public IList<V1beta1MonitorAutoscaleSetting> Items { get; set; }
}