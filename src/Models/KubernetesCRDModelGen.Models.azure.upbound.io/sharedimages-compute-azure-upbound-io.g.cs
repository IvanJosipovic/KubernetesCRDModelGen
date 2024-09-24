using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.azure.upbound.io;
public enum V1beta1SharedImageSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1SharedImageSpecForProviderGalleryNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SharedImageSpecForProviderGalleryNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SharedImageSpecForProviderGalleryNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SharedImageSpecForProviderGalleryNameRefPolicyResolutionEnum>))]
    public V1beta1SharedImageSpecForProviderGalleryNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SharedImageSpecForProviderGalleryNameRefPolicyResolveEnum>))]
    public V1beta1SharedImageSpecForProviderGalleryNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SharedImageSpecForProviderGalleryNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SharedImageSpecForProviderGalleryNameRefPolicy? Policy { get; set; }
}

public enum V1beta1SharedImageSpecForProviderGalleryNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SharedImageSpecForProviderGalleryNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SharedImageSpecForProviderGalleryNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SharedImageSpecForProviderGalleryNameSelectorPolicyResolutionEnum>))]
    public V1beta1SharedImageSpecForProviderGalleryNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SharedImageSpecForProviderGalleryNameSelectorPolicyResolveEnum>))]
    public V1beta1SharedImageSpecForProviderGalleryNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SharedImageSpecForProviderGalleryNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SharedImageSpecForProviderGalleryNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1SharedImageSpecForProviderIdentifier
{
    /// <summary>The Offer Name for this Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("offer")]
    public string? Offer { get; set; }

    /// <summary>The Publisher Name for this Gallery Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>The Name of the SKU for this Gallery Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }
}

public partial class V1beta1SharedImageSpecForProviderPurchasePlan
{
    /// <summary>The Purchase Plan Name for this Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Purchase Plan Product for this Gallery Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary>The Purchase Plan Publisher for this Gallery Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}

public enum V1beta1SharedImageSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SharedImageSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SharedImageSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SharedImageSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1SharedImageSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SharedImageSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1SharedImageSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SharedImageSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SharedImageSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1SharedImageSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SharedImageSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SharedImageSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SharedImageSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1SharedImageSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SharedImageSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1SharedImageSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SharedImageSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SharedImageSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

public partial class V1beta1SharedImageSpecForProvider
{
    /// <summary>Specifies if the Shared Image supports Accelerated Network. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("acceleratedNetworkSupportEnabled")]
    public bool? AcceleratedNetworkSupportEnabled { get; set; }

    /// <summary>CPU architecture supported by an OS. Possible values are x64 and Arm64. Defaults to x64. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary>Specifies if Confidential Virtual Machines enabled. It will enable all the features of trusted, with higher confidentiality features for isolate machines or encrypted data. Available for Gen2 machines. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("confidentialVmEnabled")]
    public bool? ConfidentialVmEnabled { get; set; }

    /// <summary>Specifies if supports creation of both Confidential virtual machines and Gen2 virtual machines with standard security from a compatible Gen2 OS disk VHD or Gen2 Managed image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("confidentialVmSupported")]
    public bool? ConfidentialVmSupported { get; set; }

    /// <summary>A description of this Shared Image.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more Disk Types not allowed for the Image. Possible values include Standard_LRS and Premium_LRS.</summary>
    [JsonPropertyName("diskTypesNotAllowed")]
    public IList<string>? DiskTypesNotAllowed { get; set; }

    /// <summary>The end of life date in RFC3339 format of the Image.</summary>
    [JsonPropertyName("endOfLifeDate")]
    public string? EndOfLifeDate { get; set; }

    /// <summary>The End User Licence Agreement for the Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eula")]
    public string? Eula { get; set; }

    /// <summary>Specifies the name of the Shared Image Gallery in which this Shared Image should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("galleryName")]
    public string? GalleryName { get; set; }

    /// <summary>Reference to a SharedImageGallery in compute to populate galleryName.</summary>
    [JsonPropertyName("galleryNameRef")]
    public V1beta1SharedImageSpecForProviderGalleryNameRef? GalleryNameRef { get; set; }

    /// <summary>Selector for a SharedImageGallery in compute to populate galleryName.</summary>
    [JsonPropertyName("galleryNameSelector")]
    public V1beta1SharedImageSpecForProviderGalleryNameSelector? GalleryNameSelector { get; set; }

    /// <summary>The generation of HyperV that the Virtual Machine used to create the Shared Image is based on. Possible values are V1 and V2. Defaults to V1. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hyperVGeneration")]
    public string? HyperVGeneration { get; set; }

