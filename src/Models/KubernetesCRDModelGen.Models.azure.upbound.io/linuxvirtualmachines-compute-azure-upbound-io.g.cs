using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.azure.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecForProviderAdditionalCapabilities
{
    /// <summary>Whether to enable the hibernation capability or not.</summary>
    [JsonPropertyName("hibernationEnabled")]
    public bool? HibernationEnabled { get; set; }

    /// <summary>Should the capacity to enable Data Disks of the UltraSSD_LRS storage account type be supported on this Virtual Machine? Defaults to false.</summary>
    [JsonPropertyName("ultraSsdEnabled")]
    public bool? UltraSsdEnabled { get; set; }
}

/// <summary>The Password which should be used for the local-administrator on this Virtual Machine. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecForProviderAdminPasswordSecretRef
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
public partial class V1beta1LinuxVirtualMachineSpecForProviderAdminSshKey
{
    /// <summary>The Public Key which should be used for authentication, which needs to be at least 2048-bit and in ssh-rsa format. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    /// <summary>The Username for which this Public SSH Key should be configured. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecForProviderBootDiagnostics
{
    /// <summary>The Primary/Secondary Endpoint for the Azure Storage Account which should be used to store Boot Diagnostics, including Console Output and Screenshots from the Hypervisor.</summary>
    [JsonPropertyName("storageAccountUri")]
    public string? StorageAccountUri { get; set; }
}

/// <summary>The Base64-Encoded Custom Data which should be used for this Virtual Machine. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecForProviderCustomDataSecretRef
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
public partial class V1beta1LinuxVirtualMachineSpecForProviderGalleryApplication
{
    /// <summary>Specifies whether the version will be automatically updated for the VM when a new Gallery Application version is available in PIR/SIG. Defaults to false.</summary>
    [JsonPropertyName("automaticUpgradeEnabled")]
    public bool? AutomaticUpgradeEnabled { get; set; }

    /// <summary>Specifies the URI to an Azure Blob that will replace the default configuration for the package if provided.</summary>
    [JsonPropertyName("configurationBlobUri")]
    public string? ConfigurationBlobUri { get; set; }

    /// <summary>Specifies the order in which the packages have to be installed. Possible values are between 0 and 2,147,483,647.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>Specifies a passthrough value for more generic context. This field can be any valid string value.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>Specifies whether any failure for any operation in the VmApplication will fail the deployment of the VM. Defaults to false.</summary>
    [JsonPropertyName("treatFailureAsDeploymentFailureEnabled")]
    public bool? TreatFailureAsDeploymentFailureEnabled { get; set; }

    /// <summary>Specifies the Gallery Application Version resource ID.</summary>
    [JsonPropertyName("versionId")]
    public string? VersionId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecForProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Linux Virtual Machine.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Linux Virtual Machine. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecForProviderNetworkInterfaceIdsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecForProviderNetworkInterfaceIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxVirtualMachineSpecForProviderNetworkInterfaceIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecForProviderNetworkInterfaceIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of NetworkInterface in network to populate networkInterfaceIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecForProviderNetworkInterfaceIdsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxVirtualMachineSpecForProviderNetworkInterfaceIdsSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecForProviderOsDiskDiffDiskSettings
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
public partial class V1beta1LinuxVirtualMachineSpecForProviderOsDisk
{
    /// <summary>The Type of Caching which should be used for the Internal OS Disk. Possible values are None, ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>A diff_disk_settings block as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diffDiskSettings")]
    public IList<V1beta1LinuxVirtualMachineSpecForProviderOsDiskDiffDiskSettings>? DiffDiskSettings { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to Encrypt this OS Disk. Conflicts with secure_vm_disk_encryption_set_id.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>The Size of the Internal OS Disk in GB, if you wish to vary from the size used in the image this Virtual Machine is sourced from.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The name which should be used for the Internal OS Disk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to Encrypt this OS Disk when the Virtual Machine is a Confidential VM. Conflicts with disk_encryption_set_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("secureVmDiskEncryptionSetId")]
    public string? SecureVmDiskEncryptionSetId { get; set; }

    /// <summary>Encryption Type when the Virtual Machine is a Confidential VM. Possible values are VMGuestStateOnly and DiskWithVMGuestState. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityEncryptionType")]
    public string? SecurityEncryptionType { get; set; }

