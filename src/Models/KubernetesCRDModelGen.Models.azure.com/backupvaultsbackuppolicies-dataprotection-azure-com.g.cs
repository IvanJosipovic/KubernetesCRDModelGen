using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataprotection.azure.com;
/// <summary>Storage version of v1api20231101.BackupVaultsBackupPolicy Generator information: - Generated from: /dataprotection/resource-manager/Microsoft.DataProtection/stable/2023-11-01/dataprotection.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupPolicies/{backupPolicyName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20231101storageBackupVaultsBackupPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1api20231101storageBackupVaultsBackupPolicy>
{
    public const string KubeApiVersion = "v1api20231101storage";
    public const string KubeKind = "BackupVaultsBackupPolicyList";
    public const string KubeGroup = "dataprotection.azure.com";
    public const string KubePluralName = "backupvaultsbackuppolicies";
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
    public IList<V1api20231101storageBackupVaultsBackupPolicy> Items { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecOperatorSpecConfigMapExpressions
{
    /// <summary>Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting map[string]string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap or secret to write to. The configmap or secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecOperatorSpecSecretExpressions
{
    /// <summary>Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting map[string]string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap or secret to write to. The configmap or secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>Storage version of v1api20231101.BackupVaultsBackupPolicyOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20231101storageBackupVaultsBackupPolicySpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20231101storageBackupVaultsBackupPolicySpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a dataprotection.azure.com/BackupVault resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20231101.AzureBackupParams</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleBackupParametersAzureBackupParams
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backupType")]
    public string? BackupType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20231101.BackupParameters</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleBackupParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.AzureBackupParams</summary>
    [JsonPropertyName("azureBackupParams")]
    public V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleBackupParametersAzureBackupParams? AzureBackupParams { get; set; }
}

/// <summary>Storage version of v1api20231101.DataStoreInfoBase DataStoreInfo base</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleDataStore
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20231101.RetentionTag Retention tag</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContextTaggingCriteriaTagInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tagName")]
    public string? TagName { get; set; }
}

/// <summary>Storage version of v1api20231101.AdhocBasedTaggingCriteria Adhoc backup tagging criteria</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContextTaggingCriteria
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.RetentionTag Retention tag</summary>
    [JsonPropertyName("tagInfo")]
    public V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContextTaggingCriteriaTagInfo? TagInfo { get; set; }
}

/// <summary>Storage version of v1api20231101.AdhocBasedTriggerContext</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContext
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>Storage version of v1api20231101.AdhocBasedTaggingCriteria Adhoc backup tagging criteria</summary>
    [JsonPropertyName("taggingCriteria")]
    public V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContextTaggingCriteria? TaggingCriteria { get; set; }
}

/// <summary>Storage version of v1api20231101.BackupSchedule Schedule for backup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextSchedule
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repeatingTimeIntervals")]
    public IList<string>? RepeatingTimeIntervals { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>Storage version of v1api20231101.Day Day of the week</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteriaDaysOfMonth
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("date")]
    public int? Date { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isLast")]
    public bool? IsLast { get; set; }
}

/// <summary>Storage version of v1api20231101.ScheduleBasedBackupCriteria</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteria
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("absoluteCriteria")]
    public IList<string>? AbsoluteCriteria { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysOfMonth")]
    public IList<V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteriaDaysOfMonth>? DaysOfMonth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysOfTheWeek")]
    public IList<string>? DaysOfTheWeek { get; set; }

    /// <summary></summary>
    [JsonPropertyName("monthsOfYear")]
    public IList<string>? MonthsOfYear { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scheduleTimes")]
    public IList<string>? ScheduleTimes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weeksOfTheMonth")]
    public IList<string>? WeeksOfTheMonth { get; set; }
}

/// <summary>Storage version of v1api20231101.BackupCriteria</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteria
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.ScheduleBasedBackupCriteria</summary>
    [JsonPropertyName("scheduleBasedBackupCriteria")]
    public V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteria? ScheduleBasedBackupCriteria { get; set; }
}

/// <summary>Storage version of v1api20231101.RetentionTag Retention tag</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaTagInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tagName")]
    public string? TagName { get; set; }
}

