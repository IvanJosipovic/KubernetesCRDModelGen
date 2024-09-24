using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sql.azure.upbound.io;
public enum V1beta1MSSQLServerSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public partial class V1beta1MSSQLServerSpecForProviderAdministratorLoginPasswordSecretRef
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

public enum V1beta1MSSQLServerSpecForProviderAzureadAdministratorLoginUsernameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLServerSpecForProviderAzureadAdministratorLoginUsernameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLServerSpecForProviderAzureadAdministratorLoginUsernameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecForProviderAzureadAdministratorLoginUsernameRefPolicyResolutionEnum>))]
    public V1beta1MSSQLServerSpecForProviderAzureadAdministratorLoginUsernameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecForProviderAzureadAdministratorLoginUsernameRefPolicyResolveEnum>))]
    public V1beta1MSSQLServerSpecForProviderAzureadAdministratorLoginUsernameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLServerSpecForProviderAzureadAdministratorLoginUsernameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLServerSpecForProviderAzureadAdministratorLoginUsernameRefPolicy? Policy { get; set; }
}

public enum V1beta1MSSQLServerSpecForProviderAzureadAdministratorLoginUsernameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLServerSpecForProviderAzureadAdministratorLoginUsernameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLServerSpecForProviderAzureadAdministratorLoginUsernameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecForProviderAzureadAdministratorLoginUsernameSelectorPolicyResolutionEnum>))]
    public V1beta1MSSQLServerSpecForProviderAzureadAdministratorLoginUsernameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecForProviderAzureadAdministratorLoginUsernameSelectorPolicyResolveEnum>))]
    public V1beta1MSSQLServerSpecForProviderAzureadAdministratorLoginUsernameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLServerSpecForProviderAzureadAdministratorLoginUsernameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLServerSpecForProviderAzureadAdministratorLoginUsernameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1MSSQLServerSpecForProviderAzureadAdministratorObjectIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLServerSpecForProviderAzureadAdministratorObjectIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLServerSpecForProviderAzureadAdministratorObjectIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecForProviderAzureadAdministratorObjectIdRefPolicyResolutionEnum>))]
    public V1beta1MSSQLServerSpecForProviderAzureadAdministratorObjectIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecForProviderAzureadAdministratorObjectIdRefPolicyResolveEnum>))]
    public V1beta1MSSQLServerSpecForProviderAzureadAdministratorObjectIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLServerSpecForProviderAzureadAdministratorObjectIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLServerSpecForProviderAzureadAdministratorObjectIdRefPolicy? Policy { get; set; }
}

