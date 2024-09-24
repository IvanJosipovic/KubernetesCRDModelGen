using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.upbound.io;
public enum V1beta1PacketMirroringSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    /// <summary>Orphan</summary>
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete
}

public enum V1beta1PacketMirroringSpecForProviderCollectorIlbUrlRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PacketMirroringSpecForProviderCollectorIlbUrlRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PacketMirroringSpecForProviderCollectorIlbUrlRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PacketMirroringSpecForProviderCollectorIlbUrlRefPolicyResolutionEnum>))]
    public V1beta1PacketMirroringSpecForProviderCollectorIlbUrlRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PacketMirroringSpecForProviderCollectorIlbUrlRefPolicyResolveEnum>))]
    public V1beta1PacketMirroringSpecForProviderCollectorIlbUrlRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ForwardingRule in compute to populate url.</summary>
public partial class V1beta1PacketMirroringSpecForProviderCollectorIlbUrlRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PacketMirroringSpecForProviderCollectorIlbUrlRefPolicy? Policy { get; set; }
}

public enum V1beta1PacketMirroringSpecForProviderCollectorIlbUrlSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PacketMirroringSpecForProviderCollectorIlbUrlSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1PacketMirroringSpecForProviderCollectorIlbUrlSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PacketMirroringSpecForProviderCollectorIlbUrlSelectorPolicyResolutionEnum>))]
    public V1beta1PacketMirroringSpecForProviderCollectorIlbUrlSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PacketMirroringSpecForProviderCollectorIlbUrlSelectorPolicyResolveEnum>))]
    public V1beta1PacketMirroringSpecForProviderCollectorIlbUrlSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ForwardingRule in compute to populate url.</summary>
public partial class V1beta1PacketMirroringSpecForProviderCollectorIlbUrlSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PacketMirroringSpecForProviderCollectorIlbUrlSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1PacketMirroringSpecForProviderCollectorIlb
{
    /// <summary>The URL of the forwarding rule.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Reference to a ForwardingRule in compute to populate url.</summary>
    [JsonPropertyName("urlRef")]
    public V1beta1PacketMirroringSpecForProviderCollectorIlbUrlRef? UrlRef { get; set; }

    /// <summary>Selector for a ForwardingRule in compute to populate url.</summary>
    [JsonPropertyName("urlSelector")]
    public V1beta1PacketMirroringSpecForProviderCollectorIlbUrlSelector? UrlSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1PacketMirroringSpecForProviderFilter
{
    /// <summary>IP CIDR ranges that apply as a filter on the source (ingress) or destination (egress) IP in the IP header. Only IPv4 is supported.</summary>
    [JsonPropertyName("cidrRanges")]
    public IList<string>? CidrRanges { get; set; }

    /// <summary>Direction of traffic to mirror. Default value is BOTH. Possible values are: INGRESS, EGRESS, BOTH.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>Possible IP protocols including tcp, udp, icmp and esp</summary>
    [JsonPropertyName("ipProtocols")]
    public IList<string>? IpProtocols { get; set; }
}

public enum V1beta1PacketMirroringSpecForProviderMirroredResourcesInstancesUrlRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PacketMirroringSpecForProviderMirroredResourcesInstancesUrlRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PacketMirroringSpecForProviderMirroredResourcesInstancesUrlRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PacketMirroringSpecForProviderMirroredResourcesInstancesUrlRefPolicyResolutionEnum>))]
    public V1beta1PacketMirroringSpecForProviderMirroredResourcesInstancesUrlRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PacketMirroringSpecForProviderMirroredResourcesInstancesUrlRefPolicyResolveEnum>))]
    public V1beta1PacketMirroringSpecForProviderMirroredResourcesInstancesUrlRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Instance in compute to populate url.</summary>
public partial class V1beta1PacketMirroringSpecForProviderMirroredResourcesInstancesUrlRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PacketMirroringSpecForProviderMirroredResourcesInstancesUrlRefPolicy? Policy { get; set; }
}

