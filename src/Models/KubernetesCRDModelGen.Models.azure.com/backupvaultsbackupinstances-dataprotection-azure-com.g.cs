using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataprotection.azure.com;
/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a dataprotection.azure.com/BackupVault resource</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20231101.DefaultResourceProperties</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceInfoResourcePropertiesDefaultResourceProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20231101.BaseResourceProperties</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceInfoResourceProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.DefaultResourceProperties</summary>
    [JsonPropertyName("defaultResourceProperties")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceInfoResourcePropertiesDefaultResourceProperties? DefaultResourceProperties { get; set; }
}

/// <summary>ResourceReference: Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created by backup service via Fabric/Vault.</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceInfoResourceReference
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

/// <summary>Storage version of v1api20231101.Datasource Datasource to be backed up</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("datasourceType")]
    public string? DatasourceType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceLocation")]
    public string? ResourceLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceName")]
    public string? ResourceName { get; set; }

    /// <summary>Storage version of v1api20231101.BaseResourceProperties</summary>
    [JsonPropertyName("resourceProperties")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceInfoResourceProperties? ResourceProperties { get; set; }

    /// <summary>ResourceReference: Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created by backup service via Fabric/Vault.</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceInfoResourceReference ResourceReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceUri")]
    public string? ResourceUri { get; set; }
}

/// <summary>Storage version of v1api20231101.DefaultResourceProperties</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceSetInfoResourcePropertiesDefaultResourceProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20231101.BaseResourceProperties</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceSetInfoResourceProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.DefaultResourceProperties</summary>
    [JsonPropertyName("defaultResourceProperties")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceSetInfoResourcePropertiesDefaultResourceProperties? DefaultResourceProperties { get; set; }
}

/// <summary>ResourceReference: Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created by backup service via Fabric/Vault.</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceSetInfoResourceReference
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

/// <summary>Storage version of v1api20231101.DatasourceSet DatasourceSet details of datasource to be backed up</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceSetInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("datasourceType")]
    public string? DatasourceType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceLocation")]
    public string? ResourceLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceName")]
    public string? ResourceName { get; set; }

    /// <summary>Storage version of v1api20231101.BaseResourceProperties</summary>
    [JsonPropertyName("resourceProperties")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceSetInfoResourceProperties? ResourceProperties { get; set; }

    /// <summary>ResourceReference: Full ARM ID of the resource. For azure resources, this is ARM ID. For non azure resources, this will be the ID created by backup service via Fabric/Vault.</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceSetInfoResourceReference ResourceReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceUri")]
    public string? ResourceUri { get; set; }
}

/// <summary>Storage version of v1api20231101.SecretStoreResource Class representing a secret store resource.</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDatasourceAuthCredentialsSecretStoreBasedAuthCredentialsSecretStoreResource
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretStoreType")]
    public string? SecretStoreType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v1api20231101.SecretStoreBasedAuthCredentials</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDatasourceAuthCredentialsSecretStoreBasedAuthCredentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>Storage version of v1api20231101.SecretStoreResource Class representing a secret store resource.</summary>
    [JsonPropertyName("secretStoreResource")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDatasourceAuthCredentialsSecretStoreBasedAuthCredentialsSecretStoreResource? SecretStoreResource { get; set; }
}

/// <summary>Storage version of v1api20231101.AuthCredentials</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDatasourceAuthCredentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.SecretStoreBasedAuthCredentials</summary>
    [JsonPropertyName("secretStoreBasedAuthCredentials")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDatasourceAuthCredentialsSecretStoreBasedAuthCredentials? SecretStoreBasedAuthCredentials { get; set; }
}

/// <summary>Storage version of v1api20231101.IdentityDetails</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesIdentityDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useSystemAssignedIdentity")]
    public bool? UseSystemAssignedIdentity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentityArmUrl")]
    public string? UserAssignedIdentityArmUrl { get; set; }
}

