using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.eventarc.gcp.m.upbound.io;
/// <summary>Trigger is the Schema for the Triggers API. The Eventarc Trigger resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TriggerList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Trigger>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TriggerList";
    public const string KubeGroup = "eventarc.gcp.m.upbound.io";
    public const string KubePluralName = "triggers";
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
    public IList<V1beta1Trigger> Items { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderDestinationCloudRunServiceServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Service in cloudrun to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderDestinationCloudRunServiceServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecForProviderDestinationCloudRunServiceServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderDestinationCloudRunServiceServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Service in cloudrun to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderDestinationCloudRunServiceServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecForProviderDestinationCloudRunServiceServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>Cloud Run fully-managed service that receives the events. The service should be running in the same project of the trigger. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderDestinationCloudRunService
{
    /// <summary>Optional. The relative path on the GKE service the events should be sent to. The value must conform to the definition of a URI path segment (section 3.3 of RFC2396). Examples: "/route", "route", "route/subroute".</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Required. The region the Cloud Run service is deployed in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Required. Name of the GKE service.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a Service in cloudrun to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta1TriggerSpecForProviderDestinationCloudRunServiceServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a Service in cloudrun to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta1TriggerSpecForProviderDestinationCloudRunServiceServiceSelector? ServiceSelector { get; set; }
}

/// <summary>A GKE service capable of receiving events. The service should be running in the same project as the trigger. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderDestinationGke
{
    /// <summary>Required. The name of the cluster the GKE service is running in. The cluster must be running in the same project as the trigger being created.</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Required. The namespace the GKE service is running in.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Optional. The relative path on the GKE service the events should be sent to. The value must conform to the definition of a URI path segment (section 3.3 of RFC2396). Examples: "/route", "route", "route/subroute".</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Required. Name of the GKE service.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>An HTTP endpoint destination described by an URI. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderDestinationHttpEndpoint
{
    /// <summary>Required. The URI of the HTTP enpdoint. The value must be a RFC2396 URI string. Examples: http://10.10.10.8:80/route, http://svc.us-central1.p.local:8080/. Only HTTP and HTTPS protocols are supported. The host can be either a static IP addressable from the VPC specified by the network config, or an internal DNS hostname of the service resolvable via Cloud DNS.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Optional. Network config is used to configure how Eventarc resolves and connect to a destination. This should only be used with HttpEndpoint destination type. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderDestinationNetworkConfig
{
    /// <summary>Required. Name of the NetworkAttachment that allows access to the destination VPC. Format: projects/{PROJECT_ID}/regions/{REGION}/networkAttachments/{NETWORK_ATTACHMENT_NAME}</summary>
    [JsonPropertyName("networkAttachment")]
    public string? NetworkAttachment { get; set; }
}

/// <summary>Required. Destination specifies where the events should be sent to. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderDestination
{
    /// <summary>Cloud Run fully-managed service that receives the events. The service should be running in the same project of the trigger. Structure is documented below.</summary>
    [JsonPropertyName("cloudRunService")]
    public V1beta1TriggerSpecForProviderDestinationCloudRunService? CloudRunService { get; set; }

    /// <summary>A GKE service capable of receiving events. The service should be running in the same project as the trigger. Structure is documented below.</summary>
    [JsonPropertyName("gke")]
    public V1beta1TriggerSpecForProviderDestinationGke? Gke { get; set; }

    /// <summary>An HTTP endpoint destination described by an URI. Structure is documented below.</summary>
    [JsonPropertyName("httpEndpoint")]
    public V1beta1TriggerSpecForProviderDestinationHttpEndpoint? HttpEndpoint { get; set; }

    /// <summary>Optional. Network config is used to configure how Eventarc resolves and connect to a destination. This should only be used with HttpEndpoint destination type. Structure is documented below.</summary>
    [JsonPropertyName("networkConfig")]
    public V1beta1TriggerSpecForProviderDestinationNetworkConfig? NetworkConfig { get; set; }

    /// <summary>The resource name of the Workflow whose Executions are triggered by the events. The Workflow resource should be deployed in the same project as the trigger. Format: projects/{project}/locations/{location}/workflows/{workflow}</summary>
    [JsonPropertyName("workflow")]
    public string? Workflow { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderMatchingCriteria
{
    /// <summary>Required. The name of a CloudEvents attribute. Currently, only a subset of attributes are supported for filtering. All triggers MUST provide a filter for the 'type' attribute.</summary>
    [JsonPropertyName("attribute")]
    public string? Attribute { get; set; }

    /// <summary>Optional. The operator used for matching the events with the value of the filter. If not specified, only events that have an exact key-value pair specified in the filter are matched. The only allowed value is match-path-pattern.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Required. The value for the attribute. See https://cloud.google.com/eventarc/docs/creating-triggers#trigger-gcloud for available values.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderTransportPubsubTopicRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Topic in pubsub to populate topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderTransportPubsubTopicRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecForProviderTransportPubsubTopicRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderTransportPubsubTopicSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Topic in pubsub to populate topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderTransportPubsubTopicSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecForProviderTransportPubsubTopicSelectorPolicy? Policy { get; set; }
}

/// <summary>The Pub/Sub topic and subscription used by Eventarc as delivery intermediary. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderTransportPubsub
{
    /// <summary>Optional. The name of the Pub/Sub topic created and managed by Eventarc system as a transport for the event delivery. Format: projects/{PROJECT_ID}/topics/{TOPIC_NAME}. You may set an existing topic for triggers of the type google.cloud.pubsub.topic.v1.messagePublished only. The topic you provide here will not be deleted by Eventarc at trigger deletion.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }

    /// <summary>Reference to a Topic in pubsub to populate topic.</summary>
    [JsonPropertyName("topicRef")]
    public V1beta1TriggerSpecForProviderTransportPubsubTopicRef? TopicRef { get; set; }

    /// <summary>Selector for a Topic in pubsub to populate topic.</summary>
    [JsonPropertyName("topicSelector")]
    public V1beta1TriggerSpecForProviderTransportPubsubTopicSelector? TopicSelector { get; set; }
}

/// <summary>Optional. In order to deliver messages, Eventarc may use other GCP products as transport intermediary. This field contains a reference to that transport intermediary. This information can be used for debugging purposes. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProviderTransport
{
    /// <summary>The Pub/Sub topic and subscription used by Eventarc as delivery intermediary. Structure is documented below.</summary>
    [JsonPropertyName("pubsub")]
    public V1beta1TriggerSpecForProviderTransportPubsub? Pubsub { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecForProvider
{
    /// <summary>Optional. The name of the channel associated with the trigger in projects/{project}/locations/{location}/channels/{channel} format. You must provide a channel to receive events from Eventarc SaaS partners.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Required. Destination specifies where the events should be sent to. Structure is documented below.</summary>
    [JsonPropertyName("destination")]
    public V1beta1TriggerSpecForProviderDestination? Destination { get; set; }

    /// <summary>Optional. EventDataContentType specifies the type of payload in MIME format that is expected from the CloudEvent data field. This is set to application/json if the value is not defined.</summary>
    [JsonPropertyName("eventDataContentType")]
    public string? EventDataContentType { get; set; }

    /// <summary>Optional. User labels attached to the triggers that can be used to group resources. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Required. null The list of filters that applies to event attributes. Only events that match all the provided filters will be sent to the destination. Structure is documented below.</summary>
    [JsonPropertyName("matchingCriteria")]
    public IList<V1beta1TriggerSpecForProviderMatchingCriteria>? MatchingCriteria { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Optional. The IAM service account email associated with the trigger. The service account represents the identity of the trigger. The principal who calls this API must have iam.serviceAccounts.actAs permission in the service account. See https://cloud.google.com/iam/docs/understanding-service-accounts#sa_common for more information. For Cloud Run destinations, this service account is used to generate identity tokens when invoking the service. See https://cloud.google.com/run/docs/triggering/pubsub-push#create-service-account for information on how to invoke authenticated Cloud Run services. In order to create Audit Log triggers, the service account should also have roles/eventarc.eventReceiver IAM role.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Optional. In order to deliver messages, Eventarc may use other GCP products as transport intermediary. This field contains a reference to that transport intermediary. This information can be used for debugging purposes. Structure is documented below.</summary>
    [JsonPropertyName("transport")]
    public V1beta1TriggerSpecForProviderTransport? Transport { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderDestinationCloudRunServiceServiceRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Service in cloudrun to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderDestinationCloudRunServiceServiceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecInitProviderDestinationCloudRunServiceServiceRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderDestinationCloudRunServiceServiceSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Service in cloudrun to populate service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderDestinationCloudRunServiceServiceSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecInitProviderDestinationCloudRunServiceServiceSelectorPolicy? Policy { get; set; }
}

/// <summary>Cloud Run fully-managed service that receives the events. The service should be running in the same project of the trigger. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderDestinationCloudRunService
{
    /// <summary>Optional. The relative path on the GKE service the events should be sent to. The value must conform to the definition of a URI path segment (section 3.3 of RFC2396). Examples: "/route", "route", "route/subroute".</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Required. The region the Cloud Run service is deployed in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Required. Name of the GKE service.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>Reference to a Service in cloudrun to populate service.</summary>
    [JsonPropertyName("serviceRef")]
    public V1beta1TriggerSpecInitProviderDestinationCloudRunServiceServiceRef? ServiceRef { get; set; }

    /// <summary>Selector for a Service in cloudrun to populate service.</summary>
    [JsonPropertyName("serviceSelector")]
    public V1beta1TriggerSpecInitProviderDestinationCloudRunServiceServiceSelector? ServiceSelector { get; set; }
}

/// <summary>A GKE service capable of receiving events. The service should be running in the same project as the trigger. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderDestinationGke
{
    /// <summary>Required. The name of the cluster the GKE service is running in. The cluster must be running in the same project as the trigger being created.</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>Required. The namespace the GKE service is running in.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Optional. The relative path on the GKE service the events should be sent to. The value must conform to the definition of a URI path segment (section 3.3 of RFC2396). Examples: "/route", "route", "route/subroute".</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Required. Name of the GKE service.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>An HTTP endpoint destination described by an URI. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderDestinationHttpEndpoint
{
    /// <summary>Required. The URI of the HTTP enpdoint. The value must be a RFC2396 URI string. Examples: http://10.10.10.8:80/route, http://svc.us-central1.p.local:8080/. Only HTTP and HTTPS protocols are supported. The host can be either a static IP addressable from the VPC specified by the network config, or an internal DNS hostname of the service resolvable via Cloud DNS.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Optional. Network config is used to configure how Eventarc resolves and connect to a destination. This should only be used with HttpEndpoint destination type. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderDestinationNetworkConfig
{
    /// <summary>Required. Name of the NetworkAttachment that allows access to the destination VPC. Format: projects/{PROJECT_ID}/regions/{REGION}/networkAttachments/{NETWORK_ATTACHMENT_NAME}</summary>
    [JsonPropertyName("networkAttachment")]
    public string? NetworkAttachment { get; set; }
}

/// <summary>Required. Destination specifies where the events should be sent to. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderDestination
{
    /// <summary>Cloud Run fully-managed service that receives the events. The service should be running in the same project of the trigger. Structure is documented below.</summary>
    [JsonPropertyName("cloudRunService")]
    public V1beta1TriggerSpecInitProviderDestinationCloudRunService? CloudRunService { get; set; }

    /// <summary>A GKE service capable of receiving events. The service should be running in the same project as the trigger. Structure is documented below.</summary>
    [JsonPropertyName("gke")]
    public V1beta1TriggerSpecInitProviderDestinationGke? Gke { get; set; }

    /// <summary>An HTTP endpoint destination described by an URI. Structure is documented below.</summary>
    [JsonPropertyName("httpEndpoint")]
    public V1beta1TriggerSpecInitProviderDestinationHttpEndpoint? HttpEndpoint { get; set; }

    /// <summary>Optional. Network config is used to configure how Eventarc resolves and connect to a destination. This should only be used with HttpEndpoint destination type. Structure is documented below.</summary>
    [JsonPropertyName("networkConfig")]
    public V1beta1TriggerSpecInitProviderDestinationNetworkConfig? NetworkConfig { get; set; }

    /// <summary>The resource name of the Workflow whose Executions are triggered by the events. The Workflow resource should be deployed in the same project as the trigger. Format: projects/{project}/locations/{location}/workflows/{workflow}</summary>
    [JsonPropertyName("workflow")]
    public string? Workflow { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderMatchingCriteria
{
    /// <summary>Required. The name of a CloudEvents attribute. Currently, only a subset of attributes are supported for filtering. All triggers MUST provide a filter for the 'type' attribute.</summary>
    [JsonPropertyName("attribute")]
    public string? Attribute { get; set; }

    /// <summary>Optional. The operator used for matching the events with the value of the filter. If not specified, only events that have an exact key-value pair specified in the filter are matched. The only allowed value is match-path-pattern.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Required. The value for the attribute. See https://cloud.google.com/eventarc/docs/creating-triggers#trigger-gcloud for available values.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderTransportPubsubTopicRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Topic in pubsub to populate topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderTransportPubsubTopicRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecInitProviderTransportPubsubTopicRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderTransportPubsubTopicSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Topic in pubsub to populate topic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderTransportPubsubTopicSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TriggerSpecInitProviderTransportPubsubTopicSelectorPolicy? Policy { get; set; }
}

/// <summary>The Pub/Sub topic and subscription used by Eventarc as delivery intermediary. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderTransportPubsub
{
    /// <summary>Optional. The name of the Pub/Sub topic created and managed by Eventarc system as a transport for the event delivery. Format: projects/{PROJECT_ID}/topics/{TOPIC_NAME}. You may set an existing topic for triggers of the type google.cloud.pubsub.topic.v1.messagePublished only. The topic you provide here will not be deleted by Eventarc at trigger deletion.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }

    /// <summary>Reference to a Topic in pubsub to populate topic.</summary>
    [JsonPropertyName("topicRef")]
    public V1beta1TriggerSpecInitProviderTransportPubsubTopicRef? TopicRef { get; set; }

    /// <summary>Selector for a Topic in pubsub to populate topic.</summary>
    [JsonPropertyName("topicSelector")]
    public V1beta1TriggerSpecInitProviderTransportPubsubTopicSelector? TopicSelector { get; set; }
}

/// <summary>Optional. In order to deliver messages, Eventarc may use other GCP products as transport intermediary. This field contains a reference to that transport intermediary. This information can be used for debugging purposes. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProviderTransport
{
    /// <summary>The Pub/Sub topic and subscription used by Eventarc as delivery intermediary. Structure is documented below.</summary>
    [JsonPropertyName("pubsub")]
    public V1beta1TriggerSpecInitProviderTransportPubsub? Pubsub { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecInitProvider
{
    /// <summary>Optional. The name of the channel associated with the trigger in projects/{project}/locations/{location}/channels/{channel} format. You must provide a channel to receive events from Eventarc SaaS partners.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Required. Destination specifies where the events should be sent to. Structure is documented below.</summary>
    [JsonPropertyName("destination")]
    public V1beta1TriggerSpecInitProviderDestination? Destination { get; set; }

    /// <summary>Optional. EventDataContentType specifies the type of payload in MIME format that is expected from the CloudEvent data field. This is set to application/json if the value is not defined.</summary>
    [JsonPropertyName("eventDataContentType")]
    public string? EventDataContentType { get; set; }

    /// <summary>Optional. User labels attached to the triggers that can be used to group resources. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Required. null The list of filters that applies to event attributes. Only events that match all the provided filters will be sent to the destination. Structure is documented below.</summary>
    [JsonPropertyName("matchingCriteria")]
    public IList<V1beta1TriggerSpecInitProviderMatchingCriteria>? MatchingCriteria { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Optional. The IAM service account email associated with the trigger. The service account represents the identity of the trigger. The principal who calls this API must have iam.serviceAccounts.actAs permission in the service account. See https://cloud.google.com/iam/docs/understanding-service-accounts#sa_common for more information. For Cloud Run destinations, this service account is used to generate identity tokens when invoking the service. See https://cloud.google.com/run/docs/triggering/pubsub-push#create-service-account for information on how to invoke authenticated Cloud Run services. In order to create Audit Log triggers, the service account should also have roles/eventarc.eventReceiver IAM role.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Optional. In order to deliver messages, Eventarc may use other GCP products as transport intermediary. This field contains a reference to that transport intermediary. This information can be used for debugging purposes. Structure is documented below.</summary>
    [JsonPropertyName("transport")]
    public V1beta1TriggerSpecInitProviderTransport? Transport { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>TriggerSpec defines the desired state of Trigger</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1TriggerSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1TriggerSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TriggerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TriggerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Cloud Run fully-managed service that receives the events. The service should be running in the same project of the trigger. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderDestinationCloudRunService
{
    /// <summary>Optional. The relative path on the GKE service the events should be sent to. The value must conform to the definition of a URI path segment (section 3.3 of RFC2396). Examples: "/route", "route", "route/subroute".</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Required. The region the Cloud Run service is deployed in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Required. Name of the GKE service.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>A GKE service capable of receiving events. The service should be running in the same project as the trigger. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderDestinationGke
{
    /// <summary>Required. The name of the cluster the GKE service is running in. The cluster must be running in the same project as the trigger being created.</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Required. The namespace the GKE service is running in.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Optional. The relative path on the GKE service the events should be sent to. The value must conform to the definition of a URI path segment (section 3.3 of RFC2396). Examples: "/route", "route", "route/subroute".</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Required. Name of the GKE service.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>An HTTP endpoint destination described by an URI. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderDestinationHttpEndpoint
{
    /// <summary>Required. The URI of the HTTP enpdoint. The value must be a RFC2396 URI string. Examples: http://10.10.10.8:80/route, http://svc.us-central1.p.local:8080/. Only HTTP and HTTPS protocols are supported. The host can be either a static IP addressable from the VPC specified by the network config, or an internal DNS hostname of the service resolvable via Cloud DNS.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Optional. Network config is used to configure how Eventarc resolves and connect to a destination. This should only be used with HttpEndpoint destination type. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderDestinationNetworkConfig
{
    /// <summary>Required. Name of the NetworkAttachment that allows access to the destination VPC. Format: projects/{PROJECT_ID}/regions/{REGION}/networkAttachments/{NETWORK_ATTACHMENT_NAME}</summary>
    [JsonPropertyName("networkAttachment")]
    public string? NetworkAttachment { get; set; }
}

/// <summary>Required. Destination specifies where the events should be sent to. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderDestination
{
    /// <summary>(Output) The Cloud Function resource name. Only Cloud Functions V2 is supported. Format projects/{project}/locations/{location}/functions/{function} This is a read-only field. [WARNING] Creating Cloud Functions V2 triggers is only supported via the Cloud Functions product. An error will be returned if the user sets this value.</summary>
    [JsonPropertyName("cloudFunction")]
    public string? CloudFunction { get; set; }

    /// <summary>Cloud Run fully-managed service that receives the events. The service should be running in the same project of the trigger. Structure is documented below.</summary>
    [JsonPropertyName("cloudRunService")]
    public V1beta1TriggerStatusAtProviderDestinationCloudRunService? CloudRunService { get; set; }

    /// <summary>A GKE service capable of receiving events. The service should be running in the same project as the trigger. Structure is documented below.</summary>
    [JsonPropertyName("gke")]
    public V1beta1TriggerStatusAtProviderDestinationGke? Gke { get; set; }

    /// <summary>An HTTP endpoint destination described by an URI. Structure is documented below.</summary>
    [JsonPropertyName("httpEndpoint")]
    public V1beta1TriggerStatusAtProviderDestinationHttpEndpoint? HttpEndpoint { get; set; }

    /// <summary>Optional. Network config is used to configure how Eventarc resolves and connect to a destination. This should only be used with HttpEndpoint destination type. Structure is documented below.</summary>
    [JsonPropertyName("networkConfig")]
    public V1beta1TriggerStatusAtProviderDestinationNetworkConfig? NetworkConfig { get; set; }

    /// <summary>The resource name of the Workflow whose Executions are triggered by the events. The Workflow resource should be deployed in the same project as the trigger. Format: projects/{project}/locations/{location}/workflows/{workflow}</summary>
    [JsonPropertyName("workflow")]
    public string? Workflow { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderMatchingCriteria
{
    /// <summary>Required. The name of a CloudEvents attribute. Currently, only a subset of attributes are supported for filtering. All triggers MUST provide a filter for the 'type' attribute.</summary>
    [JsonPropertyName("attribute")]
    public string? Attribute { get; set; }

    /// <summary>Optional. The operator used for matching the events with the value of the filter. If not specified, only events that have an exact key-value pair specified in the filter are matched. The only allowed value is match-path-pattern.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Required. The value for the attribute. See https://cloud.google.com/eventarc/docs/creating-triggers#trigger-gcloud for available values.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The Pub/Sub topic and subscription used by Eventarc as delivery intermediary. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderTransportPubsub
{
    /// <summary>(Output) Output only. The name of the Pub/Sub subscription created and managed by Eventarc system as a transport for the event delivery. Format: projects/{PROJECT_ID}/subscriptions/{SUBSCRIPTION_NAME}.</summary>
    [JsonPropertyName("subscription")]
    public string? Subscription { get; set; }

    /// <summary>Optional. The name of the Pub/Sub topic created and managed by Eventarc system as a transport for the event delivery. Format: projects/{PROJECT_ID}/topics/{TOPIC_NAME}. You may set an existing topic for triggers of the type google.cloud.pubsub.topic.v1.messagePublished only. The topic you provide here will not be deleted by Eventarc at trigger deletion.</summary>
    [JsonPropertyName("topic")]
    public string? Topic { get; set; }
}

/// <summary>Optional. In order to deliver messages, Eventarc may use other GCP products as transport intermediary. This field contains a reference to that transport intermediary. This information can be used for debugging purposes. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProviderTransport
{
    /// <summary>The Pub/Sub topic and subscription used by Eventarc as delivery intermediary. Structure is documented below.</summary>
    [JsonPropertyName("pubsub")]
    public V1beta1TriggerStatusAtProviderTransportPubsub? Pubsub { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusAtProvider
{
    /// <summary>Optional. The name of the channel associated with the trigger in projects/{project}/locations/{location}/channels/{channel} format. You must provide a channel to receive events from Eventarc SaaS partners.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>Output only. The reason(s) why a trigger is in FAILED state.</summary>
    [JsonPropertyName("conditions")]
    public IDictionary<string, string>? Conditions { get; set; }

    /// <summary>Output only. The creation time.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Required. Destination specifies where the events should be sent to. Structure is documented below.</summary>
    [JsonPropertyName("destination")]
    public V1beta1TriggerStatusAtProviderDestination? Destination { get; set; }

    /// <summary></summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>Output only. This checksum is computed by the server based on the value of other fields, and may be sent only on create requests to ensure the client has an up-to-date value before proceeding.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Optional. EventDataContentType specifies the type of payload in MIME format that is expected from the CloudEvent data field. This is set to application/json if the value is not defined.</summary>
    [JsonPropertyName("eventDataContentType")]
    public string? EventDataContentType { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/triggers/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Optional. User labels attached to the triggers that can be used to group resources. Note: This field is non-authoritative, and will only manage the labels present in your configuration. Please refer to the field effective_labels for all of the labels present on the resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Required. null The list of filters that applies to event attributes. Only events that match all the provided filters will be sent to the destination. Structure is documented below.</summary>
    [JsonPropertyName("matchingCriteria")]
    public IList<V1beta1TriggerStatusAtProviderMatchingCriteria>? MatchingCriteria { get; set; }

    /// <summary>The ID of the project in which the resource belongs. If it is not provided, the provider project is used.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Optional. The IAM service account email associated with the trigger. The service account represents the identity of the trigger. The principal who calls this API must have iam.serviceAccounts.actAs permission in the service account. See https://cloud.google.com/iam/docs/understanding-service-accounts#sa_common for more information. For Cloud Run destinations, this service account is used to generate identity tokens when invoking the service. See https://cloud.google.com/run/docs/triggering/pubsub-push#create-service-account for information on how to invoke authenticated Cloud Run services. In order to create Audit Log triggers, the service account should also have roles/eventarc.eventReceiver IAM role.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>Optional. In order to deliver messages, Eventarc may use other GCP products as transport intermediary. This field contains a reference to that transport intermediary. This information can be used for debugging purposes. Structure is documented below.</summary>
    [JsonPropertyName("transport")]
    public V1beta1TriggerStatusAtProviderTransport? Transport { get; set; }

    /// <summary>Output only. Server assigned unique identifier for the trigger. The value is a UUID4 string and guaranteed to remain unchanged until the resource is deleted.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The last-modified time.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatusConditions
{
    /// <summary>LastTransitionTime is the last time this condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string LastTransitionTime { get; set; }

    /// <summary>A Message containing details about this condition's last transition from one status to another, if any.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>ObservedGeneration represents the .metadata.generation that the condition was set based upon. For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date with respect to the current state of the instance.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition's last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>Type of this condition. At most one of each condition type may apply to a resource at any point in time.</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}

/// <summary>TriggerStatus defines the observed state of Trigger.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TriggerStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1TriggerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TriggerStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Trigger is the Schema for the Triggers API. The Eventarc Trigger resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Trigger : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TriggerSpec>, IStatus<V1beta1TriggerStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Trigger";
    public const string KubeGroup = "eventarc.gcp.m.upbound.io";
    public const string KubePluralName = "triggers";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TriggerSpec defines the desired state of Trigger</summary>
    [JsonPropertyName("spec")]
    public V1beta1TriggerSpec Spec { get; set; }

    /// <summary>TriggerStatus defines the observed state of Trigger.</summary>
    [JsonPropertyName("status")]
    public V1beta1TriggerStatus? Status { get; set; }
}