public enum V1beta1MSSQLServerSpecForProviderAzureadAdministratorObjectIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLServerSpecForProviderAzureadAdministratorObjectIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLServerSpecForProviderAzureadAdministratorObjectIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecForProviderAzureadAdministratorObjectIdSelectorPolicyResolutionEnum>))]
    public V1beta1MSSQLServerSpecForProviderAzureadAdministratorObjectIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecForProviderAzureadAdministratorObjectIdSelectorPolicyResolveEnum>))]
    public V1beta1MSSQLServerSpecForProviderAzureadAdministratorObjectIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLServerSpecForProviderAzureadAdministratorObjectIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLServerSpecForProviderAzureadAdministratorObjectIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1MSSQLServerSpecForProviderAzureadAdministrator
{
    /// <summary>Specifies whether only AD Users and administrators (e.g. azuread_administrator[0].login_username) can be used to login, or also local database users (e.g. administrator_login). When true, the administrator_login and administrator_login_password properties can be omitted.</summary>
    [JsonPropertyName("azureadAuthenticationOnly")]
    public bool? AzureadAuthenticationOnly { get; set; }

    /// <summary>The login username of the Azure AD Administrator of this SQL Server.</summary>
    [JsonPropertyName("loginUsername")]
    public string? LoginUsername { get; set; }

    /// <summary>Reference to a UserAssignedIdentity in managedidentity to populate loginUsername.</summary>
    [JsonPropertyName("loginUsernameRef")]
    public V1beta1MSSQLServerSpecForProviderAzureadAdministratorLoginUsernameRef? LoginUsernameRef { get; set; }

    /// <summary>Selector for a UserAssignedIdentity in managedidentity to populate loginUsername.</summary>
    [JsonPropertyName("loginUsernameSelector")]
    public V1beta1MSSQLServerSpecForProviderAzureadAdministratorLoginUsernameSelector? LoginUsernameSelector { get; set; }

    /// <summary>The object id of the Azure AD Administrator of this SQL Server.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>Reference to a UserAssignedIdentity in managedidentity to populate objectId.</summary>
    [JsonPropertyName("objectIdRef")]
    public V1beta1MSSQLServerSpecForProviderAzureadAdministratorObjectIdRef? ObjectIdRef { get; set; }

    /// <summary>Selector for a UserAssignedIdentity in managedidentity to populate objectId.</summary>
    [JsonPropertyName("objectIdSelector")]
    public V1beta1MSSQLServerSpecForProviderAzureadAdministratorObjectIdSelector? ObjectIdSelector { get; set; }

    /// <summary>The tenant id of the Azure AD Administrator of this SQL Server.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

public partial class V1beta1MSSQLServerSpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this SQL Server.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this SQL Server. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public enum V1beta1MSSQLServerSpecForProviderPrimaryUserAssignedIdentityIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLServerSpecForProviderPrimaryUserAssignedIdentityIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLServerSpecForProviderPrimaryUserAssignedIdentityIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecForProviderPrimaryUserAssignedIdentityIdRefPolicyResolutionEnum>))]
    public V1beta1MSSQLServerSpecForProviderPrimaryUserAssignedIdentityIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecForProviderPrimaryUserAssignedIdentityIdRefPolicyResolveEnum>))]
    public V1beta1MSSQLServerSpecForProviderPrimaryUserAssignedIdentityIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLServerSpecForProviderPrimaryUserAssignedIdentityIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLServerSpecForProviderPrimaryUserAssignedIdentityIdRefPolicy? Policy { get; set; }
}

public enum V1beta1MSSQLServerSpecForProviderPrimaryUserAssignedIdentityIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLServerSpecForProviderPrimaryUserAssignedIdentityIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLServerSpecForProviderPrimaryUserAssignedIdentityIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecForProviderPrimaryUserAssignedIdentityIdSelectorPolicyResolutionEnum>))]
    public V1beta1MSSQLServerSpecForProviderPrimaryUserAssignedIdentityIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecForProviderPrimaryUserAssignedIdentityIdSelectorPolicyResolveEnum>))]
    public V1beta1MSSQLServerSpecForProviderPrimaryUserAssignedIdentityIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLServerSpecForProviderPrimaryUserAssignedIdentityIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLServerSpecForProviderPrimaryUserAssignedIdentityIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1MSSQLServerSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLServerSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLServerSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1MSSQLServerSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1MSSQLServerSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLServerSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLServerSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1MSSQLServerSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLServerSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLServerSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1MSSQLServerSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1MSSQLServerSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLServerSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLServerSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1MSSQLServerSpecForProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLServerSpecForProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLServerSpecForProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecForProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicyResolutionEnum>))]
    public V1beta1MSSQLServerSpecForProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecForProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicyResolveEnum>))]
    public V1beta1MSSQLServerSpecForProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLServerSpecForProviderTransparentDataEncryptionKeyVaultKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLServerSpecForProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicy? Policy { get; set; }
}