public enum V1beta1PacketMirroringSpecForProviderMirroredResourcesInstancesUrlSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PacketMirroringSpecForProviderMirroredResourcesInstancesUrlSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1PacketMirroringSpecForProviderMirroredResourcesInstancesUrlSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PacketMirroringSpecForProviderMirroredResourcesInstancesUrlSelectorPolicyResolutionEnum>))]
    public V1beta1PacketMirroringSpecForProviderMirroredResourcesInstancesUrlSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PacketMirroringSpecForProviderMirroredResourcesInstancesUrlSelectorPolicyResolveEnum>))]
    public V1beta1PacketMirroringSpecForProviderMirroredResourcesInstancesUrlSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Instance in compute to populate url.</summary>
public partial class V1beta1PacketMirroringSpecForProviderMirroredResourcesInstancesUrlSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PacketMirroringSpecForProviderMirroredResourcesInstancesUrlSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1PacketMirroringSpecForProviderMirroredResourcesInstances
{
    /// <summary>The URL of the subnetwork where this rule should be active.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Reference to a Instance in compute to populate url.</summary>
    [JsonPropertyName("urlRef")]
    public V1beta1PacketMirroringSpecForProviderMirroredResourcesInstancesUrlRef? UrlRef { get; set; }

    /// <summary>Selector for a Instance in compute to populate url.</summary>
    [JsonPropertyName("urlSelector")]
    public V1beta1PacketMirroringSpecForProviderMirroredResourcesInstancesUrlSelector? UrlSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1PacketMirroringSpecForProviderMirroredResourcesSubnetworks
{
    /// <summary>The URL of the subnetwork where this rule should be active.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
public partial class V1beta1PacketMirroringSpecForProviderMirroredResources
{
    /// <summary>All the listed instances will be mirrored.  Specify at most 50. Structure is documented below.</summary>
    [JsonPropertyName("instances")]
    public IList<V1beta1PacketMirroringSpecForProviderMirroredResourcesInstances>? Instances { get; set; }

    /// <summary>All instances in one of these subnetworks will be mirrored. Structure is documented below.</summary>
    [JsonPropertyName("subnetworks")]
    public IList<V1beta1PacketMirroringSpecForProviderMirroredResourcesSubnetworks>? Subnetworks { get; set; }

    /// <summary>All instances with these tags will be mirrored.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}

public enum V1beta1PacketMirroringSpecForProviderNetworkUrlRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PacketMirroringSpecForProviderNetworkUrlRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PacketMirroringSpecForProviderNetworkUrlRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PacketMirroringSpecForProviderNetworkUrlRefPolicyResolutionEnum>))]
    public V1beta1PacketMirroringSpecForProviderNetworkUrlRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PacketMirroringSpecForProviderNetworkUrlRefPolicyResolveEnum>))]
    public V1beta1PacketMirroringSpecForProviderNetworkUrlRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate url.</summary>
public partial class V1beta1PacketMirroringSpecForProviderNetworkUrlRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PacketMirroringSpecForProviderNetworkUrlRefPolicy? Policy { get; set; }
}

public enum V1beta1PacketMirroringSpecForProviderNetworkUrlSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PacketMirroringSpecForProviderNetworkUrlSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1PacketMirroringSpecForProviderNetworkUrlSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PacketMirroringSpecForProviderNetworkUrlSelectorPolicyResolutionEnum>))]
    public V1beta1PacketMirroringSpecForProviderNetworkUrlSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PacketMirroringSpecForProviderNetworkUrlSelectorPolicyResolveEnum>))]
    public V1beta1PacketMirroringSpecForProviderNetworkUrlSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate url.</summary>
public partial class V1beta1PacketMirroringSpecForProviderNetworkUrlSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PacketMirroringSpecForProviderNetworkUrlSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1PacketMirroringSpecForProviderNetwork
{
    /// <summary>The full self_link URL of the network where this rule is active.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Reference to a Network in compute to populate url.</summary>
    [JsonPropertyName("urlRef")]
    public V1beta1PacketMirroringSpecForProviderNetworkUrlRef? UrlRef { get; set; }

