using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.com;
/// <summary>Storage version of v1api20201101.IPConfigurationBgpPeeringAddress Properties of IPConfigurationBgpPeeringAddress.</summary>
public partial class V1api20201101storageVirtualNetworkGatewaySpecBgpSettingsBgpPeeringAddresses
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customBgpIpAddresses")]
    public IList<string>? CustomBgpIpAddresses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipconfigurationId")]
    public string? IpconfigurationId { get; set; }
}

/// <summary>Storage version of v1api20201101.BgpSettings BGP settings details.</summary>
public partial class V1api20201101storageVirtualNetworkGatewaySpecBgpSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("asn")]
    public int? Asn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bgpPeeringAddress")]
    public string? BgpPeeringAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bgpPeeringAddresses")]
    public IList<V1api20201101storageVirtualNetworkGatewaySpecBgpSettingsBgpPeeringAddresses>? BgpPeeringAddresses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("peerWeight")]
    public int? PeerWeight { get; set; }
}

/// <summary>Storage version of v1api20201101.AddressSpace AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
public partial class V1api20201101storageVirtualNetworkGatewaySpecCustomRoutes
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }
}

/// <summary>Storage version of v1api20201101.ExtendedLocation ExtendedLocation complex type.</summary>
public partial class V1api20201101storageVirtualNetworkGatewaySpecExtendedLocation
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

/// <summary>Reference: Resource ID.</summary>
public partial class V1api20201101storageVirtualNetworkGatewaySpecGatewayDefaultSiteReference
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

/// <summary>Storage version of v1api20201101.SubResource Reference to another subresource.</summary>
public partial class V1api20201101storageVirtualNetworkGatewaySpecGatewayDefaultSite
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101storageVirtualNetworkGatewaySpecGatewayDefaultSiteReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
public partial class V1api20201101storageVirtualNetworkGatewaySpecIpConfigurationsPublicIPAddressReference
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

/// <summary>Storage version of v1api20201101.SubResource Reference to another subresource.</summary>
public partial class V1api20201101storageVirtualNetworkGatewaySpecIpConfigurationsPublicIPAddress
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101storageVirtualNetworkGatewaySpecIpConfigurationsPublicIPAddressReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
public partial class V1api20201101storageVirtualNetworkGatewaySpecIpConfigurationsSubnetReference
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

/// <summary>Storage version of v1api20201101.SubResource Reference to another subresource.</summary>
public partial class V1api20201101storageVirtualNetworkGatewaySpecIpConfigurationsSubnet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20201101storageVirtualNetworkGatewaySpecIpConfigurationsSubnetReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20201101.VirtualNetworkGatewayIPConfiguration IP configuration for virtual network gateway.</summary>
public partial class V1api20201101storageVirtualNetworkGatewaySpecIpConfigurations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateIPAllocationMethod")]
    public string? PrivateIPAllocationMethod { get; set; }

    /// <summary>Storage version of v1api20201101.SubResource Reference to another subresource.</summary>
    [JsonPropertyName("publicIPAddress")]
    public V1api20201101storageVirtualNetworkGatewaySpecIpConfigurationsPublicIPAddress? PublicIPAddress { get; set; }

    /// <summary>Storage version of v1api20201101.SubResource Reference to another subresource.</summary>
    [JsonPropertyName("subnet")]
    public V1api20201101storageVirtualNetworkGatewaySpecIpConfigurationsSubnet? Subnet { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
public partial class V1api20201101storageVirtualNetworkGatewaySpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20201101.VirtualNetworkGatewaySku VirtualNetworkGatewaySku details.</summary>
public partial class V1api20201101storageVirtualNetworkGatewaySpecSku
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

/// <summary>VNetExtendedLocationResourceReference: Customer vnet resource id. VirtualNetworkGateway of type local gateway is associated with the customer vnet.</summary>
public partial class V1api20201101storageVirtualNetworkGatewaySpecVNetExtendedLocationResourceReference
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

/// <summary>Storage version of v1api20201101.RadiusServer Radius Server Settings.</summary>
public partial class V1api20201101storageVirtualNetworkGatewaySpecVpnClientConfigurationRadiusServers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("radiusServerAddress")]
    public string? RadiusServerAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("radiusServerScore")]
    public int? RadiusServerScore { get; set; }

    /// <summary></summary>
    [JsonPropertyName("radiusServerSecret")]
    public string? RadiusServerSecret { get; set; }
}

