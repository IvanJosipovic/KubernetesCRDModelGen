using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.upbound.io;
public enum V1beta1VPNSiteSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

/// <summary></summary>
public partial class V1beta1VPNSiteSpecForProviderLinkBgp
{
    /// <summary>The BGP speaker's ASN.</summary>
    [JsonPropertyName("asn")]
    public double? Asn { get; set; }

    /// <summary>The BGP peering IP address.</summary>
    [JsonPropertyName("peeringAddress")]
    public string? PeeringAddress { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNSiteSpecForProviderLink
{
    /// <summary>A bgp block as defined above.</summary>
    [JsonPropertyName("bgp")]
    public IList<V1beta1VPNSiteSpecForProviderLinkBgp>? Bgp { get; set; }

    /// <summary>The FQDN of this VPN Site Link.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>The IP address of this VPN Site Link.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The name which should be used for this VPN Site Link.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the physical link at the VPN Site. Example: ATT, Verizon.</summary>
    [JsonPropertyName("providerName")]
    public string? ProviderName { get; set; }

    /// <summary>The speed of the VPN device at the branch location in unit of mbps. Defaults to 0.</summary>
    [JsonPropertyName("speedInMbps")]
    public double? SpeedInMbps { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNSiteSpecForProviderO365PolicyTrafficCategory
{
    /// <summary>Is allow endpoint enabled? The Allow endpoint is required for connectivity to specific O365 services and features, but are not as sensitive to network performance and latency as other endpoint types. Defaults to false.</summary>
    [JsonPropertyName("allowEndpointEnabled")]
    public bool? AllowEndpointEnabled { get; set; }

    /// <summary>Is default endpoint enabled? The Default endpoint represents O365 services and dependencies that do not require any optimization, and can be treated by customer networks as normal Internet bound traffic. Defaults to false.</summary>
    [JsonPropertyName("defaultEndpointEnabled")]
    public bool? DefaultEndpointEnabled { get; set; }

    /// <summary>Is optimize endpoint enabled? The Optimize endpoint is required for connectivity to every O365 service and represents the O365 scenario that is the most sensitive to network performance, latency, and availability. Defaults to false.</summary>
    [JsonPropertyName("optimizeEndpointEnabled")]
    public bool? OptimizeEndpointEnabled { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNSiteSpecForProviderO365Policy
{
    /// <summary>A traffic_category block as defined above.</summary>
    [JsonPropertyName("trafficCategory")]
    public IList<V1beta1VPNSiteSpecForProviderO365PolicyTrafficCategory>? TrafficCategory { get; set; }
}

public enum V1beta1VPNSiteSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPNSiteSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VPNSiteSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNSiteSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
    public V1beta1VPNSiteSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNSiteSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
    public V1beta1VPNSiteSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1VPNSiteSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNSiteSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

public enum V1beta1VPNSiteSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPNSiteSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1VPNSiteSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNSiteSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
    public V1beta1VPNSiteSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNSiteSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
    public V1beta1VPNSiteSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
public partial class V1beta1VPNSiteSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNSiteSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

public enum V1beta1VPNSiteSpecForProviderVirtualWanIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPNSiteSpecForProviderVirtualWanIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VPNSiteSpecForProviderVirtualWanIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNSiteSpecForProviderVirtualWanIdRefPolicyResolutionEnum>))]
    public V1beta1VPNSiteSpecForProviderVirtualWanIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNSiteSpecForProviderVirtualWanIdRefPolicyResolveEnum>))]
    public V1beta1VPNSiteSpecForProviderVirtualWanIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VirtualWAN in network to populate virtualWanId.</summary>
public partial class V1beta1VPNSiteSpecForProviderVirtualWanIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNSiteSpecForProviderVirtualWanIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VPNSiteSpecForProviderVirtualWanIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPNSiteSpecForProviderVirtualWanIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1VPNSiteSpecForProviderVirtualWanIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNSiteSpecForProviderVirtualWanIdSelectorPolicyResolutionEnum>))]
    public V1beta1VPNSiteSpecForProviderVirtualWanIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNSiteSpecForProviderVirtualWanIdSelectorPolicyResolveEnum>))]
    public V1beta1VPNSiteSpecForProviderVirtualWanIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VirtualWAN in network to populate virtualWanId.</summary>
