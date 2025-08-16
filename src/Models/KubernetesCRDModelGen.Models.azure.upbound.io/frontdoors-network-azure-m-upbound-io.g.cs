using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.m.upbound.io;
/// <summary>FrontDoor is the Schema for the FrontDoors API. Manages an Azure Front Door (classic) instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FrontDoorList : IKubernetesObject<V1ListMeta>, IItems<V1beta1FrontDoor>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FrontDoorList";
    public const string KubeGroup = "network.azure.m.upbound.io";
    public const string KubePluralName = "frontdoors";
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
    public IList<V1beta1FrontDoor> Items { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorSpecForProviderBackendPoolBackend
{
    /// <summary>Location of the backend (IP address or FQDN)</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>Enable or Disable use of this Backend Routing Rule. Permitted values are true or false. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The value to use as the host header sent to the backend.</summary>
    [JsonPropertyName("hostHeader")]
    public string? HostHeader { get; set; }

    /// <summary>The HTTP TCP port number. Possible values are between 1 - 65535.</summary>
    [JsonPropertyName("httpPort")]
    public double? HttpPort { get; set; }

    /// <summary>The HTTPS TCP port number. Possible values are between 1 - 65535.</summary>
    [JsonPropertyName("httpsPort")]
    public double? HttpsPort { get; set; }

    /// <summary>Priority to use for load balancing. Higher priorities will not be used for load balancing if any lower priority backend is healthy. Defaults to 1.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Weight of this endpoint for load balancing purposes. Defaults to 50.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorSpecForProviderBackendPool
{
    /// <summary>A backend block as defined below.</summary>
    [JsonPropertyName("backend")]
    public IList<V1beta1FrontDoorSpecForProviderBackendPoolBackend>? Backend { get; set; }

    /// <summary>Specifies the name of the backend_pool_health_probe block within this resource to use for this Backend Pool.</summary>
    [JsonPropertyName("healthProbeName")]
    public string? HealthProbeName { get; set; }

    /// <summary>Specifies the name of the backend_pool_load_balancing block within this resource to use for this Backend Pool.</summary>
    [JsonPropertyName("loadBalancingName")]
    public string? LoadBalancingName { get; set; }

    /// <summary>Specifies the name of the Backend Pool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorSpecForProviderBackendPoolHealthProbe
{
    /// <summary>Is this health probe enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The number of seconds between each Health Probe. Defaults to 120.</summary>
    [JsonPropertyName("intervalInSeconds")]
    public double? IntervalInSeconds { get; set; }

    /// <summary>Specifies the name of the Health Probe.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The path to use for the Health Probe. Default is /.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Specifies HTTP method the health probe uses when querying the backend pool instances. Possible values include: GET and HEAD. Defaults to GET.</summary>
    [JsonPropertyName("probeMethod")]
    public string? ProbeMethod { get; set; }

    /// <summary>Protocol scheme to use for the Health Probe. Possible values are Http and Https. Defaults to Http.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorSpecForProviderBackendPoolLoadBalancing
{
    /// <summary>The additional latency in milliseconds for probes to fall into the lowest latency bucket. Defaults to 0.</summary>
    [JsonPropertyName("additionalLatencyMilliseconds")]
    public double? AdditionalLatencyMilliseconds { get; set; }

    /// <summary>Specifies the name of the Load Balancer.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The number of samples to consider for load balancing decisions. Defaults to 4.</summary>
    [JsonPropertyName("sampleSize")]
    public double? SampleSize { get; set; }

    /// <summary>The number of samples within the sample period that must succeed. Defaults to 2.</summary>
    [JsonPropertyName("successfulSamplesRequired")]
    public double? SuccessfulSamplesRequired { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorSpecForProviderBackendPoolSettings
{
    /// <summary>Specifies the send and receive timeout on forwarding request to the backend. When the timeout is reached, the request fails and returns. Possible values are between 0 - 240. Defaults to 60.</summary>
    [JsonPropertyName("backendPoolsSendReceiveTimeoutSeconds")]
    public double? BackendPoolsSendReceiveTimeoutSeconds { get; set; }

    /// <summary>Enforce certificate name check on HTTPS requests to all backend pools, this setting will have no effect on HTTP requests. Permitted values are true or false.</summary>
    [JsonPropertyName("enforceBackendPoolsCertificateNameCheck")]
    public bool? EnforceBackendPoolsCertificateNameCheck { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorSpecForProviderFrontendEndpoint
{
    /// <summary>Specifies the host name of the frontend_endpoint. Must be a domain name. In order to use a name.azurefd.net domain, the name value must match the Front Door name.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>Specifies the name of the frontend_endpoint.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether to allow session affinity on this host. Valid options are true or false Defaults to false.</summary>
    [JsonPropertyName("sessionAffinityEnabled")]
    public bool? SessionAffinityEnabled { get; set; }

    /// <summary>The TTL to use in seconds for session affinity, if applicable. Defaults to 0.</summary>
    [JsonPropertyName("sessionAffinityTtlSeconds")]
    public double? SessionAffinityTtlSeconds { get; set; }

    /// <summary>Defines the Web Application Firewall policy ID for each host.</summary>
    [JsonPropertyName("webApplicationFirewallPolicyLinkId")]
    public string? WebApplicationFirewallPolicyLinkId { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1FrontDoorSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorSpecForProviderResourceGroupNameSelector
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
    public V1beta1FrontDoorSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A forwarding_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorSpecForProviderRoutingRuleForwardingConfiguration
{
    /// <summary>Specifies the name of the Backend Pool to forward the incoming traffic to.</summary>
    [JsonPropertyName("backendPoolName")]
    public string? BackendPoolName { get; set; }

    /// <summary>Specify the minimum caching duration (in ISO8601 notation e.g. P1DT2H for 1 day and 2 hours). Needs to be greater than 0 and smaller than 365 days. cache_duration works only in combination with cache_enabled set to true.</summary>
    [JsonPropertyName("cacheDuration")]
    public string? CacheDuration { get; set; }

    /// <summary>Specifies whether to Enable caching or not. Valid options are true or false. Defaults to false.</summary>
    [JsonPropertyName("cacheEnabled")]
    public bool? CacheEnabled { get; set; }

    /// <summary>Defines cache behaviour in relation to query string parameters. Valid options are StripAll, StripAllExcept, StripOnly or StripNone. Defaults to StripAll.</summary>
    [JsonPropertyName("cacheQueryParameterStripDirective")]
    public string? CacheQueryParameterStripDirective { get; set; }

    /// <summary>Specify query parameters (array). Works only in combination with cache_query_parameter_strip_directive set to StripAllExcept or StripOnly.</summary>
    [JsonPropertyName("cacheQueryParameters")]
    public IList<string>? CacheQueryParameters { get; set; }

    /// <summary>Whether to use dynamic compression when caching. Valid options are true or false. Defaults to false.</summary>
    [JsonPropertyName("cacheUseDynamicCompression")]
    public bool? CacheUseDynamicCompression { get; set; }

    /// <summary>Path to use when constructing the request to forward to the backend. This functions as a URL Rewrite. Default behaviour preserves the URL path.</summary>
    [JsonPropertyName("customForwardingPath")]
    public string? CustomForwardingPath { get; set; }

    /// <summary>Protocol to use when redirecting. Valid options are HttpOnly, HttpsOnly, or MatchRequest. Defaults to HttpsOnly.</summary>
    [JsonPropertyName("forwardingProtocol")]
    public string? ForwardingProtocol { get; set; }
}

/// <summary>A redirect_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorSpecForProviderRoutingRuleRedirectConfiguration
{
    /// <summary>The destination fragment in the portion of URL after '#'. Set this to add a fragment to the redirect URL.</summary>
    [JsonPropertyName("customFragment")]
    public string? CustomFragment { get; set; }

    /// <summary>Set this to change the URL for the redirection.</summary>
    [JsonPropertyName("customHost")]
    public string? CustomHost { get; set; }

    /// <summary>The path to retain as per the incoming request, or update in the URL for the redirection.</summary>
    [JsonPropertyName("customPath")]
    public string? CustomPath { get; set; }

    /// <summary>Replace any existing query string from the incoming request URL.</summary>
    [JsonPropertyName("customQueryString")]
    public string? CustomQueryString { get; set; }

    /// <summary>Protocol to use when redirecting. Valid options are HttpOnly, HttpsOnly, or MatchRequest.</summary>
    [JsonPropertyName("redirectProtocol")]
    public string? RedirectProtocol { get; set; }

    /// <summary>Status code for the redirect. Valida options are Moved, Found, TemporaryRedirect, PermanentRedirect.</summary>
    [JsonPropertyName("redirectType")]
    public string? RedirectType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorSpecForProviderRoutingRule
{
    /// <summary>Protocol schemes to match for the Backend Routing Rule. Possible values are Http and Https.</summary>
    [JsonPropertyName("acceptedProtocols")]
    public IList<string>? AcceptedProtocols { get; set; }

    /// <summary>Enable or Disable use of this Backend Routing Rule. Permitted values are true or false. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A forwarding_configuration block as defined below.</summary>
    [JsonPropertyName("forwardingConfiguration")]
    public V1beta1FrontDoorSpecForProviderRoutingRuleForwardingConfiguration? ForwardingConfiguration { get; set; }

    /// <summary>The names of the frontend_endpoint blocks within this resource to associate with this routing_rule.</summary>
    [JsonPropertyName("frontendEndpoints")]
    public IList<string>? FrontendEndpoints { get; set; }

    /// <summary>Specifies the name of the Routing Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The route patterns for the Backend Routing Rule.</summary>
    [JsonPropertyName("patternsToMatch")]
    public IList<string>? PatternsToMatch { get; set; }

    /// <summary>A redirect_configuration block as defined below.</summary>
    [JsonPropertyName("redirectConfiguration")]
    public V1beta1FrontDoorSpecForProviderRoutingRuleRedirectConfiguration? RedirectConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorSpecForProvider
{
    /// <summary>A backend_pool block as defined below.</summary>
    [JsonPropertyName("backendPool")]
    public IList<V1beta1FrontDoorSpecForProviderBackendPool>? BackendPool { get; set; }

    /// <summary>A backend_pool_health_probe block as defined below.</summary>
    [JsonPropertyName("backendPoolHealthProbe")]
    public IList<V1beta1FrontDoorSpecForProviderBackendPoolHealthProbe>? BackendPoolHealthProbe { get; set; }

    /// <summary>A backend_pool_load_balancing block as defined below.</summary>
    [JsonPropertyName("backendPoolLoadBalancing")]
    public IList<V1beta1FrontDoorSpecForProviderBackendPoolLoadBalancing>? BackendPoolLoadBalancing { get; set; }

    /// <summary>A backend_pool_settings block as defined below.</summary>
    [JsonPropertyName("backendPoolSettings")]
    public IList<V1beta1FrontDoorSpecForProviderBackendPoolSettings>? BackendPoolSettings { get; set; }

    /// <summary>A friendly name for the Front Door service.</summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>A frontend_endpoint block as defined below.</summary>
    [JsonPropertyName("frontendEndpoint")]
    public IList<V1beta1FrontDoorSpecForProviderFrontendEndpoint>? FrontendEndpoint { get; set; }

    /// <summary>Should the Front Door Load Balancer be Enabled? Defaults to true.</summary>
    [JsonPropertyName("loadBalancerEnabled")]
    public bool? LoadBalancerEnabled { get; set; }

    /// <summary>Specifies the name of the Resource Group in which the Front Door service should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1FrontDoorSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1FrontDoorSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A routing_rule block as defined below.</summary>
    [JsonPropertyName("routingRule")]
    public IList<V1beta1FrontDoorSpecForProviderRoutingRule>? RoutingRule { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorSpecInitProviderBackendPoolBackend
{
    /// <summary>Location of the backend (IP address or FQDN)</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>Enable or Disable use of this Backend Routing Rule. Permitted values are true or false. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The value to use as the host header sent to the backend.</summary>
    [JsonPropertyName("hostHeader")]
    public string? HostHeader { get; set; }

    /// <summary>The HTTP TCP port number. Possible values are between 1 - 65535.</summary>
    [JsonPropertyName("httpPort")]
    public double? HttpPort { get; set; }

    /// <summary>The HTTPS TCP port number. Possible values are between 1 - 65535.</summary>
    [JsonPropertyName("httpsPort")]
    public double? HttpsPort { get; set; }

    /// <summary>Priority to use for load balancing. Higher priorities will not be used for load balancing if any lower priority backend is healthy. Defaults to 1.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Weight of this endpoint for load balancing purposes. Defaults to 50.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorSpecInitProviderBackendPool
{
    /// <summary>A backend block as defined below.</summary>
    [JsonPropertyName("backend")]
    public IList<V1beta1FrontDoorSpecInitProviderBackendPoolBackend>? Backend { get; set; }

    /// <summary>Specifies the name of the backend_pool_health_probe block within this resource to use for this Backend Pool.</summary>
    [JsonPropertyName("healthProbeName")]
    public string? HealthProbeName { get; set; }

    /// <summary>Specifies the name of the backend_pool_load_balancing block within this resource to use for this Backend Pool.</summary>
    [JsonPropertyName("loadBalancingName")]
    public string? LoadBalancingName { get; set; }

    /// <summary>Specifies the name of the Backend Pool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorSpecInitProviderBackendPoolHealthProbe
{
    /// <summary>Is this health probe enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The number of seconds between each Health Probe. Defaults to 120.</summary>
    [JsonPropertyName("intervalInSeconds")]
    public double? IntervalInSeconds { get; set; }

    /// <summary>Specifies the name of the Health Probe.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The path to use for the Health Probe. Default is /.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Specifies HTTP method the health probe uses when querying the backend pool instances. Possible values include: GET and HEAD. Defaults to GET.</summary>
    [JsonPropertyName("probeMethod")]
    public string? ProbeMethod { get; set; }

    /// <summary>Protocol scheme to use for the Health Probe. Possible values are Http and Https. Defaults to Http.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorSpecInitProviderBackendPoolLoadBalancing
{
    /// <summary>The additional latency in milliseconds for probes to fall into the lowest latency bucket. Defaults to 0.</summary>
    [JsonPropertyName("additionalLatencyMilliseconds")]
    public double? AdditionalLatencyMilliseconds { get; set; }

    /// <summary>Specifies the name of the Load Balancer.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The number of samples to consider for load balancing decisions. Defaults to 4.</summary>
    [JsonPropertyName("sampleSize")]
    public double? SampleSize { get; set; }

    /// <summary>The number of samples within the sample period that must succeed. Defaults to 2.</summary>
    [JsonPropertyName("successfulSamplesRequired")]
    public double? SuccessfulSamplesRequired { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorSpecInitProviderBackendPoolSettings
{
    /// <summary>Specifies the send and receive timeout on forwarding request to the backend. When the timeout is reached, the request fails and returns. Possible values are between 0 - 240. Defaults to 60.</summary>
    [JsonPropertyName("backendPoolsSendReceiveTimeoutSeconds")]
    public double? BackendPoolsSendReceiveTimeoutSeconds { get; set; }

    /// <summary>Enforce certificate name check on HTTPS requests to all backend pools, this setting will have no effect on HTTP requests. Permitted values are true or false.</summary>
    [JsonPropertyName("enforceBackendPoolsCertificateNameCheck")]
    public bool? EnforceBackendPoolsCertificateNameCheck { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorSpecInitProviderFrontendEndpoint
{
    /// <summary>Specifies the host name of the frontend_endpoint. Must be a domain name. In order to use a name.azurefd.net domain, the name value must match the Front Door name.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>Specifies the name of the frontend_endpoint.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether to allow session affinity on this host. Valid options are true or false Defaults to false.</summary>
    [JsonPropertyName("sessionAffinityEnabled")]
    public bool? SessionAffinityEnabled { get; set; }

    /// <summary>The TTL to use in seconds for session affinity, if applicable. Defaults to 0.</summary>
    [JsonPropertyName("sessionAffinityTtlSeconds")]
    public double? SessionAffinityTtlSeconds { get; set; }

    /// <summary>Defines the Web Application Firewall policy ID for each host.</summary>
    [JsonPropertyName("webApplicationFirewallPolicyLinkId")]
    public string? WebApplicationFirewallPolicyLinkId { get; set; }
}

/// <summary>A forwarding_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorSpecInitProviderRoutingRuleForwardingConfiguration
{
    /// <summary>Specifies the name of the Backend Pool to forward the incoming traffic to.</summary>
    [JsonPropertyName("backendPoolName")]
    public string? BackendPoolName { get; set; }

    /// <summary>Specify the minimum caching duration (in ISO8601 notation e.g. P1DT2H for 1 day and 2 hours). Needs to be greater than 0 and smaller than 365 days. cache_duration works only in combination with cache_enabled set to true.</summary>
    [JsonPropertyName("cacheDuration")]
    public string? CacheDuration { get; set; }

    /// <summary>Specifies whether to Enable caching or not. Valid options are true or false. Defaults to false.</summary>
    [JsonPropertyName("cacheEnabled")]
    public bool? CacheEnabled { get; set; }

    /// <summary>Defines cache behaviour in relation to query string parameters. Valid options are StripAll, StripAllExcept, StripOnly or StripNone. Defaults to StripAll.</summary>
    [JsonPropertyName("cacheQueryParameterStripDirective")]
    public string? CacheQueryParameterStripDirective { get; set; }

    /// <summary>Specify query parameters (array). Works only in combination with cache_query_parameter_strip_directive set to StripAllExcept or StripOnly.</summary>
    [JsonPropertyName("cacheQueryParameters")]
    public IList<string>? CacheQueryParameters { get; set; }

    /// <summary>Whether to use dynamic compression when caching. Valid options are true or false. Defaults to false.</summary>
    [JsonPropertyName("cacheUseDynamicCompression")]
    public bool? CacheUseDynamicCompression { get; set; }

    /// <summary>Path to use when constructing the request to forward to the backend. This functions as a URL Rewrite. Default behaviour preserves the URL path.</summary>
    [JsonPropertyName("customForwardingPath")]
    public string? CustomForwardingPath { get; set; }

    /// <summary>Protocol to use when redirecting. Valid options are HttpOnly, HttpsOnly, or MatchRequest. Defaults to HttpsOnly.</summary>
    [JsonPropertyName("forwardingProtocol")]
    public string? ForwardingProtocol { get; set; }
}

/// <summary>A redirect_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorSpecInitProviderRoutingRuleRedirectConfiguration
{
    /// <summary>The destination fragment in the portion of URL after '#'. Set this to add a fragment to the redirect URL.</summary>
    [JsonPropertyName("customFragment")]
    public string? CustomFragment { get; set; }

    /// <summary>Set this to change the URL for the redirection.</summary>
    [JsonPropertyName("customHost")]
    public string? CustomHost { get; set; }

    /// <summary>The path to retain as per the incoming request, or update in the URL for the redirection.</summary>
    [JsonPropertyName("customPath")]
    public string? CustomPath { get; set; }

    /// <summary>Replace any existing query string from the incoming request URL.</summary>
    [JsonPropertyName("customQueryString")]
    public string? CustomQueryString { get; set; }

    /// <summary>Protocol to use when redirecting. Valid options are HttpOnly, HttpsOnly, or MatchRequest.</summary>
    [JsonPropertyName("redirectProtocol")]
    public string? RedirectProtocol { get; set; }

    /// <summary>Status code for the redirect. Valida options are Moved, Found, TemporaryRedirect, PermanentRedirect.</summary>
    [JsonPropertyName("redirectType")]
    public string? RedirectType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorSpecInitProviderRoutingRule
{
    /// <summary>Protocol schemes to match for the Backend Routing Rule. Possible values are Http and Https.</summary>
    [JsonPropertyName("acceptedProtocols")]
    public IList<string>? AcceptedProtocols { get; set; }

    /// <summary>Enable or Disable use of this Backend Routing Rule. Permitted values are true or false. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A forwarding_configuration block as defined below.</summary>
    [JsonPropertyName("forwardingConfiguration")]
    public V1beta1FrontDoorSpecInitProviderRoutingRuleForwardingConfiguration? ForwardingConfiguration { get; set; }

    /// <summary>The names of the frontend_endpoint blocks within this resource to associate with this routing_rule.</summary>
    [JsonPropertyName("frontendEndpoints")]
    public IList<string>? FrontendEndpoints { get; set; }

    /// <summary>Specifies the name of the Routing Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The route patterns for the Backend Routing Rule.</summary>
    [JsonPropertyName("patternsToMatch")]
    public IList<string>? PatternsToMatch { get; set; }

    /// <summary>A redirect_configuration block as defined below.</summary>
    [JsonPropertyName("redirectConfiguration")]
    public V1beta1FrontDoorSpecInitProviderRoutingRuleRedirectConfiguration? RedirectConfiguration { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorSpecInitProvider
{
    /// <summary>A backend_pool block as defined below.</summary>
    [JsonPropertyName("backendPool")]
    public IList<V1beta1FrontDoorSpecInitProviderBackendPool>? BackendPool { get; set; }

    /// <summary>A backend_pool_health_probe block as defined below.</summary>
    [JsonPropertyName("backendPoolHealthProbe")]
    public IList<V1beta1FrontDoorSpecInitProviderBackendPoolHealthProbe>? BackendPoolHealthProbe { get; set; }

    /// <summary>A backend_pool_load_balancing block as defined below.</summary>
    [JsonPropertyName("backendPoolLoadBalancing")]
    public IList<V1beta1FrontDoorSpecInitProviderBackendPoolLoadBalancing>? BackendPoolLoadBalancing { get; set; }

    /// <summary>A backend_pool_settings block as defined below.</summary>
    [JsonPropertyName("backendPoolSettings")]
    public IList<V1beta1FrontDoorSpecInitProviderBackendPoolSettings>? BackendPoolSettings { get; set; }

    /// <summary>A friendly name for the Front Door service.</summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>A frontend_endpoint block as defined below.</summary>
    [JsonPropertyName("frontendEndpoint")]
    public IList<V1beta1FrontDoorSpecInitProviderFrontendEndpoint>? FrontendEndpoint { get; set; }

    /// <summary>Should the Front Door Load Balancer be Enabled? Defaults to true.</summary>
    [JsonPropertyName("loadBalancerEnabled")]
    public bool? LoadBalancerEnabled { get; set; }

    /// <summary>A routing_rule block as defined below.</summary>
    [JsonPropertyName("routingRule")]
    public IList<V1beta1FrontDoorSpecInitProviderRoutingRule>? RoutingRule { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorSpecProviderConfigRef
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
public partial class V1beta1FrontDoorSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>FrontDoorSpec defines the desired state of FrontDoor</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorSpec
{
    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1FrontDoorSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1FrontDoorSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1FrontDoorSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1FrontDoorSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorStatusAtProviderBackendPoolBackend
{
    /// <summary>Location of the backend (IP address or FQDN)</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>Enable or Disable use of this Backend Routing Rule. Permitted values are true or false. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The value to use as the host header sent to the backend.</summary>
    [JsonPropertyName("hostHeader")]
    public string? HostHeader { get; set; }

    /// <summary>The HTTP TCP port number. Possible values are between 1 - 65535.</summary>
    [JsonPropertyName("httpPort")]
    public double? HttpPort { get; set; }

    /// <summary>The HTTPS TCP port number. Possible values are between 1 - 65535.</summary>
    [JsonPropertyName("httpsPort")]
    public double? HttpsPort { get; set; }

    /// <summary>Priority to use for load balancing. Higher priorities will not be used for load balancing if any lower priority backend is healthy. Defaults to 1.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>Weight of this endpoint for load balancing purposes. Defaults to 50.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorStatusAtProviderBackendPool
{
    /// <summary>A backend block as defined below.</summary>
    [JsonPropertyName("backend")]
    public IList<V1beta1FrontDoorStatusAtProviderBackendPoolBackend>? Backend { get; set; }

    /// <summary>Specifies the name of the backend_pool_health_probe block within this resource to use for this Backend Pool.</summary>
    [JsonPropertyName("healthProbeName")]
    public string? HealthProbeName { get; set; }

    /// <summary>The ID of the Azure Front Door Backend.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the name of the backend_pool_load_balancing block within this resource to use for this Backend Pool.</summary>
    [JsonPropertyName("loadBalancingName")]
    public string? LoadBalancingName { get; set; }

    /// <summary>Specifies the name of the Backend Pool.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorStatusAtProviderBackendPoolHealthProbe
{
    /// <summary>Is this health probe enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The ID of the Azure Front Door Backend.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The number of seconds between each Health Probe. Defaults to 120.</summary>
    [JsonPropertyName("intervalInSeconds")]
    public double? IntervalInSeconds { get; set; }

    /// <summary>Specifies the name of the Health Probe.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The path to use for the Health Probe. Default is /.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Specifies HTTP method the health probe uses when querying the backend pool instances. Possible values include: GET and HEAD. Defaults to GET.</summary>
    [JsonPropertyName("probeMethod")]
    public string? ProbeMethod { get; set; }

    /// <summary>Protocol scheme to use for the Health Probe. Possible values are Http and Https. Defaults to Http.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorStatusAtProviderBackendPoolLoadBalancing
{
    /// <summary>The additional latency in milliseconds for probes to fall into the lowest latency bucket. Defaults to 0.</summary>
    [JsonPropertyName("additionalLatencyMilliseconds")]
    public double? AdditionalLatencyMilliseconds { get; set; }

    /// <summary>The ID of the Azure Front Door Backend.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the name of the Load Balancer.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The number of samples to consider for load balancing decisions. Defaults to 4.</summary>
    [JsonPropertyName("sampleSize")]
    public double? SampleSize { get; set; }

    /// <summary>The number of samples within the sample period that must succeed. Defaults to 2.</summary>
    [JsonPropertyName("successfulSamplesRequired")]
    public double? SuccessfulSamplesRequired { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorStatusAtProviderBackendPoolSettings
{
    /// <summary>Specifies the send and receive timeout on forwarding request to the backend. When the timeout is reached, the request fails and returns. Possible values are between 0 - 240. Defaults to 60.</summary>
    [JsonPropertyName("backendPoolsSendReceiveTimeoutSeconds")]
    public double? BackendPoolsSendReceiveTimeoutSeconds { get; set; }

    /// <summary>Enforce certificate name check on HTTPS requests to all backend pools, this setting will have no effect on HTTP requests. Permitted values are true or false.</summary>
    [JsonPropertyName("enforceBackendPoolsCertificateNameCheck")]
    public bool? EnforceBackendPoolsCertificateNameCheck { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorStatusAtProviderExplicitResourceOrder
{
    /// <summary></summary>
    [JsonPropertyName("backendPoolHealthProbeIds")]
    public IList<string>? BackendPoolHealthProbeIds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backendPoolIds")]
    public IList<string>? BackendPoolIds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("backendPoolLoadBalancingIds")]
    public IList<string>? BackendPoolLoadBalancingIds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("frontendEndpointIds")]
    public IList<string>? FrontendEndpointIds { get; set; }

    /// <summary></summary>
    [JsonPropertyName("routingRuleIds")]
    public IList<string>? RoutingRuleIds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorStatusAtProviderFrontendEndpoint
{
    /// <summary>Specifies the host name of the frontend_endpoint. Must be a domain name. In order to use a name.azurefd.net domain, the name value must match the Front Door name.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Azure Front Door Backend.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the name of the frontend_endpoint.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Whether to allow session affinity on this host. Valid options are true or false Defaults to false.</summary>
    [JsonPropertyName("sessionAffinityEnabled")]
    public bool? SessionAffinityEnabled { get; set; }

    /// <summary>The TTL to use in seconds for session affinity, if applicable. Defaults to 0.</summary>
    [JsonPropertyName("sessionAffinityTtlSeconds")]
    public double? SessionAffinityTtlSeconds { get; set; }

    /// <summary>Defines the Web Application Firewall policy ID for each host.</summary>
    [JsonPropertyName("webApplicationFirewallPolicyLinkId")]
    public string? WebApplicationFirewallPolicyLinkId { get; set; }
}

/// <summary>A forwarding_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorStatusAtProviderRoutingRuleForwardingConfiguration
{
    /// <summary>Specifies the name of the Backend Pool to forward the incoming traffic to.</summary>
    [JsonPropertyName("backendPoolName")]
    public string? BackendPoolName { get; set; }

    /// <summary>Specify the minimum caching duration (in ISO8601 notation e.g. P1DT2H for 1 day and 2 hours). Needs to be greater than 0 and smaller than 365 days. cache_duration works only in combination with cache_enabled set to true.</summary>
    [JsonPropertyName("cacheDuration")]
    public string? CacheDuration { get; set; }

    /// <summary>Specifies whether to Enable caching or not. Valid options are true or false. Defaults to false.</summary>
    [JsonPropertyName("cacheEnabled")]
    public bool? CacheEnabled { get; set; }

    /// <summary>Defines cache behaviour in relation to query string parameters. Valid options are StripAll, StripAllExcept, StripOnly or StripNone. Defaults to StripAll.</summary>
    [JsonPropertyName("cacheQueryParameterStripDirective")]
    public string? CacheQueryParameterStripDirective { get; set; }

    /// <summary>Specify query parameters (array). Works only in combination with cache_query_parameter_strip_directive set to StripAllExcept or StripOnly.</summary>
    [JsonPropertyName("cacheQueryParameters")]
    public IList<string>? CacheQueryParameters { get; set; }

    /// <summary>Whether to use dynamic compression when caching. Valid options are true or false. Defaults to false.</summary>
    [JsonPropertyName("cacheUseDynamicCompression")]
    public bool? CacheUseDynamicCompression { get; set; }

    /// <summary>Path to use when constructing the request to forward to the backend. This functions as a URL Rewrite. Default behaviour preserves the URL path.</summary>
    [JsonPropertyName("customForwardingPath")]
    public string? CustomForwardingPath { get; set; }

    /// <summary>Protocol to use when redirecting. Valid options are HttpOnly, HttpsOnly, or MatchRequest. Defaults to HttpsOnly.</summary>
    [JsonPropertyName("forwardingProtocol")]
    public string? ForwardingProtocol { get; set; }
}

/// <summary>A redirect_configuration block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorStatusAtProviderRoutingRuleRedirectConfiguration
{
    /// <summary>The destination fragment in the portion of URL after '#'. Set this to add a fragment to the redirect URL.</summary>
    [JsonPropertyName("customFragment")]
    public string? CustomFragment { get; set; }

    /// <summary>Set this to change the URL for the redirection.</summary>
    [JsonPropertyName("customHost")]
    public string? CustomHost { get; set; }

    /// <summary>The path to retain as per the incoming request, or update in the URL for the redirection.</summary>
    [JsonPropertyName("customPath")]
    public string? CustomPath { get; set; }

    /// <summary>Replace any existing query string from the incoming request URL.</summary>
    [JsonPropertyName("customQueryString")]
    public string? CustomQueryString { get; set; }

    /// <summary>Protocol to use when redirecting. Valid options are HttpOnly, HttpsOnly, or MatchRequest.</summary>
    [JsonPropertyName("redirectProtocol")]
    public string? RedirectProtocol { get; set; }

    /// <summary>Status code for the redirect. Valida options are Moved, Found, TemporaryRedirect, PermanentRedirect.</summary>
    [JsonPropertyName("redirectType")]
    public string? RedirectType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorStatusAtProviderRoutingRule
{
    /// <summary>Protocol schemes to match for the Backend Routing Rule. Possible values are Http and Https.</summary>
    [JsonPropertyName("acceptedProtocols")]
    public IList<string>? AcceptedProtocols { get; set; }

    /// <summary>Enable or Disable use of this Backend Routing Rule. Permitted values are true or false. Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>A forwarding_configuration block as defined below.</summary>
    [JsonPropertyName("forwardingConfiguration")]
    public V1beta1FrontDoorStatusAtProviderRoutingRuleForwardingConfiguration? ForwardingConfiguration { get; set; }

    /// <summary>The names of the frontend_endpoint blocks within this resource to associate with this routing_rule.</summary>
    [JsonPropertyName("frontendEndpoints")]
    public IList<string>? FrontendEndpoints { get; set; }

    /// <summary>The ID of the Azure Front Door Backend.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the name of the Routing Rule.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The route patterns for the Backend Routing Rule.</summary>
    [JsonPropertyName("patternsToMatch")]
    public IList<string>? PatternsToMatch { get; set; }

    /// <summary>A redirect_configuration block as defined below.</summary>
    [JsonPropertyName("redirectConfiguration")]
    public V1beta1FrontDoorStatusAtProviderRoutingRuleRedirectConfiguration? RedirectConfiguration { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorStatusAtProvider
{
    /// <summary>A backend_pool block as defined below.</summary>
    [JsonPropertyName("backendPool")]
    public IList<V1beta1FrontDoorStatusAtProviderBackendPool>? BackendPool { get; set; }

    /// <summary>A backend_pool_health_probe block as defined below.</summary>
    [JsonPropertyName("backendPoolHealthProbe")]
    public IList<V1beta1FrontDoorStatusAtProviderBackendPoolHealthProbe>? BackendPoolHealthProbe { get; set; }

    /// <summary>A map/dictionary of Backend Pool Health Probe Names (key) to the Backend Pool Health Probe ID (value)</summary>
    [JsonPropertyName("backendPoolHealthProbes")]
    public IDictionary<string, string>? BackendPoolHealthProbes { get; set; }

    /// <summary>A backend_pool_load_balancing block as defined below.</summary>
    [JsonPropertyName("backendPoolLoadBalancing")]
    public IList<V1beta1FrontDoorStatusAtProviderBackendPoolLoadBalancing>? BackendPoolLoadBalancing { get; set; }

    /// <summary>A map/dictionary of Backend Pool Load Balancing Setting Names (key) to the Backend Pool Load Balancing Setting ID (value)</summary>
    [JsonPropertyName("backendPoolLoadBalancingSettings")]
    public IDictionary<string, string>? BackendPoolLoadBalancingSettings { get; set; }

    /// <summary>A backend_pool_settings block as defined below.</summary>
    [JsonPropertyName("backendPoolSettings")]
    public IList<V1beta1FrontDoorStatusAtProviderBackendPoolSettings>? BackendPoolSettings { get; set; }

    /// <summary>A map/dictionary of Backend Pool Names (key) to the Backend Pool ID (value)</summary>
    [JsonPropertyName("backendPools")]
    public IDictionary<string, string>? BackendPools { get; set; }

    /// <summary>The host that each frontendEndpoint must CNAME to.</summary>
    [JsonPropertyName("cname")]
    public string? Cname { get; set; }

    /// <summary></summary>
    [JsonPropertyName("explicitResourceOrder")]
    public IList<V1beta1FrontDoorStatusAtProviderExplicitResourceOrder>? ExplicitResourceOrder { get; set; }

    /// <summary>A friendly name for the Front Door service.</summary>
    [JsonPropertyName("friendlyName")]
    public string? FriendlyName { get; set; }

    /// <summary>A frontend_endpoint block as defined below.</summary>
    [JsonPropertyName("frontendEndpoint")]
    public IList<V1beta1FrontDoorStatusAtProviderFrontendEndpoint>? FrontendEndpoint { get; set; }

    /// <summary>A map/dictionary of Frontend Endpoint Names (key) to the Frontend Endpoint ID (value)</summary>
    [JsonPropertyName("frontendEndpoints")]
    public IDictionary<string, string>? FrontendEndpoints { get; set; }

    /// <summary>The unique ID of the Front Door which is embedded into the incoming headers X-Azure-FDID attribute and maybe used to filter traffic sent by the Front Door to your backend.</summary>
    [JsonPropertyName("headerFrontdoorId")]
    public string? HeaderFrontdoorId { get; set; }

    /// <summary>The ID of the Azure Front Door Backend.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Should the Front Door Load Balancer be Enabled? Defaults to true.</summary>
    [JsonPropertyName("loadBalancerEnabled")]
    public bool? LoadBalancerEnabled { get; set; }

    /// <summary>Specifies the name of the Resource Group in which the Front Door service should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A routing_rule block as defined below.</summary>
    [JsonPropertyName("routingRule")]
    public IList<V1beta1FrontDoorStatusAtProviderRoutingRule>? RoutingRule { get; set; }

    /// <summary>A map/dictionary of Routing Rule Names (key) to the Routing Rule ID (value)</summary>
    [JsonPropertyName("routingRules")]
    public IDictionary<string, string>? RoutingRules { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorStatusConditions
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

/// <summary>FrontDoorStatus defines the observed state of FrontDoor.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1FrontDoorStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1FrontDoorStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1FrontDoorStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>FrontDoor is the Schema for the FrontDoors API. Manages an Azure Front Door (classic) instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1FrontDoor : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1FrontDoorSpec>, IStatus<V1beta1FrontDoorStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "FrontDoor";
    public const string KubeGroup = "network.azure.m.upbound.io";
    public const string KubePluralName = "frontdoors";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FrontDoorSpec defines the desired state of FrontDoor</summary>
    [JsonPropertyName("spec")]
    public V1beta1FrontDoorSpec Spec { get; set; }

    /// <summary>FrontDoorStatus defines the observed state of FrontDoor.</summary>
    [JsonPropertyName("status")]
    public V1beta1FrontDoorStatus? Status { get; set; }
}