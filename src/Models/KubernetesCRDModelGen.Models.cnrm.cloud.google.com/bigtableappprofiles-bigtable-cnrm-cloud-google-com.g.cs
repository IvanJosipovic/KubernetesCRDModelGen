using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.bigtable.cnrm.cloud.google.com;
/// <summary>The instance to create the app profile within.</summary>
public partial class V1beta1BigtableAppProfileSpecInstanceRef
{
    /// <summary>Allowed value: The `name` field of a `BigtableInstance` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Use a single-cluster routing policy.</summary>
public partial class V1beta1BigtableAppProfileSpecSingleClusterRouting
{
    /// <summary>If true, CheckAndMutateRow and ReadModifyWriteRow requests are allowed by this app profile. It is unsafe to send these requests to the same table/row/column in multiple clusters.</summary>
    [JsonPropertyName("allowTransactionalWrites")]
    public bool? AllowTransactionalWrites { get; set; }

    /// <summary>The cluster to which read/write requests should be routed.</summary>
    [JsonPropertyName("clusterId")]
    public string ClusterId { get; set; }
}

/// <summary>The standard options used for isolating this app profile's traffic from other use cases.</summary>
public partial class V1beta1BigtableAppProfileSpecStandardIsolation
{
    /// <summary>The priority of requests sent using this app profile. Possible values: ["PRIORITY_LOW", "PRIORITY_MEDIUM", "PRIORITY_HIGH"].</summary>
    [JsonPropertyName("priority")]
    public string Priority { get; set; }
}

/// <summary></summary>
public partial class V1beta1BigtableAppProfileSpec
{
    /// <summary>Long form description of the use case for this app profile.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The instance to create the app profile within.</summary>
    [JsonPropertyName("instanceRef")]
    public V1beta1BigtableAppProfileSpecInstanceRef? InstanceRef { get; set; }

    /// <summary>The set of clusters to route to. The order is ignored; clusters will be tried in order of distance. If left empty, all clusters are eligible.</summary>
    [JsonPropertyName("multiClusterRoutingClusterIds")]
    public IList<string>? MultiClusterRoutingClusterIds { get; set; }

    /// <summary>If true, read/write requests are routed to the nearest cluster in the instance, and will fail over to the nearest cluster that is available in the event of transient errors or delays. Clusters in a region are considered equidistant. Choosing this option sacrifices read-your-writes consistency to improve availability.</summary>
    [JsonPropertyName("multiClusterRoutingUseAny")]
    public bool? MultiClusterRoutingUseAny { get; set; }

    /// <summary>Immutable. Optional. The appProfileId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Use a single-cluster routing policy.</summary>
    [JsonPropertyName("singleClusterRouting")]
    public V1beta1BigtableAppProfileSpecSingleClusterRouting? SingleClusterRouting { get; set; }

    /// <summary>The standard options used for isolating this app profile's traffic from other use cases.</summary>
    [JsonPropertyName("standardIsolation")]
    public V1beta1BigtableAppProfileSpecStandardIsolation? StandardIsolation { get; set; }
}

/// <summary></summary>
public partial class V1beta1BigtableAppProfileStatusConditions
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
public partial class V1beta1BigtableAppProfileStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BigtableAppProfileStatusConditions>? Conditions { get; set; }

    /// <summary>The unique name of the requested app profile. Values are of the form 'projects/&lt;project&gt;/instances/&lt;instance&gt;/appProfiles/&lt;appProfileId&gt;'.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
/// <summary></summary>
public partial class V1beta1BigtableAppProfile : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BigtableAppProfileSpec>, IStatus<V1beta1BigtableAppProfileStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BigtableAppProfile";
    public const string KubeGroup = "bigtable.cnrm.cloud.google.com";
    public const string KubePluralName = "bigtableappprofiles";
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
    public V1beta1BigtableAppProfileSpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1BigtableAppProfileStatus? Status { get; set; }
}