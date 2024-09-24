using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.azure.upbound.io;
public enum V1beta1LinuxVirtualMachineScaleSetSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderAdditionalCapabilities
{
    /// <summary>Should the capacity to enable Data Disks of the UltraSSD_LRS storage account type be supported on this Virtual Machine Scale Set? Possible values are true or false. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ultraSsdEnabled")]
    public bool? UltraSsdEnabled { get; set; }
}

/// <summary>The Password which should be used for the local-administrator on this Virtual Machine. Changing this forces a new resource to be created.</summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderAdminPasswordSecretRef
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
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderAdminSshKey
{
    /// <summary>The Public Key which should be used for authentication, which needs to be at least 2048-bit and in ssh-rsa format.</summary>
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    /// <summary>The Username for which this Public SSH Key should be configured.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderAutomaticInstanceRepair
{
    /// <summary>Should the automatic instance repair be enabled on this Virtual Machine Scale Set?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Amount of time (in minutes, between 30 and 90) for which automatic repairs will be delayed. The grace period starts right after the VM is found unhealthy. The time duration should be specified in ISO 8601 format. Defaults to PT30M.</summary>
    [JsonPropertyName("gracePeriod")]
    public string? GracePeriod { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderAutomaticOsUpgradePolicy
{
    /// <summary>Should automatic rollbacks be disabled?</summary>
    [JsonPropertyName("disableAutomaticRollback")]
    public bool? DisableAutomaticRollback { get; set; }

    /// <summary>Should OS Upgrades automatically be applied to Scale Set instances in a rolling fashion when a newer version of the OS Image becomes available?</summary>
    [JsonPropertyName("enableAutomaticOsUpgrade")]
    public bool? EnableAutomaticOsUpgrade { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderBootDiagnostics
{
    /// <summary>The Primary/Secondary Endpoint for the Azure Storage Account which should be used to store Boot Diagnostics, including Console Output and Screenshots from the Hypervisor.</summary>
    [JsonPropertyName("storageAccountUri")]
    public string? StorageAccountUri { get; set; }
}

/// <summary>The Base64-Encoded Custom Data which should be used for this Virtual Machine Scale Set.</summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderCustomDataSecretRef
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
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderDataDisk
{
    /// <summary>The type of Caching which should be used for this Data Disk. Possible values are None, ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>The create option which should be used for this Data Disk. Possible values are Empty and FromImage. Defaults to Empty. (FromImage should only be used if the source image includes data disks).</summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to encrypt this OS Disk. Conflicts with secure_vm_disk_encryption_set_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>The size of the Data Disk which should be created.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The Logical Unit Number of the Data Disk, which must be unique within the Virtual Machine.</summary>
    [JsonPropertyName("lun")]
    public double? Lun { get; set; }

    /// <summary>The name of the Data Disk.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Type of Storage Account which should back this Data Disk. Possible values include Standard_LRS, StandardSSD_LRS, StandardSSD_ZRS, Premium_LRS, PremiumV2_LRS, Premium_ZRS and UltraSSD_LRS.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>Specifies the Read-Write IOPS for this Data Disk. Only settable when storage_account_type is PremiumV2_LRS or UltraSSD_LRS.</summary>
    [JsonPropertyName("ultraSsdDiskIopsReadWrite")]
    public double? UltraSsdDiskIopsReadWrite { get; set; }

    /// <summary>Specifies the bandwidth in MB per second for this Data Disk. Only settable when storage_account_type is PremiumV2_LRS or UltraSSD_LRS.</summary>
    [JsonPropertyName("ultraSsdDiskMbpsReadWrite")]
    public double? UltraSsdDiskMbpsReadWrite { get; set; }

    /// <summary>Should Write Accelerator be Enabled for this OS Disk? Defaults to false.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderExtensionProtectedSettingsFromKeyVault
{
    /// <summary>The URL to the Key Vault Secret which stores the protected settings.</summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>The ID of the source Key Vault.</summary>
    [JsonPropertyName("sourceVaultId")]
    public string? SourceVaultId { get; set; }
}

/// <summary>A JSON String which specifies Sensitive Settings (such as Passwords) for the Extension.</summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderExtensionProtectedSettingsSecretRef
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
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderExtension
{
    /// <summary>Should the latest version of the Extension be used at Deployment Time, if one is available? This won't auto-update the extension on existing installation. Defaults to true.</summary>
    [JsonPropertyName("autoUpgradeMinorVersion")]
    public bool? AutoUpgradeMinorVersion { get; set; }

    /// <summary>Should the Extension be automatically updated whenever the Publisher releases a new version of this VM Extension?</summary>
    [JsonPropertyName("automaticUpgradeEnabled")]
    public bool? AutomaticUpgradeEnabled { get; set; }

    /// <summary>A value which, when different to the previous value can be used to force-run the Extension even if the Extension Configuration hasn't changed.</summary>
    [JsonPropertyName("forceUpdateTag")]
    public string? ForceUpdateTag { get; set; }

    /// <summary>The name for the Virtual Machine Scale Set Extension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A protected_settings_from_key_vault block as defined below.</summary>
    [JsonPropertyName("protectedSettingsFromKeyVault")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecForProviderExtensionProtectedSettingsFromKeyVault>? ProtectedSettingsFromKeyVault { get; set; }

    /// <summary>A JSON String which specifies Sensitive Settings (such as Passwords) for the Extension.</summary>
    [JsonPropertyName("protectedSettingsSecretRef")]
    public V1beta1LinuxVirtualMachineScaleSetSpecForProviderExtensionProtectedSettingsSecretRef? ProtectedSettingsSecretRef { get; set; }

    /// <summary>An ordered list of Extension names which this should be provisioned after.</summary>
    [JsonPropertyName("provisionAfterExtensions")]
    public IList<string>? ProvisionAfterExtensions { get; set; }

    /// <summary>Specifies the Publisher of the Extension.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>A JSON String which specifies Settings for the Extension.</summary>
    [JsonPropertyName("settings")]
    public string? Settings { get; set; }

    /// <summary>Specifies the Type of the Extension.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Specifies the version of the extension to use, available versions can be found using the Azure CLI.</summary>
    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderGalleryApplication
{
    /// <summary>Specifies the URI to an Azure Blob that will replace the default configuration for the package if provided. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("configurationBlobUri")]
    public string? ConfigurationBlobUri { get; set; }

    /// <summary>Specifies the order in which the packages have to be installed. Possible values are between 0 and 2,147,483,647. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>Specifies a passthrough value for more generic context. This field can be any valid string value. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>Specifies the Gallery Application Version resource ID. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("versionId")]
    public string? VersionId { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderGalleryApplications
{
    /// <summary></summary>
    [JsonPropertyName("configurationReferenceBlobUri")]
    public string? ConfigurationReferenceBlobUri { get; set; }

    /// <summary>Specifies the order in which the packages have to be installed. Possible values are between 0 and 2,147,483,647. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>The ID of the Linux Virtual Machine Scale Set.</summary>
    [JsonPropertyName("packageReferenceId")]
    public string? PackageReferenceId { get; set; }

    /// <summary>The IP Tag associated with the Public IP, such as SQL or Storage. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Linux Virtual Machine Scale Set.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Linux Virtual Machine Scale Set. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationPublicIpAddressIpTag
{
    /// <summary>The IP Tag associated with the Public IP, such as SQL or Storage. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The Type of IP Tag, such as FirstPartyUsage. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationPublicIpAddress
{
    /// <summary>The Prefix which should be used for the Domain Name Label for each Virtual Machine Instance. Azure concatenates the Domain Name Label and Virtual Machine Index to create a unique Domain Name Label for each Virtual Machine.</summary>
    [JsonPropertyName("domainNameLabel")]
    public string? DomainNameLabel { get; set; }

    /// <summary>The Idle Timeout in Minutes for the Public IP Address. Possible values are in the range 4 to 32.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>One or more ip_tag blocks as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ipTag")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationPublicIpAddressIpTag>? IpTag { get; set; }

    /// <summary>The Name of the Public IP Address Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Public IP Address Prefix from where Public IP Addresses should be allocated. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicIpPrefixId")]
    public string? PublicIpPrefixId { get; set; }

    /// <summary>Specifies the version of the image used to create the virtual machines.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public enum V1beta1LinuxVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LinuxVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LinuxVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1LinuxVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LinuxVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolveEnum>))]
    public V1beta1LinuxVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1LinuxVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LinuxVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LinuxVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1LinuxVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LinuxVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1LinuxVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfiguration
{
    /// <summary>A list of Backend Address Pools ID's from a Application Gateway which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("applicationGatewayBackendAddressPoolIds")]
    public IList<string>? ApplicationGatewayBackendAddressPoolIds { get; set; }

    /// <summary>A list of Application Security Group ID's which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("applicationSecurityGroupIds")]
    public IList<string>? ApplicationSecurityGroupIds { get; set; }

    /// <summary>A list of Backend Address Pools ID's from a Load Balancer which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("loadBalancerBackendAddressPoolIds")]
    public IList<string>? LoadBalancerBackendAddressPoolIds { get; set; }

    /// <summary>A list of NAT Rule ID's from a Load Balancer which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("loadBalancerInboundNatRulesIds")]
    public IList<string>? LoadBalancerInboundNatRulesIds { get; set; }

    /// <summary>The Name of the Public IP Address Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this the Primary IP Configuration?</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>A public_ip_address block as defined below.</summary>
    [JsonPropertyName("publicIpAddress")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationPublicIpAddress>? PublicIpAddress { get; set; }

    /// <summary>The ID of the Subnet which this IP Configuration should be connected to.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1LinuxVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1LinuxVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>Specifies the version of the image used to create the virtual machines.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderNetworkInterface
{
    /// <summary>A list of IP Addresses of DNS Servers which should be assigned to the Network Interface.</summary>
    [JsonPropertyName("dnsServers")]
    public IList<string>? DnsServers { get; set; }

    /// <summary>Does this Network Interface support Accelerated Networking? Defaults to false.</summary>
    [JsonPropertyName("enableAcceleratedNetworking")]
    public bool? EnableAcceleratedNetworking { get; set; }

    /// <summary>Does this Network Interface support IP Forwarding? Defaults to false.</summary>
    [JsonPropertyName("enableIpForwarding")]
    public bool? EnableIpForwarding { get; set; }

    /// <summary>One or more ip_configuration blocks as defined above.</summary>
    [JsonPropertyName("ipConfiguration")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfiguration>? IpConfiguration { get; set; }

    /// <summary>The Name which should be used for this Network Interface. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of a Network Security Group which should be assigned to this Network Interface.</summary>
    [JsonPropertyName("networkSecurityGroupId")]
    public string? NetworkSecurityGroupId { get; set; }

    /// <summary>Is this the Primary IP Configuration?</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderOsDiskDiffDiskSettings
{
    /// <summary>Specifies the Ephemeral Disk Settings for the OS Disk. At this time the only possible value is Local. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("option")]
    public string? Option { get; set; }

    /// <summary>Specifies where to store the Ephemeral Disk. Possible values are CacheDisk and ResourceDisk. Defaults to CacheDisk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("placement")]
    public string? Placement { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderOsDisk
{
    /// <summary>The Type of Caching which should be used for the Internal OS Disk. Possible values are None, ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>A diff_disk_settings block as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diffDiskSettings")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecForProviderOsDiskDiffDiskSettings>? DiffDiskSettings { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to encrypt this OS Disk. Conflicts with secure_vm_disk_encryption_set_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>The Size of the Internal OS Disk in GB, if you wish to vary from the size used in the image this Virtual Machine Scale Set is sourced from.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to Encrypt the OS Disk when the Virtual Machine Scale Set is Confidential VMSS. Conflicts with disk_encryption_set_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("secureVmDiskEncryptionSetId")]
    public string? SecureVmDiskEncryptionSetId { get; set; }

    /// <summary>Encryption Type when the Virtual Machine Scale Set is Confidential VMSS. Possible values are VMGuestStateOnly and DiskWithVMGuestState. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityEncryptionType")]
    public string? SecurityEncryptionType { get; set; }

    /// <summary>The Type of Storage Account which should back this the Internal OS Disk. Possible values include Standard_LRS, StandardSSD_LRS, StandardSSD_ZRS, Premium_LRS and Premium_ZRS. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>Should Write Accelerator be Enabled for this OS Disk? Defaults to false.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderPlan
{
    /// <summary>Specifies the name of the image from the marketplace. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the product of the image from the marketplace. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary>Specifies the publisher of the image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}

public enum V1beta1LinuxVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LinuxVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LinuxVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1LinuxVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LinuxVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1LinuxVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1LinuxVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LinuxVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LinuxVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1LinuxVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LinuxVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1LinuxVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderRollingUpgradePolicy
{
    /// <summary>Should the Virtual Machine Scale Set ignore the Azure Zone boundaries when constructing upgrade batches? Possible values are true or false.</summary>
    [JsonPropertyName("crossZoneUpgradesEnabled")]
    public bool? CrossZoneUpgradesEnabled { get; set; }

    /// <summary>The maximum percent of total virtual machine instances that will be upgraded simultaneously by the rolling upgrade in one batch. As this is a maximum, unhealthy instances in previous or future batches can cause the percentage of instances in a batch to decrease to ensure higher reliability.</summary>
    [JsonPropertyName("maxBatchInstancePercent")]
    public double? MaxBatchInstancePercent { get; set; }

    /// <summary>The maximum percentage of the total virtual machine instances in the scale set that can be simultaneously unhealthy, either as a result of being upgraded, or by being found in an unhealthy state by the virtual machine health checks before the rolling upgrade aborts. This constraint will be checked prior to starting any batch.</summary>
    [JsonPropertyName("maxUnhealthyInstancePercent")]
    public double? MaxUnhealthyInstancePercent { get; set; }

    /// <summary>The maximum percentage of upgraded virtual machine instances that can be found to be in an unhealthy state. This check will happen after each batch is upgraded. If this percentage is ever exceeded, the rolling update aborts.</summary>
    [JsonPropertyName("maxUnhealthyUpgradedInstancePercent")]
    public double? MaxUnhealthyUpgradedInstancePercent { get; set; }

    /// <summary>The wait time between completing the update for all virtual machines in one batch and starting the next batch. The time duration should be specified in ISO 8601 format.</summary>
    [JsonPropertyName("pauseTimeBetweenBatches")]
    public string? PauseTimeBetweenBatches { get; set; }

    /// <summary>Upgrade all unhealthy instances in a scale set before any healthy instances. Possible values are true or false.</summary>
    [JsonPropertyName("prioritizeUnhealthyInstancesEnabled")]
    public bool? PrioritizeUnhealthyInstancesEnabled { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderScaleIn
{
    /// <summary>Should the virtual machines chosen for removal be force deleted when the virtual machine scale set is being scaled-in? Possible values are true or false. Defaults to false.</summary>
    [JsonPropertyName("forceDeletionEnabled")]
    public bool? ForceDeletionEnabled { get; set; }

    /// <summary>The scale-in policy rule that decides which virtual machines are chosen for removal when a Virtual Machine Scale Set is scaled in. Possible values for the scale-in policy rules are Default, NewestVM and OldestVM, defaults to Default. For more information about scale in policy, please refer to this doc.</summary>
    [JsonPropertyName("rule")]
    public string? Rule { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderSecretCertificate
{
    /// <summary>The Secret URL of a Key Vault Certificate.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderSecret
{
    /// <summary>One or more certificate blocks as defined above.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecForProviderSecretCertificate>? Certificate { get; set; }

    /// <summary>The ID of the Key Vault from which all Secrets should be sourced.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderSourceImageReference
{
    /// <summary>Specifies the offer of the image used to create the virtual machines. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("offer")]
    public string? Offer { get; set; }

    /// <summary>Specifies the publisher of the image used to create the virtual machines. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>Specifies the SKU of the image used to create the virtual machines.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>Specifies the version of the image used to create the virtual machines.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderSpotRestore
{
    /// <summary>Should the Spot-Try-Restore feature be enabled? The Spot-Try-Restore feature will attempt to automatically restore the evicted Spot Virtual Machine Scale Set VM instances opportunistically based on capacity availability and pricing constraints. Possible values are true or false. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The length of time that the Virtual Machine Scale Set should attempt to restore the Spot VM instances which have been evicted. The time duration should be between 15 minutes and 120 minutes (inclusive). The time duration should be specified in the ISO 8601 format. Defaults to PT1H. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderTerminateNotification
{
    /// <summary>Should the terminate notification be enabled on this Virtual Machine Scale Set?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Length of time (in minutes, between 5 and 15) a notification to be sent to the VM on the instance metadata server till the VM gets deleted. The time duration should be specified in ISO 8601 format. Defaults to PT5M.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProviderTerminationNotification
{
    /// <summary>Should the termination notification be enabled on this Virtual Machine Scale Set?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Length of time (in minutes, between 5 and 15) a notification to be sent to the VM on the instance metadata server till the VM gets deleted. The time duration should be specified in ISO 8601 format. Defaults to PT5M.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecForProvider
{
    /// <summary>An additional_capabilities block as defined below.</summary>
    [JsonPropertyName("additionalCapabilities")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecForProviderAdditionalCapabilities>? AdditionalCapabilities { get; set; }

    /// <summary>The Password which should be used for the local-administrator on this Virtual Machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminPasswordSecretRef")]
    public V1beta1LinuxVirtualMachineScaleSetSpecForProviderAdminPasswordSecretRef? AdminPasswordSecretRef { get; set; }

    /// <summary>One or more admin_ssh_key blocks as defined below.</summary>
    [JsonPropertyName("adminSshKey")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecForProviderAdminSshKey>? AdminSshKey { get; set; }

    /// <summary>The username of the local administrator on each Virtual Machine Scale Set instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>An automatic_instance_repair block as defined below. To enable the automatic instance repair, this Virtual Machine Scale Set must have a valid health_probe_id or an Application Health Extension.</summary>
    [JsonPropertyName("automaticInstanceRepair")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecForProviderAutomaticInstanceRepair>? AutomaticInstanceRepair { get; set; }

    /// <summary>An automatic_os_upgrade_policy block as defined below. This can only be specified when upgrade_mode is set to either Automatic or Rolling.</summary>
    [JsonPropertyName("automaticOsUpgradePolicy")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecForProviderAutomaticOsUpgradePolicy>? AutomaticOsUpgradePolicy { get; set; }

    /// <summary>A boot_diagnostics block as defined below.</summary>
    [JsonPropertyName("bootDiagnostics")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecForProviderBootDiagnostics>? BootDiagnostics { get; set; }

    /// <summary>Specifies the ID of the Capacity Reservation Group which the Virtual Machine Scale Set should be allocated to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("capacityReservationGroupId")]
    public string? CapacityReservationGroupId { get; set; }

    /// <summary>The prefix which should be used for the name of the Virtual Machines in this Scale Set. If unspecified this defaults to the value for the name field. If the value of the name field is not a valid computer_name_prefix, then you must specify computer_name_prefix. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("computerNamePrefix")]
    public string? ComputerNamePrefix { get; set; }

    /// <summary>The Base64-Encoded Custom Data which should be used for this Virtual Machine Scale Set.</summary>
    [JsonPropertyName("customDataSecretRef")]
    public V1beta1LinuxVirtualMachineScaleSetSpecForProviderCustomDataSecretRef? CustomDataSecretRef { get; set; }

    /// <summary>One or more data_disk blocks as defined below.</summary>
    [JsonPropertyName("dataDisk")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecForProviderDataDisk>? DataDisk { get; set; }

    /// <summary>Should Password Authentication be disabled on this Virtual Machine Scale Set? Defaults to true.</summary>
    [JsonPropertyName("disablePasswordAuthentication")]
    public bool? DisablePasswordAuthentication { get; set; }

    /// <summary>Should Virtual Machine Extensions be run on Overprovisioned Virtual Machines in the Scale Set? Defaults to false.</summary>
    [JsonPropertyName("doNotRunExtensionsOnOverprovisionedMachines")]
    public bool? DoNotRunExtensionsOnOverprovisionedMachines { get; set; }

    /// <summary>Specifies the Edge Zone within the Azure Region where this Linux Virtual Machine Scale Set should exist. Changing this forces a new Linux Virtual Machine Scale Set to be created.</summary>
    [JsonPropertyName("edgeZone")]
    public string? EdgeZone { get; set; }

    /// <summary>Should all of the disks (including the temp disk) attached to this Virtual Machine be encrypted by enabling Encryption at Host?</summary>
    [JsonPropertyName("encryptionAtHostEnabled")]
    public bool? EncryptionAtHostEnabled { get; set; }

    /// <summary>Specifies the eviction policy for Virtual Machines in this Scale Set. Possible values are Deallocate and Delete. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>One or more extension blocks as defined below</summary>
    [JsonPropertyName("extension")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecForProviderExtension>? Extension { get; set; }

    /// <summary>Should extension operations be allowed on the Virtual Machine Scale Set? Possible values are true or false. Defaults to true. Changing this forces a new Linux Virtual Machine Scale Set to be created.</summary>
    [JsonPropertyName("extensionOperationsEnabled")]
    public bool? ExtensionOperationsEnabled { get; set; }

    /// <summary>Specifies the duration allocated for all extensions to start. The time duration should be between 15 minutes and 120 minutes (inclusive) and should be specified in ISO 8601 format. Defaults to PT1H30M.</summary>
    [JsonPropertyName("extensionsTimeBudget")]
    public string? ExtensionsTimeBudget { get; set; }

    /// <summary>One or more gallery_application blocks as defined below.</summary>
    [JsonPropertyName("galleryApplication")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecForProviderGalleryApplication>? GalleryApplication { get; set; }

    /// <summary></summary>
    [JsonPropertyName("galleryApplications")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecForProviderGalleryApplications>? GalleryApplications { get; set; }

    /// <summary>The ID of a Load Balancer Probe which should be used to determine the health of an instance. This is Required and can only be specified when upgrade_mode is set to Automatic or Rolling.</summary>
    [JsonPropertyName("healthProbeId")]
    public string? HealthProbeId { get; set; }

    /// <summary>Specifies the ID of the dedicated host group that the virtual machine scale set resides in. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hostGroupId")]
    public string? HostGroupId { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecForProviderIdentity>? Identity { get; set; }

    /// <summary>The number of Virtual Machines in the Scale Set. Defaults to 0.</summary>
    [JsonPropertyName("instances")]
    public double? Instances { get; set; }

    /// <summary>The Azure location where the Linux Virtual Machine Scale Set should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The maximum price you're willing to pay for each Virtual Machine in this Scale Set, in US Dollars; which must be greater than the current spot price. If this bid price falls below the current spot price the Virtual Machines in the Scale Set will be evicted using the eviction_policy. Defaults to -1, which means that each Virtual Machine in this Scale Set should not be evicted for price reasons.</summary>
    [JsonPropertyName("maxBidPrice")]
    public double? MaxBidPrice { get; set; }

    /// <summary>One or more network_interface blocks as defined below.</summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecForProviderNetworkInterface>? NetworkInterface { get; set; }

    /// <summary>An os_disk block as defined below.</summary>
    [JsonPropertyName("osDisk")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecForProviderOsDisk>? OsDisk { get; set; }

    /// <summary>Should Azure over-provision Virtual Machines in this Scale Set? This means that multiple Virtual Machines will be provisioned and Azure will keep the instances which become available first - which improves provisioning success rates and improves deployment time. You're not billed for these over-provisioned VM's and they don't count towards the Subscription Quota. Defaults to true.</summary>
    [JsonPropertyName("overprovision")]
    public bool? Overprovision { get; set; }

    /// <summary>A plan block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("plan")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecForProviderPlan>? Plan { get; set; }

    /// <summary>Specifies the number of fault domains that are used by this Linux Virtual Machine Scale Set. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("platformFaultDomainCount")]
    public double? PlatformFaultDomainCount { get; set; }

    /// <summary>The Priority of this Virtual Machine Scale Set. Possible values are Regular and Spot. Defaults to Regular. Changing this value forces a new resource.</summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>Should the Azure VM Agent be provisioned on each Virtual Machine in the Scale Set? Defaults to true. Changing this value forces a new resource to be created.</summary>
    [JsonPropertyName("provisionVmAgent")]
    public bool? ProvisionVmAgent { get; set; }

    /// <summary>The ID of the Proximity Placement Group in which the Virtual Machine Scale Set should be assigned to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("proximityPlacementGroupId")]
    public string? ProximityPlacementGroupId { get; set; }

    /// <summary>The name of the Resource Group in which the Linux Virtual Machine Scale Set should be exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1LinuxVirtualMachineScaleSetSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1LinuxVirtualMachineScaleSetSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A rolling_upgrade_policy block as defined below. This is Required and can only be specified when upgrade_mode is set to Automatic or Rolling. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("rollingUpgradePolicy")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecForProviderRollingUpgradePolicy>? RollingUpgradePolicy { get; set; }

    /// <summary>A scale_in block as defined below.</summary>
    [JsonPropertyName("scaleIn")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecForProviderScaleIn>? ScaleIn { get; set; }

    /// <summary>One or more secret blocks as defined below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecForProviderSecret>? Secret { get; set; }

    /// <summary>Specifies whether secure boot should be enabled on the virtual machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("secureBootEnabled")]
    public bool? SecureBootEnabled { get; set; }

    /// <summary>Should this Virtual Machine Scale Set be limited to a Single Placement Group, which means the number of instances will be capped at 100 Virtual Machines. Defaults to true.</summary>
    [JsonPropertyName("singlePlacementGroup")]
    public bool? SinglePlacementGroup { get; set; }

    /// <summary>The Virtual Machine SKU for the Scale Set, such as Standard_F2.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>The ID of an Image which each Virtual Machine in this Scale Set should be based on. Possible Image ID types include Image ID, Shared Image ID, Shared Image Version ID, Community Gallery Image ID, Community Gallery Image Version ID, Shared Gallery Image ID and Shared Gallery Image Version ID.</summary>
    [JsonPropertyName("sourceImageId")]
    public string? SourceImageId { get; set; }

    /// <summary>A source_image_reference block as defined below.</summary>
    [JsonPropertyName("sourceImageReference")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecForProviderSourceImageReference>? SourceImageReference { get; set; }

    /// <summary>A spot_restore block as defined below.</summary>
    [JsonPropertyName("spotRestore")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecForProviderSpotRestore>? SpotRestore { get; set; }

    /// <summary>A mapping of tags which should be assigned to this Virtual Machine Scale Set.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A terminate_notification block as defined below.</summary>
    [JsonPropertyName("terminateNotification")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecForProviderTerminateNotification>? TerminateNotification { get; set; }

    /// <summary>A termination_notification block as defined below.</summary>
    [JsonPropertyName("terminationNotification")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecForProviderTerminationNotification>? TerminationNotification { get; set; }

    /// <summary>Specifies how Upgrades (e.g. changing the Image/SKU) should be performed to Virtual Machine Instances. Possible values are Automatic, Manual and Rolling. Defaults to Manual. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("upgradeMode")]
    public string? UpgradeMode { get; set; }

    /// <summary>The Base64-Encoded User Data which should be used for this Virtual Machine Scale Set.</summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary>Specifies whether vTPM should be enabled on the virtual machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vtpmEnabled")]
    public bool? VtpmEnabled { get; set; }

    /// <summary>Should the Virtual Machines in this Scale Set be strictly evenly distributed across Availability Zones? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("zoneBalance")]
    public bool? ZoneBalance { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this Linux Virtual Machine Scale Set should be located. Changing this forces a new Linux Virtual Machine Scale Set to be created.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecInitProviderAdditionalCapabilities
{
    /// <summary>Should the capacity to enable Data Disks of the UltraSSD_LRS storage account type be supported on this Virtual Machine Scale Set? Possible values are true or false. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ultraSsdEnabled")]
    public bool? UltraSsdEnabled { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecInitProviderAdminSshKey
{
    /// <summary>The Public Key which should be used for authentication, which needs to be at least 2048-bit and in ssh-rsa format.</summary>
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    /// <summary>The Username for which this Public SSH Key should be configured.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecInitProviderAutomaticInstanceRepair
{
    /// <summary>Should the automatic instance repair be enabled on this Virtual Machine Scale Set?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Amount of time (in minutes, between 30 and 90) for which automatic repairs will be delayed. The grace period starts right after the VM is found unhealthy. The time duration should be specified in ISO 8601 format. Defaults to PT30M.</summary>
    [JsonPropertyName("gracePeriod")]
    public string? GracePeriod { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecInitProviderAutomaticOsUpgradePolicy
{
    /// <summary>Should automatic rollbacks be disabled?</summary>
    [JsonPropertyName("disableAutomaticRollback")]
    public bool? DisableAutomaticRollback { get; set; }

    /// <summary>Should OS Upgrades automatically be applied to Scale Set instances in a rolling fashion when a newer version of the OS Image becomes available?</summary>
    [JsonPropertyName("enableAutomaticOsUpgrade")]
    public bool? EnableAutomaticOsUpgrade { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecInitProviderBootDiagnostics
{
    /// <summary>The Primary/Secondary Endpoint for the Azure Storage Account which should be used to store Boot Diagnostics, including Console Output and Screenshots from the Hypervisor.</summary>
    [JsonPropertyName("storageAccountUri")]
    public string? StorageAccountUri { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecInitProviderDataDisk
{
    /// <summary>The type of Caching which should be used for this Data Disk. Possible values are None, ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>The create option which should be used for this Data Disk. Possible values are Empty and FromImage. Defaults to Empty. (FromImage should only be used if the source image includes data disks).</summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to encrypt this OS Disk. Conflicts with secure_vm_disk_encryption_set_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>The size of the Data Disk which should be created.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The Logical Unit Number of the Data Disk, which must be unique within the Virtual Machine.</summary>
    [JsonPropertyName("lun")]
    public double? Lun { get; set; }

    /// <summary>The name of the Data Disk.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Type of Storage Account which should back this Data Disk. Possible values include Standard_LRS, StandardSSD_LRS, StandardSSD_ZRS, Premium_LRS, PremiumV2_LRS, Premium_ZRS and UltraSSD_LRS.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>Specifies the Read-Write IOPS for this Data Disk. Only settable when storage_account_type is PremiumV2_LRS or UltraSSD_LRS.</summary>
    [JsonPropertyName("ultraSsdDiskIopsReadWrite")]
    public double? UltraSsdDiskIopsReadWrite { get; set; }

    /// <summary>Specifies the bandwidth in MB per second for this Data Disk. Only settable when storage_account_type is PremiumV2_LRS or UltraSSD_LRS.</summary>
    [JsonPropertyName("ultraSsdDiskMbpsReadWrite")]
    public double? UltraSsdDiskMbpsReadWrite { get; set; }

    /// <summary>Should Write Accelerator be Enabled for this OS Disk? Defaults to false.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecInitProviderExtensionProtectedSettingsFromKeyVault
{
    /// <summary>The URL to the Key Vault Secret which stores the protected settings.</summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>The ID of the source Key Vault.</summary>
    [JsonPropertyName("sourceVaultId")]
    public string? SourceVaultId { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecInitProviderExtension
{
    /// <summary>Should the latest version of the Extension be used at Deployment Time, if one is available? This won't auto-update the extension on existing installation. Defaults to true.</summary>
    [JsonPropertyName("autoUpgradeMinorVersion")]
    public bool? AutoUpgradeMinorVersion { get; set; }

    /// <summary>Should the Extension be automatically updated whenever the Publisher releases a new version of this VM Extension?</summary>
    [JsonPropertyName("automaticUpgradeEnabled")]
    public bool? AutomaticUpgradeEnabled { get; set; }

    /// <summary>A value which, when different to the previous value can be used to force-run the Extension even if the Extension Configuration hasn't changed.</summary>
    [JsonPropertyName("forceUpdateTag")]
    public string? ForceUpdateTag { get; set; }

    /// <summary>The name for the Virtual Machine Scale Set Extension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A protected_settings_from_key_vault block as defined below.</summary>
    [JsonPropertyName("protectedSettingsFromKeyVault")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecInitProviderExtensionProtectedSettingsFromKeyVault>? ProtectedSettingsFromKeyVault { get; set; }

    /// <summary>An ordered list of Extension names which this should be provisioned after.</summary>
    [JsonPropertyName("provisionAfterExtensions")]
    public IList<string>? ProvisionAfterExtensions { get; set; }

    /// <summary>Specifies the Publisher of the Extension.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>A JSON String which specifies Settings for the Extension.</summary>
    [JsonPropertyName("settings")]
    public string? Settings { get; set; }

    /// <summary>Specifies the Type of the Extension.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Specifies the version of the extension to use, available versions can be found using the Azure CLI.</summary>
    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecInitProviderGalleryApplication
{
    /// <summary>Specifies the URI to an Azure Blob that will replace the default configuration for the package if provided. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("configurationBlobUri")]
    public string? ConfigurationBlobUri { get; set; }

    /// <summary>Specifies the order in which the packages have to be installed. Possible values are between 0 and 2,147,483,647. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>Specifies a passthrough value for more generic context. This field can be any valid string value. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>Specifies the Gallery Application Version resource ID. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("versionId")]
    public string? VersionId { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecInitProviderGalleryApplications
{
    /// <summary></summary>
    [JsonPropertyName("configurationReferenceBlobUri")]
    public string? ConfigurationReferenceBlobUri { get; set; }

    /// <summary>Specifies the order in which the packages have to be installed. Possible values are between 0 and 2,147,483,647. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>The ID of the Linux Virtual Machine Scale Set.</summary>
    [JsonPropertyName("packageReferenceId")]
    public string? PackageReferenceId { get; set; }

    /// <summary>The IP Tag associated with the Public IP, such as SQL or Storage. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Linux Virtual Machine Scale Set.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Linux Virtual Machine Scale Set. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationPublicIpAddressIpTag
{
    /// <summary>The IP Tag associated with the Public IP, such as SQL or Storage. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The Type of IP Tag, such as FirstPartyUsage. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationPublicIpAddress
{
    /// <summary>The Prefix which should be used for the Domain Name Label for each Virtual Machine Instance. Azure concatenates the Domain Name Label and Virtual Machine Index to create a unique Domain Name Label for each Virtual Machine.</summary>
    [JsonPropertyName("domainNameLabel")]
    public string? DomainNameLabel { get; set; }

    /// <summary>The Idle Timeout in Minutes for the Public IP Address. Possible values are in the range 4 to 32.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>One or more ip_tag blocks as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ipTag")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationPublicIpAddressIpTag>? IpTag { get; set; }

    /// <summary>The Name of the Public IP Address Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Public IP Address Prefix from where Public IP Addresses should be allocated. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicIpPrefixId")]
    public string? PublicIpPrefixId { get; set; }

    /// <summary>Specifies the version of the image used to create the virtual machines.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public enum V1beta1LinuxVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LinuxVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LinuxVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1LinuxVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LinuxVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolveEnum>))]
    public V1beta1LinuxVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

public enum V1beta1LinuxVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LinuxVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LinuxVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1LinuxVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LinuxVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1LinuxVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfiguration
{
    /// <summary>A list of Backend Address Pools ID's from a Application Gateway which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("applicationGatewayBackendAddressPoolIds")]
    public IList<string>? ApplicationGatewayBackendAddressPoolIds { get; set; }

    /// <summary>A list of Application Security Group ID's which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("applicationSecurityGroupIds")]
    public IList<string>? ApplicationSecurityGroupIds { get; set; }

    /// <summary>A list of Backend Address Pools ID's from a Load Balancer which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("loadBalancerBackendAddressPoolIds")]
    public IList<string>? LoadBalancerBackendAddressPoolIds { get; set; }

    /// <summary>A list of NAT Rule ID's from a Load Balancer which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("loadBalancerInboundNatRulesIds")]
    public IList<string>? LoadBalancerInboundNatRulesIds { get; set; }

    /// <summary>The Name of the Public IP Address Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this the Primary IP Configuration?</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>A public_ip_address block as defined below.</summary>
    [JsonPropertyName("publicIpAddress")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationPublicIpAddress>? PublicIpAddress { get; set; }

    /// <summary>The ID of the Subnet which this IP Configuration should be connected to.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1LinuxVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1LinuxVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>Specifies the version of the image used to create the virtual machines.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecInitProviderNetworkInterface
{
    /// <summary>A list of IP Addresses of DNS Servers which should be assigned to the Network Interface.</summary>
    [JsonPropertyName("dnsServers")]
    public IList<string>? DnsServers { get; set; }

    /// <summary>Does this Network Interface support Accelerated Networking? Defaults to false.</summary>
    [JsonPropertyName("enableAcceleratedNetworking")]
    public bool? EnableAcceleratedNetworking { get; set; }

    /// <summary>Does this Network Interface support IP Forwarding? Defaults to false.</summary>
    [JsonPropertyName("enableIpForwarding")]
    public bool? EnableIpForwarding { get; set; }

    /// <summary>One or more ip_configuration blocks as defined above.</summary>
    [JsonPropertyName("ipConfiguration")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfiguration>? IpConfiguration { get; set; }

    /// <summary>The Name which should be used for this Network Interface. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of a Network Security Group which should be assigned to this Network Interface.</summary>
    [JsonPropertyName("networkSecurityGroupId")]
    public string? NetworkSecurityGroupId { get; set; }

    /// <summary>Is this the Primary IP Configuration?</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecInitProviderOsDiskDiffDiskSettings
{
    /// <summary>Specifies the Ephemeral Disk Settings for the OS Disk. At this time the only possible value is Local. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("option")]
    public string? Option { get; set; }

    /// <summary>Specifies where to store the Ephemeral Disk. Possible values are CacheDisk and ResourceDisk. Defaults to CacheDisk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("placement")]
    public string? Placement { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecInitProviderOsDisk
{
    /// <summary>The Type of Caching which should be used for the Internal OS Disk. Possible values are None, ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>A diff_disk_settings block as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diffDiskSettings")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecInitProviderOsDiskDiffDiskSettings>? DiffDiskSettings { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to encrypt this OS Disk. Conflicts with secure_vm_disk_encryption_set_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>The Size of the Internal OS Disk in GB, if you wish to vary from the size used in the image this Virtual Machine Scale Set is sourced from.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to Encrypt the OS Disk when the Virtual Machine Scale Set is Confidential VMSS. Conflicts with disk_encryption_set_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("secureVmDiskEncryptionSetId")]
    public string? SecureVmDiskEncryptionSetId { get; set; }

    /// <summary>Encryption Type when the Virtual Machine Scale Set is Confidential VMSS. Possible values are VMGuestStateOnly and DiskWithVMGuestState. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityEncryptionType")]
    public string? SecurityEncryptionType { get; set; }

    /// <summary>The Type of Storage Account which should back this the Internal OS Disk. Possible values include Standard_LRS, StandardSSD_LRS, StandardSSD_ZRS, Premium_LRS and Premium_ZRS. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>Should Write Accelerator be Enabled for this OS Disk? Defaults to false.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecInitProviderPlan
{
    /// <summary>Specifies the name of the image from the marketplace. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the product of the image from the marketplace. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary>Specifies the publisher of the image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecInitProviderRollingUpgradePolicy
{
    /// <summary>Should the Virtual Machine Scale Set ignore the Azure Zone boundaries when constructing upgrade batches? Possible values are true or false.</summary>
    [JsonPropertyName("crossZoneUpgradesEnabled")]
    public bool? CrossZoneUpgradesEnabled { get; set; }

    /// <summary>The maximum percent of total virtual machine instances that will be upgraded simultaneously by the rolling upgrade in one batch. As this is a maximum, unhealthy instances in previous or future batches can cause the percentage of instances in a batch to decrease to ensure higher reliability.</summary>
    [JsonPropertyName("maxBatchInstancePercent")]
    public double? MaxBatchInstancePercent { get; set; }

    /// <summary>The maximum percentage of the total virtual machine instances in the scale set that can be simultaneously unhealthy, either as a result of being upgraded, or by being found in an unhealthy state by the virtual machine health checks before the rolling upgrade aborts. This constraint will be checked prior to starting any batch.</summary>
    [JsonPropertyName("maxUnhealthyInstancePercent")]
    public double? MaxUnhealthyInstancePercent { get; set; }

    /// <summary>The maximum percentage of upgraded virtual machine instances that can be found to be in an unhealthy state. This check will happen after each batch is upgraded. If this percentage is ever exceeded, the rolling update aborts.</summary>
    [JsonPropertyName("maxUnhealthyUpgradedInstancePercent")]
    public double? MaxUnhealthyUpgradedInstancePercent { get; set; }

    /// <summary>The wait time between completing the update for all virtual machines in one batch and starting the next batch. The time duration should be specified in ISO 8601 format.</summary>
    [JsonPropertyName("pauseTimeBetweenBatches")]
    public string? PauseTimeBetweenBatches { get; set; }

    /// <summary>Upgrade all unhealthy instances in a scale set before any healthy instances. Possible values are true or false.</summary>
    [JsonPropertyName("prioritizeUnhealthyInstancesEnabled")]
    public bool? PrioritizeUnhealthyInstancesEnabled { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecInitProviderScaleIn
{
    /// <summary>Should the virtual machines chosen for removal be force deleted when the virtual machine scale set is being scaled-in? Possible values are true or false. Defaults to false.</summary>
    [JsonPropertyName("forceDeletionEnabled")]
    public bool? ForceDeletionEnabled { get; set; }

    /// <summary>The scale-in policy rule that decides which virtual machines are chosen for removal when a Virtual Machine Scale Set is scaled in. Possible values for the scale-in policy rules are Default, NewestVM and OldestVM, defaults to Default. For more information about scale in policy, please refer to this doc.</summary>
    [JsonPropertyName("rule")]
    public string? Rule { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecInitProviderSecretCertificate
{
    /// <summary>The Secret URL of a Key Vault Certificate.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecInitProviderSecret
{
    /// <summary>One or more certificate blocks as defined above.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecInitProviderSecretCertificate>? Certificate { get; set; }

    /// <summary>The ID of the Key Vault from which all Secrets should be sourced.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecInitProviderSourceImageReference
{
    /// <summary>Specifies the offer of the image used to create the virtual machines. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("offer")]
    public string? Offer { get; set; }

    /// <summary>Specifies the publisher of the image used to create the virtual machines. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>Specifies the SKU of the image used to create the virtual machines.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>Specifies the version of the image used to create the virtual machines.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecInitProviderSpotRestore
{
    /// <summary>Should the Spot-Try-Restore feature be enabled? The Spot-Try-Restore feature will attempt to automatically restore the evicted Spot Virtual Machine Scale Set VM instances opportunistically based on capacity availability and pricing constraints. Possible values are true or false. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The length of time that the Virtual Machine Scale Set should attempt to restore the Spot VM instances which have been evicted. The time duration should be between 15 minutes and 120 minutes (inclusive). The time duration should be specified in the ISO 8601 format. Defaults to PT1H. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecInitProviderTerminateNotification
{
    /// <summary>Should the terminate notification be enabled on this Virtual Machine Scale Set?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Length of time (in minutes, between 5 and 15) a notification to be sent to the VM on the instance metadata server till the VM gets deleted. The time duration should be specified in ISO 8601 format. Defaults to PT5M.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecInitProviderTerminationNotification
{
    /// <summary>Should the termination notification be enabled on this Virtual Machine Scale Set?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Length of time (in minutes, between 5 and 15) a notification to be sent to the VM on the instance metadata server till the VM gets deleted. The time duration should be specified in ISO 8601 format. Defaults to PT5M.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecInitProvider
{
    /// <summary>An additional_capabilities block as defined below.</summary>
    [JsonPropertyName("additionalCapabilities")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecInitProviderAdditionalCapabilities>? AdditionalCapabilities { get; set; }

    /// <summary>One or more admin_ssh_key blocks as defined below.</summary>
    [JsonPropertyName("adminSshKey")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecInitProviderAdminSshKey>? AdminSshKey { get; set; }

    /// <summary>The username of the local administrator on each Virtual Machine Scale Set instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>An automatic_instance_repair block as defined below. To enable the automatic instance repair, this Virtual Machine Scale Set must have a valid health_probe_id or an Application Health Extension.</summary>
    [JsonPropertyName("automaticInstanceRepair")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecInitProviderAutomaticInstanceRepair>? AutomaticInstanceRepair { get; set; }

    /// <summary>An automatic_os_upgrade_policy block as defined below. This can only be specified when upgrade_mode is set to either Automatic or Rolling.</summary>
    [JsonPropertyName("automaticOsUpgradePolicy")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecInitProviderAutomaticOsUpgradePolicy>? AutomaticOsUpgradePolicy { get; set; }

    /// <summary>A boot_diagnostics block as defined below.</summary>
    [JsonPropertyName("bootDiagnostics")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecInitProviderBootDiagnostics>? BootDiagnostics { get; set; }

    /// <summary>Specifies the ID of the Capacity Reservation Group which the Virtual Machine Scale Set should be allocated to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("capacityReservationGroupId")]
    public string? CapacityReservationGroupId { get; set; }

    /// <summary>The prefix which should be used for the name of the Virtual Machines in this Scale Set. If unspecified this defaults to the value for the name field. If the value of the name field is not a valid computer_name_prefix, then you must specify computer_name_prefix. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("computerNamePrefix")]
    public string? ComputerNamePrefix { get; set; }

    /// <summary>One or more data_disk blocks as defined below.</summary>
    [JsonPropertyName("dataDisk")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecInitProviderDataDisk>? DataDisk { get; set; }

    /// <summary>Should Password Authentication be disabled on this Virtual Machine Scale Set? Defaults to true.</summary>
    [JsonPropertyName("disablePasswordAuthentication")]
    public bool? DisablePasswordAuthentication { get; set; }

    /// <summary>Should Virtual Machine Extensions be run on Overprovisioned Virtual Machines in the Scale Set? Defaults to false.</summary>
    [JsonPropertyName("doNotRunExtensionsOnOverprovisionedMachines")]
    public bool? DoNotRunExtensionsOnOverprovisionedMachines { get; set; }

    /// <summary>Specifies the Edge Zone within the Azure Region where this Linux Virtual Machine Scale Set should exist. Changing this forces a new Linux Virtual Machine Scale Set to be created.</summary>
    [JsonPropertyName("edgeZone")]
    public string? EdgeZone { get; set; }

    /// <summary>Should all of the disks (including the temp disk) attached to this Virtual Machine be encrypted by enabling Encryption at Host?</summary>
    [JsonPropertyName("encryptionAtHostEnabled")]
    public bool? EncryptionAtHostEnabled { get; set; }

    /// <summary>Specifies the eviction policy for Virtual Machines in this Scale Set. Possible values are Deallocate and Delete. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>One or more extension blocks as defined below</summary>
    [JsonPropertyName("extension")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecInitProviderExtension>? Extension { get; set; }

    /// <summary>Should extension operations be allowed on the Virtual Machine Scale Set? Possible values are true or false. Defaults to true. Changing this forces a new Linux Virtual Machine Scale Set to be created.</summary>
    [JsonPropertyName("extensionOperationsEnabled")]
    public bool? ExtensionOperationsEnabled { get; set; }

    /// <summary>Specifies the duration allocated for all extensions to start. The time duration should be between 15 minutes and 120 minutes (inclusive) and should be specified in ISO 8601 format. Defaults to PT1H30M.</summary>
    [JsonPropertyName("extensionsTimeBudget")]
    public string? ExtensionsTimeBudget { get; set; }

    /// <summary>One or more gallery_application blocks as defined below.</summary>
    [JsonPropertyName("galleryApplication")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecInitProviderGalleryApplication>? GalleryApplication { get; set; }

    /// <summary></summary>
    [JsonPropertyName("galleryApplications")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecInitProviderGalleryApplications>? GalleryApplications { get; set; }

    /// <summary>The ID of a Load Balancer Probe which should be used to determine the health of an instance. This is Required and can only be specified when upgrade_mode is set to Automatic or Rolling.</summary>
    [JsonPropertyName("healthProbeId")]
    public string? HealthProbeId { get; set; }

    /// <summary>Specifies the ID of the dedicated host group that the virtual machine scale set resides in. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hostGroupId")]
    public string? HostGroupId { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecInitProviderIdentity>? Identity { get; set; }

    /// <summary>The number of Virtual Machines in the Scale Set. Defaults to 0.</summary>
    [JsonPropertyName("instances")]
    public double? Instances { get; set; }

    /// <summary>The Azure location where the Linux Virtual Machine Scale Set should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The maximum price you're willing to pay for each Virtual Machine in this Scale Set, in US Dollars; which must be greater than the current spot price. If this bid price falls below the current spot price the Virtual Machines in the Scale Set will be evicted using the eviction_policy. Defaults to -1, which means that each Virtual Machine in this Scale Set should not be evicted for price reasons.</summary>
    [JsonPropertyName("maxBidPrice")]
    public double? MaxBidPrice { get; set; }

    /// <summary>One or more network_interface blocks as defined below.</summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecInitProviderNetworkInterface>? NetworkInterface { get; set; }

    /// <summary>An os_disk block as defined below.</summary>
    [JsonPropertyName("osDisk")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecInitProviderOsDisk>? OsDisk { get; set; }

    /// <summary>Should Azure over-provision Virtual Machines in this Scale Set? This means that multiple Virtual Machines will be provisioned and Azure will keep the instances which become available first - which improves provisioning success rates and improves deployment time. You're not billed for these over-provisioned VM's and they don't count towards the Subscription Quota. Defaults to true.</summary>
    [JsonPropertyName("overprovision")]
    public bool? Overprovision { get; set; }

    /// <summary>A plan block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("plan")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecInitProviderPlan>? Plan { get; set; }

    /// <summary>Specifies the number of fault domains that are used by this Linux Virtual Machine Scale Set. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("platformFaultDomainCount")]
    public double? PlatformFaultDomainCount { get; set; }

    /// <summary>The Priority of this Virtual Machine Scale Set. Possible values are Regular and Spot. Defaults to Regular. Changing this value forces a new resource.</summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>Should the Azure VM Agent be provisioned on each Virtual Machine in the Scale Set? Defaults to true. Changing this value forces a new resource to be created.</summary>
    [JsonPropertyName("provisionVmAgent")]
    public bool? ProvisionVmAgent { get; set; }

    /// <summary>The ID of the Proximity Placement Group in which the Virtual Machine Scale Set should be assigned to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("proximityPlacementGroupId")]
    public string? ProximityPlacementGroupId { get; set; }

    /// <summary>A rolling_upgrade_policy block as defined below. This is Required and can only be specified when upgrade_mode is set to Automatic or Rolling. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("rollingUpgradePolicy")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecInitProviderRollingUpgradePolicy>? RollingUpgradePolicy { get; set; }

    /// <summary>A scale_in block as defined below.</summary>
    [JsonPropertyName("scaleIn")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecInitProviderScaleIn>? ScaleIn { get; set; }

    /// <summary>One or more secret blocks as defined below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecInitProviderSecret>? Secret { get; set; }

    /// <summary>Specifies whether secure boot should be enabled on the virtual machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("secureBootEnabled")]
    public bool? SecureBootEnabled { get; set; }

    /// <summary>Should this Virtual Machine Scale Set be limited to a Single Placement Group, which means the number of instances will be capped at 100 Virtual Machines. Defaults to true.</summary>
    [JsonPropertyName("singlePlacementGroup")]
    public bool? SinglePlacementGroup { get; set; }

    /// <summary>The Virtual Machine SKU for the Scale Set, such as Standard_F2.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>The ID of an Image which each Virtual Machine in this Scale Set should be based on. Possible Image ID types include Image ID, Shared Image ID, Shared Image Version ID, Community Gallery Image ID, Community Gallery Image Version ID, Shared Gallery Image ID and Shared Gallery Image Version ID.</summary>
    [JsonPropertyName("sourceImageId")]
    public string? SourceImageId { get; set; }

    /// <summary>A source_image_reference block as defined below.</summary>
    [JsonPropertyName("sourceImageReference")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecInitProviderSourceImageReference>? SourceImageReference { get; set; }

    /// <summary>A spot_restore block as defined below.</summary>
    [JsonPropertyName("spotRestore")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecInitProviderSpotRestore>? SpotRestore { get; set; }

    /// <summary>A mapping of tags which should be assigned to this Virtual Machine Scale Set.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A terminate_notification block as defined below.</summary>
    [JsonPropertyName("terminateNotification")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecInitProviderTerminateNotification>? TerminateNotification { get; set; }

    /// <summary>A termination_notification block as defined below.</summary>
    [JsonPropertyName("terminationNotification")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecInitProviderTerminationNotification>? TerminationNotification { get; set; }

    /// <summary>Specifies how Upgrades (e.g. changing the Image/SKU) should be performed to Virtual Machine Instances. Possible values are Automatic, Manual and Rolling. Defaults to Manual. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("upgradeMode")]
    public string? UpgradeMode { get; set; }

    /// <summary>The Base64-Encoded User Data which should be used for this Virtual Machine Scale Set.</summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary>Specifies whether vTPM should be enabled on the virtual machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vtpmEnabled")]
    public bool? VtpmEnabled { get; set; }

    /// <summary>Should the Virtual Machines in this Scale Set be strictly evenly distributed across Availability Zones? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("zoneBalance")]
    public bool? ZoneBalance { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this Linux Virtual Machine Scale Set should be located. Changing this forces a new Linux Virtual Machine Scale Set to be created.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

public enum V1beta1LinuxVirtualMachineScaleSetSpecManagementPoliciesEnum
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

public enum V1beta1LinuxVirtualMachineScaleSetSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LinuxVirtualMachineScaleSetSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LinuxVirtualMachineScaleSetSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1LinuxVirtualMachineScaleSetSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LinuxVirtualMachineScaleSetSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1LinuxVirtualMachineScaleSetSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxVirtualMachineScaleSetSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1LinuxVirtualMachineScaleSetSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1LinuxVirtualMachineScaleSetSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LinuxVirtualMachineScaleSetSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1LinuxVirtualMachineScaleSetSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LinuxVirtualMachineScaleSetSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1LinuxVirtualMachineScaleSetSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxVirtualMachineScaleSetSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1LinuxVirtualMachineScaleSetSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1LinuxVirtualMachineScaleSetSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1LinuxVirtualMachineScaleSetSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>LinuxVirtualMachineScaleSetSpec defines the desired state of LinuxVirtualMachineScaleSet</summary>
public partial class V1beta1LinuxVirtualMachineScaleSetSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1LinuxVirtualMachineScaleSetSpecDeletionPolicyEnum>))]
    public V1beta1LinuxVirtualMachineScaleSetSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1LinuxVirtualMachineScaleSetSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1LinuxVirtualMachineScaleSetSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1LinuxVirtualMachineScaleSetSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1LinuxVirtualMachineScaleSetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1LinuxVirtualMachineScaleSetSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1LinuxVirtualMachineScaleSetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetStatusAtProviderAdditionalCapabilities
{
    /// <summary>Should the capacity to enable Data Disks of the UltraSSD_LRS storage account type be supported on this Virtual Machine Scale Set? Possible values are true or false. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ultraSsdEnabled")]
    public bool? UltraSsdEnabled { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetStatusAtProviderAdminSshKey
{
    /// <summary>The Public Key which should be used for authentication, which needs to be at least 2048-bit and in ssh-rsa format.</summary>
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    /// <summary>The Username for which this Public SSH Key should be configured.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetStatusAtProviderAutomaticInstanceRepair
{
    /// <summary>Should the automatic instance repair be enabled on this Virtual Machine Scale Set?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Amount of time (in minutes, between 30 and 90) for which automatic repairs will be delayed. The grace period starts right after the VM is found unhealthy. The time duration should be specified in ISO 8601 format. Defaults to PT30M.</summary>
    [JsonPropertyName("gracePeriod")]
    public string? GracePeriod { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetStatusAtProviderAutomaticOsUpgradePolicy
{
    /// <summary>Should automatic rollbacks be disabled?</summary>
    [JsonPropertyName("disableAutomaticRollback")]
    public bool? DisableAutomaticRollback { get; set; }

    /// <summary>Should OS Upgrades automatically be applied to Scale Set instances in a rolling fashion when a newer version of the OS Image becomes available?</summary>
    [JsonPropertyName("enableAutomaticOsUpgrade")]
    public bool? EnableAutomaticOsUpgrade { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetStatusAtProviderBootDiagnostics
{
    /// <summary>The Primary/Secondary Endpoint for the Azure Storage Account which should be used to store Boot Diagnostics, including Console Output and Screenshots from the Hypervisor.</summary>
    [JsonPropertyName("storageAccountUri")]
    public string? StorageAccountUri { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetStatusAtProviderDataDisk
{
    /// <summary>The type of Caching which should be used for this Data Disk. Possible values are None, ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>The create option which should be used for this Data Disk. Possible values are Empty and FromImage. Defaults to Empty. (FromImage should only be used if the source image includes data disks).</summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to encrypt this OS Disk. Conflicts with secure_vm_disk_encryption_set_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>The size of the Data Disk which should be created.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The Logical Unit Number of the Data Disk, which must be unique within the Virtual Machine.</summary>
    [JsonPropertyName("lun")]
    public double? Lun { get; set; }

    /// <summary>The name of the Data Disk.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Type of Storage Account which should back this Data Disk. Possible values include Standard_LRS, StandardSSD_LRS, StandardSSD_ZRS, Premium_LRS, PremiumV2_LRS, Premium_ZRS and UltraSSD_LRS.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>Specifies the Read-Write IOPS for this Data Disk. Only settable when storage_account_type is PremiumV2_LRS or UltraSSD_LRS.</summary>
    [JsonPropertyName("ultraSsdDiskIopsReadWrite")]
    public double? UltraSsdDiskIopsReadWrite { get; set; }

    /// <summary>Specifies the bandwidth in MB per second for this Data Disk. Only settable when storage_account_type is PremiumV2_LRS or UltraSSD_LRS.</summary>
    [JsonPropertyName("ultraSsdDiskMbpsReadWrite")]
    public double? UltraSsdDiskMbpsReadWrite { get; set; }

    /// <summary>Should Write Accelerator be Enabled for this OS Disk? Defaults to false.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetStatusAtProviderExtensionProtectedSettingsFromKeyVault
{
    /// <summary>The URL to the Key Vault Secret which stores the protected settings.</summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>The ID of the source Key Vault.</summary>
    [JsonPropertyName("sourceVaultId")]
    public string? SourceVaultId { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetStatusAtProviderExtension
{
    /// <summary>Should the latest version of the Extension be used at Deployment Time, if one is available? This won't auto-update the extension on existing installation. Defaults to true.</summary>
    [JsonPropertyName("autoUpgradeMinorVersion")]
    public bool? AutoUpgradeMinorVersion { get; set; }

    /// <summary>Should the Extension be automatically updated whenever the Publisher releases a new version of this VM Extension?</summary>
    [JsonPropertyName("automaticUpgradeEnabled")]
    public bool? AutomaticUpgradeEnabled { get; set; }

    /// <summary>A value which, when different to the previous value can be used to force-run the Extension even if the Extension Configuration hasn't changed.</summary>
    [JsonPropertyName("forceUpdateTag")]
    public string? ForceUpdateTag { get; set; }

    /// <summary>The name for the Virtual Machine Scale Set Extension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A protected_settings_from_key_vault block as defined below.</summary>
    [JsonPropertyName("protectedSettingsFromKeyVault")]
    public IList<V1beta1LinuxVirtualMachineScaleSetStatusAtProviderExtensionProtectedSettingsFromKeyVault>? ProtectedSettingsFromKeyVault { get; set; }

    /// <summary>An ordered list of Extension names which this should be provisioned after.</summary>
    [JsonPropertyName("provisionAfterExtensions")]
    public IList<string>? ProvisionAfterExtensions { get; set; }

    /// <summary>Specifies the Publisher of the Extension.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>A JSON String which specifies Settings for the Extension.</summary>
    [JsonPropertyName("settings")]
    public string? Settings { get; set; }

    /// <summary>Specifies the Type of the Extension.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Specifies the version of the extension to use, available versions can be found using the Azure CLI.</summary>
    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetStatusAtProviderGalleryApplication
{
    /// <summary>Specifies the URI to an Azure Blob that will replace the default configuration for the package if provided. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("configurationBlobUri")]
    public string? ConfigurationBlobUri { get; set; }

    /// <summary>Specifies the order in which the packages have to be installed. Possible values are between 0 and 2,147,483,647. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>Specifies a passthrough value for more generic context. This field can be any valid string value. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>Specifies the Gallery Application Version resource ID. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("versionId")]
    public string? VersionId { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetStatusAtProviderGalleryApplications
{
    /// <summary></summary>
    [JsonPropertyName("configurationReferenceBlobUri")]
    public string? ConfigurationReferenceBlobUri { get; set; }

    /// <summary>Specifies the order in which the packages have to be installed. Possible values are between 0 and 2,147,483,647. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>The ID of the Linux Virtual Machine Scale Set.</summary>
    [JsonPropertyName("packageReferenceId")]
    public string? PackageReferenceId { get; set; }

    /// <summary>The IP Tag associated with the Public IP, such as SQL or Storage. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Linux Virtual Machine Scale Set.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Linux Virtual Machine Scale Set. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetStatusAtProviderNetworkInterfaceIpConfigurationPublicIpAddressIpTag
{
    /// <summary>The IP Tag associated with the Public IP, such as SQL or Storage. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The Type of IP Tag, such as FirstPartyUsage. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetStatusAtProviderNetworkInterfaceIpConfigurationPublicIpAddress
{
    /// <summary>The Prefix which should be used for the Domain Name Label for each Virtual Machine Instance. Azure concatenates the Domain Name Label and Virtual Machine Index to create a unique Domain Name Label for each Virtual Machine.</summary>
    [JsonPropertyName("domainNameLabel")]
    public string? DomainNameLabel { get; set; }

    /// <summary>The Idle Timeout in Minutes for the Public IP Address. Possible values are in the range 4 to 32.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>One or more ip_tag blocks as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ipTag")]
    public IList<V1beta1LinuxVirtualMachineScaleSetStatusAtProviderNetworkInterfaceIpConfigurationPublicIpAddressIpTag>? IpTag { get; set; }

    /// <summary>The Name of the Public IP Address Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Public IP Address Prefix from where Public IP Addresses should be allocated. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicIpPrefixId")]
    public string? PublicIpPrefixId { get; set; }

    /// <summary>Specifies the version of the image used to create the virtual machines.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetStatusAtProviderNetworkInterfaceIpConfiguration
{
    /// <summary>A list of Backend Address Pools ID's from a Application Gateway which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("applicationGatewayBackendAddressPoolIds")]
    public IList<string>? ApplicationGatewayBackendAddressPoolIds { get; set; }

    /// <summary>A list of Application Security Group ID's which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("applicationSecurityGroupIds")]
    public IList<string>? ApplicationSecurityGroupIds { get; set; }

    /// <summary>A list of Backend Address Pools ID's from a Load Balancer which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("loadBalancerBackendAddressPoolIds")]
    public IList<string>? LoadBalancerBackendAddressPoolIds { get; set; }

    /// <summary>A list of NAT Rule ID's from a Load Balancer which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("loadBalancerInboundNatRulesIds")]
    public IList<string>? LoadBalancerInboundNatRulesIds { get; set; }

    /// <summary>The Name of the Public IP Address Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this the Primary IP Configuration?</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>A public_ip_address block as defined below.</summary>
    [JsonPropertyName("publicIpAddress")]
    public IList<V1beta1LinuxVirtualMachineScaleSetStatusAtProviderNetworkInterfaceIpConfigurationPublicIpAddress>? PublicIpAddress { get; set; }

    /// <summary>The ID of the Subnet which this IP Configuration should be connected to.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Specifies the version of the image used to create the virtual machines.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetStatusAtProviderNetworkInterface
{
    /// <summary>A list of IP Addresses of DNS Servers which should be assigned to the Network Interface.</summary>
    [JsonPropertyName("dnsServers")]
    public IList<string>? DnsServers { get; set; }

    /// <summary>Does this Network Interface support Accelerated Networking? Defaults to false.</summary>
    [JsonPropertyName("enableAcceleratedNetworking")]
    public bool? EnableAcceleratedNetworking { get; set; }

    /// <summary>Does this Network Interface support IP Forwarding? Defaults to false.</summary>
    [JsonPropertyName("enableIpForwarding")]
    public bool? EnableIpForwarding { get; set; }

    /// <summary>One or more ip_configuration blocks as defined above.</summary>
    [JsonPropertyName("ipConfiguration")]
    public IList<V1beta1LinuxVirtualMachineScaleSetStatusAtProviderNetworkInterfaceIpConfiguration>? IpConfiguration { get; set; }

    /// <summary>The Name which should be used for this Network Interface. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of a Network Security Group which should be assigned to this Network Interface.</summary>
    [JsonPropertyName("networkSecurityGroupId")]
    public string? NetworkSecurityGroupId { get; set; }

    /// <summary>Is this the Primary IP Configuration?</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetStatusAtProviderOsDiskDiffDiskSettings
{
    /// <summary>Specifies the Ephemeral Disk Settings for the OS Disk. At this time the only possible value is Local. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("option")]
    public string? Option { get; set; }

    /// <summary>Specifies where to store the Ephemeral Disk. Possible values are CacheDisk and ResourceDisk. Defaults to CacheDisk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("placement")]
    public string? Placement { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetStatusAtProviderOsDisk
{
    /// <summary>The Type of Caching which should be used for the Internal OS Disk. Possible values are None, ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>A diff_disk_settings block as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diffDiskSettings")]
    public IList<V1beta1LinuxVirtualMachineScaleSetStatusAtProviderOsDiskDiffDiskSettings>? DiffDiskSettings { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to encrypt this OS Disk. Conflicts with secure_vm_disk_encryption_set_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>The Size of the Internal OS Disk in GB, if you wish to vary from the size used in the image this Virtual Machine Scale Set is sourced from.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to Encrypt the OS Disk when the Virtual Machine Scale Set is Confidential VMSS. Conflicts with disk_encryption_set_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("secureVmDiskEncryptionSetId")]
    public string? SecureVmDiskEncryptionSetId { get; set; }

    /// <summary>Encryption Type when the Virtual Machine Scale Set is Confidential VMSS. Possible values are VMGuestStateOnly and DiskWithVMGuestState. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityEncryptionType")]
    public string? SecurityEncryptionType { get; set; }

    /// <summary>The Type of Storage Account which should back this the Internal OS Disk. Possible values include Standard_LRS, StandardSSD_LRS, StandardSSD_ZRS, Premium_LRS and Premium_ZRS. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>Should Write Accelerator be Enabled for this OS Disk? Defaults to false.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetStatusAtProviderPlan
{
    /// <summary>Specifies the name of the image from the marketplace. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the product of the image from the marketplace. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary>Specifies the publisher of the image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetStatusAtProviderRollingUpgradePolicy
{
    /// <summary>Should the Virtual Machine Scale Set ignore the Azure Zone boundaries when constructing upgrade batches? Possible values are true or false.</summary>
    [JsonPropertyName("crossZoneUpgradesEnabled")]
    public bool? CrossZoneUpgradesEnabled { get; set; }

    /// <summary>The maximum percent of total virtual machine instances that will be upgraded simultaneously by the rolling upgrade in one batch. As this is a maximum, unhealthy instances in previous or future batches can cause the percentage of instances in a batch to decrease to ensure higher reliability.</summary>
    [JsonPropertyName("maxBatchInstancePercent")]
    public double? MaxBatchInstancePercent { get; set; }

    /// <summary>The maximum percentage of the total virtual machine instances in the scale set that can be simultaneously unhealthy, either as a result of being upgraded, or by being found in an unhealthy state by the virtual machine health checks before the rolling upgrade aborts. This constraint will be checked prior to starting any batch.</summary>
    [JsonPropertyName("maxUnhealthyInstancePercent")]
    public double? MaxUnhealthyInstancePercent { get; set; }

    /// <summary>The maximum percentage of upgraded virtual machine instances that can be found to be in an unhealthy state. This check will happen after each batch is upgraded. If this percentage is ever exceeded, the rolling update aborts.</summary>
    [JsonPropertyName("maxUnhealthyUpgradedInstancePercent")]
    public double? MaxUnhealthyUpgradedInstancePercent { get; set; }

    /// <summary>The wait time between completing the update for all virtual machines in one batch and starting the next batch. The time duration should be specified in ISO 8601 format.</summary>
    [JsonPropertyName("pauseTimeBetweenBatches")]
    public string? PauseTimeBetweenBatches { get; set; }

    /// <summary>Upgrade all unhealthy instances in a scale set before any healthy instances. Possible values are true or false.</summary>
    [JsonPropertyName("prioritizeUnhealthyInstancesEnabled")]
    public bool? PrioritizeUnhealthyInstancesEnabled { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetStatusAtProviderScaleIn
{
    /// <summary>Should the virtual machines chosen for removal be force deleted when the virtual machine scale set is being scaled-in? Possible values are true or false. Defaults to false.</summary>
    [JsonPropertyName("forceDeletionEnabled")]
    public bool? ForceDeletionEnabled { get; set; }

    /// <summary>The scale-in policy rule that decides which virtual machines are chosen for removal when a Virtual Machine Scale Set is scaled in. Possible values for the scale-in policy rules are Default, NewestVM and OldestVM, defaults to Default. For more information about scale in policy, please refer to this doc.</summary>
    [JsonPropertyName("rule")]
    public string? Rule { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetStatusAtProviderSecretCertificate
{
    /// <summary>The Secret URL of a Key Vault Certificate.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetStatusAtProviderSecret
{
    /// <summary>One or more certificate blocks as defined above.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1LinuxVirtualMachineScaleSetStatusAtProviderSecretCertificate>? Certificate { get; set; }

    /// <summary>The ID of the Key Vault from which all Secrets should be sourced.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetStatusAtProviderSourceImageReference
{
    /// <summary>Specifies the offer of the image used to create the virtual machines. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("offer")]
    public string? Offer { get; set; }

    /// <summary>Specifies the publisher of the image used to create the virtual machines. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>Specifies the SKU of the image used to create the virtual machines.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>Specifies the version of the image used to create the virtual machines.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetStatusAtProviderSpotRestore
{
    /// <summary>Should the Spot-Try-Restore feature be enabled? The Spot-Try-Restore feature will attempt to automatically restore the evicted Spot Virtual Machine Scale Set VM instances opportunistically based on capacity availability and pricing constraints. Possible values are true or false. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The length of time that the Virtual Machine Scale Set should attempt to restore the Spot VM instances which have been evicted. The time duration should be between 15 minutes and 120 minutes (inclusive). The time duration should be specified in the ISO 8601 format. Defaults to PT1H. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetStatusAtProviderTerminateNotification
{
    /// <summary>Should the terminate notification be enabled on this Virtual Machine Scale Set?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Length of time (in minutes, between 5 and 15) a notification to be sent to the VM on the instance metadata server till the VM gets deleted. The time duration should be specified in ISO 8601 format. Defaults to PT5M.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetStatusAtProviderTerminationNotification
{
    /// <summary>Should the termination notification be enabled on this Virtual Machine Scale Set?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Length of time (in minutes, between 5 and 15) a notification to be sent to the VM on the instance metadata server till the VM gets deleted. The time duration should be specified in ISO 8601 format. Defaults to PT5M.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary></summary>
public partial class V1beta1LinuxVirtualMachineScaleSetStatusAtProvider
{
    /// <summary>An additional_capabilities block as defined below.</summary>
    [JsonPropertyName("additionalCapabilities")]
    public IList<V1beta1LinuxVirtualMachineScaleSetStatusAtProviderAdditionalCapabilities>? AdditionalCapabilities { get; set; }

    /// <summary>One or more admin_ssh_key blocks as defined below.</summary>
    [JsonPropertyName("adminSshKey")]
    public IList<V1beta1LinuxVirtualMachineScaleSetStatusAtProviderAdminSshKey>? AdminSshKey { get; set; }

    /// <summary>The username of the local administrator on each Virtual Machine Scale Set instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>An automatic_instance_repair block as defined below. To enable the automatic instance repair, this Virtual Machine Scale Set must have a valid health_probe_id or an Application Health Extension.</summary>
    [JsonPropertyName("automaticInstanceRepair")]
    public IList<V1beta1LinuxVirtualMachineScaleSetStatusAtProviderAutomaticInstanceRepair>? AutomaticInstanceRepair { get; set; }

    /// <summary>An automatic_os_upgrade_policy block as defined below. This can only be specified when upgrade_mode is set to either Automatic or Rolling.</summary>
    [JsonPropertyName("automaticOsUpgradePolicy")]
    public IList<V1beta1LinuxVirtualMachineScaleSetStatusAtProviderAutomaticOsUpgradePolicy>? AutomaticOsUpgradePolicy { get; set; }

    /// <summary>A boot_diagnostics block as defined below.</summary>
    [JsonPropertyName("bootDiagnostics")]
    public IList<V1beta1LinuxVirtualMachineScaleSetStatusAtProviderBootDiagnostics>? BootDiagnostics { get; set; }

    /// <summary>Specifies the ID of the Capacity Reservation Group which the Virtual Machine Scale Set should be allocated to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("capacityReservationGroupId")]
    public string? CapacityReservationGroupId { get; set; }

    /// <summary>The prefix which should be used for the name of the Virtual Machines in this Scale Set. If unspecified this defaults to the value for the name field. If the value of the name field is not a valid computer_name_prefix, then you must specify computer_name_prefix. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("computerNamePrefix")]
    public string? ComputerNamePrefix { get; set; }

    /// <summary>One or more data_disk blocks as defined below.</summary>
    [JsonPropertyName("dataDisk")]
    public IList<V1beta1LinuxVirtualMachineScaleSetStatusAtProviderDataDisk>? DataDisk { get; set; }

    /// <summary>Should Password Authentication be disabled on this Virtual Machine Scale Set? Defaults to true.</summary>
    [JsonPropertyName("disablePasswordAuthentication")]
    public bool? DisablePasswordAuthentication { get; set; }

    /// <summary>Should Virtual Machine Extensions be run on Overprovisioned Virtual Machines in the Scale Set? Defaults to false.</summary>
    [JsonPropertyName("doNotRunExtensionsOnOverprovisionedMachines")]
    public bool? DoNotRunExtensionsOnOverprovisionedMachines { get; set; }

    /// <summary>Specifies the Edge Zone within the Azure Region where this Linux Virtual Machine Scale Set should exist. Changing this forces a new Linux Virtual Machine Scale Set to be created.</summary>
    [JsonPropertyName("edgeZone")]
    public string? EdgeZone { get; set; }

    /// <summary>Should all of the disks (including the temp disk) attached to this Virtual Machine be encrypted by enabling Encryption at Host?</summary>
    [JsonPropertyName("encryptionAtHostEnabled")]
    public bool? EncryptionAtHostEnabled { get; set; }

    /// <summary>Specifies the eviction policy for Virtual Machines in this Scale Set. Possible values are Deallocate and Delete. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>One or more extension blocks as defined below</summary>
    [JsonPropertyName("extension")]
    public IList<V1beta1LinuxVirtualMachineScaleSetStatusAtProviderExtension>? Extension { get; set; }

    /// <summary>Should extension operations be allowed on the Virtual Machine Scale Set? Possible values are true or false. Defaults to true. Changing this forces a new Linux Virtual Machine Scale Set to be created.</summary>
    [JsonPropertyName("extensionOperationsEnabled")]
    public bool? ExtensionOperationsEnabled { get; set; }

    /// <summary>Specifies the duration allocated for all extensions to start. The time duration should be between 15 minutes and 120 minutes (inclusive) and should be specified in ISO 8601 format. Defaults to PT1H30M.</summary>
    [JsonPropertyName("extensionsTimeBudget")]
    public string? ExtensionsTimeBudget { get; set; }

    /// <summary>One or more gallery_application blocks as defined below.</summary>
    [JsonPropertyName("galleryApplication")]
    public IList<V1beta1LinuxVirtualMachineScaleSetStatusAtProviderGalleryApplication>? GalleryApplication { get; set; }

    /// <summary></summary>
    [JsonPropertyName("galleryApplications")]
    public IList<V1beta1LinuxVirtualMachineScaleSetStatusAtProviderGalleryApplications>? GalleryApplications { get; set; }

    /// <summary>The ID of a Load Balancer Probe which should be used to determine the health of an instance. This is Required and can only be specified when upgrade_mode is set to Automatic or Rolling.</summary>
    [JsonPropertyName("healthProbeId")]
    public string? HealthProbeId { get; set; }

    /// <summary>Specifies the ID of the dedicated host group that the virtual machine scale set resides in. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hostGroupId")]
    public string? HostGroupId { get; set; }

    /// <summary>The ID of the Linux Virtual Machine Scale Set.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1LinuxVirtualMachineScaleSetStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>The number of Virtual Machines in the Scale Set. Defaults to 0.</summary>
    [JsonPropertyName("instances")]
    public double? Instances { get; set; }

    /// <summary>The Azure location where the Linux Virtual Machine Scale Set should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The maximum price you're willing to pay for each Virtual Machine in this Scale Set, in US Dollars; which must be greater than the current spot price. If this bid price falls below the current spot price the Virtual Machines in the Scale Set will be evicted using the eviction_policy. Defaults to -1, which means that each Virtual Machine in this Scale Set should not be evicted for price reasons.</summary>
    [JsonPropertyName("maxBidPrice")]
    public double? MaxBidPrice { get; set; }

    /// <summary>One or more network_interface blocks as defined below.</summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta1LinuxVirtualMachineScaleSetStatusAtProviderNetworkInterface>? NetworkInterface { get; set; }

    /// <summary>An os_disk block as defined below.</summary>
    [JsonPropertyName("osDisk")]
    public IList<V1beta1LinuxVirtualMachineScaleSetStatusAtProviderOsDisk>? OsDisk { get; set; }

    /// <summary>Should Azure over-provision Virtual Machines in this Scale Set? This means that multiple Virtual Machines will be provisioned and Azure will keep the instances which become available first - which improves provisioning success rates and improves deployment time. You're not billed for these over-provisioned VM's and they don't count towards the Subscription Quota. Defaults to true.</summary>
    [JsonPropertyName("overprovision")]
    public bool? Overprovision { get; set; }

    /// <summary>A plan block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("plan")]
    public IList<V1beta1LinuxVirtualMachineScaleSetStatusAtProviderPlan>? Plan { get; set; }

    /// <summary>Specifies the number of fault domains that are used by this Linux Virtual Machine Scale Set. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("platformFaultDomainCount")]
    public double? PlatformFaultDomainCount { get; set; }

    /// <summary>The Priority of this Virtual Machine Scale Set. Possible values are Regular and Spot. Defaults to Regular. Changing this value forces a new resource.</summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>Should the Azure VM Agent be provisioned on each Virtual Machine in the Scale Set? Defaults to true. Changing this value forces a new resource to be created.</summary>
    [JsonPropertyName("provisionVmAgent")]
    public bool? ProvisionVmAgent { get; set; }

    /// <summary>The ID of the Proximity Placement Group in which the Virtual Machine Scale Set should be assigned to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("proximityPlacementGroupId")]
    public string? ProximityPlacementGroupId { get; set; }

    /// <summary>The name of the Resource Group in which the Linux Virtual Machine Scale Set should be exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A rolling_upgrade_policy block as defined below. This is Required and can only be specified when upgrade_mode is set to Automatic or Rolling. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("rollingUpgradePolicy")]
    public IList<V1beta1LinuxVirtualMachineScaleSetStatusAtProviderRollingUpgradePolicy>? RollingUpgradePolicy { get; set; }

    /// <summary>A scale_in block as defined below.</summary>
    [JsonPropertyName("scaleIn")]
    public IList<V1beta1LinuxVirtualMachineScaleSetStatusAtProviderScaleIn>? ScaleIn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("scaleInPolicy")]
    public string? ScaleInPolicy { get; set; }

    /// <summary>One or more secret blocks as defined below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta1LinuxVirtualMachineScaleSetStatusAtProviderSecret>? Secret { get; set; }

    /// <summary>Specifies whether secure boot should be enabled on the virtual machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("secureBootEnabled")]
    public bool? SecureBootEnabled { get; set; }

    /// <summary>Should this Virtual Machine Scale Set be limited to a Single Placement Group, which means the number of instances will be capped at 100 Virtual Machines. Defaults to true.</summary>
    [JsonPropertyName("singlePlacementGroup")]
    public bool? SinglePlacementGroup { get; set; }

    /// <summary>The Virtual Machine SKU for the Scale Set, such as Standard_F2.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>The ID of an Image which each Virtual Machine in this Scale Set should be based on. Possible Image ID types include Image ID, Shared Image ID, Shared Image Version ID, Community Gallery Image ID, Community Gallery Image Version ID, Shared Gallery Image ID and Shared Gallery Image Version ID.</summary>
    [JsonPropertyName("sourceImageId")]
    public string? SourceImageId { get; set; }

    /// <summary>A source_image_reference block as defined below.</summary>
    [JsonPropertyName("sourceImageReference")]
    public IList<V1beta1LinuxVirtualMachineScaleSetStatusAtProviderSourceImageReference>? SourceImageReference { get; set; }

    /// <summary>A spot_restore block as defined below.</summary>
    [JsonPropertyName("spotRestore")]
    public IList<V1beta1LinuxVirtualMachineScaleSetStatusAtProviderSpotRestore>? SpotRestore { get; set; }

    /// <summary>A mapping of tags which should be assigned to this Virtual Machine Scale Set.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A terminate_notification block as defined below.</summary>
    [JsonPropertyName("terminateNotification")]
    public IList<V1beta1LinuxVirtualMachineScaleSetStatusAtProviderTerminateNotification>? TerminateNotification { get; set; }

    /// <summary>A termination_notification block as defined below.</summary>
    [JsonPropertyName("terminationNotification")]
    public IList<V1beta1LinuxVirtualMachineScaleSetStatusAtProviderTerminationNotification>? TerminationNotification { get; set; }

    /// <summary>The Unique ID for this Linux Virtual Machine Scale Set.</summary>
    [JsonPropertyName("uniqueId")]
    public string? UniqueId { get; set; }

    /// <summary>Specifies how Upgrades (e.g. changing the Image/SKU) should be performed to Virtual Machine Instances. Possible values are Automatic, Manual and Rolling. Defaults to Manual. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("upgradeMode")]
    public string? UpgradeMode { get; set; }

    /// <summary>The Base64-Encoded User Data which should be used for this Virtual Machine Scale Set.</summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary>Specifies whether vTPM should be enabled on the virtual machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vtpmEnabled")]
    public bool? VtpmEnabled { get; set; }

    /// <summary>Should the Virtual Machines in this Scale Set be strictly evenly distributed across Availability Zones? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("zoneBalance")]
    public bool? ZoneBalance { get; set; }

    /// <summary>Specifies a list of Availability Zones in which this Linux Virtual Machine Scale Set should be located. Changing this forces a new Linux Virtual Machine Scale Set to be created.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1LinuxVirtualMachineScaleSetStatusConditions
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

/// <summary>LinuxVirtualMachineScaleSetStatus defines the observed state of LinuxVirtualMachineScaleSet.</summary>
public partial class V1beta1LinuxVirtualMachineScaleSetStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1LinuxVirtualMachineScaleSetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LinuxVirtualMachineScaleSetStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>LinuxVirtualMachineScaleSet is the Schema for the LinuxVirtualMachineScaleSets API. Manages a Linux Virtual Machine Scale Set.</summary>
public partial class V1beta1LinuxVirtualMachineScaleSet : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LinuxVirtualMachineScaleSetSpec>, IStatus<V1beta1LinuxVirtualMachineScaleSetStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LinuxVirtualMachineScaleSet";
    public const string KubeGroup = "compute.azure.upbound.io";
    public const string KubePluralName = "linuxvirtualmachinescalesets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LinuxVirtualMachineScaleSetSpec defines the desired state of LinuxVirtualMachineScaleSet</summary>
    [JsonPropertyName("spec")]
    public V1beta1LinuxVirtualMachineScaleSetSpec Spec { get; set; }

    /// <summary>LinuxVirtualMachineScaleSetStatus defines the observed state of LinuxVirtualMachineScaleSet.</summary>
    [JsonPropertyName("status")]
    public V1beta1LinuxVirtualMachineScaleSetStatus? Status { get; set; }
}