using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dms.aws.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecForProviderElasticsearchSettings
{
    /// <summary>Endpoint for the OpenSearch cluster.</summary>
    [JsonPropertyName("endpointUri")]
    public string? EndpointUri { get; set; }

    /// <summary>Maximum number of seconds for which DMS retries failed API requests to the OpenSearch cluster. Default is 300.</summary>
    [JsonPropertyName("errorRetryDuration")]
    public double? ErrorRetryDuration { get; set; }

    /// <summary>Maximum percentage of records that can fail to be written before a full load operation stops. Default is 10.</summary>
    [JsonPropertyName("fullLoadErrorPercentage")]
    public double? FullLoadErrorPercentage { get; set; }

    /// <summary>ARN of the IAM Role with permissions to write to the OpenSearch cluster.</summary>
    [JsonPropertyName("serviceAccessRoleArn")]
    public string? ServiceAccessRoleArn { get; set; }

    /// <summary>Enable to migrate documentation using the documentation type _doc. OpenSearch and an Elasticsearch clusters only support the _doc documentation type in versions 7.x and later. The default value is false.</summary>
    [JsonPropertyName("useNewMappingType")]
    public bool? UseNewMappingType { get; set; }
}

/// <summary>Secure password you created when you first set up your MSK cluster to validate a client identity and make an encrypted connection between server and client using SASL-SSL authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecForProviderKafkaSettingsSaslPasswordSecretRef
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

/// <summary>Password for the client private key used to securely connect to a Kafka target endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecForProviderKafkaSettingsSslClientKeyPasswordSecretRef
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
public partial class V1beta1EndpointSpecForProviderKafkaSettings
{
    /// <summary>Kafka broker location. Specify in the form broker-hostname-or-ip:port.</summary>
    [JsonPropertyName("broker")]
    public string? Broker { get; set; }

    /// <summary>Shows detailed control information for table definition, column definition, and table and column changes in the Kafka message output. Default is false.</summary>
    [JsonPropertyName("includeControlDetails")]
    public bool? IncludeControlDetails { get; set; }

    /// <summary>Include NULL and empty columns for records migrated to the endpoint. Default is false.</summary>
    [JsonPropertyName("includeNullAndEmpty")]
    public bool? IncludeNullAndEmpty { get; set; }

    /// <summary>Shows the partition value within the Kafka message output unless the partition type is schema-table-type. Default is false.</summary>
    [JsonPropertyName("includePartitionValue")]
    public bool? IncludePartitionValue { get; set; }

    /// <summary>Includes any data definition language (DDL) operations that change the table in the control data, such as rename-table, drop-table, add-column, drop-column, and rename-column. Default is false.</summary>
    [JsonPropertyName("includeTableAlterOperations")]
    public bool? IncludeTableAlterOperations { get; set; }

    /// <summary>Provides detailed transaction information from the source database. This information includes a commit timestamp, a log position, and values for transaction_id, previous transaction_id, and transaction_record_id (the record offset within a transaction). Default is false.</summary>
    [JsonPropertyName("includeTransactionDetails")]
    public bool? IncludeTransactionDetails { get; set; }

    /// <summary>Output format for the records created on the endpoint. Message format is JSON (default) or JSON_UNFORMATTED (a single line with no tab).</summary>
    [JsonPropertyName("messageFormat")]
    public string? MessageFormat { get; set; }

    /// <summary>Maximum size in bytes for records created on the endpoint Default is 1,000,000.</summary>
    [JsonPropertyName("messageMaxBytes")]
    public double? MessageMaxBytes { get; set; }

    /// <summary>Set this optional parameter to true to avoid adding a '0x' prefix to raw data in hexadecimal format. For example, by default, AWS DMS adds a '0x' prefix to the LOB column type in hexadecimal format moving from an Oracle source to a Kafka target. Use the no_hex_prefix endpoint setting to enable migration of RAW data type columns without adding the '0x' prefix.</summary>
    [JsonPropertyName("noHexPrefix")]
    public bool? NoHexPrefix { get; set; }

    /// <summary>Prefixes schema and table names to partition values, when the partition type is primary-key-type. Doing this increases data distribution among Kafka partitions. For example, suppose that a SysBench schema has thousands of tables and each table has only limited range for a primary key. In this case, the same primary key is sent from thousands of tables to the same partition, which causes throttling. Default is false.</summary>
    [JsonPropertyName("partitionIncludeSchemaTable")]
    public bool? PartitionIncludeSchemaTable { get; set; }

    /// <summary>For SASL/SSL authentication, AWS DMS supports the scram-sha-512 mechanism by default. AWS DMS versions 3.5.0 and later also support the PLAIN mechanism. To use the PLAIN mechanism, set this parameter to plain.</summary>
    [JsonPropertyName("saslMechanism")]
    public string? SaslMechanism { get; set; }

    /// <summary>Secure password you created when you first set up your MSK cluster to validate a client identity and make an encrypted connection between server and client using SASL-SSL authentication.</summary>
    [JsonPropertyName("saslPasswordSecretRef")]
    public V1beta1EndpointSpecForProviderKafkaSettingsSaslPasswordSecretRef? SaslPasswordSecretRef { get; set; }

    /// <summary>Secure user name you created when you first set up your MSK cluster to validate a client identity and make an encrypted connection between server and client using SASL-SSL authentication.</summary>
    [JsonPropertyName("saslUsername")]
    public string? SaslUsername { get; set; }

    /// <summary>Set secure connection to a Kafka target endpoint using Transport Layer Security (TLS). Options include ssl-encryption, ssl-authentication, and sasl-ssl. sasl-ssl requires sasl_username and sasl_password.</summary>
    [JsonPropertyName("securityProtocol")]
    public string? SecurityProtocol { get; set; }

    /// <summary>ARN for the private certificate authority (CA) cert that AWS DMS uses to securely connect to your Kafka target endpoint.</summary>
    [JsonPropertyName("sslCaCertificateArn")]
    public string? SslCaCertificateArn { get; set; }

    /// <summary>ARN of the client certificate used to securely connect to a Kafka target endpoint.</summary>
    [JsonPropertyName("sslClientCertificateArn")]
    public string? SslClientCertificateArn { get; set; }

    /// <summary>ARN for the client private key used to securely connect to a Kafka target endpoint.</summary>
    [JsonPropertyName("sslClientKeyArn")]
    public string? SslClientKeyArn { get; set; }

    /// <summary>Password for the client private key used to securely connect to a Kafka target endpoint.</summary>
    [JsonPropertyName("sslClientKeyPasswordSecretRef")]
    public V1beta1EndpointSpecForProviderKafkaSettingsSslClientKeyPasswordSecretRef? SslClientKeyPasswordSecretRef { get; set; }

