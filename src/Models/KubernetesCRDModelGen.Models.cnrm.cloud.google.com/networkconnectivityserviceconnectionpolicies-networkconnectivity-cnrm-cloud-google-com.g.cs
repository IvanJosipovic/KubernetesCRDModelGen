using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networkconnectivity.cnrm.cloud.google.com;
/// <summary>The resource path of the consumer network. Example: - projects/{projectNumOrId}/global/networks/{resourceId}.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkConnectivityServiceConnectionPolicySpecNetworkRef
{
    /// <summary>A reference to an externally managed Compute Network resource. Should be in the format `projects/{{projectID}}/global/networks/{{network}}`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeNetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkConnectivityServiceConnectionPolicySpecProjectRef
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkConnectivityServiceConnectionPolicySpecPscConfigSubnetworkRefs
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

/// <summary>Configuration used for Private Service Connect connections. Used when Infrastructure is PSC.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkConnectivityServiceConnectionPolicySpecPscConfig
{
    /// <summary>Optional. Max number of PSC connections for this policy.</summary>
    [JsonPropertyName("limit")]
    public long? Limit { get; set; }

    /// <summary>Required. ProducerInstanceLocation is used to specify which authorization mechanism to use to determine which projects the Producer instance can be within.</summary>
    [JsonPropertyName("producerInstanceLocation")]
    public string? ProducerInstanceLocation { get; set; }

    /// <summary>The resource paths of subnetworks to use for IP address management. Example: projects/{projectNumOrId}/regions/{region}/subnetworks/{resourceId}.</summary>
    [JsonPropertyName("subnetworkRefs")]
    public IList<V1alpha1NetworkConnectivityServiceConnectionPolicySpecPscConfigSubnetworkRefs>? SubnetworkRefs { get; set; }
}

/// <summary>NetworkConnectivityServiceConnectionPolicySpec defines the desired state of NetworkConnectivityServiceConnectionPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkConnectivityServiceConnectionPolicySpec
{
    /// <summary>A description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. Location of the resource.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>The resource path of the consumer network. Example: - projects/{projectNumOrId}/global/networks/{resourceId}.</summary>
    [JsonPropertyName("networkRef")]
    public V1alpha1NetworkConnectivityServiceConnectionPolicySpecNetworkRef? NetworkRef { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1NetworkConnectivityServiceConnectionPolicySpecProjectRef ProjectRef { get; set; }

    /// <summary>Configuration used for Private Service Connect connections. Used when Infrastructure is PSC.</summary>
    [JsonPropertyName("pscConfig")]
    public V1alpha1NetworkConnectivityServiceConnectionPolicySpecPscConfig? PscConfig { get; set; }

    /// <summary>The NetworkConnectivityServiceConnectionPolicy name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The service class identifier for which this ServiceConnectionPolicy is for. The service class identifier is a unique, symbolic representation of a ServiceClass. It is provided by the Service Producer. Google services have a prefix of gcp. For example, gcp-cloud-sql. 3rd party services do not. For example, test-service-a3dfcx.</summary>
    [JsonPropertyName("serviceClass")]
    public string? ServiceClass { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkConnectivityServiceConnectionPolicyStatusConditions
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

/// <summary>The most recent error during operating this connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkConnectivityServiceConnectionPolicyStatusObservedStatePscConnectionsError
{
    /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>A developer-facing error message, which should be in English. Any user-facing error message should be localized and sent in the google.rpc.Status.details field, or localized by the client.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

/// <summary>Output only. The error info for the latest error during operating this connection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkConnectivityServiceConnectionPolicyStatusObservedStatePscConnectionsErrorInfo
{
    /// <summary>The logical grouping to which the "reason" belongs. The error domain is typically the registered service name of the tool or product that generates the error. Example: "pubsub.googleapis.com". If the error is generated by some common infrastructure, the error domain must be a globally unique value that identifies the infrastructure. For Google API infrastructure, the error domain is "googleapis.com".</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>Additional structured details about this error. Keys must match /a-z+/ but should ideally be lowerCamelCase. Also they must be limited to 64 characters in length. When identifying the current value of an exceeded limit, the units should be contained in the key, not the value. For example, rather than {"instanceLimit": "100/request"}, should be returned as, {"instanceLimitPerRequest": "100"}, if the client exceeds the number of instances that can be created in a single (batch) request.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The reason of the error. This is a constant value that identifies the proximate cause of the error. Error reasons are unique within a particular domain of errors. This should be at most 63 characters and match a regular expression of `A-Z+[A-Z0-9]`, which represents UPPER_SNAKE_CASE.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkConnectivityServiceConnectionPolicyStatusObservedStatePscConnections
{
    /// <summary>The resource reference of the consumer address.</summary>
    [JsonPropertyName("consumerAddress")]
    public string? ConsumerAddress { get; set; }

    /// <summary>The resource reference of the PSC Forwarding Rule within the consumer VPC.</summary>
    [JsonPropertyName("consumerForwardingRule")]
    public string? ConsumerForwardingRule { get; set; }

    /// <summary>The project where the PSC connection is created.</summary>
    [JsonPropertyName("consumerTargetProject")]
    public string? ConsumerTargetProject { get; set; }

    /// <summary>The most recent error during operating this connection.</summary>
    [JsonPropertyName("error")]
    public V1alpha1NetworkConnectivityServiceConnectionPolicyStatusObservedStatePscConnectionsError? Error { get; set; }

    /// <summary>Output only. The error info for the latest error during operating this connection.</summary>
    [JsonPropertyName("errorInfo")]
    public V1alpha1NetworkConnectivityServiceConnectionPolicyStatusObservedStatePscConnectionsErrorInfo? ErrorInfo { get; set; }

    /// <summary>The error type indicates whether the error is consumer facing, producer facing or system internal.</summary>
    [JsonPropertyName("errorType")]
    public string? ErrorType { get; set; }

    /// <summary>The last Compute Engine operation to setup PSC connection.</summary>
    [JsonPropertyName("gceOperation")]
    public string? GceOperation { get; set; }

    /// <summary>Immutable. An immutable identifier for the producer instance.</summary>
    [JsonPropertyName("producerInstanceID")]
    public string? ProducerInstanceID { get; set; }

    /// <summary>The PSC connection id of the PSC forwarding rule.</summary>
    [JsonPropertyName("pscConnectionID")]
    public string? PscConnectionID { get; set; }

    /// <summary>Output only. The URI of the subnetwork selected to allocate IP address for this connection.</summary>
    [JsonPropertyName("selectedSubnetwork")]
    public string? SelectedSubnetwork { get; set; }

    /// <summary>State of the PSC Connection</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkConnectivityServiceConnectionPolicyStatusObservedState
{
    /// <summary>Output only. Time when the ServiceConnectionMap was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Optional. The etag is computed by the server, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Output only. The type of underlying resources used to create the connection.</summary>
    [JsonPropertyName("infrastructure")]
    public string? Infrastructure { get; set; }

    /// <summary>Output only. [Output only] Information about each Private Service Connect connection.</summary>
    [JsonPropertyName("pscConnections")]
    public IList<V1alpha1NetworkConnectivityServiceConnectionPolicyStatusObservedStatePscConnections>? PscConnections { get; set; }

    /// <summary>Output only. Time when the ServiceConnectionMap was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>NetworkConnectivityServiceConnectionPolicyStatus defines the config connector machine state of NetworkConnectivityServiceConnectionPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkConnectivityServiceConnectionPolicyStatus
{
    /// <summary>Conditions represent the latest available observations of the object's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1NetworkConnectivityServiceConnectionPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the NetworkConnectivityServiceConnectionPolicy resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1NetworkConnectivityServiceConnectionPolicyStatusObservedState? ObservedState { get; set; }
}

/// <summary>NetworkConnectivityServiceConnectionPolicy is the Schema for the NetworkConnectivityServiceConnectionPolicy API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NetworkConnectivityServiceConnectionPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1NetworkConnectivityServiceConnectionPolicySpec>, IStatus<V1alpha1NetworkConnectivityServiceConnectionPolicyStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NetworkConnectivityServiceConnectionPolicy";
    public const string KubeGroup = "networkconnectivity.cnrm.cloud.google.com";
    public const string KubePluralName = "networkconnectivityserviceconnectionpolicies";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NetworkConnectivityServiceConnectionPolicySpec defines the desired state of NetworkConnectivityServiceConnectionPolicy</summary>
    [JsonPropertyName("spec")]
    public V1alpha1NetworkConnectivityServiceConnectionPolicySpec? Spec { get; set; }

    /// <summary>NetworkConnectivityServiceConnectionPolicyStatus defines the config connector machine state of NetworkConnectivityServiceConnectionPolicy</summary>
    [JsonPropertyName("status")]
    public V1alpha1NetworkConnectivityServiceConnectionPolicyStatus? Status { get; set; }
}