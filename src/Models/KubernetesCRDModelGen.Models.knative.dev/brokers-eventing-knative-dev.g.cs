using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.eventing.knative.dev;
/// <summary>Config is a KReference to the configuration that specifies configuration options for this Broker. For example, this could be a pointer to a ConfigMap.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BrokerSpecConfig
{
    /// <summary>API version of the referent.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind of the referent. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/ This is optional field, it gets defaulted to the object holding it if left out.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Spec defines the desired state of the Broker.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BrokerSpec
{
    /// <summary>Config is a KReference to the configuration that specifies configuration options for this Broker. For example, this could be a pointer to a ConfigMap.</summary>
    [JsonPropertyName("config")]
    public V1BrokerSpecConfig? Config { get; set; }

    /// <summary>Delivery contains the delivery spec for each trigger to this Broker. Each trigger delivery spec, if any, overrides this global delivery spec.</summary>
    [JsonPropertyName("delivery")]
    public JsonNode? Delivery { get; set; }
}

/// <summary>Broker is Addressable. It exposes the endpoint as an URI to get events delivered into the Broker mesh.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BrokerStatusAddress
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary></summary>
    [JsonPropertyName("CACerts")]
    public string? CACerts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BrokerStatusAddresses
{
    /// <summary></summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary></summary>
    [JsonPropertyName("CACerts")]
    public string? CACerts { get; set; }

    /// <summary></summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BrokerStatusPolicies
{
    /// <summary>The API version of the applied EventPolicy. This indicates, which version of EventPolicy is supported by the resource.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>The name of the applied EventPolicy</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BrokerStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another. We use VolatileTime in place of metav1.Time to exclude this from creating equality.Semantic differences (all other things held constant).</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Severity with which to treat failures of this type of condition. When this is not specified, it defaults to Error.</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>Status represents the current state of the Broker. This data may be out of date.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1BrokerStatus
{
    /// <summary>Broker is Addressable. It exposes the endpoint as an URI to get events delivered into the Broker mesh.</summary>
    [JsonPropertyName("address")]
    public V1BrokerStatusAddress? Address { get; set; }

    /// <summary>Broker is Addressable. It exposes the endpoints as URIs to get events delivered into the Broker mesh.</summary>
    [JsonPropertyName("addresses")]
    public IList<V1BrokerStatusAddresses>? Addresses { get; set; }

    /// <summary>Annotations is additional Status fields for the Resource to save some additional State as well as convey more information to the user. This is roughly akin to Annotations on any k8s resource, just the reconciler conveying richer information outwards.</summary>
    [JsonPropertyName("annotations")]
    public JsonNode? Annotations { get; set; }

    /// <summary>List of applied EventPolicies</summary>
    [JsonPropertyName("policies")]
    public IList<V1BrokerStatusPolicies>? Policies { get; set; }

    /// <summary>Conditions the latest available observations of a resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1BrokerStatusConditions>? Conditions { get; set; }

    /// <summary>DeadLetterSinkURI is the resolved URI of the dead letter sink that will be used as a fallback when not specified by Triggers.</summary>
    [JsonPropertyName("deadLetterSinkUri")]
    public string? DeadLetterSinkUri { get; set; }

    /// <summary>Certification Authority (CA) certificates in PEM format according to https://www.rfc-editor.org/rfc/rfc7468.</summary>
    [JsonPropertyName("deadLetterSinkCACerts")]
    public string? DeadLetterSinkCACerts { get; set; }

    /// <summary>OIDC audience of the dead letter sink.</summary>
    [JsonPropertyName("deadLetterSinkAudience")]
    public string? DeadLetterSinkAudience { get; set; }

    /// <summary>ObservedGeneration is the 'Generation' of the Service that was last processed by the controller.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Broker collects a pool of events that are consumable using Triggers. Brokers provide a well-known endpoint for event delivery that senders can use with minimal knowledge of the event routing strategy. Subscribers use Triggers to request delivery of events from a Broker's pool to a specific URL or Addressable endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Broker : IKubernetesObject<V1ObjectMeta>, ISpec<V1BrokerSpec>, IStatus<V1BrokerStatus>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Broker";
    public const string KubeGroup = "eventing.knative.dev";
    public const string KubePluralName = "brokers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec defines the desired state of the Broker.</summary>
    [JsonPropertyName("spec")]
    public V1BrokerSpec? Spec { get; set; }

    /// <summary>Status represents the current state of the Broker. This data may be out of date.</summary>
    [JsonPropertyName("status")]
    public V1BrokerStatus? Status { get; set; }
}

/// <summary>Broker collects a pool of events that are consumable using Triggers. Brokers provide a well-known endpoint for event delivery that senders can use with minimal knowledge of the event routing strategy. Subscribers use Triggers to request delivery of events from a Broker's pool to a specific URL or Addressable endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1BrokerList : IKubernetesObject<V1ListMeta>, IItems<V1Broker>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "BrokerList";
    public const string KubeGroup = "eventing.knative.dev";
    public const string KubePluralName = "brokers";
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
    public IList<V1Broker> Items { get; set; }
}