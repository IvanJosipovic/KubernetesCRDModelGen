using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.machinelearningservices.azure.com;
/// <summary>ApplicationInsightsReference: ARM id of the application insights associated with this workspace. This cannot be changed once the workspace has been created</summary>
public partial class V1api20210701storageWorkspaceSpecApplicationInsightsReference
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

/// <summary>ContainerRegistryReference: ARM id of the container registry associated with this workspace. This cannot be changed once the workspace has been created</summary>
public partial class V1api20210701storageWorkspaceSpecContainerRegistryReference
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

/// <summary>Storage version of v1api20210701.IdentityForCmk Identity that will be used to access key vault for encryption at rest</summary>
public partial class V1api20210701storageWorkspaceSpecEncryptionIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>Storage version of v1api20210701.KeyVaultProperties</summary>
public partial class V1api20210701storageWorkspaceSpecEncryptionKeyVaultProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("identityClientId")]
    public string? IdentityClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyIdentifier")]
    public string? KeyIdentifier { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyVaultArmId")]
    public string? KeyVaultArmId { get; set; }
}

/// <summary>Storage version of v1api20210701.EncryptionProperty</summary>
public partial class V1api20210701storageWorkspaceSpecEncryption
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210701.IdentityForCmk Identity that will be used to access key vault for encryption at rest</summary>
    [JsonPropertyName("identity")]
    public V1api20210701storageWorkspaceSpecEncryptionIdentity? Identity { get; set; }

    /// <summary>Storage version of v1api20210701.KeyVaultProperties</summary>
    [JsonPropertyName("keyVaultProperties")]
    public V1api20210701storageWorkspaceSpecEncryptionKeyVaultProperties? KeyVaultProperties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
public partial class V1api20210701storageWorkspaceSpecIdentityUserAssignedIdentitiesReference
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

/// <summary>Storage version of v1api20210701.UserAssignedIdentityDetails Information about the user assigned identity for the resource</summary>
public partial class V1api20210701storageWorkspaceSpecIdentityUserAssignedIdentities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20210701storageWorkspaceSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20210701.Identity Identity for the resource.</summary>
public partial class V1api20210701storageWorkspaceSpecIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20210701storageWorkspaceSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>KeyVaultReference: ARM id of the key vault associated with this workspace. This cannot be changed once the workspace has been created</summary>
public partial class V1api20210701storageWorkspaceSpecKeyVaultReference
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

