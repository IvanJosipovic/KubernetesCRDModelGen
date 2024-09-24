using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigquerydatatransfer.cnrm.cloud.google.com;
/// <summary>The BigQuery target dataset id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryDataTransferConfigSpecDatasetRef
{
    /// <summary>If provided must be in the format `projects/[project_id]/datasets/[dataset_id]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `metadata.name` field of a `BigQueryDataset` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `BigQueryDataset` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Email notifications will be sent according to these preferences to the email address of the user who owns this transfer config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryDataTransferConfigSpecEmailPreferences
{
    /// <summary>If true, email notifications will be sent on transfer run failures.</summary>
    [JsonPropertyName("enableFailureEmail")]
    public bool? EnableFailureEmail { get; set; }
}

/// <summary>The KMS key used for encrypting BigQuery data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryDataTransferConfigSpecEncryptionConfigurationKmsKeyRef
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

/// <summary>The encryption configuration part. Currently, it is only used for the optional KMS key name. The BigQuery service account of your project must be granted permissions to use the key. Read methods will return the key name applied in effect. Write methods will apply the key if it is present, or otherwise try to apply project default keys if it is absent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryDataTransferConfigSpecEncryptionConfiguration
{
    /// <summary>The KMS key used for encrypting BigQuery data.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1alpha1BigQueryDataTransferConfigSpecEncryptionConfigurationKmsKeyRef? KmsKeyRef { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryDataTransferConfigSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Pub/Sub topic where notifications will be sent after transfer runs associated with this transfer config finish.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryDataTransferConfigSpecPubSubTopicRef
{
    /// <summary>If provided must be in the format `projects/[project_id]/topics/[topic_id]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `metadata.name` field of a `PubSubTopic` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `PubSubTopic` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Options customizing the data transfer schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryDataTransferConfigSpecScheduleOptions
{
    /// <summary>If true, automatic scheduling of data transfer runs for this configuration will be disabled. The runs can be started on ad-hoc basis using StartManualTransferRuns API. When automatic scheduling is disabled, the TransferConfig.schedule field will be ignored.</summary>
    [JsonPropertyName("disableAutoScheduling")]
    public bool? DisableAutoScheduling { get; set; }

    /// <summary>Defines time to stop scheduling transfer runs. A transfer run cannot be scheduled at or after the end time. The end time can be changed at any moment. The time when a data transfer can be triggered manually is not limited by this option.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>Specifies time to start scheduling transfer runs. The first run will be scheduled at or after the start time according to a recurrence pattern defined in the schedule string. The start time can be changed at any moment. The time when a data transfer can be triggered manually is not limited by this option.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }
}

/// <summary>Service account email. If this field is set, the transfer config will be created with this service account's credentials. It requires that the requesting user calling this API has permissions to act as this service account. Note that not all data sources support service account credentials when creating a transfer config. For the latest list of data sources, please refer to https://cloud.google.com/bigquery/docs/use-service-accounts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryDataTransferConfigSpecServiceAccountRef
{
    /// <summary>The `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>BigQueryDataTransferConfigSpec defines the desired state of BigQueryDataTransferConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryDataTransferConfigSpec
{
    /// <summary>The number of days to look back to automatically refresh the data. For example, if `data_refresh_window_days = 10`, then every day BigQuery reingests data for [today-10, today-1], rather than ingesting data for just [today-1]. Only valid if the data source supports the feature. Set the value to 0 to use the default value.</summary>
    [JsonPropertyName("dataRefreshWindowDays")]
    public int? DataRefreshWindowDays { get; set; }

    /// <summary>Immutable. Data source ID. This cannot be changed once data transfer is created. The full list of available data source IDs can be returned through an API call: https://cloud.google.com/bigquery-transfer/docs/reference/datatransfer/rest/v1/projects.locations.dataSources/list</summary>
    [JsonPropertyName("dataSourceID")]
    public string DataSourceID { get; set; }

    /// <summary>The BigQuery target dataset id.</summary>
    [JsonPropertyName("datasetRef")]
    public V1alpha1BigQueryDataTransferConfigSpecDatasetRef DatasetRef { get; set; }

    /// <summary>Is this config disabled. When set to true, no runs will be scheduled for this transfer config.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>User specified display name for the data transfer.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Email notifications will be sent according to these preferences to the email address of the user who owns this transfer config.</summary>
    [JsonPropertyName("emailPreferences")]
    public V1alpha1BigQueryDataTransferConfigSpecEmailPreferences? EmailPreferences { get; set; }

    /// <summary>The encryption configuration part. Currently, it is only used for the optional KMS key name. The BigQuery service account of your project must be granted permissions to use the key. Read methods will return the key name applied in effect. Write methods will apply the key if it is present, or otherwise try to apply project default keys if it is absent.</summary>
    [JsonPropertyName("encryptionConfiguration")]
    public V1alpha1BigQueryDataTransferConfigSpecEncryptionConfiguration? EncryptionConfiguration { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Parameters specific to each data source. For more information see the bq tab in the 'Setting up a data transfer' section for each data source. For example the parameters for Cloud Storage transfers are listed here: https://cloud.google.com/bigquery-transfer/docs/cloud-storage-transfer#bq</summary>
    [JsonPropertyName("params")]
    public IDictionary<string, string> Params { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1BigQueryDataTransferConfigSpecProjectRef ProjectRef { get; set; }

    /// <summary>Pub/Sub topic where notifications will be sent after transfer runs associated with this transfer config finish.</summary>
    [JsonPropertyName("pubSubTopicRef")]
    public V1alpha1BigQueryDataTransferConfigSpecPubSubTopicRef? PubSubTopicRef { get; set; }

    /// <summary>Immutable. The BigQueryDataTransferConfig name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Data transfer schedule.  If the data source does not support a custom schedule, this should be  empty. If it is empty, the default value for the data source will be used.  The specified times are in UTC.  Examples of valid format:  `1st,3rd monday of month 15:30`,  `every wed,fri of jan,jun 13:15`, and  `first sunday of quarter 00:00`.  See more explanation about the format here:  https://cloud.google.com/appengine/docs/flexible/python/scheduling-jobs-with-cron-yaml#the_schedule_format   NOTE: The minimum interval time between recurring transfers depends on the  data source; refer to the documentation for your data source.</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>Options customizing the data transfer schedule.</summary>
    [JsonPropertyName("scheduleOptions")]
    public V1alpha1BigQueryDataTransferConfigSpecScheduleOptions? ScheduleOptions { get; set; }

    /// <summary>Service account email. If this field is set, the transfer config will be created with this service account's credentials. It requires that the requesting user calling this API has permissions to act as this service account. Note that not all data sources support service account credentials when creating a transfer config. For the latest list of data sources, please refer to https://cloud.google.com/bigquery/docs/use-service-accounts.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1alpha1BigQueryDataTransferConfigSpecServiceAccountRef? ServiceAccountRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryDataTransferConfigStatusConditions
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

/// <summary>Output only. Information about the user whose credentials are used to transfer data. Populated only for `transferConfigs.get` requests. In case the user information is not available, this field will not be populated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryDataTransferConfigStatusObservedStateOwnerInfo
{
    /// <summary>E-mail address of the user.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryDataTransferConfigStatusObservedState
{
    /// <summary>Output only. Region in which BigQuery dataset is located.</summary>
    [JsonPropertyName("datasetRegion")]
    public string? DatasetRegion { get; set; }

    /// <summary>Identifier. The resource name of the transfer config. Transfer config names have the form either `projects/{project_id}/locations/{region}/transferConfigs/{config_id}` or `projects/{project_id}/transferConfigs/{config_id}`, where `config_id` is usually a UUID, even though it is not guaranteed or required. The name is ignored when creating a transfer config.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Output only. Next time when data transfer will run.</summary>
    [JsonPropertyName("nextRunTime")]
    public string? NextRunTime { get; set; }

    /// <summary>Output only. Information about the user whose credentials are used to transfer data. Populated only for `transferConfigs.get` requests. In case the user information is not available, this field will not be populated.</summary>
    [JsonPropertyName("ownerInfo")]
    public V1alpha1BigQueryDataTransferConfigStatusObservedStateOwnerInfo? OwnerInfo { get; set; }

    /// <summary>Output only. State of the most recently updated transfer run.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Data transfer modification time. Ignored by server on input.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Deprecated. Unique ID of the user on whose behalf transfer is done.</summary>
    [JsonPropertyName("userID")]
    public long? UserID { get; set; }
}

/// <summary>BigQueryDataTransferConfigStatus defines the config connector machine state of BigQueryDataTransferConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BigQueryDataTransferConfigStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BigQueryDataTransferConfigStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the BigQueryDataTransferConfig resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1BigQueryDataTransferConfigStatusObservedState? ObservedState { get; set; }
}

/// <summary>BigQueryDataTransferConfig is the Schema for the BigQueryDataTransferConfig API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BigQueryDataTransferConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BigQueryDataTransferConfigSpec>, IStatus<V1alpha1BigQueryDataTransferConfigStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BigQueryDataTransferConfig";
    public const string KubeGroup = "bigquerydatatransfer.cnrm.cloud.google.com";
    public const string KubePluralName = "bigquerydatatransferconfigs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BigQueryDataTransferConfigSpec defines the desired state of BigQueryDataTransferConfig</summary>
    [JsonPropertyName("spec")]
    public V1alpha1BigQueryDataTransferConfigSpec Spec { get; set; }

    /// <summary>BigQueryDataTransferConfigStatus defines the config connector machine state of BigQueryDataTransferConfig</summary>
    [JsonPropertyName("status")]
    public V1alpha1BigQueryDataTransferConfigStatus? Status { get; set; }
}