    /// <summary>An identifier block as defined below.</summary>
    [JsonPropertyName("identifier")]
    public IList<V1beta1SharedImageSpecForProviderIdentifier>? Identifier { get; set; }

    /// <summary>Specifies the supported Azure location where the Shared Image Gallery exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Maximum memory in GB recommended for the Image.</summary>
    [JsonPropertyName("maxRecommendedMemoryInGb")]
    public double? MaxRecommendedMemoryInGb { get; set; }

    /// <summary>Maximum count of vCPUs recommended for the Image.</summary>
    [JsonPropertyName("maxRecommendedVcpuCount")]
    public double? MaxRecommendedVcpuCount { get; set; }

    /// <summary>Minimum memory in GB recommended for the Image.</summary>
    [JsonPropertyName("minRecommendedMemoryInGb")]
    public double? MinRecommendedMemoryInGb { get; set; }

    /// <summary>Minimum count of vCPUs recommended for the Image.</summary>
    [JsonPropertyName("minRecommendedVcpuCount")]
    public double? MinRecommendedVcpuCount { get; set; }

    /// <summary>The type of Operating System present in this Shared Image. Possible values are Linux and Windows. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>The URI containing the Privacy Statement associated with this Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privacyStatementUri")]
    public string? PrivacyStatementUri { get; set; }

    /// <summary>A purchase_plan block as defined below.</summary>
    [JsonPropertyName("purchasePlan")]
    public IList<V1beta1SharedImageSpecForProviderPurchasePlan>? PurchasePlan { get; set; }

    /// <summary>The URI containing the Release Notes associated with this Shared Image.</summary>
    [JsonPropertyName("releaseNoteUri")]
    public string? ReleaseNoteUri { get; set; }

    /// <summary>The name of the resource group in which the Shared Image Gallery exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1SharedImageSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1SharedImageSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Specifies that the Operating System used inside this Image has not been Generalized (for example, sysprep on Windows has not been run). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("specialized")]
    public bool? Specialized { get; set; }

    /// <summary>A mapping of tags to assign to the Shared Image.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies if Trusted Launch has to be enabled for the Virtual Machine created from the Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("trustedLaunchEnabled")]
    public bool? TrustedLaunchEnabled { get; set; }

    /// <summary>Specifies if supports creation of both Trusted Launch virtual machines and Gen2 virtual machines with standard security created from the Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("trustedLaunchSupported")]
    public bool? TrustedLaunchSupported { get; set; }
}

public partial class V1beta1SharedImageSpecInitProviderIdentifier
{
    /// <summary>The Offer Name for this Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("offer")]
    public string? Offer { get; set; }

    /// <summary>The Publisher Name for this Gallery Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>The Name of the SKU for this Gallery Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }
}

public partial class V1beta1SharedImageSpecInitProviderPurchasePlan
{
    /// <summary>The Purchase Plan Name for this Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Purchase Plan Product for this Gallery Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary>The Purchase Plan Publisher for this Gallery Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}

public partial class V1beta1SharedImageSpecInitProvider
{
    /// <summary>Specifies if the Shared Image supports Accelerated Network. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("acceleratedNetworkSupportEnabled")]
    public bool? AcceleratedNetworkSupportEnabled { get; set; }

    /// <summary>CPU architecture supported by an OS. Possible values are x64 and Arm64. Defaults to x64. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary>Specifies if Confidential Virtual Machines enabled. It will enable all the features of trusted, with higher confidentiality features for isolate machines or encrypted data. Available for Gen2 machines. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("confidentialVmEnabled")]
    public bool? ConfidentialVmEnabled { get; set; }

    /// <summary>Specifies if supports creation of both Confidential virtual machines and Gen2 virtual machines with standard security from a compatible Gen2 OS disk VHD or Gen2 Managed image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("confidentialVmSupported")]
    public bool? ConfidentialVmSupported { get; set; }

    /// <summary>A description of this Shared Image.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more Disk Types not allowed for the Image. Possible values include Standard_LRS and Premium_LRS.</summary>
    [JsonPropertyName("diskTypesNotAllowed")]
    public IList<string>? DiskTypesNotAllowed { get; set; }

    /// <summary>The end of life date in RFC3339 format of the Image.</summary>
    [JsonPropertyName("endOfLifeDate")]
    public string? EndOfLifeDate { get; set; }

    /// <summary>The End User Licence Agreement for the Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eula")]
    public string? Eula { get; set; }

