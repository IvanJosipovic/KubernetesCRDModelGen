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
public partial class V1beta1ComputeServiceAttachmentSpecConsumerAcceptListsProjectRef
{
    /// <summary>The project id or number for the project to set the limit for.  Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).</summary>
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
public partial class V1beta1ComputeServiceAttachmentSpecConsumerAcceptLists
{
    /// <summary>The value of the limit to set.</summary>
    [JsonPropertyName("connectionLimit")]
    public long? ConnectionLimit { get; set; }

    /// <summary></summary>
    [JsonPropertyName("projectRef")]
    public V1beta1ComputeServiceAttachmentSpecConsumerAcceptListsProjectRef ProjectRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeServiceAttachmentSpecConsumerRejectLists
{
    /// <summary>Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).</summary>
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
public partial class V1beta1ComputeServiceAttachmentSpecNatSubnets
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

/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeServiceAttachmentSpecProjectRef
{
    /// <summary>The project for the resource  Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeServiceAttachmentSpecTargetServiceRef
{
    /// <summary>The URL of a service serving the endpoint identified by this service attachment.  Allowed value: The `selfLink` field of a `ComputeForwardingRule` resource.</summary>
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
public partial class V1beta1ComputeServiceAttachmentSpec
{
    /// <summary>The connection preference of service attachment. The value can be set to `ACCEPT_AUTOMATIC`. An `ACCEPT_AUTOMATIC` service attachment is one that always accepts the connection from consumer forwarding rules. Possible values: CONNECTION_PREFERENCE_UNSPECIFIED, ACCEPT_AUTOMATIC, ACCEPT_MANUAL</summary>
    [JsonPropertyName("connectionPreference")]
    public string ConnectionPreference { get; set; }

    /// <summary>Projects that are allowed to connect to this service attachment.</summary>
    [JsonPropertyName("consumerAcceptLists")]
    public IList<V1beta1ComputeServiceAttachmentSpecConsumerAcceptLists>? ConsumerAcceptLists { get; set; }

    /// <summary></summary>
    [JsonPropertyName("consumerRejectLists")]
    public IList<V1beta1ComputeServiceAttachmentSpecConsumerRejectLists>? ConsumerRejectLists { get; set; }

    /// <summary>An optional description of this resource. Provide this property when you create the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. If true, enable the proxy protocol which is for supplying client TCP/IP address data in TCP connections that traverse proxies on their way to destination servers.</summary>
    [JsonPropertyName("enableProxyProtocol")]
    public bool? EnableProxyProtocol { get; set; }

    /// <summary>Immutable. The location for the resource</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("natSubnets")]
    public IList<V1beta1ComputeServiceAttachmentSpecNatSubnets> NatSubnets { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1ComputeServiceAttachmentSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("targetServiceRef")]
    public V1beta1ComputeServiceAttachmentSpecTargetServiceRef TargetServiceRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeServiceAttachmentStatusConditions
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
public partial class V1beta1ComputeServiceAttachmentStatusConnectedEndpoints
{
    /// <summary>The url of a connected endpoint.</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    /// <summary>The PSC connection id of the connected endpoint.</summary>
    [JsonPropertyName("pscConnectionId")]
    public long? PscConnectionId { get; set; }

    /// <summary>The status of a connected endpoint to this service attachment. Possible values: PENDING, RUNNING, DONE</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>An 128-bit global unique ID of the PSC service attachment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeServiceAttachmentStatusPscServiceAttachmentId
{
    /// <summary></summary>
    [JsonPropertyName("high")]
    public long? High { get; set; }

    /// <summary></summary>
    [JsonPropertyName("low")]
    public long? Low { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeServiceAttachmentStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeServiceAttachmentStatusConditions>? Conditions { get; set; }

    /// <summary>An array of connections for all the consumers connected to this service attachment.</summary>
    [JsonPropertyName("connectedEndpoints")]
    public IList<V1beta1ComputeServiceAttachmentStatusConnectedEndpoints>? ConnectedEndpoints { get; set; }

    /// <summary>Fingerprint of this resource. This field is used internally during updates of this resource.</summary>
    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; set; }

    /// <summary>The unique identifier for the resource type. The server generates this identifier.</summary>
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>An 128-bit global unique ID of the PSC service attachment.</summary>
    [JsonPropertyName("pscServiceAttachmentId")]
    public V1beta1ComputeServiceAttachmentStatusPscServiceAttachmentId? PscServiceAttachmentId { get; set; }

    /// <summary>URL of the region where the service attachment resides. This field applies only to the region resource. You must specify this field as part of the HTTP request URL. It is not settable as a field in the request body.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Server-defined URL for the resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeServiceAttachment : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeServiceAttachmentSpec>, IStatus<V1beta1ComputeServiceAttachmentStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeServiceAttachment";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computeserviceattachments";
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
    public V1beta1ComputeServiceAttachmentSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeServiceAttachmentStatus? Status { get; set; }
}