using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.insights.azure.com;
/// <summary>Storage version of v1api20221001.EmailNotification Email notification of an autoscale event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecNotificationsEmail
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customEmails")]
    public IList<string>? CustomEmails { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sendToSubscriptionAdministrator")]
    public bool? SendToSubscriptionAdministrator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sendToSubscriptionCoAdministrators")]
    public bool? SendToSubscriptionCoAdministrators { get; set; }
}

/// <summary>Storage version of v1api20221001.WebhookNotification Webhook notification of an autoscale event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecNotificationsWebhooks
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceUri")]
    public string? ServiceUri { get; set; }
}

/// <summary>Storage version of v1api20221001.AutoscaleNotification Autoscale notification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecNotifications
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20221001.EmailNotification Email notification of an autoscale event.</summary>
    [JsonPropertyName("email")]
    public V1api20221001storageAutoscaleSettingSpecNotificationsEmail? Email { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("webhooks")]
    public IList<V1api20221001storageAutoscaleSettingSpecNotificationsWebhooks>? Webhooks { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20221001.PredictiveAutoscalePolicy The parameters for enabling predictive autoscale.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecPredictiveAutoscalePolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scaleLookAheadTime")]
    public string? ScaleLookAheadTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scaleMode")]
    public string? ScaleMode { get; set; }
}

/// <summary>Storage version of v1api20221001.ScaleCapacity The number of instances that can be used during this profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecProfilesCapacity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("default")]
    public string? Default { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maximum")]
    public string? Maximum { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minimum")]
    public string? Minimum { get; set; }
}

/// <summary>Storage version of v1api20221001.TimeWindow A specific date-time for the profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecProfilesFixedDate
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary></summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>Storage version of v1api20221001.RecurrentSchedule The scheduling constraints for when the profile begins.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecProfilesRecurrenceSchedule
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("days")]
    public IList<string>? Days { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hours")]
    public IList<int>? Hours { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minutes")]
    public IList<int>? Minutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>Storage version of v1api20221001.Recurrence The repeating times at which this profile begins. This element is not used if the FixedDate element is used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecProfilesRecurrence
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>Storage version of v1api20221001.RecurrentSchedule The scheduling constraints for when the profile begins.</summary>
    [JsonPropertyName("schedule")]
    public V1api20221001storageAutoscaleSettingSpecProfilesRecurrenceSchedule? Schedule { get; set; }
}

/// <summary>Storage version of v1api20221001.ScaleRuleMetricDimension Specifies an auto scale rule metric dimension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecProfilesRulesMetricTriggerDimensions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("DimensionName")]
    public string? DimensionName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("Operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("Values")]
    public IList<string>? Values { get; set; }
}

/// <summary>MetricResourceUriReference: the resource identifier of the resource the rule monitors.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecProfilesRulesMetricTriggerMetricResourceUriReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20221001.MetricTrigger The trigger that results in a scaling action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecProfilesRulesMetricTrigger
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dimensions")]
    public IList<V1api20221001storageAutoscaleSettingSpecProfilesRulesMetricTriggerDimensions>? Dimensions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dividePerInstance")]
    public bool? DividePerInstance { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metricResourceLocation")]
    public string? MetricResourceLocation { get; set; }

    /// <summary>MetricResourceUriReference: the resource identifier of the resource the rule monitors.</summary>
    [JsonPropertyName("metricResourceUriReference")]
    public V1api20221001storageAutoscaleSettingSpecProfilesRulesMetricTriggerMetricResourceUriReference MetricResourceUriReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary></summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeAggregation")]
    public string? TimeAggregation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeGrain")]
    public string? TimeGrain { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeWindow")]
    public string? TimeWindow { get; set; }
}

/// <summary>Storage version of v1api20221001.ScaleAction The parameters for the scaling action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecProfilesRulesScaleAction
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cooldown")]
    public string? Cooldown { get; set; }

    /// <summary></summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v1api20221001.ScaleRule A rule that provide the triggers and parameters for the scaling action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecProfilesRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20221001.MetricTrigger The trigger that results in a scaling action.</summary>
    [JsonPropertyName("metricTrigger")]
    public V1api20221001storageAutoscaleSettingSpecProfilesRulesMetricTrigger? MetricTrigger { get; set; }

    /// <summary>Storage version of v1api20221001.ScaleAction The parameters for the scaling action.</summary>
    [JsonPropertyName("scaleAction")]
    public V1api20221001storageAutoscaleSettingSpecProfilesRulesScaleAction? ScaleAction { get; set; }
}

/// <summary>Storage version of v1api20221001.AutoscaleProfile Autoscale profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecProfiles
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20221001.ScaleCapacity The number of instances that can be used during this profile.</summary>
    [JsonPropertyName("capacity")]
    public V1api20221001storageAutoscaleSettingSpecProfilesCapacity? Capacity { get; set; }

    /// <summary>Storage version of v1api20221001.TimeWindow A specific date-time for the profile.</summary>
    [JsonPropertyName("fixedDate")]
    public V1api20221001storageAutoscaleSettingSpecProfilesFixedDate? FixedDate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20221001.Recurrence The repeating times at which this profile begins. This element is not used if the FixedDate element is used.</summary>
    [JsonPropertyName("recurrence")]
    public V1api20221001storageAutoscaleSettingSpecProfilesRecurrence? Recurrence { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rules")]
    public IList<V1api20221001storageAutoscaleSettingSpecProfilesRules>? Rules { get; set; }
}

/// <summary>TargetResourceUriReference: the resource identifier of the resource that the autoscale setting should be added to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpecTargetResourceUriReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20221001.Autoscalesetting_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notifications")]
    public IList<V1api20221001storageAutoscaleSettingSpecNotifications>? Notifications { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20221001storageAutoscaleSettingSpecOwner Owner { get; set; }

    /// <summary>Storage version of v1api20221001.PredictiveAutoscalePolicy The parameters for enabling predictive autoscale.</summary>
    [JsonPropertyName("predictiveAutoscalePolicy")]
    public V1api20221001storageAutoscaleSettingSpecPredictiveAutoscalePolicy? PredictiveAutoscalePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("profiles")]
    public IList<V1api20221001storageAutoscaleSettingSpecProfiles>? Profiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetResourceLocation")]
    public string? TargetResourceLocation { get; set; }

    /// <summary>TargetResourceUriReference: the resource identifier of the resource that the autoscale setting should be added to.</summary>
    [JsonPropertyName("targetResourceUriReference")]
    public V1api20221001storageAutoscaleSettingSpecTargetResourceUriReference? TargetResourceUriReference { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Reason for the condition's last transition. Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Severity with which to treat failures of this type of condition. For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False. This is omitted in all cases when Status == Unknown</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Storage version of v1api20221001.EmailNotification_STATUS Email notification of an autoscale event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatusNotificationsEmail
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customEmails")]
    public IList<string>? CustomEmails { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sendToSubscriptionAdministrator")]
    public bool? SendToSubscriptionAdministrator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sendToSubscriptionCoAdministrators")]
    public bool? SendToSubscriptionCoAdministrators { get; set; }
}

/// <summary>Storage version of v1api20221001.WebhookNotification_STATUS Webhook notification of an autoscale event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatusNotificationsWebhooks
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceUri")]
    public string? ServiceUri { get; set; }
}

/// <summary>Storage version of v1api20221001.AutoscaleNotification_STATUS Autoscale notification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatusNotifications
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20221001.EmailNotification_STATUS Email notification of an autoscale event.</summary>
    [JsonPropertyName("email")]
    public V1api20221001storageAutoscaleSettingStatusNotificationsEmail? Email { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("webhooks")]
    public IList<V1api20221001storageAutoscaleSettingStatusNotificationsWebhooks>? Webhooks { get; set; }
}

