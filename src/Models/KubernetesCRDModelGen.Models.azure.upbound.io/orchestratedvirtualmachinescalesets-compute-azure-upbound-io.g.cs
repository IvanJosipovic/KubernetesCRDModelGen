using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.azure.upbound.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1OrchestratedVirtualMachineScaleSetSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderAdditionalCapabilities
{
    /// <summary>Should the capacity to enable Data Disks of the UltraSSD_LRS storage account type be supported on this Virtual Machine Scale Set? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ultraSsdEnabled")]
    public bool? UltraSsdEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderAutomaticInstanceRepair
{
    /// <summary>Should the automatic instance repair be enabled on this Virtual Machine Scale Set? Possible values are true and false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Amount of time for which automatic repairs will be delayed. The grace period starts right after the VM is found unhealthy. Possible values are between 30 and 90 minutes. The time duration should be specified in ISO 8601 format (e.g. PT30M to PT90M). Defaults to PT30M.</summary>
    [JsonPropertyName("gracePeriod")]
    public string? GracePeriod { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderBootDiagnostics
{
    /// <summary>The Primary/Secondary Endpoint for the Azure Storage Account which should be used to store Boot Diagnostics, including Console Output and Screenshots from the Hypervisor. By including a boot_diagnostics block without passing the storage_account_uri field will cause the API to utilize a Managed Storage Account to store the Boot Diagnostics output.</summary>
    [JsonPropertyName("storageAccountUri")]
    public string? StorageAccountUri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderDataDisk
{
    /// <summary>The type of Caching which should be used for this Data Disk. Possible values are None, ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>The create option which should be used for this Data Disk. Possible values are Empty and FromImage. Defaults to Empty. (FromImage should only be used if the source image includes data disks).</summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to encrypt the Data Disk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>The size of the Data Disk which should be created. Required if create_option is specified as Empty.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The Logical Unit Number of the Data Disk, which must be unique within the Virtual Machine. Required if create_option is specified as Empty.</summary>
    [JsonPropertyName("lun")]
    public double? Lun { get; set; }

    /// <summary>The Type of Storage Account which should back this Data Disk. Possible values include Standard_LRS, StandardSSD_LRS, StandardSSD_ZRS, Premium_LRS, PremiumV2_LRS, Premium_ZRS and UltraSSD_LRS.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>Specifies the Read-Write IOPS for this Data Disk. Only settable when storage_account_type is PremiumV2_LRS or UltraSSD_LRS.</summary>
    [JsonPropertyName("ultraSsdDiskIopsReadWrite")]
    public double? UltraSsdDiskIopsReadWrite { get; set; }

    /// <summary>Specifies the bandwidth in MB per second for this Data Disk. Only settable when storage_account_type is PremiumV2_LRS or UltraSSD_LRS.</summary>
    [JsonPropertyName("ultraSsdDiskMbpsReadWrite")]
    public double? UltraSsdDiskMbpsReadWrite { get; set; }

    /// <summary>Specifies if Write Accelerator is enabled on the Data Disk. Defaults to false.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderExtensionProtectedSettingsFromKeyVault
{
    /// <summary>The URL to the Key Vault Secret which stores the protected settings.</summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>The ID of the source Key Vault.</summary>
    [JsonPropertyName("sourceVaultId")]
    public string? SourceVaultId { get; set; }
}

/// <summary>A JSON String which specifies Sensitive Settings (such as Passwords) for the Extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderExtensionProtectedSettingsSecretRef
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
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderExtension
{
    /// <summary>Should the latest version of the Extension be used at Deployment Time, if one is available? This won't auto-update the extension on existing installation. Defaults to true.</summary>
    [JsonPropertyName("autoUpgradeMinorVersionEnabled")]
    public bool? AutoUpgradeMinorVersionEnabled { get; set; }

    /// <summary>An ordered list of Extension names which Virtual Machine Scale Set should provision after VM creation.</summary>
    [JsonPropertyName("extensionsToProvisionAfterVmCreation")]
    public IList<string>? ExtensionsToProvisionAfterVmCreation { get; set; }

    /// <summary>Should failures from the extension be suppressed? Possible values are true or false.</summary>
    [JsonPropertyName("failureSuppressionEnabled")]
    public bool? FailureSuppressionEnabled { get; set; }

    /// <summary>A value which, when different to the previous value can be used to force-run the Extension even if the Extension Configuration hasn't changed.</summary>
    [JsonPropertyName("forceExtensionExecutionOnChange")]
    public string? ForceExtensionExecutionOnChange { get; set; }

    /// <summary>The name for the Virtual Machine Scale Set Extension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A protected_settings_from_key_vault block as defined below.</summary>
    [JsonPropertyName("protectedSettingsFromKeyVault")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderExtensionProtectedSettingsFromKeyVault>? ProtectedSettingsFromKeyVault { get; set; }

    /// <summary>A JSON String which specifies Sensitive Settings (such as Passwords) for the Extension.</summary>
    [JsonPropertyName("protectedSettingsSecretRef")]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderExtensionProtectedSettingsSecretRef? ProtectedSettingsSecretRef { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderIdentity
{
    /// <summary>Specifies a list of User Managed Identity IDs to be assigned to this Windows Virtual Machine Scale Set.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The type of Managed Identity that should be configured on this Windows Virtual Machine Scale Set. Only possible value is UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationPublicIpAddressIpTag
{
    /// <summary>The IP Tag associated with the Public IP, such as SQL or Storage. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The Type of IP Tag, such as FirstPartyUsage. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationPublicIpAddress
{
    /// <summary>The Prefix which should be used for the Domain Name Label for each Virtual Machine Instance. Azure concatenates the Domain Name Label and Virtual Machine Index to create a unique Domain Name Label for each Virtual Machine. Valid values must be between 1 and 26 characters long, start with a lower case letter, end with a lower case letter or number and contains only a-z, 0-9 and hyphens.</summary>
    [JsonPropertyName("domainNameLabel")]
    public string? DomainNameLabel { get; set; }

    /// <summary>The Idle Timeout in Minutes for the Public IP Address. Possible values are in the range 4 to 32.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>One or more ip_tag blocks as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ipTag")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationPublicIpAddressIpTag>? IpTag { get; set; }

    /// <summary>The Name of the Public IP Address Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Public IP Address Prefix from where Public IP Addresses should be allocated. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicIpPrefixId")]
    public string? PublicIpPrefixId { get; set; }

    /// <summary>The name of the SKU to be used by this Virtual Machine Scale Set. Valid values include: any of the General purpose, Compute optimized, Memory optimized, Storage optimized, GPU optimized, FPGA optimized, High performance, or Previous generation virtual machine SKUs.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>Specifies the version of the image used to create the virtual machines.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolveEnum>))]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfiguration
{
    /// <summary>A list of Backend Address Pools IDs from a Application Gateway which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("applicationGatewayBackendAddressPoolIds")]
    public IList<string>? ApplicationGatewayBackendAddressPoolIds { get; set; }

    /// <summary>A list of Application Security Group IDs which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("applicationSecurityGroupIds")]
    public IList<string>? ApplicationSecurityGroupIds { get; set; }

    /// <summary>A list of Backend Address Pools IDs from a Load Balancer which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("loadBalancerBackendAddressPoolIds")]
    public IList<string>? LoadBalancerBackendAddressPoolIds { get; set; }

    /// <summary>The Name of the Public IP Address Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this the Primary IP Configuration? Possible values are true and false. Defaults to false.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>A public_ip_address block as defined below.</summary>
    [JsonPropertyName("publicIpAddress")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationPublicIpAddress>? PublicIpAddress { get; set; }

    /// <summary>The ID of the Subnet which this IP Configuration should be connected to.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>Specifies the version of the image used to create the virtual machines.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterface
{
    /// <summary>A list of IP Addresses of DNS Servers which should be assigned to the Network Interface.</summary>
    [JsonPropertyName("dnsServers")]
    public IList<string>? DnsServers { get; set; }

    /// <summary>Does this Network Interface support Accelerated Networking? Possible values are true and false. Defaults to false.</summary>
    [JsonPropertyName("enableAcceleratedNetworking")]
    public bool? EnableAcceleratedNetworking { get; set; }

    /// <summary>Does this Network Interface support IP Forwarding? Possible values are true and false. Defaults to false.</summary>
    [JsonPropertyName("enableIpForwarding")]
    public bool? EnableIpForwarding { get; set; }

    /// <summary>One or more ip_configuration blocks as defined above.</summary>
    [JsonPropertyName("ipConfiguration")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterfaceIpConfiguration>? IpConfiguration { get; set; }

    /// <summary>The Name which should be used for this Network Interface. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of a Network Security Group which should be assigned to this Network Interface.</summary>
    [JsonPropertyName("networkSecurityGroupId")]
    public string? NetworkSecurityGroupId { get; set; }

    /// <summary>Is this the Primary IP Configuration? Possible values are true and false. Defaults to false.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsDiskDiffDiskSettings
{
    /// <summary>Specifies the Ephemeral Disk Settings for the OS Disk. At this time the only possible value is Local. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("option")]
    public string? Option { get; set; }

    /// <summary>Specifies where to store the Ephemeral Disk. Possible values are CacheDisk and ResourceDisk. Defaults to CacheDisk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("placement")]
    public string? Placement { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsDisk
{
    /// <summary>The Type of Caching which should be used for the Internal OS Disk. Possible values are None, ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>A diff_disk_settings block as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diffDiskSettings")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsDiskDiffDiskSettings>? DiffDiskSettings { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to encrypt this OS Disk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>The Size of the Internal OS Disk in GB, if you wish to vary from the size used in the image this Virtual Machine Scale Set is sourced from.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The Type of Storage Account which should back this the Internal OS Disk. Possible values include Standard_LRS, StandardSSD_LRS, StandardSSD_ZRS, Premium_LRS and Premium_ZRS. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>Specifies if Write Accelerator is enabled on the OS Disk. Defaults to false.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>The Base64-Encoded Custom Data which should be used for this Virtual Machine Scale Set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileCustomDataSecretRef
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

/// <summary>The Password which should be used for the local-administrator on this Virtual Machine. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileLinuxConfigurationAdminPasswordSecretRef
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
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileLinuxConfigurationAdminSshKey
{
    /// <summary>The Public Key which should be used for authentication, which needs to be at least 2048-bit and in ssh-rsa format.</summary>
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    /// <summary>The Username for which this Public SSH Key should be configured.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileLinuxConfigurationSecretCertificate
{
    /// <summary>The Secret URL of a Key Vault Certificate.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileLinuxConfigurationSecret
{
    /// <summary>One or more certificate blocks as defined below.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileLinuxConfigurationSecretCertificate>? Certificate { get; set; }

    /// <summary>The ID of the Key Vault from which all Secrets should be sourced.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileLinuxConfiguration
{
    /// <summary>The Password which should be used for the local-administrator on this Virtual Machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminPasswordSecretRef")]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileLinuxConfigurationAdminPasswordSecretRef? AdminPasswordSecretRef { get; set; }

    /// <summary>A admin_ssh_key block as documented below.</summary>
    [JsonPropertyName("adminSshKey")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileLinuxConfigurationAdminSshKey>? AdminSshKey { get; set; }

    /// <summary>The username of the local administrator on each Virtual Machine Scale Set instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>The prefix which should be used for the name of the Virtual Machines in this Scale Set. If unspecified this defaults to the value for the name field. If the value of the name field is not a valid computer_name_prefix, then you must specify computer_name_prefix. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("computerNamePrefix")]
    public string? ComputerNamePrefix { get; set; }

    /// <summary>When an admin_password is specified disable_password_authentication must be set to false. Defaults to true.</summary>
    [JsonPropertyName("disablePasswordAuthentication")]
    public bool? DisablePasswordAuthentication { get; set; }

    /// <summary>Specifies the mode of VM Guest Patching for the virtual machines that are associated to the Virtual Machine Scale Set. Possible values are AutomaticByPlatform or ImageDefault. Defaults to ImageDefault.</summary>
    [JsonPropertyName("patchAssessmentMode")]
    public string? PatchAssessmentMode { get; set; }

    /// <summary>Specifies the mode of in-guest patching of this Windows Virtual Machine. Possible values are Manual, AutomaticByOS and AutomaticByPlatform. Defaults to AutomaticByOS. For more information on patch modes please see the product documentation.</summary>
    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }

    /// <summary>Should the Azure VM Agent be provisioned on each Virtual Machine in the Scale Set? Defaults to true. Changing this value forces a new resource to be created.</summary>
    [JsonPropertyName("provisionVmAgent")]
    public bool? ProvisionVmAgent { get; set; }

    /// <summary>One or more secret blocks as defined below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileLinuxConfigurationSecret>? Secret { get; set; }
}

/// <summary>The XML formatted content that is added to the unattend.xml file for the specified path and component. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileWindowsConfigurationAdditionalUnattendContentContentSecretRef
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
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileWindowsConfigurationAdditionalUnattendContent
{
    /// <summary>The XML formatted content that is added to the unattend.xml file for the specified path and component. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("contentSecretRef")]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileWindowsConfigurationAdditionalUnattendContentContentSecretRef ContentSecretRef { get; set; }

    /// <summary>The name of the setting to which the content applies. Possible values are AutoLogon and FirstLogonCommands. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("setting")]
    public string? Setting { get; set; }
}

/// <summary>The Password which should be used for the local-administrator on this Virtual Machine. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileWindowsConfigurationAdminPasswordSecretRef
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
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileWindowsConfigurationSecretCertificate
{
    /// <summary>The certificate store on the Virtual Machine where the certificate should be added.</summary>
    [JsonPropertyName("store")]
    public string? Store { get; set; }

    /// <summary>The Secret URL of a Key Vault Certificate.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileWindowsConfigurationSecret
{
    /// <summary>One or more certificate blocks as defined below.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileWindowsConfigurationSecretCertificate>? Certificate { get; set; }

    /// <summary>The ID of the Key Vault from which all Secrets should be sourced.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileWindowsConfigurationWinrmListener
{
    /// <summary>The Secret URL of a Key Vault Certificate, which must be specified when protocol is set to Https. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("certificateUrl")]
    public string? CertificateUrl { get; set; }

    /// <summary>Specifies the protocol of listener. Possible values are Http or Https. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileWindowsConfiguration
{
    /// <summary>One or more additional_unattend_content blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("additionalUnattendContent")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileWindowsConfigurationAdditionalUnattendContent>? AdditionalUnattendContent { get; set; }

    /// <summary>The Password which should be used for the local-administrator on this Virtual Machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminPasswordSecretRef")]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileWindowsConfigurationAdminPasswordSecretRef AdminPasswordSecretRef { get; set; }

    /// <summary>The username of the local administrator on each Virtual Machine Scale Set instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>The prefix which should be used for the name of the Virtual Machines in this Scale Set. If unspecified this defaults to the value for the name field. If the value of the name field is not a valid computer_name_prefix, then you must specify computer_name_prefix. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("computerNamePrefix")]
    public string? ComputerNamePrefix { get; set; }

    /// <summary>Are automatic updates enabled for this Virtual Machine? Defaults to true.</summary>
    [JsonPropertyName("enableAutomaticUpdates")]
    public bool? EnableAutomaticUpdates { get; set; }

    /// <summary>Should the VM be patched without requiring a reboot? Possible values are true or false. Defaults to false. For more information about hot patching please see the product documentation.</summary>
    [JsonPropertyName("hotpatchingEnabled")]
    public bool? HotpatchingEnabled { get; set; }

    /// <summary>Specifies the mode of VM Guest Patching for the virtual machines that are associated to the Virtual Machine Scale Set. Possible values are AutomaticByPlatform or ImageDefault. Defaults to ImageDefault.</summary>
    [JsonPropertyName("patchAssessmentMode")]
    public string? PatchAssessmentMode { get; set; }

    /// <summary>Specifies the mode of in-guest patching of this Windows Virtual Machine. Possible values are Manual, AutomaticByOS and AutomaticByPlatform. Defaults to AutomaticByOS. For more information on patch modes please see the product documentation.</summary>
    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }

    /// <summary>Should the Azure VM Agent be provisioned on each Virtual Machine in the Scale Set? Defaults to true. Changing this value forces a new resource to be created.</summary>
    [JsonPropertyName("provisionVmAgent")]
    public bool? ProvisionVmAgent { get; set; }

    /// <summary>One or more secret blocks as defined below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileWindowsConfigurationSecret>? Secret { get; set; }

    /// <summary>Specifies the time zone of the virtual machine, the possible values are defined here.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>One or more winrm_listener blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("winrmListener")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileWindowsConfigurationWinrmListener>? WinrmListener { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsProfile
{
    /// <summary>The Base64-Encoded Custom Data which should be used for this Virtual Machine Scale Set.</summary>
    [JsonPropertyName("customDataSecretRef")]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileCustomDataSecretRef? CustomDataSecretRef { get; set; }

    /// <summary>A linux_configuration block as documented below.</summary>
    [JsonPropertyName("linuxConfiguration")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileLinuxConfiguration>? LinuxConfiguration { get; set; }

    /// <summary>A windows_configuration block as documented below.</summary>
    [JsonPropertyName("windowsConfiguration")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsProfileWindowsConfiguration>? WindowsConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderPlan
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderPriorityMix
{
    /// <summary>Specifies the base number of VMs of Regular priority that will be created before any VMs of priority Spot are created. Possible values are integers between 0 and 1000. Defaults to 0.</summary>
    [JsonPropertyName("baseRegularCount")]
    public double? BaseRegularCount { get; set; }

    /// <summary>Specifies the desired percentage of VM instances that are of Regular priority after the base count has been reached. Possible values are integers between 0 and 100. Defaults to 0.</summary>
    [JsonPropertyName("regularPercentageAboveBase")]
    public double? RegularPercentageAboveBase { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderSourceImageReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderTerminationNotification
{
    /// <summary>Should the termination notification be enabled on this Virtual Machine Scale Set? Possible values true or false</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Length of time (in minutes, between 5 and 15) a notification to be sent to the VM on the instance metadata server till the VM gets deleted. The time duration should be specified in ISO 8601 format. Defaults to PT5M.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>The Base64-Encoded User Data which should be used for this Virtual Machine Scale Set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderUserDataBase64SecretRef
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
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecForProvider
{
    /// <summary>An additional_capabilities block as defined below.</summary>
    [JsonPropertyName("additionalCapabilities")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderAdditionalCapabilities>? AdditionalCapabilities { get; set; }

    /// <summary>An automatic_instance_repair block as defined below.</summary>
    [JsonPropertyName("automaticInstanceRepair")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderAutomaticInstanceRepair>? AutomaticInstanceRepair { get; set; }

    /// <summary>A boot_diagnostics block as defined below.</summary>
    [JsonPropertyName("bootDiagnostics")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderBootDiagnostics>? BootDiagnostics { get; set; }

    /// <summary>Specifies the ID of the Capacity Reservation Group which the Virtual Machine Scale Set should be allocated to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("capacityReservationGroupId")]
    public string? CapacityReservationGroupId { get; set; }

    /// <summary>One or more data_disk blocks as defined below.</summary>
    [JsonPropertyName("dataDisk")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderDataDisk>? DataDisk { get; set; }

    /// <summary>Should disks attached to this Virtual Machine Scale Set be encrypted by enabling Encryption at Host?</summary>
    [JsonPropertyName("encryptionAtHostEnabled")]
    public bool? EncryptionAtHostEnabled { get; set; }

    /// <summary>The Policy which should be used by Spot Virtual Machines that are Evicted from the Scale Set. Possible values are Deallocate and Delete. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>One or more extension blocks as defined below</summary>
    [JsonPropertyName("extension")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderExtension>? Extension { get; set; }

    /// <summary>Should extension operations be allowed on the Virtual Machine Scale Set? Possible values are true or false. Defaults to true. Changing this forces a new Virtual Machine Scale Set to be created.</summary>
    [JsonPropertyName("extensionOperationsEnabled")]
    public bool? ExtensionOperationsEnabled { get; set; }

    /// <summary>Specifies the time alloted for all extensions to start. The time duration should be between 15 minutes and 120 minutes (inclusive) and should be specified in ISO 8601 format. Defaults to PT1H30M.</summary>
    [JsonPropertyName("extensionsTimeBudget")]
    public string? ExtensionsTimeBudget { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderIdentity>? Identity { get; set; }

    /// <summary>The number of Virtual Machines in the Virtual Machine Scale Set.</summary>
    [JsonPropertyName("instances")]
    public double? Instances { get; set; }

    /// <summary>Specifies the type of on-premise license (also known as Azure Hybrid Use Benefit) which should be used for this Virtual Machine Scale Set. Possible values are None, Windows_Client and Windows_Server.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>The Azure location where the Virtual Machine Scale Set should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The maximum price you're willing to pay for each Virtual Machine in this Scale Set, in US Dollars; which must be greater than the current spot price. If this bid price falls below the current spot price the Virtual Machines in the Scale Set will be evicted using the eviction_policy. Defaults to -1, which means that each Virtual Machine in the Scale Set should not be evicted for price reasons.</summary>
    [JsonPropertyName("maxBidPrice")]
    public double? MaxBidPrice { get; set; }

    /// <summary>One or more network_interface blocks as defined below.</summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderNetworkInterface>? NetworkInterface { get; set; }

    /// <summary>An os_disk block as defined below.</summary>
    [JsonPropertyName("osDisk")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsDisk>? OsDisk { get; set; }

    /// <summary>An os_profile block as defined below.</summary>
    [JsonPropertyName("osProfile")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderOsProfile>? OsProfile { get; set; }

    /// <summary>A plan block as documented below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("plan")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderPlan>? Plan { get; set; }

    /// <summary>Specifies the number of fault domains that are used by this Virtual Machine Scale Set. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("platformFaultDomainCount")]
    public double? PlatformFaultDomainCount { get; set; }

    /// <summary>The Priority of this Virtual Machine Scale Set. Possible values are Regular and Spot. Defaults to Regular. Changing this value forces a new resource.</summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>a priority_mix block as defined below</summary>
    [JsonPropertyName("priorityMix")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderPriorityMix>? PriorityMix { get; set; }

    /// <summary>The ID of the Proximity Placement Group which the Virtual Machine should be assigned to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("proximityPlacementGroupId")]
    public string? ProximityPlacementGroupId { get; set; }

    /// <summary>The name of the Resource Group in which the Virtual Machine Scale Set should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Should this Virtual Machine Scale Set be limited to a Single Placement Group, which means the number of instances will be capped at 100 Virtual Machines. Possible values are true or false.</summary>
    [JsonPropertyName("singlePlacementGroup")]
    public bool? SinglePlacementGroup { get; set; }

    /// <summary>The name of the SKU to be used by this Virtual Machine Scale Set. Valid values include: any of the General purpose, Compute optimized, Memory optimized, Storage optimized, GPU optimized, FPGA optimized, High performance, or Previous generation virtual machine SKUs.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>The ID of an Image which each Virtual Machine in this Scale Set should be based on. Possible Image ID types include Image IDs, Shared Image IDs, Shared Image Version IDs, Community Gallery Image IDs, Community Gallery Image Version IDs, Shared Gallery Image IDs and Shared Gallery Image Version IDs.</summary>
    [JsonPropertyName("sourceImageId")]
    public string? SourceImageId { get; set; }

    /// <summary>A source_image_reference block as defined below.</summary>
    [JsonPropertyName("sourceImageReference")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderSourceImageReference>? SourceImageReference { get; set; }

    /// <summary>A mapping of tags which should be assigned to this Virtual Machine Scale Set.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A termination_notification block as defined below.</summary>
    [JsonPropertyName("terminationNotification")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderTerminationNotification>? TerminationNotification { get; set; }

    /// <summary>The Base64-Encoded User Data which should be used for this Virtual Machine Scale Set.</summary>
    [JsonPropertyName("userDataBase64SecretRef")]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecForProviderUserDataBase64SecretRef? UserDataBase64SecretRef { get; set; }

    /// <summary>Should the Virtual Machines in this Scale Set be strictly evenly distributed across Availability Zones? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("zoneBalance")]
    public bool? ZoneBalance { get; set; }

    /// <summary>Specifies a list of Availability Zones across which the Virtual Machine Scale Set will create instances. Changing this forces a new Virtual Machine Scale Set to be created.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderAdditionalCapabilities
{
    /// <summary>Should the capacity to enable Data Disks of the UltraSSD_LRS storage account type be supported on this Virtual Machine Scale Set? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ultraSsdEnabled")]
    public bool? UltraSsdEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderAutomaticInstanceRepair
{
    /// <summary>Should the automatic instance repair be enabled on this Virtual Machine Scale Set? Possible values are true and false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Amount of time for which automatic repairs will be delayed. The grace period starts right after the VM is found unhealthy. Possible values are between 30 and 90 minutes. The time duration should be specified in ISO 8601 format (e.g. PT30M to PT90M). Defaults to PT30M.</summary>
    [JsonPropertyName("gracePeriod")]
    public string? GracePeriod { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderBootDiagnostics
{
    /// <summary>The Primary/Secondary Endpoint for the Azure Storage Account which should be used to store Boot Diagnostics, including Console Output and Screenshots from the Hypervisor. By including a boot_diagnostics block without passing the storage_account_uri field will cause the API to utilize a Managed Storage Account to store the Boot Diagnostics output.</summary>
    [JsonPropertyName("storageAccountUri")]
    public string? StorageAccountUri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderDataDisk
{
    /// <summary>The type of Caching which should be used for this Data Disk. Possible values are None, ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>The create option which should be used for this Data Disk. Possible values are Empty and FromImage. Defaults to Empty. (FromImage should only be used if the source image includes data disks).</summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to encrypt the Data Disk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>The size of the Data Disk which should be created. Required if create_option is specified as Empty.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The Logical Unit Number of the Data Disk, which must be unique within the Virtual Machine. Required if create_option is specified as Empty.</summary>
    [JsonPropertyName("lun")]
    public double? Lun { get; set; }

    /// <summary>The Type of Storage Account which should back this Data Disk. Possible values include Standard_LRS, StandardSSD_LRS, StandardSSD_ZRS, Premium_LRS, PremiumV2_LRS, Premium_ZRS and UltraSSD_LRS.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>Specifies the Read-Write IOPS for this Data Disk. Only settable when storage_account_type is PremiumV2_LRS or UltraSSD_LRS.</summary>
    [JsonPropertyName("ultraSsdDiskIopsReadWrite")]
    public double? UltraSsdDiskIopsReadWrite { get; set; }

    /// <summary>Specifies the bandwidth in MB per second for this Data Disk. Only settable when storage_account_type is PremiumV2_LRS or UltraSSD_LRS.</summary>
    [JsonPropertyName("ultraSsdDiskMbpsReadWrite")]
    public double? UltraSsdDiskMbpsReadWrite { get; set; }

    /// <summary>Specifies if Write Accelerator is enabled on the Data Disk. Defaults to false.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderExtensionProtectedSettingsFromKeyVault
{
    /// <summary>The URL to the Key Vault Secret which stores the protected settings.</summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>The ID of the source Key Vault.</summary>
    [JsonPropertyName("sourceVaultId")]
    public string? SourceVaultId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderExtension
{
    /// <summary>Should the latest version of the Extension be used at Deployment Time, if one is available? This won't auto-update the extension on existing installation. Defaults to true.</summary>
    [JsonPropertyName("autoUpgradeMinorVersionEnabled")]
    public bool? AutoUpgradeMinorVersionEnabled { get; set; }

    /// <summary>An ordered list of Extension names which Virtual Machine Scale Set should provision after VM creation.</summary>
    [JsonPropertyName("extensionsToProvisionAfterVmCreation")]
    public IList<string>? ExtensionsToProvisionAfterVmCreation { get; set; }

    /// <summary>Should failures from the extension be suppressed? Possible values are true or false.</summary>
    [JsonPropertyName("failureSuppressionEnabled")]
    public bool? FailureSuppressionEnabled { get; set; }

    /// <summary>A value which, when different to the previous value can be used to force-run the Extension even if the Extension Configuration hasn't changed.</summary>
    [JsonPropertyName("forceExtensionExecutionOnChange")]
    public string? ForceExtensionExecutionOnChange { get; set; }

    /// <summary>The name for the Virtual Machine Scale Set Extension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A protected_settings_from_key_vault block as defined below.</summary>
    [JsonPropertyName("protectedSettingsFromKeyVault")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderExtensionProtectedSettingsFromKeyVault>? ProtectedSettingsFromKeyVault { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Managed Identity IDs to be assigned to this Windows Virtual Machine Scale Set.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The type of Managed Identity that should be configured on this Windows Virtual Machine Scale Set. Only possible value is UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationPublicIpAddressIpTag
{
    /// <summary>The IP Tag associated with the Public IP, such as SQL or Storage. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The Type of IP Tag, such as FirstPartyUsage. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationPublicIpAddress
{
    /// <summary>The Prefix which should be used for the Domain Name Label for each Virtual Machine Instance. Azure concatenates the Domain Name Label and Virtual Machine Index to create a unique Domain Name Label for each Virtual Machine. Valid values must be between 1 and 26 characters long, start with a lower case letter, end with a lower case letter or number and contains only a-z, 0-9 and hyphens.</summary>
    [JsonPropertyName("domainNameLabel")]
    public string? DomainNameLabel { get; set; }

    /// <summary>The Idle Timeout in Minutes for the Public IP Address. Possible values are in the range 4 to 32.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>One or more ip_tag blocks as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ipTag")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationPublicIpAddressIpTag>? IpTag { get; set; }

    /// <summary>The Name of the Public IP Address Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Public IP Address Prefix from where Public IP Addresses should be allocated. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicIpPrefixId")]
    public string? PublicIpPrefixId { get; set; }

    /// <summary>The name of the SKU to be used by this Virtual Machine Scale Set. Valid values include: any of the General purpose, Compute optimized, Memory optimized, Storage optimized, GPU optimized, FPGA optimized, High performance, or Previous generation virtual machine SKUs.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>Specifies the version of the image used to create the virtual machines.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolutionEnum>))]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolveEnum>))]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolutionEnum>))]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolveEnum>))]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfiguration
{
    /// <summary>A list of Backend Address Pools IDs from a Application Gateway which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("applicationGatewayBackendAddressPoolIds")]
    public IList<string>? ApplicationGatewayBackendAddressPoolIds { get; set; }

    /// <summary>A list of Application Security Group IDs which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("applicationSecurityGroupIds")]
    public IList<string>? ApplicationSecurityGroupIds { get; set; }

    /// <summary>A list of Backend Address Pools IDs from a Load Balancer which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("loadBalancerBackendAddressPoolIds")]
    public IList<string>? LoadBalancerBackendAddressPoolIds { get; set; }

    /// <summary>The Name of the Public IP Address Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this the Primary IP Configuration? Possible values are true and false. Defaults to false.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>A public_ip_address block as defined below.</summary>
    [JsonPropertyName("publicIpAddress")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationPublicIpAddress>? PublicIpAddress { get; set; }

    /// <summary>The ID of the Subnet which this IP Configuration should be connected to.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfigurationSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>Specifies the version of the image used to create the virtual machines.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterface
{
    /// <summary>A list of IP Addresses of DNS Servers which should be assigned to the Network Interface.</summary>
    [JsonPropertyName("dnsServers")]
    public IList<string>? DnsServers { get; set; }

    /// <summary>Does this Network Interface support Accelerated Networking? Possible values are true and false. Defaults to false.</summary>
    [JsonPropertyName("enableAcceleratedNetworking")]
    public bool? EnableAcceleratedNetworking { get; set; }

    /// <summary>Does this Network Interface support IP Forwarding? Possible values are true and false. Defaults to false.</summary>
    [JsonPropertyName("enableIpForwarding")]
    public bool? EnableIpForwarding { get; set; }

    /// <summary>One or more ip_configuration blocks as defined above.</summary>
    [JsonPropertyName("ipConfiguration")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterfaceIpConfiguration>? IpConfiguration { get; set; }

    /// <summary>The Name which should be used for this Network Interface. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of a Network Security Group which should be assigned to this Network Interface.</summary>
    [JsonPropertyName("networkSecurityGroupId")]
    public string? NetworkSecurityGroupId { get; set; }

    /// <summary>Is this the Primary IP Configuration? Possible values are true and false. Defaults to false.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderOsDiskDiffDiskSettings
{
    /// <summary>Specifies the Ephemeral Disk Settings for the OS Disk. At this time the only possible value is Local. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("option")]
    public string? Option { get; set; }

    /// <summary>Specifies where to store the Ephemeral Disk. Possible values are CacheDisk and ResourceDisk. Defaults to CacheDisk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("placement")]
    public string? Placement { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderOsDisk
{
    /// <summary>The Type of Caching which should be used for the Internal OS Disk. Possible values are None, ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>A diff_disk_settings block as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diffDiskSettings")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderOsDiskDiffDiskSettings>? DiffDiskSettings { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to encrypt this OS Disk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>The Size of the Internal OS Disk in GB, if you wish to vary from the size used in the image this Virtual Machine Scale Set is sourced from.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The Type of Storage Account which should back this the Internal OS Disk. Possible values include Standard_LRS, StandardSSD_LRS, StandardSSD_ZRS, Premium_LRS and Premium_ZRS. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>Specifies if Write Accelerator is enabled on the OS Disk. Defaults to false.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileLinuxConfigurationAdminSshKey
{
    /// <summary>The Public Key which should be used for authentication, which needs to be at least 2048-bit and in ssh-rsa format.</summary>
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    /// <summary>The Username for which this Public SSH Key should be configured.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileLinuxConfigurationSecretCertificate
{
    /// <summary>The Secret URL of a Key Vault Certificate.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileLinuxConfigurationSecret
{
    /// <summary>One or more certificate blocks as defined below.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileLinuxConfigurationSecretCertificate>? Certificate { get; set; }

    /// <summary>The ID of the Key Vault from which all Secrets should be sourced.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileLinuxConfiguration
{
    /// <summary>A admin_ssh_key block as documented below.</summary>
    [JsonPropertyName("adminSshKey")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileLinuxConfigurationAdminSshKey>? AdminSshKey { get; set; }

    /// <summary>The username of the local administrator on each Virtual Machine Scale Set instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>The prefix which should be used for the name of the Virtual Machines in this Scale Set. If unspecified this defaults to the value for the name field. If the value of the name field is not a valid computer_name_prefix, then you must specify computer_name_prefix. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("computerNamePrefix")]
    public string? ComputerNamePrefix { get; set; }

    /// <summary>When an admin_password is specified disable_password_authentication must be set to false. Defaults to true.</summary>
    [JsonPropertyName("disablePasswordAuthentication")]
    public bool? DisablePasswordAuthentication { get; set; }

    /// <summary>Specifies the mode of VM Guest Patching for the virtual machines that are associated to the Virtual Machine Scale Set. Possible values are AutomaticByPlatform or ImageDefault. Defaults to ImageDefault.</summary>
    [JsonPropertyName("patchAssessmentMode")]
    public string? PatchAssessmentMode { get; set; }

    /// <summary>Specifies the mode of in-guest patching of this Windows Virtual Machine. Possible values are Manual, AutomaticByOS and AutomaticByPlatform. Defaults to AutomaticByOS. For more information on patch modes please see the product documentation.</summary>
    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }

    /// <summary>Should the Azure VM Agent be provisioned on each Virtual Machine in the Scale Set? Defaults to true. Changing this value forces a new resource to be created.</summary>
    [JsonPropertyName("provisionVmAgent")]
    public bool? ProvisionVmAgent { get; set; }

    /// <summary>One or more secret blocks as defined below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileLinuxConfigurationSecret>? Secret { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileWindowsConfigurationAdditionalUnattendContent
{
    /// <summary>The name of the setting to which the content applies. Possible values are AutoLogon and FirstLogonCommands. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("setting")]
    public string? Setting { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileWindowsConfigurationSecretCertificate
{
    /// <summary>The certificate store on the Virtual Machine where the certificate should be added.</summary>
    [JsonPropertyName("store")]
    public string? Store { get; set; }

    /// <summary>The Secret URL of a Key Vault Certificate.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileWindowsConfigurationSecret
{
    /// <summary>One or more certificate blocks as defined below.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileWindowsConfigurationSecretCertificate>? Certificate { get; set; }

    /// <summary>The ID of the Key Vault from which all Secrets should be sourced.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileWindowsConfigurationWinrmListener
{
    /// <summary>The Secret URL of a Key Vault Certificate, which must be specified when protocol is set to Https. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("certificateUrl")]
    public string? CertificateUrl { get; set; }

    /// <summary>Specifies the protocol of listener. Possible values are Http or Https. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileWindowsConfiguration
{
    /// <summary>One or more additional_unattend_content blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("additionalUnattendContent")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileWindowsConfigurationAdditionalUnattendContent>? AdditionalUnattendContent { get; set; }

    /// <summary>The username of the local administrator on each Virtual Machine Scale Set instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>The prefix which should be used for the name of the Virtual Machines in this Scale Set. If unspecified this defaults to the value for the name field. If the value of the name field is not a valid computer_name_prefix, then you must specify computer_name_prefix. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("computerNamePrefix")]
    public string? ComputerNamePrefix { get; set; }

    /// <summary>Are automatic updates enabled for this Virtual Machine? Defaults to true.</summary>
    [JsonPropertyName("enableAutomaticUpdates")]
    public bool? EnableAutomaticUpdates { get; set; }

    /// <summary>Should the VM be patched without requiring a reboot? Possible values are true or false. Defaults to false. For more information about hot patching please see the product documentation.</summary>
    [JsonPropertyName("hotpatchingEnabled")]
    public bool? HotpatchingEnabled { get; set; }

    /// <summary>Specifies the mode of VM Guest Patching for the virtual machines that are associated to the Virtual Machine Scale Set. Possible values are AutomaticByPlatform or ImageDefault. Defaults to ImageDefault.</summary>
    [JsonPropertyName("patchAssessmentMode")]
    public string? PatchAssessmentMode { get; set; }

    /// <summary>Specifies the mode of in-guest patching of this Windows Virtual Machine. Possible values are Manual, AutomaticByOS and AutomaticByPlatform. Defaults to AutomaticByOS. For more information on patch modes please see the product documentation.</summary>
    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }

    /// <summary>Should the Azure VM Agent be provisioned on each Virtual Machine in the Scale Set? Defaults to true. Changing this value forces a new resource to be created.</summary>
    [JsonPropertyName("provisionVmAgent")]
    public bool? ProvisionVmAgent { get; set; }

    /// <summary>One or more secret blocks as defined below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileWindowsConfigurationSecret>? Secret { get; set; }

    /// <summary>Specifies the time zone of the virtual machine, the possible values are defined here.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>One or more winrm_listener blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("winrmListener")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileWindowsConfigurationWinrmListener>? WinrmListener { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfile
{
    /// <summary>A linux_configuration block as documented below.</summary>
    [JsonPropertyName("linuxConfiguration")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileLinuxConfiguration>? LinuxConfiguration { get; set; }

    /// <summary>A windows_configuration block as documented below.</summary>
    [JsonPropertyName("windowsConfiguration")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfileWindowsConfiguration>? WindowsConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderPlan
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderPriorityMix
{
    /// <summary>Specifies the base number of VMs of Regular priority that will be created before any VMs of priority Spot are created. Possible values are integers between 0 and 1000. Defaults to 0.</summary>
    [JsonPropertyName("baseRegularCount")]
    public double? BaseRegularCount { get; set; }

    /// <summary>Specifies the desired percentage of VM instances that are of Regular priority after the base count has been reached. Possible values are integers between 0 and 100. Defaults to 0.</summary>
    [JsonPropertyName("regularPercentageAboveBase")]
    public double? RegularPercentageAboveBase { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderSourceImageReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderTerminationNotification
{
    /// <summary>Should the termination notification be enabled on this Virtual Machine Scale Set? Possible values true or false</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Length of time (in minutes, between 5 and 15) a notification to be sent to the VM on the instance metadata server till the VM gets deleted. The time duration should be specified in ISO 8601 format. Defaults to PT5M.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecInitProvider
{
    /// <summary>An additional_capabilities block as defined below.</summary>
    [JsonPropertyName("additionalCapabilities")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderAdditionalCapabilities>? AdditionalCapabilities { get; set; }

    /// <summary>An automatic_instance_repair block as defined below.</summary>
    [JsonPropertyName("automaticInstanceRepair")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderAutomaticInstanceRepair>? AutomaticInstanceRepair { get; set; }

    /// <summary>A boot_diagnostics block as defined below.</summary>
    [JsonPropertyName("bootDiagnostics")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderBootDiagnostics>? BootDiagnostics { get; set; }

    /// <summary>Specifies the ID of the Capacity Reservation Group which the Virtual Machine Scale Set should be allocated to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("capacityReservationGroupId")]
    public string? CapacityReservationGroupId { get; set; }

    /// <summary>One or more data_disk blocks as defined below.</summary>
    [JsonPropertyName("dataDisk")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderDataDisk>? DataDisk { get; set; }

    /// <summary>Should disks attached to this Virtual Machine Scale Set be encrypted by enabling Encryption at Host?</summary>
    [JsonPropertyName("encryptionAtHostEnabled")]
    public bool? EncryptionAtHostEnabled { get; set; }

    /// <summary>The Policy which should be used by Spot Virtual Machines that are Evicted from the Scale Set. Possible values are Deallocate and Delete. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>One or more extension blocks as defined below</summary>
    [JsonPropertyName("extension")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderExtension>? Extension { get; set; }

    /// <summary>Should extension operations be allowed on the Virtual Machine Scale Set? Possible values are true or false. Defaults to true. Changing this forces a new Virtual Machine Scale Set to be created.</summary>
    [JsonPropertyName("extensionOperationsEnabled")]
    public bool? ExtensionOperationsEnabled { get; set; }

    /// <summary>Specifies the time alloted for all extensions to start. The time duration should be between 15 minutes and 120 minutes (inclusive) and should be specified in ISO 8601 format. Defaults to PT1H30M.</summary>
    [JsonPropertyName("extensionsTimeBudget")]
    public string? ExtensionsTimeBudget { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderIdentity>? Identity { get; set; }

    /// <summary>The number of Virtual Machines in the Virtual Machine Scale Set.</summary>
    [JsonPropertyName("instances")]
    public double? Instances { get; set; }

    /// <summary>Specifies the type of on-premise license (also known as Azure Hybrid Use Benefit) which should be used for this Virtual Machine Scale Set. Possible values are None, Windows_Client and Windows_Server.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>The Azure location where the Virtual Machine Scale Set should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The maximum price you're willing to pay for each Virtual Machine in this Scale Set, in US Dollars; which must be greater than the current spot price. If this bid price falls below the current spot price the Virtual Machines in the Scale Set will be evicted using the eviction_policy. Defaults to -1, which means that each Virtual Machine in the Scale Set should not be evicted for price reasons.</summary>
    [JsonPropertyName("maxBidPrice")]
    public double? MaxBidPrice { get; set; }

    /// <summary>One or more network_interface blocks as defined below.</summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderNetworkInterface>? NetworkInterface { get; set; }

    /// <summary>An os_disk block as defined below.</summary>
    [JsonPropertyName("osDisk")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderOsDisk>? OsDisk { get; set; }

    /// <summary>An os_profile block as defined below.</summary>
    [JsonPropertyName("osProfile")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderOsProfile>? OsProfile { get; set; }

    /// <summary>A plan block as documented below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("plan")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderPlan>? Plan { get; set; }

    /// <summary>Specifies the number of fault domains that are used by this Virtual Machine Scale Set. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("platformFaultDomainCount")]
    public double? PlatformFaultDomainCount { get; set; }

    /// <summary>The Priority of this Virtual Machine Scale Set. Possible values are Regular and Spot. Defaults to Regular. Changing this value forces a new resource.</summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>a priority_mix block as defined below</summary>
    [JsonPropertyName("priorityMix")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderPriorityMix>? PriorityMix { get; set; }

    /// <summary>The ID of the Proximity Placement Group which the Virtual Machine should be assigned to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("proximityPlacementGroupId")]
    public string? ProximityPlacementGroupId { get; set; }

    /// <summary>Should this Virtual Machine Scale Set be limited to a Single Placement Group, which means the number of instances will be capped at 100 Virtual Machines. Possible values are true or false.</summary>
    [JsonPropertyName("singlePlacementGroup")]
    public bool? SinglePlacementGroup { get; set; }

    /// <summary>The name of the SKU to be used by this Virtual Machine Scale Set. Valid values include: any of the General purpose, Compute optimized, Memory optimized, Storage optimized, GPU optimized, FPGA optimized, High performance, or Previous generation virtual machine SKUs.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>The ID of an Image which each Virtual Machine in this Scale Set should be based on. Possible Image ID types include Image IDs, Shared Image IDs, Shared Image Version IDs, Community Gallery Image IDs, Community Gallery Image Version IDs, Shared Gallery Image IDs and Shared Gallery Image Version IDs.</summary>
    [JsonPropertyName("sourceImageId")]
    public string? SourceImageId { get; set; }

    /// <summary>A source_image_reference block as defined below.</summary>
    [JsonPropertyName("sourceImageReference")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderSourceImageReference>? SourceImageReference { get; set; }

    /// <summary>A mapping of tags which should be assigned to this Virtual Machine Scale Set.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A termination_notification block as defined below.</summary>
    [JsonPropertyName("terminationNotification")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecInitProviderTerminationNotification>? TerminationNotification { get; set; }

    /// <summary>Should the Virtual Machines in this Scale Set be strictly evenly distributed across Availability Zones? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("zoneBalance")]
    public bool? ZoneBalance { get; set; }

    /// <summary>Specifies a list of Availability Zones across which the Virtual Machine Scale Set will create instances. Changing this forces a new Virtual Machine Scale Set to be created.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1OrchestratedVirtualMachineScaleSetSpecManagementPoliciesEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1OrchestratedVirtualMachineScaleSetSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1OrchestratedVirtualMachineScaleSetSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OrchestratedVirtualMachineScaleSetSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OrchestratedVirtualMachineScaleSetSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecProviderConfigRefPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1OrchestratedVirtualMachineScaleSetSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1beta1OrchestratedVirtualMachineScaleSetSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OrchestratedVirtualMachineScaleSetSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OrchestratedVirtualMachineScaleSetSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>OrchestratedVirtualMachineScaleSetSpec defines the desired state of OrchestratedVirtualMachineScaleSet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1OrchestratedVirtualMachineScaleSetSpecDeletionPolicyEnum>))]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1OrchestratedVirtualMachineScaleSetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderAdditionalCapabilities
{
    /// <summary>Should the capacity to enable Data Disks of the UltraSSD_LRS storage account type be supported on this Virtual Machine Scale Set? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ultraSsdEnabled")]
    public bool? UltraSsdEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderAutomaticInstanceRepair
{
    /// <summary>Should the automatic instance repair be enabled on this Virtual Machine Scale Set? Possible values are true and false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Amount of time for which automatic repairs will be delayed. The grace period starts right after the VM is found unhealthy. Possible values are between 30 and 90 minutes. The time duration should be specified in ISO 8601 format (e.g. PT30M to PT90M). Defaults to PT30M.</summary>
    [JsonPropertyName("gracePeriod")]
    public string? GracePeriod { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderBootDiagnostics
{
    /// <summary>The Primary/Secondary Endpoint for the Azure Storage Account which should be used to store Boot Diagnostics, including Console Output and Screenshots from the Hypervisor. By including a boot_diagnostics block without passing the storage_account_uri field will cause the API to utilize a Managed Storage Account to store the Boot Diagnostics output.</summary>
    [JsonPropertyName("storageAccountUri")]
    public string? StorageAccountUri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderDataDisk
{
    /// <summary>The type of Caching which should be used for this Data Disk. Possible values are None, ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>The create option which should be used for this Data Disk. Possible values are Empty and FromImage. Defaults to Empty. (FromImage should only be used if the source image includes data disks).</summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to encrypt the Data Disk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>The size of the Data Disk which should be created. Required if create_option is specified as Empty.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The Logical Unit Number of the Data Disk, which must be unique within the Virtual Machine. Required if create_option is specified as Empty.</summary>
    [JsonPropertyName("lun")]
    public double? Lun { get; set; }

    /// <summary>The Type of Storage Account which should back this Data Disk. Possible values include Standard_LRS, StandardSSD_LRS, StandardSSD_ZRS, Premium_LRS, PremiumV2_LRS, Premium_ZRS and UltraSSD_LRS.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>Specifies the Read-Write IOPS for this Data Disk. Only settable when storage_account_type is PremiumV2_LRS or UltraSSD_LRS.</summary>
    [JsonPropertyName("ultraSsdDiskIopsReadWrite")]
    public double? UltraSsdDiskIopsReadWrite { get; set; }

    /// <summary>Specifies the bandwidth in MB per second for this Data Disk. Only settable when storage_account_type is PremiumV2_LRS or UltraSSD_LRS.</summary>
    [JsonPropertyName("ultraSsdDiskMbpsReadWrite")]
    public double? UltraSsdDiskMbpsReadWrite { get; set; }

    /// <summary>Specifies if Write Accelerator is enabled on the Data Disk. Defaults to false.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderExtensionProtectedSettingsFromKeyVault
{
    /// <summary>The URL to the Key Vault Secret which stores the protected settings.</summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>The ID of the source Key Vault.</summary>
    [JsonPropertyName("sourceVaultId")]
    public string? SourceVaultId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderExtension
{
    /// <summary>Should the latest version of the Extension be used at Deployment Time, if one is available? This won't auto-update the extension on existing installation. Defaults to true.</summary>
    [JsonPropertyName("autoUpgradeMinorVersionEnabled")]
    public bool? AutoUpgradeMinorVersionEnabled { get; set; }

    /// <summary>An ordered list of Extension names which Virtual Machine Scale Set should provision after VM creation.</summary>
    [JsonPropertyName("extensionsToProvisionAfterVmCreation")]
    public IList<string>? ExtensionsToProvisionAfterVmCreation { get; set; }

    /// <summary>Should failures from the extension be suppressed? Possible values are true or false.</summary>
    [JsonPropertyName("failureSuppressionEnabled")]
    public bool? FailureSuppressionEnabled { get; set; }

    /// <summary>A value which, when different to the previous value can be used to force-run the Extension even if the Extension Configuration hasn't changed.</summary>
    [JsonPropertyName("forceExtensionExecutionOnChange")]
    public string? ForceExtensionExecutionOnChange { get; set; }

    /// <summary>The name for the Virtual Machine Scale Set Extension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A protected_settings_from_key_vault block as defined below.</summary>
    [JsonPropertyName("protectedSettingsFromKeyVault")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderExtensionProtectedSettingsFromKeyVault>? ProtectedSettingsFromKeyVault { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Managed Identity IDs to be assigned to this Windows Virtual Machine Scale Set.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The type of Managed Identity that should be configured on this Windows Virtual Machine Scale Set. Only possible value is UserAssigned.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderNetworkInterfaceIpConfigurationPublicIpAddressIpTag
{
    /// <summary>The IP Tag associated with the Public IP, such as SQL or Storage. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The Type of IP Tag, such as FirstPartyUsage. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderNetworkInterfaceIpConfigurationPublicIpAddress
{
    /// <summary>The Prefix which should be used for the Domain Name Label for each Virtual Machine Instance. Azure concatenates the Domain Name Label and Virtual Machine Index to create a unique Domain Name Label for each Virtual Machine. Valid values must be between 1 and 26 characters long, start with a lower case letter, end with a lower case letter or number and contains only a-z, 0-9 and hyphens.</summary>
    [JsonPropertyName("domainNameLabel")]
    public string? DomainNameLabel { get; set; }

    /// <summary>The Idle Timeout in Minutes for the Public IP Address. Possible values are in the range 4 to 32.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>One or more ip_tag blocks as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("ipTag")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderNetworkInterfaceIpConfigurationPublicIpAddressIpTag>? IpTag { get; set; }

    /// <summary>The Name of the Public IP Address Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Public IP Address Prefix from where Public IP Addresses should be allocated. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicIpPrefixId")]
    public string? PublicIpPrefixId { get; set; }

    /// <summary>The name of the SKU to be used by this Virtual Machine Scale Set. Valid values include: any of the General purpose, Compute optimized, Memory optimized, Storage optimized, GPU optimized, FPGA optimized, High performance, or Previous generation virtual machine SKUs.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>Specifies the version of the image used to create the virtual machines.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderNetworkInterfaceIpConfiguration
{
    /// <summary>A list of Backend Address Pools IDs from a Application Gateway which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("applicationGatewayBackendAddressPoolIds")]
    public IList<string>? ApplicationGatewayBackendAddressPoolIds { get; set; }

    /// <summary>A list of Application Security Group IDs which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("applicationSecurityGroupIds")]
    public IList<string>? ApplicationSecurityGroupIds { get; set; }

    /// <summary>A list of Backend Address Pools IDs from a Load Balancer which this Virtual Machine Scale Set should be connected to.</summary>
    [JsonPropertyName("loadBalancerBackendAddressPoolIds")]
    public IList<string>? LoadBalancerBackendAddressPoolIds { get; set; }

    /// <summary>The Name of the Public IP Address Configuration.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Is this the Primary IP Configuration? Possible values are true and false. Defaults to false.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>A public_ip_address block as defined below.</summary>
    [JsonPropertyName("publicIpAddress")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderNetworkInterfaceIpConfigurationPublicIpAddress>? PublicIpAddress { get; set; }

    /// <summary>The ID of the Subnet which this IP Configuration should be connected to.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Specifies the version of the image used to create the virtual machines.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderNetworkInterface
{
    /// <summary>A list of IP Addresses of DNS Servers which should be assigned to the Network Interface.</summary>
    [JsonPropertyName("dnsServers")]
    public IList<string>? DnsServers { get; set; }

    /// <summary>Does this Network Interface support Accelerated Networking? Possible values are true and false. Defaults to false.</summary>
    [JsonPropertyName("enableAcceleratedNetworking")]
    public bool? EnableAcceleratedNetworking { get; set; }

    /// <summary>Does this Network Interface support IP Forwarding? Possible values are true and false. Defaults to false.</summary>
    [JsonPropertyName("enableIpForwarding")]
    public bool? EnableIpForwarding { get; set; }

    /// <summary>One or more ip_configuration blocks as defined above.</summary>
    [JsonPropertyName("ipConfiguration")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderNetworkInterfaceIpConfiguration>? IpConfiguration { get; set; }

    /// <summary>The Name which should be used for this Network Interface. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of a Network Security Group which should be assigned to this Network Interface.</summary>
    [JsonPropertyName("networkSecurityGroupId")]
    public string? NetworkSecurityGroupId { get; set; }

    /// <summary>Is this the Primary IP Configuration? Possible values are true and false. Defaults to false.</summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderOsDiskDiffDiskSettings
{
    /// <summary>Specifies the Ephemeral Disk Settings for the OS Disk. At this time the only possible value is Local. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("option")]
    public string? Option { get; set; }

    /// <summary>Specifies where to store the Ephemeral Disk. Possible values are CacheDisk and ResourceDisk. Defaults to CacheDisk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("placement")]
    public string? Placement { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderOsDisk
{
    /// <summary>The Type of Caching which should be used for the Internal OS Disk. Possible values are None, ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>A diff_disk_settings block as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diffDiskSettings")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderOsDiskDiffDiskSettings>? DiffDiskSettings { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to encrypt this OS Disk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>The Size of the Internal OS Disk in GB, if you wish to vary from the size used in the image this Virtual Machine Scale Set is sourced from.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The Type of Storage Account which should back this the Internal OS Disk. Possible values include Standard_LRS, StandardSSD_LRS, StandardSSD_ZRS, Premium_LRS and Premium_ZRS. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>Specifies if Write Accelerator is enabled on the OS Disk. Defaults to false.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileLinuxConfigurationAdminSshKey
{
    /// <summary>The Public Key which should be used for authentication, which needs to be at least 2048-bit and in ssh-rsa format.</summary>
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    /// <summary>The Username for which this Public SSH Key should be configured.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileLinuxConfigurationSecretCertificate
{
    /// <summary>The Secret URL of a Key Vault Certificate.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileLinuxConfigurationSecret
{
    /// <summary>One or more certificate blocks as defined below.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileLinuxConfigurationSecretCertificate>? Certificate { get; set; }

    /// <summary>The ID of the Key Vault from which all Secrets should be sourced.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileLinuxConfiguration
{
    /// <summary>A admin_ssh_key block as documented below.</summary>
    [JsonPropertyName("adminSshKey")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileLinuxConfigurationAdminSshKey>? AdminSshKey { get; set; }

    /// <summary>The username of the local administrator on each Virtual Machine Scale Set instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>The prefix which should be used for the name of the Virtual Machines in this Scale Set. If unspecified this defaults to the value for the name field. If the value of the name field is not a valid computer_name_prefix, then you must specify computer_name_prefix. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("computerNamePrefix")]
    public string? ComputerNamePrefix { get; set; }

    /// <summary>When an admin_password is specified disable_password_authentication must be set to false. Defaults to true.</summary>
    [JsonPropertyName("disablePasswordAuthentication")]
    public bool? DisablePasswordAuthentication { get; set; }

    /// <summary>Specifies the mode of VM Guest Patching for the virtual machines that are associated to the Virtual Machine Scale Set. Possible values are AutomaticByPlatform or ImageDefault. Defaults to ImageDefault.</summary>
    [JsonPropertyName("patchAssessmentMode")]
    public string? PatchAssessmentMode { get; set; }

    /// <summary>Specifies the mode of in-guest patching of this Windows Virtual Machine. Possible values are Manual, AutomaticByOS and AutomaticByPlatform. Defaults to AutomaticByOS. For more information on patch modes please see the product documentation.</summary>
    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }

    /// <summary>Should the Azure VM Agent be provisioned on each Virtual Machine in the Scale Set? Defaults to true. Changing this value forces a new resource to be created.</summary>
    [JsonPropertyName("provisionVmAgent")]
    public bool? ProvisionVmAgent { get; set; }

    /// <summary>One or more secret blocks as defined below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileLinuxConfigurationSecret>? Secret { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileWindowsConfigurationAdditionalUnattendContent
{
    /// <summary>The name of the setting to which the content applies. Possible values are AutoLogon and FirstLogonCommands. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("setting")]
    public string? Setting { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileWindowsConfigurationSecretCertificate
{
    /// <summary>The certificate store on the Virtual Machine where the certificate should be added.</summary>
    [JsonPropertyName("store")]
    public string? Store { get; set; }

    /// <summary>The Secret URL of a Key Vault Certificate.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileWindowsConfigurationSecret
{
    /// <summary>One or more certificate blocks as defined below.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileWindowsConfigurationSecretCertificate>? Certificate { get; set; }

    /// <summary>The ID of the Key Vault from which all Secrets should be sourced.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileWindowsConfigurationWinrmListener
{
    /// <summary>The Secret URL of a Key Vault Certificate, which must be specified when protocol is set to Https. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("certificateUrl")]
    public string? CertificateUrl { get; set; }

    /// <summary>Specifies the protocol of listener. Possible values are Http or Https. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileWindowsConfiguration
{
    /// <summary>One or more additional_unattend_content blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("additionalUnattendContent")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileWindowsConfigurationAdditionalUnattendContent>? AdditionalUnattendContent { get; set; }

    /// <summary>The username of the local administrator on each Virtual Machine Scale Set instance. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>The prefix which should be used for the name of the Virtual Machines in this Scale Set. If unspecified this defaults to the value for the name field. If the value of the name field is not a valid computer_name_prefix, then you must specify computer_name_prefix. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("computerNamePrefix")]
    public string? ComputerNamePrefix { get; set; }

    /// <summary>Are automatic updates enabled for this Virtual Machine? Defaults to true.</summary>
    [JsonPropertyName("enableAutomaticUpdates")]
    public bool? EnableAutomaticUpdates { get; set; }

    /// <summary>Should the VM be patched without requiring a reboot? Possible values are true or false. Defaults to false. For more information about hot patching please see the product documentation.</summary>
    [JsonPropertyName("hotpatchingEnabled")]
    public bool? HotpatchingEnabled { get; set; }

    /// <summary>Specifies the mode of VM Guest Patching for the virtual machines that are associated to the Virtual Machine Scale Set. Possible values are AutomaticByPlatform or ImageDefault. Defaults to ImageDefault.</summary>
    [JsonPropertyName("patchAssessmentMode")]
    public string? PatchAssessmentMode { get; set; }

    /// <summary>Specifies the mode of in-guest patching of this Windows Virtual Machine. Possible values are Manual, AutomaticByOS and AutomaticByPlatform. Defaults to AutomaticByOS. For more information on patch modes please see the product documentation.</summary>
    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }

    /// <summary>Should the Azure VM Agent be provisioned on each Virtual Machine in the Scale Set? Defaults to true. Changing this value forces a new resource to be created.</summary>
    [JsonPropertyName("provisionVmAgent")]
    public bool? ProvisionVmAgent { get; set; }

    /// <summary>One or more secret blocks as defined below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileWindowsConfigurationSecret>? Secret { get; set; }

    /// <summary>Specifies the time zone of the virtual machine, the possible values are defined here.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>One or more winrm_listener blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("winrmListener")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileWindowsConfigurationWinrmListener>? WinrmListener { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfile
{
    /// <summary>A linux_configuration block as documented below.</summary>
    [JsonPropertyName("linuxConfiguration")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileLinuxConfiguration>? LinuxConfiguration { get; set; }

    /// <summary>A windows_configuration block as documented below.</summary>
    [JsonPropertyName("windowsConfiguration")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfileWindowsConfiguration>? WindowsConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderPlan
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderPriorityMix
{
    /// <summary>Specifies the base number of VMs of Regular priority that will be created before any VMs of priority Spot are created. Possible values are integers between 0 and 1000. Defaults to 0.</summary>
    [JsonPropertyName("baseRegularCount")]
    public double? BaseRegularCount { get; set; }

    /// <summary>Specifies the desired percentage of VM instances that are of Regular priority after the base count has been reached. Possible values are integers between 0 and 100. Defaults to 0.</summary>
    [JsonPropertyName("regularPercentageAboveBase")]
    public double? RegularPercentageAboveBase { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderSourceImageReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderTerminationNotification
{
    /// <summary>Should the termination notification be enabled on this Virtual Machine Scale Set? Possible values true or false</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Length of time (in minutes, between 5 and 15) a notification to be sent to the VM on the instance metadata server till the VM gets deleted. The time duration should be specified in ISO 8601 format. Defaults to PT5M.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetStatusAtProvider
{
    /// <summary>An additional_capabilities block as defined below.</summary>
    [JsonPropertyName("additionalCapabilities")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderAdditionalCapabilities>? AdditionalCapabilities { get; set; }

    /// <summary>An automatic_instance_repair block as defined below.</summary>
    [JsonPropertyName("automaticInstanceRepair")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderAutomaticInstanceRepair>? AutomaticInstanceRepair { get; set; }

    /// <summary>A boot_diagnostics block as defined below.</summary>
    [JsonPropertyName("bootDiagnostics")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderBootDiagnostics>? BootDiagnostics { get; set; }

    /// <summary>Specifies the ID of the Capacity Reservation Group which the Virtual Machine Scale Set should be allocated to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("capacityReservationGroupId")]
    public string? CapacityReservationGroupId { get; set; }

    /// <summary>One or more data_disk blocks as defined below.</summary>
    [JsonPropertyName("dataDisk")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderDataDisk>? DataDisk { get; set; }

    /// <summary>Should disks attached to this Virtual Machine Scale Set be encrypted by enabling Encryption at Host?</summary>
    [JsonPropertyName("encryptionAtHostEnabled")]
    public bool? EncryptionAtHostEnabled { get; set; }

    /// <summary>The Policy which should be used by Spot Virtual Machines that are Evicted from the Scale Set. Possible values are Deallocate and Delete. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>One or more extension blocks as defined below</summary>
    [JsonPropertyName("extension")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderExtension>? Extension { get; set; }

    /// <summary>Should extension operations be allowed on the Virtual Machine Scale Set? Possible values are true or false. Defaults to true. Changing this forces a new Virtual Machine Scale Set to be created.</summary>
    [JsonPropertyName("extensionOperationsEnabled")]
    public bool? ExtensionOperationsEnabled { get; set; }

    /// <summary>Specifies the time alloted for all extensions to start. The time duration should be between 15 minutes and 120 minutes (inclusive) and should be specified in ISO 8601 format. Defaults to PT1H30M.</summary>
    [JsonPropertyName("extensionsTimeBudget")]
    public string? ExtensionsTimeBudget { get; set; }

    /// <summary>The ID of the Virtual Machine Scale Set.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>The number of Virtual Machines in the Virtual Machine Scale Set.</summary>
    [JsonPropertyName("instances")]
    public double? Instances { get; set; }

    /// <summary>Specifies the type of on-premise license (also known as Azure Hybrid Use Benefit) which should be used for this Virtual Machine Scale Set. Possible values are None, Windows_Client and Windows_Server.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>The Azure location where the Virtual Machine Scale Set should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The maximum price you're willing to pay for each Virtual Machine in this Scale Set, in US Dollars; which must be greater than the current spot price. If this bid price falls below the current spot price the Virtual Machines in the Scale Set will be evicted using the eviction_policy. Defaults to -1, which means that each Virtual Machine in the Scale Set should not be evicted for price reasons.</summary>
    [JsonPropertyName("maxBidPrice")]
    public double? MaxBidPrice { get; set; }

    /// <summary>One or more network_interface blocks as defined below.</summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderNetworkInterface>? NetworkInterface { get; set; }

    /// <summary>An os_disk block as defined below.</summary>
    [JsonPropertyName("osDisk")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderOsDisk>? OsDisk { get; set; }

    /// <summary>An os_profile block as defined below.</summary>
    [JsonPropertyName("osProfile")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderOsProfile>? OsProfile { get; set; }

    /// <summary>A plan block as documented below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("plan")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderPlan>? Plan { get; set; }

    /// <summary>Specifies the number of fault domains that are used by this Virtual Machine Scale Set. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("platformFaultDomainCount")]
    public double? PlatformFaultDomainCount { get; set; }

    /// <summary>The Priority of this Virtual Machine Scale Set. Possible values are Regular and Spot. Defaults to Regular. Changing this value forces a new resource.</summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>a priority_mix block as defined below</summary>
    [JsonPropertyName("priorityMix")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderPriorityMix>? PriorityMix { get; set; }

    /// <summary>The ID of the Proximity Placement Group which the Virtual Machine should be assigned to. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("proximityPlacementGroupId")]
    public string? ProximityPlacementGroupId { get; set; }

    /// <summary>The name of the Resource Group in which the Virtual Machine Scale Set should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Should this Virtual Machine Scale Set be limited to a Single Placement Group, which means the number of instances will be capped at 100 Virtual Machines. Possible values are true or false.</summary>
    [JsonPropertyName("singlePlacementGroup")]
    public bool? SinglePlacementGroup { get; set; }

    /// <summary>The name of the SKU to be used by this Virtual Machine Scale Set. Valid values include: any of the General purpose, Compute optimized, Memory optimized, Storage optimized, GPU optimized, FPGA optimized, High performance, or Previous generation virtual machine SKUs.</summary>
    [JsonPropertyName("skuName")]
    public string? SkuName { get; set; }

    /// <summary>The ID of an Image which each Virtual Machine in this Scale Set should be based on. Possible Image ID types include Image IDs, Shared Image IDs, Shared Image Version IDs, Community Gallery Image IDs, Community Gallery Image Version IDs, Shared Gallery Image IDs and Shared Gallery Image Version IDs.</summary>
    [JsonPropertyName("sourceImageId")]
    public string? SourceImageId { get; set; }

    /// <summary>A source_image_reference block as defined below.</summary>
    [JsonPropertyName("sourceImageReference")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderSourceImageReference>? SourceImageReference { get; set; }

    /// <summary>A mapping of tags which should be assigned to this Virtual Machine Scale Set.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A termination_notification block as defined below.</summary>
    [JsonPropertyName("terminationNotification")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetStatusAtProviderTerminationNotification>? TerminationNotification { get; set; }

    /// <summary>The Unique ID for the Virtual Machine Scale Set.</summary>
    [JsonPropertyName("uniqueId")]
    public string? UniqueId { get; set; }

    /// <summary>Should the Virtual Machines in this Scale Set be strictly evenly distributed across Availability Zones? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("zoneBalance")]
    public bool? ZoneBalance { get; set; }

    /// <summary>Specifies a list of Availability Zones across which the Virtual Machine Scale Set will create instances. Changing this forces a new Virtual Machine Scale Set to be created.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetStatusConditions
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

/// <summary>OrchestratedVirtualMachineScaleSetStatus defines the observed state of OrchestratedVirtualMachineScaleSet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1OrchestratedVirtualMachineScaleSetStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1OrchestratedVirtualMachineScaleSetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1OrchestratedVirtualMachineScaleSetStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>OrchestratedVirtualMachineScaleSet is the Schema for the OrchestratedVirtualMachineScaleSets API. Manages an Virtual Machine Scale Set in Flexible Orchestration Mode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1OrchestratedVirtualMachineScaleSet : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1OrchestratedVirtualMachineScaleSetSpec>, IStatus<V1beta1OrchestratedVirtualMachineScaleSetStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "OrchestratedVirtualMachineScaleSet";
    public const string KubeGroup = "compute.azure.upbound.io";
    public const string KubePluralName = "orchestratedvirtualmachinescalesets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>OrchestratedVirtualMachineScaleSetSpec defines the desired state of OrchestratedVirtualMachineScaleSet</summary>
    [JsonPropertyName("spec")]
    public V1beta1OrchestratedVirtualMachineScaleSetSpec Spec { get; set; }

    /// <summary>OrchestratedVirtualMachineScaleSetStatus defines the observed state of OrchestratedVirtualMachineScaleSet.</summary>
    [JsonPropertyName("status")]
    public V1beta1OrchestratedVirtualMachineScaleSetStatus? Status { get; set; }
}