    /// <summary>Selector for a Network in compute to populate url.</summary>
    [JsonPropertyName("urlSelector")]
    public V1beta1PacketMirroringSpecForProviderNetworkUrlSelector? UrlSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1PacketMirroringSpecForProvider
{
    /// <summary>The Forwarding Rule resource (of type load_balancing_scheme=INTERNAL) that will be used as collector for mirrored traffic. The specified forwarding rule must have is_mirroring_collector set to true. Structure is documented below.</summary>
    [JsonPropertyName("collectorIlb")]
    public IList<V1beta1PacketMirroringSpecForProviderCollectorIlb>? CollectorIlb { get; set; }

    /// <summary>A human-readable description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A filter for mirrored traffic.  If unset, all traffic is mirrored. Structure is documented below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1PacketMirroringSpecForProviderFilter>? Filter { get; set; }

    /// <summary>A means of specifying which resources to mirror. Structure is documented below.</summary>
    [JsonPropertyName("mirroredResources")]
    public IList<V1beta1PacketMirroringSpecForProviderMirroredResources>? MirroredResources { get; set; }

    /// <summary>Specifies the mirrored VPC network. Only packets in this network will be mirrored. All mirrored VMs should have a NIC in the given network. All mirrored subnetworks should belong to the given network. Structure is documented below.</summary>
    [JsonPropertyName("network")]
    public IList<V1beta1PacketMirroringSpecForProviderNetwork>? Network { get; set; }

    /// <summary>Since only one rule can be active at a time, priority is used to break ties in the case of two rules that apply to the same instances.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The Region in which the created address should reside. If it is not provided, the provider region is used.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }
}

public enum V1beta1PacketMirroringSpecInitProviderCollectorIlbUrlRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PacketMirroringSpecInitProviderCollectorIlbUrlRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PacketMirroringSpecInitProviderCollectorIlbUrlRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PacketMirroringSpecInitProviderCollectorIlbUrlRefPolicyResolutionEnum>))]
    public V1beta1PacketMirroringSpecInitProviderCollectorIlbUrlRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PacketMirroringSpecInitProviderCollectorIlbUrlRefPolicyResolveEnum>))]
    public V1beta1PacketMirroringSpecInitProviderCollectorIlbUrlRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ForwardingRule in compute to populate url.</summary>
public partial class V1beta1PacketMirroringSpecInitProviderCollectorIlbUrlRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PacketMirroringSpecInitProviderCollectorIlbUrlRefPolicy? Policy { get; set; }
}

public enum V1beta1PacketMirroringSpecInitProviderCollectorIlbUrlSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PacketMirroringSpecInitProviderCollectorIlbUrlSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1PacketMirroringSpecInitProviderCollectorIlbUrlSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PacketMirroringSpecInitProviderCollectorIlbUrlSelectorPolicyResolutionEnum>))]
    public V1beta1PacketMirroringSpecInitProviderCollectorIlbUrlSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PacketMirroringSpecInitProviderCollectorIlbUrlSelectorPolicyResolveEnum>))]
    public V1beta1PacketMirroringSpecInitProviderCollectorIlbUrlSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ForwardingRule in compute to populate url.</summary>
public partial class V1beta1PacketMirroringSpecInitProviderCollectorIlbUrlSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PacketMirroringSpecInitProviderCollectorIlbUrlSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1PacketMirroringSpecInitProviderCollectorIlb
{
    /// <summary>The URL of the forwarding rule.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Reference to a ForwardingRule in compute to populate url.</summary>
    [JsonPropertyName("urlRef")]
    public V1beta1PacketMirroringSpecInitProviderCollectorIlbUrlRef? UrlRef { get; set; }

    /// <summary>Selector for a ForwardingRule in compute to populate url.</summary>
    [JsonPropertyName("urlSelector")]
    public V1beta1PacketMirroringSpecInitProviderCollectorIlbUrlSelector? UrlSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1PacketMirroringSpecInitProviderFilter
{
    /// <summary>IP CIDR ranges that apply as a filter on the source (ingress) or destination (egress) IP in the IP header. Only IPv4 is supported.</summary>
    [JsonPropertyName("cidrRanges")]
    public IList<string>? CidrRanges { get; set; }

    /// <summary>Direction of traffic to mirror. Default value is BOTH. Possible values are: INGRESS, EGRESS, BOTH.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>Possible IP protocols including tcp, udp, icmp and esp</summary>
    [JsonPropertyName("ipProtocols")]
    public IList<string>? IpProtocols { get; set; }
}

public enum V1beta1PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlRefPolicyResolutionEnum>))]
    public V1beta1PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlRefPolicyResolveEnum>))]
    public V1beta1PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Instance in compute to populate url.</summary>
