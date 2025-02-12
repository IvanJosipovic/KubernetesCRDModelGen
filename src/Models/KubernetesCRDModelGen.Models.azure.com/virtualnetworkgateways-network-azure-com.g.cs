using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.com;
/// <summary>Storage version of v1api20240301.VirtualNetworkGatewayAutoScaleBounds</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecAutoScaleConfigurationBounds
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("max")]
    public int? Max { get; set; }

    /// <summary></summary>
    [JsonPropertyName("min")]
    public int? Min { get; set; }
}

/// <summary>Storage version of v1api20240301.VirtualNetworkGatewayAutoScaleConfiguration Virtual Network Gateway Autoscale Configuration details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecAutoScaleConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240301.VirtualNetworkGatewayAutoScaleBounds</summary>
    [JsonPropertyName("bounds")]
    public V1api20240301storageVirtualNetworkGatewaySpecAutoScaleConfigurationBounds? Bounds { get; set; }
}

/// <summary>Storage version of v1api20240301.IPConfigurationBgpPeeringAddress Properties of IPConfigurationBgpPeeringAddress.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecBgpSettingsBgpPeeringAddresses
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

/// <summary>Storage version of v1api20240301.BgpSettings BGP settings details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecBgpSettings
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
    public IList<V1api20240301storageVirtualNetworkGatewaySpecBgpSettingsBgpPeeringAddresses>? BgpPeeringAddresses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("peerWeight")]
    public int? PeerWeight { get; set; }
}

/// <summary>Storage version of v1api20240301.AddressSpace AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecCustomRoutes
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }
}

/// <summary>Storage version of v1api20240301.ExtendedLocation ExtendedLocation complex type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecExtendedLocation
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecGatewayDefaultSiteReference
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

/// <summary>Storage version of v1api20240301.SubResource Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecGatewayDefaultSite
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301storageVirtualNetworkGatewaySpecGatewayDefaultSiteReference? Reference { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecIdentityUserAssignedIdentitiesReference
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

/// <summary>Storage version of v1api20240301.UserAssignedIdentityDetails Information about the user assigned identity for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecIdentityUserAssignedIdentities
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID nolint:recvcheck</summary>
    [JsonPropertyName("reference")]
    public V1api20240301storageVirtualNetworkGatewaySpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20240301.ManagedServiceIdentity Identity for the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecIdentity
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20240301storageVirtualNetworkGatewaySpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecIpConfigurationsPublicIPAddressReference
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

/// <summary>Storage version of v1api20240301.SubResource Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecIpConfigurationsPublicIPAddress
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301storageVirtualNetworkGatewaySpecIpConfigurationsPublicIPAddressReference? Reference { get; set; }
}

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecIpConfigurationsSubnetReference
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

/// <summary>Storage version of v1api20240301.SubResource Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecIpConfigurationsSubnet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301storageVirtualNetworkGatewaySpecIpConfigurationsSubnetReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20240301.VirtualNetworkGatewayIPConfiguration IP configuration for virtual network gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecIpConfigurations
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

    /// <summary>Storage version of v1api20240301.SubResource Reference to another subresource.</summary>
    [JsonPropertyName("publicIPAddress")]
    public V1api20240301storageVirtualNetworkGatewaySpecIpConfigurationsPublicIPAddress? PublicIPAddress { get; set; }

    /// <summary>Storage version of v1api20240301.SubResource Reference to another subresource.</summary>
    [JsonPropertyName("subnet")]
    public V1api20240301storageVirtualNetworkGatewaySpecIpConfigurationsSubnet? Subnet { get; set; }
}

/// <summary>Storage version of v1api20240301.VpnNatRuleMapping Vpn NatRule mapping.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecNatRulesExternalMappings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("addressSpace")]
    public string? AddressSpace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("portRange")]
    public string? PortRange { get; set; }
}

