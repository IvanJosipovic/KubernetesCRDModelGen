using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.azure.com;
#nullable enable
/// <summary>Storage version of v1api20220301.VirtualMachine Generator information: - Generated from: /compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-03-01/virtualMachine.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220301storageVirtualMachineList : IKubernetesObject<V1ListMeta>, IItems<V1api20220301storageVirtualMachine>
{
    public const string KubeApiVersion = "v1api20220301storage";
    public const string KubeKind = "VirtualMachineList";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "virtualmachines";
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
    public IList<V1api20220301storageVirtualMachine> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.AdditionalCapabilities Enables or disables a capability on the virtual machine or virtual machine scale set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecAdditionalCapabilities
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
#nullable disable

#nullable enable
/// <summary>PackageReferenceReference: Specifies the GalleryApplicationVersion resource id on the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{application}/versions/{version}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecApplicationProfileGalleryApplicationsPackageReferenceReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VMGalleryApplication Specifies the required information to reference a compute gallery application version</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecApplicationProfileGalleryApplications
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
    public V1api20220301storageVirtualMachineSpecApplicationProfileGalleryApplicationsPackageReferenceReference PackageReferenceReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public string? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("treatFailureAsDeploymentFailure")]
    public bool? TreatFailureAsDeploymentFailure { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.ApplicationProfile Contains the list of gallery applications that should be made available to the VM/VMSS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecApplicationProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("galleryApplications")]
    public IList<V1api20220301storageVirtualMachineSpecApplicationProfileGalleryApplications>? GalleryApplications { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecAvailabilitySetReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecAvailabilitySet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineSpecAvailabilitySetReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.BillingProfile Specifies the billing related details of a Azure Spot VM or VMSS. Minimum api-version: 2019-03-01.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecBillingProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxPrice")]
    public double? MaxPrice { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecCapacityReservationCapacityReservationGroupReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecCapacityReservationCapacityReservationGroup
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineSpecCapacityReservationCapacityReservationGroupReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.CapacityReservationProfile The parameters of a capacity reservation Profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecCapacityReservation
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource</summary>
    [JsonPropertyName("capacityReservationGroup")]
    public V1api20220301storageVirtualMachineSpecCapacityReservationCapacityReservationGroup? CapacityReservationGroup { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.BootDiagnostics Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to diagnose VM status. You can easily view the output of your console log. Azure also enables you to see a screenshot of the VM from the hypervisor.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecDiagnosticsProfileBootDiagnostics
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.DiagnosticsProfile Specifies the boot diagnostic settings state. Minimum api-version: 2015-06-15.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecDiagnosticsProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.BootDiagnostics Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to diagnose VM status. You can easily view the output of your console log. Azure also enables you to see a screenshot of the VM from the hypervisor.</summary>
    [JsonPropertyName("bootDiagnostics")]
    public V1api20220301storageVirtualMachineSpecDiagnosticsProfileBootDiagnostics? BootDiagnostics { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.ExtendedLocation The complex type of the extended location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecExtendedLocation
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VMSizeProperties Specifies VM Size Property settings on the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecHardwareProfileVmSizeProperties
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.HardwareProfile Specifies the hardware settings for the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecHardwareProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }

    /// <summary>Storage version of v1api20220301.VMSizeProperties Specifies VM Size Property settings on the virtual machine.</summary>
    [JsonPropertyName("vmSizeProperties")]
    public V1api20220301storageVirtualMachineSpecHardwareProfileVmSizeProperties? VmSizeProperties { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecHostReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecHost
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineSpecHostReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecHostGroupReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecHostGroup
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineSpecHostGroupReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecIdentityUserAssignedIdentitiesReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.UserAssignedIdentityDetails Information about the user assigned identity for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecIdentityUserAssignedIdentities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualMachineIdentity Identity for the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20220301storageVirtualMachineSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualMachineNetworkInterfaceDnsSettingsConfiguration Describes a virtual machines network configuration's DNS settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsDnsSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dnsServers")]
    public IList<string>? DnsServers { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsDscpConfigurationReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsDscpConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsDscpConfigurationReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPoolsReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPools
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPoolsReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroupsReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroups
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroupsReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPoolsReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPools
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPoolsReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualMachinePublicIPAddressDnsSettingsConfiguration Describes a virtual machines network configuration's DNS settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationDnsSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("domainNameLabel")]
    public string? DomainNameLabel { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualMachineIpTag Contains the IP tag associated with the public IP address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationIpTags
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
#nullable disable

#nullable enable
/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefixReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefix
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefixReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.PublicIPAddressSku Describes the public IP Sku. It can only be set with OrchestrationMode as Flexible.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationSku
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualMachinePublicIPAddressConfiguration Describes a virtual machines IP Configuration's PublicIPAddress configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deleteOption")]
    public string? DeleteOption { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachinePublicIPAddressDnsSettingsConfiguration Describes a virtual machines network configuration's DNS settings.</summary>
    [JsonPropertyName("dnsSettings")]
    public V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationDnsSettings? DnsSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipTags")]
    public IList<V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationIpTags>? IpTags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicIPAddressVersion")]
    public string? PublicIPAddressVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicIPAllocationMethod")]
    public string? PublicIPAllocationMethod { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource</summary>
    [JsonPropertyName("publicIPPrefix")]
    public V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefix? PublicIPPrefix { get; set; }

    /// <summary>Storage version of v1api20220301.PublicIPAddressSku Describes the public IP Sku. It can only be set with OrchestrationMode as Flexible.</summary>
    [JsonPropertyName("sku")]
    public V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationSku? Sku { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnetReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnetReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualMachineNetworkInterfaceIPConfiguration Describes a virtual machine network profile's IP configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applicationGatewayBackendAddressPools")]
    public IList<V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPools>? ApplicationGatewayBackendAddressPools { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applicationSecurityGroups")]
    public IList<V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroups>? ApplicationSecurityGroups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loadBalancerBackendAddressPools")]
    public IList<V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPools>? LoadBalancerBackendAddressPools { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateIPAddressVersion")]
    public string? PrivateIPAddressVersion { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachinePublicIPAddressConfiguration Describes a virtual machines IP Configuration's PublicIPAddress configuration</summary>
    [JsonPropertyName("publicIPAddressConfiguration")]
    public V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfiguration? PublicIPAddressConfiguration { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource</summary>
    [JsonPropertyName("subnet")]
    public V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnet? Subnet { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroupReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroup
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroupReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualMachineNetworkInterfaceConfiguration Describes a virtual machine network interface configurations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deleteOption")]
    public string? DeleteOption { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineNetworkInterfaceDnsSettingsConfiguration Describes a virtual machines network configuration's DNS settings.</summary>
    [JsonPropertyName("dnsSettings")]
    public V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsDnsSettings? DnsSettings { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource</summary>
    [JsonPropertyName("dscpConfiguration")]
    public V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsDscpConfiguration? DscpConfiguration { get; set; }

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
    public IList<V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsIpConfigurations>? IpConfigurations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource</summary>
    [JsonPropertyName("networkSecurityGroup")]
    public V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroup? NetworkSecurityGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfacesReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.NetworkInterfaceReference Describes a network interface reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaces
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deleteOption")]
    public string? DeleteOption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfacesReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.NetworkProfile Specifies the network interfaces or the networking configuration of the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecNetworkProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkApiVersion")]
    public string? NetworkApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkInterfaceConfigurations")]
    public IList<V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaceConfigurations>? NetworkInterfaceConfigurations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkInterfaces")]
    public IList<V1api20220301storageVirtualMachineSpecNetworkProfileNetworkInterfaces>? NetworkInterfaces { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting map[string]string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap or secret to write to. The configmap or secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecOperatorSpecSecretExpressions
{
    /// <summary>Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting map[string]string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Name is the name of the Kubernetes configmap or secret to write to. The configmap or secret will be created in the same namespace as the resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualMachineOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20220301storageVirtualMachineSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20220301storageVirtualMachineSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}
#nullable disable

#nullable enable
/// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecOsProfileAdminPassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name is the name of the Kubernetes secret being referenced. The secret must be in the same namespace as the resource</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.LinuxVMGuestPatchAutomaticByPlatformSettings Specifies additional settings to be applied when patch mode AutomaticByPlatform is selected in Linux patch settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecOsProfileLinuxConfigurationPatchSettingsAutomaticByPlatformSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rebootSetting")]
    public string? RebootSetting { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.LinuxPatchSettings Specifies settings related to VM Guest Patching on Linux.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecOsProfileLinuxConfigurationPatchSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("assessmentMode")]
    public string? AssessmentMode { get; set; }

    /// <summary>Storage version of v1api20220301.LinuxVMGuestPatchAutomaticByPlatformSettings Specifies additional settings to be applied when patch mode AutomaticByPlatform is selected in Linux patch settings.</summary>
    [JsonPropertyName("automaticByPlatformSettings")]
    public V1api20220301storageVirtualMachineSpecOsProfileLinuxConfigurationPatchSettingsAutomaticByPlatformSettings? AutomaticByPlatformSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SshPublicKeySpec Contains information about SSH certificate public key and the path on the Linux VM where the public key is placed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecOsProfileLinuxConfigurationSshPublicKeys
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SshConfiguration SSH configuration for Linux based VMs running on Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecOsProfileLinuxConfigurationSsh
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicKeys")]
    public IList<V1api20220301storageVirtualMachineSpecOsProfileLinuxConfigurationSshPublicKeys>? PublicKeys { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.LinuxConfiguration Specifies the Linux operating system settings on the virtual machine. For a list of supported Linux distributions, see [Linux on Azure-Endorsed Distributions](https://docs.microsoft.com/azure/virtual-machines/linux/endorsed-distros).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecOsProfileLinuxConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disablePasswordAuthentication")]
    public bool? DisablePasswordAuthentication { get; set; }

    /// <summary>Storage version of v1api20220301.LinuxPatchSettings Specifies settings related to VM Guest Patching on Linux.</summary>
    [JsonPropertyName("patchSettings")]
    public V1api20220301storageVirtualMachineSpecOsProfileLinuxConfigurationPatchSettings? PatchSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisionVMAgent")]
    public bool? ProvisionVMAgent { get; set; }

    /// <summary>Storage version of v1api20220301.SshConfiguration SSH configuration for Linux based VMs running on Azure</summary>
    [JsonPropertyName("ssh")]
    public V1api20220301storageVirtualMachineSpecOsProfileLinuxConfigurationSsh? Ssh { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecOsProfileSecretsSourceVaultReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecOsProfileSecretsSourceVault
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineSpecOsProfileSecretsSourceVaultReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VaultCertificate Describes a single certificate reference in a Key Vault, and where the certificate should reside on the VM.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecOsProfileSecretsVaultCertificates
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VaultSecretGroup Describes a set of certificates which are all in the same Key Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecOsProfileSecrets
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20220301storageVirtualMachineSpecOsProfileSecretsSourceVault? SourceVault { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vaultCertificates")]
    public IList<V1api20220301storageVirtualMachineSpecOsProfileSecretsVaultCertificates>? VaultCertificates { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.AdditionalUnattendContent Specifies additional XML formatted information that can be included in the Unattend.xml file, which is used by Windows Setup. Contents are defined by setting name, component name, and the pass in which the content is applied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecOsProfileWindowsConfigurationAdditionalUnattendContent
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.WindowsVMGuestPatchAutomaticByPlatformSettings Specifies additional settings to be applied when patch mode AutomaticByPlatform is selected in Windows patch settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecOsProfileWindowsConfigurationPatchSettingsAutomaticByPlatformSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rebootSetting")]
    public string? RebootSetting { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.PatchSettings Specifies settings related to VM Guest Patching on Windows.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecOsProfileWindowsConfigurationPatchSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("assessmentMode")]
    public string? AssessmentMode { get; set; }

    /// <summary>Storage version of v1api20220301.WindowsVMGuestPatchAutomaticByPlatformSettings Specifies additional settings to be applied when patch mode AutomaticByPlatform is selected in Windows patch settings.</summary>
    [JsonPropertyName("automaticByPlatformSettings")]
    public V1api20220301storageVirtualMachineSpecOsProfileWindowsConfigurationPatchSettingsAutomaticByPlatformSettings? AutomaticByPlatformSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableHotpatching")]
    public bool? EnableHotpatching { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.WinRMListener Describes Protocol and thumbprint of Windows Remote Management listener</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecOsProfileWindowsConfigurationWinRMListeners
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.WinRMConfiguration Describes Windows Remote Management configuration of the VM</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecOsProfileWindowsConfigurationWinRM
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("listeners")]
    public IList<V1api20220301storageVirtualMachineSpecOsProfileWindowsConfigurationWinRMListeners>? Listeners { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.WindowsConfiguration Specifies Windows operating system settings on the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecOsProfileWindowsConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalUnattendContent")]
    public IList<V1api20220301storageVirtualMachineSpecOsProfileWindowsConfigurationAdditionalUnattendContent>? AdditionalUnattendContent { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableAutomaticUpdates")]
    public bool? EnableAutomaticUpdates { get; set; }

    /// <summary>Storage version of v1api20220301.PatchSettings Specifies settings related to VM Guest Patching on Windows.</summary>
    [JsonPropertyName("patchSettings")]
    public V1api20220301storageVirtualMachineSpecOsProfileWindowsConfigurationPatchSettings? PatchSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisionVMAgent")]
    public bool? ProvisionVMAgent { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>Storage version of v1api20220301.WinRMConfiguration Describes Windows Remote Management configuration of the VM</summary>
    [JsonPropertyName("winRM")]
    public V1api20220301storageVirtualMachineSpecOsProfileWindowsConfigurationWinRM? WinRM { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.OSProfile Specifies the operating system settings for the virtual machine. Some of the settings cannot be changed once VM is provisioned.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecOsProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>SecretReference is a reference to a Kubernetes secret and key in the same namespace as the resource it is on.</summary>
    [JsonPropertyName("adminPassword")]
    public V1api20220301storageVirtualMachineSpecOsProfileAdminPassword? AdminPassword { get; set; }

    /// <summary></summary>
    [JsonPropertyName("adminUsername")]
    public string? AdminUsername { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowExtensionOperations")]
    public bool? AllowExtensionOperations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computerName")]
    public string? ComputerName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customData")]
    public string? CustomData { get; set; }

    /// <summary>Storage version of v1api20220301.LinuxConfiguration Specifies the Linux operating system settings on the virtual machine. For a list of supported Linux distributions, see [Linux on Azure-Endorsed Distributions](https://docs.microsoft.com/azure/virtual-machines/linux/endorsed-distros).</summary>
    [JsonPropertyName("linuxConfiguration")]
    public V1api20220301storageVirtualMachineSpecOsProfileLinuxConfiguration? LinuxConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requireGuestProvisionSignal")]
    public bool? RequireGuestProvisionSignal { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secrets")]
    public IList<V1api20220301storageVirtualMachineSpecOsProfileSecrets>? Secrets { get; set; }

    /// <summary>Storage version of v1api20220301.WindowsConfiguration Specifies Windows operating system settings on the virtual machine.</summary>
    [JsonPropertyName("windowsConfiguration")]
    public V1api20220301storageVirtualMachineSpecOsProfileWindowsConfiguration? WindowsConfiguration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.Plan Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use. In the Azure portal, find the marketplace image that you want to use and then click Want to deploy programmatically, Get Started -&gt;. Enter any required information and then click Save.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecPlan
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
#nullable disable

#nullable enable
/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecProximityPlacementGroupReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecProximityPlacementGroup
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineSpecProximityPlacementGroupReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.TerminateNotificationProfile</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecScheduledEventsProfileTerminateNotificationProfile
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.ScheduledEventsProfile</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecScheduledEventsProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.TerminateNotificationProfile</summary>
    [JsonPropertyName("terminateNotificationProfile")]
    public V1api20220301storageVirtualMachineSpecScheduledEventsProfileTerminateNotificationProfile? TerminateNotificationProfile { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.UefiSettings Specifies the security settings like secure boot and vTPM used while creating the virtual machine. Minimum api-version: 2020-12-01</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecSecurityProfileUefiSettings
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SecurityProfile Specifies the Security profile settings for the virtual machine or virtual machine scale set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecSecurityProfile
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
    public V1api20220301storageVirtualMachineSpecSecurityProfileUefiSettings? UefiSettings { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualHardDisk Describes the uri of a disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecStorageProfileDataDisksImage
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecStorageProfileDataDisksManagedDiskDiskEncryptionSetReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecStorageProfileDataDisksManagedDiskDiskEncryptionSet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineSpecStorageProfileDataDisksManagedDiskDiskEncryptionSetReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecStorageProfileDataDisksManagedDiskReference
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
#nullable disable

#nullable enable
/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecStorageProfileDataDisksManagedDiskSecurityProfileDiskEncryptionSetReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecStorageProfileDataDisksManagedDiskSecurityProfileDiskEncryptionSet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineSpecStorageProfileDataDisksManagedDiskSecurityProfileDiskEncryptionSetReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VMDiskSecurityProfile Specifies the security profile settings for the managed disk. NOTE: It can only be set for Confidential VMs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecStorageProfileDataDisksManagedDiskSecurityProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20220301storageVirtualMachineSpecStorageProfileDataDisksManagedDiskSecurityProfileDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityEncryptionType")]
    public string? SecurityEncryptionType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.ManagedDiskParameters The parameters of a managed disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecStorageProfileDataDisksManagedDisk
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20220301storageVirtualMachineSpecStorageProfileDataDisksManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineSpecStorageProfileDataDisksManagedDiskReference? Reference { get; set; }

    /// <summary>Storage version of v1api20220301.VMDiskSecurityProfile Specifies the security profile settings for the managed disk. NOTE: It can only be set for Confidential VMs</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20220301storageVirtualMachineSpecStorageProfileDataDisksManagedDiskSecurityProfile? SecurityProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualHardDisk Describes the uri of a disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecStorageProfileDataDisksVhd
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.DataDisk Describes a data disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecStorageProfileDataDisks
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
    [JsonPropertyName("detachOption")]
    public string? DetachOption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualHardDisk Describes the uri of a disk.</summary>
    [JsonPropertyName("image")]
    public V1api20220301storageVirtualMachineSpecStorageProfileDataDisksImage? Image { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lun")]
    public int? Lun { get; set; }

    /// <summary>Storage version of v1api20220301.ManagedDiskParameters The parameters of a managed disk.</summary>
    [JsonPropertyName("managedDisk")]
    public V1api20220301storageVirtualMachineSpecStorageProfileDataDisksManagedDisk? ManagedDisk { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("toBeDetached")]
    public bool? ToBeDetached { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualHardDisk Describes the uri of a disk.</summary>
    [JsonPropertyName("vhd")]
    public V1api20220301storageVirtualMachineSpecStorageProfileDataDisksVhd? Vhd { get; set; }

    /// <summary></summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecStorageProfileImageReferenceReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.ImageReference Specifies information about the image to use. You can specify information about platform images, marketplace images, or virtual machine images. This element is required when you want to use a platform image, marketplace image, or virtual machine image, but is not used in other creation operations. NOTE: Image reference publisher and offer can only be set when you create the scale set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecStorageProfileImageReference
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
    public V1api20220301storageVirtualMachineSpecStorageProfileImageReferenceReference? Reference { get; set; }

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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.DiffDiskSettings Describes the parameters of ephemeral disk settings that can be specified for operating system disk. NOTE: The ephemeral disk settings can only be specified for managed disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecStorageProfileOsDiskDiffDiskSettings
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
#nullable disable

#nullable enable
/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecStorageProfileOsDiskEncryptionSettingsDiskEncryptionKeySourceVaultReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecStorageProfileOsDiskEncryptionSettingsDiskEncryptionKeySourceVault
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineSpecStorageProfileOsDiskEncryptionSettingsDiskEncryptionKeySourceVaultReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.KeyVaultSecretReference Describes a reference to Key Vault Secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecStorageProfileOsDiskEncryptionSettingsDiskEncryptionKey
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20220301storageVirtualMachineSpecStorageProfileOsDiskEncryptionSettingsDiskEncryptionKeySourceVault? SourceVault { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecStorageProfileOsDiskEncryptionSettingsKeyEncryptionKeySourceVaultReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecStorageProfileOsDiskEncryptionSettingsKeyEncryptionKeySourceVault
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineSpecStorageProfileOsDiskEncryptionSettingsKeyEncryptionKeySourceVaultReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.KeyVaultKeyReference Describes a reference to Key Vault Key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecStorageProfileOsDiskEncryptionSettingsKeyEncryptionKey
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyUrl")]
    public string? KeyUrl { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20220301storageVirtualMachineSpecStorageProfileOsDiskEncryptionSettingsKeyEncryptionKeySourceVault? SourceVault { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.DiskEncryptionSettings Describes a Encryption Settings for a Disk</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecStorageProfileOsDiskEncryptionSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.KeyVaultSecretReference Describes a reference to Key Vault Secret</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1api20220301storageVirtualMachineSpecStorageProfileOsDiskEncryptionSettingsDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Storage version of v1api20220301.KeyVaultKeyReference Describes a reference to Key Vault Key</summary>
    [JsonPropertyName("keyEncryptionKey")]
    public V1api20220301storageVirtualMachineSpecStorageProfileOsDiskEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualHardDisk Describes the uri of a disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecStorageProfileOsDiskImage
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecStorageProfileOsDiskManagedDiskDiskEncryptionSetReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecStorageProfileOsDiskManagedDiskDiskEncryptionSet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineSpecStorageProfileOsDiskManagedDiskDiskEncryptionSetReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecStorageProfileOsDiskManagedDiskReference
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
#nullable disable

#nullable enable
/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecStorageProfileOsDiskManagedDiskSecurityProfileDiskEncryptionSetReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecStorageProfileOsDiskManagedDiskSecurityProfileDiskEncryptionSet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineSpecStorageProfileOsDiskManagedDiskSecurityProfileDiskEncryptionSetReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VMDiskSecurityProfile Specifies the security profile settings for the managed disk. NOTE: It can only be set for Confidential VMs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecStorageProfileOsDiskManagedDiskSecurityProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20220301storageVirtualMachineSpecStorageProfileOsDiskManagedDiskSecurityProfileDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityEncryptionType")]
    public string? SecurityEncryptionType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.ManagedDiskParameters The parameters of a managed disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecStorageProfileOsDiskManagedDisk
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20220301storageVirtualMachineSpecStorageProfileOsDiskManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineSpecStorageProfileOsDiskManagedDiskReference? Reference { get; set; }

    /// <summary>Storage version of v1api20220301.VMDiskSecurityProfile Specifies the security profile settings for the managed disk. NOTE: It can only be set for Confidential VMs</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20220301storageVirtualMachineSpecStorageProfileOsDiskManagedDiskSecurityProfile? SecurityProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualHardDisk Describes the uri of a disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecStorageProfileOsDiskVhd
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.OSDisk Specifies information about the operating system disk used by the virtual machine. For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecStorageProfileOsDisk
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
    public V1api20220301storageVirtualMachineSpecStorageProfileOsDiskDiffDiskSettings? DiffDiskSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>Storage version of v1api20220301.DiskEncryptionSettings Describes a Encryption Settings for a Disk</summary>
    [JsonPropertyName("encryptionSettings")]
    public V1api20220301storageVirtualMachineSpecStorageProfileOsDiskEncryptionSettings? EncryptionSettings { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualHardDisk Describes the uri of a disk.</summary>
    [JsonPropertyName("image")]
    public V1api20220301storageVirtualMachineSpecStorageProfileOsDiskImage? Image { get; set; }

    /// <summary>Storage version of v1api20220301.ManagedDiskParameters The parameters of a managed disk.</summary>
    [JsonPropertyName("managedDisk")]
    public V1api20220301storageVirtualMachineSpecStorageProfileOsDiskManagedDisk? ManagedDisk { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualHardDisk Describes the uri of a disk.</summary>
    [JsonPropertyName("vhd")]
    public V1api20220301storageVirtualMachineSpecStorageProfileOsDiskVhd? Vhd { get; set; }

    /// <summary></summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.StorageProfile Specifies the storage settings for the virtual machine disks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecStorageProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataDisks")]
    public IList<V1api20220301storageVirtualMachineSpecStorageProfileDataDisks>? DataDisks { get; set; }

    /// <summary>Storage version of v1api20220301.ImageReference Specifies information about the image to use. You can specify information about platform images, marketplace images, or virtual machine images. This element is required when you want to use a platform image, marketplace image, or virtual machine image, but is not used in other creation operations. NOTE: Image reference publisher and offer can only be set when you create the scale set.</summary>
    [JsonPropertyName("imageReference")]
    public V1api20220301storageVirtualMachineSpecStorageProfileImageReference? ImageReference { get; set; }

    /// <summary>Storage version of v1api20220301.OSDisk Specifies information about the operating system disk used by the virtual machine. For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).</summary>
    [JsonPropertyName("osDisk")]
    public V1api20220301storageVirtualMachineSpecStorageProfileOsDisk? OsDisk { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecVirtualMachineScaleSetReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpecVirtualMachineScaleSet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20220301storageVirtualMachineSpecVirtualMachineScaleSetReference? Reference { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualMachine_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.AdditionalCapabilities Enables or disables a capability on the virtual machine or virtual machine scale set.</summary>
    [JsonPropertyName("additionalCapabilities")]
    public V1api20220301storageVirtualMachineSpecAdditionalCapabilities? AdditionalCapabilities { get; set; }

    /// <summary>Storage version of v1api20220301.ApplicationProfile Contains the list of gallery applications that should be made available to the VM/VMSS</summary>
    [JsonPropertyName("applicationProfile")]
    public V1api20220301storageVirtualMachineSpecApplicationProfile? ApplicationProfile { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource</summary>
    [JsonPropertyName("availabilitySet")]
    public V1api20220301storageVirtualMachineSpecAvailabilitySet? AvailabilitySet { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Storage version of v1api20220301.BillingProfile Specifies the billing related details of a Azure Spot VM or VMSS. Minimum api-version: 2019-03-01.</summary>
    [JsonPropertyName("billingProfile")]
    public V1api20220301storageVirtualMachineSpecBillingProfile? BillingProfile { get; set; }

    /// <summary>Storage version of v1api20220301.CapacityReservationProfile The parameters of a capacity reservation Profile.</summary>
    [JsonPropertyName("capacityReservation")]
    public V1api20220301storageVirtualMachineSpecCapacityReservation? CapacityReservation { get; set; }

    /// <summary>Storage version of v1api20220301.DiagnosticsProfile Specifies the boot diagnostic settings state. Minimum api-version: 2015-06-15.</summary>
    [JsonPropertyName("diagnosticsProfile")]
    public V1api20220301storageVirtualMachineSpecDiagnosticsProfile? DiagnosticsProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>Storage version of v1api20220301.ExtendedLocation The complex type of the extended location.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20220301storageVirtualMachineSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("extensionsTimeBudget")]
    public string? ExtensionsTimeBudget { get; set; }

    /// <summary>Storage version of v1api20220301.HardwareProfile Specifies the hardware settings for the virtual machine.</summary>
    [JsonPropertyName("hardwareProfile")]
    public V1api20220301storageVirtualMachineSpecHardwareProfile? HardwareProfile { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource</summary>
    [JsonPropertyName("host")]
    public V1api20220301storageVirtualMachineSpecHost? Host { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource</summary>
    [JsonPropertyName("hostGroup")]
    public V1api20220301storageVirtualMachineSpecHostGroup? HostGroup { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineIdentity Identity for the virtual machine.</summary>
    [JsonPropertyName("identity")]
    public V1api20220301storageVirtualMachineSpecIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Storage version of v1api20220301.NetworkProfile Specifies the network interfaces or the networking configuration of the virtual machine.</summary>
    [JsonPropertyName("networkProfile")]
    public V1api20220301storageVirtualMachineSpecNetworkProfile? NetworkProfile { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20220301storageVirtualMachineSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Storage version of v1api20220301.OSProfile Specifies the operating system settings for the virtual machine. Some of the settings cannot be changed once VM is provisioned.</summary>
    [JsonPropertyName("osProfile")]
    public V1api20220301storageVirtualMachineSpecOsProfile? OsProfile { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20220301storageVirtualMachineSpecOwner Owner { get; set; }

    /// <summary>Storage version of v1api20220301.Plan Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use. In the Azure portal, find the marketplace image that you want to use and then click Want to deploy programmatically, Get Started -&gt;. Enter any required information and then click Save.</summary>
    [JsonPropertyName("plan")]
    public V1api20220301storageVirtualMachineSpecPlan? Plan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("platformFaultDomain")]
    public int? PlatformFaultDomain { get; set; }

    /// <summary></summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource</summary>
    [JsonPropertyName("proximityPlacementGroup")]
    public V1api20220301storageVirtualMachineSpecProximityPlacementGroup? ProximityPlacementGroup { get; set; }

    /// <summary>Storage version of v1api20220301.ScheduledEventsProfile</summary>
    [JsonPropertyName("scheduledEventsProfile")]
    public V1api20220301storageVirtualMachineSpecScheduledEventsProfile? ScheduledEventsProfile { get; set; }

    /// <summary>Storage version of v1api20220301.SecurityProfile Specifies the Security profile settings for the virtual machine or virtual machine scale set.</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20220301storageVirtualMachineSpecSecurityProfile? SecurityProfile { get; set; }

    /// <summary>Storage version of v1api20220301.StorageProfile Specifies the storage settings for the virtual machine disks.</summary>
    [JsonPropertyName("storageProfile")]
    public V1api20220301storageVirtualMachineSpecStorageProfile? StorageProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource</summary>
    [JsonPropertyName("virtualMachineScaleSet")]
    public V1api20220301storageVirtualMachineSpecVirtualMachineScaleSet? VirtualMachineScaleSet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.AdditionalCapabilities_STATUS Enables or disables a capability on the virtual machine or virtual machine scale set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusAdditionalCapabilities
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VMGalleryApplication_STATUS Specifies the required information to reference a compute gallery application version</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusApplicationProfileGalleryApplications
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.ApplicationProfile_STATUS Contains the list of gallery applications that should be made available to the VM/VMSS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusApplicationProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("galleryApplications")]
    public IList<V1api20220301storageVirtualMachineStatusApplicationProfileGalleryApplications>? GalleryApplications { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusAvailabilitySet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.BillingProfile_STATUS Specifies the billing related details of a Azure Spot VM or VMSS. Minimum api-version: 2019-03-01.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusBillingProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maxPrice")]
    public double? MaxPrice { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusCapacityReservationCapacityReservationGroup
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.CapacityReservationProfile_STATUS The parameters of a capacity reservation Profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusCapacityReservation
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
    [JsonPropertyName("capacityReservationGroup")]
    public V1api20220301storageVirtualMachineStatusCapacityReservationCapacityReservationGroup? CapacityReservationGroup { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusConditions
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.BootDiagnostics_STATUS Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to diagnose VM status. You can easily view the output of your console log. Azure also enables you to see a screenshot of the VM from the hypervisor.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusDiagnosticsProfileBootDiagnostics
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.DiagnosticsProfile_STATUS Specifies the boot diagnostic settings state. Minimum api-version: 2015-06-15.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusDiagnosticsProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.BootDiagnostics_STATUS Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to diagnose VM status. You can easily view the output of your console log. Azure also enables you to see a screenshot of the VM from the hypervisor.</summary>
    [JsonPropertyName("bootDiagnostics")]
    public V1api20220301storageVirtualMachineStatusDiagnosticsProfileBootDiagnostics? BootDiagnostics { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.ExtendedLocation_STATUS The complex type of the extended location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusExtendedLocation
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VMSizeProperties_STATUS Specifies VM Size Property settings on the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusHardwareProfileVmSizeProperties
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.HardwareProfile_STATUS Specifies the hardware settings for the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusHardwareProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmSize")]
    public string? VmSize { get; set; }

    /// <summary>Storage version of v1api20220301.VMSizeProperties_STATUS Specifies VM Size Property settings on the virtual machine.</summary>
    [JsonPropertyName("vmSizeProperties")]
    public V1api20220301storageVirtualMachineStatusHardwareProfileVmSizeProperties? VmSizeProperties { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusHost
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusHostGroup
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualMachineIdentity_UserAssignedIdentities_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusIdentityUserAssignedIdentities
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualMachineIdentity_STATUS Identity for the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusIdentity
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
    public IDictionary<string, V1api20220301storageVirtualMachineStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.InstanceViewStatus_STATUS Instance view status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusInstanceViewBootDiagnosticsStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("displayStatus")]
    public string? DisplayStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.BootDiagnosticsInstanceView_STATUS The instance view of a virtual machine boot diagnostics.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusInstanceViewBootDiagnostics
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("consoleScreenshotBlobUri")]
    public string? ConsoleScreenshotBlobUri { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serialConsoleLogBlobUri")]
    public string? SerialConsoleLogBlobUri { get; set; }

    /// <summary>Storage version of v1api20220301.InstanceViewStatus_STATUS Instance view status.</summary>
    [JsonPropertyName("status")]
    public V1api20220301storageVirtualMachineStatusInstanceViewBootDiagnosticsStatus? Status { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusInstanceViewDisksEncryptionSettingsDiskEncryptionKeySourceVault
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.KeyVaultSecretReference_STATUS Describes a reference to Key Vault Secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusInstanceViewDisksEncryptionSettingsDiskEncryptionKey
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20220301storageVirtualMachineStatusInstanceViewDisksEncryptionSettingsDiskEncryptionKeySourceVault? SourceVault { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusInstanceViewDisksEncryptionSettingsKeyEncryptionKeySourceVault
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.KeyVaultKeyReference_STATUS Describes a reference to Key Vault Key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusInstanceViewDisksEncryptionSettingsKeyEncryptionKey
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyUrl")]
    public string? KeyUrl { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20220301storageVirtualMachineStatusInstanceViewDisksEncryptionSettingsKeyEncryptionKeySourceVault? SourceVault { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.DiskEncryptionSettings_STATUS Describes a Encryption Settings for a Disk</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusInstanceViewDisksEncryptionSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.KeyVaultSecretReference_STATUS Describes a reference to Key Vault Secret</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1api20220301storageVirtualMachineStatusInstanceViewDisksEncryptionSettingsDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Storage version of v1api20220301.KeyVaultKeyReference_STATUS Describes a reference to Key Vault Key</summary>
    [JsonPropertyName("keyEncryptionKey")]
    public V1api20220301storageVirtualMachineStatusInstanceViewDisksEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.InstanceViewStatus_STATUS Instance view status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusInstanceViewDisksStatuses
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("displayStatus")]
    public string? DisplayStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.DiskInstanceView_STATUS The instance view of the disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusInstanceViewDisks
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("encryptionSettings")]
    public IList<V1api20220301storageVirtualMachineStatusInstanceViewDisksEncryptionSettings>? EncryptionSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("statuses")]
    public IList<V1api20220301storageVirtualMachineStatusInstanceViewDisksStatuses>? Statuses { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.InstanceViewStatus_STATUS Instance view status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusInstanceViewExtensionsStatuses
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("displayStatus")]
    public string? DisplayStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.InstanceViewStatus_STATUS Instance view status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusInstanceViewExtensionsSubstatuses
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("displayStatus")]
    public string? DisplayStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualMachineExtensionInstanceView_STATUS The instance view of a virtual machine extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusInstanceViewExtensions
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("statuses")]
    public IList<V1api20220301storageVirtualMachineStatusInstanceViewExtensionsStatuses>? Statuses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("substatuses")]
    public IList<V1api20220301storageVirtualMachineStatusInstanceViewExtensionsSubstatuses>? Substatuses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.MaintenanceRedeployStatus_STATUS Maintenance Operation Status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusInstanceViewMaintenanceRedeployStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isCustomerInitiatedMaintenanceAllowed")]
    public bool? IsCustomerInitiatedMaintenanceAllowed { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastOperationMessage")]
    public string? LastOperationMessage { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastOperationResultCode")]
    public string? LastOperationResultCode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maintenanceWindowEndTime")]
    public string? MaintenanceWindowEndTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maintenanceWindowStartTime")]
    public string? MaintenanceWindowStartTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preMaintenanceWindowEndTime")]
    public string? PreMaintenanceWindowEndTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("preMaintenanceWindowStartTime")]
    public string? PreMaintenanceWindowStartTime { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.ApiErrorBase_STATUS Api error base.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummaryErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.InnerError_STATUS Inner error details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummaryErrorInnererror
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("errordetail")]
    public string? Errordetail { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exceptiontype")]
    public string? Exceptiontype { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.ApiError_STATUS Api error.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummaryError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20220301storageVirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummaryErrorDetails>? Details { get; set; }

    /// <summary>Storage version of v1api20220301.InnerError_STATUS Inner error details.</summary>
    [JsonPropertyName("innererror")]
    public V1api20220301storageVirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummaryErrorInnererror? Innererror { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.AvailablePatchSummary_STATUS Describes the properties of an virtual machine instance view for available patch summary.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummary
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("assessmentActivityId")]
    public string? AssessmentActivityId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("criticalAndSecurityPatchCount")]
    public int? CriticalAndSecurityPatchCount { get; set; }

    /// <summary>Storage version of v1api20220301.ApiError_STATUS Api error.</summary>
    [JsonPropertyName("error")]
    public V1api20220301storageVirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummaryError? Error { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedTime")]
    public string? LastModifiedTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("otherPatchCount")]
    public int? OtherPatchCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rebootPending")]
    public bool? RebootPending { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.InstanceViewStatus_STATUS Instance view status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusInstanceViewPatchStatusConfigurationStatuses
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("displayStatus")]
    public string? DisplayStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.ApiErrorBase_STATUS Api error base.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummaryErrorDetails
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.InnerError_STATUS Inner error details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummaryErrorInnererror
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("errordetail")]
    public string? Errordetail { get; set; }

    /// <summary></summary>
    [JsonPropertyName("exceptiontype")]
    public string? Exceptiontype { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.ApiError_STATUS Api error.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummaryError
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("details")]
    public IList<V1api20220301storageVirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummaryErrorDetails>? Details { get; set; }

    /// <summary>Storage version of v1api20220301.InnerError_STATUS Inner error details.</summary>
    [JsonPropertyName("innererror")]
    public V1api20220301storageVirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummaryErrorInnererror? Innererror { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.LastPatchInstallationSummary_STATUS Describes the properties of the last installed patch summary.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummary
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.ApiError_STATUS Api error.</summary>
    [JsonPropertyName("error")]
    public V1api20220301storageVirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummaryError? Error { get; set; }

    /// <summary></summary>
    [JsonPropertyName("excludedPatchCount")]
    public int? ExcludedPatchCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("failedPatchCount")]
    public int? FailedPatchCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("installationActivityId")]
    public string? InstallationActivityId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("installedPatchCount")]
    public int? InstalledPatchCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lastModifiedTime")]
    public string? LastModifiedTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("maintenanceWindowExceeded")]
    public bool? MaintenanceWindowExceeded { get; set; }

    /// <summary></summary>
    [JsonPropertyName("notSelectedPatchCount")]
    public int? NotSelectedPatchCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pendingPatchCount")]
    public int? PendingPatchCount { get; set; }

    /// <summary></summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualMachinePatchStatus_STATUS The status of virtual machine patch operations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusInstanceViewPatchStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.AvailablePatchSummary_STATUS Describes the properties of an virtual machine instance view for available patch summary.</summary>
    [JsonPropertyName("availablePatchSummary")]
    public V1api20220301storageVirtualMachineStatusInstanceViewPatchStatusAvailablePatchSummary? AvailablePatchSummary { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configurationStatuses")]
    public IList<V1api20220301storageVirtualMachineStatusInstanceViewPatchStatusConfigurationStatuses>? ConfigurationStatuses { get; set; }

    /// <summary>Storage version of v1api20220301.LastPatchInstallationSummary_STATUS Describes the properties of the last installed patch summary.</summary>
    [JsonPropertyName("lastPatchInstallationSummary")]
    public V1api20220301storageVirtualMachineStatusInstanceViewPatchStatusLastPatchInstallationSummary? LastPatchInstallationSummary { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.InstanceViewStatus_STATUS Instance view status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusInstanceViewStatuses
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("displayStatus")]
    public string? DisplayStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.InstanceViewStatus_STATUS Instance view status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusInstanceViewVmAgentExtensionHandlersStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("displayStatus")]
    public string? DisplayStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualMachineExtensionHandlerInstanceView_STATUS The instance view of a virtual machine extension handler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusInstanceViewVmAgentExtensionHandlers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.InstanceViewStatus_STATUS Instance view status.</summary>
    [JsonPropertyName("status")]
    public V1api20220301storageVirtualMachineStatusInstanceViewVmAgentExtensionHandlersStatus? Status { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.InstanceViewStatus_STATUS Instance view status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusInstanceViewVmAgentStatuses
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("displayStatus")]
    public string? DisplayStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualMachineAgentInstanceView_STATUS The instance view of the VM Agent running on the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusInstanceViewVmAgent
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("extensionHandlers")]
    public IList<V1api20220301storageVirtualMachineStatusInstanceViewVmAgentExtensionHandlers>? ExtensionHandlers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("statuses")]
    public IList<V1api20220301storageVirtualMachineStatusInstanceViewVmAgentStatuses>? Statuses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmAgentVersion")]
    public string? VmAgentVersion { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.InstanceViewStatus_STATUS Instance view status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusInstanceViewVmHealthStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("displayStatus")]
    public string? DisplayStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualMachineHealthStatus_STATUS The health status of the VM.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusInstanceViewVmHealth
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.InstanceViewStatus_STATUS Instance view status.</summary>
    [JsonPropertyName("status")]
    public V1api20220301storageVirtualMachineStatusInstanceViewVmHealthStatus? Status { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualMachineInstanceView_STATUS The instance view of a virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusInstanceView
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("assignedHost")]
    public string? AssignedHost { get; set; }

    /// <summary>Storage version of v1api20220301.BootDiagnosticsInstanceView_STATUS The instance view of a virtual machine boot diagnostics.</summary>
    [JsonPropertyName("bootDiagnostics")]
    public V1api20220301storageVirtualMachineStatusInstanceViewBootDiagnostics? BootDiagnostics { get; set; }

    /// <summary></summary>
    [JsonPropertyName("computerName")]
    public string? ComputerName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disks")]
    public IList<V1api20220301storageVirtualMachineStatusInstanceViewDisks>? Disks { get; set; }

    /// <summary></summary>
    [JsonPropertyName("extensions")]
    public IList<V1api20220301storageVirtualMachineStatusInstanceViewExtensions>? Extensions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("hyperVGeneration")]
    public string? HyperVGeneration { get; set; }

    /// <summary>Storage version of v1api20220301.MaintenanceRedeployStatus_STATUS Maintenance Operation Status.</summary>
    [JsonPropertyName("maintenanceRedeployStatus")]
    public V1api20220301storageVirtualMachineStatusInstanceViewMaintenanceRedeployStatus? MaintenanceRedeployStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("osName")]
    public string? OsName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("osVersion")]
    public string? OsVersion { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachinePatchStatus_STATUS The status of virtual machine patch operations.</summary>
    [JsonPropertyName("patchStatus")]
    public V1api20220301storageVirtualMachineStatusInstanceViewPatchStatus? PatchStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("platformFaultDomain")]
    public int? PlatformFaultDomain { get; set; }

    /// <summary></summary>
    [JsonPropertyName("platformUpdateDomain")]
    public int? PlatformUpdateDomain { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rdpThumbPrint")]
    public string? RdpThumbPrint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("statuses")]
    public IList<V1api20220301storageVirtualMachineStatusInstanceViewStatuses>? Statuses { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineAgentInstanceView_STATUS The instance view of the VM Agent running on the virtual machine.</summary>
    [JsonPropertyName("vmAgent")]
    public V1api20220301storageVirtualMachineStatusInstanceViewVmAgent? VmAgent { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineHealthStatus_STATUS The health status of the VM.</summary>
    [JsonPropertyName("vmHealth")]
    public V1api20220301storageVirtualMachineStatusInstanceViewVmHealth? VmHealth { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualMachineNetworkInterfaceDnsSettingsConfiguration_STATUS Describes a virtual machines network configuration's DNS settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsDnsSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dnsServers")]
    public IList<string>? DnsServers { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsDscpConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPools
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroups
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPools
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualMachinePublicIPAddressDnsSettingsConfiguration_STATUS Describes a virtual machines network configuration's DNS settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationDnsSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("domainNameLabel")]
    public string? DomainNameLabel { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualMachineIpTag_STATUS Contains the IP tag associated with the public IP address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationIpTags
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefix
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.PublicIPAddressSku_STATUS Describes the public IP Sku. It can only be set with OrchestrationMode as Flexible.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationSku
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualMachinePublicIPAddressConfiguration_STATUS Describes a virtual machines IP Configuration's PublicIPAddress configuration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deleteOption")]
    public string? DeleteOption { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachinePublicIPAddressDnsSettingsConfiguration_STATUS Describes a virtual machines network configuration's DNS settings.</summary>
    [JsonPropertyName("dnsSettings")]
    public V1api20220301storageVirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationDnsSettings? DnsSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public int? IdleTimeoutInMinutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipTags")]
    public IList<V1api20220301storageVirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationIpTags>? IpTags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicIPAddressVersion")]
    public string? PublicIPAddressVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicIPAllocationMethod")]
    public string? PublicIPAllocationMethod { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
    [JsonPropertyName("publicIPPrefix")]
    public V1api20220301storageVirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationPublicIPPrefix? PublicIPPrefix { get; set; }

    /// <summary>Storage version of v1api20220301.PublicIPAddressSku_STATUS Describes the public IP Sku. It can only be set with OrchestrationMode as Flexible.</summary>
    [JsonPropertyName("sku")]
    public V1api20220301storageVirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfigurationSku? Sku { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualMachineNetworkInterfaceIPConfiguration_STATUS Describes a virtual machine network profile's IP configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applicationGatewayBackendAddressPools")]
    public IList<V1api20220301storageVirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationGatewayBackendAddressPools>? ApplicationGatewayBackendAddressPools { get; set; }

    /// <summary></summary>
    [JsonPropertyName("applicationSecurityGroups")]
    public IList<V1api20220301storageVirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsApplicationSecurityGroups>? ApplicationSecurityGroups { get; set; }

    /// <summary></summary>
    [JsonPropertyName("loadBalancerBackendAddressPools")]
    public IList<V1api20220301storageVirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsLoadBalancerBackendAddressPools>? LoadBalancerBackendAddressPools { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateIPAddressVersion")]
    public string? PrivateIPAddressVersion { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachinePublicIPAddressConfiguration_STATUS Describes a virtual machines IP Configuration's PublicIPAddress configuration</summary>
    [JsonPropertyName("publicIPAddressConfiguration")]
    public V1api20220301storageVirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsPublicIPAddressConfiguration? PublicIPAddressConfiguration { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
    [JsonPropertyName("subnet")]
    public V1api20220301storageVirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurationsSubnet? Subnet { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroup
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualMachineNetworkInterfaceConfiguration_STATUS Describes a virtual machine network interface configurations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusNetworkProfileNetworkInterfaceConfigurations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deleteOption")]
    public string? DeleteOption { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineNetworkInterfaceDnsSettingsConfiguration_STATUS Describes a virtual machines network configuration's DNS settings.</summary>
    [JsonPropertyName("dnsSettings")]
    public V1api20220301storageVirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsDnsSettings? DnsSettings { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
    [JsonPropertyName("dscpConfiguration")]
    public V1api20220301storageVirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsDscpConfiguration? DscpConfiguration { get; set; }

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
    public IList<V1api20220301storageVirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsIpConfigurations>? IpConfigurations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
    [JsonPropertyName("networkSecurityGroup")]
    public V1api20220301storageVirtualMachineStatusNetworkProfileNetworkInterfaceConfigurationsNetworkSecurityGroup? NetworkSecurityGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.NetworkInterfaceReference_STATUS Describes a network interface reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusNetworkProfileNetworkInterfaces
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("deleteOption")]
    public string? DeleteOption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.NetworkProfile_STATUS Specifies the network interfaces or the networking configuration of the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusNetworkProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkApiVersion")]
    public string? NetworkApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkInterfaceConfigurations")]
    public IList<V1api20220301storageVirtualMachineStatusNetworkProfileNetworkInterfaceConfigurations>? NetworkInterfaceConfigurations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("networkInterfaces")]
    public IList<V1api20220301storageVirtualMachineStatusNetworkProfileNetworkInterfaces>? NetworkInterfaces { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.LinuxVMGuestPatchAutomaticByPlatformSettings_STATUS Specifies additional settings to be applied when patch mode AutomaticByPlatform is selected in Linux patch settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusOsProfileLinuxConfigurationPatchSettingsAutomaticByPlatformSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rebootSetting")]
    public string? RebootSetting { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.LinuxPatchSettings_STATUS Specifies settings related to VM Guest Patching on Linux.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusOsProfileLinuxConfigurationPatchSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("assessmentMode")]
    public string? AssessmentMode { get; set; }

    /// <summary>Storage version of v1api20220301.LinuxVMGuestPatchAutomaticByPlatformSettings_STATUS Specifies additional settings to be applied when patch mode AutomaticByPlatform is selected in Linux patch settings.</summary>
    [JsonPropertyName("automaticByPlatformSettings")]
    public V1api20220301storageVirtualMachineStatusOsProfileLinuxConfigurationPatchSettingsAutomaticByPlatformSettings? AutomaticByPlatformSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SshPublicKey_STATUS Contains information about SSH certificate public key and the path on the Linux VM where the public key is placed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusOsProfileLinuxConfigurationSshPublicKeys
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SshConfiguration_STATUS SSH configuration for Linux based VMs running on Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusOsProfileLinuxConfigurationSsh
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicKeys")]
    public IList<V1api20220301storageVirtualMachineStatusOsProfileLinuxConfigurationSshPublicKeys>? PublicKeys { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.LinuxConfiguration_STATUS Specifies the Linux operating system settings on the virtual machine. For a list of supported Linux distributions, see [Linux on Azure-Endorsed Distributions](https://docs.microsoft.com/azure/virtual-machines/linux/endorsed-distros).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusOsProfileLinuxConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disablePasswordAuthentication")]
    public bool? DisablePasswordAuthentication { get; set; }

    /// <summary>Storage version of v1api20220301.LinuxPatchSettings_STATUS Specifies settings related to VM Guest Patching on Linux.</summary>
    [JsonPropertyName("patchSettings")]
    public V1api20220301storageVirtualMachineStatusOsProfileLinuxConfigurationPatchSettings? PatchSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisionVMAgent")]
    public bool? ProvisionVMAgent { get; set; }

    /// <summary>Storage version of v1api20220301.SshConfiguration_STATUS SSH configuration for Linux based VMs running on Azure</summary>
    [JsonPropertyName("ssh")]
    public V1api20220301storageVirtualMachineStatusOsProfileLinuxConfigurationSsh? Ssh { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusOsProfileSecretsSourceVault
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VaultCertificate_STATUS Describes a single certificate reference in a Key Vault, and where the certificate should reside on the VM.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusOsProfileSecretsVaultCertificates
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VaultSecretGroup_STATUS Describes a set of certificates which are all in the same Key Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusOsProfileSecrets
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20220301storageVirtualMachineStatusOsProfileSecretsSourceVault? SourceVault { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vaultCertificates")]
    public IList<V1api20220301storageVirtualMachineStatusOsProfileSecretsVaultCertificates>? VaultCertificates { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.AdditionalUnattendContent_STATUS Specifies additional XML formatted information that can be included in the Unattend.xml file, which is used by Windows Setup. Contents are defined by setting name, component name, and the pass in which the content is applied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusOsProfileWindowsConfigurationAdditionalUnattendContent
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.WindowsVMGuestPatchAutomaticByPlatformSettings_STATUS Specifies additional settings to be applied when patch mode AutomaticByPlatform is selected in Windows patch settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusOsProfileWindowsConfigurationPatchSettingsAutomaticByPlatformSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("rebootSetting")]
    public string? RebootSetting { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.PatchSettings_STATUS Specifies settings related to VM Guest Patching on Windows.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusOsProfileWindowsConfigurationPatchSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("assessmentMode")]
    public string? AssessmentMode { get; set; }

    /// <summary>Storage version of v1api20220301.WindowsVMGuestPatchAutomaticByPlatformSettings_STATUS Specifies additional settings to be applied when patch mode AutomaticByPlatform is selected in Windows patch settings.</summary>
    [JsonPropertyName("automaticByPlatformSettings")]
    public V1api20220301storageVirtualMachineStatusOsProfileWindowsConfigurationPatchSettingsAutomaticByPlatformSettings? AutomaticByPlatformSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableHotpatching")]
    public bool? EnableHotpatching { get; set; }

    /// <summary></summary>
    [JsonPropertyName("patchMode")]
    public string? PatchMode { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.WinRMListener_STATUS Describes Protocol and thumbprint of Windows Remote Management listener</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusOsProfileWindowsConfigurationWinRMListeners
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.WinRMConfiguration_STATUS Describes Windows Remote Management configuration of the VM</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusOsProfileWindowsConfigurationWinRM
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("listeners")]
    public IList<V1api20220301storageVirtualMachineStatusOsProfileWindowsConfigurationWinRMListeners>? Listeners { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.WindowsConfiguration_STATUS Specifies Windows operating system settings on the virtual machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusOsProfileWindowsConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("additionalUnattendContent")]
    public IList<V1api20220301storageVirtualMachineStatusOsProfileWindowsConfigurationAdditionalUnattendContent>? AdditionalUnattendContent { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableAutomaticUpdates")]
    public bool? EnableAutomaticUpdates { get; set; }

    /// <summary>Storage version of v1api20220301.PatchSettings_STATUS Specifies settings related to VM Guest Patching on Windows.</summary>
    [JsonPropertyName("patchSettings")]
    public V1api20220301storageVirtualMachineStatusOsProfileWindowsConfigurationPatchSettings? PatchSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisionVMAgent")]
    public bool? ProvisionVMAgent { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>Storage version of v1api20220301.WinRMConfiguration_STATUS Describes Windows Remote Management configuration of the VM</summary>
    [JsonPropertyName("winRM")]
    public V1api20220301storageVirtualMachineStatusOsProfileWindowsConfigurationWinRM? WinRM { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.OSProfile_STATUS Specifies the operating system settings for the virtual machine. Some of the settings cannot be changed once VM is provisioned.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusOsProfile
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
    [JsonPropertyName("computerName")]
    public string? ComputerName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customData")]
    public string? CustomData { get; set; }

    /// <summary>Storage version of v1api20220301.LinuxConfiguration_STATUS Specifies the Linux operating system settings on the virtual machine. For a list of supported Linux distributions, see [Linux on Azure-Endorsed Distributions](https://docs.microsoft.com/azure/virtual-machines/linux/endorsed-distros).</summary>
    [JsonPropertyName("linuxConfiguration")]
    public V1api20220301storageVirtualMachineStatusOsProfileLinuxConfiguration? LinuxConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("requireGuestProvisionSignal")]
    public bool? RequireGuestProvisionSignal { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secrets")]
    public IList<V1api20220301storageVirtualMachineStatusOsProfileSecrets>? Secrets { get; set; }

    /// <summary>Storage version of v1api20220301.WindowsConfiguration_STATUS Specifies Windows operating system settings on the virtual machine.</summary>
    [JsonPropertyName("windowsConfiguration")]
    public V1api20220301storageVirtualMachineStatusOsProfileWindowsConfiguration? WindowsConfiguration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.Plan_STATUS Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use. In the Azure portal, find the marketplace image that you want to use and then click Want to deploy programmatically, Get Started -&gt;. Enter any required information and then click Save.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusPlan
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusProximityPlacementGroup
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.InstanceViewStatus_STATUS Instance view status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusResourcesInstanceViewStatuses
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("displayStatus")]
    public string? DisplayStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.InstanceViewStatus_STATUS Instance view status.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusResourcesInstanceViewSubstatuses
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary></summary>
    [JsonPropertyName("displayStatus")]
    public string? DisplayStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary></summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary></summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualMachineExtensionInstanceView_STATUS The instance view of a virtual machine extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusResourcesInstanceView
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("statuses")]
    public IList<V1api20220301storageVirtualMachineStatusResourcesInstanceViewStatuses>? Statuses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("substatuses")]
    public IList<V1api20220301storageVirtualMachineStatusResourcesInstanceViewSubstatuses>? Substatuses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusResourcesProtectedSettingsFromKeyVaultSourceVault
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.KeyVaultSecretReference_STATUS Describes a reference to Key Vault Secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusResourcesProtectedSettingsFromKeyVault
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20220301storageVirtualMachineStatusResourcesProtectedSettingsFromKeyVaultSourceVault? SourceVault { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualMachineExtension_STATUS Describes a Virtual Machine Extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusResources
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

    /// <summary>Storage version of v1api20220301.VirtualMachineExtensionInstanceView_STATUS The instance view of a virtual machine extension.</summary>
    [JsonPropertyName("instanceView")]
    public V1api20220301storageVirtualMachineStatusResourcesInstanceView? InstanceView { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("properties_type")]
    public string? PropertiesType { get; set; }

    /// <summary>Storage version of v1api20220301.KeyVaultSecretReference_STATUS Describes a reference to Key Vault Secret</summary>
    [JsonPropertyName("protectedSettingsFromKeyVault")]
    public V1api20220301storageVirtualMachineStatusResourcesProtectedSettingsFromKeyVault? ProtectedSettingsFromKeyVault { get; set; }

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
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("typeHandlerVersion")]
    public string? TypeHandlerVersion { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.TerminateNotificationProfile_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusScheduledEventsProfileTerminateNotificationProfile
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.ScheduledEventsProfile_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusScheduledEventsProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.TerminateNotificationProfile_STATUS</summary>
    [JsonPropertyName("terminateNotificationProfile")]
    public V1api20220301storageVirtualMachineStatusScheduledEventsProfileTerminateNotificationProfile? TerminateNotificationProfile { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.UefiSettings_STATUS Specifies the security settings like secure boot and vTPM used while creating the virtual machine. Minimum api-version: 2020-12-01</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusSecurityProfileUefiSettings
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SecurityProfile_STATUS Specifies the Security profile settings for the virtual machine or virtual machine scale set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusSecurityProfile
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
    public V1api20220301storageVirtualMachineStatusSecurityProfileUefiSettings? UefiSettings { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualHardDisk_STATUS Describes the uri of a disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusStorageProfileDataDisksImage
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusStorageProfileDataDisksManagedDiskDiskEncryptionSet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusStorageProfileDataDisksManagedDiskSecurityProfileDiskEncryptionSet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VMDiskSecurityProfile_STATUS Specifies the security profile settings for the managed disk. NOTE: It can only be set for Confidential VMs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusStorageProfileDataDisksManagedDiskSecurityProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20220301storageVirtualMachineStatusStorageProfileDataDisksManagedDiskSecurityProfileDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityEncryptionType")]
    public string? SecurityEncryptionType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.ManagedDiskParameters_STATUS The parameters of a managed disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusStorageProfileDataDisksManagedDisk
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20220301storageVirtualMachineStatusStorageProfileDataDisksManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20220301.VMDiskSecurityProfile_STATUS Specifies the security profile settings for the managed disk. NOTE: It can only be set for Confidential VMs</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20220301storageVirtualMachineStatusStorageProfileDataDisksManagedDiskSecurityProfile? SecurityProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualHardDisk_STATUS Describes the uri of a disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusStorageProfileDataDisksVhd
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.DataDisk_STATUS Describes a data disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusStorageProfileDataDisks
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
    [JsonPropertyName("detachOption")]
    public string? DetachOption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskIOPSReadWrite")]
    public int? DiskIOPSReadWrite { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskMBpsReadWrite")]
    public int? DiskMBpsReadWrite { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualHardDisk_STATUS Describes the uri of a disk.</summary>
    [JsonPropertyName("image")]
    public V1api20220301storageVirtualMachineStatusStorageProfileDataDisksImage? Image { get; set; }

    /// <summary></summary>
    [JsonPropertyName("lun")]
    public int? Lun { get; set; }

    /// <summary>Storage version of v1api20220301.ManagedDiskParameters_STATUS The parameters of a managed disk.</summary>
    [JsonPropertyName("managedDisk")]
    public V1api20220301storageVirtualMachineStatusStorageProfileDataDisksManagedDisk? ManagedDisk { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("toBeDetached")]
    public bool? ToBeDetached { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualHardDisk_STATUS Describes the uri of a disk.</summary>
    [JsonPropertyName("vhd")]
    public V1api20220301storageVirtualMachineStatusStorageProfileDataDisksVhd? Vhd { get; set; }

    /// <summary></summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.ImageReference_STATUS Specifies information about the image to use. You can specify information about platform images, marketplace images, or virtual machine images. This element is required when you want to use a platform image, marketplace image, or virtual machine image, but is not used in other creation operations. NOTE: Image reference publisher and offer can only be set when you create the scale set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusStorageProfileImageReference
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.DiffDiskSettings_STATUS Describes the parameters of ephemeral disk settings that can be specified for operating system disk. NOTE: The ephemeral disk settings can only be specified for managed disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusStorageProfileOsDiskDiffDiskSettings
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
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusStorageProfileOsDiskEncryptionSettingsDiskEncryptionKeySourceVault
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.KeyVaultSecretReference_STATUS Describes a reference to Key Vault Secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusStorageProfileOsDiskEncryptionSettingsDiskEncryptionKey
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20220301storageVirtualMachineStatusStorageProfileOsDiskEncryptionSettingsDiskEncryptionKeySourceVault? SourceVault { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusStorageProfileOsDiskEncryptionSettingsKeyEncryptionKeySourceVault
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.KeyVaultKeyReference_STATUS Describes a reference to Key Vault Key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusStorageProfileOsDiskEncryptionSettingsKeyEncryptionKey
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("keyUrl")]
    public string? KeyUrl { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20220301storageVirtualMachineStatusStorageProfileOsDiskEncryptionSettingsKeyEncryptionKeySourceVault? SourceVault { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.DiskEncryptionSettings_STATUS Describes a Encryption Settings for a Disk</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusStorageProfileOsDiskEncryptionSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.KeyVaultSecretReference_STATUS Describes a reference to Key Vault Secret</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1api20220301storageVirtualMachineStatusStorageProfileOsDiskEncryptionSettingsDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Storage version of v1api20220301.KeyVaultKeyReference_STATUS Describes a reference to Key Vault Key</summary>
    [JsonPropertyName("keyEncryptionKey")]
    public V1api20220301storageVirtualMachineStatusStorageProfileOsDiskEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualHardDisk_STATUS Describes the uri of a disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusStorageProfileOsDiskImage
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusStorageProfileOsDiskManagedDiskDiskEncryptionSet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusStorageProfileOsDiskManagedDiskSecurityProfileDiskEncryptionSet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VMDiskSecurityProfile_STATUS Specifies the security profile settings for the managed disk. NOTE: It can only be set for Confidential VMs</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusStorageProfileOsDiskManagedDiskSecurityProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20220301storageVirtualMachineStatusStorageProfileOsDiskManagedDiskSecurityProfileDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("securityEncryptionType")]
    public string? SecurityEncryptionType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.ManagedDiskParameters_STATUS The parameters of a managed disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusStorageProfileOsDiskManagedDisk
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V1api20220301storageVirtualMachineStatusStorageProfileOsDiskManagedDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20220301.VMDiskSecurityProfile_STATUS Specifies the security profile settings for the managed disk. NOTE: It can only be set for Confidential VMs</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20220301storageVirtualMachineStatusStorageProfileOsDiskManagedDiskSecurityProfile? SecurityProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualHardDisk_STATUS Describes the uri of a disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusStorageProfileOsDiskVhd
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.OSDisk_STATUS Specifies information about the operating system disk used by the virtual machine. For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusStorageProfileOsDisk
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
    public V1api20220301storageVirtualMachineStatusStorageProfileOsDiskDiffDiskSettings? DiffDiskSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>Storage version of v1api20220301.DiskEncryptionSettings_STATUS Describes a Encryption Settings for a Disk</summary>
    [JsonPropertyName("encryptionSettings")]
    public V1api20220301storageVirtualMachineStatusStorageProfileOsDiskEncryptionSettings? EncryptionSettings { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualHardDisk_STATUS Describes the uri of a disk.</summary>
    [JsonPropertyName("image")]
    public V1api20220301storageVirtualMachineStatusStorageProfileOsDiskImage? Image { get; set; }

    /// <summary>Storage version of v1api20220301.ManagedDiskParameters_STATUS The parameters of a managed disk.</summary>
    [JsonPropertyName("managedDisk")]
    public V1api20220301storageVirtualMachineStatusStorageProfileOsDiskManagedDisk? ManagedDisk { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualHardDisk_STATUS Describes the uri of a disk.</summary>
    [JsonPropertyName("vhd")]
    public V1api20220301storageVirtualMachineStatusStorageProfileOsDiskVhd? Vhd { get; set; }

    /// <summary></summary>
    [JsonPropertyName("writeAcceleratorEnabled")]
    public bool? WriteAcceleratorEnabled { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.StorageProfile_STATUS Specifies the storage settings for the virtual machine disks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusStorageProfile
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dataDisks")]
    public IList<V1api20220301storageVirtualMachineStatusStorageProfileDataDisks>? DataDisks { get; set; }

    /// <summary>Storage version of v1api20220301.ImageReference_STATUS Specifies information about the image to use. You can specify information about platform images, marketplace images, or virtual machine images. This element is required when you want to use a platform image, marketplace image, or virtual machine image, but is not used in other creation operations. NOTE: Image reference publisher and offer can only be set when you create the scale set.</summary>
    [JsonPropertyName("imageReference")]
    public V1api20220301storageVirtualMachineStatusStorageProfileImageReference? ImageReference { get; set; }

    /// <summary>Storage version of v1api20220301.OSDisk_STATUS Specifies information about the operating system disk used by the virtual machine. For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).</summary>
    [JsonPropertyName("osDisk")]
    public V1api20220301storageVirtualMachineStatusStorageProfileOsDisk? OsDisk { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatusVirtualMachineScaleSet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualMachine_STATUS Describes a Virtual Machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20220301storageVirtualMachineStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20220301.AdditionalCapabilities_STATUS Enables or disables a capability on the virtual machine or virtual machine scale set.</summary>
    [JsonPropertyName("additionalCapabilities")]
    public V1api20220301storageVirtualMachineStatusAdditionalCapabilities? AdditionalCapabilities { get; set; }

    /// <summary>Storage version of v1api20220301.ApplicationProfile_STATUS Contains the list of gallery applications that should be made available to the VM/VMSS</summary>
    [JsonPropertyName("applicationProfile")]
    public V1api20220301storageVirtualMachineStatusApplicationProfile? ApplicationProfile { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
    [JsonPropertyName("availabilitySet")]
    public V1api20220301storageVirtualMachineStatusAvailabilitySet? AvailabilitySet { get; set; }

    /// <summary>Storage version of v1api20220301.BillingProfile_STATUS Specifies the billing related details of a Azure Spot VM or VMSS. Minimum api-version: 2019-03-01.</summary>
    [JsonPropertyName("billingProfile")]
    public V1api20220301storageVirtualMachineStatusBillingProfile? BillingProfile { get; set; }

    /// <summary>Storage version of v1api20220301.CapacityReservationProfile_STATUS The parameters of a capacity reservation Profile.</summary>
    [JsonPropertyName("capacityReservation")]
    public V1api20220301storageVirtualMachineStatusCapacityReservation? CapacityReservation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20220301storageVirtualMachineStatusConditions>? Conditions { get; set; }

    /// <summary>Storage version of v1api20220301.DiagnosticsProfile_STATUS Specifies the boot diagnostic settings state. Minimum api-version: 2015-06-15.</summary>
    [JsonPropertyName("diagnosticsProfile")]
    public V1api20220301storageVirtualMachineStatusDiagnosticsProfile? DiagnosticsProfile { get; set; }

    /// <summary></summary>
    [JsonPropertyName("evictionPolicy")]
    public string? EvictionPolicy { get; set; }

    /// <summary>Storage version of v1api20220301.ExtendedLocation_STATUS The complex type of the extended location.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20220301storageVirtualMachineStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary></summary>
    [JsonPropertyName("extensionsTimeBudget")]
    public string? ExtensionsTimeBudget { get; set; }

    /// <summary>Storage version of v1api20220301.HardwareProfile_STATUS Specifies the hardware settings for the virtual machine.</summary>
    [JsonPropertyName("hardwareProfile")]
    public V1api20220301storageVirtualMachineStatusHardwareProfile? HardwareProfile { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
    [JsonPropertyName("host")]
    public V1api20220301storageVirtualMachineStatusHost? Host { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
    [JsonPropertyName("hostGroup")]
    public V1api20220301storageVirtualMachineStatusHostGroup? HostGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineIdentity_STATUS Identity for the virtual machine.</summary>
    [JsonPropertyName("identity")]
    public V1api20220301storageVirtualMachineStatusIdentity? Identity { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachineInstanceView_STATUS The instance view of a virtual machine.</summary>
    [JsonPropertyName("instanceView")]
    public V1api20220301storageVirtualMachineStatusInstanceView? InstanceView { get; set; }

    /// <summary></summary>
    [JsonPropertyName("licenseType")]
    public string? LicenseType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Storage version of v1api20220301.NetworkProfile_STATUS Specifies the network interfaces or the networking configuration of the virtual machine.</summary>
    [JsonPropertyName("networkProfile")]
    public V1api20220301storageVirtualMachineStatusNetworkProfile? NetworkProfile { get; set; }

    /// <summary>Storage version of v1api20220301.OSProfile_STATUS Specifies the operating system settings for the virtual machine. Some of the settings cannot be changed once VM is provisioned.</summary>
    [JsonPropertyName("osProfile")]
    public V1api20220301storageVirtualMachineStatusOsProfile? OsProfile { get; set; }

    /// <summary>Storage version of v1api20220301.Plan_STATUS Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use. In the Azure portal, find the marketplace image that you want to use and then click Want to deploy programmatically, Get Started -&gt;. Enter any required information and then click Save.</summary>
    [JsonPropertyName("plan")]
    public V1api20220301storageVirtualMachineStatusPlan? Plan { get; set; }

    /// <summary></summary>
    [JsonPropertyName("platformFaultDomain")]
    public int? PlatformFaultDomain { get; set; }

    /// <summary></summary>
    [JsonPropertyName("priority")]
    public string? Priority { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
    [JsonPropertyName("proximityPlacementGroup")]
    public V1api20220301storageVirtualMachineStatusProximityPlacementGroup? ProximityPlacementGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resources")]
    public IList<V1api20220301storageVirtualMachineStatusResources>? Resources { get; set; }

    /// <summary>Storage version of v1api20220301.ScheduledEventsProfile_STATUS</summary>
    [JsonPropertyName("scheduledEventsProfile")]
    public V1api20220301storageVirtualMachineStatusScheduledEventsProfile? ScheduledEventsProfile { get; set; }

    /// <summary>Storage version of v1api20220301.SecurityProfile_STATUS Specifies the Security profile settings for the virtual machine or virtual machine scale set.</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20220301storageVirtualMachineStatusSecurityProfile? SecurityProfile { get; set; }

    /// <summary>Storage version of v1api20220301.StorageProfile_STATUS Specifies the storage settings for the virtual machine disks.</summary>
    [JsonPropertyName("storageProfile")]
    public V1api20220301storageVirtualMachineStatusStorageProfile? StorageProfile { get; set; }

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
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary>Storage version of v1api20220301.SubResource_STATUS</summary>
    [JsonPropertyName("virtualMachineScaleSet")]
    public V1api20220301storageVirtualMachineStatusVirtualMachineScaleSet? VirtualMachineScaleSet { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vmId")]
    public string? VmId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Storage version of v1api20220301.VirtualMachine Generator information: - Generated from: /compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-03-01/virtualMachine.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20220301storageVirtualMachine : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20220301storageVirtualMachineSpec>, IStatus<V1api20220301storageVirtualMachineStatus>
{
    public const string KubeApiVersion = "v1api20220301storage";
    public const string KubeKind = "VirtualMachine";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "virtualmachines";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachine_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20220301storageVirtualMachineSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20220301.VirtualMachine_STATUS Describes a Virtual Machine.</summary>
    [JsonPropertyName("status")]
    public V1api20220301storageVirtualMachineStatus? Status { get; set; }
}
#nullable disable