public partial class V1beta1VPNSiteSpecForProviderVirtualWanIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNSiteSpecForProviderVirtualWanIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNSiteSpecForProvider
{
    /// <summary>Specifies a list of IP address CIDRs that are located on your on-premises site. Traffic destined for these address spaces is routed to your local site.</summary>
    [JsonPropertyName("addressCidrs")]
    public IList<string>? AddressCidrs { get; set; }

    /// <summary>The model of the VPN device.</summary>
    [JsonPropertyName("deviceModel")]
    public string? DeviceModel { get; set; }

    /// <summary>The name of the VPN device vendor.</summary>
    [JsonPropertyName("deviceVendor")]
    public string? DeviceVendor { get; set; }

    /// <summary>One or more link blocks as defined below.</summary>
    [JsonPropertyName("link")]
    public IList<V1beta1VPNSiteSpecForProviderLink>? Link { get; set; }

    /// <summary>The Azure Region where the VPN Site should exist. Changing this forces a new VPN Site to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>An o365_policy block as defined below.</summary>
    [JsonPropertyName("o365Policy")]
    public IList<V1beta1VPNSiteSpecForProviderO365Policy>? O365Policy { get; set; }

    /// <summary>The name of the Resource Group where the VPN Site should exist. Changing this forces a new VPN Site to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1VPNSiteSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1VPNSiteSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of tags which should be assigned to the VPN Site.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The ID of the Virtual Wan where this VPN site resides in. Changing this forces a new VPN Site to be created.</summary>
    [JsonPropertyName("virtualWanId")]
    public string? VirtualWanId { get; set; }

    /// <summary>Reference to a VirtualWAN in network to populate virtualWanId.</summary>
    [JsonPropertyName("virtualWanIdRef")]
    public V1beta1VPNSiteSpecForProviderVirtualWanIdRef? VirtualWanIdRef { get; set; }

    /// <summary>Selector for a VirtualWAN in network to populate virtualWanId.</summary>
    [JsonPropertyName("virtualWanIdSelector")]
    public V1beta1VPNSiteSpecForProviderVirtualWanIdSelector? VirtualWanIdSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNSiteSpecInitProviderLinkBgp
{
    /// <summary>The BGP speaker's ASN.</summary>
    [JsonPropertyName("asn")]
    public double? Asn { get; set; }

    /// <summary>The BGP peering IP address.</summary>
    [JsonPropertyName("peeringAddress")]
    public string? PeeringAddress { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNSiteSpecInitProviderLink
{
    /// <summary>A bgp block as defined above.</summary>
    [JsonPropertyName("bgp")]
    public IList<V1beta1VPNSiteSpecInitProviderLinkBgp>? Bgp { get; set; }

    /// <summary>The FQDN of this VPN Site Link.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>The IP address of this VPN Site Link.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The name which should be used for this VPN Site Link.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the physical link at the VPN Site. Example: ATT, Verizon.</summary>
    [JsonPropertyName("providerName")]
    public string? ProviderName { get; set; }

    /// <summary>The speed of the VPN device at the branch location in unit of mbps. Defaults to 0.</summary>
    [JsonPropertyName("speedInMbps")]
    public double? SpeedInMbps { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNSiteSpecInitProviderO365PolicyTrafficCategory
{
    /// <summary>Is allow endpoint enabled? The Allow endpoint is required for connectivity to specific O365 services and features, but are not as sensitive to network performance and latency as other endpoint types. Defaults to false.</summary>
    [JsonPropertyName("allowEndpointEnabled")]
    public bool? AllowEndpointEnabled { get; set; }

    /// <summary>Is default endpoint enabled? The Default endpoint represents O365 services and dependencies that do not require any optimization, and can be treated by customer networks as normal Internet bound traffic. Defaults to false.</summary>
    [JsonPropertyName("defaultEndpointEnabled")]
    public bool? DefaultEndpointEnabled { get; set; }

    /// <summary>Is optimize endpoint enabled? The Optimize endpoint is required for connectivity to every O365 service and represents the O365 scenario that is the most sensitive to network performance, latency, and availability. Defaults to false.</summary>
    [JsonPropertyName("optimizeEndpointEnabled")]
    public bool? OptimizeEndpointEnabled { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNSiteSpecInitProviderO365Policy
{
    /// <summary>A traffic_category block as defined above.</summary>
    [JsonPropertyName("trafficCategory")]
    public IList<V1beta1VPNSiteSpecInitProviderO365PolicyTrafficCategory>? TrafficCategory { get; set; }
}

public enum V1beta1VPNSiteSpecInitProviderVirtualWanIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPNSiteSpecInitProviderVirtualWanIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VPNSiteSpecInitProviderVirtualWanIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNSiteSpecInitProviderVirtualWanIdRefPolicyResolutionEnum>))]
    public V1beta1VPNSiteSpecInitProviderVirtualWanIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNSiteSpecInitProviderVirtualWanIdRefPolicyResolveEnum>))]
    public V1beta1VPNSiteSpecInitProviderVirtualWanIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a VirtualWAN in network to populate virtualWanId.</summary>
public partial class V1beta1VPNSiteSpecInitProviderVirtualWanIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNSiteSpecInitProviderVirtualWanIdRefPolicy? Policy { get; set; }
}