/// <summary>Storage version of v1api20221001.PredictiveAutoscalePolicy_STATUS The parameters for enabling predictive autoscale.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatusPredictiveAutoscalePolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scaleLookAheadTime")]
    public string? ScaleLookAheadTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scaleMode")]
    public string? ScaleMode { get; set; }
}

/// <summary>Storage version of v1api20221001.ScaleCapacity_STATUS The number of instances that can be used during this profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatusProfilesCapacity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("default")]
    public string? Default { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maximum")]
    public string? Maximum { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minimum")]
    public string? Minimum { get; set; }
}

/// <summary>Storage version of v1api20221001.TimeWindow_STATUS A specific date-time for the profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatusProfilesFixedDate
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary></summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>Storage version of v1api20221001.RecurrentSchedule_STATUS The scheduling constraints for when the profile begins.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatusProfilesRecurrenceSchedule
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("days")]
    public IList<string>? Days { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hours")]
    public IList<int>? Hours { get; set; }

    /// <summary></summary>
    [JsonPropertyName("minutes")]
    public IList<int>? Minutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>Storage version of v1api20221001.Recurrence_STATUS The repeating times at which this profile begins. This element is not used if the FixedDate element is used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatusProfilesRecurrence
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>Storage version of v1api20221001.RecurrentSchedule_STATUS The scheduling constraints for when the profile begins.</summary>
    [JsonPropertyName("schedule")]
    public V1api20221001storageAutoscaleSettingStatusProfilesRecurrenceSchedule? Schedule { get; set; }
}

