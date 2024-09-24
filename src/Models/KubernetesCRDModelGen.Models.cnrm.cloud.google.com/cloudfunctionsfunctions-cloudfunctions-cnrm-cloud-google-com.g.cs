using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudfunctions.cnrm.cloud.google.com;
/// <summary>Immutable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudFunctionsFunctionSpecEventTriggerResourceRef
{
    /// <summary>Required. The resource(s) from which to observe events, for example, `projects/_/buckets/myBucket`.  Not all syntactically correct values are accepted by all services. For example:  1. The authorization model must support it. Google Cloud Functions    only allows EventTriggers to be deployed that observe resources in the    same project as the `Function`. 2. The resource type must match the pattern expected for an    `event_type`. For example, an `EventTrigger` that has an    `event_type` of "google.pubsub.topic.publish" should have a resource    that matches Google Cloud Pub/Sub topics.  Additionally, some services may support short names when creating an `EventTrigger`. These will always be returned in the normalized "long" format.  See each *service's* documentation for supported formats.  Allowed values: * The Google Cloud resource name of a `StorageBucket` resource (format: `{{name}}`). * The Google Cloud resource name of a `PubSubTopic` resource (format: `projects/{{project}}/topics/{{name}}`).</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Kind of the referent. Allowed values: StorageBucket,PubSubTopic</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. A source that fires events in response to a condition in another service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudFunctionsFunctionSpecEventTrigger
{
    /// <summary>Immutable. Required. The type of event to observe. For example: `providers/cloud.storage/eventTypes/object.change` and `providers/cloud.pubsub/eventTypes/topic.publish`.  Event types match pattern `providers/*/eventTypes/*.*`. The pattern contains:  1. namespace: For example, `cloud.storage` and    `google.firebase.analytics`. 2. resource type: The type of resource on which event occurs. For    example, the Google Cloud Storage API includes the type `object`. 3. action: The action that generates the event. For example, action for    a Google Cloud Storage Object is 'change'. These parts are lower case.</summary>
    [JsonPropertyName("eventType")]
    public string EventType { get; set; }

    /// <summary>Immutable. Specifies policy for failed executions.</summary>
    [JsonPropertyName("failurePolicy")]
    public bool? FailurePolicy { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("resourceRef")]
    public V1beta1CloudFunctionsFunctionSpecEventTriggerResourceRef ResourceRef { get; set; }

    /// <summary>Immutable. The hostname of the service that should be observed.  If no string is provided, the default service implementing the API will be used. For example, `storage.googleapis.com` is the default for all event types in the `google.storage` namespace.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }
}

/// <summary>Immutable. An HTTPS endpoint type of source that can be triggered via URL.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudFunctionsFunctionSpecHttpsTrigger
{
    /// <summary>Immutable. Both HTTP and HTTPS requests with URLs that match the handler succeed without redirects. The application can examine the request to determine which protocol was used and respond accordingly. Possible values: SECURITY_LEVEL_UNSPECIFIED, SECURE_ALWAYS, SECURE_OPTIONAL</summary>
    [JsonPropertyName("securityLevel")]
    public string? SecurityLevel { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudFunctionsFunctionSpecProjectRef
{
    /// <summary>The project id of the function.  Allowed value: The Google Cloud resource name of a `Project` resource (format: `projects/{{name}}`).</summary>
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
public partial class V1beta1CloudFunctionsFunctionSpecServiceAccountRef
{
    /// <summary>The email of the function's service account. If empty, defaults to `{project_id}@appspot.gserviceaccount.com`.  Allowed value: The `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. Represents parameters related to source repository where a function is hosted.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudFunctionsFunctionSpecSourceRepository
{
    /// <summary>Immutable. The URL pointing to the hosted repository where the function is defined. There are supported Cloud Source Repository URLs in the following formats:  To refer to a specific commit: `https://source.developers.google.com/projects/*/repos/*/revisions/*/paths/*` To refer to a moveable alias (branch): `https://source.developers.google.com/projects/*/repos/*/moveable-aliases/*/paths/*` In particular, to refer to HEAD use `master` moveable alias. To refer to a specific fixed alias (tag): `https://source.developers.google.com/projects/*/repos/*/fixed-aliases/*/paths/*`  You may omit `paths/*` if you want to use the main directory.</summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudFunctionsFunctionSpecVpcConnectorRef
{
    /// <summary>The VPC Network Connector that this cloud function can connect to. It can be either the fully-qualified URI, or the short name of the network connector resource. The format of this field is `projects/*/locations/*/connectors/*`  Allowed value: The Google Cloud resource name of a `VPCAccessConnector` resource (format: `projects/{{project}}/locations/{{location}}/connectors/{{name}}`).</summary>
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
public partial class V1beta1CloudFunctionsFunctionSpec
{
    /// <summary>Memory (in MB), available to the function. Default value is 256MB. Allowed values are: 128MB, 256MB, 512MB, 1024MB, and 2048MB.</summary>
    [JsonPropertyName("availableMemoryMb")]
    public long? AvailableMemoryMb { get; set; }

    /// <summary>User-provided description of a function.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable. The name of the function (as defined in source code) that will be executed. Defaults to the resource name suffix, if not specified. For backward compatibility, if function with given name is not found, then the system will try to use function named "function". For Node.js this is name of a function exported by the module specified in `source_location`.</summary>
    [JsonPropertyName("entryPoint")]
    public string? EntryPoint { get; set; }

    /// <summary>Environment variables that shall be available during function execution.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>Immutable. A source that fires events in response to a condition in another service.</summary>
    [JsonPropertyName("eventTrigger")]
    public V1beta1CloudFunctionsFunctionSpecEventTrigger? EventTrigger { get; set; }

    /// <summary>Immutable. An HTTPS endpoint type of source that can be triggered via URL.</summary>
    [JsonPropertyName("httpsTrigger")]
    public V1beta1CloudFunctionsFunctionSpecHttpsTrigger? HttpsTrigger { get; set; }

    /// <summary>The ingress settings for the function, controlling what traffic can reach it. Possible values: INGRESS_SETTINGS_UNSPECIFIED, ALLOW_ALL, ALLOW_INTERNAL_ONLY, ALLOW_INTERNAL_AND_GCLB</summary>
    [JsonPropertyName("ingressSettings")]
    public string? IngressSettings { get; set; }

    /// <summary>The limit on the maximum number of function instances that may coexist at a given time.</summary>
    [JsonPropertyName("maxInstances")]
    public long? MaxInstances { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1CloudFunctionsFunctionSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. The name of the Cloud Functions region of the function.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The runtime in which to run the function. Required when deploying a new function, optional when updating an existing function. For a complete list of possible choices, see the [`gcloud` command reference](/sdk/gcloud/reference/functions/deploy#--runtime). </summary>
    [JsonPropertyName("runtime")]
    public string Runtime { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1CloudFunctionsFunctionSpecServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Immutable. The Google Cloud Storage URL, starting with gs://, pointing to the zip archive which contains the function.</summary>
    [JsonPropertyName("sourceArchiveUrl")]
    public string? SourceArchiveUrl { get; set; }

    /// <summary>Immutable. Represents parameters related to source repository where a function is hosted.</summary>
    [JsonPropertyName("sourceRepository")]
    public V1beta1CloudFunctionsFunctionSpecSourceRepository? SourceRepository { get; set; }

    /// <summary>The function execution timeout. Execution is considered failed and can be terminated if the function is not completed at the end of the timeout period. Defaults to 60 seconds.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>The egress settings for the connector, controlling what traffic is diverted through it. Possible values: VPC_CONNECTOR_EGRESS_SETTINGS_UNSPECIFIED, PRIVATE_RANGES_ONLY, ALL_TRAFFIC</summary>
    [JsonPropertyName("vpcConnectorEgressSettings")]
    public string? VpcConnectorEgressSettings { get; set; }

    /// <summary></summary>
    [JsonPropertyName("vpcConnectorRef")]
    public V1beta1CloudFunctionsFunctionSpecVpcConnectorRef? VpcConnectorRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudFunctionsFunctionStatusConditions
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
public partial class V1beta1CloudFunctionsFunctionStatusHttpsTrigger
{
    /// <summary>Output only. The deployed url for the function.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudFunctionsFunctionStatusSourceRepository
{
    /// <summary>Output only. The URL pointing to the hosted repository where the function were defined at the time of deployment. It always points to a specific commit in the format described above.</summary>
    [JsonPropertyName("deployedUrl")]
    public string? DeployedUrl { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CloudFunctionsFunctionStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CloudFunctionsFunctionStatusConditions>? Conditions { get; set; }

    /// <summary></summary>
    [JsonPropertyName("httpsTrigger")]
    public V1beta1CloudFunctionsFunctionStatusHttpsTrigger? HttpsTrigger { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sourceRepository")]
    public V1beta1CloudFunctionsFunctionStatusSourceRepository? SourceRepository { get; set; }

    /// <summary>Output only. Status of the function deployment. Possible values: CLOUD_FUNCTION_STATUS_UNSPECIFIED, ACTIVE, OFFLINE, DEPLOY_IN_PROGRESS, DELETE_IN_PROGRESS, UNKNOWN</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Output only. The last update timestamp of a Cloud Function in RFC3339 UTC 'Zulu' format, with nanosecond resolution and up to nine fractional digits.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Output only. The version identifier of the Cloud Function. Each deployment attempt results in a new version of a function being created.</summary>
    [JsonPropertyName("versionId")]
    public long? VersionId { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CloudFunctionsFunction : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CloudFunctionsFunctionSpec>, IStatus<V1beta1CloudFunctionsFunctionStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CloudFunctionsFunction";
    public const string KubeGroup = "cloudfunctions.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudfunctionsfunctions";
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
    public V1beta1CloudFunctionsFunctionSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1beta1CloudFunctionsFunctionStatus? Status { get; set; }
}