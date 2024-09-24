using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networking.istio.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1alpha3EnvoyFilterSpecConfigPatchesApplyToEnum
{
    [EnumMember(Value = "INVALID"), JsonStringEnumMemberName("INVALID")]
    /// <summary>INVALID</summary>
    INVALID,
    [EnumMember(Value = "LISTENER"), JsonStringEnumMemberName("LISTENER")]
    /// <summary>LISTENER</summary>
    LISTENER,
    [EnumMember(Value = "FILTER_CHAIN"), JsonStringEnumMemberName("FILTER_CHAIN")]
    /// <summary>FILTER_CHAIN</summary>
    FILTERCHAIN,
    [EnumMember(Value = "NETWORK_FILTER"), JsonStringEnumMemberName("NETWORK_FILTER")]
    /// <summary>NETWORK_FILTER</summary>
    NETWORKFILTER,
    [EnumMember(Value = "HTTP_FILTER"), JsonStringEnumMemberName("HTTP_FILTER")]
    /// <summary>HTTP_FILTER</summary>
    HTTPFILTER,
    [EnumMember(Value = "ROUTE_CONFIGURATION"), JsonStringEnumMemberName("ROUTE_CONFIGURATION")]
    /// <summary>ROUTE_CONFIGURATION</summary>
    ROUTECONFIGURATION,
    [EnumMember(Value = "VIRTUAL_HOST"), JsonStringEnumMemberName("VIRTUAL_HOST")]
    /// <summary>VIRTUAL_HOST</summary>
    VIRTUALHOST,
    [EnumMember(Value = "HTTP_ROUTE"), JsonStringEnumMemberName("HTTP_ROUTE")]
    /// <summary>HTTP_ROUTE</summary>
    HTTPROUTE,
    [EnumMember(Value = "CLUSTER"), JsonStringEnumMemberName("CLUSTER")]
    /// <summary>CLUSTER</summary>
    CLUSTER,
    [EnumMember(Value = "EXTENSION_CONFIG"), JsonStringEnumMemberName("EXTENSION_CONFIG")]
    /// <summary>EXTENSION_CONFIG</summary>
    EXTENSIONCONFIG,
    [EnumMember(Value = "BOOTSTRAP"), JsonStringEnumMemberName("BOOTSTRAP")]
    /// <summary>BOOTSTRAP</summary>
    BOOTSTRAP,
    [EnumMember(Value = "LISTENER_FILTER"), JsonStringEnumMemberName("LISTENER_FILTER")]
    /// <summary>LISTENER_FILTER</summary>
    LISTENERFILTER
}

