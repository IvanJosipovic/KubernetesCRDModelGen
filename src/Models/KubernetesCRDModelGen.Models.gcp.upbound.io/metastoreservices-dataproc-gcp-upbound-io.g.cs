using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataproc.gcp.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecForProviderEncryptionConfigKmsKeyRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CryptoKey in kms to populate kmsKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecForProviderEncryptionConfigKmsKeyRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MetastoreServiceSpecForProviderEncryptionConfigKmsKeyRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecForProviderEncryptionConfigKmsKeySelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CryptoKey in kms to populate kmsKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecForProviderEncryptionConfigKmsKeySelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MetastoreServiceSpecForProviderEncryptionConfigKmsKeySelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecForProviderEncryptionConfig
{
    /// <summary>The fully qualified customer provided Cloud KMS key name to use for customer data encryption. Use the following format: projects/([^/]+)/locations/([^/]+)/keyRings/([^/]+)/cryptoKeys/([^/]+)</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>Reference to a CryptoKey in kms to populate kmsKey.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1MetastoreServiceSpecForProviderEncryptionConfigKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>Selector for a CryptoKey in kms to populate kmsKey.</summary>
    [JsonPropertyName("kmsKeySelector")]
    public V1beta1MetastoreServiceSpecForProviderEncryptionConfigKmsKeySelector? KmsKeySelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecForProviderHiveMetastoreConfigAuxiliaryVersions
{
    /// <summary>A mapping of Hive metastore configuration key-value pairs to apply to the Hive metastore (configured in hive-site.xml). The mappings override system defaults (some keys cannot be overridden)</summary>
    [JsonPropertyName("configOverrides")]
    public IDictionary<string, string>? ConfigOverrides { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The Hive metastore schema version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecForProviderHiveMetastoreConfigKerberosConfigKeytab
{
    /// <summary>The relative resource name of a Secret Manager secret version, in the following form: "projects/{projectNumber}/secrets/{secret_id}/versions/{version_id}".</summary>
    [JsonPropertyName("cloudSecret")]
    public string? CloudSecret { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecForProviderHiveMetastoreConfigKerberosConfig
{
    /// <summary>A Kerberos keytab file that can be used to authenticate a service principal with a Kerberos Key Distribution Center (KDC). Structure is documented below.</summary>
    [JsonPropertyName("keytab")]
    public IList<V1beta1MetastoreServiceSpecForProviderHiveMetastoreConfigKerberosConfigKeytab>? Keytab { get; set; }

    /// <summary>A Cloud Storage URI that specifies the path to a krb5.conf file. It is of the form gs://{bucket_name}/path/to/krb5.conf, although the file does not need to be named krb5.conf explicitly.</summary>
    [JsonPropertyName("krb5ConfigGcsUri")]
    public string? Krb5ConfigGcsUri { get; set; }

    /// <summary>A Kerberos principal that exists in the both the keytab the KDC to authenticate as. A typical principal is of the form "primary/instance@REALM", but there is no exact format.</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecForProviderHiveMetastoreConfig
{
    /// <summary>A mapping of Hive metastore version to the auxiliary version configuration. When specified, a secondary Hive metastore service is created along with the primary service. All auxiliary versions must be less than the service's primary version. The key is the auxiliary service name and it must match the regular expression a-z?. This means that the first character must be a lowercase letter, and all the following characters must be hyphens, lowercase letters, or digits, except the last character, which cannot be a hyphen. Structure is documented below.</summary>
    [JsonPropertyName("auxiliaryVersions")]
    public IList<V1beta1MetastoreServiceSpecForProviderHiveMetastoreConfigAuxiliaryVersions>? AuxiliaryVersions { get; set; }

    /// <summary>A mapping of Hive metastore configuration key-value pairs to apply to the Hive metastore (configured in hive-site.xml). The mappings override system defaults (some keys cannot be overridden)</summary>
    [JsonPropertyName("configOverrides")]
    public IDictionary<string, string>? ConfigOverrides { get; set; }

    /// <summary>The protocol to use for the metastore service endpoint. If unspecified, defaults to THRIFT. Default value is THRIFT. Possible values are: THRIFT, GRPC.</summary>
    [JsonPropertyName("endpointProtocol")]
    public string? EndpointProtocol { get; set; }

    /// <summary>Information used to configure the Hive metastore service as a service principal in a Kerberos realm. Structure is documented below.</summary>
    [JsonPropertyName("kerberosConfig")]
    public IList<V1beta1MetastoreServiceSpecForProviderHiveMetastoreConfigKerberosConfig>? KerberosConfig { get; set; }

    /// <summary>The Hive metastore schema version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecForProviderMaintenanceWindow
{
    /// <summary>The day of week, when the window starts. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>The hour of day (0-23) when the window starts.</summary>
    [JsonPropertyName("hourOfDay")]
    public double? HourOfDay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecForProviderMetadataIntegrationDataCatalogConfig
{
    /// <summary>Defines whether the metastore metadata should be synced to Data Catalog. The default value is to disable syncing metastore metadata to Data Catalog.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecForProviderMetadataIntegration
{
    /// <summary>The integration config for the Data Catalog service. Structure is documented below.</summary>
    [JsonPropertyName("dataCatalogConfig")]
    public IList<V1beta1MetastoreServiceSpecForProviderMetadataIntegrationDataCatalogConfig>? DataCatalogConfig { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecForProviderNetworkConfigConsumersSubnetworkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecForProviderNetworkConfigConsumersSubnetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MetastoreServiceSpecForProviderNetworkConfigConsumersSubnetworkRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecForProviderNetworkConfigConsumersSubnetworkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecForProviderNetworkConfigConsumersSubnetworkSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MetastoreServiceSpecForProviderNetworkConfigConsumersSubnetworkSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecForProviderNetworkConfigConsumers
{
    /// <summary>The subnetwork of the customer project from which an IP address is reserved and used as the Dataproc Metastore service's endpoint. It is accessible to hosts in the subnet and to all hosts in a subnet in the same region and same network. There must be at least one IP address available in the subnet's primary range. The subnet is specified in the following form: `projects/{projectNumber}/regions/{region_id}/subnetworks/{subnetwork_id}</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta1MetastoreServiceSpecForProviderNetworkConfigConsumersSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkSelector")]
    public V1beta1MetastoreServiceSpecForProviderNetworkConfigConsumersSubnetworkSelector? SubnetworkSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecForProviderNetworkConfig
{
    /// <summary>The consumer-side network configuration for the Dataproc Metastore instance. Structure is documented below.</summary>
    [JsonPropertyName("consumers")]
    public IList<V1beta1MetastoreServiceSpecForProviderNetworkConfigConsumers>? Consumers { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecForProviderScalingConfigAutoscalingConfigLimitConfig
{
    /// <summary>The maximum scaling factor that the service will autoscale to. The default value is 6.0.</summary>
    [JsonPropertyName("maxScalingFactor")]
    public double? MaxScalingFactor { get; set; }

    /// <summary>The minimum scaling factor that the service will autoscale to. The default value is 0.1.</summary>
    [JsonPropertyName("minScalingFactor")]
    public double? MinScalingFactor { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecForProviderScalingConfigAutoscalingConfig
{
    /// <summary>Defines whether autoscaling is enabled. The default value is false.</summary>
    [JsonPropertyName("autoscalingEnabled")]
    public bool? AutoscalingEnabled { get; set; }

    /// <summary>Represents the limit configuration of a metastore service. Structure is documented below.</summary>
    [JsonPropertyName("limitConfig")]
    public IList<V1beta1MetastoreServiceSpecForProviderScalingConfigAutoscalingConfigLimitConfig>? LimitConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecForProviderScalingConfig
{
    /// <summary>Represents the autoscaling configuration of a metastore service. Structure is documented below.</summary>
    [JsonPropertyName("autoscalingConfig")]
    public IList<V1beta1MetastoreServiceSpecForProviderScalingConfigAutoscalingConfig>? AutoscalingConfig { get; set; }

    /// <summary>Metastore instance sizes. Possible values are: EXTRA_SMALL, SMALL, MEDIUM, LARGE, EXTRA_LARGE.</summary>
    [JsonPropertyName("instanceSize")]
    public string? InstanceSize { get; set; }

    /// <summary>Scaling factor, in increments of 0.1 for values less than 1.0, and increments of 1.0 for values greater than 1.0.</summary>
    [JsonPropertyName("scalingFactor")]
    public double? ScalingFactor { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecForProviderScheduledBackup
{
    /// <summary>A Cloud Storage URI of a folder, in the format gs://&lt;bucket_name&gt;/&lt;path_inside_bucket&gt;. A sub-folder &lt;backup_folder&gt; containing backup files will be stored below it.</summary>
    [JsonPropertyName("backupLocation")]
    public string? BackupLocation { get; set; }

    /// <summary>The scheduled interval in Cron format, see https://en.wikipedia.org/wiki/Cron The default is empty: scheduled backup is not enabled. Must be specified to enable scheduled backups.</summary>
    [JsonPropertyName("cronSchedule")]
    public string? CronSchedule { get; set; }

    /// <summary>Defines whether the scheduled backup is enabled. The default value is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the time zone to be used when interpreting cronSchedule. Must be a time zone name from the time zone database (https://en.wikipedia.org/wiki/List_of_tz_database_time_zones), e.g. America/Los_Angeles or Africa/Abidjan. If left unspecified, the default is UTC.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecForProviderTelemetryConfig
{
    /// <summary>The output format of the Dataproc Metastore service's logs. Default value is JSON. Possible values are: LEGACY, JSON.</summary>
    [JsonPropertyName("logFormat")]
    public string? LogFormat { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecForProvider
{
    /// <summary>The database type that the Metastore service stores its data. Default value is MYSQL. Possible values are: MYSQL, SPANNER.</summary>
    [JsonPropertyName("databaseType")]
    public string? DatabaseType { get; set; }

    /// <summary>Indicates if the dataproc metastore should be protected against accidental deletions.</summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>Information used to configure the Dataproc Metastore service to encrypt customer data at rest. Structure is documented below.</summary>
    [JsonPropertyName("encryptionConfig")]
    public IList<V1beta1MetastoreServiceSpecForProviderEncryptionConfig>? EncryptionConfig { get; set; }

    /// <summary>Configuration information specific to running Hive metastore software as the metastore service. Structure is documented below.</summary>
    [JsonPropertyName("hiveMetastoreConfig")]
    public IList<V1beta1MetastoreServiceSpecForProviderHiveMetastoreConfig>? HiveMetastoreConfig { get; set; }

    /// <summary>User-defined labels for the metastore service. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location where the metastore service should reside. The default value is global.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The one hour maintenance window of the metastore service. This specifies when the service can be restarted for maintenance purposes in UTC time. Maintenance window is not needed for services with the SPANNER database type. Structure is documented below.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public IList<V1beta1MetastoreServiceSpecForProviderMaintenanceWindow>? MaintenanceWindow { get; set; }

    /// <summary>The setting that defines how metastore metadata should be integrated with external services and systems. Structure is documented below.</summary>
    [JsonPropertyName("metadataIntegration")]
    public IList<V1beta1MetastoreServiceSpecForProviderMetadataIntegration>? MetadataIntegration { get; set; }

    /// <summary>The relative resource name of the VPC network on which the instance can be accessed. It is specified in the following form: "projects/{projectNumber}/global/networks/{network_id}".</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>The configuration specifying the network settings for the Dataproc Metastore service. Structure is documented below.</summary>
    [JsonPropertyName("networkConfig")]
    public IList<V1beta1MetastoreServiceSpecForProviderNetworkConfig>? NetworkConfig { get; set; }

    /// <summary>The TCP port at which the metastore service is reached. Default: 9083.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The release channel of the service. If unspecified, defaults to STABLE. Default value is STABLE. Possible values are: CANARY, STABLE.</summary>
    [JsonPropertyName("releaseChannel")]
    public string? ReleaseChannel { get; set; }

    /// <summary>Represents the scaling configuration of a metastore service. Structure is documented below.</summary>
    [JsonPropertyName("scalingConfig")]
    public IList<V1beta1MetastoreServiceSpecForProviderScalingConfig>? ScalingConfig { get; set; }

    /// <summary>The configuration of scheduled backup for the metastore service. Structure is documented below.</summary>
    [JsonPropertyName("scheduledBackup")]
    public IList<V1beta1MetastoreServiceSpecForProviderScheduledBackup>? ScheduledBackup { get; set; }

    /// <summary>The configuration specifying telemetry settings for the Dataproc Metastore service. If unspecified defaults to JSON. Structure is documented below.</summary>
    [JsonPropertyName("telemetryConfig")]
    public IList<V1beta1MetastoreServiceSpecForProviderTelemetryConfig>? TelemetryConfig { get; set; }

    /// <summary>The tier of the service. Possible values are: DEVELOPER, ENTERPRISE.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecInitProviderEncryptionConfigKmsKeyRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a CryptoKey in kms to populate kmsKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecInitProviderEncryptionConfigKmsKeyRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MetastoreServiceSpecInitProviderEncryptionConfigKmsKeyRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecInitProviderEncryptionConfigKmsKeySelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a CryptoKey in kms to populate kmsKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecInitProviderEncryptionConfigKmsKeySelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MetastoreServiceSpecInitProviderEncryptionConfigKmsKeySelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecInitProviderEncryptionConfig
{
    /// <summary>The fully qualified customer provided Cloud KMS key name to use for customer data encryption. Use the following format: projects/([^/]+)/locations/([^/]+)/keyRings/([^/]+)/cryptoKeys/([^/]+)</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>Reference to a CryptoKey in kms to populate kmsKey.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1MetastoreServiceSpecInitProviderEncryptionConfigKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>Selector for a CryptoKey in kms to populate kmsKey.</summary>
    [JsonPropertyName("kmsKeySelector")]
    public V1beta1MetastoreServiceSpecInitProviderEncryptionConfigKmsKeySelector? KmsKeySelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecInitProviderHiveMetastoreConfigAuxiliaryVersions
{
    /// <summary>A mapping of Hive metastore configuration key-value pairs to apply to the Hive metastore (configured in hive-site.xml). The mappings override system defaults (some keys cannot be overridden)</summary>
    [JsonPropertyName("configOverrides")]
    public IDictionary<string, string>? ConfigOverrides { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The Hive metastore schema version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecInitProviderHiveMetastoreConfigKerberosConfigKeytab
{
    /// <summary>The relative resource name of a Secret Manager secret version, in the following form: "projects/{projectNumber}/secrets/{secret_id}/versions/{version_id}".</summary>
    [JsonPropertyName("cloudSecret")]
    public string? CloudSecret { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecInitProviderHiveMetastoreConfigKerberosConfig
{
    /// <summary>A Kerberos keytab file that can be used to authenticate a service principal with a Kerberos Key Distribution Center (KDC). Structure is documented below.</summary>
    [JsonPropertyName("keytab")]
    public IList<V1beta1MetastoreServiceSpecInitProviderHiveMetastoreConfigKerberosConfigKeytab>? Keytab { get; set; }

    /// <summary>A Cloud Storage URI that specifies the path to a krb5.conf file. It is of the form gs://{bucket_name}/path/to/krb5.conf, although the file does not need to be named krb5.conf explicitly.</summary>
    [JsonPropertyName("krb5ConfigGcsUri")]
    public string? Krb5ConfigGcsUri { get; set; }

    /// <summary>A Kerberos principal that exists in the both the keytab the KDC to authenticate as. A typical principal is of the form "primary/instance@REALM", but there is no exact format.</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecInitProviderHiveMetastoreConfig
{
    /// <summary>A mapping of Hive metastore version to the auxiliary version configuration. When specified, a secondary Hive metastore service is created along with the primary service. All auxiliary versions must be less than the service's primary version. The key is the auxiliary service name and it must match the regular expression a-z?. This means that the first character must be a lowercase letter, and all the following characters must be hyphens, lowercase letters, or digits, except the last character, which cannot be a hyphen. Structure is documented below.</summary>
    [JsonPropertyName("auxiliaryVersions")]
    public IList<V1beta1MetastoreServiceSpecInitProviderHiveMetastoreConfigAuxiliaryVersions>? AuxiliaryVersions { get; set; }

    /// <summary>A mapping of Hive metastore configuration key-value pairs to apply to the Hive metastore (configured in hive-site.xml). The mappings override system defaults (some keys cannot be overridden)</summary>
    [JsonPropertyName("configOverrides")]
    public IDictionary<string, string>? ConfigOverrides { get; set; }

    /// <summary>The protocol to use for the metastore service endpoint. If unspecified, defaults to THRIFT. Default value is THRIFT. Possible values are: THRIFT, GRPC.</summary>
    [JsonPropertyName("endpointProtocol")]
    public string? EndpointProtocol { get; set; }

    /// <summary>Information used to configure the Hive metastore service as a service principal in a Kerberos realm. Structure is documented below.</summary>
    [JsonPropertyName("kerberosConfig")]
    public IList<V1beta1MetastoreServiceSpecInitProviderHiveMetastoreConfigKerberosConfig>? KerberosConfig { get; set; }

    /// <summary>The Hive metastore schema version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecInitProviderMaintenanceWindow
{
    /// <summary>The day of week, when the window starts. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>The hour of day (0-23) when the window starts.</summary>
    [JsonPropertyName("hourOfDay")]
    public double? HourOfDay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecInitProviderMetadataIntegrationDataCatalogConfig
{
    /// <summary>Defines whether the metastore metadata should be synced to Data Catalog. The default value is to disable syncing metastore metadata to Data Catalog.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecInitProviderMetadataIntegration
{
    /// <summary>The integration config for the Data Catalog service. Structure is documented below.</summary>
    [JsonPropertyName("dataCatalogConfig")]
    public IList<V1beta1MetastoreServiceSpecInitProviderMetadataIntegrationDataCatalogConfig>? DataCatalogConfig { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecInitProviderNetworkConfigConsumersSubnetworkRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecInitProviderNetworkConfigConsumersSubnetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MetastoreServiceSpecInitProviderNetworkConfigConsumersSubnetworkRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecInitProviderNetworkConfigConsumersSubnetworkSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecInitProviderNetworkConfigConsumersSubnetworkSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MetastoreServiceSpecInitProviderNetworkConfigConsumersSubnetworkSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecInitProviderNetworkConfigConsumers
{
    /// <summary>The subnetwork of the customer project from which an IP address is reserved and used as the Dataproc Metastore service's endpoint. It is accessible to hosts in the subnet and to all hosts in a subnet in the same region and same network. There must be at least one IP address available in the subnet's primary range. The subnet is specified in the following form: `projects/{projectNumber}/regions/{region_id}/subnetworks/{subnetwork_id}</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta1MetastoreServiceSpecInitProviderNetworkConfigConsumersSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkSelector")]
    public V1beta1MetastoreServiceSpecInitProviderNetworkConfigConsumersSubnetworkSelector? SubnetworkSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecInitProviderNetworkConfig
{
    /// <summary>The consumer-side network configuration for the Dataproc Metastore instance. Structure is documented below.</summary>
    [JsonPropertyName("consumers")]
    public IList<V1beta1MetastoreServiceSpecInitProviderNetworkConfigConsumers>? Consumers { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecInitProviderScalingConfigAutoscalingConfigLimitConfig
{
    /// <summary>The maximum scaling factor that the service will autoscale to. The default value is 6.0.</summary>
    [JsonPropertyName("maxScalingFactor")]
    public double? MaxScalingFactor { get; set; }

    /// <summary>The minimum scaling factor that the service will autoscale to. The default value is 0.1.</summary>
    [JsonPropertyName("minScalingFactor")]
    public double? MinScalingFactor { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecInitProviderScalingConfigAutoscalingConfig
{
    /// <summary>Defines whether autoscaling is enabled. The default value is false.</summary>
    [JsonPropertyName("autoscalingEnabled")]
    public bool? AutoscalingEnabled { get; set; }

    /// <summary>Represents the limit configuration of a metastore service. Structure is documented below.</summary>
    [JsonPropertyName("limitConfig")]
    public IList<V1beta1MetastoreServiceSpecInitProviderScalingConfigAutoscalingConfigLimitConfig>? LimitConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecInitProviderScalingConfig
{
    /// <summary>Represents the autoscaling configuration of a metastore service. Structure is documented below.</summary>
    [JsonPropertyName("autoscalingConfig")]
    public IList<V1beta1MetastoreServiceSpecInitProviderScalingConfigAutoscalingConfig>? AutoscalingConfig { get; set; }

    /// <summary>Metastore instance sizes. Possible values are: EXTRA_SMALL, SMALL, MEDIUM, LARGE, EXTRA_LARGE.</summary>
    [JsonPropertyName("instanceSize")]
    public string? InstanceSize { get; set; }

    /// <summary>Scaling factor, in increments of 0.1 for values less than 1.0, and increments of 1.0 for values greater than 1.0.</summary>
    [JsonPropertyName("scalingFactor")]
    public double? ScalingFactor { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecInitProviderScheduledBackup
{
    /// <summary>A Cloud Storage URI of a folder, in the format gs://&lt;bucket_name&gt;/&lt;path_inside_bucket&gt;. A sub-folder &lt;backup_folder&gt; containing backup files will be stored below it.</summary>
    [JsonPropertyName("backupLocation")]
    public string? BackupLocation { get; set; }

    /// <summary>The scheduled interval in Cron format, see https://en.wikipedia.org/wiki/Cron The default is empty: scheduled backup is not enabled. Must be specified to enable scheduled backups.</summary>
    [JsonPropertyName("cronSchedule")]
    public string? CronSchedule { get; set; }

    /// <summary>Defines whether the scheduled backup is enabled. The default value is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the time zone to be used when interpreting cronSchedule. Must be a time zone name from the time zone database (https://en.wikipedia.org/wiki/List_of_tz_database_time_zones), e.g. America/Los_Angeles or Africa/Abidjan. If left unspecified, the default is UTC.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecInitProviderTelemetryConfig
{
    /// <summary>The output format of the Dataproc Metastore service's logs. Default value is JSON. Possible values are: LEGACY, JSON.</summary>
    [JsonPropertyName("logFormat")]
    public string? LogFormat { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecInitProvider
{
    /// <summary>The database type that the Metastore service stores its data. Default value is MYSQL. Possible values are: MYSQL, SPANNER.</summary>
    [JsonPropertyName("databaseType")]
    public string? DatabaseType { get; set; }

    /// <summary>Indicates if the dataproc metastore should be protected against accidental deletions.</summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>Information used to configure the Dataproc Metastore service to encrypt customer data at rest. Structure is documented below.</summary>
    [JsonPropertyName("encryptionConfig")]
    public IList<V1beta1MetastoreServiceSpecInitProviderEncryptionConfig>? EncryptionConfig { get; set; }

    /// <summary>Configuration information specific to running Hive metastore software as the metastore service. Structure is documented below.</summary>
    [JsonPropertyName("hiveMetastoreConfig")]
    public IList<V1beta1MetastoreServiceSpecInitProviderHiveMetastoreConfig>? HiveMetastoreConfig { get; set; }

    /// <summary>User-defined labels for the metastore service. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The one hour maintenance window of the metastore service. This specifies when the service can be restarted for maintenance purposes in UTC time. Maintenance window is not needed for services with the SPANNER database type. Structure is documented below.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public IList<V1beta1MetastoreServiceSpecInitProviderMaintenanceWindow>? MaintenanceWindow { get; set; }

    /// <summary>The setting that defines how metastore metadata should be integrated with external services and systems. Structure is documented below.</summary>
    [JsonPropertyName("metadataIntegration")]
    public IList<V1beta1MetastoreServiceSpecInitProviderMetadataIntegration>? MetadataIntegration { get; set; }

    /// <summary>The relative resource name of the VPC network on which the instance can be accessed. It is specified in the following form: "projects/{projectNumber}/global/networks/{network_id}".</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>The configuration specifying the network settings for the Dataproc Metastore service. Structure is documented below.</summary>
    [JsonPropertyName("networkConfig")]
    public IList<V1beta1MetastoreServiceSpecInitProviderNetworkConfig>? NetworkConfig { get; set; }

    /// <summary>The TCP port at which the metastore service is reached. Default: 9083.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The release channel of the service. If unspecified, defaults to STABLE. Default value is STABLE. Possible values are: CANARY, STABLE.</summary>
    [JsonPropertyName("releaseChannel")]
    public string? ReleaseChannel { get; set; }

    /// <summary>Represents the scaling configuration of a metastore service. Structure is documented below.</summary>
    [JsonPropertyName("scalingConfig")]
    public IList<V1beta1MetastoreServiceSpecInitProviderScalingConfig>? ScalingConfig { get; set; }

    /// <summary>The configuration of scheduled backup for the metastore service. Structure is documented below.</summary>
    [JsonPropertyName("scheduledBackup")]
    public IList<V1beta1MetastoreServiceSpecInitProviderScheduledBackup>? ScheduledBackup { get; set; }

    /// <summary>The configuration specifying telemetry settings for the Dataproc Metastore service. If unspecified defaults to JSON. Structure is documented below.</summary>
    [JsonPropertyName("telemetryConfig")]
    public IList<V1beta1MetastoreServiceSpecInitProviderTelemetryConfig>? TelemetryConfig { get; set; }

    /// <summary>The tier of the service. Possible values are: DEVELOPER, ENTERPRISE.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecProviderConfigRefPolicy
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
public partial class V1beta1MetastoreServiceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MetastoreServiceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>MetastoreServiceSpec defines the desired state of MetastoreService</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1MetastoreServiceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1MetastoreServiceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MetastoreServiceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MetastoreServiceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceStatusAtProviderEncryptionConfig
{
    /// <summary>The fully qualified customer provided Cloud KMS key name to use for customer data encryption. Use the following format: projects/([^/]+)/locations/([^/]+)/keyRings/([^/]+)/cryptoKeys/([^/]+)</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceStatusAtProviderHiveMetastoreConfigAuxiliaryVersions
{
    /// <summary>A mapping of Hive metastore configuration key-value pairs to apply to the Hive metastore (configured in hive-site.xml). The mappings override system defaults (some keys cannot be overridden)</summary>
    [JsonPropertyName("configOverrides")]
    public IDictionary<string, string>? ConfigOverrides { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The Hive metastore schema version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceStatusAtProviderHiveMetastoreConfigKerberosConfigKeytab
{
    /// <summary>The relative resource name of a Secret Manager secret version, in the following form: "projects/{projectNumber}/secrets/{secret_id}/versions/{version_id}".</summary>
    [JsonPropertyName("cloudSecret")]
    public string? CloudSecret { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceStatusAtProviderHiveMetastoreConfigKerberosConfig
{
    /// <summary>A Kerberos keytab file that can be used to authenticate a service principal with a Kerberos Key Distribution Center (KDC). Structure is documented below.</summary>
    [JsonPropertyName("keytab")]
    public IList<V1beta1MetastoreServiceStatusAtProviderHiveMetastoreConfigKerberosConfigKeytab>? Keytab { get; set; }

    /// <summary>A Cloud Storage URI that specifies the path to a krb5.conf file. It is of the form gs://{bucket_name}/path/to/krb5.conf, although the file does not need to be named krb5.conf explicitly.</summary>
    [JsonPropertyName("krb5ConfigGcsUri")]
    public string? Krb5ConfigGcsUri { get; set; }

    /// <summary>A Kerberos principal that exists in the both the keytab the KDC to authenticate as. A typical principal is of the form "primary/instance@REALM", but there is no exact format.</summary>
    [JsonPropertyName("principal")]
    public string? Principal { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceStatusAtProviderHiveMetastoreConfig
{
    /// <summary>A mapping of Hive metastore version to the auxiliary version configuration. When specified, a secondary Hive metastore service is created along with the primary service. All auxiliary versions must be less than the service's primary version. The key is the auxiliary service name and it must match the regular expression a-z?. This means that the first character must be a lowercase letter, and all the following characters must be hyphens, lowercase letters, or digits, except the last character, which cannot be a hyphen. Structure is documented below.</summary>
    [JsonPropertyName("auxiliaryVersions")]
    public IList<V1beta1MetastoreServiceStatusAtProviderHiveMetastoreConfigAuxiliaryVersions>? AuxiliaryVersions { get; set; }

    /// <summary>A mapping of Hive metastore configuration key-value pairs to apply to the Hive metastore (configured in hive-site.xml). The mappings override system defaults (some keys cannot be overridden)</summary>
    [JsonPropertyName("configOverrides")]
    public IDictionary<string, string>? ConfigOverrides { get; set; }

    /// <summary>The protocol to use for the metastore service endpoint. If unspecified, defaults to THRIFT. Default value is THRIFT. Possible values are: THRIFT, GRPC.</summary>
    [JsonPropertyName("endpointProtocol")]
    public string? EndpointProtocol { get; set; }

    /// <summary>Information used to configure the Hive metastore service as a service principal in a Kerberos realm. Structure is documented below.</summary>
    [JsonPropertyName("kerberosConfig")]
    public IList<V1beta1MetastoreServiceStatusAtProviderHiveMetastoreConfigKerberosConfig>? KerberosConfig { get; set; }

    /// <summary>The Hive metastore schema version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceStatusAtProviderMaintenanceWindow
{
    /// <summary>The day of week, when the window starts. Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>The hour of day (0-23) when the window starts.</summary>
    [JsonPropertyName("hourOfDay")]
    public double? HourOfDay { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceStatusAtProviderMetadataIntegrationDataCatalogConfig
{
    /// <summary>Defines whether the metastore metadata should be synced to Data Catalog. The default value is to disable syncing metastore metadata to Data Catalog.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceStatusAtProviderMetadataIntegration
{
    /// <summary>The integration config for the Data Catalog service. Structure is documented below.</summary>
    [JsonPropertyName("dataCatalogConfig")]
    public IList<V1beta1MetastoreServiceStatusAtProviderMetadataIntegrationDataCatalogConfig>? DataCatalogConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceStatusAtProviderNetworkConfigConsumers
{
    /// <summary>The URI of the endpoint used to access the metastore service.</summary>
    [JsonPropertyName("endpointUri")]
    public string? EndpointUri { get; set; }

    /// <summary>The subnetwork of the customer project from which an IP address is reserved and used as the Dataproc Metastore service's endpoint. It is accessible to hosts in the subnet and to all hosts in a subnet in the same region and same network. There must be at least one IP address available in the subnet's primary range. The subnet is specified in the following form: `projects/{projectNumber}/regions/{region_id}/subnetworks/{subnetwork_id}</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceStatusAtProviderNetworkConfig
{
    /// <summary>The consumer-side network configuration for the Dataproc Metastore instance. Structure is documented below.</summary>
    [JsonPropertyName("consumers")]
    public IList<V1beta1MetastoreServiceStatusAtProviderNetworkConfigConsumers>? Consumers { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceStatusAtProviderScalingConfigAutoscalingConfigLimitConfig
{
    /// <summary>The maximum scaling factor that the service will autoscale to. The default value is 6.0.</summary>
    [JsonPropertyName("maxScalingFactor")]
    public double? MaxScalingFactor { get; set; }

    /// <summary>The minimum scaling factor that the service will autoscale to. The default value is 0.1.</summary>
    [JsonPropertyName("minScalingFactor")]
    public double? MinScalingFactor { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceStatusAtProviderScalingConfigAutoscalingConfig
{
    /// <summary>Defines whether autoscaling is enabled. The default value is false.</summary>
    [JsonPropertyName("autoscalingEnabled")]
    public bool? AutoscalingEnabled { get; set; }

    /// <summary>(Output) Output only. The scaling factor of a service with autoscaling enabled.</summary>
    [JsonPropertyName("autoscalingFactor")]
    public double? AutoscalingFactor { get; set; }

    /// <summary>Represents the limit configuration of a metastore service. Structure is documented below.</summary>
    [JsonPropertyName("limitConfig")]
    public IList<V1beta1MetastoreServiceStatusAtProviderScalingConfigAutoscalingConfigLimitConfig>? LimitConfig { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceStatusAtProviderScalingConfig
{
    /// <summary>Represents the autoscaling configuration of a metastore service. Structure is documented below.</summary>
    [JsonPropertyName("autoscalingConfig")]
    public IList<V1beta1MetastoreServiceStatusAtProviderScalingConfigAutoscalingConfig>? AutoscalingConfig { get; set; }

    /// <summary>Metastore instance sizes. Possible values are: EXTRA_SMALL, SMALL, MEDIUM, LARGE, EXTRA_LARGE.</summary>
    [JsonPropertyName("instanceSize")]
    public string? InstanceSize { get; set; }

    /// <summary>Scaling factor, in increments of 0.1 for values less than 1.0, and increments of 1.0 for values greater than 1.0.</summary>
    [JsonPropertyName("scalingFactor")]
    public double? ScalingFactor { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceStatusAtProviderScheduledBackup
{
    /// <summary>A Cloud Storage URI of a folder, in the format gs://&lt;bucket_name&gt;/&lt;path_inside_bucket&gt;. A sub-folder &lt;backup_folder&gt; containing backup files will be stored below it.</summary>
    [JsonPropertyName("backupLocation")]
    public string? BackupLocation { get; set; }

    /// <summary>The scheduled interval in Cron format, see https://en.wikipedia.org/wiki/Cron The default is empty: scheduled backup is not enabled. Must be specified to enable scheduled backups.</summary>
    [JsonPropertyName("cronSchedule")]
    public string? CronSchedule { get; set; }

    /// <summary>Defines whether the scheduled backup is enabled. The default value is false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Specifies the time zone to be used when interpreting cronSchedule. Must be a time zone name from the time zone database (https://en.wikipedia.org/wiki/List_of_tz_database_time_zones), e.g. America/Los_Angeles or Africa/Abidjan. If left unspecified, the default is UTC.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceStatusAtProviderTelemetryConfig
{
    /// <summary>The output format of the Dataproc Metastore service's logs. Default value is JSON. Possible values are: LEGACY, JSON.</summary>
    [JsonPropertyName("logFormat")]
    public string? LogFormat { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceStatusAtProvider
{
    /// <summary>A Cloud Storage URI (starting with gs://) that specifies where artifacts related to the metastore service are stored.</summary>
    [JsonPropertyName("artifactGcsUri")]
    public string? ArtifactGcsUri { get; set; }

    /// <summary>Output only. The time when the metastore service was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>The database type that the Metastore service stores its data. Default value is MYSQL. Possible values are: MYSQL, SPANNER.</summary>
    [JsonPropertyName("databaseType")]
    public string? DatabaseType { get; set; }

    /// <summary>Indicates if the dataproc metastore should be protected against accidental deletions.</summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>Information used to configure the Dataproc Metastore service to encrypt customer data at rest. Structure is documented below.</summary>
    [JsonPropertyName("encryptionConfig")]
    public IList<V1beta1MetastoreServiceStatusAtProviderEncryptionConfig>? EncryptionConfig { get; set; }

    /// <summary>The URI of the endpoint used to access the metastore service.</summary>
    [JsonPropertyName("endpointUri")]
    public string? EndpointUri { get; set; }

    /// <summary>Configuration information specific to running Hive metastore software as the metastore service. Structure is documented below.</summary>
    [JsonPropertyName("hiveMetastoreConfig")]
    public IList<V1beta1MetastoreServiceStatusAtProviderHiveMetastoreConfig>? HiveMetastoreConfig { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/services/{{service_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>User-defined labels for the metastore service. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location where the metastore service should reside. The default value is global.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The one hour maintenance window of the metastore service. This specifies when the service can be restarted for maintenance purposes in UTC time. Maintenance window is not needed for services with the SPANNER database type. Structure is documented below.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public IList<V1beta1MetastoreServiceStatusAtProviderMaintenanceWindow>? MaintenanceWindow { get; set; }

    /// <summary>The setting that defines how metastore metadata should be integrated with external services and systems. Structure is documented below.</summary>
    [JsonPropertyName("metadataIntegration")]
    public IList<V1beta1MetastoreServiceStatusAtProviderMetadataIntegration>? MetadataIntegration { get; set; }

    /// <summary>The relative resource name of the metastore service.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The relative resource name of the VPC network on which the instance can be accessed. It is specified in the following form: "projects/{projectNumber}/global/networks/{network_id}".</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>The configuration specifying the network settings for the Dataproc Metastore service. Structure is documented below.</summary>
    [JsonPropertyName("networkConfig")]
    public IList<V1beta1MetastoreServiceStatusAtProviderNetworkConfig>? NetworkConfig { get; set; }

    /// <summary>The TCP port at which the metastore service is reached. Default: 9083.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The release channel of the service. If unspecified, defaults to STABLE. Default value is STABLE. Possible values are: CANARY, STABLE.</summary>
    [JsonPropertyName("releaseChannel")]
    public string? ReleaseChannel { get; set; }

    /// <summary>Represents the scaling configuration of a metastore service. Structure is documented below.</summary>
    [JsonPropertyName("scalingConfig")]
    public IList<V1beta1MetastoreServiceStatusAtProviderScalingConfig>? ScalingConfig { get; set; }

    /// <summary>The configuration of scheduled backup for the metastore service. Structure is documented below.</summary>
    [JsonPropertyName("scheduledBackup")]
    public IList<V1beta1MetastoreServiceStatusAtProviderScheduledBackup>? ScheduledBackup { get; set; }

    /// <summary>The current state of the metastore service.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Additional information about the current state of the metastore service, if available.</summary>
    [JsonPropertyName("stateMessage")]
    public string? StateMessage { get; set; }

    /// <summary>The configuration specifying telemetry settings for the Dataproc Metastore service. If unspecified defaults to JSON. Structure is documented below.</summary>
    [JsonPropertyName("telemetryConfig")]
    public IList<V1beta1MetastoreServiceStatusAtProviderTelemetryConfig>? TelemetryConfig { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>The tier of the service. Possible values are: DEVELOPER, ENTERPRISE.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>The globally unique resource identifier of the metastore service.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The time when the metastore service was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceStatusConditions
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

/// <summary>MetastoreServiceStatus defines the observed state of MetastoreService.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetastoreServiceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1MetastoreServiceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MetastoreServiceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MetastoreService is the Schema for the MetastoreServices API. A managed metastore service that serves metadata queries.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MetastoreService : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MetastoreServiceSpec>, IStatus<V1beta1MetastoreServiceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MetastoreService";
    public const string KubeGroup = "dataproc.gcp.upbound.io";
    public const string KubePluralName = "metastoreservices";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MetastoreServiceSpec defines the desired state of MetastoreService</summary>
    [JsonPropertyName("spec")]
    public V1beta1MetastoreServiceSpec Spec { get; set; }

    /// <summary>MetastoreServiceStatus defines the observed state of MetastoreService.</summary>
    [JsonPropertyName("status")]
    public V1beta1MetastoreServiceStatus? Status { get; set; }
}

/// <summary>MetastoreService is the Schema for the MetastoreServices API. A managed metastore service that serves metadata queries.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MetastoreServiceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1MetastoreService>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MetastoreServiceList";
    public const string KubeGroup = "dataproc.gcp.upbound.io";
    public const string KubePluralName = "metastoreservices";
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
    public IList<V1beta1MetastoreService> Items { get; set; }
}