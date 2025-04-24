using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.alertsmanagement.azure.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecForProviderConditionAlertContext
{
    /// <summary>The operator for a given condition. Possible values are Equals and NotEquals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecForProviderConditionAlertRuleId
{
    /// <summary>The operator for a given condition. Possible values are Equals and NotEquals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecForProviderConditionDescription
{
    /// <summary>The operator for a given condition. Possible values are Equals and NotEquals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecForProviderConditionMonitor
{
    /// <summary>The operator for a given condition. Possible values are Equals and NotEquals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecForProviderConditionMonitorService
{
    /// <summary>The operator for a given condition. Possible values are Equals and NotEquals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecForProviderConditionSeverity
{
    /// <summary>The operator for a given condition. Possible values are Equals and NotEquals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecForProviderConditionTargetResourceType
{
    /// <summary>The operator for a given condition. Possible values are Equals and NotEquals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecForProviderCondition
{
    /// <summary>A alert_context block as defined below.</summary>
    [JsonPropertyName("alertContext")]
    public IList<V1beta1MonitorActionRuleSuppressionSpecForProviderConditionAlertContext>? AlertContext { get; set; }

    /// <summary>A alert_rule_id block as defined below.</summary>
    [JsonPropertyName("alertRuleId")]
    public IList<V1beta1MonitorActionRuleSuppressionSpecForProviderConditionAlertRuleId>? AlertRuleId { get; set; }

    /// <summary>A description block as defined below.</summary>
    [JsonPropertyName("description")]
    public IList<V1beta1MonitorActionRuleSuppressionSpecForProviderConditionDescription>? Description { get; set; }

    /// <summary>A monitor block as defined below.</summary>
    [JsonPropertyName("monitor")]
    public IList<V1beta1MonitorActionRuleSuppressionSpecForProviderConditionMonitor>? Monitor { get; set; }

    /// <summary>A monitor_service block as defined below.</summary>
    [JsonPropertyName("monitorService")]
    public IList<V1beta1MonitorActionRuleSuppressionSpecForProviderConditionMonitorService>? MonitorService { get; set; }

    /// <summary>A severity block as defined below.</summary>
    [JsonPropertyName("severity")]
    public IList<V1beta1MonitorActionRuleSuppressionSpecForProviderConditionSeverity>? Severity { get; set; }

    /// <summary>A target_resource_type block as defined below.</summary>
    [JsonPropertyName("targetResourceType")]
    public IList<V1beta1MonitorActionRuleSuppressionSpecForProviderConditionTargetResourceType>? TargetResourceType { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1MonitorActionRuleSuppressionSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorActionRuleSuppressionSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1MonitorActionRuleSuppressionSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorActionRuleSuppressionSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecForProviderScopeResourceIdsRefsPolicy
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
public partial class V1beta1MonitorActionRuleSuppressionSpecForProviderScopeResourceIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorActionRuleSuppressionSpecForProviderScopeResourceIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecForProviderScopeResourceIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of ResourceGroup in azure to populate resourceIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecForProviderScopeResourceIdsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorActionRuleSuppressionSpecForProviderScopeResourceIdsSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecForProviderScope
{
    /// <summary>A list of resource IDs of the given scope type which will be the target of action rule.</summary>
    [JsonPropertyName("resourceIds")]
    public IList<string>? ResourceIds { get; set; }

    /// <summary>References to ResourceGroup in azure to populate resourceIds.</summary>
    [JsonPropertyName("resourceIdsRefs")]
    public IList<V1beta1MonitorActionRuleSuppressionSpecForProviderScopeResourceIdsRefs>? ResourceIdsRefs { get; set; }

    /// <summary>Selector for a list of ResourceGroup in azure to populate resourceIds.</summary>
    [JsonPropertyName("resourceIdsSelector")]
    public V1beta1MonitorActionRuleSuppressionSpecForProviderScopeResourceIdsSelector? ResourceIdsSelector { get; set; }

    /// <summary>Specifies the type of target scope. Possible values are ResourceGroup and Resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecForProviderSuppressionSchedule
{
    /// <summary>specifies the recurrence UTC end datetime (Y-m-d'T'H:M:S'Z').</summary>
    [JsonPropertyName("endDateUtc")]
    public string? EndDateUtc { get; set; }

    /// <summary>specifies the list of dayOfMonth to recurrence. Possible values are between 1 - 31. Required if recurrence_type is Monthly.</summary>
    [JsonPropertyName("recurrenceMonthly")]
    public IList<double>? RecurrenceMonthly { get; set; }

    /// <summary>specifies the list of dayOfWeek to recurrence. Possible values are Sunday, Monday, Tuesday, Wednesday, Thursday, Friday and Saturday.</summary>
    [JsonPropertyName("recurrenceWeekly")]
    public IList<string>? RecurrenceWeekly { get; set; }

    /// <summary>specifies the recurrence UTC start datetime (Y-m-d'T'H:M:S'Z').</summary>
    [JsonPropertyName("startDateUtc")]
    public string? StartDateUtc { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecForProviderSuppression
{
    /// <summary>Specifies the type of suppression. Possible values are Always, Daily, Monthly, Once, and Weekly.</summary>
    [JsonPropertyName("recurrenceType")]
    public string? RecurrenceType { get; set; }

    /// <summary>A schedule block as defined below. Required if recurrence_type is Daily, Monthly, Once or Weekly.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1MonitorActionRuleSuppressionSpecForProviderSuppressionSchedule>? Schedule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecForProvider
{
    /// <summary>A condition block as defined below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1MonitorActionRuleSuppressionSpecForProviderCondition>? Condition { get; set; }

    /// <summary>Specifies a description for the Action Rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Is the Action Rule enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the name of the resource group in which the Monitor Action Rule should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1MonitorActionRuleSuppressionSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1MonitorActionRuleSuppressionSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A scope block as defined below.</summary>
    [JsonPropertyName("scope")]
    public IList<V1beta1MonitorActionRuleSuppressionSpecForProviderScope>? Scope { get; set; }

    /// <summary>A suppression block as defined below.</summary>
    [JsonPropertyName("suppression")]
    public IList<V1beta1MonitorActionRuleSuppressionSpecForProviderSuppression>? Suppression { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecInitProviderConditionAlertContext
{
    /// <summary>The operator for a given condition. Possible values are Equals and NotEquals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecInitProviderConditionAlertRuleId
{
    /// <summary>The operator for a given condition. Possible values are Equals and NotEquals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecInitProviderConditionDescription
{
    /// <summary>The operator for a given condition. Possible values are Equals and NotEquals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecInitProviderConditionMonitor
{
    /// <summary>The operator for a given condition. Possible values are Equals and NotEquals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecInitProviderConditionMonitorService
{
    /// <summary>The operator for a given condition. Possible values are Equals and NotEquals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecInitProviderConditionSeverity
{
    /// <summary>The operator for a given condition. Possible values are Equals and NotEquals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecInitProviderConditionTargetResourceType
{
    /// <summary>The operator for a given condition. Possible values are Equals and NotEquals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecInitProviderCondition
{
    /// <summary>A alert_context block as defined below.</summary>
    [JsonPropertyName("alertContext")]
    public IList<V1beta1MonitorActionRuleSuppressionSpecInitProviderConditionAlertContext>? AlertContext { get; set; }

    /// <summary>A alert_rule_id block as defined below.</summary>
    [JsonPropertyName("alertRuleId")]
    public IList<V1beta1MonitorActionRuleSuppressionSpecInitProviderConditionAlertRuleId>? AlertRuleId { get; set; }

    /// <summary>A description block as defined below.</summary>
    [JsonPropertyName("description")]
    public IList<V1beta1MonitorActionRuleSuppressionSpecInitProviderConditionDescription>? Description { get; set; }

    /// <summary>A monitor block as defined below.</summary>
    [JsonPropertyName("monitor")]
    public IList<V1beta1MonitorActionRuleSuppressionSpecInitProviderConditionMonitor>? Monitor { get; set; }

    /// <summary>A monitor_service block as defined below.</summary>
    [JsonPropertyName("monitorService")]
    public IList<V1beta1MonitorActionRuleSuppressionSpecInitProviderConditionMonitorService>? MonitorService { get; set; }

    /// <summary>A severity block as defined below.</summary>
    [JsonPropertyName("severity")]
    public IList<V1beta1MonitorActionRuleSuppressionSpecInitProviderConditionSeverity>? Severity { get; set; }

    /// <summary>A target_resource_type block as defined below.</summary>
    [JsonPropertyName("targetResourceType")]
    public IList<V1beta1MonitorActionRuleSuppressionSpecInitProviderConditionTargetResourceType>? TargetResourceType { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecInitProviderScopeResourceIdsRefsPolicy
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
public partial class V1beta1MonitorActionRuleSuppressionSpecInitProviderScopeResourceIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorActionRuleSuppressionSpecInitProviderScopeResourceIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecInitProviderScopeResourceIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of ResourceGroup in azure to populate resourceIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecInitProviderScopeResourceIdsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorActionRuleSuppressionSpecInitProviderScopeResourceIdsSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecInitProviderScope
{
    /// <summary>A list of resource IDs of the given scope type which will be the target of action rule.</summary>
    [JsonPropertyName("resourceIds")]
    public IList<string>? ResourceIds { get; set; }

    /// <summary>References to ResourceGroup in azure to populate resourceIds.</summary>
    [JsonPropertyName("resourceIdsRefs")]
    public IList<V1beta1MonitorActionRuleSuppressionSpecInitProviderScopeResourceIdsRefs>? ResourceIdsRefs { get; set; }

    /// <summary>Selector for a list of ResourceGroup in azure to populate resourceIds.</summary>
    [JsonPropertyName("resourceIdsSelector")]
    public V1beta1MonitorActionRuleSuppressionSpecInitProviderScopeResourceIdsSelector? ResourceIdsSelector { get; set; }

    /// <summary>Specifies the type of target scope. Possible values are ResourceGroup and Resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecInitProviderSuppressionSchedule
{
    /// <summary>specifies the recurrence UTC end datetime (Y-m-d'T'H:M:S'Z').</summary>
    [JsonPropertyName("endDateUtc")]
    public string? EndDateUtc { get; set; }

    /// <summary>specifies the list of dayOfMonth to recurrence. Possible values are between 1 - 31. Required if recurrence_type is Monthly.</summary>
    [JsonPropertyName("recurrenceMonthly")]
    public IList<double>? RecurrenceMonthly { get; set; }

    /// <summary>specifies the list of dayOfWeek to recurrence. Possible values are Sunday, Monday, Tuesday, Wednesday, Thursday, Friday and Saturday.</summary>
    [JsonPropertyName("recurrenceWeekly")]
    public IList<string>? RecurrenceWeekly { get; set; }

    /// <summary>specifies the recurrence UTC start datetime (Y-m-d'T'H:M:S'Z').</summary>
    [JsonPropertyName("startDateUtc")]
    public string? StartDateUtc { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecInitProviderSuppression
{
    /// <summary>Specifies the type of suppression. Possible values are Always, Daily, Monthly, Once, and Weekly.</summary>
    [JsonPropertyName("recurrenceType")]
    public string? RecurrenceType { get; set; }

    /// <summary>A schedule block as defined below. Required if recurrence_type is Daily, Monthly, Once or Weekly.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1MonitorActionRuleSuppressionSpecInitProviderSuppressionSchedule>? Schedule { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecInitProvider
{
    /// <summary>A condition block as defined below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1MonitorActionRuleSuppressionSpecInitProviderCondition>? Condition { get; set; }

    /// <summary>Specifies a description for the Action Rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Is the Action Rule enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A scope block as defined below.</summary>
    [JsonPropertyName("scope")]
    public IList<V1beta1MonitorActionRuleSuppressionSpecInitProviderScope>? Scope { get; set; }

    /// <summary>A suppression block as defined below.</summary>
    [JsonPropertyName("suppression")]
    public IList<V1beta1MonitorActionRuleSuppressionSpecInitProviderSuppression>? Suppression { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecProviderConfigRefPolicy
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
public partial class V1beta1MonitorActionRuleSuppressionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorActionRuleSuppressionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1MonitorActionRuleSuppressionSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorActionRuleSuppressionSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1MonitorActionRuleSuppressionSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1MonitorActionRuleSuppressionSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1MonitorActionRuleSuppressionSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>MonitorActionRuleSuppressionSpec defines the desired state of MonitorActionRuleSuppression</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1MonitorActionRuleSuppressionSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1MonitorActionRuleSuppressionSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MonitorActionRuleSuppressionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1MonitorActionRuleSuppressionSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MonitorActionRuleSuppressionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionStatusAtProviderConditionAlertContext
{
    /// <summary>The operator for a given condition. Possible values are Equals and NotEquals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionStatusAtProviderConditionAlertRuleId
{
    /// <summary>The operator for a given condition. Possible values are Equals and NotEquals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionStatusAtProviderConditionDescription
{
    /// <summary>The operator for a given condition. Possible values are Equals and NotEquals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionStatusAtProviderConditionMonitor
{
    /// <summary>The operator for a given condition. Possible values are Equals and NotEquals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionStatusAtProviderConditionMonitorService
{
    /// <summary>The operator for a given condition. Possible values are Equals and NotEquals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionStatusAtProviderConditionSeverity
{
    /// <summary>The operator for a given condition. Possible values are Equals and NotEquals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionStatusAtProviderConditionTargetResourceType
{
    /// <summary>The operator for a given condition. Possible values are Equals and NotEquals.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>A list of values to match for a given condition. The values should be valid resource types.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionStatusAtProviderCondition
{
    /// <summary>A alert_context block as defined below.</summary>
    [JsonPropertyName("alertContext")]
    public IList<V1beta1MonitorActionRuleSuppressionStatusAtProviderConditionAlertContext>? AlertContext { get; set; }

    /// <summary>A alert_rule_id block as defined below.</summary>
    [JsonPropertyName("alertRuleId")]
    public IList<V1beta1MonitorActionRuleSuppressionStatusAtProviderConditionAlertRuleId>? AlertRuleId { get; set; }

    /// <summary>A description block as defined below.</summary>
    [JsonPropertyName("description")]
    public IList<V1beta1MonitorActionRuleSuppressionStatusAtProviderConditionDescription>? Description { get; set; }

    /// <summary>A monitor block as defined below.</summary>
    [JsonPropertyName("monitor")]
    public IList<V1beta1MonitorActionRuleSuppressionStatusAtProviderConditionMonitor>? Monitor { get; set; }

    /// <summary>A monitor_service block as defined below.</summary>
    [JsonPropertyName("monitorService")]
    public IList<V1beta1MonitorActionRuleSuppressionStatusAtProviderConditionMonitorService>? MonitorService { get; set; }

    /// <summary>A severity block as defined below.</summary>
    [JsonPropertyName("severity")]
    public IList<V1beta1MonitorActionRuleSuppressionStatusAtProviderConditionSeverity>? Severity { get; set; }

    /// <summary>A target_resource_type block as defined below.</summary>
    [JsonPropertyName("targetResourceType")]
    public IList<V1beta1MonitorActionRuleSuppressionStatusAtProviderConditionTargetResourceType>? TargetResourceType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionStatusAtProviderScope
{
    /// <summary>A list of resource IDs of the given scope type which will be the target of action rule.</summary>
    [JsonPropertyName("resourceIds")]
    public IList<string>? ResourceIds { get; set; }

    /// <summary>Specifies the type of target scope. Possible values are ResourceGroup and Resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionStatusAtProviderSuppressionSchedule
{
    /// <summary>specifies the recurrence UTC end datetime (Y-m-d'T'H:M:S'Z').</summary>
    [JsonPropertyName("endDateUtc")]
    public string? EndDateUtc { get; set; }

    /// <summary>specifies the list of dayOfMonth to recurrence. Possible values are between 1 - 31. Required if recurrence_type is Monthly.</summary>
    [JsonPropertyName("recurrenceMonthly")]
    public IList<double>? RecurrenceMonthly { get; set; }

    /// <summary>specifies the list of dayOfWeek to recurrence. Possible values are Sunday, Monday, Tuesday, Wednesday, Thursday, Friday and Saturday.</summary>
    [JsonPropertyName("recurrenceWeekly")]
    public IList<string>? RecurrenceWeekly { get; set; }

    /// <summary>specifies the recurrence UTC start datetime (Y-m-d'T'H:M:S'Z').</summary>
    [JsonPropertyName("startDateUtc")]
    public string? StartDateUtc { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionStatusAtProviderSuppression
{
    /// <summary>Specifies the type of suppression. Possible values are Always, Daily, Monthly, Once, and Weekly.</summary>
    [JsonPropertyName("recurrenceType")]
    public string? RecurrenceType { get; set; }

    /// <summary>A schedule block as defined below. Required if recurrence_type is Daily, Monthly, Once or Weekly.</summary>
    [JsonPropertyName("schedule")]
    public IList<V1beta1MonitorActionRuleSuppressionStatusAtProviderSuppressionSchedule>? Schedule { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionStatusAtProvider
{
    /// <summary>A condition block as defined below.</summary>
    [JsonPropertyName("condition")]
    public IList<V1beta1MonitorActionRuleSuppressionStatusAtProviderCondition>? Condition { get; set; }

    /// <summary>Specifies a description for the Action Rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Is the Action Rule enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The ID of the Monitor Action Rule.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the name of the resource group in which the Monitor Action Rule should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A scope block as defined below.</summary>
    [JsonPropertyName("scope")]
    public IList<V1beta1MonitorActionRuleSuppressionStatusAtProviderScope>? Scope { get; set; }

    /// <summary>A suppression block as defined below.</summary>
    [JsonPropertyName("suppression")]
    public IList<V1beta1MonitorActionRuleSuppressionStatusAtProviderSuppression>? Suppression { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionStatusConditions
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

/// <summary>MonitorActionRuleSuppressionStatus defines the observed state of MonitorActionRuleSuppression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActionRuleSuppressionStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1MonitorActionRuleSuppressionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MonitorActionRuleSuppressionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MonitorActionRuleSuppression is the Schema for the MonitorActionRuleSuppressions API. Manages an Monitor Action Rule which type is suppression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MonitorActionRuleSuppression : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MonitorActionRuleSuppressionSpec>, IStatus<V1beta1MonitorActionRuleSuppressionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MonitorActionRuleSuppression";
    public const string KubeGroup = "alertsmanagement.azure.upbound.io";
    public const string KubePluralName = "monitoractionrulesuppressions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MonitorActionRuleSuppressionSpec defines the desired state of MonitorActionRuleSuppression</summary>
    [JsonPropertyName("spec")]
    public V1beta1MonitorActionRuleSuppressionSpec Spec { get; set; }

    /// <summary>MonitorActionRuleSuppressionStatus defines the observed state of MonitorActionRuleSuppression.</summary>
    [JsonPropertyName("status")]
    public V1beta1MonitorActionRuleSuppressionStatus? Status { get; set; }
}

/// <summary>MonitorActionRuleSuppression is the Schema for the MonitorActionRuleSuppressions API. Manages an Monitor Action Rule which type is suppression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MonitorActionRuleSuppressionList : IKubernetesObject<V1ListMeta>, IItems<V1beta1MonitorActionRuleSuppression>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MonitorActionRuleSuppressionList";
    public const string KubeGroup = "alertsmanagement.azure.upbound.io";
    public const string KubePluralName = "monitoractionrulesuppressions";
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
    public IList<V1beta1MonitorActionRuleSuppression> Items { get; set; }
}