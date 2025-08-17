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
/// <summary>ComputeNetworkAttachment is the Schema for the ComputeNetworkAttachment API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ComputeNetworkAttachmentList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ComputeNetworkAttachment>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ComputeNetworkAttachmentList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computenetworkattachments";
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
    public IList<V1alpha1ComputeNetworkAttachment> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeNetworkAttachmentSpecProducerAcceptLists
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
#nullable disable

#nullable enable
/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeNetworkAttachmentSpecProducerRejectLists
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
#nullable disable

#nullable enable
/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeNetworkAttachmentSpecProjectRef
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
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeNetworkAttachmentSpecSubnetworkRefs
{
    /// <summary>The ComputeSubnetwork selflink of form "projects/{{project}}/regions/{{region}}/subnetworks/{{name}}", when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ComputeNetworkAttachmentSpec defines the desired state of ComputeNetworkAttachment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeNetworkAttachmentSpec
{
    /// <summary>Check the ConnectionPreference enum for the list of possible values.</summary>
    [JsonPropertyName("connectionPreference")]
    public string? ConnectionPreference { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Fingerprint of this resource. A hash of the contents stored in this object. This field is used in optimistic locking. An up-to-date fingerprint must be provided in order to patch.</summary>
    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; set; }

    /// <summary></summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Projects that are allowed to connect to this network attachment. The project can be specified using its id or number.</summary>
    [JsonPropertyName("producerAcceptLists")]
    public IList<V1alpha1ComputeNetworkAttachmentSpecProducerAcceptLists>? ProducerAcceptLists { get; set; }

    /// <summary>Projects that are not allowed to connect to this network attachment. The project can be specified using its id or number.</summary>
    [JsonPropertyName("producerRejectLists")]
    public IList<V1alpha1ComputeNetworkAttachmentSpecProducerRejectLists>? ProducerRejectLists { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1ComputeNetworkAttachmentSpecProjectRef ProjectRef { get; set; }

    /// <summary>The ComputeNetworkAttachment name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>An array of URLs where each entry is the URL of a subnet provided by the service consumer to use for endpoints in the producers that connect to this network attachment.</summary>
    [JsonPropertyName("subnetworkRefs")]
    public IList<V1alpha1ComputeNetworkAttachmentSpecSubnetworkRefs>? SubnetworkRefs { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeNetworkAttachmentStatusConditions
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
public partial class V1alpha1ComputeNetworkAttachmentStatusObservedStateConnectionEndpoints
{
    /// <summary>The IPv4 address assigned to the producer instance network interface. This value will be a range in case of Serverless.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>The IPv6 address assigned to the producer instance network interface. This is only assigned when the stack types of both the instance network interface and the consumer subnet are IPv4_IPv6.</summary>
    [JsonPropertyName("ipv6Address")]
    public string? Ipv6Address { get; set; }

    /// <summary>The project id or number of the interface to which the IP was assigned.</summary>
    [JsonPropertyName("projectIDOrNum")]
    public string? ProjectIDOrNum { get; set; }

    /// <summary>Alias IP ranges from the same subnetwork.</summary>
    [JsonPropertyName("secondaryIPCIDRRanges")]
    public IList<string>? SecondaryIPCIDRRanges { get; set; }

    /// <summary>The status of a connected endpoint to this network attachment. Check the Status enum for the list of possible values.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>The subnetwork used to assign the IP to the producer instance network interface.</summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>[Output Only] The CIDR range of the subnet from which the IPv4 internal IP was allocated from.</summary>
    [JsonPropertyName("subnetworkCIDRRange")]
    public string? SubnetworkCIDRRange { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeNetworkAttachmentStatusObservedState
{
    /// <summary>[Output Only] An array of connections for all the producers connected to this network attachment.</summary>
    [JsonPropertyName("connectionEndpoints")]
    public IList<V1alpha1ComputeNetworkAttachmentStatusObservedStateConnectionEndpoints>? ConnectionEndpoints { get; set; }

    /// <summary>[Output Only] Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>[Output Only] The unique identifier for the resource type. The server generates this identifier.</summary>
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    /// <summary>[Output Only] Type of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>[Output Only] The URL of the network which the Network Attachment belongs to. Practically it is inferred by fetching the network of the first subnetwork associated. Because it is required that all the subnetworks must be from the same network, it is assured that the Network Attachment belongs to the same network as all the subnetworks.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>[Output Only] URL of the region where the network attachment resides. This field applies only to the region resource. You must specify this field as part of the HTTP request URL. It is not settable as a field in the request body.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>[Output Only] Server-defined URL for the resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>[Output Only] Server-defined URL for this resource's resource id.</summary>
    [JsonPropertyName("selfLinkWithID")]
    public string? SelfLinkWithID { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ComputeNetworkAttachmentStatus defines the config connector machine state of ComputeNetworkAttachment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ComputeNetworkAttachmentStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ComputeNetworkAttachmentStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the ComputeNetworkAttachment resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1ComputeNetworkAttachmentStatusObservedState? ObservedState { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ComputeNetworkAttachment is the Schema for the ComputeNetworkAttachment API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ComputeNetworkAttachment : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ComputeNetworkAttachmentSpec>, IStatus<V1alpha1ComputeNetworkAttachmentStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ComputeNetworkAttachment";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computenetworkattachments";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ComputeNetworkAttachmentSpec defines the desired state of ComputeNetworkAttachment</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ComputeNetworkAttachmentSpec Spec { get; set; }

    /// <summary>ComputeNetworkAttachmentStatus defines the config connector machine state of ComputeNetworkAttachment</summary>
    [JsonPropertyName("status")]
    public V1alpha1ComputeNetworkAttachmentStatus? Status { get; set; }
}
#nullable disable
