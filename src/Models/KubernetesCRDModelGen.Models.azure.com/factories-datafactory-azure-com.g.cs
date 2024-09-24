using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datafactory.azure.com;
/// <summary>UserAssignedIdentityReference: The resource id of the user assigned identity to authenticate to customer's key vault.</summary>
public partial class V1api20180601storageFactorySpecEncryptionIdentityUserAssignedIdentityReference
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

/// <summary>Storage version of v1api20180601.CMKIdentityDefinition Managed Identity used for CMK.</summary>
public partial class V1api20180601storageFactorySpecEncryptionIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>UserAssignedIdentityReference: The resource id of the user assigned identity to authenticate to customer's key vault.</summary>
    [JsonPropertyName("userAssignedIdentityReference")]
    public V1api20180601storageFactorySpecEncryptionIdentityUserAssignedIdentityReference? UserAssignedIdentityReference { get; set; }
}

/// <summary>Storage version of v1api20180601.EncryptionConfiguration Definition of CMK for the factory.</summary>
public partial class V1api20180601storageFactorySpecEncryption
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20180601.CMKIdentityDefinition Managed Identity used for CMK.</summary>
    [JsonPropertyName("identity")]
    public V1api20180601storageFactorySpecEncryptionIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyVersion")]
    public string? KeyVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vaultBaseUrl")]
    public string? VaultBaseUrl { get; set; }
}

/// <summary>Storage version of v1api20180601.GlobalParameterSpecification Definition of a single parameter for an entity.</summary>
public partial class V1api20180601storageFactorySpecGlobalParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public IDictionary<string, JsonNode>? Value { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
public partial class V1api20180601storageFactorySpecIdentityUserAssignedIdentitiesReference
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

/// <summary>Storage version of v1api20180601.UserAssignedIdentityDetails Information about the user assigned identity for the resource</summary>
public partial class V1api20180601storageFactorySpecIdentityUserAssignedIdentities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20180601storageFactorySpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20180601.FactoryIdentity Identity properties of the factory resource.</summary>
public partial class V1api20180601storageFactorySpecIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20180601storageFactorySpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
public partial class V1api20180601storageFactorySpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PurviewResourceReference: Purview resource id.</summary>
public partial class V1api20180601storageFactorySpecPurviewConfigurationPurviewResourceReference
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

/// <summary>Storage version of v1api20180601.PurviewConfiguration Purview configuration.</summary>
public partial class V1api20180601storageFactorySpecPurviewConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>PurviewResourceReference: Purview resource id.</summary>
    [JsonPropertyName("purviewResourceReference")]
    public V1api20180601storageFactorySpecPurviewConfigurationPurviewResourceReference? PurviewResourceReference { get; set; }
}

/// <summary>Storage version of v1api20180601.GitHubClientSecret Client secret information for factory's bring your own app repository configuration.</summary>
public partial class V1api20180601storageFactorySpecRepoConfigurationFactoryGitHubConfigurationClientSecret
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("byoaSecretAkvUrl")]
    public string? ByoaSecretAkvUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("byoaSecretName")]
    public string? ByoaSecretName { get; set; }
}

