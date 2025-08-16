using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.eventing.keda.sh;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ClusterCloudEventSourceList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ClusterCloudEventSource>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterCloudEventSourceList";
    public const string KubeGroup = "eventing.keda.sh";
    public const string KubePluralName = "clustercloudeventsources";
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
    public IList<V1alpha1ClusterCloudEventSource> Items { get; set; }
}

/// <summary>AuthenticationRef points to the TriggerAuthentication or ClusterTriggerAuthentication object that is used to authenticate the scaler with the environment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterCloudEventSourceSpecAuthenticationRef
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
public partial class V1alpha1ClusterCloudEventSourceSpecDestinationAzureEventGridTopic
{
    /// <summary></summary>
    [JsonPropertyName("endpoint")]
    public string Endpoint { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterCloudEventSourceSpecDestinationHttp
{
    /// <summary></summary>
    [JsonPropertyName("uri")]
    public string Uri { get; set; }
}

/// <summary>Destination defines the various ways to emit events</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterCloudEventSourceSpecDestination
{
    /// <summary></summary>
    [JsonPropertyName("azureEventGridTopic")]
    public V1alpha1ClusterCloudEventSourceSpecDestinationAzureEventGridTopic? AzureEventGridTopic { get; set; }

    /// <summary></summary>
    [JsonPropertyName("http")]
    public V1alpha1ClusterCloudEventSourceSpecDestinationHttp? Http { get; set; }
}

/// <summary>EventSubscription defines filters for events</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterCloudEventSourceSpecEventSubscription
{
    /// <summary></summary>
    [JsonPropertyName("excludedEventTypes")]
    public IList<string>? ExcludedEventTypes { get; set; }

    /// <summary></summary>
    [JsonPropertyName("includedEventTypes")]
    public IList<string>? IncludedEventTypes { get; set; }
}

/// <summary>CloudEventSourceSpec defines the spec of CloudEventSource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterCloudEventSourceSpec
{
    /// <summary>AuthenticationRef points to the TriggerAuthentication or ClusterTriggerAuthentication object that is used to authenticate the scaler with the environment</summary>
    [JsonPropertyName("authenticationRef")]
    public V1alpha1ClusterCloudEventSourceSpecAuthenticationRef? AuthenticationRef { get; set; }

    /// <summary></summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>Destination defines the various ways to emit events</summary>
    [JsonPropertyName("destination")]
    public V1alpha1ClusterCloudEventSourceSpecDestination Destination { get; set; }

    /// <summary>EventSubscription defines filters for events</summary>
    [JsonPropertyName("eventSubscription")]
    public V1alpha1ClusterCloudEventSourceSpecEventSubscription? EventSubscription { get; set; }
}

/// <summary>Condition to store the condition state</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterCloudEventSourceStatusConditions
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
public partial class V1alpha1ClusterCloudEventSourceStatus
{
    /// <summary>Conditions an array representation to store multiple Conditions</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ClusterCloudEventSourceStatusConditions>? Conditions { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ClusterCloudEventSource : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ClusterCloudEventSourceSpec>, IStatus<V1alpha1ClusterCloudEventSourceStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterCloudEventSource";
    public const string KubeGroup = "eventing.keda.sh";
    public const string KubePluralName = "clustercloudeventsources";
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
    public V1alpha1ClusterCloudEventSourceSpec Spec { get; set; }

    /// <summary>CloudEventSourceStatus defines the observed state of CloudEventSource</summary>
    [JsonPropertyName("status")]
    public V1alpha1ClusterCloudEventSourceStatus? Status { get; set; }
}