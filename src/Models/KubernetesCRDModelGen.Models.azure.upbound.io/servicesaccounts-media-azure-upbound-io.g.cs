using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.media.azure.upbound.io;
public enum V1beta1ServicesAccountSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1ServicesAccountSpecForProviderEncryptionManagedIdentity
{
    /// <summary>Whether to use System Assigned Identity. Possible Values are true and false.</summary>
    [JsonPropertyName("useSystemAssignedIdentity")]
    public bool? UseSystemAssignedIdentity { get; set; }

    /// <summary>The ID of the User Assigned Identity. This value can only be set when use_system_assigned_identity is false</summary>
    [JsonPropertyName("userAssignedIdentityId")]
    public string? UserAssignedIdentityId { get; set; }
}

/// <summary></summary>
public partial class V1beta1ServicesAccountSpecForProviderEncryption
{
    /// <summary>Specifies the URI of the Key Vault Key used to encrypt data. The key may either be versioned (for example https://vault/keys/mykey/version1) or reference a key without a version (for example https://vault/keys/mykey).</summary>
    [JsonPropertyName("keyVaultKeyIdentifier")]
    public string? KeyVaultKeyIdentifier { get; set; }

    /// <summary>A managed_identity block as defined below.</summary>
    [JsonPropertyName("managedIdentity")]
    public IList<V1beta1ServicesAccountSpecForProviderEncryptionManagedIdentity>? ManagedIdentity { get; set; }

    /// <summary>Specifies the type of key used to encrypt the account data. Possible values are SystemKey and CustomerKey. Defaults to SystemKey.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1ServicesAccountSpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Media Services Account.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Media Services Account. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1ServicesAccountSpecForProviderKeyDeliveryAccessControl
{
    /// <summary>The Default Action to use when no rules match from ip_allow_list. Possible values are Allow and Deny.</summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>One or more IP Addresses, or CIDR Blocks which should be able to access the Key Delivery.</summary>
    [JsonPropertyName("ipAllowList")]
    public IList<string>? IpAllowList { get; set; }
}

public enum V1beta1ServicesAccountSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ServicesAccountSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ServicesAccountSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServicesAccountSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1ServicesAccountSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServicesAccountSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1ServicesAccountSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1ServicesAccountSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServicesAccountSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1ServicesAccountSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ServicesAccountSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ServicesAccountSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServicesAccountSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1ServicesAccountSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServicesAccountSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1ServicesAccountSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1ServicesAccountSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServicesAccountSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1ServicesAccountSpecForProviderStorageAccountIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ServicesAccountSpecForProviderStorageAccountIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ServicesAccountSpecForProviderStorageAccountIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServicesAccountSpecForProviderStorageAccountIdRefPolicyResolutionEnum>))]
    public V1beta1ServicesAccountSpecForProviderStorageAccountIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServicesAccountSpecForProviderStorageAccountIdRefPolicyResolveEnum>))]
    public V1beta1ServicesAccountSpecForProviderStorageAccountIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Account in storage to populate id.</summary>
public partial class V1beta1ServicesAccountSpecForProviderStorageAccountIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServicesAccountSpecForProviderStorageAccountIdRefPolicy? Policy { get; set; }
}

public enum V1beta1ServicesAccountSpecForProviderStorageAccountIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ServicesAccountSpecForProviderStorageAccountIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ServicesAccountSpecForProviderStorageAccountIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServicesAccountSpecForProviderStorageAccountIdSelectorPolicyResolutionEnum>))]
    public V1beta1ServicesAccountSpecForProviderStorageAccountIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServicesAccountSpecForProviderStorageAccountIdSelectorPolicyResolveEnum>))]
    public V1beta1ServicesAccountSpecForProviderStorageAccountIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Account in storage to populate id.</summary>
public partial class V1beta1ServicesAccountSpecForProviderStorageAccountIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServicesAccountSpecForProviderStorageAccountIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1ServicesAccountSpecForProviderStorageAccountManagedIdentity
{
    /// <summary>Whether to use System Assigned Identity. Possible Values are true and false.</summary>
    [JsonPropertyName("useSystemAssignedIdentity")]
    public bool? UseSystemAssignedIdentity { get; set; }

    /// <summary>The ID of the User Assigned Identity. This value can only be set when use_system_assigned_identity is false</summary>
    [JsonPropertyName("userAssignedIdentityId")]
    public string? UserAssignedIdentityId { get; set; }
}

/// <summary></summary>
public partial class V1beta1ServicesAccountSpecForProviderStorageAccount
{
    /// <summary>Specifies the ID of the Storage Account that will be associated with the Media Services instance.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Reference to a Account in storage to populate id.</summary>
    [JsonPropertyName("idRef")]
    public V1beta1ServicesAccountSpecForProviderStorageAccountIdRef? IdRef { get; set; }