/// <summary>Storage version of v1api20180601.FactoryGitHubConfiguration</summary>
public partial class V1api20180601storageFactorySpecRepoConfigurationFactoryGitHubConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Storage version of v1api20180601.GitHubClientSecret Client secret information for factory's bring your own app repository configuration.</summary>
    [JsonPropertyName("clientSecret")]
    public V1api20180601storageFactorySpecRepoConfigurationFactoryGitHubConfigurationClientSecret? ClientSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("collaborationBranch")]
    public string? CollaborationBranch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disablePublish")]
    public bool? DisablePublish { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastCommitId")]
    public string? LastCommitId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rootFolder")]
    public string? RootFolder { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20180601.FactoryVSTSConfiguration</summary>
public partial class V1api20180601storageFactorySpecRepoConfigurationFactoryVSTSConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("collaborationBranch")]
    public string? CollaborationBranch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disablePublish")]
    public bool? DisablePublish { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastCommitId")]
    public string? LastCommitId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("projectName")]
    public string? ProjectName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rootFolder")]
    public string? RootFolder { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20180601.FactoryRepoConfiguration</summary>
public partial class V1api20180601storageFactorySpecRepoConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20180601.FactoryGitHubConfiguration</summary>
    [JsonPropertyName("factoryGitHubConfiguration")]
    public V1api20180601storageFactorySpecRepoConfigurationFactoryGitHubConfiguration? FactoryGitHubConfiguration { get; set; }

    /// <summary>Storage version of v1api20180601.FactoryVSTSConfiguration</summary>
    [JsonPropertyName("factoryVSTSConfiguration")]
    public V1api20180601storageFactorySpecRepoConfigurationFactoryVSTSConfiguration? FactoryVSTSConfiguration { get; set; }
}

/// <summary>Storage version of v1api20180601.Factory_Spec</summary>
public partial class V1api20180601storageFactorySpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, JsonNode>? AdditionalProperties { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Storage version of v1api20180601.EncryptionConfiguration Definition of CMK for the factory.</summary>
    [JsonPropertyName("encryption")]
    public V1api20180601storageFactorySpecEncryption? Encryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("globalParameters")]
    public IDictionary<string, V1api20180601storageFactorySpecGlobalParameters>? GlobalParameters { get; set; }

    /// <summary>Storage version of v1api20180601.FactoryIdentity Identity properties of the factory resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20180601storageFactorySpecIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20180601storageFactorySpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>Storage version of v1api20180601.PurviewConfiguration Purview configuration.</summary>
    [JsonPropertyName("purviewConfiguration")]
    public V1api20180601storageFactorySpecPurviewConfiguration? PurviewConfiguration { get; set; }

    /// <summary>Storage version of v1api20180601.FactoryRepoConfiguration</summary>
    [JsonPropertyName("repoConfiguration")]
    public V1api20180601storageFactorySpecRepoConfiguration? RepoConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
public partial class V1api20180601storageFactoryStatusConditions
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

/// <summary>Storage version of v1api20180601.CMKIdentityDefinition_STATUS Managed Identity used for CMK.</summary>
public partial class V1api20180601storageFactoryStatusEncryptionIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>Storage version of v1api20180601.EncryptionConfiguration_STATUS Definition of CMK for the factory.</summary>
public partial class V1api20180601storageFactoryStatusEncryption
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20180601.CMKIdentityDefinition_STATUS Managed Identity used for CMK.</summary>
    [JsonPropertyName("identity")]
    public V1api20180601storageFactoryStatusEncryptionIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyVersion")]
    public string? KeyVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vaultBaseUrl")]
    public string? VaultBaseUrl { get; set; }
}

/// <summary>Storage version of v1api20180601.GlobalParameterSpecification_STATUS Definition of a single parameter for an entity.</summary>
public partial class V1api20180601storageFactoryStatusGlobalParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public IDictionary<string, JsonNode>? Value { get; set; }
}

/// <summary>Storage version of v1api20180601.FactoryIdentity_STATUS Identity properties of the factory resource.</summary>
public partial class V1api20180601storageFactoryStatusIdentity
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
    public IDictionary<string, JsonNode>? UserAssignedIdentities { get; set; }
}

/// <summary>Storage version of v1api20180601.PurviewConfiguration_STATUS Purview configuration.</summary>
public partial class V1api20180601storageFactoryStatusPurviewConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("purviewResourceId")]
    public string? PurviewResourceId { get; set; }
}

/// <summary>Storage version of v1api20180601.GitHubClientSecret_STATUS Client secret information for factory's bring your own app repository configuration.</summary>
public partial class V1api20180601storageFactoryStatusRepoConfigurationFactoryGitHubConfigurationClientSecret
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("byoaSecretAkvUrl")]
    public string? ByoaSecretAkvUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("byoaSecretName")]
    public string? ByoaSecretName { get; set; }
}

