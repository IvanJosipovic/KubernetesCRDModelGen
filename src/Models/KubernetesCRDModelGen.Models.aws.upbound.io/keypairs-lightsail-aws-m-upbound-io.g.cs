using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.lightsail.aws.m.upbound.io;
/// <summary>KeyPair is the Schema for the KeyPairs API. Manages a Lightsail Key Pair.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1KeyPairList : IKubernetesObject<V1ListMeta>, IItems<V1beta1KeyPair>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "KeyPairList";
    public const string KubeGroup = "lightsail.aws.m.upbound.io";
    public const string KubePluralName = "keypairs";
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
    public IList<V1beta1KeyPair> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeyPairSpecForProvider
{
    /// <summary>Name of the Lightsail Key Pair. Conflicts with name_prefix.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PGP key to encrypt the resulting private key material. Only used when creating a new key pair.</summary>
    [JsonPropertyName("pgpKey")]
    public string? PgpKey { get; set; }

    /// <summary>Public key material. This public key will be imported into Lightsail.</summary>
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeyPairSpecInitProvider
{
    /// <summary>Name of the Lightsail Key Pair. Conflicts with name_prefix.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PGP key to encrypt the resulting private key material. Only used when creating a new key pair.</summary>
    [JsonPropertyName("pgpKey")]
    public string? PgpKey { get; set; }

    /// <summary>Public key material. This public key will be imported into Lightsail.</summary>
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeyPairSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeyPairSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>KeyPairSpec defines the desired state of KeyPair</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeyPairSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1KeyPairSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1KeyPairSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1KeyPairSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1KeyPairSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeyPairStatusAtProvider
{
    /// <summary>ARN of the Lightsail key pair.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>MD5 public key fingerprint for the encrypted private key.</summary>
    [JsonPropertyName("encryptedFingerprint")]
    public string? EncryptedFingerprint { get; set; }

    /// <summary>Private key material, base 64 encoded and encrypted with the given pgp_key. This is only populated when creating a new key and pgp_key is supplied.</summary>
    [JsonPropertyName("encryptedPrivateKey")]
    public string? EncryptedPrivateKey { get; set; }

    /// <summary>MD5 public key fingerprint as specified in section 4 of RFC 4716.</summary>
    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; set; }

    /// <summary>Name used for this key pair.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the Lightsail Key Pair. Conflicts with name_prefix.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PGP key to encrypt the resulting private key material. Only used when creating a new key pair.</summary>
    [JsonPropertyName("pgpKey")]
    public string? PgpKey { get; set; }

    /// <summary>Private key, base64 encoded. This is only populated when creating a new key, and when no pgp_key is provided.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }

    /// <summary>Public key material. This public key will be imported into Lightsail.</summary>
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeyPairStatusConditions
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

/// <summary>KeyPairStatus defines the observed state of KeyPair.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeyPairStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1KeyPairStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1KeyPairStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>KeyPair is the Schema for the KeyPairs API. Manages a Lightsail Key Pair.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1KeyPair : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1KeyPairSpec>, IStatus<V1beta1KeyPairStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "KeyPair";
    public const string KubeGroup = "lightsail.aws.m.upbound.io";
    public const string KubePluralName = "keypairs";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>KeyPairSpec defines the desired state of KeyPair</summary>
    [JsonPropertyName("spec")]
    public V1beta1KeyPairSpec Spec { get; set; }

    /// <summary>KeyPairStatus defines the observed state of KeyPair.</summary>
    [JsonPropertyName("status")]
    public V1beta1KeyPairStatus? Status { get; set; }
}