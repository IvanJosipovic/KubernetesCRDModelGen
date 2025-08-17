using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dbforpostgresql.azure.m.upbound.io;
#nullable enable
/// <summary>FlexibleServer is the Schema for the FlexibleServers API. Manages a PostgreSQL Flexible Server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FlexibleServerList : IKubernetesObject<V1ListMeta>, IItems<V1beta1FlexibleServer>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FlexibleServerList";
    public const string KubeGroup = "dbforpostgresql.azure.m.upbound.io";
    public const string KubePluralName = "flexibleservers";
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
    public IList<V1beta1FlexibleServer> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The Password associated with the administrator_login for the PostgreSQL Flexible Server. Password for the master DB user. If you set autoGeneratePassword to true, the Secret referenced here will be created or updated with generated password if it does not already contain one.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecForProviderAdministratorPasswordSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An authentication block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecForProviderAuthentication
{
    /// <summary>Whether Active Directory authentication is allowed to access the PostgreSQL Flexible Server. Defaults to false.</summary>
    [JsonPropertyName("activeDirectoryAuthEnabled")]
    public bool? ActiveDirectoryAuthEnabled { get; set; }

    /// <summary>Whether password authentication is allowed to access the PostgreSQL Flexible Server. Defaults to true.</summary>
    [JsonPropertyName("passwordAuthEnabled")]
    public bool? PasswordAuthEnabled { get; set; }

    /// <summary>The Tenant ID of the Azure Active Directory which is used by the Active Directory authentication. active_directory_auth_enabled must be set to true.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A customer_managed_key block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecForProviderCustomerManagedKey
{
    /// <summary>The versioned ID of the geo backup Key Vault Key.</summary>
    [JsonPropertyName("geoBackupKeyVaultKeyId")]
    public string? GeoBackupKeyVaultKeyId { get; set; }

    /// <summary>The geo backup user managed identity id for a Customer Managed Key. Must be added to identity.identity_ids.</summary>
    [JsonPropertyName("geoBackupUserAssignedIdentityId")]
    public string? GeoBackupUserAssignedIdentityId { get; set; }

    /// <summary>The versioned/versionless ID of the Key Vault Key.</summary>
    [JsonPropertyName("keyVaultKeyId")]
    public string? KeyVaultKeyId { get; set; }

    /// <summary>Specifies the primary user managed identity id for a Customer Managed Key. Must be added to identity.identity_ids.</summary>
    [JsonPropertyName("primaryUserAssignedIdentityId")]
    public string? PrimaryUserAssignedIdentityId { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>Reference to a Subnet in network to populate delegatedSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecForProviderDelegatedSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlexibleServerSpecForProviderDelegatedSubnetIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlexibleServerSpecForProviderDelegatedSubnetIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A high_availability block as defined below.</summary>
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
#nullable disable

#nullable enable
/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecForProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this PostgreSQL Flexible Server. Required if used together with customer_managed_key block.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this PostgreSQL Flexible Server. Possible values are UserAssigned, SystemAssigned and SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A maintenance_window block as defined below.</summary>
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>Reference to a PrivateDNSZone in network to populate privateDnsZoneId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecForProviderPrivateDnsZoneIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlexibleServerSpecForProviderPrivateDnsZoneIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlexibleServerSpecForProviderPrivateDnsZoneIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlexibleServerSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlexibleServerSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecForProvider
{
    /// <summary>The Administrator login for the PostgreSQL Flexible Server. Required when create_mode is Default and authentication.password_auth_enabled is true.</summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>The Password associated with the administrator_login for the PostgreSQL Flexible Server. Password for the master DB user. If you set autoGeneratePassword to true, the Secret referenced here will be created or updated with generated password if it does not already contain one.</summary>
    [JsonPropertyName("administratorPasswordSecretRef")]
    public V1beta1FlexibleServerSpecForProviderAdministratorPasswordSecretRef? AdministratorPasswordSecretRef { get; set; }

    /// <summary>The Password associated with the administrator_login for the PostgreSQL Flexible Server.</summary>
    [JsonPropertyName("administratorPasswordWo")]
    public string? AdministratorPasswordWo { get; set; }

    /// <summary>An integer value used to trigger an update for administrator_password_wo. This property should be incremented when updating administrator_password_wo.</summary>
    [JsonPropertyName("administratorPasswordWoVersion")]
    public double? AdministratorPasswordWoVersion { get; set; }

    /// <summary>An authentication block as defined below.</summary>
    [JsonPropertyName("authentication")]
    public V1beta1FlexibleServerSpecForProviderAuthentication? Authentication { get; set; }

    /// <summary>If true, the password will be auto-generated and stored in the Secret referenced by the administratorPasswordSecretRef field.</summary>
    [JsonPropertyName("autoGeneratePassword")]
    public bool? AutoGeneratePassword { get; set; }

    /// <summary>Is the storage auto grow for PostgreSQL Flexible Server enabled? Defaults to false.</summary>
    [JsonPropertyName("autoGrowEnabled")]
    public bool? AutoGrowEnabled { get; set; }

    /// <summary>The backup retention days for the PostgreSQL Flexible Server. Possible values are between 7 and 35 days.</summary>
    [JsonPropertyName("backupRetentionDays")]
    public double? BackupRetentionDays { get; set; }

    /// <summary>The creation mode which can be used to restore or replicate existing servers. Possible values are Default, GeoRestore, PointInTimeRestore, Replica, ReviveDropped and Update.</summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>A customer_managed_key block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("customerManagedKey")]
    public V1beta1FlexibleServerSpecForProviderCustomerManagedKey? CustomerManagedKey { get; set; }

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
    public V1beta1FlexibleServerSpecForProviderHighAvailability? HighAvailability { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1FlexibleServerSpecForProviderIdentity? Identity { get; set; }

    /// <summary>The Azure Region where the PostgreSQL Flexible Server should exist. Changing this forces a new PostgreSQL Flexible Server to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A maintenance_window block as defined below.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1beta1FlexibleServerSpecForProviderMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>The point in time to restore from source_server_id when create_mode is GeoRestore, PointInTimeRestore. Changing this forces a new PostgreSQL Flexible Server to be created.</summary>
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

    /// <summary>The resource ID of the source PostgreSQL Flexible Server to be restored. Required when create_mode is GeoRestore, PointInTimeRestore or Replica. Changing this forces a new PostgreSQL Flexible Server to be created.</summary>
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
#nullable disable

#nullable enable
/// <summary>The Password associated with the administrator_login for the PostgreSQL Flexible Server. Password for the master DB user. If you set autoGeneratePassword to true, the Secret referenced here will be created or updated with generated password if it does not already contain one.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecInitProviderAdministratorPasswordSecretRef
{
    /// <summary></summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An authentication block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecInitProviderAuthentication
{
    /// <summary>Whether Active Directory authentication is allowed to access the PostgreSQL Flexible Server. Defaults to false.</summary>
    [JsonPropertyName("activeDirectoryAuthEnabled")]
    public bool? ActiveDirectoryAuthEnabled { get; set; }

    /// <summary>Whether password authentication is allowed to access the PostgreSQL Flexible Server. Defaults to true.</summary>
    [JsonPropertyName("passwordAuthEnabled")]
    public bool? PasswordAuthEnabled { get; set; }

    /// <summary>The Tenant ID of the Azure Active Directory which is used by the Active Directory authentication. active_directory_auth_enabled must be set to true.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A customer_managed_key block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecInitProviderCustomerManagedKey
{
    /// <summary>The versioned ID of the geo backup Key Vault Key.</summary>
    [JsonPropertyName("geoBackupKeyVaultKeyId")]
    public string? GeoBackupKeyVaultKeyId { get; set; }

    /// <summary>The geo backup user managed identity id for a Customer Managed Key. Must be added to identity.identity_ids.</summary>
    [JsonPropertyName("geoBackupUserAssignedIdentityId")]
    public string? GeoBackupUserAssignedIdentityId { get; set; }

    /// <summary>The versioned/versionless ID of the Key Vault Key.</summary>
    [JsonPropertyName("keyVaultKeyId")]
    public string? KeyVaultKeyId { get; set; }

    /// <summary>Specifies the primary user managed identity id for a Customer Managed Key. Must be added to identity.identity_ids.</summary>
    [JsonPropertyName("primaryUserAssignedIdentityId")]
    public string? PrimaryUserAssignedIdentityId { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>Reference to a Subnet in network to populate delegatedSubnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecInitProviderDelegatedSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlexibleServerSpecInitProviderDelegatedSubnetIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlexibleServerSpecInitProviderDelegatedSubnetIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A high_availability block as defined below.</summary>
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
#nullable disable

#nullable enable
/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecInitProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this PostgreSQL Flexible Server. Required if used together with customer_managed_key block.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this PostgreSQL Flexible Server. Possible values are UserAssigned, SystemAssigned and SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A maintenance_window block as defined below.</summary>
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>Reference to a PrivateDNSZone in network to populate privateDnsZoneId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecInitProviderPrivateDnsZoneIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlexibleServerSpecInitProviderPrivateDnsZoneIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FlexibleServerSpecInitProviderPrivateDnsZoneIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecInitProvider
{
    /// <summary>The Administrator login for the PostgreSQL Flexible Server. Required when create_mode is Default and authentication.password_auth_enabled is true.</summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>The Password associated with the administrator_login for the PostgreSQL Flexible Server. Password for the master DB user. If you set autoGeneratePassword to true, the Secret referenced here will be created or updated with generated password if it does not already contain one.</summary>
    [JsonPropertyName("administratorPasswordSecretRef")]
    public V1beta1FlexibleServerSpecInitProviderAdministratorPasswordSecretRef? AdministratorPasswordSecretRef { get; set; }

    /// <summary>The Password associated with the administrator_login for the PostgreSQL Flexible Server.</summary>
    [JsonPropertyName("administratorPasswordWo")]
    public string? AdministratorPasswordWo { get; set; }

    /// <summary>An integer value used to trigger an update for administrator_password_wo. This property should be incremented when updating administrator_password_wo.</summary>
    [JsonPropertyName("administratorPasswordWoVersion")]
    public double? AdministratorPasswordWoVersion { get; set; }

    /// <summary>An authentication block as defined below.</summary>
    [JsonPropertyName("authentication")]
    public V1beta1FlexibleServerSpecInitProviderAuthentication? Authentication { get; set; }

    /// <summary>Is the storage auto grow for PostgreSQL Flexible Server enabled? Defaults to false.</summary>
    [JsonPropertyName("autoGrowEnabled")]
    public bool? AutoGrowEnabled { get; set; }

    /// <summary>The backup retention days for the PostgreSQL Flexible Server. Possible values are between 7 and 35 days.</summary>
    [JsonPropertyName("backupRetentionDays")]
    public double? BackupRetentionDays { get; set; }

    /// <summary>The creation mode which can be used to restore or replicate existing servers. Possible values are Default, GeoRestore, PointInTimeRestore, Replica, ReviveDropped and Update.</summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>A customer_managed_key block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("customerManagedKey")]
    public V1beta1FlexibleServerSpecInitProviderCustomerManagedKey? CustomerManagedKey { get; set; }

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
    public V1beta1FlexibleServerSpecInitProviderHighAvailability? HighAvailability { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1FlexibleServerSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>The Azure Region where the PostgreSQL Flexible Server should exist. Changing this forces a new PostgreSQL Flexible Server to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A maintenance_window block as defined below.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1beta1FlexibleServerSpecInitProviderMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>The point in time to restore from source_server_id when create_mode is GeoRestore, PointInTimeRestore. Changing this forces a new PostgreSQL Flexible Server to be created.</summary>
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

    /// <summary>The resource ID of the source PostgreSQL Flexible Server to be restored. Required when create_mode is GeoRestore, PointInTimeRestore or Replica. Changing this forces a new PostgreSQL Flexible Server to be created.</summary>
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
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>FlexibleServerSpec defines the desired state of FlexibleServer</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FlexibleServerSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FlexibleServerSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FlexibleServerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FlexibleServerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>An authentication block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerStatusAtProviderAuthentication
{
    /// <summary>Whether Active Directory authentication is allowed to access the PostgreSQL Flexible Server. Defaults to false.</summary>
    [JsonPropertyName("activeDirectoryAuthEnabled")]
    public bool? ActiveDirectoryAuthEnabled { get; set; }

    /// <summary>Whether password authentication is allowed to access the PostgreSQL Flexible Server. Defaults to true.</summary>
    [JsonPropertyName("passwordAuthEnabled")]
    public bool? PasswordAuthEnabled { get; set; }

    /// <summary>The Tenant ID of the Azure Active Directory which is used by the Active Directory authentication. active_directory_auth_enabled must be set to true.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A customer_managed_key block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerStatusAtProviderCustomerManagedKey
{
    /// <summary>The versioned ID of the geo backup Key Vault Key.</summary>
    [JsonPropertyName("geoBackupKeyVaultKeyId")]
    public string? GeoBackupKeyVaultKeyId { get; set; }

    /// <summary>The geo backup user managed identity id for a Customer Managed Key. Must be added to identity.identity_ids.</summary>
    [JsonPropertyName("geoBackupUserAssignedIdentityId")]
    public string? GeoBackupUserAssignedIdentityId { get; set; }

    /// <summary>The versioned/versionless ID of the Key Vault Key.</summary>
    [JsonPropertyName("keyVaultKeyId")]
    public string? KeyVaultKeyId { get; set; }

    /// <summary>Specifies the primary user managed identity id for a Customer Managed Key. Must be added to identity.identity_ids.</summary>
    [JsonPropertyName("primaryUserAssignedIdentityId")]
    public string? PrimaryUserAssignedIdentityId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A high_availability block as defined below.</summary>
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
#nullable disable

#nullable enable
/// <summary>An identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerStatusAtProviderIdentity
{
    /// <summary>A list of User Assigned Managed Identity IDs to be assigned to this PostgreSQL Flexible Server. Required if used together with customer_managed_key block.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this PostgreSQL Flexible Server. Possible values are UserAssigned, SystemAssigned and SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A maintenance_window block as defined below.</summary>
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FlexibleServerStatusAtProvider
{
    /// <summary>The Administrator login for the PostgreSQL Flexible Server. Required when create_mode is Default and authentication.password_auth_enabled is true.</summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>The Password associated with the administrator_login for the PostgreSQL Flexible Server.</summary>
    [JsonPropertyName("administratorPasswordWo")]
    public string? AdministratorPasswordWo { get; set; }

    /// <summary>An integer value used to trigger an update for administrator_password_wo. This property should be incremented when updating administrator_password_wo.</summary>
    [JsonPropertyName("administratorPasswordWoVersion")]
    public double? AdministratorPasswordWoVersion { get; set; }

    /// <summary>An authentication block as defined below.</summary>
    [JsonPropertyName("authentication")]
    public V1beta1FlexibleServerStatusAtProviderAuthentication? Authentication { get; set; }

    /// <summary>Is the storage auto grow for PostgreSQL Flexible Server enabled? Defaults to false.</summary>
    [JsonPropertyName("autoGrowEnabled")]
    public bool? AutoGrowEnabled { get; set; }

    /// <summary>The backup retention days for the PostgreSQL Flexible Server. Possible values are between 7 and 35 days.</summary>
    [JsonPropertyName("backupRetentionDays")]
    public double? BackupRetentionDays { get; set; }

    /// <summary>The creation mode which can be used to restore or replicate existing servers. Possible values are Default, GeoRestore, PointInTimeRestore, Replica, ReviveDropped and Update.</summary>
    [JsonPropertyName("createMode")]
    public string? CreateMode { get; set; }

    /// <summary>A customer_managed_key block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("customerManagedKey")]
    public V1beta1FlexibleServerStatusAtProviderCustomerManagedKey? CustomerManagedKey { get; set; }

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
    public V1beta1FlexibleServerStatusAtProviderHighAvailability? HighAvailability { get; set; }

    /// <summary>The ID of the PostgreSQL Flexible Server.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1FlexibleServerStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>The Azure Region where the PostgreSQL Flexible Server should exist. Changing this forces a new PostgreSQL Flexible Server to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A maintenance_window block as defined below.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V1beta1FlexibleServerStatusAtProviderMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>The point in time to restore from source_server_id when create_mode is GeoRestore, PointInTimeRestore. Changing this forces a new PostgreSQL Flexible Server to be created.</summary>
    [JsonPropertyName("pointInTimeRestoreTimeInUtc")]
    public string? PointInTimeRestoreTimeInUtc { get; set; }

    /// <summary>The ID of the private DNS zone to create the PostgreSQL Flexible Server.</summary>
    [JsonPropertyName("privateDnsZoneId")]
    public string? PrivateDnsZoneId { get; set; }

    /// <summary>Specifies whether this PostgreSQL Flexible Server is publicly accessible. Defaults to true.</summary>
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

    /// <summary>The resource ID of the source PostgreSQL Flexible Server to be restored. Required when create_mode is GeoRestore, PointInTimeRestore or Replica. Changing this forces a new PostgreSQL Flexible Server to be created.</summary>
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>FlexibleServer is the Schema for the FlexibleServers API. Manages a PostgreSQL Flexible Server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FlexibleServer : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FlexibleServerSpec>, IStatus<V1beta1FlexibleServerStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FlexibleServer";
    public const string KubeGroup = "dbforpostgresql.azure.m.upbound.io";
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
#nullable disable
