using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.batch.azure.com;
public partial class V1api20210101storageBatchAccountSpecAutoStorageStorageAccountReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1api20210101storageBatchAccountSpecAutoStorage
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>StorageAccountReference: The resource ID of the storage account to be used for auto-storage account.</summary>
    [JsonPropertyName("storageAccountReference")]
    public V1api20210101storageBatchAccountSpecAutoStorageStorageAccountReference StorageAccountReference { get; set; }
}

public partial class V1api20210101storageBatchAccountSpecEncryptionKeyVaultProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyIdentifier")]
    public string? KeyIdentifier { get; set; }
}

public partial class V1api20210101storageBatchAccountSpecEncryption
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keySource")]
    public string? KeySource { get; set; }

    /// <summary>Storage version of v1api20210101.KeyVaultProperties KeyVault configuration when using an encryption KeySource of Microsoft.KeyVault.</summary>
    [JsonPropertyName("keyVaultProperties")]
    public V1api20210101storageBatchAccountSpecEncryptionKeyVaultProperties? KeyVaultProperties { get; set; }
}

public partial class V1api20210101storageBatchAccountSpecIdentityUserAssignedIdentitiesReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1api20210101storageBatchAccountSpecIdentityUserAssignedIdentities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20210101storageBatchAccountSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

public partial class V1api20210101storageBatchAccountSpecIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20210101storageBatchAccountSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

public partial class V1api20210101storageBatchAccountSpecKeyVaultReferenceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1api20210101storageBatchAccountSpecKeyVaultReference
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: The resource ID of the Azure key vault associated with the Batch account.</summary>
    [JsonPropertyName("reference")]
    public V1api20210101storageBatchAccountSpecKeyVaultReferenceReference Reference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

public partial class V1api20210101storageBatchAccountSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1api20210101storageBatchAccountSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210101.AutoStorageBaseProperties The properties related to the auto-storage account.</summary>
    [JsonPropertyName("autoStorage")]
    public V1api20210101storageBatchAccountSpecAutoStorage? AutoStorage { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Storage version of v1api20210101.EncryptionProperties Configures how customer data is encrypted inside the Batch account. By default, accounts are encrypted using a Microsoft managed key. For additional control, a customer-managed key can be used instead.</summary>
    [JsonPropertyName("encryption")]
    public V1api20210101storageBatchAccountSpecEncryption? Encryption { get; set; }

    /// <summary>Storage version of v1api20210101.BatchAccountIdentity The identity of the Batch account, if configured. This is only used when the user specifies 'Microsoft.KeyVault' as their Batch account encryption configuration.</summary>
    [JsonPropertyName("identity")]
    public V1api20210101storageBatchAccountSpecIdentity? Identity { get; set; }

    /// <summary>Storage version of v1api20210101.KeyVaultReference Identifies the Azure key vault associated with a Batch account.</summary>
    [JsonPropertyName("keyVaultReference")]
    public V1api20210101storageBatchAccountSpecKeyVaultReference? KeyVaultReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20210101storageBatchAccountSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("poolAllocationMode")]
    public string? PoolAllocationMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public partial class V1api20210101storageBatchAccountStatusAutoStorage
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastKeySync")]
    public string? LastKeySync { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }
}

public partial class V1api20210101storageBatchAccountStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Reason for the condition's last transition. Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Severity with which to treat failures of this type of condition. For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False. This is omitted in all cases when Status == Unknown</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

public partial class V1api20210101storageBatchAccountStatusDedicatedCoreQuotaPerVMFamily
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("coreQuota")]
    public int? CoreQuota { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public partial class V1api20210101storageBatchAccountStatusEncryptionKeyVaultProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyIdentifier")]
    public string? KeyIdentifier { get; set; }
}

public partial class V1api20210101storageBatchAccountStatusEncryption
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keySource")]
    public string? KeySource { get; set; }

    /// <summary>Storage version of v1api20210101.KeyVaultProperties_STATUS KeyVault configuration when using an encryption KeySource of Microsoft.KeyVault.</summary>
    [JsonPropertyName("keyVaultProperties")]
    public V1api20210101storageBatchAccountStatusEncryptionKeyVaultProperties? KeyVaultProperties { get; set; }
}

public partial class V1api20210101storageBatchAccountStatusIdentityUserAssignedIdentities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

public partial class V1api20210101storageBatchAccountStatusIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20210101storageBatchAccountStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

public partial class V1api20210101storageBatchAccountStatusKeyVaultReference
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

public partial class V1api20210101storageBatchAccountStatusPrivateEndpointConnections
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

public partial class V1api20210101storageBatchAccountStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("accountEndpoint")]
    public string? AccountEndpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("activeJobAndJobScheduleQuota")]
    public int? ActiveJobAndJobScheduleQuota { get; set; }

    /// <summary>Storage version of v1api20210101.AutoStorageProperties_STATUS Contains information about the auto-storage account associated with a Batch account.</summary>
    [JsonPropertyName("autoStorage")]
    public V1api20210101storageBatchAccountStatusAutoStorage? AutoStorage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20210101storageBatchAccountStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dedicatedCoreQuota")]
    public int? DedicatedCoreQuota { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dedicatedCoreQuotaPerVMFamily")]
    public IList<V1api20210101storageBatchAccountStatusDedicatedCoreQuotaPerVMFamily>? DedicatedCoreQuotaPerVMFamily { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dedicatedCoreQuotaPerVMFamilyEnforced")]
    public bool? DedicatedCoreQuotaPerVMFamilyEnforced { get; set; }

    /// <summary>Storage version of v1api20210101.EncryptionProperties_STATUS Configures how customer data is encrypted inside the Batch account. By default, accounts are encrypted using a Microsoft managed key. For additional control, a customer-managed key can be used instead.</summary>
    [JsonPropertyName("encryption")]
    public V1api20210101storageBatchAccountStatusEncryption? Encryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20210101.BatchAccountIdentity_STATUS The identity of the Batch account, if configured. This is only used when the user specifies 'Microsoft.KeyVault' as their Batch account encryption configuration.</summary>
    [JsonPropertyName("identity")]
    public V1api20210101storageBatchAccountStatusIdentity? Identity { get; set; }

    /// <summary>Storage version of v1api20210101.KeyVaultReference_STATUS Identifies the Azure key vault associated with a Batch account.</summary>
    [JsonPropertyName("keyVaultReference")]
    public V1api20210101storageBatchAccountStatusKeyVaultReference? KeyVaultReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lowPriorityCoreQuota")]
    public int? LowPriorityCoreQuota { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("poolAllocationMode")]
    public string? PoolAllocationMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("poolQuota")]
    public int? PoolQuota { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20210101storageBatchAccountStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210101storageBatchAccount : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20210101storageBatchAccountSpec>, IStatus<V1api20210101storageBatchAccountStatus>
{
    public const string KubeApiVersion = "v1api20210101storage";
    public const string KubeKind = "BatchAccount";
    public const string KubeGroup = "batch.azure.com";
    public const string KubePluralName = "batchaccounts";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20210101.BatchAccount_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20210101storageBatchAccountSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20210101.BatchAccount_STATUS Contains information about an Azure Batch account.</summary>
    [JsonPropertyName("status")]
    public V1api20210101storageBatchAccountStatus? Status { get; set; }
}