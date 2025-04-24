using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sinks.knative.dev;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class IntegrationSinkSpecLog
{
    /// <summary>Name of the logging category to use</summary>
    [JsonPropertyName("loggerName")]
    public string? LoggerName { get; set; }

    /// <summary>Logging level to use</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>Mask sensitive information like password or passphrase in the log</summary>
    [JsonPropertyName("logMask")]
    public bool? LogMask { get; set; }

    /// <summary>An optional Marker name to use</summary>
    [JsonPropertyName("marker")]
    public string? Marker { get; set; }

    /// <summary>If enabled then each information is outputted on a newline</summary>
    [JsonPropertyName("multiline")]
    public bool? Multiline { get; set; }

    /// <summary>Show all of the exchange properties (both internal and custom)</summary>
    [JsonPropertyName("showAllProperties")]
    public bool? ShowAllProperties { get; set; }

    /// <summary>Show the message body</summary>
    [JsonPropertyName("showBody")]
    public bool? ShowBody { get; set; }

    /// <summary>Show the body Java type</summary>
    [JsonPropertyName("showBodyType")]
    public bool? ShowBodyType { get; set; }

    /// <summary>Shows the Message Exchange Pattern (or MEP for short)</summary>
    [JsonPropertyName("showExchangePattern")]
    public bool? ShowExchangePattern { get; set; }

    /// <summary>Show the headers received</summary>
    [JsonPropertyName("showHeaders")]
    public bool? ShowHeaders { get; set; }

    /// <summary>Show the exchange properties (only custom). Use showAllProperties to show both internal and custom properties.</summary>
    [JsonPropertyName("showProperties")]
    public bool? ShowProperties { get; set; }

    /// <summary>Show the stream bodies (they may not be available in following steps)</summary>
    [JsonPropertyName("showStreams")]
    public bool? ShowStreams { get; set; }

    /// <summary>Whether Camel should show cached stream bodies or not.</summary>
    [JsonPropertyName("showCachedStreams")]
    public bool? ShowCachedStreams { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class IntegrationSinkSpecAwsS3
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
public partial class IntegrationSinkSpecAwsSqs
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
public partial class IntegrationSinkSpecAwsSns
{
    /// <summary>The SNS topic name name or Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The AWS region to access.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Setting the autocreation of the SNS topic.</summary>
    [JsonPropertyName("autoCreateTopic")]
    public bool? AutoCreateTopic { get; set; }

    /// <summary>The overriding endpoint URI. To use this option, you must also select the `overrideEndpoint` option.</summary>
    [JsonPropertyName("uriEndpointOverride")]
    public string? UriEndpointOverride { get; set; }

    /// <summary>Select this option to override the endpoint URI. To use this option, you must also provide a URI for the `uriEndpointOverride` option.</summary>
    [JsonPropertyName("overrideEndpoint")]
    public bool? OverrideEndpoint { get; set; }
}

/// <summary>Secret reference. </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class IntegrationSinkSpecAwsAuthSecretRef
{
    /// <summary>Secret name</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>Auth secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class IntegrationSinkSpecAwsAuthSecret
{
    /// <summary>Secret reference. </summary>
    [JsonPropertyName("ref")]
    public IntegrationSinkSpecAwsAuthSecretRef? Ref { get; set; }
}

/// <summary>Auth configurations</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class IntegrationSinkSpecAwsAuth
{
    /// <summary>Auth secret</summary>
    [JsonPropertyName("secret")]
    public IntegrationSinkSpecAwsAuthSecret? Secret { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class IntegrationSinkSpecAws
{
    /// <summary></summary>
    [JsonPropertyName("s3")]
    public IntegrationSinkSpecAwsS3? S3 { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sqs")]
    public IntegrationSinkSpecAwsSqs? Sqs { get; set; }

    /// <summary></summary>
    [JsonPropertyName("sns")]
    public IntegrationSinkSpecAwsSns? Sns { get; set; }

    /// <summary>Auth configurations</summary>
    [JsonPropertyName("auth")]
    public IntegrationSinkSpecAwsAuth? Auth { get; set; }
}

/// <summary>Spec defines the desired state of the IntegrationSink.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class IntegrationSinkSpec
{
    /// <summary></summary>
    [JsonPropertyName("log")]
    public IntegrationSinkSpecLog? Log { get; set; }

    /// <summary></summary>
    [JsonPropertyName("aws")]
    public IntegrationSinkSpecAws? Aws { get; set; }
}

/// <summary>IntegrationSink is Addressable. It exposes the endpoints as URIs to get events delivered into the used Kamelet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class IntegrationSinkStatusAddress
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
public partial class IntegrationSinkStatusAddresses
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
public partial class IntegrationSinkStatusPolicies
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
public partial class IntegrationSinkStatusConditions
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

/// <summary>Status represents the current state of the IntegrationSink. This data may be out of date.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class IntegrationSinkStatus
{
    /// <summary>IntegrationSink is Addressable. It exposes the endpoints as URIs to get events delivered into the used Kamelet.</summary>
    [JsonPropertyName("address")]
    public IntegrationSinkStatusAddress? Address { get; set; }

    /// <summary>IntegrationSink is Addressable. It exposes the endpoints as URIs to get events delivered into the used Kamelet.</summary>
    [JsonPropertyName("addresses")]
    public IList<IntegrationSinkStatusAddresses>? Addresses { get; set; }

    /// <summary>Annotations is additional Status fields for the Resource to save some additional State as well as convey more information to the user. This is roughly akin to Annotations on any k8s resource, just the reconciler conveying richer information outwards.</summary>
    [JsonPropertyName("annotations")]
    public JsonNode? Annotations { get; set; }

    /// <summary>List of applied EventPolicies</summary>
    [JsonPropertyName("policies")]
    public IList<IntegrationSinkStatusPolicies>? Policies { get; set; }

    /// <summary>Conditions the latest available observations of a resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<IntegrationSinkStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the 'Generation' of the Service that was last processed by the controller.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>IntegrationSink sends events to generic event sink</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class IntegrationSink
{
    /// <summary>Spec defines the desired state of the IntegrationSink.</summary>
    [JsonPropertyName("spec")]
    public IntegrationSinkSpec? Spec { get; set; }

    /// <summary>Status represents the current state of the IntegrationSink. This data may be out of date.</summary>
    [JsonPropertyName("status")]
    public IntegrationSinkStatus? Status { get; set; }
}