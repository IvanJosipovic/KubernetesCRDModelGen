using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sql.gcp.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecForProviderClone
{
    /// <summary>The name of the allocated ip range for the private ip CloudSQL instance. For example: "google-managed-services-default". If set, the cloned instance ip will be created in the allocated range. The range name must comply with RFC 1035. Specifically, the name must be 1-63 characters long and match the regular expression a-z?.</summary>
    [JsonPropertyName("allocatedIpRange")]
    public string? AllocatedIpRange { get; set; }

    /// <summary>(SQL Server only, use with point_in_time) Clone only the specified databases from the source instance. Clone all databases if empty.</summary>
    [JsonPropertyName("databaseNames")]
    public IList<string>? DatabaseNames { get; set; }

    /// <summary>The timestamp of the point in time that should be restored.</summary>
    [JsonPropertyName("pointInTime")]
    public string? PointInTime { get; set; }

    /// <summary>(Point-in-time recovery for PostgreSQL only) Clone to an instance in the specified zone. If no zone is specified, clone to the same zone as the source instance. clone-unavailable-instance</summary>
    [JsonPropertyName("preferredZone")]
    public string? PreferredZone { get; set; }

    /// <summary>Name of the source instance which will be cloned.</summary>
    [JsonPropertyName("sourceInstanceName")]
    public string? SourceInstanceName { get; set; }
}

