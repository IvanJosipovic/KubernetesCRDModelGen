using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.directconnect.aws.m.upbound.io;
#nullable enable
/// <summary>PrivateVirtualInterface is the Schema for the PrivateVirtualInterfaces API. Provides a Direct Connect private virtual interface resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PrivateVirtualInterfaceList : IKubernetesObject<V1ListMeta>, IItems<V1beta1PrivateVirtualInterface>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PrivateVirtualInterfaceList";
    public const string KubeGroup = "directconnect.aws.m.upbound.io";
    public const string KubePluralName = "privatevirtualinterfaces";
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
    public IList<V1beta1PrivateVirtualInterface> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateVirtualInterfaceSpecForProviderConnectionIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Connection in directconnect to populate connectionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateVirtualInterfaceSpecForProviderConnectionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivateVirtualInterfaceSpecForProviderConnectionIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateVirtualInterfaceSpecForProviderConnectionIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Connection in directconnect to populate connectionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateVirtualInterfaceSpecForProviderConnectionIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivateVirtualInterfaceSpecForProviderConnectionIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateVirtualInterfaceSpecForProviderVpnGatewayIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a VPNGateway in ec2 to populate vpnGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateVirtualInterfaceSpecForProviderVpnGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivateVirtualInterfaceSpecForProviderVpnGatewayIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateVirtualInterfaceSpecForProviderVpnGatewayIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a VPNGateway in ec2 to populate vpnGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateVirtualInterfaceSpecForProviderVpnGatewayIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivateVirtualInterfaceSpecForProviderVpnGatewayIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateVirtualInterfaceSpecForProvider
{
    /// <summary>The address family for the BGP peer. ipv4  or ipv6.</summary>
    [JsonPropertyName("addressFamily")]
    public string? AddressFamily { get; set; }

    /// <summary>The IPv4 CIDR address to use to send traffic to Amazon. Required for IPv4 BGP peers.</summary>
    [JsonPropertyName("amazonAddress")]
    public string? AmazonAddress { get; set; }

    /// <summary>The autonomous system (AS) number for Border Gateway Protocol (BGP) configuration.</summary>
    [JsonPropertyName("bgpAsn")]
    public double? BgpAsn { get; set; }

    /// <summary>The authentication key for BGP configuration.</summary>
    [JsonPropertyName("bgpAuthKey")]
    public string? BgpAuthKey { get; set; }

    /// <summary>The ID of the Direct Connect connection (or LAG) on which to create the virtual interface.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>Reference to a Connection in directconnect to populate connectionId.</summary>
    [JsonPropertyName("connectionIdRef")]
    public V1beta1PrivateVirtualInterfaceSpecForProviderConnectionIdRef? ConnectionIdRef { get; set; }

    /// <summary>Selector for a Connection in directconnect to populate connectionId.</summary>
    [JsonPropertyName("connectionIdSelector")]
    public V1beta1PrivateVirtualInterfaceSpecForProviderConnectionIdSelector? ConnectionIdSelector { get; set; }

    /// <summary>The IPv4 CIDR destination address to which Amazon should send traffic. Required for IPv4 BGP peers.</summary>
    [JsonPropertyName("customerAddress")]
    public string? CustomerAddress { get; set; }

    /// <summary>The ID of the Direct Connect gateway to which to connect the virtual interface.</summary>
    [JsonPropertyName("dxGatewayId")]
    public string? DxGatewayId { get; set; }

    /// <summary>The maximum transmission unit (MTU) is the size, in bytes, of the largest permissible packet that can be passed over the connection. The MTU of a virtual private interface can be either 1500 or 9001 (jumbo frames). Default is 1500.</summary>
    [JsonPropertyName("mtu")]
    public double? Mtu { get; set; }

    /// <summary>The name for the virtual interface.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Indicates whether to enable or disable SiteLink.</summary>
    [JsonPropertyName("sitelinkEnabled")]
    public bool? SitelinkEnabled { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The VLAN ID.</summary>
    [JsonPropertyName("vlan")]
    public double? Vlan { get; set; }

    /// <summary>The ID of the virtual private gateway to which to connect the virtual interface.</summary>
    [JsonPropertyName("vpnGatewayId")]
    public string? VpnGatewayId { get; set; }

    /// <summary>Reference to a VPNGateway in ec2 to populate vpnGatewayId.</summary>
    [JsonPropertyName("vpnGatewayIdRef")]
    public V1beta1PrivateVirtualInterfaceSpecForProviderVpnGatewayIdRef? VpnGatewayIdRef { get; set; }

    /// <summary>Selector for a VPNGateway in ec2 to populate vpnGatewayId.</summary>
    [JsonPropertyName("vpnGatewayIdSelector")]
    public V1beta1PrivateVirtualInterfaceSpecForProviderVpnGatewayIdSelector? VpnGatewayIdSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateVirtualInterfaceSpecInitProviderConnectionIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Connection in directconnect to populate connectionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateVirtualInterfaceSpecInitProviderConnectionIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivateVirtualInterfaceSpecInitProviderConnectionIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateVirtualInterfaceSpecInitProviderConnectionIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Connection in directconnect to populate connectionId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateVirtualInterfaceSpecInitProviderConnectionIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivateVirtualInterfaceSpecInitProviderConnectionIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateVirtualInterfaceSpecInitProviderVpnGatewayIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a VPNGateway in ec2 to populate vpnGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateVirtualInterfaceSpecInitProviderVpnGatewayIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivateVirtualInterfaceSpecInitProviderVpnGatewayIdRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateVirtualInterfaceSpecInitProviderVpnGatewayIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a VPNGateway in ec2 to populate vpnGatewayId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateVirtualInterfaceSpecInitProviderVpnGatewayIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivateVirtualInterfaceSpecInitProviderVpnGatewayIdSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateVirtualInterfaceSpecInitProvider
{
    /// <summary>The address family for the BGP peer. ipv4  or ipv6.</summary>
    [JsonPropertyName("addressFamily")]
    public string? AddressFamily { get; set; }

    /// <summary>The IPv4 CIDR address to use to send traffic to Amazon. Required for IPv4 BGP peers.</summary>
    [JsonPropertyName("amazonAddress")]
    public string? AmazonAddress { get; set; }

    /// <summary>The autonomous system (AS) number for Border Gateway Protocol (BGP) configuration.</summary>
    [JsonPropertyName("bgpAsn")]
    public double? BgpAsn { get; set; }

    /// <summary>The authentication key for BGP configuration.</summary>
    [JsonPropertyName("bgpAuthKey")]
    public string? BgpAuthKey { get; set; }

    /// <summary>The ID of the Direct Connect connection (or LAG) on which to create the virtual interface.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>Reference to a Connection in directconnect to populate connectionId.</summary>
    [JsonPropertyName("connectionIdRef")]
    public V1beta1PrivateVirtualInterfaceSpecInitProviderConnectionIdRef? ConnectionIdRef { get; set; }

    /// <summary>Selector for a Connection in directconnect to populate connectionId.</summary>
    [JsonPropertyName("connectionIdSelector")]
    public V1beta1PrivateVirtualInterfaceSpecInitProviderConnectionIdSelector? ConnectionIdSelector { get; set; }

    /// <summary>The IPv4 CIDR destination address to which Amazon should send traffic. Required for IPv4 BGP peers.</summary>
    [JsonPropertyName("customerAddress")]
    public string? CustomerAddress { get; set; }

    /// <summary>The ID of the Direct Connect gateway to which to connect the virtual interface.</summary>
    [JsonPropertyName("dxGatewayId")]
    public string? DxGatewayId { get; set; }

    /// <summary>The maximum transmission unit (MTU) is the size, in bytes, of the largest permissible packet that can be passed over the connection. The MTU of a virtual private interface can be either 1500 or 9001 (jumbo frames). Default is 1500.</summary>
    [JsonPropertyName("mtu")]
    public double? Mtu { get; set; }

    /// <summary>The name for the virtual interface.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Indicates whether to enable or disable SiteLink.</summary>
    [JsonPropertyName("sitelinkEnabled")]
    public bool? SitelinkEnabled { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The VLAN ID.</summary>
    [JsonPropertyName("vlan")]
    public double? Vlan { get; set; }

    /// <summary>The ID of the virtual private gateway to which to connect the virtual interface.</summary>
    [JsonPropertyName("vpnGatewayId")]
    public string? VpnGatewayId { get; set; }

    /// <summary>Reference to a VPNGateway in ec2 to populate vpnGatewayId.</summary>
    [JsonPropertyName("vpnGatewayIdRef")]
    public V1beta1PrivateVirtualInterfaceSpecInitProviderVpnGatewayIdRef? VpnGatewayIdRef { get; set; }

    /// <summary>Selector for a VPNGateway in ec2 to populate vpnGatewayId.</summary>
    [JsonPropertyName("vpnGatewayIdSelector")]
    public V1beta1PrivateVirtualInterfaceSpecInitProviderVpnGatewayIdSelector? VpnGatewayIdSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateVirtualInterfaceSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateVirtualInterfaceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>PrivateVirtualInterfaceSpec defines the desired state of PrivateVirtualInterface</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateVirtualInterfaceSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PrivateVirtualInterfaceSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PrivateVirtualInterfaceSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PrivateVirtualInterfaceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PrivateVirtualInterfaceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateVirtualInterfaceStatusAtProvider
{
    /// <summary>The address family for the BGP peer. ipv4  or ipv6.</summary>
    [JsonPropertyName("addressFamily")]
    public string? AddressFamily { get; set; }

    /// <summary>The IPv4 CIDR address to use to send traffic to Amazon. Required for IPv4 BGP peers.</summary>
    [JsonPropertyName("amazonAddress")]
    public string? AmazonAddress { get; set; }

    /// <summary></summary>
    [JsonPropertyName("amazonSideAsn")]
    public string? AmazonSideAsn { get; set; }

    /// <summary>The ARN of the virtual interface.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The Direct Connect endpoint on which the virtual interface terminates.</summary>
    [JsonPropertyName("awsDevice")]
    public string? AwsDevice { get; set; }

    /// <summary>The autonomous system (AS) number for Border Gateway Protocol (BGP) configuration.</summary>
    [JsonPropertyName("bgpAsn")]
    public double? BgpAsn { get; set; }

    /// <summary>The authentication key for BGP configuration.</summary>
    [JsonPropertyName("bgpAuthKey")]
    public string? BgpAuthKey { get; set; }

    /// <summary>The ID of the Direct Connect connection (or LAG) on which to create the virtual interface.</summary>
    [JsonPropertyName("connectionId")]
    public string? ConnectionId { get; set; }

    /// <summary>The IPv4 CIDR destination address to which Amazon should send traffic. Required for IPv4 BGP peers.</summary>
    [JsonPropertyName("customerAddress")]
    public string? CustomerAddress { get; set; }

    /// <summary>The ID of the Direct Connect gateway to which to connect the virtual interface.</summary>
    [JsonPropertyName("dxGatewayId")]
    public string? DxGatewayId { get; set; }

    /// <summary>The ID of the virtual interface.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Indicates whether jumbo frames (9001 MTU) are supported.</summary>
    [JsonPropertyName("jumboFrameCapable")]
    public bool? JumboFrameCapable { get; set; }

    /// <summary>The maximum transmission unit (MTU) is the size, in bytes, of the largest permissible packet that can be passed over the connection. The MTU of a virtual private interface can be either 1500 or 9001 (jumbo frames). Default is 1500.</summary>
    [JsonPropertyName("mtu")]
    public double? Mtu { get; set; }

    /// <summary>The name for the virtual interface.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Indicates whether to enable or disable SiteLink.</summary>
    [JsonPropertyName("sitelinkEnabled")]
    public bool? SitelinkEnabled { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The VLAN ID.</summary>
    [JsonPropertyName("vlan")]
    public double? Vlan { get; set; }

    /// <summary>The ID of the virtual private gateway to which to connect the virtual interface.</summary>
    [JsonPropertyName("vpnGatewayId")]
    public string? VpnGatewayId { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateVirtualInterfaceStatusConditions
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
#nullable disable

#nullable enable
/// <summary>PrivateVirtualInterfaceStatus defines the observed state of PrivateVirtualInterface.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateVirtualInterfaceStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1PrivateVirtualInterfaceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PrivateVirtualInterfaceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>PrivateVirtualInterface is the Schema for the PrivateVirtualInterfaces API. Provides a Direct Connect private virtual interface resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PrivateVirtualInterface : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PrivateVirtualInterfaceSpec>, IStatus<V1beta1PrivateVirtualInterfaceStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PrivateVirtualInterface";
    public const string KubeGroup = "directconnect.aws.m.upbound.io";
    public const string KubePluralName = "privatevirtualinterfaces";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PrivateVirtualInterfaceSpec defines the desired state of PrivateVirtualInterface</summary>
    [JsonPropertyName("spec")]
    public V1beta1PrivateVirtualInterfaceSpec Spec { get; set; }

    /// <summary>PrivateVirtualInterfaceStatus defines the observed state of PrivateVirtualInterface.</summary>
    [JsonPropertyName("status")]
    public V1beta1PrivateVirtualInterfaceStatus? Status { get; set; }
}
#nullable disable
