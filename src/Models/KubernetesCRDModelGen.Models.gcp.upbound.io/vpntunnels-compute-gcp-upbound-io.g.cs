using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.upbound.io;
/// <summary>VPNTunnel is the Schema for the VPNTunnels API. VPN tunnel resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VPNTunnelList : IKubernetesObject<V1ListMeta>, IItems<V1beta1VPNTunnel>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VPNTunnelList";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "vpntunnels";
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
    public IList<V1beta1VPNTunnel> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecForProviderPeerExternalGatewayRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ExternalVPNGateway in compute to populate peerExternalGateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecForProviderPeerExternalGatewayRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNTunnelSpecForProviderPeerExternalGatewayRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecForProviderPeerExternalGatewaySelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ExternalVPNGateway in compute to populate peerExternalGateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecForProviderPeerExternalGatewaySelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNTunnelSpecForProviderPeerExternalGatewaySelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecForProviderRouterRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Router in compute to populate router.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecForProviderRouterRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNTunnelSpecForProviderRouterRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecForProviderRouterSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Router in compute to populate router.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecForProviderRouterSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNTunnelSpecForProviderRouterSelectorPolicy? Policy { get; set; }
}

/// <summary>Shared secret used to set the secure session between the Cloud VPN gateway and the peer VPN gateway. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecForProviderSharedSecretSecretRef
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

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecForProviderTargetVpnGatewayRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a VPNGateway in compute to populate targetVpnGateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecForProviderTargetVpnGatewayRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNTunnelSpecForProviderTargetVpnGatewayRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecForProviderTargetVpnGatewaySelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a VPNGateway in compute to populate targetVpnGateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecForProviderTargetVpnGatewaySelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNTunnelSpecForProviderTargetVpnGatewaySelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecForProviderVpnGatewayRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a HaVPNGateway in compute to populate vpnGateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecForProviderVpnGatewayRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNTunnelSpecForProviderVpnGatewayRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecForProviderVpnGatewaySelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a HaVPNGateway in compute to populate vpnGateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecForProviderVpnGatewaySelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNTunnelSpecForProviderVpnGatewaySelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecForProvider
{
    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>IKE protocol version to use when establishing the VPN tunnel with peer VPN gateway. Acceptable IKE versions are 1 or 2. Default version is 2.</summary>
    [JsonPropertyName("ikeVersion")]
    public double? IkeVersion { get; set; }

    /// <summary>Labels to apply to this VpnTunnel. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Local traffic selector to use when establishing the VPN tunnel with peer VPN gateway. The value should be a CIDR formatted string, for example 192.168.0.0/16. The ranges should be disjoint. Only IPv4 is supported.</summary>
    [JsonPropertyName("localTrafficSelector")]
    public IList<string>? LocalTrafficSelector { get; set; }

    /// <summary>URL of the peer side external VPN gateway to which this VPN tunnel is connected.</summary>
    [JsonPropertyName("peerExternalGateway")]
    public string? PeerExternalGateway { get; set; }

    /// <summary>The interface ID of the external VPN gateway to which this VPN tunnel is connected.</summary>
    [JsonPropertyName("peerExternalGatewayInterface")]
    public double? PeerExternalGatewayInterface { get; set; }

    /// <summary>Reference to a ExternalVPNGateway in compute to populate peerExternalGateway.</summary>
    [JsonPropertyName("peerExternalGatewayRef")]
    public V1beta1VPNTunnelSpecForProviderPeerExternalGatewayRef? PeerExternalGatewayRef { get; set; }

    /// <summary>Selector for a ExternalVPNGateway in compute to populate peerExternalGateway.</summary>
    [JsonPropertyName("peerExternalGatewaySelector")]
    public V1beta1VPNTunnelSpecForProviderPeerExternalGatewaySelector? PeerExternalGatewaySelector { get; set; }

    /// <summary>URL of the peer side HA GCP VPN gateway to which this VPN tunnel is connected. If provided, the VPN tunnel will automatically use the same vpn_gateway_interface ID in the peer GCP VPN gateway. This field must reference a google_compute_ha_vpn_gateway resource.</summary>
    [JsonPropertyName("peerGcpGateway")]
    public string? PeerGcpGateway { get; set; }

    /// <summary>IP address of the peer VPN gateway. Only IPv4 is supported.</summary>
    [JsonPropertyName("peerIp")]
    public string? PeerIp { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region where the tunnel is located. If unset, is set to the region of target_vpn_gateway.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Remote traffic selector to use when establishing the VPN tunnel with peer VPN gateway. The value should be a CIDR formatted string, for example 192.168.0.0/16. The ranges should be disjoint. Only IPv4 is supported.</summary>
    [JsonPropertyName("remoteTrafficSelector")]
    public IList<string>? RemoteTrafficSelector { get; set; }

    /// <summary>URL of router resource to be used for dynamic routing.</summary>
    [JsonPropertyName("router")]
    public string? Router { get; set; }

    /// <summary>Reference to a Router in compute to populate router.</summary>
    [JsonPropertyName("routerRef")]
    public V1beta1VPNTunnelSpecForProviderRouterRef? RouterRef { get; set; }

    /// <summary>Selector for a Router in compute to populate router.</summary>
    [JsonPropertyName("routerSelector")]
    public V1beta1VPNTunnelSpecForProviderRouterSelector? RouterSelector { get; set; }

    /// <summary>Shared secret used to set the secure session between the Cloud VPN gateway and the peer VPN gateway. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("sharedSecretSecretRef")]
    public V1beta1VPNTunnelSpecForProviderSharedSecretSecretRef? SharedSecretSecretRef { get; set; }

    /// <summary>URL of the Target VPN gateway with which this VPN tunnel is associated.</summary>
    [JsonPropertyName("targetVpnGateway")]
    public string? TargetVpnGateway { get; set; }

    /// <summary>Reference to a VPNGateway in compute to populate targetVpnGateway.</summary>
    [JsonPropertyName("targetVpnGatewayRef")]
    public V1beta1VPNTunnelSpecForProviderTargetVpnGatewayRef? TargetVpnGatewayRef { get; set; }

    /// <summary>Selector for a VPNGateway in compute to populate targetVpnGateway.</summary>
    [JsonPropertyName("targetVpnGatewaySelector")]
    public V1beta1VPNTunnelSpecForProviderTargetVpnGatewaySelector? TargetVpnGatewaySelector { get; set; }

    /// <summary>URL of the VPN gateway with which this VPN tunnel is associated. This must be used if a High Availability VPN gateway resource is created. This field must reference a google_compute_ha_vpn_gateway resource.</summary>
    [JsonPropertyName("vpnGateway")]
    public string? VpnGateway { get; set; }

    /// <summary>The interface ID of the VPN gateway with which this VPN tunnel is associated.</summary>
    [JsonPropertyName("vpnGatewayInterface")]
    public double? VpnGatewayInterface { get; set; }

    /// <summary>Reference to a HaVPNGateway in compute to populate vpnGateway.</summary>
    [JsonPropertyName("vpnGatewayRef")]
    public V1beta1VPNTunnelSpecForProviderVpnGatewayRef? VpnGatewayRef { get; set; }

    /// <summary>Selector for a HaVPNGateway in compute to populate vpnGateway.</summary>
    [JsonPropertyName("vpnGatewaySelector")]
    public V1beta1VPNTunnelSpecForProviderVpnGatewaySelector? VpnGatewaySelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecInitProviderPeerExternalGatewayRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ExternalVPNGateway in compute to populate peerExternalGateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecInitProviderPeerExternalGatewayRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNTunnelSpecInitProviderPeerExternalGatewayRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecInitProviderPeerExternalGatewaySelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ExternalVPNGateway in compute to populate peerExternalGateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecInitProviderPeerExternalGatewaySelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNTunnelSpecInitProviderPeerExternalGatewaySelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecInitProviderRouterRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Router in compute to populate router.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecInitProviderRouterRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNTunnelSpecInitProviderRouterRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecInitProviderRouterSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Router in compute to populate router.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecInitProviderRouterSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNTunnelSpecInitProviderRouterSelectorPolicy? Policy { get; set; }
}

/// <summary>Shared secret used to set the secure session between the Cloud VPN gateway and the peer VPN gateway. Note: This property is sensitive and will not be displayed in the plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecInitProviderSharedSecretSecretRef
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

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecInitProviderTargetVpnGatewayRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a VPNGateway in compute to populate targetVpnGateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecInitProviderTargetVpnGatewayRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNTunnelSpecInitProviderTargetVpnGatewayRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecInitProviderTargetVpnGatewaySelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a VPNGateway in compute to populate targetVpnGateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecInitProviderTargetVpnGatewaySelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNTunnelSpecInitProviderTargetVpnGatewaySelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecInitProviderVpnGatewayRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a HaVPNGateway in compute to populate vpnGateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecInitProviderVpnGatewayRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNTunnelSpecInitProviderVpnGatewayRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecInitProviderVpnGatewaySelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a HaVPNGateway in compute to populate vpnGateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecInitProviderVpnGatewaySelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNTunnelSpecInitProviderVpnGatewaySelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecInitProvider
{
    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>IKE protocol version to use when establishing the VPN tunnel with peer VPN gateway. Acceptable IKE versions are 1 or 2. Default version is 2.</summary>
    [JsonPropertyName("ikeVersion")]
    public double? IkeVersion { get; set; }

    /// <summary>Labels to apply to this VpnTunnel. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Local traffic selector to use when establishing the VPN tunnel with peer VPN gateway. The value should be a CIDR formatted string, for example 192.168.0.0/16. The ranges should be disjoint. Only IPv4 is supported.</summary>
    [JsonPropertyName("localTrafficSelector")]
    public IList<string>? LocalTrafficSelector { get; set; }

    /// <summary>URL of the peer side external VPN gateway to which this VPN tunnel is connected.</summary>
    [JsonPropertyName("peerExternalGateway")]
    public string? PeerExternalGateway { get; set; }

    /// <summary>The interface ID of the external VPN gateway to which this VPN tunnel is connected.</summary>
    [JsonPropertyName("peerExternalGatewayInterface")]
    public double? PeerExternalGatewayInterface { get; set; }

    /// <summary>Reference to a ExternalVPNGateway in compute to populate peerExternalGateway.</summary>
    [JsonPropertyName("peerExternalGatewayRef")]
    public V1beta1VPNTunnelSpecInitProviderPeerExternalGatewayRef? PeerExternalGatewayRef { get; set; }

    /// <summary>Selector for a ExternalVPNGateway in compute to populate peerExternalGateway.</summary>
    [JsonPropertyName("peerExternalGatewaySelector")]
    public V1beta1VPNTunnelSpecInitProviderPeerExternalGatewaySelector? PeerExternalGatewaySelector { get; set; }

    /// <summary>URL of the peer side HA GCP VPN gateway to which this VPN tunnel is connected. If provided, the VPN tunnel will automatically use the same vpn_gateway_interface ID in the peer GCP VPN gateway. This field must reference a google_compute_ha_vpn_gateway resource.</summary>
    [JsonPropertyName("peerGcpGateway")]
    public string? PeerGcpGateway { get; set; }

    /// <summary>IP address of the peer VPN gateway. Only IPv4 is supported.</summary>
    [JsonPropertyName("peerIp")]
    public string? PeerIp { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Remote traffic selector to use when establishing the VPN tunnel with peer VPN gateway. The value should be a CIDR formatted string, for example 192.168.0.0/16. The ranges should be disjoint. Only IPv4 is supported.</summary>
    [JsonPropertyName("remoteTrafficSelector")]
    public IList<string>? RemoteTrafficSelector { get; set; }

    /// <summary>URL of router resource to be used for dynamic routing.</summary>
    [JsonPropertyName("router")]
    public string? Router { get; set; }

    /// <summary>Reference to a Router in compute to populate router.</summary>
    [JsonPropertyName("routerRef")]
    public V1beta1VPNTunnelSpecInitProviderRouterRef? RouterRef { get; set; }

    /// <summary>Selector for a Router in compute to populate router.</summary>
    [JsonPropertyName("routerSelector")]
    public V1beta1VPNTunnelSpecInitProviderRouterSelector? RouterSelector { get; set; }

    /// <summary>Shared secret used to set the secure session between the Cloud VPN gateway and the peer VPN gateway. Note: This property is sensitive and will not be displayed in the plan.</summary>
    [JsonPropertyName("sharedSecretSecretRef")]
    public V1beta1VPNTunnelSpecInitProviderSharedSecretSecretRef SharedSecretSecretRef { get; set; }

    /// <summary>URL of the Target VPN gateway with which this VPN tunnel is associated.</summary>
    [JsonPropertyName("targetVpnGateway")]
    public string? TargetVpnGateway { get; set; }

    /// <summary>Reference to a VPNGateway in compute to populate targetVpnGateway.</summary>
    [JsonPropertyName("targetVpnGatewayRef")]
    public V1beta1VPNTunnelSpecInitProviderTargetVpnGatewayRef? TargetVpnGatewayRef { get; set; }

    /// <summary>Selector for a VPNGateway in compute to populate targetVpnGateway.</summary>
    [JsonPropertyName("targetVpnGatewaySelector")]
    public V1beta1VPNTunnelSpecInitProviderTargetVpnGatewaySelector? TargetVpnGatewaySelector { get; set; }

    /// <summary>URL of the VPN gateway with which this VPN tunnel is associated. This must be used if a High Availability VPN gateway resource is created. This field must reference a google_compute_ha_vpn_gateway resource.</summary>
    [JsonPropertyName("vpnGateway")]
    public string? VpnGateway { get; set; }

    /// <summary>The interface ID of the VPN gateway with which this VPN tunnel is associated.</summary>
    [JsonPropertyName("vpnGatewayInterface")]
    public double? VpnGatewayInterface { get; set; }

    /// <summary>Reference to a HaVPNGateway in compute to populate vpnGateway.</summary>
    [JsonPropertyName("vpnGatewayRef")]
    public V1beta1VPNTunnelSpecInitProviderVpnGatewayRef? VpnGatewayRef { get; set; }

    /// <summary>Selector for a HaVPNGateway in compute to populate vpnGateway.</summary>
    [JsonPropertyName("vpnGatewaySelector")]
    public V1beta1VPNTunnelSpecInitProviderVpnGatewaySelector? VpnGatewaySelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecProviderConfigRefPolicy
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
public partial class V1beta1VPNTunnelSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNTunnelSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>VPNTunnelSpec defines the desired state of VPNTunnel</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1VPNTunnelSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1VPNTunnelSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1VPNTunnelSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1VPNTunnelSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelStatusAtProvider
{
    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Detailed status message for the VPN tunnel.</summary>
    [JsonPropertyName("detailedStatus")]
    public string? DetailedStatus { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/regions/{{region}}/vpnTunnels/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IKE protocol version to use when establishing the VPN tunnel with peer VPN gateway. Acceptable IKE versions are 1 or 2. Default version is 2.</summary>
    [JsonPropertyName("ikeVersion")]
    public double? IkeVersion { get; set; }

    /// <summary>The fingerprint used for optimistic locking of this resource.  Used internally during updates.</summary>
    [JsonPropertyName("labelFingerprint")]
    public string? LabelFingerprint { get; set; }

    /// <summary>Labels to apply to this VpnTunnel. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Local traffic selector to use when establishing the VPN tunnel with peer VPN gateway. The value should be a CIDR formatted string, for example 192.168.0.0/16. The ranges should be disjoint. Only IPv4 is supported.</summary>
    [JsonPropertyName("localTrafficSelector")]
    public IList<string>? LocalTrafficSelector { get; set; }

    /// <summary>URL of the peer side external VPN gateway to which this VPN tunnel is connected.</summary>
    [JsonPropertyName("peerExternalGateway")]
    public string? PeerExternalGateway { get; set; }

    /// <summary>The interface ID of the external VPN gateway to which this VPN tunnel is connected.</summary>
    [JsonPropertyName("peerExternalGatewayInterface")]
    public double? PeerExternalGatewayInterface { get; set; }

    /// <summary>URL of the peer side HA GCP VPN gateway to which this VPN tunnel is connected. If provided, the VPN tunnel will automatically use the same vpn_gateway_interface ID in the peer GCP VPN gateway. This field must reference a google_compute_ha_vpn_gateway resource.</summary>
    [JsonPropertyName("peerGcpGateway")]
    public string? PeerGcpGateway { get; set; }

    /// <summary>IP address of the peer VPN gateway. Only IPv4 is supported.</summary>
    [JsonPropertyName("peerIp")]
    public string? PeerIp { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The region where the tunnel is located. If unset, is set to the region of target_vpn_gateway.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Remote traffic selector to use when establishing the VPN tunnel with peer VPN gateway. The value should be a CIDR formatted string, for example 192.168.0.0/16. The ranges should be disjoint. Only IPv4 is supported.</summary>
    [JsonPropertyName("remoteTrafficSelector")]
    public IList<string>? RemoteTrafficSelector { get; set; }

    /// <summary>URL of router resource to be used for dynamic routing.</summary>
    [JsonPropertyName("router")]
    public string? Router { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>Hash of the shared secret.</summary>
    [JsonPropertyName("sharedSecretHash")]
    public string? SharedSecretHash { get; set; }

    /// <summary>URL of the Target VPN gateway with which this VPN tunnel is associated.</summary>
    [JsonPropertyName("targetVpnGateway")]
    public string? TargetVpnGateway { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>The unique identifier for the resource. This identifier is defined by the server.</summary>
    [JsonPropertyName("tunnelId")]
    public string? TunnelId { get; set; }

    /// <summary>URL of the VPN gateway with which this VPN tunnel is associated. This must be used if a High Availability VPN gateway resource is created. This field must reference a google_compute_ha_vpn_gateway resource.</summary>
    [JsonPropertyName("vpnGateway")]
    public string? VpnGateway { get; set; }

    /// <summary>The interface ID of the VPN gateway with which this VPN tunnel is associated.</summary>
    [JsonPropertyName("vpnGatewayInterface")]
    public double? VpnGatewayInterface { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelStatusConditions
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

/// <summary>VPNTunnelStatus defines the observed state of VPNTunnel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNTunnelStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1VPNTunnelStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VPNTunnelStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>VPNTunnel is the Schema for the VPNTunnels API. VPN tunnel resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VPNTunnel : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VPNTunnelSpec>, IStatus<V1beta1VPNTunnelStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VPNTunnel";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "vpntunnels";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VPNTunnelSpec defines the desired state of VPNTunnel</summary>
    [JsonPropertyName("spec")]
    public V1beta1VPNTunnelSpec Spec { get; set; }

    /// <summary>VPNTunnelStatus defines the observed state of VPNTunnel.</summary>
    [JsonPropertyName("status")]
    public V1beta1VPNTunnelStatus? Status { get; set; }
}