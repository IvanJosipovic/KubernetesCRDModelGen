using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datafactory.azure.m.upbound.io;
/// <summary>LinkedServiceAzureBlobStorage is the Schema for the LinkedServiceAzureBlobStorages API. Manages a Linked Service (connection) between an Azure Blob Storage Account and Azure Data Factory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LinkedServiceAzureBlobStorageList : IKubernetesObject<V1ListMeta>, IItems<V1beta1LinkedServiceAzureBlobStorage>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LinkedServiceAzureBlobStorageList";
    public const string KubeGroup = "datafactory.azure.m.upbound.io";
    public const string KubePluralName = "linkedserviceazureblobstorages";
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
    public IList<V1beta1LinkedServiceAzureBlobStorage> Items { get; set; }
}

/// <summary>The connection string. Conflicts with connection_string_insecure, sas_uri and service_endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpecForProviderConnectionStringSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpecForProviderDataFactoryIdRefPolicy
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
public partial class V1beta1LinkedServiceAzureBlobStorageSpecForProviderDataFactoryIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceAzureBlobStorageSpecForProviderDataFactoryIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpecForProviderDataFactoryIdSelectorPolicy
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
public partial class V1beta1LinkedServiceAzureBlobStorageSpecForProviderDataFactoryIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceAzureBlobStorageSpecForProviderDataFactoryIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpecForProviderKeyVaultSasTokenLinkedServiceNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LinkedServiceKeyVault in datafactory to populate linkedServiceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpecForProviderKeyVaultSasTokenLinkedServiceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceAzureBlobStorageSpecForProviderKeyVaultSasTokenLinkedServiceNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpecForProviderKeyVaultSasTokenLinkedServiceNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LinkedServiceKeyVault in datafactory to populate linkedServiceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpecForProviderKeyVaultSasTokenLinkedServiceNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceAzureBlobStorageSpecForProviderKeyVaultSasTokenLinkedServiceNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A key_vault_sas_token block as defined below. Use this argument to store SAS Token in an existing Key Vault. It needs an existing Key Vault Data Factory Linked Service. A sas_uri is required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpecForProviderKeyVaultSasToken
{
    /// <summary>Specifies the name of an existing Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Reference to a LinkedServiceKeyVault in datafactory to populate linkedServiceName.</summary>
    [JsonPropertyName("linkedServiceNameRef")]
    public V1beta1LinkedServiceAzureBlobStorageSpecForProviderKeyVaultSasTokenLinkedServiceNameRef? LinkedServiceNameRef { get; set; }

    /// <summary>Selector for a LinkedServiceKeyVault in datafactory to populate linkedServiceName.</summary>
    [JsonPropertyName("linkedServiceNameSelector")]
    public V1beta1LinkedServiceAzureBlobStorageSpecForProviderKeyVaultSasTokenLinkedServiceNameSelector? LinkedServiceNameSelector { get; set; }

