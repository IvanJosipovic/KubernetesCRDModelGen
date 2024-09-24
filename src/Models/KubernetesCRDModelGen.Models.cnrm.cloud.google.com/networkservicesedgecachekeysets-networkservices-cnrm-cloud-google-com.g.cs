using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networkservices.cnrm.cloud.google.com;
/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheKeysetSpecProjectRef
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

/// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheKeysetSpecPublicKeyValueValueFromSecretKeyRef
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
public partial class V1alpha1NetworkServicesEdgeCacheKeysetSpecPublicKeyValueValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1alpha1NetworkServicesEdgeCacheKeysetSpecPublicKeyValueValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

/// <summary>The base64-encoded value of the Ed25519 public key. The base64 encoding can be padded (44 bytes) or unpadded (43 bytes). Representations or encodings of the public key other than this will be rejected with an error.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheKeysetSpecPublicKeyValue
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1alpha1NetworkServicesEdgeCacheKeysetSpecPublicKeyValueValueFrom? ValueFrom { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheKeysetSpecPublicKey
{
    /// <summary>The ID of the public key. The ID must be 1-63 characters long, and comply with RFC1035. The name must be 1-64 characters long, and match the regular expression [a-zA-Z][a-zA-Z0-9_-]* which means the first character must be a letter, and all following characters must be a dash, underscore, letter or digit.</summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>Set to true to have the CDN automatically manage this public key value.</summary>
    [JsonPropertyName("managed")]
    public bool? Managed { get; set; }

    /// <summary>The base64-encoded value of the Ed25519 public key. The base64 encoding can be padded (44 bytes) or unpadded (43 bytes). Representations or encodings of the public key other than this will be rejected with an error.</summary>
    [JsonPropertyName("value")]
    public V1alpha1NetworkServicesEdgeCacheKeysetSpecPublicKeyValue? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheKeysetSpecValidationSharedKeys
{
    /// <summary>The name of the secret version in Secret Manager.  The resource name of the secret version must be in the format 'projects/*/secrets/*/versions/*' where the '*' values are replaced by the secrets themselves. The secrets must be at least 16 bytes large.  The recommended secret size depends on the signature algorithm you are using. * If you are using HMAC-SHA1, we suggest 20-byte secrets. * If you are using HMAC-SHA256, we suggest 32-byte secrets. See RFC 2104, Section 3 for more details on these recommendations.</summary>
    [JsonPropertyName("secretVersion")]
    public string SecretVersion { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheKeysetSpec
{
    /// <summary>A human-readable description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1NetworkServicesEdgeCacheKeysetSpecProjectRef ProjectRef { get; set; }

    /// <summary>An ordered list of Ed25519 public keys to use for validating signed requests. You must specify 'public_keys' or 'validation_shared_keys' (or both). The keys in 'public_keys' are checked first. You may specify no more than one Google-managed public key. If you specify 'public_keys', you must specify at least one (1) key and may specify up to three (3) keys.  Ed25519 public keys are not secret, and only allow Google to validate a request was signed by your corresponding private key. Ensure that the private key is kept secret, and that only authorized users can add public keys to a keyset.</summary>
    [JsonPropertyName("publicKey")]
    public IList<V1alpha1NetworkServicesEdgeCacheKeysetSpecPublicKey>? PublicKey { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>An ordered list of shared keys to use for validating signed requests. Shared keys are secret.  Ensure that only authorized users can add 'validation_shared_keys' to a keyset. You can rotate keys by appending (pushing) a new key to the list of 'validation_shared_keys' and removing any superseded keys. You must specify 'public_keys' or 'validation_shared_keys' (or both). The keys in 'public_keys' are checked first.</summary>
    [JsonPropertyName("validationSharedKeys")]
    public IList<V1alpha1NetworkServicesEdgeCacheKeysetSpecValidationSharedKeys>? ValidationSharedKeys { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkServicesEdgeCacheKeysetStatusConditions
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
public partial class V1alpha1NetworkServicesEdgeCacheKeysetStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1NetworkServicesEdgeCacheKeysetStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NetworkServicesEdgeCacheKeyset : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1NetworkServicesEdgeCacheKeysetSpec>, IStatus<V1alpha1NetworkServicesEdgeCacheKeysetStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NetworkServicesEdgeCacheKeyset";
    public const string KubeGroup = "networkservices.cnrm.cloud.google.com";
    public const string KubePluralName = "networkservicesedgecachekeysets";
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
    public V1alpha1NetworkServicesEdgeCacheKeysetSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1NetworkServicesEdgeCacheKeysetStatus? Status { get; set; }
}