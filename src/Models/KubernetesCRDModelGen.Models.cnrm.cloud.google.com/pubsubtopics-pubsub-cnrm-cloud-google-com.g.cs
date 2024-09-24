using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.pubsub.cnrm.cloud.google.com;
public partial class V1beta1PubSubTopicSpecKmsKeyRef
{
    /// <summary>Allowed value: The `selfLink` field of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1PubSubTopicSpecMessageStoragePolicy
{
    /// <summary>A list of IDs of GCP regions where messages that are published to the topic may be persisted in storage. Messages published by publishers running in non-allowed GCP regions (or running outside of GCP altogether) will be routed for storage in one of the allowed regions. An empty list means that no regions are allowed, and is not a valid configuration.</summary>
    [JsonPropertyName("allowedPersistenceRegions")]
    public IList<string> AllowedPersistenceRegions { get; set; }
}

public partial class V1beta1PubSubTopicSpecSchemaSettingsSchemaRef
{
    /// <summary>Allowed value: string of the format `projects/{{project}}/schemas/{{value}}`, where {{value}} is the `name` field of a `PubSubSchema` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1PubSubTopicSpecSchemaSettings
{
    /// <summary>The encoding of messages validated against schema. Default value: "ENCODING_UNSPECIFIED" Possible values: ["ENCODING_UNSPECIFIED", "JSON", "BINARY"].</summary>
    [JsonPropertyName("encoding")]
    public string? Encoding { get; set; }

    /// <summary></summary>
    [JsonPropertyName("schemaRef")]
    public V1beta1PubSubTopicSpecSchemaSettingsSchemaRef SchemaRef { get; set; }
}

public partial class V1beta1PubSubTopicSpec
{
    /// <summary>The KMSCryptoKey to be used to protect access to messages published on this topic. Your project's Pub/Sub service account ('service-{{PROJECT_NUMBER}}@gcp-sa-pubsub.iam.gserviceaccount.com') must have 'roles/cloudkms.cryptoKeyEncrypterDecrypter' to use this feature.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1PubSubTopicSpecKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>Indicates the minimum duration to retain a message after it is published to the topic. If this field is set, messages published to the topic in the last messageRetentionDuration are always available to subscribers. For instance, it allows any attached subscription to seek to a timestamp that is up to messageRetentionDuration in the past. If this field is not set, message retention is controlled by settings on individual subscriptions. Cannot be more than 31 days or less than 10 minutes.</summary>
    [JsonPropertyName("messageRetentionDuration")]
    public string? MessageRetentionDuration { get; set; }

    /// <summary>Policy constraining the set of Google Cloud Platform regions where messages published to the topic may be stored. If not present, then no constraints are in effect.</summary>
    [JsonPropertyName("messageStoragePolicy")]
    public V1beta1PubSubTopicSpecMessageStoragePolicy? MessageStoragePolicy { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Settings for validating messages published against a schema.</summary>
    [JsonPropertyName("schemaSettings")]
    public V1beta1PubSubTopicSpecSchemaSettings? SchemaSettings { get; set; }
}

public partial class V1beta1PubSubTopicStatusConditions
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

public partial class V1beta1PubSubTopicStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PubSubTopicStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PubSubTopic : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PubSubTopicSpec>, IStatus<V1beta1PubSubTopicStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PubSubTopic";
    public const string KubeGroup = "pubsub.cnrm.cloud.google.com";
    public const string KubePluralName = "pubsubtopics";
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
    public V1beta1PubSubTopicSpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1PubSubTopicStatus? Status { get; set; }
}