    /// <summary>Specifies the secret name in Azure Key Vault that stores the SAS token.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>The SAS URI. Conflicts with connection_string_insecure, connection_string and service_endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpecForProviderSasuriSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The Service Endpoint. Conflicts with connection_string, connection_string_insecure and sas_uri.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpecForProviderServiceEndpointSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpecForProviderServicePrincipalLinkedKeyVaultKeyLinkedServiceNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LinkedServiceKeyVault in datafactory to populate linkedServiceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpecForProviderServicePrincipalLinkedKeyVaultKeyLinkedServiceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceAzureBlobStorageSpecForProviderServicePrincipalLinkedKeyVaultKeyLinkedServiceNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpecForProviderServicePrincipalLinkedKeyVaultKeyLinkedServiceNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LinkedServiceKeyVault in datafactory to populate linkedServiceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpecForProviderServicePrincipalLinkedKeyVaultKeyLinkedServiceNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceAzureBlobStorageSpecForProviderServicePrincipalLinkedKeyVaultKeyLinkedServiceNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A service_principal_linked_key_vault_key block as defined below. Use this argument to store Service Principal key in an existing Key Vault. It needs an existing Key Vault Data Factory Linked Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpecForProviderServicePrincipalLinkedKeyVaultKey
{
    /// <summary>Specifies the name of an existing Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Reference to a LinkedServiceKeyVault in datafactory to populate linkedServiceName.</summary>
    [JsonPropertyName("linkedServiceNameRef")]
    public V1beta1LinkedServiceAzureBlobStorageSpecForProviderServicePrincipalLinkedKeyVaultKeyLinkedServiceNameRef? LinkedServiceNameRef { get; set; }

    /// <summary>Selector for a LinkedServiceKeyVault in datafactory to populate linkedServiceName.</summary>
    [JsonPropertyName("linkedServiceNameSelector")]
    public V1beta1LinkedServiceAzureBlobStorageSpecForProviderServicePrincipalLinkedKeyVaultKeyLinkedServiceNameSelector? LinkedServiceNameSelector { get; set; }

    /// <summary>Specifies the secret name in Azure Key Vault that stores the Service Principal key.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpecForProvider
{
    /// <summary>A map of additional properties to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, string>? AdditionalProperties { get; set; }

    /// <summary>List of tags that can be used for describing the Data Factory Linked Service.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>The connection string sent insecurely. Conflicts with connection_string, sas_uri and service_endpoint.</summary>
    [JsonPropertyName("connectionStringInsecure")]
    public string? ConnectionStringInsecure { get; set; }

    /// <summary>The connection string. Conflicts with connection_string_insecure, sas_uri and service_endpoint.</summary>
    [JsonPropertyName("connectionStringSecretRef")]
    public V1beta1LinkedServiceAzureBlobStorageSpecForProviderConnectionStringSecretRef? ConnectionStringSecretRef { get; set; }

    /// <summary>The Data Factory ID in which to associate the Linked Service with. Changing this forces a new resource.</summary>
    [JsonPropertyName("dataFactoryId")]
    public string? DataFactoryId { get; set; }

    /// <summary>Reference to a Factory in datafactory to populate dataFactoryId.</summary>
    [JsonPropertyName("dataFactoryIdRef")]
    public V1beta1LinkedServiceAzureBlobStorageSpecForProviderDataFactoryIdRef? DataFactoryIdRef { get; set; }

    /// <summary>Selector for a Factory in datafactory to populate dataFactoryId.</summary>
    [JsonPropertyName("dataFactoryIdSelector")]
    public V1beta1LinkedServiceAzureBlobStorageSpecForProviderDataFactoryIdSelector? DataFactoryIdSelector { get; set; }

    /// <summary>The description for the Data Factory Linked Service.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The integration runtime reference to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("integrationRuntimeName")]
    public string? IntegrationRuntimeName { get; set; }

    /// <summary>A key_vault_sas_token block as defined below. Use this argument to store SAS Token in an existing Key Vault. It needs an existing Key Vault Data Factory Linked Service. A sas_uri is required.</summary>
    [JsonPropertyName("keyVaultSasToken")]
    public V1beta1LinkedServiceAzureBlobStorageSpecForProviderKeyVaultSasToken? KeyVaultSasToken { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>The SAS URI. Conflicts with connection_string_insecure, connection_string and service_endpoint.</summary>
    [JsonPropertyName("sasuriSecretRef")]
    public V1beta1LinkedServiceAzureBlobStorageSpecForProviderSasuriSecretRef? SasuriSecretRef { get; set; }

    /// <summary>The Service Endpoint. Conflicts with connection_string, connection_string_insecure and sas_uri.</summary>
    [JsonPropertyName("serviceEndpointSecretRef")]
    public V1beta1LinkedServiceAzureBlobStorageSpecForProviderServiceEndpointSecretRef? ServiceEndpointSecretRef { get; set; }

    /// <summary>The service principal id in which to authenticate against the Azure Blob Storage account.</summary>
    [JsonPropertyName("servicePrincipalId")]
    public string? ServicePrincipalId { get; set; }

    /// <summary>The service principal key in which to authenticate against the AAzure Blob Storage account.</summary>
    [JsonPropertyName("servicePrincipalKey")]
    public string? ServicePrincipalKey { get; set; }

    /// <summary>A service_principal_linked_key_vault_key block as defined below. Use this argument to store Service Principal key in an existing Key Vault. It needs an existing Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("servicePrincipalLinkedKeyVaultKey")]
    public V1beta1LinkedServiceAzureBlobStorageSpecForProviderServicePrincipalLinkedKeyVaultKey? ServicePrincipalLinkedKeyVaultKey { get; set; }

    /// <summary>Specify the kind of the storage account. Allowed values are Storage, StorageV2, BlobStorage and BlockBlobStorage.</summary>
    [JsonPropertyName("storageKind")]
    public string? StorageKind { get; set; }

    /// <summary>The tenant id or name in which to authenticate against the Azure Blob Storage account.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Whether to use the Data Factory's managed identity to authenticate against the Azure Blob Storage account. Incompatible with service_principal_id and service_principal_key.</summary>
    [JsonPropertyName("useManagedIdentity")]
    public bool? UseManagedIdentity { get; set; }
}

/// <summary>The connection string. Conflicts with connection_string_insecure, sas_uri and service_endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpecInitProviderConnectionStringSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpecInitProviderKeyVaultSasTokenLinkedServiceNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LinkedServiceKeyVault in datafactory to populate linkedServiceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpecInitProviderKeyVaultSasTokenLinkedServiceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceAzureBlobStorageSpecInitProviderKeyVaultSasTokenLinkedServiceNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpecInitProviderKeyVaultSasTokenLinkedServiceNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LinkedServiceKeyVault in datafactory to populate linkedServiceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpecInitProviderKeyVaultSasTokenLinkedServiceNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceAzureBlobStorageSpecInitProviderKeyVaultSasTokenLinkedServiceNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A key_vault_sas_token block as defined below. Use this argument to store SAS Token in an existing Key Vault. It needs an existing Key Vault Data Factory Linked Service. A sas_uri is required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpecInitProviderKeyVaultSasToken
{
    /// <summary>Specifies the name of an existing Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Reference to a LinkedServiceKeyVault in datafactory to populate linkedServiceName.</summary>
    [JsonPropertyName("linkedServiceNameRef")]
    public V1beta1LinkedServiceAzureBlobStorageSpecInitProviderKeyVaultSasTokenLinkedServiceNameRef? LinkedServiceNameRef { get; set; }

    /// <summary>Selector for a LinkedServiceKeyVault in datafactory to populate linkedServiceName.</summary>
    [JsonPropertyName("linkedServiceNameSelector")]
    public V1beta1LinkedServiceAzureBlobStorageSpecInitProviderKeyVaultSasTokenLinkedServiceNameSelector? LinkedServiceNameSelector { get; set; }

    /// <summary>Specifies the secret name in Azure Key Vault that stores the SAS token.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>The SAS URI. Conflicts with connection_string_insecure, connection_string and service_endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpecInitProviderSasuriSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>The Service Endpoint. Conflicts with connection_string, connection_string_insecure and sas_uri.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpecInitProviderServiceEndpointSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpecInitProviderServicePrincipalLinkedKeyVaultKeyLinkedServiceNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a LinkedServiceKeyVault in datafactory to populate linkedServiceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpecInitProviderServicePrincipalLinkedKeyVaultKeyLinkedServiceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceAzureBlobStorageSpecInitProviderServicePrincipalLinkedKeyVaultKeyLinkedServiceNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpecInitProviderServicePrincipalLinkedKeyVaultKeyLinkedServiceNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a LinkedServiceKeyVault in datafactory to populate linkedServiceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpecInitProviderServicePrincipalLinkedKeyVaultKeyLinkedServiceNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinkedServiceAzureBlobStorageSpecInitProviderServicePrincipalLinkedKeyVaultKeyLinkedServiceNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A service_principal_linked_key_vault_key block as defined below. Use this argument to store Service Principal key in an existing Key Vault. It needs an existing Key Vault Data Factory Linked Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpecInitProviderServicePrincipalLinkedKeyVaultKey
{
    /// <summary>Specifies the name of an existing Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Reference to a LinkedServiceKeyVault in datafactory to populate linkedServiceName.</summary>
    [JsonPropertyName("linkedServiceNameRef")]
    public V1beta1LinkedServiceAzureBlobStorageSpecInitProviderServicePrincipalLinkedKeyVaultKeyLinkedServiceNameRef? LinkedServiceNameRef { get; set; }

    /// <summary>Selector for a LinkedServiceKeyVault in datafactory to populate linkedServiceName.</summary>
    [JsonPropertyName("linkedServiceNameSelector")]
    public V1beta1LinkedServiceAzureBlobStorageSpecInitProviderServicePrincipalLinkedKeyVaultKeyLinkedServiceNameSelector? LinkedServiceNameSelector { get; set; }

    /// <summary>Specifies the secret name in Azure Key Vault that stores the Service Principal key.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpecInitProvider
{
    /// <summary>A map of additional properties to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, string>? AdditionalProperties { get; set; }

    /// <summary>List of tags that can be used for describing the Data Factory Linked Service.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>The connection string sent insecurely. Conflicts with connection_string, sas_uri and service_endpoint.</summary>
    [JsonPropertyName("connectionStringInsecure")]
    public string? ConnectionStringInsecure { get; set; }

    /// <summary>The connection string. Conflicts with connection_string_insecure, sas_uri and service_endpoint.</summary>
    [JsonPropertyName("connectionStringSecretRef")]
    public V1beta1LinkedServiceAzureBlobStorageSpecInitProviderConnectionStringSecretRef? ConnectionStringSecretRef { get; set; }

    /// <summary>The description for the Data Factory Linked Service.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The integration runtime reference to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("integrationRuntimeName")]
    public string? IntegrationRuntimeName { get; set; }

    /// <summary>A key_vault_sas_token block as defined below. Use this argument to store SAS Token in an existing Key Vault. It needs an existing Key Vault Data Factory Linked Service. A sas_uri is required.</summary>
    [JsonPropertyName("keyVaultSasToken")]
    public V1beta1LinkedServiceAzureBlobStorageSpecInitProviderKeyVaultSasToken? KeyVaultSasToken { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>The SAS URI. Conflicts with connection_string_insecure, connection_string and service_endpoint.</summary>
    [JsonPropertyName("sasuriSecretRef")]
    public V1beta1LinkedServiceAzureBlobStorageSpecInitProviderSasuriSecretRef? SasuriSecretRef { get; set; }

    /// <summary>The Service Endpoint. Conflicts with connection_string, connection_string_insecure and sas_uri.</summary>
    [JsonPropertyName("serviceEndpointSecretRef")]
    public V1beta1LinkedServiceAzureBlobStorageSpecInitProviderServiceEndpointSecretRef? ServiceEndpointSecretRef { get; set; }

    /// <summary>The service principal id in which to authenticate against the Azure Blob Storage account.</summary>
    [JsonPropertyName("servicePrincipalId")]
    public string? ServicePrincipalId { get; set; }

    /// <summary>The service principal key in which to authenticate against the AAzure Blob Storage account.</summary>
    [JsonPropertyName("servicePrincipalKey")]
    public string? ServicePrincipalKey { get; set; }

    /// <summary>A service_principal_linked_key_vault_key block as defined below. Use this argument to store Service Principal key in an existing Key Vault. It needs an existing Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("servicePrincipalLinkedKeyVaultKey")]
    public V1beta1LinkedServiceAzureBlobStorageSpecInitProviderServicePrincipalLinkedKeyVaultKey? ServicePrincipalLinkedKeyVaultKey { get; set; }

    /// <summary>Specify the kind of the storage account. Allowed values are Storage, StorageV2, BlobStorage and BlockBlobStorage.</summary>
    [JsonPropertyName("storageKind")]
    public string? StorageKind { get; set; }

    /// <summary>The tenant id or name in which to authenticate against the Azure Blob Storage account.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Whether to use the Data Factory's managed identity to authenticate against the Azure Blob Storage account. Incompatible with service_principal_id and service_principal_key.</summary>
    [JsonPropertyName("useManagedIdentity")]
    public bool? UseManagedIdentity { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpecProviderConfigRef
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
public partial class V1beta1LinkedServiceAzureBlobStorageSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>LinkedServiceAzureBlobStorageSpec defines the desired state of LinkedServiceAzureBlobStorage</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1LinkedServiceAzureBlobStorageSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1LinkedServiceAzureBlobStorageSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1LinkedServiceAzureBlobStorageSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1LinkedServiceAzureBlobStorageSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A key_vault_sas_token block as defined below. Use this argument to store SAS Token in an existing Key Vault. It needs an existing Key Vault Data Factory Linked Service. A sas_uri is required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageStatusAtProviderKeyVaultSasToken
{
    /// <summary>Specifies the name of an existing Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Specifies the secret name in Azure Key Vault that stores the SAS token.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>A service_principal_linked_key_vault_key block as defined below. Use this argument to store Service Principal key in an existing Key Vault. It needs an existing Key Vault Data Factory Linked Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageStatusAtProviderServicePrincipalLinkedKeyVaultKey
{
    /// <summary>Specifies the name of an existing Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("linkedServiceName")]
    public string? LinkedServiceName { get; set; }

    /// <summary>Specifies the secret name in Azure Key Vault that stores the Service Principal key.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageStatusAtProvider
{
    /// <summary>A map of additional properties to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, string>? AdditionalProperties { get; set; }

    /// <summary>List of tags that can be used for describing the Data Factory Linked Service.</summary>
    [JsonPropertyName("annotations")]
    public IList<string>? Annotations { get; set; }

    /// <summary>The connection string sent insecurely. Conflicts with connection_string, sas_uri and service_endpoint.</summary>
    [JsonPropertyName("connectionStringInsecure")]
    public string? ConnectionStringInsecure { get; set; }

    /// <summary>The Data Factory ID in which to associate the Linked Service with. Changing this forces a new resource.</summary>
    [JsonPropertyName("dataFactoryId")]
    public string? DataFactoryId { get; set; }

    /// <summary>The description for the Data Factory Linked Service.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The ID of the Data Factory Linked Service.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The integration runtime reference to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("integrationRuntimeName")]
    public string? IntegrationRuntimeName { get; set; }

    /// <summary>A key_vault_sas_token block as defined below. Use this argument to store SAS Token in an existing Key Vault. It needs an existing Key Vault Data Factory Linked Service. A sas_uri is required.</summary>
    [JsonPropertyName("keyVaultSasToken")]
    public V1beta1LinkedServiceAzureBlobStorageStatusAtProviderKeyVaultSasToken? KeyVaultSasToken { get; set; }

    /// <summary>A map of parameters to associate with the Data Factory Linked Service.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>The service principal id in which to authenticate against the Azure Blob Storage account.</summary>
    [JsonPropertyName("servicePrincipalId")]
    public string? ServicePrincipalId { get; set; }

    /// <summary>The service principal key in which to authenticate against the AAzure Blob Storage account.</summary>
    [JsonPropertyName("servicePrincipalKey")]
    public string? ServicePrincipalKey { get; set; }

    /// <summary>A service_principal_linked_key_vault_key block as defined below. Use this argument to store Service Principal key in an existing Key Vault. It needs an existing Key Vault Data Factory Linked Service.</summary>
    [JsonPropertyName("servicePrincipalLinkedKeyVaultKey")]
    public V1beta1LinkedServiceAzureBlobStorageStatusAtProviderServicePrincipalLinkedKeyVaultKey? ServicePrincipalLinkedKeyVaultKey { get; set; }

    /// <summary>Specify the kind of the storage account. Allowed values are Storage, StorageV2, BlobStorage and BlockBlobStorage.</summary>
    [JsonPropertyName("storageKind")]
    public string? StorageKind { get; set; }

    /// <summary>The tenant id or name in which to authenticate against the Azure Blob Storage account.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Whether to use the Data Factory's managed identity to authenticate against the Azure Blob Storage account. Incompatible with service_principal_id and service_principal_key.</summary>
    [JsonPropertyName("useManagedIdentity")]
    public bool? UseManagedIdentity { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageStatusConditions
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

/// <summary>LinkedServiceAzureBlobStorageStatus defines the observed state of LinkedServiceAzureBlobStorage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinkedServiceAzureBlobStorageStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1LinkedServiceAzureBlobStorageStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LinkedServiceAzureBlobStorageStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>LinkedServiceAzureBlobStorage is the Schema for the LinkedServiceAzureBlobStorages API. Manages a Linked Service (connection) between an Azure Blob Storage Account and Azure Data Factory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LinkedServiceAzureBlobStorage : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LinkedServiceAzureBlobStorageSpec>, IStatus<V1beta1LinkedServiceAzureBlobStorageStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LinkedServiceAzureBlobStorage";
    public const string KubeGroup = "datafactory.azure.m.upbound.io";
    public const string KubePluralName = "linkedserviceazureblobstorages";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LinkedServiceAzureBlobStorageSpec defines the desired state of LinkedServiceAzureBlobStorage</summary>
    [JsonPropertyName("spec")]
    public V1beta1LinkedServiceAzureBlobStorageSpec Spec { get; set; }

    /// <summary>LinkedServiceAzureBlobStorageStatus defines the observed state of LinkedServiceAzureBlobStorage.</summary>
    [JsonPropertyName("status")]
    public V1beta1LinkedServiceAzureBlobStorageStatus? Status { get; set; }
}