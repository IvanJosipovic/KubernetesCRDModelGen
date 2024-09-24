using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.edgecontainer.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EdgeContainerVpnConnectionSpecClusterRef
{
    /// <summary>Allowed value: The `name` field of an `EdgeContainerCluster` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EdgeContainerVpnConnectionSpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Project detail of the VPC network. Required if VPC is in a different project than the cluster project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EdgeContainerVpnConnectionSpecVpcProject
{
    /// <summary>Immutable. The project of the VPC to connect to. If not specified, it is the same as the cluster project.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EdgeContainerVpnConnectionSpec
{
    /// <summary></summary>
    [JsonPropertyName("clusterRef")]
    public V1beta1EdgeContainerVpnConnectionSpecClusterRef ClusterRef { get; set; }

    /// <summary>Immutable. Whether this VPN connection has HA enabled on cluster side. If enabled, when creating VPN connection we will attempt to use 2 ANG floating IPs.</summary>
    [JsonPropertyName("enableHighAvailability")]
    public bool? EnableHighAvailability { get; set; }

    /// <summary>Immutable. Google Cloud Platform location.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Immutable. NAT gateway IP, or WAN IP address. If a customer has multiple NAT IPs, the customer needs to configure NAT such that only one external IP maps to the GMEC Anthos cluster. This is empty if NAT is not used.</summary>
    [JsonPropertyName("natGatewayIp")]
    public string? NatGatewayIp { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1EdgeContainerVpnConnectionSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The VPN connection Cloud Router name.</summary>
    [JsonPropertyName("router")]
    public string? Router { get; set; }

    /// <summary>Immutable. The network ID of VPC to connect to.</summary>
    [JsonPropertyName("vpc")]
    public string? Vpc { get; set; }

    /// <summary>Project detail of the VPC network. Required if VPC is in a different project than the cluster project.</summary>
    [JsonPropertyName("vpcProject")]
    public V1beta1EdgeContainerVpnConnectionSpecVpcProject? VpcProject { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EdgeContainerVpnConnectionStatusConditions
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EdgeContainerVpnConnectionStatusDetailsCloudRouter
{
    /// <summary>The associated Cloud Router name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EdgeContainerVpnConnectionStatusDetailsCloudVpns
{
    /// <summary>The created Cloud VPN gateway name.</summary>
    [JsonPropertyName("gateway")]
    public string? Gateway { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EdgeContainerVpnConnectionStatusDetails
{
    /// <summary>The Cloud Router info.</summary>
    [JsonPropertyName("cloudRouter")]
    public IList<V1beta1EdgeContainerVpnConnectionStatusDetailsCloudRouter>? CloudRouter { get; set; }

    /// <summary>Each connection has multiple Cloud VPN gateways.</summary>
    [JsonPropertyName("cloudVpns")]
    public IList<V1beta1EdgeContainerVpnConnectionStatusDetailsCloudVpns>? CloudVpns { get; set; }

    /// <summary>The error message. This is only populated when state=ERROR.</summary>
    [JsonPropertyName("error")]
    public string? Error { get; set; }

    /// <summary>The current connection state.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EdgeContainerVpnConnectionStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1EdgeContainerVpnConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>The time when the VPN connection was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>A nested object resource.</summary>
    [JsonPropertyName("details")]
    public IList<V1beta1EdgeContainerVpnConnectionStatusDetails>? Details { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The time when the VPN connection was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EdgeContainerVpnConnection : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1EdgeContainerVpnConnectionSpec>, IStatus<V1beta1EdgeContainerVpnConnectionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EdgeContainerVpnConnection";
    public const string KubeGroup = "edgecontainer.cnrm.cloud.google.com";
    public const string KubePluralName = "edgecontainervpnconnections";
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
    public V1beta1EdgeContainerVpnConnectionSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1EdgeContainerVpnConnectionStatus? Status { get; set; }
}