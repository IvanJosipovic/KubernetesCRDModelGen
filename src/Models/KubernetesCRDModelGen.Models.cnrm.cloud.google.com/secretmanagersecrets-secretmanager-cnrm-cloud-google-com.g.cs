using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.secretmanager.cnrm.cloud.google.com;
/// <summary>Required. The resource name of the Cloud KMS CryptoKey used to encrypt  secret payloads.   For secrets using the  [UserManaged][google.cloud.secretmanager.v1.Replication.UserManaged]  replication policy type, Cloud KMS CryptoKeys must reside in the same  location as the [replica location][Secret.UserManaged.Replica.location].   For secrets using the  [Automatic][google.cloud.secretmanager.v1.Replication.Automatic]  replication policy type, Cloud KMS CryptoKeys must reside in `global`.   The expected format is `projects/*/locations/*/keyRings/*/cryptoKeys/*`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretManagerSecretSpecReplicationAutoCustomerManagedEncryptionKmsKeyRef
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

/// <summary>Optional. The customer-managed encryption configuration of the  [Secret][google.cloud.secretmanager.v1.Secret]. If no configuration is  provided, Google-managed default encryption is used.   Updates to the [Secret][google.cloud.secretmanager.v1.Secret] encryption  configuration only apply to  [SecretVersions][google.cloud.secretmanager.v1.SecretVersion] added  afterwards. They do not apply retroactively to existing  [SecretVersions][google.cloud.secretmanager.v1.SecretVersion].</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretManagerSecretSpecReplicationAutoCustomerManagedEncryption
{
    /// <summary>Required. The resource name of the Cloud KMS CryptoKey used to encrypt  secret payloads.   For secrets using the  [UserManaged][google.cloud.secretmanager.v1.Replication.UserManaged]  replication policy type, Cloud KMS CryptoKeys must reside in the same  location as the [replica location][Secret.UserManaged.Replica.location].   For secrets using the  [Automatic][google.cloud.secretmanager.v1.Replication.Automatic]  replication policy type, Cloud KMS CryptoKeys must reside in `global`.   The expected format is `projects/*/locations/*/keyRings/*/cryptoKeys/*`.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1SecretManagerSecretSpecReplicationAutoCustomerManagedEncryptionKmsKeyRef KmsKeyRef { get; set; }
}

/// <summary>The [Secret][google.cloud.secretmanager.v1.Secret] will automatically be replicated without any restrictions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretManagerSecretSpecReplicationAuto
{
    /// <summary>Optional. The customer-managed encryption configuration of the  [Secret][google.cloud.secretmanager.v1.Secret]. If no configuration is  provided, Google-managed default encryption is used.   Updates to the [Secret][google.cloud.secretmanager.v1.Secret] encryption  configuration only apply to  [SecretVersions][google.cloud.secretmanager.v1.SecretVersion] added  afterwards. They do not apply retroactively to existing  [SecretVersions][google.cloud.secretmanager.v1.SecretVersion].</summary>
    [JsonPropertyName("customerManagedEncryption")]
    public V1beta1SecretManagerSecretSpecReplicationAutoCustomerManagedEncryption? CustomerManagedEncryption { get; set; }
}

/// <summary>Required. The resource name of the Cloud KMS CryptoKey used to encrypt  secret payloads.   For secrets using the  [UserManaged][google.cloud.secretmanager.v1.Replication.UserManaged]  replication policy type, Cloud KMS CryptoKeys must reside in the same  location as the [replica location][Secret.UserManaged.Replica.location].   For secrets using the  [Automatic][google.cloud.secretmanager.v1.Replication.Automatic]  replication policy type, Cloud KMS CryptoKeys must reside in `global`.   The expected format is `projects/*/locations/*/keyRings/*/cryptoKeys/*`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretManagerSecretSpecReplicationUserManagedReplicasCustomerManagedEncryptionKmsKeyRef
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

