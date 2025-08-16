using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.backupdr.cnrm.cloud.google.com;
/// <summary>BackupDRBackupPlan is the Schema for the BackupDRBackupPlan API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BackupDRBackupPlanList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1BackupDRBackupPlan>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BackupDRBackupPlanList";
    public const string KubeGroup = "backupdr.cnrm.cloud.google.com";
    public const string KubePluralName = "backupdrbackupplans";
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
    public IList<V1alpha1BackupDRBackupPlan> Items { get; set; }
}

/// <summary>Required. A BackupWindow defines the window of day during which backup jobs  will run. Jobs are queued at the beginning of the window and will be marked  as `NOT_RUN` if they do not start by the end of the window.   Note: running jobs will not be cancelled at the end of the window.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRBackupPlanSpecBackupRulesStandardScheduleBackupWindow
{
    /// <summary>Required. The hour of day (1-24) when the window end for e.g. if value of  end hour of day is 10 that mean backup window end time is 10:00.   End hour of day should be greater than start hour of day.  0 &lt;= start_hour_of_day &lt; end_hour_of_day &lt;= 24   End hour of day is not include in backup window that mean if  end_hour_of_day= 10 jobs should start before 10:00.</summary>
    [JsonPropertyName("endHourOfDay")]
    public int? EndHourOfDay { get; set; }

    /// <summary>Required. The hour of day (0-23) when the window starts for e.g. if value of start hour of day is 6 that mean backup window start at 6:00.</summary>
    [JsonPropertyName("startHourOfDay")]
    public int? StartHourOfDay { get; set; }
}

/// <summary>Optional. Specifies a week day of the month like, FIRST SUNDAY or LAST  MONDAY, on which jobs will run. This will be specified by two fields in  `WeekDayOfMonth`, one for the day, e.g. `MONDAY`, and one for the week,  e.g. `LAST`.   This field is only applicable for `recurrence_type`, `MONTHLY` and  `YEARLY`. A validation error will occur if other values are supplied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRBackupPlanSpecBackupRulesStandardScheduleWeekDayOfMonth
{
    /// <summary>Required. Specifies the day of the week.</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>Required. Specifies the week of the month.</summary>
    [JsonPropertyName("weekOfMonth")]
    public string? WeekOfMonth { get; set; }
}

