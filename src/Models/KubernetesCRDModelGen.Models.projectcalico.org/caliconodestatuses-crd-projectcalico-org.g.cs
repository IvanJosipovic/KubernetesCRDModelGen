using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.crd.projectcalico.org;
public partial class V1CalicoNodeStatusSpec
{
    /// <summary>Classes declares the types of information to monitor for this calico/node, and allows for selective status reporting about certain subsets of information.</summary>
    [JsonPropertyName("classes")]
    public IList<string>? Classes { get; set; }

    /// <summary>The node name identifies the Calico node instance for node status.</summary>
    [JsonPropertyName("node")]
    public string? Node { get; set; }

    /// <summary>UpdatePeriodSeconds is the period at which CalicoNodeStatus should be updated. Set to 0 to disable CalicoNodeStatus refresh. Maximum update period is one day.</summary>
    [JsonPropertyName("updatePeriodSeconds")]
    public int? UpdatePeriodSeconds { get; set; }
}

public partial class V1CalicoNodeStatusStatusAgentBirdV4
{
    /// <summary>LastBootTime holds the value of lastBootTime from bird.ctl output.</summary>
    [JsonPropertyName("lastBootTime")]
    public string? LastBootTime { get; set; }

    /// <summary>LastReconfigurationTime holds the value of lastReconfigTime from bird.ctl output.</summary>
    [JsonPropertyName("lastReconfigurationTime")]
    public string? LastReconfigurationTime { get; set; }

    /// <summary>Router ID used by bird.</summary>
    [JsonPropertyName("routerID")]
    public string? RouterID { get; set; }