/// <summary>Password for the replication connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecForProviderReplicaConfigurationPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecForProviderReplicaConfiguration
{
    /// <summary>PEM representation of the trusted CA's x509 certificate.</summary>
    [JsonPropertyName("caCertificate")]
    public string? CaCertificate { get; set; }

    /// <summary>PEM representation of the replica's x509 certificate.</summary>
    [JsonPropertyName("clientCertificate")]
    public string? ClientCertificate { get; set; }

    /// <summary>PEM representation of the replica's private key. The corresponding public key in encoded in the client_certificate.</summary>
    [JsonPropertyName("clientKey")]
    public string? ClientKey { get; set; }

    /// <summary>The number of seconds between connect retries. MySQL's default is 60 seconds.</summary>
    [JsonPropertyName("connectRetryInterval")]
    public double? ConnectRetryInterval { get; set; }

    /// <summary>Path to a SQL file in GCS from which replica instances are created. Format is gs://bucket/filename.</summary>
    [JsonPropertyName("dumpFilePath")]
    public string? DumpFilePath { get; set; }

    /// <summary>Specifies if the replica is the failover target. If the field is set to true the replica will be designated as a failover replica. If the master instance fails, the replica instance will be promoted as the new master instance. ~&gt; NOTE: Not supported for Postgres database.</summary>
    [JsonPropertyName("failoverTarget")]
    public bool? FailoverTarget { get; set; }

    /// <summary>Time in ms between replication heartbeats.</summary>
    [JsonPropertyName("masterHeartbeatPeriod")]
    public double? MasterHeartbeatPeriod { get; set; }

    /// <summary>Password for the replication connection.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1DatabaseInstanceSpecForProviderReplicaConfigurationPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>Permissible ciphers for use in SSL encryption.</summary>
    [JsonPropertyName("sslCipher")]
    public string? SslCipher { get; set; }

    /// <summary>Username for replication connection.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>True if the master's common name value is checked during the SSL handshake.</summary>
    [JsonPropertyName("verifyServerCertificate")]
    public bool? VerifyServerCertificate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecForProviderRestoreBackupContext
{
    /// <summary>The ID of the backup run to restore from.</summary>
    [JsonPropertyName("backupRunId")]
    public double? BackupRunId { get; set; }

    /// <summary>The ID of the instance that the backup was taken from. If left empty, this instance's ID will be used.</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    /// <summary>The full project ID of the source instance.`</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

/// <summary>Initial root password. Can be updated. Required for MS SQL Server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecForProviderRootPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecForProviderSettingsActiveDirectoryConfig
{
    /// <summary>The domain name for the active directory (e.g., mydomain.com). Can only be used with SQL Server.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecForProviderSettingsAdvancedMachineFeatures
{
    /// <summary>The number of threads per core. The value of this flag can be 1 or 2. To disable SMT, set this flag to 1. Only available in Cloud SQL for SQL Server instances. See smt for more details.</summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecForProviderSettingsBackupConfigurationBackupRetentionSettings
{
    /// <summary>Depending on the value of retention_unit, this is used to determine if a backup needs to be deleted. If retention_unit is 'COUNT', we will retain this many backups.</summary>
    [JsonPropertyName("retainedBackups")]
    public double? RetainedBackups { get; set; }

    /// <summary>The unit that 'retained_backups' represents. Defaults to COUNT.</summary>
    [JsonPropertyName("retentionUnit")]
    public string? RetentionUnit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecForProviderSettingsBackupConfiguration
{
    /// <summary>Backup retention settings. The configuration is detailed below.</summary>
    [JsonPropertyName("backupRetentionSettings")]
    public IList<V1beta1DatabaseInstanceSpecForProviderSettingsBackupConfigurationBackupRetentionSettings>? BackupRetentionSettings { get; set; }

    /// <summary>True if binary logging is enabled. Can only be used with MySQL.</summary>
    [JsonPropertyName("binaryLogEnabled")]
    public bool? BinaryLogEnabled { get; set; }

    /// <summary>True if backup configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The region where the backup will be stored</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>True if Point-in-time recovery is enabled. Will restart database if enabled after instance creation. Valid only for PostgreSQL and SQL Server instances.</summary>
    [JsonPropertyName("pointInTimeRecoveryEnabled")]
    public bool? PointInTimeRecoveryEnabled { get; set; }

    /// <summary>HH:MM format time indicating when backup configuration starts.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>The number of days of transaction logs we retain for point in time restore, from 1-7. For PostgreSQL Enterprise Plus instances, the number of days of retained transaction logs can be set from 1 to 35.</summary>
    [JsonPropertyName("transactionLogRetentionDays")]
    public double? TransactionLogRetentionDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecForProviderSettingsDataCacheConfig
{
    /// <summary>Whether data cache is enabled for the instance. Defaults to false. Can be used with MYSQL and PostgreSQL only.</summary>
    [JsonPropertyName("dataCacheEnabled")]
    public bool? DataCacheEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecForProviderSettingsDatabaseFlags
{
    /// <summary>A name for this whitelist entry.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A CIDR notation IPv4 or IPv6 address that is allowed to access this instance. Must be set even if other two attributes are not for the whitelist to become active.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecForProviderSettingsDenyMaintenancePeriod
{
    /// <summary>"deny maintenance period" end date. If the year of the end date is empty, the year of the start date also must be empty. In this case, it means the no maintenance interval recurs every year. The date is in format yyyy-mm-dd i.e., 2020-11-01, or mm-dd, i.e., 11-01</summary>
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    /// <summary>"deny maintenance period" start date. If the year of the start date is empty, the year of the end date also must be empty. In this case, it means the deny maintenance period recurs every year. The date is in format yyyy-mm-dd i.e., 2020-11-01, or mm-dd, i.e., 11-01</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }

    /// <summary>Time in UTC when the "deny maintenance period" starts on startDate and ends on endDate. The time is in format: HH:mm:SS, i.e., 00:00:00</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecForProviderSettingsInsightsConfig
{
    /// <summary>True if Query Insights feature is enabled.</summary>
    [JsonPropertyName("queryInsightsEnabled")]
    public bool? QueryInsightsEnabled { get; set; }

    /// <summary>Number of query execution plans captured by Insights per minute for all queries combined. Between 0 and 20. Default to 5.</summary>
    [JsonPropertyName("queryPlansPerMinute")]
    public double? QueryPlansPerMinute { get; set; }

    /// <summary>Maximum query length stored in bytes. Between 256 and 4500. Default to 1024. Higher query lengths are more useful for analytical queries, but they also require more memory. Changing the query length requires you to restart the instance. You can still add tags to queries that exceed the length limit.</summary>
    [JsonPropertyName("queryStringLength")]
    public double? QueryStringLength { get; set; }

    /// <summary>True if Query Insights will record application tags from query when enabled.</summary>
    [JsonPropertyName("recordApplicationTags")]
    public bool? RecordApplicationTags { get; set; }

    /// <summary>True if Query Insights will record client address when enabled.</summary>
    [JsonPropertyName("recordClientAddress")]
    public bool? RecordClientAddress { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecForProviderSettingsIpConfigurationAuthorizedNetworks
{
    /// <summary>The RFC 3339 formatted date time string indicating when this whitelist expires.</summary>
    [JsonPropertyName("expirationTime")]
    public string? ExpirationTime { get; set; }

    /// <summary>A name for this whitelist entry.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A CIDR notation IPv4 or IPv6 address that is allowed to access this instance. Must be set even if other two attributes are not for the whitelist to become active.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecForProviderSettingsIpConfigurationPrivateNetworkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate privateNetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecForProviderSettingsIpConfigurationPrivateNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatabaseInstanceSpecForProviderSettingsIpConfigurationPrivateNetworkRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecForProviderSettingsIpConfigurationPrivateNetworkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate privateNetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecForProviderSettingsIpConfigurationPrivateNetworkSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatabaseInstanceSpecForProviderSettingsIpConfigurationPrivateNetworkSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecForProviderSettingsIpConfigurationPscConfig
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
public partial class V1beta1DatabaseInstanceSpecForProviderSettingsIpConfiguration
{
    /// <summary>The name of the allocated ip range for the private ip CloudSQL instance. For example: "google-managed-services-default". If set, the instance ip will be created in the allocated range. The range name must comply with RFC 1035. Specifically, the name must be 1-63 characters long and match the regular expression a-z?.</summary>
    [JsonPropertyName("allocatedIpRange")]
    public string? AllocatedIpRange { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authorizedNetworks")]
    public IList<V1beta1DatabaseInstanceSpecForProviderSettingsIpConfigurationAuthorizedNetworks>? AuthorizedNetworks { get; set; }

    /// <summary>Whether Google Cloud services such as BigQuery are allowed to access data in this Cloud SQL instance over a private IP connection. SQLSERVER database type is not supported.</summary>
    [JsonPropertyName("enablePrivatePathForGoogleCloudServices")]
    public bool? EnablePrivatePathForGoogleCloudServices { get; set; }

    /// <summary>Whether this Cloud SQL instance should be assigned a public IPV4 address. At least ipv4_enabled must be enabled or a private_network must be configured.</summary>
    [JsonPropertyName("ipv4Enabled")]
    public bool? Ipv4Enabled { get; set; }

    /// <summary>The VPC network from which the Cloud SQL instance is accessible for private IP. For example, projects/myProject/global/networks/default. Specifying a network enables private IP. At least ipv4_enabled must be enabled or a private_network must be configured. This setting can be updated, but it cannot be removed after it is set.</summary>
    [JsonPropertyName("privateNetwork")]
    public string? PrivateNetwork { get; set; }

    /// <summary>Reference to a Network in compute to populate privateNetwork.</summary>
    [JsonPropertyName("privateNetworkRef")]
    public V1beta1DatabaseInstanceSpecForProviderSettingsIpConfigurationPrivateNetworkRef? PrivateNetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate privateNetwork.</summary>
    [JsonPropertyName("privateNetworkSelector")]
    public V1beta1DatabaseInstanceSpecForProviderSettingsIpConfigurationPrivateNetworkSelector? PrivateNetworkSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pscConfig")]
    public IList<V1beta1DatabaseInstanceSpecForProviderSettingsIpConfigurationPscConfig>? PscConfig { get; set; }

    /// <summary>Whether SSL connections over IP are enforced or not. To change this field, also set the corresponding value in ssl_mode.</summary>
    [JsonPropertyName("requireSsl")]
    public bool? RequireSsl { get; set; }

    /// <summary>Specify how the server certificate's Certificate Authority is hosted. Supported value is GOOGLE_MANAGED_INTERNAL_CA.</summary>
    [JsonPropertyName("serverCaMode")]
    public string? ServerCaMode { get; set; }

    /// <summary>Specify how SSL connection should be enforced in DB connections. This field provides more SSL enforcment options compared to require_ssl. To change this field, also set the correspoding value in require_ssl.</summary>
    [JsonPropertyName("sslMode")]
    public string? SslMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecForProviderSettingsLocationPreference
{
    /// <summary>A GAE application whose zone to remain in. Must be in the same region as this instance.</summary>
    [JsonPropertyName("followGaeApplication")]
    public string? FollowGaeApplication { get; set; }

    /// <summary>The preferred Compute Engine zone for the secondary/failover.</summary>
    [JsonPropertyName("secondaryZone")]
    public string? SecondaryZone { get; set; }

    /// <summary>The preferred compute engine zone.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecForProviderSettingsMaintenanceWindow
{
    /// <summary>Day of week (1-7), starting on Monday</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Hour of day (0-23), ignored if day not set</summary>
    [JsonPropertyName("hour")]
    public double? Hour { get; set; }

    /// <summary>Receive updates earlier (canary) or later (stable)</summary>
    [JsonPropertyName("updateTrack")]
    public string? UpdateTrack { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecForProviderSettingsPasswordValidationPolicy
{
    /// <summary>Checks if the password is a combination of lowercase, uppercase, numeric, and non-alphanumeric characters.</summary>
    [JsonPropertyName("complexity")]
    public string? Complexity { get; set; }

    /// <summary>Prevents the use of the username in the password.</summary>
    [JsonPropertyName("disallowUsernameSubstring")]
    public bool? DisallowUsernameSubstring { get; set; }

    /// <summary>Enables or disable the password validation policy.</summary>
    [JsonPropertyName("enablePasswordPolicy")]
    public bool? EnablePasswordPolicy { get; set; }

    /// <summary>Specifies the minimum number of characters that the password must have.</summary>
    [JsonPropertyName("minLength")]
    public double? MinLength { get; set; }

    /// <summary>Specifies the minimum duration after which you can change the password.</summary>
    [JsonPropertyName("passwordChangeInterval")]
    public string? PasswordChangeInterval { get; set; }

    /// <summary>Specifies the number of previous passwords that you can't reuse.</summary>
    [JsonPropertyName("reuseInterval")]
    public double? ReuseInterval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecForProviderSettingsSqlServerAuditConfig
{
    /// <summary>The name of the destination bucket (e.g., gs://mybucket).</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>How long to keep generated audit files. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("retentionInterval")]
    public string? RetentionInterval { get; set; }

    /// <summary>How often to upload generated audit files. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("uploadInterval")]
    public string? UploadInterval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecForProviderSettings
{
    /// <summary>This specifies when the instance should be active. Can be either ALWAYS, NEVER or ON_DEMAND.</summary>
    [JsonPropertyName("activationPolicy")]
    public string? ActivationPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("activeDirectoryConfig")]
    public IList<V1beta1DatabaseInstanceSpecForProviderSettingsActiveDirectoryConfig>? ActiveDirectoryConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("advancedMachineFeatures")]
    public IList<V1beta1DatabaseInstanceSpecForProviderSettingsAdvancedMachineFeatures>? AdvancedMachineFeatures { get; set; }

    /// <summary>The availability type of the Cloud SQL instance, high availability (REGIONAL) or single zone (ZONAL).' For all instances, ensure that settings.backup_configuration.enabled is set to true. For MySQL instances, ensure that settings.backup_configuration.binary_log_enabled is set to true. For Postgres and SQL Server instances, ensure that settings.backup_configuration.point_in_time_recovery_enabled is set to true. Defaults to ZONAL.</summary>
    [JsonPropertyName("availabilityType")]
    public string? AvailabilityType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backupConfiguration")]
    public IList<V1beta1DatabaseInstanceSpecForProviderSettingsBackupConfiguration>? BackupConfiguration { get; set; }

    /// <summary>The name of server instance collation.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>Specifies if connections must use Cloud SQL connectors.</summary>
    [JsonPropertyName("connectorEnforcement")]
    public string? ConnectorEnforcement { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataCacheConfig")]
    public IList<V1beta1DatabaseInstanceSpecForProviderSettingsDataCacheConfig>? DataCacheConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("databaseFlags")]
    public IList<V1beta1DatabaseInstanceSpecForProviderSettingsDatabaseFlags>? DatabaseFlags { get; set; }

    /// <summary>.</summary>
    [JsonPropertyName("deletionProtectionEnabled")]
    public bool? DeletionProtectionEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("denyMaintenancePeriod")]
    public IList<V1beta1DatabaseInstanceSpecForProviderSettingsDenyMaintenancePeriod>? DenyMaintenancePeriod { get; set; }

    /// <summary>Enables auto-resizing of the storage size. Defaults to true.</summary>
    [JsonPropertyName("diskAutoresize")]
    public bool? DiskAutoresize { get; set; }

    /// <summary>The maximum size to which storage capacity can be automatically increased. The default value is 0, which specifies that there is no limit.</summary>
    [JsonPropertyName("diskAutoresizeLimit")]
    public double? DiskAutoresizeLimit { get; set; }

    /// <summary>The size of data disk, in GB. Size of a running instance cannot be reduced but can be increased. The minimum value is 10GB.</summary>
    [JsonPropertyName("diskSize")]
    public double? DiskSize { get; set; }

    /// <summary>The type of data disk: PD_SSD or PD_HDD. Defaults to PD_SSD.</summary>
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    /// <summary>The edition of the instance, can be ENTERPRISE or ENTERPRISE_PLUS.</summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    /// <summary>Enables Cloud SQL instance integration with Dataplex. MySQL, Postgres and SQL Server instances are supported for this feature. Defaults to false.</summary>
    [JsonPropertyName("enableDataplexIntegration")]
    public bool? EnableDataplexIntegration { get; set; }

    /// <summary>Enables Cloud SQL instances to connect to Vertex AI and pass requests for real-time predictions and insights. Defaults to false.</summary>
    [JsonPropertyName("enableGoogleMlIntegration")]
    public bool? EnableGoogleMlIntegration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("insightsConfig")]
    public IList<V1beta1DatabaseInstanceSpecForProviderSettingsInsightsConfig>? InsightsConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipConfiguration")]
    public IList<V1beta1DatabaseInstanceSpecForProviderSettingsIpConfiguration>? IpConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("locationPreference")]
    public IList<V1beta1DatabaseInstanceSpecForProviderSettingsLocationPreference>? LocationPreference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maintenanceWindow")]
    public IList<V1beta1DatabaseInstanceSpecForProviderSettingsMaintenanceWindow>? MaintenanceWindow { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passwordValidationPolicy")]
    public IList<V1beta1DatabaseInstanceSpecForProviderSettingsPasswordValidationPolicy>? PasswordValidationPolicy { get; set; }

    /// <summary>Pricing plan for this instance, can only be PER_USE.</summary>
    [JsonPropertyName("pricingPlan")]
    public string? PricingPlan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sqlServerAuditConfig")]
    public IList<V1beta1DatabaseInstanceSpecForProviderSettingsSqlServerAuditConfig>? SqlServerAuditConfig { get; set; }

    /// <summary>The machine type to use. See tiers for more details and supported versions. Postgres supports only shared-core machine types, and custom machine types such as db-custom-2-13312. See the Custom Machine Type Documentation to learn about specifying custom machine types.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>The time_zone to be used by the database engine (supported only for SQL Server), in SQL Server timezone format.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>A set of key/value user label pairs to assign to the instance.</summary>
    [JsonPropertyName("userLabels")]
    public IDictionary<string, string>? UserLabels { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecForProvider
{
    /// <summary>The context needed to create this instance as a clone of another instance. The configuration is detailed below.</summary>
    [JsonPropertyName("clone")]
    public IList<V1beta1DatabaseInstanceSpecForProviderClone>? Clone { get; set; }

    /// <summary>The MySQL, PostgreSQL or SQL Server version to use. Supported values include MYSQL_5_6, MYSQL_5_7, MYSQL_8_0, POSTGRES_9_6,POSTGRES_10, POSTGRES_11, POSTGRES_12, POSTGRES_13, POSTGRES_14, POSTGRES_15, SQLSERVER_2017_STANDARD, SQLSERVER_2017_ENTERPRISE, SQLSERVER_2017_EXPRESS, SQLSERVER_2017_WEB. SQLSERVER_2019_STANDARD, SQLSERVER_2019_ENTERPRISE, SQLSERVER_2019_EXPRESS, SQLSERVER_2019_WEB. Database Version Policies includes an up-to-date reference of supported versions.</summary>
    [JsonPropertyName("databaseVersion")]
    public string? DatabaseVersion { get; set; }

    /// <summary>Defaults to true.</summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>The full path to the encryption key used for the CMEK disk encryption. The provided key must be in the same region as the SQL instance.  In order to use this feature, a special kind of service account must be created and granted permission on this key.  This step can currently only be done manually, please see this step. That service account needs the Cloud KMS &gt; Cloud KMS CryptoKey Encrypter/Decrypter role on your key - please see this step.</summary>
    [JsonPropertyName("encryptionKeyName")]
    public string? EncryptionKeyName { get; set; }

    /// <summary>The current software version on the instance. This attribute can not be set during creation. Refer to available_maintenance_versions attribute to see what maintenance_version are available for upgrade. When this attribute gets updated, it will cause an instance restart. Setting a maintenance_version value that is older than the current one on the instance will be ignored.</summary>
    [JsonPropertyName("maintenanceVersion")]
    public string? MaintenanceVersion { get; set; }

    /// <summary>The name of the existing instance that will act as the master in the replication setup. Note, this requires the master to have binary_log_enabled set, as well as existing backups.</summary>
    [JsonPropertyName("masterInstanceName")]
    public string? MasterInstanceName { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region the instance will sit in. If a region is not provided in the resource definition, the provider region will be used instead.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The configuration for replication. The configuration is detailed below. Valid only for MySQL instances.</summary>
    [JsonPropertyName("replicaConfiguration")]
    public IList<V1beta1DatabaseInstanceSpecForProviderReplicaConfiguration>? ReplicaConfiguration { get; set; }

    /// <summary>The context needed to restore the database to a backup run. The configuration is detailed below. Adding or modifying this block during resource creation/update will trigger the restore action after the resource is created/updated.</summary>
    [JsonPropertyName("restoreBackupContext")]
    public IList<V1beta1DatabaseInstanceSpecForProviderRestoreBackupContext>? RestoreBackupContext { get; set; }

    /// <summary>Initial root password. Can be updated. Required for MS SQL Server.</summary>
    [JsonPropertyName("rootPasswordSecretRef")]
    public V1beta1DatabaseInstanceSpecForProviderRootPasswordSecretRef? RootPasswordSecretRef { get; set; }

    /// <summary>The settings to use for the database. The configuration is detailed below. Required if clone is not set.</summary>
    [JsonPropertyName("settings")]
    public IList<V1beta1DatabaseInstanceSpecForProviderSettings>? Settings { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecInitProviderClone
{
    /// <summary>The name of the allocated ip range for the private ip CloudSQL instance. For example: "google-managed-services-default". If set, the cloned instance ip will be created in the allocated range. The range name must comply with RFC 1035. Specifically, the name must be 1-63 characters long and match the regular expression a-z?.</summary>
    [JsonPropertyName("allocatedIpRange")]
    public string? AllocatedIpRange { get; set; }

    /// <summary>(SQL Server only, use with point_in_time) Clone only the specified databases from the source instance. Clone all databases if empty.</summary>
    [JsonPropertyName("databaseNames")]
    public IList<string>? DatabaseNames { get; set; }

    /// <summary>The timestamp of the point in time that should be restored.</summary>
    [JsonPropertyName("pointInTime")]
    public string? PointInTime { get; set; }

    /// <summary>(Point-in-time recovery for PostgreSQL only) Clone to an instance in the specified zone. If no zone is specified, clone to the same zone as the source instance. clone-unavailable-instance</summary>
    [JsonPropertyName("preferredZone")]
    public string? PreferredZone { get; set; }

    /// <summary>Name of the source instance which will be cloned.</summary>
    [JsonPropertyName("sourceInstanceName")]
    public string? SourceInstanceName { get; set; }
}

/// <summary>Password for the replication connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecInitProviderReplicaConfigurationPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecInitProviderReplicaConfiguration
{
    /// <summary>PEM representation of the trusted CA's x509 certificate.</summary>
    [JsonPropertyName("caCertificate")]
    public string? CaCertificate { get; set; }

    /// <summary>PEM representation of the replica's x509 certificate.</summary>
    [JsonPropertyName("clientCertificate")]
    public string? ClientCertificate { get; set; }

    /// <summary>PEM representation of the replica's private key. The corresponding public key in encoded in the client_certificate.</summary>
    [JsonPropertyName("clientKey")]
    public string? ClientKey { get; set; }

    /// <summary>The number of seconds between connect retries. MySQL's default is 60 seconds.</summary>
    [JsonPropertyName("connectRetryInterval")]
    public double? ConnectRetryInterval { get; set; }

    /// <summary>Path to a SQL file in GCS from which replica instances are created. Format is gs://bucket/filename.</summary>
    [JsonPropertyName("dumpFilePath")]
    public string? DumpFilePath { get; set; }

    /// <summary>Specifies if the replica is the failover target. If the field is set to true the replica will be designated as a failover replica. If the master instance fails, the replica instance will be promoted as the new master instance. ~&gt; NOTE: Not supported for Postgres database.</summary>
    [JsonPropertyName("failoverTarget")]
    public bool? FailoverTarget { get; set; }

    /// <summary>Time in ms between replication heartbeats.</summary>
    [JsonPropertyName("masterHeartbeatPeriod")]
    public double? MasterHeartbeatPeriod { get; set; }

    /// <summary>Password for the replication connection.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1DatabaseInstanceSpecInitProviderReplicaConfigurationPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>Permissible ciphers for use in SSL encryption.</summary>
    [JsonPropertyName("sslCipher")]
    public string? SslCipher { get; set; }

    /// <summary>Username for replication connection.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>True if the master's common name value is checked during the SSL handshake.</summary>
    [JsonPropertyName("verifyServerCertificate")]
    public bool? VerifyServerCertificate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecInitProviderRestoreBackupContext
{
    /// <summary>The ID of the backup run to restore from.</summary>
    [JsonPropertyName("backupRunId")]
    public double? BackupRunId { get; set; }

    /// <summary>The ID of the instance that the backup was taken from. If left empty, this instance's ID will be used.</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    /// <summary>The full project ID of the source instance.`</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

/// <summary>Initial root password. Can be updated. Required for MS SQL Server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecInitProviderRootPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecInitProviderSettingsActiveDirectoryConfig
{
    /// <summary>The domain name for the active directory (e.g., mydomain.com). Can only be used with SQL Server.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecInitProviderSettingsAdvancedMachineFeatures
{
    /// <summary>The number of threads per core. The value of this flag can be 1 or 2. To disable SMT, set this flag to 1. Only available in Cloud SQL for SQL Server instances. See smt for more details.</summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecInitProviderSettingsBackupConfigurationBackupRetentionSettings
{
    /// <summary>Depending on the value of retention_unit, this is used to determine if a backup needs to be deleted. If retention_unit is 'COUNT', we will retain this many backups.</summary>
    [JsonPropertyName("retainedBackups")]
    public double? RetainedBackups { get; set; }

    /// <summary>The unit that 'retained_backups' represents. Defaults to COUNT.</summary>
    [JsonPropertyName("retentionUnit")]
    public string? RetentionUnit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecInitProviderSettingsBackupConfiguration
{
    /// <summary>Backup retention settings. The configuration is detailed below.</summary>
    [JsonPropertyName("backupRetentionSettings")]
    public IList<V1beta1DatabaseInstanceSpecInitProviderSettingsBackupConfigurationBackupRetentionSettings>? BackupRetentionSettings { get; set; }

    /// <summary>True if binary logging is enabled. Can only be used with MySQL.</summary>
    [JsonPropertyName("binaryLogEnabled")]
    public bool? BinaryLogEnabled { get; set; }

    /// <summary>True if backup configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The region where the backup will be stored</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>True if Point-in-time recovery is enabled. Will restart database if enabled after instance creation. Valid only for PostgreSQL and SQL Server instances.</summary>
    [JsonPropertyName("pointInTimeRecoveryEnabled")]
    public bool? PointInTimeRecoveryEnabled { get; set; }

    /// <summary>HH:MM format time indicating when backup configuration starts.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>The number of days of transaction logs we retain for point in time restore, from 1-7. For PostgreSQL Enterprise Plus instances, the number of days of retained transaction logs can be set from 1 to 35.</summary>
    [JsonPropertyName("transactionLogRetentionDays")]
    public double? TransactionLogRetentionDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecInitProviderSettingsDataCacheConfig
{
    /// <summary>Whether data cache is enabled for the instance. Defaults to false. Can be used with MYSQL and PostgreSQL only.</summary>
    [JsonPropertyName("dataCacheEnabled")]
    public bool? DataCacheEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecInitProviderSettingsDatabaseFlags
{
    /// <summary>A name for this whitelist entry.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A CIDR notation IPv4 or IPv6 address that is allowed to access this instance. Must be set even if other two attributes are not for the whitelist to become active.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecInitProviderSettingsDenyMaintenancePeriod
{
    /// <summary>"deny maintenance period" end date. If the year of the end date is empty, the year of the start date also must be empty. In this case, it means the no maintenance interval recurs every year. The date is in format yyyy-mm-dd i.e., 2020-11-01, or mm-dd, i.e., 11-01</summary>
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    /// <summary>"deny maintenance period" start date. If the year of the start date is empty, the year of the end date also must be empty. In this case, it means the deny maintenance period recurs every year. The date is in format yyyy-mm-dd i.e., 2020-11-01, or mm-dd, i.e., 11-01</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }

    /// <summary>Time in UTC when the "deny maintenance period" starts on startDate and ends on endDate. The time is in format: HH:mm:SS, i.e., 00:00:00</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecInitProviderSettingsInsightsConfig
{
    /// <summary>True if Query Insights feature is enabled.</summary>
    [JsonPropertyName("queryInsightsEnabled")]
    public bool? QueryInsightsEnabled { get; set; }

    /// <summary>Number of query execution plans captured by Insights per minute for all queries combined. Between 0 and 20. Default to 5.</summary>
    [JsonPropertyName("queryPlansPerMinute")]
    public double? QueryPlansPerMinute { get; set; }

    /// <summary>Maximum query length stored in bytes. Between 256 and 4500. Default to 1024. Higher query lengths are more useful for analytical queries, but they also require more memory. Changing the query length requires you to restart the instance. You can still add tags to queries that exceed the length limit.</summary>
    [JsonPropertyName("queryStringLength")]
    public double? QueryStringLength { get; set; }

    /// <summary>True if Query Insights will record application tags from query when enabled.</summary>
    [JsonPropertyName("recordApplicationTags")]
    public bool? RecordApplicationTags { get; set; }

    /// <summary>True if Query Insights will record client address when enabled.</summary>
    [JsonPropertyName("recordClientAddress")]
    public bool? RecordClientAddress { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecInitProviderSettingsIpConfigurationAuthorizedNetworks
{
    /// <summary>The RFC 3339 formatted date time string indicating when this whitelist expires.</summary>
    [JsonPropertyName("expirationTime")]
    public string? ExpirationTime { get; set; }

    /// <summary>A name for this whitelist entry.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A CIDR notation IPv4 or IPv6 address that is allowed to access this instance. Must be set even if other two attributes are not for the whitelist to become active.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecInitProviderSettingsIpConfigurationPrivateNetworkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate privateNetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecInitProviderSettingsIpConfigurationPrivateNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatabaseInstanceSpecInitProviderSettingsIpConfigurationPrivateNetworkRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecInitProviderSettingsIpConfigurationPrivateNetworkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate privateNetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecInitProviderSettingsIpConfigurationPrivateNetworkSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatabaseInstanceSpecInitProviderSettingsIpConfigurationPrivateNetworkSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecInitProviderSettingsIpConfigurationPscConfig
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
public partial class V1beta1DatabaseInstanceSpecInitProviderSettingsIpConfiguration
{
    /// <summary>The name of the allocated ip range for the private ip CloudSQL instance. For example: "google-managed-services-default". If set, the instance ip will be created in the allocated range. The range name must comply with RFC 1035. Specifically, the name must be 1-63 characters long and match the regular expression a-z?.</summary>
    [JsonPropertyName("allocatedIpRange")]
    public string? AllocatedIpRange { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authorizedNetworks")]
    public IList<V1beta1DatabaseInstanceSpecInitProviderSettingsIpConfigurationAuthorizedNetworks>? AuthorizedNetworks { get; set; }

    /// <summary>Whether Google Cloud services such as BigQuery are allowed to access data in this Cloud SQL instance over a private IP connection. SQLSERVER database type is not supported.</summary>
    [JsonPropertyName("enablePrivatePathForGoogleCloudServices")]
    public bool? EnablePrivatePathForGoogleCloudServices { get; set; }

    /// <summary>Whether this Cloud SQL instance should be assigned a public IPV4 address. At least ipv4_enabled must be enabled or a private_network must be configured.</summary>
    [JsonPropertyName("ipv4Enabled")]
    public bool? Ipv4Enabled { get; set; }

    /// <summary>The VPC network from which the Cloud SQL instance is accessible for private IP. For example, projects/myProject/global/networks/default. Specifying a network enables private IP. At least ipv4_enabled must be enabled or a private_network must be configured. This setting can be updated, but it cannot be removed after it is set.</summary>
    [JsonPropertyName("privateNetwork")]
    public string? PrivateNetwork { get; set; }

    /// <summary>Reference to a Network in compute to populate privateNetwork.</summary>
    [JsonPropertyName("privateNetworkRef")]
    public V1beta1DatabaseInstanceSpecInitProviderSettingsIpConfigurationPrivateNetworkRef? PrivateNetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate privateNetwork.</summary>
    [JsonPropertyName("privateNetworkSelector")]
    public V1beta1DatabaseInstanceSpecInitProviderSettingsIpConfigurationPrivateNetworkSelector? PrivateNetworkSelector { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pscConfig")]
    public IList<V1beta1DatabaseInstanceSpecInitProviderSettingsIpConfigurationPscConfig>? PscConfig { get; set; }

    /// <summary>Whether SSL connections over IP are enforced or not. To change this field, also set the corresponding value in ssl_mode.</summary>
    [JsonPropertyName("requireSsl")]
    public bool? RequireSsl { get; set; }

    /// <summary>Specify how the server certificate's Certificate Authority is hosted. Supported value is GOOGLE_MANAGED_INTERNAL_CA.</summary>
    [JsonPropertyName("serverCaMode")]
    public string? ServerCaMode { get; set; }

    /// <summary>Specify how SSL connection should be enforced in DB connections. This field provides more SSL enforcment options compared to require_ssl. To change this field, also set the correspoding value in require_ssl.</summary>
    [JsonPropertyName("sslMode")]
    public string? SslMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecInitProviderSettingsLocationPreference
{
    /// <summary>A GAE application whose zone to remain in. Must be in the same region as this instance.</summary>
    [JsonPropertyName("followGaeApplication")]
    public string? FollowGaeApplication { get; set; }

    /// <summary>The preferred Compute Engine zone for the secondary/failover.</summary>
    [JsonPropertyName("secondaryZone")]
    public string? SecondaryZone { get; set; }

    /// <summary>The preferred compute engine zone.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecInitProviderSettingsMaintenanceWindow
{
    /// <summary>Day of week (1-7), starting on Monday</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Hour of day (0-23), ignored if day not set</summary>
    [JsonPropertyName("hour")]
    public double? Hour { get; set; }

    /// <summary>Receive updates earlier (canary) or later (stable)</summary>
    [JsonPropertyName("updateTrack")]
    public string? UpdateTrack { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecInitProviderSettingsPasswordValidationPolicy
{
    /// <summary>Checks if the password is a combination of lowercase, uppercase, numeric, and non-alphanumeric characters.</summary>
    [JsonPropertyName("complexity")]
    public string? Complexity { get; set; }

    /// <summary>Prevents the use of the username in the password.</summary>
    [JsonPropertyName("disallowUsernameSubstring")]
    public bool? DisallowUsernameSubstring { get; set; }

    /// <summary>Enables or disable the password validation policy.</summary>
    [JsonPropertyName("enablePasswordPolicy")]
    public bool? EnablePasswordPolicy { get; set; }

    /// <summary>Specifies the minimum number of characters that the password must have.</summary>
    [JsonPropertyName("minLength")]
    public double? MinLength { get; set; }

    /// <summary>Specifies the minimum duration after which you can change the password.</summary>
    [JsonPropertyName("passwordChangeInterval")]
    public string? PasswordChangeInterval { get; set; }

    /// <summary>Specifies the number of previous passwords that you can't reuse.</summary>
    [JsonPropertyName("reuseInterval")]
    public double? ReuseInterval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecInitProviderSettingsSqlServerAuditConfig
{
    /// <summary>The name of the destination bucket (e.g., gs://mybucket).</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>How long to keep generated audit files. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("retentionInterval")]
    public string? RetentionInterval { get; set; }

    /// <summary>How often to upload generated audit files. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("uploadInterval")]
    public string? UploadInterval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecInitProviderSettings
{
    /// <summary>This specifies when the instance should be active. Can be either ALWAYS, NEVER or ON_DEMAND.</summary>
    [JsonPropertyName("activationPolicy")]
    public string? ActivationPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("activeDirectoryConfig")]
    public IList<V1beta1DatabaseInstanceSpecInitProviderSettingsActiveDirectoryConfig>? ActiveDirectoryConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("advancedMachineFeatures")]
    public IList<V1beta1DatabaseInstanceSpecInitProviderSettingsAdvancedMachineFeatures>? AdvancedMachineFeatures { get; set; }

    /// <summary>The availability type of the Cloud SQL instance, high availability (REGIONAL) or single zone (ZONAL).' For all instances, ensure that settings.backup_configuration.enabled is set to true. For MySQL instances, ensure that settings.backup_configuration.binary_log_enabled is set to true. For Postgres and SQL Server instances, ensure that settings.backup_configuration.point_in_time_recovery_enabled is set to true. Defaults to ZONAL.</summary>
    [JsonPropertyName("availabilityType")]
    public string? AvailabilityType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backupConfiguration")]
    public IList<V1beta1DatabaseInstanceSpecInitProviderSettingsBackupConfiguration>? BackupConfiguration { get; set; }

    /// <summary>The name of server instance collation.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>Specifies if connections must use Cloud SQL connectors.</summary>
    [JsonPropertyName("connectorEnforcement")]
    public string? ConnectorEnforcement { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataCacheConfig")]
    public IList<V1beta1DatabaseInstanceSpecInitProviderSettingsDataCacheConfig>? DataCacheConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("databaseFlags")]
    public IList<V1beta1DatabaseInstanceSpecInitProviderSettingsDatabaseFlags>? DatabaseFlags { get; set; }

    /// <summary>.</summary>
    [JsonPropertyName("deletionProtectionEnabled")]
    public bool? DeletionProtectionEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("denyMaintenancePeriod")]
    public IList<V1beta1DatabaseInstanceSpecInitProviderSettingsDenyMaintenancePeriod>? DenyMaintenancePeriod { get; set; }

    /// <summary>Enables auto-resizing of the storage size. Defaults to true.</summary>
    [JsonPropertyName("diskAutoresize")]
    public bool? DiskAutoresize { get; set; }

    /// <summary>The maximum size to which storage capacity can be automatically increased. The default value is 0, which specifies that there is no limit.</summary>
    [JsonPropertyName("diskAutoresizeLimit")]
    public double? DiskAutoresizeLimit { get; set; }

    /// <summary>The size of data disk, in GB. Size of a running instance cannot be reduced but can be increased. The minimum value is 10GB.</summary>
    [JsonPropertyName("diskSize")]
    public double? DiskSize { get; set; }

    /// <summary>The type of data disk: PD_SSD or PD_HDD. Defaults to PD_SSD.</summary>
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    /// <summary>The edition of the instance, can be ENTERPRISE or ENTERPRISE_PLUS.</summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    /// <summary>Enables Cloud SQL instance integration with Dataplex. MySQL, Postgres and SQL Server instances are supported for this feature. Defaults to false.</summary>
    [JsonPropertyName("enableDataplexIntegration")]
    public bool? EnableDataplexIntegration { get; set; }

    /// <summary>Enables Cloud SQL instances to connect to Vertex AI and pass requests for real-time predictions and insights. Defaults to false.</summary>
    [JsonPropertyName("enableGoogleMlIntegration")]
    public bool? EnableGoogleMlIntegration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("insightsConfig")]
    public IList<V1beta1DatabaseInstanceSpecInitProviderSettingsInsightsConfig>? InsightsConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipConfiguration")]
    public IList<V1beta1DatabaseInstanceSpecInitProviderSettingsIpConfiguration>? IpConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("locationPreference")]
    public IList<V1beta1DatabaseInstanceSpecInitProviderSettingsLocationPreference>? LocationPreference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maintenanceWindow")]
    public IList<V1beta1DatabaseInstanceSpecInitProviderSettingsMaintenanceWindow>? MaintenanceWindow { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passwordValidationPolicy")]
    public IList<V1beta1DatabaseInstanceSpecInitProviderSettingsPasswordValidationPolicy>? PasswordValidationPolicy { get; set; }

    /// <summary>Pricing plan for this instance, can only be PER_USE.</summary>
    [JsonPropertyName("pricingPlan")]
    public string? PricingPlan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sqlServerAuditConfig")]
    public IList<V1beta1DatabaseInstanceSpecInitProviderSettingsSqlServerAuditConfig>? SqlServerAuditConfig { get; set; }

    /// <summary>The machine type to use. See tiers for more details and supported versions. Postgres supports only shared-core machine types, and custom machine types such as db-custom-2-13312. See the Custom Machine Type Documentation to learn about specifying custom machine types.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>The time_zone to be used by the database engine (supported only for SQL Server), in SQL Server timezone format.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>A set of key/value user label pairs to assign to the instance.</summary>
    [JsonPropertyName("userLabels")]
    public IDictionary<string, string>? UserLabels { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecInitProvider
{
    /// <summary>The context needed to create this instance as a clone of another instance. The configuration is detailed below.</summary>
    [JsonPropertyName("clone")]
    public IList<V1beta1DatabaseInstanceSpecInitProviderClone>? Clone { get; set; }

    /// <summary>The MySQL, PostgreSQL or SQL Server version to use. Supported values include MYSQL_5_6, MYSQL_5_7, MYSQL_8_0, POSTGRES_9_6,POSTGRES_10, POSTGRES_11, POSTGRES_12, POSTGRES_13, POSTGRES_14, POSTGRES_15, SQLSERVER_2017_STANDARD, SQLSERVER_2017_ENTERPRISE, SQLSERVER_2017_EXPRESS, SQLSERVER_2017_WEB. SQLSERVER_2019_STANDARD, SQLSERVER_2019_ENTERPRISE, SQLSERVER_2019_EXPRESS, SQLSERVER_2019_WEB. Database Version Policies includes an up-to-date reference of supported versions.</summary>
    [JsonPropertyName("databaseVersion")]
    public string? DatabaseVersion { get; set; }

    /// <summary>Defaults to true.</summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>The full path to the encryption key used for the CMEK disk encryption. The provided key must be in the same region as the SQL instance.  In order to use this feature, a special kind of service account must be created and granted permission on this key.  This step can currently only be done manually, please see this step. That service account needs the Cloud KMS &gt; Cloud KMS CryptoKey Encrypter/Decrypter role on your key - please see this step.</summary>
    [JsonPropertyName("encryptionKeyName")]
    public string? EncryptionKeyName { get; set; }

    /// <summary>The current software version on the instance. This attribute can not be set during creation. Refer to available_maintenance_versions attribute to see what maintenance_version are available for upgrade. When this attribute gets updated, it will cause an instance restart. Setting a maintenance_version value that is older than the current one on the instance will be ignored.</summary>
    [JsonPropertyName("maintenanceVersion")]
    public string? MaintenanceVersion { get; set; }

    /// <summary>The name of the existing instance that will act as the master in the replication setup. Note, this requires the master to have binary_log_enabled set, as well as existing backups.</summary>
    [JsonPropertyName("masterInstanceName")]
    public string? MasterInstanceName { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region the instance will sit in. If a region is not provided in the resource definition, the provider region will be used instead.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The configuration for replication. The configuration is detailed below. Valid only for MySQL instances.</summary>
    [JsonPropertyName("replicaConfiguration")]
    public IList<V1beta1DatabaseInstanceSpecInitProviderReplicaConfiguration>? ReplicaConfiguration { get; set; }

    /// <summary>The context needed to restore the database to a backup run. The configuration is detailed below. Adding or modifying this block during resource creation/update will trigger the restore action after the resource is created/updated.</summary>
    [JsonPropertyName("restoreBackupContext")]
    public IList<V1beta1DatabaseInstanceSpecInitProviderRestoreBackupContext>? RestoreBackupContext { get; set; }

    /// <summary>Initial root password. Can be updated. Required for MS SQL Server.</summary>
    [JsonPropertyName("rootPasswordSecretRef")]
    public V1beta1DatabaseInstanceSpecInitProviderRootPasswordSecretRef? RootPasswordSecretRef { get; set; }

    /// <summary>The settings to use for the database. The configuration is detailed below. Required if clone is not set.</summary>
    [JsonPropertyName("settings")]
    public IList<V1beta1DatabaseInstanceSpecInitProviderSettings>? Settings { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecProviderConfigRefPolicy
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
public partial class V1beta1DatabaseInstanceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatabaseInstanceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1DatabaseInstanceSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DatabaseInstanceSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1DatabaseInstanceSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1DatabaseInstanceSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1DatabaseInstanceSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>DatabaseInstanceSpec defines the desired state of DatabaseInstance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1DatabaseInstanceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1DatabaseInstanceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DatabaseInstanceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1DatabaseInstanceSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DatabaseInstanceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceStatusAtProviderClone
{
    /// <summary>The name of the allocated ip range for the private ip CloudSQL instance. For example: "google-managed-services-default". If set, the cloned instance ip will be created in the allocated range. The range name must comply with RFC 1035. Specifically, the name must be 1-63 characters long and match the regular expression a-z?.</summary>
    [JsonPropertyName("allocatedIpRange")]
    public string? AllocatedIpRange { get; set; }

    /// <summary>(SQL Server only, use with point_in_time) Clone only the specified databases from the source instance. Clone all databases if empty.</summary>
    [JsonPropertyName("databaseNames")]
    public IList<string>? DatabaseNames { get; set; }

    /// <summary>The timestamp of the point in time that should be restored.</summary>
    [JsonPropertyName("pointInTime")]
    public string? PointInTime { get; set; }

    /// <summary>(Point-in-time recovery for PostgreSQL only) Clone to an instance in the specified zone. If no zone is specified, clone to the same zone as the source instance. clone-unavailable-instance</summary>
    [JsonPropertyName("preferredZone")]
    public string? PreferredZone { get; set; }

    /// <summary>Name of the source instance which will be cloned.</summary>
    [JsonPropertyName("sourceInstanceName")]
    public string? SourceInstanceName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceStatusAtProviderIpAddress
{
    /// <summary>The IPv4 address assigned.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The time this IP address will be retired, in RFC 3339 format.</summary>
    [JsonPropertyName("timeToRetire")]
    public string? TimeToRetire { get; set; }

    /// <summary>The type of this IP address.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceStatusAtProviderReplicaConfiguration
{
    /// <summary>PEM representation of the trusted CA's x509 certificate.</summary>
    [JsonPropertyName("caCertificate")]
    public string? CaCertificate { get; set; }

    /// <summary>PEM representation of the replica's x509 certificate.</summary>
    [JsonPropertyName("clientCertificate")]
    public string? ClientCertificate { get; set; }

    /// <summary>PEM representation of the replica's private key. The corresponding public key in encoded in the client_certificate.</summary>
    [JsonPropertyName("clientKey")]
    public string? ClientKey { get; set; }

    /// <summary>The number of seconds between connect retries. MySQL's default is 60 seconds.</summary>
    [JsonPropertyName("connectRetryInterval")]
    public double? ConnectRetryInterval { get; set; }

    /// <summary>Path to a SQL file in GCS from which replica instances are created. Format is gs://bucket/filename.</summary>
    [JsonPropertyName("dumpFilePath")]
    public string? DumpFilePath { get; set; }

    /// <summary>Specifies if the replica is the failover target. If the field is set to true the replica will be designated as a failover replica. If the master instance fails, the replica instance will be promoted as the new master instance. ~&gt; NOTE: Not supported for Postgres database.</summary>
    [JsonPropertyName("failoverTarget")]
    public bool? FailoverTarget { get; set; }

    /// <summary>Time in ms between replication heartbeats.</summary>
    [JsonPropertyName("masterHeartbeatPeriod")]
    public double? MasterHeartbeatPeriod { get; set; }

    /// <summary>Permissible ciphers for use in SSL encryption.</summary>
    [JsonPropertyName("sslCipher")]
    public string? SslCipher { get; set; }

    /// <summary>Username for replication connection.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>True if the master's common name value is checked during the SSL handshake.</summary>
    [JsonPropertyName("verifyServerCertificate")]
    public bool? VerifyServerCertificate { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceStatusAtProviderRestoreBackupContext
{
    /// <summary>The ID of the backup run to restore from.</summary>
    [JsonPropertyName("backupRunId")]
    public double? BackupRunId { get; set; }

    /// <summary>The ID of the instance that the backup was taken from. If left empty, this instance's ID will be used.</summary>
    [JsonPropertyName("instanceId")]
    public string? InstanceId { get; set; }

    /// <summary>The full project ID of the source instance.`</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceStatusAtProviderSettingsActiveDirectoryConfig
{
    /// <summary>The domain name for the active directory (e.g., mydomain.com). Can only be used with SQL Server.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceStatusAtProviderSettingsAdvancedMachineFeatures
{
    /// <summary>The number of threads per core. The value of this flag can be 1 or 2. To disable SMT, set this flag to 1. Only available in Cloud SQL for SQL Server instances. See smt for more details.</summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceStatusAtProviderSettingsBackupConfigurationBackupRetentionSettings
{
    /// <summary>Depending on the value of retention_unit, this is used to determine if a backup needs to be deleted. If retention_unit is 'COUNT', we will retain this many backups.</summary>
    [JsonPropertyName("retainedBackups")]
    public double? RetainedBackups { get; set; }

    /// <summary>The unit that 'retained_backups' represents. Defaults to COUNT.</summary>
    [JsonPropertyName("retentionUnit")]
    public string? RetentionUnit { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceStatusAtProviderSettingsBackupConfiguration
{
    /// <summary>Backup retention settings. The configuration is detailed below.</summary>
    [JsonPropertyName("backupRetentionSettings")]
    public IList<V1beta1DatabaseInstanceStatusAtProviderSettingsBackupConfigurationBackupRetentionSettings>? BackupRetentionSettings { get; set; }

    /// <summary>True if binary logging is enabled. Can only be used with MySQL.</summary>
    [JsonPropertyName("binaryLogEnabled")]
    public bool? BinaryLogEnabled { get; set; }

    /// <summary>True if backup configuration is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The region where the backup will be stored</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>True if Point-in-time recovery is enabled. Will restart database if enabled after instance creation. Valid only for PostgreSQL and SQL Server instances.</summary>
    [JsonPropertyName("pointInTimeRecoveryEnabled")]
    public bool? PointInTimeRecoveryEnabled { get; set; }

    /// <summary>HH:MM format time indicating when backup configuration starts.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>The number of days of transaction logs we retain for point in time restore, from 1-7. For PostgreSQL Enterprise Plus instances, the number of days of retained transaction logs can be set from 1 to 35.</summary>
    [JsonPropertyName("transactionLogRetentionDays")]
    public double? TransactionLogRetentionDays { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceStatusAtProviderSettingsDataCacheConfig
{
    /// <summary>Whether data cache is enabled for the instance. Defaults to false. Can be used with MYSQL and PostgreSQL only.</summary>
    [JsonPropertyName("dataCacheEnabled")]
    public bool? DataCacheEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceStatusAtProviderSettingsDatabaseFlags
{
    /// <summary>A name for this whitelist entry.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A CIDR notation IPv4 or IPv6 address that is allowed to access this instance. Must be set even if other two attributes are not for the whitelist to become active.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceStatusAtProviderSettingsDenyMaintenancePeriod
{
    /// <summary>"deny maintenance period" end date. If the year of the end date is empty, the year of the start date also must be empty. In this case, it means the no maintenance interval recurs every year. The date is in format yyyy-mm-dd i.e., 2020-11-01, or mm-dd, i.e., 11-01</summary>
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    /// <summary>"deny maintenance period" start date. If the year of the start date is empty, the year of the end date also must be empty. In this case, it means the deny maintenance period recurs every year. The date is in format yyyy-mm-dd i.e., 2020-11-01, or mm-dd, i.e., 11-01</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }

    /// <summary>Time in UTC when the "deny maintenance period" starts on startDate and ends on endDate. The time is in format: HH:mm:SS, i.e., 00:00:00</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceStatusAtProviderSettingsInsightsConfig
{
    /// <summary>True if Query Insights feature is enabled.</summary>
    [JsonPropertyName("queryInsightsEnabled")]
    public bool? QueryInsightsEnabled { get; set; }

    /// <summary>Number of query execution plans captured by Insights per minute for all queries combined. Between 0 and 20. Default to 5.</summary>
    [JsonPropertyName("queryPlansPerMinute")]
    public double? QueryPlansPerMinute { get; set; }

    /// <summary>Maximum query length stored in bytes. Between 256 and 4500. Default to 1024. Higher query lengths are more useful for analytical queries, but they also require more memory. Changing the query length requires you to restart the instance. You can still add tags to queries that exceed the length limit.</summary>
    [JsonPropertyName("queryStringLength")]
    public double? QueryStringLength { get; set; }

    /// <summary>True if Query Insights will record application tags from query when enabled.</summary>
    [JsonPropertyName("recordApplicationTags")]
    public bool? RecordApplicationTags { get; set; }

    /// <summary>True if Query Insights will record client address when enabled.</summary>
    [JsonPropertyName("recordClientAddress")]
    public bool? RecordClientAddress { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceStatusAtProviderSettingsIpConfigurationAuthorizedNetworks
{
    /// <summary>The RFC 3339 formatted date time string indicating when this whitelist expires.</summary>
    [JsonPropertyName("expirationTime")]
    public string? ExpirationTime { get; set; }

    /// <summary>A name for this whitelist entry.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A CIDR notation IPv4 or IPv6 address that is allowed to access this instance. Must be set even if other two attributes are not for the whitelist to become active.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceStatusAtProviderSettingsIpConfigurationPscConfig
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
public partial class V1beta1DatabaseInstanceStatusAtProviderSettingsIpConfiguration
{
    /// <summary>The name of the allocated ip range for the private ip CloudSQL instance. For example: "google-managed-services-default". If set, the instance ip will be created in the allocated range. The range name must comply with RFC 1035. Specifically, the name must be 1-63 characters long and match the regular expression a-z?.</summary>
    [JsonPropertyName("allocatedIpRange")]
    public string? AllocatedIpRange { get; set; }

    /// <summary></summary>
    [JsonPropertyName("authorizedNetworks")]
    public IList<V1beta1DatabaseInstanceStatusAtProviderSettingsIpConfigurationAuthorizedNetworks>? AuthorizedNetworks { get; set; }

    /// <summary>Whether Google Cloud services such as BigQuery are allowed to access data in this Cloud SQL instance over a private IP connection. SQLSERVER database type is not supported.</summary>
    [JsonPropertyName("enablePrivatePathForGoogleCloudServices")]
    public bool? EnablePrivatePathForGoogleCloudServices { get; set; }

    /// <summary>Whether this Cloud SQL instance should be assigned a public IPV4 address. At least ipv4_enabled must be enabled or a private_network must be configured.</summary>
    [JsonPropertyName("ipv4Enabled")]
    public bool? Ipv4Enabled { get; set; }

    /// <summary>The VPC network from which the Cloud SQL instance is accessible for private IP. For example, projects/myProject/global/networks/default. Specifying a network enables private IP. At least ipv4_enabled must be enabled or a private_network must be configured. This setting can be updated, but it cannot be removed after it is set.</summary>
    [JsonPropertyName("privateNetwork")]
    public string? PrivateNetwork { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pscConfig")]
    public IList<V1beta1DatabaseInstanceStatusAtProviderSettingsIpConfigurationPscConfig>? PscConfig { get; set; }

    /// <summary>Whether SSL connections over IP are enforced or not. To change this field, also set the corresponding value in ssl_mode.</summary>
    [JsonPropertyName("requireSsl")]
    public bool? RequireSsl { get; set; }

    /// <summary>Specify how the server certificate's Certificate Authority is hosted. Supported value is GOOGLE_MANAGED_INTERNAL_CA.</summary>
    [JsonPropertyName("serverCaMode")]
    public string? ServerCaMode { get; set; }

    /// <summary>Specify how SSL connection should be enforced in DB connections. This field provides more SSL enforcment options compared to require_ssl. To change this field, also set the correspoding value in require_ssl.</summary>
    [JsonPropertyName("sslMode")]
    public string? SslMode { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceStatusAtProviderSettingsLocationPreference
{
    /// <summary>A GAE application whose zone to remain in. Must be in the same region as this instance.</summary>
    [JsonPropertyName("followGaeApplication")]
    public string? FollowGaeApplication { get; set; }

    /// <summary>The preferred Compute Engine zone for the secondary/failover.</summary>
    [JsonPropertyName("secondaryZone")]
    public string? SecondaryZone { get; set; }

    /// <summary>The preferred compute engine zone.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceStatusAtProviderSettingsMaintenanceWindow
{
    /// <summary>Day of week (1-7), starting on Monday</summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Hour of day (0-23), ignored if day not set</summary>
    [JsonPropertyName("hour")]
    public double? Hour { get; set; }

    /// <summary>Receive updates earlier (canary) or later (stable)</summary>
    [JsonPropertyName("updateTrack")]
    public string? UpdateTrack { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceStatusAtProviderSettingsPasswordValidationPolicy
{
    /// <summary>Checks if the password is a combination of lowercase, uppercase, numeric, and non-alphanumeric characters.</summary>
    [JsonPropertyName("complexity")]
    public string? Complexity { get; set; }

    /// <summary>Prevents the use of the username in the password.</summary>
    [JsonPropertyName("disallowUsernameSubstring")]
    public bool? DisallowUsernameSubstring { get; set; }

    /// <summary>Enables or disable the password validation policy.</summary>
    [JsonPropertyName("enablePasswordPolicy")]
    public bool? EnablePasswordPolicy { get; set; }

    /// <summary>Specifies the minimum number of characters that the password must have.</summary>
    [JsonPropertyName("minLength")]
    public double? MinLength { get; set; }

    /// <summary>Specifies the minimum duration after which you can change the password.</summary>
    [JsonPropertyName("passwordChangeInterval")]
    public string? PasswordChangeInterval { get; set; }

    /// <summary>Specifies the number of previous passwords that you can't reuse.</summary>
    [JsonPropertyName("reuseInterval")]
    public double? ReuseInterval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceStatusAtProviderSettingsSqlServerAuditConfig
{
    /// <summary>The name of the destination bucket (e.g., gs://mybucket).</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>How long to keep generated audit files. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("retentionInterval")]
    public string? RetentionInterval { get; set; }

    /// <summary>How often to upload generated audit files. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("uploadInterval")]
    public string? UploadInterval { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceStatusAtProviderSettings
{
    /// <summary>This specifies when the instance should be active. Can be either ALWAYS, NEVER or ON_DEMAND.</summary>
    [JsonPropertyName("activationPolicy")]
    public string? ActivationPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("activeDirectoryConfig")]
    public IList<V1beta1DatabaseInstanceStatusAtProviderSettingsActiveDirectoryConfig>? ActiveDirectoryConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("advancedMachineFeatures")]
    public IList<V1beta1DatabaseInstanceStatusAtProviderSettingsAdvancedMachineFeatures>? AdvancedMachineFeatures { get; set; }

    /// <summary>The availability type of the Cloud SQL instance, high availability (REGIONAL) or single zone (ZONAL).' For all instances, ensure that settings.backup_configuration.enabled is set to true. For MySQL instances, ensure that settings.backup_configuration.binary_log_enabled is set to true. For Postgres and SQL Server instances, ensure that settings.backup_configuration.point_in_time_recovery_enabled is set to true. Defaults to ZONAL.</summary>
    [JsonPropertyName("availabilityType")]
    public string? AvailabilityType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backupConfiguration")]
    public IList<V1beta1DatabaseInstanceStatusAtProviderSettingsBackupConfiguration>? BackupConfiguration { get; set; }

    /// <summary>The name of server instance collation.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>Specifies if connections must use Cloud SQL connectors.</summary>
    [JsonPropertyName("connectorEnforcement")]
    public string? ConnectorEnforcement { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataCacheConfig")]
    public IList<V1beta1DatabaseInstanceStatusAtProviderSettingsDataCacheConfig>? DataCacheConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("databaseFlags")]
    public IList<V1beta1DatabaseInstanceStatusAtProviderSettingsDatabaseFlags>? DatabaseFlags { get; set; }

    /// <summary>.</summary>
    [JsonPropertyName("deletionProtectionEnabled")]
    public bool? DeletionProtectionEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("denyMaintenancePeriod")]
    public IList<V1beta1DatabaseInstanceStatusAtProviderSettingsDenyMaintenancePeriod>? DenyMaintenancePeriod { get; set; }

    /// <summary>Enables auto-resizing of the storage size. Defaults to true.</summary>
    [JsonPropertyName("diskAutoresize")]
    public bool? DiskAutoresize { get; set; }

    /// <summary>The maximum size to which storage capacity can be automatically increased. The default value is 0, which specifies that there is no limit.</summary>
    [JsonPropertyName("diskAutoresizeLimit")]
    public double? DiskAutoresizeLimit { get; set; }

    /// <summary>The size of data disk, in GB. Size of a running instance cannot be reduced but can be increased. The minimum value is 10GB.</summary>
    [JsonPropertyName("diskSize")]
    public double? DiskSize { get; set; }

    /// <summary>The type of data disk: PD_SSD or PD_HDD. Defaults to PD_SSD.</summary>
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    /// <summary>The edition of the instance, can be ENTERPRISE or ENTERPRISE_PLUS.</summary>
    [JsonPropertyName("edition")]
    public string? Edition { get; set; }

    /// <summary>Enables Cloud SQL instance integration with Dataplex. MySQL, Postgres and SQL Server instances are supported for this feature. Defaults to false.</summary>
    [JsonPropertyName("enableDataplexIntegration")]
    public bool? EnableDataplexIntegration { get; set; }

    /// <summary>Enables Cloud SQL instances to connect to Vertex AI and pass requests for real-time predictions and insights. Defaults to false.</summary>
    [JsonPropertyName("enableGoogleMlIntegration")]
    public bool? EnableGoogleMlIntegration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("insightsConfig")]
    public IList<V1beta1DatabaseInstanceStatusAtProviderSettingsInsightsConfig>? InsightsConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipConfiguration")]
    public IList<V1beta1DatabaseInstanceStatusAtProviderSettingsIpConfiguration>? IpConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("locationPreference")]
    public IList<V1beta1DatabaseInstanceStatusAtProviderSettingsLocationPreference>? LocationPreference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maintenanceWindow")]
    public IList<V1beta1DatabaseInstanceStatusAtProviderSettingsMaintenanceWindow>? MaintenanceWindow { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passwordValidationPolicy")]
    public IList<V1beta1DatabaseInstanceStatusAtProviderSettingsPasswordValidationPolicy>? PasswordValidationPolicy { get; set; }

    /// <summary>Pricing plan for this instance, can only be PER_USE.</summary>
    [JsonPropertyName("pricingPlan")]
    public string? PricingPlan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sqlServerAuditConfig")]
    public IList<V1beta1DatabaseInstanceStatusAtProviderSettingsSqlServerAuditConfig>? SqlServerAuditConfig { get; set; }

    /// <summary>The machine type to use. See tiers for more details and supported versions. Postgres supports only shared-core machine types, and custom machine types such as db-custom-2-13312. See the Custom Machine Type Documentation to learn about specifying custom machine types.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>The time_zone to be used by the database engine (supported only for SQL Server), in SQL Server timezone format.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>A set of key/value user label pairs to assign to the instance.</summary>
    [JsonPropertyName("userLabels")]
    public IDictionary<string, string>? UserLabels { get; set; }

    /// <summary>Used to make sure changes to the settings block are atomic.</summary>
    [JsonPropertyName("version")]
    public double? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceStatusAtProvider
{
    /// <summary>The list of all maintenance versions applicable on the instance.</summary>
    [JsonPropertyName("availableMaintenanceVersions")]
    public IList<string>? AvailableMaintenanceVersions { get; set; }

    /// <summary>The context needed to create this instance as a clone of another instance. The configuration is detailed below.</summary>
    [JsonPropertyName("clone")]
    public IList<V1beta1DatabaseInstanceStatusAtProviderClone>? Clone { get; set; }

    /// <summary>The connection name of the instance to be used in connection strings. For example, when connecting with Cloud SQL Proxy.</summary>
    [JsonPropertyName("connectionName")]
    public string? ConnectionName { get; set; }

    /// <summary>The MySQL, PostgreSQL or SQL Server version to use. Supported values include MYSQL_5_6, MYSQL_5_7, MYSQL_8_0, POSTGRES_9_6,POSTGRES_10, POSTGRES_11, POSTGRES_12, POSTGRES_13, POSTGRES_14, POSTGRES_15, SQLSERVER_2017_STANDARD, SQLSERVER_2017_ENTERPRISE, SQLSERVER_2017_EXPRESS, SQLSERVER_2017_WEB. SQLSERVER_2019_STANDARD, SQLSERVER_2019_ENTERPRISE, SQLSERVER_2019_EXPRESS, SQLSERVER_2019_WEB. Database Version Policies includes an up-to-date reference of supported versions.</summary>
    [JsonPropertyName("databaseVersion")]
    public string? DatabaseVersion { get; set; }

    /// <summary>Defaults to true.</summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>The name of the instance. This is done because after a name is used, it cannot be reused for up to one week.</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>The full path to the encryption key used for the CMEK disk encryption. The provided key must be in the same region as the SQL instance.  In order to use this feature, a special kind of service account must be created and granted permission on this key.  This step can currently only be done manually, please see this step. That service account needs the Cloud KMS &gt; Cloud KMS CryptoKey Encrypter/Decrypter role on your key - please see this step.</summary>
    [JsonPropertyName("encryptionKeyName")]
    public string? EncryptionKeyName { get; set; }

    /// <summary>The first IPv4 address of any type assigned.</summary>
    [JsonPropertyName("firstIpAddress")]
    public string? FirstIpAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The type of the instance. The supported values are SQL_INSTANCE_TYPE_UNSPECIFIED, CLOUD_SQL_INSTANCE, ON_PREMISES_INSTANCE and READ_REPLICA_INSTANCE.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The IPv4 address assigned.</summary>
    [JsonPropertyName("ipAddress")]
    public IList<V1beta1DatabaseInstanceStatusAtProviderIpAddress>? IpAddress { get; set; }

    /// <summary>The current software version on the instance. This attribute can not be set during creation. Refer to available_maintenance_versions attribute to see what maintenance_version are available for upgrade. When this attribute gets updated, it will cause an instance restart. Setting a maintenance_version value that is older than the current one on the instance will be ignored.</summary>
    [JsonPropertyName("maintenanceVersion")]
    public string? MaintenanceVersion { get; set; }

    /// <summary>The name of the existing instance that will act as the master in the replication setup. Note, this requires the master to have binary_log_enabled set, as well as existing backups.</summary>
    [JsonPropertyName("masterInstanceName")]
    public string? MasterInstanceName { get; set; }

    /// <summary>The first private (PRIVATE) IPv4 address assigned.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>the URI that points to the service attachment of the instance.</summary>
    [JsonPropertyName("pscServiceAttachmentLink")]
    public string? PscServiceAttachmentLink { get; set; }

    /// <summary>The first public (PRIMARY) IPv4 address assigned.</summary>
    [JsonPropertyName("publicIpAddress")]
    public string? PublicIpAddress { get; set; }

    /// <summary>The region the instance will sit in. If a region is not provided in the resource definition, the provider region will be used instead.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The configuration for replication. The configuration is detailed below. Valid only for MySQL instances.</summary>
    [JsonPropertyName("replicaConfiguration")]
    public IList<V1beta1DatabaseInstanceStatusAtProviderReplicaConfiguration>? ReplicaConfiguration { get; set; }

    /// <summary>The context needed to restore the database to a backup run. The configuration is detailed below. Adding or modifying this block during resource creation/update will trigger the restore action after the resource is created/updated.</summary>
    [JsonPropertyName("restoreBackupContext")]
    public IList<V1beta1DatabaseInstanceStatusAtProviderRestoreBackupContext>? RestoreBackupContext { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>The service account email address assigned to the instance.</summary>
    [JsonPropertyName("serviceAccountEmailAddress")]
    public string? ServiceAccountEmailAddress { get; set; }

    /// <summary>The settings to use for the database. The configuration is detailed below. Required if clone is not set.</summary>
    [JsonPropertyName("settings")]
    public IList<V1beta1DatabaseInstanceStatusAtProviderSettings>? Settings { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceStatusConditions
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

/// <summary>DatabaseInstanceStatus defines the observed state of DatabaseInstance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DatabaseInstanceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1DatabaseInstanceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DatabaseInstanceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>DatabaseInstance is the Schema for the DatabaseInstances API. Creates a new SQL database instance in Google Cloud SQL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DatabaseInstance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DatabaseInstanceSpec>, IStatus<V1beta1DatabaseInstanceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DatabaseInstance";
    public const string KubeGroup = "sql.gcp.upbound.io";
    public const string KubePluralName = "databaseinstances";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DatabaseInstanceSpec defines the desired state of DatabaseInstance</summary>
    [JsonPropertyName("spec")]
    public V1beta1DatabaseInstanceSpec Spec { get; set; }

    /// <summary>DatabaseInstanceStatus defines the observed state of DatabaseInstance.</summary>
    [JsonPropertyName("status")]
    public V1beta1DatabaseInstanceStatus? Status { get; set; }
}