    /// <summary>The Type of Storage Account which should back this the Internal OS Disk. Possible values are Standard_LRS, StandardSSD_LRS, Premium_LRS, StandardSSD_ZRS and Premium_ZRS. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>Should Write Accelerator be Enabled for this OS Disk? Defaults to false.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecForProviderOsImageNotification
{
    /// <summary>Length of time a notification to be sent to the VM on the instance metadata server till the VM gets OS upgraded. The only possible value is PT15M. Defaults to PT15M.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecForProviderPlan
{
    /// <summary>Specifies the Name of the Marketplace Image this Virtual Machine should be created from. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the Product of the Marketplace Image this Virtual Machine should be created from. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary>Specifies the Publisher of the Marketplace Image this Virtual Machine should be created from. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1LinuxVirtualMachineSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxVirtualMachineSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1LinuxVirtualMachineSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxVirtualMachineSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecForProviderSecretCertificate
{
    /// <summary>The Secret URL of a Key Vault Certificate.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecForProviderSecret
{
    /// <summary>One or more certificate blocks as defined above.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1LinuxVirtualMachineSpecForProviderSecretCertificate>? Certificate { get; set; }

    /// <summary>The ID of the Key Vault from which all Secrets should be sourced.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecForProviderSourceImageReference
{
    /// <summary>Specifies the offer of the image used to create the virtual machines. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("offer")]
    public string? Offer { get; set; }

    /// <summary>Specifies the publisher of the image used to create the virtual machines. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>Specifies the SKU of the image used to create the virtual machines. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>Specifies the version of the image used to create the virtual machines. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecForProviderTerminationNotification
{
    /// <summary>Should the termination notification be enabled on this Virtual Machine?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Length of time (in minutes, between 5 and 15) a notification to be sent to the VM on the instance metadata server till the VM gets deleted. The time duration should be specified in ISO 8601 format. Defaults to PT5M.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecForProvider
{
    /// <summary>A additional_capabilities block as defined below.</summary>
    [JsonPropertyName("additionalCapabilities")]
    public IList<V1beta1LinuxVirtualMachineSpecForProviderAdditionalCapabilities>? AdditionalCapabilities { get; set; }

    /// <summary>The Password which should be used for the local-administrator on this Virtual Machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminPasswordSecretRef")]
    public V1beta1LinuxVirtualMachineSpecForProviderAdminPasswordSecretRef? AdminPasswordSecretRef { get; set; }

    /// <summary>One or more admin_ssh_key blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminSshKey")]
    public IList<V1beta1LinuxVirtualMachineSpecForProviderAdminSshKey>? AdminSshKey { get; set; }

    /// <summary>The username of the local administrator used for the Virtual Machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>Should Extension Operations be allowed on this Virtual Machine? Defaults to true.</summary>
    [JsonPropertyName("allowExtensionOperations")]
    public bool? AllowExtensionOperations { get; set; }

    /// <summary>Specifies the ID of the Availability Set in which the Virtual Machine should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("availabilitySetId")]
    public string? AvailabilitySetId { get; set; }

    /// <summary>A boot_diagnostics block as defined below.</summary>
    [JsonPropertyName("bootDiagnostics")]
    public IList<V1beta1LinuxVirtualMachineSpecForProviderBootDiagnostics>? BootDiagnostics { get; set; }

    /// <summary>Specifies whether to skip platform scheduled patching when a user schedule is associated with the VM. Defaults to false.</summary>
    [JsonPropertyName("bypassPlatformSafetyChecksOnUserScheduleEnabled")]
    public bool? BypassPlatformSafetyChecksOnUserScheduleEnabled { get; set; }

    /// <summary>Specifies the ID of the Capacity Reservation Group which the Virtual Machine should be allocated to.</summary>
    [JsonPropertyName("capacityReservationGroupId")]
    public string? CapacityReservationGroupId { get; set; }

    /// <summary>Specifies the Hostname which should be used for this Virtual Machine. If unspecified this defaults to the value for the name field. If the value of the name field is not a valid computer_name, then you must specify computer_name. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("computerName")]
    public string? ComputerName { get; set; }

    /// <summary>The Base64-Encoded Custom Data which should be used for this Virtual Machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("customDataSecretRef")]
    public V1beta1LinuxVirtualMachineSpecForProviderCustomDataSecretRef? CustomDataSecretRef { get; set; }

    /// <summary>The ID of a Dedicated Host Group that this Linux Virtual Machine should be run within. Conflicts with dedicated_host_id.</summary>
    [JsonPropertyName("dedicatedHostGroupId")]
    public string? DedicatedHostGroupId { get; set; }

    /// <summary>The ID of a Dedicated Host where this machine should be run on. Conflicts with dedicated_host_group_id.</summary>
    [JsonPropertyName("dedicatedHostId")]
    public string? DedicatedHostId { get; set; }

    /// <summary>Should Password Authentication be disabled on this Virtual Machine? Defaults to true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("disablePasswordAuthentication")]
    public bool? DisablePasswordAuthentication { get; set; }

    /// <summary>Specifies the Disk Controller Type used for this Virtual Machine. Possible values are SCSI and NVMe.</summary>
    [JsonPropertyName("diskControllerType")]
    public string? DiskControllerType { get; set; }

    /// <summary>Specifies the Edge Zone within the Azure Region where this Linux Virtual Machine should exist. Changing this forces a new Linux Virtual Machine to be created.</summary>
    [JsonPropertyName("edgeZone")]
    public string? EdgeZone { get; set; }

    /// <summary>Should all of the disks (including the temp disk) attached to this Virtual Machine be encrypted by enabling Encryption at Host?</summary>
    [JsonPropertyName("encryptionAtHostEnabled")]
    public bool? EncryptionAtHostEnabled { get; set; }

    /// <summary>Specifies what should happen when the Virtual Machine is evicted for price reasons when using a Spot instance. Possible values are Deallocate and Delete. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>Specifies the duration allocated for all extensions to start. The time duration should be between 15 minutes and 120 minutes (inclusive) and should be specified in ISO 8601 format. Defaults to PT1H30M.</summary>
    [JsonPropertyName("extensionsTimeBudget")]
    public string? ExtensionsTimeBudget { get; set; }

    /// <summary>One or more gallery_application blocks as defined below.</summary>
    [JsonPropertyName("galleryApplication")]
    public IList<V1beta1LinuxVirtualMachineSpecForProviderGalleryApplication>? GalleryApplication { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1LinuxVirtualMachineSpecForProviderIdentity>? Identity { get; set; }

    /// <summary>Specifies the BYOL Type for this Virtual Machine. Possible values are RHEL_BYOS and SLES_BYOS.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>The Azure location where the Linux Virtual Machine should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The maximum price you're willing to pay for this Virtual Machine, in US Dollars; which must be greater than the current spot price. If this bid price falls below the current spot price the Virtual Machine will be evicted using the eviction_policy. Defaults to -1, which means that the Virtual Machine should not be evicted for price reasons.</summary>
    [JsonPropertyName("maxBidPrice")]
    public double? MaxBidPrice { get; set; }

    /// <summary>. A list of Network Interface IDs which should be attached to this Virtual Machine. The first Network Interface ID in this list will be the Primary Network Interface on the Virtual Machine.</summary>
    [JsonPropertyName("networkInterfaceIds")]
    public IList<string>? NetworkInterfaceIds { get; set; }

    /// <summary>References to NetworkInterface in network to populate networkInterfaceIds.</summary>
    [JsonPropertyName("networkInterfaceIdsRefs")]
    public IList<V1beta1LinuxVirtualMachineSpecForProviderNetworkInterfaceIdsRefs>? NetworkInterfaceIdsRefs { get; set; }

    /// <summary>Selector for a list of NetworkInterface in network to populate networkInterfaceIds.</summary>
    [JsonPropertyName("networkInterfaceIdsSelector")]
    public V1beta1LinuxVirtualMachineSpecForProviderNetworkInterfaceIdsSelector? NetworkInterfaceIdsSelector { get; set; }

    /// <summary>A os_disk block as defined below.</summary>
    [JsonPropertyName("osDisk")]
    public IList<V1beta1LinuxVirtualMachineSpecForProviderOsDisk>? OsDisk { get; set; }

    /// <summary>A os_image_notification block as defined below.</summary>
    [JsonPropertyName("osImageNotification")]
    public IList<V1beta1LinuxVirtualMachineSpecForProviderOsImageNotification>? OsImageNotification { get; set; }

    /// <summary>Specifies the mode of VM Guest Patching for the Virtual Machine. Possible values are AutomaticByPlatform or ImageDefault. Defaults to ImageDefault.</summary>
    [JsonPropertyName("patchAssessmentMode")]
    public string? PatchAssessmentMode { get; set; }

    /// <summary>Specifies the mode of in-guest patching to this Linux Virtual Machine. Possible values are AutomaticByPlatform and ImageDefault. Defaults to ImageDefault. For more information on patch modes please see the product documentation.</summary>
    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }

    /// <summary>A plan block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("plan")]
    public IList<V1beta1LinuxVirtualMachineSpecForProviderPlan>? Plan { get; set; }

    /// <summary>Specifies the Platform Fault Domain in which this Linux Virtual Machine should be created. Defaults to -1, which means this will be automatically assigned to a fault domain that best maintains balance across the available fault domains. Changing this forces a new Linux Virtual Machine to be created.</summary>
    [JsonPropertyName("platformFaultDomain")]
    public double? PlatformFaultDomain { get; set; }

    /// <summary>Specifies the priority of this Virtual Machine. Possible values are Regular and Spot. Defaults to Regular. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>Should the Azure VM Agent be provisioned on this Virtual Machine? Defaults to true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("provisionVmAgent")]
    public bool? ProvisionVmAgent { get; set; }

    /// <summary>The ID of the Proximity Placement Group which the Virtual Machine should be assigned to.</summary>
    [JsonPropertyName("proximityPlacementGroupId")]
    public string? ProximityPlacementGroupId { get; set; }

    /// <summary>Specifies the reboot setting for platform scheduled patching. Possible values are Always, IfRequired and Never.</summary>
    [JsonPropertyName("rebootSetting")]
    public string? RebootSetting { get; set; }

    /// <summary>The name of the Resource Group in which the Linux Virtual Machine should be exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1LinuxVirtualMachineSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1LinuxVirtualMachineSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>One or more secret blocks as defined below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta1LinuxVirtualMachineSpecForProviderSecret>? Secret { get; set; }

    /// <summary>Specifies whether secure boot should be enabled on the virtual machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("secureBootEnabled")]
    public bool? SecureBootEnabled { get; set; }

    /// <summary>The SKU which should be used for this Virtual Machine, such as Standard_F2.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>The ID of the Image which this Virtual Machine should be created from. Changing this forces a new resource to be created. Possible Image ID types include Image IDs, Shared Image IDs, Shared Image Version IDs, Community Gallery Image IDs, Community Gallery Image Version IDs, Shared Gallery Image IDs and Shared Gallery Image Version IDs.</summary>
    [JsonPropertyName("sourceImageId")]
    public string? SourceImageId { get; set; }

    /// <summary>A source_image_reference block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sourceImageReference")]
    public IList<V1beta1LinuxVirtualMachineSpecForProviderSourceImageReference>? SourceImageReference { get; set; }

    /// <summary>A mapping of tags which should be assigned to this Virtual Machine.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A termination_notification block as defined below.</summary>
    [JsonPropertyName("terminationNotification")]
    public IList<V1beta1LinuxVirtualMachineSpecForProviderTerminationNotification>? TerminationNotification { get; set; }

    /// <summary>The Base64-Encoded User Data which should be used for this Virtual Machine.</summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary>Specifies the Orchestrated Virtual Machine Scale Set that this Virtual Machine should be created within.</summary>
    [JsonPropertyName("virtualMachineScaleSetId")]
    public string? VirtualMachineScaleSetId { get; set; }

    /// <summary>Specifies whether VMAgent Platform Updates is enabled. Defaults to false.</summary>
    [JsonPropertyName("vmAgentPlatformUpdatesEnabled")]
    public bool? VmAgentPlatformUpdatesEnabled { get; set; }

    /// <summary>Specifies whether vTPM should be enabled on the virtual machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vtpmEnabled")]
    public bool? VtpmEnabled { get; set; }

    /// <summary>Specifies the Availability Zones in which this Linux Virtual Machine should be located. Changing this forces a new Linux Virtual Machine to be created.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecInitProviderAdditionalCapabilities
{
    /// <summary>Whether to enable the hibernation capability or not.</summary>
    [JsonPropertyName("hibernationEnabled")]
    public bool? HibernationEnabled { get; set; }

    /// <summary>Should the capacity to enable Data Disks of the UltraSSD_LRS storage account type be supported on this Virtual Machine? Defaults to false.</summary>
    [JsonPropertyName("ultraSsdEnabled")]
    public bool? UltraSsdEnabled { get; set; }
}

/// <summary>The Password which should be used for the local-administrator on this Virtual Machine. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecInitProviderAdminPasswordSecretRef
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
public partial class V1beta1LinuxVirtualMachineSpecInitProviderAdminSshKey
{
    /// <summary>The Public Key which should be used for authentication, which needs to be at least 2048-bit and in ssh-rsa format. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    /// <summary>The Username for which this Public SSH Key should be configured. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecInitProviderBootDiagnostics
{
    /// <summary>The Primary/Secondary Endpoint for the Azure Storage Account which should be used to store Boot Diagnostics, including Console Output and Screenshots from the Hypervisor.</summary>
    [JsonPropertyName("storageAccountUri")]
    public string? StorageAccountUri { get; set; }
}

/// <summary>The Base64-Encoded Custom Data which should be used for this Virtual Machine. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecInitProviderCustomDataSecretRef
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
public partial class V1beta1LinuxVirtualMachineSpecInitProviderGalleryApplication
{
    /// <summary>Specifies whether the version will be automatically updated for the VM when a new Gallery Application version is available in PIR/SIG. Defaults to false.</summary>
    [JsonPropertyName("automaticUpgradeEnabled")]
    public bool? AutomaticUpgradeEnabled { get; set; }

    /// <summary>Specifies the URI to an Azure Blob that will replace the default configuration for the package if provided.</summary>
    [JsonPropertyName("configurationBlobUri")]
    public string? ConfigurationBlobUri { get; set; }

    /// <summary>Specifies the order in which the packages have to be installed. Possible values are between 0 and 2,147,483,647.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>Specifies a passthrough value for more generic context. This field can be any valid string value.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>Specifies whether any failure for any operation in the VmApplication will fail the deployment of the VM. Defaults to false.</summary>
    [JsonPropertyName("treatFailureAsDeploymentFailureEnabled")]
    public bool? TreatFailureAsDeploymentFailureEnabled { get; set; }

    /// <summary>Specifies the Gallery Application Version resource ID.</summary>
    [JsonPropertyName("versionId")]
    public string? VersionId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecInitProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Linux Virtual Machine.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Linux Virtual Machine. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecInitProviderNetworkInterfaceIdsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecInitProviderNetworkInterfaceIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxVirtualMachineSpecInitProviderNetworkInterfaceIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecInitProviderNetworkInterfaceIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of NetworkInterface in network to populate networkInterfaceIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecInitProviderNetworkInterfaceIdsSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxVirtualMachineSpecInitProviderNetworkInterfaceIdsSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecInitProviderOsDiskDiffDiskSettings
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
public partial class V1beta1LinuxVirtualMachineSpecInitProviderOsDisk
{
    /// <summary>The Type of Caching which should be used for the Internal OS Disk. Possible values are None, ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>A diff_disk_settings block as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diffDiskSettings")]
    public IList<V1beta1LinuxVirtualMachineSpecInitProviderOsDiskDiffDiskSettings>? DiffDiskSettings { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to Encrypt this OS Disk. Conflicts with secure_vm_disk_encryption_set_id.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>The Size of the Internal OS Disk in GB, if you wish to vary from the size used in the image this Virtual Machine is sourced from.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The name which should be used for the Internal OS Disk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to Encrypt this OS Disk when the Virtual Machine is a Confidential VM. Conflicts with disk_encryption_set_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("secureVmDiskEncryptionSetId")]
    public string? SecureVmDiskEncryptionSetId { get; set; }

    /// <summary>Encryption Type when the Virtual Machine is a Confidential VM. Possible values are VMGuestStateOnly and DiskWithVMGuestState. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityEncryptionType")]
    public string? SecurityEncryptionType { get; set; }

    /// <summary>The Type of Storage Account which should back this the Internal OS Disk. Possible values are Standard_LRS, StandardSSD_LRS, Premium_LRS, StandardSSD_ZRS and Premium_ZRS. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>Should Write Accelerator be Enabled for this OS Disk? Defaults to false.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecInitProviderOsImageNotification
{
    /// <summary>Length of time a notification to be sent to the VM on the instance metadata server till the VM gets OS upgraded. The only possible value is PT15M. Defaults to PT15M.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecInitProviderPlan
{
    /// <summary>Specifies the Name of the Marketplace Image this Virtual Machine should be created from. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the Product of the Marketplace Image this Virtual Machine should be created from. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary>Specifies the Publisher of the Marketplace Image this Virtual Machine should be created from. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecInitProviderSecretCertificate
{
    /// <summary>The Secret URL of a Key Vault Certificate.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecInitProviderSecret
{
    /// <summary>One or more certificate blocks as defined above.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1LinuxVirtualMachineSpecInitProviderSecretCertificate>? Certificate { get; set; }

    /// <summary>The ID of the Key Vault from which all Secrets should be sourced.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecInitProviderSourceImageReference
{
    /// <summary>Specifies the offer of the image used to create the virtual machines. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("offer")]
    public string? Offer { get; set; }

    /// <summary>Specifies the publisher of the image used to create the virtual machines. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>Specifies the SKU of the image used to create the virtual machines. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>Specifies the version of the image used to create the virtual machines. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecInitProviderTerminationNotification
{
    /// <summary>Should the termination notification be enabled on this Virtual Machine?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Length of time (in minutes, between 5 and 15) a notification to be sent to the VM on the instance metadata server till the VM gets deleted. The time duration should be specified in ISO 8601 format. Defaults to PT5M.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecInitProvider
{
    /// <summary>A additional_capabilities block as defined below.</summary>
    [JsonPropertyName("additionalCapabilities")]
    public IList<V1beta1LinuxVirtualMachineSpecInitProviderAdditionalCapabilities>? AdditionalCapabilities { get; set; }

    /// <summary>The Password which should be used for the local-administrator on this Virtual Machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminPasswordSecretRef")]
    public V1beta1LinuxVirtualMachineSpecInitProviderAdminPasswordSecretRef? AdminPasswordSecretRef { get; set; }

    /// <summary>One or more admin_ssh_key blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminSshKey")]
    public IList<V1beta1LinuxVirtualMachineSpecInitProviderAdminSshKey>? AdminSshKey { get; set; }

    /// <summary>The username of the local administrator used for the Virtual Machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>Should Extension Operations be allowed on this Virtual Machine? Defaults to true.</summary>
    [JsonPropertyName("allowExtensionOperations")]
    public bool? AllowExtensionOperations { get; set; }

    /// <summary>Specifies the ID of the Availability Set in which the Virtual Machine should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("availabilitySetId")]
    public string? AvailabilitySetId { get; set; }

    /// <summary>A boot_diagnostics block as defined below.</summary>
    [JsonPropertyName("bootDiagnostics")]
    public IList<V1beta1LinuxVirtualMachineSpecInitProviderBootDiagnostics>? BootDiagnostics { get; set; }

    /// <summary>Specifies whether to skip platform scheduled patching when a user schedule is associated with the VM. Defaults to false.</summary>
    [JsonPropertyName("bypassPlatformSafetyChecksOnUserScheduleEnabled")]
    public bool? BypassPlatformSafetyChecksOnUserScheduleEnabled { get; set; }

    /// <summary>Specifies the ID of the Capacity Reservation Group which the Virtual Machine should be allocated to.</summary>
    [JsonPropertyName("capacityReservationGroupId")]
    public string? CapacityReservationGroupId { get; set; }

    /// <summary>Specifies the Hostname which should be used for this Virtual Machine. If unspecified this defaults to the value for the name field. If the value of the name field is not a valid computer_name, then you must specify computer_name. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("computerName")]
    public string? ComputerName { get; set; }

    /// <summary>The Base64-Encoded Custom Data which should be used for this Virtual Machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("customDataSecretRef")]
    public V1beta1LinuxVirtualMachineSpecInitProviderCustomDataSecretRef? CustomDataSecretRef { get; set; }

    /// <summary>The ID of a Dedicated Host Group that this Linux Virtual Machine should be run within. Conflicts with dedicated_host_id.</summary>
    [JsonPropertyName("dedicatedHostGroupId")]
    public string? DedicatedHostGroupId { get; set; }

    /// <summary>The ID of a Dedicated Host where this machine should be run on. Conflicts with dedicated_host_group_id.</summary>
    [JsonPropertyName("dedicatedHostId")]
    public string? DedicatedHostId { get; set; }

    /// <summary>Should Password Authentication be disabled on this Virtual Machine? Defaults to true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("disablePasswordAuthentication")]
    public bool? DisablePasswordAuthentication { get; set; }

    /// <summary>Specifies the Disk Controller Type used for this Virtual Machine. Possible values are SCSI and NVMe.</summary>
    [JsonPropertyName("diskControllerType")]
    public string? DiskControllerType { get; set; }

    /// <summary>Specifies the Edge Zone within the Azure Region where this Linux Virtual Machine should exist. Changing this forces a new Linux Virtual Machine to be created.</summary>
    [JsonPropertyName("edgeZone")]
    public string? EdgeZone { get; set; }

    /// <summary>Should all of the disks (including the temp disk) attached to this Virtual Machine be encrypted by enabling Encryption at Host?</summary>
    [JsonPropertyName("encryptionAtHostEnabled")]
    public bool? EncryptionAtHostEnabled { get; set; }

    /// <summary>Specifies what should happen when the Virtual Machine is evicted for price reasons when using a Spot instance. Possible values are Deallocate and Delete. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>Specifies the duration allocated for all extensions to start. The time duration should be between 15 minutes and 120 minutes (inclusive) and should be specified in ISO 8601 format. Defaults to PT1H30M.</summary>
    [JsonPropertyName("extensionsTimeBudget")]
    public string? ExtensionsTimeBudget { get; set; }

    /// <summary>One or more gallery_application blocks as defined below.</summary>
    [JsonPropertyName("galleryApplication")]
    public IList<V1beta1LinuxVirtualMachineSpecInitProviderGalleryApplication>? GalleryApplication { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1LinuxVirtualMachineSpecInitProviderIdentity>? Identity { get; set; }

    /// <summary>Specifies the BYOL Type for this Virtual Machine. Possible values are RHEL_BYOS and SLES_BYOS.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>The Azure location where the Linux Virtual Machine should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The maximum price you're willing to pay for this Virtual Machine, in US Dollars; which must be greater than the current spot price. If this bid price falls below the current spot price the Virtual Machine will be evicted using the eviction_policy. Defaults to -1, which means that the Virtual Machine should not be evicted for price reasons.</summary>
    [JsonPropertyName("maxBidPrice")]
    public double? MaxBidPrice { get; set; }

    /// <summary>. A list of Network Interface IDs which should be attached to this Virtual Machine. The first Network Interface ID in this list will be the Primary Network Interface on the Virtual Machine.</summary>
    [JsonPropertyName("networkInterfaceIds")]
    public IList<string>? NetworkInterfaceIds { get; set; }

    /// <summary>References to NetworkInterface in network to populate networkInterfaceIds.</summary>
    [JsonPropertyName("networkInterfaceIdsRefs")]
    public IList<V1beta1LinuxVirtualMachineSpecInitProviderNetworkInterfaceIdsRefs>? NetworkInterfaceIdsRefs { get; set; }

    /// <summary>Selector for a list of NetworkInterface in network to populate networkInterfaceIds.</summary>
    [JsonPropertyName("networkInterfaceIdsSelector")]
    public V1beta1LinuxVirtualMachineSpecInitProviderNetworkInterfaceIdsSelector? NetworkInterfaceIdsSelector { get; set; }

    /// <summary>A os_disk block as defined below.</summary>
    [JsonPropertyName("osDisk")]
    public IList<V1beta1LinuxVirtualMachineSpecInitProviderOsDisk>? OsDisk { get; set; }

    /// <summary>A os_image_notification block as defined below.</summary>
    [JsonPropertyName("osImageNotification")]
    public IList<V1beta1LinuxVirtualMachineSpecInitProviderOsImageNotification>? OsImageNotification { get; set; }

    /// <summary>Specifies the mode of VM Guest Patching for the Virtual Machine. Possible values are AutomaticByPlatform or ImageDefault. Defaults to ImageDefault.</summary>
    [JsonPropertyName("patchAssessmentMode")]
    public string? PatchAssessmentMode { get; set; }

    /// <summary>Specifies the mode of in-guest patching to this Linux Virtual Machine. Possible values are AutomaticByPlatform and ImageDefault. Defaults to ImageDefault. For more information on patch modes please see the product documentation.</summary>
    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }

    /// <summary>A plan block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("plan")]
    public IList<V1beta1LinuxVirtualMachineSpecInitProviderPlan>? Plan { get; set; }

    /// <summary>Specifies the Platform Fault Domain in which this Linux Virtual Machine should be created. Defaults to -1, which means this will be automatically assigned to a fault domain that best maintains balance across the available fault domains. Changing this forces a new Linux Virtual Machine to be created.</summary>
    [JsonPropertyName("platformFaultDomain")]
    public double? PlatformFaultDomain { get; set; }

    /// <summary>Specifies the priority of this Virtual Machine. Possible values are Regular and Spot. Defaults to Regular. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>Should the Azure VM Agent be provisioned on this Virtual Machine? Defaults to true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("provisionVmAgent")]
    public bool? ProvisionVmAgent { get; set; }

    /// <summary>The ID of the Proximity Placement Group which the Virtual Machine should be assigned to.</summary>
    [JsonPropertyName("proximityPlacementGroupId")]
    public string? ProximityPlacementGroupId { get; set; }

    /// <summary>Specifies the reboot setting for platform scheduled patching. Possible values are Always, IfRequired and Never.</summary>
    [JsonPropertyName("rebootSetting")]
    public string? RebootSetting { get; set; }

    /// <summary>One or more secret blocks as defined below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta1LinuxVirtualMachineSpecInitProviderSecret>? Secret { get; set; }

    /// <summary>Specifies whether secure boot should be enabled on the virtual machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("secureBootEnabled")]
    public bool? SecureBootEnabled { get; set; }

    /// <summary>The SKU which should be used for this Virtual Machine, such as Standard_F2.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>The ID of the Image which this Virtual Machine should be created from. Changing this forces a new resource to be created. Possible Image ID types include Image IDs, Shared Image IDs, Shared Image Version IDs, Community Gallery Image IDs, Community Gallery Image Version IDs, Shared Gallery Image IDs and Shared Gallery Image Version IDs.</summary>
    [JsonPropertyName("sourceImageId")]
    public string? SourceImageId { get; set; }

    /// <summary>A source_image_reference block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sourceImageReference")]
    public IList<V1beta1LinuxVirtualMachineSpecInitProviderSourceImageReference>? SourceImageReference { get; set; }

    /// <summary>A mapping of tags which should be assigned to this Virtual Machine.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A termination_notification block as defined below.</summary>
    [JsonPropertyName("terminationNotification")]
    public IList<V1beta1LinuxVirtualMachineSpecInitProviderTerminationNotification>? TerminationNotification { get; set; }

    /// <summary>The Base64-Encoded User Data which should be used for this Virtual Machine.</summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary>Specifies the Orchestrated Virtual Machine Scale Set that this Virtual Machine should be created within.</summary>
    [JsonPropertyName("virtualMachineScaleSetId")]
    public string? VirtualMachineScaleSetId { get; set; }

    /// <summary>Specifies whether VMAgent Platform Updates is enabled. Defaults to false.</summary>
    [JsonPropertyName("vmAgentPlatformUpdatesEnabled")]
    public bool? VmAgentPlatformUpdatesEnabled { get; set; }

    /// <summary>Specifies whether vTPM should be enabled on the virtual machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vtpmEnabled")]
    public bool? VtpmEnabled { get; set; }

    /// <summary>Specifies the Availability Zones in which this Linux Virtual Machine should be located. Changing this forces a new Linux Virtual Machine to be created.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecProviderConfigRefPolicy
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
public partial class V1beta1LinuxVirtualMachineSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxVirtualMachineSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1LinuxVirtualMachineSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LinuxVirtualMachineSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1LinuxVirtualMachineSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1LinuxVirtualMachineSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1LinuxVirtualMachineSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>LinuxVirtualMachineSpec defines the desired state of LinuxVirtualMachine</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1LinuxVirtualMachineSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1LinuxVirtualMachineSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1LinuxVirtualMachineSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1LinuxVirtualMachineSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1LinuxVirtualMachineSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineStatusAtProviderAdditionalCapabilities
{
    /// <summary>Whether to enable the hibernation capability or not.</summary>
    [JsonPropertyName("hibernationEnabled")]
    public bool? HibernationEnabled { get; set; }

    /// <summary>Should the capacity to enable Data Disks of the UltraSSD_LRS storage account type be supported on this Virtual Machine? Defaults to false.</summary>
    [JsonPropertyName("ultraSsdEnabled")]
    public bool? UltraSsdEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineStatusAtProviderAdminSshKey
{
    /// <summary>The Public Key which should be used for authentication, which needs to be at least 2048-bit and in ssh-rsa format. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    /// <summary>The Username for which this Public SSH Key should be configured. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineStatusAtProviderBootDiagnostics
{
    /// <summary>The Primary/Secondary Endpoint for the Azure Storage Account which should be used to store Boot Diagnostics, including Console Output and Screenshots from the Hypervisor.</summary>
    [JsonPropertyName("storageAccountUri")]
    public string? StorageAccountUri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineStatusAtProviderGalleryApplication
{
    /// <summary>Specifies whether the version will be automatically updated for the VM when a new Gallery Application version is available in PIR/SIG. Defaults to false.</summary>
    [JsonPropertyName("automaticUpgradeEnabled")]
    public bool? AutomaticUpgradeEnabled { get; set; }

    /// <summary>Specifies the URI to an Azure Blob that will replace the default configuration for the package if provided.</summary>
    [JsonPropertyName("configurationBlobUri")]
    public string? ConfigurationBlobUri { get; set; }

    /// <summary>Specifies the order in which the packages have to be installed. Possible values are between 0 and 2,147,483,647.</summary>
    [JsonPropertyName("order")]
    public double? Order { get; set; }

    /// <summary>Specifies a passthrough value for more generic context. This field can be any valid string value.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>Specifies whether any failure for any operation in the VmApplication will fail the deployment of the VM. Defaults to false.</summary>
    [JsonPropertyName("treatFailureAsDeploymentFailureEnabled")]
    public bool? TreatFailureAsDeploymentFailureEnabled { get; set; }

    /// <summary>Specifies the Gallery Application Version resource ID.</summary>
    [JsonPropertyName("versionId")]
    public string? VersionId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineStatusAtProviderIdentity
{
    /// <summary>Specifies a list of User Assigned Managed Identity IDs to be assigned to this Linux Virtual Machine.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Specifies the type of Managed Service Identity that should be configured on this Linux Virtual Machine. Possible values are SystemAssigned, UserAssigned, SystemAssigned, UserAssigned (to enable both).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineStatusAtProviderOsDiskDiffDiskSettings
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
public partial class V1beta1LinuxVirtualMachineStatusAtProviderOsDisk
{
    /// <summary>The Type of Caching which should be used for the Internal OS Disk. Possible values are None, ReadOnly and ReadWrite.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>A diff_disk_settings block as defined above. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diffDiskSettings")]
    public IList<V1beta1LinuxVirtualMachineStatusAtProviderOsDiskDiffDiskSettings>? DiffDiskSettings { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to Encrypt this OS Disk. Conflicts with secure_vm_disk_encryption_set_id.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>The Size of the Internal OS Disk in GB, if you wish to vary from the size used in the image this Virtual Machine is sourced from.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>The name which should be used for the Internal OS Disk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to Encrypt this OS Disk when the Virtual Machine is a Confidential VM. Conflicts with disk_encryption_set_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("secureVmDiskEncryptionSetId")]
    public string? SecureVmDiskEncryptionSetId { get; set; }

    /// <summary>Encryption Type when the Virtual Machine is a Confidential VM. Possible values are VMGuestStateOnly and DiskWithVMGuestState. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityEncryptionType")]
    public string? SecurityEncryptionType { get; set; }

    /// <summary>The Type of Storage Account which should back this the Internal OS Disk. Possible values are Standard_LRS, StandardSSD_LRS, Premium_LRS, StandardSSD_ZRS and Premium_ZRS. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>Should Write Accelerator be Enabled for this OS Disk? Defaults to false.</summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineStatusAtProviderOsImageNotification
{
    /// <summary>Length of time a notification to be sent to the VM on the instance metadata server till the VM gets OS upgraded. The only possible value is PT15M. Defaults to PT15M.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineStatusAtProviderPlan
{
    /// <summary>Specifies the Name of the Marketplace Image this Virtual Machine should be created from. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the Product of the Marketplace Image this Virtual Machine should be created from. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary>Specifies the Publisher of the Marketplace Image this Virtual Machine should be created from. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineStatusAtProviderSecretCertificate
{
    /// <summary>The Secret URL of a Key Vault Certificate.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineStatusAtProviderSecret
{
    /// <summary>One or more certificate blocks as defined above.</summary>
    [JsonPropertyName("certificate")]
    public IList<V1beta1LinuxVirtualMachineStatusAtProviderSecretCertificate>? Certificate { get; set; }

    /// <summary>The ID of the Key Vault from which all Secrets should be sourced.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineStatusAtProviderSourceImageReference
{
    /// <summary>Specifies the offer of the image used to create the virtual machines. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("offer")]
    public string? Offer { get; set; }

    /// <summary>Specifies the publisher of the image used to create the virtual machines. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>Specifies the SKU of the image used to create the virtual machines. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>Specifies the version of the image used to create the virtual machines. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineStatusAtProviderTerminationNotification
{
    /// <summary>Should the termination notification be enabled on this Virtual Machine?</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Length of time (in minutes, between 5 and 15) a notification to be sent to the VM on the instance metadata server till the VM gets deleted. The time duration should be specified in ISO 8601 format. Defaults to PT5M.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineStatusAtProvider
{
    /// <summary>A additional_capabilities block as defined below.</summary>
    [JsonPropertyName("additionalCapabilities")]
    public IList<V1beta1LinuxVirtualMachineStatusAtProviderAdditionalCapabilities>? AdditionalCapabilities { get; set; }

    /// <summary>One or more admin_ssh_key blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminSshKey")]
    public IList<V1beta1LinuxVirtualMachineStatusAtProviderAdminSshKey>? AdminSshKey { get; set; }

    /// <summary>The username of the local administrator used for the Virtual Machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary>Should Extension Operations be allowed on this Virtual Machine? Defaults to true.</summary>
    [JsonPropertyName("allowExtensionOperations")]
    public bool? AllowExtensionOperations { get; set; }

    /// <summary>Specifies the ID of the Availability Set in which the Virtual Machine should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("availabilitySetId")]
    public string? AvailabilitySetId { get; set; }

    /// <summary>A boot_diagnostics block as defined below.</summary>
    [JsonPropertyName("bootDiagnostics")]
    public IList<V1beta1LinuxVirtualMachineStatusAtProviderBootDiagnostics>? BootDiagnostics { get; set; }

    /// <summary>Specifies whether to skip platform scheduled patching when a user schedule is associated with the VM. Defaults to false.</summary>
    [JsonPropertyName("bypassPlatformSafetyChecksOnUserScheduleEnabled")]
    public bool? BypassPlatformSafetyChecksOnUserScheduleEnabled { get; set; }

    /// <summary>Specifies the ID of the Capacity Reservation Group which the Virtual Machine should be allocated to.</summary>
    [JsonPropertyName("capacityReservationGroupId")]
    public string? CapacityReservationGroupId { get; set; }

    /// <summary>Specifies the Hostname which should be used for this Virtual Machine. If unspecified this defaults to the value for the name field. If the value of the name field is not a valid computer_name, then you must specify computer_name. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("computerName")]
    public string? ComputerName { get; set; }

    /// <summary>The ID of a Dedicated Host Group that this Linux Virtual Machine should be run within. Conflicts with dedicated_host_id.</summary>
    [JsonPropertyName("dedicatedHostGroupId")]
    public string? DedicatedHostGroupId { get; set; }

    /// <summary>The ID of a Dedicated Host where this machine should be run on. Conflicts with dedicated_host_group_id.</summary>
    [JsonPropertyName("dedicatedHostId")]
    public string? DedicatedHostId { get; set; }

    /// <summary>Should Password Authentication be disabled on this Virtual Machine? Defaults to true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("disablePasswordAuthentication")]
    public bool? DisablePasswordAuthentication { get; set; }

    /// <summary>Specifies the Disk Controller Type used for this Virtual Machine. Possible values are SCSI and NVMe.</summary>
    [JsonPropertyName("diskControllerType")]
    public string? DiskControllerType { get; set; }

    /// <summary>Specifies the Edge Zone within the Azure Region where this Linux Virtual Machine should exist. Changing this forces a new Linux Virtual Machine to be created.</summary>
    [JsonPropertyName("edgeZone")]
    public string? EdgeZone { get; set; }

    /// <summary>Should all of the disks (including the temp disk) attached to this Virtual Machine be encrypted by enabling Encryption at Host?</summary>
    [JsonPropertyName("encryptionAtHostEnabled")]
    public bool? EncryptionAtHostEnabled { get; set; }

    /// <summary>Specifies what should happen when the Virtual Machine is evicted for price reasons when using a Spot instance. Possible values are Deallocate and Delete. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>Specifies the duration allocated for all extensions to start. The time duration should be between 15 minutes and 120 minutes (inclusive) and should be specified in ISO 8601 format. Defaults to PT1H30M.</summary>
    [JsonPropertyName("extensionsTimeBudget")]
    public string? ExtensionsTimeBudget { get; set; }

    /// <summary>One or more gallery_application blocks as defined below.</summary>
    [JsonPropertyName("galleryApplication")]
    public IList<V1beta1LinuxVirtualMachineStatusAtProviderGalleryApplication>? GalleryApplication { get; set; }

    /// <summary>The ID of the Linux Virtual Machine.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public IList<V1beta1LinuxVirtualMachineStatusAtProviderIdentity>? Identity { get; set; }

    /// <summary>Specifies the BYOL Type for this Virtual Machine. Possible values are RHEL_BYOS and SLES_BYOS.</summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>The Azure location where the Linux Virtual Machine should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The maximum price you're willing to pay for this Virtual Machine, in US Dollars; which must be greater than the current spot price. If this bid price falls below the current spot price the Virtual Machine will be evicted using the eviction_policy. Defaults to -1, which means that the Virtual Machine should not be evicted for price reasons.</summary>
    [JsonPropertyName("maxBidPrice")]
    public double? MaxBidPrice { get; set; }

    /// <summary>. A list of Network Interface IDs which should be attached to this Virtual Machine. The first Network Interface ID in this list will be the Primary Network Interface on the Virtual Machine.</summary>
    [JsonPropertyName("networkInterfaceIds")]
    public IList<string>? NetworkInterfaceIds { get; set; }

    /// <summary>A os_disk block as defined below.</summary>
    [JsonPropertyName("osDisk")]
    public IList<V1beta1LinuxVirtualMachineStatusAtProviderOsDisk>? OsDisk { get; set; }

    /// <summary>A os_image_notification block as defined below.</summary>
    [JsonPropertyName("osImageNotification")]
    public IList<V1beta1LinuxVirtualMachineStatusAtProviderOsImageNotification>? OsImageNotification { get; set; }

    /// <summary>Specifies the mode of VM Guest Patching for the Virtual Machine. Possible values are AutomaticByPlatform or ImageDefault. Defaults to ImageDefault.</summary>
    [JsonPropertyName("patchAssessmentMode")]
    public string? PatchAssessmentMode { get; set; }

    /// <summary>Specifies the mode of in-guest patching to this Linux Virtual Machine. Possible values are AutomaticByPlatform and ImageDefault. Defaults to ImageDefault. For more information on patch modes please see the product documentation.</summary>
    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }

    /// <summary>A plan block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("plan")]
    public IList<V1beta1LinuxVirtualMachineStatusAtProviderPlan>? Plan { get; set; }

    /// <summary>Specifies the Platform Fault Domain in which this Linux Virtual Machine should be created. Defaults to -1, which means this will be automatically assigned to a fault domain that best maintains balance across the available fault domains. Changing this forces a new Linux Virtual Machine to be created.</summary>
    [JsonPropertyName("platformFaultDomain")]
    public double? PlatformFaultDomain { get; set; }

    /// <summary>Specifies the priority of this Virtual Machine. Possible values are Regular and Spot. Defaults to Regular. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>The Primary Private IP Address assigned to this Virtual Machine.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>A list of Private IP Addresses assigned to this Virtual Machine.</summary>
    [JsonPropertyName("privateIpAddresses")]
    public IList<string>? PrivateIpAddresses { get; set; }

    /// <summary>Should the Azure VM Agent be provisioned on this Virtual Machine? Defaults to true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("provisionVmAgent")]
    public bool? ProvisionVmAgent { get; set; }

    /// <summary>The ID of the Proximity Placement Group which the Virtual Machine should be assigned to.</summary>
    [JsonPropertyName("proximityPlacementGroupId")]
    public string? ProximityPlacementGroupId { get; set; }

    /// <summary>The Primary Public IP Address assigned to this Virtual Machine.</summary>
    [JsonPropertyName("publicIpAddress")]
    public string? PublicIpAddress { get; set; }

    /// <summary>A list of the Public IP Addresses assigned to this Virtual Machine.</summary>
    [JsonPropertyName("publicIpAddresses")]
    public IList<string>? PublicIpAddresses { get; set; }

    /// <summary>Specifies the reboot setting for platform scheduled patching. Possible values are Always, IfRequired and Never.</summary>
    [JsonPropertyName("rebootSetting")]
    public string? RebootSetting { get; set; }

    /// <summary>The name of the Resource Group in which the Linux Virtual Machine should be exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>One or more secret blocks as defined below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta1LinuxVirtualMachineStatusAtProviderSecret>? Secret { get; set; }

    /// <summary>Specifies whether secure boot should be enabled on the virtual machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("secureBootEnabled")]
    public bool? SecureBootEnabled { get; set; }

    /// <summary>The SKU which should be used for this Virtual Machine, such as Standard_F2.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>The ID of the Image which this Virtual Machine should be created from. Changing this forces a new resource to be created. Possible Image ID types include Image IDs, Shared Image IDs, Shared Image Version IDs, Community Gallery Image IDs, Community Gallery Image Version IDs, Shared Gallery Image IDs and Shared Gallery Image Version IDs.</summary>
    [JsonPropertyName("sourceImageId")]
    public string? SourceImageId { get; set; }

    /// <summary>A source_image_reference block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sourceImageReference")]
    public IList<V1beta1LinuxVirtualMachineStatusAtProviderSourceImageReference>? SourceImageReference { get; set; }

    /// <summary>A mapping of tags which should be assigned to this Virtual Machine.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A termination_notification block as defined below.</summary>
    [JsonPropertyName("terminationNotification")]
    public IList<V1beta1LinuxVirtualMachineStatusAtProviderTerminationNotification>? TerminationNotification { get; set; }

    /// <summary>The Base64-Encoded User Data which should be used for this Virtual Machine.</summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary>A 128-bit identifier which uniquely identifies this Virtual Machine.</summary>
    [JsonPropertyName("virtualMachineId")]
    public string? VirtualMachineId { get; set; }

    /// <summary>Specifies the Orchestrated Virtual Machine Scale Set that this Virtual Machine should be created within.</summary>
    [JsonPropertyName("virtualMachineScaleSetId")]
    public string? VirtualMachineScaleSetId { get; set; }

    /// <summary>Specifies whether VMAgent Platform Updates is enabled. Defaults to false.</summary>
    [JsonPropertyName("vmAgentPlatformUpdatesEnabled")]
    public bool? VmAgentPlatformUpdatesEnabled { get; set; }

    /// <summary>Specifies whether vTPM should be enabled on the virtual machine. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("vtpmEnabled")]
    public bool? VtpmEnabled { get; set; }

    /// <summary>Specifies the Availability Zones in which this Linux Virtual Machine should be located. Changing this forces a new Linux Virtual Machine to be created.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineStatusConditions
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

/// <summary>LinuxVirtualMachineStatus defines the observed state of LinuxVirtualMachine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LinuxVirtualMachineStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1LinuxVirtualMachineStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LinuxVirtualMachineStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>LinuxVirtualMachine is the Schema for the LinuxVirtualMachines API. Manages a Linux Virtual Machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LinuxVirtualMachine : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LinuxVirtualMachineSpec>, IStatus<V1beta1LinuxVirtualMachineStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LinuxVirtualMachine";
    public const string KubeGroup = "compute.azure.upbound.io";
    public const string KubePluralName = "linuxvirtualmachines";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LinuxVirtualMachineSpec defines the desired state of LinuxVirtualMachine</summary>
    [JsonPropertyName("spec")]
    public V1beta1LinuxVirtualMachineSpec Spec { get; set; }

    /// <summary>LinuxVirtualMachineStatus defines the observed state of LinuxVirtualMachine.</summary>
    [JsonPropertyName("status")]
    public V1beta1LinuxVirtualMachineStatus? Status { get; set; }
}