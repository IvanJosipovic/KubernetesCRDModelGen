using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sql.azure.upbound.io;
/// <summary>MSSQLManagedDatabase is the Schema for the MSSQLManagedDatabases API. Manages an Azure SQL Azure Managed Database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MSSQLManagedDatabaseList : IKubernetesObject<V1ListMeta>, IItems<V1beta1MSSQLManagedDatabase>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MSSQLManagedDatabaseList";
    public const string KubeGroup = "sql.azure.upbound.io";
    public const string KubePluralName = "mssqlmanageddatabases";
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
    public IList<V1beta1MSSQLManagedDatabase> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedDatabaseSpecForProviderLongTermRetentionPolicy
{
    /// <summary></summary>
    [JsonPropertyName("immutableBackupsEnabled")]
    public bool? ImmutableBackupsEnabled { get; set; }

    /// <summary>The monthly retention policy for an LTR backup in an ISO 8601 format. Valid value is between 1 to 120 months. e.g. P1Y, P1M, P4W or P30D. Defaults to PT0S.</summary>
    [JsonPropertyName("monthlyRetention")]
    public string? MonthlyRetention { get; set; }

    /// <summary>The week of year to take the yearly backup. Value has to be between 1 and 52.</summary>
    [JsonPropertyName("weekOfYear")]
    public double? WeekOfYear { get; set; }

    /// <summary>The weekly retention policy for an LTR backup in an ISO 8601 format. Valid value is between 1 to 520 weeks. e.g. P1Y, P1M, P1W or P7D. Defaults to PT0S.</summary>
    [JsonPropertyName("weeklyRetention")]
    public string? WeeklyRetention { get; set; }

    /// <summary>The yearly retention policy for an LTR backup in an ISO 8601 format. Valid value is between 1 to 10 years. e.g. P1Y, P12M, P52W or P365D. Defaults to PT0S.</summary>
    [JsonPropertyName("yearlyRetention")]
    public string? YearlyRetention { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedDatabaseSpecForProviderManagedInstanceIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a MSSQLManagedInstance in sql to populate managedInstanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedDatabaseSpecForProviderManagedInstanceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLManagedDatabaseSpecForProviderManagedInstanceIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedDatabaseSpecForProviderManagedInstanceIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a MSSQLManagedInstance in sql to populate managedInstanceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedDatabaseSpecForProviderManagedInstanceIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLManagedDatabaseSpecForProviderManagedInstanceIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedDatabaseSpecForProviderPointInTimeRestore
{
    /// <summary>The point in time for the restore from source_database_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("restorePointInTime")]
    public string? RestorePointInTime { get; set; }

    /// <summary>The source database id that will be used to restore from. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sourceDatabaseId")]
    public string? SourceDatabaseId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedDatabaseSpecForProvider
{
    /// <summary>A long_term_retention_policy block as defined below.</summary>
    [JsonPropertyName("longTermRetentionPolicy")]
    public IList<V1beta1MSSQLManagedDatabaseSpecForProviderLongTermRetentionPolicy>? LongTermRetentionPolicy { get; set; }

    /// <summary>The ID of the Azure SQL Managed Instance on which to create this Managed Database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedInstanceId")]
    public string? ManagedInstanceId { get; set; }

    /// <summary>Reference to a MSSQLManagedInstance in sql to populate managedInstanceId.</summary>
    [JsonPropertyName("managedInstanceIdRef")]
    public V1beta1MSSQLManagedDatabaseSpecForProviderManagedInstanceIdRef? ManagedInstanceIdRef { get; set; }

    /// <summary>Selector for a MSSQLManagedInstance in sql to populate managedInstanceId.</summary>
    [JsonPropertyName("managedInstanceIdSelector")]
    public V1beta1MSSQLManagedDatabaseSpecForProviderManagedInstanceIdSelector? ManagedInstanceIdSelector { get; set; }

    /// <summary>A point_in_time_restore block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("pointInTimeRestore")]
    public IList<V1beta1MSSQLManagedDatabaseSpecForProviderPointInTimeRestore>? PointInTimeRestore { get; set; }

    /// <summary>The backup retention period in days. This is how many days Point-in-Time Restore will be supported.</summary>
    [JsonPropertyName("shortTermRetentionDays")]
    public double? ShortTermRetentionDays { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedDatabaseSpecInitProviderLongTermRetentionPolicy
{
    /// <summary></summary>
    [JsonPropertyName("immutableBackupsEnabled")]
    public bool? ImmutableBackupsEnabled { get; set; }

    /// <summary>The monthly retention policy for an LTR backup in an ISO 8601 format. Valid value is between 1 to 120 months. e.g. P1Y, P1M, P4W or P30D. Defaults to PT0S.</summary>
    [JsonPropertyName("monthlyRetention")]
    public string? MonthlyRetention { get; set; }

    /// <summary>The week of year to take the yearly backup. Value has to be between 1 and 52.</summary>
    [JsonPropertyName("weekOfYear")]
    public double? WeekOfYear { get; set; }

    /// <summary>The weekly retention policy for an LTR backup in an ISO 8601 format. Valid value is between 1 to 520 weeks. e.g. P1Y, P1M, P1W or P7D. Defaults to PT0S.</summary>
    [JsonPropertyName("weeklyRetention")]
    public string? WeeklyRetention { get; set; }

    /// <summary>The yearly retention policy for an LTR backup in an ISO 8601 format. Valid value is between 1 to 10 years. e.g. P1Y, P12M, P52W or P365D. Defaults to PT0S.</summary>
    [JsonPropertyName("yearlyRetention")]
    public string? YearlyRetention { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedDatabaseSpecInitProviderPointInTimeRestore
{
    /// <summary>The point in time for the restore from source_database_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("restorePointInTime")]
    public string? RestorePointInTime { get; set; }

    /// <summary>The source database id that will be used to restore from. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sourceDatabaseId")]
    public string? SourceDatabaseId { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedDatabaseSpecInitProvider
{
    /// <summary>A long_term_retention_policy block as defined below.</summary>
    [JsonPropertyName("longTermRetentionPolicy")]
    public IList<V1beta1MSSQLManagedDatabaseSpecInitProviderLongTermRetentionPolicy>? LongTermRetentionPolicy { get; set; }

    /// <summary>A point_in_time_restore block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("pointInTimeRestore")]
    public IList<V1beta1MSSQLManagedDatabaseSpecInitProviderPointInTimeRestore>? PointInTimeRestore { get; set; }

    /// <summary>The backup retention period in days. This is how many days Point-in-Time Restore will be supported.</summary>
    [JsonPropertyName("shortTermRetentionDays")]
    public double? ShortTermRetentionDays { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedDatabaseSpecProviderConfigRefPolicy
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
public partial class V1beta1MSSQLManagedDatabaseSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLManagedDatabaseSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedDatabaseSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>MSSQLManagedDatabaseSpec defines the desired state of MSSQLManagedDatabase</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedDatabaseSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1MSSQLManagedDatabaseSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1MSSQLManagedDatabaseSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MSSQLManagedDatabaseSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MSSQLManagedDatabaseSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedDatabaseStatusAtProviderLongTermRetentionPolicy
{
    /// <summary></summary>
    [JsonPropertyName("immutableBackupsEnabled")]
    public bool? ImmutableBackupsEnabled { get; set; }

    /// <summary>The monthly retention policy for an LTR backup in an ISO 8601 format. Valid value is between 1 to 120 months. e.g. P1Y, P1M, P4W or P30D. Defaults to PT0S.</summary>
    [JsonPropertyName("monthlyRetention")]
    public string? MonthlyRetention { get; set; }

    /// <summary>The week of year to take the yearly backup. Value has to be between 1 and 52.</summary>
    [JsonPropertyName("weekOfYear")]
    public double? WeekOfYear { get; set; }

    /// <summary>The weekly retention policy for an LTR backup in an ISO 8601 format. Valid value is between 1 to 520 weeks. e.g. P1Y, P1M, P1W or P7D. Defaults to PT0S.</summary>
    [JsonPropertyName("weeklyRetention")]
    public string? WeeklyRetention { get; set; }

    /// <summary>The yearly retention policy for an LTR backup in an ISO 8601 format. Valid value is between 1 to 10 years. e.g. P1Y, P12M, P52W or P365D. Defaults to PT0S.</summary>
    [JsonPropertyName("yearlyRetention")]
    public string? YearlyRetention { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedDatabaseStatusAtProviderPointInTimeRestore
{
    /// <summary>The point in time for the restore from source_database_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("restorePointInTime")]
    public string? RestorePointInTime { get; set; }

    /// <summary>The source database id that will be used to restore from. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sourceDatabaseId")]
    public string? SourceDatabaseId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedDatabaseStatusAtProvider
{
    /// <summary>The Azure SQL Managed Database ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A long_term_retention_policy block as defined below.</summary>
    [JsonPropertyName("longTermRetentionPolicy")]
    public IList<V1beta1MSSQLManagedDatabaseStatusAtProviderLongTermRetentionPolicy>? LongTermRetentionPolicy { get; set; }

    /// <summary>The ID of the Azure SQL Managed Instance on which to create this Managed Database. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedInstanceId")]
    public string? ManagedInstanceId { get; set; }

    /// <summary>A point_in_time_restore block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("pointInTimeRestore")]
    public IList<V1beta1MSSQLManagedDatabaseStatusAtProviderPointInTimeRestore>? PointInTimeRestore { get; set; }

    /// <summary>The backup retention period in days. This is how many days Point-in-Time Restore will be supported.</summary>
    [JsonPropertyName("shortTermRetentionDays")]
    public double? ShortTermRetentionDays { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedDatabaseStatusConditions
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

/// <summary>MSSQLManagedDatabaseStatus defines the observed state of MSSQLManagedDatabase.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedDatabaseStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1MSSQLManagedDatabaseStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MSSQLManagedDatabaseStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MSSQLManagedDatabase is the Schema for the MSSQLManagedDatabases API. Manages an Azure SQL Azure Managed Database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MSSQLManagedDatabase : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MSSQLManagedDatabaseSpec>, IStatus<V1beta1MSSQLManagedDatabaseStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MSSQLManagedDatabase";
    public const string KubeGroup = "sql.azure.upbound.io";
    public const string KubePluralName = "mssqlmanageddatabases";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MSSQLManagedDatabaseSpec defines the desired state of MSSQLManagedDatabase</summary>
    [JsonPropertyName("spec")]
    public V1beta1MSSQLManagedDatabaseSpec Spec { get; set; }

    /// <summary>MSSQLManagedDatabaseStatus defines the observed state of MSSQLManagedDatabase.</summary>
    [JsonPropertyName("status")]
    public V1beta1MSSQLManagedDatabaseStatus? Status { get; set; }
}