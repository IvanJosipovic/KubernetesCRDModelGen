using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.recoveryservices.azure.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BackupPolicyFileShareSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareSpecForProviderBackupHourly
{
    /// <summary>Specifies the interval at which backup needs to be triggered. Possible values are 4, 6, 8 and 12.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>Specifies the start time of the hourly backup. The time format should be in 24-hour format. Times must be either on the hour or half hour (e.g. 12:00, 12:30, 13:00, etc.).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Species the duration of the backup window in hours. Details could be found here.</summary>
    [JsonPropertyName("windowDuration")]
    public double? WindowDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareSpecForProviderBackup
{
    /// <summary>Sets the backup frequency. Possible values are Daily and Hourly.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>A hourly block defined as below. This is required when frequency is set to Hourly.</summary>
    [JsonPropertyName("hourly")]
    public IList<V1beta1BackupPolicyFileShareSpecForProviderBackupHourly>? Hourly { get; set; }

    /// <summary>The time of day to perform the backup in 24-hour format. Times must be either on the hour or half hour (e.g. 12:00, 12:30, 13:00, etc.)</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BackupPolicyFileShareSpecForProviderRecoveryVaultNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BackupPolicyFileShareSpecForProviderRecoveryVaultNameRefPolicyResolveEnum
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
public partial class V1beta1BackupPolicyFileShareSpecForProviderRecoveryVaultNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupPolicyFileShareSpecForProviderRecoveryVaultNameRefPolicyResolutionEnum>))]
    public V1beta1BackupPolicyFileShareSpecForProviderRecoveryVaultNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupPolicyFileShareSpecForProviderRecoveryVaultNameRefPolicyResolveEnum>))]
    public V1beta1BackupPolicyFileShareSpecForProviderRecoveryVaultNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Vault in recoveryservices to populate recoveryVaultName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareSpecForProviderRecoveryVaultNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupPolicyFileShareSpecForProviderRecoveryVaultNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BackupPolicyFileShareSpecForProviderRecoveryVaultNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BackupPolicyFileShareSpecForProviderRecoveryVaultNameSelectorPolicyResolveEnum
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
public partial class V1beta1BackupPolicyFileShareSpecForProviderRecoveryVaultNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupPolicyFileShareSpecForProviderRecoveryVaultNameSelectorPolicyResolutionEnum>))]
    public V1beta1BackupPolicyFileShareSpecForProviderRecoveryVaultNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupPolicyFileShareSpecForProviderRecoveryVaultNameSelectorPolicyResolveEnum>))]
    public V1beta1BackupPolicyFileShareSpecForProviderRecoveryVaultNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Vault in recoveryservices to populate recoveryVaultName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareSpecForProviderRecoveryVaultNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupPolicyFileShareSpecForProviderRecoveryVaultNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BackupPolicyFileShareSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BackupPolicyFileShareSpecForProviderResourceGroupNameRefPolicyResolveEnum
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
public partial class V1beta1BackupPolicyFileShareSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupPolicyFileShareSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1BackupPolicyFileShareSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupPolicyFileShareSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1BackupPolicyFileShareSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupPolicyFileShareSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BackupPolicyFileShareSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BackupPolicyFileShareSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
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
public partial class V1beta1BackupPolicyFileShareSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupPolicyFileShareSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1BackupPolicyFileShareSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupPolicyFileShareSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1BackupPolicyFileShareSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupPolicyFileShareSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareSpecForProviderRetentionDaily
{
    /// <summary>The number of daily backups to keep. Must be between 1 and 200 (inclusive)</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareSpecForProviderRetentionMonthly
{
    /// <summary>The number of monthly backups to keep. Must be between 1 and 120</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The days of the month to retain backups of. Must be between 1 and 31.</summary>
    [JsonPropertyName("days")]
    public IList<double>? Days { get; set; }

    /// <summary>Including the last day of the month, default to false.</summary>
    [JsonPropertyName("includeLastDays")]
    public bool? IncludeLastDays { get; set; }

    /// <summary>The weekday backups to retain . Must be one of Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }

    /// <summary>The weeks of the month to retain backups of. Must be one of First, Second, Third, Fourth, Last.</summary>
    [JsonPropertyName("weeks")]
    public IList<string>? Weeks { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareSpecForProviderRetentionWeekly
{
    /// <summary>The number of daily backups to keep. Must be between 1 and 200 (inclusive)</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The weekday backups to retain. Must be one of Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareSpecForProviderRetentionYearly
{
    /// <summary>The number of yearly backups to keep. Must be between 1 and 10</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The days of the month to retain backups of. Must be between 1 and 31.</summary>
    [JsonPropertyName("days")]
    public IList<double>? Days { get; set; }

    /// <summary>Including the last day of the month, default to false.</summary>
    [JsonPropertyName("includeLastDays")]
    public bool? IncludeLastDays { get; set; }

    /// <summary>The months of the year to retain backups of. Must be one of January, February, March, April, May, June, July, Augest, September, October, November and December.</summary>
    [JsonPropertyName("months")]
    public IList<string>? Months { get; set; }

    /// <summary>The weekday backups to retain . Must be one of Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }

    /// <summary>The weeks of the month to retain backups of. Must be one of First, Second, Third, Fourth, Last.</summary>
    [JsonPropertyName("weeks")]
    public IList<string>? Weeks { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareSpecForProvider
{
    /// <summary>Configures the Policy backup frequency and times as documented in the backup block below.</summary>
    [JsonPropertyName("backup")]
    public IList<V1beta1BackupPolicyFileShareSpecForProviderBackup>? Backup { get; set; }

    /// <summary>Specifies the name of the Recovery Services Vault to use. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("recoveryVaultName")]
    public string? RecoveryVaultName { get; set; }

    /// <summary>Reference to a Vault in recoveryservices to populate recoveryVaultName.</summary>
    [JsonPropertyName("recoveryVaultNameRef")]
    public V1beta1BackupPolicyFileShareSpecForProviderRecoveryVaultNameRef? RecoveryVaultNameRef { get; set; }

    /// <summary>Selector for a Vault in recoveryservices to populate recoveryVaultName.</summary>
    [JsonPropertyName("recoveryVaultNameSelector")]
    public V1beta1BackupPolicyFileShareSpecForProviderRecoveryVaultNameSelector? RecoveryVaultNameSelector { get; set; }

    /// <summary>The name of the resource group in which to create the policy. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1BackupPolicyFileShareSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1BackupPolicyFileShareSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Configures the policy daily retention as documented in the retention_daily block below.</summary>
    [JsonPropertyName("retentionDaily")]
    public IList<V1beta1BackupPolicyFileShareSpecForProviderRetentionDaily>? RetentionDaily { get; set; }

    /// <summary>Configures the policy monthly retention as documented in the retention_monthly block below.</summary>
    [JsonPropertyName("retentionMonthly")]
    public IList<V1beta1BackupPolicyFileShareSpecForProviderRetentionMonthly>? RetentionMonthly { get; set; }

    /// <summary>Configures the policy weekly retention as documented in the retention_weekly block below.</summary>
    [JsonPropertyName("retentionWeekly")]
    public IList<V1beta1BackupPolicyFileShareSpecForProviderRetentionWeekly>? RetentionWeekly { get; set; }

    /// <summary>Configures the policy yearly retention as documented in the retention_yearly block below.</summary>
    [JsonPropertyName("retentionYearly")]
    public IList<V1beta1BackupPolicyFileShareSpecForProviderRetentionYearly>? RetentionYearly { get; set; }

    /// <summary>Specifies the timezone. the possible values are defined here. Defaults to UTC</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareSpecInitProviderBackupHourly
{
    /// <summary>Specifies the interval at which backup needs to be triggered. Possible values are 4, 6, 8 and 12.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>Specifies the start time of the hourly backup. The time format should be in 24-hour format. Times must be either on the hour or half hour (e.g. 12:00, 12:30, 13:00, etc.).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Species the duration of the backup window in hours. Details could be found here.</summary>
    [JsonPropertyName("windowDuration")]
    public double? WindowDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareSpecInitProviderBackup
{
    /// <summary>Sets the backup frequency. Possible values are Daily and Hourly.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>A hourly block defined as below. This is required when frequency is set to Hourly.</summary>
    [JsonPropertyName("hourly")]
    public IList<V1beta1BackupPolicyFileShareSpecInitProviderBackupHourly>? Hourly { get; set; }

    /// <summary>The time of day to perform the backup in 24-hour format. Times must be either on the hour or half hour (e.g. 12:00, 12:30, 13:00, etc.)</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareSpecInitProviderRetentionDaily
{
    /// <summary>The number of daily backups to keep. Must be between 1 and 200 (inclusive)</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareSpecInitProviderRetentionMonthly
{
    /// <summary>The number of monthly backups to keep. Must be between 1 and 120</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The days of the month to retain backups of. Must be between 1 and 31.</summary>
    [JsonPropertyName("days")]
    public IList<double>? Days { get; set; }

    /// <summary>Including the last day of the month, default to false.</summary>
    [JsonPropertyName("includeLastDays")]
    public bool? IncludeLastDays { get; set; }

    /// <summary>The weekday backups to retain . Must be one of Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }

    /// <summary>The weeks of the month to retain backups of. Must be one of First, Second, Third, Fourth, Last.</summary>
    [JsonPropertyName("weeks")]
    public IList<string>? Weeks { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareSpecInitProviderRetentionWeekly
{
    /// <summary>The number of daily backups to keep. Must be between 1 and 200 (inclusive)</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The weekday backups to retain. Must be one of Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareSpecInitProviderRetentionYearly
{
    /// <summary>The number of yearly backups to keep. Must be between 1 and 10</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The days of the month to retain backups of. Must be between 1 and 31.</summary>
    [JsonPropertyName("days")]
    public IList<double>? Days { get; set; }

    /// <summary>Including the last day of the month, default to false.</summary>
    [JsonPropertyName("includeLastDays")]
    public bool? IncludeLastDays { get; set; }

    /// <summary>The months of the year to retain backups of. Must be one of January, February, March, April, May, June, July, Augest, September, October, November and December.</summary>
    [JsonPropertyName("months")]
    public IList<string>? Months { get; set; }

    /// <summary>The weekday backups to retain . Must be one of Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }

    /// <summary>The weeks of the month to retain backups of. Must be one of First, Second, Third, Fourth, Last.</summary>
    [JsonPropertyName("weeks")]
    public IList<string>? Weeks { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareSpecInitProvider
{
    /// <summary>Configures the Policy backup frequency and times as documented in the backup block below.</summary>
    [JsonPropertyName("backup")]
    public IList<V1beta1BackupPolicyFileShareSpecInitProviderBackup>? Backup { get; set; }

    /// <summary>Configures the policy daily retention as documented in the retention_daily block below.</summary>
    [JsonPropertyName("retentionDaily")]
    public IList<V1beta1BackupPolicyFileShareSpecInitProviderRetentionDaily>? RetentionDaily { get; set; }

    /// <summary>Configures the policy monthly retention as documented in the retention_monthly block below.</summary>
    [JsonPropertyName("retentionMonthly")]
    public IList<V1beta1BackupPolicyFileShareSpecInitProviderRetentionMonthly>? RetentionMonthly { get; set; }

    /// <summary>Configures the policy weekly retention as documented in the retention_weekly block below.</summary>
    [JsonPropertyName("retentionWeekly")]
    public IList<V1beta1BackupPolicyFileShareSpecInitProviderRetentionWeekly>? RetentionWeekly { get; set; }

    /// <summary>Configures the policy yearly retention as documented in the retention_yearly block below.</summary>
    [JsonPropertyName("retentionYearly")]
    public IList<V1beta1BackupPolicyFileShareSpecInitProviderRetentionYearly>? RetentionYearly { get; set; }

    /// <summary>Specifies the timezone. the possible values are defined here. Defaults to UTC</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BackupPolicyFileShareSpecManagementPoliciesEnum
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
public enum V1beta1BackupPolicyFileShareSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BackupPolicyFileShareSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1BackupPolicyFileShareSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupPolicyFileShareSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1BackupPolicyFileShareSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupPolicyFileShareSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1BackupPolicyFileShareSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupPolicyFileShareSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BackupPolicyFileShareSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1BackupPolicyFileShareSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1BackupPolicyFileShareSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupPolicyFileShareSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1BackupPolicyFileShareSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupPolicyFileShareSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1BackupPolicyFileShareSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupPolicyFileShareSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1BackupPolicyFileShareSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1BackupPolicyFileShareSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1BackupPolicyFileShareSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>BackupPolicyFileShareSpec defines the desired state of BackupPolicyFileShare</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1BackupPolicyFileShareSpecDeletionPolicyEnum>))]
    public V1beta1BackupPolicyFileShareSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1BackupPolicyFileShareSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1BackupPolicyFileShareSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1BackupPolicyFileShareSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BackupPolicyFileShareSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1BackupPolicyFileShareSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BackupPolicyFileShareSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareStatusAtProviderBackupHourly
{
    /// <summary>Specifies the interval at which backup needs to be triggered. Possible values are 4, 6, 8 and 12.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>Specifies the start time of the hourly backup. The time format should be in 24-hour format. Times must be either on the hour or half hour (e.g. 12:00, 12:30, 13:00, etc.).</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>Species the duration of the backup window in hours. Details could be found here.</summary>
    [JsonPropertyName("windowDuration")]
    public double? WindowDuration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareStatusAtProviderBackup
{
    /// <summary>Sets the backup frequency. Possible values are Daily and Hourly.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>A hourly block defined as below. This is required when frequency is set to Hourly.</summary>
    [JsonPropertyName("hourly")]
    public IList<V1beta1BackupPolicyFileShareStatusAtProviderBackupHourly>? Hourly { get; set; }

    /// <summary>The time of day to perform the backup in 24-hour format. Times must be either on the hour or half hour (e.g. 12:00, 12:30, 13:00, etc.)</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareStatusAtProviderRetentionDaily
{
    /// <summary>The number of daily backups to keep. Must be between 1 and 200 (inclusive)</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareStatusAtProviderRetentionMonthly
{
    /// <summary>The number of monthly backups to keep. Must be between 1 and 120</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The days of the month to retain backups of. Must be between 1 and 31.</summary>
    [JsonPropertyName("days")]
    public IList<double>? Days { get; set; }

    /// <summary>Including the last day of the month, default to false.</summary>
    [JsonPropertyName("includeLastDays")]
    public bool? IncludeLastDays { get; set; }

    /// <summary>The weekday backups to retain . Must be one of Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }

    /// <summary>The weeks of the month to retain backups of. Must be one of First, Second, Third, Fourth, Last.</summary>
    [JsonPropertyName("weeks")]
    public IList<string>? Weeks { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareStatusAtProviderRetentionWeekly
{
    /// <summary>The number of daily backups to keep. Must be between 1 and 200 (inclusive)</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The weekday backups to retain. Must be one of Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareStatusAtProviderRetentionYearly
{
    /// <summary>The number of yearly backups to keep. Must be between 1 and 10</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The days of the month to retain backups of. Must be between 1 and 31.</summary>
    [JsonPropertyName("days")]
    public IList<double>? Days { get; set; }

    /// <summary>Including the last day of the month, default to false.</summary>
    [JsonPropertyName("includeLastDays")]
    public bool? IncludeLastDays { get; set; }

    /// <summary>The months of the year to retain backups of. Must be one of January, February, March, April, May, June, July, Augest, September, October, November and December.</summary>
    [JsonPropertyName("months")]
    public IList<string>? Months { get; set; }

    /// <summary>The weekday backups to retain . Must be one of Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }

    /// <summary>The weeks of the month to retain backups of. Must be one of First, Second, Third, Fourth, Last.</summary>
    [JsonPropertyName("weeks")]
    public IList<string>? Weeks { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareStatusAtProvider
{
    /// <summary>Configures the Policy backup frequency and times as documented in the backup block below.</summary>
    [JsonPropertyName("backup")]
    public IList<V1beta1BackupPolicyFileShareStatusAtProviderBackup>? Backup { get; set; }

    /// <summary>The ID of the Azure File Share Backup Policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the name of the Recovery Services Vault to use. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("recoveryVaultName")]
    public string? RecoveryVaultName { get; set; }

    /// <summary>The name of the resource group in which to create the policy. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Configures the policy daily retention as documented in the retention_daily block below.</summary>
    [JsonPropertyName("retentionDaily")]
    public IList<V1beta1BackupPolicyFileShareStatusAtProviderRetentionDaily>? RetentionDaily { get; set; }

    /// <summary>Configures the policy monthly retention as documented in the retention_monthly block below.</summary>
    [JsonPropertyName("retentionMonthly")]
    public IList<V1beta1BackupPolicyFileShareStatusAtProviderRetentionMonthly>? RetentionMonthly { get; set; }

    /// <summary>Configures the policy weekly retention as documented in the retention_weekly block below.</summary>
    [JsonPropertyName("retentionWeekly")]
    public IList<V1beta1BackupPolicyFileShareStatusAtProviderRetentionWeekly>? RetentionWeekly { get; set; }

    /// <summary>Configures the policy yearly retention as documented in the retention_yearly block below.</summary>
    [JsonPropertyName("retentionYearly")]
    public IList<V1beta1BackupPolicyFileShareStatusAtProviderRetentionYearly>? RetentionYearly { get; set; }

    /// <summary>Specifies the timezone. the possible values are defined here. Defaults to UTC</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareStatusConditions
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

/// <summary>BackupPolicyFileShareStatus defines the observed state of BackupPolicyFileShare.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyFileShareStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1BackupPolicyFileShareStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BackupPolicyFileShareStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>BackupPolicyFileShare is the Schema for the BackupPolicyFileShares API. Manages an Azure File Share Backup Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BackupPolicyFileShare : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BackupPolicyFileShareSpec>, IStatus<V1beta1BackupPolicyFileShareStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BackupPolicyFileShare";
    public const string KubeGroup = "recoveryservices.azure.upbound.io";
    public const string KubePluralName = "backuppolicyfileshares";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BackupPolicyFileShareSpec defines the desired state of BackupPolicyFileShare</summary>
    [JsonPropertyName("spec")]
    public V1beta1BackupPolicyFileShareSpec Spec { get; set; }

    /// <summary>BackupPolicyFileShareStatus defines the observed state of BackupPolicyFileShare.</summary>
    [JsonPropertyName("status")]
    public V1beta1BackupPolicyFileShareStatus? Status { get; set; }
}