public partial class V1beta1PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlRefPolicy? Policy { get; set; }
}

public enum V1beta1PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlSelectorPolicyResolutionEnum>))]
    public V1beta1PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlSelectorPolicyResolveEnum>))]
    public V1beta1PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Instance in compute to populate url.</summary>
public partial class V1beta1PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1PacketMirroringSpecInitProviderMirroredResourcesInstances
{
    /// <summary>The URL of the subnetwork where this rule should be active.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Reference to a Instance in compute to populate url.</summary>
    [JsonPropertyName("urlRef")]
    public V1beta1PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlRef? UrlRef { get; set; }

    /// <summary>Selector for a Instance in compute to populate url.</summary>
    [JsonPropertyName("urlSelector")]
    public V1beta1PacketMirroringSpecInitProviderMirroredResourcesInstancesUrlSelector? UrlSelector { get; set; }
}

/// <summary></summary>
public partial class V1beta1PacketMirroringSpecInitProviderMirroredResourcesSubnetworks
{
    /// <summary>The URL of the subnetwork where this rule should be active.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
public partial class V1beta1PacketMirroringSpecInitProviderMirroredResources
{
    /// <summary>All the listed instances will be mirrored.  Specify at most 50. Structure is documented below.</summary>
    [JsonPropertyName("instances")]
    public IList<V1beta1PacketMirroringSpecInitProviderMirroredResourcesInstances>? Instances { get; set; }

    /// <summary>All instances in one of these subnetworks will be mirrored. Structure is documented below.</summary>
    [JsonPropertyName("subnetworks")]
    public IList<V1beta1PacketMirroringSpecInitProviderMirroredResourcesSubnetworks>? Subnetworks { get; set; }

    /// <summary>All instances with these tags will be mirrored.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}

public enum V1beta1PacketMirroringSpecInitProviderNetworkUrlRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PacketMirroringSpecInitProviderNetworkUrlRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PacketMirroringSpecInitProviderNetworkUrlRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PacketMirroringSpecInitProviderNetworkUrlRefPolicyResolutionEnum>))]
    public V1beta1PacketMirroringSpecInitProviderNetworkUrlRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PacketMirroringSpecInitProviderNetworkUrlRefPolicyResolveEnum>))]
    public V1beta1PacketMirroringSpecInitProviderNetworkUrlRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate url.</summary>
public partial class V1beta1PacketMirroringSpecInitProviderNetworkUrlRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PacketMirroringSpecInitProviderNetworkUrlRefPolicy? Policy { get; set; }
}

public enum V1beta1PacketMirroringSpecInitProviderNetworkUrlSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PacketMirroringSpecInitProviderNetworkUrlSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
public partial class V1beta1PacketMirroringSpecInitProviderNetworkUrlSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PacketMirroringSpecInitProviderNetworkUrlSelectorPolicyResolutionEnum>))]
    public V1beta1PacketMirroringSpecInitProviderNetworkUrlSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PacketMirroringSpecInitProviderNetworkUrlSelectorPolicyResolveEnum>))]
    public V1beta1PacketMirroringSpecInitProviderNetworkUrlSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate url.</summary>
public partial class V1beta1PacketMirroringSpecInitProviderNetworkUrlSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PacketMirroringSpecInitProviderNetworkUrlSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
public partial class V1beta1PacketMirroringSpecInitProviderNetwork
{
    /// <summary>The full self_link URL of the network where this rule is active.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Reference to a Network in compute to populate url.</summary>
    [JsonPropertyName("urlRef")]
    public V1beta1PacketMirroringSpecInitProviderNetworkUrlRef? UrlRef { get; set; }

