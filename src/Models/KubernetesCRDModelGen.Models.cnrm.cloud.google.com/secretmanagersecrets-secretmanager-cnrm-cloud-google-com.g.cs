using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.secretmanager.cnrm.cloud.google.com;
/// <summary>The customer-managed encryption configuration of the Secret. If no configuration is provided, Google-managed default encryption is used.</summary>
public partial class V1beta1SecretManagerSecretSpecReplicationAutoCustomerManagedEncryptionKmsKeyRef
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

/// <summary>The customer-managed encryption configuration of the Secret. If no configuration is provided, Google-managed default encryption is used.</summary>
public partial class V1beta1SecretManagerSecretSpecReplicationAutoCustomerManagedEncryption
{
    /// <summary>The customer-managed encryption configuration of the Secret. If no configuration is provided, Google-managed default encryption is used.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1SecretManagerSecretSpecReplicationAutoCustomerManagedEncryptionKmsKeyRef KmsKeyRef { get; set; }
}

/// <summary>The Secret will automatically be replicated without any restrictions.</summary>
public partial class V1beta1SecretManagerSecretSpecReplicationAuto
{
    /// <summary>The customer-managed encryption configuration of the Secret. If no configuration is provided, Google-managed default encryption is used.</summary>
    [JsonPropertyName("customerManagedEncryption")]
    public V1beta1SecretManagerSecretSpecReplicationAutoCustomerManagedEncryption? CustomerManagedEncryption { get; set; }
}

/// <summary>Customer Managed Encryption for the secret.</summary>
public partial class V1beta1SecretManagerSecretSpecReplicationUserManagedReplicasCustomerManagedEncryptionKmsKeyRef
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

/// <summary>Customer Managed Encryption for the secret.</summary>
public partial class V1beta1SecretManagerSecretSpecReplicationUserManagedReplicasCustomerManagedEncryption
{
    /// <summary>Customer Managed Encryption for the secret.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1SecretManagerSecretSpecReplicationUserManagedReplicasCustomerManagedEncryptionKmsKeyRef KmsKeyRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecretManagerSecretSpecReplicationUserManagedReplicas
{
    /// <summary>Customer Managed Encryption for the secret.</summary>
    [JsonPropertyName("customerManagedEncryption")]
    public V1beta1SecretManagerSecretSpecReplicationUserManagedReplicasCustomerManagedEncryption? CustomerManagedEncryption { get; set; }

    /// <summary>Immutable. The canonical IDs of the location to replicate data. For example: "us-east1".</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }
}

/// <summary>Immutable. The Secret will be replicated to the regions specified by the user.</summary>
public partial class V1beta1SecretManagerSecretSpecReplicationUserManaged
{
    /// <summary>Immutable. The list of Replicas for this Secret. Cannot be empty.</summary>
    [JsonPropertyName("replicas")]
    public IList<V1beta1SecretManagerSecretSpecReplicationUserManagedReplicas> Replicas { get; set; }
}

/// <summary>Immutable. The replication policy of the secret data attached to the Secret. It cannot be changed after the Secret has been created.</summary>
public partial class V1beta1SecretManagerSecretSpecReplication
{
    /// <summary>The Secret will automatically be replicated without any restrictions.</summary>
    [JsonPropertyName("auto")]
    public V1beta1SecretManagerSecretSpecReplicationAuto? Auto { get; set; }

    /// <summary>The Secret will automatically be replicated without any restrictions.</summary>
    [JsonPropertyName("automatic")]
    public bool? Automatic { get; set; }

    /// <summary>Immutable. The Secret will be replicated to the regions specified by the user.</summary>
    [JsonPropertyName("userManaged")]
    public V1beta1SecretManagerSecretSpecReplicationUserManaged? UserManaged { get; set; }
}

/// <summary>The rotation time and period for a Secret. At 'next_rotation_time', Secret Manager will send a Pub/Sub notification to the topics configured on the Secret. 'topics' must be set to configure rotation.</summary>
public partial class V1beta1SecretManagerSecretSpecRotation
{
    /// <summary>Timestamp in UTC at which the Secret is scheduled to rotate. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("nextRotationTime")]
    public string? NextRotationTime { get; set; }

