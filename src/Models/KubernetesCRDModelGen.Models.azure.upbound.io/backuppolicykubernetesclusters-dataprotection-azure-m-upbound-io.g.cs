using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataprotection.azure.m.upbound.io;
#nullable enable
/// <summary>BackupPolicyKubernetesCluster is the Schema for the BackupPolicyKubernetesClusters API. Manages a Backup Policy to back up Kubernetes Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BackupPolicyKubernetesClusterList : IKubernetesObject<V1ListMeta>, IItems<V1beta1BackupPolicyKubernetesCluster>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BackupPolicyKubernetesClusterList";
    public const string KubeGroup = "dataprotection.azure.m.upbound.io";
    public const string KubePluralName = "backuppolicykubernetesclusters";
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
    public IList<V1beta1BackupPolicyKubernetesCluster> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyKubernetesClusterSpecForProviderDefaultRetentionRuleLifeCycle
{
    /// <summary>The type of data store. The only possible value is OperationalStore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    /// <summary>The retention duration up to which the backups are to be retained in the data stores. It should follow ISO 8601 duration format. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A default_retention_rule block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyKubernetesClusterSpecForProviderDefaultRetentionRule
{
    /// <summary>A life_cycle block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("lifeCycle")]
    public IList<V1beta1BackupPolicyKubernetesClusterSpecForProviderDefaultRetentionRuleLifeCycle>? LifeCycle { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyKubernetesClusterSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1BackupPolicyKubernetesClusterSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupPolicyKubernetesClusterSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyKubernetesClusterSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1BackupPolicyKubernetesClusterSpecForProviderResourceGroupNameSelector
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
    public V1beta1BackupPolicyKubernetesClusterSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A criteria block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyKubernetesClusterSpecForProviderRetentionRuleCriteria
{
    /// <summary>Possible values are AllBackup, FirstOfDay, FirstOfWeek, FirstOfMonth and FirstOfYear. These values mean the first successful backup of the day/week/month/year. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("absoluteCriteria")]
    public string? AbsoluteCriteria { get; set; }

    /// <summary>Possible values are Monday, Tuesday, Thursday, Friday, Saturday and Sunday. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    /// <summary>Possible values are January, February, March, April, May, June, July, August, September, October, November and December. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("monthsOfYear")]
    public IList<string>? MonthsOfYear { get; set; }

    /// <summary>Specifies a list of backup times for backup in the RFC3339 format. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scheduledBackupTimes")]
    public IList<string>? ScheduledBackupTimes { get; set; }

    /// <summary>Possible values are First, Second, Third, Fourth and Last. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("weeksOfMonth")]
    public IList<string>? WeeksOfMonth { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyKubernetesClusterSpecForProviderRetentionRuleLifeCycle
{
    /// <summary>The type of data store. The only possible value is OperationalStore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    /// <summary>The retention duration up to which the backups are to be retained in the data stores. It should follow ISO 8601 duration format. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyKubernetesClusterSpecForProviderRetentionRule
{
    /// <summary>A criteria block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("criteria")]
    public V1beta1BackupPolicyKubernetesClusterSpecForProviderRetentionRuleCriteria? Criteria { get; set; }

    /// <summary>A life_cycle block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("lifeCycle")]
    public IList<V1beta1BackupPolicyKubernetesClusterSpecForProviderRetentionRuleLifeCycle>? LifeCycle { get; set; }

    /// <summary>The name which should be used for this retention rule. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the priority of the rule. The priority number must be unique for each rule. The lower the priority number, the higher the priority of the rule. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyKubernetesClusterSpecForProviderVaultNameRefPolicy
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
/// <summary>Reference to a BackupVault in dataprotection to populate vaultName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyKubernetesClusterSpecForProviderVaultNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupPolicyKubernetesClusterSpecForProviderVaultNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyKubernetesClusterSpecForProviderVaultNameSelectorPolicy
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
/// <summary>Selector for a BackupVault in dataprotection to populate vaultName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyKubernetesClusterSpecForProviderVaultNameSelector
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
    public V1beta1BackupPolicyKubernetesClusterSpecForProviderVaultNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyKubernetesClusterSpecForProvider
{
    /// <summary>Specifies a list of repeating time interval. It supports weekly back. It should follow ISO 8601 repeating time interval. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("backupRepeatingTimeIntervals")]
    public IList<string>? BackupRepeatingTimeIntervals { get; set; }

    /// <summary>A default_retention_rule block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("defaultRetentionRule")]
    public V1beta1BackupPolicyKubernetesClusterSpecForProviderDefaultRetentionRule? DefaultRetentionRule { get; set; }

    /// <summary>The name of the Resource Group where the Backup Policy Kubernetes Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1BackupPolicyKubernetesClusterSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1BackupPolicyKubernetesClusterSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>One or more retention_rule blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("retentionRule")]
    public IList<V1beta1BackupPolicyKubernetesClusterSpecForProviderRetentionRule>? RetentionRule { get; set; }

    /// <summary>Specifies the Time Zone which should be used by the backup schedule. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>The name of the Backup Vault where the Backup Policy Kubernetes Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vaultName")]
    public string? VaultName { get; set; }

    /// <summary>Reference to a BackupVault in dataprotection to populate vaultName.</summary>
    [JsonPropertyName("vaultNameRef")]
    public V1beta1BackupPolicyKubernetesClusterSpecForProviderVaultNameRef? VaultNameRef { get; set; }

    /// <summary>Selector for a BackupVault in dataprotection to populate vaultName.</summary>
    [JsonPropertyName("vaultNameSelector")]
    public V1beta1BackupPolicyKubernetesClusterSpecForProviderVaultNameSelector? VaultNameSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyKubernetesClusterSpecInitProviderDefaultRetentionRuleLifeCycle
{
    /// <summary>The type of data store. The only possible value is OperationalStore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    /// <summary>The retention duration up to which the backups are to be retained in the data stores. It should follow ISO 8601 duration format. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A default_retention_rule block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyKubernetesClusterSpecInitProviderDefaultRetentionRule
{
    /// <summary>A life_cycle block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("lifeCycle")]
    public IList<V1beta1BackupPolicyKubernetesClusterSpecInitProviderDefaultRetentionRuleLifeCycle>? LifeCycle { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A criteria block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyKubernetesClusterSpecInitProviderRetentionRuleCriteria
{
    /// <summary>Possible values are AllBackup, FirstOfDay, FirstOfWeek, FirstOfMonth and FirstOfYear. These values mean the first successful backup of the day/week/month/year. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("absoluteCriteria")]
    public string? AbsoluteCriteria { get; set; }

    /// <summary>Possible values are Monday, Tuesday, Thursday, Friday, Saturday and Sunday. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    /// <summary>Possible values are January, February, March, April, May, June, July, August, September, October, November and December. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("monthsOfYear")]
    public IList<string>? MonthsOfYear { get; set; }

    /// <summary>Specifies a list of backup times for backup in the RFC3339 format. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scheduledBackupTimes")]
    public IList<string>? ScheduledBackupTimes { get; set; }

    /// <summary>Possible values are First, Second, Third, Fourth and Last. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("weeksOfMonth")]
    public IList<string>? WeeksOfMonth { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyKubernetesClusterSpecInitProviderRetentionRuleLifeCycle
{
    /// <summary>The type of data store. The only possible value is OperationalStore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    /// <summary>The retention duration up to which the backups are to be retained in the data stores. It should follow ISO 8601 duration format. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyKubernetesClusterSpecInitProviderRetentionRule
{
    /// <summary>A criteria block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("criteria")]
    public V1beta1BackupPolicyKubernetesClusterSpecInitProviderRetentionRuleCriteria? Criteria { get; set; }

    /// <summary>A life_cycle block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("lifeCycle")]
    public IList<V1beta1BackupPolicyKubernetesClusterSpecInitProviderRetentionRuleLifeCycle>? LifeCycle { get; set; }

    /// <summary>The name which should be used for this retention rule. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the priority of the rule. The priority number must be unique for each rule. The lower the priority number, the higher the priority of the rule. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyKubernetesClusterSpecInitProvider
{
    /// <summary>Specifies a list of repeating time interval. It supports weekly back. It should follow ISO 8601 repeating time interval. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("backupRepeatingTimeIntervals")]
    public IList<string>? BackupRepeatingTimeIntervals { get; set; }

    /// <summary>A default_retention_rule block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("defaultRetentionRule")]
    public V1beta1BackupPolicyKubernetesClusterSpecInitProviderDefaultRetentionRule? DefaultRetentionRule { get; set; }

    /// <summary>One or more retention_rule blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("retentionRule")]
    public IList<V1beta1BackupPolicyKubernetesClusterSpecInitProviderRetentionRule>? RetentionRule { get; set; }

    /// <summary>Specifies the Time Zone which should be used by the backup schedule. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyKubernetesClusterSpecProviderConfigRef
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
public partial class V1beta1BackupPolicyKubernetesClusterSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>BackupPolicyKubernetesClusterSpec defines the desired state of BackupPolicyKubernetesCluster</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyKubernetesClusterSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1BackupPolicyKubernetesClusterSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1BackupPolicyKubernetesClusterSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BackupPolicyKubernetesClusterSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BackupPolicyKubernetesClusterSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyKubernetesClusterStatusAtProviderDefaultRetentionRuleLifeCycle
{
    /// <summary>The type of data store. The only possible value is OperationalStore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    /// <summary>The retention duration up to which the backups are to be retained in the data stores. It should follow ISO 8601 duration format. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A default_retention_rule block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyKubernetesClusterStatusAtProviderDefaultRetentionRule
{
    /// <summary>A life_cycle block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("lifeCycle")]
    public IList<V1beta1BackupPolicyKubernetesClusterStatusAtProviderDefaultRetentionRuleLifeCycle>? LifeCycle { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A criteria block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyKubernetesClusterStatusAtProviderRetentionRuleCriteria
{
    /// <summary>Possible values are AllBackup, FirstOfDay, FirstOfWeek, FirstOfMonth and FirstOfYear. These values mean the first successful backup of the day/week/month/year. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("absoluteCriteria")]
    public string? AbsoluteCriteria { get; set; }

    /// <summary>Possible values are Monday, Tuesday, Thursday, Friday, Saturday and Sunday. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    /// <summary>Possible values are January, February, March, April, May, June, July, August, September, October, November and December. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("monthsOfYear")]
    public IList<string>? MonthsOfYear { get; set; }

    /// <summary>Specifies a list of backup times for backup in the RFC3339 format. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scheduledBackupTimes")]
    public IList<string>? ScheduledBackupTimes { get; set; }

    /// <summary>Possible values are First, Second, Third, Fourth and Last. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("weeksOfMonth")]
    public IList<string>? WeeksOfMonth { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyKubernetesClusterStatusAtProviderRetentionRuleLifeCycle
{
    /// <summary>The type of data store. The only possible value is OperationalStore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    /// <summary>The retention duration up to which the backups are to be retained in the data stores. It should follow ISO 8601 duration format. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyKubernetesClusterStatusAtProviderRetentionRule
{
    /// <summary>A criteria block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("criteria")]
    public V1beta1BackupPolicyKubernetesClusterStatusAtProviderRetentionRuleCriteria? Criteria { get; set; }

    /// <summary>A life_cycle block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("lifeCycle")]
    public IList<V1beta1BackupPolicyKubernetesClusterStatusAtProviderRetentionRuleLifeCycle>? LifeCycle { get; set; }

    /// <summary>The name which should be used for this retention rule. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the priority of the rule. The priority number must be unique for each rule. The lower the priority number, the higher the priority of the rule. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyKubernetesClusterStatusAtProvider
{
    /// <summary>Specifies a list of repeating time interval. It supports weekly back. It should follow ISO 8601 repeating time interval. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("backupRepeatingTimeIntervals")]
    public IList<string>? BackupRepeatingTimeIntervals { get; set; }

    /// <summary>A default_retention_rule block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("defaultRetentionRule")]
    public V1beta1BackupPolicyKubernetesClusterStatusAtProviderDefaultRetentionRule? DefaultRetentionRule { get; set; }

    /// <summary>The ID of the Backup Policy Kubernetes Cluster.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the Resource Group where the Backup Policy Kubernetes Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>One or more retention_rule blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("retentionRule")]
    public IList<V1beta1BackupPolicyKubernetesClusterStatusAtProviderRetentionRule>? RetentionRule { get; set; }

    /// <summary>Specifies the Time Zone which should be used by the backup schedule. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>The name of the Backup Vault where the Backup Policy Kubernetes Cluster should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vaultName")]
    public string? VaultName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyKubernetesClusterStatusConditions
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
/// <summary>BackupPolicyKubernetesClusterStatus defines the observed state of BackupPolicyKubernetesCluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyKubernetesClusterStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1BackupPolicyKubernetesClusterStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BackupPolicyKubernetesClusterStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>BackupPolicyKubernetesCluster is the Schema for the BackupPolicyKubernetesClusters API. Manages a Backup Policy to back up Kubernetes Cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BackupPolicyKubernetesCluster : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BackupPolicyKubernetesClusterSpec>, IStatus<V1beta1BackupPolicyKubernetesClusterStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BackupPolicyKubernetesCluster";
    public const string KubeGroup = "dataprotection.azure.m.upbound.io";
    public const string KubePluralName = "backuppolicykubernetesclusters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BackupPolicyKubernetesClusterSpec defines the desired state of BackupPolicyKubernetesCluster</summary>
    [JsonPropertyName("spec")]
    public V1beta1BackupPolicyKubernetesClusterSpec Spec { get; set; }

    /// <summary>BackupPolicyKubernetesClusterStatus defines the observed state of BackupPolicyKubernetesCluster.</summary>
    [JsonPropertyName("status")]
    public V1beta1BackupPolicyKubernetesClusterStatus? Status { get; set; }
}
#nullable disable
