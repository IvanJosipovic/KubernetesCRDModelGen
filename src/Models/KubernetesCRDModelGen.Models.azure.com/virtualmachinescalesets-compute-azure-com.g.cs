using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.azure.com;
/// <summary>Storage version of v1api20220301.AdditionalCapabilities Enables or disables a capability on the virtual machine or virtual machine scale set.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecAdditionalCapabilities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hibernationEnabled")]
    public bool? HibernationEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ultraSSDEnabled")]
    public bool? UltraSSDEnabled { get; set; }
}

/// <summary>Storage version of v1api20220301.AutomaticRepairsPolicy Specifies the configuration parameters for automatic repairs on the virtual machine scale set.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecAutomaticRepairsPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gracePeriod")]
    public string? GracePeriod { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repairAction")]
    public string? RepairAction { get; set; }
}

/// <summary>Storage version of v1api20220301.ExtendedLocation The complex type of the extended location.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecExtendedLocation
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Reference: Resource Id</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecHostGroupReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220301.SubResource</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecHostGroup
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineScaleSetSpecHostGroupReference? Reference { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecIdentityUserAssignedIdentitiesReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220301.UserAssignedIdentityDetails Information about the user assigned identity for the resource</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecIdentityUserAssignedIdentities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineScaleSetSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetIdentity Identity for the virtual machine scale set.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20220301storageVirtualMachineScaleSetSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220301.Plan Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use. In the Azure portal, find the marketplace image that you want to use and then click Want to deploy programmatically, Get Started -&gt;. Enter any required information and then click Save.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecPlan
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary></summary>
    [JsonPropertyName("promotionCode")]
    public string? PromotionCode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}

/// <summary>Reference: Resource Id</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecProximityPlacementGroupReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220301.SubResource</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecProximityPlacementGroup
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineScaleSetSpecProximityPlacementGroupReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20220301.ScaleInPolicy Describes a scale-in policy for a virtual machine scale set.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecScaleInPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceDeletion")]
    public bool? ForceDeletion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rules")]
    public IList<string>? Rules { get; set; }
}

/// <summary>Storage version of v1api20220301.Sku Describes a virtual machine scale set sku. NOTE: If the new VM SKU is not supported on the hardware the scale set is currently on, you need to deallocate the VMs in the scale set before you modify the SKU name.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecSku
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Storage version of v1api20220301.SpotRestorePolicy Specifies the Spot-Try-Restore properties for the virtual machine scale set. With this property customer can enable or disable automatic restore of the evicted Spot VMSS VM instances opportunistically based on capacity availability and pricing constraint.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecSpotRestorePolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restoreTimeout")]
    public string? RestoreTimeout { get; set; }
}

/// <summary>Storage version of v1api20220301.AutomaticOSUpgradePolicy The configuration parameters used for performing automatic OS upgrade.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecUpgradePolicyAutomaticOSUpgradePolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableAutomaticRollback")]
    public bool? DisableAutomaticRollback { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableAutomaticOSUpgrade")]
    public bool? EnableAutomaticOSUpgrade { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useRollingUpgradePolicy")]
    public bool? UseRollingUpgradePolicy { get; set; }
}

/// <summary>Storage version of v1api20220301.RollingUpgradePolicy The configuration parameters used while performing a rolling upgrade.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecUpgradePolicyRollingUpgradePolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableCrossZoneUpgrade")]
    public bool? EnableCrossZoneUpgrade { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxBatchInstancePercent")]
    public int? MaxBatchInstancePercent { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxUnhealthyInstancePercent")]
    public int? MaxUnhealthyInstancePercent { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxUnhealthyUpgradedInstancePercent")]
    public int? MaxUnhealthyUpgradedInstancePercent { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pauseTimeBetweenBatches")]
    public string? PauseTimeBetweenBatches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prioritizeUnhealthyInstances")]
    public bool? PrioritizeUnhealthyInstances { get; set; }
}

/// <summary>Storage version of v1api20220301.UpgradePolicy Describes an upgrade policy - automatic, manual, or rolling.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecUpgradePolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.AutomaticOSUpgradePolicy The configuration parameters used for performing automatic OS upgrade.</summary>
    [JsonPropertyName("automaticOSUpgradePolicy")]
    public V1api20220301storageVirtualMachineScaleSetSpecUpgradePolicyAutomaticOSUpgradePolicy? AutomaticOSUpgradePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Storage version of v1api20220301.RollingUpgradePolicy The configuration parameters used while performing a rolling upgrade.</summary>
    [JsonPropertyName("rollingUpgradePolicy")]
    public V1api20220301storageVirtualMachineScaleSetSpecUpgradePolicyRollingUpgradePolicy? RollingUpgradePolicy { get; set; }
}

/// <summary>PackageReferenceReference: Specifies the GalleryApplicationVersion resource id on the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{application}/versions/{version}</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileApplicationProfileGalleryApplicationsPackageReferenceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220301.VMGalleryApplication Specifies the required information to reference a compute gallery application version</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileApplicationProfileGalleryApplications
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configurationReference")]
    public string? ConfigurationReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableAutomaticUpgrade")]
    public bool? EnableAutomaticUpgrade { get; set; }

    /// <summary></summary>
    [JsonPropertyName("order")]
    public int? Order { get; set; }

    /// <summary>PackageReferenceReference: Specifies the GalleryApplicationVersion resource id on the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{application}/versions/{version}</summary>
    [JsonPropertyName("packageReferenceReference")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileApplicationProfileGalleryApplicationsPackageReferenceReference PackageReferenceReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public string? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("treatFailureAsDeploymentFailure")]
    public bool? TreatFailureAsDeploymentFailure { get; set; }
}

/// <summary>Storage version of v1api20220301.ApplicationProfile Contains the list of gallery applications that should be made available to the VM/VMSS</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileApplicationProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("galleryApplications")]
    public IList<V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileApplicationProfileGalleryApplications>? GalleryApplications { get; set; }
}

/// <summary>Storage version of v1api20220301.BillingProfile Specifies the billing related details of a Azure Spot VM or VMSS. Minimum api-version: 2019-03-01.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileBillingProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxPrice")]
    public double? MaxPrice { get; set; }
}

/// <summary>Reference: Resource Id</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileCapacityReservationCapacityReservationGroupReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220301.SubResource</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileCapacityReservationCapacityReservationGroup
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileCapacityReservationCapacityReservationGroupReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20220301.CapacityReservationProfile The parameters of a capacity reservation Profile.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileCapacityReservation
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource</summary>
    [JsonPropertyName("capacityReservationGroup")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileCapacityReservationCapacityReservationGroup? CapacityReservationGroup { get; set; }
}

/// <summary>Storage version of v1api20220301.BootDiagnostics Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to diagnose VM status. You can easily view the output of your console log. Azure also enables you to see a screenshot of the VM from the hypervisor.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileDiagnosticsProfileBootDiagnostics
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageUri")]
    public string? StorageUri { get; set; }
}

/// <summary>Storage version of v1api20220301.DiagnosticsProfile Specifies the boot diagnostic settings state. Minimum api-version: 2015-06-15.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileDiagnosticsProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.BootDiagnostics Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to diagnose VM status. You can easily view the output of your console log. Azure also enables you to see a screenshot of the VM from the hypervisor.</summary>
    [JsonPropertyName("bootDiagnostics")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileDiagnosticsProfileBootDiagnostics? BootDiagnostics { get; set; }
}