/// <summary>Storage version of v1api20231101.TaggingCriteria Tagging criteria</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteria
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("criteria")]
    public IList<V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteria>? Criteria { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>Storage version of v1api20231101.RetentionTag Retention tag</summary>
    [JsonPropertyName("tagInfo")]
    public V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaTagInfo? TagInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("taggingPriority")]
    public int? TaggingPriority { get; set; }
}

/// <summary>Storage version of v1api20231101.ScheduleBasedTriggerContext</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContext
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>Storage version of v1api20231101.BackupSchedule Schedule for backup</summary>
    [JsonPropertyName("schedule")]
    public V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextSchedule? Schedule { get; set; }

    /// <summary></summary>
    [JsonPropertyName("taggingCriteria")]
    public IList<V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteria>? TaggingCriteria { get; set; }
}

/// <summary>Storage version of v1api20231101.TriggerContext</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTrigger
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.AdhocBasedTriggerContext</summary>
    [JsonPropertyName("adhocBasedTriggerContext")]
    public V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContext? AdhocBasedTriggerContext { get; set; }

    /// <summary>Storage version of v1api20231101.ScheduleBasedTriggerContext</summary>
    [JsonPropertyName("scheduleBasedTriggerContext")]
    public V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContext? ScheduleBasedTriggerContext { get; set; }
}

/// <summary>Storage version of v1api20231101.AzureBackupRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRule
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.BackupParameters</summary>
    [JsonPropertyName("backupParameters")]
    public V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleBackupParameters? BackupParameters { get; set; }

    /// <summary>Storage version of v1api20231101.DataStoreInfoBase DataStoreInfo base</summary>
    [JsonPropertyName("dataStore")]
    public V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleDataStore? DataStore { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>Storage version of v1api20231101.TriggerContext</summary>
    [JsonPropertyName("trigger")]
    public V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRuleTrigger? Trigger { get; set; }
}

/// <summary>Storage version of v1api20231101.AbsoluteDeleteOption</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesDeleteAfterAbsoluteDeleteOption
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20231101.DeleteOption</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesDeleteAfter
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.AbsoluteDeleteOption</summary>
    [JsonPropertyName("absoluteDeleteOption")]
    public V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesDeleteAfterAbsoluteDeleteOption? AbsoluteDeleteOption { get; set; }
}

/// <summary>Storage version of v1api20231101.DataStoreInfoBase DataStoreInfo base</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesSourceDataStore
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20231101.CopyOnExpiryOption</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterCopyOnExpiryOption
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20231101.CustomCopyOption</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterCustomCopyOption
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20231101.ImmediateCopyOption</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterImmediateCopyOption
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20231101.CopyOption</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfter
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.CopyOnExpiryOption</summary>
    [JsonPropertyName("copyOnExpiryOption")]
    public V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterCopyOnExpiryOption? CopyOnExpiryOption { get; set; }

    /// <summary>Storage version of v1api20231101.CustomCopyOption</summary>
    [JsonPropertyName("customCopyOption")]
    public V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterCustomCopyOption? CustomCopyOption { get; set; }

    /// <summary>Storage version of v1api20231101.ImmediateCopyOption</summary>
    [JsonPropertyName("immediateCopyOption")]
    public V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterImmediateCopyOption? ImmediateCopyOption { get; set; }
}

/// <summary>Storage version of v1api20231101.DataStoreInfoBase DataStoreInfo base</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsDataStore
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20231101.TargetCopySetting Target copy settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.CopyOption</summary>
    [JsonPropertyName("copyAfter")]
    public V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfter? CopyAfter { get; set; }

    /// <summary>Storage version of v1api20231101.DataStoreInfoBase DataStoreInfo base</summary>
    [JsonPropertyName("dataStore")]
    public V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsDataStore? DataStore { get; set; }
}

/// <summary>Storage version of v1api20231101.SourceLifeCycle Source LifeCycle</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecycles
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.DeleteOption</summary>
    [JsonPropertyName("deleteAfter")]
    public V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesDeleteAfter? DeleteAfter { get; set; }

    /// <summary>Storage version of v1api20231101.DataStoreInfoBase DataStoreInfo base</summary>
    [JsonPropertyName("sourceDataStore")]
    public V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesSourceDataStore? SourceDataStore { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetDataStoreCopySettings")]
    public IList<V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettings>? TargetDataStoreCopySettings { get; set; }
}

