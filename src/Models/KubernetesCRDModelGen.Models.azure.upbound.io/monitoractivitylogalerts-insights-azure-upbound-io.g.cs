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
public enum V1beta1MonitorActivityLogAlertSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecForProviderActionActionGroupIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecForProviderActionActionGroupIdRefPolicyResolveEnum
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
public partial class V1beta1MonitorActivityLogAlertSpecForProviderActionActionGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecForProviderActionActionGroupIdRefPolicyResolutionEnum>))]
    public V1beta1MonitorActivityLogAlertSpecForProviderActionActionGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecForProviderActionActionGroupIdRefPolicyResolveEnum>))]
    public V1beta1MonitorActivityLogAlertSpecForProviderActionActionGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a MonitorActionGroup in insights to populate actionGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertSpecForProviderActionActionGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorActivityLogAlertSpecForProviderActionActionGroupIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecForProviderActionActionGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecForProviderActionActionGroupIdSelectorPolicyResolveEnum
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
public partial class V1beta1MonitorActivityLogAlertSpecForProviderActionActionGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecForProviderActionActionGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1MonitorActivityLogAlertSpecForProviderActionActionGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecForProviderActionActionGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1MonitorActivityLogAlertSpecForProviderActionActionGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a MonitorActionGroup in insights to populate actionGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertSpecForProviderActionActionGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorActivityLogAlertSpecForProviderActionActionGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertSpecForProviderAction
{
    /// <summary>The ID of the Action Group can be sourced from the .</summary>
    [JsonPropertyName("actionGroupId")]
    public string? ActionGroupId { get; set; }

    /// <summary>Reference to a MonitorActionGroup in insights to populate actionGroupId.</summary>
    [JsonPropertyName("actionGroupIdRef")]
    public V1beta1MonitorActivityLogAlertSpecForProviderActionActionGroupIdRef? ActionGroupIdRef { get; set; }

    /// <summary>Selector for a MonitorActionGroup in insights to populate actionGroupId.</summary>
    [JsonPropertyName("actionGroupIdSelector")]
    public V1beta1MonitorActivityLogAlertSpecForProviderActionActionGroupIdSelector? ActionGroupIdSelector { get; set; }