    /// <summary>Selector for a Network in compute to populate url.</summary>
    [JsonPropertyName("urlSelector")]
    public V1beta1PacketMirroringSpecInitProviderNetworkUrlSelector? UrlSelector { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
public partial class V1beta1PacketMirroringSpecInitProvider
{
    /// <summary>The Forwarding Rule resource (of type load_balancing_scheme=INTERNAL) that will be used as collector for mirrored traffic. The specified forwarding rule must have is_mirroring_collector set to true. Structure is documented below.</summary>
    [JsonPropertyName("collectorIlb")]
    public IList<V1beta1PacketMirroringSpecInitProviderCollectorIlb>? CollectorIlb { get; set; }

    /// <summary>A human-readable description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A filter for mirrored traffic.  If unset, all traffic is mirrored. Structure is documented below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1PacketMirroringSpecInitProviderFilter>? Filter { get; set; }

    /// <summary>A means of specifying which resources to mirror. Structure is documented below.</summary>
    [JsonPropertyName("mirroredResources")]
    public IList<V1beta1PacketMirroringSpecInitProviderMirroredResources>? MirroredResources { get; set; }

    /// <summary>Specifies the mirrored VPC network. Only packets in this network will be mirrored. All mirrored VMs should have a NIC in the given network. All mirrored subnetworks should belong to the given network. Structure is documented below.</summary>
    [JsonPropertyName("network")]
    public IList<V1beta1PacketMirroringSpecInitProviderNetwork>? Network { get; set; }

    /// <summary>Since only one rule can be active at a time, priority is used to break ties in the case of two rules that apply to the same instances.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

public enum V1beta1PacketMirroringSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    /// <summary>Observe</summary>
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    /// <summary>Create</summary>
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    /// <summary>Update</summary>
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    /// <summary>Delete</summary>
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    /// <summary>LateInitialize</summary>
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    /// <summary>*</summary>
    Option5
}

public enum V1beta1PacketMirroringSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PacketMirroringSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PacketMirroringSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PacketMirroringSpecProviderConfigRefPolicyResolutionEnum>))]
    public V1beta1PacketMirroringSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PacketMirroringSpecProviderConfigRefPolicyResolveEnum>))]
    public V1beta1PacketMirroringSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
public partial class V1beta1PacketMirroringSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PacketMirroringSpecProviderConfigRefPolicy? Policy { get; set; }
}

public enum V1beta1PacketMirroringSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    /// <summary>Required</summary>
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    /// <summary>Optional</summary>
    Optional
}

public enum V1beta1PacketMirroringSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    /// <summary>Always</summary>
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    /// <summary>IfNotPresent</summary>
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
public partial class V1beta1PacketMirroringSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PacketMirroringSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum>))]
    public V1beta1PacketMirroringSpecPublishConnectionDetailsToConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PacketMirroringSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum>))]
    public V1beta1PacketMirroringSpecPublishConnectionDetailsToConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
public partial class V1beta1PacketMirroringSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PacketMirroringSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
public partial class V1beta1PacketMirroringSpecPublishConnectionDetailsToMetadata
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
public partial class V1beta1PacketMirroringSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1PacketMirroringSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1PacketMirroringSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
public partial class V1beta1PacketMirroringSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>PacketMirroringSpec defines the desired state of PacketMirroring</summary>
public partial class V1beta1PacketMirroringSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1beta1PacketMirroringSpecDeletionPolicyEnum>))]
    public V1beta1PacketMirroringSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1PacketMirroringSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1PacketMirroringSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1PacketMirroringSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PacketMirroringSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1PacketMirroringSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PacketMirroringSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
public partial class V1beta1PacketMirroringStatusAtProviderCollectorIlb
{
    /// <summary>The URL of the forwarding rule.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
public partial class V1beta1PacketMirroringStatusAtProviderFilter
{
    /// <summary>IP CIDR ranges that apply as a filter on the source (ingress) or destination (egress) IP in the IP header. Only IPv4 is supported.</summary>
    [JsonPropertyName("cidrRanges")]
    public IList<string>? CidrRanges { get; set; }

