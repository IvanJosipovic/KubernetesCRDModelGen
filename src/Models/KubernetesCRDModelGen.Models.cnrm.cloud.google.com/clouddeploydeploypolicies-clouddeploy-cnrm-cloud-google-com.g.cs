using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.clouddeploy.cnrm.cloud.google.com;
#nullable enable
/// <summary>CloudDeployDeployPolicy is the Schema for the CloudDeployDeployPolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudDeployDeployPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CloudDeployDeployPolicy>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudDeployDeployPolicyList";
    public const string KubeGroup = "clouddeploy.cnrm.cloud.google.com";
    public const string KubePluralName = "clouddeploydeploypolicies";
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
    public IList<V1alpha1CloudDeployDeployPolicy> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeployPolicySpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. End date.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeployPolicySpecRulesRolloutRestrictionTimeWindowsOneTimeWindowsEndDate
{
    /// <summary>Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn't significant.</summary>
    [JsonPropertyName("day")]
    public int? Day { get; set; }

    /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public int? Month { get; set; }

    /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
    [JsonPropertyName("year")]
    public int? Year { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. End time (exclusive). You may use 24:00 for the end of the day.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeployPolicySpecRulesRolloutRestrictionTimeWindowsOneTimeWindowsEndTime
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public int? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public int? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public int? Seconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. Start date.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeployPolicySpecRulesRolloutRestrictionTimeWindowsOneTimeWindowsStartDate
{
    /// <summary>Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn't significant.</summary>
    [JsonPropertyName("day")]
    public int? Day { get; set; }

    /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public int? Month { get; set; }

    /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
    [JsonPropertyName("year")]
    public int? Year { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. Start time (inclusive). Use 00:00 for the beginning of the day.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeployPolicySpecRulesRolloutRestrictionTimeWindowsOneTimeWindowsStartTime
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public int? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public int? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public int? Seconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeployPolicySpecRulesRolloutRestrictionTimeWindowsOneTimeWindows
{
    /// <summary>Required. End date.</summary>
    [JsonPropertyName("endDate")]
    public V1alpha1CloudDeployDeployPolicySpecRulesRolloutRestrictionTimeWindowsOneTimeWindowsEndDate? EndDate { get; set; }

    /// <summary>Required. End time (exclusive). You may use 24:00 for the end of the day.</summary>
    [JsonPropertyName("endTime")]
    public V1alpha1CloudDeployDeployPolicySpecRulesRolloutRestrictionTimeWindowsOneTimeWindowsEndTime? EndTime { get; set; }

    /// <summary>Required. Start date.</summary>
    [JsonPropertyName("startDate")]
    public V1alpha1CloudDeployDeployPolicySpecRulesRolloutRestrictionTimeWindowsOneTimeWindowsStartDate? StartDate { get; set; }

    /// <summary>Required. Start time (inclusive). Use 00:00 for the beginning of the day.</summary>
    [JsonPropertyName("startTime")]
    public V1alpha1CloudDeployDeployPolicySpecRulesRolloutRestrictionTimeWindowsOneTimeWindowsStartTime? StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. End time (exclusive). Use 24:00 to indicate midnight. If you specify end_time you must also specify start_time. If left empty, this will block for the entire day for the days specified in days_of_week.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeployPolicySpecRulesRolloutRestrictionTimeWindowsWeeklyWindowsEndTime
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public int? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public int? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public int? Seconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Start time (inclusive). Use 00:00 for the beginning of the day. If you specify start_time you must also specify end_time. If left empty, this will block for the entire day for the days specified in days_of_week.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeployPolicySpecRulesRolloutRestrictionTimeWindowsWeeklyWindowsStartTime
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for scenarios like business closing time.</summary>
    [JsonPropertyName("hours")]
    public int? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public int? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows leap-seconds.</summary>
    [JsonPropertyName("seconds")]
    public int? Seconds { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeployPolicySpecRulesRolloutRestrictionTimeWindowsWeeklyWindows
{
    /// <summary>Optional. Days of week. If left empty, all days of the week will be included.</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    /// <summary>Optional. End time (exclusive). Use 24:00 to indicate midnight. If you specify end_time you must also specify start_time. If left empty, this will block for the entire day for the days specified in days_of_week.</summary>
    [JsonPropertyName("endTime")]
    public V1alpha1CloudDeployDeployPolicySpecRulesRolloutRestrictionTimeWindowsWeeklyWindowsEndTime? EndTime { get; set; }

    /// <summary>Optional. Start time (inclusive). Use 00:00 for the beginning of the day. If you specify start_time you must also specify end_time. If left empty, this will block for the entire day for the days specified in days_of_week.</summary>
    [JsonPropertyName("startTime")]
    public V1alpha1CloudDeployDeployPolicySpecRulesRolloutRestrictionTimeWindowsWeeklyWindowsStartTime? StartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Required. Time window within which actions are restricted.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeployPolicySpecRulesRolloutRestrictionTimeWindows
{
    /// <summary>Optional. One-time windows within which actions are restricted.</summary>
    [JsonPropertyName("oneTimeWindows")]
    public IList<V1alpha1CloudDeployDeployPolicySpecRulesRolloutRestrictionTimeWindowsOneTimeWindows>? OneTimeWindows { get; set; }

    /// <summary>Required. The time zone in IANA format [IANA Time Zone Database](https://www.iana.org/time-zones) (e.g. America/New_York).</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>Optional. Recurring weekly windows within which actions are restricted.</summary>
    [JsonPropertyName("weeklyWindows")]
    public IList<V1alpha1CloudDeployDeployPolicySpecRulesRolloutRestrictionTimeWindowsWeeklyWindows>? WeeklyWindows { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Rollout restrictions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeployPolicySpecRulesRolloutRestriction
{
    /// <summary>Optional. Rollout actions to be restricted as part of the policy. If left empty, all actions will be restricted.</summary>
    [JsonPropertyName("actions")]
    public IList<string>? Actions { get; set; }

    /// <summary>Required. Restriction rule ID. Required and must be unique within a DeployPolicy. The format is `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Optional. What invoked the action. If left empty, all invoker types will be restricted.</summary>
    [JsonPropertyName("invokers")]
    public IList<string>? Invokers { get; set; }

    /// <summary>Required. Time window within which actions are restricted.</summary>
    [JsonPropertyName("timeWindows")]
    public V1alpha1CloudDeployDeployPolicySpecRulesRolloutRestrictionTimeWindows? TimeWindows { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeployPolicySpecRules
{
    /// <summary>Rollout restrictions.</summary>
    [JsonPropertyName("rolloutRestriction")]
    public V1alpha1CloudDeployDeployPolicySpecRulesRolloutRestriction? RolloutRestriction { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Contains attributes about a delivery pipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeployPolicySpecSelectorsDeliveryPipeline
{
    /// <summary>ID of the `DeliveryPipeline`. The value of this field could be one of the  following:   * The last segment of a pipeline name  * "*", all delivery pipelines in a location</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>DeliveryPipeline labels.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Optional. Contains attributes about a target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeployPolicySpecSelectorsTarget
{
    /// <summary>ID of the `Target`. The value of this field could be one of the  following:   * The last segment of a target name  * "*", all targets in a location</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Target labels.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeployPolicySpecSelectors
{
    /// <summary>Optional. Contains attributes about a delivery pipeline.</summary>
    [JsonPropertyName("deliveryPipeline")]
    public V1alpha1CloudDeployDeployPolicySpecSelectorsDeliveryPipeline? DeliveryPipeline { get; set; }

    /// <summary>Optional. Contains attributes about a target.</summary>
    [JsonPropertyName("target")]
    public V1alpha1CloudDeployDeployPolicySpecSelectorsTarget? Target { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DeployPolicySpec defines the desired state of DeployDeployPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeployPolicySpec
{
    /// <summary>Description of the `DeployPolicy`. Max length is 255 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1CloudDeployDeployPolicySpecProjectRef ProjectRef { get; set; }

    /// <summary>The DeployDeployPolicy name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. Rules to apply. At least one rule must be present.</summary>
    [JsonPropertyName("rules")]
    public IList<V1alpha1CloudDeployDeployPolicySpecRules>? Rules { get; set; }

    /// <summary>Required. Selected resources to which the policy will be applied. At least one selector is required. If one selector matches the resource the policy applies. For example, if there are two selectors and the action being attempted matches one of them, the policy will apply to that action.</summary>
    [JsonPropertyName("selectors")]
    public IList<V1alpha1CloudDeployDeployPolicySpecSelectors>? Selectors { get; set; }

    /// <summary>When suspended, the policy will not prevent actions from occurring, even if the action violates the policy.</summary>
    [JsonPropertyName("suspended")]
    public bool? Suspended { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeployPolicyStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeployPolicyStatusObservedState
{
    /// <summary>Output only. Time at which the deploy policy was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Name of the `DeployPolicy`. Format is `projects/{project}/locations/{location}/deployPolicies/{deployPolicy}`. The `deployPolicy` component must match `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Output only. Unique identifier of the `DeployPolicy`.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. Most recent time at which the deploy policy was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DeployPolicyStatus defines the config connector machine state of DeployDeployPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployDeployPolicyStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CloudDeployDeployPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DeployDeployPolicy resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1CloudDeployDeployPolicyStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>CloudDeployDeployPolicy is the Schema for the CloudDeployDeployPolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudDeployDeployPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CloudDeployDeployPolicySpec>, IStatus<V1alpha1CloudDeployDeployPolicyStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudDeployDeployPolicy";
    public const string KubeGroup = "clouddeploy.cnrm.cloud.google.com";
    public const string KubePluralName = "clouddeploydeploypolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DeployPolicySpec defines the desired state of DeployDeployPolicy</summary>
    [JsonPropertyName("spec")]
    public V1alpha1CloudDeployDeployPolicySpec Spec { get; set; }

    /// <summary>DeployPolicyStatus defines the config connector machine state of DeployDeployPolicy</summary>
    [JsonPropertyName("status")]
    public V1alpha1CloudDeployDeployPolicyStatus? Status { get; set; }
}
#nullable disable