public enum V1beta1MSSQLServerSpecForProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLServerSpecForProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLServerSpecForProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecForProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicyResolutionEnum>))]
    public V1beta1MSSQLServerSpecForProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecForProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicyResolveEnum>))]
    public V1beta1MSSQLServerSpecForProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLServerSpecForProviderTransparentDataEncryptionKeyVaultKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLServerSpecForProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1MSSQLServerSpecForProvider
{
    /// <summary>The administrator login name for the new server. Required unless azuread_authentication_only in the azuread_administrator block is true. When omitted, Azure will generate a default username which cannot be subsequently changed. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>The password associated with the administrator_login user. Needs to comply with Azure's Password Policy. Required unless azuread_authentication_only in the azuread_administrator block is true.</summary>
    [JsonPropertyName("administratorLoginPasswordSecretRef")]
    public V1beta1MSSQLServerSpecForProviderAdministratorLoginPasswordSecretRef? AdministratorLoginPasswordSecretRef { get; set; }

    /// <summary>An azuread_administrator block as defined below.</summary>
    [JsonPropertyName("azureadAdministrator")]
    public IList<V1beta1MSSQLServerSpecForProviderAzureadAdministrator>? AzureadAdministrator { get; set; }

    /// <summary>The connection policy the server will use. Possible values are Default, Proxy, and Redirect. Defaults to Default.</summary>
    [JsonPropertyName("connectionPolicy")]
    public string? ConnectionPolicy { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1MSSQLServerSpecForProviderIdentity>? Identity { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The Minimum TLS Version for all SQL Database and SQL Data Warehouse databases associated with the server. Valid values are: 1.0, 1.1 , 1.2 and Disabled. Defaults to 1.2.</summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>Whether outbound network traffic is restricted for this server. Defaults to false.</summary>
    [JsonPropertyName("outboundNetworkRestrictionEnabled")]
    public bool? OutboundNetworkRestrictionEnabled { get; set; }

    /// <summary>Specifies the primary user managed identity id. Required if type is UserAssigned and should be combined with identity_ids.</summary>
    [JsonPropertyName("primaryUserAssignedIdentityId")]
    public string? PrimaryUserAssignedIdentityId { get; set; }

    /// <summary>Reference to a UserAssignedIdentity in managedidentity to populate primaryUserAssignedIdentityId.</summary>
    [JsonPropertyName("primaryUserAssignedIdentityIdRef")]
    public V1beta1MSSQLServerSpecForProviderPrimaryUserAssignedIdentityIdRef? PrimaryUserAssignedIdentityIdRef { get; set; }

    /// <summary>Selector for a UserAssignedIdentity in managedidentity to populate primaryUserAssignedIdentityId.</summary>
    [JsonPropertyName("primaryUserAssignedIdentityIdSelector")]
    public V1beta1MSSQLServerSpecForProviderPrimaryUserAssignedIdentityIdSelector? PrimaryUserAssignedIdentityIdSelector { get; set; }

    /// <summary>Whether public network access is allowed for this server. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the resource group in which to create the Microsoft SQL Server. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1MSSQLServerSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1MSSQLServerSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The fully versioned Key Vault Key URL (e.g. 'https://<YourVaultName>.vault.azure.net/keys/<YourKeyName>/<YourKeyVersion>) to be used as the Customer Managed Key(CMK/BYOK) for the Transparent Data Encryption(TDE) layer.</summary>
    [JsonPropertyName("transparentDataEncryptionKeyVaultKeyId")]
    public string? TransparentDataEncryptionKeyVaultKeyId { get; set; }

    /// <summary>Reference to a Key in keyvault to populate transparentDataEncryptionKeyVaultKeyId.</summary>
    [JsonPropertyName("transparentDataEncryptionKeyVaultKeyIdRef")]
    public V1beta1MSSQLServerSpecForProviderTransparentDataEncryptionKeyVaultKeyIdRef? TransparentDataEncryptionKeyVaultKeyIdRef { get; set; }

    /// <summary>Selector for a Key in keyvault to populate transparentDataEncryptionKeyVaultKeyId.</summary>
    [JsonPropertyName("transparentDataEncryptionKeyVaultKeyIdSelector")]
    public V1beta1MSSQLServerSpecForProviderTransparentDataEncryptionKeyVaultKeyIdSelector? TransparentDataEncryptionKeyVaultKeyIdSelector { get; set; }

    /// <summary>The version for the new server. Valid values are: 2.0 (for v11 server) and 12.0 (for v12 server). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public enum V1beta1MSSQLServerSpecInitProviderAzureadAdministratorLoginUsernameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLServerSpecInitProviderAzureadAdministratorLoginUsernameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLServerSpecInitProviderAzureadAdministratorLoginUsernameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecInitProviderAzureadAdministratorLoginUsernameRefPolicyResolutionEnum>))]
    public V1beta1MSSQLServerSpecInitProviderAzureadAdministratorLoginUsernameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecInitProviderAzureadAdministratorLoginUsernameRefPolicyResolveEnum>))]
    public V1beta1MSSQLServerSpecInitProviderAzureadAdministratorLoginUsernameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLServerSpecInitProviderAzureadAdministratorLoginUsernameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLServerSpecInitProviderAzureadAdministratorLoginUsernameRefPolicy? Policy { get; set; }
}

