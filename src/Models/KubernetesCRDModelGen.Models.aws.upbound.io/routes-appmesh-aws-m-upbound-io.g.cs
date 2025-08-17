using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appmesh.aws.m.upbound.io;
#nullable enable
/// <summary>Route is the Schema for the Routes API. Provides an AWS App Mesh route resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RouteList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Route>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RouteList";
    public const string KubeGroup = "appmesh.aws.m.upbound.io";
    public const string KubePluralName = "routes";
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
    public IList<V1beta1Route> Items { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderMeshNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Mesh in appmesh to populate meshName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderMeshNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouteSpecForProviderMeshNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderMeshNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Mesh in appmesh to populate meshName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderMeshNameSelector
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
    public V1beta1RouteSpecForProviderMeshNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecGrpcRouteActionWeightedTarget
{
    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual node to associate with the weighted target. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualNode")]
    public string? VirtualNode { get; set; }

    /// <summary>Relative weight of the weighted target. An integer between 0 and 100.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecGrpcRouteAction
{
    /// <summary>Targets that traffic is routed to when a request matches the route. You can specify one or more targets and their relative weights with which to distribute traffic.</summary>
    [JsonPropertyName("weightedTarget")]
    public IList<V1beta1RouteSpecForProviderSpecGrpcRouteActionWeightedTarget>? WeightedTarget { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecGrpcRouteMatchMetadataMatchRange
{
    /// <summary>End of the range.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>(Requited) Start of the range.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecGrpcRouteMatchMetadataMatch
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
    [JsonPropertyName("range")]
    public V1beta1RouteSpecForProviderSpecGrpcRouteMatchMetadataMatchRange? Range { get; set; }

    /// <summary>Value sent by the client must include the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Value sent by the client must end with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecGrpcRouteMatchMetadata
{
    /// <summary>If true, the match is on the opposite of the match criteria. Default is false.</summary>
    [JsonPropertyName("invert")]
    public bool? Invert { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1RouteSpecForProviderSpecGrpcRouteMatchMetadataMatch? Match { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecGrpcRouteMatch
{
    /// <summary>Data to match from the gRPC request.</summary>
    [JsonPropertyName("metadata")]
    public IList<V1beta1RouteSpecForProviderSpecGrpcRouteMatchMetadata>? Metadata { get; set; }

    /// <summary>Method name to match from the request. If you specify a name, you must also specify a service_name.</summary>
    [JsonPropertyName("methodName")]
    public string? MethodName { get; set; }

    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Fully qualified domain name for the service to match from the request.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Per-retry timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecGrpcRouteRetryPolicyPerRetryTimeout
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Retry policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecGrpcRouteRetryPolicy
{
    /// <summary>List of gRPC retry events. Valid values: cancelled, deadline-exceeded, internal, resource-exhausted, unavailable.</summary>
    [JsonPropertyName("grpcRetryEvents")]
    public IList<string>? GrpcRetryEvents { get; set; }

    /// <summary>List of HTTP retry events. Valid values: client-error (HTTP status code 409), gateway-error (HTTP status codes 502, 503, and 504), server-error (HTTP status codes 500, 501, 502, 503, 504, 505, 506, 507, 508, 510, and 511), stream-error (retry on refused stream).</summary>
    [JsonPropertyName("httpRetryEvents")]
    public IList<string>? HttpRetryEvents { get; set; }

    /// <summary>Maximum number of retries.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>Per-retry timeout.</summary>
    [JsonPropertyName("perRetryTimeout")]
    public V1beta1RouteSpecForProviderSpecGrpcRouteRetryPolicyPerRetryTimeout? PerRetryTimeout { get; set; }

    /// <summary>List of TCP retry events. The only valid value is connection-error.</summary>
    [JsonPropertyName("tcpRetryEvents")]
    public IList<string>? TcpRetryEvents { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecGrpcRouteTimeoutIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Per request timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecGrpcRouteTimeoutPerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Types of timeouts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecGrpcRouteTimeout
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta1RouteSpecForProviderSpecGrpcRouteTimeoutIdle? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public V1beta1RouteSpecForProviderSpecGrpcRouteTimeoutPerRequest? PerRequest { get; set; }
}
#nullable disable

#nullable enable
/// <summary>GRPC routing information for the route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecGrpcRoute
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta1RouteSpecForProviderSpecGrpcRouteAction? Action { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1RouteSpecForProviderSpecGrpcRouteMatch? Match { get; set; }

    /// <summary>Retry policy.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta1RouteSpecForProviderSpecGrpcRouteRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Types of timeouts.</summary>
    [JsonPropertyName("timeout")]
    public V1beta1RouteSpecForProviderSpecGrpcRouteTimeout? Timeout { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttp2RouteActionWeightedTarget
{
    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual node to associate with the weighted target. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualNode")]
    public string? VirtualNode { get; set; }

    /// <summary>Relative weight of the weighted target. An integer between 0 and 100.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttp2RouteAction
{
    /// <summary>Targets that traffic is routed to when a request matches the route. You can specify one or more targets and their relative weights with which to distribute traffic.</summary>
    [JsonPropertyName("weightedTarget")]
    public IList<V1beta1RouteSpecForProviderSpecHttp2RouteActionWeightedTarget>? WeightedTarget { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttp2RouteMatchHeaderMatchRange
{
    /// <summary>End of the range.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>(Requited) Start of the range.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttp2RouteMatchHeaderMatch
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
    [JsonPropertyName("range")]
    public V1beta1RouteSpecForProviderSpecHttp2RouteMatchHeaderMatchRange? Range { get; set; }

    /// <summary>Value sent by the client must include the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Value sent by the client must end with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttp2RouteMatchHeader
{
    /// <summary>If true, the match is on the opposite of the match criteria. Default is false.</summary>
    [JsonPropertyName("invert")]
    public bool? Invert { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1RouteSpecForProviderSpecHttp2RouteMatchHeaderMatch? Match { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Client request path to match on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttp2RouteMatchPath
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Value sent by the client must include the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttp2RouteMatchQueryParameterMatch
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttp2RouteMatchQueryParameter
{
    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1RouteSpecForProviderSpecHttp2RouteMatchQueryParameterMatch? Match { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttp2RouteMatch
{
    /// <summary>Client request headers to match on.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1RouteSpecForProviderSpecHttp2RouteMatchHeader>? Header { get; set; }

    /// <summary>Client request header method to match on. Valid values: GET, HEAD, POST, PUT, DELETE, CONNECT, OPTIONS, TRACE, PATCH.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Client request path to match on.</summary>
    [JsonPropertyName("path")]
    public V1beta1RouteSpecForProviderSpecHttp2RouteMatchPath? Path { get; set; }

    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Client request query parameters to match on.</summary>
    [JsonPropertyName("queryParameter")]
    public IList<V1beta1RouteSpecForProviderSpecHttp2RouteMatchQueryParameter>? QueryParameter { get; set; }

    /// <summary>Client request header scheme to match on. Valid values: http, https.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Per-retry timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttp2RouteRetryPolicyPerRetryTimeout
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Retry policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttp2RouteRetryPolicy
{
    /// <summary>List of HTTP retry events. Valid values: client-error (HTTP status code 409), gateway-error (HTTP status codes 502, 503, and 504), server-error (HTTP status codes 500, 501, 502, 503, 504, 505, 506, 507, 508, 510, and 511), stream-error (retry on refused stream).</summary>
    [JsonPropertyName("httpRetryEvents")]
    public IList<string>? HttpRetryEvents { get; set; }

    /// <summary>Maximum number of retries.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>Per-retry timeout.</summary>
    [JsonPropertyName("perRetryTimeout")]
    public V1beta1RouteSpecForProviderSpecHttp2RouteRetryPolicyPerRetryTimeout? PerRetryTimeout { get; set; }

    /// <summary>List of TCP retry events. The only valid value is connection-error.</summary>
    [JsonPropertyName("tcpRetryEvents")]
    public IList<string>? TcpRetryEvents { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttp2RouteTimeoutIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Per request timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttp2RouteTimeoutPerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Types of timeouts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttp2RouteTimeout
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta1RouteSpecForProviderSpecHttp2RouteTimeoutIdle? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public V1beta1RouteSpecForProviderSpecHttp2RouteTimeoutPerRequest? PerRequest { get; set; }
}
#nullable disable

#nullable enable
/// <summary>HTTP/2 routing information for the route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttp2Route
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta1RouteSpecForProviderSpecHttp2RouteAction? Action { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1RouteSpecForProviderSpecHttp2RouteMatch? Match { get; set; }

    /// <summary>Retry policy.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta1RouteSpecForProviderSpecHttp2RouteRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Types of timeouts.</summary>
    [JsonPropertyName("timeout")]
    public V1beta1RouteSpecForProviderSpecHttp2RouteTimeout? Timeout { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttpRouteActionWeightedTargetVirtualNodeRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a VirtualNode in appmesh to populate virtualNode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttpRouteActionWeightedTargetVirtualNodeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouteSpecForProviderSpecHttpRouteActionWeightedTargetVirtualNodeRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttpRouteActionWeightedTargetVirtualNodeSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a VirtualNode in appmesh to populate virtualNode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttpRouteActionWeightedTargetVirtualNodeSelector
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
    public V1beta1RouteSpecForProviderSpecHttpRouteActionWeightedTargetVirtualNodeSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttpRouteActionWeightedTarget
{
    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual node to associate with the weighted target. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualNode")]
    public string? VirtualNode { get; set; }

    /// <summary>Reference to a VirtualNode in appmesh to populate virtualNode.</summary>
    [JsonPropertyName("virtualNodeRef")]
    public V1beta1RouteSpecForProviderSpecHttpRouteActionWeightedTargetVirtualNodeRef? VirtualNodeRef { get; set; }

    /// <summary>Selector for a VirtualNode in appmesh to populate virtualNode.</summary>
    [JsonPropertyName("virtualNodeSelector")]
    public V1beta1RouteSpecForProviderSpecHttpRouteActionWeightedTargetVirtualNodeSelector? VirtualNodeSelector { get; set; }

    /// <summary>Relative weight of the weighted target. An integer between 0 and 100.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttpRouteAction
{
    /// <summary>Targets that traffic is routed to when a request matches the route. You can specify one or more targets and their relative weights with which to distribute traffic.</summary>
    [JsonPropertyName("weightedTarget")]
    public IList<V1beta1RouteSpecForProviderSpecHttpRouteActionWeightedTarget>? WeightedTarget { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttpRouteMatchHeaderMatchRange
{
    /// <summary>End of the range.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>(Requited) Start of the range.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttpRouteMatchHeaderMatch
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
    [JsonPropertyName("range")]
    public V1beta1RouteSpecForProviderSpecHttpRouteMatchHeaderMatchRange? Range { get; set; }

    /// <summary>Value sent by the client must include the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Value sent by the client must end with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttpRouteMatchHeader
{
    /// <summary>If true, the match is on the opposite of the match criteria. Default is false.</summary>
    [JsonPropertyName("invert")]
    public bool? Invert { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1RouteSpecForProviderSpecHttpRouteMatchHeaderMatch? Match { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Client request path to match on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttpRouteMatchPath
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Value sent by the client must include the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttpRouteMatchQueryParameterMatch
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttpRouteMatchQueryParameter
{
    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1RouteSpecForProviderSpecHttpRouteMatchQueryParameterMatch? Match { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttpRouteMatch
{
    /// <summary>Client request headers to match on.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1RouteSpecForProviderSpecHttpRouteMatchHeader>? Header { get; set; }

    /// <summary>Client request header method to match on. Valid values: GET, HEAD, POST, PUT, DELETE, CONNECT, OPTIONS, TRACE, PATCH.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Client request path to match on.</summary>
    [JsonPropertyName("path")]
    public V1beta1RouteSpecForProviderSpecHttpRouteMatchPath? Path { get; set; }

    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Client request query parameters to match on.</summary>
    [JsonPropertyName("queryParameter")]
    public IList<V1beta1RouteSpecForProviderSpecHttpRouteMatchQueryParameter>? QueryParameter { get; set; }

    /// <summary>Client request header scheme to match on. Valid values: http, https.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Per-retry timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttpRouteRetryPolicyPerRetryTimeout
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Retry policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttpRouteRetryPolicy
{
    /// <summary>List of HTTP retry events. Valid values: client-error (HTTP status code 409), gateway-error (HTTP status codes 502, 503, and 504), server-error (HTTP status codes 500, 501, 502, 503, 504, 505, 506, 507, 508, 510, and 511), stream-error (retry on refused stream).</summary>
    [JsonPropertyName("httpRetryEvents")]
    public IList<string>? HttpRetryEvents { get; set; }

    /// <summary>Maximum number of retries.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>Per-retry timeout.</summary>
    [JsonPropertyName("perRetryTimeout")]
    public V1beta1RouteSpecForProviderSpecHttpRouteRetryPolicyPerRetryTimeout? PerRetryTimeout { get; set; }

    /// <summary>List of TCP retry events. The only valid value is connection-error.</summary>
    [JsonPropertyName("tcpRetryEvents")]
    public IList<string>? TcpRetryEvents { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttpRouteTimeoutIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Per request timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttpRouteTimeoutPerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Types of timeouts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttpRouteTimeout
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta1RouteSpecForProviderSpecHttpRouteTimeoutIdle? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public V1beta1RouteSpecForProviderSpecHttpRouteTimeoutPerRequest? PerRequest { get; set; }
}
#nullable disable

#nullable enable
/// <summary>HTTP routing information for the route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecHttpRoute
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta1RouteSpecForProviderSpecHttpRouteAction? Action { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1RouteSpecForProviderSpecHttpRouteMatch? Match { get; set; }

    /// <summary>Retry policy.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta1RouteSpecForProviderSpecHttpRouteRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Types of timeouts.</summary>
    [JsonPropertyName("timeout")]
    public V1beta1RouteSpecForProviderSpecHttpRouteTimeout? Timeout { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecTcpRouteActionWeightedTargetVirtualNodeRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a VirtualNode in appmesh to populate virtualNode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecTcpRouteActionWeightedTargetVirtualNodeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouteSpecForProviderSpecTcpRouteActionWeightedTargetVirtualNodeRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecTcpRouteActionWeightedTargetVirtualNodeSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a VirtualNode in appmesh to populate virtualNode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecTcpRouteActionWeightedTargetVirtualNodeSelector
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
    public V1beta1RouteSpecForProviderSpecTcpRouteActionWeightedTargetVirtualNodeSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecTcpRouteActionWeightedTarget
{
    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual node to associate with the weighted target. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualNode")]
    public string? VirtualNode { get; set; }

    /// <summary>Reference to a VirtualNode in appmesh to populate virtualNode.</summary>
    [JsonPropertyName("virtualNodeRef")]
    public V1beta1RouteSpecForProviderSpecTcpRouteActionWeightedTargetVirtualNodeRef? VirtualNodeRef { get; set; }

    /// <summary>Selector for a VirtualNode in appmesh to populate virtualNode.</summary>
    [JsonPropertyName("virtualNodeSelector")]
    public V1beta1RouteSpecForProviderSpecTcpRouteActionWeightedTargetVirtualNodeSelector? VirtualNodeSelector { get; set; }

    /// <summary>Relative weight of the weighted target. An integer between 0 and 100.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecTcpRouteAction
{
    /// <summary>Targets that traffic is routed to when a request matches the route. You can specify one or more targets and their relative weights with which to distribute traffic.</summary>
    [JsonPropertyName("weightedTarget")]
    public IList<V1beta1RouteSpecForProviderSpecTcpRouteActionWeightedTarget>? WeightedTarget { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecTcpRouteMatch
{
    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecTcpRouteTimeoutIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Types of timeouts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecTcpRouteTimeout
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta1RouteSpecForProviderSpecTcpRouteTimeoutIdle? Idle { get; set; }
}
#nullable disable

#nullable enable
/// <summary>TCP routing information for the route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpecTcpRoute
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta1RouteSpecForProviderSpecTcpRouteAction? Action { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1RouteSpecForProviderSpecTcpRouteMatch? Match { get; set; }

    /// <summary>Types of timeouts.</summary>
    [JsonPropertyName("timeout")]
    public V1beta1RouteSpecForProviderSpecTcpRouteTimeout? Timeout { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Route specification to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderSpec
{
    /// <summary>GRPC routing information for the route.</summary>
    [JsonPropertyName("grpcRoute")]
    public V1beta1RouteSpecForProviderSpecGrpcRoute? GrpcRoute { get; set; }

    /// <summary>HTTP/2 routing information for the route.</summary>
    [JsonPropertyName("http2Route")]
    public V1beta1RouteSpecForProviderSpecHttp2Route? Http2Route { get; set; }

    /// <summary>HTTP routing information for the route.</summary>
    [JsonPropertyName("httpRoute")]
    public V1beta1RouteSpecForProviderSpecHttpRoute? HttpRoute { get; set; }

    /// <summary>Priority for the route, between 0 and 1000. Routes are matched based on the specified value, where 0 is the highest priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>TCP routing information for the route.</summary>
    [JsonPropertyName("tcpRoute")]
    public V1beta1RouteSpecForProviderSpecTcpRoute? TcpRoute { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderVirtualRouterNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a VirtualRouter in appmesh to populate virtualRouterName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderVirtualRouterNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouteSpecForProviderVirtualRouterNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderVirtualRouterNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a VirtualRouter in appmesh to populate virtualRouterName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProviderVirtualRouterNameSelector
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
    public V1beta1RouteSpecForProviderVirtualRouterNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecForProvider
{
    /// <summary>Name of the service mesh in which to create the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("meshName")]
    public string? MeshName { get; set; }

    /// <summary>Reference to a Mesh in appmesh to populate meshName.</summary>
    [JsonPropertyName("meshNameRef")]
    public V1beta1RouteSpecForProviderMeshNameRef? MeshNameRef { get; set; }

    /// <summary>Selector for a Mesh in appmesh to populate meshName.</summary>
    [JsonPropertyName("meshNameSelector")]
    public V1beta1RouteSpecForProviderMeshNameSelector? MeshNameSelector { get; set; }

    /// <summary>AWS account ID of the service mesh's owner. Defaults to the account ID the AWS provider is currently connected to.</summary>
    [JsonPropertyName("meshOwner")]
    public string? MeshOwner { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Route specification to apply.</summary>
    [JsonPropertyName("spec")]
    public V1beta1RouteSpecForProviderSpec? Spec { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Name of the virtual router in which to create the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualRouterName")]
    public string? VirtualRouterName { get; set; }

    /// <summary>Reference to a VirtualRouter in appmesh to populate virtualRouterName.</summary>
    [JsonPropertyName("virtualRouterNameRef")]
    public V1beta1RouteSpecForProviderVirtualRouterNameRef? VirtualRouterNameRef { get; set; }

    /// <summary>Selector for a VirtualRouter in appmesh to populate virtualRouterName.</summary>
    [JsonPropertyName("virtualRouterNameSelector")]
    public V1beta1RouteSpecForProviderVirtualRouterNameSelector? VirtualRouterNameSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderMeshNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a Mesh in appmesh to populate meshName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderMeshNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouteSpecInitProviderMeshNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderMeshNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a Mesh in appmesh to populate meshName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderMeshNameSelector
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
    public V1beta1RouteSpecInitProviderMeshNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecGrpcRouteActionWeightedTarget
{
    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual node to associate with the weighted target. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualNode")]
    public string? VirtualNode { get; set; }

    /// <summary>Relative weight of the weighted target. An integer between 0 and 100.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecGrpcRouteAction
{
    /// <summary>Targets that traffic is routed to when a request matches the route. You can specify one or more targets and their relative weights with which to distribute traffic.</summary>
    [JsonPropertyName("weightedTarget")]
    public IList<V1beta1RouteSpecInitProviderSpecGrpcRouteActionWeightedTarget>? WeightedTarget { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecGrpcRouteMatchMetadataMatchRange
{
    /// <summary>End of the range.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>(Requited) Start of the range.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecGrpcRouteMatchMetadataMatch
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
    [JsonPropertyName("range")]
    public V1beta1RouteSpecInitProviderSpecGrpcRouteMatchMetadataMatchRange? Range { get; set; }

    /// <summary>Value sent by the client must include the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Value sent by the client must end with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecGrpcRouteMatchMetadata
{
    /// <summary>If true, the match is on the opposite of the match criteria. Default is false.</summary>
    [JsonPropertyName("invert")]
    public bool? Invert { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1RouteSpecInitProviderSpecGrpcRouteMatchMetadataMatch? Match { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecGrpcRouteMatch
{
    /// <summary>Data to match from the gRPC request.</summary>
    [JsonPropertyName("metadata")]
    public IList<V1beta1RouteSpecInitProviderSpecGrpcRouteMatchMetadata>? Metadata { get; set; }

    /// <summary>Method name to match from the request. If you specify a name, you must also specify a service_name.</summary>
    [JsonPropertyName("methodName")]
    public string? MethodName { get; set; }

    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Fully qualified domain name for the service to match from the request.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Per-retry timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecGrpcRouteRetryPolicyPerRetryTimeout
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Retry policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecGrpcRouteRetryPolicy
{
    /// <summary>List of gRPC retry events. Valid values: cancelled, deadline-exceeded, internal, resource-exhausted, unavailable.</summary>
    [JsonPropertyName("grpcRetryEvents")]
    public IList<string>? GrpcRetryEvents { get; set; }

    /// <summary>List of HTTP retry events. Valid values: client-error (HTTP status code 409), gateway-error (HTTP status codes 502, 503, and 504), server-error (HTTP status codes 500, 501, 502, 503, 504, 505, 506, 507, 508, 510, and 511), stream-error (retry on refused stream).</summary>
    [JsonPropertyName("httpRetryEvents")]
    public IList<string>? HttpRetryEvents { get; set; }

    /// <summary>Maximum number of retries.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>Per-retry timeout.</summary>
    [JsonPropertyName("perRetryTimeout")]
    public V1beta1RouteSpecInitProviderSpecGrpcRouteRetryPolicyPerRetryTimeout? PerRetryTimeout { get; set; }

    /// <summary>List of TCP retry events. The only valid value is connection-error.</summary>
    [JsonPropertyName("tcpRetryEvents")]
    public IList<string>? TcpRetryEvents { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecGrpcRouteTimeoutIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Per request timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecGrpcRouteTimeoutPerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Types of timeouts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecGrpcRouteTimeout
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta1RouteSpecInitProviderSpecGrpcRouteTimeoutIdle? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public V1beta1RouteSpecInitProviderSpecGrpcRouteTimeoutPerRequest? PerRequest { get; set; }
}
#nullable disable

#nullable enable
/// <summary>GRPC routing information for the route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecGrpcRoute
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta1RouteSpecInitProviderSpecGrpcRouteAction? Action { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1RouteSpecInitProviderSpecGrpcRouteMatch? Match { get; set; }

    /// <summary>Retry policy.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta1RouteSpecInitProviderSpecGrpcRouteRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Types of timeouts.</summary>
    [JsonPropertyName("timeout")]
    public V1beta1RouteSpecInitProviderSpecGrpcRouteTimeout? Timeout { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttp2RouteActionWeightedTarget
{
    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual node to associate with the weighted target. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualNode")]
    public string? VirtualNode { get; set; }

    /// <summary>Relative weight of the weighted target. An integer between 0 and 100.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttp2RouteAction
{
    /// <summary>Targets that traffic is routed to when a request matches the route. You can specify one or more targets and their relative weights with which to distribute traffic.</summary>
    [JsonPropertyName("weightedTarget")]
    public IList<V1beta1RouteSpecInitProviderSpecHttp2RouteActionWeightedTarget>? WeightedTarget { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttp2RouteMatchHeaderMatchRange
{
    /// <summary>End of the range.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>(Requited) Start of the range.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttp2RouteMatchHeaderMatch
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
    [JsonPropertyName("range")]
    public V1beta1RouteSpecInitProviderSpecHttp2RouteMatchHeaderMatchRange? Range { get; set; }

    /// <summary>Value sent by the client must include the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Value sent by the client must end with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttp2RouteMatchHeader
{
    /// <summary>If true, the match is on the opposite of the match criteria. Default is false.</summary>
    [JsonPropertyName("invert")]
    public bool? Invert { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1RouteSpecInitProviderSpecHttp2RouteMatchHeaderMatch? Match { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Client request path to match on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttp2RouteMatchPath
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Value sent by the client must include the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttp2RouteMatchQueryParameterMatch
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttp2RouteMatchQueryParameter
{
    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1RouteSpecInitProviderSpecHttp2RouteMatchQueryParameterMatch? Match { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttp2RouteMatch
{
    /// <summary>Client request headers to match on.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1RouteSpecInitProviderSpecHttp2RouteMatchHeader>? Header { get; set; }

    /// <summary>Client request header method to match on. Valid values: GET, HEAD, POST, PUT, DELETE, CONNECT, OPTIONS, TRACE, PATCH.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Client request path to match on.</summary>
    [JsonPropertyName("path")]
    public V1beta1RouteSpecInitProviderSpecHttp2RouteMatchPath? Path { get; set; }

    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Client request query parameters to match on.</summary>
    [JsonPropertyName("queryParameter")]
    public IList<V1beta1RouteSpecInitProviderSpecHttp2RouteMatchQueryParameter>? QueryParameter { get; set; }

    /// <summary>Client request header scheme to match on. Valid values: http, https.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Per-retry timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttp2RouteRetryPolicyPerRetryTimeout
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Retry policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttp2RouteRetryPolicy
{
    /// <summary>List of HTTP retry events. Valid values: client-error (HTTP status code 409), gateway-error (HTTP status codes 502, 503, and 504), server-error (HTTP status codes 500, 501, 502, 503, 504, 505, 506, 507, 508, 510, and 511), stream-error (retry on refused stream).</summary>
    [JsonPropertyName("httpRetryEvents")]
    public IList<string>? HttpRetryEvents { get; set; }

    /// <summary>Maximum number of retries.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>Per-retry timeout.</summary>
    [JsonPropertyName("perRetryTimeout")]
    public V1beta1RouteSpecInitProviderSpecHttp2RouteRetryPolicyPerRetryTimeout? PerRetryTimeout { get; set; }

    /// <summary>List of TCP retry events. The only valid value is connection-error.</summary>
    [JsonPropertyName("tcpRetryEvents")]
    public IList<string>? TcpRetryEvents { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttp2RouteTimeoutIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Per request timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttp2RouteTimeoutPerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Types of timeouts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttp2RouteTimeout
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta1RouteSpecInitProviderSpecHttp2RouteTimeoutIdle? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public V1beta1RouteSpecInitProviderSpecHttp2RouteTimeoutPerRequest? PerRequest { get; set; }
}
#nullable disable

#nullable enable
/// <summary>HTTP/2 routing information for the route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttp2Route
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta1RouteSpecInitProviderSpecHttp2RouteAction? Action { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1RouteSpecInitProviderSpecHttp2RouteMatch? Match { get; set; }

    /// <summary>Retry policy.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta1RouteSpecInitProviderSpecHttp2RouteRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Types of timeouts.</summary>
    [JsonPropertyName("timeout")]
    public V1beta1RouteSpecInitProviderSpecHttp2RouteTimeout? Timeout { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttpRouteActionWeightedTargetVirtualNodeRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a VirtualNode in appmesh to populate virtualNode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttpRouteActionWeightedTargetVirtualNodeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouteSpecInitProviderSpecHttpRouteActionWeightedTargetVirtualNodeRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttpRouteActionWeightedTargetVirtualNodeSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a VirtualNode in appmesh to populate virtualNode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttpRouteActionWeightedTargetVirtualNodeSelector
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
    public V1beta1RouteSpecInitProviderSpecHttpRouteActionWeightedTargetVirtualNodeSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttpRouteActionWeightedTarget
{
    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual node to associate with the weighted target. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualNode")]
    public string? VirtualNode { get; set; }

    /// <summary>Reference to a VirtualNode in appmesh to populate virtualNode.</summary>
    [JsonPropertyName("virtualNodeRef")]
    public V1beta1RouteSpecInitProviderSpecHttpRouteActionWeightedTargetVirtualNodeRef? VirtualNodeRef { get; set; }

    /// <summary>Selector for a VirtualNode in appmesh to populate virtualNode.</summary>
    [JsonPropertyName("virtualNodeSelector")]
    public V1beta1RouteSpecInitProviderSpecHttpRouteActionWeightedTargetVirtualNodeSelector? VirtualNodeSelector { get; set; }

    /// <summary>Relative weight of the weighted target. An integer between 0 and 100.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttpRouteAction
{
    /// <summary>Targets that traffic is routed to when a request matches the route. You can specify one or more targets and their relative weights with which to distribute traffic.</summary>
    [JsonPropertyName("weightedTarget")]
    public IList<V1beta1RouteSpecInitProviderSpecHttpRouteActionWeightedTarget>? WeightedTarget { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttpRouteMatchHeaderMatchRange
{
    /// <summary>End of the range.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>(Requited) Start of the range.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttpRouteMatchHeaderMatch
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
    [JsonPropertyName("range")]
    public V1beta1RouteSpecInitProviderSpecHttpRouteMatchHeaderMatchRange? Range { get; set; }

    /// <summary>Value sent by the client must include the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Value sent by the client must end with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttpRouteMatchHeader
{
    /// <summary>If true, the match is on the opposite of the match criteria. Default is false.</summary>
    [JsonPropertyName("invert")]
    public bool? Invert { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1RouteSpecInitProviderSpecHttpRouteMatchHeaderMatch? Match { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Client request path to match on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttpRouteMatchPath
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Value sent by the client must include the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttpRouteMatchQueryParameterMatch
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttpRouteMatchQueryParameter
{
    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1RouteSpecInitProviderSpecHttpRouteMatchQueryParameterMatch? Match { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttpRouteMatch
{
    /// <summary>Client request headers to match on.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1RouteSpecInitProviderSpecHttpRouteMatchHeader>? Header { get; set; }

    /// <summary>Client request header method to match on. Valid values: GET, HEAD, POST, PUT, DELETE, CONNECT, OPTIONS, TRACE, PATCH.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Client request path to match on.</summary>
    [JsonPropertyName("path")]
    public V1beta1RouteSpecInitProviderSpecHttpRouteMatchPath? Path { get; set; }

    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Client request query parameters to match on.</summary>
    [JsonPropertyName("queryParameter")]
    public IList<V1beta1RouteSpecInitProviderSpecHttpRouteMatchQueryParameter>? QueryParameter { get; set; }

    /// <summary>Client request header scheme to match on. Valid values: http, https.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Per-retry timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttpRouteRetryPolicyPerRetryTimeout
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Retry policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttpRouteRetryPolicy
{
    /// <summary>List of HTTP retry events. Valid values: client-error (HTTP status code 409), gateway-error (HTTP status codes 502, 503, and 504), server-error (HTTP status codes 500, 501, 502, 503, 504, 505, 506, 507, 508, 510, and 511), stream-error (retry on refused stream).</summary>
    [JsonPropertyName("httpRetryEvents")]
    public IList<string>? HttpRetryEvents { get; set; }

    /// <summary>Maximum number of retries.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>Per-retry timeout.</summary>
    [JsonPropertyName("perRetryTimeout")]
    public V1beta1RouteSpecInitProviderSpecHttpRouteRetryPolicyPerRetryTimeout? PerRetryTimeout { get; set; }

    /// <summary>List of TCP retry events. The only valid value is connection-error.</summary>
    [JsonPropertyName("tcpRetryEvents")]
    public IList<string>? TcpRetryEvents { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttpRouteTimeoutIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Per request timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttpRouteTimeoutPerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Types of timeouts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttpRouteTimeout
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta1RouteSpecInitProviderSpecHttpRouteTimeoutIdle? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public V1beta1RouteSpecInitProviderSpecHttpRouteTimeoutPerRequest? PerRequest { get; set; }
}
#nullable disable

#nullable enable
/// <summary>HTTP routing information for the route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecHttpRoute
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta1RouteSpecInitProviderSpecHttpRouteAction? Action { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1RouteSpecInitProviderSpecHttpRouteMatch? Match { get; set; }

    /// <summary>Retry policy.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta1RouteSpecInitProviderSpecHttpRouteRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Types of timeouts.</summary>
    [JsonPropertyName("timeout")]
    public V1beta1RouteSpecInitProviderSpecHttpRouteTimeout? Timeout { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecTcpRouteActionWeightedTargetVirtualNodeRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a VirtualNode in appmesh to populate virtualNode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecTcpRouteActionWeightedTargetVirtualNodeRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouteSpecInitProviderSpecTcpRouteActionWeightedTargetVirtualNodeRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecTcpRouteActionWeightedTargetVirtualNodeSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a VirtualNode in appmesh to populate virtualNode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecTcpRouteActionWeightedTargetVirtualNodeSelector
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
    public V1beta1RouteSpecInitProviderSpecTcpRouteActionWeightedTargetVirtualNodeSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecTcpRouteActionWeightedTarget
{
    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual node to associate with the weighted target. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualNode")]
    public string? VirtualNode { get; set; }

    /// <summary>Reference to a VirtualNode in appmesh to populate virtualNode.</summary>
    [JsonPropertyName("virtualNodeRef")]
    public V1beta1RouteSpecInitProviderSpecTcpRouteActionWeightedTargetVirtualNodeRef? VirtualNodeRef { get; set; }

    /// <summary>Selector for a VirtualNode in appmesh to populate virtualNode.</summary>
    [JsonPropertyName("virtualNodeSelector")]
    public V1beta1RouteSpecInitProviderSpecTcpRouteActionWeightedTargetVirtualNodeSelector? VirtualNodeSelector { get; set; }

    /// <summary>Relative weight of the weighted target. An integer between 0 and 100.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecTcpRouteAction
{
    /// <summary>Targets that traffic is routed to when a request matches the route. You can specify one or more targets and their relative weights with which to distribute traffic.</summary>
    [JsonPropertyName("weightedTarget")]
    public IList<V1beta1RouteSpecInitProviderSpecTcpRouteActionWeightedTarget>? WeightedTarget { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecTcpRouteMatch
{
    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecTcpRouteTimeoutIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Types of timeouts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecTcpRouteTimeout
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta1RouteSpecInitProviderSpecTcpRouteTimeoutIdle? Idle { get; set; }
}
#nullable disable

#nullable enable
/// <summary>TCP routing information for the route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpecTcpRoute
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta1RouteSpecInitProviderSpecTcpRouteAction? Action { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1RouteSpecInitProviderSpecTcpRouteMatch? Match { get; set; }

    /// <summary>Types of timeouts.</summary>
    [JsonPropertyName("timeout")]
    public V1beta1RouteSpecInitProviderSpecTcpRouteTimeout? Timeout { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Route specification to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderSpec
{
    /// <summary>GRPC routing information for the route.</summary>
    [JsonPropertyName("grpcRoute")]
    public V1beta1RouteSpecInitProviderSpecGrpcRoute? GrpcRoute { get; set; }

    /// <summary>HTTP/2 routing information for the route.</summary>
    [JsonPropertyName("http2Route")]
    public V1beta1RouteSpecInitProviderSpecHttp2Route? Http2Route { get; set; }

    /// <summary>HTTP routing information for the route.</summary>
    [JsonPropertyName("httpRoute")]
    public V1beta1RouteSpecInitProviderSpecHttpRoute? HttpRoute { get; set; }

    /// <summary>Priority for the route, between 0 and 1000. Routes are matched based on the specified value, where 0 is the highest priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>TCP routing information for the route.</summary>
    [JsonPropertyName("tcpRoute")]
    public V1beta1RouteSpecInitProviderSpecTcpRoute? TcpRoute { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderVirtualRouterNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Reference to a VirtualRouter in appmesh to populate virtualRouterName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderVirtualRouterNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1RouteSpecInitProviderVirtualRouterNameRefPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderVirtualRouterNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Selector for a VirtualRouter in appmesh to populate virtualRouterName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProviderVirtualRouterNameSelector
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
    public V1beta1RouteSpecInitProviderVirtualRouterNameSelectorPolicy? Policy { get; set; }
}
#nullable disable

#nullable enable
/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecInitProvider
{
    /// <summary>Name of the service mesh in which to create the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("meshName")]
    public string? MeshName { get; set; }

    /// <summary>Reference to a Mesh in appmesh to populate meshName.</summary>
    [JsonPropertyName("meshNameRef")]
    public V1beta1RouteSpecInitProviderMeshNameRef? MeshNameRef { get; set; }

    /// <summary>Selector for a Mesh in appmesh to populate meshName.</summary>
    [JsonPropertyName("meshNameSelector")]
    public V1beta1RouteSpecInitProviderMeshNameSelector? MeshNameSelector { get; set; }

    /// <summary>AWS account ID of the service mesh's owner. Defaults to the account ID the AWS provider is currently connected to.</summary>
    [JsonPropertyName("meshOwner")]
    public string? MeshOwner { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Route specification to apply.</summary>
    [JsonPropertyName("spec")]
    public V1beta1RouteSpecInitProviderSpec? Spec { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Name of the virtual router in which to create the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualRouterName")]
    public string? VirtualRouterName { get; set; }

    /// <summary>Reference to a VirtualRouter in appmesh to populate virtualRouterName.</summary>
    [JsonPropertyName("virtualRouterNameRef")]
    public V1beta1RouteSpecInitProviderVirtualRouterNameRef? VirtualRouterNameRef { get; set; }

    /// <summary>Selector for a VirtualRouter in appmesh to populate virtualRouterName.</summary>
    [JsonPropertyName("virtualRouterNameSelector")]
    public V1beta1RouteSpecInitProviderVirtualRouterNameSelector? VirtualRouterNameSelector { get; set; }
}
#nullable disable

#nullable enable
/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>RouteSpec defines the desired state of Route</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1RouteSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1RouteSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1RouteSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1RouteSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecGrpcRouteActionWeightedTarget
{
    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual node to associate with the weighted target. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualNode")]
    public string? VirtualNode { get; set; }

    /// <summary>Relative weight of the weighted target. An integer between 0 and 100.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecGrpcRouteAction
{
    /// <summary>Targets that traffic is routed to when a request matches the route. You can specify one or more targets and their relative weights with which to distribute traffic.</summary>
    [JsonPropertyName("weightedTarget")]
    public IList<V1beta1RouteStatusAtProviderSpecGrpcRouteActionWeightedTarget>? WeightedTarget { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecGrpcRouteMatchMetadataMatchRange
{
    /// <summary>End of the range.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>(Requited) Start of the range.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecGrpcRouteMatchMetadataMatch
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
    [JsonPropertyName("range")]
    public V1beta1RouteStatusAtProviderSpecGrpcRouteMatchMetadataMatchRange? Range { get; set; }

    /// <summary>Value sent by the client must include the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Value sent by the client must end with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecGrpcRouteMatchMetadata
{
    /// <summary>If true, the match is on the opposite of the match criteria. Default is false.</summary>
    [JsonPropertyName("invert")]
    public bool? Invert { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1RouteStatusAtProviderSpecGrpcRouteMatchMetadataMatch? Match { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecGrpcRouteMatch
{
    /// <summary>Data to match from the gRPC request.</summary>
    [JsonPropertyName("metadata")]
    public IList<V1beta1RouteStatusAtProviderSpecGrpcRouteMatchMetadata>? Metadata { get; set; }

    /// <summary>Method name to match from the request. If you specify a name, you must also specify a service_name.</summary>
    [JsonPropertyName("methodName")]
    public string? MethodName { get; set; }

    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Fully qualified domain name for the service to match from the request.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Per-retry timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecGrpcRouteRetryPolicyPerRetryTimeout
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Retry policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecGrpcRouteRetryPolicy
{
    /// <summary>List of gRPC retry events. Valid values: cancelled, deadline-exceeded, internal, resource-exhausted, unavailable.</summary>
    [JsonPropertyName("grpcRetryEvents")]
    public IList<string>? GrpcRetryEvents { get; set; }

    /// <summary>List of HTTP retry events. Valid values: client-error (HTTP status code 409), gateway-error (HTTP status codes 502, 503, and 504), server-error (HTTP status codes 500, 501, 502, 503, 504, 505, 506, 507, 508, 510, and 511), stream-error (retry on refused stream).</summary>
    [JsonPropertyName("httpRetryEvents")]
    public IList<string>? HttpRetryEvents { get; set; }

    /// <summary>Maximum number of retries.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>Per-retry timeout.</summary>
    [JsonPropertyName("perRetryTimeout")]
    public V1beta1RouteStatusAtProviderSpecGrpcRouteRetryPolicyPerRetryTimeout? PerRetryTimeout { get; set; }

    /// <summary>List of TCP retry events. The only valid value is connection-error.</summary>
    [JsonPropertyName("tcpRetryEvents")]
    public IList<string>? TcpRetryEvents { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecGrpcRouteTimeoutIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Per request timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecGrpcRouteTimeoutPerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Types of timeouts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecGrpcRouteTimeout
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta1RouteStatusAtProviderSpecGrpcRouteTimeoutIdle? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public V1beta1RouteStatusAtProviderSpecGrpcRouteTimeoutPerRequest? PerRequest { get; set; }
}
#nullable disable

#nullable enable
/// <summary>GRPC routing information for the route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecGrpcRoute
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta1RouteStatusAtProviderSpecGrpcRouteAction? Action { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1RouteStatusAtProviderSpecGrpcRouteMatch? Match { get; set; }

    /// <summary>Retry policy.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta1RouteStatusAtProviderSpecGrpcRouteRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Types of timeouts.</summary>
    [JsonPropertyName("timeout")]
    public V1beta1RouteStatusAtProviderSpecGrpcRouteTimeout? Timeout { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecHttp2RouteActionWeightedTarget
{
    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual node to associate with the weighted target. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualNode")]
    public string? VirtualNode { get; set; }

    /// <summary>Relative weight of the weighted target. An integer between 0 and 100.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecHttp2RouteAction
{
    /// <summary>Targets that traffic is routed to when a request matches the route. You can specify one or more targets and their relative weights with which to distribute traffic.</summary>
    [JsonPropertyName("weightedTarget")]
    public IList<V1beta1RouteStatusAtProviderSpecHttp2RouteActionWeightedTarget>? WeightedTarget { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecHttp2RouteMatchHeaderMatchRange
{
    /// <summary>End of the range.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>(Requited) Start of the range.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecHttp2RouteMatchHeaderMatch
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
    [JsonPropertyName("range")]
    public V1beta1RouteStatusAtProviderSpecHttp2RouteMatchHeaderMatchRange? Range { get; set; }

    /// <summary>Value sent by the client must include the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Value sent by the client must end with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecHttp2RouteMatchHeader
{
    /// <summary>If true, the match is on the opposite of the match criteria. Default is false.</summary>
    [JsonPropertyName("invert")]
    public bool? Invert { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1RouteStatusAtProviderSpecHttp2RouteMatchHeaderMatch? Match { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Client request path to match on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecHttp2RouteMatchPath
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Value sent by the client must include the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecHttp2RouteMatchQueryParameterMatch
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecHttp2RouteMatchQueryParameter
{
    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1RouteStatusAtProviderSpecHttp2RouteMatchQueryParameterMatch? Match { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecHttp2RouteMatch
{
    /// <summary>Client request headers to match on.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1RouteStatusAtProviderSpecHttp2RouteMatchHeader>? Header { get; set; }

    /// <summary>Client request header method to match on. Valid values: GET, HEAD, POST, PUT, DELETE, CONNECT, OPTIONS, TRACE, PATCH.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Client request path to match on.</summary>
    [JsonPropertyName("path")]
    public V1beta1RouteStatusAtProviderSpecHttp2RouteMatchPath? Path { get; set; }

    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Client request query parameters to match on.</summary>
    [JsonPropertyName("queryParameter")]
    public IList<V1beta1RouteStatusAtProviderSpecHttp2RouteMatchQueryParameter>? QueryParameter { get; set; }

    /// <summary>Client request header scheme to match on. Valid values: http, https.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Per-retry timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecHttp2RouteRetryPolicyPerRetryTimeout
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Retry policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecHttp2RouteRetryPolicy
{
    /// <summary>List of HTTP retry events. Valid values: client-error (HTTP status code 409), gateway-error (HTTP status codes 502, 503, and 504), server-error (HTTP status codes 500, 501, 502, 503, 504, 505, 506, 507, 508, 510, and 511), stream-error (retry on refused stream).</summary>
    [JsonPropertyName("httpRetryEvents")]
    public IList<string>? HttpRetryEvents { get; set; }

    /// <summary>Maximum number of retries.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>Per-retry timeout.</summary>
    [JsonPropertyName("perRetryTimeout")]
    public V1beta1RouteStatusAtProviderSpecHttp2RouteRetryPolicyPerRetryTimeout? PerRetryTimeout { get; set; }

    /// <summary>List of TCP retry events. The only valid value is connection-error.</summary>
    [JsonPropertyName("tcpRetryEvents")]
    public IList<string>? TcpRetryEvents { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecHttp2RouteTimeoutIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Per request timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecHttp2RouteTimeoutPerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Types of timeouts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecHttp2RouteTimeout
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta1RouteStatusAtProviderSpecHttp2RouteTimeoutIdle? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public V1beta1RouteStatusAtProviderSpecHttp2RouteTimeoutPerRequest? PerRequest { get; set; }
}
#nullable disable

#nullable enable
/// <summary>HTTP/2 routing information for the route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecHttp2Route
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta1RouteStatusAtProviderSpecHttp2RouteAction? Action { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1RouteStatusAtProviderSpecHttp2RouteMatch? Match { get; set; }

    /// <summary>Retry policy.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta1RouteStatusAtProviderSpecHttp2RouteRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Types of timeouts.</summary>
    [JsonPropertyName("timeout")]
    public V1beta1RouteStatusAtProviderSpecHttp2RouteTimeout? Timeout { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecHttpRouteActionWeightedTarget
{
    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual node to associate with the weighted target. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualNode")]
    public string? VirtualNode { get; set; }

    /// <summary>Relative weight of the weighted target. An integer between 0 and 100.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecHttpRouteAction
{
    /// <summary>Targets that traffic is routed to when a request matches the route. You can specify one or more targets and their relative weights with which to distribute traffic.</summary>
    [JsonPropertyName("weightedTarget")]
    public IList<V1beta1RouteStatusAtProviderSpecHttpRouteActionWeightedTarget>? WeightedTarget { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecHttpRouteMatchHeaderMatchRange
{
    /// <summary>End of the range.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>(Requited) Start of the range.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecHttpRouteMatchHeaderMatch
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Object that specifies the range of numbers that the value sent by the client must be included in.</summary>
    [JsonPropertyName("range")]
    public V1beta1RouteStatusAtProviderSpecHttpRouteMatchHeaderMatchRange? Range { get; set; }

    /// <summary>Value sent by the client must include the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Value sent by the client must end with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecHttpRouteMatchHeader
{
    /// <summary>If true, the match is on the opposite of the match criteria. Default is false.</summary>
    [JsonPropertyName("invert")]
    public bool? Invert { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1RouteStatusAtProviderSpecHttpRouteMatchHeaderMatch? Match { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Client request path to match on.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecHttpRouteMatchPath
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Value sent by the client must include the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecHttpRouteMatchQueryParameterMatch
{
    /// <summary>Value sent by the client must match the specified value exactly. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecHttpRouteMatchQueryParameter
{
    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1RouteStatusAtProviderSpecHttpRouteMatchQueryParameterMatch? Match { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecHttpRouteMatch
{
    /// <summary>Client request headers to match on.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1RouteStatusAtProviderSpecHttpRouteMatchHeader>? Header { get; set; }

    /// <summary>Client request header method to match on. Valid values: GET, HEAD, POST, PUT, DELETE, CONNECT, OPTIONS, TRACE, PATCH.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>Client request path to match on.</summary>
    [JsonPropertyName("path")]
    public V1beta1RouteStatusAtProviderSpecHttpRouteMatchPath? Path { get; set; }

    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Value sent by the client must begin with the specified characters. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Client request query parameters to match on.</summary>
    [JsonPropertyName("queryParameter")]
    public IList<V1beta1RouteStatusAtProviderSpecHttpRouteMatchQueryParameter>? QueryParameter { get; set; }

    /// <summary>Client request header scheme to match on. Valid values: http, https.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Per-retry timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecHttpRouteRetryPolicyPerRetryTimeout
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Retry policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecHttpRouteRetryPolicy
{
    /// <summary>List of HTTP retry events. Valid values: client-error (HTTP status code 409), gateway-error (HTTP status codes 502, 503, and 504), server-error (HTTP status codes 500, 501, 502, 503, 504, 505, 506, 507, 508, 510, and 511), stream-error (retry on refused stream).</summary>
    [JsonPropertyName("httpRetryEvents")]
    public IList<string>? HttpRetryEvents { get; set; }

    /// <summary>Maximum number of retries.</summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>Per-retry timeout.</summary>
    [JsonPropertyName("perRetryTimeout")]
    public V1beta1RouteStatusAtProviderSpecHttpRouteRetryPolicyPerRetryTimeout? PerRetryTimeout { get; set; }

    /// <summary>List of TCP retry events. The only valid value is connection-error.</summary>
    [JsonPropertyName("tcpRetryEvents")]
    public IList<string>? TcpRetryEvents { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecHttpRouteTimeoutIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Per request timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecHttpRouteTimeoutPerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Types of timeouts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecHttpRouteTimeout
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta1RouteStatusAtProviderSpecHttpRouteTimeoutIdle? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public V1beta1RouteStatusAtProviderSpecHttpRouteTimeoutPerRequest? PerRequest { get; set; }
}
#nullable disable

#nullable enable
/// <summary>HTTP routing information for the route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecHttpRoute
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta1RouteStatusAtProviderSpecHttpRouteAction? Action { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1RouteStatusAtProviderSpecHttpRouteMatch? Match { get; set; }

    /// <summary>Retry policy.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta1RouteStatusAtProviderSpecHttpRouteRetryPolicy? RetryPolicy { get; set; }

    /// <summary>Types of timeouts.</summary>
    [JsonPropertyName("timeout")]
    public V1beta1RouteStatusAtProviderSpecHttpRouteTimeout? Timeout { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecTcpRouteActionWeightedTarget
{
    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual node to associate with the weighted target. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualNode")]
    public string? VirtualNode { get; set; }

    /// <summary>Relative weight of the weighted target. An integer between 0 and 100.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecTcpRouteAction
{
    /// <summary>Targets that traffic is routed to when a request matches the route. You can specify one or more targets and their relative weights with which to distribute traffic.</summary>
    [JsonPropertyName("weightedTarget")]
    public IList<V1beta1RouteStatusAtProviderSpecTcpRouteActionWeightedTarget>? WeightedTarget { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Criteria for determining an gRPC request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecTcpRouteMatch
{
    /// <summary>The port number to match from the request.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecTcpRouteTimeoutIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>Number of time units. Minimum value of 0.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Types of timeouts.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecTcpRouteTimeout
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta1RouteStatusAtProviderSpecTcpRouteTimeoutIdle? Idle { get; set; }
}
#nullable disable

#nullable enable
/// <summary>TCP routing information for the route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpecTcpRoute
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta1RouteStatusAtProviderSpecTcpRouteAction? Action { get; set; }

    /// <summary>Criteria for determining an gRPC request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1RouteStatusAtProviderSpecTcpRouteMatch? Match { get; set; }

    /// <summary>Types of timeouts.</summary>
    [JsonPropertyName("timeout")]
    public V1beta1RouteStatusAtProviderSpecTcpRouteTimeout? Timeout { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Route specification to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProviderSpec
{
    /// <summary>GRPC routing information for the route.</summary>
    [JsonPropertyName("grpcRoute")]
    public V1beta1RouteStatusAtProviderSpecGrpcRoute? GrpcRoute { get; set; }

    /// <summary>HTTP/2 routing information for the route.</summary>
    [JsonPropertyName("http2Route")]
    public V1beta1RouteStatusAtProviderSpecHttp2Route? Http2Route { get; set; }

    /// <summary>HTTP routing information for the route.</summary>
    [JsonPropertyName("httpRoute")]
    public V1beta1RouteStatusAtProviderSpecHttpRoute? HttpRoute { get; set; }

    /// <summary>Priority for the route, between 0 and 1000. Routes are matched based on the specified value, where 0 is the highest priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>TCP routing information for the route.</summary>
    [JsonPropertyName("tcpRoute")]
    public V1beta1RouteStatusAtProviderSpecTcpRoute? TcpRoute { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusAtProvider
{
    /// <summary>ARN of the route.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Creation date of the route.</summary>
    [JsonPropertyName("createdDate")]
    public string? CreatedDate { get; set; }

    /// <summary>ID of the route.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Last update date of the route.</summary>
    [JsonPropertyName("lastUpdatedDate")]
    public string? LastUpdatedDate { get; set; }

    /// <summary>Name of the service mesh in which to create the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("meshName")]
    public string? MeshName { get; set; }

    /// <summary>AWS account ID of the service mesh's owner. Defaults to the account ID the AWS provider is currently connected to.</summary>
    [JsonPropertyName("meshOwner")]
    public string? MeshOwner { get; set; }

    /// <summary>Name to use for the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Resource owner's AWS account ID.</summary>
    [JsonPropertyName("resourceOwner")]
    public string? ResourceOwner { get; set; }

    /// <summary>Route specification to apply.</summary>
    [JsonPropertyName("spec")]
    public V1beta1RouteStatusAtProviderSpec? Spec { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Name of the virtual router in which to create the route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualRouterName")]
    public string? VirtualRouterName { get; set; }
}
#nullable disable

#nullable enable
/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatusConditions
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
#nullable disable

#nullable enable
/// <summary>RouteStatus defines the observed state of Route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RouteStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1RouteStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RouteStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Route is the Schema for the Routes API. Provides an AWS App Mesh route resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Route : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RouteSpec>, IStatus<V1beta1RouteStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Route";
    public const string KubeGroup = "appmesh.aws.m.upbound.io";
    public const string KubePluralName = "routes";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RouteSpec defines the desired state of Route</summary>
    [JsonPropertyName("spec")]
    public V1beta1RouteSpec Spec { get; set; }

    /// <summary>RouteStatus defines the observed state of Route.</summary>
    [JsonPropertyName("status")]
    public V1beta1RouteStatus? Status { get; set; }
}
#nullable disable
