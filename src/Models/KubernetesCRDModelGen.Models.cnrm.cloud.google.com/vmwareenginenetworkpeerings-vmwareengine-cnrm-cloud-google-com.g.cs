using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.vmwareengine.cnrm.cloud.google.com;
/// <summary>Reference to a ComputeNetwork. Exactly one of VMwareEngineNetworkRef or ComputeNetworkRef must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEngineNetworkPeeringSpecPeerNetworkComputeNetworkRef
{
    /// <summary>A reference to an externally managed Compute Network resource. Should be in the format `projects/{{projectID}}/global/networks/{{network}}`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference to a VmwareEngineNetwork. Exactly one of VMwareEngineNetworkRef or ComputeNetworkRef must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEngineNetworkPeeringSpecPeerNetworkVmwareEngineNetworkRef
{
    /// <summary>A reference to an externally managed VMwareEngineNetwork resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/vmwareEngineNetworks/{{vmwareenginenetworkID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a VMwareEngineNetwork resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a VMwareEngineNetwork resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. The name of the network to peer with a standard VMware Engine network. The provided network can be a consumer VPC network or another standard VMware Engine network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEngineNetworkPeeringSpecPeerNetwork
{
    /// <summary>Reference to a ComputeNetwork. Exactly one of VMwareEngineNetworkRef or ComputeNetworkRef must be specified.</summary>
    [JsonPropertyName("computeNetworkRef")]
    public V1alpha1VMwareEngineNetworkPeeringSpecPeerNetworkComputeNetworkRef? ComputeNetworkRef { get; set; }

    /// <summary>Reference to a VmwareEngineNetwork. Exactly one of VMwareEngineNetworkRef or ComputeNetworkRef must be specified.</summary>
    [JsonPropertyName("vmwareEngineNetworkRef")]
    public V1alpha1VMwareEngineNetworkPeeringSpecPeerNetworkVmwareEngineNetworkRef? VmwareEngineNetworkRef { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEngineNetworkPeeringSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. The relative resource name of the VMware Engine network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEngineNetworkPeeringSpecVmwareEngineNetworkRef
{
    /// <summary>A reference to an externally managed VMwareEngineNetwork resource. Should be in the format "projects/{{projectID}}/locations/{{location}}/vmwareEngineNetworks/{{vmwareenginenetworkID}}".</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a VMwareEngineNetwork resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a VMwareEngineNetwork resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>VMwareEngineNetworkPeeringSpec defines the desired state of VMwareEngineNetworkPeering</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEngineNetworkPeeringSpec
{
    /// <summary>Optional. User-provided description for this network peering.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Optional. True if full mesh connectivity is created and managed automatically between peered networks; false otherwise. Currently this field is always true because Google Compute Engine automatically creates and manages subnetwork routes between two VPC networks when peering state is 'ACTIVE'.</summary>
    [JsonPropertyName("exchangeSubnetRoutes")]
    public bool? ExchangeSubnetRoutes { get; set; }

    /// <summary>Optional. True if custom routes are exported to the peered network; false otherwise. The default value is true.</summary>
    [JsonPropertyName("exportCustomRoutes")]
    public bool? ExportCustomRoutes { get; set; }

    /// <summary>Optional. True if all subnet routes with a public IP address range are exported; false otherwise. The default value is true. IPv4 special-use ranges (https://en.wikipedia.org/wiki/IPv4#Special_addresses) are always exported to peers and are not controlled by this field.</summary>
    [JsonPropertyName("exportCustomRoutesWithPublicIP")]
    public bool? ExportCustomRoutesWithPublicIP { get; set; }

    /// <summary>Optional. True if custom routes are imported from the peered network; false otherwise. The default value is true.</summary>
    [JsonPropertyName("importCustomRoutes")]
    public bool? ImportCustomRoutes { get; set; }

    /// <summary>Optional. True if all subnet routes with public IP address range are imported; false otherwise. The default value is true. IPv4 special-use ranges (https://en.wikipedia.org/wiki/IPv4#Special_addresses) are always imported to peers and are not controlled by this field.</summary>
    [JsonPropertyName("importCustomRoutesWithPublicIP")]
    public bool? ImportCustomRoutesWithPublicIP { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Optional. Maximum transmission unit (MTU) in bytes. The default value is `1500`. If a value of `0` is provided for this field, VMware Engine uses the default value instead.</summary>
    [JsonPropertyName("peerMTU")]
    public int? PeerMTU { get; set; }

    /// <summary>Required. The name of the network to peer with a standard VMware Engine network. The provided network can be a consumer VPC network or another standard VMware Engine network.</summary>
    [JsonPropertyName("peerNetwork")]
    public V1alpha1VMwareEngineNetworkPeeringSpecPeerNetwork PeerNetwork { get; set; }

    /// <summary>Required. The type of the network to peer with the VMware Engine network.</summary>
    [JsonPropertyName("peerNetworkType")]
    public string PeerNetworkType { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1VMwareEngineNetworkPeeringSpecProjectRef ProjectRef { get; set; }

    /// <summary>The VMwareEngineNetworkPeering name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. The relative resource name of the VMware Engine network.</summary>
    [JsonPropertyName("vmwareEngineNetworkRef")]
    public V1alpha1VMwareEngineNetworkPeeringSpecVmwareEngineNetworkRef VmwareEngineNetworkRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEngineNetworkPeeringStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEngineNetworkPeeringStatusObservedState
{
    /// <summary>Output only. Creation time of this resource.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. State of the network peering. This field has a value of 'ACTIVE' when there's a matching configuration in the peer network. New values may be added to this enum when appropriate.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Output Only. Details about the current state of the network peering.</summary>
    [JsonPropertyName("stateDetails")]
    public string? StateDetails { get; set; }

    /// <summary>Output only. System-generated unique identifier for the resource.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. Last update time of this resource.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>VMwareEngineNetworkPeeringStatus defines the config connector machine state of VMwareEngineNetworkPeering</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VMwareEngineNetworkPeeringStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1VMwareEngineNetworkPeeringStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the VMwareEngineNetworkPeering resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1VMwareEngineNetworkPeeringStatusObservedState? ObservedState { get; set; }
}

/// <summary>VMwareEngineNetworkPeering is the Schema for the VMwareEngineNetworkPeering API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VMwareEngineNetworkPeering : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1VMwareEngineNetworkPeeringSpec>, IStatus<V1alpha1VMwareEngineNetworkPeeringStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VMwareEngineNetworkPeering";
    public const string KubeGroup = "vmwareengine.cnrm.cloud.google.com";
    public const string KubePluralName = "vmwareenginenetworkpeerings";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VMwareEngineNetworkPeeringSpec defines the desired state of VMwareEngineNetworkPeering</summary>
    [JsonPropertyName("spec")]
    public V1alpha1VMwareEngineNetworkPeeringSpec Spec { get; set; }

    /// <summary>VMwareEngineNetworkPeeringStatus defines the config connector machine state of VMwareEngineNetworkPeering</summary>
    [JsonPropertyName("status")]
    public V1alpha1VMwareEngineNetworkPeeringStatus? Status { get; set; }
}

/// <summary>VMwareEngineNetworkPeering is the Schema for the VMwareEngineNetworkPeering API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VMwareEngineNetworkPeeringList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1VMwareEngineNetworkPeering>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VMwareEngineNetworkPeeringList";
    public const string KubeGroup = "vmwareengine.cnrm.cloud.google.com";
    public const string KubePluralName = "vmwareenginenetworkpeerings";
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
    public IList<V1alpha1VMwareEngineNetworkPeering> Items { get; set; }
}