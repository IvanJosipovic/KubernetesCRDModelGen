using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.postgresql.cnpg.io;
/// <summary>The cluster to backup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BackupSpecCluster
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The backup method to be used, possible options are `barmanObjectStore`, `volumeSnapshot` or `plugin`. Defaults to: `barmanObjectStore`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1BackupSpecMethodEnum
{
    [EnumMember(Value = "barmanObjectStore"), JsonStringEnumMemberName("barmanObjectStore")]
    /// <summary>barmanObjectStore</summary>
    BarmanObjectStore,
    [EnumMember(Value = "volumeSnapshot"), JsonStringEnumMemberName("volumeSnapshot")]
    /// <summary>volumeSnapshot</summary>
    VolumeSnapshot,
    [EnumMember(Value = "plugin"), JsonStringEnumMemberName("plugin")]
    /// <summary>plugin</summary>
    Plugin
}

/// <summary>Configuration parameters to control the online/hot backup with volume snapshots Overrides the default settings specified in the cluster '.backup.volumeSnapshot.onlineConfiguration' stanza</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BackupSpecOnlineConfiguration
{
    /// <summary>Control whether the I/O workload for the backup initial checkpoint will be limited, according to the `checkpoint_completion_target` setting on the PostgreSQL server. If set to true, an immediate checkpoint will be used, meaning PostgreSQL will complete the checkpoint as soon as possible. `false` by default.</summary>
    [JsonPropertyName("immediateCheckpoint")]
    public bool? ImmediateCheckpoint { get; set; }

    /// <summary>If false, the function will return immediately after the backup is completed, without waiting for WAL to be archived. This behavior is only useful with backup software that independently monitors WAL archiving. Otherwise, WAL required to make the backup consistent might be missing and make the backup useless. By default, or when this parameter is true, pg_backup_stop will wait for WAL to be archived when archiving is enabled. On a standby, this means that it will wait only when archive_mode = always. If write activity on the primary is low, it may be useful to run pg_switch_wal on the primary in order to trigger an immediate segment switch.</summary>
    [JsonPropertyName("waitForArchive")]
    public bool? WaitForArchive { get; set; }
}

/// <summary>Configuration parameters passed to the plugin managing this backup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BackupSpecPluginConfiguration
{
    /// <summary>Name is the name of the plugin managing this backup</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Parameters are the configuration parameters passed to the backup plugin for this backup</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

/// <summary>The policy to decide which instance should perform this backup. If empty, it defaults to `cluster.spec.backup.target`. Available options are empty string, `primary` and `prefer-standby`. `primary` to have backups run always on primary instances, `prefer-standby` to have backups run preferably on the most updated standby, if available.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1BackupSpecTargetEnum
{
    [EnumMember(Value = "primary"), JsonStringEnumMemberName("primary")]
    /// <summary>primary</summary>
    Primary,
    [EnumMember(Value = "prefer-standby"), JsonStringEnumMemberName("prefer-standby")]
    /// <summary>prefer-standby</summary>
    PreferStandby
}

/// <summary>Specification of the desired behavior of the backup. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BackupSpec
{
    /// <summary>The cluster to backup</summary>
    [JsonPropertyName("cluster")]
    public V1BackupSpecCluster Cluster { get; set; }

    /// <summary>The backup method to be used, possible options are `barmanObjectStore`, `volumeSnapshot` or `plugin`. Defaults to: `barmanObjectStore`.</summary>
    [JsonPropertyName("method")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1BackupSpecMethodEnum>))]
    public V1BackupSpecMethodEnum? Method { get; set; }

    /// <summary>Whether the default type of backup with volume snapshots is online/hot (`true`, default) or offline/cold (`false`) Overrides the default setting specified in the cluster field '.spec.backup.volumeSnapshot.online'</summary>
    [JsonPropertyName("online")]
    public bool? Online { get; set; }

    /// <summary>Configuration parameters to control the online/hot backup with volume snapshots Overrides the default settings specified in the cluster '.backup.volumeSnapshot.onlineConfiguration' stanza</summary>
    [JsonPropertyName("onlineConfiguration")]
    public V1BackupSpecOnlineConfiguration? OnlineConfiguration { get; set; }

    /// <summary>Configuration parameters passed to the plugin managing this backup</summary>
    [JsonPropertyName("pluginConfiguration")]
    public V1BackupSpecPluginConfiguration? PluginConfiguration { get; set; }

    /// <summary>The policy to decide which instance should perform this backup. If empty, it defaults to `cluster.spec.backup.target`. Available options are empty string, `primary` and `prefer-standby`. `primary` to have backups run always on primary instances, `prefer-standby` to have backups run preferably on the most updated standby, if available.</summary>
    [JsonPropertyName("target")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1BackupSpecTargetEnum>))]
    public V1BackupSpecTargetEnum? Target { get; set; }
}