    /// <summary>The generation of HyperV that the Virtual Machine used to create the Shared Image is based on. Possible values are V1 and V2. Defaults to V1. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hyperVGeneration")]
    public string? HyperVGeneration { get; set; }

    /// <summary>An identifier block as defined below.</summary>
    [JsonPropertyName("identifier")]
    public IList<V1beta1SharedImageSpecInitProviderIdentifier>? Identifier { get; set; }

    /// <summary>Specifies the supported Azure location where the Shared Image Gallery exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Maximum memory in GB recommended for the Image.</summary>
    [JsonPropertyName("maxRecommendedMemoryInGb")]
    public double? MaxRecommendedMemoryInGb { get; set; }

    /// <summary>Maximum count of vCPUs recommended for the Image.</summary>
    [JsonPropertyName("maxRecommendedVcpuCount")]
    public double? MaxRecommendedVcpuCount { get; set; }

    /// <summary>Minimum memory in GB recommended for the Image.</summary>
    [JsonPropertyName("minRecommendedMemoryInGb")]
    public double? MinRecommendedMemoryInGb { get; set; }

    /// <summary>Minimum count of vCPUs recommended for the Image.</summary>
    [JsonPropertyName("minRecommendedVcpuCount")]
    public double? MinRecommendedVcpuCount { get; set; }

    /// <summary>The type of Operating System present in this Shared Image. Possible values are Linux and Windows. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>The URI containing the Privacy Statement associated with this Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privacyStatementUri")]
    public string? PrivacyStatementUri { get; set; }

    /// <summary>A purchase_plan block as defined below.</summary>
    [JsonPropertyName("purchasePlan")]
    public IList<V1beta1SharedImageSpecInitProviderPurchasePlan>? PurchasePlan { get; set; }

    /// <summary>The URI containing the Release Notes associated with this Shared Image.</summary>
    [JsonPropertyName("releaseNoteUri")]
    public string? ReleaseNoteUri { get; set; }

    /// <summary>Specifies that the Operating System used inside this Image has not been Generalized (for example, sysprep on Windows has not been run). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("specialized")]
    public bool? Specialized { get; set; }

    /// <summary>A mapping of tags to assign to the Shared Image.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies if Trusted Launch has to be enabled for the Virtual Machine created from the Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("trustedLaunchEnabled")]
    public bool? TrustedLaunchEnabled { get; set; }

    /// <summary>Specifies if supports creation of both Trusted Launch virtual machines and Gen2 virtual machines with standard security created from the Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("trustedLaunchSupported")]
    public bool? TrustedLaunchSupported { get; set; }
}

public enum V1beta1SharedImageSpecManagementPoliciesEnum
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

public enum V1beta1SharedImageSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SharedImageSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SharedImageSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SharedImageSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1SharedImageSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SharedImageSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1SharedImageSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SharedImageSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SharedImageSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1SharedImageSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1SharedImageSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

public partial class V1beta1SharedImageSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SharedImageSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1SharedImageSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SharedImageSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1SharedImageSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

public partial class V1beta1SharedImageSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SharedImageSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

public partial class V1beta1SharedImageSpecPublishConnectionDetailsToMetadata
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

public partial class V1beta1SharedImageSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1SharedImageSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1SharedImageSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1SharedImageSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

public partial class V1beta1SharedImageSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1SharedImageSpecDeletionPolicyEnum>))]
    public V1beta1SharedImageSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1SharedImageSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1SharedImageSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1SharedImageSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SharedImageSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1SharedImageSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SharedImageSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

public partial class V1beta1SharedImageStatusAtProviderIdentifier
{
    /// <summary>The Offer Name for this Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("offer")]
    public string? Offer { get; set; }

    /// <summary>The Publisher Name for this Gallery Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>The Name of the SKU for this Gallery Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }
}

public partial class V1beta1SharedImageStatusAtProviderPurchasePlan
{
    /// <summary>The Purchase Plan Name for this Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Purchase Plan Product for this Gallery Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary>The Purchase Plan Publisher for this Gallery Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}

public partial class V1beta1SharedImageStatusAtProvider
{
    /// <summary>Specifies if the Shared Image supports Accelerated Network. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("acceleratedNetworkSupportEnabled")]
    public bool? AcceleratedNetworkSupportEnabled { get; set; }

    /// <summary>CPU architecture supported by an OS. Possible values are x64 and Arm64. Defaults to x64. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary>Specifies if Confidential Virtual Machines enabled. It will enable all the features of trusted, with higher confidentiality features for isolate machines or encrypted data. Available for Gen2 machines. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("confidentialVmEnabled")]
    public bool? ConfidentialVmEnabled { get; set; }

