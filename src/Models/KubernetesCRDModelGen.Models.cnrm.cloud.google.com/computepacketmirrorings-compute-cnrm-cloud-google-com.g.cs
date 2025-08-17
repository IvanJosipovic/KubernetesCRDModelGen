using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputePacketMirroringList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ComputePacketMirroring>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputePacketMirroringList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computepacketmirrorings";
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
    public IList<V1beta1ComputePacketMirroring> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputePacketMirroringSpecCollectorIlbUrlRef
{
    /// <summary>Resource URL to the forwarding rule representing the ILB configured as destination of the mirrored traffic.  Allowed value: The `selfLink` field of a `ComputeForwardingRule` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The Forwarding Rule resource of type `loadBalancingScheme=INTERNAL` that will be used as collector for mirrored traffic. The specified forwarding rule must have `isMirroringCollector` set to true.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputePacketMirroringSpecCollectorIlb
{
    /// <summary></summary>
    [JsonPropertyName("urlRef")]
    public V1beta1ComputePacketMirroringSpecCollectorIlbUrlRef UrlRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Filter for mirrored traffic. If unspecified, all traffic is mirrored.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputePacketMirroringSpecFilter
{
    /// <summary>IP CIDR ranges that apply as filter on the source (ingress) or destination (egress) IP in the IP header. Only IPv4 is supported. If no ranges are specified, all traffic that matches the specified IPProtocols is mirrored. If neither cidrRanges nor IPProtocols is specified, all traffic is mirrored.</summary>
    [JsonPropertyName("cidrRanges")]
    public IList<string>? CidrRanges { get; set; }

    /// <summary>Direction of traffic to mirror, either INGRESS, EGRESS, or BOTH. The default is BOTH.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>Protocols that apply as filter on mirrored traffic. If no protocols are specified, all traffic that matches the specified CIDR ranges is mirrored. If neither cidrRanges nor IPProtocols is specified, all traffic is mirrored.</summary>
    [JsonPropertyName("ipProtocols")]
    public IList<string>? IpProtocols { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputePacketMirroringSpecMirroredResourcesInstancesUrlRef
{
    /// <summary>Resource URL to the virtual machine instance which is being mirrored.  Allowed value: The `selfLink` field of a `ComputeInstance` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputePacketMirroringSpecMirroredResourcesInstances
{
    /// <summary>Immutable. Output only. Unique identifier for the instance; defined by the server.</summary>
    [JsonPropertyName("canonicalUrl")]
    public string? CanonicalUrl { get; set; }

    /// <summary></summary>
    [JsonPropertyName("urlRef")]
    public V1beta1ComputePacketMirroringSpecMirroredResourcesInstancesUrlRef? UrlRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputePacketMirroringSpecMirroredResourcesSubnetworksUrlRef
{
    /// <summary>Resource URL to the subnetwork for which traffic from/to all VM instances will be mirrored.  Allowed value: The `selfLink` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputePacketMirroringSpecMirroredResourcesSubnetworks
{
    /// <summary>Immutable. Output only. Unique identifier for the subnetwork; defined by the server.</summary>
    [JsonPropertyName("canonicalUrl")]
    public string? CanonicalUrl { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("urlRef")]
    public V1beta1ComputePacketMirroringSpecMirroredResourcesSubnetworksUrlRef? UrlRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>PacketMirroring mirroredResourceInfos. MirroredResourceInfo specifies a set of mirrored VM instances, subnetworks and/or tags for which traffic from/to all VM instances will be mirrored.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputePacketMirroringSpecMirroredResources
{
    /// <summary>A set of virtual machine instances that are being mirrored. They must live in zones contained in the same region as this packetMirroring. Note that this config will apply only to those network interfaces of the Instances that belong to the network specified in this packetMirroring. You may specify a maximum of 50 Instances.</summary>
    [JsonPropertyName("instances")]
    public IList<V1beta1ComputePacketMirroringSpecMirroredResourcesInstances>? Instances { get; set; }

    /// <summary>Immutable. A set of subnetworks for which traffic from/to all VM instances will be mirrored. They must live in the same region as this packetMirroring. You may specify a maximum of 5 subnetworks.</summary>
    [JsonPropertyName("subnetworks")]
    public IList<V1beta1ComputePacketMirroringSpecMirroredResourcesSubnetworks>? Subnetworks { get; set; }

    /// <summary>A set of mirrored tags. Traffic from/to all VM instances that have one or more of these tags will be mirrored.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputePacketMirroringSpecNetworkUrlRef
{
    /// <summary>URL of the network resource.  Allowed value: The `selfLink` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. Specifies the mirrored VPC network. Only packets in this network will be mirrored. All mirrored VMs should have a NIC in the given network. All mirrored subnetworks should belong to the given network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputePacketMirroringSpecNetwork
{
    /// <summary>Immutable.</summary>
    [JsonPropertyName("urlRef")]
    public V1beta1ComputePacketMirroringSpecNetworkUrlRef UrlRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputePacketMirroringSpecProjectRef
{
    /// <summary>The project for the resource  Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputePacketMirroringSpec
{
    /// <summary>The Forwarding Rule resource of type `loadBalancingScheme=INTERNAL` that will be used as collector for mirrored traffic. The specified forwarding rule must have `isMirroringCollector` set to true.</summary>
    [JsonPropertyName("collectorIlb")]
    public V1beta1ComputePacketMirroringSpecCollectorIlb CollectorIlb { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Indicates whether or not this packet mirroring takes effect. If set to FALSE, this packet mirroring policy will not be enforced on the network. The default is TRUE.</summary>
    [JsonPropertyName("enable")]
    public string? Enable { get; set; }

    /// <summary>Filter for mirrored traffic. If unspecified, all traffic is mirrored.</summary>
    [JsonPropertyName("filter")]
    public V1beta1ComputePacketMirroringSpecFilter? Filter { get; set; }

    /// <summary>Immutable. The location for the resource</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>PacketMirroring mirroredResourceInfos. MirroredResourceInfo specifies a set of mirrored VM instances, subnetworks and/or tags for which traffic from/to all VM instances will be mirrored.</summary>
    [JsonPropertyName("mirroredResources")]
    public V1beta1ComputePacketMirroringSpecMirroredResources MirroredResources { get; set; }

    /// <summary>Immutable. Specifies the mirrored VPC network. Only packets in this network will be mirrored. All mirrored VMs should have a NIC in the given network. All mirrored subnetworks should belong to the given network.</summary>
    [JsonPropertyName("network")]
    public V1beta1ComputePacketMirroringSpecNetwork Network { get; set; }

    /// <summary>The priority of applying this configuration. Priority is used to break ties in cases where there is more than one matching rule. In the case of two rules that apply for a given Instance, the one with the lowest-numbered priority value wins. Default value is 1000. Valid range is 0 through 65535.</summary>
    [JsonPropertyName("priority")]
    public long? Priority { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1ComputePacketMirroringSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputePacketMirroringStatusCollectorIlb
{
    /// <summary>Output only. Unique identifier for the forwarding rule; defined by the server.</summary>
    [JsonPropertyName("canonicalUrl")]
    public string? CanonicalUrl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputePacketMirroringStatusConditions
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputePacketMirroringStatusNetwork
{
    /// <summary>Output only. Unique identifier for the network; defined by the server.</summary>
    [JsonPropertyName("canonicalUrl")]
    public string? CanonicalUrl { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputePacketMirroringStatus
{
    /// <summary></summary>
    [JsonPropertyName("collectorIlb")]
    public V1beta1ComputePacketMirroringStatusCollectorIlb? CollectorIlb { get; set; }

    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputePacketMirroringStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. The unique identifier for the resource. This identifier is defined by the server.</summary>
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    /// <summary></summary>
    [JsonPropertyName("network")]
    public V1beta1ComputePacketMirroringStatusNetwork? Network { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>URI of the region where the packetMirroring resides.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Server-defined URL for the resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputePacketMirroring : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputePacketMirroringSpec>, IStatus<V1beta1ComputePacketMirroringStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputePacketMirroring";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computepacketmirrorings";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public V1beta1ComputePacketMirroringSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ComputePacketMirroringStatus? Status { get; set; }
}
#nullable disable