    /// <summary>Selector for a Account in storage to populate id.</summary>
    [JsonPropertyName("idSelector")]
    public V1beta1ServicesAccountSpecForProviderStorageAccountIdSelector? IdSelector { get; set; }

    /// <summary>Specifies whether the storage account should be the primary account or not. Defaults to false.</summary>
    [JsonPropertyName("isPrimary")]
    public bool? IsPrimary { get; set; }

    /// <summary>A managed_identity block as defined below.</summary>
    [JsonPropertyName("managedIdentity")]
    public IList<V1beta1ServicesAccountSpecForProviderStorageAccountManagedIdentity>? ManagedIdentity { get; set; }
}

/// <summary></summary>
public partial class V1beta1ServicesAccountSpecForProvider
{
    /// <summary>An encryption block as defined below.</summary>
    [JsonPropertyName("encryption")]
    public IList<V1beta1ServicesAccountSpecForProviderEncryption>? Encryption { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1ServicesAccountSpecForProviderIdentity>? Identity { get; set; }

    /// <summary>A key_delivery_access_control block as defined below.</summary>
    [JsonPropertyName("keyDeliveryAccessControl")]
    public IList<V1beta1ServicesAccountSpecForProviderKeyDeliveryAccessControl>? KeyDeliveryAccessControl { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Whether public network access is allowed for this server. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the resource group in which to create the Media Services Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1ServicesAccountSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1ServicesAccountSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>One or more storage_account blocks as defined below.</summary>
    [JsonPropertyName("storageAccount")]
    public IList<V1beta1ServicesAccountSpecForProviderStorageAccount>? StorageAccount { get; set; }

    /// <summary>Specifies the storage authentication type. Possible value is ManagedIdentity or System.</summary>
    [JsonPropertyName("storageAuthenticationType")]
    public string? StorageAuthenticationType { get; set; }

    /// <summary>A mapping of tags assigned to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
public partial class V1beta1ServicesAccountSpecInitProviderEncryptionManagedIdentity
{
    /// <summary>Whether to use System Assigned Identity. Possible Values are true and false.</summary>
    [JsonPropertyName("useSystemAssignedIdentity")]
    public bool? UseSystemAssignedIdentity { get; set; }

    /// <summary>The ID of the User Assigned Identity. This value can only be set when use_system_assigned_identity is false</summary>
    [JsonPropertyName("userAssignedIdentityId")]
    public string? UserAssignedIdentityId { get; set; }
}

/// <summary></summary>
public partial class V1beta1ServicesAccountSpecInitProviderEncryption
{
    /// <summary>Specifies the URI of the Key Vault Key used to encrypt data. The key may either be versioned (for example https://vault/keys/mykey/version1) or reference a key without a version (for example https://vault/keys/mykey).</summary>
    [JsonPropertyName("keyVaultKeyIdentifier")]
    public string? KeyVaultKeyIdentifier { get; set; }

    /// <summary>A managed_identity block as defined below.</summary>
    [JsonPropertyName("managedIdentity")]
    public IList<V1beta1ServicesAccountSpecInitProviderEncryptionManagedIdentity>? ManagedIdentity { get; set; }

    /// <summary>Specifies the type of key used to encrypt the account data. Possible values are SystemKey and CustomerKey. Defaults to SystemKey.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1ServicesAccountSpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Media Services Account.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Media Services Account. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1ServicesAccountSpecInitProviderKeyDeliveryAccessControl
{
    /// <summary>The Default Action to use when no rules match from ip_allow_list. Possible values are Allow and Deny.</summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>One or more IP Addresses, or CIDR Blocks which should be able to access the Key Delivery.</summary>
    [JsonPropertyName("ipAllowList")]
    public IList<string>? IpAllowList { get; set; }
}

public enum V1beta1ServicesAccountSpecInitProviderStorageAccountIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ServicesAccountSpecInitProviderStorageAccountIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ServicesAccountSpecInitProviderStorageAccountIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServicesAccountSpecInitProviderStorageAccountIdRefPolicyResolutionEnum>))]
    public V1beta1ServicesAccountSpecInitProviderStorageAccountIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServicesAccountSpecInitProviderStorageAccountIdRefPolicyResolveEnum>))]
    public V1beta1ServicesAccountSpecInitProviderStorageAccountIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Account in storage to populate id.</summary>
public partial class V1beta1ServicesAccountSpecInitProviderStorageAccountIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServicesAccountSpecInitProviderStorageAccountIdRefPolicy? Policy { get; set; }
}