/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to ConfigMapDestination in configmaps.go. Changes to one should likely also be made to the other.</summary>
public partial class V1api20210701storageWorkspaceSpecOperatorSpecSecretsAppInsightsInstrumentationKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to ConfigMapDestination in configmaps.go. Changes to one should likely also be made to the other.</summary>
public partial class V1api20210701storageWorkspaceSpecOperatorSpecSecretsContainerRegistryPassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to ConfigMapDestination in configmaps.go. Changes to one should likely also be made to the other.</summary>
public partial class V1api20210701storageWorkspaceSpecOperatorSpecSecretsContainerRegistryPassword2
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to ConfigMapDestination in configmaps.go. Changes to one should likely also be made to the other.</summary>
public partial class V1api20210701storageWorkspaceSpecOperatorSpecSecretsContainerRegistryUserName
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to ConfigMapDestination in configmaps.go. Changes to one should likely also be made to the other.</summary>
public partial class V1api20210701storageWorkspaceSpecOperatorSpecSecretsPrimaryNotebookAccessKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to ConfigMapDestination in configmaps.go. Changes to one should likely also be made to the other.</summary>
public partial class V1api20210701storageWorkspaceSpecOperatorSpecSecretsSecondaryNotebookAccessKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to ConfigMapDestination in configmaps.go. Changes to one should likely also be made to the other.</summary>
public partial class V1api20210701storageWorkspaceSpecOperatorSpecSecretsUserStorageKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20210701.WorkspaceOperatorSecrets</summary>
public partial class V1api20210701storageWorkspaceSpecOperatorSpecSecrets
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to ConfigMapDestination in configmaps.go. Changes to one should likely also be made to the other.</summary>
    [JsonPropertyName("appInsightsInstrumentationKey")]
    public V1api20210701storageWorkspaceSpecOperatorSpecSecretsAppInsightsInstrumentationKey? AppInsightsInstrumentationKey { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to ConfigMapDestination in configmaps.go. Changes to one should likely also be made to the other.</summary>
    [JsonPropertyName("containerRegistryPassword")]
    public V1api20210701storageWorkspaceSpecOperatorSpecSecretsContainerRegistryPassword? ContainerRegistryPassword { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to ConfigMapDestination in configmaps.go. Changes to one should likely also be made to the other.</summary>
    [JsonPropertyName("containerRegistryPassword2")]
    public V1api20210701storageWorkspaceSpecOperatorSpecSecretsContainerRegistryPassword2? ContainerRegistryPassword2 { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to ConfigMapDestination in configmaps.go. Changes to one should likely also be made to the other.</summary>
    [JsonPropertyName("containerRegistryUserName")]
    public V1api20210701storageWorkspaceSpecOperatorSpecSecretsContainerRegistryUserName? ContainerRegistryUserName { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to ConfigMapDestination in configmaps.go. Changes to one should likely also be made to the other.</summary>
    [JsonPropertyName("primaryNotebookAccessKey")]
    public V1api20210701storageWorkspaceSpecOperatorSpecSecretsPrimaryNotebookAccessKey? PrimaryNotebookAccessKey { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to ConfigMapDestination in configmaps.go. Changes to one should likely also be made to the other.</summary>
    [JsonPropertyName("secondaryNotebookAccessKey")]
    public V1api20210701storageWorkspaceSpecOperatorSpecSecretsSecondaryNotebookAccessKey? SecondaryNotebookAccessKey { get; set; }

    /// <summary>SecretDestination describes the location to store a single secret value. Note: This is similar to ConfigMapDestination in configmaps.go. Changes to one should likely also be made to the other.</summary>
    [JsonPropertyName("userStorageKey")]
    public V1api20210701storageWorkspaceSpecOperatorSpecSecretsUserStorageKey? UserStorageKey { get; set; }
}

/// <summary>Storage version of v1api20210701.WorkspaceOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
public partial class V1api20210701storageWorkspaceSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210701.WorkspaceOperatorSecrets</summary>
    [JsonPropertyName("secrets")]
    public V1api20210701storageWorkspaceSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
public partial class V1api20210701storageWorkspaceSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PrimaryUserAssignedIdentityReference: The user assigned identity resource id that represents the workspace identity.</summary>
public partial class V1api20210701storageWorkspaceSpecPrimaryUserAssignedIdentityReference
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

/// <summary>Storage version of v1api20210701.CosmosDbSettings</summary>
public partial class V1api20210701storageWorkspaceSpecServiceManagedResourcesSettingsCosmosDb
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("collectionsThroughput")]
    public int? CollectionsThroughput { get; set; }
}

/// <summary>Storage version of v1api20210701.ServiceManagedResourcesSettings</summary>
public partial class V1api20210701storageWorkspaceSpecServiceManagedResourcesSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210701.CosmosDbSettings</summary>
    [JsonPropertyName("cosmosDb")]
    public V1api20210701storageWorkspaceSpecServiceManagedResourcesSettingsCosmosDb? CosmosDb { get; set; }
}

/// <summary>PrivateLinkResourceReference: The resource id that private link links to.</summary>
public partial class V1api20210701storageWorkspaceSpecSharedPrivateLinkResourcesPrivateLinkResourceReference
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

/// <summary>Storage version of v1api20210701.SharedPrivateLinkResource</summary>
public partial class V1api20210701storageWorkspaceSpecSharedPrivateLinkResources
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>PrivateLinkResourceReference: The resource id that private link links to.</summary>
    [JsonPropertyName("privateLinkResourceReference")]
    public V1api20210701storageWorkspaceSpecSharedPrivateLinkResourcesPrivateLinkResourceReference? PrivateLinkResourceReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requestMessage")]
    public string? RequestMessage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Storage version of v1api20210701.Sku Sku of the resource</summary>
public partial class V1api20210701storageWorkspaceSpecSku
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>StorageAccountReference: ARM id of the storage account associated with this workspace. This cannot be changed once the workspace has been created</summary>
public partial class V1api20210701storageWorkspaceSpecStorageAccountReference
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

/// <summary>Storage version of v1api20210701.SystemData Metadata pertaining to creation and last modification of the resource.</summary>
public partial class V1api20210701storageWorkspaceSpecSystemData
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>Storage version of v1api20210701.Workspace_Spec</summary>
public partial class V1api20210701storageWorkspaceSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowPublicAccessWhenBehindVnet")]
    public bool? AllowPublicAccessWhenBehindVnet { get; set; }

    /// <summary>ApplicationInsightsReference: ARM id of the application insights associated with this workspace. This cannot be changed once the workspace has been created</summary>
    [JsonPropertyName("applicationInsightsReference")]
    public V1api20210701storageWorkspaceSpecApplicationInsightsReference? ApplicationInsightsReference { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>ContainerRegistryReference: ARM id of the container registry associated with this workspace. This cannot be changed once the workspace has been created</summary>
    [JsonPropertyName("containerRegistryReference")]
    public V1api20210701storageWorkspaceSpecContainerRegistryReference? ContainerRegistryReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }

    /// <summary>Storage version of v1api20210701.EncryptionProperty</summary>
    [JsonPropertyName("encryption")]
    public V1api20210701storageWorkspaceSpecEncryption? Encryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hbiWorkspace")]
    public bool? HbiWorkspace { get; set; }

    /// <summary>Storage version of v1api20210701.Identity Identity for the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20210701storageWorkspaceSpecIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imageBuildCompute")]
    public string? ImageBuildCompute { get; set; }

    /// <summary>KeyVaultReference: ARM id of the key vault associated with this workspace. This cannot be changed once the workspace has been created</summary>
    [JsonPropertyName("keyVaultReference")]
    public V1api20210701storageWorkspaceSpecKeyVaultReference? KeyVaultReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Storage version of v1api20210701.WorkspaceOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20210701storageWorkspaceSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20210701storageWorkspaceSpecOwner Owner { get; set; }

    /// <summary>PrimaryUserAssignedIdentityReference: The user assigned identity resource id that represents the workspace identity.</summary>
    [JsonPropertyName("primaryUserAssignedIdentityReference")]
    public V1api20210701storageWorkspaceSpecPrimaryUserAssignedIdentityReference? PrimaryUserAssignedIdentityReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>Storage version of v1api20210701.ServiceManagedResourcesSettings</summary>
    [JsonPropertyName("serviceManagedResourcesSettings")]
    public V1api20210701storageWorkspaceSpecServiceManagedResourcesSettings? ServiceManagedResourcesSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedPrivateLinkResources")]
    public IList<V1api20210701storageWorkspaceSpecSharedPrivateLinkResources>? SharedPrivateLinkResources { get; set; }

    /// <summary>Storage version of v1api20210701.Sku Sku of the resource</summary>
    [JsonPropertyName("sku")]
    public V1api20210701storageWorkspaceSpecSku? Sku { get; set; }

    /// <summary>StorageAccountReference: ARM id of the storage account associated with this workspace. This cannot be changed once the workspace has been created</summary>
    [JsonPropertyName("storageAccountReference")]
    public V1api20210701storageWorkspaceSpecStorageAccountReference? StorageAccountReference { get; set; }

    /// <summary>Storage version of v1api20210701.SystemData Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20210701storageWorkspaceSpecSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
public partial class V1api20210701storageWorkspaceStatusConditions
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

/// <summary>Storage version of v1api20210701.IdentityForCmk_STATUS Identity that will be used to access key vault for encryption at rest</summary>
public partial class V1api20210701storageWorkspaceStatusEncryptionIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>Storage version of v1api20210701.KeyVaultProperties_STATUS</summary>
public partial class V1api20210701storageWorkspaceStatusEncryptionKeyVaultProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("identityClientId")]
    public string? IdentityClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyIdentifier")]
    public string? KeyIdentifier { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyVaultArmId")]
    public string? KeyVaultArmId { get; set; }
}

