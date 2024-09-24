using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datastream.cnrm.cloud.google.com;
/// <summary>The project that this resource belongs to.</summary>
public partial class V1alpha1DatastreamPrivateConnectionSpecProjectRef
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

/// <summary>Immutable. The VPC Peering configuration is used to create VPC peering between Datastream and the consumer's VPC.</summary>
public partial class V1alpha1DatastreamPrivateConnectionSpecVpcPeeringConfig
{
    /// <summary>Immutable. A free subnet for peering. (CIDR of /29).</summary>
    [JsonPropertyName("subnet")]
    public string Subnet { get; set; }

    /// <summary>Immutable. Fully qualified name of the VPC that Datastream will peer to. Format: projects/{project}/global/{networks}/{name}.</summary>
    [JsonPropertyName("vpc")]
    public string Vpc { get; set; }
}

/// <summary></summary>
public partial class V1alpha1DatastreamPrivateConnectionSpec
{
    /// <summary>Immutable. Display name.</summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    /// <summary>Immutable. The name of the location this private connection is located in.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1DatastreamPrivateConnectionSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The privateConnectionId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. The VPC Peering configuration is used to create VPC peering between Datastream and the consumer's VPC.</summary>
    [JsonPropertyName("vpcPeeringConfig")]
    public V1alpha1DatastreamPrivateConnectionSpecVpcPeeringConfig VpcPeeringConfig { get; set; }
}

/// <summary></summary>
public partial class V1alpha1DatastreamPrivateConnectionStatusConditions
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
public partial class V1alpha1DatastreamPrivateConnectionStatusError
{
    /// <summary>A list of messages that carry the error details.</summary>
    [JsonPropertyName("details")]
    public IDictionary<string, string>? Details { get; set; }

    /// <summary>A message containing more information about the error that occurred.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

/// <summary></summary>
public partial class V1alpha1DatastreamPrivateConnectionStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DatastreamPrivateConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>The PrivateConnection error in case of failure.</summary>
    [JsonPropertyName("error")]
    public IList<V1alpha1DatastreamPrivateConnectionStatusError>? Error { get; set; }

    /// <summary>The resource's name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>State of the PrivateConnection.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1alpha1DatastreamPrivateConnection : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DatastreamPrivateConnectionSpec>, IStatus<V1alpha1DatastreamPrivateConnectionStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DatastreamPrivateConnection";
    public const string KubeGroup = "datastream.cnrm.cloud.google.com";
    public const string KubePluralName = "datastreamprivateconnections";
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
    public V1alpha1DatastreamPrivateConnectionSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1DatastreamPrivateConnectionStatus? Status { get; set; }
}