public enum V1beta1ServicesAccountSpecInitProviderStorageAccountIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ServicesAccountSpecInitProviderStorageAccountIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1ServicesAccountSpecInitProviderStorageAccountIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServicesAccountSpecInitProviderStorageAccountIdSelectorPolicyResolutionEnum>))]
    public V1beta1ServicesAccountSpecInitProviderStorageAccountIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServicesAccountSpecInitProviderStorageAccountIdSelectorPolicyResolveEnum>))]
    public V1beta1ServicesAccountSpecInitProviderStorageAccountIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Account in storage to populate id.</summary>
public partial class V1beta1ServicesAccountSpecInitProviderStorageAccountIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServicesAccountSpecInitProviderStorageAccountIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1ServicesAccountSpecInitProviderStorageAccountManagedIdentity
{
    /// <summary>Whether to use System Assigned Identity. Possible Values are true and false.</summary>
    [JsonPropertyName("useSystemAssignedIdentity")]
    public bool? UseSystemAssignedIdentity { get; set; }

    /// <summary>The ID of the User Assigned Identity. This value can only be set when use_system_assigned_identity is false</summary>
    [JsonPropertyName("userAssignedIdentityId")]
    public string? UserAssignedIdentityId { get; set; }
}

/// <summary></summary>
public partial class V1beta1ServicesAccountSpecInitProviderStorageAccount
{
    /// <summary>Specifies the ID of the Storage Account that will be associated with the Media Services instance.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Reference to a Account in storage to populate id.</summary>
    [JsonPropertyName("idRef")]
    public V1beta1ServicesAccountSpecInitProviderStorageAccountIdRef? IdRef { get; set; }

    /// <summary>Selector for a Account in storage to populate id.</summary>
    [JsonPropertyName("idSelector")]
    public V1beta1ServicesAccountSpecInitProviderStorageAccountIdSelector? IdSelector { get; set; }

    /// <summary>Specifies whether the storage account should be the primary account or not. Defaults to false.</summary>
    [JsonPropertyName("isPrimary")]
    public bool? IsPrimary { get; set; }