/// <summary>Storage version of v1api20210701.EncryptionProperty_STATUS</summary>
public partial class V1api20210701storageWorkspaceStatusEncryption
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210701.IdentityForCmk_STATUS Identity that will be used to access key vault for encryption at rest</summary>
    [JsonPropertyName("identity")]
    public V1api20210701storageWorkspaceStatusEncryptionIdentity? Identity { get; set; }

    /// <summary>Storage version of v1api20210701.KeyVaultProperties_STATUS</summary>
    [JsonPropertyName("keyVaultProperties")]
    public V1api20210701storageWorkspaceStatusEncryptionKeyVaultProperties? KeyVaultProperties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Storage version of v1api20210701.UserAssignedIdentity_STATUS User Assigned Identity</summary>
public partial class V1api20210701storageWorkspaceStatusIdentityUserAssignedIdentities
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

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>Storage version of v1api20210701.Identity_STATUS Identity for the resource.</summary>
public partial class V1api20210701storageWorkspaceStatusIdentity
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
    public IDictionary<string, V1api20210701storageWorkspaceStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Storage version of v1api20210701.NotebookPreparationError_STATUS</summary>
public partial class V1api20210701storageWorkspaceStatusNotebookInfoNotebookPreparationError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("statusCode")]
    public int? StatusCode { get; set; }
}