/// <summary>Storage version of v1api20231101.BlobBackupDatasourceParameters</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListBlobBackupDatasourceParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("containersList")]
    public IList<string>? ContainersList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20231101.NamespacedNameResource Class to refer resources which contains namespace and name</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListKubernetesClusterBackupDatasourceParametersBackupHookReferences
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Storage version of v1api20231101.KubernetesClusterBackupDatasourceParameters</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListKubernetesClusterBackupDatasourceParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backupHookReferences")]
    public IList<V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListKubernetesClusterBackupDatasourceParametersBackupHookReferences>? BackupHookReferences { get; set; }

    /// <summary></summary>
    [JsonPropertyName("excludedNamespaces")]
    public IList<string>? ExcludedNamespaces { get; set; }

    /// <summary></summary>
    [JsonPropertyName("excludedResourceTypes")]
    public IList<string>? ExcludedResourceTypes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includeClusterScopeResources")]
    public bool? IncludeClusterScopeResources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includedNamespaces")]
    public IList<string>? IncludedNamespaces { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includedResourceTypes")]
    public IList<string>? IncludedResourceTypes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelectors")]
    public IList<string>? LabelSelectors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("snapshotVolumes")]
    public bool? SnapshotVolumes { get; set; }
}

/// <summary>Storage version of v1api20231101.BackupDatasourceParameters</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersList
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.BlobBackupDatasourceParameters</summary>
    [JsonPropertyName("blobBackupDatasourceParameters")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListBlobBackupDatasourceParameters? BlobBackupDatasourceParameters { get; set; }

    /// <summary>Storage version of v1api20231101.KubernetesClusterBackupDatasourceParameters</summary>
    [JsonPropertyName("kubernetesClusterBackupDatasourceParameters")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListKubernetesClusterBackupDatasourceParameters? KubernetesClusterBackupDatasourceParameters { get; set; }
}

/// <summary>ResourceGroupReference: Gets or sets the Snapshot Resource Group Uri.</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersDataStoreParametersListAzureOperationalStoreParametersResourceGroupReference
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

/// <summary>Storage version of v1api20231101.AzureOperationalStoreParameters</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersDataStoreParametersListAzureOperationalStoreParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>ResourceGroupReference: Gets or sets the Snapshot Resource Group Uri.</summary>
    [JsonPropertyName("resourceGroupReference")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersDataStoreParametersListAzureOperationalStoreParametersResourceGroupReference? ResourceGroupReference { get; set; }
}

/// <summary>Storage version of v1api20231101.DataStoreParameters</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersDataStoreParametersList
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.AzureOperationalStoreParameters</summary>
    [JsonPropertyName("azureOperationalStoreParameters")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersDataStoreParametersListAzureOperationalStoreParameters? AzureOperationalStoreParameters { get; set; }
}

/// <summary>Storage version of v1api20231101.PolicyParameters Parameters in Policy</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backupDatasourceParametersList")]
    public IList<V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersList>? BackupDatasourceParametersList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataStoreParametersList")]
    public IList<V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParametersDataStoreParametersList>? DataStoreParametersList { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyReference
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

/// <summary>Storage version of v1api20231101.PolicyInfo Policy Info in backupInstance</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.PolicyParameters Parameters in Policy</summary>
    [JsonPropertyName("policyParameters")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyParameters? PolicyParameters { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("policyReference")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfoPolicyReference PolicyReference { get; set; }
}

/// <summary>Storage version of v1api20231101.BackupInstance Backup Instance</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceSpecProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.Datasource Datasource to be backed up</summary>
    [JsonPropertyName("dataSourceInfo")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceInfo? DataSourceInfo { get; set; }

    /// <summary>Storage version of v1api20231101.DatasourceSet DatasourceSet details of datasource to be backed up</summary>
    [JsonPropertyName("dataSourceSetInfo")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDataSourceSetInfo? DataSourceSetInfo { get; set; }

    /// <summary>Storage version of v1api20231101.AuthCredentials</summary>
    [JsonPropertyName("datasourceAuthCredentials")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesDatasourceAuthCredentials? DatasourceAuthCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>Storage version of v1api20231101.IdentityDetails</summary>
    [JsonPropertyName("identityDetails")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesIdentityDetails? IdentityDetails { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>Storage version of v1api20231101.PolicyInfo Policy Info in backupInstance</summary>
    [JsonPropertyName("policyInfo")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecPropertiesPolicyInfo? PolicyInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("validationType")]
    public string? ValidationType { get; set; }
}

/// <summary>Storage version of v1api20231101.BackupVaults_BackupInstance_Spec</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a dataprotection.azure.com/BackupVault resource</summary>
    [JsonPropertyName("owner")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecOwner Owner { get; set; }

    /// <summary>Storage version of v1api20231101.BackupInstance Backup Instance</summary>
    [JsonPropertyName("properties")]
    public V1api20231101storageBackupVaultsBackupInstanceSpecProperties? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusConditions
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

/// <summary>Storage version of v1api20231101.DefaultResourceProperties_STATUS</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDataSourceInfoResourcePropertiesDefaultResourceProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20231101.BaseResourceProperties_STATUS</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDataSourceInfoResourceProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.DefaultResourceProperties_STATUS</summary>
    [JsonPropertyName("defaultResourceProperties")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDataSourceInfoResourcePropertiesDefaultResourceProperties? DefaultResourceProperties { get; set; }
}

/// <summary>Storage version of v1api20231101.Datasource_STATUS Datasource to be backed up</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDataSourceInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("datasourceType")]
    public string? DatasourceType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceLocation")]
    public string? ResourceLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceName")]
    public string? ResourceName { get; set; }

    /// <summary>Storage version of v1api20231101.BaseResourceProperties_STATUS</summary>
    [JsonPropertyName("resourceProperties")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDataSourceInfoResourceProperties? ResourceProperties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceUri")]
    public string? ResourceUri { get; set; }
}

/// <summary>Storage version of v1api20231101.DefaultResourceProperties_STATUS</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDataSourceSetInfoResourcePropertiesDefaultResourceProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20231101.BaseResourceProperties_STATUS</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDataSourceSetInfoResourceProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.DefaultResourceProperties_STATUS</summary>
    [JsonPropertyName("defaultResourceProperties")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDataSourceSetInfoResourcePropertiesDefaultResourceProperties? DefaultResourceProperties { get; set; }
}

/// <summary>Storage version of v1api20231101.DatasourceSet_STATUS DatasourceSet details of datasource to be backed up</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDataSourceSetInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("datasourceType")]
    public string? DatasourceType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceLocation")]
    public string? ResourceLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceName")]
    public string? ResourceName { get; set; }

    /// <summary>Storage version of v1api20231101.BaseResourceProperties_STATUS</summary>
    [JsonPropertyName("resourceProperties")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDataSourceSetInfoResourceProperties? ResourceProperties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceUri")]
    public string? ResourceUri { get; set; }
}

/// <summary>Storage version of v1api20231101.SecretStoreResource_STATUS Class representing a secret store resource.</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDatasourceAuthCredentialsSecretStoreBasedAuthCredentialsSecretStoreResource
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretStoreType")]
    public string? SecretStoreType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary></summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v1api20231101.SecretStoreBasedAuthCredentials_STATUS</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDatasourceAuthCredentialsSecretStoreBasedAuthCredentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>Storage version of v1api20231101.SecretStoreResource_STATUS Class representing a secret store resource.</summary>
    [JsonPropertyName("secretStoreResource")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDatasourceAuthCredentialsSecretStoreBasedAuthCredentialsSecretStoreResource? SecretStoreResource { get; set; }
}

/// <summary>Storage version of v1api20231101.AuthCredentials_STATUS</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDatasourceAuthCredentials
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.SecretStoreBasedAuthCredentials_STATUS</summary>
    [JsonPropertyName("secretStoreBasedAuthCredentials")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDatasourceAuthCredentialsSecretStoreBasedAuthCredentials? SecretStoreBasedAuthCredentials { get; set; }
}

/// <summary>Storage version of v1api20231101.IdentityDetails_STATUS</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesIdentityDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useSystemAssignedIdentity")]
    public bool? UseSystemAssignedIdentity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentityArmUrl")]
    public string? UserAssignedIdentityArmUrl { get; set; }
}

/// <summary>Storage version of v1api20231101.BlobBackupDatasourceParameters_STATUS</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListBlobBackupDatasourceParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("containersList")]
    public IList<string>? ContainersList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }
}

/// <summary>Storage version of v1api20231101.NamespacedNameResource_STATUS Class to refer resources which contains namespace and name</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListKubernetesClusterBackupDatasourceParametersBackupHookReferences
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Storage version of v1api20231101.KubernetesClusterBackupDatasourceParameters_STATUS</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListKubernetesClusterBackupDatasourceParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backupHookReferences")]
    public IList<V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListKubernetesClusterBackupDatasourceParametersBackupHookReferences>? BackupHookReferences { get; set; }

    /// <summary></summary>
    [JsonPropertyName("excludedNamespaces")]
    public IList<string>? ExcludedNamespaces { get; set; }

    /// <summary></summary>
    [JsonPropertyName("excludedResourceTypes")]
    public IList<string>? ExcludedResourceTypes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includeClusterScopeResources")]
    public bool? IncludeClusterScopeResources { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includedNamespaces")]
    public IList<string>? IncludedNamespaces { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includedResourceTypes")]
    public IList<string>? IncludedResourceTypes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("labelSelectors")]
    public IList<string>? LabelSelectors { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("snapshotVolumes")]
    public bool? SnapshotVolumes { get; set; }
}

/// <summary>Storage version of v1api20231101.BackupDatasourceParameters_STATUS</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersList
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.BlobBackupDatasourceParameters_STATUS</summary>
    [JsonPropertyName("blobBackupDatasourceParameters")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListBlobBackupDatasourceParameters? BlobBackupDatasourceParameters { get; set; }

    /// <summary>Storage version of v1api20231101.KubernetesClusterBackupDatasourceParameters_STATUS</summary>
    [JsonPropertyName("kubernetesClusterBackupDatasourceParameters")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersListKubernetesClusterBackupDatasourceParameters? KubernetesClusterBackupDatasourceParameters { get; set; }
}

/// <summary>Storage version of v1api20231101.AzureOperationalStoreParameters_STATUS</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersDataStoreParametersListAzureOperationalStoreParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceGroupId")]
    public string? ResourceGroupId { get; set; }
}

/// <summary>Storage version of v1api20231101.DataStoreParameters_STATUS</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersDataStoreParametersList
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.AzureOperationalStoreParameters_STATUS</summary>
    [JsonPropertyName("azureOperationalStoreParameters")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersDataStoreParametersListAzureOperationalStoreParameters? AzureOperationalStoreParameters { get; set; }
}

/// <summary>Storage version of v1api20231101.PolicyParameters_STATUS Parameters in Policy</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParameters
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backupDatasourceParametersList")]
    public IList<V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersBackupDatasourceParametersList>? BackupDatasourceParametersList { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataStoreParametersList")]
    public IList<V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParametersDataStoreParametersList>? DataStoreParametersList { get; set; }
}

/// <summary>Storage version of v1api20231101.PolicyInfo_STATUS Policy Info in backupInstance</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfo
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("policyId")]
    public string? PolicyId { get; set; }

    /// <summary>Storage version of v1api20231101.PolicyParameters_STATUS Parameters in Policy</summary>
    [JsonPropertyName("policyParameters")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfoPolicyParameters? PolicyParameters { get; set; }

    /// <summary></summary>
    [JsonPropertyName("policyVersion")]
    public string? PolicyVersion { get; set; }
}

/// <summary>Storage version of v1api20231101.InnerError_STATUS_Unrolled</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetailsDetailsInnerErrorEmbeddedInnerError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IDictionary<string, string>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

/// <summary>Storage version of v1api20231101.InnerError_STATUS Inner Error</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetailsDetailsInnerError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IDictionary<string, string>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Storage version of v1api20231101.InnerError_STATUS_Unrolled</summary>
    [JsonPropertyName("embeddedInnerError")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetailsDetailsInnerErrorEmbeddedInnerError? EmbeddedInnerError { get; set; }
}

/// <summary>Storage version of v1api20231101.UserFacingError_STATUS_Unrolled</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetailsDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Storage version of v1api20231101.InnerError_STATUS Inner Error</summary>
    [JsonPropertyName("innerError")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetailsDetailsInnerError? InnerError { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isRetryable")]
    public bool? IsRetryable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isUserError")]
    public bool? IsUserError { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recommendedAction")]
    public IList<string>? RecommendedAction { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20231101.InnerError_STATUS_Unrolled</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetailsInnerErrorEmbeddedInnerError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IDictionary<string, string>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

/// <summary>Storage version of v1api20231101.InnerError_STATUS Inner Error</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetailsInnerError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IDictionary<string, string>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Storage version of v1api20231101.InnerError_STATUS_Unrolled</summary>
    [JsonPropertyName("embeddedInnerError")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetailsInnerErrorEmbeddedInnerError? EmbeddedInnerError { get; set; }
}

/// <summary>Storage version of v1api20231101.UserFacingError_STATUS Error object used by layers that have access to localized content, and propagate that to user</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetailsDetails>? Details { get; set; }

    /// <summary>Storage version of v1api20231101.InnerError_STATUS Inner Error</summary>
    [JsonPropertyName("innerError")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetailsInnerError? InnerError { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isRetryable")]
    public bool? IsRetryable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isUserError")]
    public bool? IsUserError { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recommendedAction")]
    public IList<string>? RecommendedAction { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20231101.InnerError_STATUS_Unrolled</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetailsDetailsInnerErrorEmbeddedInnerError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IDictionary<string, string>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

/// <summary>Storage version of v1api20231101.InnerError_STATUS Inner Error</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetailsDetailsInnerError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IDictionary<string, string>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Storage version of v1api20231101.InnerError_STATUS_Unrolled</summary>
    [JsonPropertyName("embeddedInnerError")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetailsDetailsInnerErrorEmbeddedInnerError? EmbeddedInnerError { get; set; }
}

/// <summary>Storage version of v1api20231101.UserFacingError_STATUS_Unrolled</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetailsDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Storage version of v1api20231101.InnerError_STATUS Inner Error</summary>
    [JsonPropertyName("innerError")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetailsDetailsInnerError? InnerError { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isRetryable")]
    public bool? IsRetryable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isUserError")]
    public bool? IsUserError { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recommendedAction")]
    public IList<string>? RecommendedAction { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20231101.InnerError_STATUS_Unrolled</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetailsInnerErrorEmbeddedInnerError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IDictionary<string, string>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

/// <summary>Storage version of v1api20231101.InnerError_STATUS Inner Error</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetailsInnerError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalInfo")]
    public IDictionary<string, string>? AdditionalInfo { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Storage version of v1api20231101.InnerError_STATUS_Unrolled</summary>
    [JsonPropertyName("embeddedInnerError")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetailsInnerErrorEmbeddedInnerError? EmbeddedInnerError { get; set; }
}

/// <summary>Storage version of v1api20231101.UserFacingError_STATUS Error object used by layers that have access to localized content, and propagate that to user</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetailsDetails>? Details { get; set; }

    /// <summary>Storage version of v1api20231101.InnerError_STATUS Inner Error</summary>
    [JsonPropertyName("innerError")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetailsInnerError? InnerError { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isRetryable")]
    public bool? IsRetryable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isUserError")]
    public bool? IsUserError { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, string>? Properties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("recommendedAction")]
    public IList<string>? RecommendedAction { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Storage version of v1api20231101.ProtectionStatusDetails_STATUS Protection status details</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20231101.UserFacingError_STATUS Error object used by layers that have access to localized content, and propagate that to user</summary>
    [JsonPropertyName("errorDetails")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionStatusErrorDetails? ErrorDetails { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Storage version of v1api20231101.BackupInstance_STATUS Backup Instance</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("currentProtectionState")]
    public string? CurrentProtectionState { get; set; }

    /// <summary>Storage version of v1api20231101.Datasource_STATUS Datasource to be backed up</summary>
    [JsonPropertyName("dataSourceInfo")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDataSourceInfo? DataSourceInfo { get; set; }

    /// <summary>Storage version of v1api20231101.DatasourceSet_STATUS DatasourceSet details of datasource to be backed up</summary>
    [JsonPropertyName("dataSourceSetInfo")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDataSourceSetInfo? DataSourceSetInfo { get; set; }

    /// <summary>Storage version of v1api20231101.AuthCredentials_STATUS</summary>
    [JsonPropertyName("datasourceAuthCredentials")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesDatasourceAuthCredentials? DatasourceAuthCredentials { get; set; }

    /// <summary></summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>Storage version of v1api20231101.IdentityDetails_STATUS</summary>
    [JsonPropertyName("identityDetails")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesIdentityDetails? IdentityDetails { get; set; }

    /// <summary></summary>
    [JsonPropertyName("objectType")]
    public string? ObjectType { get; set; }

    /// <summary>Storage version of v1api20231101.PolicyInfo_STATUS Policy Info in backupInstance</summary>
    [JsonPropertyName("policyInfo")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesPolicyInfo? PolicyInfo { get; set; }

    /// <summary>Storage version of v1api20231101.UserFacingError_STATUS Error object used by layers that have access to localized content, and propagate that to user</summary>
    [JsonPropertyName("protectionErrorDetails")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionErrorDetails? ProtectionErrorDetails { get; set; }

    /// <summary>Storage version of v1api20231101.ProtectionStatusDetails_STATUS Protection status details</summary>
    [JsonPropertyName("protectionStatus")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusPropertiesProtectionStatus? ProtectionStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("validationType")]
    public string? ValidationType { get; set; }
}

/// <summary>Storage version of v1api20231101.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatusSystemData
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

/// <summary>Storage version of v1api20231101.BackupVaults_BackupInstance_STATUS</summary>
public partial class V1api20231101storageBackupVaultsBackupInstanceStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20231101storageBackupVaultsBackupInstanceStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20231101.BackupInstance_STATUS Backup Instance</summary>
    [JsonPropertyName("properties")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusProperties? Properties { get; set; }

    /// <summary>Storage version of v1api20231101.SystemData_STATUS Metadata pertaining to creation and last modification of the resource.</summary>
    [JsonPropertyName("systemData")]
    public V1api20231101storageBackupVaultsBackupInstanceStatusSystemData? SystemData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Storage version of v1api20231101.BackupVaultsBackupInstance Generator information: - Generated from: /dataprotection/resource-manager/Microsoft.DataProtection/stable/2023-11-01/dataprotection.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataProtection/backupVaults/{vaultName}/backupInstances/{backupInstanceName}</summary>
public partial class V1api20231101storageBackupVaultsBackupInstance : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20231101storageBackupVaultsBackupInstanceSpec>, IStatus<V1api20231101storageBackupVaultsBackupInstanceStatus>
{
    public const string KubeApiVersion = "v1api20231101storage";
    public const string KubeKind = "BackupVaultsBackupInstance";
    public const string KubeGroup = "dataprotection.azure.com";
    public const string KubePluralName = "backupvaultsbackupinstances";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20231101.BackupVaults_BackupInstance_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20231101storageBackupVaultsBackupInstanceSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20231101.BackupVaults_BackupInstance_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20231101storageBackupVaultsBackupInstanceStatus? Status { get; set; }
}