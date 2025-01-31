using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.secretmanager.cnrm.cloud.google.com;
/// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretManagerSecretVersionSpecSecretDataValueFromSecretKeyRef
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
public partial class V1beta1SecretManagerSecretVersionSpecSecretDataValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1SecretManagerSecretVersionSpecSecretDataValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>The actual secret data. Config Connector supports secret data stored in Kubernetes secret or plain data (base64)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretManagerSecretVersionSpecSecretData
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1SecretManagerSecretVersionSpecSecretDataValueFrom? ValueFrom { get; set; }
}

/// <summary>The resource name of the [Secret][google.cloud.secretmanager.v1.Secret] to create a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] for.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretManagerSecretVersionSpecSecretRef
{
    /// <summary>A reference to an externally managed SecretManagerSecret resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/secrets/{{secretID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>SecretManagerSecretVersionSpec defines the desired state of SecretManagerSecretVersion</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretManagerSecretVersionSpec
{
    /// <summary>DEPRECATED. You do not need to set this field in direct reconciler mode. Use delete-policy annotation instead. https://cloud.google.com/config-connector/docs/how-to/managing-deleting-resources#keeping_resources_after_deletion The deletion policy for the secret version. Setting 'ABANDON' allows the resource to be abandoned rather than deleted. Setting 'DISABLE' allows the resource to be disabled rather than deleted. Default is 'DELETE'. Possible values are: * DELETE * DISABLE * ABANDON.</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary>Should enable or disable the current SecretVersion. - Enabled version can be accessed and described. - Disabled version cannot be accessed, but the secret's contents still exist</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>DEPRECATED. You do not need to set this field in direct reconciler mode.</summary>
    [JsonPropertyName("isSecretDataBase64")]
    public bool? IsSecretDataBase64 { get; set; }

    /// <summary>The SecretVersion number. If given, Config Connector acquires the resource from the Secret Manager service. If not given, Config Connector adds a new secret version to the GCP service, and you can find out the version number from `status.observedState.version`</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The actual secret data. Config Connector supports secret data stored in Kubernetes secret or plain data (base64)</summary>
    [JsonPropertyName("secretData")]
    public V1beta1SecretManagerSecretVersionSpecSecretData? SecretData { get; set; }

    /// <summary>The resource name of the [Secret][google.cloud.secretmanager.v1.Secret] to create a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] for.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta1SecretManagerSecretVersionSpecSecretRef? SecretRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretManagerSecretVersionStatusConditions
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

/// <summary>Output only. The customer-managed encryption status of the [SecretVersion][google.cloud.secretmanager.v1.SecretVersion]. Only populated if customer-managed encryption is used and [Secret][google.cloud.secretmanager.v1.Secret] is a Regionalised Secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretManagerSecretVersionStatusObservedStateCustomerManagedEncryption
{
    /// <summary>Required. The resource name of the Cloud KMS CryptoKeyVersion used to encrypt the secret payload, in the following format: `projects/*/locations/*/keyRings/*/cryptoKeys/*/versions/*`.</summary>
    [JsonPropertyName("kmsKeyVersionName")]
    public string? KmsKeyVersionName { get; set; }
}

/// <summary>Output only. The customer-managed encryption status of the [SecretVersion][google.cloud.secretmanager.v1.SecretVersion]. Only populated if customer-managed encryption is used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretManagerSecretVersionStatusObservedStateReplicationStatusAutomaticCustomerManagedEncryption
{
    /// <summary>Required. The resource name of the Cloud KMS CryptoKeyVersion used to encrypt the secret payload, in the following format: `projects/*/locations/*/keyRings/*/cryptoKeys/*/versions/*`.</summary>
    [JsonPropertyName("kmsKeyVersionName")]
    public string? KmsKeyVersionName { get; set; }
}

/// <summary>Describes the replication status of a  [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] with  automatic replication.   Only populated if the parent  [Secret][google.cloud.secretmanager.v1.Secret] has an automatic  replication policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretManagerSecretVersionStatusObservedStateReplicationStatusAutomatic
{
    /// <summary>Output only. The customer-managed encryption status of the [SecretVersion][google.cloud.secretmanager.v1.SecretVersion]. Only populated if customer-managed encryption is used.</summary>
    [JsonPropertyName("customerManagedEncryption")]
    public V1beta1SecretManagerSecretVersionStatusObservedStateReplicationStatusAutomaticCustomerManagedEncryption? CustomerManagedEncryption { get; set; }
}

/// <summary>Output only. The customer-managed encryption status of the [SecretVersion][google.cloud.secretmanager.v1.SecretVersion]. Only populated if customer-managed encryption is used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretManagerSecretVersionStatusObservedStateReplicationStatusUserManagedReplicasCustomerManagedEncryption
{
    /// <summary>Required. The resource name of the Cloud KMS CryptoKeyVersion used to encrypt the secret payload, in the following format: `projects/*/locations/*/keyRings/*/cryptoKeys/*/versions/*`.</summary>
    [JsonPropertyName("kmsKeyVersionName")]
    public string? KmsKeyVersionName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretManagerSecretVersionStatusObservedStateReplicationStatusUserManagedReplicas
{
    /// <summary>Output only. The customer-managed encryption status of the [SecretVersion][google.cloud.secretmanager.v1.SecretVersion]. Only populated if customer-managed encryption is used.</summary>
    [JsonPropertyName("customerManagedEncryption")]
    public V1beta1SecretManagerSecretVersionStatusObservedStateReplicationStatusUserManagedReplicasCustomerManagedEncryption? CustomerManagedEncryption { get; set; }

    /// <summary>Output only. The canonical ID of the replica location. For example: `"us-east1"`.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }
}

/// <summary>Describes the replication status of a  [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] with  user-managed replication.   Only populated if the parent  [Secret][google.cloud.secretmanager.v1.Secret] has a user-managed  replication policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretManagerSecretVersionStatusObservedStateReplicationStatusUserManaged
{
    /// <summary>Output only. The list of replica statuses for the [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].</summary>
    [JsonPropertyName("replicas")]
    public IList<V1beta1SecretManagerSecretVersionStatusObservedStateReplicationStatusUserManagedReplicas>? Replicas { get; set; }
}

/// <summary>The replication status of the [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretManagerSecretVersionStatusObservedStateReplicationStatus
{
    /// <summary>Describes the replication status of a  [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] with  automatic replication.   Only populated if the parent  [Secret][google.cloud.secretmanager.v1.Secret] has an automatic  replication policy.</summary>
    [JsonPropertyName("automatic")]
    public V1beta1SecretManagerSecretVersionStatusObservedStateReplicationStatusAutomatic? Automatic { get; set; }

    /// <summary>Describes the replication status of a  [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] with  user-managed replication.   Only populated if the parent  [Secret][google.cloud.secretmanager.v1.Secret] has a user-managed  replication policy.</summary>
    [JsonPropertyName("userManaged")]
    public V1beta1SecretManagerSecretVersionStatusObservedStateReplicationStatusUserManaged? UserManaged { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretManagerSecretVersionStatusObservedState
{
    /// <summary>Output only. True if payload checksum specified in [SecretPayload][google.cloud.secretmanager.v1.SecretPayload] object has been received by [SecretManagerService][google.cloud.secretmanager.v1.SecretManagerService] on [SecretManagerService.AddSecretVersion][google.cloud.secretmanager.v1.SecretManagerService.AddSecretVersion].</summary>
    [JsonPropertyName("clientSpecifiedPayloadChecksum")]
    public bool? ClientSpecifiedPayloadChecksum { get; set; }

    /// <summary>Output only. The time at which the [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The customer-managed encryption status of the [SecretVersion][google.cloud.secretmanager.v1.SecretVersion]. Only populated if customer-managed encryption is used and [Secret][google.cloud.secretmanager.v1.Secret] is a Regionalised Secret.</summary>
    [JsonPropertyName("customerManagedEncryption")]
    public V1beta1SecretManagerSecretVersionStatusObservedStateCustomerManagedEncryption? CustomerManagedEncryption { get; set; }

    /// <summary>Output only. The time this [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] was destroyed. Only present if [state][google.cloud.secretmanager.v1.SecretVersion.state] is [DESTROYED][google.cloud.secretmanager.v1.SecretVersion.State.DESTROYED].</summary>
    [JsonPropertyName("destroyTime")]
    public string? DestroyTime { get; set; }

    /// <summary>Output only. The resource name of the [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] in the format `projects/*/secrets/*/versions/*`.  [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] IDs in a [Secret][google.cloud.secretmanager.v1.Secret] start at 1 and are incremented for each subsequent version of the secret.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The replication status of the [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].</summary>
    [JsonPropertyName("replicationStatus")]
    public V1beta1SecretManagerSecretVersionStatusObservedStateReplicationStatus? ReplicationStatus { get; set; }

    /// <summary>Optional. Output only. Scheduled destroy time for secret version. This is a part of the Delayed secret version destroy feature. For a Secret with a valid version destroy TTL, when a secert version is destroyed, the version is moved to disabled state and it is scheduled for destruction. The version is destroyed only after the `scheduled_destroy_time`.</summary>
    [JsonPropertyName("scheduledDestroyTime")]
    public string? ScheduledDestroyTime { get; set; }
}

/// <summary>SecretManagerSecretVersionStatus defines the config connector machine state of SecretManagerSecretVersion</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretManagerSecretVersionStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SecretManagerSecretVersionStatusConditions>? Conditions { get; set; }

    /// <summary>DEPRECATING NOTE: Please use status.observedState.createTime instead.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>DEPRECATING NOTE: Please use status.observedState.destroyTime instead.</summary>
    [JsonPropertyName("destroyTime")]
    public string? DestroyTime { get; set; }

    /// <summary>A unique specifier for the SecretManagerSecretVersion resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>DEPRECATING NOTE: Please use status.observedState.name instead.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1SecretManagerSecretVersionStatusObservedState? ObservedState { get; set; }

    /// <summary>DEPRECATED.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>SecretManagerSecretVersion is the Schema for the SecretManagerSecretVersion API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SecretManagerSecretVersion : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SecretManagerSecretVersionSpec>, IStatus<V1beta1SecretManagerSecretVersionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SecretManagerSecretVersion";
    public const string KubeGroup = "secretmanager.cnrm.cloud.google.com";
    public const string KubePluralName = "secretmanagersecretversions";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SecretManagerSecretVersionSpec defines the desired state of SecretManagerSecretVersion</summary>
    [JsonPropertyName("spec")]
    public V1beta1SecretManagerSecretVersionSpec Spec { get; set; }

    /// <summary>SecretManagerSecretVersionStatus defines the config connector machine state of SecretManagerSecretVersion</summary>
    [JsonPropertyName("status")]
    public V1beta1SecretManagerSecretVersionStatus? Status { get; set; }
}