/// <summary>Storage version of v1api20231101.AzureRetentionRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRule
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lifecycles")]
    public IList<V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecycles>? Lifecycles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20231101.BasePolicyRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.AzureBackupRule</summary>
    [JsonPropertyName("azureBackupRule")]
    public V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureBackupRule? AzureBackupRule { get; set; }

    /// <summary>Storage version of v1api20231101.AzureRetentionRule</summary>
    [JsonPropertyName("azureRetentionRule")]
    public V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRulesAzureRetentionRule? AzureRetentionRule { get; set; }
}

/// <summary>Storage version of v1api20231101.BackupPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("datasourceTypes")]
    public IList<string>? DatasourceTypes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("policyRules")]
    public IList<V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicyPolicyRules>? PolicyRules { get; set; }
}

/// <summary>Storage version of v1api20231101.BaseBackupPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpecProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.BackupPolicy</summary>
    [JsonPropertyName("backupPolicy")]
    public V1api20231101storageBackupVaultsBackupPolicySpecPropertiesBackupPolicy? BackupPolicy { get; set; }
}

/// <summary>Storage version of v1api20231101.BackupVaultsBackupPolicy_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicySpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Storage version of v1api20231101.BackupVaultsBackupPolicyOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20231101storageBackupVaultsBackupPolicySpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a dataprotection.azure.com/BackupVault resource</summary>
    [JsonPropertyName("owner")]
    public V1api20231101storageBackupVaultsBackupPolicySpecOwner Owner { get; set; }

    /// <summary>Storage version of v1api20231101.BaseBackupPolicy</summary>
    [JsonPropertyName("properties")]
    public V1api20231101storageBackupVaultsBackupPolicySpecProperties? Properties { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatusConditions
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

/// <summary>Storage version of v1api20231101.AzureBackupParams_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleBackupParametersAzureBackupParams
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backupType")]
    public string? BackupType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20231101.BackupParameters_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleBackupParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.AzureBackupParams_STATUS</summary>
    [JsonPropertyName("azureBackupParams")]
    public V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleBackupParametersAzureBackupParams? AzureBackupParams { get; set; }
}

/// <summary>Storage version of v1api20231101.DataStoreInfoBase_STATUS DataStoreInfo base</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleDataStore
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20231101.RetentionTag_STATUS Retention tag</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContextTaggingCriteriaTagInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tagName")]
    public string? TagName { get; set; }
}

/// <summary>Storage version of v1api20231101.AdhocBasedTaggingCriteria_STATUS Adhoc backup tagging criteria</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContextTaggingCriteria
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.RetentionTag_STATUS Retention tag</summary>
    [JsonPropertyName("tagInfo")]
    public V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContextTaggingCriteriaTagInfo? TagInfo { get; set; }
}

/// <summary>Storage version of v1api20231101.AdhocBasedTriggerContext_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContext
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>Storage version of v1api20231101.AdhocBasedTaggingCriteria_STATUS Adhoc backup tagging criteria</summary>
    [JsonPropertyName("taggingCriteria")]
    public V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContextTaggingCriteria? TaggingCriteria { get; set; }
}

/// <summary>Storage version of v1api20231101.BackupSchedule_STATUS Schedule for backup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextSchedule
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repeatingTimeIntervals")]
    public IList<string>? RepeatingTimeIntervals { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>Storage version of v1api20231101.Day_STATUS Day of the week</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteriaDaysOfMonth
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("date")]
    public int? Date { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isLast")]
    public bool? IsLast { get; set; }
}

/// <summary>Storage version of v1api20231101.ScheduleBasedBackupCriteria_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteria
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("absoluteCriteria")]
    public IList<string>? AbsoluteCriteria { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysOfMonth")]
    public IList<V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteriaDaysOfMonth>? DaysOfMonth { get; set; }

    /// <summary></summary>
    [JsonPropertyName("daysOfTheWeek")]
    public IList<string>? DaysOfTheWeek { get; set; }

    /// <summary></summary>
    [JsonPropertyName("monthsOfYear")]
    public IList<string>? MonthsOfYear { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scheduleTimes")]
    public IList<string>? ScheduleTimes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("weeksOfTheMonth")]
    public IList<string>? WeeksOfTheMonth { get; set; }
}

