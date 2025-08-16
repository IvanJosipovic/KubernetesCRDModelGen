using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.upbound.io;
/// <summary>VPNGateway is the Schema for the VPNGateways API. Manages a VPN Gateway within a Virtual Hub.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VPNGatewayList : IKubernetesObject<V1ListMeta>, IItems<V1beta1VPNGateway>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VPNGatewayList";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "vpngateways";
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
    public IList<V1beta1VPNGateway> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNGatewaySpecForProviderBgpSettingsInstance0BgpPeeringAddress
{
    /// <summary>A list of custom BGP peering addresses to assign to this instance.</summary>
    [JsonPropertyName("customIps")]
    public IList<string>? CustomIps { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNGatewaySpecForProviderBgpSettingsInstance1BgpPeeringAddress
{
    /// <summary>A list of custom BGP peering addresses to assign to this instance.</summary>
    [JsonPropertyName("customIps")]
    public IList<string>? CustomIps { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNGatewaySpecForProviderBgpSettings
{
    /// <summary>The ASN of the BGP Speaker. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("asn")]
    public double? Asn { get; set; }

    /// <summary>An instance_bgp_peering_address block as defined below.</summary>
    [JsonPropertyName("instance0BgpPeeringAddress")]
    public IList<V1beta1VPNGatewaySpecForProviderBgpSettingsInstance0BgpPeeringAddress>? Instance0BgpPeeringAddress { get; set; }

    /// <summary>An instance_bgp_peering_address block as defined below.</summary>
    [JsonPropertyName("instance1BgpPeeringAddress")]
    public IList<V1beta1VPNGatewaySpecForProviderBgpSettingsInstance1BgpPeeringAddress>? Instance1BgpPeeringAddress { get; set; }

    /// <summary>The weight added to Routes learned from this BGP Speaker. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("peerWeight")]
    public double? PeerWeight { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNGatewaySpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1VPNGatewaySpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNGatewaySpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNGatewaySpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1VPNGatewaySpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNGatewaySpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNGatewaySpecForProviderVirtualHubIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a VirtualHub in network to populate virtualHubId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNGatewaySpecForProviderVirtualHubIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNGatewaySpecForProviderVirtualHubIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNGatewaySpecForProviderVirtualHubIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a VirtualHub in network to populate virtualHubId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNGatewaySpecForProviderVirtualHubIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNGatewaySpecForProviderVirtualHubIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNGatewaySpecForProvider
{
    /// <summary>Is BGP route translation for NAT on this VPN Gateway enabled? Defaults to false.</summary>
    [JsonPropertyName("bgpRouteTranslationForNatEnabled")]
    public bool? BgpRouteTranslationForNatEnabled { get; set; }

    /// <summary>A bgp_settings block as defined below.</summary>
    [JsonPropertyName("bgpSettings")]
    public IList<V1beta1VPNGatewaySpecForProviderBgpSettings>? BgpSettings { get; set; }

    /// <summary>The Azure location where this VPN Gateway should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The Name of the Resource Group in which this VPN Gateway should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1VPNGatewaySpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1VPNGatewaySpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Azure routing preference lets you to choose how your traffic routes between Azure and the internet. You can choose to route traffic either via the Microsoft network (default value, Microsoft Network), or via the ISP network (public internet, set to Internet). More context of the configuration can be found in the Microsoft Docs to create a VPN Gateway. Defaults to Microsoft Network. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("routingPreference")]
    public string? RoutingPreference { get; set; }

    /// <summary>The Scale Unit for this VPN Gateway. Defaults to 1.</summary>
    [JsonPropertyName("scaleUnit")]
    public double? ScaleUnit { get; set; }

    /// <summary>A mapping of tags to assign to the VPN Gateway.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The ID of the Virtual Hub within which this VPN Gateway should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualHubId")]
    public string? VirtualHubId { get; set; }

    /// <summary>Reference to a VirtualHub in network to populate virtualHubId.</summary>
    [JsonPropertyName("virtualHubIdRef")]
    public V1beta1VPNGatewaySpecForProviderVirtualHubIdRef? VirtualHubIdRef { get; set; }

    /// <summary>Selector for a VirtualHub in network to populate virtualHubId.</summary>
    [JsonPropertyName("virtualHubIdSelector")]
    public V1beta1VPNGatewaySpecForProviderVirtualHubIdSelector? VirtualHubIdSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNGatewaySpecInitProviderBgpSettingsInstance0BgpPeeringAddress
{
    /// <summary>A list of custom BGP peering addresses to assign to this instance.</summary>
    [JsonPropertyName("customIps")]
    public IList<string>? CustomIps { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNGatewaySpecInitProviderBgpSettingsInstance1BgpPeeringAddress
{
    /// <summary>A list of custom BGP peering addresses to assign to this instance.</summary>
    [JsonPropertyName("customIps")]
    public IList<string>? CustomIps { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNGatewaySpecInitProviderBgpSettings
{
    /// <summary>The ASN of the BGP Speaker. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("asn")]
    public double? Asn { get; set; }

    /// <summary>An instance_bgp_peering_address block as defined below.</summary>
    [JsonPropertyName("instance0BgpPeeringAddress")]
    public IList<V1beta1VPNGatewaySpecInitProviderBgpSettingsInstance0BgpPeeringAddress>? Instance0BgpPeeringAddress { get; set; }

    /// <summary>An instance_bgp_peering_address block as defined below.</summary>
    [JsonPropertyName("instance1BgpPeeringAddress")]
    public IList<V1beta1VPNGatewaySpecInitProviderBgpSettingsInstance1BgpPeeringAddress>? Instance1BgpPeeringAddress { get; set; }

    /// <summary>The weight added to Routes learned from this BGP Speaker. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("peerWeight")]
    public double? PeerWeight { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNGatewaySpecInitProviderVirtualHubIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a VirtualHub in network to populate virtualHubId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNGatewaySpecInitProviderVirtualHubIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNGatewaySpecInitProviderVirtualHubIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNGatewaySpecInitProviderVirtualHubIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a VirtualHub in network to populate virtualHubId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNGatewaySpecInitProviderVirtualHubIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNGatewaySpecInitProviderVirtualHubIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNGatewaySpecInitProvider
{
    /// <summary>Is BGP route translation for NAT on this VPN Gateway enabled? Defaults to false.</summary>
    [JsonPropertyName("bgpRouteTranslationForNatEnabled")]
    public bool? BgpRouteTranslationForNatEnabled { get; set; }

    /// <summary>A bgp_settings block as defined below.</summary>
    [JsonPropertyName("bgpSettings")]
    public IList<V1beta1VPNGatewaySpecInitProviderBgpSettings>? BgpSettings { get; set; }

    /// <summary>The Azure location where this VPN Gateway should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Azure routing preference lets you to choose how your traffic routes between Azure and the internet. You can choose to route traffic either via the Microsoft network (default value, Microsoft Network), or via the ISP network (public internet, set to Internet). More context of the configuration can be found in the Microsoft Docs to create a VPN Gateway. Defaults to Microsoft Network. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("routingPreference")]
    public string? RoutingPreference { get; set; }

    /// <summary>The Scale Unit for this VPN Gateway. Defaults to 1.</summary>
    [JsonPropertyName("scaleUnit")]
    public double? ScaleUnit { get; set; }

    /// <summary>A mapping of tags to assign to the VPN Gateway.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The ID of the Virtual Hub within which this VPN Gateway should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualHubId")]
    public string? VirtualHubId { get; set; }

    /// <summary>Reference to a VirtualHub in network to populate virtualHubId.</summary>
    [JsonPropertyName("virtualHubIdRef")]
    public V1beta1VPNGatewaySpecInitProviderVirtualHubIdRef? VirtualHubIdRef { get; set; }

    /// <summary>Selector for a VirtualHub in network to populate virtualHubId.</summary>
    [JsonPropertyName("virtualHubIdSelector")]
    public V1beta1VPNGatewaySpecInitProviderVirtualHubIdSelector? VirtualHubIdSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNGatewaySpecProviderConfigRefPolicy
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
public partial class V1beta1VPNGatewaySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VPNGatewaySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNGatewaySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>VPNGatewaySpec defines the desired state of VPNGateway</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNGatewaySpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1VPNGatewaySpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1VPNGatewaySpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1VPNGatewaySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1VPNGatewaySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNGatewayStatusAtProviderBgpSettingsInstance0BgpPeeringAddress
{
    /// <summary>A list of custom BGP peering addresses to assign to this instance.</summary>
    [JsonPropertyName("customIps")]
    public IList<string>? CustomIps { get; set; }

    /// <summary>The list of default BGP peering addresses which belong to the pre-defined VPN Gateway IP configuration.</summary>
    [JsonPropertyName("defaultIps")]
    public IList<string>? DefaultIps { get; set; }

    /// <summary>The pre-defined id of VPN Gateway IP Configuration.</summary>
    [JsonPropertyName("ipConfigurationId")]
    public string? IpConfigurationId { get; set; }

    /// <summary>The list of tunnel public IP addresses which belong to the pre-defined VPN Gateway IP configuration.</summary>
    [JsonPropertyName("tunnelIps")]
    public IList<string>? TunnelIps { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNGatewayStatusAtProviderBgpSettingsInstance1BgpPeeringAddress
{
    /// <summary>A list of custom BGP peering addresses to assign to this instance.</summary>
    [JsonPropertyName("customIps")]
    public IList<string>? CustomIps { get; set; }

    /// <summary>The list of default BGP peering addresses which belong to the pre-defined VPN Gateway IP configuration.</summary>
    [JsonPropertyName("defaultIps")]
    public IList<string>? DefaultIps { get; set; }

    /// <summary>The pre-defined id of VPN Gateway IP Configuration.</summary>
    [JsonPropertyName("ipConfigurationId")]
    public string? IpConfigurationId { get; set; }

    /// <summary>The list of tunnel public IP addresses which belong to the pre-defined VPN Gateway IP configuration.</summary>
    [JsonPropertyName("tunnelIps")]
    public IList<string>? TunnelIps { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNGatewayStatusAtProviderBgpSettings
{
    /// <summary>The ASN of the BGP Speaker. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("asn")]
    public double? Asn { get; set; }

    /// <summary>The Address which should be used for the BGP Peering.</summary>
    [JsonPropertyName("bgpPeeringAddress")]
    public string? BgpPeeringAddress { get; set; }

    /// <summary>An instance_bgp_peering_address block as defined below.</summary>
    [JsonPropertyName("instance0BgpPeeringAddress")]
    public IList<V1beta1VPNGatewayStatusAtProviderBgpSettingsInstance0BgpPeeringAddress>? Instance0BgpPeeringAddress { get; set; }

    /// <summary>An instance_bgp_peering_address block as defined below.</summary>
    [JsonPropertyName("instance1BgpPeeringAddress")]
    public IList<V1beta1VPNGatewayStatusAtProviderBgpSettingsInstance1BgpPeeringAddress>? Instance1BgpPeeringAddress { get; set; }

    /// <summary>The weight added to Routes learned from this BGP Speaker. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("peerWeight")]
    public double? PeerWeight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNGatewayStatusAtProviderIpConfiguration
{
    /// <summary>The identifier of the IP configuration for the VPN Gateway.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The private IP address of this IP configuration.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>The public IP address of this IP configuration.</summary>
    [JsonPropertyName("publicIpAddress")]
    public string? PublicIpAddress { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNGatewayStatusAtProvider
{
    /// <summary>Is BGP route translation for NAT on this VPN Gateway enabled? Defaults to false.</summary>
    [JsonPropertyName("bgpRouteTranslationForNatEnabled")]
    public bool? BgpRouteTranslationForNatEnabled { get; set; }

    /// <summary>A bgp_settings block as defined below.</summary>
    [JsonPropertyName("bgpSettings")]
    public IList<V1beta1VPNGatewayStatusAtProviderBgpSettings>? BgpSettings { get; set; }

    /// <summary>The ID of the VPN Gateway.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An ip_configuration block as defined below.</summary>
    [JsonPropertyName("ipConfiguration")]
    public IList<V1beta1VPNGatewayStatusAtProviderIpConfiguration>? IpConfiguration { get; set; }

    /// <summary>The Azure location where this VPN Gateway should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The Name of the Resource Group in which this VPN Gateway should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Azure routing preference lets you to choose how your traffic routes between Azure and the internet. You can choose to route traffic either via the Microsoft network (default value, Microsoft Network), or via the ISP network (public internet, set to Internet). More context of the configuration can be found in the Microsoft Docs to create a VPN Gateway. Defaults to Microsoft Network. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("routingPreference")]
    public string? RoutingPreference { get; set; }

    /// <summary>The Scale Unit for this VPN Gateway. Defaults to 1.</summary>
    [JsonPropertyName("scaleUnit")]
    public double? ScaleUnit { get; set; }

    /// <summary>A mapping of tags to assign to the VPN Gateway.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The ID of the Virtual Hub within which this VPN Gateway should be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualHubId")]
    public string? VirtualHubId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNGatewayStatusConditions
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

/// <summary>VPNGatewayStatus defines the observed state of VPNGateway.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPNGatewayStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1VPNGatewayStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VPNGatewayStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>VPNGateway is the Schema for the VPNGateways API. Manages a VPN Gateway within a Virtual Hub.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VPNGateway : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VPNGatewaySpec>, IStatus<V1beta1VPNGatewayStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VPNGateway";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "vpngateways";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VPNGatewaySpec defines the desired state of VPNGateway</summary>
    [JsonPropertyName("spec")]
    public V1beta1VPNGatewaySpec Spec { get; set; }

    /// <summary>VPNGatewayStatus defines the observed state of VPNGateway.</summary>
    [JsonPropertyName("status")]
    public V1beta1VPNGatewayStatus? Status { get; set; }
}