public enum V1beta1MSSQLServerSpecInitProviderAzureadAdministratorLoginUsernameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLServerSpecInitProviderAzureadAdministratorLoginUsernameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLServerSpecInitProviderAzureadAdministratorLoginUsernameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecInitProviderAzureadAdministratorLoginUsernameSelectorPolicyResolutionEnum>))]
    public V1beta1MSSQLServerSpecInitProviderAzureadAdministratorLoginUsernameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecInitProviderAzureadAdministratorLoginUsernameSelectorPolicyResolveEnum>))]
    public V1beta1MSSQLServerSpecInitProviderAzureadAdministratorLoginUsernameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLServerSpecInitProviderAzureadAdministratorLoginUsernameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLServerSpecInitProviderAzureadAdministratorLoginUsernameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1MSSQLServerSpecInitProviderAzureadAdministratorObjectIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLServerSpecInitProviderAzureadAdministratorObjectIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLServerSpecInitProviderAzureadAdministratorObjectIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecInitProviderAzureadAdministratorObjectIdRefPolicyResolutionEnum>))]
    public V1beta1MSSQLServerSpecInitProviderAzureadAdministratorObjectIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecInitProviderAzureadAdministratorObjectIdRefPolicyResolveEnum>))]
    public V1beta1MSSQLServerSpecInitProviderAzureadAdministratorObjectIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLServerSpecInitProviderAzureadAdministratorObjectIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLServerSpecInitProviderAzureadAdministratorObjectIdRefPolicy? Policy { get; set; }
}