/// <summary>Storage version of v1api20201101.AddressSpace AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
public partial class V1api20201101storageVirtualNetworkGatewaySpecVpnClientConfigurationVpnClientAddressPool
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }
}

/// <summary>Storage version of v1api20201101.IpsecPolicy An IPSec Policy configuration for a virtual network gateway connection.</summary>
public partial class V1api20201101storageVirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPolicies
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dhGroup")]
    public string? DhGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ikeEncryption")]
    public string? IkeEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ikeIntegrity")]
    public string? IkeIntegrity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipsecEncryption")]
    public string? IpsecEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipsecIntegrity")]
    public string? IpsecIntegrity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pfsGroup")]
    public string? PfsGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("saDataSizeKilobytes")]
    public int? SaDataSizeKilobytes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("saLifeTimeSeconds")]
    public int? SaLifeTimeSeconds { get; set; }
}

/// <summary>Storage version of v1api20201101.VpnClientRevokedCertificate VPN client revoked certificate of virtual network gateway.</summary>
public partial class V1api20201101storageVirtualNetworkGatewaySpecVpnClientConfigurationVpnClientRevokedCertificates
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary>Storage version of v1api20201101.VpnClientRootCertificate VPN client root certificate of virtual network gateway.</summary>
public partial class V1api20201101storageVirtualNetworkGatewaySpecVpnClientConfigurationVpnClientRootCertificates
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicCertData")]
    public string? PublicCertData { get; set; }
}

/// <summary>Storage version of v1api20201101.VpnClientConfiguration VpnClientConfiguration for P2S client.</summary>
public partial class V1api20201101storageVirtualNetworkGatewaySpecVpnClientConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("aadAudience")]
    public string? AadAudience { get; set; }

    /// <summary></summary>
    [JsonPropertyName("aadIssuer")]
    public string? AadIssuer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("aadTenant")]
    public string? AadTenant { get; set; }

    /// <summary></summary>
    [JsonPropertyName("radiusServerAddress")]
    public string? RadiusServerAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("radiusServerSecret")]
    public string? RadiusServerSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("radiusServers")]
    public IList<V1api20201101storageVirtualNetworkGatewaySpecVpnClientConfigurationRadiusServers>? RadiusServers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpnAuthenticationTypes")]
    public IList<string>? VpnAuthenticationTypes { get; set; }

    /// <summary>Storage version of v1api20201101.AddressSpace AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
    [JsonPropertyName("vpnClientAddressPool")]
    public V1api20201101storageVirtualNetworkGatewaySpecVpnClientConfigurationVpnClientAddressPool? VpnClientAddressPool { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpnClientIpsecPolicies")]
    public IList<V1api20201101storageVirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPolicies>? VpnClientIpsecPolicies { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpnClientProtocols")]
    public IList<string>? VpnClientProtocols { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpnClientRevokedCertificates")]
    public IList<V1api20201101storageVirtualNetworkGatewaySpecVpnClientConfigurationVpnClientRevokedCertificates>? VpnClientRevokedCertificates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpnClientRootCertificates")]
    public IList<V1api20201101storageVirtualNetworkGatewaySpecVpnClientConfigurationVpnClientRootCertificates>? VpnClientRootCertificates { get; set; }
}

/// <summary>Storage version of v1api20201101.VirtualNetworkGateway_Spec</summary>
public partial class V1api20201101storageVirtualNetworkGatewaySpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("activeActive")]
    public bool? ActiveActive { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Storage version of v1api20201101.BgpSettings BGP settings details.</summary>
    [JsonPropertyName("bgpSettings")]
    public V1api20201101storageVirtualNetworkGatewaySpecBgpSettings? BgpSettings { get; set; }

    /// <summary>Storage version of v1api20201101.AddressSpace AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
    [JsonPropertyName("customRoutes")]
    public V1api20201101storageVirtualNetworkGatewaySpecCustomRoutes? CustomRoutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableBgp")]
    public bool? EnableBgp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableDnsForwarding")]
    public bool? EnableDnsForwarding { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enablePrivateIpAddress")]
    public bool? EnablePrivateIpAddress { get; set; }

    /// <summary>Storage version of v1api20201101.ExtendedLocation ExtendedLocation complex type.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20201101storageVirtualNetworkGatewaySpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>Storage version of v1api20201101.SubResource Reference to another subresource.</summary>
    [JsonPropertyName("gatewayDefaultSite")]
    public V1api20201101storageVirtualNetworkGatewaySpecGatewayDefaultSite? GatewayDefaultSite { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gatewayType")]
    public string? GatewayType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipConfigurations")]
    public IList<V1api20201101storageVirtualNetworkGatewaySpecIpConfigurations>? IpConfigurations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20201101storageVirtualNetworkGatewaySpecOwner Owner { get; set; }

    /// <summary>Storage version of v1api20201101.VirtualNetworkGatewaySku VirtualNetworkGatewaySku details.</summary>
    [JsonPropertyName("sku")]
    public V1api20201101storageVirtualNetworkGatewaySpecSku? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>VNetExtendedLocationResourceReference: Customer vnet resource id. VirtualNetworkGateway of type local gateway is associated with the customer vnet.</summary>
    [JsonPropertyName("vNetExtendedLocationResourceReference")]
    public V1api20201101storageVirtualNetworkGatewaySpecVNetExtendedLocationResourceReference? VNetExtendedLocationResourceReference { get; set; }

    /// <summary>Storage version of v1api20201101.VpnClientConfiguration VpnClientConfiguration for P2S client.</summary>
    [JsonPropertyName("vpnClientConfiguration")]
    public V1api20201101storageVirtualNetworkGatewaySpecVpnClientConfiguration? VpnClientConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpnGatewayGeneration")]
    public string? VpnGatewayGeneration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpnType")]
    public string? VpnType { get; set; }
}

/// <summary>Storage version of v1api20201101.IPConfigurationBgpPeeringAddress_STATUS Properties of IPConfigurationBgpPeeringAddress.</summary>
public partial class V1api20201101storageVirtualNetworkGatewayStatusBgpSettingsBgpPeeringAddresses
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("customBgpIpAddresses")]
    public IList<string>? CustomBgpIpAddresses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("defaultBgpIpAddresses")]
    public IList<string>? DefaultBgpIpAddresses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipconfigurationId")]
    public string? IpconfigurationId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tunnelIpAddresses")]
    public IList<string>? TunnelIpAddresses { get; set; }
}