/// <summary>Match on envoy cluster attributes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesMatchCluster
{
    /// <summary>The exact name of the cluster to match.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The service port for which this cluster was generated.</summary>
    [JsonPropertyName("portNumber")]
    public int? PortNumber { get; set; }

    /// <summary>The fully qualified service name for this cluster.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>The subset associated with the service.</summary>
    [JsonPropertyName("subset")]
    public string? Subset { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1alpha3EnvoyFilterSpecConfigPatchesMatchContextEnum
{
    [EnumMember(Value = "ANY"), JsonStringEnumMemberName("ANY")]
    /// <summary>ANY</summary>
    ANY,
    [EnumMember(Value = "SIDECAR_INBOUND"), JsonStringEnumMemberName("SIDECAR_INBOUND")]
    /// <summary>SIDECAR_INBOUND</summary>
    SIDECARINBOUND,
    [EnumMember(Value = "SIDECAR_OUTBOUND"), JsonStringEnumMemberName("SIDECAR_OUTBOUND")]
    /// <summary>SIDECAR_OUTBOUND</summary>
    SIDECAROUTBOUND,
    [EnumMember(Value = "GATEWAY"), JsonStringEnumMemberName("GATEWAY")]
    /// <summary>GATEWAY</summary>
    GATEWAY
}

/// <summary>The next level filter within this filter to match upon.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesMatchListenerFilterChainFilterSubFilter
{
    /// <summary>The filter name to match on.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The name of a specific filter to apply the patch to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesMatchListenerFilterChainFilter
{
    /// <summary>The filter name to match on.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The next level filter within this filter to match upon.</summary>
    [JsonPropertyName("subFilter")]
    public V1alpha3EnvoyFilterSpecConfigPatchesMatchListenerFilterChainFilterSubFilter? SubFilter { get; set; }
}

/// <summary>Match a specific filter chain in a listener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesMatchListenerFilterChain
{
    /// <summary>Applies only to sidecars.</summary>
    [JsonPropertyName("applicationProtocols")]
    public string? ApplicationProtocols { get; set; }

    /// <summary>The destination_port value used by a filter chain's match condition.</summary>
    [JsonPropertyName("destinationPort")]
    public int? DestinationPort { get; set; }

    /// <summary>The name of a specific filter to apply the patch to.</summary>
    [JsonPropertyName("filter")]
    public V1alpha3EnvoyFilterSpecConfigPatchesMatchListenerFilterChainFilter? Filter { get; set; }

    /// <summary>The name assigned to the filter chain.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The SNI value used by a filter chain's match condition.</summary>
    [JsonPropertyName("sni")]
    public string? Sni { get; set; }

    /// <summary>Applies only to `SIDECAR_INBOUND` context.</summary>
    [JsonPropertyName("transportProtocol")]
    public string? TransportProtocol { get; set; }
}

/// <summary>Match on envoy listener attributes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesMatchListener
{
    /// <summary>Match a specific filter chain in a listener.</summary>
    [JsonPropertyName("filterChain")]
    public V1alpha3EnvoyFilterSpecConfigPatchesMatchListenerFilterChain? FilterChain { get; set; }

    /// <summary>Match a specific listener filter.</summary>
    [JsonPropertyName("listenerFilter")]
    public string? ListenerFilter { get; set; }

    /// <summary>Match a specific listener by its name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary></summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>The service port/gateway port to which traffic is being sent/received.</summary>
    [JsonPropertyName("portNumber")]
    public int? PortNumber { get; set; }
}

/// <summary>Match on properties associated with a proxy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesMatchProxy
{
    /// <summary>Match on the node metadata supplied by a proxy when connecting to Istio Pilot.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>A regular expression in golang regex format (RE2) that can be used to select proxies using a specific version of istio proxy.</summary>
    [JsonPropertyName("proxyVersion")]
    public string? ProxyVersion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1alpha3EnvoyFilterSpecConfigPatchesMatchRouteConfigurationVhostRouteActionEnum
{
    [EnumMember(Value = "ANY"), JsonStringEnumMemberName("ANY")]
    /// <summary>ANY</summary>
    ANY,
    [EnumMember(Value = "ROUTE"), JsonStringEnumMemberName("ROUTE")]
    /// <summary>ROUTE</summary>
    ROUTE,
    [EnumMember(Value = "REDIRECT"), JsonStringEnumMemberName("REDIRECT")]
    /// <summary>REDIRECT</summary>
    REDIRECT,
    [EnumMember(Value = "DIRECT_RESPONSE"), JsonStringEnumMemberName("DIRECT_RESPONSE")]
    /// <summary>DIRECT_RESPONSE</summary>
    DIRECTRESPONSE
}

/// <summary>Match a specific route within the virtual host.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesMatchRouteConfigurationVhostRoute
{
    /// <summary>Match a route with specific action type.  Valid Options: ANY, ROUTE, REDIRECT, DIRECT_RESPONSE</summary>
    [JsonPropertyName("action")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1alpha3EnvoyFilterSpecConfigPatchesMatchRouteConfigurationVhostRouteActionEnum>))]
    public V1alpha3EnvoyFilterSpecConfigPatchesMatchRouteConfigurationVhostRouteActionEnum? Action { get; set; }

    /// <summary>The Route objects generated by default are named as default.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Match a specific virtual host in a route configuration and apply the patch to the virtual host.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesMatchRouteConfigurationVhost
{
    /// <summary>The VirtualHosts objects generated by Istio are named as host:port, where the host typically corresponds to the VirtualService's host field or the hostname of a service in the registry.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Match a specific route within the virtual host.</summary>
    [JsonPropertyName("route")]
    public V1alpha3EnvoyFilterSpecConfigPatchesMatchRouteConfigurationVhostRoute? Route { get; set; }
}

/// <summary>Match on envoy HTTP route configuration attributes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesMatchRouteConfiguration
{
    /// <summary>The Istio gateway config's namespace/name for which this route configuration was generated.</summary>
    [JsonPropertyName("gateway")]
    public string? Gateway { get; set; }

    /// <summary>Route configuration name to match on.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Applicable only for GATEWAY context.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>The service port number or gateway server port number for which this route configuration was generated.</summary>
    [JsonPropertyName("portNumber")]
    public int? PortNumber { get; set; }

    /// <summary>Match a specific virtual host in a route configuration and apply the patch to the virtual host.</summary>
    [JsonPropertyName("vhost")]
    public V1alpha3EnvoyFilterSpecConfigPatchesMatchRouteConfigurationVhost? Vhost { get; set; }
}

/// <summary>Match on listener/route configuration/cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesMatch
{
    /// <summary>Match on envoy cluster attributes.</summary>
    [JsonPropertyName("cluster")]
    public V1alpha3EnvoyFilterSpecConfigPatchesMatchCluster? Cluster { get; set; }

    /// <summary>The specific config generation context to match on.  Valid Options: ANY, SIDECAR_INBOUND, SIDECAR_OUTBOUND, GATEWAY</summary>
    [JsonPropertyName("context")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1alpha3EnvoyFilterSpecConfigPatchesMatchContextEnum>))]
    public V1alpha3EnvoyFilterSpecConfigPatchesMatchContextEnum? Context { get; set; }

    /// <summary>Match on envoy listener attributes.</summary>
    [JsonPropertyName("listener")]
    public V1alpha3EnvoyFilterSpecConfigPatchesMatchListener? Listener { get; set; }

    /// <summary>Match on properties associated with a proxy.</summary>
    [JsonPropertyName("proxy")]
    public V1alpha3EnvoyFilterSpecConfigPatchesMatchProxy? Proxy { get; set; }

    /// <summary>Match on envoy HTTP route configuration attributes.</summary>
    [JsonPropertyName("routeConfiguration")]
    public V1alpha3EnvoyFilterSpecConfigPatchesMatchRouteConfiguration? RouteConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1alpha3EnvoyFilterSpecConfigPatchesPatchFilterClassEnum
{
    [EnumMember(Value = "UNSPECIFIED"), JsonStringEnumMemberName("UNSPECIFIED")]
    /// <summary>UNSPECIFIED</summary>
    UNSPECIFIED,
    [EnumMember(Value = "AUTHN"), JsonStringEnumMemberName("AUTHN")]
    /// <summary>AUTHN</summary>
    AUTHN,
    [EnumMember(Value = "AUTHZ"), JsonStringEnumMemberName("AUTHZ")]
    /// <summary>AUTHZ</summary>
    AUTHZ,
    [EnumMember(Value = "STATS"), JsonStringEnumMemberName("STATS")]
    /// <summary>STATS</summary>
    STATS
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0")]
public enum V1alpha3EnvoyFilterSpecConfigPatchesPatchOperationEnum
{
    [EnumMember(Value = "INVALID"), JsonStringEnumMemberName("INVALID")]
    /// <summary>INVALID</summary>
    INVALID,
    [EnumMember(Value = "MERGE"), JsonStringEnumMemberName("MERGE")]
    /// <summary>MERGE</summary>
    MERGE,
    [EnumMember(Value = "ADD"), JsonStringEnumMemberName("ADD")]
    /// <summary>ADD</summary>
    ADD,
    [EnumMember(Value = "REMOVE"), JsonStringEnumMemberName("REMOVE")]
    /// <summary>REMOVE</summary>
    REMOVE,
    [EnumMember(Value = "INSERT_BEFORE"), JsonStringEnumMemberName("INSERT_BEFORE")]
    /// <summary>INSERT_BEFORE</summary>
    INSERTBEFORE,
    [EnumMember(Value = "INSERT_AFTER"), JsonStringEnumMemberName("INSERT_AFTER")]
    /// <summary>INSERT_AFTER</summary>
    INSERTAFTER,
    [EnumMember(Value = "INSERT_FIRST"), JsonStringEnumMemberName("INSERT_FIRST")]
    /// <summary>INSERT_FIRST</summary>
    INSERTFIRST,
    [EnumMember(Value = "REPLACE"), JsonStringEnumMemberName("REPLACE")]
    /// <summary>REPLACE</summary>
    REPLACE
}

/// <summary>The patch to apply along with the operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesPatch
{
    /// <summary>Determines the filter insertion order.  Valid Options: AUTHN, AUTHZ, STATS</summary>
    [JsonPropertyName("filterClass")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1alpha3EnvoyFilterSpecConfigPatchesPatchFilterClassEnum>))]
    public V1alpha3EnvoyFilterSpecConfigPatchesPatchFilterClassEnum? FilterClass { get; set; }

    /// <summary>Determines how the patch should be applied.  Valid Options: MERGE, ADD, REMOVE, INSERT_BEFORE, INSERT_AFTER, INSERT_FIRST, REPLACE</summary>
    [JsonPropertyName("operation")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1alpha3EnvoyFilterSpecConfigPatchesPatchOperationEnum>))]
    public V1alpha3EnvoyFilterSpecConfigPatchesPatchOperationEnum? Operation { get; set; }

    /// <summary>The JSON config of the object being patched.</summary>
    [JsonPropertyName("value")]
    public JsonNode? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatches
{
    /// <summary>Specifies where in the Envoy configuration, the patch should be applied.  Valid Options: LISTENER, FILTER_CHAIN, NETWORK_FILTER, HTTP_FILTER, ROUTE_CONFIGURATION, VIRTUAL_HOST, HTTP_ROUTE, CLUSTER, EXTENSION_CONFIG, BOOTSTRAP, LISTENER_FILTER</summary>
    [JsonPropertyName("applyTo")]
    [JsonConverter(typeof(JsonStringEnumConverter<V1alpha3EnvoyFilterSpecConfigPatchesApplyToEnum>))]
    public V1alpha3EnvoyFilterSpecConfigPatchesApplyToEnum? ApplyTo { get; set; }

    /// <summary>Match on listener/route configuration/cluster.</summary>
    [JsonPropertyName("match")]
    public V1alpha3EnvoyFilterSpecConfigPatchesMatch? Match { get; set; }

    /// <summary>The patch to apply along with the operation.</summary>
    [JsonPropertyName("patch")]
    public V1alpha3EnvoyFilterSpecConfigPatchesPatch? Patch { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecTargetRefs
{
    /// <summary>group is the group of the target resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>kind is kind of the target resource.</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>name is the name of the target resource.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>namespace is the namespace of the referent.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Criteria used to select the specific set of pods/VMs on which this patch configuration should be applied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecWorkloadSelector
{
    /// <summary>One or more labels that indicate a specific set of pods/VMs on which the configuration should be applied.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>Customizing Envoy configuration generated by Istio. See more details at: https://istio.io/docs/reference/config/networking/envoy-filter.html</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpec
{
    /// <summary>One or more patches with match conditions.</summary>
    [JsonPropertyName("configPatches")]
    public IList<V1alpha3EnvoyFilterSpecConfigPatches>? ConfigPatches { get; set; }

    /// <summary>Priority defines the order in which patch sets are applied within a context.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>Optional.</summary>
    [JsonPropertyName("targetRefs")]
    public IList<V1alpha3EnvoyFilterSpecTargetRefs>? TargetRefs { get; set; }

    /// <summary>Criteria used to select the specific set of pods/VMs on which this patch configuration should be applied.</summary>
    [JsonPropertyName("workloadSelector")]
    public V1alpha3EnvoyFilterSpecWorkloadSelector? WorkloadSelector { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha3EnvoyFilter : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha3EnvoyFilterSpec>, IStatus<JsonNode>
{
    public const string KubeApiVersion = "v1alpha3";
    public const string KubeKind = "EnvoyFilter";
    public const string KubeGroup = "networking.istio.io";
    public const string KubePluralName = "envoyfilters";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Customizing Envoy configuration generated by Istio. See more details at: https://istio.io/docs/reference/config/networking/envoy-filter.html</summary>
    [JsonPropertyName("spec")]
    public V1alpha3EnvoyFilterSpec? Spec { get; set; }

    /// <summary></summary>
    [JsonPropertyName("status")]
    public JsonNode? Status { get; set; }
}