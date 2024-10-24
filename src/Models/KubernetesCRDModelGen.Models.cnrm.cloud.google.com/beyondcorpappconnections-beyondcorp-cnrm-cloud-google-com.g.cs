using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.beyondcorp.cnrm.cloud.google.com;
/// <summary>Address of the remote application endpoint for the BeyondCorp AppConnection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BeyondCorpAppConnectionSpecApplicationEndpoint
{
    /// <summary>Hostname or IP address of the remote application endpoint.</summary>
    [JsonPropertyName("host")]
    public string Host { get; set; }

    /// <summary>Port of the remote application endpoint.</summary>
    [JsonPropertyName("port")]
    public int Port { get; set; }
}

/// <summary>Gateway used by the AppConnection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BeyondCorpAppConnectionSpecGateway
{
    /// <summary>AppGateway name in following format: projects/{project_id}/locations/{locationId}/appgateways/{gateway_id}.</summary>
    [JsonPropertyName("appGateway")]
    public string AppGateway { get; set; }

    /// <summary>Ingress port reserved on the gateways for this AppConnection, if not specified or zero, the default port is 19443.</summary>
    [JsonPropertyName("ingressPort")]
    public int? IngressPort { get; set; }

    /// <summary>The type of hosting used by the gateway. Refer to https://cloud.google.com/beyondcorp/docs/reference/rest/v1/projects.locations.appConnections#Type_1 for a list of possible values.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Server-defined URI for this resource.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BeyondCorpAppConnectionSpecProjectRef
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BeyondCorpAppConnectionSpec
{
    /// <summary>Address of the remote application endpoint for the BeyondCorp AppConnection.</summary>
    [JsonPropertyName("applicationEndpoint")]
    public V1alpha1BeyondCorpAppConnectionSpecApplicationEndpoint ApplicationEndpoint { get; set; }

    /// <summary>List of AppConnectors that are authorised to be associated with this AppConnection.</summary>
    [JsonPropertyName("connectors")]
    public IList<string>? Connectors { get; set; }

    /// <summary>An arbitrary user-provided name for the AppConnection.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Gateway used by the AppConnection.</summary>
    [JsonPropertyName("gateway")]
    public V1alpha1BeyondCorpAppConnectionSpecGateway? Gateway { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1BeyondCorpAppConnectionSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. The region of the AppConnection.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Immutable. The type of network connectivity used by the AppConnection. Refer to https://cloud.google.com/beyondcorp/docs/reference/rest/v1/projects.locations.appConnections#type for a list of possible values.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BeyondCorpAppConnectionStatusConditions
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
public partial class V1alpha1BeyondCorpAppConnectionStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BeyondCorpAppConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BeyondCorpAppConnection : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BeyondCorpAppConnectionSpec>, IStatus<V1alpha1BeyondCorpAppConnectionStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BeyondCorpAppConnection";
    public const string KubeGroup = "beyondcorp.cnrm.cloud.google.com";
    public const string KubePluralName = "beyondcorpappconnections";
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
    public V1alpha1BeyondCorpAppConnectionSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1BeyondCorpAppConnectionStatus? Status { get; set; }
}