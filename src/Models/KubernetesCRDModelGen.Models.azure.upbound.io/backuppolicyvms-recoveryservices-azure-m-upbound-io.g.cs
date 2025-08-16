using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.recoveryservices.azure.m.upbound.io;
/// <summary>BackupPolicyVM is the Schema for the BackupPolicyVMs API. Manages an Azure Backup VM Backup Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BackupPolicyVMList : IKubernetesObject<V1ListMeta>, IItems<V1beta1BackupPolicyVM>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BackupPolicyVMList";
    public const string KubeGroup = "recoveryservices.azure.m.upbound.io";
    public const string KubePluralName = "backuppolicyvms";
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
    public IList<V1beta1BackupPolicyVM> Items { get; set; }
}

/// <summary>Configures the Policy backup frequency, times &amp; days as documented in the backup block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMSpecForProviderBackup
{
    /// <summary>Sets the backup frequency. Possible values are Hourly, Daily and Weekly.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>Duration of the backup window in hours. Possible values are between 4 and 24 This is used when frequency is Hourly.</summary>
    [JsonPropertyName("hourDuration")]
    public double? HourDuration { get; set; }

    /// <summary>Interval in hour at which backup is triggered. Possible values are 4, 6, 8 and 12. This is used when frequency is Hourly.</summary>
    [JsonPropertyName("hourInterval")]
    public double? HourInterval { get; set; }

    /// <summary>The time of day to perform the backup in 24hour format.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }

    /// <summary>The days of the week to perform backups on. Must be one of Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday. This is used when frequency is Weekly.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }
}