/// <summary>Storage version of v1api20201101.BgpSettings_STATUS BGP settings details.</summary>
public partial class V1api20201101storageVirtualNetworkGatewayStatusBgpSettings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("asn")]
    public int? Asn { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bgpPeeringAddress")]
    public string? BgpPeeringAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("bgpPeeringAddresses")]
    public IList<V1api20201101storageVirtualNetworkGatewayStatusBgpSettingsBgpPeeringAddresses>? BgpPeeringAddresses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("peerWeight")]
    public int? PeerWeight { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
public partial class V1api20201101storageVirtualNetworkGatewayStatusConditions
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

/// <summary>Storage version of v1api20201101.AddressSpace_STATUS AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
public partial class V1api20201101storageVirtualNetworkGatewayStatusCustomRoutes
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }
}

/// <summary>Storage version of v1api20201101.ExtendedLocation_STATUS ExtendedLocation complex type.</summary>
public partial class V1api20201101storageVirtualNetworkGatewayStatusExtendedLocation
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

/// <summary>Storage version of v1api20201101.SubResource_STATUS Reference to another subresource.</summary>
public partial class V1api20201101storageVirtualNetworkGatewayStatusGatewayDefaultSite
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20201101.SubResource_STATUS Reference to another subresource.</summary>
public partial class V1api20201101storageVirtualNetworkGatewayStatusIpConfigurationsPublicIPAddress
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20201101.SubResource_STATUS Reference to another subresource.</summary>
public partial class V1api20201101storageVirtualNetworkGatewayStatusIpConfigurationsSubnet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20201101.VirtualNetworkGatewayIPConfiguration_STATUS IP configuration for virtual network gateway.</summary>
public partial class V1api20201101storageVirtualNetworkGatewayStatusIpConfigurations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateIPAddress")]
    public string? PrivateIPAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("privateIPAllocationMethod")]
    public string? PrivateIPAllocationMethod { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>Storage version of v1api20201101.SubResource_STATUS Reference to another subresource.</summary>
    [JsonPropertyName("publicIPAddress")]
    public V1api20201101storageVirtualNetworkGatewayStatusIpConfigurationsPublicIPAddress? PublicIPAddress { get; set; }

    /// <summary>Storage version of v1api20201101.SubResource_STATUS Reference to another subresource.</summary>
    [JsonPropertyName("subnet")]
    public V1api20201101storageVirtualNetworkGatewayStatusIpConfigurationsSubnet? Subnet { get; set; }
}