/// <summary>The connection string to be used</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BackupStatusAzureCredentialsConnectionString
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The storage account where to upload data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BackupStatusAzureCredentialsStorageAccount
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The storage account key to be used in conjunction with the storage account name</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BackupStatusAzureCredentialsStorageKey
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>A shared-access-signature to be used in conjunction with the storage account name</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BackupStatusAzureCredentialsStorageSasToken
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The credentials to use to upload data to Azure Blob Storage</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BackupStatusAzureCredentials
{
    /// <summary>The connection string to be used</summary>
    [JsonPropertyName("connectionString")]
    public V1BackupStatusAzureCredentialsConnectionString? ConnectionString { get; set; }

    /// <summary>Use the Azure AD based authentication without providing explicitly the keys.</summary>
    [JsonPropertyName("inheritFromAzureAD")]
    public bool? InheritFromAzureAD { get; set; }

    /// <summary>The storage account where to upload data</summary>
    [JsonPropertyName("storageAccount")]
    public V1BackupStatusAzureCredentialsStorageAccount? StorageAccount { get; set; }

    /// <summary>The storage account key to be used in conjunction with the storage account name</summary>
    [JsonPropertyName("storageKey")]
    public V1BackupStatusAzureCredentialsStorageKey? StorageKey { get; set; }

    /// <summary>A shared-access-signature to be used in conjunction with the storage account name</summary>
    [JsonPropertyName("storageSasToken")]
    public V1BackupStatusAzureCredentialsStorageSasToken? StorageSasToken { get; set; }
}

/// <summary>EndpointCA store the CA bundle of the barman endpoint. Useful when using self-signed certificates to avoid errors with certificate issuer and barman-cloud-wal-archive.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BackupStatusEndpointCA
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The secret containing the Google Cloud Storage JSON file with the credentials</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BackupStatusGoogleCredentialsApplicationCredentials
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The credentials to use to upload data to Google Cloud Storage</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BackupStatusGoogleCredentials
{
    /// <summary>The secret containing the Google Cloud Storage JSON file with the credentials</summary>
    [JsonPropertyName("applicationCredentials")]
    public V1BackupStatusGoogleCredentialsApplicationCredentials? ApplicationCredentials { get; set; }

    /// <summary>If set to true, will presume that it's running inside a GKE environment, default to false.</summary>
    [JsonPropertyName("gkeEnvironment")]
    public bool? GkeEnvironment { get; set; }
}

/// <summary>Information to identify the instance where the backup has been taken from</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BackupStatusInstanceID
{
    /// <summary>The container ID</summary>
    [JsonPropertyName("ContainerID")]
    public string? ContainerID { get; set; }

    /// <summary>The pod name</summary>
    [JsonPropertyName("podName")]
    public string? PodName { get; set; }
}