public enum V1beta1MSSQLServerSpecInitProviderAzureadAdministratorObjectIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLServerSpecInitProviderAzureadAdministratorObjectIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLServerSpecInitProviderAzureadAdministratorObjectIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecInitProviderAzureadAdministratorObjectIdSelectorPolicyResolutionEnum>))]
    public V1beta1MSSQLServerSpecInitProviderAzureadAdministratorObjectIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecInitProviderAzureadAdministratorObjectIdSelectorPolicyResolveEnum>))]
    public V1beta1MSSQLServerSpecInitProviderAzureadAdministratorObjectIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLServerSpecInitProviderAzureadAdministratorObjectIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLServerSpecInitProviderAzureadAdministratorObjectIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1MSSQLServerSpecInitProviderAzureadAdministrator
{
    /// <summary>Specifies whether only AD Users and administrators (e.g. azuread_administrator[0].login_username) can be used to login, or also local database users (e.g. administrator_login). When true, the administrator_login and administrator_login_password properties can be omitted.</summary>
    [JsonPropertyName("azureadAuthenticationOnly")]
    public bool? AzureadAuthenticationOnly { get; set; }

    /// <summary>The login username of the Azure AD Administrator of this SQL Server.</summary>
    [JsonPropertyName("loginUsername")]
    public string? LoginUsername { get; set; }

    /// <summary>Reference to a UserAssignedIdentity in managedidentity to populate loginUsername.</summary>
    [JsonPropertyName("loginUsernameRef")]
    public V1beta1MSSQLServerSpecInitProviderAzureadAdministratorLoginUsernameRef? LoginUsernameRef { get; set; }

    /// <summary>Selector for a UserAssignedIdentity in managedidentity to populate loginUsername.</summary>
    [JsonPropertyName("loginUsernameSelector")]
    public V1beta1MSSQLServerSpecInitProviderAzureadAdministratorLoginUsernameSelector? LoginUsernameSelector { get; set; }

    /// <summary>The object id of the Azure AD Administrator of this SQL Server.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>Reference to a UserAssignedIdentity in managedidentity to populate objectId.</summary>
    [JsonPropertyName("objectIdRef")]
    public V1beta1MSSQLServerSpecInitProviderAzureadAdministratorObjectIdRef? ObjectIdRef { get; set; }

    /// <summary>Selector for a UserAssignedIdentity in managedidentity to populate objectId.</summary>
    [JsonPropertyName("objectIdSelector")]
    public V1beta1MSSQLServerSpecInitProviderAzureadAdministratorObjectIdSelector? ObjectIdSelector { get; set; }

    /// <summary>The tenant id of the Azure AD Administrator of this SQL Server.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

public partial class V1beta1MSSQLServerSpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this SQL Server.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this SQL Server. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public enum V1beta1MSSQLServerSpecInitProviderPrimaryUserAssignedIdentityIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLServerSpecInitProviderPrimaryUserAssignedIdentityIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLServerSpecInitProviderPrimaryUserAssignedIdentityIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecInitProviderPrimaryUserAssignedIdentityIdRefPolicyResolutionEnum>))]
    public V1beta1MSSQLServerSpecInitProviderPrimaryUserAssignedIdentityIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecInitProviderPrimaryUserAssignedIdentityIdRefPolicyResolveEnum>))]
    public V1beta1MSSQLServerSpecInitProviderPrimaryUserAssignedIdentityIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLServerSpecInitProviderPrimaryUserAssignedIdentityIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLServerSpecInitProviderPrimaryUserAssignedIdentityIdRefPolicy? Policy { get; set; }
}

public enum V1beta1MSSQLServerSpecInitProviderPrimaryUserAssignedIdentityIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLServerSpecInitProviderPrimaryUserAssignedIdentityIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLServerSpecInitProviderPrimaryUserAssignedIdentityIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecInitProviderPrimaryUserAssignedIdentityIdSelectorPolicyResolutionEnum>))]
    public V1beta1MSSQLServerSpecInitProviderPrimaryUserAssignedIdentityIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecInitProviderPrimaryUserAssignedIdentityIdSelectorPolicyResolveEnum>))]
    public V1beta1MSSQLServerSpecInitProviderPrimaryUserAssignedIdentityIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLServerSpecInitProviderPrimaryUserAssignedIdentityIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLServerSpecInitProviderPrimaryUserAssignedIdentityIdSelectorPolicy? Policy { get; set; }
}

public enum V1beta1MSSQLServerSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLServerSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLServerSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicyResolutionEnum>))]
    public V1beta1MSSQLServerSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicyResolveEnum>))]
    public V1beta1MSSQLServerSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLServerSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLServerSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdRefPolicy? Policy { get; set; }
}