/// <summary>Storage version of v1api20221001.ScaleRuleMetricDimension_STATUS Specifies an auto scale rule metric dimension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatusProfilesRulesMetricTriggerDimensions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("DimensionName")]
    public string? DimensionName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("Operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("Values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Storage version of v1api20221001.MetricTrigger_STATUS The trigger that results in a scaling action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatusProfilesRulesMetricTrigger
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dimensions")]
    public IList<V1api20221001storageAutoscaleSettingStatusProfilesRulesMetricTriggerDimensions>? Dimensions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dividePerInstance")]
    public bool? DividePerInstance { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metricResourceLocation")]
    public string? MetricResourceLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metricResourceUri")]
    public string? MetricResourceUri { get; set; }

    /// <summary></summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary></summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary></summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeAggregation")]
    public string? TimeAggregation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeGrain")]
    public string? TimeGrain { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeWindow")]
    public string? TimeWindow { get; set; }
}

/// <summary>Storage version of v1api20221001.ScaleAction_STATUS The parameters for the scaling action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatusProfilesRulesScaleAction
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("cooldown")]
    public string? Cooldown { get; set; }

    /// <summary></summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v1api20221001.ScaleRule_STATUS A rule that provide the triggers and parameters for the scaling action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatusProfilesRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20221001.MetricTrigger_STATUS The trigger that results in a scaling action.</summary>
    [JsonPropertyName("metricTrigger")]
    public V1api20221001storageAutoscaleSettingStatusProfilesRulesMetricTrigger? MetricTrigger { get; set; }

    /// <summary>Storage version of v1api20221001.ScaleAction_STATUS The parameters for the scaling action.</summary>
    [JsonPropertyName("scaleAction")]
    public V1api20221001storageAutoscaleSettingStatusProfilesRulesScaleAction? ScaleAction { get; set; }
}

/// <summary>Storage version of v1api20221001.AutoscaleProfile_STATUS Autoscale profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatusProfiles
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20221001.ScaleCapacity_STATUS The number of instances that can be used during this profile.</summary>
    [JsonPropertyName("capacity")]
    public V1api20221001storageAutoscaleSettingStatusProfilesCapacity? Capacity { get; set; }

    /// <summary>Storage version of v1api20221001.TimeWindow_STATUS A specific date-time for the profile.</summary>
    [JsonPropertyName("fixedDate")]
    public V1api20221001storageAutoscaleSettingStatusProfilesFixedDate? FixedDate { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20221001.Recurrence_STATUS The repeating times at which this profile begins. This element is not used if the FixedDate element is used.</summary>
    [JsonPropertyName("recurrence")]
    public V1api20221001storageAutoscaleSettingStatusProfilesRecurrence? Recurrence { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rules")]
    public IList<V1api20221001storageAutoscaleSettingStatusProfilesRules>? Rules { get; set; }
}

/// <summary>Storage version of v1api20221001.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatusSystemData
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>Storage version of v1api20221001.Autoscalesetting_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20221001storageAutoscaleSettingStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20221001storageAutoscaleSettingStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notifications")]
    public IList<V1api20221001storageAutoscaleSettingStatusNotifications>? Notifications { get; set; }

    /// <summary>Storage version of v1api20221001.PredictiveAutoscalePolicy_STATUS The parameters for enabling predictive autoscale.</summary>
    [JsonPropertyName("predictiveAutoscalePolicy")]
    public V1api20221001storageAutoscaleSettingStatusPredictiveAutoscalePolicy? PredictiveAutoscalePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("profiles")]
    public IList<V1api20221001storageAutoscaleSettingStatusProfiles>? Profiles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("properties_name")]
    public string? PropertiesName { get; set; }

    /// <summary>Storage version of v1api20221001.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20221001storageAutoscaleSettingStatusSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetResourceLocation")]
    public string? TargetResourceLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetResourceUri")]
    public string? TargetResourceUri { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20221001.AutoscaleSetting Generator information: - Generated from: /monitor/resource-manager/Microsoft.Insights/stable/2022-10-01/autoscale_API.json - ARM URI: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Insights/autoscalesettings/{autoscaleSettingName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20221001storageAutoscaleSetting : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20221001storageAutoscaleSettingSpec>, IStatus<V1api20221001storageAutoscaleSettingStatus>
{
    public const string KubeApiVersion = "v1api20221001storage";
    public const string KubeKind = "AutoscaleSetting";
    public const string KubeGroup = "insights.azure.com";
    public const string KubePluralName = "autoscalesettings";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20221001.Autoscalesetting_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20221001storageAutoscaleSettingSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20221001.Autoscalesetting_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20221001storageAutoscaleSettingStatus? Status { get; set; }
}