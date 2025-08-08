using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sql.azure.upbound.io;
/// <summary>The password associated with the administrator_login user. Needs to comply with Azure's Password Policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceSpecForProviderAdministratorLoginPasswordSecretRef
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
public partial class V1beta1MSSQLManagedInstanceSpecForProviderAzureActiveDirectoryAdministrator
{
    /// <summary>Specifies whether only Azure AD authentication can be used to log in to this SQL Managed Instance. When true, the administrator_login and administrator_login_password properties can be omitted. Defaults to false.</summary>
    [JsonPropertyName("azureadAuthenticationOnlyEnabled")]
    public bool? AzureadAuthenticationOnlyEnabled { get; set; }

    /// <summary>The login username of the Azure AD Administrator of this SQL Managed Instance.</summary>
    [JsonPropertyName("loginUsername")]
    public string? LoginUsername { get; set; }

    /// <summary>The object id of the Azure AD Administrator of this SQL Managed Instance.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>The principal type of the Azure AD Administrator of this SQL Managed Instance. Possible values are Application, Group, User.</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }

    /// <summary>The tenant id of the Azure AD Administrator of this SQL Managed Instance. Should be specified if the Azure AD Administrator is homed in a different tenant to the SQL Managed Instance.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceSpecForProviderDnsZonePartnerIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a MSSQLManagedInstance in sql to populate dnsZonePartnerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceSpecForProviderDnsZonePartnerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLManagedInstanceSpecForProviderDnsZonePartnerIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceSpecForProviderDnsZonePartnerIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a MSSQLManagedInstance in sql to populate dnsZonePartnerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceSpecForProviderDnsZonePartnerIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLManagedInstanceSpecForProviderDnsZonePartnerIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceSpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this SQL Managed Instance. Required when type includes UserAssigned.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this SQL Managed Instance. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1MSSQLManagedInstanceSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLManagedInstanceSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1MSSQLManagedInstanceSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLManagedInstanceSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceSpecForProviderSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceSpecForProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLManagedInstanceSpecForProviderSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceSpecForProviderSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceSpecForProviderSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLManagedInstanceSpecForProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceSpecForProvider
{
    /// <summary>The administrator login name for the new SQL Managed Instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>The password associated with the administrator_login user. Needs to comply with Azure's Password Policy</summary>
    [JsonPropertyName("administratorLoginPasswordSecretRef")]
    public V1beta1MSSQLManagedInstanceSpecForProviderAdministratorLoginPasswordSecretRef? AdministratorLoginPasswordSecretRef { get; set; }

    /// <summary>An azure_active_directory_administrator block as defined below.</summary>
    [JsonPropertyName("azureActiveDirectoryAdministrator")]
    public IList<V1beta1MSSQLManagedInstanceSpecForProviderAzureActiveDirectoryAdministrator>? AzureActiveDirectoryAdministrator { get; set; }

    /// <summary>Specifies how the SQL Managed Instance will be collated. Default value is SQL_Latin1_General_CP1_CI_AS. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>Specifies the internal format of the SQL Managed Instance databases specific to the SQL engine version. Possible values are AlwaysUpToDate and SQLServer2022. Defaults to SQLServer2022.</summary>
    [JsonPropertyName("databaseFormat")]
    public string? DatabaseFormat { get; set; }

    /// <summary>The ID of the SQL Managed Instance which will share the DNS zone. This is a prerequisite for creating an azurerm_sql_managed_instance_failover_group. Setting this after creation forces a new resource to be created.</summary>
    [JsonPropertyName("dnsZonePartnerId")]
    public string? DnsZonePartnerId { get; set; }

    /// <summary>Reference to a MSSQLManagedInstance in sql to populate dnsZonePartnerId.</summary>
    [JsonPropertyName("dnsZonePartnerIdRef")]
    public V1beta1MSSQLManagedInstanceSpecForProviderDnsZonePartnerIdRef? DnsZonePartnerIdRef { get; set; }

    /// <summary>Selector for a MSSQLManagedInstance in sql to populate dnsZonePartnerId.</summary>
    [JsonPropertyName("dnsZonePartnerIdSelector")]
    public V1beta1MSSQLManagedInstanceSpecForProviderDnsZonePartnerIdSelector? DnsZonePartnerIdSelector { get; set; }

    /// <summary>Specifies the hybrid secondary usage for disaster recovery of the SQL Managed Instance. Possible values are Active and Passive. Defaults to Active.</summary>
    [JsonPropertyName("hybridSecondaryUsage")]
    public string? HybridSecondaryUsage { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1MSSQLManagedInstanceSpecForProviderIdentity>? Identity { get; set; }

    /// <summary>What type of license the Managed Instance will use. Possible values are LicenseIncluded and BasePrice.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the Public Maintenance Configuration window to apply to the SQL Managed Instance. Valid values include SQL_Default or an Azure Location in the format SQL_{Location}_MI_{Size}(for example SQL_EastUS_MI_1). Defaults to SQL_Default.</summary>
    [JsonPropertyName("maintenanceConfigurationName")]
    public string? MaintenanceConfigurationName { get; set; }

    /// <summary>The Minimum TLS Version. Default value is 1.2 Valid values include 1.0, 1.1, 1.2.</summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>Specifies how the SQL Managed Instance will be accessed. Default value is Default. Valid values include Default, Proxy, and Redirect.</summary>
    [JsonPropertyName("proxyOverride")]
    public string? ProxyOverride { get; set; }

    /// <summary>Is the public data endpoint enabled? Default value is false.</summary>
    [JsonPropertyName("publicDataEndpointEnabled")]
    public bool? PublicDataEndpointEnabled { get; set; }

    /// <summary>The name of the resource group in which to create the SQL Managed Instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1MSSQLManagedInstanceSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1MSSQLManagedInstanceSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The service principal type. The only possible value is SystemAssigned.</summary>
    [JsonPropertyName("servicePrincipalType")]
    public string? ServicePrincipalType { get; set; }

    /// <summary>Specifies the SKU Name for the SQL Managed Instance. Valid values include GP_Gen4, GP_Gen5, GP_Gen8IM, GP_Gen8IH, BC_Gen4, BC_Gen5, BC_Gen8IM or BC_Gen8IH.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>Specifies the storage account type used to store backups for this database. Possible values are GRS, GZRS, LRS, and ZRS. Defaults to GRS.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>Maximum storage space for the SQL Managed instance. This should be a multiple of 32 (GB).</summary>
    [JsonPropertyName("storageSizeInGb")]
    public double? StorageSizeInGb { get; set; }

    /// <summary>The subnet resource id that the SQL Managed Instance will be associated with.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1MSSQLManagedInstanceSpecForProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1MSSQLManagedInstanceSpecForProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The TimeZone ID that the SQL Managed Instance will be operating in. Default value is UTC. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("timezoneId")]
    public string? TimezoneId { get; set; }

    /// <summary>Number of cores that should be assigned to the SQL Managed Instance. Values can be 8, 16, or 24 for Gen4 SKUs, or 4, 6, 8, 10, 12, 16, 20, 24, 32, 40, 48, 56, 64, 80, 96 or 128 for Gen5 SKUs.</summary>
    [JsonPropertyName("vcores")]
    public double? Vcores { get; set; }

    /// <summary>Specifies whether or not the SQL Managed Instance is zone redundant. Defaults to false.</summary>
    [JsonPropertyName("zoneRedundantEnabled")]
    public bool? ZoneRedundantEnabled { get; set; }
}

/// <summary>The password associated with the administrator_login user. Needs to comply with Azure's Password Policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceSpecInitProviderAdministratorLoginPasswordSecretRef
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
public partial class V1beta1MSSQLManagedInstanceSpecInitProviderAzureActiveDirectoryAdministrator
{
    /// <summary>Specifies whether only Azure AD authentication can be used to log in to this SQL Managed Instance. When true, the administrator_login and administrator_login_password properties can be omitted. Defaults to false.</summary>
    [JsonPropertyName("azureadAuthenticationOnlyEnabled")]
    public bool? AzureadAuthenticationOnlyEnabled { get; set; }

    /// <summary>The login username of the Azure AD Administrator of this SQL Managed Instance.</summary>
    [JsonPropertyName("loginUsername")]
    public string? LoginUsername { get; set; }

    /// <summary>The object id of the Azure AD Administrator of this SQL Managed Instance.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>The principal type of the Azure AD Administrator of this SQL Managed Instance. Possible values are Application, Group, User.</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }

    /// <summary>The tenant id of the Azure AD Administrator of this SQL Managed Instance. Should be specified if the Azure AD Administrator is homed in a different tenant to the SQL Managed Instance.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceSpecInitProviderDnsZonePartnerIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a MSSQLManagedInstance in sql to populate dnsZonePartnerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceSpecInitProviderDnsZonePartnerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLManagedInstanceSpecInitProviderDnsZonePartnerIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceSpecInitProviderDnsZonePartnerIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a MSSQLManagedInstance in sql to populate dnsZonePartnerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceSpecInitProviderDnsZonePartnerIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLManagedInstanceSpecInitProviderDnsZonePartnerIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceSpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this SQL Managed Instance. Required when type includes UserAssigned.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this SQL Managed Instance. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceSpecInitProviderSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceSpecInitProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLManagedInstanceSpecInitProviderSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceSpecInitProviderSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceSpecInitProviderSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLManagedInstanceSpecInitProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceSpecInitProvider
{
    /// <summary>The administrator login name for the new SQL Managed Instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>The password associated with the administrator_login user. Needs to comply with Azure's Password Policy</summary>
    [JsonPropertyName("administratorLoginPasswordSecretRef")]
    public V1beta1MSSQLManagedInstanceSpecInitProviderAdministratorLoginPasswordSecretRef? AdministratorLoginPasswordSecretRef { get; set; }

    /// <summary>An azure_active_directory_administrator block as defined below.</summary>
    [JsonPropertyName("azureActiveDirectoryAdministrator")]
    public IList<V1beta1MSSQLManagedInstanceSpecInitProviderAzureActiveDirectoryAdministrator>? AzureActiveDirectoryAdministrator { get; set; }

    /// <summary>Specifies how the SQL Managed Instance will be collated. Default value is SQL_Latin1_General_CP1_CI_AS. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>Specifies the internal format of the SQL Managed Instance databases specific to the SQL engine version. Possible values are AlwaysUpToDate and SQLServer2022. Defaults to SQLServer2022.</summary>
    [JsonPropertyName("databaseFormat")]
    public string? DatabaseFormat { get; set; }

    /// <summary>The ID of the SQL Managed Instance which will share the DNS zone. This is a prerequisite for creating an azurerm_sql_managed_instance_failover_group. Setting this after creation forces a new resource to be created.</summary>
    [JsonPropertyName("dnsZonePartnerId")]
    public string? DnsZonePartnerId { get; set; }

    /// <summary>Reference to a MSSQLManagedInstance in sql to populate dnsZonePartnerId.</summary>
    [JsonPropertyName("dnsZonePartnerIdRef")]
    public V1beta1MSSQLManagedInstanceSpecInitProviderDnsZonePartnerIdRef? DnsZonePartnerIdRef { get; set; }

    /// <summary>Selector for a MSSQLManagedInstance in sql to populate dnsZonePartnerId.</summary>
    [JsonPropertyName("dnsZonePartnerIdSelector")]
    public V1beta1MSSQLManagedInstanceSpecInitProviderDnsZonePartnerIdSelector? DnsZonePartnerIdSelector { get; set; }

    /// <summary>Specifies the hybrid secondary usage for disaster recovery of the SQL Managed Instance. Possible values are Active and Passive. Defaults to Active.</summary>
    [JsonPropertyName("hybridSecondaryUsage")]
    public string? HybridSecondaryUsage { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1MSSQLManagedInstanceSpecInitProviderIdentity>? Identity { get; set; }

    /// <summary>What type of license the Managed Instance will use. Possible values are LicenseIncluded and BasePrice.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the Public Maintenance Configuration window to apply to the SQL Managed Instance. Valid values include SQL_Default or an Azure Location in the format SQL_{Location}_MI_{Size}(for example SQL_EastUS_MI_1). Defaults to SQL_Default.</summary>
    [JsonPropertyName("maintenanceConfigurationName")]
    public string? MaintenanceConfigurationName { get; set; }

    /// <summary>The Minimum TLS Version. Default value is 1.2 Valid values include 1.0, 1.1, 1.2.</summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>Specifies how the SQL Managed Instance will be accessed. Default value is Default. Valid values include Default, Proxy, and Redirect.</summary>
    [JsonPropertyName("proxyOverride")]
    public string? ProxyOverride { get; set; }

    /// <summary>Is the public data endpoint enabled? Default value is false.</summary>
    [JsonPropertyName("publicDataEndpointEnabled")]
    public bool? PublicDataEndpointEnabled { get; set; }

    /// <summary>The service principal type. The only possible value is SystemAssigned.</summary>
    [JsonPropertyName("servicePrincipalType")]
    public string? ServicePrincipalType { get; set; }

    /// <summary>Specifies the SKU Name for the SQL Managed Instance. Valid values include GP_Gen4, GP_Gen5, GP_Gen8IM, GP_Gen8IH, BC_Gen4, BC_Gen5, BC_Gen8IM or BC_Gen8IH.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>Specifies the storage account type used to store backups for this database. Possible values are GRS, GZRS, LRS, and ZRS. Defaults to GRS.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>Maximum storage space for the SQL Managed instance. This should be a multiple of 32 (GB).</summary>
    [JsonPropertyName("storageSizeInGb")]
    public double? StorageSizeInGb { get; set; }

    /// <summary>The subnet resource id that the SQL Managed Instance will be associated with.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1MSSQLManagedInstanceSpecInitProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1MSSQLManagedInstanceSpecInitProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The TimeZone ID that the SQL Managed Instance will be operating in. Default value is UTC. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("timezoneId")]
    public string? TimezoneId { get; set; }

    /// <summary>Number of cores that should be assigned to the SQL Managed Instance. Values can be 8, 16, or 24 for Gen4 SKUs, or 4, 6, 8, 10, 12, 16, 20, 24, 32, 40, 48, 56, 64, 80, 96 or 128 for Gen5 SKUs.</summary>
    [JsonPropertyName("vcores")]
    public double? Vcores { get; set; }

    /// <summary>Specifies whether or not the SQL Managed Instance is zone redundant. Defaults to false.</summary>
    [JsonPropertyName("zoneRedundantEnabled")]
    public bool? ZoneRedundantEnabled { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceSpecProviderConfigRefPolicy
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
public partial class V1beta1MSSQLManagedInstanceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MSSQLManagedInstanceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>MSSQLManagedInstanceSpec defines the desired state of MSSQLManagedInstance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1MSSQLManagedInstanceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1MSSQLManagedInstanceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MSSQLManagedInstanceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MSSQLManagedInstanceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceStatusAtProviderAzureActiveDirectoryAdministrator
{
    /// <summary>Specifies whether only Azure AD authentication can be used to log in to this SQL Managed Instance. When true, the administrator_login and administrator_login_password properties can be omitted. Defaults to false.</summary>
    [JsonPropertyName("azureadAuthenticationOnlyEnabled")]
    public bool? AzureadAuthenticationOnlyEnabled { get; set; }

    /// <summary>The login username of the Azure AD Administrator of this SQL Managed Instance.</summary>
    [JsonPropertyName("loginUsername")]
    public string? LoginUsername { get; set; }

    /// <summary>The object id of the Azure AD Administrator of this SQL Managed Instance.</summary>
    [JsonPropertyName("objectId")]
    public string? ObjectId { get; set; }

    /// <summary>The principal type of the Azure AD Administrator of this SQL Managed Instance. Possible values are Application, Group, User.</summary>
    [JsonPropertyName("principalType")]
    public string? PrincipalType { get; set; }

    /// <summary>The tenant id of the Azure AD Administrator of this SQL Managed Instance. Should be specified if the Azure AD Administrator is homed in a different tenant to the SQL Managed Instance.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this SQL Managed Instance. Required when type includes UserAssigned.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID for the Service Principal associated with the Identity of this SQL Managed Instance.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID for the Service Principal associated with the Identity of this SQL Managed Instance.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this SQL Managed Instance. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceStatusAtProvider
{
    /// <summary>The administrator login name for the new SQL Managed Instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("administratorLogin")]
    public string? AdministratorLogin { get; set; }

    /// <summary>An azure_active_directory_administrator block as defined below.</summary>
    [JsonPropertyName("azureActiveDirectoryAdministrator")]
    public IList<V1beta1MSSQLManagedInstanceStatusAtProviderAzureActiveDirectoryAdministrator>? AzureActiveDirectoryAdministrator { get; set; }

    /// <summary>Specifies how the SQL Managed Instance will be collated. Default value is SQL_Latin1_General_CP1_CI_AS. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("collation")]
    public string? Collation { get; set; }

    /// <summary>Specifies the internal format of the SQL Managed Instance databases specific to the SQL engine version. Possible values are AlwaysUpToDate and SQLServer2022. Defaults to SQLServer2022.</summary>
    [JsonPropertyName("databaseFormat")]
    public string? DatabaseFormat { get; set; }

    /// <summary>The Dns Zone where the SQL Managed Instance is located.</summary>
    [JsonPropertyName("dnsZone")]
    public string? DnsZone { get; set; }

    /// <summary>The ID of the SQL Managed Instance which will share the DNS zone. This is a prerequisite for creating an azurerm_sql_managed_instance_failover_group. Setting this after creation forces a new resource to be created.</summary>
    [JsonPropertyName("dnsZonePartnerId")]
    public string? DnsZonePartnerId { get; set; }

    /// <summary>The fully qualified domain name of the Azure Managed SQL Instance</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>Specifies the hybrid secondary usage for disaster recovery of the SQL Managed Instance. Possible values are Active and Passive. Defaults to Active.</summary>
    [JsonPropertyName("hybridSecondaryUsage")]
    public string? HybridSecondaryUsage { get; set; }

    /// <summary>The SQL Managed Instance ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1MSSQLManagedInstanceStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>What type of license the Managed Instance will use. Possible values are LicenseIncluded and BasePrice.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The name of the Public Maintenance Configuration window to apply to the SQL Managed Instance. Valid values include SQL_Default or an Azure Location in the format SQL_{Location}_MI_{Size}(for example SQL_EastUS_MI_1). Defaults to SQL_Default.</summary>
    [JsonPropertyName("maintenanceConfigurationName")]
    public string? MaintenanceConfigurationName { get; set; }

    /// <summary>The Minimum TLS Version. Default value is 1.2 Valid values include 1.0, 1.1, 1.2.</summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>Specifies how the SQL Managed Instance will be accessed. Default value is Default. Valid values include Default, Proxy, and Redirect.</summary>
    [JsonPropertyName("proxyOverride")]
    public string? ProxyOverride { get; set; }

    /// <summary>Is the public data endpoint enabled? Default value is false.</summary>
    [JsonPropertyName("publicDataEndpointEnabled")]
    public bool? PublicDataEndpointEnabled { get; set; }

    /// <summary>The name of the resource group in which to create the SQL Managed Instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The service principal type. The only possible value is SystemAssigned.</summary>
    [JsonPropertyName("servicePrincipalType")]
    public string? ServicePrincipalType { get; set; }

    /// <summary>Specifies the SKU Name for the SQL Managed Instance. Valid values include GP_Gen4, GP_Gen5, GP_Gen8IM, GP_Gen8IH, BC_Gen4, BC_Gen5, BC_Gen8IM or BC_Gen8IH.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>Specifies the storage account type used to store backups for this database. Possible values are GRS, GZRS, LRS, and ZRS. Defaults to GRS.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>Maximum storage space for the SQL Managed instance. This should be a multiple of 32 (GB).</summary>
    [JsonPropertyName("storageSizeInGb")]
    public double? StorageSizeInGb { get; set; }

    /// <summary>The subnet resource id that the SQL Managed Instance will be associated with.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The TimeZone ID that the SQL Managed Instance will be operating in. Default value is UTC. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("timezoneId")]
    public string? TimezoneId { get; set; }

    /// <summary>Number of cores that should be assigned to the SQL Managed Instance. Values can be 8, 16, or 24 for Gen4 SKUs, or 4, 6, 8, 10, 12, 16, 20, 24, 32, 40, 48, 56, 64, 80, 96 or 128 for Gen5 SKUs.</summary>
    [JsonPropertyName("vcores")]
    public double? Vcores { get; set; }

    /// <summary>Specifies whether or not the SQL Managed Instance is zone redundant. Defaults to false.</summary>
    [JsonPropertyName("zoneRedundantEnabled")]
    public bool? ZoneRedundantEnabled { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceStatusConditions
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

/// <summary>MSSQLManagedInstanceStatus defines the observed state of MSSQLManagedInstance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MSSQLManagedInstanceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1MSSQLManagedInstanceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MSSQLManagedInstanceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MSSQLManagedInstance is the Schema for the MSSQLManagedInstances API. Manages a Microsoft SQL Azure Managed Instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MSSQLManagedInstance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MSSQLManagedInstanceSpec>, IStatus<V1beta1MSSQLManagedInstanceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MSSQLManagedInstance";
    public const string KubeGroup = "sql.azure.upbound.io";
    public const string KubePluralName = "mssqlmanagedinstances";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MSSQLManagedInstanceSpec defines the desired state of MSSQLManagedInstance</summary>
    [JsonPropertyName("spec")]
    public V1beta1MSSQLManagedInstanceSpec Spec { get; set; }

    /// <summary>MSSQLManagedInstanceStatus defines the observed state of MSSQLManagedInstance.</summary>
    [JsonPropertyName("status")]
    public V1beta1MSSQLManagedInstanceStatus? Status { get; set; }
}

/// <summary>MSSQLManagedInstance is the Schema for the MSSQLManagedInstances API. Manages a Microsoft SQL Azure Managed Instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MSSQLManagedInstanceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1MSSQLManagedInstance>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MSSQLManagedInstanceList";
    public const string KubeGroup = "sql.azure.upbound.io";
    public const string KubePluralName = "mssqlmanagedinstances";
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
    public IList<V1beta1MSSQLManagedInstance> Items { get; set; }
}