using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.synapse.azure.com;
/// <summary>Storage version of v1api20210601.Workspace Generator information: - Generated from: /synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/workspace.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210601storageWorkspaceList : IKubernetesObject<V1ListMeta>, IItems<V1api20210601storageWorkspace>
{
    public const string KubeApiVersion = "v1api20210601storage";
    public const string KubeKind = "WorkspaceList";
    public const string KubeGroup = "synapse.azure.com";
    public const string KubePluralName = "workspaces";
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
    public IList<V1api20210601storageWorkspace> Items { get; set; }
}

/// <summary>Storage version of v1api20210601.CspWorkspaceAdminProperties Initial workspace AAD admin properties for a CSP subscription</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceSpecCspWorkspaceAdminProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initialWorkspaceAdminObjectId")]
    public string? InitialWorkspaceAdminObjectId { get; set; }
}

/// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceSpecDefaultDataLakeStorageAccountUrlFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap being referenced. The configmap must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>ResourceReference: ARM resource Id of this storage account</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceSpecDefaultDataLakeStorageResourceReference
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

/// <summary>Storage version of v1api20210601.DataLakeStorageAccountDetails Details of the data lake storage account associated with the workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceSpecDefaultDataLakeStorage
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("accountUrl")]
    public string? AccountUrl { get; set; }

    /// <summary>ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("accountUrlFromConfig")]
    public V1api20210601storageWorkspaceSpecDefaultDataLakeStorageAccountUrlFromConfig? AccountUrlFromConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createManagedPrivateEndpoint")]
    public bool? CreateManagedPrivateEndpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filesystem")]
    public string? Filesystem { get; set; }

    /// <summary>ResourceReference: ARM resource Id of this storage account</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20210601storageWorkspaceSpecDefaultDataLakeStorageResourceReference? ResourceReference { get; set; }
}

/// <summary>UserAssignedIdentityReference: User assigned identity resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceSpecEncryptionCmkKekIdentityUserAssignedIdentityReference
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

/// <summary>Storage version of v1api20210601.KekIdentityProperties Key encryption key properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceSpecEncryptionCmkKekIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useSystemAssignedIdentity")]
    public JsonNode? UseSystemAssignedIdentity { get; set; }

    /// <summary>UserAssignedIdentityReference: User assigned identity resource Id</summary>
    [JsonPropertyName("userAssignedIdentityReference")]
    public V1api20210601storageWorkspaceSpecEncryptionCmkKekIdentityUserAssignedIdentityReference? UserAssignedIdentityReference { get; set; }
}

/// <summary>Storage version of v1api20210601.WorkspaceKeyDetails Details of the customer managed key associated with the workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceSpecEncryptionCmkKey
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyVaultUrl")]
    public string? KeyVaultUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20210601.CustomerManagedKeyDetails Details of the customer managed key associated with the workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceSpecEncryptionCmk
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210601.KekIdentityProperties Key encryption key properties</summary>
    [JsonPropertyName("kekIdentity")]
    public V1api20210601storageWorkspaceSpecEncryptionCmkKekIdentity? KekIdentity { get; set; }

    /// <summary>Storage version of v1api20210601.WorkspaceKeyDetails Details of the customer managed key associated with the workspace</summary>
    [JsonPropertyName("key")]
    public V1api20210601storageWorkspaceSpecEncryptionCmkKey? Key { get; set; }
}