    /// <summary>The state of the BGP Daemon.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Version of the BGP daemon</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public partial class V1CalicoNodeStatusStatusAgentBirdV6
{
    /// <summary>LastBootTime holds the value of lastBootTime from bird.ctl output.</summary>
    [JsonPropertyName("lastBootTime")]
    public string? LastBootTime { get; set; }

    /// <summary>LastReconfigurationTime holds the value of lastReconfigTime from bird.ctl output.</summary>
    [JsonPropertyName("lastReconfigurationTime")]
    public string? LastReconfigurationTime { get; set; }

    /// <summary>Router ID used by bird.</summary>
    [JsonPropertyName("routerID")]
    public string? RouterID { get; set; }

    /// <summary>The state of the BGP Daemon.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Version of the BGP daemon</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

public partial class V1CalicoNodeStatusStatusAgent
{
    /// <summary>BIRDV4 represents the latest observed status of bird4.</summary>
    [JsonPropertyName("birdV4")]
    public V1CalicoNodeStatusStatusAgentBirdV4? BirdV4 { get; set; }

    /// <summary>BIRDV6 represents the latest observed status of bird6.</summary>
    [JsonPropertyName("birdV6")]
    public V1CalicoNodeStatusStatusAgentBirdV6? BirdV6 { get; set; }
}

public partial class V1CalicoNodeStatusStatusBgpPeersV4
{
    /// <summary>IP address of the peer whose condition we are reporting.</summary>
    [JsonPropertyName("peerIP")]
    public string? PeerIP { get; set; }

    /// <summary>Since the state or reason last changed.</summary>
    [JsonPropertyName("since")]
    public string? Since { get; set; }

    /// <summary>State is the BGP session state.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Type indicates whether this peer is configured via the node-to-node mesh, or via en explicit global or per-node BGPPeer object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1CalicoNodeStatusStatusBgpPeersV6
{
    /// <summary>IP address of the peer whose condition we are reporting.</summary>
    [JsonPropertyName("peerIP")]
    public string? PeerIP { get; set; }

    /// <summary>Since the state or reason last changed.</summary>
    [JsonPropertyName("since")]
    public string? Since { get; set; }

    /// <summary>State is the BGP session state.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Type indicates whether this peer is configured via the node-to-node mesh, or via en explicit global or per-node BGPPeer object.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1CalicoNodeStatusStatusBgp
{
    /// <summary>The total number of IPv4 established bgp sessions.</summary>
    [JsonPropertyName("numberEstablishedV4")]
    public int NumberEstablishedV4 { get; set; }

    /// <summary>The total number of IPv6 established bgp sessions.</summary>
    [JsonPropertyName("numberEstablishedV6")]
    public int NumberEstablishedV6 { get; set; }

    /// <summary>The total number of IPv4 non-established bgp sessions.</summary>
    [JsonPropertyName("numberNotEstablishedV4")]
    public int NumberNotEstablishedV4 { get; set; }

    /// <summary>The total number of IPv6 non-established bgp sessions.</summary>
    [JsonPropertyName("numberNotEstablishedV6")]
    public int NumberNotEstablishedV6 { get; set; }

    /// <summary>PeersV4 represents IPv4 BGP peers status on the node.</summary>
    [JsonPropertyName("peersV4")]
    public IList<V1CalicoNodeStatusStatusBgpPeersV4>? PeersV4 { get; set; }

    /// <summary>PeersV6 represents IPv6 BGP peers status on the node.</summary>
    [JsonPropertyName("peersV6")]
    public IList<V1CalicoNodeStatusStatusBgpPeersV6>? PeersV6 { get; set; }
}

public partial class V1CalicoNodeStatusStatusRoutesRoutesV4LearnedFrom
{
    /// <summary>If sourceType is NodeMesh or BGPPeer, IP address of the router that sent us this route.</summary>
    [JsonPropertyName("peerIP")]
    public string? PeerIP { get; set; }

    /// <summary>Type of the source where a route is learned from.</summary>
    [JsonPropertyName("sourceType")]
    public string? SourceType { get; set; }
}

public partial class V1CalicoNodeStatusStatusRoutesRoutesV4
{
    /// <summary>Destination of the route.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Gateway for the destination.</summary>
    [JsonPropertyName("gateway")]
    public string? Gateway { get; set; }

    /// <summary>Interface for the destination</summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary>LearnedFrom contains information regarding where this route originated.</summary>
    [JsonPropertyName("learnedFrom")]
    public V1CalicoNodeStatusStatusRoutesRoutesV4LearnedFrom? LearnedFrom { get; set; }

    /// <summary>Type indicates if the route is being used for forwarding or not.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1CalicoNodeStatusStatusRoutesRoutesV6LearnedFrom
{
    /// <summary>If sourceType is NodeMesh or BGPPeer, IP address of the router that sent us this route.</summary>
    [JsonPropertyName("peerIP")]
    public string? PeerIP { get; set; }

    /// <summary>Type of the source where a route is learned from.</summary>
    [JsonPropertyName("sourceType")]
    public string? SourceType { get; set; }
}

public partial class V1CalicoNodeStatusStatusRoutesRoutesV6
{
    /// <summary>Destination of the route.</summary>
    [JsonPropertyName("destination")]
    public string? Destination { get; set; }

    /// <summary>Gateway for the destination.</summary>
    [JsonPropertyName("gateway")]
    public string? Gateway { get; set; }

    /// <summary>Interface for the destination</summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary>LearnedFrom contains information regarding where this route originated.</summary>
    [JsonPropertyName("learnedFrom")]
    public V1CalicoNodeStatusStatusRoutesRoutesV6LearnedFrom? LearnedFrom { get; set; }

    /// <summary>Type indicates if the route is being used for forwarding or not.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

public partial class V1CalicoNodeStatusStatusRoutes
{
    /// <summary>RoutesV4 represents IPv4 routes on the node.</summary>
    [JsonPropertyName("routesV4")]
    public IList<V1CalicoNodeStatusStatusRoutesRoutesV4>? RoutesV4 { get; set; }

    /// <summary>RoutesV6 represents IPv6 routes on the node.</summary>
    [JsonPropertyName("routesV6")]
    public IList<V1CalicoNodeStatusStatusRoutesRoutesV6>? RoutesV6 { get; set; }
}

public partial class V1CalicoNodeStatusStatus
{
    /// <summary>Agent holds agent status on the node.</summary>
    [JsonPropertyName("agent")]
    public V1CalicoNodeStatusStatusAgent? Agent { get; set; }

    /// <summary>BGP holds node BGP status.</summary>
    [JsonPropertyName("bgp")]
    public V1CalicoNodeStatusStatusBgp? Bgp { get; set; }

    /// <summary>LastUpdated is a timestamp representing the server time when CalicoNodeStatus object last updated. It is represented in RFC3339 form and is in UTC.</summary>
    [JsonPropertyName("lastUpdated")]
    public string? LastUpdated { get; set; }

    /// <summary>Routes reports routes known to the Calico BGP daemon on the node.</summary>
    [JsonPropertyName("routes")]
    public V1CalicoNodeStatusStatusRoutes? Routes { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1CalicoNodeStatus : IKubernetesObject<V1ObjectMeta>, ISpec<V1CalicoNodeStatusSpec>, IStatus<V1CalicoNodeStatusStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "CalicoNodeStatus";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "caliconodestatuses";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CalicoNodeStatusSpec contains the specification for a CalicoNodeStatus resource.</summary>
    [JsonPropertyName("spec")]
    public V1CalicoNodeStatusSpec? Spec { get; set; }

    /// <summary>CalicoNodeStatusStatus defines the observed state of CalicoNodeStatus. No validation needed for status since it is updated by Calico.</summary>
    [JsonPropertyName("status")]
    public V1CalicoNodeStatusStatus? Status { get; set; }
}