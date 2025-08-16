using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeNetworkEndpointGroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ComputeNetworkEndpointGroup>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeNetworkEndpointGroupList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computenetworkendpointgroups";
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
    public IList<V1beta1ComputeNetworkEndpointGroup> Items { get; set; }
}

/// <summary>The network to which all network endpoints in the NEG belong. Uses "default" project network if unspecified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeNetworkEndpointGroupSpecNetworkRef
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

/// <summary>Optional subnetwork to which all network endpoints in the NEG belong.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeNetworkEndpointGroupSpecSubnetworkRef
{
    /// <summary>Allowed value: The `selfLink` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeNetworkEndpointGroupSpec
{
    /// <summary>Immutable. The default port used if the port number is not specified in the network endpoint.</summary>
    [JsonPropertyName("defaultPort")]
    public int? DefaultPort { get; set; }

    /// <summary>Immutable. An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Location represents the geographical location of the ComputeNetworkEndpointGroup. Specify a zone name. Reference: GCP definition of regions/zones (https://cloud.google.com/compute/docs/regions-zones/)</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Immutable. Type of network endpoints in this network endpoint group. NON_GCP_PRIVATE_IP_PORT is used for hybrid connectivity network endpoint groups (see https://cloud.google.com/load-balancing/docs/hybrid). Note that NON_GCP_PRIVATE_IP_PORT can only be used with Backend Services that 1) have the following load balancing schemes: EXTERNAL, EXTERNAL_MANAGED, INTERNAL_MANAGED, and INTERNAL_SELF_MANAGED and 2) support the RATE or CONNECTION balancing modes.  Possible values include: GCE_VM_IP, GCE_VM_IP_PORT, and NON_GCP_PRIVATE_IP_PORT. Default value: "GCE_VM_IP_PORT" Possible values: ["GCE_VM_IP", "GCE_VM_IP_PORT", "NON_GCP_PRIVATE_IP_PORT"].</summary>
    [JsonPropertyName("networkEndpointType")]
    public string? NetworkEndpointType { get; set; }

    /// <summary>The network to which all network endpoints in the NEG belong. Uses "default" project network if unspecified.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1ComputeNetworkEndpointGroupSpecNetworkRef NetworkRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional subnetwork to which all network endpoints in the NEG belong.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta1ComputeNetworkEndpointGroupSpecSubnetworkRef? SubnetworkRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeNetworkEndpointGroupStatusConditions
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
public partial class V1beta1ComputeNetworkEndpointGroupStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeNetworkEndpointGroupStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>Number of network endpoints in the network endpoint group.</summary>
    [JsonPropertyName("size")]
    public int? Size { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeNetworkEndpointGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeNetworkEndpointGroupSpec>, IStatus<V1beta1ComputeNetworkEndpointGroupStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeNetworkEndpointGroup";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computenetworkendpointgroups";
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
    public V1beta1ComputeNetworkEndpointGroupSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeNetworkEndpointGroupStatus? Status { get; set; }
}