using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.backup.aws.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PlanSpecDeletionPolicyEnum
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
public partial class V1beta1PlanSpecForProviderAdvancedBackupSetting
{
    /// <summary>Specifies the backup option for a selected resource. This option is only available for Windows VSS backup jobs. Set to { WindowsVSS = "enabled" } to enable Windows VSS backup option and create a VSS Windows backup.</summary>
    [JsonPropertyName("backupOptions")]
    public IDictionary<string, string>? BackupOptions { get; set; }

    /// <summary>The type of AWS resource to be backed up. For VSS Windows backups, the only supported resource type is Amazon EC2. Valid values: EC2.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanSpecForProviderRuleCopyActionLifecycle
{
    /// <summary>Specifies the number of days after creation that a recovery point is moved to cold storage.</summary>
    [JsonPropertyName("coldStorageAfter")]
    public double? ColdStorageAfter { get; set; }

    /// <summary>Specifies the number of days after creation that a recovery point is deleted. Must be 90 days greater than cold_storage_after.</summary>
    [JsonPropertyName("deleteAfter")]
    public double? DeleteAfter { get; set; }

    /// <summary>This setting will instruct your backup plan to transition supported resources to archive (cold) storage tier in accordance with your lifecycle settings.</summary>
    [JsonPropertyName("optInToArchiveForSupportedResources")]
    public bool? OptInToArchiveForSupportedResources { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanSpecForProviderRuleCopyAction
{
    /// <summary>An Amazon Resource Name (ARN) that uniquely identifies the destination backup vault for the copied backup.</summary>
    [JsonPropertyName("destinationVaultArn")]
    public string? DestinationVaultArn { get; set; }

    /// <summary>The lifecycle defines when a protected resource is transitioned to cold storage and when it expires.  Fields documented below.</summary>
    [JsonPropertyName("lifecycle")]
    public IList<V1beta1PlanSpecForProviderRuleCopyActionLifecycle>? Lifecycle { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanSpecForProviderRuleLifecycle
{
    /// <summary>Specifies the number of days after creation that a recovery point is moved to cold storage.</summary>
    [JsonPropertyName("coldStorageAfter")]
    public double? ColdStorageAfter { get; set; }

    /// <summary>Specifies the number of days after creation that a recovery point is deleted. Must be 90 days greater than cold_storage_after.</summary>
    [JsonPropertyName("deleteAfter")]
    public double? DeleteAfter { get; set; }

    /// <summary>This setting will instruct your backup plan to transition supported resources to archive (cold) storage tier in accordance with your lifecycle settings.</summary>
    [JsonPropertyName("optInToArchiveForSupportedResources")]
    public bool? OptInToArchiveForSupportedResources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PlanSpecForProviderRuleTargetVaultNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PlanSpecForProviderRuleTargetVaultNameRefPolicyResolveEnum
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
public partial class V1beta1PlanSpecForProviderRuleTargetVaultNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlanSpecForProviderRuleTargetVaultNameRefPolicyResolutionEnum>))]
    public V1beta1PlanSpecForProviderRuleTargetVaultNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlanSpecForProviderRuleTargetVaultNameRefPolicyResolveEnum>))]
    public V1beta1PlanSpecForProviderRuleTargetVaultNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Vault in backup to populate targetVaultName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanSpecForProviderRuleTargetVaultNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PlanSpecForProviderRuleTargetVaultNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PlanSpecForProviderRuleTargetVaultNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PlanSpecForProviderRuleTargetVaultNameSelectorPolicyResolveEnum
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
public partial class V1beta1PlanSpecForProviderRuleTargetVaultNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlanSpecForProviderRuleTargetVaultNameSelectorPolicyResolutionEnum>))]
    public V1beta1PlanSpecForProviderRuleTargetVaultNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlanSpecForProviderRuleTargetVaultNameSelectorPolicyResolveEnum>))]
    public V1beta1PlanSpecForProviderRuleTargetVaultNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Vault in backup to populate targetVaultName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanSpecForProviderRuleTargetVaultNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PlanSpecForProviderRuleTargetVaultNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanSpecForProviderRule
{
    /// <summary>The amount of time in minutes AWS Backup attempts a backup before canceling the job and returning an error.</summary>
    [JsonPropertyName("completionWindow")]
    public double? CompletionWindow { get; set; }

    /// <summary>Configuration block(s) with copy operation settings. Detailed below.</summary>
    [JsonPropertyName("copyAction")]
    public IList<V1beta1PlanSpecForProviderRuleCopyAction>? CopyAction { get; set; }

    /// <summary>Enable continuous backups for supported resources.</summary>
    [JsonPropertyName("enableContinuousBackup")]
    public bool? EnableContinuousBackup { get; set; }

    /// <summary>The lifecycle defines when a protected resource is transitioned to cold storage and when it expires.  Fields documented below.</summary>
    [JsonPropertyName("lifecycle")]
    public IList<V1beta1PlanSpecForProviderRuleLifecycle>? Lifecycle { get; set; }

    /// <summary>Metadata that you can assign to help organize the resources that you create.</summary>
    [JsonPropertyName("recoveryPointTags")]
    public IDictionary<string, string>? RecoveryPointTags { get; set; }

    /// <summary>An display name for a backup rule.</summary>
    [JsonPropertyName("ruleName")]
    public string? RuleName { get; set; }

    /// <summary>A CRON expression specifying when AWS Backup initiates a backup job.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>The amount of time in minutes before beginning a backup.</summary>
    [JsonPropertyName("startWindow")]
    public double? StartWindow { get; set; }

    /// <summary>The name of a logical container where backups are stored.</summary>
    [JsonPropertyName("targetVaultName")]
    public string? TargetVaultName { get; set; }

    /// <summary>Reference to a Vault in backup to populate targetVaultName.</summary>
    [JsonPropertyName("targetVaultNameRef")]
    public V1beta1PlanSpecForProviderRuleTargetVaultNameRef? TargetVaultNameRef { get; set; }

    /// <summary>Selector for a Vault in backup to populate targetVaultName.</summary>
    [JsonPropertyName("targetVaultNameSelector")]
    public V1beta1PlanSpecForProviderRuleTargetVaultNameSelector? TargetVaultNameSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanSpecForProvider
{
    /// <summary>An object that specifies backup options for each resource type.</summary>
    [JsonPropertyName("advancedBackupSetting")]
    public IList<V1beta1PlanSpecForProviderAdvancedBackupSetting>? AdvancedBackupSetting { get; set; }

    /// <summary>The display name of a backup plan.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>A rule object that specifies a scheduled task that is used to back up a selection of resources.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1PlanSpecForProviderRule>? Rule { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanSpecInitProviderAdvancedBackupSetting
{
    /// <summary>Specifies the backup option for a selected resource. This option is only available for Windows VSS backup jobs. Set to { WindowsVSS = "enabled" } to enable Windows VSS backup option and create a VSS Windows backup.</summary>
    [JsonPropertyName("backupOptions")]
    public IDictionary<string, string>? BackupOptions { get; set; }

    /// <summary>The type of AWS resource to be backed up. For VSS Windows backups, the only supported resource type is Amazon EC2. Valid values: EC2.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanSpecInitProviderRuleCopyActionLifecycle
{
    /// <summary>Specifies the number of days after creation that a recovery point is moved to cold storage.</summary>
    [JsonPropertyName("coldStorageAfter")]
    public double? ColdStorageAfter { get; set; }

    /// <summary>Specifies the number of days after creation that a recovery point is deleted. Must be 90 days greater than cold_storage_after.</summary>
    [JsonPropertyName("deleteAfter")]
    public double? DeleteAfter { get; set; }

    /// <summary>This setting will instruct your backup plan to transition supported resources to archive (cold) storage tier in accordance with your lifecycle settings.</summary>
    [JsonPropertyName("optInToArchiveForSupportedResources")]
    public bool? OptInToArchiveForSupportedResources { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanSpecInitProviderRuleCopyAction
{
    /// <summary>An Amazon Resource Name (ARN) that uniquely identifies the destination backup vault for the copied backup.</summary>
    [JsonPropertyName("destinationVaultArn")]
    public string? DestinationVaultArn { get; set; }

    /// <summary>The lifecycle defines when a protected resource is transitioned to cold storage and when it expires.  Fields documented below.</summary>
    [JsonPropertyName("lifecycle")]
    public IList<V1beta1PlanSpecInitProviderRuleCopyActionLifecycle>? Lifecycle { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanSpecInitProviderRuleLifecycle
{
    /// <summary>Specifies the number of days after creation that a recovery point is moved to cold storage.</summary>
    [JsonPropertyName("coldStorageAfter")]
    public double? ColdStorageAfter { get; set; }

    /// <summary>Specifies the number of days after creation that a recovery point is deleted. Must be 90 days greater than cold_storage_after.</summary>
    [JsonPropertyName("deleteAfter")]
    public double? DeleteAfter { get; set; }

    /// <summary>This setting will instruct your backup plan to transition supported resources to archive (cold) storage tier in accordance with your lifecycle settings.</summary>
    [JsonPropertyName("optInToArchiveForSupportedResources")]
    public bool? OptInToArchiveForSupportedResources { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PlanSpecInitProviderRuleTargetVaultNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PlanSpecInitProviderRuleTargetVaultNameRefPolicyResolveEnum
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
public partial class V1beta1PlanSpecInitProviderRuleTargetVaultNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlanSpecInitProviderRuleTargetVaultNameRefPolicyResolutionEnum>))]
    public V1beta1PlanSpecInitProviderRuleTargetVaultNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlanSpecInitProviderRuleTargetVaultNameRefPolicyResolveEnum>))]
    public V1beta1PlanSpecInitProviderRuleTargetVaultNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Vault in backup to populate targetVaultName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanSpecInitProviderRuleTargetVaultNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PlanSpecInitProviderRuleTargetVaultNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PlanSpecInitProviderRuleTargetVaultNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PlanSpecInitProviderRuleTargetVaultNameSelectorPolicyResolveEnum
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
public partial class V1beta1PlanSpecInitProviderRuleTargetVaultNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlanSpecInitProviderRuleTargetVaultNameSelectorPolicyResolutionEnum>))]
    public V1beta1PlanSpecInitProviderRuleTargetVaultNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlanSpecInitProviderRuleTargetVaultNameSelectorPolicyResolveEnum>))]
    public V1beta1PlanSpecInitProviderRuleTargetVaultNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Vault in backup to populate targetVaultName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanSpecInitProviderRuleTargetVaultNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PlanSpecInitProviderRuleTargetVaultNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanSpecInitProviderRule
{
    /// <summary>The amount of time in minutes AWS Backup attempts a backup before canceling the job and returning an error.</summary>
    [JsonPropertyName("completionWindow")]
    public double? CompletionWindow { get; set; }

    /// <summary>Configuration block(s) with copy operation settings. Detailed below.</summary>
    [JsonPropertyName("copyAction")]
    public IList<V1beta1PlanSpecInitProviderRuleCopyAction>? CopyAction { get; set; }

    /// <summary>Enable continuous backups for supported resources.</summary>
    [JsonPropertyName("enableContinuousBackup")]
    public bool? EnableContinuousBackup { get; set; }

    /// <summary>The lifecycle defines when a protected resource is transitioned to cold storage and when it expires.  Fields documented below.</summary>
    [JsonPropertyName("lifecycle")]
    public IList<V1beta1PlanSpecInitProviderRuleLifecycle>? Lifecycle { get; set; }

    /// <summary>Metadata that you can assign to help organize the resources that you create.</summary>
    [JsonPropertyName("recoveryPointTags")]
    public IDictionary<string, string>? RecoveryPointTags { get; set; }

    /// <summary>An display name for a backup rule.</summary>
    [JsonPropertyName("ruleName")]
    public string? RuleName { get; set; }

    /// <summary>A CRON expression specifying when AWS Backup initiates a backup job.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>The amount of time in minutes before beginning a backup.</summary>
    [JsonPropertyName("startWindow")]
    public double? StartWindow { get; set; }

    /// <summary>The name of a logical container where backups are stored.</summary>
    [JsonPropertyName("targetVaultName")]
    public string? TargetVaultName { get; set; }

    /// <summary>Reference to a Vault in backup to populate targetVaultName.</summary>
    [JsonPropertyName("targetVaultNameRef")]
    public V1beta1PlanSpecInitProviderRuleTargetVaultNameRef? TargetVaultNameRef { get; set; }

    /// <summary>Selector for a Vault in backup to populate targetVaultName.</summary>
    [JsonPropertyName("targetVaultNameSelector")]
    public V1beta1PlanSpecInitProviderRuleTargetVaultNameSelector? TargetVaultNameSelector { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanSpecInitProvider
{
    /// <summary>An object that specifies backup options for each resource type.</summary>
    [JsonPropertyName("advancedBackupSetting")]
    public IList<V1beta1PlanSpecInitProviderAdvancedBackupSetting>? AdvancedBackupSetting { get; set; }

    /// <summary>The display name of a backup plan.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A rule object that specifies a scheduled task that is used to back up a selection of resources.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1PlanSpecInitProviderRule>? Rule { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PlanSpecManagementPoliciesEnum
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
public enum V1beta1PlanSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PlanSpecProviderConfigRefPolicyResolveEnum
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
public partial class V1beta1PlanSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlanSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1PlanSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlanSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1PlanSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PlanSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PlanSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1PlanSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
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
public partial class V1beta1PlanSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlanSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1PlanSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlanSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1PlanSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PlanSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1PlanSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1PlanSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1PlanSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>PlanSpec defines the desired state of Plan</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PlanSpecDeletionPolicyEnum>))]
    public V1beta1PlanSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PlanSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PlanSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1PlanSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PlanSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1PlanSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PlanSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanStatusAtProviderAdvancedBackupSetting
{
    /// <summary>Specifies the backup option for a selected resource. This option is only available for Windows VSS backup jobs. Set to { WindowsVSS = "enabled" } to enable Windows VSS backup option and create a VSS Windows backup.</summary>
    [JsonPropertyName("backupOptions")]
    public IDictionary<string, string>? BackupOptions { get; set; }

    /// <summary>The type of AWS resource to be backed up. For VSS Windows backups, the only supported resource type is Amazon EC2. Valid values: EC2.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanStatusAtProviderRuleCopyActionLifecycle
{
    /// <summary>Specifies the number of days after creation that a recovery point is moved to cold storage.</summary>
    [JsonPropertyName("coldStorageAfter")]
    public double? ColdStorageAfter { get; set; }

    /// <summary>Specifies the number of days after creation that a recovery point is deleted. Must be 90 days greater than cold_storage_after.</summary>
    [JsonPropertyName("deleteAfter")]
    public double? DeleteAfter { get; set; }

    /// <summary>This setting will instruct your backup plan to transition supported resources to archive (cold) storage tier in accordance with your lifecycle settings.</summary>
    [JsonPropertyName("optInToArchiveForSupportedResources")]
    public bool? OptInToArchiveForSupportedResources { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanStatusAtProviderRuleCopyAction
{
    /// <summary>An Amazon Resource Name (ARN) that uniquely identifies the destination backup vault for the copied backup.</summary>
    [JsonPropertyName("destinationVaultArn")]
    public string? DestinationVaultArn { get; set; }

    /// <summary>The lifecycle defines when a protected resource is transitioned to cold storage and when it expires.  Fields documented below.</summary>
    [JsonPropertyName("lifecycle")]
    public IList<V1beta1PlanStatusAtProviderRuleCopyActionLifecycle>? Lifecycle { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanStatusAtProviderRuleLifecycle
{
    /// <summary>Specifies the number of days after creation that a recovery point is moved to cold storage.</summary>
    [JsonPropertyName("coldStorageAfter")]
    public double? ColdStorageAfter { get; set; }

    /// <summary>Specifies the number of days after creation that a recovery point is deleted. Must be 90 days greater than cold_storage_after.</summary>
    [JsonPropertyName("deleteAfter")]
    public double? DeleteAfter { get; set; }

    /// <summary>This setting will instruct your backup plan to transition supported resources to archive (cold) storage tier in accordance with your lifecycle settings.</summary>
    [JsonPropertyName("optInToArchiveForSupportedResources")]
    public bool? OptInToArchiveForSupportedResources { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanStatusAtProviderRule
{
    /// <summary>The amount of time in minutes AWS Backup attempts a backup before canceling the job and returning an error.</summary>
    [JsonPropertyName("completionWindow")]
    public double? CompletionWindow { get; set; }

    /// <summary>Configuration block(s) with copy operation settings. Detailed below.</summary>
    [JsonPropertyName("copyAction")]
    public IList<V1beta1PlanStatusAtProviderRuleCopyAction>? CopyAction { get; set; }

    /// <summary>Enable continuous backups for supported resources.</summary>
    [JsonPropertyName("enableContinuousBackup")]
    public bool? EnableContinuousBackup { get; set; }

    /// <summary>The lifecycle defines when a protected resource is transitioned to cold storage and when it expires.  Fields documented below.</summary>
    [JsonPropertyName("lifecycle")]
    public IList<V1beta1PlanStatusAtProviderRuleLifecycle>? Lifecycle { get; set; }

    /// <summary>Metadata that you can assign to help organize the resources that you create.</summary>
    [JsonPropertyName("recoveryPointTags")]
    public IDictionary<string, string>? RecoveryPointTags { get; set; }

    /// <summary>An display name for a backup rule.</summary>
    [JsonPropertyName("ruleName")]
    public string? RuleName { get; set; }

    /// <summary>A CRON expression specifying when AWS Backup initiates a backup job.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>The amount of time in minutes before beginning a backup.</summary>
    [JsonPropertyName("startWindow")]
    public double? StartWindow { get; set; }

    /// <summary>The name of a logical container where backups are stored.</summary>
    [JsonPropertyName("targetVaultName")]
    public string? TargetVaultName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanStatusAtProvider
{
    /// <summary>An object that specifies backup options for each resource type.</summary>
    [JsonPropertyName("advancedBackupSetting")]
    public IList<V1beta1PlanStatusAtProviderAdvancedBackupSetting>? AdvancedBackupSetting { get; set; }

    /// <summary>The ARN of the backup plan.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The id of the backup plan.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The display name of a backup plan.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A rule object that specifies a scheduled task that is used to back up a selection of resources.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1PlanStatusAtProviderRule>? Rule { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Unique, randomly generated, Unicode, UTF-8 encoded string that serves as the version ID of the backup plan.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanStatusConditions
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

/// <summary>PlanStatus defines the observed state of Plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1PlanStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PlanStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Plan is the Schema for the Plans API. Provides an AWS Backup plan resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Plan : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PlanSpec>, IStatus<V1beta1PlanStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Plan";
    public const string KubeGroup = "backup.aws.upbound.io";
    public const string KubePluralName = "plans";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PlanSpec defines the desired state of Plan</summary>
    [JsonPropertyName("spec")]
    public V1beta1PlanSpec Spec { get; set; }

    /// <summary>PlanStatus defines the observed state of Plan.</summary>
    [JsonPropertyName("status")]
    public V1beta1PlanStatus? Status { get; set; }
}