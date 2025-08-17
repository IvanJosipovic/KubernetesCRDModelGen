using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.vpcaccess.cnrm.cloud.google.com;
#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VPCAccessConnectorList : IKubernetesObject<V1ListMeta>, IItems<V1beta1VPCAccessConnector>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VPCAccessConnectorList";
    public const string KubeGroup = "vpcaccess.cnrm.cloud.google.com";
    public const string KubePluralName = "vpcaccessconnectors";
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
    public IList<V1beta1VPCAccessConnector> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Immutable. Name or self_link of the VPC network. Required if 'ip_cidr_range' is set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCAccessConnectorSpecNetworkRef
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
#nullable disable

#nullable enable
/// <summary>Immutable. The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCAccessConnectorSpecProjectRef
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
#nullable disable

#nullable enable
/// <summary>Immutable. Subnet name (relative, not fully qualified). E.g. if the full subnet selfLink is https://compute.googleapis.com/compute/v1/projects/{project}/regions/{region}/subnetworks/{subnetName} the correct input for this field would be {subnetName}"</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCAccessConnectorSpecSubnetNameRef
{
    /// <summary>Allowed value: The `name` field of a `ComputeSubnetwork` resource.</summary>
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
/// <summary>Immutable. Project in which the subnet exists. If not set, this project is assumed to be the project for which the connector create request was issued.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCAccessConnectorSpecSubnetProjectRef
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
#nullable disable

#nullable enable
/// <summary>Immutable. The subnet in which to house the connector.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCAccessConnectorSpecSubnet
{
    /// <summary>Immutable. Subnet name (relative, not fully qualified). E.g. if the full subnet selfLink is https://compute.googleapis.com/compute/v1/projects/{project}/regions/{region}/subnetworks/{subnetName} the correct input for this field would be {subnetName}"</summary>
    [JsonPropertyName("nameRef")]
    public V1beta1VPCAccessConnectorSpecSubnetNameRef? NameRef { get; set; }

    /// <summary>Immutable. Project in which the subnet exists. If not set, this project is assumed to be the project for which the connector create request was issued.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1VPCAccessConnectorSpecSubnetProjectRef? ProjectRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCAccessConnectorSpec
{
    /// <summary>Immutable. The range of internal addresses that follows RFC 4632 notation. Example: '10.132.0.0/28'.</summary>
    [JsonPropertyName("ipCidrRange")]
    public string? IpCidrRange { get; set; }

    /// <summary>Location represents the geographical location of the VPCAccessConnector. Specify a region name. Reference: GCP definition of regions/zones (https://cloud.google.com/compute/docs/regions-zones/)</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Immutable. Machine type of VM Instance underlying connector. Default is e2-micro.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>Immutable. Maximum value of instances in autoscaling group underlying the connector.</summary>
    [JsonPropertyName("maxInstances")]
    public int? MaxInstances { get; set; }

    /// <summary>Immutable. Maximum throughput of the connector in Mbps, must be greater than 'min_throughput'. Default is 300.</summary>
    [JsonPropertyName("maxThroughput")]
    public int? MaxThroughput { get; set; }

    /// <summary>Immutable. Minimum value of instances in autoscaling group underlying the connector.</summary>
    [JsonPropertyName("minInstances")]
    public int? MinInstances { get; set; }

    /// <summary>Immutable. Minimum throughput of the connector in Mbps. Default and min is 200.</summary>
    [JsonPropertyName("minThroughput")]
    public int? MinThroughput { get; set; }

    /// <summary>Immutable. Name or self_link of the VPC network. Required if 'ip_cidr_range' is set.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1VPCAccessConnectorSpecNetworkRef? NetworkRef { get; set; }

    /// <summary>Immutable. The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1VPCAccessConnectorSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. The subnet in which to house the connector.</summary>
    [JsonPropertyName("subnet")]
    public V1beta1VPCAccessConnectorSpecSubnet? Subnet { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1VPCAccessConnectorStatusConditions
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
public partial class V1beta1VPCAccessConnectorStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1VPCAccessConnectorStatusConditions>? Conditions { get; set; }

    /// <summary>List of projects using the connector.</summary>
    [JsonPropertyName("connectedProjects")]
    public IList<string>? ConnectedProjects { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The fully qualified name of this VPC connector.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>State of the VPC access connector.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1VPCAccessConnector : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1VPCAccessConnectorSpec>, IStatus<V1beta1VPCAccessConnectorStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "VPCAccessConnector";
    public const string KubeGroup = "vpcaccess.cnrm.cloud.google.com";
    public const string KubePluralName = "vpcaccessconnectors";
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
    public V1beta1VPCAccessConnectorSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1VPCAccessConnectorStatus? Status { get; set; }
}
#nullable disable
