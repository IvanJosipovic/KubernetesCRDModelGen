using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networkservices.cnrm.cloud.google.com;
public partial class V1alpha1NetworkServicesEdgeCacheOriginSpecAwsV4Authentication
{
    /// <summary>The access key ID your origin uses to identify the key.</summary>
    [JsonPropertyName("accessKeyId")]
    public string AccessKeyId { get; set; }

    /// <summary>The name of the AWS region that your origin is in.</summary>
    [JsonPropertyName("originRegion")]
    public string OriginRegion { get; set; }

    /// <summary>The Secret Manager secret version of the secret access key used by your origin.  This is the resource name of the secret version in the format 'projects/*/secrets/*/versions/*' where the '*' values are replaced by the project, secret, and version you require.</summary>
    [JsonPropertyName("secretAccessKeyVersion")]
    public string SecretAccessKeyVersion { get; set; }
}

public partial class V1alpha1NetworkServicesEdgeCacheOriginSpecOriginOverrideActionHeaderActionRequestHeadersToAdd
{
    /// <summary>The name of the header to add.</summary>
    [JsonPropertyName("headerName")]
    public string HeaderName { get; set; }

    /// <summary>The value of the header to add.</summary>
    [JsonPropertyName("headerValue")]
    public string HeaderValue { get; set; }

    /// <summary>Whether to replace all existing headers with the same name.  By default, added header values are appended to the response or request headers with the same field names. The added values are separated by commas.  To overwrite existing values, set 'replace' to 'true'.</summary>
    [JsonPropertyName("replace")]
    public bool? Replace { get; set; }
}

public partial class V1alpha1NetworkServicesEdgeCacheOriginSpecOriginOverrideActionHeaderAction
{
    /// <summary>Describes a header to add.  You may add a maximum of 25 request headers.</summary>
    [JsonPropertyName("requestHeadersToAdd")]
    public IList<V1alpha1NetworkServicesEdgeCacheOriginSpecOriginOverrideActionHeaderActionRequestHeadersToAdd>? RequestHeadersToAdd { get; set; }
}

public partial class V1alpha1NetworkServicesEdgeCacheOriginSpecOriginOverrideActionUrlRewrite
{
    /// <summary>Prior to forwarding the request to the selected origin, the request's host header is replaced with contents of the hostRewrite.  This value must be between 1 and 255 characters.</summary>
    [JsonPropertyName("hostRewrite")]
    public string? HostRewrite { get; set; }
}

public partial class V1alpha1NetworkServicesEdgeCacheOriginSpecOriginOverrideAction
{
    /// <summary>The header actions, including adding and removing headers, for request handled by this origin.</summary>
    [JsonPropertyName("headerAction")]
    public V1alpha1NetworkServicesEdgeCacheOriginSpecOriginOverrideActionHeaderAction? HeaderAction { get; set; }

    /// <summary>The URL rewrite configuration for request that are handled by this origin.</summary>
    [JsonPropertyName("urlRewrite")]
    public V1alpha1NetworkServicesEdgeCacheOriginSpecOriginOverrideActionUrlRewrite? UrlRewrite { get; set; }
}

public partial class V1alpha1NetworkServicesEdgeCacheOriginSpecOriginRedirect
{
    /// <summary>The set of redirect response codes that the CDN follows. Values of [RedirectConditions](https://cloud.google.com/media-cdn/docs/reference/rest/v1/projects.locations.edgeCacheOrigins#redirectconditions) are accepted.</summary>
    [JsonPropertyName("redirectConditions")]
    public IList<string>? RedirectConditions { get; set; }
}

public partial class V1alpha1NetworkServicesEdgeCacheOriginSpecProjectRef
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

