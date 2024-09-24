using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.synapse.azure.upbound.io;
public enum V1beta1WorkspaceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1WorkspaceSpecForProviderAadAdmin
{
    /// <summary>The login name of the Azure AD Administrator of this Synapse Workspace.</summary>
    [JsonPropertyName("login")]
    public string? Login { get; set; }

    /// <summary>The object id of the Azure AD Administrator of this Synapse Workspace.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>The tenant id of the Azure AD Administrator of this Synapse Workspace.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

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

public enum V1beta1WorkspaceSpecForProviderComputeSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WorkspaceSpecForProviderComputeSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WorkspaceSpecForProviderComputeSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderComputeSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecForProviderComputeSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderComputeSubnetIdRefPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecForProviderComputeSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WorkspaceSpecForProviderComputeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecForProviderComputeSubnetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1WorkspaceSpecForProviderComputeSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WorkspaceSpecForProviderComputeSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WorkspaceSpecForProviderComputeSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderComputeSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecForProviderComputeSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderComputeSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecForProviderComputeSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WorkspaceSpecForProviderComputeSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecForProviderComputeSubnetIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1WorkspaceSpecForProviderCustomerManagedKeyKeyVersionlessIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WorkspaceSpecForProviderCustomerManagedKeyKeyVersionlessIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WorkspaceSpecForProviderCustomerManagedKeyKeyVersionlessIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderCustomerManagedKeyKeyVersionlessIdRefPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecForProviderCustomerManagedKeyKeyVersionlessIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderCustomerManagedKeyKeyVersionlessIdRefPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecForProviderCustomerManagedKeyKeyVersionlessIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WorkspaceSpecForProviderCustomerManagedKeyKeyVersionlessIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecForProviderCustomerManagedKeyKeyVersionlessIdRefPolicy? Policy { get; set; }
}

public enum V1beta1WorkspaceSpecForProviderCustomerManagedKeyKeyVersionlessIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WorkspaceSpecForProviderCustomerManagedKeyKeyVersionlessIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WorkspaceSpecForProviderCustomerManagedKeyKeyVersionlessIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderCustomerManagedKeyKeyVersionlessIdSelectorPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecForProviderCustomerManagedKeyKeyVersionlessIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderCustomerManagedKeyKeyVersionlessIdSelectorPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecForProviderCustomerManagedKeyKeyVersionlessIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WorkspaceSpecForProviderCustomerManagedKeyKeyVersionlessIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecForProviderCustomerManagedKeyKeyVersionlessIdSelectorPolicy? Policy { get; set; }
}

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

public partial class V1beta1WorkspaceSpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Synapse Workspace.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be associated with this Synapse Workspace. Possible values are SystemAssigned, UserAssigned and SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public enum V1beta1WorkspaceSpecForProviderManagedResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WorkspaceSpecForProviderManagedResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WorkspaceSpecForProviderManagedResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderManagedResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecForProviderManagedResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderManagedResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecForProviderManagedResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WorkspaceSpecForProviderManagedResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecForProviderManagedResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1WorkspaceSpecForProviderManagedResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WorkspaceSpecForProviderManagedResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WorkspaceSpecForProviderManagedResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderManagedResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecForProviderManagedResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderManagedResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecForProviderManagedResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WorkspaceSpecForProviderManagedResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecForProviderManagedResourceGroupNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1WorkspaceSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WorkspaceSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WorkspaceSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WorkspaceSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1WorkspaceSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WorkspaceSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WorkspaceSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WorkspaceSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1WorkspaceSpecForProviderSqlAadAdmin
{
    /// <summary>The login name of the Azure AD Administrator of this Synapse Workspace SQL.</summary>
    [JsonPropertyName("login")]
    public string? Login { get; set; }

    /// <summary>The object id of the Azure AD Administrator of this Synapse Workspace SQL.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>The tenant id of the Azure AD Administrator of this Synapse Workspace SQL.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

public partial class V1beta1WorkspaceSpecForProviderSqlAdministratorLoginPasswordSecretRef
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

public enum V1beta1WorkspaceSpecForProviderStorageDataLakeGen2FilesystemIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WorkspaceSpecForProviderStorageDataLakeGen2FilesystemIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WorkspaceSpecForProviderStorageDataLakeGen2FilesystemIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderStorageDataLakeGen2FilesystemIdRefPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecForProviderStorageDataLakeGen2FilesystemIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderStorageDataLakeGen2FilesystemIdRefPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecForProviderStorageDataLakeGen2FilesystemIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WorkspaceSpecForProviderStorageDataLakeGen2FilesystemIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecForProviderStorageDataLakeGen2FilesystemIdRefPolicy? Policy { get; set; }
}