/// <summary>Storage version of v1api20210601.EncryptionDetails Details of the encryption associated with the workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceSpecEncryption
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210601.CustomerManagedKeyDetails Details of the customer managed key associated with the workspace</summary>
    [JsonPropertyName("cmk")]
    public V1api20210601storageWorkspaceSpecEncryptionCmk? Cmk { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceSpecIdentityUserAssignedIdentitiesReference
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

/// <summary>Storage version of v1api20210601.UserAssignedIdentityDetails Information about the user assigned identity for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceSpecIdentityUserAssignedIdentities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20210601storageWorkspaceSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20210601.ManagedIdentity The workspace managed identity</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceSpecIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20210601storageWorkspaceSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Storage version of v1api20210601.ManagedVirtualNetworkSettings Managed Virtual Network Settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceSpecManagedVirtualNetworkSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedAadTenantIdsForLinking")]
    public IList<string>? AllowedAadTenantIdsForLinking { get; set; }

    /// <summary></summary>
    [JsonPropertyName("linkedAccessCheckOnTargetResource")]
    public bool? LinkedAccessCheckOnTargetResource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preventDataExfiltration")]
    public bool? PreventDataExfiltration { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting map[string]string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap or secret to write to. The configmap or secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceSpecOperatorSpecSecretExpressions
{
    /// <summary>Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting map[string]string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap or secret to write to. The configmap or secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>Storage version of v1api20210601.WorkspaceOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20210601storageWorkspaceSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20210601storageWorkspaceSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PurviewResourceReference: Purview Resource ID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceSpecPurviewConfigurationPurviewResourceReference
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

/// <summary>Storage version of v1api20210601.PurviewConfiguration Purview Configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceSpecPurviewConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>PurviewResourceReference: Purview Resource ID</summary>
    [JsonPropertyName("purviewResourceReference")]
    public V1api20210601storageWorkspaceSpecPurviewConfigurationPurviewResourceReference? PurviewResourceReference { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceSpecSqlAdministratorLoginPassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20210601.VirtualNetworkProfile Virtual Network Profile</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceSpecVirtualNetworkProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeSubnetId")]
    public string? ComputeSubnetId { get; set; }
}

/// <summary>Storage version of v1api20210601.WorkspaceRepositoryConfiguration Git integration settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceSpecWorkspaceRepositoryConfiguration
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
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

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

/// <summary>Storage version of v1api20210601.Workspace_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureADOnlyAuthentication")]
    public bool? AzureADOnlyAuthentication { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Storage version of v1api20210601.CspWorkspaceAdminProperties Initial workspace AAD admin properties for a CSP subscription</summary>
    [JsonPropertyName("cspWorkspaceAdminProperties")]
    public V1api20210601storageWorkspaceSpecCspWorkspaceAdminProperties? CspWorkspaceAdminProperties { get; set; }

    /// <summary>Storage version of v1api20210601.DataLakeStorageAccountDetails Details of the data lake storage account associated with the workspace</summary>
    [JsonPropertyName("defaultDataLakeStorage")]
    public V1api20210601storageWorkspaceSpecDefaultDataLakeStorage? DefaultDataLakeStorage { get; set; }

    /// <summary>Storage version of v1api20210601.EncryptionDetails Details of the encryption associated with the workspace</summary>
    [JsonPropertyName("encryption")]
    public V1api20210601storageWorkspaceSpecEncryption? Encryption { get; set; }

    /// <summary>Storage version of v1api20210601.ManagedIdentity The workspace managed identity</summary>
    [JsonPropertyName("identity")]
    public V1api20210601storageWorkspaceSpecIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedResourceGroupName")]
    public string? ManagedResourceGroupName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedVirtualNetwork")]
    public string? ManagedVirtualNetwork { get; set; }

    /// <summary>Storage version of v1api20210601.ManagedVirtualNetworkSettings Managed Virtual Network Settings</summary>
    [JsonPropertyName("managedVirtualNetworkSettings")]
    public V1api20210601storageWorkspaceSpecManagedVirtualNetworkSettings? ManagedVirtualNetworkSettings { get; set; }

    /// <summary>Storage version of v1api20210601.WorkspaceOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20210601storageWorkspaceSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20210601storageWorkspaceSpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>Storage version of v1api20210601.PurviewConfiguration Purview Configuration</summary>
    [JsonPropertyName("purviewConfiguration")]
    public V1api20210601storageWorkspaceSpecPurviewConfiguration? PurviewConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sqlAdministratorLogin")]
    public string? SqlAdministratorLogin { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("sqlAdministratorLoginPassword")]
    public V1api20210601storageWorkspaceSpecSqlAdministratorLoginPassword? SqlAdministratorLoginPassword { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("trustedServiceBypassEnabled")]
    public bool? TrustedServiceBypassEnabled { get; set; }

    /// <summary>Storage version of v1api20210601.VirtualNetworkProfile Virtual Network Profile</summary>
    [JsonPropertyName("virtualNetworkProfile")]
    public V1api20210601storageWorkspaceSpecVirtualNetworkProfile? VirtualNetworkProfile { get; set; }

    /// <summary>Storage version of v1api20210601.WorkspaceRepositoryConfiguration Git integration settings</summary>
    [JsonPropertyName("workspaceRepositoryConfiguration")]
    public V1api20210601storageWorkspaceSpecWorkspaceRepositoryConfiguration? WorkspaceRepositoryConfiguration { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceStatusConditions
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

/// <summary>Storage version of v1api20210601.CspWorkspaceAdminProperties_STATUS Initial workspace AAD admin properties for a CSP subscription</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceStatusCspWorkspaceAdminProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("initialWorkspaceAdminObjectId")]
    public string? InitialWorkspaceAdminObjectId { get; set; }
}

/// <summary>Storage version of v1api20210601.DataLakeStorageAccountDetails_STATUS Details of the data lake storage account associated with the workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceStatusDefaultDataLakeStorage
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("accountUrl")]
    public string? AccountUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createManagedPrivateEndpoint")]
    public bool? CreateManagedPrivateEndpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("filesystem")]
    public string? Filesystem { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }
}

/// <summary>Storage version of v1api20210601.KekIdentityProperties_STATUS Key encryption key properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceStatusEncryptionCmkKekIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useSystemAssignedIdentity")]
    public JsonNode? UseSystemAssignedIdentity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>Storage version of v1api20210601.WorkspaceKeyDetails_STATUS Details of the customer managed key associated with the workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceStatusEncryptionCmkKey
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyVaultUrl")]
    public string? KeyVaultUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20210601.CustomerManagedKeyDetails_STATUS Details of the customer managed key associated with the workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceStatusEncryptionCmk
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210601.KekIdentityProperties_STATUS Key encryption key properties</summary>
    [JsonPropertyName("kekIdentity")]
    public V1api20210601storageWorkspaceStatusEncryptionCmkKekIdentity? KekIdentity { get; set; }

    /// <summary>Storage version of v1api20210601.WorkspaceKeyDetails_STATUS Details of the customer managed key associated with the workspace</summary>
    [JsonPropertyName("key")]
    public V1api20210601storageWorkspaceStatusEncryptionCmkKey? Key { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Storage version of v1api20210601.EncryptionDetails_STATUS Details of the encryption associated with the workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceStatusEncryption
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20210601.CustomerManagedKeyDetails_STATUS Details of the customer managed key associated with the workspace</summary>
    [JsonPropertyName("cmk")]
    public V1api20210601storageWorkspaceStatusEncryptionCmk? Cmk { get; set; }

    /// <summary></summary>
    [JsonPropertyName("doubleEncryptionEnabled")]
    public bool? DoubleEncryptionEnabled { get; set; }
}

/// <summary>Storage version of v1api20210601.UserAssignedManagedIdentity_STATUS User Assigned Managed Identity</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceStatusIdentityUserAssignedIdentities
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

/// <summary>Storage version of v1api20210601.ManagedIdentity_STATUS The workspace managed identity</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceStatusIdentity
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
    public IDictionary<string, V1api20210601storageWorkspaceStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Storage version of v1api20210601.ManagedVirtualNetworkSettings_STATUS Managed Virtual Network Settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceStatusManagedVirtualNetworkSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowedAadTenantIdsForLinking")]
    public IList<string>? AllowedAadTenantIdsForLinking { get; set; }

    /// <summary></summary>
    [JsonPropertyName("linkedAccessCheckOnTargetResource")]
    public bool? LinkedAccessCheckOnTargetResource { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preventDataExfiltration")]
    public bool? PreventDataExfiltration { get; set; }
}

/// <summary>Storage version of v1api20210601.PrivateEndpointConnection_STATUS A private endpoint connection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceStatusPrivateEndpointConnections
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20210601.PurviewConfiguration_STATUS Purview Configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceStatusPurviewConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("purviewResourceId")]
    public string? PurviewResourceId { get; set; }
}