public partial class V1alpha1NetworkServicesEdgeCacheOriginSpecTimeout
{
    /// <summary>The maximum duration to wait for a single origin connection to be established, including DNS lookup, TLS handshake and TCP/QUIC connection establishment.  Defaults to 5 seconds. The timeout must be a value between 1s and 15s.  The connectTimeout capped by the deadline set by the request's maxAttemptsTimeout.  The last connection attempt may have a smaller connectTimeout in order to adhere to the overall maxAttemptsTimeout.</summary>
    [JsonPropertyName("connectTimeout")]
    public string? ConnectTimeout { get; set; }

    /// <summary>The maximum time across all connection attempts to the origin, including failover origins, before returning an error to the client. A HTTP 504 will be returned if the timeout is reached before a response is returned.  Defaults to 15 seconds. The timeout must be a value between 1s and 30s.  If a failoverOrigin is specified, the maxAttemptsTimeout of the first configured origin sets the deadline for all connection attempts across all failoverOrigins.</summary>
    [JsonPropertyName("maxAttemptsTimeout")]
    public string? MaxAttemptsTimeout { get; set; }

    /// <summary>The maximum duration to wait between reads of a single HTTP connection/stream.  Defaults to 15 seconds.  The timeout must be a value between 1s and 30s.  The readTimeout is capped by the responseTimeout.  All reads of the HTTP connection/stream must be completed by the deadline set by the responseTimeout.  If the response headers have already been written to the connection, the response will be truncated and logged.</summary>
    [JsonPropertyName("readTimeout")]
    public string? ReadTimeout { get; set; }

    /// <summary>The maximum duration to wait for the last byte of a response to arrive when reading from the HTTP connection/stream.  Defaults to 30 seconds. The timeout must be a value between 1s and 120s.  The responseTimeout starts after the connection has been established.  This also applies to HTTP Chunked Transfer Encoding responses, and/or when an open-ended Range request is made to the origin. Origins that take longer to write additional bytes to the response than the configured responseTimeout will result in an error being returned to the client.  If the response headers have already been written to the connection, the response will be truncated and logged.</summary>
    [JsonPropertyName("responseTimeout")]
    public string? ResponseTimeout { get; set; }
}

public partial class V1alpha1NetworkServicesEdgeCacheOriginSpec
{
    /// <summary>Enable AWS Signature Version 4 origin authentication.</summary>
    [JsonPropertyName("awsV4Authentication")]
    public V1alpha1NetworkServicesEdgeCacheOriginSpecAwsV4Authentication? AwsV4Authentication { get; set; }

    /// <summary>A human-readable description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The Origin resource to try when the current origin cannot be reached. After maxAttempts is reached, the configured failoverOrigin will be used to fulfil the request.  The value of timeout.maxAttemptsTimeout dictates the timeout across all origins. A reference to a Topic resource.</summary>
    [JsonPropertyName("failoverOrigin")]
    public string? FailoverOrigin { get; set; }

    /// <summary>The maximum number of attempts to cache fill from this origin. Another attempt is made when a cache fill fails with one of the retryConditions.  Once maxAttempts to this origin have failed the failoverOrigin will be used, if one is specified. That failoverOrigin may specify its own maxAttempts, retryConditions and failoverOrigin to control its own cache fill failures.  The total number of allowed attempts to cache fill across this and failover origins is limited to four. The total time allowed for cache fill attempts across this and failover origins can be controlled with maxAttemptsTimeout.  The last valid, non-retried response from all origins will be returned to the client. If no origin returns a valid response, an HTTP 502 will be returned to the client.  Defaults to 1. Must be a value greater than 0 and less than 4.</summary>
    [JsonPropertyName("maxAttempts")]
    public int? MaxAttempts { get; set; }

    /// <summary>A fully qualified domain name (FQDN) or IP address reachable over the public Internet, or the address of a Google Cloud Storage bucket.  This address will be used as the origin for cache requests - e.g. FQDN: media-backend.example.com, IPv4: 35.218.1.1, IPv6: 2607:f8b0:4012:809::200e, Cloud Storage: gs://bucketname  When providing an FQDN (hostname), it must be publicly resolvable (e.g. via Google public DNS) and IP addresses must be publicly routable.  It must not contain a protocol (e.g., https://) and it must not contain any slashes. If a Cloud Storage bucket is provided, it must be in the canonical "gs://bucketname" format. Other forms, such as "storage.googleapis.com", will be rejected.</summary>
    [JsonPropertyName("originAddress")]
    public string OriginAddress { get; set; }