/// <summary>Storage version of v1api20240301.VpnNatRuleMapping Vpn NatRule mapping.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecNatRulesInternalMappings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("addressSpace")]
    public string? AddressSpace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("portRange")]
    public string? PortRange { get; set; }
}

/// <summary>Storage version of v1api20240301.VirtualNetworkGatewayNatRule VirtualNetworkGatewayNatRule Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecNatRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("externalMappings")]
    public IList<V1api20240301storageVirtualNetworkGatewaySpecNatRulesExternalMappings>? ExternalMappings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("internalMappings")]
    public IList<V1api20240301storageVirtualNetworkGatewaySpecNatRulesInternalMappings>? InternalMappings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipConfigurationId")]
    public string? IpConfigurationId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecOperatorSpecConfigMapExpressions
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

/// <summary>DestinationExpression is a CEL expression and a destination to store the result in. The destination may be a secret or a configmap. The value of the expression is stored at the specified location in the destination.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecOperatorSpecSecretExpressions
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

/// <summary>Storage version of v1api20240301.VirtualNetworkGatewayOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecOperatorSpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240301storageVirtualNetworkGatewaySpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240301storageVirtualNetworkGatewaySpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecOwner
{
    /// <summary></summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240301.VirtualNetworkGatewaySku VirtualNetworkGatewaySku details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecSku
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecVNetExtendedLocationResourceReference
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

/// <summary>Storage version of v1api20240301.VirtualNetworkGatewayPolicyGroupMember Vpn Client Connection configuration PolicyGroup member</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecVirtualNetworkGatewayPolicyGroupsPolicyMembers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("attributeType")]
    public string? AttributeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("attributeValue")]
    public string? AttributeValue { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240301.VirtualNetworkGatewayPolicyGroup Parameters for VirtualNetworkGatewayPolicyGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecVirtualNetworkGatewayPolicyGroups
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("policyMembers")]
    public IList<V1api20240301storageVirtualNetworkGatewaySpecVirtualNetworkGatewayPolicyGroupsPolicyMembers>? PolicyMembers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }
}

/// <summary>Storage version of v1api20240301.RadiusServer Radius Server Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecVpnClientConfigurationRadiusServers
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

/// <summary>Reference: Resource ID.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecVpnClientConfigurationVngClientConnectionConfigurationsReference
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

/// <summary>Storage version of v1api20240301.VngClientConnectionConfiguration A vpn client connection configuration for client connection configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecVpnClientConfigurationVngClientConnectionConfigurations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource ID.</summary>
    [JsonPropertyName("reference")]
    public V1api20240301storageVirtualNetworkGatewaySpecVpnClientConfigurationVngClientConnectionConfigurationsReference? Reference { get; set; }
}

/// <summary>Storage version of v1api20240301.AddressSpace AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecVpnClientConfigurationVpnClientAddressPool
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }
}

/// <summary>Storage version of v1api20240301.IpsecPolicy An IPSec Policy configuration for a virtual network gateway connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPolicies
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

/// <summary>Storage version of v1api20240301.VpnClientRevokedCertificate VPN client revoked certificate of virtual network gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecVpnClientConfigurationVpnClientRevokedCertificates
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

/// <summary>Storage version of v1api20240301.VpnClientRootCertificate VPN client root certificate of virtual network gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecVpnClientConfigurationVpnClientRootCertificates
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

