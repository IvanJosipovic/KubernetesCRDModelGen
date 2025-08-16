using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.healthcare.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1HealthcareDICOMStoreList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1HealthcareDICOMStore>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "HealthcareDICOMStoreList";
    public const string KubeGroup = "healthcare.cnrm.cloud.google.com";
    public const string KubePluralName = "healthcaredicomstores";
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
    public IList<V1alpha1HealthcareDICOMStore> Items { get; set; }
}

/// <summary>A nested object resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HealthcareDICOMStoreSpecNotificationConfig
{
    /// <summary>The Cloud Pub/Sub topic that notifications of changes are published on. Supplied by the client. PubsubMessage.Data will contain the resource name. PubsubMessage.MessageId is the ID of this message. It is guaranteed to be unique within the topic. PubsubMessage.PublishTime is the time at which the message was published. Notifications are only sent if the topic is non-empty. Topic names must be scoped to a project. service-PROJECT_NUMBER@gcp-sa-healthcare.iam.gserviceaccount.com must have publisher permissions on the given Cloud Pub/Sub topic. Not having adequate permissions will cause the calls that send notifications to fail.</summary>
    [JsonPropertyName("pubsubTopic")]
    public string PubsubTopic { get; set; }
}

/// <summary>BigQueryDestination to include a fully qualified BigQuery table URI where DICOM instance metadata will be streamed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HealthcareDICOMStoreSpecStreamConfigsBigqueryDestination
{
    /// <summary>a fully qualified BigQuery table URI where DICOM instance metadata will be streamed.</summary>
    [JsonPropertyName("tableUri")]
    public string TableUri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HealthcareDICOMStoreSpecStreamConfigs
{
    /// <summary>BigQueryDestination to include a fully qualified BigQuery table URI where DICOM instance metadata will be streamed.</summary>
    [JsonPropertyName("bigqueryDestination")]
    public V1alpha1HealthcareDICOMStoreSpecStreamConfigsBigqueryDestination BigqueryDestination { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HealthcareDICOMStoreSpec
{
    /// <summary>Immutable. Identifies the dataset addressed by this request. Must be in the format 'projects/{project}/locations/{location}/datasets/{dataset}'.</summary>
    [JsonPropertyName("dataset")]
    public string Dataset { get; set; }

    /// <summary>A nested object resource.</summary>
    [JsonPropertyName("notificationConfig")]
    public V1alpha1HealthcareDICOMStoreSpecNotificationConfig? NotificationConfig { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>To enable streaming to BigQuery, configure the streamConfigs object in your DICOM store. streamConfigs is an array, so you can specify multiple BigQuery destinations. You can stream metadata from a single DICOM store to up to five BigQuery tables in a BigQuery dataset.</summary>
    [JsonPropertyName("streamConfigs")]
    public IList<V1alpha1HealthcareDICOMStoreSpecStreamConfigs>? StreamConfigs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HealthcareDICOMStoreStatusConditions
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
public partial class V1alpha1HealthcareDICOMStoreStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1HealthcareDICOMStoreStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The fully qualified name of this dataset.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1HealthcareDICOMStore : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1HealthcareDICOMStoreSpec>, IStatus<V1alpha1HealthcareDICOMStoreStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "HealthcareDICOMStore";
    public const string KubeGroup = "healthcare.cnrm.cloud.google.com";
    public const string KubePluralName = "healthcaredicomstores";
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
    public V1alpha1HealthcareDICOMStoreSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1HealthcareDICOMStoreStatus? Status { get; set; }
}