    /// <summary>Kafka topic for migration. Default is kafka-default-topic.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecForProviderKinesisSettings
{
    /// <summary>Shows detailed control information for table definition, column definition, and table and column changes in the Kinesis message output. Default is false.</summary>
    [JsonPropertyName("includeControlDetails")]
    public bool? IncludeControlDetails { get; set; }

    /// <summary>Include NULL and empty columns in the target. Default is false.</summary>
    [JsonPropertyName("includeNullAndEmpty")]
    public bool? IncludeNullAndEmpty { get; set; }

    /// <summary>Shows the partition value within the Kinesis message output, unless the partition type is schema-table-type. Default is false.</summary>
    [JsonPropertyName("includePartitionValue")]
    public bool? IncludePartitionValue { get; set; }

    /// <summary>Includes any data definition language (DDL) operations that change the table in the control data. Default is false.</summary>
    [JsonPropertyName("includeTableAlterOperations")]
    public bool? IncludeTableAlterOperations { get; set; }

    /// <summary>Provides detailed transaction information from the source database. Default is false.</summary>
    [JsonPropertyName("includeTransactionDetails")]
    public bool? IncludeTransactionDetails { get; set; }

    /// <summary>Output format for the records created. Default is json. Valid values are json and json-unformatted (a single line with no tab).</summary>
    [JsonPropertyName("messageFormat")]
    public string? MessageFormat { get; set; }

    /// <summary>Prefixes schema and table names to partition values, when the partition type is primary-key-type. Default is false.</summary>
    [JsonPropertyName("partitionIncludeSchemaTable")]
    public bool? PartitionIncludeSchemaTable { get; set; }

    /// <summary>ARN of the IAM Role with permissions to write to the Kinesis data stream.</summary>
    [JsonPropertyName("serviceAccessRoleArn")]
    public string? ServiceAccessRoleArn { get; set; }

    /// <summary>ARN of the Kinesis data stream.</summary>
    [JsonPropertyName("streamArn")]
    public string? StreamArn { get; set; }

    /// <summary>Use up to 18 digit int instead of casting ints as doubles, available from AWS DMS version 3.5.4. Default is false.</summary>
    [JsonPropertyName("useLargeIntegerValue")]
    public bool? UseLargeIntegerValue { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecForProviderKmsKeyArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecForProviderKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointSpecForProviderKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecForProviderKmsKeyArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecForProviderKmsKeyArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointSpecForProviderKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecForProviderMongodbSettings
{
    /// <summary>Authentication mechanism to access the MongoDB source endpoint. Default is default.</summary>
    [JsonPropertyName("authMechanism")]
    public string? AuthMechanism { get; set; }

    /// <summary>Authentication database name. Not used when auth_type is no. Default is admin.</summary>
    [JsonPropertyName("authSource")]
    public string? AuthSource { get; set; }

    /// <summary>Authentication type to access the MongoDB source endpoint. Default is password.</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>Number of documents to preview to determine the document organization. Use this setting when nesting_level is set to one. Default is 1000.</summary>
    [JsonPropertyName("docsToInvestigate")]
    public string? DocsToInvestigate { get; set; }

    /// <summary>Document ID. Use this setting when nesting_level is set to none. Default is false.</summary>
    [JsonPropertyName("extractDocId")]
    public string? ExtractDocId { get; set; }

    /// <summary>Specifies either document or table mode. Default is none. Valid values are one (table mode) and none (document mode).</summary>
    [JsonPropertyName("nestingLevel")]
    public string? NestingLevel { get; set; }
}

/// <summary>Password to be used to login to the endpoint database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecForProviderPasswordSecretRef
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
public partial class V1beta1EndpointSpecForProviderPostgresSettings
{
    /// <summary>For use with change data capture (CDC) only, this attribute has AWS DMS bypass foreign keys and user triggers to reduce the time it takes to bulk load data.</summary>
    [JsonPropertyName("afterConnectScript")]
    public string? AfterConnectScript { get; set; }

    /// <summary>The Babelfish for Aurora PostgreSQL database name for the endpoint.</summary>
    [JsonPropertyName("babelfishDatabaseName")]
    public string? BabelfishDatabaseName { get; set; }

    /// <summary>To capture DDL events, AWS DMS creates various artifacts in the PostgreSQL database when the task starts.</summary>
    [JsonPropertyName("captureDdls")]
    public bool? CaptureDdls { get; set; }

    /// <summary>Specifies the default behavior of the replication's handling of PostgreSQL- compatible endpoints that require some additional configuration, such as Babelfish endpoints.</summary>
    [JsonPropertyName("databaseMode")]
    public string? DatabaseMode { get; set; }

    /// <summary>Sets the schema in which the operational DDL database artifacts are created. Default is public.</summary>
    [JsonPropertyName("ddlArtifactsSchema")]
    public string? DdlArtifactsSchema { get; set; }

    /// <summary>Sets the client statement timeout for the PostgreSQL instance, in seconds. Default value is 60.</summary>
    [JsonPropertyName("executeTimeout")]
    public double? ExecuteTimeout { get; set; }

    /// <summary>When set to true, this value causes a task to fail if the actual size of a LOB column is greater than the specified LobMaxSize. Default is false.</summary>
    [JsonPropertyName("failTasksOnLobTruncation")]
    public bool? FailTasksOnLobTruncation { get; set; }

    /// <summary>The write-ahead log (WAL) heartbeat feature mimics a dummy transaction. By doing this, it prevents idle logical replication slots from holding onto old WAL logs, which can result in storage full situations on the source.</summary>
    [JsonPropertyName("heartbeatEnable")]
    public bool? HeartbeatEnable { get; set; }

    /// <summary>Sets the WAL heartbeat frequency (in minutes). Default value is 5.</summary>
    [JsonPropertyName("heartbeatFrequency")]
    public double? HeartbeatFrequency { get; set; }

    /// <summary>Sets the schema in which the heartbeat artifacts are created. Default value is public.</summary>
    [JsonPropertyName("heartbeatSchema")]
    public string? HeartbeatSchema { get; set; }

    /// <summary>You can use PostgreSQL endpoint settings to map a boolean as a boolean from your PostgreSQL source to a Amazon Redshift target. Default value is false.</summary>
    [JsonPropertyName("mapBooleanAsBoolean")]
    public bool? MapBooleanAsBoolean { get; set; }

    /// <summary>Optional When true, DMS migrates JSONB values as CLOB.</summary>
    [JsonPropertyName("mapJsonbAsClob")]
    public bool? MapJsonbAsClob { get; set; }

    /// <summary>Optional When true, DMS migrates LONG values as VARCHAR.</summary>
    [JsonPropertyName("mapLongVarcharAs")]
    public string? MapLongVarcharAs { get; set; }

    /// <summary>Specifies the maximum size (in KB) of any .csv file used to transfer data to PostgreSQL. Default is 32,768 KB.</summary>
    [JsonPropertyName("maxFileSize")]
    public double? MaxFileSize { get; set; }

    /// <summary>Specifies the plugin to use to create a replication slot. Valid values: pglogical, test_decoding.</summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>Sets the name of a previously created logical replication slot for a CDC load of the PostgreSQL source instance.</summary>
    [JsonPropertyName("slotName")]
    public string? SlotName { get; set; }
}

/// <summary>The password provided with the auth-role and auth-token options of the AuthType setting for a Redis target endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecForProviderRedisSettingsAuthPasswordSecretRef
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
public partial class V1beta1EndpointSpecForProviderRedisSettings
{
    /// <summary>The password provided with the auth-role and auth-token options of the AuthType setting for a Redis target endpoint.</summary>
    [JsonPropertyName("authPasswordSecretRef")]
    public V1beta1EndpointSpecForProviderRedisSettingsAuthPasswordSecretRef? AuthPasswordSecretRef { get; set; }

    /// <summary>Authentication type to access the MongoDB source endpoint. Default is password.</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>The username provided with the auth-role option of the AuthType setting for a Redis target endpoint.</summary>
    [JsonPropertyName("authUserName")]
    public string? AuthUserName { get; set; }

    /// <summary>Port used by the endpoint database.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Host name of the server.</summary>
    [JsonPropertyName("serverName")]
    public string? ServerName { get; set; }

    /// <summary>The Amazon Resource Name (ARN) for the certificate authority (CA) that DMS uses to connect to your Redis target endpoint.</summary>
    [JsonPropertyName("sslCaCertificateArn")]
    public string? SslCaCertificateArn { get; set; }

    /// <summary>The plaintext option doesn't provide Transport Layer Security (TLS) encryption for traffic between endpoint and database. Options include plaintext, ssl-encryption. The default is ssl-encryption.</summary>
    [JsonPropertyName("sslSecurityProtocol")]
    public string? SslSecurityProtocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecForProviderRedshiftSettings
{
    /// <summary>Custom S3 Bucket Object prefix for intermediate storage.</summary>
    [JsonPropertyName("bucketFolder")]
    public string? BucketFolder { get; set; }

    /// <summary>Custom S3 Bucket name for intermediate storage.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>The server-side encryption mode that you want to encrypt your intermediate .csv object files copied to S3. Defaults to SSE_S3. Valid values are SSE_S3 and SSE_KMS.</summary>
    [JsonPropertyName("encryptionMode")]
    public string? EncryptionMode { get; set; }

    /// <summary>ARN or Id of KMS Key to use when encryption_mode is SSE_KMS.</summary>
    [JsonPropertyName("serverSideEncryptionKmsKeyId")]
    public string? ServerSideEncryptionKmsKeyId { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the IAM Role with permissions to read from or write to the S3 Bucket for intermediate storage.</summary>
    [JsonPropertyName("serviceAccessRoleArn")]
    public string? ServiceAccessRoleArn { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecForProviderSecretsManagerAccessRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate secretsManagerAccessRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecForProviderSecretsManagerAccessRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointSpecForProviderSecretsManagerAccessRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecForProviderSecretsManagerAccessRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate secretsManagerAccessRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecForProviderSecretsManagerAccessRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointSpecForProviderSecretsManagerAccessRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecForProviderServiceAccessRoleRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceAccessRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecForProviderServiceAccessRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointSpecForProviderServiceAccessRoleRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecForProviderServiceAccessRoleSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceAccessRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecForProviderServiceAccessRoleSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointSpecForProviderServiceAccessRoleSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecForProvider
{
    /// <summary>ARN for the certificate.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }

    /// <summary>Name of the endpoint database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Configuration block for OpenSearch settings. See below.</summary>
    [JsonPropertyName("elasticsearchSettings")]
    public IList<V1beta1EndpointSpecForProviderElasticsearchSettings>? ElasticsearchSettings { get; set; }

    /// <summary>Type of endpoint. Valid values are source, target.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>Type of engine for the endpoint. Valid values are aurora, aurora-postgresql, aurora-serverless, aurora-postgresql-serverless,azuredb, azure-sql-managed-instance, babelfish, db2, db2-zos, docdb, dynamodb, elasticsearch, kafka, kinesis, mariadb, mongodb, mysql, opensearch, oracle, postgres, redshift,redshift-serverless, s3, sqlserver, neptune ,sybase. Please note that some of engine names are available only for target endpoint type (e.g. redshift).</summary>
    [JsonPropertyName("engineName")]
    public string? EngineName { get; set; }

    /// <summary>Additional attributes associated with the connection. For available attributes for a source Endpoint, see Sources for data migration. For available attributes for a target Endpoint, see Targets for data migration.</summary>
    [JsonPropertyName("extraConnectionAttributes")]
    public string? ExtraConnectionAttributes { get; set; }

    /// <summary>Configuration block for Kafka settings. See below.</summary>
    [JsonPropertyName("kafkaSettings")]
    public IList<V1beta1EndpointSpecForProviderKafkaSettings>? KafkaSettings { get; set; }

    /// <summary>Configuration block for Kinesis settings. See below.</summary>
    [JsonPropertyName("kinesisSettings")]
    public IList<V1beta1EndpointSpecForProviderKinesisSettings>? KinesisSettings { get; set; }

    /// <summary>ARN for the KMS key that will be used to encrypt the connection parameters. If you do not specify a value for kms_key_arn, then AWS DMS will use your default encryption key. AWS KMS creates the default encryption key for your AWS account. Your AWS account has a different default encryption key for each AWS region. When engine_name is redshift, kms_key_arn is the KMS Key for the Redshift target and the parameter redshift_settings.server_side_encryption_kms_key_id encrypts the S3 intermediate storage.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1EndpointSpecForProviderKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1EndpointSpecForProviderKmsKeyArnSelector? KmsKeyArnSelector { get; set; }

    /// <summary>Configuration block for MongoDB settings. See below.</summary>
    [JsonPropertyName("mongodbSettings")]
    public IList<V1beta1EndpointSpecForProviderMongodbSettings>? MongodbSettings { get; set; }

    /// <summary>Password to be used to login to the endpoint database.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1EndpointSpecForProviderPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>Only tasks paused by the resource will be restarted after the modification completes. Default is false.</summary>
    [JsonPropertyName("pauseReplicationTasks")]
    public bool? PauseReplicationTasks { get; set; }

    /// <summary>Port used by the endpoint database.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Configuration block for Postgres settings. See below.</summary>
    [JsonPropertyName("postgresSettings")]
    public IList<V1beta1EndpointSpecForProviderPostgresSettings>? PostgresSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("redisSettings")]
    public IList<V1beta1EndpointSpecForProviderRedisSettings>? RedisSettings { get; set; }

    /// <summary>Configuration block for Redshift settings. See below.</summary>
    [JsonPropertyName("redshiftSettings")]
    public IList<V1beta1EndpointSpecForProviderRedshiftSettings>? RedshiftSettings { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>ARN of the IAM role that specifies AWS DMS as the trusted entity and has the required permissions to access the value in the Secrets Manager secret referred to by secrets_manager_arn. The role must allow the iam:PassRole action.</summary>
    [JsonPropertyName("secretsManagerAccessRoleArn")]
    public string? SecretsManagerAccessRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate secretsManagerAccessRoleArn.</summary>
    [JsonPropertyName("secretsManagerAccessRoleArnRef")]
    public V1beta1EndpointSpecForProviderSecretsManagerAccessRoleArnRef? SecretsManagerAccessRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate secretsManagerAccessRoleArn.</summary>
    [JsonPropertyName("secretsManagerAccessRoleArnSelector")]
    public V1beta1EndpointSpecForProviderSecretsManagerAccessRoleArnSelector? SecretsManagerAccessRoleArnSelector { get; set; }

    /// <summary>text values for username, password , server_name, and port. You can't specify both.</summary>
    [JsonPropertyName("secretsManagerArn")]
    public string? SecretsManagerArn { get; set; }

    /// <summary>Host name of the server.</summary>
    [JsonPropertyName("serverName")]
    public string? ServerName { get; set; }

    /// <summary>ARN used by the service access IAM role for dynamodb endpoints.</summary>
    [JsonPropertyName("serviceAccessRole")]
    public string? ServiceAccessRole { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceAccessRole.</summary>
    [JsonPropertyName("serviceAccessRoleRef")]
    public V1beta1EndpointSpecForProviderServiceAccessRoleRef? ServiceAccessRoleRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceAccessRole.</summary>
    [JsonPropertyName("serviceAccessRoleSelector")]
    public V1beta1EndpointSpecForProviderServiceAccessRoleSelector? ServiceAccessRoleSelector { get; set; }

    /// <summary>SSL mode to use for the connection. Valid values are none, require, verify-ca, verify-full</summary>
    [JsonPropertyName("sslMode")]
    public string? SslMode { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>User name to be used to login to the endpoint database.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecInitProviderElasticsearchSettings
{
    /// <summary>Endpoint for the OpenSearch cluster.</summary>
    [JsonPropertyName("endpointUri")]
    public string? EndpointUri { get; set; }

    /// <summary>Maximum number of seconds for which DMS retries failed API requests to the OpenSearch cluster. Default is 300.</summary>
    [JsonPropertyName("errorRetryDuration")]
    public double? ErrorRetryDuration { get; set; }

    /// <summary>Maximum percentage of records that can fail to be written before a full load operation stops. Default is 10.</summary>
    [JsonPropertyName("fullLoadErrorPercentage")]
    public double? FullLoadErrorPercentage { get; set; }

    /// <summary>ARN of the IAM Role with permissions to write to the OpenSearch cluster.</summary>
    [JsonPropertyName("serviceAccessRoleArn")]
    public string? ServiceAccessRoleArn { get; set; }

    /// <summary>Enable to migrate documentation using the documentation type _doc. OpenSearch and an Elasticsearch clusters only support the _doc documentation type in versions 7.x and later. The default value is false.</summary>
    [JsonPropertyName("useNewMappingType")]
    public bool? UseNewMappingType { get; set; }
}

/// <summary>Secure password you created when you first set up your MSK cluster to validate a client identity and make an encrypted connection between server and client using SASL-SSL authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecInitProviderKafkaSettingsSaslPasswordSecretRef
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

/// <summary>Password for the client private key used to securely connect to a Kafka target endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecInitProviderKafkaSettingsSslClientKeyPasswordSecretRef
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
public partial class V1beta1EndpointSpecInitProviderKafkaSettings
{
    /// <summary>Kafka broker location. Specify in the form broker-hostname-or-ip:port.</summary>
    [JsonPropertyName("broker")]
    public string? Broker { get; set; }

    /// <summary>Shows detailed control information for table definition, column definition, and table and column changes in the Kafka message output. Default is false.</summary>
    [JsonPropertyName("includeControlDetails")]
    public bool? IncludeControlDetails { get; set; }

    /// <summary>Include NULL and empty columns for records migrated to the endpoint. Default is false.</summary>
    [JsonPropertyName("includeNullAndEmpty")]
    public bool? IncludeNullAndEmpty { get; set; }

    /// <summary>Shows the partition value within the Kafka message output unless the partition type is schema-table-type. Default is false.</summary>
    [JsonPropertyName("includePartitionValue")]
    public bool? IncludePartitionValue { get; set; }

    /// <summary>Includes any data definition language (DDL) operations that change the table in the control data, such as rename-table, drop-table, add-column, drop-column, and rename-column. Default is false.</summary>
    [JsonPropertyName("includeTableAlterOperations")]
    public bool? IncludeTableAlterOperations { get; set; }

    /// <summary>Provides detailed transaction information from the source database. This information includes a commit timestamp, a log position, and values for transaction_id, previous transaction_id, and transaction_record_id (the record offset within a transaction). Default is false.</summary>
    [JsonPropertyName("includeTransactionDetails")]
    public bool? IncludeTransactionDetails { get; set; }

    /// <summary>Output format for the records created on the endpoint. Message format is JSON (default) or JSON_UNFORMATTED (a single line with no tab).</summary>
    [JsonPropertyName("messageFormat")]
    public string? MessageFormat { get; set; }

    /// <summary>Maximum size in bytes for records created on the endpoint Default is 1,000,000.</summary>
    [JsonPropertyName("messageMaxBytes")]
    public double? MessageMaxBytes { get; set; }

    /// <summary>Set this optional parameter to true to avoid adding a '0x' prefix to raw data in hexadecimal format. For example, by default, AWS DMS adds a '0x' prefix to the LOB column type in hexadecimal format moving from an Oracle source to a Kafka target. Use the no_hex_prefix endpoint setting to enable migration of RAW data type columns without adding the '0x' prefix.</summary>
    [JsonPropertyName("noHexPrefix")]
    public bool? NoHexPrefix { get; set; }

    /// <summary>Prefixes schema and table names to partition values, when the partition type is primary-key-type. Doing this increases data distribution among Kafka partitions. For example, suppose that a SysBench schema has thousands of tables and each table has only limited range for a primary key. In this case, the same primary key is sent from thousands of tables to the same partition, which causes throttling. Default is false.</summary>
    [JsonPropertyName("partitionIncludeSchemaTable")]
    public bool? PartitionIncludeSchemaTable { get; set; }

    /// <summary>For SASL/SSL authentication, AWS DMS supports the scram-sha-512 mechanism by default. AWS DMS versions 3.5.0 and later also support the PLAIN mechanism. To use the PLAIN mechanism, set this parameter to plain.</summary>
    [JsonPropertyName("saslMechanism")]
    public string? SaslMechanism { get; set; }

    /// <summary>Secure password you created when you first set up your MSK cluster to validate a client identity and make an encrypted connection between server and client using SASL-SSL authentication.</summary>
    [JsonPropertyName("saslPasswordSecretRef")]
    public V1beta1EndpointSpecInitProviderKafkaSettingsSaslPasswordSecretRef? SaslPasswordSecretRef { get; set; }

    /// <summary>Secure user name you created when you first set up your MSK cluster to validate a client identity and make an encrypted connection between server and client using SASL-SSL authentication.</summary>
    [JsonPropertyName("saslUsername")]
    public string? SaslUsername { get; set; }

    /// <summary>Set secure connection to a Kafka target endpoint using Transport Layer Security (TLS). Options include ssl-encryption, ssl-authentication, and sasl-ssl. sasl-ssl requires sasl_username and sasl_password.</summary>
    [JsonPropertyName("securityProtocol")]
    public string? SecurityProtocol { get; set; }

    /// <summary>ARN for the private certificate authority (CA) cert that AWS DMS uses to securely connect to your Kafka target endpoint.</summary>
    [JsonPropertyName("sslCaCertificateArn")]
    public string? SslCaCertificateArn { get; set; }

    /// <summary>ARN of the client certificate used to securely connect to a Kafka target endpoint.</summary>
    [JsonPropertyName("sslClientCertificateArn")]
    public string? SslClientCertificateArn { get; set; }

    /// <summary>ARN for the client private key used to securely connect to a Kafka target endpoint.</summary>
    [JsonPropertyName("sslClientKeyArn")]
    public string? SslClientKeyArn { get; set; }

    /// <summary>Password for the client private key used to securely connect to a Kafka target endpoint.</summary>
    [JsonPropertyName("sslClientKeyPasswordSecretRef")]
    public V1beta1EndpointSpecInitProviderKafkaSettingsSslClientKeyPasswordSecretRef? SslClientKeyPasswordSecretRef { get; set; }

    /// <summary>Kafka topic for migration. Default is kafka-default-topic.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecInitProviderKinesisSettings
{
    /// <summary>Shows detailed control information for table definition, column definition, and table and column changes in the Kinesis message output. Default is false.</summary>
    [JsonPropertyName("includeControlDetails")]
    public bool? IncludeControlDetails { get; set; }

    /// <summary>Include NULL and empty columns in the target. Default is false.</summary>
    [JsonPropertyName("includeNullAndEmpty")]
    public bool? IncludeNullAndEmpty { get; set; }

    /// <summary>Shows the partition value within the Kinesis message output, unless the partition type is schema-table-type. Default is false.</summary>
    [JsonPropertyName("includePartitionValue")]
    public bool? IncludePartitionValue { get; set; }

    /// <summary>Includes any data definition language (DDL) operations that change the table in the control data. Default is false.</summary>
    [JsonPropertyName("includeTableAlterOperations")]
    public bool? IncludeTableAlterOperations { get; set; }

    /// <summary>Provides detailed transaction information from the source database. Default is false.</summary>
    [JsonPropertyName("includeTransactionDetails")]
    public bool? IncludeTransactionDetails { get; set; }

    /// <summary>Output format for the records created. Default is json. Valid values are json and json-unformatted (a single line with no tab).</summary>
    [JsonPropertyName("messageFormat")]
    public string? MessageFormat { get; set; }

    /// <summary>Prefixes schema and table names to partition values, when the partition type is primary-key-type. Default is false.</summary>
    [JsonPropertyName("partitionIncludeSchemaTable")]
    public bool? PartitionIncludeSchemaTable { get; set; }

    /// <summary>ARN of the IAM Role with permissions to write to the Kinesis data stream.</summary>
    [JsonPropertyName("serviceAccessRoleArn")]
    public string? ServiceAccessRoleArn { get; set; }

    /// <summary>ARN of the Kinesis data stream.</summary>
    [JsonPropertyName("streamArn")]
    public string? StreamArn { get; set; }

    /// <summary>Use up to 18 digit int instead of casting ints as doubles, available from AWS DMS version 3.5.4. Default is false.</summary>
    [JsonPropertyName("useLargeIntegerValue")]
    public bool? UseLargeIntegerValue { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecInitProviderKmsKeyArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecInitProviderKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointSpecInitProviderKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecInitProviderKmsKeyArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecInitProviderKmsKeyArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointSpecInitProviderKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecInitProviderMongodbSettings
{
    /// <summary>Authentication mechanism to access the MongoDB source endpoint. Default is default.</summary>
    [JsonPropertyName("authMechanism")]
    public string? AuthMechanism { get; set; }

    /// <summary>Authentication database name. Not used when auth_type is no. Default is admin.</summary>
    [JsonPropertyName("authSource")]
    public string? AuthSource { get; set; }

    /// <summary>Authentication type to access the MongoDB source endpoint. Default is password.</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>Number of documents to preview to determine the document organization. Use this setting when nesting_level is set to one. Default is 1000.</summary>
    [JsonPropertyName("docsToInvestigate")]
    public string? DocsToInvestigate { get; set; }

    /// <summary>Document ID. Use this setting when nesting_level is set to none. Default is false.</summary>
    [JsonPropertyName("extractDocId")]
    public string? ExtractDocId { get; set; }

    /// <summary>Specifies either document or table mode. Default is none. Valid values are one (table mode) and none (document mode).</summary>
    [JsonPropertyName("nestingLevel")]
    public string? NestingLevel { get; set; }
}

/// <summary>Password to be used to login to the endpoint database.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecInitProviderPasswordSecretRef
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
public partial class V1beta1EndpointSpecInitProviderPostgresSettings
{
    /// <summary>For use with change data capture (CDC) only, this attribute has AWS DMS bypass foreign keys and user triggers to reduce the time it takes to bulk load data.</summary>
    [JsonPropertyName("afterConnectScript")]
    public string? AfterConnectScript { get; set; }

    /// <summary>The Babelfish for Aurora PostgreSQL database name for the endpoint.</summary>
    [JsonPropertyName("babelfishDatabaseName")]
    public string? BabelfishDatabaseName { get; set; }

    /// <summary>To capture DDL events, AWS DMS creates various artifacts in the PostgreSQL database when the task starts.</summary>
    [JsonPropertyName("captureDdls")]
    public bool? CaptureDdls { get; set; }

    /// <summary>Specifies the default behavior of the replication's handling of PostgreSQL- compatible endpoints that require some additional configuration, such as Babelfish endpoints.</summary>
    [JsonPropertyName("databaseMode")]
    public string? DatabaseMode { get; set; }

    /// <summary>Sets the schema in which the operational DDL database artifacts are created. Default is public.</summary>
    [JsonPropertyName("ddlArtifactsSchema")]
    public string? DdlArtifactsSchema { get; set; }

    /// <summary>Sets the client statement timeout for the PostgreSQL instance, in seconds. Default value is 60.</summary>
    [JsonPropertyName("executeTimeout")]
    public double? ExecuteTimeout { get; set; }

    /// <summary>When set to true, this value causes a task to fail if the actual size of a LOB column is greater than the specified LobMaxSize. Default is false.</summary>
    [JsonPropertyName("failTasksOnLobTruncation")]
    public bool? FailTasksOnLobTruncation { get; set; }

    /// <summary>The write-ahead log (WAL) heartbeat feature mimics a dummy transaction. By doing this, it prevents idle logical replication slots from holding onto old WAL logs, which can result in storage full situations on the source.</summary>
    [JsonPropertyName("heartbeatEnable")]
    public bool? HeartbeatEnable { get; set; }

    /// <summary>Sets the WAL heartbeat frequency (in minutes). Default value is 5.</summary>
    [JsonPropertyName("heartbeatFrequency")]
    public double? HeartbeatFrequency { get; set; }

    /// <summary>Sets the schema in which the heartbeat artifacts are created. Default value is public.</summary>
    [JsonPropertyName("heartbeatSchema")]
    public string? HeartbeatSchema { get; set; }

    /// <summary>You can use PostgreSQL endpoint settings to map a boolean as a boolean from your PostgreSQL source to a Amazon Redshift target. Default value is false.</summary>
    [JsonPropertyName("mapBooleanAsBoolean")]
    public bool? MapBooleanAsBoolean { get; set; }

    /// <summary>Optional When true, DMS migrates JSONB values as CLOB.</summary>
    [JsonPropertyName("mapJsonbAsClob")]
    public bool? MapJsonbAsClob { get; set; }

    /// <summary>Optional When true, DMS migrates LONG values as VARCHAR.</summary>
    [JsonPropertyName("mapLongVarcharAs")]
    public string? MapLongVarcharAs { get; set; }

    /// <summary>Specifies the maximum size (in KB) of any .csv file used to transfer data to PostgreSQL. Default is 32,768 KB.</summary>
    [JsonPropertyName("maxFileSize")]
    public double? MaxFileSize { get; set; }

    /// <summary>Specifies the plugin to use to create a replication slot. Valid values: pglogical, test_decoding.</summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>Sets the name of a previously created logical replication slot for a CDC load of the PostgreSQL source instance.</summary>
    [JsonPropertyName("slotName")]
    public string? SlotName { get; set; }
}

/// <summary>The password provided with the auth-role and auth-token options of the AuthType setting for a Redis target endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecInitProviderRedisSettingsAuthPasswordSecretRef
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
public partial class V1beta1EndpointSpecInitProviderRedisSettings
{
    /// <summary>The password provided with the auth-role and auth-token options of the AuthType setting for a Redis target endpoint.</summary>
    [JsonPropertyName("authPasswordSecretRef")]
    public V1beta1EndpointSpecInitProviderRedisSettingsAuthPasswordSecretRef? AuthPasswordSecretRef { get; set; }

    /// <summary>Authentication type to access the MongoDB source endpoint. Default is password.</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>The username provided with the auth-role option of the AuthType setting for a Redis target endpoint.</summary>
    [JsonPropertyName("authUserName")]
    public string? AuthUserName { get; set; }

    /// <summary>Port used by the endpoint database.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Host name of the server.</summary>
    [JsonPropertyName("serverName")]
    public string? ServerName { get; set; }

    /// <summary>The Amazon Resource Name (ARN) for the certificate authority (CA) that DMS uses to connect to your Redis target endpoint.</summary>
    [JsonPropertyName("sslCaCertificateArn")]
    public string? SslCaCertificateArn { get; set; }

    /// <summary>The plaintext option doesn't provide Transport Layer Security (TLS) encryption for traffic between endpoint and database. Options include plaintext, ssl-encryption. The default is ssl-encryption.</summary>
    [JsonPropertyName("sslSecurityProtocol")]
    public string? SslSecurityProtocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecInitProviderRedshiftSettings
{
    /// <summary>Custom S3 Bucket Object prefix for intermediate storage.</summary>
    [JsonPropertyName("bucketFolder")]
    public string? BucketFolder { get; set; }

    /// <summary>Custom S3 Bucket name for intermediate storage.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>The server-side encryption mode that you want to encrypt your intermediate .csv object files copied to S3. Defaults to SSE_S3. Valid values are SSE_S3 and SSE_KMS.</summary>
    [JsonPropertyName("encryptionMode")]
    public string? EncryptionMode { get; set; }

    /// <summary>ARN or Id of KMS Key to use when encryption_mode is SSE_KMS.</summary>
    [JsonPropertyName("serverSideEncryptionKmsKeyId")]
    public string? ServerSideEncryptionKmsKeyId { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the IAM Role with permissions to read from or write to the S3 Bucket for intermediate storage.</summary>
    [JsonPropertyName("serviceAccessRoleArn")]
    public string? ServiceAccessRoleArn { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecInitProviderSecretsManagerAccessRoleArnRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate secretsManagerAccessRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecInitProviderSecretsManagerAccessRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointSpecInitProviderSecretsManagerAccessRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecInitProviderSecretsManagerAccessRoleArnSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate secretsManagerAccessRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecInitProviderSecretsManagerAccessRoleArnSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointSpecInitProviderSecretsManagerAccessRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecInitProviderServiceAccessRoleRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceAccessRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecInitProviderServiceAccessRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointSpecInitProviderServiceAccessRoleRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecInitProviderServiceAccessRoleSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceAccessRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecInitProviderServiceAccessRoleSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointSpecInitProviderServiceAccessRoleSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecInitProvider
{
    /// <summary>ARN for the certificate.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }

    /// <summary>Name of the endpoint database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Configuration block for OpenSearch settings. See below.</summary>
    [JsonPropertyName("elasticsearchSettings")]
    public IList<V1beta1EndpointSpecInitProviderElasticsearchSettings>? ElasticsearchSettings { get; set; }

    /// <summary>Type of endpoint. Valid values are source, target.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>Type of engine for the endpoint. Valid values are aurora, aurora-postgresql, aurora-serverless, aurora-postgresql-serverless,azuredb, azure-sql-managed-instance, babelfish, db2, db2-zos, docdb, dynamodb, elasticsearch, kafka, kinesis, mariadb, mongodb, mysql, opensearch, oracle, postgres, redshift,redshift-serverless, s3, sqlserver, neptune ,sybase. Please note that some of engine names are available only for target endpoint type (e.g. redshift).</summary>
    [JsonPropertyName("engineName")]
    public string? EngineName { get; set; }

    /// <summary>Additional attributes associated with the connection. For available attributes for a source Endpoint, see Sources for data migration. For available attributes for a target Endpoint, see Targets for data migration.</summary>
    [JsonPropertyName("extraConnectionAttributes")]
    public string? ExtraConnectionAttributes { get; set; }

    /// <summary>Configuration block for Kafka settings. See below.</summary>
    [JsonPropertyName("kafkaSettings")]
    public IList<V1beta1EndpointSpecInitProviderKafkaSettings>? KafkaSettings { get; set; }

    /// <summary>Configuration block for Kinesis settings. See below.</summary>
    [JsonPropertyName("kinesisSettings")]
    public IList<V1beta1EndpointSpecInitProviderKinesisSettings>? KinesisSettings { get; set; }

    /// <summary>ARN for the KMS key that will be used to encrypt the connection parameters. If you do not specify a value for kms_key_arn, then AWS DMS will use your default encryption key. AWS KMS creates the default encryption key for your AWS account. Your AWS account has a different default encryption key for each AWS region. When engine_name is redshift, kms_key_arn is the KMS Key for the Redshift target and the parameter redshift_settings.server_side_encryption_kms_key_id encrypts the S3 intermediate storage.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1EndpointSpecInitProviderKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1EndpointSpecInitProviderKmsKeyArnSelector? KmsKeyArnSelector { get; set; }

    /// <summary>Configuration block for MongoDB settings. See below.</summary>
    [JsonPropertyName("mongodbSettings")]
    public IList<V1beta1EndpointSpecInitProviderMongodbSettings>? MongodbSettings { get; set; }

    /// <summary>Password to be used to login to the endpoint database.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1EndpointSpecInitProviderPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>Only tasks paused by the resource will be restarted after the modification completes. Default is false.</summary>
    [JsonPropertyName("pauseReplicationTasks")]
    public bool? PauseReplicationTasks { get; set; }

    /// <summary>Port used by the endpoint database.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Configuration block for Postgres settings. See below.</summary>
    [JsonPropertyName("postgresSettings")]
    public IList<V1beta1EndpointSpecInitProviderPostgresSettings>? PostgresSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("redisSettings")]
    public IList<V1beta1EndpointSpecInitProviderRedisSettings>? RedisSettings { get; set; }

    /// <summary>Configuration block for Redshift settings. See below.</summary>
    [JsonPropertyName("redshiftSettings")]
    public IList<V1beta1EndpointSpecInitProviderRedshiftSettings>? RedshiftSettings { get; set; }

    /// <summary>ARN of the IAM role that specifies AWS DMS as the trusted entity and has the required permissions to access the value in the Secrets Manager secret referred to by secrets_manager_arn. The role must allow the iam:PassRole action.</summary>
    [JsonPropertyName("secretsManagerAccessRoleArn")]
    public string? SecretsManagerAccessRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate secretsManagerAccessRoleArn.</summary>
    [JsonPropertyName("secretsManagerAccessRoleArnRef")]
    public V1beta1EndpointSpecInitProviderSecretsManagerAccessRoleArnRef? SecretsManagerAccessRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate secretsManagerAccessRoleArn.</summary>
    [JsonPropertyName("secretsManagerAccessRoleArnSelector")]
    public V1beta1EndpointSpecInitProviderSecretsManagerAccessRoleArnSelector? SecretsManagerAccessRoleArnSelector { get; set; }

    /// <summary>text values for username, password , server_name, and port. You can't specify both.</summary>
    [JsonPropertyName("secretsManagerArn")]
    public string? SecretsManagerArn { get; set; }

    /// <summary>Host name of the server.</summary>
    [JsonPropertyName("serverName")]
    public string? ServerName { get; set; }

    /// <summary>ARN used by the service access IAM role for dynamodb endpoints.</summary>
    [JsonPropertyName("serviceAccessRole")]
    public string? ServiceAccessRole { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceAccessRole.</summary>
    [JsonPropertyName("serviceAccessRoleRef")]
    public V1beta1EndpointSpecInitProviderServiceAccessRoleRef? ServiceAccessRoleRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceAccessRole.</summary>
    [JsonPropertyName("serviceAccessRoleSelector")]
    public V1beta1EndpointSpecInitProviderServiceAccessRoleSelector? ServiceAccessRoleSelector { get; set; }

    /// <summary>SSL mode to use for the connection. Valid values are none, require, verify-ca, verify-full</summary>
    [JsonPropertyName("sslMode")]
    public string? SslMode { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>User name to be used to login to the endpoint database.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecProviderConfigRefPolicy
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
public partial class V1beta1EndpointSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>EndpointSpec defines the desired state of Endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1EndpointSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1EndpointSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1EndpointSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1EndpointSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointStatusAtProviderElasticsearchSettings
{
    /// <summary>Endpoint for the OpenSearch cluster.</summary>
    [JsonPropertyName("endpointUri")]
    public string? EndpointUri { get; set; }

    /// <summary>Maximum number of seconds for which DMS retries failed API requests to the OpenSearch cluster. Default is 300.</summary>
    [JsonPropertyName("errorRetryDuration")]
    public double? ErrorRetryDuration { get; set; }

    /// <summary>Maximum percentage of records that can fail to be written before a full load operation stops. Default is 10.</summary>
    [JsonPropertyName("fullLoadErrorPercentage")]
    public double? FullLoadErrorPercentage { get; set; }

    /// <summary>ARN of the IAM Role with permissions to write to the OpenSearch cluster.</summary>
    [JsonPropertyName("serviceAccessRoleArn")]
    public string? ServiceAccessRoleArn { get; set; }

    /// <summary>Enable to migrate documentation using the documentation type _doc. OpenSearch and an Elasticsearch clusters only support the _doc documentation type in versions 7.x and later. The default value is false.</summary>
    [JsonPropertyName("useNewMappingType")]
    public bool? UseNewMappingType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointStatusAtProviderKafkaSettings
{
    /// <summary>Kafka broker location. Specify in the form broker-hostname-or-ip:port.</summary>
    [JsonPropertyName("broker")]
    public string? Broker { get; set; }

    /// <summary>Shows detailed control information for table definition, column definition, and table and column changes in the Kafka message output. Default is false.</summary>
    [JsonPropertyName("includeControlDetails")]
    public bool? IncludeControlDetails { get; set; }

    /// <summary>Include NULL and empty columns for records migrated to the endpoint. Default is false.</summary>
    [JsonPropertyName("includeNullAndEmpty")]
    public bool? IncludeNullAndEmpty { get; set; }

    /// <summary>Shows the partition value within the Kafka message output unless the partition type is schema-table-type. Default is false.</summary>
    [JsonPropertyName("includePartitionValue")]
    public bool? IncludePartitionValue { get; set; }

    /// <summary>Includes any data definition language (DDL) operations that change the table in the control data, such as rename-table, drop-table, add-column, drop-column, and rename-column. Default is false.</summary>
    [JsonPropertyName("includeTableAlterOperations")]
    public bool? IncludeTableAlterOperations { get; set; }

    /// <summary>Provides detailed transaction information from the source database. This information includes a commit timestamp, a log position, and values for transaction_id, previous transaction_id, and transaction_record_id (the record offset within a transaction). Default is false.</summary>
    [JsonPropertyName("includeTransactionDetails")]
    public bool? IncludeTransactionDetails { get; set; }

    /// <summary>Output format for the records created on the endpoint. Message format is JSON (default) or JSON_UNFORMATTED (a single line with no tab).</summary>
    [JsonPropertyName("messageFormat")]
    public string? MessageFormat { get; set; }

    /// <summary>Maximum size in bytes for records created on the endpoint Default is 1,000,000.</summary>
    [JsonPropertyName("messageMaxBytes")]
    public double? MessageMaxBytes { get; set; }

    /// <summary>Set this optional parameter to true to avoid adding a '0x' prefix to raw data in hexadecimal format. For example, by default, AWS DMS adds a '0x' prefix to the LOB column type in hexadecimal format moving from an Oracle source to a Kafka target. Use the no_hex_prefix endpoint setting to enable migration of RAW data type columns without adding the '0x' prefix.</summary>
    [JsonPropertyName("noHexPrefix")]
    public bool? NoHexPrefix { get; set; }

    /// <summary>Prefixes schema and table names to partition values, when the partition type is primary-key-type. Doing this increases data distribution among Kafka partitions. For example, suppose that a SysBench schema has thousands of tables and each table has only limited range for a primary key. In this case, the same primary key is sent from thousands of tables to the same partition, which causes throttling. Default is false.</summary>
    [JsonPropertyName("partitionIncludeSchemaTable")]
    public bool? PartitionIncludeSchemaTable { get; set; }

    /// <summary>For SASL/SSL authentication, AWS DMS supports the scram-sha-512 mechanism by default. AWS DMS versions 3.5.0 and later also support the PLAIN mechanism. To use the PLAIN mechanism, set this parameter to plain.</summary>
    [JsonPropertyName("saslMechanism")]
    public string? SaslMechanism { get; set; }

    /// <summary>Secure user name you created when you first set up your MSK cluster to validate a client identity and make an encrypted connection between server and client using SASL-SSL authentication.</summary>
    [JsonPropertyName("saslUsername")]
    public string? SaslUsername { get; set; }

    /// <summary>Set secure connection to a Kafka target endpoint using Transport Layer Security (TLS). Options include ssl-encryption, ssl-authentication, and sasl-ssl. sasl-ssl requires sasl_username and sasl_password.</summary>
    [JsonPropertyName("securityProtocol")]
    public string? SecurityProtocol { get; set; }

    /// <summary>ARN for the private certificate authority (CA) cert that AWS DMS uses to securely connect to your Kafka target endpoint.</summary>
    [JsonPropertyName("sslCaCertificateArn")]
    public string? SslCaCertificateArn { get; set; }

    /// <summary>ARN of the client certificate used to securely connect to a Kafka target endpoint.</summary>
    [JsonPropertyName("sslClientCertificateArn")]
    public string? SslClientCertificateArn { get; set; }

    /// <summary>ARN for the client private key used to securely connect to a Kafka target endpoint.</summary>
    [JsonPropertyName("sslClientKeyArn")]
    public string? SslClientKeyArn { get; set; }

    /// <summary>Kafka topic for migration. Default is kafka-default-topic.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointStatusAtProviderKinesisSettings
{
    /// <summary>Shows detailed control information for table definition, column definition, and table and column changes in the Kinesis message output. Default is false.</summary>
    [JsonPropertyName("includeControlDetails")]
    public bool? IncludeControlDetails { get; set; }

    /// <summary>Include NULL and empty columns in the target. Default is false.</summary>
    [JsonPropertyName("includeNullAndEmpty")]
    public bool? IncludeNullAndEmpty { get; set; }

    /// <summary>Shows the partition value within the Kinesis message output, unless the partition type is schema-table-type. Default is false.</summary>
    [JsonPropertyName("includePartitionValue")]
    public bool? IncludePartitionValue { get; set; }

    /// <summary>Includes any data definition language (DDL) operations that change the table in the control data. Default is false.</summary>
    [JsonPropertyName("includeTableAlterOperations")]
    public bool? IncludeTableAlterOperations { get; set; }

    /// <summary>Provides detailed transaction information from the source database. Default is false.</summary>
    [JsonPropertyName("includeTransactionDetails")]
    public bool? IncludeTransactionDetails { get; set; }

    /// <summary>Output format for the records created. Default is json. Valid values are json and json-unformatted (a single line with no tab).</summary>
    [JsonPropertyName("messageFormat")]
    public string? MessageFormat { get; set; }

    /// <summary>Prefixes schema and table names to partition values, when the partition type is primary-key-type. Default is false.</summary>
    [JsonPropertyName("partitionIncludeSchemaTable")]
    public bool? PartitionIncludeSchemaTable { get; set; }

    /// <summary>ARN of the IAM Role with permissions to write to the Kinesis data stream.</summary>
    [JsonPropertyName("serviceAccessRoleArn")]
    public string? ServiceAccessRoleArn { get; set; }

    /// <summary>ARN of the Kinesis data stream.</summary>
    [JsonPropertyName("streamArn")]
    public string? StreamArn { get; set; }

    /// <summary>Use up to 18 digit int instead of casting ints as doubles, available from AWS DMS version 3.5.4. Default is false.</summary>
    [JsonPropertyName("useLargeIntegerValue")]
    public bool? UseLargeIntegerValue { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointStatusAtProviderMongodbSettings
{
    /// <summary>Authentication mechanism to access the MongoDB source endpoint. Default is default.</summary>
    [JsonPropertyName("authMechanism")]
    public string? AuthMechanism { get; set; }

    /// <summary>Authentication database name. Not used when auth_type is no. Default is admin.</summary>
    [JsonPropertyName("authSource")]
    public string? AuthSource { get; set; }

    /// <summary>Authentication type to access the MongoDB source endpoint. Default is password.</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>Number of documents to preview to determine the document organization. Use this setting when nesting_level is set to one. Default is 1000.</summary>
    [JsonPropertyName("docsToInvestigate")]
    public string? DocsToInvestigate { get; set; }

    /// <summary>Document ID. Use this setting when nesting_level is set to none. Default is false.</summary>
    [JsonPropertyName("extractDocId")]
    public string? ExtractDocId { get; set; }

    /// <summary>Specifies either document or table mode. Default is none. Valid values are one (table mode) and none (document mode).</summary>
    [JsonPropertyName("nestingLevel")]
    public string? NestingLevel { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointStatusAtProviderPostgresSettings
{
    /// <summary>For use with change data capture (CDC) only, this attribute has AWS DMS bypass foreign keys and user triggers to reduce the time it takes to bulk load data.</summary>
    [JsonPropertyName("afterConnectScript")]
    public string? AfterConnectScript { get; set; }

    /// <summary>The Babelfish for Aurora PostgreSQL database name for the endpoint.</summary>
    [JsonPropertyName("babelfishDatabaseName")]
    public string? BabelfishDatabaseName { get; set; }

    /// <summary>To capture DDL events, AWS DMS creates various artifacts in the PostgreSQL database when the task starts.</summary>
    [JsonPropertyName("captureDdls")]
    public bool? CaptureDdls { get; set; }

    /// <summary>Specifies the default behavior of the replication's handling of PostgreSQL- compatible endpoints that require some additional configuration, such as Babelfish endpoints.</summary>
    [JsonPropertyName("databaseMode")]
    public string? DatabaseMode { get; set; }

    /// <summary>Sets the schema in which the operational DDL database artifacts are created. Default is public.</summary>
    [JsonPropertyName("ddlArtifactsSchema")]
    public string? DdlArtifactsSchema { get; set; }

    /// <summary>Sets the client statement timeout for the PostgreSQL instance, in seconds. Default value is 60.</summary>
    [JsonPropertyName("executeTimeout")]
    public double? ExecuteTimeout { get; set; }

    /// <summary>When set to true, this value causes a task to fail if the actual size of a LOB column is greater than the specified LobMaxSize. Default is false.</summary>
    [JsonPropertyName("failTasksOnLobTruncation")]
    public bool? FailTasksOnLobTruncation { get; set; }

    /// <summary>The write-ahead log (WAL) heartbeat feature mimics a dummy transaction. By doing this, it prevents idle logical replication slots from holding onto old WAL logs, which can result in storage full situations on the source.</summary>
    [JsonPropertyName("heartbeatEnable")]
    public bool? HeartbeatEnable { get; set; }

    /// <summary>Sets the WAL heartbeat frequency (in minutes). Default value is 5.</summary>
    [JsonPropertyName("heartbeatFrequency")]
    public double? HeartbeatFrequency { get; set; }

    /// <summary>Sets the schema in which the heartbeat artifacts are created. Default value is public.</summary>
    [JsonPropertyName("heartbeatSchema")]
    public string? HeartbeatSchema { get; set; }

    /// <summary>You can use PostgreSQL endpoint settings to map a boolean as a boolean from your PostgreSQL source to a Amazon Redshift target. Default value is false.</summary>
    [JsonPropertyName("mapBooleanAsBoolean")]
    public bool? MapBooleanAsBoolean { get; set; }

    /// <summary>Optional When true, DMS migrates JSONB values as CLOB.</summary>
    [JsonPropertyName("mapJsonbAsClob")]
    public bool? MapJsonbAsClob { get; set; }

    /// <summary>Optional When true, DMS migrates LONG values as VARCHAR.</summary>
    [JsonPropertyName("mapLongVarcharAs")]
    public string? MapLongVarcharAs { get; set; }

    /// <summary>Specifies the maximum size (in KB) of any .csv file used to transfer data to PostgreSQL. Default is 32,768 KB.</summary>
    [JsonPropertyName("maxFileSize")]
    public double? MaxFileSize { get; set; }

    /// <summary>Specifies the plugin to use to create a replication slot. Valid values: pglogical, test_decoding.</summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>Sets the name of a previously created logical replication slot for a CDC load of the PostgreSQL source instance.</summary>
    [JsonPropertyName("slotName")]
    public string? SlotName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointStatusAtProviderRedisSettings
{
    /// <summary>Authentication type to access the MongoDB source endpoint. Default is password.</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>The username provided with the auth-role option of the AuthType setting for a Redis target endpoint.</summary>
    [JsonPropertyName("authUserName")]
    public string? AuthUserName { get; set; }

    /// <summary>Port used by the endpoint database.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Host name of the server.</summary>
    [JsonPropertyName("serverName")]
    public string? ServerName { get; set; }

    /// <summary>The Amazon Resource Name (ARN) for the certificate authority (CA) that DMS uses to connect to your Redis target endpoint.</summary>
    [JsonPropertyName("sslCaCertificateArn")]
    public string? SslCaCertificateArn { get; set; }

    /// <summary>The plaintext option doesn't provide Transport Layer Security (TLS) encryption for traffic between endpoint and database. Options include plaintext, ssl-encryption. The default is ssl-encryption.</summary>
    [JsonPropertyName("sslSecurityProtocol")]
    public string? SslSecurityProtocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointStatusAtProviderRedshiftSettings
{
    /// <summary>Custom S3 Bucket Object prefix for intermediate storage.</summary>
    [JsonPropertyName("bucketFolder")]
    public string? BucketFolder { get; set; }

    /// <summary>Custom S3 Bucket name for intermediate storage.</summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>The server-side encryption mode that you want to encrypt your intermediate .csv object files copied to S3. Defaults to SSE_S3. Valid values are SSE_S3 and SSE_KMS.</summary>
    [JsonPropertyName("encryptionMode")]
    public string? EncryptionMode { get; set; }

    /// <summary>ARN or Id of KMS Key to use when encryption_mode is SSE_KMS.</summary>
    [JsonPropertyName("serverSideEncryptionKmsKeyId")]
    public string? ServerSideEncryptionKmsKeyId { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the IAM Role with permissions to read from or write to the S3 Bucket for intermediate storage.</summary>
    [JsonPropertyName("serviceAccessRoleArn")]
    public string? ServiceAccessRoleArn { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointStatusAtProvider
{
    /// <summary>ARN for the certificate.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }

    /// <summary>Name of the endpoint database.</summary>
    [JsonPropertyName("databaseName")]
    public string? DatabaseName { get; set; }

    /// <summary>Configuration block for OpenSearch settings. See below.</summary>
    [JsonPropertyName("elasticsearchSettings")]
    public IList<V1beta1EndpointStatusAtProviderElasticsearchSettings>? ElasticsearchSettings { get; set; }

    /// <summary>ARN for the endpoint.</summary>
    [JsonPropertyName("endpointArn")]
    public string? EndpointArn { get; set; }

    /// <summary>Type of endpoint. Valid values are source, target.</summary>
    [JsonPropertyName("endpointType")]
    public string? EndpointType { get; set; }

    /// <summary>Type of engine for the endpoint. Valid values are aurora, aurora-postgresql, aurora-serverless, aurora-postgresql-serverless,azuredb, azure-sql-managed-instance, babelfish, db2, db2-zos, docdb, dynamodb, elasticsearch, kafka, kinesis, mariadb, mongodb, mysql, opensearch, oracle, postgres, redshift,redshift-serverless, s3, sqlserver, neptune ,sybase. Please note that some of engine names are available only for target endpoint type (e.g. redshift).</summary>
    [JsonPropertyName("engineName")]
    public string? EngineName { get; set; }

    /// <summary>Additional attributes associated with the connection. For available attributes for a source Endpoint, see Sources for data migration. For available attributes for a target Endpoint, see Targets for data migration.</summary>
    [JsonPropertyName("extraConnectionAttributes")]
    public string? ExtraConnectionAttributes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configuration block for Kafka settings. See below.</summary>
    [JsonPropertyName("kafkaSettings")]
    public IList<V1beta1EndpointStatusAtProviderKafkaSettings>? KafkaSettings { get; set; }

    /// <summary>Configuration block for Kinesis settings. See below.</summary>
    [JsonPropertyName("kinesisSettings")]
    public IList<V1beta1EndpointStatusAtProviderKinesisSettings>? KinesisSettings { get; set; }

    /// <summary>ARN for the KMS key that will be used to encrypt the connection parameters. If you do not specify a value for kms_key_arn, then AWS DMS will use your default encryption key. AWS KMS creates the default encryption key for your AWS account. Your AWS account has a different default encryption key for each AWS region. When engine_name is redshift, kms_key_arn is the KMS Key for the Redshift target and the parameter redshift_settings.server_side_encryption_kms_key_id encrypts the S3 intermediate storage.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Configuration block for MongoDB settings. See below.</summary>
    [JsonPropertyName("mongodbSettings")]
    public IList<V1beta1EndpointStatusAtProviderMongodbSettings>? MongodbSettings { get; set; }

    /// <summary>Only tasks paused by the resource will be restarted after the modification completes. Default is false.</summary>
    [JsonPropertyName("pauseReplicationTasks")]
    public bool? PauseReplicationTasks { get; set; }

    /// <summary>Port used by the endpoint database.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Configuration block for Postgres settings. See below.</summary>
    [JsonPropertyName("postgresSettings")]
    public IList<V1beta1EndpointStatusAtProviderPostgresSettings>? PostgresSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("redisSettings")]
    public IList<V1beta1EndpointStatusAtProviderRedisSettings>? RedisSettings { get; set; }

    /// <summary>Configuration block for Redshift settings. See below.</summary>
    [JsonPropertyName("redshiftSettings")]
    public IList<V1beta1EndpointStatusAtProviderRedshiftSettings>? RedshiftSettings { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>ARN of the IAM role that specifies AWS DMS as the trusted entity and has the required permissions to access the value in the Secrets Manager secret referred to by secrets_manager_arn. The role must allow the iam:PassRole action.</summary>
    [JsonPropertyName("secretsManagerAccessRoleArn")]
    public string? SecretsManagerAccessRoleArn { get; set; }

    /// <summary>text values for username, password , server_name, and port. You can't specify both.</summary>
    [JsonPropertyName("secretsManagerArn")]
    public string? SecretsManagerArn { get; set; }

    /// <summary>Host name of the server.</summary>
    [JsonPropertyName("serverName")]
    public string? ServerName { get; set; }

    /// <summary>ARN used by the service access IAM role for dynamodb endpoints.</summary>
    [JsonPropertyName("serviceAccessRole")]
    public string? ServiceAccessRole { get; set; }

    /// <summary>SSL mode to use for the connection. Valid values are none, require, verify-ca, verify-full</summary>
    [JsonPropertyName("sslMode")]
    public string? SslMode { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>User name to be used to login to the endpoint database.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointStatusConditions
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

/// <summary>EndpointStatus defines the observed state of Endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1EndpointStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1EndpointStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Endpoint is the Schema for the Endpoints API. Provides a DMS (Data Migration Service) endpoint resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Endpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1EndpointSpec>, IStatus<V1beta1EndpointStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Endpoint";
    public const string KubeGroup = "dms.aws.upbound.io";
    public const string KubePluralName = "endpoints";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EndpointSpec defines the desired state of Endpoint</summary>
    [JsonPropertyName("spec")]
    public V1beta1EndpointSpec Spec { get; set; }

    /// <summary>EndpointStatus defines the observed state of Endpoint.</summary>
    [JsonPropertyName("status")]
    public V1beta1EndpointStatus? Status { get; set; }
}

/// <summary>Endpoint is the Schema for the Endpoints API. Provides a DMS (Data Migration Service) endpoint resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EndpointList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Endpoint>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EndpointList";
    public const string KubeGroup = "dms.aws.upbound.io";
    public const string KubePluralName = "endpoints";
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
    public IList<V1beta1Endpoint> Items { get; set; }
}