/// <summary>Storage version of v1api20201101.VirtualNetworkGatewaySku_STATUS VirtualNetworkGatewaySku details.</summary>
public partial class V1api20201101storageVirtualNetworkGatewayStatusSku
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

/// <summary>Storage version of v1api20201101.RadiusServer_STATUS Radius Server Settings.</summary>
public partial class V1api20201101storageVirtualNetworkGatewayStatusVpnClientConfigurationRadiusServers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("radiusServerAddress")]
    public string? RadiusServerAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("radiusServerScore")]
    public int? RadiusServerScore { get; set; }

    /// <summary></summary>
    [JsonPropertyName("radiusServerSecret")]
    public string? RadiusServerSecret { get; set; }
}

/// <summary>Storage version of v1api20201101.AddressSpace_STATUS AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
public partial class V1api20201101storageVirtualNetworkGatewayStatusVpnClientConfigurationVpnClientAddressPool
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }
}

/// <summary>Storage version of v1api20201101.IpsecPolicy_STATUS An IPSec Policy configuration for a virtual network gateway connection.</summary>
public partial class V1api20201101storageVirtualNetworkGatewayStatusVpnClientConfigurationVpnClientIpsecPolicies
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("dhGroup")]
    public string? DhGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ikeEncryption")]
    public string? IkeEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ikeIntegrity")]
    public string? IkeIntegrity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipsecEncryption")]
    public string? IpsecEncryption { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipsecIntegrity")]
    public string? IpsecIntegrity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("pfsGroup")]
    public string? PfsGroup { get; set; }

    /// <summary></summary>
    [JsonPropertyName("saDataSizeKilobytes")]
    public int? SaDataSizeKilobytes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("saLifeTimeSeconds")]
    public int? SaLifeTimeSeconds { get; set; }
}

/// <summary>Storage version of v1api20201101.VpnClientRevokedCertificate_STATUS VPN client revoked certificate of virtual network gateway.</summary>
public partial class V1api20201101storageVirtualNetworkGatewayStatusVpnClientConfigurationVpnClientRevokedCertificates
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

/// <summary>Storage version of v1api20201101.VpnClientRootCertificate_STATUS VPN client root certificate of virtual network gateway.</summary>
public partial class V1api20201101storageVirtualNetworkGatewayStatusVpnClientConfigurationVpnClientRootCertificates
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("publicCertData")]
    public string? PublicCertData { get; set; }
}