/// <summary>Storage version of v1api20240301.VpnClientConfiguration VpnClientConfiguration for P2S client.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpecVpnClientConfiguration
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
    public IList<V1api20240301storageVirtualNetworkGatewaySpecVpnClientConfigurationRadiusServers>? RadiusServers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vngClientConnectionConfigurations")]
    public IList<V1api20240301storageVirtualNetworkGatewaySpecVpnClientConfigurationVngClientConnectionConfigurations>? VngClientConnectionConfigurations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpnAuthenticationTypes")]
    public IList<string>? VpnAuthenticationTypes { get; set; }

    /// <summary>Storage version of v1api20240301.AddressSpace AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
    [JsonPropertyName("vpnClientAddressPool")]
    public V1api20240301storageVirtualNetworkGatewaySpecVpnClientConfigurationVpnClientAddressPool? VpnClientAddressPool { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpnClientIpsecPolicies")]
    public IList<V1api20240301storageVirtualNetworkGatewaySpecVpnClientConfigurationVpnClientIpsecPolicies>? VpnClientIpsecPolicies { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpnClientProtocols")]
    public IList<string>? VpnClientProtocols { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpnClientRevokedCertificates")]
    public IList<V1api20240301storageVirtualNetworkGatewaySpecVpnClientConfigurationVpnClientRevokedCertificates>? VpnClientRevokedCertificates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpnClientRootCertificates")]
    public IList<V1api20240301storageVirtualNetworkGatewaySpecVpnClientConfigurationVpnClientRootCertificates>? VpnClientRootCertificates { get; set; }
}

/// <summary>Storage version of v1api20240301.VirtualNetworkGateway_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewaySpec
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("activeActive")]
    public bool? ActiveActive { get; set; }

    /// <summary></summary>
    [JsonPropertyName("adminState")]
    public string? AdminState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowRemoteVnetTraffic")]
    public bool? AllowRemoteVnetTraffic { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowVirtualWanTraffic")]
    public bool? AllowVirtualWanTraffic { get; set; }

    /// <summary>Storage version of v1api20240301.VirtualNetworkGatewayAutoScaleConfiguration Virtual Network Gateway Autoscale Configuration details</summary>
    [JsonPropertyName("autoScaleConfiguration")]
    public V1api20240301storageVirtualNetworkGatewaySpecAutoScaleConfiguration? AutoScaleConfiguration { get; set; }

    /// <summary>AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it doesn't have to be.</summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Storage version of v1api20240301.BgpSettings BGP settings details.</summary>
    [JsonPropertyName("bgpSettings")]
    public V1api20240301storageVirtualNetworkGatewaySpecBgpSettings? BgpSettings { get; set; }

    /// <summary>Storage version of v1api20240301.AddressSpace AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
    [JsonPropertyName("customRoutes")]
    public V1api20240301storageVirtualNetworkGatewaySpecCustomRoutes? CustomRoutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableIPSecReplayProtection")]
    public bool? DisableIPSecReplayProtection { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableBgp")]
    public bool? EnableBgp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableBgpRouteTranslationForNat")]
    public bool? EnableBgpRouteTranslationForNat { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableDnsForwarding")]
    public bool? EnableDnsForwarding { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enablePrivateIpAddress")]
    public bool? EnablePrivateIpAddress { get; set; }

    /// <summary>Storage version of v1api20240301.ExtendedLocation ExtendedLocation complex type.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20240301storageVirtualNetworkGatewaySpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>Storage version of v1api20240301.SubResource Reference to another subresource.</summary>
    [JsonPropertyName("gatewayDefaultSite")]
    public V1api20240301storageVirtualNetworkGatewaySpecGatewayDefaultSite? GatewayDefaultSite { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gatewayType")]
    public string? GatewayType { get; set; }

    /// <summary>Storage version of v1api20240301.ManagedServiceIdentity Identity for the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20240301storageVirtualNetworkGatewaySpecIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipConfigurations")]
    public IList<V1api20240301storageVirtualNetworkGatewaySpecIpConfigurations>? IpConfigurations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("natRules")]
    public IList<V1api20240301storageVirtualNetworkGatewaySpecNatRules>? NatRules { get; set; }

    /// <summary>Storage version of v1api20240301.VirtualNetworkGatewayOperatorSpec Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure</summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240301storageVirtualNetworkGatewaySpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a reference to a resources.azure.com/ResourceGroup resource</summary>
    [JsonPropertyName("owner")]
    public V1api20240301storageVirtualNetworkGatewaySpecOwner Owner { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resiliencyModel")]
    public string? ResiliencyModel { get; set; }

    /// <summary>Storage version of v1api20240301.VirtualNetworkGatewaySku VirtualNetworkGatewaySku details.</summary>
    [JsonPropertyName("sku")]
    public V1api20240301storageVirtualNetworkGatewaySpecSku? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>VNetExtendedLocationResourceReference: Customer vnet resource id. VirtualNetworkGateway of type local gateway is associated with the customer vnet.</summary>
    [JsonPropertyName("vNetExtendedLocationResourceReference")]
    public V1api20240301storageVirtualNetworkGatewaySpecVNetExtendedLocationResourceReference? VNetExtendedLocationResourceReference { get; set; }

    /// <summary></summary>
    [JsonPropertyName("virtualNetworkGatewayPolicyGroups")]
    public IList<V1api20240301storageVirtualNetworkGatewaySpecVirtualNetworkGatewayPolicyGroups>? VirtualNetworkGatewayPolicyGroups { get; set; }

    /// <summary>Storage version of v1api20240301.VpnClientConfiguration VpnClientConfiguration for P2S client.</summary>
    [JsonPropertyName("vpnClientConfiguration")]
    public V1api20240301storageVirtualNetworkGatewaySpecVpnClientConfiguration? VpnClientConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpnGatewayGeneration")]
    public string? VpnGatewayGeneration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpnType")]
    public string? VpnType { get; set; }
}

/// <summary>Storage version of v1api20240301.VirtualNetworkGatewayAutoScaleBounds_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewayStatusAutoScaleConfigurationBounds
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("max")]
    public int? Max { get; set; }

    /// <summary></summary>
    [JsonPropertyName("min")]
    public int? Min { get; set; }
}

/// <summary>Storage version of v1api20240301.VirtualNetworkGatewayAutoScaleConfiguration_STATUS Virtual Network Gateway Autoscale Configuration details</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewayStatusAutoScaleConfiguration
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v1api20240301.VirtualNetworkGatewayAutoScaleBounds_STATUS</summary>
    [JsonPropertyName("bounds")]
    public V1api20240301storageVirtualNetworkGatewayStatusAutoScaleConfigurationBounds? Bounds { get; set; }
}

/// <summary>Storage version of v1api20240301.IPConfigurationBgpPeeringAddress_STATUS Properties of IPConfigurationBgpPeeringAddress.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewayStatusBgpSettingsBgpPeeringAddresses
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

/// <summary>Storage version of v1api20240301.BgpSettings_STATUS BGP settings details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewayStatusBgpSettings
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
    public IList<V1api20240301storageVirtualNetworkGatewayStatusBgpSettingsBgpPeeringAddresses>? BgpPeeringAddresses { get; set; }

    /// <summary></summary>
    [JsonPropertyName("peerWeight")]
    public int? PeerWeight { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource nolint:recvcheck</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewayStatusConditions
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

/// <summary>Storage version of v1api20240301.AddressSpace_STATUS AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewayStatusCustomRoutes
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }
}

/// <summary>Storage version of v1api20240301.ExtendedLocation_STATUS ExtendedLocation complex type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewayStatusExtendedLocation
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

/// <summary>Storage version of v1api20240301.SubResource_STATUS Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewayStatusGatewayDefaultSite
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20240301.ManagedServiceIdentity_UserAssignedIdentities_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewayStatusIdentityUserAssignedIdentities
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

/// <summary>Storage version of v1api20240301.ManagedServiceIdentity_STATUS Identity for the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewayStatusIdentity
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
    public IDictionary<string, V1api20240301storageVirtualNetworkGatewayStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Storage version of v1api20240301.SubResource_STATUS Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewayStatusIpConfigurationsPublicIPAddress
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20240301.SubResource_STATUS Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewayStatusIpConfigurationsSubnet
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20240301.VirtualNetworkGatewayIPConfiguration_STATUS IP configuration for virtual network gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewayStatusIpConfigurations
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

    /// <summary>Storage version of v1api20240301.SubResource_STATUS Reference to another subresource.</summary>
    [JsonPropertyName("publicIPAddress")]
    public V1api20240301storageVirtualNetworkGatewayStatusIpConfigurationsPublicIPAddress? PublicIPAddress { get; set; }

    /// <summary>Storage version of v1api20240301.SubResource_STATUS Reference to another subresource.</summary>
    [JsonPropertyName("subnet")]
    public V1api20240301storageVirtualNetworkGatewayStatusIpConfigurationsSubnet? Subnet { get; set; }
}

