using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataprotection.azure.upbound.io;
/// <summary>A criteria block as defined below. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyBlobStorageSpecForProviderRetentionRuleCriteria
{
    /// <summary>Possible values are AllBackup, FirstOfDay, FirstOfWeek, FirstOfMonth and FirstOfYear. These values mean the first successful backup of the day/week/month/year. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("absoluteCriteria")]
    public string? AbsoluteCriteria { get; set; }

    /// <summary>Must be between 0 and 28. 0 for last day within the month. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("daysOfMonth")]
    public IList<double>? DaysOfMonth { get; set; }

    /// <summary>Possible values are Monday, Tuesday, Thursday, Friday, Saturday and Sunday. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    /// <summary>Possible values are January, February, March, April, May, June, July, August, September, October, November and December. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("monthsOfYear")]
    public IList<string>? MonthsOfYear { get; set; }

    /// <summary>Specifies a list of backup times for backup in the RFC3339 format. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("scheduledBackupTimes")]
    public IList<string>? ScheduledBackupTimes { get; set; }

    /// <summary>Possible values are First, Second, Third, Fourth and Last. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("weeksOfMonth")]
    public IList<string>? WeeksOfMonth { get; set; }
}

/// <summary>A life_cycle block as defined below. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyBlobStorageSpecForProviderRetentionRuleLifeCycle
{
    /// <summary>The type of data store. The only possible value is VaultStore. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    /// <summary>Duration after which the backup is deleted. It should follow ISO 8601 duration format. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyBlobStorageSpecForProviderRetentionRule
{
    /// <summary>A criteria block as defined below. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("criteria")]
    public V1beta1BackupPolicyBlobStorageSpecForProviderRetentionRuleCriteria? Criteria { get; set; }

    /// <summary>A life_cycle block as defined below. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("lifeCycle")]
    public V1beta1BackupPolicyBlobStorageSpecForProviderRetentionRuleLifeCycle? LifeCycle { get; set; }

    /// <summary>The name which should be used for this retention rule. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the priority of the rule. The priority number must be unique for each rule. The lower the priority number, the higher the priority of the rule. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyBlobStorageSpecForProviderVaultIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a BackupVault in dataprotection to populate vaultId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyBlobStorageSpecForProviderVaultIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupPolicyBlobStorageSpecForProviderVaultIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyBlobStorageSpecForProviderVaultIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a BackupVault in dataprotection to populate vaultId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyBlobStorageSpecForProviderVaultIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupPolicyBlobStorageSpecForProviderVaultIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyBlobStorageSpecForProvider
{
    /// <summary>Specifies a list of repeating time interval. It should follow ISO 8601 repeating time interval. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("backupRepeatingTimeIntervals")]
    public IList<string>? BackupRepeatingTimeIntervals { get; set; }

    /// <summary>The duration of operational default retention rule. It should follow ISO 8601 duration format. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("operationalDefaultRetentionDuration")]
    public string? OperationalDefaultRetentionDuration { get; set; }

    /// <summary>Duration of deletion after given timespan. It should follow ISO 8601 duration format. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("retentionDuration")]
    public string? RetentionDuration { get; set; }

    /// <summary>One or more retention_rule blocks as defined below. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("retentionRule")]
    public IList<V1beta1BackupPolicyBlobStorageSpecForProviderRetentionRule>? RetentionRule { get; set; }

    /// <summary>Specifies the Time Zone which should be used by the backup schedule. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>The duration of vault default retention rule. It should follow ISO 8601 duration format. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("vaultDefaultRetentionDuration")]
    public string? VaultDefaultRetentionDuration { get; set; }

    /// <summary>The ID of the Backup Vault within which the Backup Policy Blob Storage should exist. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("vaultId")]
    public string? VaultId { get; set; }

    /// <summary>Reference to a BackupVault in dataprotection to populate vaultId.</summary>
    [JsonPropertyName("vaultIdRef")]
    public V1beta1BackupPolicyBlobStorageSpecForProviderVaultIdRef? VaultIdRef { get; set; }

    /// <summary>Selector for a BackupVault in dataprotection to populate vaultId.</summary>
    [JsonPropertyName("vaultIdSelector")]
    public V1beta1BackupPolicyBlobStorageSpecForProviderVaultIdSelector? VaultIdSelector { get; set; }
}

/// <summary>A criteria block as defined below. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyBlobStorageSpecInitProviderRetentionRuleCriteria
{
    /// <summary>Possible values are AllBackup, FirstOfDay, FirstOfWeek, FirstOfMonth and FirstOfYear. These values mean the first successful backup of the day/week/month/year. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("absoluteCriteria")]
    public string? AbsoluteCriteria { get; set; }

    /// <summary>Must be between 0 and 28. 0 for last day within the month. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("daysOfMonth")]
    public IList<double>? DaysOfMonth { get; set; }

    /// <summary>Possible values are Monday, Tuesday, Thursday, Friday, Saturday and Sunday. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    /// <summary>Possible values are January, February, March, April, May, June, July, August, September, October, November and December. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("monthsOfYear")]
    public IList<string>? MonthsOfYear { get; set; }

    /// <summary>Specifies a list of backup times for backup in the RFC3339 format. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("scheduledBackupTimes")]
    public IList<string>? ScheduledBackupTimes { get; set; }

    /// <summary>Possible values are First, Second, Third, Fourth and Last. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("weeksOfMonth")]
    public IList<string>? WeeksOfMonth { get; set; }
}

/// <summary>A life_cycle block as defined below. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyBlobStorageSpecInitProviderRetentionRuleLifeCycle
{
    /// <summary>The type of data store. The only possible value is VaultStore. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    /// <summary>Duration after which the backup is deleted. It should follow ISO 8601 duration format. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyBlobStorageSpecInitProviderRetentionRule
{
    /// <summary>A criteria block as defined below. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("criteria")]
    public V1beta1BackupPolicyBlobStorageSpecInitProviderRetentionRuleCriteria? Criteria { get; set; }

    /// <summary>A life_cycle block as defined below. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("lifeCycle")]
    public V1beta1BackupPolicyBlobStorageSpecInitProviderRetentionRuleLifeCycle? LifeCycle { get; set; }

    /// <summary>The name which should be used for this retention rule. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the priority of the rule. The priority number must be unique for each rule. The lower the priority number, the higher the priority of the rule. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyBlobStorageSpecInitProvider
{
    /// <summary>Specifies a list of repeating time interval. It should follow ISO 8601 repeating time interval. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("backupRepeatingTimeIntervals")]
    public IList<string>? BackupRepeatingTimeIntervals { get; set; }

    /// <summary>The duration of operational default retention rule. It should follow ISO 8601 duration format. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("operationalDefaultRetentionDuration")]
    public string? OperationalDefaultRetentionDuration { get; set; }

    /// <summary>Duration of deletion after given timespan. It should follow ISO 8601 duration format. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("retentionDuration")]
    public string? RetentionDuration { get; set; }

    /// <summary>One or more retention_rule blocks as defined below. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("retentionRule")]
    public IList<V1beta1BackupPolicyBlobStorageSpecInitProviderRetentionRule>? RetentionRule { get; set; }

    /// <summary>Specifies the Time Zone which should be used by the backup schedule. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>The duration of vault default retention rule. It should follow ISO 8601 duration format. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("vaultDefaultRetentionDuration")]
    public string? VaultDefaultRetentionDuration { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyBlobStorageSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyBlobStorageSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupPolicyBlobStorageSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyBlobStorageSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyBlobStorageSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1BackupPolicyBlobStorageSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyBlobStorageSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1BackupPolicyBlobStorageSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1BackupPolicyBlobStorageSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1BackupPolicyBlobStorageSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyBlobStorageSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>BackupPolicyBlobStorageSpec defines the desired state of BackupPolicyBlobStorage</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyBlobStorageSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1BackupPolicyBlobStorageSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1BackupPolicyBlobStorageSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1BackupPolicyBlobStorageSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1BackupPolicyBlobStorageSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1BackupPolicyBlobStorageSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A criteria block as defined below. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyBlobStorageStatusAtProviderRetentionRuleCriteria
{
    /// <summary>Possible values are AllBackup, FirstOfDay, FirstOfWeek, FirstOfMonth and FirstOfYear. These values mean the first successful backup of the day/week/month/year. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("absoluteCriteria")]
    public string? AbsoluteCriteria { get; set; }

    /// <summary>Must be between 0 and 28. 0 for last day within the month. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("daysOfMonth")]
    public IList<double>? DaysOfMonth { get; set; }

    /// <summary>Possible values are Monday, Tuesday, Thursday, Friday, Saturday and Sunday. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    /// <summary>Possible values are January, February, March, April, May, June, July, August, September, October, November and December. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("monthsOfYear")]
    public IList<string>? MonthsOfYear { get; set; }

    /// <summary>Specifies a list of backup times for backup in the RFC3339 format. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("scheduledBackupTimes")]
    public IList<string>? ScheduledBackupTimes { get; set; }

    /// <summary>Possible values are First, Second, Third, Fourth and Last. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("weeksOfMonth")]
    public IList<string>? WeeksOfMonth { get; set; }
}

/// <summary>A life_cycle block as defined below. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyBlobStorageStatusAtProviderRetentionRuleLifeCycle
{
    /// <summary>The type of data store. The only possible value is VaultStore. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    /// <summary>Duration after which the backup is deleted. It should follow ISO 8601 duration format. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyBlobStorageStatusAtProviderRetentionRule
{
    /// <summary>A criteria block as defined below. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("criteria")]
    public V1beta1BackupPolicyBlobStorageStatusAtProviderRetentionRuleCriteria? Criteria { get; set; }

    /// <summary>A life_cycle block as defined below. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("lifeCycle")]
    public V1beta1BackupPolicyBlobStorageStatusAtProviderRetentionRuleLifeCycle? LifeCycle { get; set; }

    /// <summary>The name which should be used for this retention rule. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the priority of the rule. The priority number must be unique for each rule. The lower the priority number, the higher the priority of the rule. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyBlobStorageStatusAtProvider
{
    /// <summary>Specifies a list of repeating time interval. It should follow ISO 8601 repeating time interval. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("backupRepeatingTimeIntervals")]
    public IList<string>? BackupRepeatingTimeIntervals { get; set; }

    /// <summary>The ID of the Backup Policy Blob Storage.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The duration of operational default retention rule. It should follow ISO 8601 duration format. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("operationalDefaultRetentionDuration")]
    public string? OperationalDefaultRetentionDuration { get; set; }

    /// <summary>Duration of deletion after given timespan. It should follow ISO 8601 duration format. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("retentionDuration")]
    public string? RetentionDuration { get; set; }

    /// <summary>One or more retention_rule blocks as defined below. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("retentionRule")]
    public IList<V1beta1BackupPolicyBlobStorageStatusAtProviderRetentionRule>? RetentionRule { get; set; }

    /// <summary>Specifies the Time Zone which should be used by the backup schedule. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>The duration of vault default retention rule. It should follow ISO 8601 duration format. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("vaultDefaultRetentionDuration")]
    public string? VaultDefaultRetentionDuration { get; set; }

    /// <summary>The ID of the Backup Vault within which the Backup Policy Blob Storage should exist. Changing this forces a new Backup Policy Blob Storage to be created.</summary>
    [JsonPropertyName("vaultId")]
    public string? VaultId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyBlobStorageStatusConditions
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

/// <summary>BackupPolicyBlobStorageStatus defines the observed state of BackupPolicyBlobStorage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupPolicyBlobStorageStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1BackupPolicyBlobStorageStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BackupPolicyBlobStorageStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>BackupPolicyBlobStorage is the Schema for the BackupPolicyBlobStorages API. Manages a Backup Policy Blob Storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BackupPolicyBlobStorage : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BackupPolicyBlobStorageSpec>, IStatus<V1beta1BackupPolicyBlobStorageStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BackupPolicyBlobStorage";
    public const string KubeGroup = "dataprotection.azure.upbound.io";
    public const string KubePluralName = "backuppolicyblobstorages";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BackupPolicyBlobStorageSpec defines the desired state of BackupPolicyBlobStorage</summary>
    [JsonPropertyName("spec")]
    public V1beta1BackupPolicyBlobStorageSpec Spec { get; set; }

    /// <summary>BackupPolicyBlobStorageStatus defines the observed state of BackupPolicyBlobStorage.</summary>
    [JsonPropertyName("status")]
    public V1beta1BackupPolicyBlobStorageStatus? Status { get; set; }
}