/// <summary>Optional. The customer-managed encryption configuration of the  [User-Managed Replica][Replication.UserManaged.Replica]. If no  configuration is provided, Google-managed default encryption is used.   Updates to the [Secret][google.cloud.secretmanager.v1.Secret]  encryption configuration only apply to  [SecretVersions][google.cloud.secretmanager.v1.SecretVersion] added  afterwards. They do not apply retroactively to existing  [SecretVersions][google.cloud.secretmanager.v1.SecretVersion].</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretManagerSecretSpecReplicationUserManagedReplicasCustomerManagedEncryption
{
    /// <summary>Required. The resource name of the Cloud KMS CryptoKey used to encrypt  secret payloads.   For secrets using the  [UserManaged][google.cloud.secretmanager.v1.Replication.UserManaged]  replication policy type, Cloud KMS CryptoKeys must reside in the same  location as the [replica location][Secret.UserManaged.Replica.location].   For secrets using the  [Automatic][google.cloud.secretmanager.v1.Replication.Automatic]  replication policy type, Cloud KMS CryptoKeys must reside in `global`.   The expected format is `projects/*/locations/*/keyRings/*/cryptoKeys/*`.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1SecretManagerSecretSpecReplicationUserManagedReplicasCustomerManagedEncryptionKmsKeyRef KmsKeyRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretManagerSecretSpecReplicationUserManagedReplicas
{
    /// <summary>Optional. The customer-managed encryption configuration of the  [User-Managed Replica][Replication.UserManaged.Replica]. If no  configuration is provided, Google-managed default encryption is used.   Updates to the [Secret][google.cloud.secretmanager.v1.Secret]  encryption configuration only apply to  [SecretVersions][google.cloud.secretmanager.v1.SecretVersion] added  afterwards. They do not apply retroactively to existing  [SecretVersions][google.cloud.secretmanager.v1.SecretVersion].</summary>
    [JsonPropertyName("customerManagedEncryption")]
    public V1beta1SecretManagerSecretSpecReplicationUserManagedReplicasCustomerManagedEncryption? CustomerManagedEncryption { get; set; }

    /// <summary>The canonical IDs of the location to replicate data. For example: `"us-east1"`.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }
}

/// <summary>The [Secret][google.cloud.secretmanager.v1.Secret] will only be replicated into the locations specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretManagerSecretSpecReplicationUserManaged
{
    /// <summary>Required. The list of Replicas for this  [Secret][google.cloud.secretmanager.v1.Secret].   Cannot be empty.</summary>
    [JsonPropertyName("replicas")]
    public IList<V1beta1SecretManagerSecretSpecReplicationUserManagedReplicas> Replicas { get; set; }
}

/// <summary>Optional. Immutable. The replication policy of the secret data attached to  the [Secret][google.cloud.secretmanager.v1.Secret].   The replication policy cannot be changed after the Secret has been created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretManagerSecretSpecReplication
{
    /// <summary>The [Secret][google.cloud.secretmanager.v1.Secret] will automatically be replicated without any restrictions.</summary>
    [JsonPropertyName("auto")]
    public V1beta1SecretManagerSecretSpecReplicationAuto? Auto { get; set; }

    /// <summary>The Secret will automatically be replicated without any restrictions.</summary>
    [JsonPropertyName("automatic")]
    public bool? Automatic { get; set; }

    /// <summary>The [Secret][google.cloud.secretmanager.v1.Secret] will only be replicated into the locations specified.</summary>
    [JsonPropertyName("userManaged")]
    public V1beta1SecretManagerSecretSpecReplicationUserManaged? UserManaged { get; set; }
}

/// <summary>Optional. Rotation policy attached to the [Secret][google.cloud.secretmanager.v1.Secret]. May be excluded if there is no rotation policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretManagerSecretSpecRotation
{
    /// <summary>Optional. Timestamp in UTC at which the  [Secret][google.cloud.secretmanager.v1.Secret] is scheduled to rotate.  Cannot be set to less than 300s (5 min) in the future and at most  3153600000s (100 years).   [next_rotation_time][google.cloud.secretmanager.v1.Rotation.next_rotation_time]  MUST  be set if  [rotation_period][google.cloud.secretmanager.v1.Rotation.rotation_period]  is set.</summary>
    [JsonPropertyName("nextRotationTime")]
    public string? NextRotationTime { get; set; }

    /// <summary>Input only. The Duration between rotation notifications. Must be in seconds  and at least 3600s (1h) and at most 3153600000s (100 years).   If  [rotation_period][google.cloud.secretmanager.v1.Rotation.rotation_period]  is set,  [next_rotation_time][google.cloud.secretmanager.v1.Rotation.next_rotation_time]  must be set.  [next_rotation_time][google.cloud.secretmanager.v1.Rotation.next_rotation_time]  will be advanced by this period when the service automatically sends  rotation notifications.</summary>
    [JsonPropertyName("rotationPeriod")]
    public string? RotationPeriod { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretManagerSecretSpecTopicsTopicRef
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretManagerSecretSpecTopics
{
    /// <summary></summary>
    [JsonPropertyName("topicRef")]
    public V1beta1SecretManagerSecretSpecTopicsTopicRef TopicRef { get; set; }
}

/// <summary>SecretManagerSecretSpec defines the desired state of SecretManagerSecret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretManagerSecretSpec
{
    /// <summary>Optional. Custom metadata about the secret.   Annotations are distinct from various forms of labels.  Annotations exist to allow client tools to store their own state  information without requiring a database.   Annotation keys must be between 1 and 63 characters long, have a UTF-8  encoding of maximum 128 bytes, begin and end with an alphanumeric character  ([a-z0-9A-Z]), and may have dashes (-), underscores (_), dots (.), and  alphanumerics in between these symbols.   The total size of annotation keys and values must be less than 16KiB.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Optional. Timestamp in UTC when the [Secret][google.cloud.secretmanager.v1.Secret] is scheduled to expire. This is always provided on output, regardless of what was sent on input.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>Optional. Immutable. The replication policy of the secret data attached to  the [Secret][google.cloud.secretmanager.v1.Secret].   The replication policy cannot be changed after the Secret has been created.</summary>
    [JsonPropertyName("replication")]
    public V1beta1SecretManagerSecretSpecReplication? Replication { get; set; }

    /// <summary>The SecretManagerSecret name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. Rotation policy attached to the [Secret][google.cloud.secretmanager.v1.Secret]. May be excluded if there is no rotation policy.</summary>
    [JsonPropertyName("rotation")]
    public V1beta1SecretManagerSecretSpecRotation? Rotation { get; set; }

    /// <summary>Optional. A list of up to 10 Pub/Sub topics to which messages are published when control plane operations are called on the secret or its versions.</summary>
    [JsonPropertyName("topics")]
    public IList<V1beta1SecretManagerSecretSpecTopics>? Topics { get; set; }

    /// <summary>Input only. A duration in seconds with up to nine fractional digits, ending with 's'. Example: "3.5s".</summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }

    /// <summary>Optional. Mapping from version alias to version name.   A version alias is a string with a maximum length of 63 characters and can  contain uppercase and lowercase letters, numerals, and the hyphen (`-`)  and underscore ('_') characters. An alias string must start with a  letter and cannot be the string 'latest' or 'NEW'.  No more than 50 aliases can be assigned to a given secret.   Version-Alias pairs will be viewable via GetSecret and modifiable via  UpdateSecret. Access by alias is only be supported on  GetSecretVersion and AccessSecretVersion.</summary>
    [JsonPropertyName("versionAliases")]
    public IDictionary<string, string>? VersionAliases { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
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

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretManagerSecretStatusObservedState
{
    /// <summary></summary>
    [JsonPropertyName("versionAliases")]
    public IDictionary<string, string>? VersionAliases { get; set; }
}

/// <summary>SecretManagerSecretStatus defines the config connector machine state of SecretManagerSecret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretManagerSecretStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SecretManagerSecretStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the SecretManagerSecret resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>[DEPRECATED] Please read from `.status.externalRef` instead. Config Connector will remove the `.status.name` in v1 Version.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1SecretManagerSecretStatusObservedState? ObservedState { get; set; }
}

/// <summary>SecretManagerSecret is the Schema for the SecretManagerSecret API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
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

    /// <summary>SecretManagerSecretSpec defines the desired state of SecretManagerSecret</summary>
    [JsonPropertyName("spec")]
    public V1beta1SecretManagerSecretSpec? Spec { get; set; }

    /// <summary>SecretManagerSecretStatus defines the config connector machine state of SecretManagerSecret</summary>
    [JsonPropertyName("status")]
    public V1beta1SecretManagerSecretStatus? Status { get; set; }
}

/// <summary>SecretManagerSecret is the Schema for the SecretManagerSecret API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SecretManagerSecretList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SecretManagerSecret>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SecretManagerSecretList";
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
    public V1ListMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1beta1SecretManagerSecret> Items { get; set; }
}