/// <summary>SecretMapReference is a reference to a Kubernetes secret in the same namespace as the resource it is on.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfileExtensionsProtectedSettings
{
    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Reference: Resource Id</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfileExtensionsProtectedSettingsFromKeyVaultSourceVaultReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220301.SubResource</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfileExtensionsProtectedSettingsFromKeyVaultSourceVault
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfileExtensionsProtectedSettingsFromKeyVaultSourceVaultReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20220301.KeyVaultSecretReference Describes a reference to Key Vault Secret</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfileExtensionsProtectedSettingsFromKeyVault
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfileExtensionsProtectedSettingsFromKeyVaultSourceVault? SourceVault { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetExtension Describes a Virtual Machine Scale Set Extension.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfileExtensions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("autoUpgradeMinorVersion")]
    public bool? AutoUpgradeMinorVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableAutomaticUpgrade")]
    public bool? EnableAutomaticUpgrade { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceUpdateTag")]
    public string? ForceUpdateTag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SecretMapReference is a reference to a Kubernetes secret in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("protectedSettings")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfileExtensionsProtectedSettings? ProtectedSettings { get; set; }

    /// <summary>Storage version of v1api20220301.KeyVaultSecretReference Describes a reference to Key Vault Secret</summary>
    [JsonPropertyName("protectedSettingsFromKeyVault")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfileExtensionsProtectedSettingsFromKeyVault? ProtectedSettingsFromKeyVault { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisionAfterExtensions")]
    public IList<string>? ProvisionAfterExtensions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary></summary>
    [JsonPropertyName("settings")]
    public IDictionary<string, JsonNode>? Settings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("suppressFailures")]
    public bool? SuppressFailures { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetExtensionProfile Describes a virtual machine scale set extension profile.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("extensions")]
    public IList<V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfileExtensions>? Extensions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("extensionsTimeBudget")]
    public string? ExtensionsTimeBudget { get; set; }
}

/// <summary>Storage version of v1api20220301.VMSizeProperties Specifies VM Size Property settings on the virtual machine.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileHardwareProfileVmSizeProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vCPUsAvailable")]
    public int? VCPUsAvailable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vCPUsPerCore")]
    public int? VCPUsPerCore { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetHardwareProfile Specifies the hardware settings for the virtual machine scale set.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileHardwareProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.VMSizeProperties Specifies VM Size Property settings on the virtual machine.</summary>
    [JsonPropertyName("vmSizeProperties")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileHardwareProfileVmSizeProperties? VmSizeProperties { get; set; }
}

/// <summary>Reference: The ARM resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileHealthProbeReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220301.ApiEntityReference The API entity reference.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileHealthProbe
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: The ARM resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileHealthProbeReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetNetworkConfigurationDnsSettings Describes a virtual machines scale sets network configuration's DNS settings.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsDnsSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dnsServers")]
    public IList<string>? DnsServers { get; set; }
}

/// <summary>Reference: Resource Id</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPoolsReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220301.SubResource</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPools
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPoolsReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroupsReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220301.SubResource</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroups
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroupsReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPoolsReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220301.SubResource</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPools
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPoolsReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerInboundNatPoolsReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220301.SubResource</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerInboundNatPools
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerInboundNatPoolsReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings Describes a virtual machines scale sets network configuration's DNS settings.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationDnsSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("domainNameLabel")]
    public string? DomainNameLabel { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetIpTag Contains the IP tag associated with the public IP address.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationIpTags
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipTagType")]
    public string? IpTagType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>Reference: Resource Id</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefixReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220301.SubResource</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefix
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefixReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20220301.PublicIPAddressSku Describes the public IP Sku. It can only be set with OrchestrationMode as Flexible.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationSku
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetPublicIPAddressConfiguration Describes a virtual machines scale set IP Configuration's PublicIPAddress configuration</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deleteOption")]
    public string? DeleteOption { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings Describes a virtual machines scale sets network configuration's DNS settings.</summary>
    [JsonPropertyName("dnsSettings")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationDnsSettings? DnsSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipTags")]
    public IList<V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationIpTags>? IpTags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicIPAddressVersion")]
    public string? PublicIPAddressVersion { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource</summary>
    [JsonPropertyName("publicIPPrefix")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefix? PublicIPPrefix { get; set; }

    /// <summary>Storage version of v1api20220301.PublicIPAddressSku Describes the public IP Sku. It can only be set with OrchestrationMode as Flexible.</summary>
    [JsonPropertyName("sku")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationSku? Sku { get; set; }
}

/// <summary>Reference: Resource Id</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Reference: The ARM resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnetReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220301.ApiEntityReference The API entity reference.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: The ARM resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnetReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetIPConfiguration Describes a virtual machine scale set network profile's IP configuration.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applicationGatewayBackendAddressPools")]
    public IList<V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPools>? ApplicationGatewayBackendAddressPools { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applicationSecurityGroups")]
    public IList<V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroups>? ApplicationSecurityGroups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loadBalancerBackendAddressPools")]
    public IList<V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPools>? LoadBalancerBackendAddressPools { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loadBalancerInboundNatPools")]
    public IList<V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerInboundNatPools>? LoadBalancerInboundNatPools { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateIPAddressVersion")]
    public string? PrivateIPAddressVersion { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineScaleSetPublicIPAddressConfiguration Describes a virtual machines scale set IP Configuration's PublicIPAddress configuration</summary>
    [JsonPropertyName("publicIPAddressConfiguration")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfiguration? PublicIPAddressConfiguration { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsReference? Reference { get; set; }

    /// <summary>Storage version of v1api20220301.ApiEntityReference The API entity reference.</summary>
    [JsonPropertyName("subnet")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnet? Subnet { get; set; }
}

/// <summary>Reference: Resource Id</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroupReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220301.SubResource</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroup
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroupReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetNetworkConfiguration Describes a virtual machine scale set network profile's network configurations.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deleteOption")]
    public string? DeleteOption { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineScaleSetNetworkConfigurationDnsSettings Describes a virtual machines scale sets network configuration's DNS settings.</summary>
    [JsonPropertyName("dnsSettings")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsDnsSettings? DnsSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableAcceleratedNetworking")]
    public bool? EnableAcceleratedNetworking { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableFpga")]
    public bool? EnableFpga { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableIPForwarding")]
    public bool? EnableIPForwarding { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipConfigurations")]
    public IList<V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurations>? IpConfigurations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource</summary>
    [JsonPropertyName("networkSecurityGroup")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroup? NetworkSecurityGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetNetworkProfile Describes a virtual machine scale set network profile.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.ApiEntityReference The API entity reference.</summary>
    [JsonPropertyName("healthProbe")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileHealthProbe? HealthProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkApiVersion")]
    public string? NetworkApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkInterfaceConfigurations")]
    public IList<V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurations>? NetworkInterfaceConfigurations { get; set; }
}

/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileAdminPassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Storage version of v1api20220301.LinuxVMGuestPatchAutomaticByPlatformSettings Specifies additional settings to be applied when patch mode AutomaticByPlatform is selected in Linux patch settings.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationPatchSettingsAutomaticByPlatformSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rebootSetting")]
    public string? RebootSetting { get; set; }
}

/// <summary>Storage version of v1api20220301.LinuxPatchSettings Specifies settings related to VM Guest Patching on Linux.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationPatchSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("assessmentMode")]
    public string? AssessmentMode { get; set; }

    /// <summary>Storage version of v1api20220301.LinuxVMGuestPatchAutomaticByPlatformSettings Specifies additional settings to be applied when patch mode AutomaticByPlatform is selected in Linux patch settings.</summary>
    [JsonPropertyName("automaticByPlatformSettings")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationPatchSettingsAutomaticByPlatformSettings? AutomaticByPlatformSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }
}

/// <summary>Storage version of v1api20220301.SshPublicKeySpec Contains information about SSH certificate public key and the path on the Linux VM where the public key is placed.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationSshPublicKeys
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyData")]
    public string? KeyData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Storage version of v1api20220301.SshConfiguration SSH configuration for Linux based VMs running on Azure</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationSsh
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicKeys")]
    public IList<V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationSshPublicKeys>? PublicKeys { get; set; }
}

/// <summary>Storage version of v1api20220301.LinuxConfiguration Specifies the Linux operating system settings on the virtual machine. For a list of supported Linux distributions, see [Linux on Azure-Endorsed Distributions](https://docs.microsoft.com/azure/virtual-machines/linux/endorsed-distros).</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disablePasswordAuthentication")]
    public bool? DisablePasswordAuthentication { get; set; }

    /// <summary>Storage version of v1api20220301.LinuxPatchSettings Specifies settings related to VM Guest Patching on Linux.</summary>
    [JsonPropertyName("patchSettings")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationPatchSettings? PatchSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisionVMAgent")]
    public bool? ProvisionVMAgent { get; set; }

    /// <summary>Storage version of v1api20220301.SshConfiguration SSH configuration for Linux based VMs running on Azure</summary>
    [JsonPropertyName("ssh")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfigurationSsh? Ssh { get; set; }
}

/// <summary>Reference: Resource Id</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecretsSourceVaultReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220301.SubResource</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecretsSourceVault
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecretsSourceVaultReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20220301.VaultCertificate Describes a single certificate reference in a Key Vault, and where the certificate should reside on the VM.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecretsVaultCertificates
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("certificateStore")]
    public string? CertificateStore { get; set; }

    /// <summary></summary>
    [JsonPropertyName("certificateUrl")]
    public string? CertificateUrl { get; set; }
}

/// <summary>Storage version of v1api20220301.VaultSecretGroup Describes a set of certificates which are all in the same Key Vault.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecrets
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecretsSourceVault? SourceVault { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vaultCertificates")]
    public IList<V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecretsVaultCertificates>? VaultCertificates { get; set; }
}

/// <summary>Storage version of v1api20220301.AdditionalUnattendContent Specifies additional XML formatted information that can be included in the Unattend.xml file, which is used by Windows Setup. Contents are defined by setting name, component name, and the pass in which the content is applied.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContent
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("componentName")]
    public string? ComponentName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passName")]
    public string? PassName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("settingName")]
    public string? SettingName { get; set; }
}

/// <summary>Storage version of v1api20220301.WindowsVMGuestPatchAutomaticByPlatformSettings Specifies additional settings to be applied when patch mode AutomaticByPlatform is selected in Windows patch settings.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationPatchSettingsAutomaticByPlatformSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rebootSetting")]
    public string? RebootSetting { get; set; }
}

/// <summary>Storage version of v1api20220301.PatchSettings Specifies settings related to VM Guest Patching on Windows.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationPatchSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("assessmentMode")]
    public string? AssessmentMode { get; set; }

    /// <summary>Storage version of v1api20220301.WindowsVMGuestPatchAutomaticByPlatformSettings Specifies additional settings to be applied when patch mode AutomaticByPlatform is selected in Windows patch settings.</summary>
    [JsonPropertyName("automaticByPlatformSettings")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationPatchSettingsAutomaticByPlatformSettings? AutomaticByPlatformSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableHotpatching")]
    public bool? EnableHotpatching { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }
}

/// <summary>Storage version of v1api20220301.WinRMListener Describes Protocol and thumbprint of Windows Remote Management listener</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationWinRMListeners
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("certificateUrl")]
    public string? CertificateUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>Storage version of v1api20220301.WinRMConfiguration Describes Windows Remote Management configuration of the VM</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationWinRM
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("listeners")]
    public IList<V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationWinRMListeners>? Listeners { get; set; }
}

/// <summary>Storage version of v1api20220301.WindowsConfiguration Specifies Windows operating system settings on the virtual machine.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalUnattendContent")]
    public IList<V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContent>? AdditionalUnattendContent { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableAutomaticUpdates")]
    public bool? EnableAutomaticUpdates { get; set; }

    /// <summary>Storage version of v1api20220301.PatchSettings Specifies settings related to VM Guest Patching on Windows.</summary>
    [JsonPropertyName("patchSettings")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationPatchSettings? PatchSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisionVMAgent")]
    public bool? ProvisionVMAgent { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>Storage version of v1api20220301.WinRMConfiguration Describes Windows Remote Management configuration of the VM</summary>
    [JsonPropertyName("winRM")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfigurationWinRM? WinRM { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetOSProfile Describes a virtual machine scale set OS profile.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("adminPassword")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileAdminPassword? AdminPassword { get; set; }

    /// <summary></summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowExtensionOperations")]
    public bool? AllowExtensionOperations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computerNamePrefix")]
    public string? ComputerNamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customData")]
    public string? CustomData { get; set; }

    /// <summary>Storage version of v1api20220301.LinuxConfiguration Specifies the Linux operating system settings on the virtual machine. For a list of supported Linux distributions, see [Linux on Azure-Endorsed Distributions](https://docs.microsoft.com/azure/virtual-machines/linux/endorsed-distros).</summary>
    [JsonPropertyName("linuxConfiguration")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileLinuxConfiguration? LinuxConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secrets")]
    public IList<V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileSecrets>? Secrets { get; set; }

    /// <summary>Storage version of v1api20220301.WindowsConfiguration Specifies Windows operating system settings on the virtual machine.</summary>
    [JsonPropertyName("windowsConfiguration")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfileWindowsConfiguration? WindowsConfiguration { get; set; }
}

/// <summary>Storage version of v1api20220301.TerminateNotificationProfile</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileScheduledEventsProfileTerminateNotificationProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notBeforeTimeout")]
    public string? NotBeforeTimeout { get; set; }
}

/// <summary>Storage version of v1api20220301.ScheduledEventsProfile</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileScheduledEventsProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.TerminateNotificationProfile</summary>
    [JsonPropertyName("terminateNotificationProfile")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileScheduledEventsProfileTerminateNotificationProfile? TerminateNotificationProfile { get; set; }
}

/// <summary>Storage version of v1api20220301.UefiSettings Specifies the security settings like secure boot and vTPM used while creating the virtual machine. Minimum api-version: 2020-12-01</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileSecurityProfileUefiSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secureBootEnabled")]
    public bool? SecureBootEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vTpmEnabled")]
    public bool? VTpmEnabled { get; set; }
}

/// <summary>Storage version of v1api20220301.SecurityProfile Specifies the Security profile settings for the virtual machine or virtual machine scale set.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileSecurityProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionAtHost")]
    public bool? EncryptionAtHost { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityType")]
    public string? SecurityType { get; set; }

    /// <summary>Storage version of v1api20220301.UefiSettings Specifies the security settings like secure boot and vTPM used while creating the virtual machine. Minimum api-version: 2020-12-01</summary>
    [JsonPropertyName("uefiSettings")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileSecurityProfileUefiSettings? UefiSettings { get; set; }
}

/// <summary>Reference: Resource Id</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskDiskEncryptionSetReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220301.SubResource</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskDiskEncryptionSet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskDiskEncryptionSetReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskSecurityProfileDiskEncryptionSetReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220301.SubResource</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskSecurityProfileDiskEncryptionSet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskSecurityProfileDiskEncryptionSetReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20220301.VMDiskSecurityProfile Specifies the security profile settings for the managed disk. NOTE: It can only be set for Confidential VMs</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskSecurityProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskSecurityProfileDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityEncryptionType")]
    public string? SecurityEncryptionType { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetManagedDiskParameters Describes the parameters of a ScaleSet managed disk.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDisk
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>Storage version of v1api20220301.VMDiskSecurityProfile Specifies the security profile settings for the managed disk. NOTE: It can only be set for Confidential VMs</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDiskSecurityProfile? SecurityProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetDataDisk Describes a virtual machine scale set data disk.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisks
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deleteOption")]
    public string? DeleteOption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskIOPSReadWrite")]
    public int? DiskIOPSReadWrite { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskMBpsReadWrite")]
    public int? DiskMBpsReadWrite { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lun")]
    public int? Lun { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineScaleSetManagedDiskParameters Describes the parameters of a ScaleSet managed disk.</summary>
    [JsonPropertyName("managedDisk")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisksManagedDisk? ManagedDisk { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>Reference: Resource Id</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileImageReferenceReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220301.ImageReference Specifies information about the image to use. You can specify information about platform images, marketplace images, or virtual machine images. This element is required when you want to use a platform image, marketplace image, or virtual machine image, but is not used in other creation operations. NOTE: Image reference publisher and offer can only be set when you create the scale set.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileImageReference
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("communityGalleryImageId")]
    public string? CommunityGalleryImageId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("offer")]
    public string? Offer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileImageReferenceReference? Reference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedGalleryImageId")]
    public string? SharedGalleryImageId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Storage version of v1api20220301.DiffDiskSettings Describes the parameters of ephemeral disk settings that can be specified for operating system disk. NOTE: The ephemeral disk settings can only be specified for managed disk.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskDiffDiskSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("option")]
    public string? Option { get; set; }

    /// <summary></summary>
    [JsonPropertyName("placement")]
    public string? Placement { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualHardDisk Describes the uri of a disk.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskImage
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Reference: Resource Id</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskDiskEncryptionSetReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220301.SubResource</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskDiskEncryptionSet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskDiskEncryptionSetReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskSecurityProfileDiskEncryptionSetReference
{
    /// <summary>ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level ARMID is mutually exclusive with Group, Kind, Namespace and Name.</summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20220301.SubResource</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskSecurityProfileDiskEncryptionSet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskSecurityProfileDiskEncryptionSetReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20220301.VMDiskSecurityProfile Specifies the security profile settings for the managed disk. NOTE: It can only be set for Confidential VMs</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskSecurityProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskSecurityProfileDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityEncryptionType")]
    public string? SecurityEncryptionType { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetManagedDiskParameters Describes the parameters of a ScaleSet managed disk.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDisk
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>Storage version of v1api20220301.VMDiskSecurityProfile Specifies the security profile settings for the managed disk. NOTE: It can only be set for Confidential VMs</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDiskSecurityProfile? SecurityProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetOSDisk Describes a virtual machine scale set operating system disk.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDisk
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deleteOption")]
    public string? DeleteOption { get; set; }

    /// <summary>Storage version of v1api20220301.DiffDiskSettings Describes the parameters of ephemeral disk settings that can be specified for operating system disk. NOTE: The ephemeral disk settings can only be specified for managed disk.</summary>
    [JsonPropertyName("diffDiskSettings")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskDiffDiskSettings? DiffDiskSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualHardDisk Describes the uri of a disk.</summary>
    [JsonPropertyName("image")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskImage? Image { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineScaleSetManagedDiskParameters Describes the parameters of a ScaleSet managed disk.</summary>
    [JsonPropertyName("managedDisk")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDiskManagedDisk? ManagedDisk { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vhdContainers")]
    public IList<string>? VhdContainers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetStorageProfile Describes a virtual machine scale set storage profile.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataDisks")]
    public IList<V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileDataDisks>? DataDisks { get; set; }

    /// <summary>Storage version of v1api20220301.ImageReference Specifies information about the image to use. You can specify information about platform images, marketplace images, or virtual machine images. This element is required when you want to use a platform image, marketplace image, or virtual machine image, but is not used in other creation operations. NOTE: Image reference publisher and offer can only be set when you create the scale set.</summary>
    [JsonPropertyName("imageReference")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileImageReference? ImageReference { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineScaleSetOSDisk Describes a virtual machine scale set operating system disk.</summary>
    [JsonPropertyName("osDisk")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfileOsDisk? OsDisk { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetVMProfile Describes a virtual machine scale set virtual machine profile.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.ApplicationProfile Contains the list of gallery applications that should be made available to the VM/VMSS</summary>
    [JsonPropertyName("applicationProfile")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileApplicationProfile? ApplicationProfile { get; set; }

    /// <summary>Storage version of v1api20220301.BillingProfile Specifies the billing related details of a Azure Spot VM or VMSS. Minimum api-version: 2019-03-01.</summary>
    [JsonPropertyName("billingProfile")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileBillingProfile? BillingProfile { get; set; }

    /// <summary>Storage version of v1api20220301.CapacityReservationProfile The parameters of a capacity reservation Profile.</summary>
    [JsonPropertyName("capacityReservation")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileCapacityReservation? CapacityReservation { get; set; }

    /// <summary>Storage version of v1api20220301.DiagnosticsProfile Specifies the boot diagnostic settings state. Minimum api-version: 2015-06-15.</summary>
    [JsonPropertyName("diagnosticsProfile")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileDiagnosticsProfile? DiagnosticsProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineScaleSetExtensionProfile Describes a virtual machine scale set extension profile.</summary>
    [JsonPropertyName("extensionProfile")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileExtensionProfile? ExtensionProfile { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineScaleSetHardwareProfile Specifies the hardware settings for the virtual machine scale set.</summary>
    [JsonPropertyName("hardwareProfile")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileHardwareProfile? HardwareProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineScaleSetNetworkProfile Describes a virtual machine scale set network profile.</summary>
    [JsonPropertyName("networkProfile")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileNetworkProfile? NetworkProfile { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineScaleSetOSProfile Describes a virtual machine scale set OS profile.</summary>
    [JsonPropertyName("osProfile")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileOsProfile? OsProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>Storage version of v1api20220301.ScheduledEventsProfile</summary>
    [JsonPropertyName("scheduledEventsProfile")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileScheduledEventsProfile? ScheduledEventsProfile { get; set; }

    /// <summary>Storage version of v1api20220301.SecurityProfile Specifies the Security profile settings for the virtual machine or virtual machine scale set.</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileSecurityProfile? SecurityProfile { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineScaleSetStorageProfile Describes a virtual machine scale set storage profile.</summary>
    [JsonPropertyName("storageProfile")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfileStorageProfile? StorageProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSet_Spec</summary>
public partial class V1api20220301storageVirtualMachineScaleSetSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.AdditionalCapabilities Enables or disables a capability on the virtual machine or virtual machine scale set.</summary>
    [JsonPropertyName("additionalCapabilities")]
    public V1api20220301storageVirtualMachineScaleSetSpecAdditionalCapabilities? AdditionalCapabilities { get; set; }

    /// <summary>Storage version of v1api20220301.AutomaticRepairsPolicy Specifies the configuration parameters for automatic repairs on the virtual machine scale set.</summary>
    [JsonPropertyName("automaticRepairsPolicy")]
    public V1api20220301storageVirtualMachineScaleSetSpecAutomaticRepairsPolicy? AutomaticRepairsPolicy { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("doNotRunExtensionsOnOverprovisionedVMs")]
    public bool? DoNotRunExtensionsOnOverprovisionedVMs { get; set; }

    /// <summary>Storage version of v1api20220301.ExtendedLocation The complex type of the extended location.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20220301storageVirtualMachineScaleSetSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource</summary>
    [JsonPropertyName("hostGroup")]
    public V1api20220301storageVirtualMachineScaleSetSpecHostGroup? HostGroup { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineScaleSetIdentity Identity for the virtual machine scale set.</summary>
    [JsonPropertyName("identity")]
    public V1api20220301storageVirtualMachineScaleSetSpecIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("orchestrationMode")]
    public string? OrchestrationMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("overprovision")]
    public bool? Overprovision { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20220301storageVirtualMachineScaleSetSpecOwner Owner { get; set; }

    /// <summary>Storage version of v1api20220301.Plan Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use. In the Azure portal, find the marketplace image that you want to use and then click Want to deploy programmatically, Get Started -&gt;. Enter any required information and then click Save.</summary>
    [JsonPropertyName("plan")]
    public V1api20220301storageVirtualMachineScaleSetSpecPlan? Plan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("platformFaultDomainCount")]
    public int? PlatformFaultDomainCount { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource</summary>
    [JsonPropertyName("proximityPlacementGroup")]
    public V1api20220301storageVirtualMachineScaleSetSpecProximityPlacementGroup? ProximityPlacementGroup { get; set; }

    /// <summary>Storage version of v1api20220301.ScaleInPolicy Describes a scale-in policy for a virtual machine scale set.</summary>
    [JsonPropertyName("scaleInPolicy")]
    public V1api20220301storageVirtualMachineScaleSetSpecScaleInPolicy? ScaleInPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("singlePlacementGroup")]
    public bool? SinglePlacementGroup { get; set; }

    /// <summary>Storage version of v1api20220301.Sku Describes a virtual machine scale set sku. NOTE: If the new VM SKU is not supported on the hardware the scale set is currently on, you need to deallocate the VMs in the scale set before you modify the SKU name.</summary>
    [JsonPropertyName("sku")]
    public V1api20220301storageVirtualMachineScaleSetSpecSku? Sku { get; set; }

    /// <summary>Storage version of v1api20220301.SpotRestorePolicy Specifies the Spot-Try-Restore properties for the virtual machine scale set. With this property customer can enable or disable automatic restore of the evicted Spot VMSS VM instances opportunistically based on capacity availability and pricing constraint.</summary>
    [JsonPropertyName("spotRestorePolicy")]
    public V1api20220301storageVirtualMachineScaleSetSpecSpotRestorePolicy? SpotRestorePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Storage version of v1api20220301.UpgradePolicy Describes an upgrade policy - automatic, manual, or rolling.</summary>
    [JsonPropertyName("upgradePolicy")]
    public V1api20220301storageVirtualMachineScaleSetSpecUpgradePolicy? UpgradePolicy { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineScaleSetVMProfile Describes a virtual machine scale set virtual machine profile.</summary>
    [JsonPropertyName("virtualMachineProfile")]
    public V1api20220301storageVirtualMachineScaleSetSpecVirtualMachineProfile? VirtualMachineProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("zoneBalance")]
    public bool? ZoneBalance { get; set; }

    /// <summary></summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>Storage version of v1api20220301.AdditionalCapabilities_STATUS Enables or disables a capability on the virtual machine or virtual machine scale set.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusAdditionalCapabilities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hibernationEnabled")]
    public bool? HibernationEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ultraSSDEnabled")]
    public bool? UltraSSDEnabled { get; set; }
}

/// <summary>Storage version of v1api20220301.AutomaticRepairsPolicy_STATUS Specifies the configuration parameters for automatic repairs on the virtual machine scale set.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusAutomaticRepairsPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gracePeriod")]
    public string? GracePeriod { get; set; }

    /// <summary></summary>
    [JsonPropertyName("repairAction")]
    public string? RepairAction { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Reason for the condition's last transition. Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Severity with which to treat failures of this type of condition. For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False. This is omitted in all cases when Status == Unknown</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Storage version of v1api20220301.ExtendedLocation_STATUS The complex type of the extended location.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusExtendedLocation
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusHostGroup
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetIdentity_UserAssignedIdentities_STATUS</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusIdentityUserAssignedIdentities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetIdentity_STATUS Identity for the virtual machine scale set.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20220301storageVirtualMachineScaleSetStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Storage version of v1api20220301.Plan_STATUS Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use. In the Azure portal, find the marketplace image that you want to use and then click Want to deploy programmatically, Get Started -&gt;. Enter any required information and then click Save.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusPlan
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary></summary>
    [JsonPropertyName("promotionCode")]
    public string? PromotionCode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}

/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusProximityPlacementGroup
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20220301.ScaleInPolicy_STATUS Describes a scale-in policy for a virtual machine scale set.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusScaleInPolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceDeletion")]
    public bool? ForceDeletion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rules")]
    public IList<string>? Rules { get; set; }
}

/// <summary>Storage version of v1api20220301.Sku_STATUS Describes a virtual machine scale set sku. NOTE: If the new VM SKU is not supported on the hardware the scale set is currently on, you need to deallocate the VMs in the scale set before you modify the SKU name.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusSku
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("capacity")]
    public int? Capacity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Storage version of v1api20220301.SpotRestorePolicy_STATUS Specifies the Spot-Try-Restore properties for the virtual machine scale set. With this property customer can enable or disable automatic restore of the evicted Spot VMSS VM instances opportunistically based on capacity availability and pricing constraint.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusSpotRestorePolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("restoreTimeout")]
    public string? RestoreTimeout { get; set; }
}

/// <summary>Storage version of v1api20220301.AutomaticOSUpgradePolicy_STATUS The configuration parameters used for performing automatic OS upgrade.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusUpgradePolicyAutomaticOSUpgradePolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableAutomaticRollback")]
    public bool? DisableAutomaticRollback { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableAutomaticOSUpgrade")]
    public bool? EnableAutomaticOSUpgrade { get; set; }

    /// <summary></summary>
    [JsonPropertyName("useRollingUpgradePolicy")]
    public bool? UseRollingUpgradePolicy { get; set; }
}

/// <summary>Storage version of v1api20220301.RollingUpgradePolicy_STATUS The configuration parameters used while performing a rolling upgrade.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusUpgradePolicyRollingUpgradePolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableCrossZoneUpgrade")]
    public bool? EnableCrossZoneUpgrade { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxBatchInstancePercent")]
    public int? MaxBatchInstancePercent { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxUnhealthyInstancePercent")]
    public int? MaxUnhealthyInstancePercent { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxUnhealthyUpgradedInstancePercent")]
    public int? MaxUnhealthyUpgradedInstancePercent { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pauseTimeBetweenBatches")]
    public string? PauseTimeBetweenBatches { get; set; }

    /// <summary></summary>
    [JsonPropertyName("prioritizeUnhealthyInstances")]
    public bool? PrioritizeUnhealthyInstances { get; set; }
}

/// <summary>Storage version of v1api20220301.UpgradePolicy_STATUS Describes an upgrade policy - automatic, manual, or rolling.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusUpgradePolicy
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.AutomaticOSUpgradePolicy_STATUS The configuration parameters used for performing automatic OS upgrade.</summary>
    [JsonPropertyName("automaticOSUpgradePolicy")]
    public V1api20220301storageVirtualMachineScaleSetStatusUpgradePolicyAutomaticOSUpgradePolicy? AutomaticOSUpgradePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Storage version of v1api20220301.RollingUpgradePolicy_STATUS The configuration parameters used while performing a rolling upgrade.</summary>
    [JsonPropertyName("rollingUpgradePolicy")]
    public V1api20220301storageVirtualMachineScaleSetStatusUpgradePolicyRollingUpgradePolicy? RollingUpgradePolicy { get; set; }
}

/// <summary>Storage version of v1api20220301.VMGalleryApplication_STATUS Specifies the required information to reference a compute gallery application version</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileApplicationProfileGalleryApplications
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configurationReference")]
    public string? ConfigurationReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableAutomaticUpgrade")]
    public bool? EnableAutomaticUpgrade { get; set; }

    /// <summary></summary>
    [JsonPropertyName("order")]
    public int? Order { get; set; }

    /// <summary></summary>
    [JsonPropertyName("packageReferenceId")]
    public string? PackageReferenceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public string? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("treatFailureAsDeploymentFailure")]
    public bool? TreatFailureAsDeploymentFailure { get; set; }
}

/// <summary>Storage version of v1api20220301.ApplicationProfile_STATUS Contains the list of gallery applications that should be made available to the VM/VMSS</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileApplicationProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("galleryApplications")]
    public IList<V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileApplicationProfileGalleryApplications>? GalleryApplications { get; set; }
}

/// <summary>Storage version of v1api20220301.BillingProfile_STATUS Specifies the billing related details of a Azure Spot VM or VMSS. Minimum api-version: 2019-03-01.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileBillingProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxPrice")]
    public double? MaxPrice { get; set; }
}

/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileCapacityReservationCapacityReservationGroup
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20220301.CapacityReservationProfile_STATUS The parameters of a capacity reservation Profile.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileCapacityReservation
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
    [JsonPropertyName("capacityReservationGroup")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileCapacityReservationCapacityReservationGroup? CapacityReservationGroup { get; set; }
}

/// <summary>Storage version of v1api20220301.BootDiagnostics_STATUS Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to diagnose VM status. You can easily view the output of your console log. Azure also enables you to see a screenshot of the VM from the hypervisor.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileDiagnosticsProfileBootDiagnostics
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageUri")]
    public string? StorageUri { get; set; }
}

/// <summary>Storage version of v1api20220301.DiagnosticsProfile_STATUS Specifies the boot diagnostic settings state. Minimum api-version: 2015-06-15.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileDiagnosticsProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.BootDiagnostics_STATUS Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to diagnose VM status. You can easily view the output of your console log. Azure also enables you to see a screenshot of the VM from the hypervisor.</summary>
    [JsonPropertyName("bootDiagnostics")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileDiagnosticsProfileBootDiagnostics? BootDiagnostics { get; set; }
}

/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileExtensionProfileExtensionsProtectedSettingsFromKeyVaultSourceVault
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20220301.KeyVaultSecretReference_STATUS Describes a reference to Key Vault Secret</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileExtensionProfileExtensionsProtectedSettingsFromKeyVault
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileExtensionProfileExtensionsProtectedSettingsFromKeyVaultSourceVault? SourceVault { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetExtension_STATUS Describes a Virtual Machine Scale Set Extension.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileExtensionProfileExtensions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("autoUpgradeMinorVersion")]
    public bool? AutoUpgradeMinorVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableAutomaticUpgrade")]
    public bool? EnableAutomaticUpgrade { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forceUpdateTag")]
    public string? ForceUpdateTag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("properties_type")]
    public string? PropertiesType { get; set; }

    /// <summary>Storage version of v1api20220301.KeyVaultSecretReference_STATUS Describes a reference to Key Vault Secret</summary>
    [JsonPropertyName("protectedSettingsFromKeyVault")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileExtensionProfileExtensionsProtectedSettingsFromKeyVault? ProtectedSettingsFromKeyVault { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisionAfterExtensions")]
    public IList<string>? ProvisionAfterExtensions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary></summary>
    [JsonPropertyName("settings")]
    public IDictionary<string, JsonNode>? Settings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("suppressFailures")]
    public bool? SuppressFailures { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetExtensionProfile_STATUS Describes a virtual machine scale set extension profile.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileExtensionProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("extensions")]
    public IList<V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileExtensionProfileExtensions>? Extensions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("extensionsTimeBudget")]
    public string? ExtensionsTimeBudget { get; set; }
}

/// <summary>Storage version of v1api20220301.VMSizeProperties_STATUS Specifies VM Size Property settings on the virtual machine.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileHardwareProfileVmSizeProperties
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vCPUsAvailable")]
    public int? VCPUsAvailable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vCPUsPerCore")]
    public int? VCPUsPerCore { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetHardwareProfile_STATUS Specifies the hardware settings for the virtual machine scale set.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileHardwareProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.VMSizeProperties_STATUS Specifies VM Size Property settings on the virtual machine.</summary>
    [JsonPropertyName("vmSizeProperties")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileHardwareProfileVmSizeProperties? VmSizeProperties { get; set; }
}

/// <summary>Storage version of v1api20220301.ApiEntityReference_STATUS The API entity reference.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileHealthProbe
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetNetworkConfigurationDnsSettings_STATUS Describes a virtual machines scale sets network configuration's DNS settings.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsDnsSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dnsServers")]
    public IList<string>? DnsServers { get; set; }
}

/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPools
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroups
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPools
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerInboundNatPools
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings_STATUS Describes a virtual machines scale sets network configuration's DNS settings.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationDnsSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("domainNameLabel")]
    public string? DomainNameLabel { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetIpTag_STATUS Contains the IP tag associated with the public IP address.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationIpTags
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipTagType")]
    public string? IpTagType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }
}

/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefix
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20220301.PublicIPAddressSku_STATUS Describes the public IP Sku. It can only be set with OrchestrationMode as Flexible.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationSku
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetPublicIPAddressConfiguration_STATUS Describes a virtual machines scale set IP Configuration's PublicIPAddress configuration</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deleteOption")]
    public string? DeleteOption { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings_STATUS Describes a virtual machines scale sets network configuration's DNS settings.</summary>
    [JsonPropertyName("dnsSettings")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationDnsSettings? DnsSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipTags")]
    public IList<V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationIpTags>? IpTags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicIPAddressVersion")]
    public string? PublicIPAddressVersion { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
    [JsonPropertyName("publicIPPrefix")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefix? PublicIPPrefix { get; set; }

    /// <summary>Storage version of v1api20220301.PublicIPAddressSku_STATUS Describes the public IP Sku. It can only be set with OrchestrationMode as Flexible.</summary>
    [JsonPropertyName("sku")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationSku? Sku { get; set; }
}

/// <summary>Storage version of v1api20220301.ApiEntityReference_STATUS The API entity reference.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetIPConfiguration_STATUS Describes a virtual machine scale set network profile's IP configuration.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applicationGatewayBackendAddressPools")]
    public IList<V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPools>? ApplicationGatewayBackendAddressPools { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applicationSecurityGroups")]
    public IList<V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroups>? ApplicationSecurityGroups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loadBalancerBackendAddressPools")]
    public IList<V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPools>? LoadBalancerBackendAddressPools { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loadBalancerInboundNatPools")]
    public IList<V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerInboundNatPools>? LoadBalancerInboundNatPools { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateIPAddressVersion")]
    public string? PrivateIPAddressVersion { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineScaleSetPublicIPAddressConfiguration_STATUS Describes a virtual machines scale set IP Configuration's PublicIPAddress configuration</summary>
    [JsonPropertyName("publicIPAddressConfiguration")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfiguration? PublicIPAddressConfiguration { get; set; }

    /// <summary>Storage version of v1api20220301.ApiEntityReference_STATUS The API entity reference.</summary>
    [JsonPropertyName("subnet")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnet? Subnet { get; set; }
}

/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroup
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetNetworkConfiguration_STATUS Describes a virtual machine scale set network profile's network configurations.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deleteOption")]
    public string? DeleteOption { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineScaleSetNetworkConfigurationDnsSettings_STATUS Describes a virtual machines scale sets network configuration's DNS settings.</summary>
    [JsonPropertyName("dnsSettings")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsDnsSettings? DnsSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableAcceleratedNetworking")]
    public bool? EnableAcceleratedNetworking { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableFpga")]
    public bool? EnableFpga { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableIPForwarding")]
    public bool? EnableIPForwarding { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipConfigurations")]
    public IList<V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsIpConfigurations>? IpConfigurations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
    [JsonPropertyName("networkSecurityGroup")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroup? NetworkSecurityGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetNetworkProfile_STATUS Describes a virtual machine scale set network profile.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.ApiEntityReference_STATUS The API entity reference.</summary>
    [JsonPropertyName("healthProbe")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileHealthProbe? HealthProbe { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkApiVersion")]
    public string? NetworkApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkInterfaceConfigurations")]
    public IList<V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfileNetworkInterfaceConfigurations>? NetworkInterfaceConfigurations { get; set; }
}

/// <summary>Storage version of v1api20220301.LinuxVMGuestPatchAutomaticByPlatformSettings_STATUS Specifies additional settings to be applied when patch mode AutomaticByPlatform is selected in Linux patch settings.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfigurationPatchSettingsAutomaticByPlatformSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rebootSetting")]
    public string? RebootSetting { get; set; }
}

/// <summary>Storage version of v1api20220301.LinuxPatchSettings_STATUS Specifies settings related to VM Guest Patching on Linux.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfigurationPatchSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("assessmentMode")]
    public string? AssessmentMode { get; set; }

    /// <summary>Storage version of v1api20220301.LinuxVMGuestPatchAutomaticByPlatformSettings_STATUS Specifies additional settings to be applied when patch mode AutomaticByPlatform is selected in Linux patch settings.</summary>
    [JsonPropertyName("automaticByPlatformSettings")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfigurationPatchSettingsAutomaticByPlatformSettings? AutomaticByPlatformSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }
}

/// <summary>Storage version of v1api20220301.SshPublicKey_STATUS Contains information about SSH certificate public key and the path on the Linux VM where the public key is placed.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfigurationSshPublicKeys
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyData")]
    public string? KeyData { get; set; }

    /// <summary></summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Storage version of v1api20220301.SshConfiguration_STATUS SSH configuration for Linux based VMs running on Azure</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfigurationSsh
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicKeys")]
    public IList<V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfigurationSshPublicKeys>? PublicKeys { get; set; }
}

/// <summary>Storage version of v1api20220301.LinuxConfiguration_STATUS Specifies the Linux operating system settings on the virtual machine. For a list of supported Linux distributions, see [Linux on Azure-Endorsed Distributions](https://docs.microsoft.com/azure/virtual-machines/linux/endorsed-distros).</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disablePasswordAuthentication")]
    public bool? DisablePasswordAuthentication { get; set; }

    /// <summary>Storage version of v1api20220301.LinuxPatchSettings_STATUS Specifies settings related to VM Guest Patching on Linux.</summary>
    [JsonPropertyName("patchSettings")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfigurationPatchSettings? PatchSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisionVMAgent")]
    public bool? ProvisionVMAgent { get; set; }

    /// <summary>Storage version of v1api20220301.SshConfiguration_STATUS SSH configuration for Linux based VMs running on Azure</summary>
    [JsonPropertyName("ssh")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfigurationSsh? Ssh { get; set; }
}

/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileSecretsSourceVault
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20220301.VaultCertificate_STATUS Describes a single certificate reference in a Key Vault, and where the certificate should reside on the VM.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileSecretsVaultCertificates
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("certificateStore")]
    public string? CertificateStore { get; set; }

    /// <summary></summary>
    [JsonPropertyName("certificateUrl")]
    public string? CertificateUrl { get; set; }
}

/// <summary>Storage version of v1api20220301.VaultSecretGroup_STATUS Describes a set of certificates which are all in the same Key Vault.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileSecrets
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileSecretsSourceVault? SourceVault { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vaultCertificates")]
    public IList<V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileSecretsVaultCertificates>? VaultCertificates { get; set; }
}

/// <summary>Storage version of v1api20220301.AdditionalUnattendContent_STATUS Specifies additional XML formatted information that can be included in the Unattend.xml file, which is used by Windows Setup. Contents are defined by setting name, component name, and the pass in which the content is applied.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContent
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("componentName")]
    public string? ComponentName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary></summary>
    [JsonPropertyName("passName")]
    public string? PassName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("settingName")]
    public string? SettingName { get; set; }
}

/// <summary>Storage version of v1api20220301.WindowsVMGuestPatchAutomaticByPlatformSettings_STATUS Specifies additional settings to be applied when patch mode AutomaticByPlatform is selected in Windows patch settings.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationPatchSettingsAutomaticByPlatformSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rebootSetting")]
    public string? RebootSetting { get; set; }
}

/// <summary>Storage version of v1api20220301.PatchSettings_STATUS Specifies settings related to VM Guest Patching on Windows.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationPatchSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("assessmentMode")]
    public string? AssessmentMode { get; set; }

    /// <summary>Storage version of v1api20220301.WindowsVMGuestPatchAutomaticByPlatformSettings_STATUS Specifies additional settings to be applied when patch mode AutomaticByPlatform is selected in Windows patch settings.</summary>
    [JsonPropertyName("automaticByPlatformSettings")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationPatchSettingsAutomaticByPlatformSettings? AutomaticByPlatformSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableHotpatching")]
    public bool? EnableHotpatching { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }
}

/// <summary>Storage version of v1api20220301.WinRMListener_STATUS Describes Protocol and thumbprint of Windows Remote Management listener</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationWinRMListeners
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("certificateUrl")]
    public string? CertificateUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>Storage version of v1api20220301.WinRMConfiguration_STATUS Describes Windows Remote Management configuration of the VM</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationWinRM
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("listeners")]
    public IList<V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationWinRMListeners>? Listeners { get; set; }
}

/// <summary>Storage version of v1api20220301.WindowsConfiguration_STATUS Specifies Windows operating system settings on the virtual machine.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalUnattendContent")]
    public IList<V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationAdditionalUnattendContent>? AdditionalUnattendContent { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableAutomaticUpdates")]
    public bool? EnableAutomaticUpdates { get; set; }

    /// <summary>Storage version of v1api20220301.PatchSettings_STATUS Specifies settings related to VM Guest Patching on Windows.</summary>
    [JsonPropertyName("patchSettings")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationPatchSettings? PatchSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisionVMAgent")]
    public bool? ProvisionVMAgent { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>Storage version of v1api20220301.WinRMConfiguration_STATUS Describes Windows Remote Management configuration of the VM</summary>
    [JsonPropertyName("winRM")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfigurationWinRM? WinRM { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetOSProfile_STATUS Describes a virtual machine scale set OS profile.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowExtensionOperations")]
    public bool? AllowExtensionOperations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computerNamePrefix")]
    public string? ComputerNamePrefix { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customData")]
    public string? CustomData { get; set; }

    /// <summary>Storage version of v1api20220301.LinuxConfiguration_STATUS Specifies the Linux operating system settings on the virtual machine. For a list of supported Linux distributions, see [Linux on Azure-Endorsed Distributions](https://docs.microsoft.com/azure/virtual-machines/linux/endorsed-distros).</summary>
    [JsonPropertyName("linuxConfiguration")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileLinuxConfiguration? LinuxConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secrets")]
    public IList<V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileSecrets>? Secrets { get; set; }

    /// <summary>Storage version of v1api20220301.WindowsConfiguration_STATUS Specifies Windows operating system settings on the virtual machine.</summary>
    [JsonPropertyName("windowsConfiguration")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfileWindowsConfiguration? WindowsConfiguration { get; set; }
}

/// <summary>Storage version of v1api20220301.TerminateNotificationProfile_STATUS</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileScheduledEventsProfileTerminateNotificationProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notBeforeTimeout")]
    public string? NotBeforeTimeout { get; set; }
}

/// <summary>Storage version of v1api20220301.ScheduledEventsProfile_STATUS</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileScheduledEventsProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.TerminateNotificationProfile_STATUS</summary>
    [JsonPropertyName("terminateNotificationProfile")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileScheduledEventsProfileTerminateNotificationProfile? TerminateNotificationProfile { get; set; }
}

/// <summary>Storage version of v1api20220301.UefiSettings_STATUS Specifies the security settings like secure boot and vTPM used while creating the virtual machine. Minimum api-version: 2020-12-01</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileSecurityProfileUefiSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secureBootEnabled")]
    public bool? SecureBootEnabled { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vTpmEnabled")]
    public bool? VTpmEnabled { get; set; }
}

/// <summary>Storage version of v1api20220301.SecurityProfile_STATUS Specifies the Security profile settings for the virtual machine or virtual machine scale set.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileSecurityProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionAtHost")]
    public bool? EncryptionAtHost { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityType")]
    public string? SecurityType { get; set; }

    /// <summary>Storage version of v1api20220301.UefiSettings_STATUS Specifies the security settings like secure boot and vTPM used while creating the virtual machine. Minimum api-version: 2020-12-01</summary>
    [JsonPropertyName("uefiSettings")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileSecurityProfileUefiSettings? UefiSettings { get; set; }
}

/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisksManagedDiskDiskEncryptionSet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisksManagedDiskSecurityProfileDiskEncryptionSet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20220301.VMDiskSecurityProfile_STATUS Specifies the security profile settings for the managed disk. NOTE: It can only be set for Confidential VMs</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisksManagedDiskSecurityProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisksManagedDiskSecurityProfileDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityEncryptionType")]
    public string? SecurityEncryptionType { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetManagedDiskParameters_STATUS Describes the parameters of a ScaleSet managed disk.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisksManagedDisk
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisksManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>Storage version of v1api20220301.VMDiskSecurityProfile_STATUS Specifies the security profile settings for the managed disk. NOTE: It can only be set for Confidential VMs</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisksManagedDiskSecurityProfile? SecurityProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetDataDisk_STATUS Describes a virtual machine scale set data disk.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisks
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deleteOption")]
    public string? DeleteOption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskIOPSReadWrite")]
    public int? DiskIOPSReadWrite { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskMBpsReadWrite")]
    public int? DiskMBpsReadWrite { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lun")]
    public int? Lun { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineScaleSetManagedDiskParameters_STATUS Describes the parameters of a ScaleSet managed disk.</summary>
    [JsonPropertyName("managedDisk")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisksManagedDisk? ManagedDisk { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>Storage version of v1api20220301.ImageReference_STATUS Specifies information about the image to use. You can specify information about platform images, marketplace images, or virtual machine images. This element is required when you want to use a platform image, marketplace image, or virtual machine image, but is not used in other creation operations. NOTE: Image reference publisher and offer can only be set when you create the scale set.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileImageReference
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("communityGalleryImageId")]
    public string? CommunityGalleryImageId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exactVersion")]
    public string? ExactVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("offer")]
    public string? Offer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sharedGalleryImageId")]
    public string? SharedGalleryImageId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Storage version of v1api20220301.DiffDiskSettings_STATUS Describes the parameters of ephemeral disk settings that can be specified for operating system disk. NOTE: The ephemeral disk settings can only be specified for managed disk.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskDiffDiskSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("option")]
    public string? Option { get; set; }

    /// <summary></summary>
    [JsonPropertyName("placement")]
    public string? Placement { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualHardDisk_STATUS Describes the uri of a disk.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskImage
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskManagedDiskDiskEncryptionSet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskManagedDiskSecurityProfileDiskEncryptionSet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20220301.VMDiskSecurityProfile_STATUS Specifies the security profile settings for the managed disk. NOTE: It can only be set for Confidential VMs</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskManagedDiskSecurityProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskManagedDiskSecurityProfileDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityEncryptionType")]
    public string? SecurityEncryptionType { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetManagedDiskParameters_STATUS Describes the parameters of a ScaleSet managed disk.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskManagedDisk
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>Storage version of v1api20220301.VMDiskSecurityProfile_STATUS Specifies the security profile settings for the managed disk. NOTE: It can only be set for Confidential VMs</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskManagedDiskSecurityProfile? SecurityProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetOSDisk_STATUS Describes a virtual machine scale set operating system disk.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDisk
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary></summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deleteOption")]
    public string? DeleteOption { get; set; }

    /// <summary>Storage version of v1api20220301.DiffDiskSettings_STATUS Describes the parameters of ephemeral disk settings that can be specified for operating system disk. NOTE: The ephemeral disk settings can only be specified for managed disk.</summary>
    [JsonPropertyName("diffDiskSettings")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskDiffDiskSettings? DiffDiskSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualHardDisk_STATUS Describes the uri of a disk.</summary>
    [JsonPropertyName("image")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskImage? Image { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineScaleSetManagedDiskParameters_STATUS Describes the parameters of a ScaleSet managed disk.</summary>
    [JsonPropertyName("managedDisk")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDiskManagedDisk? ManagedDisk { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vhdContainers")]
    public IList<string>? VhdContainers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetStorageProfile_STATUS Describes a virtual machine scale set storage profile.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataDisks")]
    public IList<V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileDataDisks>? DataDisks { get; set; }

    /// <summary>Storage version of v1api20220301.ImageReference_STATUS Specifies information about the image to use. You can specify information about platform images, marketplace images, or virtual machine images. This element is required when you want to use a platform image, marketplace image, or virtual machine image, but is not used in other creation operations. NOTE: Image reference publisher and offer can only be set when you create the scale set.</summary>
    [JsonPropertyName("imageReference")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileImageReference? ImageReference { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineScaleSetOSDisk_STATUS Describes a virtual machine scale set operating system disk.</summary>
    [JsonPropertyName("osDisk")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfileOsDisk? OsDisk { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSetVMProfile_STATUS Describes a virtual machine scale set virtual machine profile.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.ApplicationProfile_STATUS Contains the list of gallery applications that should be made available to the VM/VMSS</summary>
    [JsonPropertyName("applicationProfile")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileApplicationProfile? ApplicationProfile { get; set; }

    /// <summary>Storage version of v1api20220301.BillingProfile_STATUS Specifies the billing related details of a Azure Spot VM or VMSS. Minimum api-version: 2019-03-01.</summary>
    [JsonPropertyName("billingProfile")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileBillingProfile? BillingProfile { get; set; }

    /// <summary>Storage version of v1api20220301.CapacityReservationProfile_STATUS The parameters of a capacity reservation Profile.</summary>
    [JsonPropertyName("capacityReservation")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileCapacityReservation? CapacityReservation { get; set; }

    /// <summary>Storage version of v1api20220301.DiagnosticsProfile_STATUS Specifies the boot diagnostic settings state. Minimum api-version: 2015-06-15.</summary>
    [JsonPropertyName("diagnosticsProfile")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileDiagnosticsProfile? DiagnosticsProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineScaleSetExtensionProfile_STATUS Describes a virtual machine scale set extension profile.</summary>
    [JsonPropertyName("extensionProfile")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileExtensionProfile? ExtensionProfile { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineScaleSetHardwareProfile_STATUS Specifies the hardware settings for the virtual machine scale set.</summary>
    [JsonPropertyName("hardwareProfile")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileHardwareProfile? HardwareProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineScaleSetNetworkProfile_STATUS Describes a virtual machine scale set network profile.</summary>
    [JsonPropertyName("networkProfile")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileNetworkProfile? NetworkProfile { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineScaleSetOSProfile_STATUS Describes a virtual machine scale set OS profile.</summary>
    [JsonPropertyName("osProfile")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileOsProfile? OsProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>Storage version of v1api20220301.ScheduledEventsProfile_STATUS</summary>
    [JsonPropertyName("scheduledEventsProfile")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileScheduledEventsProfile? ScheduledEventsProfile { get; set; }

    /// <summary>Storage version of v1api20220301.SecurityProfile_STATUS Specifies the Security profile settings for the virtual machine or virtual machine scale set.</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileSecurityProfile? SecurityProfile { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineScaleSetStorageProfile_STATUS Describes a virtual machine scale set storage profile.</summary>
    [JsonPropertyName("storageProfile")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfileStorageProfile? StorageProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }
}

/// <summary>Storage version of v1api20220301.VirtualMachineScaleSet_STATUS Describes a Virtual Machine Scale Set.</summary>
public partial class V1api20220301storageVirtualMachineScaleSetStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.AdditionalCapabilities_STATUS Enables or disables a capability on the virtual machine or virtual machine scale set.</summary>
    [JsonPropertyName("additionalCapabilities")]
    public V1api20220301storageVirtualMachineScaleSetStatusAdditionalCapabilities? AdditionalCapabilities { get; set; }

    /// <summary>Storage version of v1api20220301.AutomaticRepairsPolicy_STATUS Specifies the configuration parameters for automatic repairs on the virtual machine scale set.</summary>
    [JsonPropertyName("automaticRepairsPolicy")]
    public V1api20220301storageVirtualMachineScaleSetStatusAutomaticRepairsPolicy? AutomaticRepairsPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20220301storageVirtualMachineScaleSetStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("doNotRunExtensionsOnOverprovisionedVMs")]
    public bool? DoNotRunExtensionsOnOverprovisionedVMs { get; set; }

    /// <summary>Storage version of v1api20220301.ExtendedLocation_STATUS The complex type of the extended location.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20220301storageVirtualMachineScaleSetStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
    [JsonPropertyName("hostGroup")]
    public V1api20220301storageVirtualMachineScaleSetStatusHostGroup? HostGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineScaleSetIdentity_STATUS Identity for the virtual machine scale set.</summary>
    [JsonPropertyName("identity")]
    public V1api20220301storageVirtualMachineScaleSetStatusIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("orchestrationMode")]
    public string? OrchestrationMode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("overprovision")]
    public bool? Overprovision { get; set; }

    /// <summary>Storage version of v1api20220301.Plan_STATUS Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use. In the Azure portal, find the marketplace image that you want to use and then click Want to deploy programmatically, Get Started -&gt;. Enter any required information and then click Save.</summary>
    [JsonPropertyName("plan")]
    public V1api20220301storageVirtualMachineScaleSetStatusPlan? Plan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("platformFaultDomainCount")]
    public int? PlatformFaultDomainCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
    [JsonPropertyName("proximityPlacementGroup")]
    public V1api20220301storageVirtualMachineScaleSetStatusProximityPlacementGroup? ProximityPlacementGroup { get; set; }

    /// <summary>Storage version of v1api20220301.ScaleInPolicy_STATUS Describes a scale-in policy for a virtual machine scale set.</summary>
    [JsonPropertyName("scaleInPolicy")]
    public V1api20220301storageVirtualMachineScaleSetStatusScaleInPolicy? ScaleInPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("singlePlacementGroup")]
    public bool? SinglePlacementGroup { get; set; }

    /// <summary>Storage version of v1api20220301.Sku_STATUS Describes a virtual machine scale set sku. NOTE: If the new VM SKU is not supported on the hardware the scale set is currently on, you need to deallocate the VMs in the scale set before you modify the SKU name.</summary>
    [JsonPropertyName("sku")]
    public V1api20220301storageVirtualMachineScaleSetStatusSku? Sku { get; set; }

    /// <summary>Storage version of v1api20220301.SpotRestorePolicy_STATUS Specifies the Spot-Try-Restore properties for the virtual machine scale set. With this property customer can enable or disable automatic restore of the evicted Spot VMSS VM instances opportunistically based on capacity availability and pricing constraint.</summary>
    [JsonPropertyName("spotRestorePolicy")]
    public V1api20220301storageVirtualMachineScaleSetStatusSpotRestorePolicy? SpotRestorePolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeCreated")]
    public string? TimeCreated { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("uniqueId")]
    public string? UniqueId { get; set; }

    /// <summary>Storage version of v1api20220301.UpgradePolicy_STATUS Describes an upgrade policy - automatic, manual, or rolling.</summary>
    [JsonPropertyName("upgradePolicy")]
    public V1api20220301storageVirtualMachineScaleSetStatusUpgradePolicy? UpgradePolicy { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineScaleSetVMProfile_STATUS Describes a virtual machine scale set virtual machine profile.</summary>
    [JsonPropertyName("virtualMachineProfile")]
    public V1api20220301storageVirtualMachineScaleSetStatusVirtualMachineProfile? VirtualMachineProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("zoneBalance")]
    public bool? ZoneBalance { get; set; }

    /// <summary></summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Storage version of v1api20220301.VirtualMachineScaleSet Generator information: - Generated from: /compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-03-01/virtualMachineScaleSet.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}</summary>
public partial class V1api20220301storageVirtualMachineScaleSet : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20220301storageVirtualMachineScaleSetSpec>, IStatus<V1api20220301storageVirtualMachineScaleSetStatus>
{
    public const string KubeApiVersion = "v1api20220301storage";
    public const string KubeKind = "VirtualMachineScaleSet";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "virtualmachinescalesets";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineScaleSet_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20220301storageVirtualMachineScaleSetSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineScaleSet_STATUS Describes a Virtual Machine Scale Set.</summary>
    [JsonPropertyName("status")]
    public V1api20220301storageVirtualMachineScaleSetStatus? Status { get; set; }
}