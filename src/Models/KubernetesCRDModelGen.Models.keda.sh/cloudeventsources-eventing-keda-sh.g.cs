using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.eventing.keda.sh;
/// <summary>AuthenticationRef points to the TriggerAuthentication or ClusterTriggerAuthentication object that is used to authenticate the scaler with the environment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudEventSourceSpecAuthenticationRef
{
    /// <summary>Kind of the resource being referred to. Defaults to TriggerAuthentication.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudEventSourceSpecDestinationAzureEventGridTopic
{
    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string Endpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudEventSourceSpecDestinationHttp
{
    /// <summary></summary>
    [JsonPropertyName("uri")]
    public string Uri { get; set; }
}

/// <summary>Destination defines the various ways to emit events</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudEventSourceSpecDestination
{
    /// <summary></summary>
    [JsonPropertyName("azureEventGridTopic")]
    public V1alpha1CloudEventSourceSpecDestinationAzureEventGridTopic? AzureEventGridTopic { get; set; }

    /// <summary></summary>
    [JsonPropertyName("http")]
    public V1alpha1CloudEventSourceSpecDestinationHttp? Http { get; set; }
}

/// <summary>CloudEventType contains the list of cloudevent types</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1alpha1CloudEventSourceSpecEventSubscriptionExcludedEventTypesEnum
{
    [EnumMember(Value = "keda.scaledobject.ready.v1"), JsonStringEnumMemberName("keda.scaledobject.ready.v1")]
    /// <summary>keda.scaledobject.ready.v1</summary>
    KedaScaledobjectReadyV1,
    [EnumMember(Value = "keda.scaledobject.failed.v1"), JsonStringEnumMemberName("keda.scaledobject.failed.v1")]
    /// <summary>keda.scaledobject.failed.v1</summary>
    KedaScaledobjectFailedV1
}

/// <summary>CloudEventType contains the list of cloudevent types</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1alpha1CloudEventSourceSpecEventSubscriptionIncludedEventTypesEnum
{
    [EnumMember(Value = "keda.scaledobject.ready.v1"), JsonStringEnumMemberName("keda.scaledobject.ready.v1")]
    /// <summary>keda.scaledobject.ready.v1</summary>
    KedaScaledobjectReadyV1,
    [EnumMember(Value = "keda.scaledobject.failed.v1"), JsonStringEnumMemberName("keda.scaledobject.failed.v1")]
    /// <summary>keda.scaledobject.failed.v1</summary>
    KedaScaledobjectFailedV1
}

/// <summary>EventSubscription defines filters for events</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudEventSourceSpecEventSubscription
{
    /// <summary></summary>
    [JsonPropertyName("excludedEventTypes")]
    public IList<V1alpha1CloudEventSourceSpecEventSubscriptionExcludedEventTypesEnum>? ExcludedEventTypes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includedEventTypes")]
    public IList<V1alpha1CloudEventSourceSpecEventSubscriptionIncludedEventTypesEnum>? IncludedEventTypes { get; set; }
}

/// <summary>CloudEventSourceSpec defines the spec of CloudEventSource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudEventSourceSpec
{
    /// <summary>AuthenticationRef points to the TriggerAuthentication or ClusterTriggerAuthentication object that is used to authenticate the scaler with the environment</summary>
    [JsonPropertyName("authenticationRef")]
    public V1alpha1CloudEventSourceSpecAuthenticationRef? AuthenticationRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>Destination defines the various ways to emit events</summary>
    [JsonPropertyName("destination")]
    public V1alpha1CloudEventSourceSpecDestination Destination { get; set; }

    /// <summary>EventSubscription defines filters for events</summary>
    [JsonPropertyName("eventSubscription")]
    public V1alpha1CloudEventSourceSpecEventSubscription? EventSubscription { get; set; }
}

/// <summary>Condition to store the condition state</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudEventSourceStatusConditions
{
    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition's last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of condition</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>CloudEventSourceStatus defines the observed state of CloudEventSource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudEventSourceStatus
{
    /// <summary>Conditions an array representation to store multiple Conditions</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CloudEventSourceStatusConditions>? Conditions { get; set; }
}

/// <summary>CloudEventSource defines how a KEDA event will be sent to event sink</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudEventSource : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CloudEventSourceSpec>, IStatus<V1alpha1CloudEventSourceStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudEventSource";
    public const string KubeGroup = "eventing.keda.sh";
    public const string KubePluralName = "cloudeventsources";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CloudEventSourceSpec defines the spec of CloudEventSource</summary>
    [JsonPropertyName("spec")]
    public V1alpha1CloudEventSourceSpec Spec { get; set; }

    /// <summary>CloudEventSourceStatus defines the observed state of CloudEventSource</summary>
    [JsonPropertyName("status")]
    public V1alpha1CloudEventSourceStatus? Status { get; set; }
}