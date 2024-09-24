using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
public partial class V1beta1ComputeVPNTunnelSpecPeerExternalGatewayRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeExternalVPNGateway` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1ComputeVPNTunnelSpecPeerGCPGatewayRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeVPNGateway` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1ComputeVPNTunnelSpecRouterRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeRouter` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1ComputeVPNTunnelSpecSharedSecretValueFromSecretKeyRef
{
    /// <summary>Key that identifies the value to be extracted.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Name of the Secret to extract a value from.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public partial class V1beta1ComputeVPNTunnelSpecSharedSecretValueFrom
{
    /// <summary>Reference to a value with the given key in the given Secret in the resource's namespace.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1ComputeVPNTunnelSpecSharedSecretValueFromSecretKeyRef? SecretKeyRef { get; set; }
}

public partial class V1beta1ComputeVPNTunnelSpecSharedSecret
{
    /// <summary>Value of the field. Cannot be used if 'valueFrom' is specified.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the field's value. Cannot be used if 'value' is specified.</summary>
    [JsonPropertyName("valueFrom")]
    public V1beta1ComputeVPNTunnelSpecSharedSecretValueFrom? ValueFrom { get; set; }
}

public partial class V1beta1ComputeVPNTunnelSpecTargetVPNGatewayRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeTargetVPNGateway` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1ComputeVPNTunnelSpecVpnGatewayRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeVPNGateway` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1ComputeVPNTunnelSpec
{
    /// <summary>Immutable. An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. IKE protocol version to use when establishing the VPN tunnel with peer VPN gateway. Acceptable IKE versions are 1 or 2. Default version is 2.</summary>
    [JsonPropertyName("ikeVersion")]
    public int? IkeVersion { get; set; }

    /// <summary>Immutable. Local traffic selector to use when establishing the VPN tunnel with peer VPN gateway. The value should be a CIDR formatted string, for example '192.168.0.0/16'. The ranges should be disjoint. Only IPv4 is supported.</summary>
    [JsonPropertyName("localTrafficSelector")]
    public IList<string>? LocalTrafficSelector { get; set; }

    /// <summary>Immutable. The interface ID of the external VPN gateway to which this VPN tunnel is connected.</summary>
    [JsonPropertyName("peerExternalGatewayInterface")]
    public int? PeerExternalGatewayInterface { get; set; }

    /// <summary>The peer side external VPN gateway to which this VPN tunnel is connected.</summary>
    [JsonPropertyName("peerExternalGatewayRef")]
    public V1beta1ComputeVPNTunnelSpecPeerExternalGatewayRef? PeerExternalGatewayRef { get; set; }

    /// <summary>The peer side HA GCP VPN gateway to which this VPN tunnel is connected. If provided, the VPN tunnel will automatically use the same VPN gateway interface ID in the peer GCP VPN gateway.</summary>
    [JsonPropertyName("peerGCPGatewayRef")]
    public V1beta1ComputeVPNTunnelSpecPeerGCPGatewayRef? PeerGCPGatewayRef { get; set; }

    /// <summary>Immutable. IP address of the peer VPN gateway. Only IPv4 is supported.</summary>
    [JsonPropertyName("peerIp")]
    public string? PeerIp { get; set; }

    /// <summary>Immutable. The region where the tunnel is located. If unset, is set to the region of 'target_vpn_gateway'.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Immutable. Remote traffic selector to use when establishing the VPN tunnel with peer VPN gateway. The value should be a CIDR formatted string, for example '192.168.0.0/16'. The ranges should be disjoint. Only IPv4 is supported.</summary>
    [JsonPropertyName("remoteTrafficSelector")]
    public IList<string>? RemoteTrafficSelector { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The router to be used for dynamic routing.</summary>
    [JsonPropertyName("routerRef")]
    public V1beta1ComputeVPNTunnelSpecRouterRef? RouterRef { get; set; }

    /// <summary>Immutable. Shared secret used to set the secure session between the Cloud VPN gateway and the peer VPN gateway.</summary>
    [JsonPropertyName("sharedSecret")]
    public V1beta1ComputeVPNTunnelSpecSharedSecret SharedSecret { get; set; }

    /// <summary>The ComputeTargetVPNGateway with which this VPN tunnel is associated.</summary>
    [JsonPropertyName("targetVPNGatewayRef")]
    public V1beta1ComputeVPNTunnelSpecTargetVPNGatewayRef? TargetVPNGatewayRef { get; set; }

    /// <summary>Immutable. The interface ID of the VPN gateway with which this VPN tunnel is associated.</summary>
    [JsonPropertyName("vpnGatewayInterface")]
    public int? VpnGatewayInterface { get; set; }

    /// <summary>The ComputeVPNGateway with which this VPN tunnel is associated. This must be used if a High Availability VPN gateway resource is created.</summary>
    [JsonPropertyName("vpnGatewayRef")]
    public V1beta1ComputeVPNTunnelSpecVpnGatewayRef? VpnGatewayRef { get; set; }
}

public partial class V1beta1ComputeVPNTunnelStatusConditions
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

public partial class V1beta1ComputeVPNTunnelStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeVPNTunnelStatusConditions>? Conditions { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>Detailed status message for the VPN tunnel.</summary>
    [JsonPropertyName("detailedStatus")]
    public string? DetailedStatus { get; set; }

    /// <summary>The fingerprint used for optimistic locking of this resource.  Used internally during updates.</summary>
    [JsonPropertyName("labelFingerprint")]
    public string? LabelFingerprint { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>Hash of the shared secret.</summary>
    [JsonPropertyName("sharedSecretHash")]
    public string? SharedSecretHash { get; set; }

    /// <summary>The unique identifier for the resource. This identifier is defined by the server.</summary>
    [JsonPropertyName("tunnelId")]
    public string? TunnelId { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeVPNTunnel : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeVPNTunnelSpec>, IStatus<V1beta1ComputeVPNTunnelStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeVPNTunnel";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computevpntunnels";
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
    public V1beta1ComputeVPNTunnelSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeVPNTunnelStatus? Status { get; set; }
}