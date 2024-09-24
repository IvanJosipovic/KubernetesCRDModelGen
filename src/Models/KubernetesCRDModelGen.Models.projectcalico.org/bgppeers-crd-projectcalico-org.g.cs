using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.crd.projectcalico.org;
public partial class V1BGPPeerSpecPasswordSecretKeyRef
{
    /// <summary>The key of the secret to select from.  Must be a valid secret key.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Specify whether the Secret or its key must be defined</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

public partial class V1BGPPeerSpecPassword
{
    /// <summary>Selects a key of a secret in the node pod's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1BGPPeerSpecPasswordSecretKeyRef? SecretKeyRef { get; set; }
}

public partial class V1BGPPeerSpec
{
    /// <summary>The AS Number of the peer.</summary>
    [JsonPropertyName("asNumber")]
    public int? AsNumber { get; set; }

    /// <summary>The ordered set of BGPFilters applied on this BGP peer.</summary>
    [JsonPropertyName("filters")]
    public IList<string>? Filters { get; set; }

    /// <summary>Option to keep the original nexthop field when routes are sent to a BGP Peer. Setting "true" configures the selected BGP Peers node to use the "next hop keep;" instead of "next hop self;"(default) in the specific branch of the Node on "bird.cfg".</summary>
    [JsonPropertyName("keepOriginalNextHop")]
    public bool? KeepOriginalNextHop { get; set; }

    /// <summary>Time to allow for software restart.  When specified, this is configured as the graceful restart timeout.  When not specified, the BIRD default of 120s is used.</summary>
    [JsonPropertyName("maxRestartTime")]
    public string? MaxRestartTime { get; set; }

    /// <summary>The node name identifying the Calico node instance that is targeted by this peer. If this is not set, and no nodeSelector is specified, then this BGP peer selects all nodes in the cluster.</summary>
    [JsonPropertyName("node")]
    public string? Node { get; set; }

    /// <summary>Selector for the nodes that should have this peering.  When this is set, the Node field must be empty.</summary>
    [JsonPropertyName("nodeSelector")]
    public string? NodeSelector { get; set; }

    /// <summary>Maximum number of local AS numbers that are allowed in the AS path for received routes. This removes BGP loop prevention and should only be used if absolutely necessary.</summary>
    [JsonPropertyName("numAllowedLocalASNumbers")]
    public int? NumAllowedLocalASNumbers { get; set; }

    /// <summary>Optional BGP password for the peerings generated by this BGPPeer resource.</summary>
    [JsonPropertyName("password")]
    public V1BGPPeerSpecPassword? Password { get; set; }

    /// <summary>The IP address of the peer followed by an optional port number to peer with. If port number is given, format should be `[&lt;IPv6&gt;]:port` or `&lt;IPv4&gt;:&lt;port&gt;` for IPv4. If optional port number is not set, and this peer IP and ASNumber belongs to a calico/node with ListenPort set in BGPConfiguration, then we use that port to peer.</summary>
    [JsonPropertyName("peerIP")]
    public string? PeerIP { get; set; }

    /// <summary>Selector for the remote nodes to peer with.  When this is set, the PeerIP and ASNumber fields must be empty.  For each peering between the local node and selected remote nodes, we configure an IPv4 peering if both ends have NodeBGPSpec.IPv4Address specified, and an IPv6 peering if both ends have NodeBGPSpec.IPv6Address specified.  The remote AS number comes from the remote node's NodeBGPSpec.ASNumber, or the global default if that is not set.</summary>
    [JsonPropertyName("peerSelector")]
    public string? PeerSelector { get; set; }

    /// <summary>Add an exact, i.e. /32, static route toward peer IP in order to prevent route flapping. ReachableBy contains the address of the gateway which peer can be reached by.</summary>
    [JsonPropertyName("reachableBy")]
    public string? ReachableBy { get; set; }

    /// <summary>Specifies whether and how to configure a source address for the peerings generated by this BGPPeer resource.  Default value "UseNodeIP" means to configure the node IP as the source address.  "None" means not to configure a source address.</summary>
    [JsonPropertyName("sourceAddress")]
    public string? SourceAddress { get; set; }

    /// <summary>TTLSecurity enables the generalized TTL security mechanism (GTSM) which protects against spoofed packets by ignoring received packets with a smaller than expected TTL value. The provided value is the number of hops (edges) between the peers.</summary>
    [JsonPropertyName("ttlSecurity")]
    public int? TtlSecurity { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1BGPPeer : IKubernetesObject<V1ObjectMeta>, ISpec<V1BGPPeerSpec>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "BGPPeer";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "bgppeers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BGPPeerSpec contains the specification for a BGPPeer resource.</summary>
    [JsonPropertyName("spec")]
    public V1BGPPeerSpec? Spec { get; set; }
}