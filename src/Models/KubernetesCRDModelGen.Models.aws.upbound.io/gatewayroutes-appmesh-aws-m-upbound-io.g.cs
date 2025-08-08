using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appmesh.aws.m.upbound.io;
/// <summary>Virtual service gateway route target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecGrpcRouteActionTargetVirtualService
{
    /// <summary>Name of the virtual service that traffic is routed to. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualServiceName")]
    public string? VirtualServiceName { get; set; }
}

/// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecGrpcRouteActionTarget
{
    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual service gateway route target.</summary>
    [JsonPropertyName("virtualService")]
    public V1beta1GatewayRouteSpecForProviderSpecGrpcRouteActionTargetVirtualService? VirtualService { get; set; }
}

/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecGrpcRouteAction
{
    /// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
    [JsonPropertyName("target")]
    public V1beta1GatewayRouteSpecForProviderSpecGrpcRouteActionTarget? Target { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecGrpcRouteMatch
{
    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Fully qualified domain name for the service to match from the request.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>Specification of a gRPC gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecGrpcRoute
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta1GatewayRouteSpecForProviderSpecGrpcRouteAction? Action { get; set; }

    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1GatewayRouteSpecForProviderSpecGrpcRouteMatch? Match { get; set; }
}

/// <summary>Host name to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttp2RouteActionRewriteHostname
{
    /// <summary>Default target host name to write to. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("defaultTargetHostname")]
    public string? DefaultTargetHostname { get; set; }
}

/// <summary>Exact path to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttp2RouteActionRewritePath
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

/// <summary>Specified beginning characters to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttp2RouteActionRewritePrefix
{
    /// <summary>Default prefix used to replace the incoming route prefix when rewritten. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("defaultPrefix")]
    public string? DefaultPrefix { get; set; }

    /// <summary>Value used to replace the incoming route prefix when rewritten.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Gateway route action to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttp2RouteActionRewrite
{
    /// <summary>Host name to rewrite.</summary>
    [JsonPropertyName("hostname")]
    public V1beta1GatewayRouteSpecForProviderSpecHttp2RouteActionRewriteHostname? Hostname { get; set; }

    /// <summary>Exact path to rewrite.</summary>
    [JsonPropertyName("path")]
    public V1beta1GatewayRouteSpecForProviderSpecHttp2RouteActionRewritePath? Path { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public V1beta1GatewayRouteSpecForProviderSpecHttp2RouteActionRewritePrefix? Prefix { get; set; }
}

/// <summary>Virtual service gateway route target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttp2RouteActionTargetVirtualService
{
    /// <summary>Name of the virtual service that traffic is routed to. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualServiceName")]
    public string? VirtualServiceName { get; set; }
}

/// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttp2RouteActionTarget
{
    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual service gateway route target.</summary>
    [JsonPropertyName("virtualService")]
    public V1beta1GatewayRouteSpecForProviderSpecHttp2RouteActionTargetVirtualService? VirtualService { get; set; }
}

/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttp2RouteAction
{
    /// <summary>Gateway route action to rewrite.</summary>
    [JsonPropertyName("rewrite")]
    public V1beta1GatewayRouteSpecForProviderSpecHttp2RouteActionRewrite? Rewrite { get; set; }

    /// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
    [JsonPropertyName("target")]
    public V1beta1GatewayRouteSpecForProviderSpecHttp2RouteActionTarget? Target { get; set; }
}

/// <summary>Object that specifies the range of numbers that the header value sent by the client must be included in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttp2RouteMatchHeaderMatchRange
{
    /// <summary>End of the range.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>(Requited) Start of the range.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttp2RouteMatchHeaderMatch
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Object that specifies the range of numbers that the header value sent by the client must be included in.</summary>
    [JsonPropertyName("range")]
    public V1beta1GatewayRouteSpecForProviderSpecHttp2RouteMatchHeaderMatchRange? Range { get; set; }

    /// <summary>Header value sent by the client must include the specified characters.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Header value sent by the client must end with the specified characters.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttp2RouteMatchHeader
{
    /// <summary>If true, the match is on the opposite of the match method and value. Default is false.</summary>
    [JsonPropertyName("invert")]
    public bool? Invert { get; set; }

    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1GatewayRouteSpecForProviderSpecHttp2RouteMatchHeaderMatch? Match { get; set; }

    /// <summary>Name to use for the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Host name to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttp2RouteMatchHostname
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Header value sent by the client must end with the specified characters.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>Exact path to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttp2RouteMatchPath
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Header value sent by the client must include the specified characters.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttp2RouteMatchQueryParameterMatch
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttp2RouteMatchQueryParameter
{
    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1GatewayRouteSpecForProviderSpecHttp2RouteMatchQueryParameterMatch? Match { get; set; }

    /// <summary>Name to use for the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttp2RouteMatch
{
    /// <summary>Client request headers to match on.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1GatewayRouteSpecForProviderSpecHttp2RouteMatchHeader>? Header { get; set; }

    /// <summary>Host name to rewrite.</summary>
    [JsonPropertyName("hostname")]
    public V1beta1GatewayRouteSpecForProviderSpecHttp2RouteMatchHostname? Hostname { get; set; }

    /// <summary>Exact path to rewrite.</summary>
    [JsonPropertyName("path")]
    public V1beta1GatewayRouteSpecForProviderSpecHttp2RouteMatchPath? Path { get; set; }

    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Client request query parameters to match on.</summary>
    [JsonPropertyName("queryParameter")]
    public IList<V1beta1GatewayRouteSpecForProviderSpecHttp2RouteMatchQueryParameter>? QueryParameter { get; set; }
}

/// <summary>Specification of an HTTP/2 gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttp2Route
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta1GatewayRouteSpecForProviderSpecHttp2RouteAction? Action { get; set; }

    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1GatewayRouteSpecForProviderSpecHttp2RouteMatch? Match { get; set; }
}

/// <summary>Host name to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttpRouteActionRewriteHostname
{
    /// <summary>Default target host name to write to. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("defaultTargetHostname")]
    public string? DefaultTargetHostname { get; set; }
}

/// <summary>Exact path to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttpRouteActionRewritePath
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

/// <summary>Specified beginning characters to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttpRouteActionRewritePrefix
{
    /// <summary>Default prefix used to replace the incoming route prefix when rewritten. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("defaultPrefix")]
    public string? DefaultPrefix { get; set; }

    /// <summary>Value used to replace the incoming route prefix when rewritten.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Gateway route action to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttpRouteActionRewrite
{
    /// <summary>Host name to rewrite.</summary>
    [JsonPropertyName("hostname")]
    public V1beta1GatewayRouteSpecForProviderSpecHttpRouteActionRewriteHostname? Hostname { get; set; }

    /// <summary>Exact path to rewrite.</summary>
    [JsonPropertyName("path")]
    public V1beta1GatewayRouteSpecForProviderSpecHttpRouteActionRewritePath? Path { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public V1beta1GatewayRouteSpecForProviderSpecHttpRouteActionRewritePrefix? Prefix { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a VirtualService in appmesh to populate virtualServiceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a VirtualService in appmesh to populate virtualServiceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameSelector
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
    public V1beta1GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Virtual service gateway route target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualService
{
    /// <summary>Name of the virtual service that traffic is routed to. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualServiceName")]
    public string? VirtualServiceName { get; set; }

    /// <summary>Reference to a VirtualService in appmesh to populate virtualServiceName.</summary>
    [JsonPropertyName("virtualServiceNameRef")]
    public V1beta1GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameRef? VirtualServiceNameRef { get; set; }

    /// <summary>Selector for a VirtualService in appmesh to populate virtualServiceName.</summary>
    [JsonPropertyName("virtualServiceNameSelector")]
    public V1beta1GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameSelector? VirtualServiceNameSelector { get; set; }
}

/// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttpRouteActionTarget
{
    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual service gateway route target.</summary>
    [JsonPropertyName("virtualService")]
    public V1beta1GatewayRouteSpecForProviderSpecHttpRouteActionTargetVirtualService? VirtualService { get; set; }
}

/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttpRouteAction
{
    /// <summary>Gateway route action to rewrite.</summary>
    [JsonPropertyName("rewrite")]
    public V1beta1GatewayRouteSpecForProviderSpecHttpRouteActionRewrite? Rewrite { get; set; }

    /// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
    [JsonPropertyName("target")]
    public V1beta1GatewayRouteSpecForProviderSpecHttpRouteActionTarget? Target { get; set; }
}

/// <summary>Object that specifies the range of numbers that the header value sent by the client must be included in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttpRouteMatchHeaderMatchRange
{
    /// <summary>End of the range.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>(Requited) Start of the range.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttpRouteMatchHeaderMatch
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Object that specifies the range of numbers that the header value sent by the client must be included in.</summary>
    [JsonPropertyName("range")]
    public V1beta1GatewayRouteSpecForProviderSpecHttpRouteMatchHeaderMatchRange? Range { get; set; }

    /// <summary>Header value sent by the client must include the specified characters.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Header value sent by the client must end with the specified characters.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttpRouteMatchHeader
{
    /// <summary>If true, the match is on the opposite of the match method and value. Default is false.</summary>
    [JsonPropertyName("invert")]
    public bool? Invert { get; set; }

    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1GatewayRouteSpecForProviderSpecHttpRouteMatchHeaderMatch? Match { get; set; }

    /// <summary>Name to use for the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Host name to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttpRouteMatchHostname
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Header value sent by the client must end with the specified characters.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>Exact path to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttpRouteMatchPath
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Header value sent by the client must include the specified characters.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttpRouteMatchQueryParameterMatch
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttpRouteMatchQueryParameter
{
    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1GatewayRouteSpecForProviderSpecHttpRouteMatchQueryParameterMatch? Match { get; set; }

    /// <summary>Name to use for the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttpRouteMatch
{
    /// <summary>Client request headers to match on.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1GatewayRouteSpecForProviderSpecHttpRouteMatchHeader>? Header { get; set; }

    /// <summary>Host name to rewrite.</summary>
    [JsonPropertyName("hostname")]
    public V1beta1GatewayRouteSpecForProviderSpecHttpRouteMatchHostname? Hostname { get; set; }

    /// <summary>Exact path to rewrite.</summary>
    [JsonPropertyName("path")]
    public V1beta1GatewayRouteSpecForProviderSpecHttpRouteMatchPath? Path { get; set; }

    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Client request query parameters to match on.</summary>
    [JsonPropertyName("queryParameter")]
    public IList<V1beta1GatewayRouteSpecForProviderSpecHttpRouteMatchQueryParameter>? QueryParameter { get; set; }
}

/// <summary>Specification of an HTTP gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpecHttpRoute
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta1GatewayRouteSpecForProviderSpecHttpRouteAction? Action { get; set; }

    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1GatewayRouteSpecForProviderSpecHttpRouteMatch? Match { get; set; }
}

/// <summary>Gateway route specification to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderSpec
{
    /// <summary>Specification of a gRPC gateway route.</summary>
    [JsonPropertyName("grpcRoute")]
    public V1beta1GatewayRouteSpecForProviderSpecGrpcRoute? GrpcRoute { get; set; }

    /// <summary>Specification of an HTTP/2 gateway route.</summary>
    [JsonPropertyName("http2Route")]
    public V1beta1GatewayRouteSpecForProviderSpecHttp2Route? Http2Route { get; set; }

    /// <summary>Specification of an HTTP gateway route.</summary>
    [JsonPropertyName("httpRoute")]
    public V1beta1GatewayRouteSpecForProviderSpecHttpRoute? HttpRoute { get; set; }

    /// <summary>Priority for the gateway route, between 0 and 1000.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderVirtualGatewayNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a VirtualGateway in appmesh to populate virtualGatewayName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderVirtualGatewayNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GatewayRouteSpecForProviderVirtualGatewayNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderVirtualGatewayNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a VirtualGateway in appmesh to populate virtualGatewayName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProviderVirtualGatewayNameSelector
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
    public V1beta1GatewayRouteSpecForProviderVirtualGatewayNameSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecForProvider
{
    /// <summary>Name of the service mesh in which to create the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("meshName")]
    public string? MeshName { get; set; }

    /// <summary>AWS account ID of the service mesh's owner. Defaults to the account ID the AWS provider is currently connected to.</summary>
    [JsonPropertyName("meshOwner")]
    public string? MeshOwner { get; set; }

    /// <summary>Name to use for the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }

    /// <summary>Gateway route specification to apply.</summary>
    [JsonPropertyName("spec")]
    public V1beta1GatewayRouteSpecForProviderSpec? Spec { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Name of the virtual gateway to associate the gateway route with. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualGatewayName")]
    public string? VirtualGatewayName { get; set; }

    /// <summary>Reference to a VirtualGateway in appmesh to populate virtualGatewayName.</summary>
    [JsonPropertyName("virtualGatewayNameRef")]
    public V1beta1GatewayRouteSpecForProviderVirtualGatewayNameRef? VirtualGatewayNameRef { get; set; }

    /// <summary>Selector for a VirtualGateway in appmesh to populate virtualGatewayName.</summary>
    [JsonPropertyName("virtualGatewayNameSelector")]
    public V1beta1GatewayRouteSpecForProviderVirtualGatewayNameSelector? VirtualGatewayNameSelector { get; set; }
}

/// <summary>Virtual service gateway route target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecGrpcRouteActionTargetVirtualService
{
    /// <summary>Name of the virtual service that traffic is routed to. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualServiceName")]
    public string? VirtualServiceName { get; set; }
}

/// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecGrpcRouteActionTarget
{
    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual service gateway route target.</summary>
    [JsonPropertyName("virtualService")]
    public V1beta1GatewayRouteSpecInitProviderSpecGrpcRouteActionTargetVirtualService? VirtualService { get; set; }
}

/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecGrpcRouteAction
{
    /// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
    [JsonPropertyName("target")]
    public V1beta1GatewayRouteSpecInitProviderSpecGrpcRouteActionTarget? Target { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecGrpcRouteMatch
{
    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Fully qualified domain name for the service to match from the request.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>Specification of a gRPC gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecGrpcRoute
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta1GatewayRouteSpecInitProviderSpecGrpcRouteAction? Action { get; set; }

    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1GatewayRouteSpecInitProviderSpecGrpcRouteMatch? Match { get; set; }
}

/// <summary>Host name to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttp2RouteActionRewriteHostname
{
    /// <summary>Default target host name to write to. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("defaultTargetHostname")]
    public string? DefaultTargetHostname { get; set; }
}

/// <summary>Exact path to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttp2RouteActionRewritePath
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

/// <summary>Specified beginning characters to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttp2RouteActionRewritePrefix
{
    /// <summary>Default prefix used to replace the incoming route prefix when rewritten. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("defaultPrefix")]
    public string? DefaultPrefix { get; set; }

    /// <summary>Value used to replace the incoming route prefix when rewritten.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Gateway route action to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttp2RouteActionRewrite
{
    /// <summary>Host name to rewrite.</summary>
    [JsonPropertyName("hostname")]
    public V1beta1GatewayRouteSpecInitProviderSpecHttp2RouteActionRewriteHostname? Hostname { get; set; }

    /// <summary>Exact path to rewrite.</summary>
    [JsonPropertyName("path")]
    public V1beta1GatewayRouteSpecInitProviderSpecHttp2RouteActionRewritePath? Path { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public V1beta1GatewayRouteSpecInitProviderSpecHttp2RouteActionRewritePrefix? Prefix { get; set; }
}

/// <summary>Virtual service gateway route target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttp2RouteActionTargetVirtualService
{
    /// <summary>Name of the virtual service that traffic is routed to. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualServiceName")]
    public string? VirtualServiceName { get; set; }
}

/// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttp2RouteActionTarget
{
    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual service gateway route target.</summary>
    [JsonPropertyName("virtualService")]
    public V1beta1GatewayRouteSpecInitProviderSpecHttp2RouteActionTargetVirtualService? VirtualService { get; set; }
}

/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttp2RouteAction
{
    /// <summary>Gateway route action to rewrite.</summary>
    [JsonPropertyName("rewrite")]
    public V1beta1GatewayRouteSpecInitProviderSpecHttp2RouteActionRewrite? Rewrite { get; set; }

    /// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
    [JsonPropertyName("target")]
    public V1beta1GatewayRouteSpecInitProviderSpecHttp2RouteActionTarget? Target { get; set; }
}

/// <summary>Object that specifies the range of numbers that the header value sent by the client must be included in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttp2RouteMatchHeaderMatchRange
{
    /// <summary>End of the range.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>(Requited) Start of the range.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttp2RouteMatchHeaderMatch
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Object that specifies the range of numbers that the header value sent by the client must be included in.</summary>
    [JsonPropertyName("range")]
    public V1beta1GatewayRouteSpecInitProviderSpecHttp2RouteMatchHeaderMatchRange? Range { get; set; }

    /// <summary>Header value sent by the client must include the specified characters.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Header value sent by the client must end with the specified characters.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttp2RouteMatchHeader
{
    /// <summary>If true, the match is on the opposite of the match method and value. Default is false.</summary>
    [JsonPropertyName("invert")]
    public bool? Invert { get; set; }

    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1GatewayRouteSpecInitProviderSpecHttp2RouteMatchHeaderMatch? Match { get; set; }

    /// <summary>Name to use for the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Host name to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttp2RouteMatchHostname
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Header value sent by the client must end with the specified characters.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>Exact path to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttp2RouteMatchPath
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Header value sent by the client must include the specified characters.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttp2RouteMatchQueryParameterMatch
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttp2RouteMatchQueryParameter
{
    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1GatewayRouteSpecInitProviderSpecHttp2RouteMatchQueryParameterMatch? Match { get; set; }

    /// <summary>Name to use for the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttp2RouteMatch
{
    /// <summary>Client request headers to match on.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1GatewayRouteSpecInitProviderSpecHttp2RouteMatchHeader>? Header { get; set; }

    /// <summary>Host name to rewrite.</summary>
    [JsonPropertyName("hostname")]
    public V1beta1GatewayRouteSpecInitProviderSpecHttp2RouteMatchHostname? Hostname { get; set; }

    /// <summary>Exact path to rewrite.</summary>
    [JsonPropertyName("path")]
    public V1beta1GatewayRouteSpecInitProviderSpecHttp2RouteMatchPath? Path { get; set; }

    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Client request query parameters to match on.</summary>
    [JsonPropertyName("queryParameter")]
    public IList<V1beta1GatewayRouteSpecInitProviderSpecHttp2RouteMatchQueryParameter>? QueryParameter { get; set; }
}

/// <summary>Specification of an HTTP/2 gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttp2Route
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta1GatewayRouteSpecInitProviderSpecHttp2RouteAction? Action { get; set; }

    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1GatewayRouteSpecInitProviderSpecHttp2RouteMatch? Match { get; set; }
}

/// <summary>Host name to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttpRouteActionRewriteHostname
{
    /// <summary>Default target host name to write to. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("defaultTargetHostname")]
    public string? DefaultTargetHostname { get; set; }
}

/// <summary>Exact path to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttpRouteActionRewritePath
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

/// <summary>Specified beginning characters to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttpRouteActionRewritePrefix
{
    /// <summary>Default prefix used to replace the incoming route prefix when rewritten. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("defaultPrefix")]
    public string? DefaultPrefix { get; set; }

    /// <summary>Value used to replace the incoming route prefix when rewritten.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Gateway route action to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttpRouteActionRewrite
{
    /// <summary>Host name to rewrite.</summary>
    [JsonPropertyName("hostname")]
    public V1beta1GatewayRouteSpecInitProviderSpecHttpRouteActionRewriteHostname? Hostname { get; set; }

    /// <summary>Exact path to rewrite.</summary>
    [JsonPropertyName("path")]
    public V1beta1GatewayRouteSpecInitProviderSpecHttpRouteActionRewritePath? Path { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public V1beta1GatewayRouteSpecInitProviderSpecHttpRouteActionRewritePrefix? Prefix { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a VirtualService in appmesh to populate virtualServiceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a VirtualService in appmesh to populate virtualServiceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameSelector
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
    public V1beta1GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Virtual service gateway route target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualService
{
    /// <summary>Name of the virtual service that traffic is routed to. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualServiceName")]
    public string? VirtualServiceName { get; set; }

    /// <summary>Reference to a VirtualService in appmesh to populate virtualServiceName.</summary>
    [JsonPropertyName("virtualServiceNameRef")]
    public V1beta1GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameRef? VirtualServiceNameRef { get; set; }

    /// <summary>Selector for a VirtualService in appmesh to populate virtualServiceName.</summary>
    [JsonPropertyName("virtualServiceNameSelector")]
    public V1beta1GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualServiceVirtualServiceNameSelector? VirtualServiceNameSelector { get; set; }
}

/// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttpRouteActionTarget
{
    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual service gateway route target.</summary>
    [JsonPropertyName("virtualService")]
    public V1beta1GatewayRouteSpecInitProviderSpecHttpRouteActionTargetVirtualService? VirtualService { get; set; }
}

/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttpRouteAction
{
    /// <summary>Gateway route action to rewrite.</summary>
    [JsonPropertyName("rewrite")]
    public V1beta1GatewayRouteSpecInitProviderSpecHttpRouteActionRewrite? Rewrite { get; set; }

    /// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
    [JsonPropertyName("target")]
    public V1beta1GatewayRouteSpecInitProviderSpecHttpRouteActionTarget? Target { get; set; }
}

/// <summary>Object that specifies the range of numbers that the header value sent by the client must be included in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttpRouteMatchHeaderMatchRange
{
    /// <summary>End of the range.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>(Requited) Start of the range.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttpRouteMatchHeaderMatch
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Object that specifies the range of numbers that the header value sent by the client must be included in.</summary>
    [JsonPropertyName("range")]
    public V1beta1GatewayRouteSpecInitProviderSpecHttpRouteMatchHeaderMatchRange? Range { get; set; }

    /// <summary>Header value sent by the client must include the specified characters.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Header value sent by the client must end with the specified characters.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttpRouteMatchHeader
{
    /// <summary>If true, the match is on the opposite of the match method and value. Default is false.</summary>
    [JsonPropertyName("invert")]
    public bool? Invert { get; set; }

    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1GatewayRouteSpecInitProviderSpecHttpRouteMatchHeaderMatch? Match { get; set; }

    /// <summary>Name to use for the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Host name to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttpRouteMatchHostname
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Header value sent by the client must end with the specified characters.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>Exact path to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttpRouteMatchPath
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Header value sent by the client must include the specified characters.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttpRouteMatchQueryParameterMatch
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttpRouteMatchQueryParameter
{
    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1GatewayRouteSpecInitProviderSpecHttpRouteMatchQueryParameterMatch? Match { get; set; }

    /// <summary>Name to use for the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttpRouteMatch
{
    /// <summary>Client request headers to match on.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1GatewayRouteSpecInitProviderSpecHttpRouteMatchHeader>? Header { get; set; }

    /// <summary>Host name to rewrite.</summary>
    [JsonPropertyName("hostname")]
    public V1beta1GatewayRouteSpecInitProviderSpecHttpRouteMatchHostname? Hostname { get; set; }

    /// <summary>Exact path to rewrite.</summary>
    [JsonPropertyName("path")]
    public V1beta1GatewayRouteSpecInitProviderSpecHttpRouteMatchPath? Path { get; set; }

    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Client request query parameters to match on.</summary>
    [JsonPropertyName("queryParameter")]
    public IList<V1beta1GatewayRouteSpecInitProviderSpecHttpRouteMatchQueryParameter>? QueryParameter { get; set; }
}

/// <summary>Specification of an HTTP gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpecHttpRoute
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta1GatewayRouteSpecInitProviderSpecHttpRouteAction? Action { get; set; }

    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1GatewayRouteSpecInitProviderSpecHttpRouteMatch? Match { get; set; }
}

/// <summary>Gateway route specification to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderSpec
{
    /// <summary>Specification of a gRPC gateway route.</summary>
    [JsonPropertyName("grpcRoute")]
    public V1beta1GatewayRouteSpecInitProviderSpecGrpcRoute? GrpcRoute { get; set; }

    /// <summary>Specification of an HTTP/2 gateway route.</summary>
    [JsonPropertyName("http2Route")]
    public V1beta1GatewayRouteSpecInitProviderSpecHttp2Route? Http2Route { get; set; }

    /// <summary>Specification of an HTTP gateway route.</summary>
    [JsonPropertyName("httpRoute")]
    public V1beta1GatewayRouteSpecInitProviderSpecHttpRoute? HttpRoute { get; set; }

    /// <summary>Priority for the gateway route, between 0 and 1000.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderVirtualGatewayNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a VirtualGateway in appmesh to populate virtualGatewayName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderVirtualGatewayNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1GatewayRouteSpecInitProviderVirtualGatewayNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderVirtualGatewayNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a VirtualGateway in appmesh to populate virtualGatewayName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProviderVirtualGatewayNameSelector
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
    public V1beta1GatewayRouteSpecInitProviderVirtualGatewayNameSelectorPolicy? Policy { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecInitProvider
{
    /// <summary>Name of the service mesh in which to create the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("meshName")]
    public string? MeshName { get; set; }

    /// <summary>AWS account ID of the service mesh's owner. Defaults to the account ID the AWS provider is currently connected to.</summary>
    [JsonPropertyName("meshOwner")]
    public string? MeshOwner { get; set; }

    /// <summary>Name to use for the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Gateway route specification to apply.</summary>
    [JsonPropertyName("spec")]
    public V1beta1GatewayRouteSpecInitProviderSpec? Spec { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Name of the virtual gateway to associate the gateway route with. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualGatewayName")]
    public string? VirtualGatewayName { get; set; }

    /// <summary>Reference to a VirtualGateway in appmesh to populate virtualGatewayName.</summary>
    [JsonPropertyName("virtualGatewayNameRef")]
    public V1beta1GatewayRouteSpecInitProviderVirtualGatewayNameRef? VirtualGatewayNameRef { get; set; }

    /// <summary>Selector for a VirtualGateway in appmesh to populate virtualGatewayName.</summary>
    [JsonPropertyName("virtualGatewayNameSelector")]
    public V1beta1GatewayRouteSpecInitProviderVirtualGatewayNameSelector? VirtualGatewayNameSelector { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpecProviderConfigRef
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
public partial class V1beta1GatewayRouteSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>GatewayRouteSpec defines the desired state of GatewayRoute</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1GatewayRouteSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1GatewayRouteSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1GatewayRouteSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1GatewayRouteSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Virtual service gateway route target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecGrpcRouteActionTargetVirtualService
{
    /// <summary>Name of the virtual service that traffic is routed to. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualServiceName")]
    public string? VirtualServiceName { get; set; }
}

/// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecGrpcRouteActionTarget
{
    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual service gateway route target.</summary>
    [JsonPropertyName("virtualService")]
    public V1beta1GatewayRouteStatusAtProviderSpecGrpcRouteActionTargetVirtualService? VirtualService { get; set; }
}

/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecGrpcRouteAction
{
    /// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
    [JsonPropertyName("target")]
    public V1beta1GatewayRouteStatusAtProviderSpecGrpcRouteActionTarget? Target { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecGrpcRouteMatch
{
    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Fully qualified domain name for the service to match from the request.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>Specification of a gRPC gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecGrpcRoute
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta1GatewayRouteStatusAtProviderSpecGrpcRouteAction? Action { get; set; }

    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1GatewayRouteStatusAtProviderSpecGrpcRouteMatch? Match { get; set; }
}

/// <summary>Host name to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttp2RouteActionRewriteHostname
{
    /// <summary>Default target host name to write to. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("defaultTargetHostname")]
    public string? DefaultTargetHostname { get; set; }
}

/// <summary>Exact path to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttp2RouteActionRewritePath
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

/// <summary>Specified beginning characters to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttp2RouteActionRewritePrefix
{
    /// <summary>Default prefix used to replace the incoming route prefix when rewritten. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("defaultPrefix")]
    public string? DefaultPrefix { get; set; }

    /// <summary>Value used to replace the incoming route prefix when rewritten.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Gateway route action to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttp2RouteActionRewrite
{
    /// <summary>Host name to rewrite.</summary>
    [JsonPropertyName("hostname")]
    public V1beta1GatewayRouteStatusAtProviderSpecHttp2RouteActionRewriteHostname? Hostname { get; set; }

    /// <summary>Exact path to rewrite.</summary>
    [JsonPropertyName("path")]
    public V1beta1GatewayRouteStatusAtProviderSpecHttp2RouteActionRewritePath? Path { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public V1beta1GatewayRouteStatusAtProviderSpecHttp2RouteActionRewritePrefix? Prefix { get; set; }
}

/// <summary>Virtual service gateway route target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttp2RouteActionTargetVirtualService
{
    /// <summary>Name of the virtual service that traffic is routed to. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualServiceName")]
    public string? VirtualServiceName { get; set; }
}

/// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttp2RouteActionTarget
{
    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual service gateway route target.</summary>
    [JsonPropertyName("virtualService")]
    public V1beta1GatewayRouteStatusAtProviderSpecHttp2RouteActionTargetVirtualService? VirtualService { get; set; }
}

/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttp2RouteAction
{
    /// <summary>Gateway route action to rewrite.</summary>
    [JsonPropertyName("rewrite")]
    public V1beta1GatewayRouteStatusAtProviderSpecHttp2RouteActionRewrite? Rewrite { get; set; }

    /// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
    [JsonPropertyName("target")]
    public V1beta1GatewayRouteStatusAtProviderSpecHttp2RouteActionTarget? Target { get; set; }
}

/// <summary>Object that specifies the range of numbers that the header value sent by the client must be included in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttp2RouteMatchHeaderMatchRange
{
    /// <summary>End of the range.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>(Requited) Start of the range.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttp2RouteMatchHeaderMatch
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Object that specifies the range of numbers that the header value sent by the client must be included in.</summary>
    [JsonPropertyName("range")]
    public V1beta1GatewayRouteStatusAtProviderSpecHttp2RouteMatchHeaderMatchRange? Range { get; set; }

    /// <summary>Header value sent by the client must include the specified characters.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Header value sent by the client must end with the specified characters.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttp2RouteMatchHeader
{
    /// <summary>If true, the match is on the opposite of the match method and value. Default is false.</summary>
    [JsonPropertyName("invert")]
    public bool? Invert { get; set; }

    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1GatewayRouteStatusAtProviderSpecHttp2RouteMatchHeaderMatch? Match { get; set; }

    /// <summary>Name to use for the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Host name to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttp2RouteMatchHostname
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Header value sent by the client must end with the specified characters.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>Exact path to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttp2RouteMatchPath
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Header value sent by the client must include the specified characters.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttp2RouteMatchQueryParameterMatch
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttp2RouteMatchQueryParameter
{
    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1GatewayRouteStatusAtProviderSpecHttp2RouteMatchQueryParameterMatch? Match { get; set; }

    /// <summary>Name to use for the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttp2RouteMatch
{
    /// <summary>Client request headers to match on.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1GatewayRouteStatusAtProviderSpecHttp2RouteMatchHeader>? Header { get; set; }

    /// <summary>Host name to rewrite.</summary>
    [JsonPropertyName("hostname")]
    public V1beta1GatewayRouteStatusAtProviderSpecHttp2RouteMatchHostname? Hostname { get; set; }

    /// <summary>Exact path to rewrite.</summary>
    [JsonPropertyName("path")]
    public V1beta1GatewayRouteStatusAtProviderSpecHttp2RouteMatchPath? Path { get; set; }

    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Client request query parameters to match on.</summary>
    [JsonPropertyName("queryParameter")]
    public IList<V1beta1GatewayRouteStatusAtProviderSpecHttp2RouteMatchQueryParameter>? QueryParameter { get; set; }
}

/// <summary>Specification of an HTTP/2 gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttp2Route
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta1GatewayRouteStatusAtProviderSpecHttp2RouteAction? Action { get; set; }

    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1GatewayRouteStatusAtProviderSpecHttp2RouteMatch? Match { get; set; }
}

/// <summary>Host name to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttpRouteActionRewriteHostname
{
    /// <summary>Default target host name to write to. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("defaultTargetHostname")]
    public string? DefaultTargetHostname { get; set; }
}

/// <summary>Exact path to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttpRouteActionRewritePath
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

/// <summary>Specified beginning characters to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttpRouteActionRewritePrefix
{
    /// <summary>Default prefix used to replace the incoming route prefix when rewritten. Valid values: ENABLED, DISABLED.</summary>
    [JsonPropertyName("defaultPrefix")]
    public string? DefaultPrefix { get; set; }

    /// <summary>Value used to replace the incoming route prefix when rewritten.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Gateway route action to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttpRouteActionRewrite
{
    /// <summary>Host name to rewrite.</summary>
    [JsonPropertyName("hostname")]
    public V1beta1GatewayRouteStatusAtProviderSpecHttpRouteActionRewriteHostname? Hostname { get; set; }

    /// <summary>Exact path to rewrite.</summary>
    [JsonPropertyName("path")]
    public V1beta1GatewayRouteStatusAtProviderSpecHttpRouteActionRewritePath? Path { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public V1beta1GatewayRouteStatusAtProviderSpecHttpRouteActionRewritePrefix? Prefix { get; set; }
}

/// <summary>Virtual service gateway route target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttpRouteActionTargetVirtualService
{
    /// <summary>Name of the virtual service that traffic is routed to. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualServiceName")]
    public string? VirtualServiceName { get; set; }
}

/// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttpRouteActionTarget
{
    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Virtual service gateway route target.</summary>
    [JsonPropertyName("virtualService")]
    public V1beta1GatewayRouteStatusAtProviderSpecHttpRouteActionTargetVirtualService? VirtualService { get; set; }
}

/// <summary>Action to take if a match is determined.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttpRouteAction
{
    /// <summary>Gateway route action to rewrite.</summary>
    [JsonPropertyName("rewrite")]
    public V1beta1GatewayRouteStatusAtProviderSpecHttpRouteActionRewrite? Rewrite { get; set; }

    /// <summary>Target that traffic is routed to when a request matches the gateway route.</summary>
    [JsonPropertyName("target")]
    public V1beta1GatewayRouteStatusAtProviderSpecHttpRouteActionTarget? Target { get; set; }
}

/// <summary>Object that specifies the range of numbers that the header value sent by the client must be included in.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttpRouteMatchHeaderMatchRange
{
    /// <summary>End of the range.</summary>
    [JsonPropertyName("end")]
    public double? End { get; set; }

    /// <summary>(Requited) Start of the range.</summary>
    [JsonPropertyName("start")]
    public double? Start { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttpRouteMatchHeaderMatch
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Object that specifies the range of numbers that the header value sent by the client must be included in.</summary>
    [JsonPropertyName("range")]
    public V1beta1GatewayRouteStatusAtProviderSpecHttpRouteMatchHeaderMatchRange? Range { get; set; }

    /// <summary>Header value sent by the client must include the specified characters.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>Header value sent by the client must end with the specified characters.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttpRouteMatchHeader
{
    /// <summary>If true, the match is on the opposite of the match method and value. Default is false.</summary>
    [JsonPropertyName("invert")]
    public bool? Invert { get; set; }

    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1GatewayRouteStatusAtProviderSpecHttpRouteMatchHeaderMatch? Match { get; set; }

    /// <summary>Name to use for the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Host name to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttpRouteMatchHostname
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Header value sent by the client must end with the specified characters.</summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}

/// <summary>Exact path to rewrite.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttpRouteMatchPath
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    /// <summary>Header value sent by the client must include the specified characters.</summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttpRouteMatchQueryParameterMatch
{
    /// <summary>Value used to replace matched path.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttpRouteMatchQueryParameter
{
    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1GatewayRouteStatusAtProviderSpecHttpRouteMatchQueryParameterMatch? Match { get; set; }

    /// <summary>Name to use for the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Criteria for determining a request match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttpRouteMatch
{
    /// <summary>Client request headers to match on.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1GatewayRouteStatusAtProviderSpecHttpRouteMatchHeader>? Header { get; set; }

    /// <summary>Host name to rewrite.</summary>
    [JsonPropertyName("hostname")]
    public V1beta1GatewayRouteStatusAtProviderSpecHttpRouteMatchHostname? Hostname { get; set; }

    /// <summary>Exact path to rewrite.</summary>
    [JsonPropertyName("path")]
    public V1beta1GatewayRouteStatusAtProviderSpecHttpRouteMatchPath? Path { get; set; }

    /// <summary>The port number that corresponds to the target for Virtual Service provider port. This is required when the provider (router or node) of the Virtual Service has multiple listeners.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Specified beginning characters to rewrite.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Client request query parameters to match on.</summary>
    [JsonPropertyName("queryParameter")]
    public IList<V1beta1GatewayRouteStatusAtProviderSpecHttpRouteMatchQueryParameter>? QueryParameter { get; set; }
}

/// <summary>Specification of an HTTP gateway route.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpecHttpRoute
{
    /// <summary>Action to take if a match is determined.</summary>
    [JsonPropertyName("action")]
    public V1beta1GatewayRouteStatusAtProviderSpecHttpRouteAction? Action { get; set; }

    /// <summary>Criteria for determining a request match.</summary>
    [JsonPropertyName("match")]
    public V1beta1GatewayRouteStatusAtProviderSpecHttpRouteMatch? Match { get; set; }
}

/// <summary>Gateway route specification to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProviderSpec
{
    /// <summary>Specification of a gRPC gateway route.</summary>
    [JsonPropertyName("grpcRoute")]
    public V1beta1GatewayRouteStatusAtProviderSpecGrpcRoute? GrpcRoute { get; set; }

    /// <summary>Specification of an HTTP/2 gateway route.</summary>
    [JsonPropertyName("http2Route")]
    public V1beta1GatewayRouteStatusAtProviderSpecHttp2Route? Http2Route { get; set; }

    /// <summary>Specification of an HTTP gateway route.</summary>
    [JsonPropertyName("httpRoute")]
    public V1beta1GatewayRouteStatusAtProviderSpecHttpRoute? HttpRoute { get; set; }

    /// <summary>Priority for the gateway route, between 0 and 1000.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusAtProvider
{
    /// <summary>ARN of the gateway route.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Creation date of the gateway route.</summary>
    [JsonPropertyName("createdDate")]
    public string? CreatedDate { get; set; }

    /// <summary>ID of the gateway route.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Last update date of the gateway route.</summary>
    [JsonPropertyName("lastUpdatedDate")]
    public string? LastUpdatedDate { get; set; }

    /// <summary>Name of the service mesh in which to create the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("meshName")]
    public string? MeshName { get; set; }

    /// <summary>AWS account ID of the service mesh's owner. Defaults to the account ID the AWS provider is currently connected to.</summary>
    [JsonPropertyName("meshOwner")]
    public string? MeshOwner { get; set; }

    /// <summary>Name to use for the gateway route. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Region where this resource will be managed. Defaults to the Region set in the provider configuration. Region is the region you'd like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Resource owner's AWS account ID.</summary>
    [JsonPropertyName("resourceOwner")]
    public string? ResourceOwner { get; set; }

    /// <summary>Gateway route specification to apply.</summary>
    [JsonPropertyName("spec")]
    public V1beta1GatewayRouteStatusAtProviderSpec? Spec { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Name of the virtual gateway to associate the gateway route with. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualGatewayName")]
    public string? VirtualGatewayName { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatusConditions
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

/// <summary>GatewayRouteStatus defines the observed state of GatewayRoute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1GatewayRouteStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1GatewayRouteStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1GatewayRouteStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>GatewayRoute is the Schema for the GatewayRoutes API. Provides an AWS App Mesh gateway route resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1GatewayRoute : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1GatewayRouteSpec>, IStatus<V1beta1GatewayRouteStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "GatewayRoute";
    public const string KubeGroup = "appmesh.aws.m.upbound.io";
    public const string KubePluralName = "gatewayroutes";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>GatewayRouteSpec defines the desired state of GatewayRoute</summary>
    [JsonPropertyName("spec")]
    public V1beta1GatewayRouteSpec Spec { get; set; }

    /// <summary>GatewayRouteStatus defines the observed state of GatewayRoute.</summary>
    [JsonPropertyName("status")]
    public V1beta1GatewayRouteStatus? Status { get; set; }
}

/// <summary>GatewayRoute is the Schema for the GatewayRoutes API. Provides an AWS App Mesh gateway route resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1GatewayRouteList : IKubernetesObject<V1ListMeta>, IItems<V1beta1GatewayRoute>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "GatewayRouteList";
    public const string KubeGroup = "appmesh.aws.m.upbound.io";
    public const string KubePluralName = "gatewayroutes";
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
    public IList<V1beta1GatewayRoute> Items { get; set; }
}