public enum V1beta1WorkspaceSpecForProviderStorageDataLakeGen2FilesystemIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WorkspaceSpecForProviderStorageDataLakeGen2FilesystemIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WorkspaceSpecForProviderStorageDataLakeGen2FilesystemIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderStorageDataLakeGen2FilesystemIdSelectorPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecForProviderStorageDataLakeGen2FilesystemIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecForProviderStorageDataLakeGen2FilesystemIdSelectorPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecForProviderStorageDataLakeGen2FilesystemIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WorkspaceSpecForProviderStorageDataLakeGen2FilesystemIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecForProviderStorageDataLakeGen2FilesystemIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1WorkspaceSpecForProvider
{
    /// <summary>An aad_admin block as defined below.</summary>
    [JsonPropertyName("aadAdmin")]
    public IList<V1beta1WorkspaceSpecForProviderAadAdmin>? AadAdmin { get; set; }

    /// <summary>An azure_devops_repo block as defined below.</summary>
    [JsonPropertyName("azureDevopsRepo")]
    public IList<V1beta1WorkspaceSpecForProviderAzureDevopsRepo>? AzureDevopsRepo { get; set; }

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
    public IList<V1beta1WorkspaceSpecForProviderCustomerManagedKey>? CustomerManagedKey { get; set; }

    /// <summary>Is data exfiltration protection enabled in this workspace? If set to true, managed_virtual_network_enabled must also be set to true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataExfiltrationProtectionEnabled")]
    public bool? DataExfiltrationProtectionEnabled { get; set; }

    /// <summary>A github_repo block as defined below.</summary>
    [JsonPropertyName("githubRepo")]
    public IList<V1beta1WorkspaceSpecForProviderGithubRepo>? GithubRepo { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1WorkspaceSpecForProviderIdentity>? Identity { get; set; }

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

    /// <summary>An sql_aad_admin block as defined below.</summary>
    [JsonPropertyName("sqlAadAdmin")]
    public IList<V1beta1WorkspaceSpecForProviderSqlAadAdmin>? SqlAadAdmin { get; set; }

    /// <summary>Specifies The login name of the SQL administrator. Changing this forces a new resource to be created. If this is not provided aad_admin or customer_managed_key must be provided.</summary>
    [JsonPropertyName("sqlAdministratorLogin")]
    public string? SqlAdministratorLogin { get; set; }

    /// <summary>The Password associated with the sql_administrator_login for the SQL administrator. If this is not provided aad_admin or customer_managed_key must be provided.</summary>
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

public partial class V1beta1WorkspaceSpecInitProviderAadAdmin
{
    /// <summary>The login name of the Azure AD Administrator of this Synapse Workspace.</summary>
    [JsonPropertyName("login")]
    public string? Login { get; set; }

    /// <summary>The object id of the Azure AD Administrator of this Synapse Workspace.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>The tenant id of the Azure AD Administrator of this Synapse Workspace.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

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

public enum V1beta1WorkspaceSpecInitProviderComputeSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WorkspaceSpecInitProviderComputeSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WorkspaceSpecInitProviderComputeSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecInitProviderComputeSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecInitProviderComputeSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecInitProviderComputeSubnetIdRefPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecInitProviderComputeSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WorkspaceSpecInitProviderComputeSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecInitProviderComputeSubnetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1WorkspaceSpecInitProviderComputeSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WorkspaceSpecInitProviderComputeSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WorkspaceSpecInitProviderComputeSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecInitProviderComputeSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecInitProviderComputeSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecInitProviderComputeSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecInitProviderComputeSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WorkspaceSpecInitProviderComputeSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecInitProviderComputeSubnetIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1WorkspaceSpecInitProviderCustomerManagedKeyKeyVersionlessIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WorkspaceSpecInitProviderCustomerManagedKeyKeyVersionlessIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WorkspaceSpecInitProviderCustomerManagedKeyKeyVersionlessIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecInitProviderCustomerManagedKeyKeyVersionlessIdRefPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecInitProviderCustomerManagedKeyKeyVersionlessIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecInitProviderCustomerManagedKeyKeyVersionlessIdRefPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecInitProviderCustomerManagedKeyKeyVersionlessIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WorkspaceSpecInitProviderCustomerManagedKeyKeyVersionlessIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecInitProviderCustomerManagedKeyKeyVersionlessIdRefPolicy? Policy { get; set; }
}

public enum V1beta1WorkspaceSpecInitProviderCustomerManagedKeyKeyVersionlessIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WorkspaceSpecInitProviderCustomerManagedKeyKeyVersionlessIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WorkspaceSpecInitProviderCustomerManagedKeyKeyVersionlessIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecInitProviderCustomerManagedKeyKeyVersionlessIdSelectorPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecInitProviderCustomerManagedKeyKeyVersionlessIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecInitProviderCustomerManagedKeyKeyVersionlessIdSelectorPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecInitProviderCustomerManagedKeyKeyVersionlessIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WorkspaceSpecInitProviderCustomerManagedKeyKeyVersionlessIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecInitProviderCustomerManagedKeyKeyVersionlessIdSelectorPolicy? Policy { get; set; }
}

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

public partial class V1beta1WorkspaceSpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Synapse Workspace.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be associated with this Synapse Workspace. Possible values are SystemAssigned, UserAssigned and SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public enum V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecInitProviderManagedResourceGroupNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1WorkspaceSpecInitProviderSqlAadAdmin
{
    /// <summary>The login name of the Azure AD Administrator of this Synapse Workspace SQL.</summary>
    [JsonPropertyName("login")]
    public string? Login { get; set; }

