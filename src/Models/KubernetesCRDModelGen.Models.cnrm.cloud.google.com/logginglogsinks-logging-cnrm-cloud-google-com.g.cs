using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.logging.cnrm.cloud.google.com;
public partial class V1beta1LoggingLogSinkSpecBigqueryOptions
{
    /// <summary>Whether to use BigQuery's partition tables. By default, Logging creates dated tables based on the log entries' timestamps, e.g. syslog_20170523. With partitioned tables the date suffix is no longer present and special query syntax has to be used instead. In both cases, tables are sharded based on UTC timezone.</summary>
    [JsonPropertyName("usePartitionedTables")]
    public bool UsePartitionedTables { get; set; }
}

public partial class V1beta1LoggingLogSinkSpecDestinationBigQueryDatasetRef
{
    /// <summary>Allowed value: string of the format `bigquery.googleapis.com/projects/{{project}}/datasets/{{value}}`, where {{value}} is the `name` field of a `BigQueryDataset` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1LoggingLogSinkSpecDestinationLoggingLogBucketRef
{
    /// <summary>Allowed value: string of the format `logging.googleapis.com/projects/{{project}}/locations/{{location}}/buckets/{{value}}`, where {{value}} is the `name` field of a `LoggingLogBucket` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1LoggingLogSinkSpecDestinationPubSubTopicRef
{
    /// <summary>Allowed value: string of the format `pubsub.googleapis.com/projects/{{project}}/topics/{{value}}`, where {{value}} is the `name` field of a `PubSubTopic` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1LoggingLogSinkSpecDestinationStorageBucketRef
{
    /// <summary>Allowed value: string of the format `storage.googleapis.com/{{value}}`, where {{value}} is the `name` field of a `StorageBucket` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1LoggingLogSinkSpecDestination
{
    /// <summary></summary>
    [JsonPropertyName("bigQueryDatasetRef")]
    public V1beta1LoggingLogSinkSpecDestinationBigQueryDatasetRef? BigQueryDatasetRef { get; set; }

    /// <summary>Only `external` field is supported to configure the reference.</summary>
    [JsonPropertyName("loggingLogBucketRef")]
    public V1beta1LoggingLogSinkSpecDestinationLoggingLogBucketRef? LoggingLogBucketRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pubSubTopicRef")]
    public V1beta1LoggingLogSinkSpecDestinationPubSubTopicRef? PubSubTopicRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageBucketRef")]
    public V1beta1LoggingLogSinkSpecDestinationStorageBucketRef? StorageBucketRef { get; set; }
}

public partial class V1beta1LoggingLogSinkSpecExclusions
{
    /// <summary>A description of this exclusion.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If set to True, then this exclusion is disabled and it does not exclude any log entries.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>An advanced logs filter that matches the log entries to be excluded. By using the sample function, you can exclude less than 100% of the matching log entries.</summary>
    [JsonPropertyName("filter")]
    public string Filter { get; set; }

    /// <summary>A client-assigned identifier, such as "load-balancer-exclusion". Identifiers are limited to 100 characters and can include only letters, digits, underscores, hyphens, and periods. First character has to be alphanumeric.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1LoggingLogSinkSpecFolderRef
{
    /// <summary>Allowed value: The `folderId` field of a `Folder` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1LoggingLogSinkSpecOrganizationRef
{
    /// <summary>Allowed value: The `name` field of an `Organization` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1LoggingLogSinkSpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1LoggingLogSinkSpec
{
    /// <summary>Options that affect sinks exporting data to BigQuery.</summary>
    [JsonPropertyName("bigqueryOptions")]
    public V1beta1LoggingLogSinkSpecBigqueryOptions? BigqueryOptions { get; set; }

    /// <summary>A description of this sink. The maximum length of the description is 8000 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("destination")]
    public V1beta1LoggingLogSinkSpecDestination Destination { get; set; }

    /// <summary>If set to True, then this sink is disabled and it does not export any log entries.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>Log entries that match any of the exclusion filters will not be exported. If a log entry is matched by both filter and one of exclusion's filters, it will not be exported.</summary>
    [JsonPropertyName("exclusions")]
    public IList<V1beta1LoggingLogSinkSpecExclusions>? Exclusions { get; set; }

    /// <summary>The filter to apply when exporting logs. Only log entries that match the filter are exported.</summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>The folder in which to create the sink. Only one of projectRef, folderRef, or organizationRef may be specified.</summary>
    [JsonPropertyName("folderRef")]
    public V1beta1LoggingLogSinkSpecFolderRef? FolderRef { get; set; }

    /// <summary>Immutable. Whether or not to include children organizations in the sink export. If true, logs associated with child projects are also exported; otherwise only logs relating to the provided organization are included.</summary>
    [JsonPropertyName("includeChildren")]
    public bool? IncludeChildren { get; set; }

    /// <summary>The organization in which to create the sink. Only one of projectRef, folderRef, or organizationRef may be specified.</summary>
    [JsonPropertyName("organizationRef")]
    public V1beta1LoggingLogSinkSpecOrganizationRef? OrganizationRef { get; set; }

    /// <summary>The project in which to create the sink. Only one of projectRef, folderRef, or organizationRef may be specified.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1LoggingLogSinkSpecProjectRef? ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Whether or not to create a unique identity associated with this sink. If false (the default), then the writer_identity used is serviceAccount:cloud-logs@system.gserviceaccount.com. If true, then a unique service account is created and used for this sink. If you wish to publish logs across projects, you must set unique_writer_identity to true.</summary>
    [JsonPropertyName("uniqueWriterIdentity")]
    public bool? UniqueWriterIdentity { get; set; }
}

public partial class V1beta1LoggingLogSinkStatusConditions
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

public partial class V1beta1LoggingLogSinkStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LoggingLogSinkStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The identity associated with this sink. This identity must be granted write access to the configured destination.</summary>
    [JsonPropertyName("writerIdentity")]
    public string? WriterIdentity { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LoggingLogSink : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LoggingLogSinkSpec>, IStatus<V1beta1LoggingLogSinkStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LoggingLogSink";
    public const string KubeGroup = "logging.cnrm.cloud.google.com";
    public const string KubePluralName = "logginglogsinks";
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
    public V1beta1LoggingLogSinkSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1LoggingLogSinkStatus? Status { get; set; }
}