    /// <summary>A managed_identity block as defined below.</summary>
    [JsonPropertyName("managedIdentity")]
    public IList<V1beta1ServicesAccountSpecInitProviderStorageAccountManagedIdentity>? ManagedIdentity { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1ServicesAccountSpecInitProvider
{
    /// <summary>An encryption block as defined below.</summary>
    [JsonPropertyName("encryption")]
    public IList<V1beta1ServicesAccountSpecInitProviderEncryption>? Encryption { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1ServicesAccountSpecInitProviderIdentity>? Identity { get; set; }

    /// <summary>A key_delivery_access_control block as defined below.</summary>
    [JsonPropertyName("keyDeliveryAccessControl")]
    public IList<V1beta1ServicesAccountSpecInitProviderKeyDeliveryAccessControl>? KeyDeliveryAccessControl { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Whether public network access is allowed for this server. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>One or more storage_account blocks as defined below.</summary>
    [JsonPropertyName("storageAccount")]
    public IList<V1beta1ServicesAccountSpecInitProviderStorageAccount>? StorageAccount { get; set; }

    /// <summary>Specifies the storage authentication type. Possible value is ManagedIdentity or System.</summary>
    [JsonPropertyName("storageAuthenticationType")]
    public string? StorageAuthenticationType { get; set; }

    /// <summary>A mapping of tags assigned to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

public enum V1beta1ServicesAccountSpecManagementPoliciesEnum
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

public enum V1beta1ServicesAccountSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ServicesAccountSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ServicesAccountSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServicesAccountSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1ServicesAccountSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServicesAccountSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1ServicesAccountSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1ServicesAccountSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServicesAccountSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1ServicesAccountSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1ServicesAccountSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1ServicesAccountSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServicesAccountSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1ServicesAccountSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServicesAccountSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1ServicesAccountSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1ServicesAccountSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ServicesAccountSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1ServicesAccountSpecPublishConnectionDetailsToMetadata
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

/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
public partial class V1beta1ServicesAccountSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ServicesAccountSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ServicesAccountSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1ServicesAccountSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ServicesAccountSpec defines the desired state of ServicesAccount</summary>
public partial class V1beta1ServicesAccountSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1ServicesAccountSpecDeletionPolicyEnum>))]
    public V1beta1ServicesAccountSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ServicesAccountSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ServicesAccountSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ServicesAccountSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ServicesAccountSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ServicesAccountSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ServicesAccountSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1ServicesAccountStatusAtProviderEncryptionManagedIdentity
{
    /// <summary>Whether to use System Assigned Identity. Possible Values are true and false.</summary>
    [JsonPropertyName("useSystemAssignedIdentity")]
    public bool? UseSystemAssignedIdentity { get; set; }

    /// <summary>The ID of the User Assigned Identity. This value can only be set when use_system_assigned_identity is false</summary>
    [JsonPropertyName("userAssignedIdentityId")]
    public string? UserAssignedIdentityId { get; set; }
}

/// <summary></summary>
public partial class V1beta1ServicesAccountStatusAtProviderEncryption
{
    /// <summary>The current key used to encrypt the Media Services Account, including the key version.</summary>
    [JsonPropertyName("currentKeyIdentifier")]
    public string? CurrentKeyIdentifier { get; set; }

    /// <summary>Specifies the URI of the Key Vault Key used to encrypt data. The key may either be versioned (for example https://vault/keys/mykey/version1) or reference a key without a version (for example https://vault/keys/mykey).</summary>
    [JsonPropertyName("keyVaultKeyIdentifier")]
    public string? KeyVaultKeyIdentifier { get; set; }

    /// <summary>A managed_identity block as defined below.</summary>
    [JsonPropertyName("managedIdentity")]
    public IList<V1beta1ServicesAccountStatusAtProviderEncryptionManagedIdentity>? ManagedIdentity { get; set; }

    /// <summary>Specifies the type of key used to encrypt the account data. Possible values are SystemKey and CustomerKey. Defaults to SystemKey.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1ServicesAccountStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Media Services Account.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Media Services Account. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1ServicesAccountStatusAtProviderKeyDeliveryAccessControl
{
    /// <summary>The Default Action to use when no rules match from ip_allow_list. Possible values are Allow and Deny.</summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>One or more IP Addresses, or CIDR Blocks which should be able to access the Key Delivery.</summary>
    [JsonPropertyName("ipAllowList")]
    public IList<string>? IpAllowList { get; set; }
}

/// <summary></summary>
public partial class V1beta1ServicesAccountStatusAtProviderStorageAccountManagedIdentity
{
    /// <summary>Whether to use System Assigned Identity. Possible Values are true and false.</summary>
    [JsonPropertyName("useSystemAssignedIdentity")]
    public bool? UseSystemAssignedIdentity { get; set; }

    /// <summary>The ID of the User Assigned Identity. This value can only be set when use_system_assigned_identity is false</summary>
    [JsonPropertyName("userAssignedIdentityId")]
    public string? UserAssignedIdentityId { get; set; }
}

/// <summary></summary>
public partial class V1beta1ServicesAccountStatusAtProviderStorageAccount
{
    /// <summary>Specifies the ID of the Storage Account that will be associated with the Media Services instance.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies whether the storage account should be the primary account or not. Defaults to false.</summary>
    [JsonPropertyName("isPrimary")]
    public bool? IsPrimary { get; set; }

    /// <summary>A managed_identity block as defined below.</summary>
    [JsonPropertyName("managedIdentity")]
    public IList<V1beta1ServicesAccountStatusAtProviderStorageAccountManagedIdentity>? ManagedIdentity { get; set; }
}

/// <summary></summary>
public partial class V1beta1ServicesAccountStatusAtProvider
{
    /// <summary>An encryption block as defined below.</summary>
    [JsonPropertyName("encryption")]
    public IList<V1beta1ServicesAccountStatusAtProviderEncryption>? Encryption { get; set; }

    /// <summary>The ID of the Media Services Account.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1ServicesAccountStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>A key_delivery_access_control block as defined below.</summary>
    [JsonPropertyName("keyDeliveryAccessControl")]
    public IList<V1beta1ServicesAccountStatusAtProviderKeyDeliveryAccessControl>? KeyDeliveryAccessControl { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Whether public network access is allowed for this server. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the resource group in which to create the Media Services Account. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>One or more storage_account blocks as defined below.</summary>
    [JsonPropertyName("storageAccount")]
    public IList<V1beta1ServicesAccountStatusAtProviderStorageAccount>? StorageAccount { get; set; }

    /// <summary>Specifies the storage authentication type. Possible value is ManagedIdentity or System.</summary>
    [JsonPropertyName("storageAuthenticationType")]
    public string? StorageAuthenticationType { get; set; }

    /// <summary>A mapping of tags assigned to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1ServicesAccountStatusConditions
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

/// <summary>ServicesAccountStatus defines the observed state of ServicesAccount.</summary>
public partial class V1beta1ServicesAccountStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ServicesAccountStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ServicesAccountStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>ServicesAccount is the Schema for the ServicesAccounts API. Manages a Media Services Account.</summary>
public partial class V1beta1ServicesAccount : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ServicesAccountSpec>, IStatus<V1beta1ServicesAccountStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ServicesAccount";
    public const string KubeGroup = "media.azure.upbound.io";
    public const string KubePluralName = "servicesaccounts";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ServicesAccountSpec defines the desired state of ServicesAccount</summary>
    [JsonPropertyName("spec")]
    public V1beta1ServicesAccountSpec Spec { get; set; }

    /// <summary>ServicesAccountStatus defines the observed state of ServicesAccount.</summary>
    [JsonPropertyName("status")]
    public V1beta1ServicesAccountStatus? Status { get; set; }
}