/// <summary>Specifies the instant restore resource group name as documented in the instant_restore_resource_group block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMSpecForProviderInstantRestoreResourceGroup
{
    /// <summary>The prefix for the instant_restore_resource_group name.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The suffix for the instant_restore_resource_group name.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMSpecForProviderRecoveryVaultNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Vault in recoveryservices to populate recoveryVaultName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMSpecForProviderRecoveryVaultNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupPolicyVMSpecForProviderRecoveryVaultNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMSpecForProviderRecoveryVaultNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Vault in recoveryservices to populate recoveryVaultName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMSpecForProviderRecoveryVaultNameSelector
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
    public V1beta1BackupPolicyVMSpecForProviderRecoveryVaultNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1BackupPolicyVMSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupPolicyVMSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1BackupPolicyVMSpecForProviderResourceGroupNameSelector
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
    public V1beta1BackupPolicyVMSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Configures the policy daily retention as documented in the retention_daily block below. Required when backup frequency is Daily.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMSpecForProviderRetentionDaily
{
    /// <summary>The number of daily backups to keep. Must be between 7 and 9999.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

/// <summary>Configures the policy monthly retention as documented in the retention_monthly block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMSpecForProviderRetentionMonthly
{
    /// <summary>The number of monthly backups to keep. Must be between 1 and 9999</summary>
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

/// <summary>Configures the policy weekly retention as documented in the retention_weekly block below. Required when backup frequency is Weekly.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMSpecForProviderRetentionWeekly
{
    /// <summary>The number of weekly backups to keep. Must be between 1 and 9999</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The weekday backups to retain. Must be one of Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }
}

/// <summary>Configures the policy yearly retention as documented in the retention_yearly block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMSpecForProviderRetentionYearly
{
    /// <summary>The number of yearly backups to keep. Must be between 1 and 9999</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The days of the month to retain backups of. Must be between 1 and 31.</summary>
    [JsonPropertyName("days")]
    public IList<double>? Days { get; set; }

    /// <summary>Including the last day of the month, default to false.</summary>
    [JsonPropertyName("includeLastDays")]
    public bool? IncludeLastDays { get; set; }

    /// <summary>The months of the year to retain backups of. Must be one of January, February, March, April, May, June, July, August, September, October, November and December.</summary>
    [JsonPropertyName("months")]
    public IList<string>? Months { get; set; }

    /// <summary>The weekday backups to retain . Must be one of Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }

    /// <summary>The weeks of the month to retain backups of. Must be one of First, Second, Third, Fourth, Last.</summary>
    [JsonPropertyName("weeks")]
    public IList<string>? Weeks { get; set; }
}

/// <summary>An archived_restore_point block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMSpecForProviderTieringPolicyArchivedRestorePoint
{
    /// <summary>The number of days/weeks/months/years to retain backups in current tier before tiering.</summary>
    [JsonPropertyName("duration")]
    public double? Duration { get; set; }

    /// <summary>The retention duration type. Possible values are Days, Weeks, Months and Years.</summary>
    [JsonPropertyName("durationType")]
    public string? DurationType { get; set; }

    /// <summary>The tiering mode to control automatic tiering of recovery points. Possible values are TierAfter and TierRecommended.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>A tiering_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMSpecForProviderTieringPolicy
{
    /// <summary>An archived_restore_point block as defined below.</summary>
    [JsonPropertyName("archivedRestorePoint")]
    public V1beta1BackupPolicyVMSpecForProviderTieringPolicyArchivedRestorePoint? ArchivedRestorePoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMSpecForProvider
{
    /// <summary>Configures the Policy backup frequency, times &amp; days as documented in the backup block below.</summary>
    [JsonPropertyName("backup")]
    public V1beta1BackupPolicyVMSpecForProviderBackup? Backup { get; set; }

    /// <summary>Specifies the instant restore resource group name as documented in the instant_restore_resource_group block below.</summary>
    [JsonPropertyName("instantRestoreResourceGroup")]
    public V1beta1BackupPolicyVMSpecForProviderInstantRestoreResourceGroup? InstantRestoreResourceGroup { get; set; }

    /// <summary>Specifies the instant restore retention range in days. Possible values are between 1 and 5 when policy_type is V1, and 1 to 30 when policy_type is V2.</summary>
    [JsonPropertyName("instantRestoreRetentionDays")]
    public double? InstantRestoreRetentionDays { get; set; }

    /// <summary>Type of the Backup Policy. Possible values are V1 and V2 where V2 stands for the Enhanced Policy. Defaults to V1. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }

    /// <summary>Specifies the name of the Recovery Services Vault to use. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("recoveryVaultName")]
    public string? RecoveryVaultName { get; set; }

    /// <summary>Reference to a Vault in recoveryservices to populate recoveryVaultName.</summary>
    [JsonPropertyName("recoveryVaultNameRef")]
    public V1beta1BackupPolicyVMSpecForProviderRecoveryVaultNameRef? RecoveryVaultNameRef { get; set; }

    /// <summary>Selector for a Vault in recoveryservices to populate recoveryVaultName.</summary>
    [JsonPropertyName("recoveryVaultNameSelector")]
    public V1beta1BackupPolicyVMSpecForProviderRecoveryVaultNameSelector? RecoveryVaultNameSelector { get; set; }

    /// <summary>The name of the resource group in which to create the policy. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1BackupPolicyVMSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1BackupPolicyVMSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Configures the policy daily retention as documented in the retention_daily block below. Required when backup frequency is Daily.</summary>
    [JsonPropertyName("retentionDaily")]
    public V1beta1BackupPolicyVMSpecForProviderRetentionDaily? RetentionDaily { get; set; }

    /// <summary>Configures the policy monthly retention as documented in the retention_monthly block below.</summary>
    [JsonPropertyName("retentionMonthly")]
    public V1beta1BackupPolicyVMSpecForProviderRetentionMonthly? RetentionMonthly { get; set; }

    /// <summary>Configures the policy weekly retention as documented in the retention_weekly block below. Required when backup frequency is Weekly.</summary>
    [JsonPropertyName("retentionWeekly")]
    public V1beta1BackupPolicyVMSpecForProviderRetentionWeekly? RetentionWeekly { get; set; }

    /// <summary>Configures the policy yearly retention as documented in the retention_yearly block below.</summary>
    [JsonPropertyName("retentionYearly")]
    public V1beta1BackupPolicyVMSpecForProviderRetentionYearly? RetentionYearly { get; set; }

    /// <summary>A tiering_policy block as defined below.</summary>
    [JsonPropertyName("tieringPolicy")]
    public V1beta1BackupPolicyVMSpecForProviderTieringPolicy? TieringPolicy { get; set; }

    /// <summary>Specifies the timezone. the possible values are defined here. Defaults to UTC</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

/// <summary>Configures the Policy backup frequency, times &amp; days as documented in the backup block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMSpecInitProviderBackup
{
    /// <summary>Sets the backup frequency. Possible values are Hourly, Daily and Weekly.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>Duration of the backup window in hours. Possible values are between 4 and 24 This is used when frequency is Hourly.</summary>
    [JsonPropertyName("hourDuration")]
    public double? HourDuration { get; set; }

    /// <summary>Interval in hour at which backup is triggered. Possible values are 4, 6, 8 and 12. This is used when frequency is Hourly.</summary>
    [JsonPropertyName("hourInterval")]
    public double? HourInterval { get; set; }

    /// <summary>The time of day to perform the backup in 24hour format.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }

    /// <summary>The days of the week to perform backups on. Must be one of Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday. This is used when frequency is Weekly.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }
}

/// <summary>Specifies the instant restore resource group name as documented in the instant_restore_resource_group block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMSpecInitProviderInstantRestoreResourceGroup
{
    /// <summary>The prefix for the instant_restore_resource_group name.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The suffix for the instant_restore_resource_group name.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>Configures the policy daily retention as documented in the retention_daily block below. Required when backup frequency is Daily.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMSpecInitProviderRetentionDaily
{
    /// <summary>The number of daily backups to keep. Must be between 7 and 9999.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

/// <summary>Configures the policy monthly retention as documented in the retention_monthly block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMSpecInitProviderRetentionMonthly
{
    /// <summary>The number of monthly backups to keep. Must be between 1 and 9999</summary>
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

/// <summary>Configures the policy weekly retention as documented in the retention_weekly block below. Required when backup frequency is Weekly.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMSpecInitProviderRetentionWeekly
{
    /// <summary>The number of weekly backups to keep. Must be between 1 and 9999</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The weekday backups to retain. Must be one of Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }
}

/// <summary>Configures the policy yearly retention as documented in the retention_yearly block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMSpecInitProviderRetentionYearly
{
    /// <summary>The number of yearly backups to keep. Must be between 1 and 9999</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The days of the month to retain backups of. Must be between 1 and 31.</summary>
    [JsonPropertyName("days")]
    public IList<double>? Days { get; set; }

    /// <summary>Including the last day of the month, default to false.</summary>
    [JsonPropertyName("includeLastDays")]
    public bool? IncludeLastDays { get; set; }

    /// <summary>The months of the year to retain backups of. Must be one of January, February, March, April, May, June, July, August, September, October, November and December.</summary>
    [JsonPropertyName("months")]
    public IList<string>? Months { get; set; }

    /// <summary>The weekday backups to retain . Must be one of Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }

    /// <summary>The weeks of the month to retain backups of. Must be one of First, Second, Third, Fourth, Last.</summary>
    [JsonPropertyName("weeks")]
    public IList<string>? Weeks { get; set; }
}

/// <summary>An archived_restore_point block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMSpecInitProviderTieringPolicyArchivedRestorePoint
{
    /// <summary>The number of days/weeks/months/years to retain backups in current tier before tiering.</summary>
    [JsonPropertyName("duration")]
    public double? Duration { get; set; }

    /// <summary>The retention duration type. Possible values are Days, Weeks, Months and Years.</summary>
    [JsonPropertyName("durationType")]
    public string? DurationType { get; set; }

    /// <summary>The tiering mode to control automatic tiering of recovery points. Possible values are TierAfter and TierRecommended.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>A tiering_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMSpecInitProviderTieringPolicy
{
    /// <summary>An archived_restore_point block as defined below.</summary>
    [JsonPropertyName("archivedRestorePoint")]
    public V1beta1BackupPolicyVMSpecInitProviderTieringPolicyArchivedRestorePoint? ArchivedRestorePoint { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMSpecInitProvider
{
    /// <summary>Configures the Policy backup frequency, times &amp; days as documented in the backup block below.</summary>
    [JsonPropertyName("backup")]
    public V1beta1BackupPolicyVMSpecInitProviderBackup? Backup { get; set; }

    /// <summary>Specifies the instant restore resource group name as documented in the instant_restore_resource_group block below.</summary>
    [JsonPropertyName("instantRestoreResourceGroup")]
    public V1beta1BackupPolicyVMSpecInitProviderInstantRestoreResourceGroup? InstantRestoreResourceGroup { get; set; }

    /// <summary>Specifies the instant restore retention range in days. Possible values are between 1 and 5 when policy_type is V1, and 1 to 30 when policy_type is V2.</summary>
    [JsonPropertyName("instantRestoreRetentionDays")]
    public double? InstantRestoreRetentionDays { get; set; }

    /// <summary>Type of the Backup Policy. Possible values are V1 and V2 where V2 stands for the Enhanced Policy. Defaults to V1. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }

    /// <summary>Configures the policy daily retention as documented in the retention_daily block below. Required when backup frequency is Daily.</summary>
    [JsonPropertyName("retentionDaily")]
    public V1beta1BackupPolicyVMSpecInitProviderRetentionDaily? RetentionDaily { get; set; }

    /// <summary>Configures the policy monthly retention as documented in the retention_monthly block below.</summary>
    [JsonPropertyName("retentionMonthly")]
    public V1beta1BackupPolicyVMSpecInitProviderRetentionMonthly? RetentionMonthly { get; set; }

    /// <summary>Configures the policy weekly retention as documented in the retention_weekly block below. Required when backup frequency is Weekly.</summary>
    [JsonPropertyName("retentionWeekly")]
    public V1beta1BackupPolicyVMSpecInitProviderRetentionWeekly? RetentionWeekly { get; set; }

    /// <summary>Configures the policy yearly retention as documented in the retention_yearly block below.</summary>
    [JsonPropertyName("retentionYearly")]
    public V1beta1BackupPolicyVMSpecInitProviderRetentionYearly? RetentionYearly { get; set; }

    /// <summary>A tiering_policy block as defined below.</summary>
    [JsonPropertyName("tieringPolicy")]
    public V1beta1BackupPolicyVMSpecInitProviderTieringPolicy? TieringPolicy { get; set; }

    /// <summary>Specifies the timezone. the possible values are defined here. Defaults to UTC</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMSpecProviderConfigRef
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
public partial class V1beta1BackupPolicyVMSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>BackupPolicyVMSpec defines the desired state of BackupPolicyVM</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1BackupPolicyVMSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1BackupPolicyVMSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BackupPolicyVMSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BackupPolicyVMSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configures the Policy backup frequency, times &amp; days as documented in the backup block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMStatusAtProviderBackup
{
    /// <summary>Sets the backup frequency. Possible values are Hourly, Daily and Weekly.</summary>
    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    /// <summary>Duration of the backup window in hours. Possible values are between 4 and 24 This is used when frequency is Hourly.</summary>
    [JsonPropertyName("hourDuration")]
    public double? HourDuration { get; set; }

    /// <summary>Interval in hour at which backup is triggered. Possible values are 4, 6, 8 and 12. This is used when frequency is Hourly.</summary>
    [JsonPropertyName("hourInterval")]
    public double? HourInterval { get; set; }

    /// <summary>The time of day to perform the backup in 24hour format.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }

    /// <summary>The days of the week to perform backups on. Must be one of Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday. This is used when frequency is Weekly.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }
}

/// <summary>Specifies the instant restore resource group name as documented in the instant_restore_resource_group block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMStatusAtProviderInstantRestoreResourceGroup
{
    /// <summary>The prefix for the instant_restore_resource_group name.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>The suffix for the instant_restore_resource_group name.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>Configures the policy daily retention as documented in the retention_daily block below. Required when backup frequency is Daily.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMStatusAtProviderRetentionDaily
{
    /// <summary>The number of daily backups to keep. Must be between 7 and 9999.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }
}

/// <summary>Configures the policy monthly retention as documented in the retention_monthly block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMStatusAtProviderRetentionMonthly
{
    /// <summary>The number of monthly backups to keep. Must be between 1 and 9999</summary>
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

/// <summary>Configures the policy weekly retention as documented in the retention_weekly block below. Required when backup frequency is Weekly.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMStatusAtProviderRetentionWeekly
{
    /// <summary>The number of weekly backups to keep. Must be between 1 and 9999</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The weekday backups to retain. Must be one of Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }
}

/// <summary>Configures the policy yearly retention as documented in the retention_yearly block below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMStatusAtProviderRetentionYearly
{
    /// <summary>The number of yearly backups to keep. Must be between 1 and 9999</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The days of the month to retain backups of. Must be between 1 and 31.</summary>
    [JsonPropertyName("days")]
    public IList<double>? Days { get; set; }

    /// <summary>Including the last day of the month, default to false.</summary>
    [JsonPropertyName("includeLastDays")]
    public bool? IncludeLastDays { get; set; }

    /// <summary>The months of the year to retain backups of. Must be one of January, February, March, April, May, June, July, August, September, October, November and December.</summary>
    [JsonPropertyName("months")]
    public IList<string>? Months { get; set; }

    /// <summary>The weekday backups to retain . Must be one of Sunday, Monday, Tuesday, Wednesday, Thursday, Friday or Saturday.</summary>
    [JsonPropertyName("weekdays")]
    public IList<string>? Weekdays { get; set; }

    /// <summary>The weeks of the month to retain backups of. Must be one of First, Second, Third, Fourth, Last.</summary>
    [JsonPropertyName("weeks")]
    public IList<string>? Weeks { get; set; }
}

/// <summary>An archived_restore_point block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMStatusAtProviderTieringPolicyArchivedRestorePoint
{
    /// <summary>The number of days/weeks/months/years to retain backups in current tier before tiering.</summary>
    [JsonPropertyName("duration")]
    public double? Duration { get; set; }

    /// <summary>The retention duration type. Possible values are Days, Weeks, Months and Years.</summary>
    [JsonPropertyName("durationType")]
    public string? DurationType { get; set; }

    /// <summary>The tiering mode to control automatic tiering of recovery points. Possible values are TierAfter and TierRecommended.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>A tiering_policy block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMStatusAtProviderTieringPolicy
{
    /// <summary>An archived_restore_point block as defined below.</summary>
    [JsonPropertyName("archivedRestorePoint")]
    public V1beta1BackupPolicyVMStatusAtProviderTieringPolicyArchivedRestorePoint? ArchivedRestorePoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMStatusAtProvider
{
    /// <summary>Configures the Policy backup frequency, times &amp; days as documented in the backup block below.</summary>
    [JsonPropertyName("backup")]
    public V1beta1BackupPolicyVMStatusAtProviderBackup? Backup { get; set; }

    /// <summary>The ID of the VM Backup Policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the instant restore resource group name as documented in the instant_restore_resource_group block below.</summary>
    [JsonPropertyName("instantRestoreResourceGroup")]
    public V1beta1BackupPolicyVMStatusAtProviderInstantRestoreResourceGroup? InstantRestoreResourceGroup { get; set; }

    /// <summary>Specifies the instant restore retention range in days. Possible values are between 1 and 5 when policy_type is V1, and 1 to 30 when policy_type is V2.</summary>
    [JsonPropertyName("instantRestoreRetentionDays")]
    public double? InstantRestoreRetentionDays { get; set; }

    /// <summary>Type of the Backup Policy. Possible values are V1 and V2 where V2 stands for the Enhanced Policy. Defaults to V1. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }

    /// <summary>Specifies the name of the Recovery Services Vault to use. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("recoveryVaultName")]
    public string? RecoveryVaultName { get; set; }

    /// <summary>The name of the resource group in which to create the policy. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Configures the policy daily retention as documented in the retention_daily block below. Required when backup frequency is Daily.</summary>
    [JsonPropertyName("retentionDaily")]
    public V1beta1BackupPolicyVMStatusAtProviderRetentionDaily? RetentionDaily { get; set; }

    /// <summary>Configures the policy monthly retention as documented in the retention_monthly block below.</summary>
    [JsonPropertyName("retentionMonthly")]
    public V1beta1BackupPolicyVMStatusAtProviderRetentionMonthly? RetentionMonthly { get; set; }

    /// <summary>Configures the policy weekly retention as documented in the retention_weekly block below. Required when backup frequency is Weekly.</summary>
    [JsonPropertyName("retentionWeekly")]
    public V1beta1BackupPolicyVMStatusAtProviderRetentionWeekly? RetentionWeekly { get; set; }

    /// <summary>Configures the policy yearly retention as documented in the retention_yearly block below.</summary>
    [JsonPropertyName("retentionYearly")]
    public V1beta1BackupPolicyVMStatusAtProviderRetentionYearly? RetentionYearly { get; set; }

    /// <summary>A tiering_policy block as defined below.</summary>
    [JsonPropertyName("tieringPolicy")]
    public V1beta1BackupPolicyVMStatusAtProviderTieringPolicy? TieringPolicy { get; set; }

    /// <summary>Specifies the timezone. the possible values are defined here. Defaults to UTC</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMStatusConditions
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

/// <summary>BackupPolicyVMStatus defines the observed state of BackupPolicyVM.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyVMStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1BackupPolicyVMStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BackupPolicyVMStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>BackupPolicyVM is the Schema for the BackupPolicyVMs API. Manages an Azure Backup VM Backup Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BackupPolicyVM : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BackupPolicyVMSpec>, IStatus<V1beta1BackupPolicyVMStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BackupPolicyVM";
    public const string KubeGroup = "recoveryservices.azure.m.upbound.io";
    public const string KubePluralName = "backuppolicyvms";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BackupPolicyVMSpec defines the desired state of BackupPolicyVM</summary>
    [JsonPropertyName("spec")]
    public V1beta1BackupPolicyVMSpec Spec { get; set; }

    /// <summary>BackupPolicyVMStatus defines the observed state of BackupPolicyVM.</summary>
    [JsonPropertyName("status")]
    public V1beta1BackupPolicyVMStatus? Status { get; set; }
}