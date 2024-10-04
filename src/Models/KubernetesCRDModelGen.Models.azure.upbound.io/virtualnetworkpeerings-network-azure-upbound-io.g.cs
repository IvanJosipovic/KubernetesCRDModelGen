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
public partial class V1beta1VirtualNetworkPeeringSpecForProviderRemoteVirtualNetworkIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a VirtualNetwork in network to populate remoteVirtualNetworkId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkPeeringSpecForProviderRemoteVirtualNetworkIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkPeeringSpecForProviderRemoteVirtualNetworkIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkPeeringSpecForProviderRemoteVirtualNetworkIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a VirtualNetwork in network to populate remoteVirtualNetworkId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkPeeringSpecForProviderRemoteVirtualNetworkIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkPeeringSpecForProviderRemoteVirtualNetworkIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkPeeringSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1VirtualNetworkPeeringSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkPeeringSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkPeeringSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1VirtualNetworkPeeringSpecForProviderResourceGroupNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkPeeringSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkPeeringSpecForProviderVirtualNetworkNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a VirtualNetwork in network to populate virtualNetworkName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkPeeringSpecForProviderVirtualNetworkNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkPeeringSpecForProviderVirtualNetworkNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkPeeringSpecForProviderVirtualNetworkNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a VirtualNetwork in network to populate virtualNetworkName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkPeeringSpecForProviderVirtualNetworkNameSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkPeeringSpecForProviderVirtualNetworkNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkPeeringSpecForProvider
{
    /// <summary>Controls if forwarded traffic from VMs in the remote virtual network is allowed. Defaults to false.</summary>
    [JsonPropertyName("allowForwardedTraffic")]
    public bool? AllowForwardedTraffic { get; set; }

    /// <summary>Controls gatewayLinks can be used in the remote virtual network’s link to the local virtual network. Defaults to false.</summary>
    [JsonPropertyName("allowGatewayTransit")]
    public bool? AllowGatewayTransit { get; set; }

    /// <summary>Controls if the VMs in the remote virtual network can access VMs in the local virtual network. Defaults to true.</summary>
    [JsonPropertyName("allowVirtualNetworkAccess")]
    public bool? AllowVirtualNetworkAccess { get; set; }

    /// <summary>A list of local Subnet names that are Subnet peered with remote Virtual Network.</summary>
    [JsonPropertyName("localSubnetNames")]
    public IList<string>? LocalSubnetNames { get; set; }

    /// <summary>Specifies whether only IPv6 address space is peered for Subnet peering. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("onlyIpv6PeeringEnabled")]
    public bool? OnlyIpv6PeeringEnabled { get; set; }

    /// <summary>Specifies whether complete Virtual Network address space is peered. Defaults to true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("peerCompleteVirtualNetworksEnabled")]
    public bool? PeerCompleteVirtualNetworksEnabled { get; set; }

    /// <summary>A list of remote Subnet names from remote Virtual Network that are Subnet peered.</summary>
    [JsonPropertyName("remoteSubnetNames")]
    public IList<string>? RemoteSubnetNames { get; set; }

    /// <summary>The full Azure resource ID of the remote virtual network. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("remoteVirtualNetworkId")]
    public string? RemoteVirtualNetworkId { get; set; }

    /// <summary>Reference to a VirtualNetwork in network to populate remoteVirtualNetworkId.</summary>
    [JsonPropertyName("remoteVirtualNetworkIdRef")]
    public V1beta1VirtualNetworkPeeringSpecForProviderRemoteVirtualNetworkIdRef? RemoteVirtualNetworkIdRef { get; set; }

    /// <summary>Selector for a VirtualNetwork in network to populate remoteVirtualNetworkId.</summary>
    [JsonPropertyName("remoteVirtualNetworkIdSelector")]
    public V1beta1VirtualNetworkPeeringSpecForProviderRemoteVirtualNetworkIdSelector? RemoteVirtualNetworkIdSelector { get; set; }

    /// <summary>The name of the resource group in which to create the virtual network peering. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1VirtualNetworkPeeringSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1VirtualNetworkPeeringSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A mapping of key values pairs that can be used to sync network routes from the remote virtual network to the local virtual network. See the trigger example for an example on how to set it up.</summary>
    [JsonPropertyName("triggers")]
    public IDictionary<string, string>? Triggers { get; set; }

    /// <summary>Controls if remote gateways can be used on the local virtual network. If the flag is set to true, and allow_gateway_transit on the remote peering is also true, virtual network will use gateways of remote virtual network for transit. Only one peering can have this flag set to true. This flag cannot be set if virtual network already has a gateway. Defaults to false.</summary>
    [JsonPropertyName("useRemoteGateways")]
    public bool? UseRemoteGateways { get; set; }

