using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
public partial class V1beta1ComputeRouteSpecNetworkRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1ComputeRouteSpecNextHopILBRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeForwardingRule` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1ComputeRouteSpecNextHopInstanceRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeInstance` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1ComputeRouteSpecNextHopVPNTunnelRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeVPNTunnel` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1ComputeRouteSpec
{
    /// <summary>Immutable. An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. The destination range of outgoing packets that this route applies to. Only IPv4 is supported.</summary>
    [JsonPropertyName("destRange")]
    public string DestRange { get; set; }

    /// <summary>The network that this route applies to.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1ComputeRouteSpecNetworkRef NetworkRef { get; set; }

    /// <summary>Immutable. URL to a gateway that should handle matching packets. Currently, you can only specify the internet gateway, using a full or partial valid URL: * 'https://www.googleapis.com/compute/v1/projects/project/global/gateways/default-internet-gateway' * 'projects/project/global/gateways/default-internet-gateway' * 'global/gateways/default-internet-gateway' * The string 'default-internet-gateway'.</summary>
    [JsonPropertyName("nextHopGateway")]
    public string? NextHopGateway { get; set; }

    /// <summary>A forwarding rule of type loadBalancingScheme=INTERNAL that should handle matching packets.  Note that this can only be used when the destinationRange is a public (non-RFC 1918) IP CIDR range.</summary>
    [JsonPropertyName("nextHopILBRef")]
    public V1beta1ComputeRouteSpecNextHopILBRef? NextHopILBRef { get; set; }

    /// <summary>Instance that should handle matching packets.</summary>
    [JsonPropertyName("nextHopInstanceRef")]
    public V1beta1ComputeRouteSpecNextHopInstanceRef? NextHopInstanceRef { get; set; }

    /// <summary>Immutable. Network IP address of an instance that should handle matching packets.</summary>
    [JsonPropertyName("nextHopIp")]
    public string? NextHopIp { get; set; }

    /// <summary>The ComputeVPNTunnel that should handle matching packets</summary>
    [JsonPropertyName("nextHopVPNTunnelRef")]
    public V1beta1ComputeRouteSpecNextHopVPNTunnelRef? NextHopVPNTunnelRef { get; set; }

    /// <summary>Immutable. The priority of this route. Priority is used to break ties in cases where there is more than one matching route of equal prefix length.  In the case of two routes with equal prefix length, the one with the lowest-numbered priority value wins.  Default value is 1000. Valid range is 0 through 65535.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. A list of instance tags to which this route applies.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}

public partial class V1beta1ComputeRouteStatusConditions
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

public partial class V1beta1ComputeRouteStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeRouteStatusConditions>? Conditions { get; set; }

    /// <summary>URL to a Network that should handle matching packets.</summary>
    [JsonPropertyName("nextHopNetwork")]
    public string? NextHopNetwork { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeRoute : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeRouteSpec>, IStatus<V1beta1ComputeRouteStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeRoute";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computeroutes";
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
    public V1beta1ComputeRouteSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeRouteStatus? Status { get; set; }
}