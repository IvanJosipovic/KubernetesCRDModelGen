using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networking.istio.io;
#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha3EnvoyFilterList : IKubernetesObject<V1ListMeta>, IItems<V1alpha3EnvoyFilter>
{
    public const string KubeApiVersion = "v1alpha3";
    public const string KubeKind = "EnvoyFilterList";
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
    public V1ListMeta Metadata { get; set; }

    /// <summary></summary>
    [JsonPropertyName("items")]
    public IList<V1alpha3EnvoyFilter> Items { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>The next level filter within this filter to match upon.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesMatchListenerFilterChainFilterSubFilter
{
    /// <summary>The filter name to match on.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>Match on properties associated with a proxy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesMatchProxy
{
    /// <summary>Match on the node metadata supplied by a proxy when connecting to istiod.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>A regular expression in golang regex format (RE2) that can be used to select proxies using a specific version of istio proxy.</summary>
    [JsonPropertyName("proxyVersion")]
    public string? ProxyVersion { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Match a specific route within the virtual host.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesMatchRouteConfigurationVhostRoute
{
    /// <summary>Match a route with specific action type.  Valid Options: ANY, ROUTE, REDIRECT, DIRECT_RESPONSE</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The Route objects generated by default are named as default.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
#nullable disable

#nullable enable
/// <summary>Match a specific virtual host in a route configuration and apply the patch to the virtual host.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesMatchRouteConfigurationVhost
{
    /// <summary>Match a domain name in a virtual host.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>The VirtualHosts objects generated by Istio are named as host:port, where the host typically corresponds to the VirtualService's host field or the hostname of a service in the registry.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Match a specific route within the virtual host.</summary>
    [JsonPropertyName("route")]
    public V1alpha3EnvoyFilterSpecConfigPatchesMatchRouteConfigurationVhostRoute? Route { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>Match on listener/route configuration/cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesMatch
{
    /// <summary>Match on envoy cluster attributes.</summary>
    [JsonPropertyName("cluster")]
    public V1alpha3EnvoyFilterSpecConfigPatchesMatchCluster? Cluster { get; set; }

    /// <summary>The specific config generation context to match on.  Valid Options: ANY, SIDECAR_INBOUND, SIDECAR_OUTBOUND, GATEWAY</summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

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
#nullable disable

#nullable enable
/// <summary>The patch to apply along with the operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatchesPatch
{
    /// <summary>Determines the filter insertion order.  Valid Options: AUTHN, AUTHZ, STATS</summary>
    [JsonPropertyName("filterClass")]
    public string? FilterClass { get; set; }

    /// <summary>Determines how the patch should be applied.  Valid Options: MERGE, ADD, REMOVE, INSERT_BEFORE, INSERT_AFTER, INSERT_FIRST, REPLACE</summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>The JSON config of the object being patched.</summary>
    [JsonPropertyName("value")]
    public JsonNode? Value { get; set; }
}
#nullable disable

#nullable enable
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecConfigPatches
{
    /// <summary>Specifies where in the Envoy configuration, the patch should be applied.  Valid Options: LISTENER, FILTER_CHAIN, NETWORK_FILTER, HTTP_FILTER, ROUTE_CONFIGURATION, VIRTUAL_HOST, HTTP_ROUTE, CLUSTER, EXTENSION_CONFIG, BOOTSTRAP, LISTENER_FILTER</summary>
    [JsonPropertyName("applyTo")]
    public string? ApplyTo { get; set; }

    /// <summary>Match on listener/route configuration/cluster.</summary>
    [JsonPropertyName("match")]
    public V1alpha3EnvoyFilterSpecConfigPatchesMatch? Match { get; set; }

    /// <summary>The patch to apply along with the operation.</summary>
    [JsonPropertyName("patch")]
    public V1alpha3EnvoyFilterSpecConfigPatchesPatch? Patch { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
/// <summary>Criteria used to select the specific set of pods/VMs on which this patch configuration should be applied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha3EnvoyFilterSpecWorkloadSelector
{
    /// <summary>One or more labels that indicate a specific set of pods/VMs on which the configuration should be applied.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}
#nullable disable

#nullable enable
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
#nullable disable

#nullable enable
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
#nullable disable
