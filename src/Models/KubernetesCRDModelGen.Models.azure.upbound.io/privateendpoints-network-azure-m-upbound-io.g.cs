using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.m.upbound.io;
/// <summary>PrivateEndpoint is the Schema for the PrivateEndpoints API. Manages a Private Endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PrivateEndpointList : IKubernetesObject<V1ListMeta>, IItems<V1beta1PrivateEndpoint>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PrivateEndpointList";
    public const string KubeGroup = "network.azure.m.upbound.io";
    public const string KubePluralName = "privateendpoints";
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
    public IList<V1beta1PrivateEndpoint> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointSpecForProviderIpConfiguration
{
    /// <summary>Specifies the member name this IP address applies to. If it is not specified, it will use the value of subresource_name. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("memberName")]
    public string? MemberName { get; set; }

    /// <summary>Specifies the Name of the IP Configuration. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the static IP address within the private endpoint's subnet to be used. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>Specifies the subresource this IP address applies to. subresource_names corresponds to group_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subresourceName")]
    public string? SubresourceName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointSpecForProviderPrivateDnsZoneGroupPrivateDnsZoneIdsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointSpecForProviderPrivateDnsZoneGroupPrivateDnsZoneIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivateEndpointSpecForProviderPrivateDnsZoneGroupPrivateDnsZoneIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointSpecForProviderPrivateDnsZoneGroupPrivateDnsZoneIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of PrivateDNSZone in network to populate privateDnsZoneIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointSpecForProviderPrivateDnsZoneGroupPrivateDnsZoneIdsSelector
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
    public V1beta1PrivateEndpointSpecForProviderPrivateDnsZoneGroupPrivateDnsZoneIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>A private_dns_zone_group block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointSpecForProviderPrivateDnsZoneGroup
{
    /// <summary>Specifies the Name of the Private DNS Zone Group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the list of Private DNS Zones to include within the private_dns_zone_group.</summary>
    [JsonPropertyName("privateDnsZoneIds")]
    public IList<string>? PrivateDnsZoneIds { get; set; }

    /// <summary>References to PrivateDNSZone in network to populate privateDnsZoneIds.</summary>
    [JsonPropertyName("privateDnsZoneIdsRefs")]
    public IList<V1beta1PrivateEndpointSpecForProviderPrivateDnsZoneGroupPrivateDnsZoneIdsRefs>? PrivateDnsZoneIdsRefs { get; set; }

    /// <summary>Selector for a list of PrivateDNSZone in network to populate privateDnsZoneIds.</summary>
    [JsonPropertyName("privateDnsZoneIdsSelector")]
    public V1beta1PrivateEndpointSpecForProviderPrivateDnsZoneGroupPrivateDnsZoneIdsSelector? PrivateDnsZoneIdsSelector { get; set; }
}

/// <summary>A private_service_connection block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointSpecForProviderPrivateServiceConnection
{
    /// <summary>Does the Private Endpoint require Manual Approval from the remote resource owner? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("isManualConnection")]
    public bool? IsManualConnection { get; set; }

    /// <summary>Specifies the Name of the Private Service Connection. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Service Alias of the Private Link Enabled Remote Resource which this Private Endpoint should be connected to. One of private_connection_resource_id or private_connection_resource_alias must be specified. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateConnectionResourceAlias")]
    public string? PrivateConnectionResourceAlias { get; set; }

    /// <summary>The ID of the Private Link Enabled Remote Resource which this Private Endpoint should be connected to. One of private_connection_resource_id or private_connection_resource_alias must be specified. Changing this forces a new resource to be created. For a web app or function app slot, the parent web app should be used in this field instead of a reference to the slot itself.</summary>
    [JsonPropertyName("privateConnectionResourceId")]
    public string? PrivateConnectionResourceId { get; set; }

    /// <summary>A message passed to the owner of the remote resource when the private endpoint attempts to establish the connection to the remote resource. The provider allows a maximum request message length of 140 characters, however the request message maximum length is dependent on the service the private endpoint is connected to. Only valid if is_manual_connection is set to true.</summary>
    [JsonPropertyName("requestMessage")]
    public string? RequestMessage { get; set; }

    /// <summary>A list of subresource names which the Private Endpoint is able to connect to. subresource_names corresponds to group_id. Possible values are detailed in the product documentation in the Subresources column. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subresourceNames")]
    public IList<string>? SubresourceNames { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointSpecForProviderResourceGroupNameRefPolicy
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
public partial class V1beta1PrivateEndpointSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivateEndpointSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointSpecForProviderResourceGroupNameSelectorPolicy
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
public partial class V1beta1PrivateEndpointSpecForProviderResourceGroupNameSelector
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
    public V1beta1PrivateEndpointSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointSpecForProviderSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointSpecForProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivateEndpointSpecForProviderSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointSpecForProviderSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointSpecForProviderSubnetIdSelector
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
    public V1beta1PrivateEndpointSpecForProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointSpecForProvider
{
    /// <summary>The custom name of the network interface attached to the private endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("customNetworkInterfaceName")]
    public string? CustomNetworkInterfaceName { get; set; }

    /// <summary>One or more ip_configuration blocks as defined below. This allows a static IP address to be set for this Private Endpoint, otherwise an address is dynamically allocated from the Subnet.</summary>
    [JsonPropertyName("ipConfiguration")]
    public IList<V1beta1PrivateEndpointSpecForProviderIpConfiguration>? IpConfiguration { get; set; }

    /// <summary>The supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A private_dns_zone_group block as defined below.</summary>
    [JsonPropertyName("privateDnsZoneGroup")]
    public V1beta1PrivateEndpointSpecForProviderPrivateDnsZoneGroup? PrivateDnsZoneGroup { get; set; }

    /// <summary>A private_service_connection block as defined below.</summary>
    [JsonPropertyName("privateServiceConnection")]
    public V1beta1PrivateEndpointSpecForProviderPrivateServiceConnection? PrivateServiceConnection { get; set; }

    /// <summary>Specifies the Name of the Resource Group within which the Private Endpoint should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1PrivateEndpointSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1PrivateEndpointSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The ID of the Subnet from which Private IP Addresses will be allocated for this Private Endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1PrivateEndpointSpecForProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1PrivateEndpointSpecForProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointSpecInitProviderIpConfiguration
{
    /// <summary>Specifies the member name this IP address applies to. If it is not specified, it will use the value of subresource_name. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("memberName")]
    public string? MemberName { get; set; }

    /// <summary>Specifies the Name of the IP Configuration. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the static IP address within the private endpoint's subnet to be used. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>Specifies the subresource this IP address applies to. subresource_names corresponds to group_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subresourceName")]
    public string? SubresourceName { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointSpecInitProviderPrivateDnsZoneGroupPrivateDnsZoneIdsRefsPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointSpecInitProviderPrivateDnsZoneGroupPrivateDnsZoneIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivateEndpointSpecInitProviderPrivateDnsZoneGroupPrivateDnsZoneIdsRefsPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointSpecInitProviderPrivateDnsZoneGroupPrivateDnsZoneIdsSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a list of PrivateDNSZone in network to populate privateDnsZoneIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointSpecInitProviderPrivateDnsZoneGroupPrivateDnsZoneIdsSelector
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
    public V1beta1PrivateEndpointSpecInitProviderPrivateDnsZoneGroupPrivateDnsZoneIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>A private_dns_zone_group block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointSpecInitProviderPrivateDnsZoneGroup
{
    /// <summary>Specifies the Name of the Private DNS Zone Group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the list of Private DNS Zones to include within the private_dns_zone_group.</summary>
    [JsonPropertyName("privateDnsZoneIds")]
    public IList<string>? PrivateDnsZoneIds { get; set; }

    /// <summary>References to PrivateDNSZone in network to populate privateDnsZoneIds.</summary>
    [JsonPropertyName("privateDnsZoneIdsRefs")]
    public IList<V1beta1PrivateEndpointSpecInitProviderPrivateDnsZoneGroupPrivateDnsZoneIdsRefs>? PrivateDnsZoneIdsRefs { get; set; }

    /// <summary>Selector for a list of PrivateDNSZone in network to populate privateDnsZoneIds.</summary>
    [JsonPropertyName("privateDnsZoneIdsSelector")]
    public V1beta1PrivateEndpointSpecInitProviderPrivateDnsZoneGroupPrivateDnsZoneIdsSelector? PrivateDnsZoneIdsSelector { get; set; }
}

/// <summary>A private_service_connection block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointSpecInitProviderPrivateServiceConnection
{
    /// <summary>Does the Private Endpoint require Manual Approval from the remote resource owner? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("isManualConnection")]
    public bool? IsManualConnection { get; set; }

    /// <summary>Specifies the Name of the Private Service Connection. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Service Alias of the Private Link Enabled Remote Resource which this Private Endpoint should be connected to. One of private_connection_resource_id or private_connection_resource_alias must be specified. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateConnectionResourceAlias")]
    public string? PrivateConnectionResourceAlias { get; set; }

    /// <summary>The ID of the Private Link Enabled Remote Resource which this Private Endpoint should be connected to. One of private_connection_resource_id or private_connection_resource_alias must be specified. Changing this forces a new resource to be created. For a web app or function app slot, the parent web app should be used in this field instead of a reference to the slot itself.</summary>
    [JsonPropertyName("privateConnectionResourceId")]
    public string? PrivateConnectionResourceId { get; set; }

    /// <summary>A message passed to the owner of the remote resource when the private endpoint attempts to establish the connection to the remote resource. The provider allows a maximum request message length of 140 characters, however the request message maximum length is dependent on the service the private endpoint is connected to. Only valid if is_manual_connection is set to true.</summary>
    [JsonPropertyName("requestMessage")]
    public string? RequestMessage { get; set; }

    /// <summary>A list of subresource names which the Private Endpoint is able to connect to. subresource_names corresponds to group_id. Possible values are detailed in the product documentation in the Subresources column. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subresourceNames")]
    public IList<string>? SubresourceNames { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointSpecInitProviderSubnetIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointSpecInitProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PrivateEndpointSpecInitProviderSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointSpecInitProviderSubnetIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in network to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointSpecInitProviderSubnetIdSelector
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
    public V1beta1PrivateEndpointSpecInitProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointSpecInitProvider
{
    /// <summary>The custom name of the network interface attached to the private endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("customNetworkInterfaceName")]
    public string? CustomNetworkInterfaceName { get; set; }

    /// <summary>One or more ip_configuration blocks as defined below. This allows a static IP address to be set for this Private Endpoint, otherwise an address is dynamically allocated from the Subnet.</summary>
    [JsonPropertyName("ipConfiguration")]
    public IList<V1beta1PrivateEndpointSpecInitProviderIpConfiguration>? IpConfiguration { get; set; }

    /// <summary>The supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A private_dns_zone_group block as defined below.</summary>
    [JsonPropertyName("privateDnsZoneGroup")]
    public V1beta1PrivateEndpointSpecInitProviderPrivateDnsZoneGroup? PrivateDnsZoneGroup { get; set; }

    /// <summary>A private_service_connection block as defined below.</summary>
    [JsonPropertyName("privateServiceConnection")]
    public V1beta1PrivateEndpointSpecInitProviderPrivateServiceConnection? PrivateServiceConnection { get; set; }

    /// <summary>The ID of the Subnet from which Private IP Addresses will be allocated for this Private Endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta1PrivateEndpointSpecInitProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in network to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1PrivateEndpointSpecInitProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>PrivateEndpointSpec defines the desired state of PrivateEndpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PrivateEndpointSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PrivateEndpointSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PrivateEndpointSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PrivateEndpointSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointStatusAtProviderCustomDnsConfigs
{
    /// <summary>The fully qualified domain name to the private_endpoint.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>A list of all IP Addresses that map to the private_endpoint fqdn.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointStatusAtProviderIpConfiguration
{
    /// <summary>Specifies the member name this IP address applies to. If it is not specified, it will use the value of subresource_name. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("memberName")]
    public string? MemberName { get; set; }

    /// <summary>Specifies the Name of the IP Configuration. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the static IP address within the private endpoint's subnet to be used. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>Specifies the subresource this IP address applies to. subresource_names corresponds to group_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subresourceName")]
    public string? SubresourceName { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointStatusAtProviderNetworkInterface
{
    /// <summary>The ID of the network interface associated with the private_endpoint.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the network interface associated with the private_endpoint.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointStatusAtProviderPrivateDnsZoneConfigsRecordSets
{
    /// <summary>The fully qualified domain name to the private_dns_zone.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>A list of all IP Addresses that map to the private_dns_zone fqdn.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }

    /// <summary>The name of the Private DNS Zone that the config belongs to.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The time to live for each connection to the private_dns_zone.</summary>
    [JsonPropertyName("ttl")]
    public double? Ttl { get; set; }

    /// <summary>The type of DNS record.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointStatusAtProviderPrivateDnsZoneConfigs
{
    /// <summary>The ID of the Private DNS Zone Config.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the Private DNS Zone that the config belongs to.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of IP Addresses</summary>
    [JsonPropertyName("privateDnsZoneId")]
    public string? PrivateDnsZoneId { get; set; }

    /// <summary>A record_sets block as defined below.</summary>
    [JsonPropertyName("recordSets")]
    public IList<V1beta1PrivateEndpointStatusAtProviderPrivateDnsZoneConfigsRecordSets>? RecordSets { get; set; }
}

/// <summary>A private_dns_zone_group block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointStatusAtProviderPrivateDnsZoneGroup
{
    /// <summary>The ID of the Private DNS Zone Group.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the Name of the Private DNS Zone Group.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specifies the list of Private DNS Zones to include within the private_dns_zone_group.</summary>
    [JsonPropertyName("privateDnsZoneIds")]
    public IList<string>? PrivateDnsZoneIds { get; set; }
}

/// <summary>A private_service_connection block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointStatusAtProviderPrivateServiceConnection
{
    /// <summary>Does the Private Endpoint require Manual Approval from the remote resource owner? Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("isManualConnection")]
    public bool? IsManualConnection { get; set; }

    /// <summary>Specifies the Name of the Private Service Connection. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Service Alias of the Private Link Enabled Remote Resource which this Private Endpoint should be connected to. One of private_connection_resource_id or private_connection_resource_alias must be specified. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privateConnectionResourceAlias")]
    public string? PrivateConnectionResourceAlias { get; set; }

    /// <summary>The ID of the Private Link Enabled Remote Resource which this Private Endpoint should be connected to. One of private_connection_resource_id or private_connection_resource_alias must be specified. Changing this forces a new resource to be created. For a web app or function app slot, the parent web app should be used in this field instead of a reference to the slot itself.</summary>
    [JsonPropertyName("privateConnectionResourceId")]
    public string? PrivateConnectionResourceId { get; set; }

    /// <summary>(Computed) The private IP address associated with the private endpoint, note that you will have a private IP address assigned to the private endpoint even if the connection request was Rejected.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>A message passed to the owner of the remote resource when the private endpoint attempts to establish the connection to the remote resource. The provider allows a maximum request message length of 140 characters, however the request message maximum length is dependent on the service the private endpoint is connected to. Only valid if is_manual_connection is set to true.</summary>
    [JsonPropertyName("requestMessage")]
    public string? RequestMessage { get; set; }

    /// <summary>A list of subresource names which the Private Endpoint is able to connect to. subresource_names corresponds to group_id. Possible values are detailed in the product documentation in the Subresources column. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subresourceNames")]
    public IList<string>? SubresourceNames { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointStatusAtProvider
{
    /// <summary>A custom_dns_configs block as defined below.</summary>
    [JsonPropertyName("customDnsConfigs")]
    public IList<V1beta1PrivateEndpointStatusAtProviderCustomDnsConfigs>? CustomDnsConfigs { get; set; }

    /// <summary>The custom name of the network interface attached to the private endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("customNetworkInterfaceName")]
    public string? CustomNetworkInterfaceName { get; set; }

    /// <summary>The ID of the Private Endpoint.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>One or more ip_configuration blocks as defined below. This allows a static IP address to be set for this Private Endpoint, otherwise an address is dynamically allocated from the Subnet.</summary>
    [JsonPropertyName("ipConfiguration")]
    public IList<V1beta1PrivateEndpointStatusAtProviderIpConfiguration>? IpConfiguration { get; set; }

    /// <summary>The supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A network_interface block as defined below.</summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta1PrivateEndpointStatusAtProviderNetworkInterface>? NetworkInterface { get; set; }

    /// <summary>A private_dns_zone_configs block as defined below.</summary>
    [JsonPropertyName("privateDnsZoneConfigs")]
    public IList<V1beta1PrivateEndpointStatusAtProviderPrivateDnsZoneConfigs>? PrivateDnsZoneConfigs { get; set; }

    /// <summary>A private_dns_zone_group block as defined below.</summary>
    [JsonPropertyName("privateDnsZoneGroup")]
    public V1beta1PrivateEndpointStatusAtProviderPrivateDnsZoneGroup? PrivateDnsZoneGroup { get; set; }

    /// <summary>A private_service_connection block as defined below.</summary>
    [JsonPropertyName("privateServiceConnection")]
    public V1beta1PrivateEndpointStatusAtProviderPrivateServiceConnection? PrivateServiceConnection { get; set; }

    /// <summary>Specifies the Name of the Resource Group within which the Private Endpoint should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The ID of the Subnet from which Private IP Addresses will be allocated for this Private Endpoint. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointStatusConditions
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

/// <summary>PrivateEndpointStatus defines the observed state of PrivateEndpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateEndpointStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1PrivateEndpointStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PrivateEndpointStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>PrivateEndpoint is the Schema for the PrivateEndpoints API. Manages a Private Endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PrivateEndpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PrivateEndpointSpec>, IStatus<V1beta1PrivateEndpointStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PrivateEndpoint";
    public const string KubeGroup = "network.azure.m.upbound.io";
    public const string KubePluralName = "privateendpoints";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PrivateEndpointSpec defines the desired state of PrivateEndpoint</summary>
    [JsonPropertyName("spec")]
    public V1beta1PrivateEndpointSpec Spec { get; set; }

    /// <summary>PrivateEndpointStatus defines the observed state of PrivateEndpoint.</summary>
    [JsonPropertyName("status")]
    public V1beta1PrivateEndpointStatus? Status { get; set; }
}