    /// <summary>The object id of the Azure AD Administrator of this Synapse Workspace SQL.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>The tenant id of the Azure AD Administrator of this Synapse Workspace SQL.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

public enum V1beta1WorkspaceSpecInitProviderStorageDataLakeGen2FilesystemIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WorkspaceSpecInitProviderStorageDataLakeGen2FilesystemIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WorkspaceSpecInitProviderStorageDataLakeGen2FilesystemIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecInitProviderStorageDataLakeGen2FilesystemIdRefPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecInitProviderStorageDataLakeGen2FilesystemIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecInitProviderStorageDataLakeGen2FilesystemIdRefPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecInitProviderStorageDataLakeGen2FilesystemIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WorkspaceSpecInitProviderStorageDataLakeGen2FilesystemIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecInitProviderStorageDataLakeGen2FilesystemIdRefPolicy? Policy { get; set; }
}

public enum V1beta1WorkspaceSpecInitProviderStorageDataLakeGen2FilesystemIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WorkspaceSpecInitProviderStorageDataLakeGen2FilesystemIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WorkspaceSpecInitProviderStorageDataLakeGen2FilesystemIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecInitProviderStorageDataLakeGen2FilesystemIdSelectorPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecInitProviderStorageDataLakeGen2FilesystemIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecInitProviderStorageDataLakeGen2FilesystemIdSelectorPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecInitProviderStorageDataLakeGen2FilesystemIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WorkspaceSpecInitProviderStorageDataLakeGen2FilesystemIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecInitProviderStorageDataLakeGen2FilesystemIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1WorkspaceSpecInitProvider
{
    /// <summary>An aad_admin block as defined below.</summary>
    [JsonPropertyName("aadAdmin")]
    public IList<V1beta1WorkspaceSpecInitProviderAadAdmin>? AadAdmin { get; set; }

    /// <summary>An azure_devops_repo block as defined below.</summary>
    [JsonPropertyName("azureDevopsRepo")]
    public IList<V1beta1WorkspaceSpecInitProviderAzureDevopsRepo>? AzureDevopsRepo { get; set; }

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
    public IList<V1beta1WorkspaceSpecInitProviderCustomerManagedKey>? CustomerManagedKey { get; set; }

    /// <summary>Is data exfiltration protection enabled in this workspace? If set to true, managed_virtual_network_enabled must also be set to true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataExfiltrationProtectionEnabled")]
    public bool? DataExfiltrationProtectionEnabled { get; set; }