    /// <summary>The map of custom string properties to include with the post operation. These data are appended to the webhook payload.</summary>
    [JsonPropertyName("webhookProperties")]
    public IDictionary<string, string>? WebhookProperties { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertSpecForProviderCriteriaResourceHealth
{
    /// <summary>The current resource health statuses that will log an alert. Possible values are Available, Degraded, Unavailable and Unknown.</summary>
    [JsonPropertyName("current")]
    public IList<string>? Current { get; set; }

    /// <summary>The previous resource health statuses that will log an alert. Possible values are Available, Degraded, Unavailable and Unknown.</summary>
    [JsonPropertyName("previous")]
    public IList<string>? Previous { get; set; }

    /// <summary>The reason that will log an alert. Possible values are PlatformInitiated (such as a problem with the resource in an affected region of an Azure incident), UserInitiated (such as a shutdown request of a VM) and Unknown.</summary>
    [JsonPropertyName("reason")]
    public IList<string>? Reason { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecForProviderCriteriaResourceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecForProviderCriteriaResourceIdRefPolicyResolveEnum
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
public partial class V1beta1MonitorActivityLogAlertSpecForProviderCriteriaResourceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecForProviderCriteriaResourceIdRefPolicyResolutionEnum>))]
    public V1beta1MonitorActivityLogAlertSpecForProviderCriteriaResourceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecForProviderCriteriaResourceIdRefPolicyResolveEnum>))]
    public V1beta1MonitorActivityLogAlertSpecForProviderCriteriaResourceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Account in storage to populate resourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertSpecForProviderCriteriaResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorActivityLogAlertSpecForProviderCriteriaResourceIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecForProviderCriteriaResourceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecForProviderCriteriaResourceIdSelectorPolicyResolveEnum
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
public partial class V1beta1MonitorActivityLogAlertSpecForProviderCriteriaResourceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecForProviderCriteriaResourceIdSelectorPolicyResolutionEnum>))]
    public V1beta1MonitorActivityLogAlertSpecForProviderCriteriaResourceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecForProviderCriteriaResourceIdSelectorPolicyResolveEnum>))]
    public V1beta1MonitorActivityLogAlertSpecForProviderCriteriaResourceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Account in storage to populate resourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertSpecForProviderCriteriaResourceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorActivityLogAlertSpecForProviderCriteriaResourceIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertSpecForProviderCriteriaServiceHealth
{
    /// <summary>Events this alert will monitor Possible values are Incident, Maintenance, Informational, ActionRequired and Security.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    /// <summary>Locations this alert will monitor. For example, West Europe.</summary>
    [JsonPropertyName("locations")]
    public IList<string>? Locations { get; set; }

    /// <summary>Services this alert will monitor. For example, Activity Logs &amp; Alerts, Action Groups. Defaults to all Services.</summary>
    [JsonPropertyName("services")]
    public IList<string>? Services { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertSpecForProviderCriteria
{
    /// <summary>The email address or Azure Active Directory identifier of the user who performed the operation.</summary>
    [JsonPropertyName("caller")]
    public string? Caller { get; set; }

    /// <summary>The category of the operation. Possible values are Administrative, Autoscale, Policy, Recommendation, ResourceHealth, Security and ServiceHealth.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The severity level of the event. Possible values are Verbose, Informational, Warning, Error, and Critical.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>A list of severity level of the event. Possible values are Verbose, Informational, Warning, Error, and Critical.</summary>
    [JsonPropertyName("levels")]
    public IList<string>? Levels { get; set; }

    /// <summary>The Resource Manager Role-Based Access Control operation name. Supported operation should be of the form: &lt;resourceProvider&gt;/&lt;resourceType&gt;/&lt;operation&gt;.</summary>
    [JsonPropertyName("operationName")]
    public string? OperationName { get; set; }

    /// <summary>The recommendation category of the event. Possible values are Cost, Reliability, OperationalExcellence, HighAvailability and Performance. It is only allowed when category is Recommendation.</summary>
    [JsonPropertyName("recommendationCategory")]
    public string? RecommendationCategory { get; set; }

    /// <summary>The recommendation impact of the event. Possible values are High, Medium and Low. It is only allowed when category is Recommendation.</summary>
    [JsonPropertyName("recommendationImpact")]
    public string? RecommendationImpact { get; set; }

    /// <summary>The recommendation type of the event. It is only allowed when category is Recommendation.</summary>
    [JsonPropertyName("recommendationType")]
    public string? RecommendationType { get; set; }

    /// <summary>The name of resource group monitored by the activity log alert.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>A list of names of resource groups monitored by the activity log alert.</summary>
    [JsonPropertyName("resourceGroups")]
    public IList<string>? ResourceGroups { get; set; }

    /// <summary>A block to define fine grain resource health settings.</summary>
    [JsonPropertyName("resourceHealth")]
    public IList<V1beta1MonitorActivityLogAlertSpecForProviderCriteriaResourceHealth>? ResourceHealth { get; set; }

    /// <summary>The specific resource monitored by the activity log alert. It should be within one of the scopes.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>Reference to a Account in storage to populate resourceId.</summary>
    [JsonPropertyName("resourceIdRef")]
    public V1beta1MonitorActivityLogAlertSpecForProviderCriteriaResourceIdRef? ResourceIdRef { get; set; }

    /// <summary>Selector for a Account in storage to populate resourceId.</summary>
    [JsonPropertyName("resourceIdSelector")]
    public V1beta1MonitorActivityLogAlertSpecForProviderCriteriaResourceIdSelector? ResourceIdSelector { get; set; }

    /// <summary>A list of specific resources monitored by the activity log alert. It should be within one of the scopes.</summary>
    [JsonPropertyName("resourceIds")]
    public IList<string>? ResourceIds { get; set; }

    /// <summary>The name of the resource provider monitored by the activity log alert.</summary>
    [JsonPropertyName("resourceProvider")]
    public string? ResourceProvider { get; set; }

    /// <summary>A list of names of resource providers monitored by the activity log alert.</summary>
    [JsonPropertyName("resourceProviders")]
    public IList<string>? ResourceProviders { get; set; }

    /// <summary>The resource type monitored by the activity log alert.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>A list of resource types monitored by the activity log alert.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }

    /// <summary>A block to define fine grain service health settings.</summary>
    [JsonPropertyName("serviceHealth")]
    public IList<V1beta1MonitorActivityLogAlertSpecForProviderCriteriaServiceHealth>? ServiceHealth { get; set; }

    /// <summary>The status of the event. For example, Started, Failed, or Succeeded.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>A list of status of the event. For example, Started, Failed, or Succeeded.</summary>
    [JsonPropertyName("statuses")]
    public IList<string>? Statuses { get; set; }

    /// <summary>The sub status of the event.</summary>
    [JsonPropertyName("subStatus")]
    public string? SubStatus { get; set; }

    /// <summary>A list of sub status of the event.</summary>
    [JsonPropertyName("subStatuses")]
    public IList<string>? SubStatuses { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecForProviderResourceGroupNameRefPolicyResolveEnum
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
public partial class V1beta1MonitorActivityLogAlertSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1MonitorActivityLogAlertSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1MonitorActivityLogAlertSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorActivityLogAlertSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
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
public partial class V1beta1MonitorActivityLogAlertSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1MonitorActivityLogAlertSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1MonitorActivityLogAlertSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorActivityLogAlertSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecForProviderScopesRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecForProviderScopesRefsPolicyResolveEnum
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
public partial class V1beta1MonitorActivityLogAlertSpecForProviderScopesRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecForProviderScopesRefsPolicyResolutionEnum>))]
    public V1beta1MonitorActivityLogAlertSpecForProviderScopesRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecForProviderScopesRefsPolicyResolveEnum>))]
    public V1beta1MonitorActivityLogAlertSpecForProviderScopesRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertSpecForProviderScopesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorActivityLogAlertSpecForProviderScopesRefsPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecForProviderScopesSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecForProviderScopesSelectorPolicyResolveEnum
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
public partial class V1beta1MonitorActivityLogAlertSpecForProviderScopesSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecForProviderScopesSelectorPolicyResolutionEnum>))]
    public V1beta1MonitorActivityLogAlertSpecForProviderScopesSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecForProviderScopesSelectorPolicyResolveEnum>))]
    public V1beta1MonitorActivityLogAlertSpecForProviderScopesSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of ResourceGroup in azure to populate scopes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertSpecForProviderScopesSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorActivityLogAlertSpecForProviderScopesSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertSpecForProvider
{
    /// <summary>One or more action blocks as defined below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1MonitorActivityLogAlertSpecForProviderAction>? Action { get; set; }

    /// <summary>A criteria block as defined below.</summary>
    [JsonPropertyName("criteria")]
    public IList<V1beta1MonitorActivityLogAlertSpecForProviderCriteria>? Criteria { get; set; }

    /// <summary>The description of this activity log alert.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Should this Activity Log Alert be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the activity log alert. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the resource group in which to create the activity log alert instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1MonitorActivityLogAlertSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1MonitorActivityLogAlertSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The Scope at which the Activity Log should be applied. A list of strings which could be a resource group , or a subscription, or a resource ID (such as a Storage Account).</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>References to ResourceGroup in azure to populate scopes.</summary>
    [JsonPropertyName("scopesRefs")]
    public IList<V1beta1MonitorActivityLogAlertSpecForProviderScopesRefs>? ScopesRefs { get; set; }

    /// <summary>Selector for a list of ResourceGroup in azure to populate scopes.</summary>
    [JsonPropertyName("scopesSelector")]
    public V1beta1MonitorActivityLogAlertSpecForProviderScopesSelector? ScopesSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecInitProviderActionActionGroupIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecInitProviderActionActionGroupIdRefPolicyResolveEnum
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
public partial class V1beta1MonitorActivityLogAlertSpecInitProviderActionActionGroupIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecInitProviderActionActionGroupIdRefPolicyResolutionEnum>))]
    public V1beta1MonitorActivityLogAlertSpecInitProviderActionActionGroupIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecInitProviderActionActionGroupIdRefPolicyResolveEnum>))]
    public V1beta1MonitorActivityLogAlertSpecInitProviderActionActionGroupIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a MonitorActionGroup in insights to populate actionGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertSpecInitProviderActionActionGroupIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorActivityLogAlertSpecInitProviderActionActionGroupIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecInitProviderActionActionGroupIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecInitProviderActionActionGroupIdSelectorPolicyResolveEnum
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
public partial class V1beta1MonitorActivityLogAlertSpecInitProviderActionActionGroupIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecInitProviderActionActionGroupIdSelectorPolicyResolutionEnum>))]
    public V1beta1MonitorActivityLogAlertSpecInitProviderActionActionGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecInitProviderActionActionGroupIdSelectorPolicyResolveEnum>))]
    public V1beta1MonitorActivityLogAlertSpecInitProviderActionActionGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a MonitorActionGroup in insights to populate actionGroupId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertSpecInitProviderActionActionGroupIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorActivityLogAlertSpecInitProviderActionActionGroupIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertSpecInitProviderAction
{
    /// <summary>The ID of the Action Group can be sourced from the .</summary>
    [JsonPropertyName("actionGroupId")]
    public string? ActionGroupId { get; set; }

    /// <summary>Reference to a MonitorActionGroup in insights to populate actionGroupId.</summary>
    [JsonPropertyName("actionGroupIdRef")]
    public V1beta1MonitorActivityLogAlertSpecInitProviderActionActionGroupIdRef? ActionGroupIdRef { get; set; }

    /// <summary>Selector for a MonitorActionGroup in insights to populate actionGroupId.</summary>
    [JsonPropertyName("actionGroupIdSelector")]
    public V1beta1MonitorActivityLogAlertSpecInitProviderActionActionGroupIdSelector? ActionGroupIdSelector { get; set; }

    /// <summary>The map of custom string properties to include with the post operation. These data are appended to the webhook payload.</summary>
    [JsonPropertyName("webhookProperties")]
    public IDictionary<string, string>? WebhookProperties { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertSpecInitProviderCriteriaResourceHealth
{
    /// <summary>The current resource health statuses that will log an alert. Possible values are Available, Degraded, Unavailable and Unknown.</summary>
    [JsonPropertyName("current")]
    public IList<string>? Current { get; set; }

    /// <summary>The previous resource health statuses that will log an alert. Possible values are Available, Degraded, Unavailable and Unknown.</summary>
    [JsonPropertyName("previous")]
    public IList<string>? Previous { get; set; }

    /// <summary>The reason that will log an alert. Possible values are PlatformInitiated (such as a problem with the resource in an affected region of an Azure incident), UserInitiated (such as a shutdown request of a VM) and Unknown.</summary>
    [JsonPropertyName("reason")]
    public IList<string>? Reason { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecInitProviderCriteriaResourceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecInitProviderCriteriaResourceIdRefPolicyResolveEnum
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
public partial class V1beta1MonitorActivityLogAlertSpecInitProviderCriteriaResourceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecInitProviderCriteriaResourceIdRefPolicyResolutionEnum>))]
    public V1beta1MonitorActivityLogAlertSpecInitProviderCriteriaResourceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecInitProviderCriteriaResourceIdRefPolicyResolveEnum>))]
    public V1beta1MonitorActivityLogAlertSpecInitProviderCriteriaResourceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Account in storage to populate resourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertSpecInitProviderCriteriaResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorActivityLogAlertSpecInitProviderCriteriaResourceIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecInitProviderCriteriaResourceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecInitProviderCriteriaResourceIdSelectorPolicyResolveEnum
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
public partial class V1beta1MonitorActivityLogAlertSpecInitProviderCriteriaResourceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecInitProviderCriteriaResourceIdSelectorPolicyResolutionEnum>))]
    public V1beta1MonitorActivityLogAlertSpecInitProviderCriteriaResourceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecInitProviderCriteriaResourceIdSelectorPolicyResolveEnum>))]
    public V1beta1MonitorActivityLogAlertSpecInitProviderCriteriaResourceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Account in storage to populate resourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertSpecInitProviderCriteriaResourceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorActivityLogAlertSpecInitProviderCriteriaResourceIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertSpecInitProviderCriteriaServiceHealth
{
    /// <summary>Events this alert will monitor Possible values are Incident, Maintenance, Informational, ActionRequired and Security.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    /// <summary>Locations this alert will monitor. For example, West Europe.</summary>
    [JsonPropertyName("locations")]
    public IList<string>? Locations { get; set; }

    /// <summary>Services this alert will monitor. For example, Activity Logs &amp; Alerts, Action Groups. Defaults to all Services.</summary>
    [JsonPropertyName("services")]
    public IList<string>? Services { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertSpecInitProviderCriteria
{
    /// <summary>The email address or Azure Active Directory identifier of the user who performed the operation.</summary>
    [JsonPropertyName("caller")]
    public string? Caller { get; set; }

    /// <summary>The category of the operation. Possible values are Administrative, Autoscale, Policy, Recommendation, ResourceHealth, Security and ServiceHealth.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The severity level of the event. Possible values are Verbose, Informational, Warning, Error, and Critical.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>A list of severity level of the event. Possible values are Verbose, Informational, Warning, Error, and Critical.</summary>
    [JsonPropertyName("levels")]
    public IList<string>? Levels { get; set; }

    /// <summary>The Resource Manager Role-Based Access Control operation name. Supported operation should be of the form: &lt;resourceProvider&gt;/&lt;resourceType&gt;/&lt;operation&gt;.</summary>
    [JsonPropertyName("operationName")]
    public string? OperationName { get; set; }

    /// <summary>The recommendation category of the event. Possible values are Cost, Reliability, OperationalExcellence, HighAvailability and Performance. It is only allowed when category is Recommendation.</summary>
    [JsonPropertyName("recommendationCategory")]
    public string? RecommendationCategory { get; set; }

    /// <summary>The recommendation impact of the event. Possible values are High, Medium and Low. It is only allowed when category is Recommendation.</summary>
    [JsonPropertyName("recommendationImpact")]
    public string? RecommendationImpact { get; set; }

    /// <summary>The recommendation type of the event. It is only allowed when category is Recommendation.</summary>
    [JsonPropertyName("recommendationType")]
    public string? RecommendationType { get; set; }

    /// <summary>The name of resource group monitored by the activity log alert.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>A list of names of resource groups monitored by the activity log alert.</summary>
    [JsonPropertyName("resourceGroups")]
    public IList<string>? ResourceGroups { get; set; }

    /// <summary>A block to define fine grain resource health settings.</summary>
    [JsonPropertyName("resourceHealth")]
    public IList<V1beta1MonitorActivityLogAlertSpecInitProviderCriteriaResourceHealth>? ResourceHealth { get; set; }

    /// <summary>The specific resource monitored by the activity log alert. It should be within one of the scopes.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>Reference to a Account in storage to populate resourceId.</summary>
    [JsonPropertyName("resourceIdRef")]
    public V1beta1MonitorActivityLogAlertSpecInitProviderCriteriaResourceIdRef? ResourceIdRef { get; set; }

    /// <summary>Selector for a Account in storage to populate resourceId.</summary>
    [JsonPropertyName("resourceIdSelector")]
    public V1beta1MonitorActivityLogAlertSpecInitProviderCriteriaResourceIdSelector? ResourceIdSelector { get; set; }

    /// <summary>A list of specific resources monitored by the activity log alert. It should be within one of the scopes.</summary>
    [JsonPropertyName("resourceIds")]
    public IList<string>? ResourceIds { get; set; }

    /// <summary>The name of the resource provider monitored by the activity log alert.</summary>
    [JsonPropertyName("resourceProvider")]
    public string? ResourceProvider { get; set; }

    /// <summary>A list of names of resource providers monitored by the activity log alert.</summary>
    [JsonPropertyName("resourceProviders")]
    public IList<string>? ResourceProviders { get; set; }

    /// <summary>The resource type monitored by the activity log alert.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>A list of resource types monitored by the activity log alert.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }

    /// <summary>A block to define fine grain service health settings.</summary>
    [JsonPropertyName("serviceHealth")]
    public IList<V1beta1MonitorActivityLogAlertSpecInitProviderCriteriaServiceHealth>? ServiceHealth { get; set; }

    /// <summary>The status of the event. For example, Started, Failed, or Succeeded.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>A list of status of the event. For example, Started, Failed, or Succeeded.</summary>
    [JsonPropertyName("statuses")]
    public IList<string>? Statuses { get; set; }

    /// <summary>The sub status of the event.</summary>
    [JsonPropertyName("subStatus")]
    public string? SubStatus { get; set; }

    /// <summary>A list of sub status of the event.</summary>
    [JsonPropertyName("subStatuses")]
    public IList<string>? SubStatuses { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecInitProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecInitProviderResourceGroupNameRefPolicyResolveEnum
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
public partial class V1beta1MonitorActivityLogAlertSpecInitProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecInitProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1MonitorActivityLogAlertSpecInitProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecInitProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1MonitorActivityLogAlertSpecInitProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertSpecInitProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorActivityLogAlertSpecInitProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecInitProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecInitProviderResourceGroupNameSelectorPolicyResolveEnum
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
public partial class V1beta1MonitorActivityLogAlertSpecInitProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecInitProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1MonitorActivityLogAlertSpecInitProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecInitProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1MonitorActivityLogAlertSpecInitProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertSpecInitProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorActivityLogAlertSpecInitProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecInitProviderScopesRefsPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecInitProviderScopesRefsPolicyResolveEnum
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
public partial class V1beta1MonitorActivityLogAlertSpecInitProviderScopesRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecInitProviderScopesRefsPolicyResolutionEnum>))]
    public V1beta1MonitorActivityLogAlertSpecInitProviderScopesRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecInitProviderScopesRefsPolicyResolveEnum>))]
    public V1beta1MonitorActivityLogAlertSpecInitProviderScopesRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertSpecInitProviderScopesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorActivityLogAlertSpecInitProviderScopesRefsPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecInitProviderScopesSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecInitProviderScopesSelectorPolicyResolveEnum
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
public partial class V1beta1MonitorActivityLogAlertSpecInitProviderScopesSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecInitProviderScopesSelectorPolicyResolutionEnum>))]
    public V1beta1MonitorActivityLogAlertSpecInitProviderScopesSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecInitProviderScopesSelectorPolicyResolveEnum>))]
    public V1beta1MonitorActivityLogAlertSpecInitProviderScopesSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of ResourceGroup in azure to populate scopes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertSpecInitProviderScopesSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorActivityLogAlertSpecInitProviderScopesSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertSpecInitProvider
{
    /// <summary>One or more action blocks as defined below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1MonitorActivityLogAlertSpecInitProviderAction>? Action { get; set; }

    /// <summary>A criteria block as defined below.</summary>
    [JsonPropertyName("criteria")]
    public IList<V1beta1MonitorActivityLogAlertSpecInitProviderCriteria>? Criteria { get; set; }

    /// <summary>The description of this activity log alert.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Should this Activity Log Alert be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the activity log alert. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the resource group in which to create the activity log alert instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1MonitorActivityLogAlertSpecInitProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1MonitorActivityLogAlertSpecInitProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The Scope at which the Activity Log should be applied. A list of strings which could be a resource group , or a subscription, or a resource ID (such as a Storage Account).</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>References to ResourceGroup in azure to populate scopes.</summary>
    [JsonPropertyName("scopesRefs")]
    public IList<V1beta1MonitorActivityLogAlertSpecInitProviderScopesRefs>? ScopesRefs { get; set; }

    /// <summary>Selector for a list of ResourceGroup in azure to populate scopes.</summary>
    [JsonPropertyName("scopesSelector")]
    public V1beta1MonitorActivityLogAlertSpecInitProviderScopesSelector? ScopesSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecManagementPoliciesEnum
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
public enum V1beta1MonitorActivityLogAlertSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1MonitorActivityLogAlertSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1MonitorActivityLogAlertSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1MonitorActivityLogAlertSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorActivityLogAlertSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1MonitorActivityLogAlertSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1MonitorActivityLogAlertSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1MonitorActivityLogAlertSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1MonitorActivityLogAlertSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MonitorActivityLogAlertSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1MonitorActivityLogAlertSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1MonitorActivityLogAlertSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1MonitorActivityLogAlertSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>MonitorActivityLogAlertSpec defines the desired state of MonitorActivityLogAlert</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MonitorActivityLogAlertSpecDeletionPolicyEnum>))]
    public V1beta1MonitorActivityLogAlertSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1MonitorActivityLogAlertSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1MonitorActivityLogAlertSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1MonitorActivityLogAlertSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MonitorActivityLogAlertSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1MonitorActivityLogAlertSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MonitorActivityLogAlertSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertStatusAtProviderAction
{
    /// <summary>The ID of the Action Group can be sourced from the .</summary>
    [JsonPropertyName("actionGroupId")]
    public string? ActionGroupId { get; set; }

    /// <summary>The map of custom string properties to include with the post operation. These data are appended to the webhook payload.</summary>
    [JsonPropertyName("webhookProperties")]
    public IDictionary<string, string>? WebhookProperties { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertStatusAtProviderCriteriaResourceHealth
{
    /// <summary>The current resource health statuses that will log an alert. Possible values are Available, Degraded, Unavailable and Unknown.</summary>
    [JsonPropertyName("current")]
    public IList<string>? Current { get; set; }

    /// <summary>The previous resource health statuses that will log an alert. Possible values are Available, Degraded, Unavailable and Unknown.</summary>
    [JsonPropertyName("previous")]
    public IList<string>? Previous { get; set; }

    /// <summary>The reason that will log an alert. Possible values are PlatformInitiated (such as a problem with the resource in an affected region of an Azure incident), UserInitiated (such as a shutdown request of a VM) and Unknown.</summary>
    [JsonPropertyName("reason")]
    public IList<string>? Reason { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertStatusAtProviderCriteriaServiceHealth
{
    /// <summary>Events this alert will monitor Possible values are Incident, Maintenance, Informational, ActionRequired and Security.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }

    /// <summary>Locations this alert will monitor. For example, West Europe.</summary>
    [JsonPropertyName("locations")]
    public IList<string>? Locations { get; set; }

    /// <summary>Services this alert will monitor. For example, Activity Logs &amp; Alerts, Action Groups. Defaults to all Services.</summary>
    [JsonPropertyName("services")]
    public IList<string>? Services { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertStatusAtProviderCriteria
{
    /// <summary>The email address or Azure Active Directory identifier of the user who performed the operation.</summary>
    [JsonPropertyName("caller")]
    public string? Caller { get; set; }

    /// <summary>The category of the operation. Possible values are Administrative, Autoscale, Policy, Recommendation, ResourceHealth, Security and ServiceHealth.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>The severity level of the event. Possible values are Verbose, Informational, Warning, Error, and Critical.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>A list of severity level of the event. Possible values are Verbose, Informational, Warning, Error, and Critical.</summary>
    [JsonPropertyName("levels")]
    public IList<string>? Levels { get; set; }

    /// <summary>The Resource Manager Role-Based Access Control operation name. Supported operation should be of the form: &lt;resourceProvider&gt;/&lt;resourceType&gt;/&lt;operation&gt;.</summary>
    [JsonPropertyName("operationName")]
    public string? OperationName { get; set; }

    /// <summary>The recommendation category of the event. Possible values are Cost, Reliability, OperationalExcellence, HighAvailability and Performance. It is only allowed when category is Recommendation.</summary>
    [JsonPropertyName("recommendationCategory")]
    public string? RecommendationCategory { get; set; }

    /// <summary>The recommendation impact of the event. Possible values are High, Medium and Low. It is only allowed when category is Recommendation.</summary>
    [JsonPropertyName("recommendationImpact")]
    public string? RecommendationImpact { get; set; }

    /// <summary>The recommendation type of the event. It is only allowed when category is Recommendation.</summary>
    [JsonPropertyName("recommendationType")]
    public string? RecommendationType { get; set; }

    /// <summary>The name of resource group monitored by the activity log alert.</summary>
    [JsonPropertyName("resourceGroup")]
    public string? ResourceGroup { get; set; }

    /// <summary>A list of names of resource groups monitored by the activity log alert.</summary>
    [JsonPropertyName("resourceGroups")]
    public IList<string>? ResourceGroups { get; set; }

    /// <summary>A block to define fine grain resource health settings.</summary>
    [JsonPropertyName("resourceHealth")]
    public IList<V1beta1MonitorActivityLogAlertStatusAtProviderCriteriaResourceHealth>? ResourceHealth { get; set; }

    /// <summary>The specific resource monitored by the activity log alert. It should be within one of the scopes.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>A list of specific resources monitored by the activity log alert. It should be within one of the scopes.</summary>
    [JsonPropertyName("resourceIds")]
    public IList<string>? ResourceIds { get; set; }

    /// <summary>The name of the resource provider monitored by the activity log alert.</summary>
    [JsonPropertyName("resourceProvider")]
    public string? ResourceProvider { get; set; }

    /// <summary>A list of names of resource providers monitored by the activity log alert.</summary>
    [JsonPropertyName("resourceProviders")]
    public IList<string>? ResourceProviders { get; set; }

    /// <summary>The resource type monitored by the activity log alert.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>A list of resource types monitored by the activity log alert.</summary>
    [JsonPropertyName("resourceTypes")]
    public IList<string>? ResourceTypes { get; set; }

    /// <summary>A block to define fine grain service health settings.</summary>
    [JsonPropertyName("serviceHealth")]
    public IList<V1beta1MonitorActivityLogAlertStatusAtProviderCriteriaServiceHealth>? ServiceHealth { get; set; }

    /// <summary>The status of the event. For example, Started, Failed, or Succeeded.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>A list of status of the event. For example, Started, Failed, or Succeeded.</summary>
    [JsonPropertyName("statuses")]
    public IList<string>? Statuses { get; set; }

    /// <summary>The sub status of the event.</summary>
    [JsonPropertyName("subStatus")]
    public string? SubStatus { get; set; }

    /// <summary>A list of sub status of the event.</summary>
    [JsonPropertyName("subStatuses")]
    public IList<string>? SubStatuses { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertStatusAtProvider
{
    /// <summary>One or more action blocks as defined below.</summary>
    [JsonPropertyName("action")]
    public IList<V1beta1MonitorActivityLogAlertStatusAtProviderAction>? Action { get; set; }

    /// <summary>A criteria block as defined below.</summary>
    [JsonPropertyName("criteria")]
    public IList<V1beta1MonitorActivityLogAlertStatusAtProviderCriteria>? Criteria { get; set; }

    /// <summary>The description of this activity log alert.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Should this Activity Log Alert be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The ID of the activity log alert.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the activity log alert. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the resource group in which to create the activity log alert instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The Scope at which the Activity Log should be applied. A list of strings which could be a resource group , or a subscription, or a resource ID (such as a Storage Account).</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertStatusConditions
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

/// <summary>MonitorActivityLogAlertStatus defines the observed state of MonitorActivityLogAlert.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MonitorActivityLogAlertStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1MonitorActivityLogAlertStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MonitorActivityLogAlertStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MonitorActivityLogAlert is the Schema for the MonitorActivityLogAlerts API. Manages an Activity Log Alert within Azure Monitor</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MonitorActivityLogAlert : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MonitorActivityLogAlertSpec>, IStatus<V1beta1MonitorActivityLogAlertStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MonitorActivityLogAlert";
    public const string KubeGroup = "insights.azure.upbound.io";
    public const string KubePluralName = "monitoractivitylogalerts";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MonitorActivityLogAlertSpec defines the desired state of MonitorActivityLogAlert</summary>
    [JsonPropertyName("spec")]
    public V1beta1MonitorActivityLogAlertSpec Spec { get; set; }

    /// <summary>MonitorActivityLogAlertStatus defines the observed state of MonitorActivityLogAlert.</summary>
    [JsonPropertyName("status")]
    public V1beta1MonitorActivityLogAlertStatus? Status { get; set; }
}