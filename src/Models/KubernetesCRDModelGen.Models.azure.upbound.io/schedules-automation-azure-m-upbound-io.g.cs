using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.automation.azure.m.upbound.io;
#nullable enable
/// <summary>Schedule is the Schema for the Schedules API. Manages a Automation Schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ScheduleList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Schedule>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ScheduleList";
    public const string KubeGroup = "automation.azure.m.upbound.io";
    public const string KubePluralName = "schedules";
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
    public IList<V1beta1Schedule> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScheduleSpecForProviderAutomationAccountNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Account in automation to populate automationAccountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScheduleSpecForProviderAutomationAccountNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ScheduleSpecForProviderAutomationAccountNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScheduleSpecForProviderAutomationAccountNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Account in automation to populate automationAccountName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScheduleSpecForProviderAutomationAccountNameSelector
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
    public V1beta1ScheduleSpecForProviderAutomationAccountNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>One monthly_occurrence blocks as defined below to specifies occurrences of days within a month. Only valid when frequency is Month. The monthly_occurrence block supports fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScheduleSpecForProviderMonthlyOccurrence
{
    /// <summary>Day of the occurrence. Must be one of Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday.</summary>
    [JsonPropertyName("day")]
    public string? Day { get; set; }

    /// <summary>Occurrence of the week within the month. Must be between 1 and 5. -1 for last week within the month.</summary>
    [JsonPropertyName("occurrence")]
    public double? Occurrence { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScheduleSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScheduleSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ScheduleSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScheduleSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScheduleSpecForProviderResourceGroupNameSelector
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
    public V1beta1ScheduleSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScheduleSpecForProvider
{
    /// <summary>The name of the automation account in which the Schedule is created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("automationAccountName")]
    public string? AutomationAccountName { get; set; }

    /// <summary>Reference to a Account in automation to populate automationAccountName.</summary>
    [JsonPropertyName("automationAccountNameRef")]
    public V1beta1ScheduleSpecForProviderAutomationAccountNameRef? AutomationAccountNameRef { get; set; }

    /// <summary>Selector for a Account in automation to populate automationAccountName.</summary>
    [JsonPropertyName("automationAccountNameSelector")]
    public V1beta1ScheduleSpecForProviderAutomationAccountNameSelector? AutomationAccountNameSelector { get; set; }

    /// <summary>A description for this Schedule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The end time of the schedule.</summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary>The frequency of the schedule. - can be either OneTime, Day, Hour, Week, or Month.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>The number of frequencys between runs. Only valid when frequency is Day, Hour, Week, or Month and defaults to 1.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>List of days of the month that the job should execute on. Must be between 1 and 31. -1 for last day of the month. Only valid when frequency is Month.</summary>
    [JsonPropertyName("monthDays")]
    public IList<double>? MonthDays { get; set; }

    /// <summary>One monthly_occurrence blocks as defined below to specifies occurrences of days within a month. Only valid when frequency is Month. The monthly_occurrence block supports fields documented below.</summary>
    [JsonPropertyName("monthlyOccurrence")]
    public V1beta1ScheduleSpecForProviderMonthlyOccurrence? MonthlyOccurrence { get; set; }

    /// <summary>The name of the resource group in which the Schedule is created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1ScheduleSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1ScheduleSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Start time of the schedule. Must be at least five minutes in the future. Defaults to seven minutes in the future from the time the resource is created.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>The timezone of the start time. Defaults to Etc/UTC. For possible values see: https://docs.microsoft.com/en-us/rest/api/maps/timezone/gettimezoneenumwindows</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>List of days of the week that the job should execute on. Only valid when frequency is Week. Possible values are Monday, Tuesday, Wednesday, Thursday, Friday, Saturday and Sunday.</summary>
    [JsonPropertyName("weekDays")]
    public IList<string>? WeekDays { get; set; }
}
#nullable disable

#nullable enable
/// <summary>One monthly_occurrence blocks as defined below to specifies occurrences of days within a month. Only valid when frequency is Month. The monthly_occurrence block supports fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScheduleSpecInitProviderMonthlyOccurrence
{
    /// <summary>Day of the occurrence. Must be one of Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday.</summary>
    [JsonPropertyName("day")]
    public string? Day { get; set; }

    /// <summary>Occurrence of the week within the month. Must be between 1 and 5. -1 for last week within the month.</summary>
    [JsonPropertyName("occurrence")]
    public double? Occurrence { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScheduleSpecInitProvider
{
    /// <summary>A description for this Schedule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The end time of the schedule.</summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary>The frequency of the schedule. - can be either OneTime, Day, Hour, Week, or Month.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>The number of frequencys between runs. Only valid when frequency is Day, Hour, Week, or Month and defaults to 1.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>List of days of the month that the job should execute on. Must be between 1 and 31. -1 for last day of the month. Only valid when frequency is Month.</summary>
    [JsonPropertyName("monthDays")]
    public IList<double>? MonthDays { get; set; }

    /// <summary>One monthly_occurrence blocks as defined below to specifies occurrences of days within a month. Only valid when frequency is Month. The monthly_occurrence block supports fields documented below.</summary>
    [JsonPropertyName("monthlyOccurrence")]
    public V1beta1ScheduleSpecInitProviderMonthlyOccurrence? MonthlyOccurrence { get; set; }

    /// <summary>Start time of the schedule. Must be at least five minutes in the future. Defaults to seven minutes in the future from the time the resource is created.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>The timezone of the start time. Defaults to Etc/UTC. For possible values see: https://docs.microsoft.com/en-us/rest/api/maps/timezone/gettimezoneenumwindows</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>List of days of the week that the job should execute on. Only valid when frequency is Week. Possible values are Monday, Tuesday, Wednesday, Thursday, Friday, Saturday and Sunday.</summary>
    [JsonPropertyName("weekDays")]
    public IList<string>? WeekDays { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScheduleSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScheduleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ScheduleSpec defines the desired state of Schedule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScheduleSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ScheduleSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ScheduleSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ScheduleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ScheduleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>One monthly_occurrence blocks as defined below to specifies occurrences of days within a month. Only valid when frequency is Month. The monthly_occurrence block supports fields documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScheduleStatusAtProviderMonthlyOccurrence
{
    /// <summary>Day of the occurrence. Must be one of Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday.</summary>
    [JsonPropertyName("day")]
    public string? Day { get; set; }

    /// <summary>Occurrence of the week within the month. Must be between 1 and 5. -1 for last week within the month.</summary>
    [JsonPropertyName("occurrence")]
    public double? Occurrence { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScheduleStatusAtProvider
{
    /// <summary>The name of the automation account in which the Schedule is created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("automationAccountName")]
    public string? AutomationAccountName { get; set; }

    /// <summary>A description for this Schedule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The end time of the schedule.</summary>
    [JsonPropertyName("expiryTime")]
    public string? ExpiryTime { get; set; }

    /// <summary>The frequency of the schedule. - can be either OneTime, Day, Hour, Week, or Month.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>The Automation Schedule ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The number of frequencys between runs. Only valid when frequency is Day, Hour, Week, or Month and defaults to 1.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>List of days of the month that the job should execute on. Must be between 1 and 31. -1 for last day of the month. Only valid when frequency is Month.</summary>
    [JsonPropertyName("monthDays")]
    public IList<double>? MonthDays { get; set; }

    /// <summary>One monthly_occurrence blocks as defined below to specifies occurrences of days within a month. Only valid when frequency is Month. The monthly_occurrence block supports fields documented below.</summary>
    [JsonPropertyName("monthlyOccurrence")]
    public V1beta1ScheduleStatusAtProviderMonthlyOccurrence? MonthlyOccurrence { get; set; }

    /// <summary>The name of the resource group in which the Schedule is created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Start time of the schedule. Must be at least five minutes in the future. Defaults to seven minutes in the future from the time the resource is created.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>The timezone of the start time. Defaults to Etc/UTC. For possible values see: https://docs.microsoft.com/en-us/rest/api/maps/timezone/gettimezoneenumwindows</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>List of days of the week that the job should execute on. Only valid when frequency is Week. Possible values are Monday, Tuesday, Wednesday, Thursday, Friday, Saturday and Sunday.</summary>
    [JsonPropertyName("weekDays")]
    public IList<string>? WeekDays { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScheduleStatusConditions
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
#nullable disable

#nullable enable
/// <summary>ScheduleStatus defines the observed state of Schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ScheduleStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ScheduleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ScheduleStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Schedule is the Schema for the Schedules API. Manages a Automation Schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Schedule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ScheduleSpec>, IStatus<V1beta1ScheduleStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Schedule";
    public const string KubeGroup = "automation.azure.m.upbound.io";
    public const string KubePluralName = "schedules";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ScheduleSpec defines the desired state of Schedule</summary>
    [JsonPropertyName("spec")]
    public V1beta1ScheduleSpec Spec { get; set; }

    /// <summary>ScheduleStatus defines the observed state of Schedule.</summary>
    [JsonPropertyName("status")]
    public V1beta1ScheduleStatus? Status { get; set; }
}
#nullable disable
