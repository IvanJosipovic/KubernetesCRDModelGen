using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.storagetransfer.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1StorageTransferJobList : IKubernetesObject<V1ListMeta>, IItems<V1beta1StorageTransferJob>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "StorageTransferJobList";
    public const string KubeGroup = "storagetransfer.cnrm.cloud.google.com";
    public const string KubePluralName = "storagetransferjobs";
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
    public IList<V1beta1StorageTransferJob> Items { get; set; }
}

/// <summary>The PubSubTopic to which to publish notifications.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageTransferJobSpecNotificationConfigTopicRef
{
    /// <summary>Allowed value: string of the format `projects/{{project}}/topics/{{value}}`, where {{value}} is the `name` field of a `PubSubTopic` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Notification configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageTransferJobSpecNotificationConfig
{
    /// <summary>Event types for which a notification is desired. If empty, send notifications for all event types. The valid types are "TRANSFER_OPERATION_SUCCESS", "TRANSFER_OPERATION_FAILED", "TRANSFER_OPERATION_ABORTED".</summary>
    [JsonPropertyName("eventTypes")]
    public IList<string>? EventTypes { get; set; }

    /// <summary>The desired format of the notification message payloads. One of "NONE" or "JSON".</summary>
    [JsonPropertyName("payloadFormat")]
    public string PayloadFormat { get; set; }

    /// <summary>The PubSubTopic to which to publish notifications.</summary>
    [JsonPropertyName("topicRef")]
    public V1beta1StorageTransferJobSpecNotificationConfigTopicRef TopicRef { get; set; }
}

/// <summary>The last day the recurring transfer will be run. If schedule_end_date is the same as schedule_start_date, the transfer will be executed only once.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageTransferJobSpecScheduleScheduleEndDate
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month.</summary>
    [JsonPropertyName("day")]
    public int Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12.</summary>
    [JsonPropertyName("month")]
    public int Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999.</summary>
    [JsonPropertyName("year")]
    public int Year { get; set; }
}

/// <summary>The first day the recurring transfer is scheduled to run. If schedule_start_date is in the past, the transfer will run for the first time on the following day.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageTransferJobSpecScheduleScheduleStartDate
{
    /// <summary>Day of month. Must be from 1 to 31 and valid for the year and month.</summary>
    [JsonPropertyName("day")]
    public int Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12.</summary>
    [JsonPropertyName("month")]
    public int Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999.</summary>
    [JsonPropertyName("year")]
    public int Year { get; set; }
}

/// <summary>The time in UTC at which the transfer will be scheduled to start in a day. Transfers may start later than this time. If not specified, recurring and one-time transfers that are scheduled to run today will run immediately; recurring transfers that are scheduled to run on a future date will start at approximately midnight UTC on that date. Note that when configuring a transfer with the Cloud Platform Console, the transfer's start time in a day is specified in your local timezone.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageTransferJobSpecScheduleStartTimeOfDay
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public int Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public int Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public int Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public int Seconds { get; set; }
}

/// <summary>Schedule specification defining when the Transfer Job should be scheduled to start, end and what time to run.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageTransferJobSpecSchedule
{
    /// <summary>Interval between the start of each scheduled transfer. If unspecified, the default value is 24 hours. This value may not be less than 1 hour. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("repeatInterval")]
    public string? RepeatInterval { get; set; }

    /// <summary>The last day the recurring transfer will be run. If schedule_end_date is the same as schedule_start_date, the transfer will be executed only once.</summary>
    [JsonPropertyName("scheduleEndDate")]
    public V1beta1StorageTransferJobSpecScheduleScheduleEndDate? ScheduleEndDate { get; set; }

    /// <summary>The first day the recurring transfer is scheduled to run. If schedule_start_date is in the past, the transfer will run for the first time on the following day.</summary>
    [JsonPropertyName("scheduleStartDate")]
    public V1beta1StorageTransferJobSpecScheduleScheduleStartDate ScheduleStartDate { get; set; }

    /// <summary>The time in UTC at which the transfer will be scheduled to start in a day. Transfers may start later than this time. If not specified, recurring and one-time transfers that are scheduled to run today will run immediately; recurring transfers that are scheduled to run on a future date will start at approximately midnight UTC on that date. Note that when configuring a transfer with the Cloud Platform Console, the transfer's start time in a day is specified in your local timezone.</summary>
    [JsonPropertyName("startTimeOfDay")]
    public V1beta1StorageTransferJobSpecScheduleStartTimeOfDay? StartTimeOfDay { get; set; }
}

/// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageTransferJobSpecTransferSpecAwsS3DataSourceAwsAccessKeyAccessKeyIdValueFromSecretKeyRef
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
public partial class V1beta1StorageTransferJobSpecTransferSpecAwsS3DataSourceAwsAccessKeyAccessKeyIdValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1StorageTransferJobSpecTransferSpecAwsS3DataSourceAwsAccessKeyAccessKeyIdValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>AWS Key ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageTransferJobSpecTransferSpecAwsS3DataSourceAwsAccessKeyAccessKeyId
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1StorageTransferJobSpecTransferSpecAwsS3DataSourceAwsAccessKeyAccessKeyIdValueFrom? ValueFrom { get; set; }
}

/// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageTransferJobSpecTransferSpecAwsS3DataSourceAwsAccessKeySecretAccessKeyValueFromSecretKeyRef
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
public partial class V1beta1StorageTransferJobSpecTransferSpecAwsS3DataSourceAwsAccessKeySecretAccessKeyValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1StorageTransferJobSpecTransferSpecAwsS3DataSourceAwsAccessKeySecretAccessKeyValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>AWS Secret Access Key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageTransferJobSpecTransferSpecAwsS3DataSourceAwsAccessKeySecretAccessKey
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1StorageTransferJobSpecTransferSpecAwsS3DataSourceAwsAccessKeySecretAccessKeyValueFrom? ValueFrom { get; set; }
}

/// <summary>AWS credentials block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageTransferJobSpecTransferSpecAwsS3DataSourceAwsAccessKey
{
    /// <summary>AWS Key ID.</summary>
    [JsonPropertyName("accessKeyId")]
    public V1beta1StorageTransferJobSpecTransferSpecAwsS3DataSourceAwsAccessKeyAccessKeyId AccessKeyId { get; set; }

    /// <summary>AWS Secret Access Key.</summary>
    [JsonPropertyName("secretAccessKey")]
    public V1beta1StorageTransferJobSpecTransferSpecAwsS3DataSourceAwsAccessKeySecretAccessKey SecretAccessKey { get; set; }
}

/// <summary>An AWS S3 data source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageTransferJobSpecTransferSpecAwsS3DataSource
{
    /// <summary>AWS credentials block.</summary>
    [JsonPropertyName("awsAccessKey")]
    public V1beta1StorageTransferJobSpecTransferSpecAwsS3DataSourceAwsAccessKey? AwsAccessKey { get; set; }

    /// <summary>S3 Bucket name.</summary>
    [JsonPropertyName("bucketName")]
    public string BucketName { get; set; }

    /// <summary>S3 Bucket path in bucket to transfer.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the role to support temporary credentials via 'AssumeRoleWithWebIdentity'. For more information about ARNs, see [IAM ARNs](https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html#identifiers-arns). When a role ARN is provided, Transfer Service fetches temporary credentials for the session using a 'AssumeRoleWithWebIdentity' call for the provided role using the [GoogleServiceAccount][] for this project.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageTransferJobSpecTransferSpecAzureBlobStorageDataSourceAzureCredentialsSasTokenValueFromSecretKeyRef
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
public partial class V1beta1StorageTransferJobSpecTransferSpecAzureBlobStorageDataSourceAzureCredentialsSasTokenValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1StorageTransferJobSpecTransferSpecAzureBlobStorageDataSourceAzureCredentialsSasTokenValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>Azure shared access signature.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageTransferJobSpecTransferSpecAzureBlobStorageDataSourceAzureCredentialsSasToken
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1StorageTransferJobSpecTransferSpecAzureBlobStorageDataSourceAzureCredentialsSasTokenValueFrom? ValueFrom { get; set; }
}

/// <summary> Credentials used to authenticate API requests to Azure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageTransferJobSpecTransferSpecAzureBlobStorageDataSourceAzureCredentials
{
    /// <summary>Azure shared access signature.</summary>
    [JsonPropertyName("sasToken")]
    public V1beta1StorageTransferJobSpecTransferSpecAzureBlobStorageDataSourceAzureCredentialsSasToken SasToken { get; set; }
}