/// <summary>Required. Defines a schedule that runs within the confines of a defined window of time.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRBackupPlanSpecBackupRulesStandardSchedule
{
    /// <summary>Required. A BackupWindow defines the window of day during which backup jobs  will run. Jobs are queued at the beginning of the window and will be marked  as `NOT_RUN` if they do not start by the end of the window.   Note: running jobs will not be cancelled at the end of the window.</summary>
    [JsonPropertyName("backupWindow")]
    public V1alpha1BackupDRBackupPlanSpecBackupRulesStandardScheduleBackupWindow? BackupWindow { get; set; }

    /// <summary>Optional. Specifies days of months like 1, 5, or 14 on which jobs will run.   Values for `days_of_month` are only applicable for `recurrence_type`,  `MONTHLY` and `YEARLY`. A validation error will occur if other values are  supplied.</summary>
    [JsonPropertyName("daysOfMonth")]
    public IList<int>? DaysOfMonth { get; set; }

    /// <summary>Optional. Specifies days of week like, MONDAY or TUESDAY, on which jobs  will run.   This is required for `recurrence_type`, `WEEKLY` and is not applicable  otherwise. A validation error will occur if a value is supplied and  `recurrence_type` is not `WEEKLY`.</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    /// <summary>Optional. Specifies frequency for hourly backups. A hourly frequency of 2  means jobs will run every 2 hours from start time till end time defined.   This is required for `recurrence_type`, `HOURLY` and is not applicable  otherwise. A validation error will occur if a value is supplied and  `recurrence_type` is not `HOURLY`.   Value of hourly frequency should be between 6 and 23.   Reason for limit : We found that there is bandwidth limitation of 3GB/S for  GMI while taking a backup and 5GB/S while doing a restore. Given the amount  of parallel backups and restore we are targeting, this will potentially  take the backup time to mins and hours (in worst case scenario).</summary>
    [JsonPropertyName("hourlyFrequency")]
    public int? HourlyFrequency { get; set; }

    /// <summary>Optional. Specifies the months of year, like `FEBRUARY` and/or `MAY`, on  which jobs will run.   This field is only applicable when `recurrence_type` is `YEARLY`. A  validation error will occur if other values are supplied.</summary>
    [JsonPropertyName("months")]
    public IList<string>? Months { get; set; }

    /// <summary>Required. Specifies the `RecurrenceType` for the schedule.</summary>
    [JsonPropertyName("recurrenceType")]
    public string? RecurrenceType { get; set; }

    /// <summary>Required. The time zone to be used when interpreting the schedule. The value of this field must be a time zone name from the IANA tz database. See https://en.wikipedia.org/wiki/List_of_tz_database_time_zones for the list of valid timezone names. For e.g., Europe/Paris.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>Optional. Specifies a week day of the month like, FIRST SUNDAY or LAST  MONDAY, on which jobs will run. This will be specified by two fields in  `WeekDayOfMonth`, one for the day, e.g. `MONDAY`, and one for the week,  e.g. `LAST`.   This field is only applicable for `recurrence_type`, `MONTHLY` and  `YEARLY`. A validation error will occur if other values are supplied.</summary>
    [JsonPropertyName("weekDayOfMonth")]
    public V1alpha1BackupDRBackupPlanSpecBackupRulesStandardScheduleWeekDayOfMonth? WeekDayOfMonth { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRBackupPlanSpecBackupRules
{
    /// <summary>Required. Configures the duration for which backup data will be kept. It is  defined in “days”. The value should be greater than or equal to minimum  enforced retention of the backup vault.   Minimum value is 1 and maximum value is 90 for hourly backups.  Minimum value is 1 and maximum value is 90 for daily backups.  Minimum value is 7 and maximum value is 186 for weekly backups.  Minimum value is 30 and maximum value is 732 for monthly backups.  Minimum value is 365 and maximum value is 36159 for yearly backups.</summary>
    [JsonPropertyName("backupRetentionDays")]
    public int? BackupRetentionDays { get; set; }

    /// <summary>Required. Immutable. The unique id of this `BackupRule`. The `rule_id` is unique per `BackupPlan`.The `rule_id` must start with a lowercase letter followed by up to 62 lowercase letters, numbers, or hyphens. Pattern, /[a-z][a-z0-9-]{,62}/.</summary>
    [JsonPropertyName("ruleID")]
    public string? RuleID { get; set; }

    /// <summary>Required. Defines a schedule that runs within the confines of a defined window of time.</summary>
    [JsonPropertyName("standardSchedule")]
    public V1alpha1BackupDRBackupPlanSpecBackupRulesStandardSchedule? StandardSchedule { get; set; }
}

/// <summary>Required. Resource name of backup vault which will be used as storage location for backups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRBackupPlanSpecBackupVaultRef
{
    /// <summary>A reference to an externally managed BackupDRBackupVault resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/backupVaults/{{backupvaultID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a BackupDRBackupVault resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a BackupDRBackupVault resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRBackupPlanSpecProjectRef
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

/// <summary>BackupDRBackupPlanSpec defines the desired state of BackupDRBackupPlan</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRBackupPlanSpec
{
    /// <summary>Required. The backup rules for this `BackupPlan`. There must be at least one `BackupRule` message.</summary>
    [JsonPropertyName("backupRules")]
    public IList<V1alpha1BackupDRBackupPlanSpecBackupRules>? BackupRules { get; set; }

    /// <summary>Required. Resource name of backup vault which will be used as storage location for backups.</summary>
    [JsonPropertyName("backupVaultRef")]
    public V1alpha1BackupDRBackupPlanSpecBackupVaultRef BackupVaultRef { get; set; }

    /// <summary>Optional. The description of the `BackupPlan` resource.   The description allows for additional details about `BackupPlan` and its  use cases to be provided. An example description is the following:  "This  is a backup plan that performs a daily backup at 6pm and retains data for 3  months". The description must be at most 2048 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. `etag` is returned from the service in the response. As a user of the service, you may provide an etag value in this field to prevent stale resources.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Optional. This collection of key/value pairs allows for custom labels to be supplied by the user.  Example, {"tag": "Weekly"}.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1BackupDRBackupPlanSpecProjectRef ProjectRef { get; set; }

    /// <summary>The BackupDRBackupPlan name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. The resource type to which the `BackupPlan` will be applied. Examples include, "compute.googleapis.com/Instance", "sqladmin.googleapis.com/Instance", or "alloydb.googleapis.com/Cluster".</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRBackupPlanStatusConditions
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

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRBackupPlanStatusObservedState
{
    /// <summary>Output only. The Google Cloud Platform Service Account to be used by the BackupVault for taking backups. Specify the email address of the Backup Vault Service Account.</summary>
    [JsonPropertyName("backupVaultServiceAccount")]
    public string? BackupVaultServiceAccount { get; set; }

    /// <summary>Output only. When the `BackupPlan` was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The `State` for the `BackupPlan`.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. When the `BackupPlan` was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>BackupDRBackupPlanStatus defines the config connector machine state of BackupDRBackupPlan</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BackupDRBackupPlanStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BackupDRBackupPlanStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the BackupDRBackupPlan resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1BackupDRBackupPlanStatusObservedState? ObservedState { get; set; }
}

/// <summary>BackupDRBackupPlan is the Schema for the BackupDRBackupPlan API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BackupDRBackupPlan : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BackupDRBackupPlanSpec>, IStatus<V1alpha1BackupDRBackupPlanStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BackupDRBackupPlan";
    public const string KubeGroup = "backupdr.cnrm.cloud.google.com";
    public const string KubePluralName = "backupdrbackupplans";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BackupDRBackupPlanSpec defines the desired state of BackupDRBackupPlan</summary>
    [JsonPropertyName("spec")]
    public V1alpha1BackupDRBackupPlanSpec Spec { get; set; }

    /// <summary>BackupDRBackupPlanStatus defines the config connector machine state of BackupDRBackupPlan</summary>
    [JsonPropertyName("status")]
    public V1alpha1BackupDRBackupPlanStatus? Status { get; set; }
}