using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.postgresql.cnpg.io;
public enum V1ScheduledBackupSpecBackupOwnerReferenceEnum
{
    [EnumMember(Value = "none"), JsonStringEnumMemberName("none")]
    /// <summary>none</summary>
    None,
    [EnumMember(Value = "self"), JsonStringEnumMemberName("self")]
    /// <summary>self</summary>
    Self,
    [EnumMember(Value = "cluster"), JsonStringEnumMemberName("cluster")]
    /// <summary>cluster</summary>
    Cluster
}

public partial class V1ScheduledBackupSpecCluster
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public enum V1ScheduledBackupSpecMethodEnum
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

public partial class V1ScheduledBackupSpecOnlineConfiguration
{
    /// <summary>Control whether the I/O workload for the backup initial checkpoint will be limited, according to the `checkpoint_completion_target` setting on the PostgreSQL server. If set to true, an immediate checkpoint will be used, meaning PostgreSQL will complete the checkpoint as soon as possible. `false` by default.</summary>
    [JsonPropertyName("immediateCheckpoint")]
    public bool? ImmediateCheckpoint { get; set; }

    /// <summary>If false, the function will return immediately after the backup is completed, without waiting for WAL to be archived. This behavior is only useful with backup software that independently monitors WAL archiving. Otherwise, WAL required to make the backup consistent might be missing and make the backup useless. By default, or when this parameter is true, pg_backup_stop will wait for WAL to be archived when archiving is enabled. On a standby, this means that it will wait only when archive_mode = always. If write activity on the primary is low, it may be useful to run pg_switch_wal on the primary in order to trigger an immediate segment switch.</summary>
    [JsonPropertyName("waitForArchive")]
    public bool? WaitForArchive { get; set; }
}

public partial class V1ScheduledBackupSpecPluginConfiguration
{
    /// <summary>Name is the name of the plugin managing this backup</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Parameters are the configuration parameters passed to the backup plugin for this backup</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}

public enum V1ScheduledBackupSpecTargetEnum
{
    [EnumMember(Value = "primary"), JsonStringEnumMemberName("primary")]
    /// <summary>primary</summary>
    Primary,
    [EnumMember(Value = "prefer-standby"), JsonStringEnumMemberName("prefer-standby")]
    /// <summary>prefer-standby</summary>
    PreferStandby
}

public partial class V1ScheduledBackupSpec
{
    /// <summary>Indicates which ownerReference should be put inside the created backup resources.&lt;br /&gt; - none: no owner reference for created backup objects (same behavior as before the field was introduced)&lt;br /&gt; - self: sets the Scheduled backup object as owner of the backup&lt;br /&gt; - cluster: set the cluster as owner of the backup&lt;br /&gt;</summary>
    [JsonPropertyName("backupOwnerReference")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1ScheduledBackupSpecBackupOwnerReferenceEnum>))]
    public V1ScheduledBackupSpecBackupOwnerReferenceEnum? BackupOwnerReference { get; set; }

    /// <summary>The cluster to backup</summary>
    [JsonPropertyName("cluster")]
    public V1ScheduledBackupSpecCluster Cluster { get; set; }

    /// <summary>If the first backup has to be immediately start after creation or not</summary>
    [JsonPropertyName("immediate")]
    public bool? Immediate { get; set; }

    /// <summary>The backup method to be used, possible options are `barmanObjectStore`, `volumeSnapshot` or `plugin`. Defaults to: `barmanObjectStore`.</summary>
    [JsonPropertyName("method")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1ScheduledBackupSpecMethodEnum>))]
    public V1ScheduledBackupSpecMethodEnum? Method { get; set; }

    /// <summary>Whether the default type of backup with volume snapshots is online/hot (`true`, default) or offline/cold (`false`) Overrides the default setting specified in the cluster field '.spec.backup.volumeSnapshot.online'</summary>
    [JsonPropertyName("online")]
    public bool? Online { get; set; }

    /// <summary>Configuration parameters to control the online/hot backup with volume snapshots Overrides the default settings specified in the cluster '.backup.volumeSnapshot.onlineConfiguration' stanza</summary>
    [JsonPropertyName("onlineConfiguration")]
    public V1ScheduledBackupSpecOnlineConfiguration? OnlineConfiguration { get; set; }

    /// <summary>Configuration parameters passed to the plugin managing this backup</summary>
    [JsonPropertyName("pluginConfiguration")]
    public V1ScheduledBackupSpecPluginConfiguration? PluginConfiguration { get; set; }

    /// <summary>The schedule does not follow the same format used in Kubernetes CronJobs as it includes an additional seconds specifier, see https://pkg.go.dev/github.com/robfig/cron#hdr-CRON_Expression_Format</summary>
    [JsonPropertyName("schedule")]
    public string Schedule { get; set; }

    /// <summary>If this backup is suspended or not</summary>
    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }

    /// <summary>The policy to decide which instance should perform this backup. If empty, it defaults to `cluster.spec.backup.target`. Available options are empty string, `primary` and `prefer-standby`. `primary` to have backups run always on primary instances, `prefer-standby` to have backups run preferably on the most updated standby, if available.</summary>
    [JsonPropertyName("target")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1ScheduledBackupSpecTargetEnum>))]
    public V1ScheduledBackupSpecTargetEnum? Target { get; set; }
}

public partial class V1ScheduledBackupStatus
{
    /// <summary>The latest time the schedule</summary>
    [JsonPropertyName("lastCheckTime")]
    public string? LastCheckTime { get; set; }

    /// <summary>Information when was the last time that backup was successfully scheduled.</summary>
    [JsonPropertyName("lastScheduleTime")]
    public string? LastScheduleTime { get; set; }

    /// <summary>Next time we will run a backup</summary>
    [JsonPropertyName("nextScheduleTime")]
    public string? NextScheduleTime { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ScheduledBackup : IKubernetesObject<V1ObjectMeta>, ISpec<V1ScheduledBackupSpec>, IStatus<V1ScheduledBackupStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ScheduledBackup";
    public const string KubeGroup = "postgresql.cnpg.io";
    public const string KubePluralName = "scheduledbackups";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Specification of the desired behavior of the ScheduledBackup. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
    [JsonPropertyName("spec")]
    public V1ScheduledBackupSpec Spec { get; set; }

    /// <summary>Most recently observed status of the ScheduledBackup. This data may not be up to date. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status</summary>
    [JsonPropertyName("status")]
    public V1ScheduledBackupStatus? Status { get; set; }
}