public enum V1beta1VPNSiteSpecInitProviderVirtualWanIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPNSiteSpecInitProviderVirtualWanIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1VPNSiteSpecInitProviderVirtualWanIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNSiteSpecInitProviderVirtualWanIdSelectorPolicyResolutionEnum>))]
    public V1beta1VPNSiteSpecInitProviderVirtualWanIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNSiteSpecInitProviderVirtualWanIdSelectorPolicyResolveEnum>))]
    public V1beta1VPNSiteSpecInitProviderVirtualWanIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a VirtualWAN in network to populate virtualWanId.</summary>
public partial class V1beta1VPNSiteSpecInitProviderVirtualWanIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNSiteSpecInitProviderVirtualWanIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1VPNSiteSpecInitProvider
{
    /// <summary>Specifies a list of IP address CIDRs that are located on your on-premises site. Traffic destined for these address spaces is routed to your local site.</summary>
    [JsonPropertyName("addressCidrs")]
    public IList<string>? AddressCidrs { get; set; }

    /// <summary>The model of the VPN device.</summary>
    [JsonPropertyName("deviceModel")]
    public string? DeviceModel { get; set; }

    /// <summary>The name of the VPN device vendor.</summary>
    [JsonPropertyName("deviceVendor")]
    public string? DeviceVendor { get; set; }

    /// <summary>One or more link blocks as defined below.</summary>
    [JsonPropertyName("link")]
    public IList<V1beta1VPNSiteSpecInitProviderLink>? Link { get; set; }

    /// <summary>The Azure Region where the VPN Site should exist. Changing this forces a new VPN Site to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>An o365_policy block as defined below.</summary>
    [JsonPropertyName("o365Policy")]
    public IList<V1beta1VPNSiteSpecInitProviderO365Policy>? O365Policy { get; set; }

    /// <summary>A mapping of tags which should be assigned to the VPN Site.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The ID of the Virtual Wan where this VPN site resides in. Changing this forces a new VPN Site to be created.</summary>
    [JsonPropertyName("virtualWanId")]
    public string? VirtualWanId { get; set; }

    /// <summary>Reference to a VirtualWAN in network to populate virtualWanId.</summary>
    [JsonPropertyName("virtualWanIdRef")]
    public V1beta1VPNSiteSpecInitProviderVirtualWanIdRef? VirtualWanIdRef { get; set; }

    /// <summary>Selector for a VirtualWAN in network to populate virtualWanId.</summary>
    [JsonPropertyName("virtualWanIdSelector")]
    public V1beta1VPNSiteSpecInitProviderVirtualWanIdSelector? VirtualWanIdSelector { get; set; }
}

public enum V1beta1VPNSiteSpecManagementPoliciesEnum
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

