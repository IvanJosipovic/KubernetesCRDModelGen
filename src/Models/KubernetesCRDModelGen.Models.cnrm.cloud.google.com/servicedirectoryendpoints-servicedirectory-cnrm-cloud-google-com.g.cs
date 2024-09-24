using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.servicedirectory.cnrm.cloud.google.com;
public partial class V1beta1ServiceDirectoryEndpointSpecAddressRef
{
    /// <summary>Allowed value: The `address` field of a `ComputeAddress` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1ServiceDirectoryEndpointSpecNetworkRef
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

public partial class V1beta1ServiceDirectoryEndpointSpecServiceRef
{
    /// <summary>Allowed value: The `name` field of a `ServiceDirectoryService` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

public partial class V1beta1ServiceDirectoryEndpointSpec
{
    /// <summary></summary>
    [JsonPropertyName("addressRef")]
    public V1beta1ServiceDirectoryEndpointSpecAddressRef? AddressRef { get; set; }

    /// <summary>Only the `external` field is supported to configure the reference.  Immutable. The Google Compute Engine network (VPC) of the endpoint in the format projects/&lt;project number&gt;/locations/global/networks/*.  The project must be specified by project number (project id is rejected). Incorrectly formatted networks are rejected, but no other validation is performed on this field (ex. network or project existence, reachability, or permissions).</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1ServiceDirectoryEndpointSpecNetworkRef? NetworkRef { get; set; }

    /// <summary>Port that the endpoint is running on, must be in the range of [0, 65535]. If unspecified, the default is 0.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Immutable. Optional. The endpointId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The ServiceDirectoryService that this endpoint belongs to.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta1ServiceDirectoryEndpointSpecServiceRef ServiceRef { get; set; }
}

public partial class V1beta1ServiceDirectoryEndpointStatusConditions
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

public partial class V1beta1ServiceDirectoryEndpointStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ServiceDirectoryEndpointStatusConditions>? Conditions { get; set; }

    /// <summary>The resource name for the endpoint in the format 'projects/*/locations/*/namespaces/*/services/*/endpoints/*'.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ServiceDirectoryEndpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ServiceDirectoryEndpointSpec>, IStatus<V1beta1ServiceDirectoryEndpointStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ServiceDirectoryEndpoint";
    public const string KubeGroup = "servicedirectory.cnrm.cloud.google.com";
    public const string KubePluralName = "servicedirectoryendpoints";
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
    public V1beta1ServiceDirectoryEndpointSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ServiceDirectoryEndpointStatus? Status { get; set; }
}