/// <summary>Storage version of v1api20231101.BackupCriteria_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteria
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.ScheduleBasedBackupCriteria_STATUS</summary>
    [JsonPropertyName("scheduleBasedBackupCriteria")]
    public V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteriaScheduleBasedBackupCriteria? ScheduleBasedBackupCriteria { get; set; }
}

/// <summary>Storage version of v1api20231101.RetentionTag_STATUS Retention tag</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaTagInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tagName")]
    public string? TagName { get; set; }
}

/// <summary>Storage version of v1api20231101.TaggingCriteria_STATUS Tagging criteria</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteria
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("criteria")]
    public IList<V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaCriteria>? Criteria { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>Storage version of v1api20231101.RetentionTag_STATUS Retention tag</summary>
    [JsonPropertyName("tagInfo")]
    public V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteriaTagInfo? TagInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("taggingPriority")]
    public int? TaggingPriority { get; set; }
}

/// <summary>Storage version of v1api20231101.ScheduleBasedTriggerContext_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContext
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>Storage version of v1api20231101.BackupSchedule_STATUS Schedule for backup</summary>
    [JsonPropertyName("schedule")]
    public V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextSchedule? Schedule { get; set; }

    /// <summary></summary>
    [JsonPropertyName("taggingCriteria")]
    public IList<V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContextTaggingCriteria>? TaggingCriteria { get; set; }
}

/// <summary>Storage version of v1api20231101.TriggerContext_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTrigger
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.AdhocBasedTriggerContext_STATUS</summary>
    [JsonPropertyName("adhocBasedTriggerContext")]
    public V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerAdhocBasedTriggerContext? AdhocBasedTriggerContext { get; set; }

    /// <summary>Storage version of v1api20231101.ScheduleBasedTriggerContext_STATUS</summary>
    [JsonPropertyName("scheduleBasedTriggerContext")]
    public V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTriggerScheduleBasedTriggerContext? ScheduleBasedTriggerContext { get; set; }
}

/// <summary>Storage version of v1api20231101.AzureBackupRule_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRule
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.BackupParameters_STATUS</summary>
    [JsonPropertyName("backupParameters")]
    public V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleBackupParameters? BackupParameters { get; set; }

    /// <summary>Storage version of v1api20231101.DataStoreInfoBase_STATUS DataStoreInfo base</summary>
    [JsonPropertyName("dataStore")]
    public V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleDataStore? DataStore { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>Storage version of v1api20231101.TriggerContext_STATUS</summary>
    [JsonPropertyName("trigger")]
    public V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRuleTrigger? Trigger { get; set; }
}

/// <summary>Storage version of v1api20231101.AbsoluteDeleteOption_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesDeleteAfterAbsoluteDeleteOption
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20231101.DeleteOption_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesDeleteAfter
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.AbsoluteDeleteOption_STATUS</summary>
    [JsonPropertyName("absoluteDeleteOption")]
    public V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesDeleteAfterAbsoluteDeleteOption? AbsoluteDeleteOption { get; set; }
}

/// <summary>Storage version of v1api20231101.DataStoreInfoBase_STATUS DataStoreInfo base</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesSourceDataStore
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20231101.CopyOnExpiryOption_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterCopyOnExpiryOption
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20231101.CustomCopyOption_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterCustomCopyOption
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20231101.ImmediateCopyOption_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterImmediateCopyOption
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20231101.CopyOption_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfter
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.CopyOnExpiryOption_STATUS</summary>
    [JsonPropertyName("copyOnExpiryOption")]
    public V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterCopyOnExpiryOption? CopyOnExpiryOption { get; set; }

    /// <summary>Storage version of v1api20231101.CustomCopyOption_STATUS</summary>
    [JsonPropertyName("customCopyOption")]
    public V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterCustomCopyOption? CustomCopyOption { get; set; }

    /// <summary>Storage version of v1api20231101.ImmediateCopyOption_STATUS</summary>
    [JsonPropertyName("immediateCopyOption")]
    public V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfterImmediateCopyOption? ImmediateCopyOption { get; set; }
}