public enum V1beta1VPNSiteSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPNSiteSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VPNSiteSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNSiteSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1VPNSiteSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNSiteSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1VPNSiteSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1VPNSiteSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNSiteSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1VPNSiteSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1VPNSiteSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1VPNSiteSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNSiteSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1VPNSiteSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNSiteSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1VPNSiteSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1VPNSiteSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNSiteSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1VPNSiteSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1VPNSiteSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1VPNSiteSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1VPNSiteSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1VPNSiteSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>VPNSiteSpec defines the desired state of VPNSite</summary>
public partial class V1beta1VPNSiteSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1VPNSiteSpecDeletionPolicyEnum>))]
    public V1beta1VPNSiteSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1VPNSiteSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1VPNSiteSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1VPNSiteSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1VPNSiteSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1VPNSiteSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1VPNSiteSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNSiteStatusAtProviderLinkBgp
{
    /// <summary>The BGP speaker's ASN.</summary>
    [JsonPropertyName("asn")]
    public double? Asn { get; set; }

    /// <summary>The BGP peering IP address.</summary>
    [JsonPropertyName("peeringAddress")]
    public string? PeeringAddress { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNSiteStatusAtProviderLink
{
    /// <summary>A bgp block as defined above.</summary>
    [JsonPropertyName("bgp")]
    public IList<V1beta1VPNSiteStatusAtProviderLinkBgp>? Bgp { get; set; }

    /// <summary>The FQDN of this VPN Site Link.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>The ID of the VPN Site Link.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The IP address of this VPN Site Link.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The name which should be used for this VPN Site Link.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The name of the physical link at the VPN Site. Example: ATT, Verizon.</summary>
    [JsonPropertyName("providerName")]
    public string? ProviderName { get; set; }

    /// <summary>The speed of the VPN device at the branch location in unit of mbps. Defaults to 0.</summary>
    [JsonPropertyName("speedInMbps")]
    public double? SpeedInMbps { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNSiteStatusAtProviderO365PolicyTrafficCategory
{
    /// <summary>Is allow endpoint enabled? The Allow endpoint is required for connectivity to specific O365 services and features, but are not as sensitive to network performance and latency as other endpoint types. Defaults to false.</summary>
    [JsonPropertyName("allowEndpointEnabled")]
    public bool? AllowEndpointEnabled { get; set; }

    /// <summary>Is default endpoint enabled? The Default endpoint represents O365 services and dependencies that do not require any optimization, and can be treated by customer networks as normal Internet bound traffic. Defaults to false.</summary>
    [JsonPropertyName("defaultEndpointEnabled")]
    public bool? DefaultEndpointEnabled { get; set; }

    /// <summary>Is optimize endpoint enabled? The Optimize endpoint is required for connectivity to every O365 service and represents the O365 scenario that is the most sensitive to network performance, latency, and availability. Defaults to false.</summary>
    [JsonPropertyName("optimizeEndpointEnabled")]
    public bool? OptimizeEndpointEnabled { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNSiteStatusAtProviderO365Policy
{
    /// <summary>A traffic_category block as defined above.</summary>
    [JsonPropertyName("trafficCategory")]
    public IList<V1beta1VPNSiteStatusAtProviderO365PolicyTrafficCategory>? TrafficCategory { get; set; }
}

/// <summary></summary>
public partial class V1beta1VPNSiteStatusAtProvider
{
    /// <summary>Specifies a list of IP address CIDRs that are located on your on-premises site. Traffic destined for these address spaces is routed to your local site.</summary>
    [JsonPropertyName("addressCidrs")]
    public IList<string>? AddressCidrs { get; set; }

    /// <summary>The model of the VPN device.</summary>
    [JsonPropertyName("deviceModel")]
    public string? DeviceModel { get; set; }

    /// <summary>The name of the VPN device vendor.</summary>
    [JsonPropertyName("deviceVendor")]
    public string? DeviceVendor { get; set; }

    /// <summary>The ID of the VPN Site.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>One or more link blocks as defined below.</summary>
    [JsonPropertyName("link")]
    public IList<V1beta1VPNSiteStatusAtProviderLink>? Link { get; set; }

    /// <summary>The Azure Region where the VPN Site should exist. Changing this forces a new VPN Site to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>An o365_policy block as defined below.</summary>
    [JsonPropertyName("o365Policy")]
    public IList<V1beta1VPNSiteStatusAtProviderO365Policy>? O365Policy { get; set; }

    /// <summary>The name of the Resource Group where the VPN Site should exist. Changing this forces a new VPN Site to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A mapping of tags which should be assigned to the VPN Site.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The ID of the Virtual Wan where this VPN site resides in. Changing this forces a new VPN Site to be created.</summary>
    [JsonPropertyName("virtualWanId")]
    public string? VirtualWanId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1VPNSiteStatusConditions
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

/// <summary>VPNSiteStatus defines the observed state of VPNSite.</summary>
public partial class V1beta1VPNSiteStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1VPNSiteStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VPNSiteStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>VPNSite is the Schema for the VPNSites API. Manages a VPN Site.</summary>
public partial class V1beta1VPNSite : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VPNSiteSpec>, IStatus<V1beta1VPNSiteStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VPNSite";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "vpnsites";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VPNSiteSpec defines the desired state of VPNSite</summary>
    [JsonPropertyName("spec")]
    public V1beta1VPNSiteSpec Spec { get; set; }

    /// <summary>VPNSiteStatus defines the observed state of VPNSite.</summary>
    [JsonPropertyName("status")]
    public V1beta1VPNSiteStatus? Status { get; set; }
}