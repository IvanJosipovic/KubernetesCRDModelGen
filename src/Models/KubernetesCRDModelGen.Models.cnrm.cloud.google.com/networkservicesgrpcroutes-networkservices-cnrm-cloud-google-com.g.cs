using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networkservices.cnrm.cloud.google.com;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesGRPCRouteMetadata
{
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesGRPCRouteSpecGateways
{
    /// <summary>Allowed value: The `selfLink` field of a `NetworkServicesGateway` resource.</summary>
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
public partial class NetworkServicesGRPCRouteSpecMeshes
{
    /// <summary>Allowed value: The `selfLink` field of a `NetworkServicesMesh` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Immutable. The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesGRPCRouteSpecProjectRef
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
public partial class NetworkServicesGRPCRouteSpecRulesActionDestinationsServiceRef
{
    /// <summary>Required. The URL of a destination service to which to route traffic. Must refer to either a BackendService or ServiceDirectoryService.  Allowed value: The Google Cloud resource name of a `ComputeBackendService` resource (format: `projects/{{project}}/global/backendServices/{{name}}`).</summary>
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
public partial class NetworkServicesGRPCRouteSpecRulesActionDestinations
{
    /// <summary></summary>
    [JsonPropertyName("serviceRef")]
    public NetworkServicesGRPCRouteSpecRulesActionDestinationsServiceRef ServiceRef { get; set; }

    /// <summary>Optional. Specifies the proportion of requests forwarded to the backend referenced by the serviceName field. This is computed as: weight/Sum(weights in this destination list). For non-zero values, there may be some epsilon from the exact proportion defined here depending on the precision an implementation supports. If only one serviceName is specified and it has a weight greater than 0, 100% of the traffic is forwarded to that backend. If weights are specified for any one service name, they need to be specified for all of them. If weights are unspecified for all services, then, traffic is distributed in equal proportions to all of them.</summary>
    [JsonPropertyName("weight")]
    public long? Weight { get; set; }
}

/// <summary>The specification for aborting to client requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesGRPCRouteSpecRulesActionFaultInjectionPolicyAbort
{
    /// <summary>The HTTP status code used to abort the request. The value must be between 200 and 599 inclusive.</summary>
    [JsonPropertyName("httpStatus")]
    public long? HttpStatus { get; set; }

    /// <summary>The percentage of traffic which will be aborted. The value must be between [0, 100]</summary>
    [JsonPropertyName("percentage")]
    public long? Percentage { get; set; }
}

/// <summary>The specification for injecting delay to client requests.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesGRPCRouteSpecRulesActionFaultInjectionPolicyDelay
{
    /// <summary>Specify a fixed delay before forwarding the request.</summary>
    [JsonPropertyName("fixedDelay")]
    public string? FixedDelay { get; set; }

    /// <summary>The percentage of traffic on which delay will be injected. The value must be between [0, 100]</summary>
    [JsonPropertyName("percentage")]
    public long? Percentage { get; set; }
}

/// <summary>Optional. The specification for fault injection introduced into traffic to test the resiliency of clients to destination service failure. As part of fault injection, when clients send requests to a destination, delays can be introduced on a percentage of requests before sending those requests to the destination service. Similarly requests from clients can be aborted by for a percentage of requests. timeout and retry_policy will be ignored by clients that are configured with a fault_injection_policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesGRPCRouteSpecRulesActionFaultInjectionPolicy
{
    /// <summary>The specification for aborting to client requests.</summary>
    [JsonPropertyName("abort")]
    public NetworkServicesGRPCRouteSpecRulesActionFaultInjectionPolicyAbort? Abort { get; set; }

    /// <summary>The specification for injecting delay to client requests.</summary>
    [JsonPropertyName("delay")]
    public NetworkServicesGRPCRouteSpecRulesActionFaultInjectionPolicyDelay? Delay { get; set; }
}

/// <summary>Optional. Specifies the retry policy associated with this route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesGRPCRouteSpecRulesActionRetryPolicy
{
    /// <summary>Specifies the allowed number of retries. This number must be &gt; 0. If not specpfied, default to 1.</summary>
    [JsonPropertyName("numRetries")]
    public long? NumRetries { get; set; }

    /// <summary>- connect-failure: Router will retry on failures connecting to Backend Services, for example due to connection timeouts. - refused-stream: Router will retry if the backend service resets the stream with a REFUSED_STREAM error code. This reset type indicates that it is safe to retry. - cancelled: Router will retry if the gRPC status code in the response header is set to cancelled - deadline-exceeded: Router will retry if the gRPC status code in the response header is set to deadline-exceeded - resource-exhausted: Router will retry if the gRPC status code in the response header is set to resource-exhausted - unavailable: Router will retry if the gRPC status code in the response header is set to unavailable</summary>
    [JsonPropertyName("retryConditions")]
    public IList<string>? RetryConditions { get; set; }
}

/// <summary>Required. A detailed rule defining how to route traffic. This field is required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesGRPCRouteSpecRulesAction
{
    /// <summary>Optional. The destination services to which traffic should be forwarded. If multiple destinations are specified, traffic will be split between Backend Service(s) according to the weight field of these destinations.</summary>
    [JsonPropertyName("destinations")]
    public IList<NetworkServicesGRPCRouteSpecRulesActionDestinations>? Destinations { get; set; }

    /// <summary>Optional. The specification for fault injection introduced into traffic to test the resiliency of clients to destination service failure. As part of fault injection, when clients send requests to a destination, delays can be introduced on a percentage of requests before sending those requests to the destination service. Similarly requests from clients can be aborted by for a percentage of requests. timeout and retry_policy will be ignored by clients that are configured with a fault_injection_policy</summary>
    [JsonPropertyName("faultInjectionPolicy")]
    public NetworkServicesGRPCRouteSpecRulesActionFaultInjectionPolicy? FaultInjectionPolicy { get; set; }

    /// <summary>Optional. Specifies the retry policy associated with this route.</summary>
    [JsonPropertyName("retryPolicy")]
    public NetworkServicesGRPCRouteSpecRulesActionRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Optional. Specifies the timeout for selected route. Timeout is computed from the time the request has been fully processed (i.e. end of stream) up until the response has been completely processed. Timeout includes all retries.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesGRPCRouteSpecRulesMatchesHeaders
{
    /// <summary>Required. The key of the header.</summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>Optional. Specifies how to match against the value of the header. If not specified, a default value of EXACT is used. Possible values: MATCH_TYPE_UNSPECIFIED, MATCH_ANY, MATCH_ALL</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Required. The value of the header.</summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }
}

/// <summary>Optional. A gRPC method to match against. If this field is empty or omitted, will match all methods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesGRPCRouteSpecRulesMatchesMethod
{
    /// <summary>Optional. Specifies that matches are case sensitive. The default value is true. case_sensitive must not be used with a type of REGULAR_EXPRESSION.</summary>
    [JsonPropertyName("caseSensitive")]
    public bool? CaseSensitive { get; set; }

    /// <summary>Required. Name of the method to match against. If unspecified, will match all methods.</summary>
    [JsonPropertyName("grpcMethod")]
    public string GrpcMethod { get; set; }

    /// <summary>Required. Name of the service to match against. If unspecified, will match all services.</summary>
    [JsonPropertyName("grpcService")]
    public string GrpcService { get; set; }

    /// <summary>Optional. Specifies how to match against the name. If not specified, a default value of "EXACT" is used. Possible values: TYPE_UNSPECIFIED, EXACT, REGULAR_EXPRESSION</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesGRPCRouteSpecRulesMatches
{
    /// <summary>Optional. Specifies a collection of headers to match.</summary>
    [JsonPropertyName("headers")]
    public IList<NetworkServicesGRPCRouteSpecRulesMatchesHeaders>? Headers { get; set; }

    /// <summary>Optional. A gRPC method to match against. If this field is empty or omitted, will match all methods.</summary>
    [JsonPropertyName("method")]
    public NetworkServicesGRPCRouteSpecRulesMatchesMethod? Method { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesGRPCRouteSpecRules
{
    /// <summary>Required. A detailed rule defining how to route traffic. This field is required.</summary>
    [JsonPropertyName("action")]
    public NetworkServicesGRPCRouteSpecRulesAction Action { get; set; }

    /// <summary>Optional. Matches define conditions used for matching the rule against incoming gRPC requests. Each match is independent, i.e. this rule will be matched if ANY one of the matches is satisfied. If no matches field is specified, this rule will unconditionally match traffic.</summary>
    [JsonPropertyName("matches")]
    public IList<NetworkServicesGRPCRouteSpecRulesMatches>? Matches { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesGRPCRouteSpec
{
    /// <summary>Optional. A free-text description of the resource. Max length 1024 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary></summary>
    [JsonPropertyName("gateways")]
    public IList<NetworkServicesGRPCRouteSpecGateways>? Gateways { get; set; }

    /// <summary>Required. Service hostnames with an optional port for which this route describes traffic. Format: [:] Hostname is the fully qualified domain name of a network host. This matches the RFC 1123 definition of a hostname with 2 notable exceptions: - IPs are not allowed. - A hostname may be prefixed with a wildcard label (*.). The wildcard label must appear by itself as the first label. Hostname can be “precise” which is a domain name without the terminating dot of a network host (e.g. “foo.example.com”) or “wildcard”, which is a domain name prefixed with a single wildcard label (e.g. *.example.com). Note that as per RFC1035 and RFC1123, a label must consist of lower case alphanumeric characters or ‘-’, and must start and end with an alphanumeric character. No other punctuation is allowed. The routes associated with a Router must have unique hostnames. If you attempt to attach multiple routes with conflicting hostnames, the configuration will be rejected. For example, while it is acceptable for routes for the hostnames "*.foo.bar.com" and "*.bar.com" to be associated with the same route, it is not possible to associate two routes both with "*.bar.com" or both with "bar.com". In the case that multiple routes match the hostname, the most specific match will be selected. For example, "foo.bar.baz.com" will take precedence over "*.bar.baz.com" and "*.bar.baz.com" will take precedence over "*.baz.com". If a port is specified, then gRPC clients must use the channel URI with the port to match this rule (i.e. "xds:///service:123"), otherwise they must supply the URI without a port (i.e. "xds:///service").</summary>
    [JsonPropertyName("hostnames")]
    public IList<string> Hostnames { get; set; }

    /// <summary>Immutable. The location for the resource</summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary></summary>
    [JsonPropertyName("meshes")]
    public IList<NetworkServicesGRPCRouteSpecMeshes>? Meshes { get; set; }

    /// <summary>Immutable. The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public NetworkServicesGRPCRouteSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. A list of detailed rules defining how to route traffic. Within a single GrpcRoute, the GrpcRoute.RouteAction associated with the first matching GrpcRoute.RouteRule will be executed. At least one rule must be supplied.</summary>
    [JsonPropertyName("rules")]
    public IList<NetworkServicesGRPCRouteSpecRules> Rules { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesGRPCRouteStatusConditions
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
public partial class NetworkServicesGRPCRouteStatus
{
    /// <summary>Conditions represent the latest available observation of the resource's current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<NetworkServicesGRPCRouteStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. The timestamp when the resource was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>Output only. Server-defined URL of this resource</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>Output only. The timestamp when the resource was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class NetworkServicesGRPCRoute
{
    /// <summary>apiVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public NetworkServicesGRPCRouteMetadata? Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("spec")]
    public NetworkServicesGRPCRouteSpec Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public NetworkServicesGRPCRouteStatus? Status { get; set; }
}