/// <summary>Storage version of v1api20240301.VpnNatRuleMapping_STATUS Vpn NatRule mapping.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewayStatusNatRulesExternalMappings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("addressSpace")]
    public string? AddressSpace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("portRange")]
    public string? PortRange { get; set; }
}

/// <summary>Storage version of v1api20240301.VpnNatRuleMapping_STATUS Vpn NatRule mapping.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewayStatusNatRulesInternalMappings
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("addressSpace")]
    public string? AddressSpace { get; set; }

    /// <summary></summary>
    [JsonPropertyName("portRange")]
    public string? PortRange { get; set; }
}

/// <summary>Storage version of v1api20240301.VirtualNetworkGatewayNatRule_STATUS VirtualNetworkGatewayNatRule Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewayStatusNatRules
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("externalMappings")]
    public IList<V1api20240301storageVirtualNetworkGatewayStatusNatRulesExternalMappings>? ExternalMappings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("internalMappings")]
    public IList<V1api20240301storageVirtualNetworkGatewayStatusNatRulesInternalMappings>? InternalMappings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipConfigurationId")]
    public string? IpConfigurationId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("properties_type")]
    public string? PropertiesType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20240301.VirtualNetworkGatewaySku_STATUS VirtualNetworkGatewaySku details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewayStatusSku
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

