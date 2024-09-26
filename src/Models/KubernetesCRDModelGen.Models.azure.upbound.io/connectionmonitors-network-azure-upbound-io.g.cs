using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.upbound.io;
/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecForProviderEndpointFilterItem
{
    /// <summary>The address of the filter item.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The type of items included in the filter. Possible values are AgentAddress. Defaults to AgentAddress.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecForProviderEndpointFilter
{
    /// <summary>A item block as defined below.</summary>
    [JsonPropertyName("item")]
    public IList<V1beta1ConnectionMonitorSpecForProviderEndpointFilterItem>? Item { get; set; }

    /// <summary>The type of items included in the filter. Possible values are AgentAddress. Defaults to AgentAddress.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecForProviderEndpoint
{
    /// <summary>The IP address or domain name of the Network Connection Monitor endpoint.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The test coverage for the Network Connection Monitor endpoint. Possible values are AboveAverage, Average, BelowAverage, Default, Full and Low.</summary>
    [JsonPropertyName("coverageLevel")]
    public string? CoverageLevel { get; set; }

    /// <summary>A list of IPv4/IPv6 subnet masks or IPv4/IPv6 IP addresses to be excluded to the Network Connection Monitor endpoint.</summary>
    [JsonPropertyName("excludedIpAddresses")]
    public IList<string>? ExcludedIpAddresses { get; set; }

    /// <summary>A filter block as defined below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1ConnectionMonitorSpecForProviderEndpointFilter>? Filter { get; set; }

    /// <summary>A list of IPv4/IPv6 subnet masks or IPv4/IPv6 IP addresses to be included to the Network Connection Monitor endpoint.</summary>
    [JsonPropertyName("includedIpAddresses")]
    public IList<string>? IncludedIpAddresses { get; set; }

    /// <summary>The name of the endpoint for the Network Connection Monitor .</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The resource ID which is used as the endpoint by the Network Connection Monitor.</summary>
    [JsonPropertyName("targetResourceId")]
    public string? TargetResourceId { get; set; }

    /// <summary>The endpoint type of the Network Connection Monitor. Possible values are AzureSubnet, AzureVM, AzureVNet, ExternalAddress, MMAWorkspaceMachine and MMAWorkspaceNetwork.</summary>
    [JsonPropertyName("targetResourceType")]
    public string? TargetResourceType { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecForProviderNetworkWatcherIdRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Reference to a Watcher in network to populate networkWatcherId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecForProviderNetworkWatcherIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionMonitorSpecForProviderNetworkWatcherIdRefPolicy? Policy { get; set; }
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecForProviderNetworkWatcherIdSelectorPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>Selector for a Watcher in network to populate networkWatcherId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecForProviderNetworkWatcherIdSelector
{
    /// <summary>MatchControllerRef ensures an object with the same controller reference as the selecting object is selected.</summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionMonitorSpecForProviderNetworkWatcherIdSelectorPolicy? Policy { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecForProviderTestConfigurationHttpConfigurationRequestHeader
{
    /// <summary>The name of the test group for the Network Connection Monitor.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecForProviderTestConfigurationHttpConfiguration
{
    /// <summary>The HTTP method for the HTTP request. Possible values are Get and Post. Defaults to Get.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>The path component of the URI. It only accepts the absolute path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The port for the TCP connection.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Should HTTPS be preferred over HTTP in cases where the choice is not explicit? Defaults to false.</summary>
    [JsonPropertyName("preferHttps")]
    public bool? PreferHttps { get; set; }

    /// <summary>A request_header block as defined below.</summary>
    [JsonPropertyName("requestHeader")]
    public IList<V1beta1ConnectionMonitorSpecForProviderTestConfigurationHttpConfigurationRequestHeader>? RequestHeader { get; set; }

    /// <summary>The HTTP status codes to consider successful. For instance, 2xx, 301-304 and 418.</summary>
    [JsonPropertyName("validStatusCodeRanges")]
    public IList<string>? ValidStatusCodeRanges { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecForProviderTestConfigurationIcmpConfiguration
{
    /// <summary>Should path evaluation with trace route be enabled? Defaults to true.</summary>
    [JsonPropertyName("traceRouteEnabled")]
    public bool? TraceRouteEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecForProviderTestConfigurationSuccessThreshold
{
    /// <summary>The maximum percentage of failed checks permitted for a test to be successful.</summary>
    [JsonPropertyName("checksFailedPercent")]
    public double? ChecksFailedPercent { get; set; }

    /// <summary>The maximum round-trip time in milliseconds permitted for a test to be successful.</summary>
    [JsonPropertyName("roundTripTimeMs")]
    public double? RoundTripTimeMs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecForProviderTestConfigurationTcpConfiguration
{
    /// <summary>The destination port behavior for the TCP connection. Possible values are None and ListenIfAvailable.</summary>
    [JsonPropertyName("destinationPortBehavior")]
    public string? DestinationPortBehavior { get; set; }

    /// <summary>The port for the TCP connection.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Should path evaluation with trace route be enabled? Defaults to true.</summary>
    [JsonPropertyName("traceRouteEnabled")]
    public bool? TraceRouteEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecForProviderTestConfiguration
{
    /// <summary>A http_configuration block as defined below.</summary>
    [JsonPropertyName("httpConfiguration")]
    public IList<V1beta1ConnectionMonitorSpecForProviderTestConfigurationHttpConfiguration>? HttpConfiguration { get; set; }

    /// <summary>A icmp_configuration block as defined below.</summary>
    [JsonPropertyName("icmpConfiguration")]
    public IList<V1beta1ConnectionMonitorSpecForProviderTestConfigurationIcmpConfiguration>? IcmpConfiguration { get; set; }

    /// <summary>The name of test configuration for the Network Connection Monitor.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The preferred IP version which is used in the test evaluation. Possible values are IPv4 and IPv6.</summary>
    [JsonPropertyName("preferredIpVersion")]
    public string? PreferredIpVersion { get; set; }

    /// <summary>The protocol used to evaluate tests. Possible values are Tcp, Http and Icmp.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>A success_threshold block as defined below.</summary>
    [JsonPropertyName("successThreshold")]
    public IList<V1beta1ConnectionMonitorSpecForProviderTestConfigurationSuccessThreshold>? SuccessThreshold { get; set; }

    /// <summary>A tcp_configuration block as defined below.</summary>
    [JsonPropertyName("tcpConfiguration")]
    public IList<V1beta1ConnectionMonitorSpecForProviderTestConfigurationTcpConfiguration>? TcpConfiguration { get; set; }

    /// <summary>The time interval in seconds at which the test evaluation will happen. Defaults to 60.</summary>
    [JsonPropertyName("testFrequencyInSeconds")]
    public double? TestFrequencyInSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecForProviderTestGroup
{
    /// <summary>A list of destination endpoint names.</summary>
    [JsonPropertyName("destinationEndpoints")]
    public IList<string>? DestinationEndpoints { get; set; }

    /// <summary>Should the test group be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the test group for the Network Connection Monitor.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of source endpoint names.</summary>
    [JsonPropertyName("sourceEndpoints")]
    public IList<string>? SourceEndpoints { get; set; }

    /// <summary>A list of test configuration names.</summary>
    [JsonPropertyName("testConfigurationNames")]
    public IList<string>? TestConfigurationNames { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecForProvider
{
    /// <summary>A endpoint block as defined below.</summary>
    [JsonPropertyName("endpoint")]
    public IList<V1beta1ConnectionMonitorSpecForProviderEndpoint>? Endpoint { get; set; }

    /// <summary>The Azure Region where the Network Connection Monitor should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The ID of the Network Watcher. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("networkWatcherId")]
    public string? NetworkWatcherId { get; set; }

    /// <summary>Reference to a Watcher in network to populate networkWatcherId.</summary>
    [JsonPropertyName("networkWatcherIdRef")]
    public V1beta1ConnectionMonitorSpecForProviderNetworkWatcherIdRef? NetworkWatcherIdRef { get; set; }

    /// <summary>Selector for a Watcher in network to populate networkWatcherId.</summary>
    [JsonPropertyName("networkWatcherIdSelector")]
    public V1beta1ConnectionMonitorSpecForProviderNetworkWatcherIdSelector? NetworkWatcherIdSelector { get; set; }

    /// <summary>The description of the Network Connection Monitor.</summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>A list of IDs of the Log Analytics Workspace which will accept the output from the Network Connection Monitor.</summary>
    [JsonPropertyName("outputWorkspaceResourceIds")]
    public IList<string>? OutputWorkspaceResourceIds { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Network Connection Monitor.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A test_configuration block as defined below.</summary>
    [JsonPropertyName("testConfiguration")]
    public IList<V1beta1ConnectionMonitorSpecForProviderTestConfiguration>? TestConfiguration { get; set; }

    /// <summary>A test_group block as defined below.</summary>
    [JsonPropertyName("testGroup")]
    public IList<V1beta1ConnectionMonitorSpecForProviderTestGroup>? TestGroup { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecInitProviderEndpointFilterItem
{
    /// <summary>The address of the filter item.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The type of items included in the filter. Possible values are AgentAddress. Defaults to AgentAddress.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecInitProviderEndpointFilter
{
    /// <summary>A item block as defined below.</summary>
    [JsonPropertyName("item")]
    public IList<V1beta1ConnectionMonitorSpecInitProviderEndpointFilterItem>? Item { get; set; }

    /// <summary>The type of items included in the filter. Possible values are AgentAddress. Defaults to AgentAddress.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecInitProviderEndpoint
{
    /// <summary>The IP address or domain name of the Network Connection Monitor endpoint.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The test coverage for the Network Connection Monitor endpoint. Possible values are AboveAverage, Average, BelowAverage, Default, Full and Low.</summary>
    [JsonPropertyName("coverageLevel")]
    public string? CoverageLevel { get; set; }

    /// <summary>A list of IPv4/IPv6 subnet masks or IPv4/IPv6 IP addresses to be excluded to the Network Connection Monitor endpoint.</summary>
    [JsonPropertyName("excludedIpAddresses")]
    public IList<string>? ExcludedIpAddresses { get; set; }

    /// <summary>A filter block as defined below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1ConnectionMonitorSpecInitProviderEndpointFilter>? Filter { get; set; }

    /// <summary>A list of IPv4/IPv6 subnet masks or IPv4/IPv6 IP addresses to be included to the Network Connection Monitor endpoint.</summary>
    [JsonPropertyName("includedIpAddresses")]
    public IList<string>? IncludedIpAddresses { get; set; }

    /// <summary>The name of the endpoint for the Network Connection Monitor .</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The resource ID which is used as the endpoint by the Network Connection Monitor.</summary>
    [JsonPropertyName("targetResourceId")]
    public string? TargetResourceId { get; set; }

    /// <summary>The endpoint type of the Network Connection Monitor. Possible values are AzureSubnet, AzureVM, AzureVNet, ExternalAddress, MMAWorkspaceMachine and MMAWorkspaceNetwork.</summary>
    [JsonPropertyName("targetResourceType")]
    public string? TargetResourceType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecInitProviderTestConfigurationHttpConfigurationRequestHeader
{
    /// <summary>The name of the test group for the Network Connection Monitor.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecInitProviderTestConfigurationHttpConfiguration
{
    /// <summary>The HTTP method for the HTTP request. Possible values are Get and Post. Defaults to Get.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>The path component of the URI. It only accepts the absolute path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The port for the TCP connection.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Should HTTPS be preferred over HTTP in cases where the choice is not explicit? Defaults to false.</summary>
    [JsonPropertyName("preferHttps")]
    public bool? PreferHttps { get; set; }

    /// <summary>A request_header block as defined below.</summary>
    [JsonPropertyName("requestHeader")]
    public IList<V1beta1ConnectionMonitorSpecInitProviderTestConfigurationHttpConfigurationRequestHeader>? RequestHeader { get; set; }

    /// <summary>The HTTP status codes to consider successful. For instance, 2xx, 301-304 and 418.</summary>
    [JsonPropertyName("validStatusCodeRanges")]
    public IList<string>? ValidStatusCodeRanges { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecInitProviderTestConfigurationIcmpConfiguration
{
    /// <summary>Should path evaluation with trace route be enabled? Defaults to true.</summary>
    [JsonPropertyName("traceRouteEnabled")]
    public bool? TraceRouteEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecInitProviderTestConfigurationSuccessThreshold
{
    /// <summary>The maximum percentage of failed checks permitted for a test to be successful.</summary>
    [JsonPropertyName("checksFailedPercent")]
    public double? ChecksFailedPercent { get; set; }

    /// <summary>The maximum round-trip time in milliseconds permitted for a test to be successful.</summary>
    [JsonPropertyName("roundTripTimeMs")]
    public double? RoundTripTimeMs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecInitProviderTestConfigurationTcpConfiguration
{
    /// <summary>The destination port behavior for the TCP connection. Possible values are None and ListenIfAvailable.</summary>
    [JsonPropertyName("destinationPortBehavior")]
    public string? DestinationPortBehavior { get; set; }

    /// <summary>The port for the TCP connection.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Should path evaluation with trace route be enabled? Defaults to true.</summary>
    [JsonPropertyName("traceRouteEnabled")]
    public bool? TraceRouteEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecInitProviderTestConfiguration
{
    /// <summary>A http_configuration block as defined below.</summary>
    [JsonPropertyName("httpConfiguration")]
    public IList<V1beta1ConnectionMonitorSpecInitProviderTestConfigurationHttpConfiguration>? HttpConfiguration { get; set; }

    /// <summary>A icmp_configuration block as defined below.</summary>
    [JsonPropertyName("icmpConfiguration")]
    public IList<V1beta1ConnectionMonitorSpecInitProviderTestConfigurationIcmpConfiguration>? IcmpConfiguration { get; set; }

    /// <summary>The name of test configuration for the Network Connection Monitor.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The preferred IP version which is used in the test evaluation. Possible values are IPv4 and IPv6.</summary>
    [JsonPropertyName("preferredIpVersion")]
    public string? PreferredIpVersion { get; set; }

    /// <summary>The protocol used to evaluate tests. Possible values are Tcp, Http and Icmp.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>A success_threshold block as defined below.</summary>
    [JsonPropertyName("successThreshold")]
    public IList<V1beta1ConnectionMonitorSpecInitProviderTestConfigurationSuccessThreshold>? SuccessThreshold { get; set; }

    /// <summary>A tcp_configuration block as defined below.</summary>
    [JsonPropertyName("tcpConfiguration")]
    public IList<V1beta1ConnectionMonitorSpecInitProviderTestConfigurationTcpConfiguration>? TcpConfiguration { get; set; }

    /// <summary>The time interval in seconds at which the test evaluation will happen. Defaults to 60.</summary>
    [JsonPropertyName("testFrequencyInSeconds")]
    public double? TestFrequencyInSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecInitProviderTestGroup
{
    /// <summary>A list of destination endpoint names.</summary>
    [JsonPropertyName("destinationEndpoints")]
    public IList<string>? DestinationEndpoints { get; set; }

    /// <summary>Should the test group be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the test group for the Network Connection Monitor.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of source endpoint names.</summary>
    [JsonPropertyName("sourceEndpoints")]
    public IList<string>? SourceEndpoints { get; set; }

    /// <summary>A list of test configuration names.</summary>
    [JsonPropertyName("testConfigurationNames")]
    public IList<string>? TestConfigurationNames { get; set; }
}

/// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecInitProvider
{
    /// <summary>A endpoint block as defined below.</summary>
    [JsonPropertyName("endpoint")]
    public IList<V1beta1ConnectionMonitorSpecInitProviderEndpoint>? Endpoint { get; set; }

    /// <summary>The Azure Region where the Network Connection Monitor should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The description of the Network Connection Monitor.</summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>A list of IDs of the Log Analytics Workspace which will accept the output from the Network Connection Monitor.</summary>
    [JsonPropertyName("outputWorkspaceResourceIds")]
    public IList<string>? OutputWorkspaceResourceIds { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Network Connection Monitor.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A test_configuration block as defined below.</summary>
    [JsonPropertyName("testConfiguration")]
    public IList<V1beta1ConnectionMonitorSpecInitProviderTestConfiguration>? TestConfiguration { get; set; }

    /// <summary>A test_group block as defined below.</summary>
    [JsonPropertyName("testGroup")]
    public IList<V1beta1ConnectionMonitorSpecInitProviderTestGroup>? TestGroup { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecProviderConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionMonitorSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecPublishConnectionDetailsToConfigRefPolicy
{
    /// <summary>Resolution specifies whether resolution of this reference is required. The default is 'Required', which means the reconcile will fail if the reference cannot be resolved. 'Optional' means this reference will be a no-op if it cannot be resolved.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }

    /// <summary>Resolve specifies when this reference should be resolved. The default is 'IfNotPresent', which will attempt to resolve the reference only when the corresponding field is not present. Use 'Always' to resolve the reference on every reconcile.</summary>
    [JsonPropertyName("resolve")]
    public string? Resolve { get; set; }
}

/// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecPublishConnectionDetailsToConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ConnectionMonitorSpecPublishConnectionDetailsToConfigRefPolicy? Policy { get; set; }
}

/// <summary>Metadata is the metadata for connection secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecPublishConnectionDetailsToMetadata
{
    /// <summary>Annotations are the annotations to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.annotations". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels are the labels/tags to be added to connection secret. - For Kubernetes secrets, this will be used as "metadata.labels". - It is up to Secret Store implementation for others store types.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Type is the SecretType for the connection secret. - Only valid for Kubernetes Secret Stores.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecPublishConnectionDetailsTo
{
    /// <summary>SecretStoreConfigRef specifies which secret store config should be used for this ConnectionSecret.</summary>
    [JsonPropertyName("configRef")]
    public V1beta1ConnectionMonitorSpecPublishConnectionDetailsToConfigRef? ConfigRef { get; set; }

    /// <summary>Metadata is the metadata for connection secret.</summary>
    [JsonPropertyName("metadata")]
    public V1beta1ConnectionMonitorSpecPublishConnectionDetailsToMetadata? Metadata { get; set; }

    /// <summary>Name is the name of the connection secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}

/// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}

/// <summary>ConnectionMonitorSpec defines the desired state of ConnectionMonitor</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorSpec
{
    /// <summary>DeletionPolicy specifies what will happen to the underlying external when this managed resource is deleted - either "Delete" or "Orphan" the external resource. This field is planned to be deprecated in favor of the ManagementPolicies field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223</summary>
    [JsonPropertyName("deletionPolicy")]
    public string? DeletionPolicy { get; set; }

    /// <summary></summary>
    [JsonPropertyName("forProvider")]
    public V1beta1ConnectionMonitorSpecForProvider ForProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It will be honored unless the Management Policies feature flag is disabled. InitProvider holds the same fields as ForProvider, with the exception of Identifier and other resource reference fields. The fields that are in InitProvider are merged into ForProvider when the resource is created. The same fields are also added to the terraform ignore_changes hook, to avoid updating them after creation. This is useful for fields that are required on creation, but we do not desire to update them after creation, for example because of an external controller is managing them, like an autoscaler.</summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ConnectionMonitorSpecInitProvider? InitProvider { get; set; }

    /// <summary>THIS IS A BETA FIELD. It is on by default but can be opted out through a Crossplane feature flag. ManagementPolicies specify the array of actions Crossplane is allowed to take on the managed and external resources. This field is planned to replace the DeletionPolicy field in a future release. Currently, both could be set independently and non-default values would be honored if the feature flag is enabled. If both are custom, the DeletionPolicy field will be ignored. See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223 and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md</summary>
    [JsonPropertyName("managementPolicies")]
    public IList<string>? ManagementPolicies { get; set; }

    /// <summary>ProviderConfigReference specifies how the provider that will be used to create, observe, update, and delete this managed resource should be configured.</summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ConnectionMonitorSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>PublishConnectionDetailsTo specifies the connection secret config which contains a name, metadata and a reference to secret store config to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource.</summary>
    [JsonPropertyName("publishConnectionDetailsTo")]
    public V1beta1ConnectionMonitorSpecPublishConnectionDetailsTo? PublishConnectionDetailsTo { get; set; }

    /// <summary>WriteConnectionSecretToReference specifies the namespace and name of a Secret to which any connection details for this managed resource should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource. This field is planned to be replaced in a future release in favor of PublishConnectionDetailsTo. Currently, both could be set independently and connection details would be published to both without affecting each other.</summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ConnectionMonitorSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorStatusAtProviderEndpointFilterItem
{
    /// <summary>The address of the filter item.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The type of items included in the filter. Possible values are AgentAddress. Defaults to AgentAddress.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorStatusAtProviderEndpointFilter
{
    /// <summary>A item block as defined below.</summary>
    [JsonPropertyName("item")]
    public IList<V1beta1ConnectionMonitorStatusAtProviderEndpointFilterItem>? Item { get; set; }

    /// <summary>The type of items included in the filter. Possible values are AgentAddress. Defaults to AgentAddress.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorStatusAtProviderEndpoint
{
    /// <summary>The IP address or domain name of the Network Connection Monitor endpoint.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>The test coverage for the Network Connection Monitor endpoint. Possible values are AboveAverage, Average, BelowAverage, Default, Full and Low.</summary>
    [JsonPropertyName("coverageLevel")]
    public string? CoverageLevel { get; set; }

    /// <summary>A list of IPv4/IPv6 subnet masks or IPv4/IPv6 IP addresses to be excluded to the Network Connection Monitor endpoint.</summary>
    [JsonPropertyName("excludedIpAddresses")]
    public IList<string>? ExcludedIpAddresses { get; set; }

    /// <summary>A filter block as defined below.</summary>
    [JsonPropertyName("filter")]
    public IList<V1beta1ConnectionMonitorStatusAtProviderEndpointFilter>? Filter { get; set; }

    /// <summary>A list of IPv4/IPv6 subnet masks or IPv4/IPv6 IP addresses to be included to the Network Connection Monitor endpoint.</summary>
    [JsonPropertyName("includedIpAddresses")]
    public IList<string>? IncludedIpAddresses { get; set; }

    /// <summary>The name of the endpoint for the Network Connection Monitor .</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The resource ID which is used as the endpoint by the Network Connection Monitor.</summary>
    [JsonPropertyName("targetResourceId")]
    public string? TargetResourceId { get; set; }

    /// <summary>The endpoint type of the Network Connection Monitor. Possible values are AzureSubnet, AzureVM, AzureVNet, ExternalAddress, MMAWorkspaceMachine and MMAWorkspaceNetwork.</summary>
    [JsonPropertyName("targetResourceType")]
    public string? TargetResourceType { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorStatusAtProviderTestConfigurationHttpConfigurationRequestHeader
{
    /// <summary>The name of the test group for the Network Connection Monitor.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the HTTP header.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorStatusAtProviderTestConfigurationHttpConfiguration
{
    /// <summary>The HTTP method for the HTTP request. Possible values are Get and Post. Defaults to Get.</summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>The path component of the URI. It only accepts the absolute path.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The port for the TCP connection.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Should HTTPS be preferred over HTTP in cases where the choice is not explicit? Defaults to false.</summary>
    [JsonPropertyName("preferHttps")]
    public bool? PreferHttps { get; set; }

    /// <summary>A request_header block as defined below.</summary>
    [JsonPropertyName("requestHeader")]
    public IList<V1beta1ConnectionMonitorStatusAtProviderTestConfigurationHttpConfigurationRequestHeader>? RequestHeader { get; set; }

    /// <summary>The HTTP status codes to consider successful. For instance, 2xx, 301-304 and 418.</summary>
    [JsonPropertyName("validStatusCodeRanges")]
    public IList<string>? ValidStatusCodeRanges { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorStatusAtProviderTestConfigurationIcmpConfiguration
{
    /// <summary>Should path evaluation with trace route be enabled? Defaults to true.</summary>
    [JsonPropertyName("traceRouteEnabled")]
    public bool? TraceRouteEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorStatusAtProviderTestConfigurationSuccessThreshold
{
    /// <summary>The maximum percentage of failed checks permitted for a test to be successful.</summary>
    [JsonPropertyName("checksFailedPercent")]
    public double? ChecksFailedPercent { get; set; }

    /// <summary>The maximum round-trip time in milliseconds permitted for a test to be successful.</summary>
    [JsonPropertyName("roundTripTimeMs")]
    public double? RoundTripTimeMs { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorStatusAtProviderTestConfigurationTcpConfiguration
{
    /// <summary>The destination port behavior for the TCP connection. Possible values are None and ListenIfAvailable.</summary>
    [JsonPropertyName("destinationPortBehavior")]
    public string? DestinationPortBehavior { get; set; }

    /// <summary>The port for the TCP connection.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Should path evaluation with trace route be enabled? Defaults to true.</summary>
    [JsonPropertyName("traceRouteEnabled")]
    public bool? TraceRouteEnabled { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorStatusAtProviderTestConfiguration
{
    /// <summary>A http_configuration block as defined below.</summary>
    [JsonPropertyName("httpConfiguration")]
    public IList<V1beta1ConnectionMonitorStatusAtProviderTestConfigurationHttpConfiguration>? HttpConfiguration { get; set; }

    /// <summary>A icmp_configuration block as defined below.</summary>
    [JsonPropertyName("icmpConfiguration")]
    public IList<V1beta1ConnectionMonitorStatusAtProviderTestConfigurationIcmpConfiguration>? IcmpConfiguration { get; set; }

    /// <summary>The name of test configuration for the Network Connection Monitor.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The preferred IP version which is used in the test evaluation. Possible values are IPv4 and IPv6.</summary>
    [JsonPropertyName("preferredIpVersion")]
    public string? PreferredIpVersion { get; set; }

    /// <summary>The protocol used to evaluate tests. Possible values are Tcp, Http and Icmp.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>A success_threshold block as defined below.</summary>
    [JsonPropertyName("successThreshold")]
    public IList<V1beta1ConnectionMonitorStatusAtProviderTestConfigurationSuccessThreshold>? SuccessThreshold { get; set; }

    /// <summary>A tcp_configuration block as defined below.</summary>
    [JsonPropertyName("tcpConfiguration")]
    public IList<V1beta1ConnectionMonitorStatusAtProviderTestConfigurationTcpConfiguration>? TcpConfiguration { get; set; }

    /// <summary>The time interval in seconds at which the test evaluation will happen. Defaults to 60.</summary>
    [JsonPropertyName("testFrequencyInSeconds")]
    public double? TestFrequencyInSeconds { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorStatusAtProviderTestGroup
{
    /// <summary>A list of destination endpoint names.</summary>
    [JsonPropertyName("destinationEndpoints")]
    public IList<string>? DestinationEndpoints { get; set; }

    /// <summary>Should the test group be enabled? Defaults to true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The name of the test group for the Network Connection Monitor.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A list of source endpoint names.</summary>
    [JsonPropertyName("sourceEndpoints")]
    public IList<string>? SourceEndpoints { get; set; }

    /// <summary>A list of test configuration names.</summary>
    [JsonPropertyName("testConfigurationNames")]
    public IList<string>? TestConfigurationNames { get; set; }
}

/// <summary></summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorStatusAtProvider
{
    /// <summary>A endpoint block as defined below.</summary>
    [JsonPropertyName("endpoint")]
    public IList<V1beta1ConnectionMonitorStatusAtProviderEndpoint>? Endpoint { get; set; }

    /// <summary>The ID of the Network Connection Monitor.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The Azure Region where the Network Connection Monitor should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The ID of the Network Watcher. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("networkWatcherId")]
    public string? NetworkWatcherId { get; set; }

    /// <summary>The description of the Network Connection Monitor.</summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>A list of IDs of the Log Analytics Workspace which will accept the output from the Network Connection Monitor.</summary>
    [JsonPropertyName("outputWorkspaceResourceIds")]
    public IList<string>? OutputWorkspaceResourceIds { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Network Connection Monitor.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A test_configuration block as defined below.</summary>
    [JsonPropertyName("testConfiguration")]
    public IList<V1beta1ConnectionMonitorStatusAtProviderTestConfiguration>? TestConfiguration { get; set; }

    /// <summary>A test_group block as defined below.</summary>
    [JsonPropertyName("testGroup")]
    public IList<V1beta1ConnectionMonitorStatusAtProviderTestGroup>? TestGroup { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorStatusConditions
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

/// <summary>ConnectionMonitorStatus defines the observed state of ConnectionMonitor.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ConnectionMonitorStatus
{
    /// <summary></summary>
    [JsonPropertyName("atProvider")]
    public V1beta1ConnectionMonitorStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ConnectionMonitorStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the latest metadata.generation which resulted in either a ready state, or stalled due to error it can not recover from without human intervention.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ConnectionMonitor is the Schema for the ConnectionMonitors API. Manages a Network Connection Monitor.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen.Tool", "1.0.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ConnectionMonitor : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ConnectionMonitorSpec>, IStatus<V1beta1ConnectionMonitorStatus>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ConnectionMonitor";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "connectionmonitors";
    /// <summary></summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary></summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary></summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ConnectionMonitorSpec defines the desired state of ConnectionMonitor</summary>
    [JsonPropertyName("spec")]
    public V1beta1ConnectionMonitorSpec Spec { get; set; }

    /// <summary>ConnectionMonitorStatus defines the observed state of ConnectionMonitor.</summary>
    [JsonPropertyName("status")]
    public V1beta1ConnectionMonitorStatus? Status { get; set; }
}