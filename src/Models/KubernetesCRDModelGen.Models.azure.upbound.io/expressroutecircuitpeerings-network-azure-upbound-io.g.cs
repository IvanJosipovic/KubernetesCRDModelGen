using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.upbound.io;
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExpressRouteCircuitPeeringSpecForProviderExpressRouteCircuitNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ExpressRouteCircuit in network to populate expressRouteCircuitName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExpressRouteCircuitPeeringSpecForProviderExpressRouteCircuitNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExpressRouteCircuitPeeringSpecForProviderExpressRouteCircuitNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExpressRouteCircuitPeeringSpecForProviderExpressRouteCircuitNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ExpressRouteCircuit in network to populate expressRouteCircuitName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExpressRouteCircuitPeeringSpecForProviderExpressRouteCircuitNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExpressRouteCircuitPeeringSpecForProviderExpressRouteCircuitNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExpressRouteCircuitPeeringSpecForProviderIpv6MicrosoftPeering
{
    /// <summary>The communities of Bgp Peering specified for microsoft peering.</summary>
    [JsonPropertyName("advertisedCommunities")]
    public IList<string>? AdvertisedCommunities { get; set; }

    /// <summary>A list of Advertised Public Prefixes.</summary>
    [JsonPropertyName("advertisedPublicPrefixes")]
    public IList<string>? AdvertisedPublicPrefixes { get; set; }

    /// <summary>The CustomerASN of the peering. Defaults to 0.</summary>
    [JsonPropertyName("customerAsn")]
    public double? CustomerAsn { get; set; }

    /// <summary>The Routing Registry against which the AS number and prefixes are registered. For example: ARIN, RIPE, AFRINIC etc. Defaults to NONE.</summary>
    [JsonPropertyName("routingRegistryName")]
    public string? RoutingRegistryName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExpressRouteCircuitPeeringSpecForProviderIpv6
{
    /// <summary>A boolean value indicating whether the IPv6 peering is enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A microsoft_peering block as defined below.</summary>
    [JsonPropertyName("microsoftPeering")]
    public IList<V1beta1ExpressRouteCircuitPeeringSpecForProviderIpv6MicrosoftPeering>? MicrosoftPeering { get; set; }

    /// <summary>A subnet for the primary link.</summary>
    [JsonPropertyName("primaryPeerAddressPrefix")]
    public string? PrimaryPeerAddressPrefix { get; set; }

    /// <summary>The ID of the Route Filter. Only available when peering_type is set to MicrosoftPeering.</summary>
    [JsonPropertyName("routeFilterId")]
    public string? RouteFilterId { get; set; }

    /// <summary>A subnet for the secondary link.</summary>
    [JsonPropertyName("secondaryPeerAddressPrefix")]
    public string? SecondaryPeerAddressPrefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExpressRouteCircuitPeeringSpecForProviderMicrosoftPeeringConfig
{
    /// <summary>The communities of Bgp Peering specified for microsoft peering.</summary>
    [JsonPropertyName("advertisedCommunities")]
    public IList<string>? AdvertisedCommunities { get; set; }

    /// <summary>A list of Advertised Public Prefixes.</summary>
    [JsonPropertyName("advertisedPublicPrefixes")]
    public IList<string>? AdvertisedPublicPrefixes { get; set; }

    /// <summary>The CustomerASN of the peering. Defaults to 0.</summary>
    [JsonPropertyName("customerAsn")]
    public double? CustomerAsn { get; set; }

    /// <summary>The Routing Registry against which the AS number and prefixes are registered. For example: ARIN, RIPE, AFRINIC etc. Defaults to NONE.</summary>
    [JsonPropertyName("routingRegistryName")]
    public string? RoutingRegistryName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExpressRouteCircuitPeeringSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1ExpressRouteCircuitPeeringSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExpressRouteCircuitPeeringSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExpressRouteCircuitPeeringSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1ExpressRouteCircuitPeeringSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExpressRouteCircuitPeeringSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>The shared key. Can be a maximum of 25 characters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExpressRouteCircuitPeeringSpecForProviderSharedKeySecretRef
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
public partial class V1beta1ExpressRouteCircuitPeeringSpecForProvider
{
    /// <summary>The name of the ExpressRoute Circuit in which to create the Peering. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("expressRouteCircuitName")]
    public string? ExpressRouteCircuitName { get; set; }

    /// <summary>Reference to a ExpressRouteCircuit in network to populate expressRouteCircuitName.</summary>
    [JsonPropertyName("expressRouteCircuitNameRef")]
    public V1beta1ExpressRouteCircuitPeeringSpecForProviderExpressRouteCircuitNameRef? ExpressRouteCircuitNameRef { get; set; }

    /// <summary>Selector for a ExpressRouteCircuit in network to populate expressRouteCircuitName.</summary>
    [JsonPropertyName("expressRouteCircuitNameSelector")]
    public V1beta1ExpressRouteCircuitPeeringSpecForProviderExpressRouteCircuitNameSelector? ExpressRouteCircuitNameSelector { get; set; }

    /// <summary>A boolean value indicating whether the IPv4 peering is enabled. Defaults to true.</summary>
    [JsonPropertyName("ipv4Enabled")]
    public bool? Ipv4Enabled { get; set; }

    /// <summary>A ipv6 block as defined below.</summary>
    [JsonPropertyName("ipv6")]
    public IList<V1beta1ExpressRouteCircuitPeeringSpecForProviderIpv6>? Ipv6 { get; set; }

    /// <summary>A microsoft_peering_config block as defined below. Required when peering_type is set to MicrosoftPeering and config for IPv4.</summary>
    [JsonPropertyName("microsoftPeeringConfig")]
    public IList<V1beta1ExpressRouteCircuitPeeringSpecForProviderMicrosoftPeeringConfig>? MicrosoftPeeringConfig { get; set; }

    /// <summary>The Either a 16-bit or a 32-bit ASN. Can either be public or private.</summary>
    [JsonPropertyName("peerAsn")]
    public double? PeerAsn { get; set; }

    /// <summary>A /30 subnet for the primary link. Required when config for IPv4.</summary>
    [JsonPropertyName("primaryPeerAddressPrefix")]
    public string? PrimaryPeerAddressPrefix { get; set; }

    /// <summary>The name of the resource group in which to create the Express Route Circuit Peering. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1ExpressRouteCircuitPeeringSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1ExpressRouteCircuitPeeringSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The ID of the Route Filter. Only available when peering_type is set to MicrosoftPeering.</summary>
    [JsonPropertyName("routeFilterId")]
    public string? RouteFilterId { get; set; }

    /// <summary>A /30 subnet for the secondary link. Required when config for IPv4.</summary>
    [JsonPropertyName("secondaryPeerAddressPrefix")]
    public string? SecondaryPeerAddressPrefix { get; set; }

    /// <summary>The shared key. Can be a maximum of 25 characters.</summary>
    [JsonPropertyName("sharedKeySecretRef")]
    public V1beta1ExpressRouteCircuitPeeringSpecForProviderSharedKeySecretRef? SharedKeySecretRef { get; set; }

    /// <summary>A valid VLAN ID to establish this peering on.</summary>
    [JsonPropertyName("vlanId")]
    public double? VlanId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExpressRouteCircuitPeeringSpecInitProviderIpv6MicrosoftPeering
{
    /// <summary>The communities of Bgp Peering specified for microsoft peering.</summary>
    [JsonPropertyName("advertisedCommunities")]
    public IList<string>? AdvertisedCommunities { get; set; }

    /// <summary>A list of Advertised Public Prefixes.</summary>
    [JsonPropertyName("advertisedPublicPrefixes")]
    public IList<string>? AdvertisedPublicPrefixes { get; set; }

    /// <summary>The CustomerASN of the peering. Defaults to 0.</summary>
    [JsonPropertyName("customerAsn")]
    public double? CustomerAsn { get; set; }

    /// <summary>The Routing Registry against which the AS number and prefixes are registered. For example: ARIN, RIPE, AFRINIC etc. Defaults to NONE.</summary>
    [JsonPropertyName("routingRegistryName")]
    public string? RoutingRegistryName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExpressRouteCircuitPeeringSpecInitProviderIpv6
{
    /// <summary>A boolean value indicating whether the IPv6 peering is enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A microsoft_peering block as defined below.</summary>
    [JsonPropertyName("microsoftPeering")]
    public IList<V1beta1ExpressRouteCircuitPeeringSpecInitProviderIpv6MicrosoftPeering>? MicrosoftPeering { get; set; }

    /// <summary>A subnet for the primary link.</summary>
    [JsonPropertyName("primaryPeerAddressPrefix")]
    public string? PrimaryPeerAddressPrefix { get; set; }

    /// <summary>The ID of the Route Filter. Only available when peering_type is set to MicrosoftPeering.</summary>
    [JsonPropertyName("routeFilterId")]
    public string? RouteFilterId { get; set; }

    /// <summary>A subnet for the secondary link.</summary>
    [JsonPropertyName("secondaryPeerAddressPrefix")]
    public string? SecondaryPeerAddressPrefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExpressRouteCircuitPeeringSpecInitProviderMicrosoftPeeringConfig
{
    /// <summary>The communities of Bgp Peering specified for microsoft peering.</summary>
    [JsonPropertyName("advertisedCommunities")]
    public IList<string>? AdvertisedCommunities { get; set; }

    /// <summary>A list of Advertised Public Prefixes.</summary>
    [JsonPropertyName("advertisedPublicPrefixes")]
    public IList<string>? AdvertisedPublicPrefixes { get; set; }

    /// <summary>The CustomerASN of the peering. Defaults to 0.</summary>
    [JsonPropertyName("customerAsn")]
    public double? CustomerAsn { get; set; }

    /// <summary>The Routing Registry against which the AS number and prefixes are registered. For example: ARIN, RIPE, AFRINIC etc. Defaults to NONE.</summary>
    [JsonPropertyName("routingRegistryName")]
    public string? RoutingRegistryName { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExpressRouteCircuitPeeringSpecInitProvider
{
    /// <summary>A boolean value indicating whether the IPv4 peering is enabled. Defaults to true.</summary>
    [JsonPropertyName("ipv4Enabled")]
    public bool? Ipv4Enabled { get; set; }

    /// <summary>A ipv6 block as defined below.</summary>
    [JsonPropertyName("ipv6")]
    public IList<V1beta1ExpressRouteCircuitPeeringSpecInitProviderIpv6>? Ipv6 { get; set; }

    /// <summary>A microsoft_peering_config block as defined below. Required when peering_type is set to MicrosoftPeering and config for IPv4.</summary>
    [JsonPropertyName("microsoftPeeringConfig")]
    public IList<V1beta1ExpressRouteCircuitPeeringSpecInitProviderMicrosoftPeeringConfig>? MicrosoftPeeringConfig { get; set; }

    /// <summary>The Either a 16-bit or a 32-bit ASN. Can either be public or private.</summary>
    [JsonPropertyName("peerAsn")]
    public double? PeerAsn { get; set; }

    /// <summary>A /30 subnet for the primary link. Required when config for IPv4.</summary>
    [JsonPropertyName("primaryPeerAddressPrefix")]
    public string? PrimaryPeerAddressPrefix { get; set; }

    /// <summary>The ID of the Route Filter. Only available when peering_type is set to MicrosoftPeering.</summary>
    [JsonPropertyName("routeFilterId")]
    public string? RouteFilterId { get; set; }

    /// <summary>A /30 subnet for the secondary link. Required when config for IPv4.</summary>
    [JsonPropertyName("secondaryPeerAddressPrefix")]
    public string? SecondaryPeerAddressPrefix { get; set; }

    /// <summary>A valid VLAN ID to establish this peering on.</summary>
    [JsonPropertyName("vlanId")]
    public double? VlanId { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExpressRouteCircuitPeeringSpecProviderConfigRefPolicy
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
public partial class V1beta1ExpressRouteCircuitPeeringSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExpressRouteCircuitPeeringSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExpressRouteCircuitPeeringSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1ExpressRouteCircuitPeeringSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ExpressRouteCircuitPeeringSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExpressRouteCircuitPeeringSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1ExpressRouteCircuitPeeringSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ExpressRouteCircuitPeeringSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ExpressRouteCircuitPeeringSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExpressRouteCircuitPeeringSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ExpressRouteCircuitPeeringSpec defines the desired state of ExpressRouteCircuitPeering</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExpressRouteCircuitPeeringSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ExpressRouteCircuitPeeringSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ExpressRouteCircuitPeeringSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ExpressRouteCircuitPeeringSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ExpressRouteCircuitPeeringSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ExpressRouteCircuitPeeringSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExpressRouteCircuitPeeringStatusAtProviderIpv6MicrosoftPeering
{
    /// <summary>The communities of Bgp Peering specified for microsoft peering.</summary>
    [JsonPropertyName("advertisedCommunities")]
    public IList<string>? AdvertisedCommunities { get; set; }

    /// <summary>A list of Advertised Public Prefixes.</summary>
    [JsonPropertyName("advertisedPublicPrefixes")]
    public IList<string>? AdvertisedPublicPrefixes { get; set; }

    /// <summary>The CustomerASN of the peering. Defaults to 0.</summary>
    [JsonPropertyName("customerAsn")]
    public double? CustomerAsn { get; set; }

    /// <summary>The Routing Registry against which the AS number and prefixes are registered. For example: ARIN, RIPE, AFRINIC etc. Defaults to NONE.</summary>
    [JsonPropertyName("routingRegistryName")]
    public string? RoutingRegistryName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExpressRouteCircuitPeeringStatusAtProviderIpv6
{
    /// <summary>A boolean value indicating whether the IPv6 peering is enabled. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A microsoft_peering block as defined below.</summary>
    [JsonPropertyName("microsoftPeering")]
    public IList<V1beta1ExpressRouteCircuitPeeringStatusAtProviderIpv6MicrosoftPeering>? MicrosoftPeering { get; set; }

    /// <summary>A subnet for the primary link.</summary>
    [JsonPropertyName("primaryPeerAddressPrefix")]
    public string? PrimaryPeerAddressPrefix { get; set; }

    /// <summary>The ID of the Route Filter. Only available when peering_type is set to MicrosoftPeering.</summary>
    [JsonPropertyName("routeFilterId")]
    public string? RouteFilterId { get; set; }

    /// <summary>A subnet for the secondary link.</summary>
    [JsonPropertyName("secondaryPeerAddressPrefix")]
    public string? SecondaryPeerAddressPrefix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExpressRouteCircuitPeeringStatusAtProviderMicrosoftPeeringConfig
{
    /// <summary>The communities of Bgp Peering specified for microsoft peering.</summary>
    [JsonPropertyName("advertisedCommunities")]
    public IList<string>? AdvertisedCommunities { get; set; }

    /// <summary>A list of Advertised Public Prefixes.</summary>
    [JsonPropertyName("advertisedPublicPrefixes")]
    public IList<string>? AdvertisedPublicPrefixes { get; set; }

    /// <summary>The CustomerASN of the peering. Defaults to 0.</summary>
    [JsonPropertyName("customerAsn")]
    public double? CustomerAsn { get; set; }

    /// <summary>The Routing Registry against which the AS number and prefixes are registered. For example: ARIN, RIPE, AFRINIC etc. Defaults to NONE.</summary>
    [JsonPropertyName("routingRegistryName")]
    public string? RoutingRegistryName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExpressRouteCircuitPeeringStatusAtProvider
{
    /// <summary>The ASN used by Azure.</summary>
    [JsonPropertyName("azureAsn")]
    public double? AzureAsn { get; set; }

    /// <summary>The name of the ExpressRoute Circuit in which to create the Peering. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("expressRouteCircuitName")]
    public string? ExpressRouteCircuitName { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gatewayManagerEtag")]
    public string? GatewayManagerEtag { get; set; }

    /// <summary>The ID of the ExpressRoute Circuit Peering.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A boolean value indicating whether the IPv4 peering is enabled. Defaults to true.</summary>
    [JsonPropertyName("ipv4Enabled")]
    public bool? Ipv4Enabled { get; set; }

    /// <summary>A ipv6 block as defined below.</summary>
    [JsonPropertyName("ipv6")]
    public IList<V1beta1ExpressRouteCircuitPeeringStatusAtProviderIpv6>? Ipv6 { get; set; }

    /// <summary>A microsoft_peering_config block as defined below. Required when peering_type is set to MicrosoftPeering and config for IPv4.</summary>
    [JsonPropertyName("microsoftPeeringConfig")]
    public IList<V1beta1ExpressRouteCircuitPeeringStatusAtProviderMicrosoftPeeringConfig>? MicrosoftPeeringConfig { get; set; }

    /// <summary>The Either a 16-bit or a 32-bit ASN. Can either be public or private.</summary>
    [JsonPropertyName("peerAsn")]
    public double? PeerAsn { get; set; }

    /// <summary>The Primary Port used by Azure for this Peering.</summary>
    [JsonPropertyName("primaryAzurePort")]
    public string? PrimaryAzurePort { get; set; }

    /// <summary>A /30 subnet for the primary link. Required when config for IPv4.</summary>
    [JsonPropertyName("primaryPeerAddressPrefix")]
    public string? PrimaryPeerAddressPrefix { get; set; }

    /// <summary>The name of the resource group in which to create the Express Route Circuit Peering. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The ID of the Route Filter. Only available when peering_type is set to MicrosoftPeering.</summary>
    [JsonPropertyName("routeFilterId")]
    public string? RouteFilterId { get; set; }

    /// <summary>The Secondary Port used by Azure for this Peering.</summary>
    [JsonPropertyName("secondaryAzurePort")]
    public string? SecondaryAzurePort { get; set; }

    /// <summary>A /30 subnet for the secondary link. Required when config for IPv4.</summary>
    [JsonPropertyName("secondaryPeerAddressPrefix")]
    public string? SecondaryPeerAddressPrefix { get; set; }

    /// <summary>A valid VLAN ID to establish this peering on.</summary>
    [JsonPropertyName("vlanId")]
    public double? VlanId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExpressRouteCircuitPeeringStatusConditions
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

/// <summary>ExpressRouteCircuitPeeringStatus defines the observed state of ExpressRouteCircuitPeering.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ExpressRouteCircuitPeeringStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ExpressRouteCircuitPeeringStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ExpressRouteCircuitPeeringStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ExpressRouteCircuitPeering is the Schema for the ExpressRouteCircuitPeerings API. Manages an ExpressRoute Circuit Peering.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ExpressRouteCircuitPeering : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ExpressRouteCircuitPeeringSpec>, IStatus<V1beta1ExpressRouteCircuitPeeringStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ExpressRouteCircuitPeering";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "expressroutecircuitpeerings";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ExpressRouteCircuitPeeringSpec defines the desired state of ExpressRouteCircuitPeering</summary>
    [JsonPropertyName("spec")]
    public V1beta1ExpressRouteCircuitPeeringSpec Spec { get; set; }

    /// <summary>ExpressRouteCircuitPeeringStatus defines the observed state of ExpressRouteCircuitPeering.</summary>
    [JsonPropertyName("status")]
    public V1beta1ExpressRouteCircuitPeeringStatus? Status { get; set; }
}

/// <summary>ExpressRouteCircuitPeering is the Schema for the ExpressRouteCircuitPeerings API. Manages an ExpressRoute Circuit Peering.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ExpressRouteCircuitPeeringList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ExpressRouteCircuitPeering>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ExpressRouteCircuitPeeringList";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "expressroutecircuitpeerings";
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
    public IList<V1beta1ExpressRouteCircuitPeering> Items { get; set; }
}