/// <summary>Storage version of v1api20240301.VirtualNetworkGatewayPolicyGroupMember_STATUS Vpn Client Connection configuration PolicyGroup member</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewayStatusVirtualNetworkGatewayPolicyGroupsPolicyMembers
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("attributeType")]
    public string? AttributeType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("attributeValue")]
    public string? AttributeValue { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20240301.SubResource_STATUS Reference to another subresource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewayStatusVirtualNetworkGatewayPolicyGroupsVngClientConnectionConfigurations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20240301.VirtualNetworkGatewayPolicyGroup_STATUS Parameters for VirtualNetworkGatewayPolicyGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewayStatusVirtualNetworkGatewayPolicyGroups
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
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("policyMembers")]
    public IList<V1api20240301storageVirtualNetworkGatewayStatusVirtualNetworkGatewayPolicyGroupsPolicyMembers>? PolicyMembers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vngClientConnectionConfigurations")]
    public IList<V1api20240301storageVirtualNetworkGatewayStatusVirtualNetworkGatewayPolicyGroupsVngClientConnectionConfigurations>? VngClientConnectionConfigurations { get; set; }
}

/// <summary>Storage version of v1api20240301.RadiusServer_STATUS Radius Server Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewayStatusVpnClientConfigurationRadiusServers
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

/// <summary>Storage version of v1api20240301.VngClientConnectionConfiguration_STATUS A vpn client connection configuration for client connection configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewayStatusVpnClientConfigurationVngClientConnectionConfigurations
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Storage version of v1api20240301.AddressSpace_STATUS AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewayStatusVpnClientConfigurationVpnClientAddressPool
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("addressPrefixes")]
    public IList<string>? AddressPrefixes { get; set; }
}

/// <summary>Storage version of v1api20240301.IpsecPolicy_STATUS An IPSec Policy configuration for a virtual network gateway connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewayStatusVpnClientConfigurationVpnClientIpsecPolicies
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