    /// <summary>The override actions, including url rewrites and header additions, for requests that use this origin.</summary>
    [JsonPropertyName("originOverrideAction")]
    public V1alpha1NetworkServicesEdgeCacheOriginSpecOriginOverrideAction? OriginOverrideAction { get; set; }

    /// <summary>Follow redirects from this origin.</summary>
    [JsonPropertyName("originRedirect")]
    public V1alpha1NetworkServicesEdgeCacheOriginSpecOriginRedirect? OriginRedirect { get; set; }

    /// <summary>The port to connect to the origin on. Defaults to port 443 for HTTP2 and HTTPS protocols, and port 80 for HTTP.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1alpha1NetworkServicesEdgeCacheOriginSpecProjectRef ProjectRef { get; set; }

    /// <summary>The protocol to use to connect to the configured origin. Defaults to HTTP2, and it is strongly recommended that users use HTTP2 for both security &amp; performance.  When using HTTP2 or HTTPS as the protocol, a valid, publicly-signed, unexpired TLS (SSL) certificate must be presented by the origin server. Possible values: ["HTTP2", "HTTPS", "HTTP"].</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Specifies one or more retry conditions for the configured origin.  If the failure mode during a connection attempt to the origin matches the configured retryCondition(s), the origin request will be retried up to maxAttempts times. The failoverOrigin, if configured, will then be used to satisfy the request.  The default retryCondition is "CONNECT_FAILURE".  retryConditions apply to this origin, and not subsequent failoverOrigin(s), which may specify their own retryConditions and maxAttempts.  Valid values are:  - CONNECT_FAILURE: Retry on failures connecting to origins, for example due to connection timeouts. - HTTP_5XX: Retry if the origin responds with any 5xx response code, or if the origin does not respond at all, example: disconnects, reset, read timeout, connection failure, and refused streams. - GATEWAY_ERROR: Similar to 5xx, but only applies to response codes 502, 503 or 504. - RETRIABLE_4XX: Retry for retriable 4xx response codes, which include HTTP 409 (Conflict) and HTTP 429 (Too Many Requests) - NOT_FOUND: Retry if the origin returns a HTTP 404 (Not Found). This can be useful when generating video content, and the segment is not available yet. - FORBIDDEN: Retry if the origin returns a HTTP 403 (Forbidden). Possible values: ["CONNECT_FAILURE", "HTTP_5XX", "GATEWAY_ERROR", "RETRIABLE_4XX", "NOT_FOUND", "FORBIDDEN"].</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }

    /// <summary>The connection and HTTP timeout configuration for this origin.</summary>
    [JsonPropertyName("timeout")]
    public V1alpha1NetworkServicesEdgeCacheOriginSpecTimeout? Timeout { get; set; }
}

public partial class V1alpha1NetworkServicesEdgeCacheOriginStatusConditions
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

public partial class V1alpha1NetworkServicesEdgeCacheOriginStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1NetworkServicesEdgeCacheOriginStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NetworkServicesEdgeCacheOrigin : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1NetworkServicesEdgeCacheOriginSpec>, IStatus<V1alpha1NetworkServicesEdgeCacheOriginStatus>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NetworkServicesEdgeCacheOrigin";
    public const string KubeGroup = "networkservices.cnrm.cloud.google.com";
    public const string KubePluralName = "networkservicesedgecacheorigins";
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
    public V1alpha1NetworkServicesEdgeCacheOriginSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public V1alpha1NetworkServicesEdgeCacheOriginStatus? Status { get; set; }
}