    /// <summary>Specifies if supports creation of both Confidential virtual machines and Gen2 virtual machines with standard security from a compatible Gen2 OS disk VHD or Gen2 Managed image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("confidentialVmSupported")]
    public bool? ConfidentialVmSupported { get; set; }

    /// <summary>A description of this Shared Image.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>One or more Disk Types not allowed for the Image. Possible values include Standard_LRS and Premium_LRS.</summary>
    [JsonPropertyName("diskTypesNotAllowed")]
    public IList<string>? DiskTypesNotAllowed { get; set; }

    /// <summary>The end of life date in RFC3339 format of the Image.</summary>
    [JsonPropertyName("endOfLifeDate")]
    public string? EndOfLifeDate { get; set; }

    /// <summary>The End User Licence Agreement for the Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eula")]
    public string? Eula { get; set; }

    /// <summary>Specifies the name of the Shared Image Gallery in which this Shared Image should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("galleryName")]
    public string? GalleryName { get; set; }

    /// <summary>The generation of HyperV that the Virtual Machine used to create the Shared Image is based on. Possible values are V1 and V2. Defaults to V1. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hyperVGeneration")]
    public string? HyperVGeneration { get; set; }

    /// <summary>The ID of the Shared Image.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identifier block as defined below.</summary>
    [JsonPropertyName("identifier")]
    public IList<V1beta1SharedImageStatusAtProviderIdentifier>? Identifier { get; set; }

    /// <summary>Specifies the supported Azure location where the Shared Image Gallery exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Maximum memory in GB recommended for the Image.</summary>
    [JsonPropertyName("maxRecommendedMemoryInGb")]
    public double? MaxRecommendedMemoryInGb { get; set; }

    /// <summary>Maximum count of vCPUs recommended for the Image.</summary>
    [JsonPropertyName("maxRecommendedVcpuCount")]
    public double? MaxRecommendedVcpuCount { get; set; }

    /// <summary>Minimum memory in GB recommended for the Image.</summary>
    [JsonPropertyName("minRecommendedMemoryInGb")]
    public double? MinRecommendedMemoryInGb { get; set; }

    /// <summary>Minimum count of vCPUs recommended for the Image.</summary>
    [JsonPropertyName("minRecommendedVcpuCount")]
    public double? MinRecommendedVcpuCount { get; set; }

    /// <summary>The type of Operating System present in this Shared Image. Possible values are Linux and Windows. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>The URI containing the Privacy Statement associated with this Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privacyStatementUri")]
    public string? PrivacyStatementUri { get; set; }

    /// <summary>A purchase_plan block as defined below.</summary>
    [JsonPropertyName("purchasePlan")]
    public IList<V1beta1SharedImageStatusAtProviderPurchasePlan>? PurchasePlan { get; set; }

    /// <summary>The URI containing the Release Notes associated with this Shared Image.</summary>
    [JsonPropertyName("releaseNoteUri")]
    public string? ReleaseNoteUri { get; set; }

    /// <summary>The name of the resource group in which the Shared Image Gallery exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Specifies that the Operating System used inside this Image has not been Generalized (for example, sysprep on Windows has not been run). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("specialized")]
    public bool? Specialized { get; set; }

    /// <summary>A mapping of tags to assign to the Shared Image.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies if Trusted Launch has to be enabled for the Virtual Machine created from the Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("trustedLaunchEnabled")]
    public bool? TrustedLaunchEnabled { get; set; }

    /// <summary>Specifies if supports creation of both Trusted Launch virtual machines and Gen2 virtual machines with standard security created from the Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("trustedLaunchSupported")]
    public bool? TrustedLaunchSupported { get; set; }
}

public partial class V1beta1SharedImageStatusConditions
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

public partial class V1beta1SharedImageStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1SharedImageStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SharedImageStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SharedImage : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SharedImageSpec>, IStatus<V1beta1SharedImageStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SharedImage";
    public const string KubeGroup = "compute.azure.upbound.io";
    public const string KubePluralName = "sharedimages";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SharedImageSpec defines the desired state of SharedImage</summary>
    [JsonPropertyName("spec")]
    public V1beta1SharedImageSpec Spec { get; set; }

    /// <summary>SharedImageStatus defines the observed state of SharedImage.</summary>
    [JsonPropertyName("status")]
    public V1beta1SharedImageStatus? Status { get; set; }
}