using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.secretmanager.gcp.m.upbound.io;
#nullable enable
/// <summary>Secret is the Schema for the Secrets API. A Secret is a logical secret whose value and versions can be accessed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SecretList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Secret>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SecretList";
    public const string KubeGroup = "secretmanager.gcp.m.upbound.io";
    public const string KubePluralName = "secrets";
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
    public IList<V1beta1Secret> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Customer Managed Encryption for the secret. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretSpecForProviderReplicationAutoCustomerManagedEncryption
{
    /// <summary>Describes the Cloud KMS encryption key that will be used to protect destination secret.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The Secret will automatically be replicated without any restrictions. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretSpecForProviderReplicationAuto
{
    /// <summary>Customer Managed Encryption for the secret. Structure is documented below.</summary>
    [JsonPropertyName("customerManagedEncryption")]
    public V1beta1SecretSpecForProviderReplicationAutoCustomerManagedEncryption? CustomerManagedEncryption { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Customer Managed Encryption for the secret. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretSpecForProviderReplicationUserManagedReplicasCustomerManagedEncryption
{
    /// <summary>Describes the Cloud KMS encryption key that will be used to protect destination secret.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretSpecForProviderReplicationUserManagedReplicas
{
    /// <summary>Customer Managed Encryption for the secret. Structure is documented below.</summary>
    [JsonPropertyName("customerManagedEncryption")]
    public V1beta1SecretSpecForProviderReplicationUserManagedReplicasCustomerManagedEncryption? CustomerManagedEncryption { get; set; }

    /// <summary>The canonical IDs of the location to replicate data. For example: "us-east1".</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The Secret will be replicated to the regions specified by the user. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretSpecForProviderReplicationUserManaged
{
    /// <summary>The list of Replicas for this Secret. Cannot be empty. Structure is documented below.</summary>
    [JsonPropertyName("replicas")]
    public IList<V1beta1SecretSpecForProviderReplicationUserManagedReplicas>? Replicas { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The replication policy of the secret data attached to the Secret. It cannot be changed after the Secret has been created. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretSpecForProviderReplication
{
    /// <summary>The Secret will automatically be replicated without any restrictions. Structure is documented below.</summary>
    [JsonPropertyName("auto")]
    public V1beta1SecretSpecForProviderReplicationAuto? Auto { get; set; }

    /// <summary>The Secret will be replicated to the regions specified by the user. Structure is documented below.</summary>
    [JsonPropertyName("userManaged")]
    public V1beta1SecretSpecForProviderReplicationUserManaged? UserManaged { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The rotation time and period for a Secret. At next_rotation_time, Secret Manager will send a Pub/Sub notification to the topics configured on the Secret. topics must be set to configure rotation. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretSpecForProviderRotation
{
    /// <summary>Timestamp in UTC at which the Secret is scheduled to rotate. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("nextRotationTime")]
    public string? NextRotationTime { get; set; }

    /// <summary>The Duration between rotation notifications. Must be in seconds and at least 3600s (1h) and at most 3153600000s (100 years). If rotationPeriod is set, next_rotation_time must be set. next_rotation_time will be advanced by this period when the service automatically sends rotation notifications.</summary>
    [JsonPropertyName("rotationPeriod")]
    public string? RotationPeriod { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretSpecForProviderTopics
{
    /// <summary>The resource name of the Pub/Sub topic that will be published to, in the following format: projects//topics/. For publication to succeed, the Secret Manager Service Agent service account must have pubsub.publisher permissions on the topic.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretSpecForProvider
{
    /// <summary>Custom metadata about the secret. Annotations are distinct from various forms of labels. Annotations exist to allow client tools to store their own state information without requiring a database. Annotation keys must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, begin and end with an alphanumeric character ([a-z0-9A-Z]), and may have dashes (-), underscores (_), dots (.), and alphanumerics in between these symbols. The total size of annotation keys and values must be less than 16KiB. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>Timestamp in UTC when the Secret is scheduled to expire. This is always provided on output, regardless of what was sent on input. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z". Only one of expire_time or ttl can be provided.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>The labels assigned to this Secret. Label keys must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}][\p{Ll}\p{Lo}\p{N}-]{0,62} Label values must be between 0 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}\p{N}-]{0,63} No more than 64 labels can be assigned to a given resource. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The replication policy of the secret data attached to the Secret. It cannot be changed after the Secret has been created. Structure is documented below.</summary>
    [JsonPropertyName("replication")]
    public V1beta1SecretSpecForProviderReplication? Replication { get; set; }

    /// <summary>The rotation time and period for a Secret. At next_rotation_time, Secret Manager will send a Pub/Sub notification to the topics configured on the Secret. topics must be set to configure rotation. Structure is documented below.</summary>
    [JsonPropertyName("rotation")]
    public V1beta1SecretSpecForProviderRotation? Rotation { get; set; }

    /// <summary>A list of up to 10 Pub/Sub topics to which messages are published when control plane operations are called on the secret or its versions. Structure is documented below.</summary>
    [JsonPropertyName("topics")]
    public IList<V1beta1SecretSpecForProviderTopics>? Topics { get; set; }

    /// <summary>The TTL for the Secret. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s". Only one of ttl or expire_time can be provided.</summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }

    /// <summary>Mapping from version alias to version name. A version alias is a string with a maximum length of 63 characters and can contain uppercase and lowercase letters, numerals, and the hyphen (-) and underscore ('_') characters. An alias string must start with a letter and cannot be the string 'latest' or 'NEW'. No more than 50 aliases can be assigned to a given secret. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("versionAliases")]
    public IDictionary<string, string>? VersionAliases { get; set; }

    /// <summary>Secret Version TTL after destruction request. This is a part of the delayed delete feature on Secret Version. For secret with versionDestroyTtl&gt;0, version destruction doesn't happen immediately on calling destroy instead the version goes to a disabled state and the actual destruction happens after this TTL expires.</summary>
    [JsonPropertyName("versionDestroyTtl")]
    public string? VersionDestroyTtl { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Customer Managed Encryption for the secret. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretSpecInitProviderReplicationAutoCustomerManagedEncryption
{
    /// <summary>Describes the Cloud KMS encryption key that will be used to protect destination secret.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The Secret will automatically be replicated without any restrictions. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretSpecInitProviderReplicationAuto
{
    /// <summary>Customer Managed Encryption for the secret. Structure is documented below.</summary>
    [JsonPropertyName("customerManagedEncryption")]
    public V1beta1SecretSpecInitProviderReplicationAutoCustomerManagedEncryption? CustomerManagedEncryption { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Customer Managed Encryption for the secret. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretSpecInitProviderReplicationUserManagedReplicasCustomerManagedEncryption
{
    /// <summary>Describes the Cloud KMS encryption key that will be used to protect destination secret.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretSpecInitProviderReplicationUserManagedReplicas
{
    /// <summary>Customer Managed Encryption for the secret. Structure is documented below.</summary>
    [JsonPropertyName("customerManagedEncryption")]
    public V1beta1SecretSpecInitProviderReplicationUserManagedReplicasCustomerManagedEncryption? CustomerManagedEncryption { get; set; }

    /// <summary>The canonical IDs of the location to replicate data. For example: "us-east1".</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The Secret will be replicated to the regions specified by the user. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretSpecInitProviderReplicationUserManaged
{
    /// <summary>The list of Replicas for this Secret. Cannot be empty. Structure is documented below.</summary>
    [JsonPropertyName("replicas")]
    public IList<V1beta1SecretSpecInitProviderReplicationUserManagedReplicas>? Replicas { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The replication policy of the secret data attached to the Secret. It cannot be changed after the Secret has been created. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretSpecInitProviderReplication
{
    /// <summary>The Secret will automatically be replicated without any restrictions. Structure is documented below.</summary>
    [JsonPropertyName("auto")]
    public V1beta1SecretSpecInitProviderReplicationAuto? Auto { get; set; }

    /// <summary>The Secret will be replicated to the regions specified by the user. Structure is documented below.</summary>
    [JsonPropertyName("userManaged")]
    public V1beta1SecretSpecInitProviderReplicationUserManaged? UserManaged { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The rotation time and period for a Secret. At next_rotation_time, Secret Manager will send a Pub/Sub notification to the topics configured on the Secret. topics must be set to configure rotation. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretSpecInitProviderRotation
{
    /// <summary>Timestamp in UTC at which the Secret is scheduled to rotate. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("nextRotationTime")]
    public string? NextRotationTime { get; set; }

    /// <summary>The Duration between rotation notifications. Must be in seconds and at least 3600s (1h) and at most 3153600000s (100 years). If rotationPeriod is set, next_rotation_time must be set. next_rotation_time will be advanced by this period when the service automatically sends rotation notifications.</summary>
    [JsonPropertyName("rotationPeriod")]
    public string? RotationPeriod { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretSpecInitProviderTopics
{
    /// <summary>The resource name of the Pub/Sub topic that will be published to, in the following format: projects//topics/. For publication to succeed, the Secret Manager Service Agent service account must have pubsub.publisher permissions on the topic.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretSpecInitProvider
{
    /// <summary>Custom metadata about the secret. Annotations are distinct from various forms of labels. Annotations exist to allow client tools to store their own state information without requiring a database. Annotation keys must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, begin and end with an alphanumeric character ([a-z0-9A-Z]), and may have dashes (-), underscores (_), dots (.), and alphanumerics in between these symbols. The total size of annotation keys and values must be less than 16KiB. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>Timestamp in UTC when the Secret is scheduled to expire. This is always provided on output, regardless of what was sent on input. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z". Only one of expire_time or ttl can be provided.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>The labels assigned to this Secret. Label keys must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}][\p{Ll}\p{Lo}\p{N}-]{0,62} Label values must be between 0 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}\p{N}-]{0,63} No more than 64 labels can be assigned to a given resource. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The replication policy of the secret data attached to the Secret. It cannot be changed after the Secret has been created. Structure is documented below.</summary>
    [JsonPropertyName("replication")]
    public V1beta1SecretSpecInitProviderReplication? Replication { get; set; }

    /// <summary>The rotation time and period for a Secret. At next_rotation_time, Secret Manager will send a Pub/Sub notification to the topics configured on the Secret. topics must be set to configure rotation. Structure is documented below.</summary>
    [JsonPropertyName("rotation")]
    public V1beta1SecretSpecInitProviderRotation? Rotation { get; set; }

    /// <summary>A list of up to 10 Pub/Sub topics to which messages are published when control plane operations are called on the secret or its versions. Structure is documented below.</summary>
    [JsonPropertyName("topics")]
    public IList<V1beta1SecretSpecInitProviderTopics>? Topics { get; set; }

    /// <summary>The TTL for the Secret. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s". Only one of ttl or expire_time can be provided.</summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }

    /// <summary>Mapping from version alias to version name. A version alias is a string with a maximum length of 63 characters and can contain uppercase and lowercase letters, numerals, and the hyphen (-) and underscore ('_') characters. An alias string must start with a letter and cannot be the string 'latest' or 'NEW'. No more than 50 aliases can be assigned to a given secret. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("versionAliases")]
    public IDictionary<string, string>? VersionAliases { get; set; }

    /// <summary>Secret Version TTL after destruction request. This is a part of the delayed delete feature on Secret Version. For secret with versionDestroyTtl&gt;0, version destruction doesn't happen immediately on calling destroy instead the version goes to a disabled state and the actual destruction happens after this TTL expires.</summary>
    [JsonPropertyName("versionDestroyTtl")]
    public string? VersionDestroyTtl { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SecretSpec defines the desired state of Secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SecretSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SecretSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SecretSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SecretSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Customer Managed Encryption for the secret. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretStatusAtProviderReplicationAutoCustomerManagedEncryption
{
    /// <summary>Describes the Cloud KMS encryption key that will be used to protect destination secret.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The Secret will automatically be replicated without any restrictions. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretStatusAtProviderReplicationAuto
{
    /// <summary>Customer Managed Encryption for the secret. Structure is documented below.</summary>
    [JsonPropertyName("customerManagedEncryption")]
    public V1beta1SecretStatusAtProviderReplicationAutoCustomerManagedEncryption? CustomerManagedEncryption { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Customer Managed Encryption for the secret. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretStatusAtProviderReplicationUserManagedReplicasCustomerManagedEncryption
{
    /// <summary>Describes the Cloud KMS encryption key that will be used to protect destination secret.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretStatusAtProviderReplicationUserManagedReplicas
{
    /// <summary>Customer Managed Encryption for the secret. Structure is documented below.</summary>
    [JsonPropertyName("customerManagedEncryption")]
    public V1beta1SecretStatusAtProviderReplicationUserManagedReplicasCustomerManagedEncryption? CustomerManagedEncryption { get; set; }

    /// <summary>The canonical IDs of the location to replicate data. For example: "us-east1".</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The Secret will be replicated to the regions specified by the user. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretStatusAtProviderReplicationUserManaged
{
    /// <summary>The list of Replicas for this Secret. Cannot be empty. Structure is documented below.</summary>
    [JsonPropertyName("replicas")]
    public IList<V1beta1SecretStatusAtProviderReplicationUserManagedReplicas>? Replicas { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The replication policy of the secret data attached to the Secret. It cannot be changed after the Secret has been created. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretStatusAtProviderReplication
{
    /// <summary>The Secret will automatically be replicated without any restrictions. Structure is documented below.</summary>
    [JsonPropertyName("auto")]
    public V1beta1SecretStatusAtProviderReplicationAuto? Auto { get; set; }

    /// <summary>The Secret will be replicated to the regions specified by the user. Structure is documented below.</summary>
    [JsonPropertyName("userManaged")]
    public V1beta1SecretStatusAtProviderReplicationUserManaged? UserManaged { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The rotation time and period for a Secret. At next_rotation_time, Secret Manager will send a Pub/Sub notification to the topics configured on the Secret. topics must be set to configure rotation. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretStatusAtProviderRotation
{
    /// <summary>Timestamp in UTC at which the Secret is scheduled to rotate. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z".</summary>
    [JsonPropertyName("nextRotationTime")]
    public string? NextRotationTime { get; set; }

    /// <summary>The Duration between rotation notifications. Must be in seconds and at least 3600s (1h) and at most 3153600000s (100 years). If rotationPeriod is set, next_rotation_time must be set. next_rotation_time will be advanced by this period when the service automatically sends rotation notifications.</summary>
    [JsonPropertyName("rotationPeriod")]
    public string? RotationPeriod { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretStatusAtProviderTopics
{
    /// <summary>The resource name of the Pub/Sub topic that will be published to, in the following format: projects//topics/. For publication to succeed, the Secret Manager Service Agent service account must have pubsub.publisher permissions on the topic.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretStatusAtProvider
{
    /// <summary>Custom metadata about the secret. Annotations are distinct from various forms of labels. Annotations exist to allow client tools to store their own state information without requiring a database. Annotation keys must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, begin and end with an alphanumeric character ([a-z0-9A-Z]), and may have dashes (-), underscores (_), dots (.), and alphanumerics in between these symbols. The total size of annotation keys and values must be less than 16KiB. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>The time at which the Secret was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Defaults to false.</summary>
    [JsonPropertyName("deletionProtection")]
    public bool? DeletionProtection { get; set; }

    /// <summary>for all of the annotations present on the resource.</summary>
    [JsonPropertyName("effectiveAnnotations")]
    public IDictionary<string, string>? EffectiveAnnotations { get; set; }

    /// <summary>for all of the labels present on the resource.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>Timestamp in UTC when the Secret is scheduled to expire. This is always provided on output, regardless of what was sent on input. A timestamp in RFC3339 UTC "Zulu" format, with nanosecond resolution and up to nine fractional digits. Examples: "2014-10-02T15:01:23Z" and "2014-10-02T15:01:23.045123456Z". Only one of expire_time or ttl can be provided.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/secrets/{{secret_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The labels assigned to this Secret. Label keys must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}][\p{Ll}\p{Lo}\p{N}-]{0,62} Label values must be between 0 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}\p{N}-]{0,63} No more than 64 labels can be assigned to a given resource. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The resource name of the Secret. Format: projects/{{project}}/secrets/{{secret_id}}</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The replication policy of the secret data attached to the Secret. It cannot be changed after the Secret has been created. Structure is documented below.</summary>
    [JsonPropertyName("replication")]
    public V1beta1SecretStatusAtProviderReplication? Replication { get; set; }

    /// <summary>The rotation time and period for a Secret. At next_rotation_time, Secret Manager will send a Pub/Sub notification to the topics configured on the Secret. topics must be set to configure rotation. Structure is documented below.</summary>
    [JsonPropertyName("rotation")]
    public V1beta1SecretStatusAtProviderRotation? Rotation { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>A list of up to 10 Pub/Sub topics to which messages are published when control plane operations are called on the secret or its versions. Structure is documented below.</summary>
    [JsonPropertyName("topics")]
    public IList<V1beta1SecretStatusAtProviderTopics>? Topics { get; set; }

    /// <summary>The TTL for the Secret. A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s". Only one of ttl or expire_time can be provided.</summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }

    /// <summary>Mapping from version alias to version name. A version alias is a string with a maximum length of 63 characters and can contain uppercase and lowercase letters, numerals, and the hyphen (-) and underscore ('_') characters. An alias string must start with a letter and cannot be the string 'latest' or 'NEW'. No more than 50 aliases can be assigned to a given secret. An object containing a list of "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.</summary>
    [JsonPropertyName("versionAliases")]
    public IDictionary<string, string>? VersionAliases { get; set; }

    /// <summary>Secret Version TTL after destruction request. This is a part of the delayed delete feature on Secret Version. For secret with versionDestroyTtl&gt;0, version destruction doesn't happen immediately on calling destroy instead the version goes to a disabled state and the actual destruction happens after this TTL expires.</summary>
    [JsonPropertyName("versionDestroyTtl")]
    public string? VersionDestroyTtl { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretStatusConditions
{
    /// <summary>LastTransitionTime is the last time this condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>A Message containing details about this condition's last transition from one status to another, if any.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition's last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of this condition. At most one of each condition type may apply to a resource at any point in time.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SecretStatus defines the observed state of Secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SecretStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SecretStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SecretStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Secret is the Schema for the Secrets API. A Secret is a logical secret whose value and versions can be accessed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Secret : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SecretSpec>, IStatus<V1beta1SecretStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Secret";
    public const string KubeGroup = "secretmanager.gcp.m.upbound.io";
    public const string KubePluralName = "secrets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SecretSpec defines the desired state of Secret</summary>
    [JsonPropertyName("spec")]
    public V1beta1SecretSpec Spec { get; set; }

    /// <summary>SecretStatus defines the observed state of Secret.</summary>
    [JsonPropertyName("status")]
    public V1beta1SecretStatus? Status { get; set; }
}
#nullable disable