/// <summary>Storage version of v1api20210701.NotebookResourceInfo_STATUS</summary>
public partial class V1api20210701storageWorkspaceStatusNotebookInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>Storage version of v1api20210701.NotebookPreparationError_STATUS</summary>
    [JsonPropertyName("notebookPreparationError")]
    public V1api20210701storageWorkspaceStatusNotebookInfoNotebookPreparationError? NotebookPreparationError { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v1api20210701.PrivateEndpointConnection_STATUS The Private Endpoint Connection resource.</summary>
public partial class V1api20210701storageWorkspaceStatusPrivateEndpointConnections
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20210701.CosmosDbSettings_STATUS</summary>
public partial class V1api20210701storageWorkspaceStatusServiceManagedResourcesSettingsCosmosDb
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("collectionsThroughput")]
    public int? CollectionsThroughput { get; set; }
}

/// <summary>Storage version of v1api20210701.ServiceManagedResourcesSettings_STATUS</summary>
public partial class V1api20210701storageWorkspaceStatusServiceManagedResourcesSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210701.CosmosDbSettings_STATUS</summary>
    [JsonPropertyName("cosmosDb")]
    public V1api20210701storageWorkspaceStatusServiceManagedResourcesSettingsCosmosDb? CosmosDb { get; set; }
}

/// <summary>Storage version of v1api20210701.SharedPrivateLinkResource_STATUS</summary>
public partial class V1api20210701storageWorkspaceStatusSharedPrivateLinkResources
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateLinkResourceId")]
    public string? PrivateLinkResourceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requestMessage")]
    public string? RequestMessage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Storage version of v1api20210701.Sku_STATUS Sku of the resource</summary>
public partial class V1api20210701storageWorkspaceStatusSku
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Storage version of v1api20210701.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
public partial class V1api20210701storageWorkspaceStatusSystemData
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>Storage version of v1api20210701.Workspace_STATUS An object that represents a machine learning workspace.</summary>
public partial class V1api20210701storageWorkspaceStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowPublicAccessWhenBehindVnet")]
    public bool? AllowPublicAccessWhenBehindVnet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applicationInsights")]
    public string? ApplicationInsights { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20210701storageWorkspaceStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("containerRegistry")]
    public string? ContainerRegistry { get; set; }

    /// <summary></summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("discoveryUrl")]
    public string? DiscoveryUrl { get; set; }

    /// <summary>Storage version of v1api20210701.EncryptionProperty_STATUS</summary>
    [JsonPropertyName("encryption")]
    public V1api20210701storageWorkspaceStatusEncryption? Encryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hbiWorkspace")]
    public bool? HbiWorkspace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20210701.Identity_STATUS Identity for the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20210701storageWorkspaceStatusIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("imageBuildCompute")]
    public string? ImageBuildCompute { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyVault")]
    public string? KeyVault { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mlFlowTrackingUri")]
    public string? MlFlowTrackingUri { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20210701.NotebookResourceInfo_STATUS</summary>
    [JsonPropertyName("notebookInfo")]
    public V1api20210701storageWorkspaceStatusNotebookInfo? NotebookInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("primaryUserAssignedIdentity")]
    public string? PrimaryUserAssignedIdentity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20210701storageWorkspaceStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateLinkCount")]
    public int? PrivateLinkCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>Storage version of v1api20210701.ServiceManagedResourcesSettings_STATUS</summary>
    [JsonPropertyName("serviceManagedResourcesSettings")]
    public V1api20210701storageWorkspaceStatusServiceManagedResourcesSettings? ServiceManagedResourcesSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceProvisionedResourceGroup")]
    public string? ServiceProvisionedResourceGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedPrivateLinkResources")]
    public IList<V1api20210701storageWorkspaceStatusSharedPrivateLinkResources>? SharedPrivateLinkResources { get; set; }

    /// <summary>Storage version of v1api20210701.Sku_STATUS Sku of the resource</summary>
    [JsonPropertyName("sku")]
    public V1api20210701storageWorkspaceStatusSku? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageAccount")]
    public string? StorageAccount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageHnsEnabled")]
    public bool? StorageHnsEnabled { get; set; }

    /// <summary>Storage version of v1api20210701.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20210701storageWorkspaceStatusSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Storage version of v1api20210701.Workspace Generator information: - Generated from: /machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2021-07-01/machineLearningServices.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}</summary>
public partial class V1api20210701storageWorkspace : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20210701storageWorkspaceSpec>, IStatus<V1api20210701storageWorkspaceStatus>
{
    public const string KubeApiVersion = "v1api20210701storage";
    public const string KubeKind = "Workspace";
    public const string KubeGroup = "machinelearningservices.azure.com";
    public const string KubePluralName = "workspaces";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20210701.Workspace_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20210701storageWorkspaceSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20210701.Workspace_STATUS An object that represents a machine learning workspace.</summary>
    [JsonPropertyName("status")]
    public V1api20210701storageWorkspaceStatus? Status { get; set; }
}