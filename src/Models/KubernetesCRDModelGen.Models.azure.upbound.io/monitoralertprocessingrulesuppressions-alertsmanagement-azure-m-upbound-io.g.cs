using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.alertsmanagement.azure.m.upbound.io;
/// <summary>A alert_context block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderConditionAlertContext
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A alert_rule_id block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderConditionAlertRuleId
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A alert_rule_name block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderConditionAlertRuleName
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A description block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderConditionDescription
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A monitor_condition block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderConditionMonitorCondition
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A monitor_service block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderConditionMonitorService
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A severity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderConditionSeverity
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A signal_type block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderConditionSignalType
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A target_resource block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderConditionTargetResource
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A target_resource_group block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderConditionTargetResourceGroup
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A target_resource_type block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderConditionTargetResourceType
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A condition block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderCondition
{
    /// <summary>A alert_context block as defined above.</summary>
    [JsonPropertyName("alertContext")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderConditionAlertContext? AlertContext { get; set; }

    /// <summary>A alert_rule_id block as defined above.</summary>
    [JsonPropertyName("alertRuleId")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderConditionAlertRuleId? AlertRuleId { get; set; }

    /// <summary>A alert_rule_name block as defined above.</summary>
    [JsonPropertyName("alertRuleName")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderConditionAlertRuleName? AlertRuleName { get; set; }

    /// <summary>A description block as defined below.</summary>
    [JsonPropertyName("description")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderConditionDescription? Description { get; set; }

    /// <summary>A monitor_condition block as defined below.</summary>
    [JsonPropertyName("monitorCondition")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderConditionMonitorCondition? MonitorCondition { get; set; }

    /// <summary>A monitor_service block as defined below.</summary>
    [JsonPropertyName("monitorService")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderConditionMonitorService? MonitorService { get; set; }

    /// <summary>A severity block as defined below.</summary>
    [JsonPropertyName("severity")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderConditionSeverity? Severity { get; set; }

    /// <summary>A signal_type block as defined below.</summary>
    [JsonPropertyName("signalType")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderConditionSignalType? SignalType { get; set; }

    /// <summary>A target_resource block as defined below.</summary>
    [JsonPropertyName("targetResource")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderConditionTargetResource? TargetResource { get; set; }

    /// <summary>A target_resource_group block as defined below.</summary>
    [JsonPropertyName("targetResourceGroup")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderConditionTargetResourceGroup? TargetResourceGroup { get; set; }

    /// <summary>A target_resource_type block as defined below.</summary>
    [JsonPropertyName("targetResourceType")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderConditionTargetResourceType? TargetResourceType { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderResourceGroupNameSelector
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
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderScheduleRecurrenceDaily
{
    /// <summary>Specifies the recurrence end time (H:M:S).</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Specifies the recurrence start time (H:M:S).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderScheduleRecurrenceMonthly
{
    /// <summary>Specifies a list of dayOfMonth to recurrence. Possible values are integers between 1 - 31.</summary>
    [JsonPropertyName("daysOfMonth")]
    public IList<double>? DaysOfMonth { get; set; }

    /// <summary>Specifies the recurrence end time (H:M:S).</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Specifies the recurrence start time (H:M:S).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderScheduleRecurrenceWeekly
{
    /// <summary>Specifies a list of dayOfWeek to recurrence. Possible values are Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, and Saturday.</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    /// <summary>Specifies the recurrence end time (H:M:S).</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Specifies the recurrence start time (H:M:S).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary>A recurrence block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderScheduleRecurrence
{
    /// <summary>One or more daily blocks as defined above.</summary>
    [JsonPropertyName("daily")]
    public IList<V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderScheduleRecurrenceDaily>? Daily { get; set; }

    /// <summary>One or more monthly blocks as defined above.</summary>
    [JsonPropertyName("monthly")]
    public IList<V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderScheduleRecurrenceMonthly>? Monthly { get; set; }

    /// <summary>One or more weekly blocks as defined below.</summary>
    [JsonPropertyName("weekly")]
    public IList<V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderScheduleRecurrenceWeekly>? Weekly { get; set; }
}

/// <summary>A schedule block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderSchedule
{
    /// <summary>Specifies the Alert Processing Rule effective start time (Y-m-d'T'H:M:S).</summary>
    [JsonPropertyName("effectiveFrom")]
    public string? EffectiveFrom { get; set; }

    /// <summary>Specifies the Alert Processing Rule effective end time (Y-m-d'T'H:M:S).</summary>
    [JsonPropertyName("effectiveUntil")]
    public string? EffectiveUntil { get; set; }

    /// <summary>A recurrence block as defined above.</summary>
    [JsonPropertyName("recurrence")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderScheduleRecurrence? Recurrence { get; set; }

    /// <summary>The time zone (e.g. Pacific Standard time, Eastern Standard Time). Defaults to UTC. possible values are defined here.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderScopesRefsPolicy
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
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderScopesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderScopesRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderScopesSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of ResourceGroup in azure to populate scopes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderScopesSelector
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
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderScopesSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecForProvider
{
    /// <summary>A condition block as defined below.</summary>
    [JsonPropertyName("condition")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderCondition? Condition { get; set; }

    /// <summary>Specifies a description for the Alert Processing Rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Should the Alert Processing Rule be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the Resource Group where the Alert Processing Rule should exist. Changing this forces a new Alert Processing Rule to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A schedule block as defined below.</summary>
    [JsonPropertyName("schedule")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderSchedule? Schedule { get; set; }

    /// <summary>A list of resource IDs which will be the target of Alert Processing Rule.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>References to ResourceGroup in azure to populate scopes.</summary>
    [JsonPropertyName("scopesRefs")]
    public IList<V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderScopesRefs>? ScopesRefs { get; set; }

    /// <summary>Selector for a list of ResourceGroup in azure to populate scopes.</summary>
    [JsonPropertyName("scopesSelector")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecForProviderScopesSelector? ScopesSelector { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Alert Processing Rule.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A alert_context block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionAlertContext
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A alert_rule_id block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionAlertRuleId
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A alert_rule_name block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionAlertRuleName
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A description block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionDescription
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A monitor_condition block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionMonitorCondition
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A monitor_service block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionMonitorService
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A severity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionSeverity
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A signal_type block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionSignalType
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A target_resource block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionTargetResource
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A target_resource_group block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionTargetResourceGroup
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A target_resource_type block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionTargetResourceType
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A condition block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderCondition
{
    /// <summary>A alert_context block as defined above.</summary>
    [JsonPropertyName("alertContext")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionAlertContext? AlertContext { get; set; }

    /// <summary>A alert_rule_id block as defined above.</summary>
    [JsonPropertyName("alertRuleId")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionAlertRuleId? AlertRuleId { get; set; }

    /// <summary>A alert_rule_name block as defined above.</summary>
    [JsonPropertyName("alertRuleName")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionAlertRuleName? AlertRuleName { get; set; }

    /// <summary>A description block as defined below.</summary>
    [JsonPropertyName("description")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionDescription? Description { get; set; }

    /// <summary>A monitor_condition block as defined below.</summary>
    [JsonPropertyName("monitorCondition")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionMonitorCondition? MonitorCondition { get; set; }

    /// <summary>A monitor_service block as defined below.</summary>
    [JsonPropertyName("monitorService")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionMonitorService? MonitorService { get; set; }

    /// <summary>A severity block as defined below.</summary>
    [JsonPropertyName("severity")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionSeverity? Severity { get; set; }

    /// <summary>A signal_type block as defined below.</summary>
    [JsonPropertyName("signalType")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionSignalType? SignalType { get; set; }

    /// <summary>A target_resource block as defined below.</summary>
    [JsonPropertyName("targetResource")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionTargetResource? TargetResource { get; set; }

    /// <summary>A target_resource_group block as defined below.</summary>
    [JsonPropertyName("targetResourceGroup")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionTargetResourceGroup? TargetResourceGroup { get; set; }

    /// <summary>A target_resource_type block as defined below.</summary>
    [JsonPropertyName("targetResourceType")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderConditionTargetResourceType? TargetResourceType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderScheduleRecurrenceDaily
{
    /// <summary>Specifies the recurrence end time (H:M:S).</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Specifies the recurrence start time (H:M:S).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderScheduleRecurrenceMonthly
{
    /// <summary>Specifies a list of dayOfMonth to recurrence. Possible values are integers between 1 - 31.</summary>
    [JsonPropertyName("daysOfMonth")]
    public IList<double>? DaysOfMonth { get; set; }

    /// <summary>Specifies the recurrence end time (H:M:S).</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Specifies the recurrence start time (H:M:S).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderScheduleRecurrenceWeekly
{
    /// <summary>Specifies a list of dayOfWeek to recurrence. Possible values are Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, and Saturday.</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    /// <summary>Specifies the recurrence end time (H:M:S).</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Specifies the recurrence start time (H:M:S).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary>A recurrence block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderScheduleRecurrence
{
    /// <summary>One or more daily blocks as defined above.</summary>
    [JsonPropertyName("daily")]
    public IList<V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderScheduleRecurrenceDaily>? Daily { get; set; }

    /// <summary>One or more monthly blocks as defined above.</summary>
    [JsonPropertyName("monthly")]
    public IList<V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderScheduleRecurrenceMonthly>? Monthly { get; set; }

    /// <summary>One or more weekly blocks as defined below.</summary>
    [JsonPropertyName("weekly")]
    public IList<V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderScheduleRecurrenceWeekly>? Weekly { get; set; }
}

/// <summary>A schedule block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderSchedule
{
    /// <summary>Specifies the Alert Processing Rule effective start time (Y-m-d'T'H:M:S).</summary>
    [JsonPropertyName("effectiveFrom")]
    public string? EffectiveFrom { get; set; }

    /// <summary>Specifies the Alert Processing Rule effective end time (Y-m-d'T'H:M:S).</summary>
    [JsonPropertyName("effectiveUntil")]
    public string? EffectiveUntil { get; set; }

    /// <summary>A recurrence block as defined above.</summary>
    [JsonPropertyName("recurrence")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderScheduleRecurrence? Recurrence { get; set; }

    /// <summary>The time zone (e.g. Pacific Standard time, Eastern Standard Time). Defaults to UTC. possible values are defined here.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderScopesRefsPolicy
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
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderScopesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderScopesRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderScopesSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of ResourceGroup in azure to populate scopes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderScopesSelector
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
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderScopesSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProvider
{
    /// <summary>A condition block as defined below.</summary>
    [JsonPropertyName("condition")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderCondition? Condition { get; set; }

    /// <summary>Specifies a description for the Alert Processing Rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Should the Alert Processing Rule be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A schedule block as defined below.</summary>
    [JsonPropertyName("schedule")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderSchedule? Schedule { get; set; }

    /// <summary>A list of resource IDs which will be the target of Alert Processing Rule.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>References to ResourceGroup in azure to populate scopes.</summary>
    [JsonPropertyName("scopesRefs")]
    public IList<V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderScopesRefs>? ScopesRefs { get; set; }

    /// <summary>Selector for a list of ResourceGroup in azure to populate scopes.</summary>
    [JsonPropertyName("scopesSelector")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProviderScopesSelector? ScopesSelector { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Alert Processing Rule.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecProviderConfigRef
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
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>MonitorAlertProcessingRuleSuppressionSpec defines the desired state of MonitorAlertProcessingRuleSuppression</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A alert_context block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionAlertContext
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A alert_rule_id block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionAlertRuleId
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A alert_rule_name block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionAlertRuleName
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A description block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionDescription
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A monitor_condition block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionMonitorCondition
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A monitor_service block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionMonitorService
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A severity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionSeverity
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A signal_type block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionSignalType
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A target_resource block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionTargetResource
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A target_resource_group block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionTargetResourceGroup
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A target_resource_type block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionTargetResourceType
{
    /// <summary>The operator for a given condition. Possible values are Equals, NotEquals, Contains, and DoesNotContain.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types. (e.g. Microsoft.Compute/VirtualMachines)</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A condition block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderCondition
{
    /// <summary>A alert_context block as defined above.</summary>
    [JsonPropertyName("alertContext")]
    public V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionAlertContext? AlertContext { get; set; }

    /// <summary>A alert_rule_id block as defined above.</summary>
    [JsonPropertyName("alertRuleId")]
    public V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionAlertRuleId? AlertRuleId { get; set; }

    /// <summary>A alert_rule_name block as defined above.</summary>
    [JsonPropertyName("alertRuleName")]
    public V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionAlertRuleName? AlertRuleName { get; set; }

    /// <summary>A description block as defined below.</summary>
    [JsonPropertyName("description")]
    public V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionDescription? Description { get; set; }

    /// <summary>A monitor_condition block as defined below.</summary>
    [JsonPropertyName("monitorCondition")]
    public V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionMonitorCondition? MonitorCondition { get; set; }

    /// <summary>A monitor_service block as defined below.</summary>
    [JsonPropertyName("monitorService")]
    public V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionMonitorService? MonitorService { get; set; }

    /// <summary>A severity block as defined below.</summary>
    [JsonPropertyName("severity")]
    public V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionSeverity? Severity { get; set; }

    /// <summary>A signal_type block as defined below.</summary>
    [JsonPropertyName("signalType")]
    public V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionSignalType? SignalType { get; set; }

    /// <summary>A target_resource block as defined below.</summary>
    [JsonPropertyName("targetResource")]
    public V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionTargetResource? TargetResource { get; set; }

    /// <summary>A target_resource_group block as defined below.</summary>
    [JsonPropertyName("targetResourceGroup")]
    public V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionTargetResourceGroup? TargetResourceGroup { get; set; }

    /// <summary>A target_resource_type block as defined below.</summary>
    [JsonPropertyName("targetResourceType")]
    public V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderConditionTargetResourceType? TargetResourceType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderScheduleRecurrenceDaily
{
    /// <summary>Specifies the recurrence end time (H:M:S).</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Specifies the recurrence start time (H:M:S).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderScheduleRecurrenceMonthly
{
    /// <summary>Specifies a list of dayOfMonth to recurrence. Possible values are integers between 1 - 31.</summary>
    [JsonPropertyName("daysOfMonth")]
    public IList<double>? DaysOfMonth { get; set; }

    /// <summary>Specifies the recurrence end time (H:M:S).</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Specifies the recurrence start time (H:M:S).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderScheduleRecurrenceWeekly
{
    /// <summary>Specifies a list of dayOfWeek to recurrence. Possible values are Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, and Saturday.</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    /// <summary>Specifies the recurrence end time (H:M:S).</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Specifies the recurrence start time (H:M:S).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary>A recurrence block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderScheduleRecurrence
{
    /// <summary>One or more daily blocks as defined above.</summary>
    [JsonPropertyName("daily")]
    public IList<V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderScheduleRecurrenceDaily>? Daily { get; set; }

    /// <summary>One or more monthly blocks as defined above.</summary>
    [JsonPropertyName("monthly")]
    public IList<V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderScheduleRecurrenceMonthly>? Monthly { get; set; }

    /// <summary>One or more weekly blocks as defined below.</summary>
    [JsonPropertyName("weekly")]
    public IList<V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderScheduleRecurrenceWeekly>? Weekly { get; set; }
}

/// <summary>A schedule block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderSchedule
{
    /// <summary>Specifies the Alert Processing Rule effective start time (Y-m-d'T'H:M:S).</summary>
    [JsonPropertyName("effectiveFrom")]
    public string? EffectiveFrom { get; set; }

    /// <summary>Specifies the Alert Processing Rule effective end time (Y-m-d'T'H:M:S).</summary>
    [JsonPropertyName("effectiveUntil")]
    public string? EffectiveUntil { get; set; }

    /// <summary>A recurrence block as defined above.</summary>
    [JsonPropertyName("recurrence")]
    public V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderScheduleRecurrence? Recurrence { get; set; }

    /// <summary>The time zone (e.g. Pacific Standard time, Eastern Standard Time). Defaults to UTC. possible values are defined here.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProvider
{
    /// <summary>A condition block as defined below.</summary>
    [JsonPropertyName("condition")]
    public V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderCondition? Condition { get; set; }

    /// <summary>Specifies a description for the Alert Processing Rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Should the Alert Processing Rule be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The ID of the Alert Processing Rule.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the Resource Group where the Alert Processing Rule should exist. Changing this forces a new Alert Processing Rule to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A schedule block as defined below.</summary>
    [JsonPropertyName("schedule")]
    public V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProviderSchedule? Schedule { get; set; }

    /// <summary>A list of resource IDs which will be the target of Alert Processing Rule.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Alert Processing Rule.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionStatusConditions
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

/// <summary>MonitorAlertProcessingRuleSuppressionStatus defines the observed state of MonitorAlertProcessingRuleSuppression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1MonitorAlertProcessingRuleSuppressionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MonitorAlertProcessingRuleSuppressionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MonitorAlertProcessingRuleSuppression is the Schema for the MonitorAlertProcessingRuleSuppressions API. Manages an Alert Processing Rule which suppress notifications.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MonitorAlertProcessingRuleSuppression : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MonitorAlertProcessingRuleSuppressionSpec>, IStatus<V1beta1MonitorAlertProcessingRuleSuppressionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MonitorAlertProcessingRuleSuppression";
    public const string KubeGroup = "alertsmanagement.azure.m.upbound.io";
    public const string KubePluralName = "monitoralertprocessingrulesuppressions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MonitorAlertProcessingRuleSuppressionSpec defines the desired state of MonitorAlertProcessingRuleSuppression</summary>
    [JsonPropertyName("spec")]
    public V1beta1MonitorAlertProcessingRuleSuppressionSpec Spec { get; set; }

    /// <summary>MonitorAlertProcessingRuleSuppressionStatus defines the observed state of MonitorAlertProcessingRuleSuppression.</summary>
    [JsonPropertyName("status")]
    public V1beta1MonitorAlertProcessingRuleSuppressionStatus? Status { get; set; }
}

/// <summary>MonitorAlertProcessingRuleSuppression is the Schema for the MonitorAlertProcessingRuleSuppressions API. Manages an Alert Processing Rule which suppress notifications.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MonitorAlertProcessingRuleSuppressionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1MonitorAlertProcessingRuleSuppression>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MonitorAlertProcessingRuleSuppressionList";
    public const string KubeGroup = "alertsmanagement.azure.m.upbound.io";
    public const string KubePluralName = "monitoralertprocessingrulesuppressions";
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
    public IList<V1beta1MonitorAlertProcessingRuleSuppression> Items { get; set; }
}