/// <summary>Storage version of v1api20201101.VpnClientConfiguration_STATUS VpnClientConfiguration for P2S client.</summary>
public partial class V1api20201101storageVirtualNetworkGatewayStatusVpnClientConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("aadAudience")]
    public string? AadAudience { get; set; }

    /// <summary></summary>
    [JsonPropertyName("aadIssuer")]
    public string? AadIssuer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("aadTenant")]
    public string? AadTenant { get; set; }

    /// <summary></summary>
    [JsonPropertyName("radiusServerAddress")]
    public string? RadiusServerAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("radiusServerSecret")]
    public string? RadiusServerSecret { get; set; }

    /// <summary></summary>
    [JsonPropertyName("radiusServers")]
    public IList<V1api20201101storageVirtualNetworkGatewayStatusVpnClientConfigurationRadiusServers>? RadiusServers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpnAuthenticationTypes")]
    public IList<string>? VpnAuthenticationTypes { get; set; }

    /// <summary>Storage version of v1api20201101.AddressSpace_STATUS AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
    [JsonPropertyName("vpnClientAddressPool")]
    public V1api20201101storageVirtualNetworkGatewayStatusVpnClientConfigurationVpnClientAddressPool? VpnClientAddressPool { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpnClientIpsecPolicies")]
    public IList<V1api20201101storageVirtualNetworkGatewayStatusVpnClientConfigurationVpnClientIpsecPolicies>? VpnClientIpsecPolicies { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpnClientProtocols")]
    public IList<string>? VpnClientProtocols { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpnClientRevokedCertificates")]
    public IList<V1api20201101storageVirtualNetworkGatewayStatusVpnClientConfigurationVpnClientRevokedCertificates>? VpnClientRevokedCertificates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpnClientRootCertificates")]
    public IList<V1api20201101storageVirtualNetworkGatewayStatusVpnClientConfigurationVpnClientRootCertificates>? VpnClientRootCertificates { get; set; }
}

/// <summary>Storage version of v1api20201101.VirtualNetworkGateway_STATUS A common class for general resource information.</summary>
public partial class V1api20201101storageVirtualNetworkGatewayStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("activeActive")]
    public bool? ActiveActive { get; set; }

    /// <summary>Storage version of v1api20201101.BgpSettings_STATUS BGP settings details.</summary>
    [JsonPropertyName("bgpSettings")]
    public V1api20201101storageVirtualNetworkGatewayStatusBgpSettings? BgpSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20201101storageVirtualNetworkGatewayStatusConditions>? Conditions { get; set; }

    /// <summary>Storage version of v1api20201101.AddressSpace_STATUS AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
    [JsonPropertyName("customRoutes")]
    public V1api20201101storageVirtualNetworkGatewayStatusCustomRoutes? CustomRoutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableBgp")]
    public bool? EnableBgp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableDnsForwarding")]
    public bool? EnableDnsForwarding { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enablePrivateIpAddress")]
    public bool? EnablePrivateIpAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Storage version of v1api20201101.ExtendedLocation_STATUS ExtendedLocation complex type.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20201101storageVirtualNetworkGatewayStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>Storage version of v1api20201101.SubResource_STATUS Reference to another subresource.</summary>
    [JsonPropertyName("gatewayDefaultSite")]
    public V1api20201101storageVirtualNetworkGatewayStatusGatewayDefaultSite? GatewayDefaultSite { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gatewayType")]
    public string? GatewayType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("inboundDnsForwardingEndpoint")]
    public string? InboundDnsForwardingEndpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipConfigurations")]
    public IList<V1api20201101storageVirtualNetworkGatewayStatusIpConfigurations>? IpConfigurations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceGuid")]
    public string? ResourceGuid { get; set; }

    /// <summary>Storage version of v1api20201101.VirtualNetworkGatewaySku_STATUS VirtualNetworkGatewaySku details.</summary>
    [JsonPropertyName("sku")]
    public V1api20201101storageVirtualNetworkGatewayStatusSku? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vNetExtendedLocationResourceId")]
    public string? VNetExtendedLocationResourceId { get; set; }

    /// <summary>Storage version of v1api20201101.VpnClientConfiguration_STATUS VpnClientConfiguration for P2S client.</summary>
    [JsonPropertyName("vpnClientConfiguration")]
    public V1api20201101storageVirtualNetworkGatewayStatusVpnClientConfiguration? VpnClientConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpnGatewayGeneration")]
    public string? VpnGatewayGeneration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpnType")]
    public string? VpnType { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>Storage version of v1api20201101.VirtualNetworkGateway Generator information: - Generated from: /network/resource-manager/Microsoft.Network/stable/2020-11-01/virtualNetworkGateway.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkGateways/{virtualNetworkGatewayName}</summary>
public partial class V1api20201101storageVirtualNetworkGateway : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20201101storageVirtualNetworkGatewaySpec>, IStatus<V1api20201101storageVirtualNetworkGatewayStatus>
{
    public const string KubeApiVersion = "v1api20201101storage";
    public const string KubeKind = "VirtualNetworkGateway";
    public const string KubeGroup = "network.azure.com";
    public const string KubePluralName = "virtualnetworkgateways";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20201101.VirtualNetworkGateway_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20201101storageVirtualNetworkGatewaySpec? Spec { get; set; }

    /// <summary>Storage version of v1api20201101.VirtualNetworkGateway_STATUS A common class for general resource information.</summary>
    [JsonPropertyName("status")]
    public V1api20201101storageVirtualNetworkGatewayStatus? Status { get; set; }
}