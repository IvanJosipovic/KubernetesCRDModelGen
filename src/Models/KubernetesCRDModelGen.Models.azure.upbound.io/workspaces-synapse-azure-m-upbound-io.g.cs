using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.synapse.azure.m.upbound.io;
/// <summary>Workspace is the Schema for the Workspaces API. Manages a Synapse Workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WorkspaceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Workspace>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WorkspaceList";
    public const string KubeGroup = "synapse.azure.m.upbound.io";
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
    public IList<V1beta1Workspace> Items { get; set; }
}

/// <summary>An azure_devops_repo block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderAzureDevopsRepo
{
    /// <summary>Specifies the Azure DevOps account name.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>Specifies the collaboration branch of the repository to get code from.</summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>The last commit ID.</summary>
    [JsonPropertyName("lastCommitId")]
    public string? LastCommitId { get; set; }

    /// <summary>Specifies the name of the Azure DevOps project.</summary>
    [JsonPropertyName("projectName")]
    public string? ProjectName { get; set; }

    /// <summary>Specifies the name of the git repository.</summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }

    /// <summary>Specifies the root folder within the repository. Set to / for the top level.</summary>
    [JsonPropertyName("rootFolder")]
    public string? RootFolder { get; set; }

    /// <summary>the ID of the tenant for the Azure DevOps account.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderComputeSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate computeSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderComputeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecForProviderComputeSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderComputeSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate computeSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderComputeSubnetIdSelector
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
    public V1beta1WorkspaceSpecForProviderComputeSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderCustomerManagedKeyKeyVersionlessIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Key in keyvault to populate keyVersionlessId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderCustomerManagedKeyKeyVersionlessIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecForProviderCustomerManagedKeyKeyVersionlessIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderCustomerManagedKeyKeyVersionlessIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Key in keyvault to populate keyVersionlessId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderCustomerManagedKeyKeyVersionlessIdSelector
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
    public V1beta1WorkspaceSpecForProviderCustomerManagedKeyKeyVersionlessIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A customer_managed_key block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderCustomerManagedKey
{
    /// <summary>An identifier for the key. Name needs to match the name of the key used with the azurerm_synapse_workspace_key resource. Defaults to "cmk" if not specified.</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>The Azure Key Vault Key Versionless ID to be used as the Customer Managed Key (CMK) for double encryption (e.g. https://example-keyvault.vault.azure.net/type/cmk/).</summary>
    [JsonPropertyName("keyVersionlessId")]
    public string? KeyVersionlessId { get; set; }

    /// <summary>Reference to a Key in keyvault to populate keyVersionlessId.</summary>
    [JsonPropertyName("keyVersionlessIdRef")]
    public V1beta1WorkspaceSpecForProviderCustomerManagedKeyKeyVersionlessIdRef? KeyVersionlessIdRef { get; set; }

    /// <summary>Selector for a Key in keyvault to populate keyVersionlessId.</summary>
    [JsonPropertyName("keyVersionlessIdSelector")]
    public V1beta1WorkspaceSpecForProviderCustomerManagedKeyKeyVersionlessIdSelector? KeyVersionlessIdSelector { get; set; }

    /// <summary>The User Assigned Identity ID to be used for accessing the Customer Managed Key for encryption.</summary>
    [JsonPropertyName("userAssignedIdentityId")]
    public string? UserAssignedIdentityId { get; set; }
}

/// <summary>A github_repo block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderGithubRepo
{
    /// <summary>Specifies the GitHub account name.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>Specifies the collaboration branch of the repository to get code from.</summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>Specifies the GitHub Enterprise host name. For example: https://github.mydomain.com.</summary>
    [JsonPropertyName("gitUrl")]
    public string? GitUrl { get; set; }

    /// <summary>The last commit ID.</summary>
    [JsonPropertyName("lastCommitId")]
    public string? LastCommitId { get; set; }

    /// <summary>Specifies the name of the git repository.</summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }

    /// <summary>Specifies the root folder within the repository. Set to / for the top level.</summary>
    [JsonPropertyName("rootFolder")]
    public string? RootFolder { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Synapse Workspace.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be associated with this Synapse Workspace. Possible values are SystemAssigned, UserAssigned and SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderManagedResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate managedResourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderManagedResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecForProviderManagedResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderManagedResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate managedResourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderManagedResourceGroupNameSelector
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
    public V1beta1WorkspaceSpecForProviderManagedResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderResourceGroupNameSelector
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
    public V1beta1WorkspaceSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>The Password associated with the sql_administrator_login for the SQL administrator. If this is not provided customer_managed_key must be provided.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderSqlAdministratorLoginPasswordSecretRef
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
public partial class V1beta1WorkspaceSpecForProviderStorageDataLakeGen2FilesystemIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a DataLakeGen2FileSystem in storage to populate storageDataLakeGen2FilesystemId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderStorageDataLakeGen2FilesystemIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecForProviderStorageDataLakeGen2FilesystemIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderStorageDataLakeGen2FilesystemIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a DataLakeGen2FileSystem in storage to populate storageDataLakeGen2FilesystemId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProviderStorageDataLakeGen2FilesystemIdSelector
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
    public V1beta1WorkspaceSpecForProviderStorageDataLakeGen2FilesystemIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecForProvider
{
    /// <summary>An azure_devops_repo block as defined below.</summary>
    [JsonPropertyName("azureDevopsRepo")]
    public V1beta1WorkspaceSpecForProviderAzureDevopsRepo? AzureDevopsRepo { get; set; }

    /// <summary>Is Azure Active Directory Authentication the only way to authenticate with resources inside this synapse Workspace. Defaults to false.</summary>
    [JsonPropertyName("azureadAuthenticationOnly")]
    public bool? AzureadAuthenticationOnly { get; set; }

    /// <summary>Subnet ID used for computes in workspace Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("computeSubnetId")]
    public string? ComputeSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate computeSubnetId.</summary>
    [JsonPropertyName("computeSubnetIdRef")]
    public V1beta1WorkspaceSpecForProviderComputeSubnetIdRef? ComputeSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate computeSubnetId.</summary>
    [JsonPropertyName("computeSubnetIdSelector")]
    public V1beta1WorkspaceSpecForProviderComputeSubnetIdSelector? ComputeSubnetIdSelector { get; set; }

    /// <summary>A customer_managed_key block as defined below.</summary>
    [JsonPropertyName("customerManagedKey")]
    public V1beta1WorkspaceSpecForProviderCustomerManagedKey? CustomerManagedKey { get; set; }

    /// <summary>Is data exfiltration protection enabled in this workspace? If set to true, managed_virtual_network_enabled must also be set to true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataExfiltrationProtectionEnabled")]
    public bool? DataExfiltrationProtectionEnabled { get; set; }

    /// <summary>A github_repo block as defined below.</summary>
    [JsonPropertyName("githubRepo")]
    public V1beta1WorkspaceSpecForProviderGithubRepo? GithubRepo { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1WorkspaceSpecForProviderIdentity? Identity { get; set; }

    /// <summary>Allowed AAD Tenant Ids For Linking.</summary>
    [JsonPropertyName("linkingAllowedForAadTenantIds")]
    public IList<string>? LinkingAllowedForAadTenantIds { get; set; }

    /// <summary>Specifies the Azure Region where the synapse Workspace should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Workspace managed resource group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedResourceGroupName")]
    public string? ManagedResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate managedResourceGroupName.</summary>
    [JsonPropertyName("managedResourceGroupNameRef")]
    public V1beta1WorkspaceSpecForProviderManagedResourceGroupNameRef? ManagedResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate managedResourceGroupName.</summary>
    [JsonPropertyName("managedResourceGroupNameSelector")]
    public V1beta1WorkspaceSpecForProviderManagedResourceGroupNameSelector? ManagedResourceGroupNameSelector { get; set; }

    /// <summary>Is Virtual Network enabled for all computes in this workspace? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedVirtualNetworkEnabled")]
    public bool? ManagedVirtualNetworkEnabled { get; set; }

    /// <summary>Whether public network access is allowed for the Cognitive Account. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The ID of purview account.</summary>
    [JsonPropertyName("purviewId")]
    public string? PurviewId { get; set; }

    /// <summary>Specifies the name of the Resource Group where the synapse Workspace should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1WorkspaceSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1WorkspaceSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Specifies The login name of the SQL administrator. Changing this forces a new resource to be created. If this is not provided customer_managed_key must be provided.</summary>
    [JsonPropertyName("sqlAdministratorLogin")]
    public string? SqlAdministratorLogin { get; set; }

    /// <summary>The Password associated with the sql_administrator_login for the SQL administrator. If this is not provided customer_managed_key must be provided.</summary>
    [JsonPropertyName("sqlAdministratorLoginPasswordSecretRef")]
    public V1beta1WorkspaceSpecForProviderSqlAdministratorLoginPasswordSecretRef? SqlAdministratorLoginPasswordSecretRef { get; set; }

    /// <summary>Are pipelines (running as workspace's system assigned identity) allowed to access SQL pools?</summary>
    [JsonPropertyName("sqlIdentityControlEnabled")]
    public bool? SqlIdentityControlEnabled { get; set; }

    /// <summary>Specifies the ID of storage data lake gen2 filesystem resource. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageDataLakeGen2FilesystemId")]
    public string? StorageDataLakeGen2FilesystemId { get; set; }

    /// <summary>Reference to a DataLakeGen2FileSystem in storage to populate storageDataLakeGen2FilesystemId.</summary>
    [JsonPropertyName("storageDataLakeGen2FilesystemIdRef")]
    public V1beta1WorkspaceSpecForProviderStorageDataLakeGen2FilesystemIdRef? StorageDataLakeGen2FilesystemIdRef { get; set; }

    /// <summary>Selector for a DataLakeGen2FileSystem in storage to populate storageDataLakeGen2FilesystemId.</summary>
    [JsonPropertyName("storageDataLakeGen2FilesystemIdSelector")]
    public V1beta1WorkspaceSpecForProviderStorageDataLakeGen2FilesystemIdSelector? StorageDataLakeGen2FilesystemIdSelector { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Synapse Workspace.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>An azure_devops_repo block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecInitProviderAzureDevopsRepo
{
    /// <summary>Specifies the Azure DevOps account name.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>Specifies the collaboration branch of the repository to get code from.</summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>The last commit ID.</summary>
    [JsonPropertyName("lastCommitId")]
    public string? LastCommitId { get; set; }

    /// <summary>Specifies the name of the Azure DevOps project.</summary>
    [JsonPropertyName("projectName")]
    public string? ProjectName { get; set; }

    /// <summary>Specifies the name of the git repository.</summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }

    /// <summary>Specifies the root folder within the repository. Set to / for the top level.</summary>
    [JsonPropertyName("rootFolder")]
    public string? RootFolder { get; set; }

    /// <summary>the ID of the tenant for the Azure DevOps account.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecInitProviderComputeSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate computeSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecInitProviderComputeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecInitProviderComputeSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecInitProviderComputeSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate computeSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecInitProviderComputeSubnetIdSelector
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
    public V1beta1WorkspaceSpecInitProviderComputeSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecInitProviderCustomerManagedKeyKeyVersionlessIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Key in keyvault to populate keyVersionlessId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecInitProviderCustomerManagedKeyKeyVersionlessIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecInitProviderCustomerManagedKeyKeyVersionlessIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecInitProviderCustomerManagedKeyKeyVersionlessIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Key in keyvault to populate keyVersionlessId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecInitProviderCustomerManagedKeyKeyVersionlessIdSelector
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
    public V1beta1WorkspaceSpecInitProviderCustomerManagedKeyKeyVersionlessIdSelectorPolicy? Policy { get; set; }
}

/// <summary>A customer_managed_key block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecInitProviderCustomerManagedKey
{
    /// <summary>An identifier for the key. Name needs to match the name of the key used with the azurerm_synapse_workspace_key resource. Defaults to "cmk" if not specified.</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>The Azure Key Vault Key Versionless ID to be used as the Customer Managed Key (CMK) for double encryption (e.g. https://example-keyvault.vault.azure.net/type/cmk/).</summary>
    [JsonPropertyName("keyVersionlessId")]
    public string? KeyVersionlessId { get; set; }

    /// <summary>Reference to a Key in keyvault to populate keyVersionlessId.</summary>
    [JsonPropertyName("keyVersionlessIdRef")]
    public V1beta1WorkspaceSpecInitProviderCustomerManagedKeyKeyVersionlessIdRef? KeyVersionlessIdRef { get; set; }

    /// <summary>Selector for a Key in keyvault to populate keyVersionlessId.</summary>
    [JsonPropertyName("keyVersionlessIdSelector")]
    public V1beta1WorkspaceSpecInitProviderCustomerManagedKeyKeyVersionlessIdSelector? KeyVersionlessIdSelector { get; set; }

    /// <summary>The User Assigned Identity ID to be used for accessing the Customer Managed Key for encryption.</summary>
    [JsonPropertyName("userAssignedIdentityId")]
    public string? UserAssignedIdentityId { get; set; }
}

/// <summary>A github_repo block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecInitProviderGithubRepo
{
    /// <summary>Specifies the GitHub account name.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>Specifies the collaboration branch of the repository to get code from.</summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>Specifies the GitHub Enterprise host name. For example: https://github.mydomain.com.</summary>
    [JsonPropertyName("gitUrl")]
    public string? GitUrl { get; set; }

    /// <summary>The last commit ID.</summary>
    [JsonPropertyName("lastCommitId")]
    public string? LastCommitId { get; set; }

    /// <summary>Specifies the name of the git repository.</summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }

    /// <summary>Specifies the root folder within the repository. Set to / for the top level.</summary>
    [JsonPropertyName("rootFolder")]
    public string? RootFolder { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Synapse Workspace.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be associated with this Synapse Workspace. Possible values are SystemAssigned, UserAssigned and SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate managedResourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate managedResourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameSelector
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
    public V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>The Password associated with the sql_administrator_login for the SQL administrator. If this is not provided customer_managed_key must be provided.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecInitProviderSqlAdministratorLoginPasswordSecretRef
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
public partial class V1beta1WorkspaceSpecInitProviderStorageDataLakeGen2FilesystemIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a DataLakeGen2FileSystem in storage to populate storageDataLakeGen2FilesystemId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecInitProviderStorageDataLakeGen2FilesystemIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecInitProviderStorageDataLakeGen2FilesystemIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecInitProviderStorageDataLakeGen2FilesystemIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a DataLakeGen2FileSystem in storage to populate storageDataLakeGen2FilesystemId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecInitProviderStorageDataLakeGen2FilesystemIdSelector
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
    public V1beta1WorkspaceSpecInitProviderStorageDataLakeGen2FilesystemIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecInitProvider
{
    /// <summary>An azure_devops_repo block as defined below.</summary>
    [JsonPropertyName("azureDevopsRepo")]
    public V1beta1WorkspaceSpecInitProviderAzureDevopsRepo? AzureDevopsRepo { get; set; }

    /// <summary>Is Azure Active Directory Authentication the only way to authenticate with resources inside this synapse Workspace. Defaults to false.</summary>
    [JsonPropertyName("azureadAuthenticationOnly")]
    public bool? AzureadAuthenticationOnly { get; set; }

    /// <summary>Subnet ID used for computes in workspace Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("computeSubnetId")]
    public string? ComputeSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate computeSubnetId.</summary>
    [JsonPropertyName("computeSubnetIdRef")]
    public V1beta1WorkspaceSpecInitProviderComputeSubnetIdRef? ComputeSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate computeSubnetId.</summary>
    [JsonPropertyName("computeSubnetIdSelector")]
    public V1beta1WorkspaceSpecInitProviderComputeSubnetIdSelector? ComputeSubnetIdSelector { get; set; }

    /// <summary>A customer_managed_key block as defined below.</summary>
    [JsonPropertyName("customerManagedKey")]
    public V1beta1WorkspaceSpecInitProviderCustomerManagedKey? CustomerManagedKey { get; set; }

    /// <summary>Is data exfiltration protection enabled in this workspace? If set to true, managed_virtual_network_enabled must also be set to true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataExfiltrationProtectionEnabled")]
    public bool? DataExfiltrationProtectionEnabled { get; set; }

    /// <summary>A github_repo block as defined below.</summary>
    [JsonPropertyName("githubRepo")]
    public V1beta1WorkspaceSpecInitProviderGithubRepo? GithubRepo { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1WorkspaceSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>Allowed AAD Tenant Ids For Linking.</summary>
    [JsonPropertyName("linkingAllowedForAadTenantIds")]
    public IList<string>? LinkingAllowedForAadTenantIds { get; set; }

    /// <summary>Specifies the Azure Region where the synapse Workspace should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Workspace managed resource group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedResourceGroupName")]
    public string? ManagedResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate managedResourceGroupName.</summary>
    [JsonPropertyName("managedResourceGroupNameRef")]
    public V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameRef? ManagedResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate managedResourceGroupName.</summary>
    [JsonPropertyName("managedResourceGroupNameSelector")]
    public V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameSelector? ManagedResourceGroupNameSelector { get; set; }

    /// <summary>Is Virtual Network enabled for all computes in this workspace? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedVirtualNetworkEnabled")]
    public bool? ManagedVirtualNetworkEnabled { get; set; }

    /// <summary>Whether public network access is allowed for the Cognitive Account. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The ID of purview account.</summary>
    [JsonPropertyName("purviewId")]
    public string? PurviewId { get; set; }

    /// <summary>Specifies The login name of the SQL administrator. Changing this forces a new resource to be created. If this is not provided customer_managed_key must be provided.</summary>
    [JsonPropertyName("sqlAdministratorLogin")]
    public string? SqlAdministratorLogin { get; set; }

    /// <summary>The Password associated with the sql_administrator_login for the SQL administrator. If this is not provided customer_managed_key must be provided.</summary>
    [JsonPropertyName("sqlAdministratorLoginPasswordSecretRef")]
    public V1beta1WorkspaceSpecInitProviderSqlAdministratorLoginPasswordSecretRef? SqlAdministratorLoginPasswordSecretRef { get; set; }

    /// <summary>Are pipelines (running as workspace's system assigned identity) allowed to access SQL pools?</summary>
    [JsonPropertyName("sqlIdentityControlEnabled")]
    public bool? SqlIdentityControlEnabled { get; set; }

    /// <summary>Specifies the ID of storage data lake gen2 filesystem resource. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageDataLakeGen2FilesystemId")]
    public string? StorageDataLakeGen2FilesystemId { get; set; }

    /// <summary>Reference to a DataLakeGen2FileSystem in storage to populate storageDataLakeGen2FilesystemId.</summary>
    [JsonPropertyName("storageDataLakeGen2FilesystemIdRef")]
    public V1beta1WorkspaceSpecInitProviderStorageDataLakeGen2FilesystemIdRef? StorageDataLakeGen2FilesystemIdRef { get; set; }

    /// <summary>Selector for a DataLakeGen2FileSystem in storage to populate storageDataLakeGen2FilesystemId.</summary>
    [JsonPropertyName("storageDataLakeGen2FilesystemIdSelector")]
    public V1beta1WorkspaceSpecInitProviderStorageDataLakeGen2FilesystemIdSelector? StorageDataLakeGen2FilesystemIdSelector { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Synapse Workspace.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpecProviderConfigRef
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
public partial class V1beta1WorkspaceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WorkspaceSpec defines the desired state of Workspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1WorkspaceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1WorkspaceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1WorkspaceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1WorkspaceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An azure_devops_repo block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceStatusAtProviderAzureDevopsRepo
{
    /// <summary>Specifies the Azure DevOps account name.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>Specifies the collaboration branch of the repository to get code from.</summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>The last commit ID.</summary>
    [JsonPropertyName("lastCommitId")]
    public string? LastCommitId { get; set; }

    /// <summary>Specifies the name of the Azure DevOps project.</summary>
    [JsonPropertyName("projectName")]
    public string? ProjectName { get; set; }

    /// <summary>Specifies the name of the git repository.</summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }

    /// <summary>Specifies the root folder within the repository. Set to / for the top level.</summary>
    [JsonPropertyName("rootFolder")]
    public string? RootFolder { get; set; }

    /// <summary>the ID of the tenant for the Azure DevOps account.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>A customer_managed_key block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceStatusAtProviderCustomerManagedKey
{
    /// <summary>An identifier for the key. Name needs to match the name of the key used with the azurerm_synapse_workspace_key resource. Defaults to "cmk" if not specified.</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>The Azure Key Vault Key Versionless ID to be used as the Customer Managed Key (CMK) for double encryption (e.g. https://example-keyvault.vault.azure.net/type/cmk/).</summary>
    [JsonPropertyName("keyVersionlessId")]
    public string? KeyVersionlessId { get; set; }

    /// <summary>The User Assigned Identity ID to be used for accessing the Customer Managed Key for encryption.</summary>
    [JsonPropertyName("userAssignedIdentityId")]
    public string? UserAssignedIdentityId { get; set; }
}

/// <summary>A github_repo block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceStatusAtProviderGithubRepo
{
    /// <summary>Specifies the GitHub account name.</summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>Specifies the collaboration branch of the repository to get code from.</summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>Specifies the GitHub Enterprise host name. For example: https://github.mydomain.com.</summary>
    [JsonPropertyName("gitUrl")]
    public string? GitUrl { get; set; }

    /// <summary>The last commit ID.</summary>
    [JsonPropertyName("lastCommitId")]
    public string? LastCommitId { get; set; }

    /// <summary>Specifies the name of the git repository.</summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }

    /// <summary>Specifies the root folder within the repository. Set to / for the top level.</summary>
    [JsonPropertyName("rootFolder")]
    public string? RootFolder { get; set; }
}

/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Synapse Workspace.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID for the Service Principal associated with the Managed Service Identity of this Synapse Workspace.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID for the Service Principal associated with the Managed Service Identity of this Synapse Workspace.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be associated with this Synapse Workspace. Possible values are SystemAssigned, UserAssigned and SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceStatusAtProvider
{
    /// <summary>An azure_devops_repo block as defined below.</summary>
    [JsonPropertyName("azureDevopsRepo")]
    public V1beta1WorkspaceStatusAtProviderAzureDevopsRepo? AzureDevopsRepo { get; set; }

    /// <summary>Is Azure Active Directory Authentication the only way to authenticate with resources inside this synapse Workspace. Defaults to false.</summary>
    [JsonPropertyName("azureadAuthenticationOnly")]
    public bool? AzureadAuthenticationOnly { get; set; }

    /// <summary>Subnet ID used for computes in workspace Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("computeSubnetId")]
    public string? ComputeSubnetId { get; set; }

    /// <summary>A map of Connectivity endpoints for this Synapse Workspace. Possible key values are dev, sql, sqlOnDemand, and web.</summary>
    [JsonPropertyName("connectivityEndpoints")]
    public IDictionary<string, string>? ConnectivityEndpoints { get; set; }

    /// <summary>A customer_managed_key block as defined below.</summary>
    [JsonPropertyName("customerManagedKey")]
    public V1beta1WorkspaceStatusAtProviderCustomerManagedKey? CustomerManagedKey { get; set; }

    /// <summary>Is data exfiltration protection enabled in this workspace? If set to true, managed_virtual_network_enabled must also be set to true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataExfiltrationProtectionEnabled")]
    public bool? DataExfiltrationProtectionEnabled { get; set; }

    /// <summary>A github_repo block as defined below.</summary>
    [JsonPropertyName("githubRepo")]
    public V1beta1WorkspaceStatusAtProviderGithubRepo? GithubRepo { get; set; }

    /// <summary>The ID of the synapse Workspace.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1WorkspaceStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>Allowed AAD Tenant Ids For Linking.</summary>
    [JsonPropertyName("linkingAllowedForAadTenantIds")]
    public IList<string>? LinkingAllowedForAadTenantIds { get; set; }

    /// <summary>Specifies the Azure Region where the synapse Workspace should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Workspace managed resource group. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedResourceGroupName")]
    public string? ManagedResourceGroupName { get; set; }

    /// <summary>Is Virtual Network enabled for all computes in this workspace? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedVirtualNetworkEnabled")]
    public bool? ManagedVirtualNetworkEnabled { get; set; }

    /// <summary>Whether public network access is allowed for the Cognitive Account. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The ID of purview account.</summary>
    [JsonPropertyName("purviewId")]
    public string? PurviewId { get; set; }

    /// <summary>Specifies the name of the Resource Group where the synapse Workspace should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Specifies The login name of the SQL administrator. Changing this forces a new resource to be created. If this is not provided customer_managed_key must be provided.</summary>
    [JsonPropertyName("sqlAdministratorLogin")]
    public string? SqlAdministratorLogin { get; set; }

    /// <summary>Are pipelines (running as workspace's system assigned identity) allowed to access SQL pools?</summary>
    [JsonPropertyName("sqlIdentityControlEnabled")]
    public bool? SqlIdentityControlEnabled { get; set; }

    /// <summary>Specifies the ID of storage data lake gen2 filesystem resource. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageDataLakeGen2FilesystemId")]
    public string? StorageDataLakeGen2FilesystemId { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Synapse Workspace.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceStatusConditions
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

/// <summary>WorkspaceStatus defines the observed state of Workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkspaceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1WorkspaceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1WorkspaceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Workspace is the Schema for the Workspaces API. Manages a Synapse Workspace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Workspace : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WorkspaceSpec>, IStatus<V1beta1WorkspaceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Workspace";
    public const string KubeGroup = "synapse.azure.m.upbound.io";
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

    /// <summary>WorkspaceSpec defines the desired state of Workspace</summary>
    [JsonPropertyName("spec")]
    public V1beta1WorkspaceSpec Spec { get; set; }

    /// <summary>WorkspaceStatus defines the observed state of Workspace.</summary>
    [JsonPropertyName("status")]
    public V1beta1WorkspaceStatus? Status { get; set; }
}