    /// <summary>Immutable. The Duration between rotation notifications. Must be in seconds and at least 3600s (1h) and at most 3153600000s (100 years). If rotationPeriod is set, 'next_rotation_time' must be set. 'next_rotation_time' will be advanced by this period when the service automatically sends rotation notifications.</summary>
    [JsonPropertyName("rotationPeriod")]
    public string? RotationPeriod { get; set; }
}

/// <summary>A list of up to 10 Pub/Sub topics to which messages are published when control plane operations are called on the secret or its versions.</summary>
public partial class V1beta1SecretManagerSecretSpecTopicsTopicRef
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

/// <summary></summary>
public partial class V1beta1SecretManagerSecretSpecTopics
{
    /// <summary>A list of up to 10 Pub/Sub topics to which messages are published when control plane operations are called on the secret or its versions.</summary>
    [JsonPropertyName("topicRef")]
    public V1beta1SecretManagerSecretSpecTopicsTopicRef TopicRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecretManagerSecretSpec
{
    /// <summary>Custom metadata about the secret.  Annotations are distinct from various forms of labels. Annotations exist to allow client tools to store their own state information without requiring a database.  Annotation keys must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, begin and end with an alphanumeric character ([a-z0-9A-Z]), and may have dashes (-), underscores (_), dots (.), and alphanumerics in between these symbols.  The total size of annotation keys and values must be less than 16KiB.  An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Timestamp in UTC when the Secret is scheduled to expire. This is always provided on output, regardless of what was sent on input. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>Immutable. The replication policy of the secret data attached to the Secret. It cannot be changed after the Secret has been created.</summary>
    [JsonPropertyName("replication")]
    public V1beta1SecretManagerSecretSpecReplication Replication { get; set; }

    /// <summary>Immutable. Optional. The secretId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The rotation time and period for a Secret. At 'next_rotation_time', Secret Manager will send a Pub/Sub notification to the topics configured on the Secret. 'topics' must be set to configure rotation.</summary>
    [JsonPropertyName("rotation")]
    public V1beta1SecretManagerSecretSpecRotation? Rotation { get; set; }

    /// <summary>A list of up to 10 Pub/Sub topics to which messages are published when control plane operations are called on the secret or its versions.</summary>
    [JsonPropertyName("topics")]
    public IList<V1beta1SecretManagerSecretSpecTopics>? Topics { get; set; }

    /// <summary>Immutable. The TTL for the Secret. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".</summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }

    /// <summary>Mapping from version alias to version name.  A version alias is a string with a maximum length of 63 characters and can contain uppercase and lowercase letters, numerals, and the hyphen (-) and underscore ('_') characters. An alias string must start with a letter and cannot be the string 'latest' or 'NEW'. No more than 50 aliases can be assigned to a given secret.  An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("versionAliases")]
    public IDictionary<string, string>? VersionAliases { get; set; }
}

/// <summary></summary>
public partial class V1beta1SecretManagerSecretStatusConditions
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
public partial class V1beta1SecretManagerSecretStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SecretManagerSecretStatusConditions>? Conditions { get; set; }

    /// <summary>The time at which the Secret was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>The resource name of the Secret. Format: 'projects/{{project}}/secrets/{{secret_id}}'.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1beta1SecretManagerSecret : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SecretManagerSecretSpec>, IStatus<V1beta1SecretManagerSecretStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SecretManagerSecret";
    public const string KubeGroup = "secretmanager.cnrm.cloud.google.com";
    public const string KubePluralName = "secretmanagersecrets";
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
    public V1beta1SecretManagerSecretSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1SecretManagerSecretStatus? Status { get; set; }
}