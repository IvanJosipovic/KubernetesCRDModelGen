using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datafactory.azure.upbound.io;
/// <summary>LinkedServiceSFTP is the Schema for the LinkedServiceSFTPs API. Manages a Linked Service (connection) between an SFTP Server and Azure Data Factory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LinkedServiceSFTPList : IKubernetesObject<V1ListMeta>, IItems<V1beta1LinkedServiceSFTP>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LinkedServiceSFTPList";
    public const string KubeGroup = "datafactory.azure.upbound.io";
    public const string KubePluralName = "linkedservicesftps";
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
    public IList<V1beta1LinkedServiceSFTP> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSFTPSpecForProviderDataFactoryIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Factory in datafactory to populate dataFactoryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSFTPSpecForProviderDataFactoryIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceSFTPSpecForProviderDataFactoryIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSFTPSpecForProviderDataFactoryIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Factory in datafactory to populate dataFactoryId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSFTPSpecForProviderDataFactoryIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceSFTPSpecForProviderDataFactoryIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSFTPSpecForProviderKeyVaultPassword
{
    /// <summary>Specifies the name of an existing Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Specifies the name of the secret containing the password.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>A key_vault_private_key_content_base64 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSFTPSpecForProviderKeyVaultPrivateKeyContentBase64
{
    /// <summary>Specifies the name of an existing Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Specifies the name of the secret containing the Base64 encoded SSH private key.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>A key_vault_private_key_passphrase block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSFTPSpecForProviderKeyVaultPrivateKeyPassphrase
{
    /// <summary>Specifies the name of an existing Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Specifies the name of the secret containing the SSH private key passphrase.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>Password to log on to the SFTP Server for Basic Authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSFTPSpecForProviderPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>The Base64 encoded private key content in OpenSSH format used to log on to the SFTP server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSFTPSpecForProviderPrivateKeyContentBase64SecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>The passphrase for the private key if the key is encrypted.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSFTPSpecForProviderPrivateKeyPassphraseSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSFTPSpecForProvider
{
    /// <summary>A map of additional properties to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, string>? AdditionalProperties { get; set; }

    /// <summary>List of tags that can be used for describing the Data Factory Linked Service.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>The type of authentication used to connect to the SFTP server. Valid options are MultiFactor, Basic and SshPublicKey.</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>The Data Factory ID in which to associate the Linked Service with. Changing this forces a new resource.</summary>
    [JsonPropertyName("dataFactoryId")]
    public string? DataFactoryId { get; set; }

    /// <summary>Reference to a Factory in datafactory to populate dataFactoryId.</summary>
    [JsonPropertyName("dataFactoryIdRef")]
    public V1beta1LinkedServiceSFTPSpecForProviderDataFactoryIdRef? DataFactoryIdRef { get; set; }

    /// <summary>Selector for a Factory in datafactory to populate dataFactoryId.</summary>
    [JsonPropertyName("dataFactoryIdSelector")]
    public V1beta1LinkedServiceSFTPSpecForProviderDataFactoryIdSelector? DataFactoryIdSelector { get; set; }

    /// <summary>The description for the Data Factory Linked Service.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The SFTP server hostname.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The host key fingerprint of the SFTP server.</summary>
    [JsonPropertyName("hostKeyFingerprint")]
    public string? HostKeyFingerprint { get; set; }

    /// <summary>The name of the integration runtime to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("integrationRuntimeName")]
    public string? IntegrationRuntimeName { get; set; }

    /// <summary>A key_vault_password block as defined below.</summary>
    [JsonPropertyName("keyVaultPassword")]
    public IList<V1beta1LinkedServiceSFTPSpecForProviderKeyVaultPassword>? KeyVaultPassword { get; set; }

    /// <summary>A key_vault_private_key_content_base64 block as defined below.</summary>
    [JsonPropertyName("keyVaultPrivateKeyContentBase64")]
    public V1beta1LinkedServiceSFTPSpecForProviderKeyVaultPrivateKeyContentBase64? KeyVaultPrivateKeyContentBase64 { get; set; }

    /// <summary>A key_vault_private_key_passphrase block as defined below.</summary>
    [JsonPropertyName("keyVaultPrivateKeyPassphrase")]
    public V1beta1LinkedServiceSFTPSpecForProviderKeyVaultPrivateKeyPassphrase? KeyVaultPrivateKeyPassphrase { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Password to log on to the SFTP Server for Basic Authentication.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1LinkedServiceSFTPSpecForProviderPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The TCP port number that the SFTP server uses to listen for client connection. Default value is 22.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The Base64 encoded private key content in OpenSSH format used to log on to the SFTP server.</summary>
    [JsonPropertyName("privateKeyContentBase64SecretRef")]
    public V1beta1LinkedServiceSFTPSpecForProviderPrivateKeyContentBase64SecretRef? PrivateKeyContentBase64SecretRef { get; set; }

    /// <summary>The passphrase for the private key if the key is encrypted.</summary>
    [JsonPropertyName("privateKeyPassphraseSecretRef")]
    public V1beta1LinkedServiceSFTPSpecForProviderPrivateKeyPassphraseSecretRef? PrivateKeyPassphraseSecretRef { get; set; }

    /// <summary>The absolute path to the private key file that the self-hosted integration runtime can access.</summary>
    [JsonPropertyName("privateKeyPath")]
    public string? PrivateKeyPath { get; set; }

    /// <summary>Whether to validate host key fingerprint while connecting. If set to false, host_key_fingerprint must also be set.</summary>
    [JsonPropertyName("skipHostKeyValidation")]
    public bool? SkipHostKeyValidation { get; set; }

    /// <summary>The username used to log on to the SFTP server.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSFTPSpecInitProviderKeyVaultPassword
{
    /// <summary>Specifies the name of an existing Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Specifies the name of the secret containing the password.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>A key_vault_private_key_content_base64 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSFTPSpecInitProviderKeyVaultPrivateKeyContentBase64
{
    /// <summary>Specifies the name of an existing Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Specifies the name of the secret containing the Base64 encoded SSH private key.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>A key_vault_private_key_passphrase block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSFTPSpecInitProviderKeyVaultPrivateKeyPassphrase
{
    /// <summary>Specifies the name of an existing Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Specifies the name of the secret containing the SSH private key passphrase.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>Password to log on to the SFTP Server for Basic Authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSFTPSpecInitProviderPasswordSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>The Base64 encoded private key content in OpenSSH format used to log on to the SFTP server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSFTPSpecInitProviderPrivateKeyContentBase64SecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>The passphrase for the private key if the key is encrypted.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSFTPSpecInitProviderPrivateKeyPassphraseSecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSFTPSpecInitProvider
{
    /// <summary>A map of additional properties to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, string>? AdditionalProperties { get; set; }

    /// <summary>List of tags that can be used for describing the Data Factory Linked Service.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>The type of authentication used to connect to the SFTP server. Valid options are MultiFactor, Basic and SshPublicKey.</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>The description for the Data Factory Linked Service.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The SFTP server hostname.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The host key fingerprint of the SFTP server.</summary>
    [JsonPropertyName("hostKeyFingerprint")]
    public string? HostKeyFingerprint { get; set; }

    /// <summary>The name of the integration runtime to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("integrationRuntimeName")]
    public string? IntegrationRuntimeName { get; set; }

    /// <summary>A key_vault_password block as defined below.</summary>
    [JsonPropertyName("keyVaultPassword")]
    public IList<V1beta1LinkedServiceSFTPSpecInitProviderKeyVaultPassword>? KeyVaultPassword { get; set; }

    /// <summary>A key_vault_private_key_content_base64 block as defined below.</summary>
    [JsonPropertyName("keyVaultPrivateKeyContentBase64")]
    public V1beta1LinkedServiceSFTPSpecInitProviderKeyVaultPrivateKeyContentBase64? KeyVaultPrivateKeyContentBase64 { get; set; }

    /// <summary>A key_vault_private_key_passphrase block as defined below.</summary>
    [JsonPropertyName("keyVaultPrivateKeyPassphrase")]
    public V1beta1LinkedServiceSFTPSpecInitProviderKeyVaultPrivateKeyPassphrase? KeyVaultPrivateKeyPassphrase { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Password to log on to the SFTP Server for Basic Authentication.</summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1beta1LinkedServiceSFTPSpecInitProviderPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>The TCP port number that the SFTP server uses to listen for client connection. Default value is 22.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The Base64 encoded private key content in OpenSSH format used to log on to the SFTP server.</summary>
    [JsonPropertyName("privateKeyContentBase64SecretRef")]
    public V1beta1LinkedServiceSFTPSpecInitProviderPrivateKeyContentBase64SecretRef? PrivateKeyContentBase64SecretRef { get; set; }

    /// <summary>The passphrase for the private key if the key is encrypted.</summary>
    [JsonPropertyName("privateKeyPassphraseSecretRef")]
    public V1beta1LinkedServiceSFTPSpecInitProviderPrivateKeyPassphraseSecretRef? PrivateKeyPassphraseSecretRef { get; set; }

    /// <summary>The absolute path to the private key file that the self-hosted integration runtime can access.</summary>
    [JsonPropertyName("privateKeyPath")]
    public string? PrivateKeyPath { get; set; }

    /// <summary>Whether to validate host key fingerprint while connecting. If set to false, host_key_fingerprint must also be set.</summary>
    [JsonPropertyName("skipHostKeyValidation")]
    public bool? SkipHostKeyValidation { get; set; }

    /// <summary>The username used to log on to the SFTP server.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSFTPSpecProviderConfigRefPolicy
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
public partial class V1beta1LinkedServiceSFTPSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceSFTPSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSFTPSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>LinkedServiceSFTPSpec defines the desired state of LinkedServiceSFTP</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSFTPSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1LinkedServiceSFTPSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1LinkedServiceSFTPSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1LinkedServiceSFTPSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1LinkedServiceSFTPSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSFTPStatusAtProviderKeyVaultPassword
{
    /// <summary>Specifies the name of an existing Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Specifies the name of the secret containing the password.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>A key_vault_private_key_content_base64 block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSFTPStatusAtProviderKeyVaultPrivateKeyContentBase64
{
    /// <summary>Specifies the name of an existing Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Specifies the name of the secret containing the Base64 encoded SSH private key.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>A key_vault_private_key_passphrase block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSFTPStatusAtProviderKeyVaultPrivateKeyPassphrase
{
    /// <summary>Specifies the name of an existing Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Specifies the name of the secret containing the SSH private key passphrase.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSFTPStatusAtProvider
{
    /// <summary>A map of additional properties to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, string>? AdditionalProperties { get; set; }

    /// <summary>List of tags that can be used for describing the Data Factory Linked Service.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>The type of authentication used to connect to the SFTP server. Valid options are MultiFactor, Basic and SshPublicKey.</summary>
    [JsonPropertyName("authenticationType")]
    public string? AuthenticationType { get; set; }

    /// <summary>The Data Factory ID in which to associate the Linked Service with. Changing this forces a new resource.</summary>
    [JsonPropertyName("dataFactoryId")]
    public string? DataFactoryId { get; set; }

    /// <summary>The description for the Data Factory Linked Service.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The SFTP server hostname.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The host key fingerprint of the SFTP server.</summary>
    [JsonPropertyName("hostKeyFingerprint")]
    public string? HostKeyFingerprint { get; set; }

    /// <summary>The ID of the Data Factory Linked Service.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the integration runtime to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("integrationRuntimeName")]
    public string? IntegrationRuntimeName { get; set; }

    /// <summary>A key_vault_password block as defined below.</summary>
    [JsonPropertyName("keyVaultPassword")]
    public IList<V1beta1LinkedServiceSFTPStatusAtProviderKeyVaultPassword>? KeyVaultPassword { get; set; }

    /// <summary>A key_vault_private_key_content_base64 block as defined below.</summary>
    [JsonPropertyName("keyVaultPrivateKeyContentBase64")]
    public V1beta1LinkedServiceSFTPStatusAtProviderKeyVaultPrivateKeyContentBase64? KeyVaultPrivateKeyContentBase64 { get; set; }

    /// <summary>A key_vault_private_key_passphrase block as defined below.</summary>
    [JsonPropertyName("keyVaultPrivateKeyPassphrase")]
    public V1beta1LinkedServiceSFTPStatusAtProviderKeyVaultPrivateKeyPassphrase? KeyVaultPrivateKeyPassphrase { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>The TCP port number that the SFTP server uses to listen for client connection. Default value is 22.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The absolute path to the private key file that the self-hosted integration runtime can access.</summary>
    [JsonPropertyName("privateKeyPath")]
    public string? PrivateKeyPath { get; set; }

    /// <summary>Whether to validate host key fingerprint while connecting. If set to false, host_key_fingerprint must also be set.</summary>
    [JsonPropertyName("skipHostKeyValidation")]
    public bool? SkipHostKeyValidation { get; set; }

    /// <summary>The username used to log on to the SFTP server.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSFTPStatusConditions
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

/// <summary>LinkedServiceSFTPStatus defines the observed state of LinkedServiceSFTP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceSFTPStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1LinkedServiceSFTPStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LinkedServiceSFTPStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>LinkedServiceSFTP is the Schema for the LinkedServiceSFTPs API. Manages a Linked Service (connection) between an SFTP Server and Azure Data Factory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LinkedServiceSFTP : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LinkedServiceSFTPSpec>, IStatus<V1beta1LinkedServiceSFTPStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LinkedServiceSFTP";
    public const string KubeGroup = "datafactory.azure.upbound.io";
    public const string KubePluralName = "linkedservicesftps";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LinkedServiceSFTPSpec defines the desired state of LinkedServiceSFTP</summary>
    [JsonPropertyName("spec")]
    public V1beta1LinkedServiceSFTPSpec Spec { get; set; }

    /// <summary>LinkedServiceSFTPStatus defines the observed state of LinkedServiceSFTP.</summary>
    [JsonPropertyName("status")]
    public V1beta1LinkedServiceSFTPStatus? Status { get; set; }
}