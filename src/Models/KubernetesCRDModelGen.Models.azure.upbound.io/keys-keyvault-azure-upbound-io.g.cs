using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.keyvault.azure.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeySpecForProviderKeyVaultIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Vault in keyvault to populate keyVaultId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeySpecForProviderKeyVaultIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KeySpecForProviderKeyVaultIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeySpecForProviderKeyVaultIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Vault in keyvault to populate keyVaultId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeySpecForProviderKeyVaultIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KeySpecForProviderKeyVaultIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeySpecForProviderRotationPolicyAutomatic
{
    /// <summary>Rotate automatically at a duration after create as an ISO 8601 duration.</summary>
    [JsonPropertyName("timeAfterCreation")]
    public string? TimeAfterCreation { get; set; }

    /// <summary>Rotate automatically at a duration before expiry as an ISO 8601 duration.</summary>
    [JsonPropertyName("timeBeforeExpiry")]
    public string? TimeBeforeExpiry { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeySpecForProviderRotationPolicy
{
    /// <summary>An automatic block as defined below.</summary>
    [JsonPropertyName("automatic")]
    public IList<V1beta1KeySpecForProviderRotationPolicyAutomatic>? Automatic { get; set; }

    /// <summary>Expire a Key Vault Key after given duration as an ISO 8601 duration.</summary>
    [JsonPropertyName("expireAfter")]
    public string? ExpireAfter { get; set; }

    /// <summary>Notify at a given duration before expiry as an ISO 8601 duration.</summary>
    [JsonPropertyName("notifyBeforeExpiry")]
    public string? NotifyBeforeExpiry { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeySpecForProvider
{
    /// <summary>Specifies the curve to use when creating an EC key. Possible values are P-256, P-256K, P-384, and P-521. This field will be required in a future release if key_type is EC or EC-HSM. The API will default to P-256 if nothing is specified. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("curve")]
    public string? Curve { get; set; }

    /// <summary>Expiration UTC datetime (Y-m-d'T'H:M:S'Z'). When this parameter gets changed on reruns, if newer date is ahead of current date, an update is performed. If the newer date is before the current date, resource will be force created.</summary>
    [JsonPropertyName("expirationDate")]
    public string? ExpirationDate { get; set; }

    /// <summary>A list of JSON web key operations. Possible values include: decrypt, encrypt, sign, unwrapKey, verify and wrapKey. Please note these values are case sensitive.</summary>
    [JsonPropertyName("keyOpts")]
    public IList<string>? KeyOpts { get; set; }

    /// <summary>Specifies the Size of the RSA key to create in bytes. For example, 1024 or 2048. Note: This field is required if key_type is RSA or RSA-HSM. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("keySize")]
    public double? KeySize { get; set; }

    /// <summary>Specifies the Key Type to use for this Key Vault Key. Possible values are EC (Elliptic Curve), EC-HSM, RSA and RSA-HSM. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>The ID of the Key Vault where the Key should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Reference to a Vault in keyvault to populate keyVaultId.</summary>
    [JsonPropertyName("keyVaultIdRef")]
    public V1beta1KeySpecForProviderKeyVaultIdRef? KeyVaultIdRef { get; set; }

    /// <summary>Selector for a Vault in keyvault to populate keyVaultId.</summary>
    [JsonPropertyName("keyVaultIdSelector")]
    public V1beta1KeySpecForProviderKeyVaultIdSelector? KeyVaultIdSelector { get; set; }

    /// <summary>Specifies the name of the Key Vault Key. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Key not usable before the provided UTC datetime (Y-m-d'T'H:M:S'Z').</summary>
    [JsonPropertyName("notBeforeDate")]
    public string? NotBeforeDate { get; set; }

    /// <summary>A rotation_policy block as defined below.</summary>
    [JsonPropertyName("rotationPolicy")]
    public IList<V1beta1KeySpecForProviderRotationPolicy>? RotationPolicy { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeySpecInitProviderKeyVaultIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Vault in keyvault to populate keyVaultId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeySpecInitProviderKeyVaultIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KeySpecInitProviderKeyVaultIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeySpecInitProviderKeyVaultIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Vault in keyvault to populate keyVaultId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeySpecInitProviderKeyVaultIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KeySpecInitProviderKeyVaultIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeySpecInitProviderRotationPolicyAutomatic
{
    /// <summary>Rotate automatically at a duration after create as an ISO 8601 duration.</summary>
    [JsonPropertyName("timeAfterCreation")]
    public string? TimeAfterCreation { get; set; }

    /// <summary>Rotate automatically at a duration before expiry as an ISO 8601 duration.</summary>
    [JsonPropertyName("timeBeforeExpiry")]
    public string? TimeBeforeExpiry { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeySpecInitProviderRotationPolicy
{
    /// <summary>An automatic block as defined below.</summary>
    [JsonPropertyName("automatic")]
    public IList<V1beta1KeySpecInitProviderRotationPolicyAutomatic>? Automatic { get; set; }

    /// <summary>Expire a Key Vault Key after given duration as an ISO 8601 duration.</summary>
    [JsonPropertyName("expireAfter")]
    public string? ExpireAfter { get; set; }

    /// <summary>Notify at a given duration before expiry as an ISO 8601 duration.</summary>
    [JsonPropertyName("notifyBeforeExpiry")]
    public string? NotifyBeforeExpiry { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeySpecInitProvider
{
    /// <summary>Specifies the curve to use when creating an EC key. Possible values are P-256, P-256K, P-384, and P-521. This field will be required in a future release if key_type is EC or EC-HSM. The API will default to P-256 if nothing is specified. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("curve")]
    public string? Curve { get; set; }

    /// <summary>Expiration UTC datetime (Y-m-d'T'H:M:S'Z'). When this parameter gets changed on reruns, if newer date is ahead of current date, an update is performed. If the newer date is before the current date, resource will be force created.</summary>
    [JsonPropertyName("expirationDate")]
    public string? ExpirationDate { get; set; }

    /// <summary>A list of JSON web key operations. Possible values include: decrypt, encrypt, sign, unwrapKey, verify and wrapKey. Please note these values are case sensitive.</summary>
    [JsonPropertyName("keyOpts")]
    public IList<string>? KeyOpts { get; set; }

    /// <summary>Specifies the Size of the RSA key to create in bytes. For example, 1024 or 2048. Note: This field is required if key_type is RSA or RSA-HSM. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("keySize")]
    public double? KeySize { get; set; }

    /// <summary>Specifies the Key Type to use for this Key Vault Key. Possible values are EC (Elliptic Curve), EC-HSM, RSA and RSA-HSM. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>The ID of the Key Vault where the Key should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Reference to a Vault in keyvault to populate keyVaultId.</summary>
    [JsonPropertyName("keyVaultIdRef")]
    public V1beta1KeySpecInitProviderKeyVaultIdRef? KeyVaultIdRef { get; set; }

    /// <summary>Selector for a Vault in keyvault to populate keyVaultId.</summary>
    [JsonPropertyName("keyVaultIdSelector")]
    public V1beta1KeySpecInitProviderKeyVaultIdSelector? KeyVaultIdSelector { get; set; }

    /// <summary>Specifies the name of the Key Vault Key. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Key not usable before the provided UTC datetime (Y-m-d'T'H:M:S'Z').</summary>
    [JsonPropertyName("notBeforeDate")]
    public string? NotBeforeDate { get; set; }

    /// <summary>A rotation_policy block as defined below.</summary>
    [JsonPropertyName("rotationPolicy")]
    public IList<V1beta1KeySpecInitProviderRotationPolicy>? RotationPolicy { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeySpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1KeySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>KeySpec defines the desired state of Key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1KeySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1KeySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1KeySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1KeySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeyStatusAtProviderRotationPolicyAutomatic
{
    /// <summary>Rotate automatically at a duration after create as an ISO 8601 duration.</summary>
    [JsonPropertyName("timeAfterCreation")]
    public string? TimeAfterCreation { get; set; }

    /// <summary>Rotate automatically at a duration before expiry as an ISO 8601 duration.</summary>
    [JsonPropertyName("timeBeforeExpiry")]
    public string? TimeBeforeExpiry { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeyStatusAtProviderRotationPolicy
{
    /// <summary>An automatic block as defined below.</summary>
    [JsonPropertyName("automatic")]
    public IList<V1beta1KeyStatusAtProviderRotationPolicyAutomatic>? Automatic { get; set; }

    /// <summary>Expire a Key Vault Key after given duration as an ISO 8601 duration.</summary>
    [JsonPropertyName("expireAfter")]
    public string? ExpireAfter { get; set; }

    /// <summary>Notify at a given duration before expiry as an ISO 8601 duration.</summary>
    [JsonPropertyName("notifyBeforeExpiry")]
    public string? NotifyBeforeExpiry { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeyStatusAtProvider
{
    /// <summary>Specifies the curve to use when creating an EC key. Possible values are P-256, P-256K, P-384, and P-521. This field will be required in a future release if key_type is EC or EC-HSM. The API will default to P-256 if nothing is specified. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("curve")]
    public string? Curve { get; set; }

    /// <summary>The RSA public exponent of this Key Vault Key.</summary>
    [JsonPropertyName("e")]
    public string? E { get; set; }

    /// <summary>Expiration UTC datetime (Y-m-d'T'H:M:S'Z'). When this parameter gets changed on reruns, if newer date is ahead of current date, an update is performed. If the newer date is before the current date, resource will be force created.</summary>
    [JsonPropertyName("expirationDate")]
    public string? ExpirationDate { get; set; }

    /// <summary>The Key Vault Key ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A list of JSON web key operations. Possible values include: decrypt, encrypt, sign, unwrapKey, verify and wrapKey. Please note these values are case sensitive.</summary>
    [JsonPropertyName("keyOpts")]
    public IList<string>? KeyOpts { get; set; }

    /// <summary>Specifies the Size of the RSA key to create in bytes. For example, 1024 or 2048. Note: This field is required if key_type is RSA or RSA-HSM. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("keySize")]
    public double? KeySize { get; set; }

    /// <summary>Specifies the Key Type to use for this Key Vault Key. Possible values are EC (Elliptic Curve), EC-HSM, RSA and RSA-HSM. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>The ID of the Key Vault where the Key should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>The RSA modulus of this Key Vault Key.</summary>
    [JsonPropertyName("n")]
    public string? N { get; set; }

    /// <summary>Specifies the name of the Key Vault Key. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Key not usable before the provided UTC datetime (Y-m-d'T'H:M:S'Z').</summary>
    [JsonPropertyName("notBeforeDate")]
    public string? NotBeforeDate { get; set; }

    /// <summary>The OpenSSH encoded public key of this Key Vault Key.</summary>
    [JsonPropertyName("publicKeyOpenssh")]
    public string? PublicKeyOpenssh { get; set; }

    /// <summary>The PEM encoded public key of this Key Vault Key.</summary>
    [JsonPropertyName("publicKeyPem")]
    public string? PublicKeyPem { get; set; }

    /// <summary>The (Versioned) ID for this Key Vault Key. This property points to a specific version of a Key Vault Key, as such using this won't auto-rotate values if used in other Azure Services.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>The Versionless ID of the Key Vault Key. This property allows other Azure Services (that support it) to auto-rotate their value when the Key Vault Key is updated.</summary>
    [JsonPropertyName("resourceVersionlessId")]
    public string? ResourceVersionlessId { get; set; }

    /// <summary>A rotation_policy block as defined below.</summary>
    [JsonPropertyName("rotationPolicy")]
    public IList<V1beta1KeyStatusAtProviderRotationPolicy>? RotationPolicy { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The current version of the Key Vault Key.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>The Base ID of the Key Vault Key.</summary>
    [JsonPropertyName("versionlessId")]
    public string? VersionlessId { get; set; }

    /// <summary>The EC X component of this Key Vault Key.</summary>
    [JsonPropertyName("x")]
    public string? X { get; set; }

    /// <summary>The EC Y component of this Key Vault Key.</summary>
    [JsonPropertyName("y")]
    public string? Y { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeyStatusConditions
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

/// <summary>KeyStatus defines the observed state of Key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1KeyStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1KeyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1KeyStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Key is the Schema for the Keys API. Manages a Key Vault Key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Key : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1KeySpec>, IStatus<V1beta1KeyStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Key";
    public const string KubeGroup = "keyvault.azure.upbound.io";
    public const string KubePluralName = "keys";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>KeySpec defines the desired state of Key</summary>
    [JsonPropertyName("spec")]
    public V1beta1KeySpec Spec { get; set; }

    /// <summary>KeyStatus defines the observed state of Key.</summary>
    [JsonPropertyName("status")]
    public V1beta1KeyStatus? Status { get; set; }
}

/// <summary>Key is the Schema for the Keys API. Manages a Key Vault Key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1KeyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Key>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "KeyList";
    public const string KubeGroup = "keyvault.azure.upbound.io";
    public const string KubePluralName = "keys";
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
    public IList<V1beta1Key> Items { get; set; }
}