/// <summary>The reference to the access key id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BackupStatusS3CredentialsAccessKeyId
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The reference to the secret containing the region name</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BackupStatusS3CredentialsRegion
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The reference to the secret access key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BackupStatusS3CredentialsSecretAccessKey
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The references to the session key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BackupStatusS3CredentialsSessionToken
{
    /// <summary>The key to select</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The credentials to use to upload data to S3</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BackupStatusS3Credentials
{
    /// <summary>The reference to the access key id</summary>
    [JsonPropertyName("accessKeyId")]
    public V1BackupStatusS3CredentialsAccessKeyId? AccessKeyId { get; set; }

    /// <summary>Use the role based authentication without providing explicitly the keys.</summary>
    [JsonPropertyName("inheritFromIAMRole")]
    public bool? InheritFromIAMRole { get; set; }

    /// <summary>The reference to the secret containing the region name</summary>
    [JsonPropertyName("region")]
    public V1BackupStatusS3CredentialsRegion? Region { get; set; }

    /// <summary>The reference to the secret access key</summary>
    [JsonPropertyName("secretAccessKey")]
    public V1BackupStatusS3CredentialsSecretAccessKey? SecretAccessKey { get; set; }

    /// <summary>The references to the session key</summary>
    [JsonPropertyName("sessionToken")]
    public V1BackupStatusS3CredentialsSessionToken? SessionToken { get; set; }
}

/// <summary>BackupSnapshotElementStatus is a volume snapshot that is part of a volume snapshot method backup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BackupStatusSnapshotBackupStatusElements
{
    /// <summary>Name is the snapshot resource name</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>TablespaceName is the name of the snapshotted tablespace. Only set when type is PG_TABLESPACE</summary>
    [JsonPropertyName("tablespaceName")]
    public string? TablespaceName { get; set; }

    /// <summary>Type is tho role of the snapshot in the cluster, such as PG_DATA, PG_WAL and PG_TABLESPACE</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Status of the volumeSnapshot backup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BackupStatusSnapshotBackupStatus
{
    /// <summary>The elements list, populated with the gathered volume snapshots</summary>
    [JsonPropertyName("elements")]
    public IList<V1BackupStatusSnapshotBackupStatusElements>? Elements { get; set; }
}

/// <summary>Most recently observed status of the backup. This data may not be up to date. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BackupStatus
{
    /// <summary>The credentials to use to upload data to Azure Blob Storage</summary>
    [JsonPropertyName("azureCredentials")]
    public V1BackupStatusAzureCredentials? AzureCredentials { get; set; }

    /// <summary>The ID of the Barman backup</summary>
    [JsonPropertyName("backupId")]
    public string? BackupId { get; set; }

    /// <summary>Backup label file content as returned by Postgres in case of online (hot) backups</summary>
    [JsonPropertyName("backupLabelFile")]
    public string? BackupLabelFile { get; set; }

    /// <summary>The Name of the Barman backup</summary>
    [JsonPropertyName("backupName")]
    public string? BackupName { get; set; }

    /// <summary>The starting xlog</summary>
    [JsonPropertyName("beginLSN")]
    public string? BeginLSN { get; set; }

    /// <summary>The starting WAL</summary>
    [JsonPropertyName("beginWal")]
    public string? BeginWal { get; set; }

    /// <summary>The backup command output in case of error</summary>
    [JsonPropertyName("commandError")]
    public string? CommandError { get; set; }

    /// <summary>Unused. Retained for compatibility with old versions.</summary>
    [JsonPropertyName("commandOutput")]
    public string? CommandOutput { get; set; }

    /// <summary>The path where to store the backup (i.e. s3://bucket/path/to/folder) this path, with different destination folders, will be used for WALs and for data. This may not be populated in case of errors.</summary>
    [JsonPropertyName("destinationPath")]
    public string? DestinationPath { get; set; }

    /// <summary>Encryption method required to S3 API</summary>
    [JsonPropertyName("encryption")]
    public string? Encryption { get; set; }

    /// <summary>The ending xlog</summary>
    [JsonPropertyName("endLSN")]
    public string? EndLSN { get; set; }

    /// <summary>The ending WAL</summary>
    [JsonPropertyName("endWal")]
    public string? EndWal { get; set; }

    /// <summary>EndpointCA store the CA bundle of the barman endpoint. Useful when using self-signed certificates to avoid errors with certificate issuer and barman-cloud-wal-archive.</summary>
    [JsonPropertyName("endpointCA")]
    public V1BackupStatusEndpointCA? EndpointCA { get; set; }

    /// <summary>Endpoint to be used to upload data to the cloud, overriding the automatic endpoint discovery</summary>
    [JsonPropertyName("endpointURL")]
    public string? EndpointURL { get; set; }

    /// <summary>The detected error</summary>
    [JsonPropertyName("error")]
    public string? Error { get; set; }

    /// <summary>The credentials to use to upload data to Google Cloud Storage</summary>
    [JsonPropertyName("googleCredentials")]
    public V1BackupStatusGoogleCredentials? GoogleCredentials { get; set; }

    /// <summary>Information to identify the instance where the backup has been taken from</summary>
    [JsonPropertyName("instanceID")]
    public V1BackupStatusInstanceID? InstanceID { get; set; }

    /// <summary>The backup method being used</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Whether the backup was online/hot (`true`) or offline/cold (`false`)</summary>
    [JsonPropertyName("online")]
    public bool? Online { get; set; }

    /// <summary>The last backup status</summary>
    [JsonPropertyName("phase")]
    public string? Phase { get; set; }

    /// <summary>The credentials to use to upload data to S3</summary>
    [JsonPropertyName("s3Credentials")]
    public V1BackupStatusS3Credentials? S3Credentials { get; set; }

    /// <summary>The server name on S3, the cluster name is used if this parameter is omitted</summary>
    [JsonPropertyName("serverName")]
    public string? ServerName { get; set; }

    /// <summary>Status of the volumeSnapshot backup</summary>
    [JsonPropertyName("snapshotBackupStatus")]
    public V1BackupStatusSnapshotBackupStatus? SnapshotBackupStatus { get; set; }

    /// <summary>When the backup was started</summary>
    [JsonPropertyName("startedAt")]
    public string? StartedAt { get; set; }

    /// <summary>When the backup was terminated</summary>
    [JsonPropertyName("stoppedAt")]
    public string? StoppedAt { get; set; }

    /// <summary>Tablespace map file content as returned by Postgres in case of online (hot) backups</summary>
    [JsonPropertyName("tablespaceMapFile")]
    public string? TablespaceMapFile { get; set; }
}

/// <summary>Backup is the Schema for the backups API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Backup : IKubernetesObject<V1ObjectMeta>, ISpec<V1BackupSpec>, IStatus<V1BackupStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Backup";
    public const string KubeGroup = "postgresql.cnpg.io";
    public const string KubePluralName = "backups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Specification of the desired behavior of the backup. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
    [JsonPropertyName("spec")]
    public V1BackupSpec Spec { get; set; }

    /// <summary>Most recently observed status of the backup. This data may not be up to date. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
    [JsonPropertyName("status")]
    public V1BackupStatus? Status { get; set; }
}