    /// <summary>A github_repo block as defined below.</summary>
    [JsonPropertyName("githubRepo")]
    public IList<V1beta1WorkspaceSpecInitProviderGithubRepo>? GithubRepo { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1WorkspaceSpecInitProviderIdentity>? Identity { get; set; }

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

    /// <summary>An sql_aad_admin block as defined below.</summary>
    [JsonPropertyName("sqlAadAdmin")]
    public IList<V1beta1WorkspaceSpecInitProviderSqlAadAdmin>? SqlAadAdmin { get; set; }

    /// <summary>Specifies The login name of the SQL administrator. Changing this forces a new resource to be created. If this is not provided aad_admin or customer_managed_key must be provided.</summary>
    [JsonPropertyName("sqlAdministratorLogin")]
    public string? SqlAdministratorLogin { get; set; }

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

public enum V1beta1WorkspaceSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    /// <summary>Observe</summary>
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    /// <summary>Create</summary>
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    /// <summary>Update</summary>
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    /// <summary>LateInitialize</summary>
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    /// <summary>*</summary>
    Option5
}

public enum V1beta1WorkspaceSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WorkspaceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WorkspaceSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WorkspaceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1WorkspaceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1WorkspaceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1WorkspaceSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1WorkspaceSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1WorkspaceSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1WorkspaceSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkspaceSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1WorkspaceSpecPublishConnectionDetailsToMetadata
{
    /// <summary>Annotations are the annotations to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.annotations". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels are the labels/tags to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.labels". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Type is the SecretType for the connection secret. - Only valid for Kubernetes Secret Stores.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1WorkspaceSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1WorkspaceSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1WorkspaceSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1WorkspaceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1WorkspaceSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkspaceSpecDeletionPolicyEnum>))]
    public V1beta1WorkspaceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1WorkspaceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1WorkspaceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1WorkspaceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1WorkspaceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1WorkspaceSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1WorkspaceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1WorkspaceStatusAtProviderAadAdmin
{
    /// <summary>The login name of the Azure AD Administrator of this Synapse Workspace.</summary>
    [JsonPropertyName("login")]
    public string? Login { get; set; }

    /// <summary>The object id of the Azure AD Administrator of this Synapse Workspace.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>The tenant id of the Azure AD Administrator of this Synapse Workspace.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

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

public partial class V1beta1WorkspaceStatusAtProviderSqlAadAdmin
{
    /// <summary>The login name of the Azure AD Administrator of this Synapse Workspace SQL.</summary>
    [JsonPropertyName("login")]
    public string? Login { get; set; }

    /// <summary>The object id of the Azure AD Administrator of this Synapse Workspace SQL.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>The tenant id of the Azure AD Administrator of this Synapse Workspace SQL.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

public partial class V1beta1WorkspaceStatusAtProvider
{
    /// <summary>An aad_admin block as defined below.</summary>
    [JsonPropertyName("aadAdmin")]
    public IList<V1beta1WorkspaceStatusAtProviderAadAdmin>? AadAdmin { get; set; }

    /// <summary>An azure_devops_repo block as defined below.</summary>
    [JsonPropertyName("azureDevopsRepo")]
    public IList<V1beta1WorkspaceStatusAtProviderAzureDevopsRepo>? AzureDevopsRepo { get; set; }

    /// <summary>Is Azure Active Directory Authentication the only way to authenticate with resources inside this synapse Workspace. Defaults to false.</summary>
    [JsonPropertyName("azureadAuthenticationOnly")]
    public bool? AzureadAuthenticationOnly { get; set; }

    /// <summary>Subnet ID used for computes in workspace Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("computeSubnetId")]
    public string? ComputeSubnetId { get; set; }

    /// <summary>A list of Connectivity endpoints for this Synapse Workspace.</summary>
    [JsonPropertyName("connectivityEndpoints")]
    public IDictionary<string, string>? ConnectivityEndpoints { get; set; }

    /// <summary>A customer_managed_key block as defined below.</summary>
    [JsonPropertyName("customerManagedKey")]
    public IList<V1beta1WorkspaceStatusAtProviderCustomerManagedKey>? CustomerManagedKey { get; set; }

    /// <summary>Is data exfiltration protection enabled in this workspace? If set to true, managed_virtual_network_enabled must also be set to true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("dataExfiltrationProtectionEnabled")]
    public bool? DataExfiltrationProtectionEnabled { get; set; }

    /// <summary>A github_repo block as defined below.</summary>
    [JsonPropertyName("githubRepo")]
    public IList<V1beta1WorkspaceStatusAtProviderGithubRepo>? GithubRepo { get; set; }

    /// <summary>The ID of the synapse Workspace.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1WorkspaceStatusAtProviderIdentity>? Identity { get; set; }

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

    /// <summary>An sql_aad_admin block as defined below.</summary>
    [JsonPropertyName("sqlAadAdmin")]
    public IList<V1beta1WorkspaceStatusAtProviderSqlAadAdmin>? SqlAadAdmin { get; set; }

    /// <summary>Specifies The login name of the SQL administrator. Changing this forces a new resource to be created. If this is not provided aad_admin or customer_managed_key must be provided.</summary>
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

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Workspace : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WorkspaceSpec>, IStatus<V1beta1WorkspaceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Workspace";
    public const string KubeGroup = "synapse.azure.upbound.io";
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