/// <summary>Storage version of v1api20231101.DataStoreInfoBase_STATUS DataStoreInfo base</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsDataStore
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20231101.TargetCopySetting_STATUS Target copy settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.CopyOption_STATUS</summary>
    [JsonPropertyName("copyAfter")]
    public V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsCopyAfter? CopyAfter { get; set; }

    /// <summary>Storage version of v1api20231101.DataStoreInfoBase_STATUS DataStoreInfo base</summary>
    [JsonPropertyName("dataStore")]
    public V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettingsDataStore? DataStore { get; set; }
}

/// <summary>Storage version of v1api20231101.SourceLifeCycle_STATUS Source LifeCycle</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecycles
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.DeleteOption_STATUS</summary>
    [JsonPropertyName("deleteAfter")]
    public V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesDeleteAfter? DeleteAfter { get; set; }

    /// <summary>Storage version of v1api20231101.DataStoreInfoBase_STATUS DataStoreInfo base</summary>
    [JsonPropertyName("sourceDataStore")]
    public V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesSourceDataStore? SourceDataStore { get; set; }

    /// <summary></summary>
    [JsonPropertyName("targetDataStoreCopySettings")]
    public IList<V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecyclesTargetDataStoreCopySettings>? TargetDataStoreCopySettings { get; set; }
}

/// <summary>Storage version of v1api20231101.AzureRetentionRule_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRule
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lifecycles")]
    public IList<V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRuleLifecycles>? Lifecycles { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20231101.BasePolicyRule_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.AzureBackupRule_STATUS</summary>
    [JsonPropertyName("azureBackupRule")]
    public V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureBackupRule? AzureBackupRule { get; set; }

    /// <summary>Storage version of v1api20231101.AzureRetentionRule_STATUS</summary>
    [JsonPropertyName("azureRetentionRule")]
    public V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRulesAzureRetentionRule? AzureRetentionRule { get; set; }
}

/// <summary>Storage version of v1api20231101.BackupPolicy_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("datasourceTypes")]
    public IList<string>? DatasourceTypes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("policyRules")]
    public IList<V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicyPolicyRules>? PolicyRules { get; set; }
}

/// <summary>Storage version of v1api20231101.BaseBackupPolicy_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatusProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.BackupPolicy_STATUS</summary>
    [JsonPropertyName("backupPolicy")]
    public V1api20231101storageBackupVaultsBackupPolicyStatusPropertiesBackupPolicy? BackupPolicy { get; set; }
}

/// <summary>Storage version of v1api20231101.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatusSystemData
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

/// <summary>Storage version of v1api20231101.BackupVaultsBackupPolicy_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20231101storageBackupVaultsBackupPolicyStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20231101storageBackupVaultsBackupPolicyStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20231101.BaseBackupPolicy_STATUS</summary>
    [JsonPropertyName("properties")]
    public V1api20231101storageBackupVaultsBackupPolicyStatusProperties? Properties { get; set; }

    /// <summary>Storage version of v1api20231101.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20231101storageBackupVaultsBackupPolicyStatusSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20231101.BackupVaultsBackupPolicy Generator information: - Generated from: /dataprotection/resource-manager/Microsoft.DataProtection/stable/2023-11-01/dataprotection.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupPolicies/{backupPolicyName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20231101storageBackupVaultsBackupPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20231101storageBackupVaultsBackupPolicySpec>, IStatus<V1api20231101storageBackupVaultsBackupPolicyStatus>
{
    public const string KubeApiVersion = "v1api20231101storage";
    public const string KubeKind = "BackupVaultsBackupPolicy";
    public const string KubeGroup = "dataprotection.azure.com";
    public const string KubePluralName = "backupvaultsbackuppolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20231101.BackupVaultsBackupPolicy_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20231101storageBackupVaultsBackupPolicySpec? Spec { get; set; }

    /// <summary>Storage version of v1api20231101.BackupVaultsBackupPolicy_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20231101storageBackupVaultsBackupPolicyStatus? Status { get; set; }
}