    /// <summary>Direction of traffic to mirror. Default value is BOTH. Possible values are: INGRESS, EGRESS, BOTH.</summary>
    [JsonPropertyName("direction")]
    public string? Direction { get; set; }

    /// <summary>Possible IP protocols including tcp, udp, icmp and esp</summary>
    [JsonPropertyName("ipProtocols")]
    public IList<string>? IpProtocols { get; set; }
}

/// <summary></summary>
public partial class V1beta1PacketMirroringStatusAtProviderMirroredResourcesInstances
{
    /// <summary>The URL of the subnetwork where this rule should be active.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
public partial class V1beta1PacketMirroringStatusAtProviderMirroredResourcesSubnetworks
{
    /// <summary>The URL of the subnetwork where this rule should be active.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
public partial class V1beta1PacketMirroringStatusAtProviderMirroredResources
{
    /// <summary>All the listed instances will be mirrored.  Specify at most 50. Structure is documented below.</summary>
    [JsonPropertyName("instances")]
    public IList<V1beta1PacketMirroringStatusAtProviderMirroredResourcesInstances>? Instances { get; set; }

    /// <summary>All instances in one of these subnetworks will be mirrored. Structure is documented below.</summary>
    [JsonPropertyName("subnetworks")]
    public IList<V1beta1PacketMirroringStatusAtProviderMirroredResourcesSubnetworks>? Subnetworks { get; set; }

    /// <summary>All instances with these tags will be mirrored.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}

/// <summary></summary>
public partial class V1beta1PacketMirroringStatusAtProviderNetwork
{
    /// <summary>The full self_link URL of the network where this rule is active.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
public partial class V1beta1PacketMirroringStatusAtProvider
{
    /// <summary>The Forwarding Rule resource (of type load_balancing_scheme=INTERNAL) that will be used as collector for mirrored traffic. The specified forwarding rule must have is_mirroring_collector set to true. Structure is documented below.</summary>
    [JsonPropertyName("collectorIlb")]
    public IList<V1beta1PacketMirroringStatusAtProviderCollectorIlb>? CollectorIlb { get; set; }

    /// <summary>A human-readable description of the rule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A filter for mirrored traffic.  If unset, all traffic is mirrored. Structure is documented below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1PacketMirroringStatusAtProviderFilter>? Filter { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/regions/{{region}}/packetMirrorings/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A means of specifying which resources to mirror. Structure is documented below.</summary>
    [JsonPropertyName("mirroredResources")]
    public IList<V1beta1PacketMirroringStatusAtProviderMirroredResources>? MirroredResources { get; set; }

    /// <summary>Specifies the mirrored VPC network. Only packets in this network will be mirrored. All mirrored VMs should have a NIC in the given network. All mirrored subnetworks should belong to the given network. Structure is documented below.</summary>
    [JsonPropertyName("network")]
    public IList<V1beta1PacketMirroringStatusAtProviderNetwork>? Network { get; set; }

    /// <summary>Since only one rule can be active at a time, priority is used to break ties in the case of two rules that apply to the same instances.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The Region in which the created address should reside. If it is not provided, the provider region is used.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
public partial class V1beta1PacketMirroringStatusConditions
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

/// <summary>PacketMirroringStatus defines the observed state of PacketMirroring.</summary>
public partial class V1beta1PacketMirroringStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1PacketMirroringStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PacketMirroringStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary>PacketMirroring is the Schema for the PacketMirrorings API. Packet Mirroring mirrors traffic to and from particular VM instances.</summary>
public partial class V1beta1PacketMirroring : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PacketMirroringSpec>, IStatus<V1beta1PacketMirroringStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PacketMirroring";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "packetmirrorings";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PacketMirroringSpec defines the desired state of PacketMirroring</summary>
    [JsonPropertyName("spec")]
    public V1beta1PacketMirroringSpec Spec { get; set; }

    /// <summary>PacketMirroringStatus defines the observed state of PacketMirroring.</summary>
    [JsonPropertyName("status")]
    public V1beta1PacketMirroringStatus? Status { get; set; }
}