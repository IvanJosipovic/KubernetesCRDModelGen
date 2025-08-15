using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sources.knative.dev;
/// <summary>CloudEventOverrides defines overrides to control the output format and modifications of the event sent to the sink.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IntegrationSourceSpecCeOverrides
{
    /// <summary>Extensions specify what attribute are added or overridden on the outbound event. Each `Extensions` key-value pair are set on the event as an attribute extension independently.</summary>
    [JsonPropertyName("extensions")]
    public JsonNode? Extensions { get; set; }
}

/// <summary>Ref points to an Addressable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IntegrationSourceSpecSinkRef
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

/// <summary>Sink is a reference to an object that will resolve to a uri to use as the sink.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IntegrationSourceSpecSink
{
    /// <summary>Ref points to an Addressable.</summary>
    [JsonPropertyName("ref")]
    public V1alpha1IntegrationSourceSpecSinkRef? Ref { get; set; }

    /// <summary>URI can be an absolute URL(non-empty scheme and non-empty host) pointing to the target or a relative URI. Relative URIs will be resolved using the base URI retrieved from Ref.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>CACerts is the Certification Authority (CA) certificates in PEM format that the source trusts when sending events to the sink.</summary>
    [JsonPropertyName("CACerts")]
    public string? CACerts { get; set; }

    /// <summary>Audience is the OIDC audience. This only needs to be set if the target is not an Addressable and thus the Audience can't be received from the target itself. If specified, it takes precedence over the target's Audience.</summary>
    [JsonPropertyName("audience")]
    public string? Audience { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IntegrationSourceSpecTimer
{
    /// <summary>The interval (in milliseconds) to wait between producing the next message.</summary>
    [JsonPropertyName("period")]
    public int? Period { get; set; }

    /// <summary>The message to generate.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The content type of the generated message.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Specifies a maximum limit of number of fires</summary>
    [JsonPropertyName("repeatCount")]
    public int? RepeatCount { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IntegrationSourceSpecAwsS3
{
    /// <summary>The S3 Bucket name or Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Specifies to delete objects after consuming them.</summary>
    [JsonPropertyName("deleteAfterRead")]
    public bool? DeleteAfterRead { get; set; }

    /// <summary>Move objects from S3 bucket to a different bucket after they have been retrieved.</summary>
    [JsonPropertyName("moveAfterRead")]
    public bool? MoveAfterRead { get; set; }

    /// <summary>Define the destination bucket where an object must be moved when moveAfterRead is set to true.</summary>
    [JsonPropertyName("destinationBucket")]
    public string? DestinationBucket { get; set; }

    /// <summary>Define the destination bucket prefix to use when an object must be moved, and moveAfterRead is set to true.</summary>
    [JsonPropertyName("destinationBucketPrefix")]
    public string? DestinationBucketPrefix { get; set; }

    /// <summary>Define the destination bucket suffix to use when an object must be moved, and moveAfterRead is set to true.</summary>
    [JsonPropertyName("destinationBucketSuffix")]
    public string? DestinationBucketSuffix { get; set; }

    /// <summary>The AWS region to access.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Specifies to automatically create the S3 bucket.</summary>
    [JsonPropertyName("autoCreateBucket")]
    public bool? AutoCreateBucket { get; set; }

    /// <summary>The AWS S3 bucket prefix to consider while searching.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>If true, the S3 Object body is ignored. Setting this to true overrides any behavior defined by the `includeBody` option. If false, the S3 object is put in the body.</summary>
    [JsonPropertyName("ignoreBody")]
    public bool? IgnoreBody { get; set; }

    /// <summary>The overriding endpoint URI. To use this option, you must also select the `overrideEndpoint` option.</summary>
    [JsonPropertyName("uriEndpointOverride")]
    public string? UriEndpointOverride { get; set; }

    /// <summary>Select this option to override the endpoint URI. To use this option, you must also provide a URI for the `uriEndpointOverride` option.</summary>
    [JsonPropertyName("overrideEndpoint")]
    public bool? OverrideEndpoint { get; set; }

    /// <summary>Forces path style when accessing AWS S3 buckets.</summary>
    [JsonPropertyName("forcePathStyle")]
    public bool? ForcePathStyle { get; set; }

    /// <summary>The number of milliseconds before the next poll of the selected bucket.</summary>
    [JsonPropertyName("delay")]
    public int? Delay { get; set; }

    /// <summary>Gets the maximum number of messages as a limit to poll at each polling. Gets the maximum number of messages as a limit to poll at each polling. The default value is 10. Use 0 or a negative number to set it as unlimited.</summary>
    [JsonPropertyName("maxMessagesPerPoll")]
    public int? MaxMessagesPerPoll { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IntegrationSourceSpecAwsSqs
{
    /// <summary>The SQS Queue Name or ARN</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Delete messages after consuming them</summary>
    [JsonPropertyName("deleteAfterRead")]
    public bool? DeleteAfterRead { get; set; }

    /// <summary>The AWS region to access.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Setting the autocreation of the SQS queue.</summary>
    [JsonPropertyName("autoCreateQueue")]
    public bool? AutoCreateQueue { get; set; }

    /// <summary>The hostname of the Amazon AWS cloud.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>The underlying protocol used to communicate with SQS</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The full SQS Queue URL (required if using KEDA)</summary>
    [JsonPropertyName("queueURL")]
    public string? QueueURL { get; set; }

    /// <summary>The overriding endpoint URI. To use this option, you must also select the `overrideEndpoint` option.</summary>
    [JsonPropertyName("uriEndpointOverride")]
    public string? UriEndpointOverride { get; set; }

    /// <summary>Select this option to override the endpoint URI. To use this option, you must also provide a URI for the `uriEndpointOverride` option.</summary>
    [JsonPropertyName("overrideEndpoint")]
    public bool? OverrideEndpoint { get; set; }

    /// <summary>The number of milliseconds before the next poll of the selected stream</summary>
    [JsonPropertyName("delay")]
    public int? Delay { get; set; }

    /// <summary>If greedy is enabled, then the polling will happen immediately again, if the previous run polled 1 or more messages.</summary>
    [JsonPropertyName("greedy")]
    public bool? Greedy { get; set; }

    /// <summary>The maximum number of messages to return. Amazon SQS never returns more messages than this value (however, fewer messages might be returned). Valid values 1 to 10. Default 1.</summary>
    [JsonPropertyName("maxMessagesPerPoll")]
    public int? MaxMessagesPerPoll { get; set; }

    /// <summary>The duration (in seconds) for which the call waits for a message to arrive in the queue before returning. If a message is available, the call returns sooner than WaitTimeSeconds. If no messages are available and the wait time expires, the call does not return a message list.</summary>
    [JsonPropertyName("waitTimeSeconds")]
    public int? WaitTimeSeconds { get; set; }

    /// <summary>The duration (in seconds) that the received messages are hidden from subsequent retrieve requests after being retrieved by a ReceiveMessage request.</summary>
    [JsonPropertyName("visibilityTimeout")]
    public int? VisibilityTimeout { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IntegrationSourceSpecAwsDdbStreams
{
    /// <summary>The name of the DynamoDB table.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }

    /// <summary>The AWS region to access.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Defines where in the DynamoDB stream to start getting records. There are two enums and the value can be one of FROM_LATEST and FROM_START. Note that using FROM_START can cause a significant delay before the stream has caught up to real-time.</summary>
    [JsonPropertyName("streamIteratorType")]
    public string? StreamIteratorType { get; set; }

    /// <summary>The overriding endpoint URI. To use this option, you must also select the `overrideEndpoint` option.</summary>
    [JsonPropertyName("uriEndpointOverride")]
    public string? UriEndpointOverride { get; set; }

    /// <summary>Select this option to override the endpoint URI. To use this option, you must also provide a URI for the `uriEndpointOverride` option.</summary>
    [JsonPropertyName("overrideEndpoint")]
    public bool? OverrideEndpoint { get; set; }

    /// <summary>The number of milliseconds before the next poll from the database.</summary>
    [JsonPropertyName("delay")]
    public int? Delay { get; set; }
}

/// <summary>Secret reference. </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IntegrationSourceSpecAwsAuthSecretRef
{
    /// <summary>Secret name</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Auth secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IntegrationSourceSpecAwsAuthSecret
{
    /// <summary>Secret reference. </summary>
    [JsonPropertyName("ref")]
    public V1alpha1IntegrationSourceSpecAwsAuthSecretRef? Ref { get; set; }
}

/// <summary>Auth configurations</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IntegrationSourceSpecAwsAuth
{
    /// <summary>Auth secret</summary>
    [JsonPropertyName("secret")]
    public V1alpha1IntegrationSourceSpecAwsAuthSecret? Secret { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IntegrationSourceSpecAws
{
    /// <summary></summary>
    [JsonPropertyName("s3")]
    public V1alpha1IntegrationSourceSpecAwsS3? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sqs")]
    public V1alpha1IntegrationSourceSpecAwsSqs? Sqs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("ddbStreams")]
    public V1alpha1IntegrationSourceSpecAwsDdbStreams? DdbStreams { get; set; }

    /// <summary>Auth configurations</summary>
    [JsonPropertyName("auth")]
    public V1alpha1IntegrationSourceSpecAwsAuth? Auth { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IntegrationSourceSpec
{
    /// <summary>CloudEventOverrides defines overrides to control the output format and modifications of the event sent to the sink.</summary>
    [JsonPropertyName("ceOverrides")]
    public V1alpha1IntegrationSourceSpecCeOverrides? CeOverrides { get; set; }

    /// <summary>Sink is a reference to an object that will resolve to a uri to use as the sink.</summary>
    [JsonPropertyName("sink")]
    public V1alpha1IntegrationSourceSpecSink? Sink { get; set; }

    /// <summary></summary>
    [JsonPropertyName("timer")]
    public V1alpha1IntegrationSourceSpecTimer? Timer { get; set; }

    /// <summary></summary>
    [JsonPropertyName("aws")]
    public V1alpha1IntegrationSourceSpecAws? Aws { get; set; }

    /// <summary>A template in the shape of `Deployment.spec.template` to be used for this ContainerSource. More info: https://kubernetes.io/docs/concepts/workloads/controllers/deployment/</summary>
    [JsonPropertyName("template")]
    public JsonNode? Template { get; set; }
}

/// <summary>Auth provides the relevant information for OIDC authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IntegrationSourceStatusAuth
{
    /// <summary>ServiceAccountName is the name of the generated service account used for this components OIDC authentication.</summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary>ServiceAccountNames is the list of names of the generated service accounts used for this components OIDC authentication.</summary>
    [JsonPropertyName("serviceAccountNames")]
    public IList<string>? ServiceAccountNames { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IntegrationSourceStatusCeAttributes
{
    /// <summary>Source is the CloudEvents source attribute.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Type refers to the CloudEvent type attribute.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IntegrationSourceStatusConditions
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

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1IntegrationSourceStatus
{
    /// <summary>Annotations is additional Status fields for the Resource to save some additional State as well as convey more information to the user. This is roughly akin to Annotations on any k8s resource, just the reconciler conveying richer information outwards.</summary>
    [JsonPropertyName("annotations")]
    public JsonNode? Annotations { get; set; }

    /// <summary>Auth provides the relevant information for OIDC authentication.</summary>
    [JsonPropertyName("auth")]
    public V1alpha1IntegrationSourceStatusAuth? Auth { get; set; }

    /// <summary>CloudEventAttributes are the specific attributes that the Source uses as part of its CloudEvents.</summary>
    [JsonPropertyName("ceAttributes")]
    public IList<V1alpha1IntegrationSourceStatusCeAttributes>? CeAttributes { get; set; }

    /// <summary>Conditions the latest available observations of a resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1IntegrationSourceStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the 'Generation' of the Service that was last processed by the controller.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>SinkURI is the current active sink URI that has been configured for the Source.</summary>
    [JsonPropertyName("sinkUri")]
    public string? SinkUri { get; set; }

    /// <summary>CACerts is the Certification Authority (CA) certificates in PEM format that the source trusts when sending events to the sink.</summary>
    [JsonPropertyName("sinkCACerts")]
    public string? SinkCACerts { get; set; }

    /// <summary>Audience is the OIDC audience of the sink.</summary>
    [JsonPropertyName("sinkAudience")]
    public string? SinkAudience { get; set; }
}

/// <summary>IntegrationSource is an event source that starts a container image which generates events under certain situations and sends messages to a sink URI</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1IntegrationSource : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1IntegrationSourceSpec>, IStatus<V1alpha1IntegrationSourceStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "IntegrationSource";
    public const string KubeGroup = "sources.knative.dev";
    public const string KubePluralName = "integrationsources";
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
    public V1alpha1IntegrationSourceSpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1IntegrationSourceStatus? Status { get; set; }
}

/// <summary>IntegrationSource is an event source that starts a container image which generates events under certain situations and sends messages to a sink URI</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1IntegrationSourceList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1IntegrationSource>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "IntegrationSourceList";
    public const string KubeGroup = "sources.knative.dev";
    public const string KubePluralName = "integrationsources";
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
    public IList<V1alpha1IntegrationSource> Items { get; set; }
}