public enum V1beta1MSSQLServerSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLServerSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLServerSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicyResolutionEnum>))]
    public V1beta1MSSQLServerSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicyResolveEnum>))]
    public V1beta1MSSQLServerSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLServerSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLServerSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1MSSQLServerSpecInitProvider
{
    /// <summary>The administrator login name for the new server. Required unless azuread_authentication_only in the azuread_administrator block is true. When omitted, Azure will generate a default username which cannot be subsequently changed. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>An azuread_administrator block as defined below.</summary>
    [JsonPropertyName("azureadAdministrator")]
    public IList<V1beta1MSSQLServerSpecInitProviderAzureadAdministrator>? AzureadAdministrator { get; set; }

    /// <summary>The connection policy the server will use. Possible values are Default, Proxy, and Redirect. Defaults to Default.</summary>
    [JsonPropertyName("connectionPolicy")]
    public string? ConnectionPolicy { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1MSSQLServerSpecInitProviderIdentity>? Identity { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The Minimum TLS Version for all SQL Database and SQL Data Warehouse databases associated with the server. Valid values are: 1.0, 1.1 , 1.2 and Disabled. Defaults to 1.2.</summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>Whether outbound network traffic is restricted for this server. Defaults to false.</summary>
    [JsonPropertyName("outboundNetworkRestrictionEnabled")]
    public bool? OutboundNetworkRestrictionEnabled { get; set; }

    /// <summary>Specifies the primary user managed identity id. Required if type is UserAssigned and should be combined with identity_ids.</summary>
    [JsonPropertyName("primaryUserAssignedIdentityId")]
    public string? PrimaryUserAssignedIdentityId { get; set; }

    /// <summary>Reference to a UserAssignedIdentity in managedidentity to populate primaryUserAssignedIdentityId.</summary>
    [JsonPropertyName("primaryUserAssignedIdentityIdRef")]
    public V1beta1MSSQLServerSpecInitProviderPrimaryUserAssignedIdentityIdRef? PrimaryUserAssignedIdentityIdRef { get; set; }

    /// <summary>Selector for a UserAssignedIdentity in managedidentity to populate primaryUserAssignedIdentityId.</summary>
    [JsonPropertyName("primaryUserAssignedIdentityIdSelector")]
    public V1beta1MSSQLServerSpecInitProviderPrimaryUserAssignedIdentityIdSelector? PrimaryUserAssignedIdentityIdSelector { get; set; }

    /// <summary>Whether public network access is allowed for this server. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The fully versioned Key Vault Key URL (e.g. 'https://<YourVaultName>.vault.azure.net/keys/<YourKeyName>/<YourKeyVersion>) to be used as the Customer Managed Key(CMK/BYOK) for the Transparent Data Encryption(TDE) layer.</summary>
    [JsonPropertyName("transparentDataEncryptionKeyVaultKeyId")]
    public string? TransparentDataEncryptionKeyVaultKeyId { get; set; }

    /// <summary>Reference to a Key in keyvault to populate transparentDataEncryptionKeyVaultKeyId.</summary>
    [JsonPropertyName("transparentDataEncryptionKeyVaultKeyIdRef")]
    public V1beta1MSSQLServerSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdRef? TransparentDataEncryptionKeyVaultKeyIdRef { get; set; }

    /// <summary>Selector for a Key in keyvault to populate transparentDataEncryptionKeyVaultKeyId.</summary>
    [JsonPropertyName("transparentDataEncryptionKeyVaultKeyIdSelector")]
    public V1beta1MSSQLServerSpecInitProviderTransparentDataEncryptionKeyVaultKeyIdSelector? TransparentDataEncryptionKeyVaultKeyIdSelector { get; set; }

    /// <summary>The version for the new server. Valid values are: 2.0 (for v11 server) and 12.0 (for v12 server). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public enum V1beta1MSSQLServerSpecManagementPoliciesEnum
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

public enum V1beta1MSSQLServerSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLServerSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLServerSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1MSSQLServerSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1MSSQLServerSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLServerSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLServerSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1MSSQLServerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1MSSQLServerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1MSSQLServerSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1MSSQLServerSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1MSSQLServerSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1MSSQLServerSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLServerSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1MSSQLServerSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1MSSQLServerSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1MSSQLServerSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1MSSQLServerSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1MSSQLServerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1MSSQLServerSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1MSSQLServerSpecDeletionPolicyEnum>))]
    public V1beta1MSSQLServerSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1MSSQLServerSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1MSSQLServerSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1MSSQLServerSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MSSQLServerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1MSSQLServerSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MSSQLServerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1MSSQLServerStatusAtProviderAzureadAdministrator
{
    /// <summary>Specifies whether only AD Users and administrators (e.g. azuread_administrator[0].login_username) can be used to login, or also local database users (e.g. administrator_login). When true, the administrator_login and administrator_login_password properties can be omitted.</summary>
    [JsonPropertyName("azureadAuthenticationOnly")]
    public bool? AzureadAuthenticationOnly { get; set; }

    /// <summary>The login username of the Azure AD Administrator of this SQL Server.</summary>
    [JsonPropertyName("loginUsername")]
    public string? LoginUsername { get; set; }

    /// <summary>The object id of the Azure AD Administrator of this SQL Server.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>The tenant id of the Azure AD Administrator of this SQL Server.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

public partial class V1beta1MSSQLServerStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this SQL Server.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID for the Service Principal associated with the Identity of this SQL Server.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID for the Service Principal associated with the Identity of this SQL Server.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this SQL Server. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1beta1MSSQLServerStatusAtProvider
{
    /// <summary>The administrator login name for the new server. Required unless azuread_authentication_only in the azuread_administrator block is true. When omitted, Azure will generate a default username which cannot be subsequently changed. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>An azuread_administrator block as defined below.</summary>
    [JsonPropertyName("azureadAdministrator")]
    public IList<V1beta1MSSQLServerStatusAtProviderAzureadAdministrator>? AzureadAdministrator { get; set; }

    /// <summary>The connection policy the server will use. Possible values are Default, Proxy, and Redirect. Defaults to Default.</summary>
    [JsonPropertyName("connectionPolicy")]
    public string? ConnectionPolicy { get; set; }

    /// <summary>The fully qualified domain name of the Azure SQL Server (e.g. myServerName.database.windows.net)</summary>
    [JsonPropertyName("fullyQualifiedDomainName")]
    public string? FullyQualifiedDomainName { get; set; }

    /// <summary>the Microsoft SQL Server ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1MSSQLServerStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The Minimum TLS Version for all SQL Database and SQL Data Warehouse databases associated with the server. Valid values are: 1.0, 1.1 , 1.2 and Disabled. Defaults to 1.2.</summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>Whether outbound network traffic is restricted for this server. Defaults to false.</summary>
    [JsonPropertyName("outboundNetworkRestrictionEnabled")]
    public bool? OutboundNetworkRestrictionEnabled { get; set; }

    /// <summary>Specifies the primary user managed identity id. Required if type is UserAssigned and should be combined with identity_ids.</summary>
    [JsonPropertyName("primaryUserAssignedIdentityId")]
    public string? PrimaryUserAssignedIdentityId { get; set; }

    /// <summary>Whether public network access is allowed for this server. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the resource group in which to create the Microsoft SQL Server. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A list of dropped restorable database IDs on the server.</summary>
    [JsonPropertyName("restorableDroppedDatabaseIds")]
    public IList<string>? RestorableDroppedDatabaseIds { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The fully versioned Key Vault Key URL (e.g. 'https://<YourVaultName>.vault.azure.net/keys/<YourKeyName>/<YourKeyVersion>) to be used as the Customer Managed Key(CMK/BYOK) for the Transparent Data Encryption(TDE) layer.</summary>
    [JsonPropertyName("transparentDataEncryptionKeyVaultKeyId")]
    public string? TransparentDataEncryptionKeyVaultKeyId { get; set; }

    /// <summary>The version for the new server. Valid values are: 2.0 (for v11 server) and 12.0 (for v12 server). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public partial class V1beta1MSSQLServerStatusConditions
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

public partial class V1beta1MSSQLServerStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1MSSQLServerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MSSQLServerStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MSSQLServer : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MSSQLServerSpec>, IStatus<V1beta1MSSQLServerStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MSSQLServer";
    public const string KubeGroup = "sql.azure.upbound.io";
    public const string KubePluralName = "mssqlservers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MSSQLServerSpec defines the desired state of MSSQLServer</summary>
    [JsonPropertyName("spec")]
    public V1beta1MSSQLServerSpec Spec { get; set; }

    /// <summary>MSSQLServerStatus defines the observed state of MSSQLServer.</summary>
    [JsonPropertyName("status")]
    public V1beta1MSSQLServerStatus? Status { get; set; }
}