using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dbforpostgresql.azure.upbound.io;
/// <summary>The Password associated with the administrator_login for the PostgreSQL Flexible Server. Required when create_mode is Default and authentication.password_auth_enabled is true. Password for the master DB user. If you set autoGeneratePassword to true, the Secret referenced here will be created or updated with generated password if it does not already contain one.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecForProviderAdministratorPasswordSecretRef
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecForProviderAuthentication
{
    /// <summary>Whether or not Active Directory authentication is allowed to access the PostgreSQL Flexible Server. Defaults to false.</summary>
    [JsonPropertyName("activeDirectoryAuthEnabled")]
    public bool? ActiveDirectoryAuthEnabled { get; set; }

    /// <summary>Whether or not password authentication is allowed to access the PostgreSQL Flexible Server. Defaults to true.</summary>
    [JsonPropertyName("passwordAuthEnabled")]
    public bool? PasswordAuthEnabled { get; set; }

    /// <summary>The Tenant ID of the Azure Active Directory which is used by the Active Directory authentication. active_directory_auth_enabled must be set to true.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecForProviderCustomerManagedKey
{
    /// <summary>The ID of the geo backup Key Vault Key. It can't cross region and need Customer Managed Key in same region as geo backup.</summary>
    [JsonPropertyName("geoBackupKeyVaultKeyId")]
    public string? GeoBackupKeyVaultKeyId { get; set; }

    /// <summary>The geo backup user managed identity id for a Customer Managed Key. Should be added with identity_ids. It can't cross region and need identity in same region as geo backup.</summary>
    [JsonPropertyName("geoBackupUserAssignedIdentityId")]
    public string? GeoBackupUserAssignedIdentityId { get; set; }

    /// <summary>The ID of the Key Vault Key.</summary>
    [JsonPropertyName("keyVaultKeyId")]
    public string? KeyVaultKeyId { get; set; }

    /// <summary>Specifies the primary user managed identity id for a Customer Managed Key. Should be added with identity_ids.</summary>
    [JsonPropertyName("primaryUserAssignedIdentityId")]
    public string? PrimaryUserAssignedIdentityId { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecForProviderDelegatedSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate delegatedSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecForProviderDelegatedSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlexibleServerSpecForProviderDelegatedSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecForProviderDelegatedSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate delegatedSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecForProviderDelegatedSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlexibleServerSpecForProviderDelegatedSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecForProviderHighAvailability
{
    /// <summary>The high availability mode for the PostgreSQL Flexible Server. Possible value are SameZone or ZoneRedundant.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Specifies the Availability Zone in which the standby Flexible Server should be located.</summary>
    [JsonPropertyName("standbyAvailabilityZone")]
    public string? StandbyAvailabilityZone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecForProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this PostgreSQL Flexible Server. Required if used together with customer_managed_key block.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this PostgreSQL Flexible Server. The only possible value is UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecForProviderMaintenanceWindow
{
    /// <summary>The day of week for maintenance window, where the week starts on a Sunday, i.e. Sunday = 0, Monday = 1. Defaults to 0.</summary>
    [JsonPropertyName("dayOfWeek")]
    public double? DayOfWeek { get; set; }

    /// <summary>The start hour for maintenance window. Defaults to 0.</summary>
    [JsonPropertyName("startHour")]
    public double? StartHour { get; set; }

    /// <summary>The start minute for maintenance window. Defaults to 0.</summary>
    [JsonPropertyName("startMinute")]
    public double? StartMinute { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecForProviderPrivateDnsZoneIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a PrivateDNSZone in network to populate privateDnsZoneId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecForProviderPrivateDnsZoneIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlexibleServerSpecForProviderPrivateDnsZoneIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecForProviderPrivateDnsZoneIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a PrivateDNSZone in network to populate privateDnsZoneId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecForProviderPrivateDnsZoneIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlexibleServerSpecForProviderPrivateDnsZoneIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1FlexibleServerSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlexibleServerSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1FlexibleServerSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlexibleServerSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecForProvider
{
    /// <summary>The Administrator login for the PostgreSQL Flexible Server. Required when create_mode is Default and authentication.password_auth_enabled is true.</summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>The Password associated with the administrator_login for the PostgreSQL Flexible Server. Required when create_mode is Default and authentication.password_auth_enabled is true. Password for the master DB user. If you set autoGeneratePassword to true, the Secret referenced here will be created or updated with generated password if it does not already contain one.</summary>
    [JsonPropertyName("administratorPasswordSecretRef")]
    public V1beta1FlexibleServerSpecForProviderAdministratorPasswordSecretRef? AdministratorPasswordSecretRef { get; set; }

    /// <summary>An authentication block as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta1FlexibleServerSpecForProviderAuthentication>? Authentication { get; set; }

    /// <summary>If true, the password will be auto-generated and stored in the Secret referenced by the administratorPasswordSecretRef field.</summary>
    [JsonPropertyName("autoGeneratePassword")]
    public bool? AutoGeneratePassword { get; set; }

    /// <summary>Is the storage auto grow for PostgreSQL Flexible Server enabled? Defaults to false.</summary>
    [JsonPropertyName("autoGrowEnabled")]
    public bool? AutoGrowEnabled { get; set; }

    /// <summary>The backup retention days for the PostgreSQL Flexible Server. Possible values are between 7 and 35 days.</summary>
    [JsonPropertyName("backupRetentionDays")]
    public double? BackupRetentionDays { get; set; }

    /// <summary>The creation mode which can be used to restore or replicate existing servers. Possible values are Default, PointInTimeRestore, Replica and Update.</summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>A customer_managed_key block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("customerManagedKey")]
    public IList<V1beta1FlexibleServerSpecForProviderCustomerManagedKey>? CustomerManagedKey { get; set; }

    /// <summary>The ID of the virtual network subnet to create the PostgreSQL Flexible Server. The provided subnet should not have any other resource deployed in it and this subnet will be delegated to the PostgreSQL Flexible Server, if not already delegated. Changing this forces a new PostgreSQL Flexible Server to be created.</summary>
    [JsonPropertyName("delegatedSubnetId")]
    public string? DelegatedSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate delegatedSubnetId.</summary>
    [JsonPropertyName("delegatedSubnetIdRef")]
    public V1beta1FlexibleServerSpecForProviderDelegatedSubnetIdRef? DelegatedSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate delegatedSubnetId.</summary>
    [JsonPropertyName("delegatedSubnetIdSelector")]
    public V1beta1FlexibleServerSpecForProviderDelegatedSubnetIdSelector? DelegatedSubnetIdSelector { get; set; }

    /// <summary>Is Geo-Redundant backup enabled on the PostgreSQL Flexible Server. Defaults to false. Changing this forces a new PostgreSQL Flexible Server to be created.</summary>
    [JsonPropertyName("geoRedundantBackupEnabled")]
    public bool? GeoRedundantBackupEnabled { get; set; }

    /// <summary>A high_availability block as defined below.</summary>
    [JsonPropertyName("highAvailability")]
    public IList<V1beta1FlexibleServerSpecForProviderHighAvailability>? HighAvailability { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1FlexibleServerSpecForProviderIdentity>? Identity { get; set; }

    /// <summary>The Azure Region where the PostgreSQL Flexible Server should exist. Changing this forces a new PostgreSQL Flexible Server to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A maintenance_window block as defined below.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public IList<V1beta1FlexibleServerSpecForProviderMaintenanceWindow>? MaintenanceWindow { get; set; }

    /// <summary>The point in time to restore from source_server_id when create_mode is PointInTimeRestore. Changing this forces a new PostgreSQL Flexible Server to be created.</summary>
    [JsonPropertyName("pointInTimeRestoreTimeInUtc")]
    public string? PointInTimeRestoreTimeInUtc { get; set; }

    /// <summary>The ID of the private DNS zone to create the PostgreSQL Flexible Server.</summary>
    [JsonPropertyName("privateDnsZoneId")]
    public string? PrivateDnsZoneId { get; set; }

    /// <summary>Reference to a PrivateDNSZone in network to populate privateDnsZoneId.</summary>
    [JsonPropertyName("privateDnsZoneIdRef")]
    public V1beta1FlexibleServerSpecForProviderPrivateDnsZoneIdRef? PrivateDnsZoneIdRef { get; set; }

    /// <summary>Selector for a PrivateDNSZone in network to populate privateDnsZoneId.</summary>
    [JsonPropertyName("privateDnsZoneIdSelector")]
    public V1beta1FlexibleServerSpecForProviderPrivateDnsZoneIdSelector? PrivateDnsZoneIdSelector { get; set; }

    /// <summary>Specifies whether this PostgreSQL Flexible Server is publicly accessible. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The replication role for the PostgreSQL Flexible Server. Possible value is None.</summary>
    [JsonPropertyName("replicationRole")]
    public string? ReplicationRole { get; set; }

    /// <summary>The name of the Resource Group where the PostgreSQL Flexible Server should exist. Changing this forces a new PostgreSQL Flexible Server to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1FlexibleServerSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1FlexibleServerSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The SKU Name for the PostgreSQL Flexible Server. The name of the SKU, follows the tier + name pattern (e.g. B_Standard_B1ms, GP_Standard_D2s_v3, MO_Standard_E4s_v3).</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>The resource ID of the source PostgreSQL Flexible Server to be restored. Required when create_mode is PointInTimeRestore or Replica. Changing this forces a new PostgreSQL Flexible Server to be created.</summary>
    [JsonPropertyName("sourceServerId")]
    public string? SourceServerId { get; set; }

    /// <summary>The max storage allowed for the PostgreSQL Flexible Server. Possible values are 32768, 65536, 131072, 262144, 524288, 1048576, 2097152, 4193280, 4194304, 8388608, 16777216 and 33553408.</summary>
    [JsonPropertyName("storageMb")]
    public double? StorageMb { get; set; }

    /// <summary>The name of storage performance tier for IOPS of the PostgreSQL Flexible Server. Possible values are P4, P6, P10, P15,P20, P30,P40, P50,P60, P70 or P80. Default value is dependant on the storage_mb value. Please see the storage_tier defaults based on storage_mb table below.</summary>
    [JsonPropertyName("storageTier")]
    public string? StorageTier { get; set; }

    /// <summary>A mapping of tags which should be assigned to the PostgreSQL Flexible Server.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The version of PostgreSQL Flexible Server to use. Possible values are 11,12, 13, 14, 15 and 16. Required when create_mode is Default.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>Specifies the Availability Zone in which the PostgreSQL Flexible Server should be located.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>The Password associated with the administrator_login for the PostgreSQL Flexible Server. Required when create_mode is Default and authentication.password_auth_enabled is true. Password for the master DB user. If you set autoGeneratePassword to true, the Secret referenced here will be created or updated with generated password if it does not already contain one.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecInitProviderAdministratorPasswordSecretRef
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecInitProviderAuthentication
{
    /// <summary>Whether or not Active Directory authentication is allowed to access the PostgreSQL Flexible Server. Defaults to false.</summary>
    [JsonPropertyName("activeDirectoryAuthEnabled")]
    public bool? ActiveDirectoryAuthEnabled { get; set; }

    /// <summary>Whether or not password authentication is allowed to access the PostgreSQL Flexible Server. Defaults to true.</summary>
    [JsonPropertyName("passwordAuthEnabled")]
    public bool? PasswordAuthEnabled { get; set; }

    /// <summary>The Tenant ID of the Azure Active Directory which is used by the Active Directory authentication. active_directory_auth_enabled must be set to true.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecInitProviderCustomerManagedKey
{
    /// <summary>The ID of the geo backup Key Vault Key. It can't cross region and need Customer Managed Key in same region as geo backup.</summary>
    [JsonPropertyName("geoBackupKeyVaultKeyId")]
    public string? GeoBackupKeyVaultKeyId { get; set; }

    /// <summary>The geo backup user managed identity id for a Customer Managed Key. Should be added with identity_ids. It can't cross region and need identity in same region as geo backup.</summary>
    [JsonPropertyName("geoBackupUserAssignedIdentityId")]
    public string? GeoBackupUserAssignedIdentityId { get; set; }

    /// <summary>The ID of the Key Vault Key.</summary>
    [JsonPropertyName("keyVaultKeyId")]
    public string? KeyVaultKeyId { get; set; }

    /// <summary>Specifies the primary user managed identity id for a Customer Managed Key. Should be added with identity_ids.</summary>
    [JsonPropertyName("primaryUserAssignedIdentityId")]
    public string? PrimaryUserAssignedIdentityId { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecInitProviderDelegatedSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate delegatedSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecInitProviderDelegatedSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlexibleServerSpecInitProviderDelegatedSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecInitProviderDelegatedSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate delegatedSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecInitProviderDelegatedSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlexibleServerSpecInitProviderDelegatedSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecInitProviderHighAvailability
{
    /// <summary>The high availability mode for the PostgreSQL Flexible Server. Possible value are SameZone or ZoneRedundant.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Specifies the Availability Zone in which the standby Flexible Server should be located.</summary>
    [JsonPropertyName("standbyAvailabilityZone")]
    public string? StandbyAvailabilityZone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecInitProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this PostgreSQL Flexible Server. Required if used together with customer_managed_key block.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this PostgreSQL Flexible Server. The only possible value is UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecInitProviderMaintenanceWindow
{
    /// <summary>The day of week for maintenance window, where the week starts on a Sunday, i.e. Sunday = 0, Monday = 1. Defaults to 0.</summary>
    [JsonPropertyName("dayOfWeek")]
    public double? DayOfWeek { get; set; }

    /// <summary>The start hour for maintenance window. Defaults to 0.</summary>
    [JsonPropertyName("startHour")]
    public double? StartHour { get; set; }

    /// <summary>The start minute for maintenance window. Defaults to 0.</summary>
    [JsonPropertyName("startMinute")]
    public double? StartMinute { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecInitProviderPrivateDnsZoneIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a PrivateDNSZone in network to populate privateDnsZoneId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecInitProviderPrivateDnsZoneIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlexibleServerSpecInitProviderPrivateDnsZoneIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecInitProviderPrivateDnsZoneIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a PrivateDNSZone in network to populate privateDnsZoneId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecInitProviderPrivateDnsZoneIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlexibleServerSpecInitProviderPrivateDnsZoneIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecInitProvider
{
    /// <summary>The Administrator login for the PostgreSQL Flexible Server. Required when create_mode is Default and authentication.password_auth_enabled is true.</summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>The Password associated with the administrator_login for the PostgreSQL Flexible Server. Required when create_mode is Default and authentication.password_auth_enabled is true. Password for the master DB user. If you set autoGeneratePassword to true, the Secret referenced here will be created or updated with generated password if it does not already contain one.</summary>
    [JsonPropertyName("administratorPasswordSecretRef")]
    public V1beta1FlexibleServerSpecInitProviderAdministratorPasswordSecretRef? AdministratorPasswordSecretRef { get; set; }

    /// <summary>An authentication block as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta1FlexibleServerSpecInitProviderAuthentication>? Authentication { get; set; }

    /// <summary>Is the storage auto grow for PostgreSQL Flexible Server enabled? Defaults to false.</summary>
    [JsonPropertyName("autoGrowEnabled")]
    public bool? AutoGrowEnabled { get; set; }

    /// <summary>The backup retention days for the PostgreSQL Flexible Server. Possible values are between 7 and 35 days.</summary>
    [JsonPropertyName("backupRetentionDays")]
    public double? BackupRetentionDays { get; set; }

    /// <summary>The creation mode which can be used to restore or replicate existing servers. Possible values are Default, PointInTimeRestore, Replica and Update.</summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>A customer_managed_key block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("customerManagedKey")]
    public IList<V1beta1FlexibleServerSpecInitProviderCustomerManagedKey>? CustomerManagedKey { get; set; }

    /// <summary>The ID of the virtual network subnet to create the PostgreSQL Flexible Server. The provided subnet should not have any other resource deployed in it and this subnet will be delegated to the PostgreSQL Flexible Server, if not already delegated. Changing this forces a new PostgreSQL Flexible Server to be created.</summary>
    [JsonPropertyName("delegatedSubnetId")]
    public string? DelegatedSubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate delegatedSubnetId.</summary>
    [JsonPropertyName("delegatedSubnetIdRef")]
    public V1beta1FlexibleServerSpecInitProviderDelegatedSubnetIdRef? DelegatedSubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate delegatedSubnetId.</summary>
    [JsonPropertyName("delegatedSubnetIdSelector")]
    public V1beta1FlexibleServerSpecInitProviderDelegatedSubnetIdSelector? DelegatedSubnetIdSelector { get; set; }

    /// <summary>Is Geo-Redundant backup enabled on the PostgreSQL Flexible Server. Defaults to false. Changing this forces a new PostgreSQL Flexible Server to be created.</summary>
    [JsonPropertyName("geoRedundantBackupEnabled")]
    public bool? GeoRedundantBackupEnabled { get; set; }

    /// <summary>A high_availability block as defined below.</summary>
    [JsonPropertyName("highAvailability")]
    public IList<V1beta1FlexibleServerSpecInitProviderHighAvailability>? HighAvailability { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1FlexibleServerSpecInitProviderIdentity>? Identity { get; set; }

    /// <summary>The Azure Region where the PostgreSQL Flexible Server should exist. Changing this forces a new PostgreSQL Flexible Server to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A maintenance_window block as defined below.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public IList<V1beta1FlexibleServerSpecInitProviderMaintenanceWindow>? MaintenanceWindow { get; set; }

    /// <summary>The point in time to restore from source_server_id when create_mode is PointInTimeRestore. Changing this forces a new PostgreSQL Flexible Server to be created.</summary>
    [JsonPropertyName("pointInTimeRestoreTimeInUtc")]
    public string? PointInTimeRestoreTimeInUtc { get; set; }

    /// <summary>The ID of the private DNS zone to create the PostgreSQL Flexible Server.</summary>
    [JsonPropertyName("privateDnsZoneId")]
    public string? PrivateDnsZoneId { get; set; }

    /// <summary>Reference to a PrivateDNSZone in network to populate privateDnsZoneId.</summary>
    [JsonPropertyName("privateDnsZoneIdRef")]
    public V1beta1FlexibleServerSpecInitProviderPrivateDnsZoneIdRef? PrivateDnsZoneIdRef { get; set; }

    /// <summary>Selector for a PrivateDNSZone in network to populate privateDnsZoneId.</summary>
    [JsonPropertyName("privateDnsZoneIdSelector")]
    public V1beta1FlexibleServerSpecInitProviderPrivateDnsZoneIdSelector? PrivateDnsZoneIdSelector { get; set; }

    /// <summary>Specifies whether this PostgreSQL Flexible Server is publicly accessible. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The replication role for the PostgreSQL Flexible Server. Possible value is None.</summary>
    [JsonPropertyName("replicationRole")]
    public string? ReplicationRole { get; set; }

    /// <summary>The SKU Name for the PostgreSQL Flexible Server. The name of the SKU, follows the tier + name pattern (e.g. B_Standard_B1ms, GP_Standard_D2s_v3, MO_Standard_E4s_v3).</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>The resource ID of the source PostgreSQL Flexible Server to be restored. Required when create_mode is PointInTimeRestore or Replica. Changing this forces a new PostgreSQL Flexible Server to be created.</summary>
    [JsonPropertyName("sourceServerId")]
    public string? SourceServerId { get; set; }

    /// <summary>The max storage allowed for the PostgreSQL Flexible Server. Possible values are 32768, 65536, 131072, 262144, 524288, 1048576, 2097152, 4193280, 4194304, 8388608, 16777216 and 33553408.</summary>
    [JsonPropertyName("storageMb")]
    public double? StorageMb { get; set; }

    /// <summary>The name of storage performance tier for IOPS of the PostgreSQL Flexible Server. Possible values are P4, P6, P10, P15,P20, P30,P40, P50,P60, P70 or P80. Default value is dependant on the storage_mb value. Please see the storage_tier defaults based on storage_mb table below.</summary>
    [JsonPropertyName("storageTier")]
    public string? StorageTier { get; set; }

    /// <summary>A mapping of tags which should be assigned to the PostgreSQL Flexible Server.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The version of PostgreSQL Flexible Server to use. Possible values are 11,12, 13, 14, 15 and 16. Required when create_mode is Default.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>Specifies the Availability Zone in which the PostgreSQL Flexible Server should be located.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlexibleServerSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlexibleServerSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecPublishConnectionDetailsToMetadata
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1FlexibleServerSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1FlexibleServerSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>FlexibleServerSpec defines the desired state of FlexibleServer</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FlexibleServerSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FlexibleServerSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FlexibleServerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1FlexibleServerSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FlexibleServerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerStatusAtProviderAuthentication
{
    /// <summary>Whether or not Active Directory authentication is allowed to access the PostgreSQL Flexible Server. Defaults to false.</summary>
    [JsonPropertyName("activeDirectoryAuthEnabled")]
    public bool? ActiveDirectoryAuthEnabled { get; set; }

    /// <summary>Whether or not password authentication is allowed to access the PostgreSQL Flexible Server. Defaults to true.</summary>
    [JsonPropertyName("passwordAuthEnabled")]
    public bool? PasswordAuthEnabled { get; set; }

    /// <summary>The Tenant ID of the Azure Active Directory which is used by the Active Directory authentication. active_directory_auth_enabled must be set to true.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerStatusAtProviderCustomerManagedKey
{
    /// <summary>The ID of the geo backup Key Vault Key. It can't cross region and need Customer Managed Key in same region as geo backup.</summary>
    [JsonPropertyName("geoBackupKeyVaultKeyId")]
    public string? GeoBackupKeyVaultKeyId { get; set; }

    /// <summary>The geo backup user managed identity id for a Customer Managed Key. Should be added with identity_ids. It can't cross region and need identity in same region as geo backup.</summary>
    [JsonPropertyName("geoBackupUserAssignedIdentityId")]
    public string? GeoBackupUserAssignedIdentityId { get; set; }

    /// <summary>The ID of the Key Vault Key.</summary>
    [JsonPropertyName("keyVaultKeyId")]
    public string? KeyVaultKeyId { get; set; }

    /// <summary>Specifies the primary user managed identity id for a Customer Managed Key. Should be added with identity_ids.</summary>
    [JsonPropertyName("primaryUserAssignedIdentityId")]
    public string? PrimaryUserAssignedIdentityId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerStatusAtProviderHighAvailability
{
    /// <summary>The high availability mode for the PostgreSQL Flexible Server. Possible value are SameZone or ZoneRedundant.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Specifies the Availability Zone in which the standby Flexible Server should be located.</summary>
    [JsonPropertyName("standbyAvailabilityZone")]
    public string? StandbyAvailabilityZone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerStatusAtProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this PostgreSQL Flexible Server. Required if used together with customer_managed_key block.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this PostgreSQL Flexible Server. The only possible value is UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerStatusAtProviderMaintenanceWindow
{
    /// <summary>The day of week for maintenance window, where the week starts on a Sunday, i.e. Sunday = 0, Monday = 1. Defaults to 0.</summary>
    [JsonPropertyName("dayOfWeek")]
    public double? DayOfWeek { get; set; }

    /// <summary>The start hour for maintenance window. Defaults to 0.</summary>
    [JsonPropertyName("startHour")]
    public double? StartHour { get; set; }

    /// <summary>The start minute for maintenance window. Defaults to 0.</summary>
    [JsonPropertyName("startMinute")]
    public double? StartMinute { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerStatusAtProvider
{
    /// <summary>The Administrator login for the PostgreSQL Flexible Server. Required when create_mode is Default and authentication.password_auth_enabled is true.</summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>An authentication block as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta1FlexibleServerStatusAtProviderAuthentication>? Authentication { get; set; }

    /// <summary>Is the storage auto grow for PostgreSQL Flexible Server enabled? Defaults to false.</summary>
    [JsonPropertyName("autoGrowEnabled")]
    public bool? AutoGrowEnabled { get; set; }

    /// <summary>The backup retention days for the PostgreSQL Flexible Server. Possible values are between 7 and 35 days.</summary>
    [JsonPropertyName("backupRetentionDays")]
    public double? BackupRetentionDays { get; set; }

    /// <summary>The creation mode which can be used to restore or replicate existing servers. Possible values are Default, PointInTimeRestore, Replica and Update.</summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>A customer_managed_key block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("customerManagedKey")]
    public IList<V1beta1FlexibleServerStatusAtProviderCustomerManagedKey>? CustomerManagedKey { get; set; }

    /// <summary>The ID of the virtual network subnet to create the PostgreSQL Flexible Server. The provided subnet should not have any other resource deployed in it and this subnet will be delegated to the PostgreSQL Flexible Server, if not already delegated. Changing this forces a new PostgreSQL Flexible Server to be created.</summary>
    [JsonPropertyName("delegatedSubnetId")]
    public string? DelegatedSubnetId { get; set; }

    /// <summary>The FQDN of the PostgreSQL Flexible Server.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>Is Geo-Redundant backup enabled on the PostgreSQL Flexible Server. Defaults to false. Changing this forces a new PostgreSQL Flexible Server to be created.</summary>
    [JsonPropertyName("geoRedundantBackupEnabled")]
    public bool? GeoRedundantBackupEnabled { get; set; }

    /// <summary>A high_availability block as defined below.</summary>
    [JsonPropertyName("highAvailability")]
    public IList<V1beta1FlexibleServerStatusAtProviderHighAvailability>? HighAvailability { get; set; }

    /// <summary>The ID of the PostgreSQL Flexible Server.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1FlexibleServerStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>The Azure Region where the PostgreSQL Flexible Server should exist. Changing this forces a new PostgreSQL Flexible Server to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A maintenance_window block as defined below.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public IList<V1beta1FlexibleServerStatusAtProviderMaintenanceWindow>? MaintenanceWindow { get; set; }

    /// <summary>The point in time to restore from source_server_id when create_mode is PointInTimeRestore. Changing this forces a new PostgreSQL Flexible Server to be created.</summary>
    [JsonPropertyName("pointInTimeRestoreTimeInUtc")]
    public string? PointInTimeRestoreTimeInUtc { get; set; }

    /// <summary>The ID of the private DNS zone to create the PostgreSQL Flexible Server.</summary>
    [JsonPropertyName("privateDnsZoneId")]
    public string? PrivateDnsZoneId { get; set; }

    /// <summary>Is public network access enabled?</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The replication role for the PostgreSQL Flexible Server. Possible value is None.</summary>
    [JsonPropertyName("replicationRole")]
    public string? ReplicationRole { get; set; }

    /// <summary>The name of the Resource Group where the PostgreSQL Flexible Server should exist. Changing this forces a new PostgreSQL Flexible Server to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The SKU Name for the PostgreSQL Flexible Server. The name of the SKU, follows the tier + name pattern (e.g. B_Standard_B1ms, GP_Standard_D2s_v3, MO_Standard_E4s_v3).</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>The resource ID of the source PostgreSQL Flexible Server to be restored. Required when create_mode is PointInTimeRestore or Replica. Changing this forces a new PostgreSQL Flexible Server to be created.</summary>
    [JsonPropertyName("sourceServerId")]
    public string? SourceServerId { get; set; }

    /// <summary>The max storage allowed for the PostgreSQL Flexible Server. Possible values are 32768, 65536, 131072, 262144, 524288, 1048576, 2097152, 4193280, 4194304, 8388608, 16777216 and 33553408.</summary>
    [JsonPropertyName("storageMb")]
    public double? StorageMb { get; set; }

    /// <summary>The name of storage performance tier for IOPS of the PostgreSQL Flexible Server. Possible values are P4, P6, P10, P15,P20, P30,P40, P50,P60, P70 or P80. Default value is dependant on the storage_mb value. Please see the storage_tier defaults based on storage_mb table below.</summary>
    [JsonPropertyName("storageTier")]
    public string? StorageTier { get; set; }

    /// <summary>A mapping of tags which should be assigned to the PostgreSQL Flexible Server.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The version of PostgreSQL Flexible Server to use. Possible values are 11,12, 13, 14, 15 and 16. Required when create_mode is Default.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>Specifies the Availability Zone in which the PostgreSQL Flexible Server should be located.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerStatusConditions
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

/// <summary>FlexibleServerStatus defines the observed state of FlexibleServer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FlexibleServerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FlexibleServerStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>FlexibleServer is the Schema for the FlexibleServers API. Manages a PostgreSQL Flexible Server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FlexibleServer : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FlexibleServerSpec>, IStatus<V1beta1FlexibleServerStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FlexibleServer";
    public const string KubeGroup = "dbforpostgresql.azure.upbound.io";
    public const string KubePluralName = "flexibleservers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FlexibleServerSpec defines the desired state of FlexibleServer</summary>
    [JsonPropertyName("spec")]
    public V1beta1FlexibleServerSpec Spec { get; set; }

    /// <summary>FlexibleServerStatus defines the observed state of FlexibleServer.</summary>
    [JsonPropertyName("status")]
    public V1beta1FlexibleServerStatus? Status { get; set; }
}