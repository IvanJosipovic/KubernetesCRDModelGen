using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.eventarc.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EventarcTriggerList : IKubernetesObject<V1ListMeta>, IItems<V1beta1EventarcTrigger>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EventarcTriggerList";
    public const string KubeGroup = "eventarc.cnrm.cloud.google.com";
    public const string KubePluralName = "eventarctriggers";
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
    public IList<V1beta1EventarcTrigger> Items { get; set; }
}

/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventarcTriggerSpecChannelRef
{
    /// <summary>Optional. The name of the channel associated with the trigger in `projects/{project}/locations/{location}/channels/{channel}` format. You must provide a channel to receive events from Eventarc SaaS partners.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>[WARNING] EventarcChannel not yet supported in Config Connector, use 'external' field to reference existing resources. Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventarcTriggerSpecDestinationCloudFunctionRef
{
    /// <summary>[WARNING] Configuring a Cloud Function in Trigger is not supported as of today. The Cloud Function resource name. Format: projects/{project}/locations/{location}/functions/{function}  Allowed value: The Google Cloud resource name of a `CloudFunctionsFunction` resource (format: `projects/{{project}}/locations/{{region}}/functions/{{name}}`).</summary>
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
public partial class V1beta1EventarcTriggerSpecDestinationCloudRunServiceServiceRef
{
    /// <summary>Required. The name of the Cloud Run service being addressed. See https://cloud.google.com/run/docs/reference/rest/v1/namespaces.services. Only services located in the same project of the trigger object can be addressed.  Allowed value: The Google Cloud resource name of a `RunService` resource (format: `projects/{{project}}/locations/{{location}}/services/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Cloud Run fully-managed service that receives the events. The service should be running in the same project of the trigger.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventarcTriggerSpecDestinationCloudRunService
{
    /// <summary>Optional. The relative path on the Cloud Run service the events should be sent to. The value must conform to the definition of URI path segment (section 3.3 of RFC2396). Examples: "/route", "route", "route/subroute".</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Required. The region the Cloud Run service is deployed in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceRef")]
    public V1beta1EventarcTriggerSpecDestinationCloudRunServiceServiceRef ServiceRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventarcTriggerSpecDestinationGkeClusterRef
{
    /// <summary>Required. The name of the cluster the GKE service is running in. The cluster must be running in the same project as the trigger being created.  Allowed value: The `selfLink` field of a `ContainerCluster` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>A GKE service capable of receiving events. The service should be running in the same project as the trigger.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventarcTriggerSpecDestinationGke
{
    /// <summary></summary>
    [JsonPropertyName("clusterRef")]
    public V1beta1EventarcTriggerSpecDestinationGkeClusterRef ClusterRef { get; set; }

    /// <summary>Required. The name of the Google Compute Engine in which the cluster resides, which can either be compute zone (for example, us-central1-a) for the zonal clusters or region (for example, us-central1) for regional clusters.</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Required. The namespace the GKE service is running in.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }

    /// <summary>Optional. The relative path on the GKE service the events should be sent to. The value must conform to the definition of a URI path segment (section 3.3 of RFC2396). Examples: "/route", "route", "route/subroute".</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Required. Name of the GKE service.</summary>
    [JsonPropertyName("service")]
    public string Service { get; set; }
}

/// <summary>An HTTP endpoint destination described by an URI.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventarcTriggerSpecDestinationHttpEndpoint
{
    /// <summary>Required. The URI of the HTTP enpdoint. The value must be a RFC2396 URI string. Examples: `http://10.10.10.8:80/route`, `http://svc.us-central1.p.local:8080/`. Only HTTP and HTTPS protocols are supported. The host can be either a static IP addressable from the VPC specified by the network config, or an internal DNS hostname of the service resolvable via Cloud DNS.</summary>
    [JsonPropertyName("uri")]
    public string Uri { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventarcTriggerSpecDestinationNetworkConfigNetworkAttachmentRef
{
    /// <summary>Required. Name of the NetworkAttachment that allows access to the destination VPC. Format: `projects/{PROJECT_ID}/regions/{REGION}/networkAttachments/{NETWORK_ATTACHMENT_NAME}`</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>[WARNING] ComputeNetworkAttachment not yet supported in Config Connector, use 'external' field to reference existing resources. Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Network config is used to configure how Eventarc resolves and connect to a destination. This should only be used with HttpEndpoint destination type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventarcTriggerSpecDestinationNetworkConfig
{
    /// <summary></summary>
    [JsonPropertyName("networkAttachmentRef")]
    public V1beta1EventarcTriggerSpecDestinationNetworkConfigNetworkAttachmentRef NetworkAttachmentRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventarcTriggerSpecDestinationWorkflowRef
{
    /// <summary>The resource name of the Workflow whose Executions are triggered by the events. The Workflow resource should be deployed in the same project as the trigger. Format: `projects/{project}/locations/{location}/workflows/{workflow}`</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>[WARNING] WorkflowsWorkflow not yet supported in Config Connector, use 'external' field to reference existing resources. Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. Destination specifies where the events should be sent to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventarcTriggerSpecDestination
{
    /// <summary></summary>
    [JsonPropertyName("cloudFunctionRef")]
    public V1beta1EventarcTriggerSpecDestinationCloudFunctionRef? CloudFunctionRef { get; set; }

    /// <summary>Cloud Run fully-managed service that receives the events. The service should be running in the same project of the trigger.</summary>
    [JsonPropertyName("cloudRunService")]
    public V1beta1EventarcTriggerSpecDestinationCloudRunService? CloudRunService { get; set; }

    /// <summary>A GKE service capable of receiving events. The service should be running in the same project as the trigger.</summary>
    [JsonPropertyName("gke")]
    public V1beta1EventarcTriggerSpecDestinationGke? Gke { get; set; }

    /// <summary>An HTTP endpoint destination described by an URI.</summary>
    [JsonPropertyName("httpEndpoint")]
    public V1beta1EventarcTriggerSpecDestinationHttpEndpoint? HttpEndpoint { get; set; }

    /// <summary>Optional. Network config is used to configure how Eventarc resolves and connect to a destination. This should only be used with HttpEndpoint destination type.</summary>
    [JsonPropertyName("networkConfig")]
    public V1beta1EventarcTriggerSpecDestinationNetworkConfig? NetworkConfig { get; set; }

    /// <summary></summary>
    [JsonPropertyName("workflowRef")]
    public V1beta1EventarcTriggerSpecDestinationWorkflowRef? WorkflowRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventarcTriggerSpecMatchingCriteria
{
    /// <summary>Required. The name of a CloudEvents attribute. Currently, only a subset of attributes are supported for filtering. All triggers MUST provide a filter for the 'type' attribute.</summary>
    [JsonPropertyName("attribute")]
    public string Attribute { get; set; }

    /// <summary>Optional. The operator used for matching the events with the value of the filter. If not specified, only events that have an exact key-value pair specified in the filter are matched. The only allowed value is `match-path-pattern`.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Required. The value for the attribute. See https://cloud.google.com/eventarc/docs/creating-triggers#trigger-gcloud for available values.</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventarcTriggerSpecProjectRef
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventarcTriggerSpecServiceAccountRef
{
    /// <summary>Optional. The IAM service account email associated with the trigger. The service account represents the identity of the trigger. The principal who calls this API must have `iam.serviceAccounts.actAs` permission in the service account. See https://cloud.google.com/iam/docs/understanding-service-accounts#sa_common for more information. For Cloud Run destinations, this service account is used to generate identity tokens when invoking the service. See https://cloud.google.com/run/docs/triggering/pubsub-push#create-service-account for information on how to invoke authenticated Cloud Run services. In order to create Audit Log triggers, the service account should also have `roles/eventarc.eventReceiver` IAM role.  Allowed value: The `email` field of an `IAMServiceAccount` resource.</summary>
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
public partial class V1beta1EventarcTriggerSpecTransportPubsubTopicRef
{
    /// <summary>Optional. The name of the Pub/Sub topic created and managed by Eventarc system as a transport for the event delivery. Format: `projects/{PROJECT_ID}/topics/{TOPIC_NAME}. You may set an existing topic for triggers of the type google.cloud.pubsub.topic.v1.messagePublished` only. The topic you provide here will not be deleted by Eventarc at trigger deletion.  Allowed value: The Google Cloud resource name of a `PubSubTopic` resource (format: `projects/{{project}}/topics/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. The Pub/Sub topic and subscription used by Eventarc as delivery intermediary.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventarcTriggerSpecTransportPubsub
{
    /// <summary>Immutable.</summary>
    [JsonPropertyName("topicRef")]
    public V1beta1EventarcTriggerSpecTransportPubsubTopicRef? TopicRef { get; set; }
}

/// <summary>Immutable. Optional. In order to deliver messages, Eventarc may use other GCP products as transport intermediary. This field contains a reference to that transport intermediary. This information can be used for debugging purposes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventarcTriggerSpecTransport
{
    /// <summary>Immutable. The Pub/Sub topic and subscription used by Eventarc as delivery intermediary.</summary>
    [JsonPropertyName("pubsub")]
    public V1beta1EventarcTriggerSpecTransportPubsub? Pubsub { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventarcTriggerSpec
{
    /// <summary>Immutable.</summary>
    [JsonPropertyName("channelRef")]
    public V1beta1EventarcTriggerSpecChannelRef? ChannelRef { get; set; }

    /// <summary>Required. Destination specifies where the events should be sent to.</summary>
    [JsonPropertyName("destination")]
    public V1beta1EventarcTriggerSpecDestination Destination { get; set; }

    /// <summary>Optional. EventDataContentType specifies the type of payload in MIME format that is expected from the CloudEvent data field. This is set to `application/json` if the value is not defined.</summary>
    [JsonPropertyName("eventDataContentType")]
    public string? EventDataContentType { get; set; }

    /// <summary>Immutable. The location for the resource</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>Required. null The list of filters that applies to event attributes. Only events that match all the provided filters will be sent to the destination.</summary>
    [JsonPropertyName("matchingCriteria")]
    public IList<V1beta1EventarcTriggerSpecMatchingCriteria> MatchingCriteria { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1EventarcTriggerSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary></summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1EventarcTriggerSpecServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Immutable. Optional. In order to deliver messages, Eventarc may use other GCP products as transport intermediary. This field contains a reference to that transport intermediary. This information can be used for debugging purposes.</summary>
    [JsonPropertyName("transport")]
    public V1beta1EventarcTriggerSpecTransport? Transport { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventarcTriggerStatusConditions
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
public partial class V1beta1EventarcTriggerStatusTransportPubsub
{
    /// <summary>Output only. The name of the Pub/Sub subscription created and managed by Eventarc system as a transport for the event delivery. Format: `projects/{PROJECT_ID}/subscriptions/{SUBSCRIPTION_NAME}`.</summary>
    [JsonPropertyName("subscription")]
    public string? Subscription { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventarcTriggerStatusTransport
{
    /// <summary></summary>
    [JsonPropertyName("pubsub")]
    public V1beta1EventarcTriggerStatusTransportPubsub? Pubsub { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EventarcTriggerStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1EventarcTriggerStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. The creation time.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. This checksum is computed by the server based on the value of other fields, and may be sent only on create requests to ensure the client has an up-to-date value before proceeding.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. The reason(s) why a trigger is in FAILED state.</summary>
    [JsonPropertyName("resourceConditions")]
    public IDictionary<string, string>? ResourceConditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("transport")]
    public V1beta1EventarcTriggerStatusTransport? Transport { get; set; }

    /// <summary>Output only. Server assigned unique identifier for the trigger. The value is a UUID4 string and guaranteed to remain unchanged until the resource is deleted.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The last-modified time.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EventarcTrigger : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1EventarcTriggerSpec>, IStatus<V1beta1EventarcTriggerStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EventarcTrigger";
    public const string KubeGroup = "eventarc.cnrm.cloud.google.com";
    public const string KubePluralName = "eventarctriggers";
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
    public V1beta1EventarcTriggerSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1EventarcTriggerStatus? Status { get; set; }
}