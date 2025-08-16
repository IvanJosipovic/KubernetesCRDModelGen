using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sql.cnrm.cloud.google.com;
/// <summary>SQLInstance is the Schema for the sql API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SQLInstanceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SQLInstance>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SQLInstanceList";
    public const string KubeGroup = "sql.cnrm.cloud.google.com";
    public const string KubePluralName = "sqlinstances";
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
    public IList<V1beta1SQLInstance> Items { get; set; }
}

/// <summary>Binary log coordinates, if specified, identify the position up to which the source instance is cloned. If not specified, the source instance is cloned up to the most recent binary log coordinates.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceSpecCloneSourceBinLogCoordinates
{
    /// <summary>Name of the binary log file for a Cloud SQL instance.</summary>
    [JsonPropertyName("binLogFileName")]
    public string? BinLogFileName { get; set; }

    /// <summary>Position (offset) within the binary log file.</summary>
    [JsonPropertyName("binLogPosition")]
    public long? BinLogPosition { get; set; }
}

/// <summary>The source SQLInstance to clone</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceSpecCloneSourceSqlInstanceRef
{
    /// <summary>The SQLInstance selfLink, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SQLInstance` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `SQLInstance` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Create this database as a clone of a source instance. Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceSpecCloneSource
{
    /// <summary>Binary log coordinates, if specified, identify the position up to which the source instance is cloned. If not specified, the source instance is cloned up to the most recent binary log coordinates.</summary>
    [JsonPropertyName("binLogCoordinates")]
    public V1beta1SQLInstanceSpecCloneSourceBinLogCoordinates? BinLogCoordinates { get; set; }

    /// <summary>(SQL Server only) Clone only the specified databases from the source instance. Clone all databases if empty.</summary>
    [JsonPropertyName("databaseNames")]
    public IList<string>? DatabaseNames { get; set; }

    /// <summary>Timestamp, if specified, identifies the time to which the source instance is cloned.</summary>
    [JsonPropertyName("pointInTime")]
    public string? PointInTime { get; set; }

    /// <summary>The source SQLInstance to clone</summary>
    [JsonPropertyName("sqlInstanceRef")]
    public V1beta1SQLInstanceSpecCloneSourceSqlInstanceRef? SqlInstanceRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceSpecEncryptionKMSCryptoKeyRef
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
public partial class V1beta1SQLInstanceSpecMasterInstanceRef
{
    /// <summary>The SQLInstance selfLink, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SQLInstance` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `SQLInstance` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceSpecReplicaConfigurationPasswordValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceSpecReplicaConfigurationPasswordValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1SQLInstanceSpecReplicaConfigurationPasswordValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>Immutable. Password for the replication connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceSpecReplicaConfigurationPassword
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1SQLInstanceSpecReplicaConfigurationPasswordValueFrom? ValueFrom { get; set; }
}

/// <summary>The configuration for replication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceSpecReplicaConfiguration
{
    /// <summary>Immutable. PEM representation of the trusted CA's x509 certificate.</summary>
    [JsonPropertyName("caCertificate")]
    public string? CaCertificate { get; set; }

    /// <summary>Immutable. PEM representation of the replica's x509 certificate.</summary>
    [JsonPropertyName("clientCertificate")]
    public string? ClientCertificate { get; set; }

    /// <summary>Immutable. PEM representation of the replica's private key. The corresponding public key in encoded in the client_certificate.</summary>
    [JsonPropertyName("clientKey")]
    public string? ClientKey { get; set; }

    /// <summary>Immutable. The number of seconds between connect retries. MySQL's default is 60 seconds.</summary>
    [JsonPropertyName("connectRetryInterval")]
    public long? ConnectRetryInterval { get; set; }

    /// <summary>Immutable. Path to a SQL file in Google Cloud Storage from which replica instances are created. Format is gs://bucket/filename.</summary>
    [JsonPropertyName("dumpFilePath")]
    public string? DumpFilePath { get; set; }

    /// <summary>Immutable. Specifies if the replica is the failover target. If the field is set to true the replica will be designated as a failover replica. If the master instance fails, the replica instance will be promoted as the new master instance. Not supported for Postgres.</summary>
    [JsonPropertyName("failoverTarget")]
    public bool? FailoverTarget { get; set; }

    /// <summary>Immutable. Time in ms between replication heartbeats.</summary>
    [JsonPropertyName("masterHeartbeatPeriod")]
    public long? MasterHeartbeatPeriod { get; set; }

    /// <summary>Immutable. Password for the replication connection.</summary>
    [JsonPropertyName("password")]
    public V1beta1SQLInstanceSpecReplicaConfigurationPassword? Password { get; set; }

    /// <summary>Immutable. Permissible ciphers for use in SSL encryption.</summary>
    [JsonPropertyName("sslCipher")]
    public string? SslCipher { get; set; }

    /// <summary>Immutable. Username for replication connection.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>Immutable. True if the master's common name value is checked during the SSL handshake.</summary>
    [JsonPropertyName("verifyServerCertificate")]
    public bool? VerifyServerCertificate { get; set; }
}

/// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceSpecRootPasswordValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceSpecRootPasswordValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1SQLInstanceSpecRootPasswordValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>Initial root password. Required for MS SQL Server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceSpecRootPassword
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1SQLInstanceSpecRootPasswordValueFrom? ValueFrom { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceSpecSettingsActiveDirectoryConfig
{
    /// <summary>Domain name of the Active Directory for SQL Server (e.g., mydomain.com).</summary>
    [JsonPropertyName("domain")]
    public string Domain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceSpecSettingsAdvancedMachineFeatures
{
    /// <summary>The number of threads per physical core. Can be 1 or 2.</summary>
    [JsonPropertyName("threadsPerCore")]
    public long? ThreadsPerCore { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceSpecSettingsBackupConfigurationBackupRetentionSettings
{
    /// <summary>Number of backups to retain.</summary>
    [JsonPropertyName("retainedBackups")]
    public long RetainedBackups { get; set; }

    /// <summary>The unit that 'retainedBackups' represents. Defaults to COUNT.</summary>
    [JsonPropertyName("retentionUnit")]
    public string? RetentionUnit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceSpecSettingsBackupConfiguration
{
    /// <summary></summary>
    [JsonPropertyName("backupRetentionSettings")]
    public V1beta1SQLInstanceSpecSettingsBackupConfigurationBackupRetentionSettings? BackupRetentionSettings { get; set; }

    /// <summary>True if binary logging is enabled. If settings.backup_configuration.enabled is false, this must be as well. Can only be used with MySQL.</summary>
    [JsonPropertyName("binaryLogEnabled")]
    public bool? BinaryLogEnabled { get; set; }

    /// <summary>True if backup configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Location of the backup configuration.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>True if Point-in-time recovery is enabled.</summary>
    [JsonPropertyName("pointInTimeRecoveryEnabled")]
    public bool? PointInTimeRecoveryEnabled { get; set; }

    /// <summary>HH:MM format time indicating when backup configuration starts.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>The number of days of transaction logs we retain for point in time restore, from 1-7. (For PostgreSQL Enterprise Plus instances, from 1 to 35.).</summary>
    [JsonPropertyName("transactionLogRetentionDays")]
    public long? TransactionLogRetentionDays { get; set; }
}

/// <summary>Data cache configurations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceSpecSettingsDataCacheConfig
{
    /// <summary>Whether data cache is enabled for the instance.</summary>
    [JsonPropertyName("dataCacheEnabled")]
    public bool? DataCacheEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceSpecSettingsDatabaseFlags
{
    /// <summary>Name of the flag.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value of the flag.</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceSpecSettingsDenyMaintenancePeriod
{
    /// <summary>End date before which maintenance will not take place. The date is in format yyyy-mm-dd i.e., 2020-11-01, or mm-dd, i.e., 11-01.</summary>
    [JsonPropertyName("endDate")]
    public string EndDate { get; set; }

    /// <summary>Start date after which maintenance will not take place. The date is in format yyyy-mm-dd i.e., 2020-11-01, or mm-dd, i.e., 11-01.</summary>
    [JsonPropertyName("startDate")]
    public string StartDate { get; set; }

    /// <summary>Time in UTC when the "deny maintenance period" starts on start_date and ends on end_date. The time is in format: HH:mm:SS, i.e., 00:00:00.</summary>
    [JsonPropertyName("time")]
    public string Time { get; set; }
}

/// <summary>Configuration of Query Insights.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceSpecSettingsInsightsConfig
{
    /// <summary>True if Query Insights feature is enabled.</summary>
    [JsonPropertyName("queryInsightsEnabled")]
    public bool? QueryInsightsEnabled { get; set; }

    /// <summary>Number of query execution plans captured by Insights per minute for all queries combined. Between 0 and 20. Default to 5.</summary>
    [JsonPropertyName("queryPlansPerMinute")]
    public long? QueryPlansPerMinute { get; set; }

    /// <summary>Maximum query length stored in bytes. Between 256 and 4500. Default to 1024.</summary>
    [JsonPropertyName("queryStringLength")]
    public long? QueryStringLength { get; set; }

    /// <summary>True if Query Insights will record application tags from query when enabled.</summary>
    [JsonPropertyName("recordApplicationTags")]
    public bool? RecordApplicationTags { get; set; }

    /// <summary>True if Query Insights will record client address when enabled.</summary>
    [JsonPropertyName("recordClientAddress")]
    public bool? RecordClientAddress { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceSpecSettingsIpConfigurationAuthorizedNetworks
{
    /// <summary></summary>
    [JsonPropertyName("expirationTime")]
    public string? ExpirationTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceSpecSettingsIpConfigurationPrivateNetworkRef
{
    /// <summary>A reference to an externally managed Compute Network resource. Should be in the format `projects/{{projectID}}/global/networks/{{network}}`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceSpecSettingsIpConfigurationPscConfig
{
    /// <summary>List of consumer projects that are allow-listed for PSC connections to this instance. This instance can be connected to with PSC from any network in these projects. Each consumer project in this list may be represented by a project number (numeric) or by a project id (alphanumeric).</summary>
    [JsonPropertyName("allowedConsumerProjects")]
    public IList<string>? AllowedConsumerProjects { get; set; }

    /// <summary>Whether PSC connectivity is enabled for this instance.</summary>
    [JsonPropertyName("pscEnabled")]
    public bool? PscEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceSpecSettingsIpConfiguration
{
    /// <summary>The name of the allocated ip range for the private ip CloudSQL instance. For example: "google-managed-services-default". If set, the instance ip will be created in the allocated range. The range name must comply with RFC 1035. Specifically, the name must be 1-63 characters long and match the regular expression [a-z]([-a-z0-9]*[a-z0-9])?.</summary>
    [JsonPropertyName("allocatedIpRange")]
    public string? AllocatedIpRange { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authorizedNetworks")]
    public IList<V1beta1SQLInstanceSpecSettingsIpConfigurationAuthorizedNetworks>? AuthorizedNetworks { get; set; }

    /// <summary>Whether Google Cloud services such as BigQuery are allowed to access data in this Cloud SQL instance over a private IP connection. SQLSERVER database type is not supported.</summary>
    [JsonPropertyName("enablePrivatePathForGoogleCloudServices")]
    public bool? EnablePrivatePathForGoogleCloudServices { get; set; }

    /// <summary>Whether this Cloud SQL instance should be assigned a public IPV4 address. At least ipv4_enabled must be enabled or a private_network must be configured.</summary>
    [JsonPropertyName("ipv4Enabled")]
    public bool? Ipv4Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateNetworkRef")]
    public V1beta1SQLInstanceSpecSettingsIpConfigurationPrivateNetworkRef? PrivateNetworkRef { get; set; }

    /// <summary>PSC settings for a Cloud SQL instance.</summary>
    [JsonPropertyName("pscConfig")]
    public IList<V1beta1SQLInstanceSpecSettingsIpConfigurationPscConfig>? PscConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requireSsl")]
    public bool? RequireSsl { get; set; }

    /// <summary>Specify how SSL connection should be enforced in DB connections. This field provides more SSL enforcment options compared to requireSsl. To change this field, also set the correspoding value in requireSsl if it has been set.</summary>
    [JsonPropertyName("sslMode")]
    public string? SslMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceSpecSettingsLocationPreference
{
    /// <summary>A Google App Engine application whose zone to remain in. Must be in the same region as this instance.</summary>
    [JsonPropertyName("followGaeApplication")]
    public string? FollowGaeApplication { get; set; }

    /// <summary>The preferred Compute Engine zone for the secondary/failover.</summary>
    [JsonPropertyName("secondaryZone")]
    public string? SecondaryZone { get; set; }

    /// <summary>The preferred compute engine zone.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>Declares a one-hour maintenance window when an Instance can automatically restart to apply updates. The maintenance window is specified in UTC time.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceSpecSettingsMaintenanceWindow
{
    /// <summary>Day of week (1-7), starting on Monday.</summary>
    [JsonPropertyName("day")]
    public long? Day { get; set; }

    /// <summary>Hour of day (0-23), ignored if day not set.</summary>
    [JsonPropertyName("hour")]
    public long? Hour { get; set; }

    /// <summary>Receive updates earlier (canary) or later (stable).</summary>
    [JsonPropertyName("updateTrack")]
    public string? UpdateTrack { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceSpecSettingsPasswordValidationPolicy
{
    /// <summary>Password complexity.</summary>
    [JsonPropertyName("complexity")]
    public string? Complexity { get; set; }

    /// <summary>Disallow username as a part of the password.</summary>
    [JsonPropertyName("disallowUsernameSubstring")]
    public bool? DisallowUsernameSubstring { get; set; }

    /// <summary>Whether the password policy is enabled or not.</summary>
    [JsonPropertyName("enablePasswordPolicy")]
    public bool EnablePasswordPolicy { get; set; }

    /// <summary>Minimum number of characters allowed.</summary>
    [JsonPropertyName("minLength")]
    public long? MinLength { get; set; }

    /// <summary>Minimum interval after which the password can be changed. This flag is only supported for PostgresSQL.</summary>
    [JsonPropertyName("passwordChangeInterval")]
    public string? PasswordChangeInterval { get; set; }

    /// <summary>Number of previous passwords that cannot be reused.</summary>
    [JsonPropertyName("reuseInterval")]
    public long? ReuseInterval { get; set; }
}

/// <summary>The name of the destination bucket (e.g., gs://mybucket).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceSpecSettingsSqlServerAuditConfigBucketRef
{
    /// <summary>The StorageBucket selfLink, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `StorageBucket` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `StorageBucket` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceSpecSettingsSqlServerAuditConfig
{
    /// <summary>The name of the destination bucket (e.g., gs://mybucket).</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1SQLInstanceSpecSettingsSqlServerAuditConfigBucketRef? BucketRef { get; set; }

    /// <summary>How long to keep generated audit files. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s"..</summary>
    [JsonPropertyName("retentionInterval")]
    public string? RetentionInterval { get; set; }

    /// <summary>How often to upload generated audit files. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("uploadInterval")]
    public string? UploadInterval { get; set; }
}

/// <summary>The settings to use for the database. The configuration is detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceSpecSettings
{
    /// <summary>This specifies when the instance should be active. Can be either ALWAYS, NEVER or ON_DEMAND.</summary>
    [JsonPropertyName("activationPolicy")]
    public string? ActivationPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("activeDirectoryConfig")]
    public V1beta1SQLInstanceSpecSettingsActiveDirectoryConfig? ActiveDirectoryConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("advancedMachineFeatures")]
    public V1beta1SQLInstanceSpecSettingsAdvancedMachineFeatures? AdvancedMachineFeatures { get; set; }

    /// <summary>DEPRECATED. This property is only applicable to First Generation instances, and First Generation instances are now deprecated. see https://cloud.google.com/sql/docs/mysql/deprecation-notice for information on how to upgrade to Second Generation instances. Specifying this field has no-ops; it's recommended to remove this field from your configuration.</summary>
    [JsonPropertyName("authorizedGaeApplications")]
    public IList<string>? AuthorizedGaeApplications { get; set; }

    /// <summary>The availability type of the Cloud SQL instance, high availability (REGIONAL) or single zone (ZONAL). For all instances, ensure that settings.backup_configuration.enabled is set to true. For MySQL instances, ensure that settings.backup_configuration.binary_log_enabled is set to true. For Postgres instances, ensure that settings.backup_configuration.point_in_time_recovery_enabled is set to true. Defaults to ZONAL.</summary>
    [JsonPropertyName("availabilityType")]
    public string? AvailabilityType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backupConfiguration")]
    public V1beta1SQLInstanceSpecSettingsBackupConfiguration? BackupConfiguration { get; set; }

    /// <summary>Immutable. The name of server instance collation.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>Specifies if connections must use Cloud SQL connectors.</summary>
    [JsonPropertyName("connectorEnforcement")]
    public string? ConnectorEnforcement { get; set; }

    /// <summary>DEPRECATED. This property is only applicable to First Generation instances, and First Generation instances are now deprecated. see https://cloud.google.com/sql/docs/mysql/deprecation-notice for information on how to upgrade to Second Generation instances. Specifying this field has no-ops; it's recommended to remove this field from your configuration.</summary>
    [JsonPropertyName("crashSafeReplication")]
    public bool? CrashSafeReplication { get; set; }

    /// <summary>Data cache configurations.</summary>
    [JsonPropertyName("dataCacheConfig")]
    public V1beta1SQLInstanceSpecSettingsDataCacheConfig? DataCacheConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("databaseFlags")]
    public IList<V1beta1SQLInstanceSpecSettingsDatabaseFlags>? DatabaseFlags { get; set; }

    /// <summary>Configuration to protect against accidental instance deletion.</summary>
    [JsonPropertyName("deletionProtectionEnabled")]
    public bool? DeletionProtectionEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("denyMaintenancePeriod")]
    public V1beta1SQLInstanceSpecSettingsDenyMaintenancePeriod? DenyMaintenancePeriod { get; set; }

    /// <summary>Enables auto-resizing of the storage size. Defaults to true.</summary>
    [JsonPropertyName("diskAutoresize")]
    public bool? DiskAutoresize { get; set; }

    /// <summary>The maximum size, in GB, to which storage capacity can be automatically increased. The default value is 0, which specifies that there is no limit.</summary>
    [JsonPropertyName("diskAutoresizeLimit")]
    public long? DiskAutoresizeLimit { get; set; }

    /// <summary>The size of data disk, in GB. Size of a running instance cannot be reduced but can be increased. The minimum value is 10GB.</summary>
    [JsonPropertyName("diskSize")]
    public long? DiskSize { get; set; }

    /// <summary>Immutable. The type of data disk: PD_SSD or PD_HDD. Defaults to PD_SSD.</summary>
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    /// <summary>The edition of the instance, can be ENTERPRISE or ENTERPRISE_PLUS.</summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    /// <summary>Configuration of Query Insights.</summary>
    [JsonPropertyName("insightsConfig")]
    public V1beta1SQLInstanceSpecSettingsInsightsConfig? InsightsConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipConfiguration")]
    public V1beta1SQLInstanceSpecSettingsIpConfiguration? IpConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("locationPreference")]
    public V1beta1SQLInstanceSpecSettingsLocationPreference? LocationPreference { get; set; }

    /// <summary>Declares a one-hour maintenance window when an Instance can automatically restart to apply updates. The maintenance window is specified in UTC time.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1beta1SQLInstanceSpecSettingsMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passwordValidationPolicy")]
    public V1beta1SQLInstanceSpecSettingsPasswordValidationPolicy? PasswordValidationPolicy { get; set; }

    /// <summary>Pricing plan for this instance, can only be PER_USE.</summary>
    [JsonPropertyName("pricingPlan")]
    public string? PricingPlan { get; set; }

    /// <summary>DEPRECATED. This property is only applicable to First Generation instances, and First Generation instances are now deprecated. see https://cloud.google.com/sql/docs/mysql/deprecation-notice for information on how to upgrade to Second Generation instances. Specifying this field has no-ops; it's recommended to remove this field from your configuration.</summary>
    [JsonPropertyName("replicationType")]
    public string? ReplicationType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sqlServerAuditConfig")]
    public V1beta1SQLInstanceSpecSettingsSqlServerAuditConfig? SqlServerAuditConfig { get; set; }

    /// <summary>The machine type to use. See tiers for more details and supported versions. Postgres supports only shared-core machine types, and custom machine types such as db-custom-2-13312. See the Custom Machine Type Documentation to learn about specifying custom machine types.</summary>
    [JsonPropertyName("tier")]
    public string Tier { get; set; }

    /// <summary>Immutable. The time_zone to be used by the database engine (supported only for SQL Server), in SQL Server timezone format.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceSpec
{
    /// <summary>Create this database as a clone of a source instance. Immutable.</summary>
    [JsonPropertyName("cloneSource")]
    public V1beta1SQLInstanceSpecCloneSource? CloneSource { get; set; }

    /// <summary>The MySQL, PostgreSQL or SQL Server (beta) version to use. Supported values include MYSQL_5_6, MYSQL_5_7, MYSQL_8_0, POSTGRES_9_6, POSTGRES_10, POSTGRES_11, POSTGRES_12, POSTGRES_13, POSTGRES_14, POSTGRES_15, SQLSERVER_2017_STANDARD, SQLSERVER_2017_ENTERPRISE, SQLSERVER_2017_EXPRESS, SQLSERVER_2017_WEB. Database Version Policies includes an up-to-date reference of supported versions.</summary>
    [JsonPropertyName("databaseVersion")]
    public string? DatabaseVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionKMSCryptoKeyRef")]
    public V1beta1SQLInstanceSpecEncryptionKMSCryptoKeyRef? EncryptionKMSCryptoKeyRef { get; set; }

    /// <summary>The type of the instance. The valid values are:- 'SQL_INSTANCE_TYPE_UNSPECIFIED', 'CLOUD_SQL_INSTANCE', 'ON_PREMISES_INSTANCE' and 'READ_REPLICA_INSTANCE'.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Maintenance version.</summary>
    [JsonPropertyName("maintenanceVersion")]
    public string? MaintenanceVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("masterInstanceRef")]
    public V1beta1SQLInstanceSpecMasterInstanceRef? MasterInstanceRef { get; set; }

    /// <summary>Immutable. The region the instance will sit in. Note, Cloud SQL is not available in all regions. A valid region must be provided to use this resource. If a region is not provided in the resource definition, the provider region will be used instead, but this will be an apply-time error for instances if the provider region is not supported with Cloud SQL. If you choose not to provide the region argument for this resource, make sure you understand this.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The configuration for replication.</summary>
    [JsonPropertyName("replicaConfiguration")]
    public V1beta1SQLInstanceSpecReplicaConfiguration? ReplicaConfiguration { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Initial root password. Required for MS SQL Server.</summary>
    [JsonPropertyName("rootPassword")]
    public V1beta1SQLInstanceSpecRootPassword? RootPassword { get; set; }

    /// <summary>The settings to use for the database. The configuration is detailed below.</summary>
    [JsonPropertyName("settings")]
    public V1beta1SQLInstanceSpecSettings Settings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceStatusConditions
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceStatusIpAddress
{
    /// <summary></summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeToRetire")]
    public string? TimeToRetire { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceStatusServerCaCert
{
    /// <summary>The CA Certificate used to connect to the SQL Instance via SSL.</summary>
    [JsonPropertyName("cert")]
    public string? Cert { get; set; }

    /// <summary>The CN valid for the CA Cert.</summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>Creation time of the CA Cert.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Expiration time of the CA Cert.</summary>
    [JsonPropertyName("expirationTime")]
    public string? ExpirationTime { get; set; }

    /// <summary>SHA Fingerprint of the CA Cert.</summary>
    [JsonPropertyName("sha1Fingerprint")]
    public string? Sha1Fingerprint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SQLInstanceStatus
{
    /// <summary>Available Maintenance versions.</summary>
    [JsonPropertyName("availableMaintenanceVersions")]
    public IList<string>? AvailableMaintenanceVersions { get; set; }

    /// <summary>Conditions represent the latest available observations of the SQLInstance's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SQLInstanceStatusConditions>? Conditions { get; set; }

    /// <summary>The connection name of the instance to be used in connection strings. For example, when connecting with Cloud SQL Proxy.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>The dns name of the instance.</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("firstIpAddress")]
    public string? FirstIpAddress { get; set; }

    /// <summary>The type of the instance. The valid values are:- 'SQL_INSTANCE_TYPE_UNSPECIFIED', 'CLOUD_SQL_INSTANCE', 'ON_PREMISES_INSTANCE' and 'READ_REPLICA_INSTANCE'.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipAddress")]
    public IList<V1beta1SQLInstanceStatusIpAddress>? IpAddress { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>The link to service attachment of PSC instance.</summary>
    [JsonPropertyName("pscServiceAttachmentLink")]
    public string? PscServiceAttachmentLink { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicIpAddress")]
    public string? PublicIpAddress { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serverCaCert")]
    public V1beta1SQLInstanceStatusServerCaCert? ServerCaCert { get; set; }

    /// <summary>The service account email address assigned to the instance.</summary>
    [JsonPropertyName("serviceAccountEmailAddress")]
    public string? ServiceAccountEmailAddress { get; set; }
}

/// <summary>SQLInstance is the Schema for the sql API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SQLInstance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SQLInstanceSpec>, IStatus<V1beta1SQLInstanceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SQLInstance";
    public const string KubeGroup = "sql.cnrm.cloud.google.com";
    public const string KubePluralName = "sqlinstances";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1beta1SQLInstanceSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1SQLInstanceStatus? Status { get; set; }
}