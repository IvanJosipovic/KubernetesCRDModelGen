using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.spanner.cnrm.cloud.google.com;
/// <summary>Optional. The Cloud KMS key that will be used to protect the backup. This field should be set only when [encryption_type][google.spanner.admin.database.v1.CreateBackupEncryptionConfig.encryption_type] is `CUSTOMER_MANAGED_ENCRYPTION`. Values are of the form `projects/&lt;project&gt;/locations/&lt;location&gt;/keyRings/&lt;key_ring&gt;/cryptoKeys/&lt;kms_key_name&gt;`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpannerBackupScheduleSpecEncryptionConfigKmsKeyRef
{
    /// <summary>A reference to an externally managed KMSCryptoKey. Should be in the format `projects/[kms_project_id]/locations/[region]/keyRings/[key_ring_id]/cryptoKeys/[key]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpannerBackupScheduleSpecEncryptionConfigKmsKeyRefs
{
    /// <summary>A reference to an externally managed KMSCryptoKey. Should be in the format `projects/[kms_project_id]/locations/[region]/keyRings/[key_ring_id]/cryptoKeys/[key]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. The encryption configuration that will be used to encrypt the backup. If this field is not specified, the backup will use the same encryption configuration as the database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpannerBackupScheduleSpecEncryptionConfig
{
    /// <summary>Required. The encryption type of the backup.</summary>
    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>Optional. The Cloud KMS key that will be used to protect the backup. This field should be set only when [encryption_type][google.spanner.admin.database.v1.CreateBackupEncryptionConfig.encryption_type] is `CUSTOMER_MANAGED_ENCRYPTION`. Values are of the form `projects/&lt;project&gt;/locations/&lt;location&gt;/keyRings/&lt;key_ring&gt;/cryptoKeys/&lt;kms_key_name&gt;`.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1alpha1SpannerBackupScheduleSpecEncryptionConfigKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>Optional. Specifies the KMS configuration for the one or more keys used to  protect the backup. Values are of the form  `projects/&lt;project&gt;/locations/&lt;location&gt;/keyRings/&lt;key_ring&gt;/cryptoKeys/&lt;kms_key_name&gt;`.   The keys referenced by kms_key_names must fully cover all  regions of the backup's instance configuration. Some examples:  * For single region instance configs, specify a single regional  location KMS key.  * For multi-regional instance configs of type GOOGLE_MANAGED,  either specify a multi-regional location KMS key or multiple regional  location KMS keys that cover all regions in the instance config.  * For an instance config of type USER_MANAGED, please specify only  regional location KMS keys to cover each region in the instance config.  Multi-regional location KMS keys are not supported for USER_MANAGED  instance configs.</summary>
    [JsonPropertyName("kmsKeyRefs")]
    public IList<V1alpha1SpannerBackupScheduleSpecEncryptionConfigKmsKeyRefs>? KmsKeyRefs { get; set; }
}

/// <summary>The schedule creates only full backups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpannerBackupScheduleSpecFullBackupSpec
{
}

/// <summary>The schedule creates incremental backup chains.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpannerBackupScheduleSpecIncrementalBackupSpec
{
}

/// <summary>Required. The spanner database that this backup applies to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpannerBackupScheduleSpecSpannerDatabaseRef
{
    /// <summary>A reference to an externally managed SpannerDatabase resource. Should be in the format "projects/{{projectID}}/instances/{{instanceID}}/databases/{{databaseID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a SpannerDatabase resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a SpannerDatabase resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Cron style schedule specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpannerBackupScheduleSpecSpecCronSpec
{
    /// <summary>Required. Textual representation of the crontab. User can customize the  backup frequency and the backup version time using the cron  expression. The version time must be in UTC timzeone.   The backup will contain an externally consistent copy of the  database at the version time. Allowed frequencies are 12 hour, 1 day,  1 week and 1 month. Examples of valid cron specifications:    * `0 2/12 * * * ` : every 12 hours at (2, 14) hours past midnight in UTC.    * `0 2,14 * * * ` : every 12 hours at (2,14) hours past midnight in UTC.    * `0 2 * * * `    : once a day at 2 past midnight in UTC.    * `0 2 * * 0 `    : once a week every Sunday at 2 past midnight in UTC.    * `0 2 8 * * `    : once a month on 8th day at 2 past midnight in UTC.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>Optional. The schedule specification based on which the backup creations are triggered.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpannerBackupScheduleSpecSpec
{
    /// <summary>Cron style schedule specification.</summary>
    [JsonPropertyName("cronSpec")]
    public V1alpha1SpannerBackupScheduleSpecSpecCronSpec? CronSpec { get; set; }
}

/// <summary>SpannerBackupScheduleSpec defines the desired state of SpannerBackupSchedule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpannerBackupScheduleSpec
{
    /// <summary>Optional. The encryption configuration that will be used to encrypt the backup. If this field is not specified, the backup will use the same encryption configuration as the database.</summary>
    [JsonPropertyName("encryptionConfig")]
    public V1alpha1SpannerBackupScheduleSpecEncryptionConfig? EncryptionConfig { get; set; }

    /// <summary>The schedule creates only full backups.</summary>
    [JsonPropertyName("fullBackupSpec")]
    public V1alpha1SpannerBackupScheduleSpecFullBackupSpec? FullBackupSpec { get; set; }

    /// <summary>The schedule creates incremental backup chains.</summary>
    [JsonPropertyName("incrementalBackupSpec")]
    public V1alpha1SpannerBackupScheduleSpecIncrementalBackupSpec? IncrementalBackupSpec { get; set; }

    /// <summary>The SpannerBackupSchedule name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. The retention duration of a backup that must be at least 6 hours and at most 366 days. The backup is eligible to be automatically deleted once the retention period has elapsed.</summary>
    [JsonPropertyName("retentionDuration")]
    public string? RetentionDuration { get; set; }

    /// <summary>Required. The spanner database that this backup applies to.</summary>
    [JsonPropertyName("spannerDatabaseRef")]
    public V1alpha1SpannerBackupScheduleSpecSpannerDatabaseRef? SpannerDatabaseRef { get; set; }

    /// <summary>Optional. The schedule specification based on which the backup creations are triggered.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1SpannerBackupScheduleSpecSpec? Spec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpannerBackupScheduleStatusConditions
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

/// <summary>Cron style schedule specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpannerBackupScheduleStatusObservedStateCronSpec
{
    /// <summary>Output only. Schedule backups will contain an externally consistent copy of the database at the version time specified in `schedule_spec.cron_spec`. However, Spanner may not initiate the creation of the scheduled backups at that version time. Spanner will initiate the creation of scheduled backups within the time window bounded by the version_time specified in `schedule_spec.cron_spec` and version_time + `creation_window`.</summary>
    [JsonPropertyName("creationWindow")]
    public string? CreationWindow { get; set; }

    /// <summary>Output only. The time zone of the times in `CrontabSpec.text`. Currently only UTC is supported.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpannerBackupScheduleStatusObservedState
{
    /// <summary>Cron style schedule specification.</summary>
    [JsonPropertyName("cronSpec")]
    public V1alpha1SpannerBackupScheduleStatusObservedStateCronSpec? CronSpec { get; set; }

    /// <summary>Output only. The timestamp at which the schedule was last updated. If the schedule has never been updated, this field contains the timestamp when the schedule was first created.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>SpannerBackupScheduleStatus defines the config connector machine state of SpannerBackupSchedule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpannerBackupScheduleStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SpannerBackupScheduleStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the SpannerBackupSchedule resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1SpannerBackupScheduleStatusObservedState? ObservedState { get; set; }
}

/// <summary>SpannerBackupSchedule is the Schema for the SpannerBackupSchedule API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SpannerBackupSchedule : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SpannerBackupScheduleSpec>, IStatus<V1alpha1SpannerBackupScheduleStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SpannerBackupSchedule";
    public const string KubeGroup = "spanner.cnrm.cloud.google.com";
    public const string KubePluralName = "spannerbackupschedules";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SpannerBackupScheduleSpec defines the desired state of SpannerBackupSchedule</summary>
    [JsonPropertyName("spec")]
    public V1alpha1SpannerBackupScheduleSpec Spec { get; set; }

    /// <summary>SpannerBackupScheduleStatus defines the config connector machine state of SpannerBackupSchedule</summary>
    [JsonPropertyName("status")]
    public V1alpha1SpannerBackupScheduleStatus? Status { get; set; }
}

/// <summary>SpannerBackupSchedule is the Schema for the SpannerBackupSchedule API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SpannerBackupScheduleList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SpannerBackupSchedule>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SpannerBackupScheduleList";
    public const string KubeGroup = "spanner.cnrm.cloud.google.com";
    public const string KubePluralName = "spannerbackupschedules";
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
    public IList<V1alpha1SpannerBackupSchedule> Items { get; set; }
}