/// <summary>An Azure Blob Storage data source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageTransferJobSpecTransferSpecAzureBlobStorageDataSource
{
    /// <summary> Credentials used to authenticate API requests to Azure.</summary>
    [JsonPropertyName("azureCredentials")]
    public V1beta1StorageTransferJobSpecTransferSpecAzureBlobStorageDataSourceAzureCredentials AzureCredentials { get; set; }

    /// <summary>The container to transfer from the Azure Storage account.</summary>
    [JsonPropertyName("container")]
    public string Container { get; set; }

    /// <summary>Root path to transfer objects. Must be an empty string or full path name that ends with a '/'. This field is treated as an object prefix. As such, it should generally not begin with a '/'.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The name of the Azure Storage account.</summary>
    [JsonPropertyName("storageAccount")]
    public string StorageAccount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageTransferJobSpecTransferSpecGcsDataSinkBucketRef
{
    /// <summary>Allowed value: The `name` field of a `StorageBucket` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>A Google Cloud Storage data sink.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageTransferJobSpecTransferSpecGcsDataSink
{
    /// <summary></summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1StorageTransferJobSpecTransferSpecGcsDataSinkBucketRef BucketRef { get; set; }

    /// <summary>Google Cloud Storage path in bucket to transfer.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageTransferJobSpecTransferSpecGcsDataSourceBucketRef
{
    /// <summary>Allowed value: The `name` field of a `StorageBucket` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>A Google Cloud Storage data source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageTransferJobSpecTransferSpecGcsDataSource
{
    /// <summary></summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1StorageTransferJobSpecTransferSpecGcsDataSourceBucketRef BucketRef { get; set; }

    /// <summary>Google Cloud Storage path in bucket to transfer.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>A HTTP URL data source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageTransferJobSpecTransferSpecHttpDataSource
{
    /// <summary>The URL that points to the file that stores the object list entries. This file must allow public access. Currently, only URLs with HTTP and HTTPS schemes are supported.</summary>
    [JsonPropertyName("listUrl")]
    public string ListUrl { get; set; }
}

/// <summary>Only objects that satisfy these object conditions are included in the set of data source and data sink objects. Object conditions based on objects' last_modification_time do not exclude objects in a data sink.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageTransferJobSpecTransferSpecObjectConditions
{
    /// <summary>exclude_prefixes must follow the requirements described for include_prefixes.</summary>
    [JsonPropertyName("excludePrefixes")]
    public IList<string>? ExcludePrefixes { get; set; }

    /// <summary>If include_refixes is specified, objects that satisfy the object conditions must have names that start with one of the include_prefixes and that do not start with any of the exclude_prefixes. If include_prefixes is not specified, all objects except those that have names starting with one of the exclude_prefixes must satisfy the object conditions.</summary>
    [JsonPropertyName("includePrefixes")]
    public IList<string>? IncludePrefixes { get; set; }

    /// <summary>If specified, only objects with a "last modification time" before this timestamp and objects that don't have a "last modification time" are transferred. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("lastModifiedBefore")]
    public string? LastModifiedBefore { get; set; }

    /// <summary>If specified, only objects with a "last modification time" on or after this timestamp and objects that don't have a "last modification time" are transferred. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("lastModifiedSince")]
    public string? LastModifiedSince { get; set; }

    /// <summary>A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("maxTimeElapsedSinceLastModification")]
    public string? MaxTimeElapsedSinceLastModification { get; set; }

    /// <summary>A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("minTimeElapsedSinceLastModification")]
    public string? MinTimeElapsedSinceLastModification { get; set; }
}

/// <summary>A POSIX filesystem data sink.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageTransferJobSpecTransferSpecPosixDataSink
{
    /// <summary>Root directory path to the filesystem.</summary>
    [JsonPropertyName("rootDirectory")]
    public string RootDirectory { get; set; }
}

/// <summary>A POSIX filesystem data source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageTransferJobSpecTransferSpecPosixDataSource
{
    /// <summary>Root directory path to the filesystem.</summary>
    [JsonPropertyName("rootDirectory")]
    public string RootDirectory { get; set; }
}

/// <summary>Characteristics of how to treat files from datasource and sink during job. If the option delete_objects_unique_in_sink is true, object conditions based on objects' last_modification_time are ignored and do not exclude objects in a data source or a data sink.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageTransferJobSpecTransferSpecTransferOptions
{
    /// <summary>Whether objects should be deleted from the source after they are transferred to the sink. Note that this option and delete_objects_unique_in_sink are mutually exclusive.</summary>
    [JsonPropertyName("deleteObjectsFromSourceAfterTransfer")]
    public bool? DeleteObjectsFromSourceAfterTransfer { get; set; }

    /// <summary>Whether objects that exist only in the sink should be deleted. Note that this option and delete_objects_from_source_after_transfer are mutually exclusive.</summary>
    [JsonPropertyName("deleteObjectsUniqueInSink")]
    public bool? DeleteObjectsUniqueInSink { get; set; }

    /// <summary>Whether overwriting objects that already exist in the sink is allowed.</summary>
    [JsonPropertyName("overwriteObjectsAlreadyExistingInSink")]
    public bool? OverwriteObjectsAlreadyExistingInSink { get; set; }

    /// <summary>When to overwrite objects that already exist in the sink. If not set, overwrite behavior is determined by overwriteObjectsAlreadyExistingInSink.</summary>
    [JsonPropertyName("overwriteWhen")]
    public string? OverwriteWhen { get; set; }
}

/// <summary>Transfer specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageTransferJobSpecTransferSpec
{
    /// <summary>An AWS S3 data source.</summary>
    [JsonPropertyName("awsS3DataSource")]
    public V1beta1StorageTransferJobSpecTransferSpecAwsS3DataSource? AwsS3DataSource { get; set; }

    /// <summary>An Azure Blob Storage data source.</summary>
    [JsonPropertyName("azureBlobStorageDataSource")]
    public V1beta1StorageTransferJobSpecTransferSpecAzureBlobStorageDataSource? AzureBlobStorageDataSource { get; set; }

    /// <summary>A Google Cloud Storage data sink.</summary>
    [JsonPropertyName("gcsDataSink")]
    public V1beta1StorageTransferJobSpecTransferSpecGcsDataSink? GcsDataSink { get; set; }

    /// <summary>A Google Cloud Storage data source.</summary>
    [JsonPropertyName("gcsDataSource")]
    public V1beta1StorageTransferJobSpecTransferSpecGcsDataSource? GcsDataSource { get; set; }

    /// <summary>A HTTP URL data source.</summary>
    [JsonPropertyName("httpDataSource")]
    public V1beta1StorageTransferJobSpecTransferSpecHttpDataSource? HttpDataSource { get; set; }

    /// <summary>Only objects that satisfy these object conditions are included in the set of data source and data sink objects. Object conditions based on objects' last_modification_time do not exclude objects in a data sink.</summary>
    [JsonPropertyName("objectConditions")]
    public V1beta1StorageTransferJobSpecTransferSpecObjectConditions? ObjectConditions { get; set; }

    /// <summary>A POSIX filesystem data sink.</summary>
    [JsonPropertyName("posixDataSink")]
    public V1beta1StorageTransferJobSpecTransferSpecPosixDataSink? PosixDataSink { get; set; }

    /// <summary>A POSIX filesystem data source.</summary>
    [JsonPropertyName("posixDataSource")]
    public V1beta1StorageTransferJobSpecTransferSpecPosixDataSource? PosixDataSource { get; set; }

    /// <summary>Immutable. Specifies the agent pool name associated with the posix data source. When unspecified, the default name is used.</summary>
    [JsonPropertyName("sinkAgentPoolName")]
    public string? SinkAgentPoolName { get; set; }

    /// <summary>Immutable. Specifies the agent pool name associated with the posix data source. When unspecified, the default name is used.</summary>
    [JsonPropertyName("sourceAgentPoolName")]
    public string? SourceAgentPoolName { get; set; }

    /// <summary>Characteristics of how to treat files from datasource and sink during job. If the option delete_objects_unique_in_sink is true, object conditions based on objects' last_modification_time are ignored and do not exclude objects in a data source or a data sink.</summary>
    [JsonPropertyName("transferOptions")]
    public V1beta1StorageTransferJobSpecTransferSpecTransferOptions? TransferOptions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageTransferJobSpec
{
    /// <summary>Unique description to identify the Transfer Job.</summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>Notification configuration.</summary>
    [JsonPropertyName("notificationConfig")]
    public V1beta1StorageTransferJobSpecNotificationConfig? NotificationConfig { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Schedule specification defining when the Transfer Job should be scheduled to start, end and what time to run.</summary>
    [JsonPropertyName("schedule")]
    public V1beta1StorageTransferJobSpecSchedule? Schedule { get; set; }

    /// <summary>Status of the job. Default: ENABLED. NOTE: The effect of the new job status takes place during a subsequent job run. For example, if you change the job status from ENABLED to DISABLED, and an operation spawned by the transfer is running, the status change would not affect the current operation.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Transfer specification.</summary>
    [JsonPropertyName("transferSpec")]
    public V1beta1StorageTransferJobSpecTransferSpec TransferSpec { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1StorageTransferJobStatusConditions
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
public partial class V1beta1StorageTransferJobStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1StorageTransferJobStatusConditions>? Conditions { get; set; }

    /// <summary>When the Transfer Job was created.</summary>
    [JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }

    /// <summary>When the Transfer Job was deleted.</summary>
    [JsonPropertyName("deletionTime")]
    public string? DeletionTime { get; set; }

    /// <summary>When the Transfer Job was last modified.</summary>
    [JsonPropertyName("lastModificationTime")]
    public string? LastModificationTime { get; set; }

    /// <summary>The name of the Transfer Job.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1StorageTransferJob : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1StorageTransferJobSpec>, IStatus<V1beta1StorageTransferJobStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "StorageTransferJob";
    public const string KubeGroup = "storagetransfer.cnrm.cloud.google.com";
    public const string KubePluralName = "storagetransferjobs";
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
    public V1beta1StorageTransferJobSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1StorageTransferJobStatus? Status { get; set; }
}