    /// <summary>The name of the virtual network. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkName")]
    public string? VirtualNetworkName { get; set; }

    /// <summary>Reference to a VirtualNetwork in network to populate virtualNetworkName.</summary>
    [JsonPropertyName("virtualNetworkNameRef")]
    public V1beta1VirtualNetworkPeeringSpecForProviderVirtualNetworkNameRef? VirtualNetworkNameRef { get; set; }

    /// <summary>Selector for a VirtualNetwork in network to populate virtualNetworkName.</summary>
    [JsonPropertyName("virtualNetworkNameSelector")]
    public V1beta1VirtualNetworkPeeringSpecForProviderVirtualNetworkNameSelector? VirtualNetworkNameSelector { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkPeeringSpecInitProviderRemoteVirtualNetworkIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a VirtualNetwork in network to populate remoteVirtualNetworkId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkPeeringSpecInitProviderRemoteVirtualNetworkIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkPeeringSpecInitProviderRemoteVirtualNetworkIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkPeeringSpecInitProviderRemoteVirtualNetworkIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a VirtualNetwork in network to populate remoteVirtualNetworkId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkPeeringSpecInitProviderRemoteVirtualNetworkIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkPeeringSpecInitProviderRemoteVirtualNetworkIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkPeeringSpecInitProvider
{
    /// <summary>Controls if forwarded traffic from VMs in the remote virtual network is allowed. Defaults to false.</summary>
    [JsonPropertyName("allowForwardedTraffic")]
    public bool? AllowForwardedTraffic { get; set; }

    /// <summary>Controls gatewayLinks can be used in the remote virtual network’s link to the local virtual network. Defaults to false.</summary>
    [JsonPropertyName("allowGatewayTransit")]
    public bool? AllowGatewayTransit { get; set; }

    /// <summary>Controls if the VMs in the remote virtual network can access VMs in the local virtual network. Defaults to true.</summary>
    [JsonPropertyName("allowVirtualNetworkAccess")]
    public bool? AllowVirtualNetworkAccess { get; set; }

    /// <summary>A list of local Subnet names that are Subnet peered with remote Virtual Network.</summary>
    [JsonPropertyName("localSubnetNames")]
    public IList<string>? LocalSubnetNames { get; set; }

    /// <summary>Specifies whether only IPv6 address space is peered for Subnet peering. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("onlyIpv6PeeringEnabled")]
    public bool? OnlyIpv6PeeringEnabled { get; set; }

    /// <summary>Specifies whether complete Virtual Network address space is peered. Defaults to true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("peerCompleteVirtualNetworksEnabled")]
    public bool? PeerCompleteVirtualNetworksEnabled { get; set; }

    /// <summary>A list of remote Subnet names from remote Virtual Network that are Subnet peered.</summary>
    [JsonPropertyName("remoteSubnetNames")]
    public IList<string>? RemoteSubnetNames { get; set; }

    /// <summary>The full Azure resource ID of the remote virtual network. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("remoteVirtualNetworkId")]
    public string? RemoteVirtualNetworkId { get; set; }

    /// <summary>Reference to a VirtualNetwork in network to populate remoteVirtualNetworkId.</summary>
    [JsonPropertyName("remoteVirtualNetworkIdRef")]
    public V1beta1VirtualNetworkPeeringSpecInitProviderRemoteVirtualNetworkIdRef? RemoteVirtualNetworkIdRef { get; set; }

    /// <summary>Selector for a VirtualNetwork in network to populate remoteVirtualNetworkId.</summary>
    [JsonPropertyName("remoteVirtualNetworkIdSelector")]
    public V1beta1VirtualNetworkPeeringSpecInitProviderRemoteVirtualNetworkIdSelector? RemoteVirtualNetworkIdSelector { get; set; }

    /// <summary>A mapping of key values pairs that can be used to sync network routes from the remote virtual network to the local virtual network. See the trigger example for an example on how to set it up.</summary>
    [JsonPropertyName("triggers")]
    public IDictionary<string, string>? Triggers { get; set; }

    /// <summary>Controls if remote gateways can be used on the local virtual network. If the flag is set to true, and allow_gateway_transit on the remote peering is also true, virtual network will use gateways of remote virtual network for transit. Only one peering can have this flag set to true. This flag cannot be set if virtual network already has a gateway. Defaults to false.</summary>
    [JsonPropertyName("useRemoteGateways")]
    public bool? UseRemoteGateways { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkPeeringSpecProviderConfigRefPolicy
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
public partial class V1beta1VirtualNetworkPeeringSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkPeeringSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkPeeringSpecPublishConnectionDetailsToConfigRefPolicy
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
public partial class V1beta1VirtualNetworkPeeringSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1VirtualNetworkPeeringSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkPeeringSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1VirtualNetworkPeeringSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1VirtualNetworkPeeringSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1VirtualNetworkPeeringSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkPeeringSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>VirtualNetworkPeeringSpec defines the desired state of VirtualNetworkPeering</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkPeeringSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1VirtualNetworkPeeringSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1VirtualNetworkPeeringSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1VirtualNetworkPeeringSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1VirtualNetworkPeeringSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1VirtualNetworkPeeringSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkPeeringStatusAtProvider
{
    /// <summary>Controls if forwarded traffic from VMs in the remote virtual network is allowed. Defaults to false.</summary>
    [JsonPropertyName("allowForwardedTraffic")]
    public bool? AllowForwardedTraffic { get; set; }

    /// <summary>Controls gatewayLinks can be used in the remote virtual network’s link to the local virtual network. Defaults to false.</summary>
    [JsonPropertyName("allowGatewayTransit")]
    public bool? AllowGatewayTransit { get; set; }

    /// <summary>Controls if the VMs in the remote virtual network can access VMs in the local virtual network. Defaults to true.</summary>
    [JsonPropertyName("allowVirtualNetworkAccess")]
    public bool? AllowVirtualNetworkAccess { get; set; }

    /// <summary>The ID of the Virtual Network Peering.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A list of local Subnet names that are Subnet peered with remote Virtual Network.</summary>
    [JsonPropertyName("localSubnetNames")]
    public IList<string>? LocalSubnetNames { get; set; }

    /// <summary>Specifies whether only IPv6 address space is peered for Subnet peering. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("onlyIpv6PeeringEnabled")]
    public bool? OnlyIpv6PeeringEnabled { get; set; }

    /// <summary>Specifies whether complete Virtual Network address space is peered. Defaults to true. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("peerCompleteVirtualNetworksEnabled")]
    public bool? PeerCompleteVirtualNetworksEnabled { get; set; }

    /// <summary>A list of remote Subnet names from remote Virtual Network that are Subnet peered.</summary>
    [JsonPropertyName("remoteSubnetNames")]
    public IList<string>? RemoteSubnetNames { get; set; }

    /// <summary>The full Azure resource ID of the remote virtual network. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("remoteVirtualNetworkId")]
    public string? RemoteVirtualNetworkId { get; set; }

    /// <summary>The name of the resource group in which to create the virtual network peering. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A mapping of key values pairs that can be used to sync network routes from the remote virtual network to the local virtual network. See the trigger example for an example on how to set it up.</summary>
    [JsonPropertyName("triggers")]
    public IDictionary<string, string>? Triggers { get; set; }

    /// <summary>Controls if remote gateways can be used on the local virtual network. If the flag is set to true, and allow_gateway_transit on the remote peering is also true, virtual network will use gateways of remote virtual network for transit. Only one peering can have this flag set to true. This flag cannot be set if virtual network already has a gateway. Defaults to false.</summary>
    [JsonPropertyName("useRemoteGateways")]
    public bool? UseRemoteGateways { get; set; }

    /// <summary>The name of the virtual network. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("virtualNetworkName")]
    public string? VirtualNetworkName { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkPeeringStatusConditions
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

/// <summary>VirtualNetworkPeeringStatus defines the observed state of VirtualNetworkPeering.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VirtualNetworkPeeringStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1VirtualNetworkPeeringStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VirtualNetworkPeeringStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>VirtualNetworkPeering is the Schema for the VirtualNetworkPeerings API. Manages a virtual network peering which allows resources to access other resources in the linked virtual network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VirtualNetworkPeering : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VirtualNetworkPeeringSpec>, IStatus<V1beta1VirtualNetworkPeeringStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VirtualNetworkPeering";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "virtualnetworkpeerings";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VirtualNetworkPeeringSpec defines the desired state of VirtualNetworkPeering</summary>
    [JsonPropertyName("spec")]
    public V1beta1VirtualNetworkPeeringSpec Spec { get; set; }

    /// <summary>VirtualNetworkPeeringStatus defines the observed state of VirtualNetworkPeering.</summary>
    [JsonPropertyName("status")]
    public V1beta1VirtualNetworkPeeringStatus? Status { get; set; }
}