/// <summary>Storage version of v1api20180601.FactoryGitHubConfiguration_STATUS</summary>
public partial class V1api20180601storageFactoryStatusRepoConfigurationFactoryGitHubConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>Storage version of v1api20180601.GitHubClientSecret_STATUS Client secret information for factory's bring your own app repository configuration.</summary>
    [JsonPropertyName("clientSecret")]
    public V1api20180601storageFactoryStatusRepoConfigurationFactoryGitHubConfigurationClientSecret? ClientSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("collaborationBranch")]
    public string? CollaborationBranch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disablePublish")]
    public bool? DisablePublish { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastCommitId")]
    public string? LastCommitId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rootFolder")]
    public string? RootFolder { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20180601.FactoryVSTSConfiguration_STATUS</summary>
public partial class V1api20180601storageFactoryStatusRepoConfigurationFactoryVSTSConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("collaborationBranch")]
    public string? CollaborationBranch { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disablePublish")]
    public bool? DisablePublish { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastCommitId")]
    public string? LastCommitId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("projectName")]
    public string? ProjectName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rootFolder")]
    public string? RootFolder { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20180601.FactoryRepoConfiguration_STATUS</summary>
public partial class V1api20180601storageFactoryStatusRepoConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20180601.FactoryGitHubConfiguration_STATUS</summary>
    [JsonPropertyName("factoryGitHubConfiguration")]
    public V1api20180601storageFactoryStatusRepoConfigurationFactoryGitHubConfiguration? FactoryGitHubConfiguration { get; set; }

    /// <summary>Storage version of v1api20180601.FactoryVSTSConfiguration_STATUS</summary>
    [JsonPropertyName("factoryVSTSConfiguration")]
    public V1api20180601storageFactoryStatusRepoConfigurationFactoryVSTSConfiguration? FactoryVSTSConfiguration { get; set; }
}

/// <summary>Storage version of v1api20180601.Factory_STATUS Factory resource type.</summary>
public partial class V1api20180601storageFactoryStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalProperties")]
    public IDictionary<string, JsonNode>? AdditionalProperties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20180601storageFactoryStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }

    /// <summary>Storage version of v1api20180601.EncryptionConfiguration_STATUS Definition of CMK for the factory.</summary>
    [JsonPropertyName("encryption")]
    public V1api20180601storageFactoryStatusEncryption? Encryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("globalParameters")]
    public IDictionary<string, V1api20180601storageFactoryStatusGlobalParameters>? GlobalParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20180601.FactoryIdentity_STATUS Identity properties of the factory resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20180601storageFactoryStatusIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>Storage version of v1api20180601.PurviewConfiguration_STATUS Purview configuration.</summary>
    [JsonPropertyName("purviewConfiguration")]
    public V1api20180601storageFactoryStatusPurviewConfiguration? PurviewConfiguration { get; set; }

    /// <summary>Storage version of v1api20180601.FactoryRepoConfiguration_STATUS</summary>
    [JsonPropertyName("repoConfiguration")]
    public V1api20180601storageFactoryStatusRepoConfiguration? RepoConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Storage version of v1api20180601.Factory Generator information: - Generated from: /datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/datafactory.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}</summary>
public partial class V1api20180601storageFactory : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20180601storageFactorySpec>, IStatus<V1api20180601storageFactoryStatus>
{
    public const string KubeApiVersion = "v1api20180601storage";
    public const string KubeKind = "Factory";
    public const string KubeGroup = "datafactory.azure.com";
    public const string KubePluralName = "factories";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20180601.Factory_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20180601storageFactorySpec? Spec { get; set; }

    /// <summary>Storage version of v1api20180601.Factory_STATUS Factory resource type.</summary>
    [JsonPropertyName("status")]
    public V1api20180601storageFactoryStatus? Status { get; set; }
}