/// <summary>Storage version of v1api20240301.VpnClientRevokedCertificate_STATUS VPN client revoked certificate of virtual network gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewayStatusVpnClientConfigurationVpnClientRevokedCertificates
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

/// <summary>Storage version of v1api20240301.VpnClientRootCertificate_STATUS VPN client root certificate of virtual network gateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewayStatusVpnClientConfigurationVpnClientRootCertificates
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

/// <summary>Storage version of v1api20240301.VpnClientConfiguration_STATUS VpnClientConfiguration for P2S client.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewayStatusVpnClientConfiguration
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
    public IList<V1api20240301storageVirtualNetworkGatewayStatusVpnClientConfigurationRadiusServers>? RadiusServers { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vngClientConnectionConfigurations")]
    public IList<V1api20240301storageVirtualNetworkGatewayStatusVpnClientConfigurationVngClientConnectionConfigurations>? VngClientConnectionConfigurations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpnAuthenticationTypes")]
    public IList<string>? VpnAuthenticationTypes { get; set; }

    /// <summary>Storage version of v1api20240301.AddressSpace_STATUS AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
    [JsonPropertyName("vpnClientAddressPool")]
    public V1api20240301storageVirtualNetworkGatewayStatusVpnClientConfigurationVpnClientAddressPool? VpnClientAddressPool { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpnClientIpsecPolicies")]
    public IList<V1api20240301storageVirtualNetworkGatewayStatusVpnClientConfigurationVpnClientIpsecPolicies>? VpnClientIpsecPolicies { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpnClientProtocols")]
    public IList<string>? VpnClientProtocols { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpnClientRevokedCertificates")]
    public IList<V1api20240301storageVirtualNetworkGatewayStatusVpnClientConfigurationVpnClientRevokedCertificates>? VpnClientRevokedCertificates { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpnClientRootCertificates")]
    public IList<V1api20240301storageVirtualNetworkGatewayStatusVpnClientConfigurationVpnClientRootCertificates>? VpnClientRootCertificates { get; set; }
}

/// <summary>Storage version of v1api20240301.VirtualNetworkGateway_STATUS_VirtualNetworkGateway_SubResourceEmbedded A common class for general resource information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240301storageVirtualNetworkGatewayStatus
{
    /// <summary>PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage resources, allowing for full fidelity round trip conversions</summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary></summary>
    [JsonPropertyName("activeActive")]
    public bool? ActiveActive { get; set; }

    /// <summary></summary>
    [JsonPropertyName("adminState")]
    public string? AdminState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowRemoteVnetTraffic")]
    public bool? AllowRemoteVnetTraffic { get; set; }

    /// <summary></summary>
    [JsonPropertyName("allowVirtualWanTraffic")]
    public bool? AllowVirtualWanTraffic { get; set; }

    /// <summary>Storage version of v1api20240301.VirtualNetworkGatewayAutoScaleConfiguration_STATUS Virtual Network Gateway Autoscale Configuration details</summary>
    [JsonPropertyName("autoScaleConfiguration")]
    public V1api20240301storageVirtualNetworkGatewayStatusAutoScaleConfiguration? AutoScaleConfiguration { get; set; }

    /// <summary>Storage version of v1api20240301.BgpSettings_STATUS BGP settings details.</summary>
    [JsonPropertyName("bgpSettings")]
    public V1api20240301storageVirtualNetworkGatewayStatusBgpSettings? BgpSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240301storageVirtualNetworkGatewayStatusConditions>? Conditions { get; set; }

    /// <summary>Storage version of v1api20240301.AddressSpace_STATUS AddressSpace contains an array of IP address ranges that can be used by subnets of the virtual network.</summary>
    [JsonPropertyName("customRoutes")]
    public V1api20240301storageVirtualNetworkGatewayStatusCustomRoutes? CustomRoutes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("disableIPSecReplayProtection")]
    public bool? DisableIPSecReplayProtection { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableBgp")]
    public bool? EnableBgp { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableBgpRouteTranslationForNat")]
    public bool? EnableBgpRouteTranslationForNat { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enableDnsForwarding")]
    public bool? EnableDnsForwarding { get; set; }

    /// <summary></summary>
    [JsonPropertyName("enablePrivateIpAddress")]
    public bool? EnablePrivateIpAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Storage version of v1api20240301.ExtendedLocation_STATUS ExtendedLocation complex type.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20240301storageVirtualNetworkGatewayStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>Storage version of v1api20240301.SubResource_STATUS Reference to another subresource.</summary>
    [JsonPropertyName("gatewayDefaultSite")]
    public V1api20240301storageVirtualNetworkGatewayStatusGatewayDefaultSite? GatewayDefaultSite { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gatewayType")]
    public string? GatewayType { get; set; }

    /// <summary></summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Storage version of v1api20240301.ManagedServiceIdentity_STATUS Identity for the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20240301storageVirtualNetworkGatewayStatusIdentity? Identity { get; set; }

    /// <summary></summary>
    [JsonPropertyName("inboundDnsForwardingEndpoint")]
    public string? InboundDnsForwardingEndpoint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ipConfigurations")]
    public IList<V1api20240301storageVirtualNetworkGatewayStatusIpConfigurations>? IpConfigurations { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("natRules")]
    public IList<V1api20240301storageVirtualNetworkGatewayStatusNatRules>? NatRules { get; set; }

    /// <summary></summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resiliencyModel")]
    public string? ResiliencyModel { get; set; }

    /// <summary></summary>
    [JsonPropertyName("resourceGuid")]
    public string? ResourceGuid { get; set; }

    /// <summary>Storage version of v1api20240301.VirtualNetworkGatewaySku_STATUS VirtualNetworkGatewaySku details.</summary>
    [JsonPropertyName("sku")]
    public V1api20240301storageVirtualNetworkGatewayStatusSku? Sku { get; set; }

    /// <summary></summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary></summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vNetExtendedLocationResourceId")]
    public string? VNetExtendedLocationResourceId { get; set; }

    /// <summary></summary>
    [JsonPropertyName("virtualNetworkGatewayPolicyGroups")]
    public IList<V1api20240301storageVirtualNetworkGatewayStatusVirtualNetworkGatewayPolicyGroups>? VirtualNetworkGatewayPolicyGroups { get; set; }

    /// <summary>Storage version of v1api20240301.VpnClientConfiguration_STATUS VpnClientConfiguration for P2S client.</summary>
    [JsonPropertyName("vpnClientConfiguration")]
    public V1api20240301storageVirtualNetworkGatewayStatusVpnClientConfiguration? VpnClientConfiguration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpnGatewayGeneration")]
    public string? VpnGatewayGeneration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpnType")]
    public string? VpnType { get; set; }
}

/// <summary>Storage version of v1api20240301.VirtualNetworkGateway Generator information: - Generated from: /network/resource-manager/Microsoft.Network/stable/2024-03-01/virtualNetworkGateway.json - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkGateways/{virtualNetworkGatewayName}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240301storageVirtualNetworkGateway : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240301storageVirtualNetworkGatewaySpec>, IStatus<V1api20240301storageVirtualNetworkGatewayStatus>
{
    public const string KubeApiVersion = "v1api20240301storage";
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

    /// <summary>Storage version of v1api20240301.VirtualNetworkGateway_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20240301storageVirtualNetworkGatewaySpec? Spec { get; set; }

    /// <summary>Storage version of v1api20240301.VirtualNetworkGateway_STATUS_VirtualNetworkGateway_SubResourceEmbedded A common class for general resource information.</summary>
    [JsonPropertyName("status")]
    public V1api20240301storageVirtualNetworkGatewayStatus? Status { get; set; }
}