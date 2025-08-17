using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.backup.aws.m.upbound.io;
#nullable enable
/// <summary>Plan is the Schema for the Plans API. Provides an AWS Backup plan resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PlanList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Plan>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PlanList";
    public const string KubeGroup = "backup.aws.m.upbound.io";
    public const string KubePluralName = "plans";
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
    public IList<V1beta1Plan> Items { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>The lifecycle defines when a protected resource is transitioned to cold storage and when it expires.  Fields documented below.</summary>
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanSpecForProviderRuleCopyAction
{
    /// <summary>An Amazon Resource Name (ARN) that uniquely identifies the destination backup vault for the copied backup.</summary>
    [JsonPropertyName("destinationVaultArn")]
    public string? DestinationVaultArn { get; set; }

    /// <summary>The lifecycle defines when a protected resource is transitioned to cold storage and when it expires.  Fields documented below.</summary>
    [JsonPropertyName("lifecycle")]
    public V1beta1PlanSpecForProviderRuleCopyActionLifecycle? Lifecycle { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The lifecycle defines when a protected resource is transitioned to cold storage and when it expires.  Fields documented below.</summary>
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
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanSpecForProviderRuleTargetVaultNameRefPolicy
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
/// <summary>Reference to a Vault in backup to populate targetVaultName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanSpecForProviderRuleTargetVaultNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PlanSpecForProviderRuleTargetVaultNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanSpecForProviderRuleTargetVaultNameSelectorPolicy
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PlanSpecForProviderRuleTargetVaultNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
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
    public V1beta1PlanSpecForProviderRuleLifecycle? Lifecycle { get; set; }

    /// <summary>Metadata that you can assign to help organize the resources that you create.</summary>
    [JsonPropertyName("recoveryPointTags")]
    public IDictionary<string, string>? RecoveryPointTags { get; set; }

    /// <summary>An display name for a backup rule.</summary>
    [JsonPropertyName("ruleName")]
    public string? RuleName { get; set; }

    /// <summary>A CRON expression specifying when AWS Backup initiates a backup job.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>The timezone in which the schedule expression is set. Default value: "Etc/UTC".</summary>
    [JsonPropertyName("scheduleExpressionTimezone")]
    public string? ScheduleExpressionTimezone { get; set; }

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
#nullable disable

#nullable enable
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

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>A rule object that specifies a scheduled task that is used to back up a selection of resources.</summary>
    [JsonPropertyName("rule")]
    public IList<V1beta1PlanSpecForProviderRule>? Rule { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>The lifecycle defines when a protected resource is transitioned to cold storage and when it expires.  Fields documented below.</summary>
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanSpecInitProviderRuleCopyAction
{
    /// <summary>An Amazon Resource Name (ARN) that uniquely identifies the destination backup vault for the copied backup.</summary>
    [JsonPropertyName("destinationVaultArn")]
    public string? DestinationVaultArn { get; set; }

    /// <summary>The lifecycle defines when a protected resource is transitioned to cold storage and when it expires.  Fields documented below.</summary>
    [JsonPropertyName("lifecycle")]
    public V1beta1PlanSpecInitProviderRuleCopyActionLifecycle? Lifecycle { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The lifecycle defines when a protected resource is transitioned to cold storage and when it expires.  Fields documented below.</summary>
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
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanSpecInitProviderRuleTargetVaultNameRefPolicy
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
/// <summary>Reference to a Vault in backup to populate targetVaultName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanSpecInitProviderRuleTargetVaultNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PlanSpecInitProviderRuleTargetVaultNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanSpecInitProviderRuleTargetVaultNameSelectorPolicy
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PlanSpecInitProviderRuleTargetVaultNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
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
    public V1beta1PlanSpecInitProviderRuleLifecycle? Lifecycle { get; set; }

    /// <summary>Metadata that you can assign to help organize the resources that you create.</summary>
    [JsonPropertyName("recoveryPointTags")]
    public IDictionary<string, string>? RecoveryPointTags { get; set; }

    /// <summary>An display name for a backup rule.</summary>
    [JsonPropertyName("ruleName")]
    public string? RuleName { get; set; }

    /// <summary>A CRON expression specifying when AWS Backup initiates a backup job.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>The timezone in which the schedule expression is set. Default value: "Etc/UTC".</summary>
    [JsonPropertyName("scheduleExpressionTimezone")]
    public string? ScheduleExpressionTimezone { get; set; }

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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanSpecProviderConfigRef
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
public partial class V1beta1PlanSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>PlanSpec defines the desired state of Plan</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PlanSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PlanSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PlanSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PlanSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>The lifecycle defines when a protected resource is transitioned to cold storage and when it expires.  Fields documented below.</summary>
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PlanStatusAtProviderRuleCopyAction
{
    /// <summary>An Amazon Resource Name (ARN) that uniquely identifies the destination backup vault for the copied backup.</summary>
    [JsonPropertyName("destinationVaultArn")]
    public string? DestinationVaultArn { get; set; }

    /// <summary>The lifecycle defines when a protected resource is transitioned to cold storage and when it expires.  Fields documented below.</summary>
    [JsonPropertyName("lifecycle")]
    public V1beta1PlanStatusAtProviderRuleCopyActionLifecycle? Lifecycle { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The lifecycle defines when a protected resource is transitioned to cold storage and when it expires.  Fields documented below.</summary>
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
#nullable disable

#nullable enable
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
    public V1beta1PlanStatusAtProviderRuleLifecycle? Lifecycle { get; set; }

    /// <summary>Metadata that you can assign to help organize the resources that you create.</summary>
    [JsonPropertyName("recoveryPointTags")]
    public IDictionary<string, string>? RecoveryPointTags { get; set; }

    /// <summary>An display name for a backup rule.</summary>
    [JsonPropertyName("ruleName")]
    public string? RuleName { get; set; }

    /// <summary>A CRON expression specifying when AWS Backup initiates a backup job.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>The timezone in which the schedule expression is set. Default value: "Etc/UTC".</summary>
    [JsonPropertyName("scheduleExpressionTimezone")]
    public string? ScheduleExpressionTimezone { get; set; }

    /// <summary>The amount of time in minutes before beginning a backup.</summary>
    [JsonPropertyName("startWindow")]
    public double? StartWindow { get; set; }

    /// <summary>The name of a logical container where backups are stored.</summary>
    [JsonPropertyName("targetVaultName")]
    public string? TargetVaultName { get; set; }
}
#nullable disable

#nullable enable
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

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>Plan is the Schema for the Plans API. Provides an AWS Backup plan resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Plan : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PlanSpec>, IStatus<V1beta1PlanStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Plan";
    public const string KubeGroup = "backup.aws.m.upbound.io";
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
#nullable disable