/// <summary>Storage version of v1api20210601.VirtualNetworkProfile_STATUS Virtual Network Profile</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceStatusVirtualNetworkProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computeSubnetId")]
    public string? ComputeSubnetId { get; set; }
}

/// <summary>Storage version of v1api20210601.WorkspaceRepositoryConfiguration_STATUS Git integration settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceStatusWorkspaceRepositoryConfiguration
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
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

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

/// <summary>Storage version of v1api20210601.Workspace_STATUS A workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspaceStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("adlaResourceId")]
    public string? AdlaResourceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("azureADOnlyAuthentication")]
    public bool? AzureADOnlyAuthentication { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20210601storageWorkspaceStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("connectivityEndpoints")]
    public IDictionary<string, string>? ConnectivityEndpoints { get; set; }

    /// <summary>Storage version of v1api20210601.CspWorkspaceAdminProperties_STATUS Initial workspace AAD admin properties for a CSP subscription</summary>
    [JsonPropertyName("cspWorkspaceAdminProperties")]
    public V1api20210601storageWorkspaceStatusCspWorkspaceAdminProperties? CspWorkspaceAdminProperties { get; set; }

    /// <summary>Storage version of v1api20210601.DataLakeStorageAccountDetails_STATUS Details of the data lake storage account associated with the workspace</summary>
    [JsonPropertyName("defaultDataLakeStorage")]
    public V1api20210601storageWorkspaceStatusDefaultDataLakeStorage? DefaultDataLakeStorage { get; set; }

    /// <summary>Storage version of v1api20210601.EncryptionDetails_STATUS Details of the encryption associated with the workspace</summary>
    [JsonPropertyName("encryption")]
    public V1api20210601storageWorkspaceStatusEncryption? Encryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("extraProperties")]
    public IDictionary<string, JsonNode>? ExtraProperties { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20210601.ManagedIdentity_STATUS The workspace managed identity</summary>
    [JsonPropertyName("identity")]
    public V1api20210601storageWorkspaceStatusIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedResourceGroupName")]
    public string? ManagedResourceGroupName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("managedVirtualNetwork")]
    public string? ManagedVirtualNetwork { get; set; }

    /// <summary>Storage version of v1api20210601.ManagedVirtualNetworkSettings_STATUS Managed Virtual Network Settings</summary>
    [JsonPropertyName("managedVirtualNetworkSettings")]
    public V1api20210601storageWorkspaceStatusManagedVirtualNetworkSettings? ManagedVirtualNetworkSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20210601storageWorkspaceStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>Storage version of v1api20210601.PurviewConfiguration_STATUS Purview Configuration</summary>
    [JsonPropertyName("purviewConfiguration")]
    public V1api20210601storageWorkspaceStatusPurviewConfiguration? PurviewConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("settings")]
    public IDictionary<string, JsonNode>? Settings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sqlAdministratorLogin")]
    public string? SqlAdministratorLogin { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("trustedServiceBypassEnabled")]
    public bool? TrustedServiceBypassEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Storage version of v1api20210601.VirtualNetworkProfile_STATUS Virtual Network Profile</summary>
    [JsonPropertyName("virtualNetworkProfile")]
    public V1api20210601storageWorkspaceStatusVirtualNetworkProfile? VirtualNetworkProfile { get; set; }

    /// <summary>Storage version of v1api20210601.WorkspaceRepositoryConfiguration_STATUS Git integration settings</summary>
    [JsonPropertyName("workspaceRepositoryConfiguration")]
    public V1api20210601storageWorkspaceStatusWorkspaceRepositoryConfiguration? WorkspaceRepositoryConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workspaceUID")]
    public string? WorkspaceUID { get; set; }
}

/// <summary>Storage version of v1api20210601.Workspace Generator information: - Generated from: /synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/workspace.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210601storageWorkspace : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20210601storageWorkspaceSpec>, IStatus<V1api20210601storageWorkspaceStatus>
{
    public const string KubeApiVersion = "v1api20210601storage";
    public const string KubeKind = "Workspace";
    public const string KubeGroup = "synapse.azure.com";
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

    /// <summary>Storage version of v1api20210601.Workspace_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20210601storageWorkspaceSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20210601.Workspace_STATUS A workspace</summary>
    [JsonPropertyName("status")]
    public V1api20210601storageWorkspaceStatus? Status { get; set; }
}